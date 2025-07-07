// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AccountCenter20241209.Models;

namespace AlibabaCloud.SDK.AccountCenter20241209
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("accountcenter", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>修改登录密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeLoginPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeLoginPasswordResponse
        /// </returns>
        public EnterpriseAccountChangeLoginPasswordResponse EnterpriseAccountChangeLoginPasswordWithOptions(EnterpriseAccountChangeLoginPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPassword))
            {
                query["EncryptPassword"] = request.EncryptPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountChangeLoginPassword",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountChangeLoginPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改登录密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeLoginPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeLoginPasswordResponse
        /// </returns>
        public async Task<EnterpriseAccountChangeLoginPasswordResponse> EnterpriseAccountChangeLoginPasswordWithOptionsAsync(EnterpriseAccountChangeLoginPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPassword))
            {
                query["EncryptPassword"] = request.EncryptPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountChangeLoginPassword",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountChangeLoginPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改登录密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeLoginPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeLoginPasswordResponse
        /// </returns>
        public EnterpriseAccountChangeLoginPasswordResponse EnterpriseAccountChangeLoginPassword(EnterpriseAccountChangeLoginPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountChangeLoginPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改登录密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeLoginPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeLoginPasswordResponse
        /// </returns>
        public async Task<EnterpriseAccountChangeLoginPasswordResponse> EnterpriseAccountChangeLoginPasswordAsync(EnterpriseAccountChangeLoginPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountChangeLoginPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改安全邮箱</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeSecurityEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeSecurityEmailResponse
        /// </returns>
        public EnterpriseAccountChangeSecurityEmailResponse EnterpriseAccountChangeSecurityEmailWithOptions(EnterpriseAccountChangeSecurityEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEmail))
            {
                query["SecurityEmail"] = request.SecurityEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountChangeSecurityEmail",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountChangeSecurityEmailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改安全邮箱</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeSecurityEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeSecurityEmailResponse
        /// </returns>
        public async Task<EnterpriseAccountChangeSecurityEmailResponse> EnterpriseAccountChangeSecurityEmailWithOptionsAsync(EnterpriseAccountChangeSecurityEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEmail))
            {
                query["SecurityEmail"] = request.SecurityEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountChangeSecurityEmail",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountChangeSecurityEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改安全邮箱</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeSecurityEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeSecurityEmailResponse
        /// </returns>
        public EnterpriseAccountChangeSecurityEmailResponse EnterpriseAccountChangeSecurityEmail(EnterpriseAccountChangeSecurityEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountChangeSecurityEmailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改安全邮箱</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeSecurityEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeSecurityEmailResponse
        /// </returns>
        public async Task<EnterpriseAccountChangeSecurityEmailResponse> EnterpriseAccountChangeSecurityEmailAsync(EnterpriseAccountChangeSecurityEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountChangeSecurityEmailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改成员账号安全手机号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeSecurityMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeSecurityMobileResponse
        /// </returns>
        public EnterpriseAccountChangeSecurityMobileResponse EnterpriseAccountChangeSecurityMobileWithOptions(EnterpriseAccountChangeSecurityMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMobile))
            {
                query["NewMobile"] = request.NewMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                query["VerificationCode"] = request.VerificationCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountChangeSecurityMobile",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountChangeSecurityMobileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改成员账号安全手机号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeSecurityMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeSecurityMobileResponse
        /// </returns>
        public async Task<EnterpriseAccountChangeSecurityMobileResponse> EnterpriseAccountChangeSecurityMobileWithOptionsAsync(EnterpriseAccountChangeSecurityMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMobile))
            {
                query["NewMobile"] = request.NewMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                query["VerificationCode"] = request.VerificationCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountChangeSecurityMobile",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountChangeSecurityMobileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改成员账号安全手机号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeSecurityMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeSecurityMobileResponse
        /// </returns>
        public EnterpriseAccountChangeSecurityMobileResponse EnterpriseAccountChangeSecurityMobile(EnterpriseAccountChangeSecurityMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountChangeSecurityMobileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改成员账号安全手机号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountChangeSecurityMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountChangeSecurityMobileResponse
        /// </returns>
        public async Task<EnterpriseAccountChangeSecurityMobileResponse> EnterpriseAccountChangeSecurityMobileAsync(EnterpriseAccountChangeSecurityMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountChangeSecurityMobileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询纳管账号授权角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryAccountGrantedRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryAccountGrantedRolesResponse
        /// </returns>
        public EnterpriseAccountQueryAccountGrantedRolesResponse EnterpriseAccountQueryAccountGrantedRolesWithOptions(EnterpriseAccountQueryAccountGrantedRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpenApi))
            {
                body["IsOpenApi"] = request.IsOpenApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                body["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountQueryAccountGrantedRoles",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountQueryAccountGrantedRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询纳管账号授权角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryAccountGrantedRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryAccountGrantedRolesResponse
        /// </returns>
        public async Task<EnterpriseAccountQueryAccountGrantedRolesResponse> EnterpriseAccountQueryAccountGrantedRolesWithOptionsAsync(EnterpriseAccountQueryAccountGrantedRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpenApi))
            {
                body["IsOpenApi"] = request.IsOpenApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                body["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountQueryAccountGrantedRoles",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountQueryAccountGrantedRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询纳管账号授权角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryAccountGrantedRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryAccountGrantedRolesResponse
        /// </returns>
        public EnterpriseAccountQueryAccountGrantedRolesResponse EnterpriseAccountQueryAccountGrantedRoles(EnterpriseAccountQueryAccountGrantedRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountQueryAccountGrantedRolesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询纳管账号授权角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryAccountGrantedRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryAccountGrantedRolesResponse
        /// </returns>
        public async Task<EnterpriseAccountQueryAccountGrantedRolesResponse> EnterpriseAccountQueryAccountGrantedRolesAsync(EnterpriseAccountQueryAccountGrantedRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountQueryAccountGrantedRolesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询纳管账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryAccountsInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryAccountsInfoResponse
        /// </returns>
        public EnterpriseAccountQueryAccountsInfoResponse EnterpriseAccountQueryAccountsInfoWithOptions(EnterpriseAccountQueryAccountsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PksJson))
            {
                query["PksJson"] = request.PksJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountQueryAccountsInfo",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountQueryAccountsInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询纳管账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryAccountsInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryAccountsInfoResponse
        /// </returns>
        public async Task<EnterpriseAccountQueryAccountsInfoResponse> EnterpriseAccountQueryAccountsInfoWithOptionsAsync(EnterpriseAccountQueryAccountsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PksJson))
            {
                query["PksJson"] = request.PksJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountQueryAccountsInfo",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountQueryAccountsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询纳管账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryAccountsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryAccountsInfoResponse
        /// </returns>
        public EnterpriseAccountQueryAccountsInfoResponse EnterpriseAccountQueryAccountsInfo(EnterpriseAccountQueryAccountsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountQueryAccountsInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询纳管账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryAccountsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryAccountsInfoResponse
        /// </returns>
        public async Task<EnterpriseAccountQueryAccountsInfoResponse> EnterpriseAccountQueryAccountsInfoAsync(EnterpriseAccountQueryAccountsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountQueryAccountsInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询纳管账号登录设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryLoginSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryLoginSettingsResponse
        /// </returns>
        public EnterpriseAccountQueryLoginSettingsResponse EnterpriseAccountQueryLoginSettingsWithOptions(EnterpriseAccountQueryLoginSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpenApi))
            {
                body["IsOpenApi"] = request.IsOpenApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                body["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountQueryLoginSettings",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountQueryLoginSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询纳管账号登录设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryLoginSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryLoginSettingsResponse
        /// </returns>
        public async Task<EnterpriseAccountQueryLoginSettingsResponse> EnterpriseAccountQueryLoginSettingsWithOptionsAsync(EnterpriseAccountQueryLoginSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpenApi))
            {
                body["IsOpenApi"] = request.IsOpenApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                body["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountQueryLoginSettings",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountQueryLoginSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询纳管账号登录设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryLoginSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryLoginSettingsResponse
        /// </returns>
        public EnterpriseAccountQueryLoginSettingsResponse EnterpriseAccountQueryLoginSettings(EnterpriseAccountQueryLoginSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountQueryLoginSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询纳管账号登录设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountQueryLoginSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountQueryLoginSettingsResponse
        /// </returns>
        public async Task<EnterpriseAccountQueryLoginSettingsResponse> EnterpriseAccountQueryLoginSettingsAsync(EnterpriseAccountQueryLoginSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountQueryLoginSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除mfa</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountRemoveMfaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountRemoveMfaResponse
        /// </returns>
        public EnterpriseAccountRemoveMfaResponse EnterpriseAccountRemoveMfaWithOptions(EnterpriseAccountRemoveMfaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountRemoveMfa",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountRemoveMfaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除mfa</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountRemoveMfaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountRemoveMfaResponse
        /// </returns>
        public async Task<EnterpriseAccountRemoveMfaResponse> EnterpriseAccountRemoveMfaWithOptionsAsync(EnterpriseAccountRemoveMfaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountRemoveMfa",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountRemoveMfaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除mfa</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountRemoveMfaRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountRemoveMfaResponse
        /// </returns>
        public EnterpriseAccountRemoveMfaResponse EnterpriseAccountRemoveMfa(EnterpriseAccountRemoveMfaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountRemoveMfaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除mfa</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountRemoveMfaRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountRemoveMfaResponse
        /// </returns>
        public async Task<EnterpriseAccountRemoveMfaResponse> EnterpriseAccountRemoveMfaAsync(EnterpriseAccountRemoveMfaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountRemoveMfaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>脱离ea</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountSeparateEaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountSeparateEaResponse
        /// </returns>
        public EnterpriseAccountSeparateEaResponse EnterpriseAccountSeparateEaWithOptions(EnterpriseAccountSeparateEaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountSeparateEa",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountSeparateEaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>脱离ea</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountSeparateEaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountSeparateEaResponse
        /// </returns>
        public async Task<EnterpriseAccountSeparateEaResponse> EnterpriseAccountSeparateEaWithOptionsAsync(EnterpriseAccountSeparateEaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountSeparateEa",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountSeparateEaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>脱离ea</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountSeparateEaRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountSeparateEaResponse
        /// </returns>
        public EnterpriseAccountSeparateEaResponse EnterpriseAccountSeparateEa(EnterpriseAccountSeparateEaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountSeparateEaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>脱离ea</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountSeparateEaRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountSeparateEaResponse
        /// </returns>
        public async Task<EnterpriseAccountSeparateEaResponse> EnterpriseAccountSeparateEaAsync(EnterpriseAccountSeparateEaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountSeparateEaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账号企业多账号中的别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateAccountAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateAccountAliasResponse
        /// </returns>
        public EnterpriseAccountUpdateAccountAliasResponse EnterpriseAccountUpdateAccountAliasWithOptions(EnterpriseAccountUpdateAccountAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateAccountAlias",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateAccountAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账号企业多账号中的别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateAccountAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateAccountAliasResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateAccountAliasResponse> EnterpriseAccountUpdateAccountAliasWithOptionsAsync(EnterpriseAccountUpdateAccountAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateAccountAlias",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateAccountAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账号企业多账号中的别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateAccountAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateAccountAliasResponse
        /// </returns>
        public EnterpriseAccountUpdateAccountAliasResponse EnterpriseAccountUpdateAccountAlias(EnterpriseAccountUpdateAccountAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountUpdateAccountAliasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账号企业多账号中的别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateAccountAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateAccountAliasResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateAccountAliasResponse> EnterpriseAccountUpdateAccountAliasAsync(EnterpriseAccountUpdateAccountAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountUpdateAccountAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateAccountBizRoleGrantRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateAccountBizRoleGrantResponse
        /// </returns>
        public EnterpriseAccountUpdateAccountBizRoleGrantResponse EnterpriseAccountUpdateAccountBizRoleGrantWithOptions(EnterpriseAccountUpdateAccountBizRoleGrantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCodeListJson))
            {
                query["BizRoleCodeListJson"] = request.BizRoleCodeListJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateAccountBizRoleGrant",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateAccountBizRoleGrantResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateAccountBizRoleGrantRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateAccountBizRoleGrantResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateAccountBizRoleGrantResponse> EnterpriseAccountUpdateAccountBizRoleGrantWithOptionsAsync(EnterpriseAccountUpdateAccountBizRoleGrantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCodeListJson))
            {
                query["BizRoleCodeListJson"] = request.BizRoleCodeListJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateAccountBizRoleGrant",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateAccountBizRoleGrantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateAccountBizRoleGrantRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateAccountBizRoleGrantResponse
        /// </returns>
        public EnterpriseAccountUpdateAccountBizRoleGrantResponse EnterpriseAccountUpdateAccountBizRoleGrant(EnterpriseAccountUpdateAccountBizRoleGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountUpdateAccountBizRoleGrantWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateAccountBizRoleGrantRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateAccountBizRoleGrantResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateAccountBizRoleGrantResponse> EnterpriseAccountUpdateAccountBizRoleGrantAsync(EnterpriseAccountUpdateAccountBizRoleGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountUpdateAccountBizRoleGrantWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Ip掩码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateIpMaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateIpMaskResponse
        /// </returns>
        public EnterpriseAccountUpdateIpMaskResponse EnterpriseAccountUpdateIpMaskWithOptions(EnterpriseAccountUpdateIpMaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpMasksJson))
            {
                query["IpMasksJson"] = request.IpMasksJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateIpMask",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateIpMaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Ip掩码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateIpMaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateIpMaskResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateIpMaskResponse> EnterpriseAccountUpdateIpMaskWithOptionsAsync(EnterpriseAccountUpdateIpMaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpMasksJson))
            {
                query["IpMasksJson"] = request.IpMasksJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateIpMask",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateIpMaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Ip掩码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateIpMaskRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateIpMaskResponse
        /// </returns>
        public EnterpriseAccountUpdateIpMaskResponse EnterpriseAccountUpdateIpMask(EnterpriseAccountUpdateIpMaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountUpdateIpMaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置Ip掩码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateIpMaskRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateIpMaskResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateIpMaskResponse> EnterpriseAccountUpdateIpMaskAsync(EnterpriseAccountUpdateIpMaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountUpdateIpMaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新操作风控</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateOperateRiskControlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateOperateRiskControlResponse
        /// </returns>
        public EnterpriseAccountUpdateOperateRiskControlResponse EnterpriseAccountUpdateOperateRiskControlWithOptions(EnterpriseAccountUpdateOperateRiskControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductLevel))
            {
                query["ProductLevel"] = request.ProductLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateType))
            {
                query["ValidateType"] = request.ValidateType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateOperateRiskControl",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateOperateRiskControlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新操作风控</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateOperateRiskControlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateOperateRiskControlResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateOperateRiskControlResponse> EnterpriseAccountUpdateOperateRiskControlWithOptionsAsync(EnterpriseAccountUpdateOperateRiskControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductLevel))
            {
                query["ProductLevel"] = request.ProductLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateType))
            {
                query["ValidateType"] = request.ValidateType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateOperateRiskControl",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateOperateRiskControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新操作风控</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateOperateRiskControlRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateOperateRiskControlResponse
        /// </returns>
        public EnterpriseAccountUpdateOperateRiskControlResponse EnterpriseAccountUpdateOperateRiskControl(EnterpriseAccountUpdateOperateRiskControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountUpdateOperateRiskControlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新操作风控</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateOperateRiskControlRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateOperateRiskControlResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateOperateRiskControlResponse> EnterpriseAccountUpdateOperateRiskControlAsync(EnterpriseAccountUpdateOperateRiskControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountUpdateOperateRiskControlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改安全手机启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateSecurityMobileLoginStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateSecurityMobileLoginStatusResponse
        /// </returns>
        public EnterpriseAccountUpdateSecurityMobileLoginStatusResponse EnterpriseAccountUpdateSecurityMobileLoginStatusWithOptions(EnterpriseAccountUpdateSecurityMobileLoginStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateSecurityMobileLoginStatus",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateSecurityMobileLoginStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改安全手机启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateSecurityMobileLoginStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateSecurityMobileLoginStatusResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateSecurityMobileLoginStatusResponse> EnterpriseAccountUpdateSecurityMobileLoginStatusWithOptionsAsync(EnterpriseAccountUpdateSecurityMobileLoginStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateSecurityMobileLoginStatus",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateSecurityMobileLoginStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改安全手机启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateSecurityMobileLoginStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateSecurityMobileLoginStatusResponse
        /// </returns>
        public EnterpriseAccountUpdateSecurityMobileLoginStatusResponse EnterpriseAccountUpdateSecurityMobileLoginStatus(EnterpriseAccountUpdateSecurityMobileLoginStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountUpdateSecurityMobileLoginStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改安全手机启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateSecurityMobileLoginStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateSecurityMobileLoginStatusResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateSecurityMobileLoginStatusResponse> EnterpriseAccountUpdateSecurityMobileLoginStatusAsync(EnterpriseAccountUpdateSecurityMobileLoginStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountUpdateSecurityMobileLoginStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新过期时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateSessionExpireTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateSessionExpireTimeResponse
        /// </returns>
        public EnterpriseAccountUpdateSessionExpireTimeResponse EnterpriseAccountUpdateSessionExpireTimeWithOptions(EnterpriseAccountUpdateSessionExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionExpireTime))
            {
                query["SessionExpireTime"] = request.SessionExpireTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateSessionExpireTime",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateSessionExpireTimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新过期时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateSessionExpireTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateSessionExpireTimeResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateSessionExpireTimeResponse> EnterpriseAccountUpdateSessionExpireTimeWithOptionsAsync(EnterpriseAccountUpdateSessionExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionExpireTime))
            {
                query["SessionExpireTime"] = request.SessionExpireTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseAccountUpdateSessionExpireTime",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseAccountUpdateSessionExpireTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新过期时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateSessionExpireTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateSessionExpireTimeResponse
        /// </returns>
        public EnterpriseAccountUpdateSessionExpireTimeResponse EnterpriseAccountUpdateSessionExpireTime(EnterpriseAccountUpdateSessionExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseAccountUpdateSessionExpireTimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新过期时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseAccountUpdateSessionExpireTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseAccountUpdateSessionExpireTimeResponse
        /// </returns>
        public async Task<EnterpriseAccountUpdateSessionExpireTimeResponse> EnterpriseAccountUpdateSessionExpireTimeAsync(EnterpriseAccountUpdateSessionExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseAccountUpdateSessionExpireTimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织目录树查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseOrgQueryLoadTreeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseOrgQueryLoadTreeResponse
        /// </returns>
        public EnterpriseOrgQueryLoadTreeResponse EnterpriseOrgQueryLoadTreeWithOptions(EnterpriseOrgQueryLoadTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadOrgOnly))
            {
                query["LoadOrgOnly"] = request.LoadOrgOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseOrgQueryLoadTree",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseOrgQueryLoadTreeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织目录树查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseOrgQueryLoadTreeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseOrgQueryLoadTreeResponse
        /// </returns>
        public async Task<EnterpriseOrgQueryLoadTreeResponse> EnterpriseOrgQueryLoadTreeWithOptionsAsync(EnterpriseOrgQueryLoadTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadOrgOnly))
            {
                query["LoadOrgOnly"] = request.LoadOrgOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseOrgQueryLoadTree",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseOrgQueryLoadTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织目录树查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseOrgQueryLoadTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseOrgQueryLoadTreeResponse
        /// </returns>
        public EnterpriseOrgQueryLoadTreeResponse EnterpriseOrgQueryLoadTree(EnterpriseOrgQueryLoadTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseOrgQueryLoadTreeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织目录树查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseOrgQueryLoadTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseOrgQueryLoadTreeResponse
        /// </returns>
        public async Task<EnterpriseOrgQueryLoadTreeResponse> EnterpriseOrgQueryLoadTreeAsync(EnterpriseOrgQueryLoadTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseOrgQueryLoadTreeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建成员账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRegisterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRegisterAccountResponse
        /// </returns>
        public EnterpriseRegisterAccountResponse EnterpriseRegisterAccountWithOptions(EnterpriseRegisterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPassword))
            {
                query["EncryptPassword"] = request.EncryptPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                query["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteNick))
            {
                query["SiteNick"] = request.SiteNick;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRegisterAccount",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRegisterAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建成员账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRegisterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRegisterAccountResponse
        /// </returns>
        public async Task<EnterpriseRegisterAccountResponse> EnterpriseRegisterAccountWithOptionsAsync(EnterpriseRegisterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPassword))
            {
                query["EncryptPassword"] = request.EncryptPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                query["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteNick))
            {
                query["SiteNick"] = request.SiteNick;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRegisterAccount",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRegisterAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建成员账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRegisterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRegisterAccountResponse
        /// </returns>
        public EnterpriseRegisterAccountResponse EnterpriseRegisterAccount(EnterpriseRegisterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseRegisterAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建成员账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRegisterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRegisterAccountResponse
        /// </returns>
        public async Task<EnterpriseRegisterAccountResponse> EnterpriseRegisterAccountAsync(EnterpriseRegisterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseRegisterAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleCreateBizRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleCreateBizRoleResponse
        /// </returns>
        public EnterpriseRoleCreateBizRoleResponse EnterpriseRoleCreateBizRoleWithOptions(EnterpriseRoleCreateBizRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizPermissionCodeListJson))
            {
                query["BizPermissionCodeListJson"] = request.BizPermissionCodeListJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleDesc))
            {
                query["BizRoleDesc"] = request.BizRoleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleName))
            {
                query["BizRoleName"] = request.BizRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleCreateBizRole",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleCreateBizRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleCreateBizRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleCreateBizRoleResponse
        /// </returns>
        public async Task<EnterpriseRoleCreateBizRoleResponse> EnterpriseRoleCreateBizRoleWithOptionsAsync(EnterpriseRoleCreateBizRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizPermissionCodeListJson))
            {
                query["BizPermissionCodeListJson"] = request.BizPermissionCodeListJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleDesc))
            {
                query["BizRoleDesc"] = request.BizRoleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleName))
            {
                query["BizRoleName"] = request.BizRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleCreateBizRole",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleCreateBizRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleCreateBizRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleCreateBizRoleResponse
        /// </returns>
        public EnterpriseRoleCreateBizRoleResponse EnterpriseRoleCreateBizRole(EnterpriseRoleCreateBizRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseRoleCreateBizRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleCreateBizRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleCreateBizRoleResponse
        /// </returns>
        public async Task<EnterpriseRoleCreateBizRoleResponse> EnterpriseRoleCreateBizRoleAsync(EnterpriseRoleCreateBizRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseRoleCreateBizRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleDeleteBizRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleDeleteBizRoleResponse
        /// </returns>
        public EnterpriseRoleDeleteBizRoleResponse EnterpriseRoleDeleteBizRoleWithOptions(EnterpriseRoleDeleteBizRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCode))
            {
                query["BizRoleCode"] = request.BizRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleDeleteBizRole",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleDeleteBizRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleDeleteBizRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleDeleteBizRoleResponse
        /// </returns>
        public async Task<EnterpriseRoleDeleteBizRoleResponse> EnterpriseRoleDeleteBizRoleWithOptionsAsync(EnterpriseRoleDeleteBizRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCode))
            {
                query["BizRoleCode"] = request.BizRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleDeleteBizRole",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleDeleteBizRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleDeleteBizRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleDeleteBizRoleResponse
        /// </returns>
        public EnterpriseRoleDeleteBizRoleResponse EnterpriseRoleDeleteBizRole(EnterpriseRoleDeleteBizRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseRoleDeleteBizRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleDeleteBizRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleDeleteBizRoleResponse
        /// </returns>
        public async Task<EnterpriseRoleDeleteBizRoleResponse> EnterpriseRoleDeleteBizRoleAsync(EnterpriseRoleDeleteBizRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseRoleDeleteBizRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>角色授权场景下分页查询账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryAccountForRoleGrantByPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryAccountForRoleGrantByPageResponse
        /// </returns>
        public EnterpriseRoleQueryAccountForRoleGrantByPageResponse EnterpriseRoleQueryAccountForRoleGrantByPageWithOptions(EnterpriseRoleQueryAccountForRoleGrantByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCode))
            {
                query["BizRoleCode"] = request.BizRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                query["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleQueryAccountForRoleGrantByPage",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleQueryAccountForRoleGrantByPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>角色授权场景下分页查询账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryAccountForRoleGrantByPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryAccountForRoleGrantByPageResponse
        /// </returns>
        public async Task<EnterpriseRoleQueryAccountForRoleGrantByPageResponse> EnterpriseRoleQueryAccountForRoleGrantByPageWithOptionsAsync(EnterpriseRoleQueryAccountForRoleGrantByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCode))
            {
                query["BizRoleCode"] = request.BizRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                query["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleQueryAccountForRoleGrantByPage",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleQueryAccountForRoleGrantByPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>角色授权场景下分页查询账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryAccountForRoleGrantByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryAccountForRoleGrantByPageResponse
        /// </returns>
        public EnterpriseRoleQueryAccountForRoleGrantByPageResponse EnterpriseRoleQueryAccountForRoleGrantByPage(EnterpriseRoleQueryAccountForRoleGrantByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseRoleQueryAccountForRoleGrantByPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>角色授权场景下分页查询账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryAccountForRoleGrantByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryAccountForRoleGrantByPageResponse
        /// </returns>
        public async Task<EnterpriseRoleQueryAccountForRoleGrantByPageResponse> EnterpriseRoleQueryAccountForRoleGrantByPageAsync(EnterpriseRoleQueryAccountForRoleGrantByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseRoleQueryAccountForRoleGrantByPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryBizRoleByPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryBizRoleByPageResponse
        /// </returns>
        public EnterpriseRoleQueryBizRoleByPageResponse EnterpriseRoleQueryBizRoleByPageWithOptions(EnterpriseRoleQueryBizRoleByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleQueryBizRoleByPage",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleQueryBizRoleByPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryBizRoleByPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryBizRoleByPageResponse
        /// </returns>
        public async Task<EnterpriseRoleQueryBizRoleByPageResponse> EnterpriseRoleQueryBizRoleByPageWithOptionsAsync(EnterpriseRoleQueryBizRoleByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                query["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleQueryBizRoleByPage",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleQueryBizRoleByPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryBizRoleByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryBizRoleByPageResponse
        /// </returns>
        public EnterpriseRoleQueryBizRoleByPageResponse EnterpriseRoleQueryBizRoleByPage(EnterpriseRoleQueryBizRoleByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseRoleQueryBizRoleByPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryBizRoleByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryBizRoleByPageResponse
        /// </returns>
        public async Task<EnterpriseRoleQueryBizRoleByPageResponse> EnterpriseRoleQueryBizRoleByPageAsync(EnterpriseRoleQueryBizRoleByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseRoleQueryBizRoleByPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务角色详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryBizRoleDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryBizRoleDetailResponse
        /// </returns>
        public EnterpriseRoleQueryBizRoleDetailResponse EnterpriseRoleQueryBizRoleDetailWithOptions(EnterpriseRoleQueryBizRoleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCode))
            {
                query["BizRoleCode"] = request.BizRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleQueryBizRoleDetail",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleQueryBizRoleDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务角色详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryBizRoleDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryBizRoleDetailResponse
        /// </returns>
        public async Task<EnterpriseRoleQueryBizRoleDetailResponse> EnterpriseRoleQueryBizRoleDetailWithOptionsAsync(EnterpriseRoleQueryBizRoleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCode))
            {
                query["BizRoleCode"] = request.BizRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleQueryBizRoleDetail",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleQueryBizRoleDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务角色详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryBizRoleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryBizRoleDetailResponse
        /// </returns>
        public EnterpriseRoleQueryBizRoleDetailResponse EnterpriseRoleQueryBizRoleDetail(EnterpriseRoleQueryBizRoleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseRoleQueryBizRoleDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务角色详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleQueryBizRoleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleQueryBizRoleDetailResponse
        /// </returns>
        public async Task<EnterpriseRoleQueryBizRoleDetailResponse> EnterpriseRoleQueryBizRoleDetailAsync(EnterpriseRoleQueryBizRoleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseRoleQueryBizRoleDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleUpdateBizRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleUpdateBizRoleResponse
        /// </returns>
        public EnterpriseRoleUpdateBizRoleResponse EnterpriseRoleUpdateBizRoleWithOptions(EnterpriseRoleUpdateBizRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizPermissionCodeListJson))
            {
                query["BizPermissionCodeListJson"] = request.BizPermissionCodeListJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCode))
            {
                query["BizRoleCode"] = request.BizRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleDesc))
            {
                query["BizRoleDesc"] = request.BizRoleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleName))
            {
                query["BizRoleName"] = request.BizRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleUpdateBizRole",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleUpdateBizRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleUpdateBizRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleUpdateBizRoleResponse
        /// </returns>
        public async Task<EnterpriseRoleUpdateBizRoleResponse> EnterpriseRoleUpdateBizRoleWithOptionsAsync(EnterpriseRoleUpdateBizRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizPermissionCodeListJson))
            {
                query["BizPermissionCodeListJson"] = request.BizPermissionCodeListJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleCode))
            {
                query["BizRoleCode"] = request.BizRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleDesc))
            {
                query["BizRoleDesc"] = request.BizRoleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRoleName))
            {
                query["BizRoleName"] = request.BizRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRoleUpdateBizRole",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRoleUpdateBizRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleUpdateBizRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleUpdateBizRoleResponse
        /// </returns>
        public EnterpriseRoleUpdateBizRoleResponse EnterpriseRoleUpdateBizRole(EnterpriseRoleUpdateBizRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseRoleUpdateBizRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRoleUpdateBizRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRoleUpdateBizRoleResponse
        /// </returns>
        public async Task<EnterpriseRoleUpdateBizRoleResponse> EnterpriseRoleUpdateBizRoleAsync(EnterpriseRoleUpdateBizRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseRoleUpdateBizRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处理待办项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoDealAccountTodoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoDealAccountTodoResponse
        /// </returns>
        public EnterpriseTodoDealAccountTodoResponse EnterpriseTodoDealAccountTodoWithOptions(EnterpriseTodoDealAccountTodoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TodoId))
            {
                body["TodoId"] = request.TodoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseTodoDealAccountTodo",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseTodoDealAccountTodoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处理待办项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoDealAccountTodoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoDealAccountTodoResponse
        /// </returns>
        public async Task<EnterpriseTodoDealAccountTodoResponse> EnterpriseTodoDealAccountTodoWithOptionsAsync(EnterpriseTodoDealAccountTodoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TodoId))
            {
                body["TodoId"] = request.TodoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseTodoDealAccountTodo",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseTodoDealAccountTodoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处理待办项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoDealAccountTodoRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoDealAccountTodoResponse
        /// </returns>
        public EnterpriseTodoDealAccountTodoResponse EnterpriseTodoDealAccountTodo(EnterpriseTodoDealAccountTodoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseTodoDealAccountTodoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处理待办项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoDealAccountTodoRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoDealAccountTodoResponse
        /// </returns>
        public async Task<EnterpriseTodoDealAccountTodoResponse> EnterpriseTodoDealAccountTodoAsync(EnterpriseTodoDealAccountTodoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseTodoDealAccountTodoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户处理的待办项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoQueryAccountTodoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoQueryAccountTodoListResponse
        /// </returns>
        public EnterpriseTodoQueryAccountTodoListResponse EnterpriseTodoQueryAccountTodoListWithOptions(EnterpriseTodoQueryAccountTodoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatePk))
            {
                body["OperatePk"] = request.OperatePk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TodoType))
            {
                body["TodoType"] = request.TodoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseTodoQueryAccountTodoList",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseTodoQueryAccountTodoListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户处理的待办项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoQueryAccountTodoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoQueryAccountTodoListResponse
        /// </returns>
        public async Task<EnterpriseTodoQueryAccountTodoListResponse> EnterpriseTodoQueryAccountTodoListWithOptionsAsync(EnterpriseTodoQueryAccountTodoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatePk))
            {
                body["OperatePk"] = request.OperatePk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TodoType))
            {
                body["TodoType"] = request.TodoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseTodoQueryAccountTodoList",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseTodoQueryAccountTodoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户处理的待办项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoQueryAccountTodoListRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoQueryAccountTodoListResponse
        /// </returns>
        public EnterpriseTodoQueryAccountTodoListResponse EnterpriseTodoQueryAccountTodoList(EnterpriseTodoQueryAccountTodoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseTodoQueryAccountTodoListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户处理的待办项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoQueryAccountTodoListRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoQueryAccountTodoListResponse
        /// </returns>
        public async Task<EnterpriseTodoQueryAccountTodoListResponse> EnterpriseTodoQueryAccountTodoListAsync(EnterpriseTodoQueryAccountTodoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseTodoQueryAccountTodoListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户发起的待办项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoQueryAccountTodoListByApplicantRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoQueryAccountTodoListByApplicantResponse
        /// </returns>
        public EnterpriseTodoQueryAccountTodoListByApplicantResponse EnterpriseTodoQueryAccountTodoListByApplicantWithOptions(EnterpriseTodoQueryAccountTodoListByApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatePk))
            {
                body["OperatePk"] = request.OperatePk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TodoType))
            {
                body["TodoType"] = request.TodoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseTodoQueryAccountTodoListByApplicant",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseTodoQueryAccountTodoListByApplicantResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户发起的待办项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoQueryAccountTodoListByApplicantRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoQueryAccountTodoListByApplicantResponse
        /// </returns>
        public async Task<EnterpriseTodoQueryAccountTodoListByApplicantResponse> EnterpriseTodoQueryAccountTodoListByApplicantWithOptionsAsync(EnterpriseTodoQueryAccountTodoListByApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatePk))
            {
                body["OperatePk"] = request.OperatePk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                body["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TodoType))
            {
                body["TodoType"] = request.TodoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseTodoQueryAccountTodoListByApplicant",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseTodoQueryAccountTodoListByApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户发起的待办项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoQueryAccountTodoListByApplicantRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoQueryAccountTodoListByApplicantResponse
        /// </returns>
        public EnterpriseTodoQueryAccountTodoListByApplicantResponse EnterpriseTodoQueryAccountTodoListByApplicant(EnterpriseTodoQueryAccountTodoListByApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseTodoQueryAccountTodoListByApplicantWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户发起的待办项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseTodoQueryAccountTodoListByApplicantRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseTodoQueryAccountTodoListByApplicantResponse
        /// </returns>
        public async Task<EnterpriseTodoQueryAccountTodoListByApplicantResponse> EnterpriseTodoQueryAccountTodoListByApplicantAsync(EnterpriseTodoQueryAccountTodoListByApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseTodoQueryAccountTodoListByApplicantWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理员邀请纳管</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseUninvitedAdminInviteJoinEnterpriseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseUninvitedAdminInviteJoinEnterpriseResponse
        /// </returns>
        public EnterpriseUninvitedAdminInviteJoinEnterpriseResponse EnterpriseUninvitedAdminInviteJoinEnterpriseWithOptions(EnterpriseUninvitedAdminInviteJoinEnterpriseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcId))
            {
                query["EcId"] = request.EcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteePk))
            {
                query["InviteePk"] = request.InviteePk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeId))
            {
                query["LeId"] = request.LeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NbId))
            {
                query["NbId"] = request.NbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseUninvitedAdminInviteJoinEnterprise",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseUninvitedAdminInviteJoinEnterpriseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理员邀请纳管</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseUninvitedAdminInviteJoinEnterpriseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseUninvitedAdminInviteJoinEnterpriseResponse
        /// </returns>
        public async Task<EnterpriseUninvitedAdminInviteJoinEnterpriseResponse> EnterpriseUninvitedAdminInviteJoinEnterpriseWithOptionsAsync(EnterpriseUninvitedAdminInviteJoinEnterpriseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcId))
            {
                query["EcId"] = request.EcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteePk))
            {
                query["InviteePk"] = request.InviteePk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeId))
            {
                query["LeId"] = request.LeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NbId))
            {
                query["NbId"] = request.NbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseUninvitedAdminInviteJoinEnterprise",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseUninvitedAdminInviteJoinEnterpriseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理员邀请纳管</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseUninvitedAdminInviteJoinEnterpriseRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseUninvitedAdminInviteJoinEnterpriseResponse
        /// </returns>
        public EnterpriseUninvitedAdminInviteJoinEnterpriseResponse EnterpriseUninvitedAdminInviteJoinEnterprise(EnterpriseUninvitedAdminInviteJoinEnterpriseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseUninvitedAdminInviteJoinEnterpriseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管理员邀请纳管</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseUninvitedAdminInviteJoinEnterpriseRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseUninvitedAdminInviteJoinEnterpriseResponse
        /// </returns>
        public async Task<EnterpriseUninvitedAdminInviteJoinEnterpriseResponse> EnterpriseUninvitedAdminInviteJoinEnterpriseAsync(EnterpriseUninvitedAdminInviteJoinEnterpriseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseUninvitedAdminInviteJoinEnterpriseWithOptionsAsync(request, runtime);
        }

    }
}
