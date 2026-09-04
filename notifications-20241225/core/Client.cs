// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Notifications20241225.Models;

namespace AlibabaCloud.SDK.Notifications20241225
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "notifications-intl.aliyuncs.com"},
                {"cn-zhangjiakou", "notifications.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("notifications", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWebhookContactResponse
        /// </returns>
        public CreateWebhookContactResponse CreateWebhookContactWithOptions(CreateWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotSecurityToken))
            {
                body["BotSecurityToken"] = request.BotSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerUrl))
            {
                body["ServerUrl"] = request.ServerUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                body["VerificationCode"] = request.VerificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["WebhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWebhookContactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWebhookContactResponse
        /// </returns>
        public async Task<CreateWebhookContactResponse> CreateWebhookContactWithOptionsAsync(CreateWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotSecurityToken))
            {
                body["BotSecurityToken"] = request.BotSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerUrl))
            {
                body["ServerUrl"] = request.ServerUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                body["VerificationCode"] = request.VerificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["WebhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWebhookContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWebhookContactResponse
        /// </returns>
        public CreateWebhookContactResponse CreateWebhookContact(CreateWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWebhookContactWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWebhookContactResponse
        /// </returns>
        public async Task<CreateWebhookContactResponse> CreateWebhookContactAsync(CreateWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWebhookContactWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelMessageResponse
        /// </returns>
        public DelMessageResponse DelMessageWithOptions(DelMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelMessage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelMessageResponse
        /// </returns>
        public async Task<DelMessageResponse> DelMessageWithOptionsAsync(DelMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelMessage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// DelMessageResponse
        /// </returns>
        public DelMessageResponse DelMessage(DelMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DelMessageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// DelMessageResponse
        /// </returns>
        public async Task<DelMessageResponse> DelMessageAsync(DelMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DelMessageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes all in-app messages (logical deletion).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAllMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAllMessageResponse
        /// </returns>
        public DeleteAllMessageResponse DeleteAllMessageWithOptions(DeleteAllMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassId))
            {
                body["ClassId"] = request.ClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAllMessage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAllMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes all in-app messages (logical deletion).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAllMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAllMessageResponse
        /// </returns>
        public async Task<DeleteAllMessageResponse> DeleteAllMessageWithOptionsAsync(DeleteAllMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassId))
            {
                body["ClassId"] = request.ClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAllMessage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAllMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes all in-app messages (logical deletion).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAllMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAllMessageResponse
        /// </returns>
        public DeleteAllMessageResponse DeleteAllMessage(DeleteAllMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAllMessageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes all in-app messages (logical deletion).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAllMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAllMessageResponse
        /// </returns>
        public async Task<DeleteAllMessageResponse> DeleteAllMessageAsync(DeleteAllMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAllMessageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebhookContactResponse
        /// </returns>
        public DeleteWebhookContactResponse DeleteWebhookContactWithOptions(DeleteWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWebhookContactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebhookContactResponse
        /// </returns>
        public async Task<DeleteWebhookContactResponse> DeleteWebhookContactWithOptionsAsync(DeleteWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWebhookContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebhookContactResponse
        /// </returns>
        public DeleteWebhookContactResponse DeleteWebhookContact(DeleteWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWebhookContactWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebhookContactResponse
        /// </returns>
        public async Task<DeleteWebhookContactResponse> DeleteWebhookContactAsync(DeleteWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWebhookContactWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all common contacts across accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllCommonContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadAllCommonContactsResponse
        /// </returns>
        public ReadAllCommonContactsResponse ReadAllCommonContactsWithOptions(ReadAllCommonContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadAllCommonContacts",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadAllCommonContactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all common contacts across accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllCommonContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadAllCommonContactsResponse
        /// </returns>
        public async Task<ReadAllCommonContactsResponse> ReadAllCommonContactsWithOptionsAsync(ReadAllCommonContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadAllCommonContacts",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadAllCommonContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all common contacts across accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllCommonContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadAllCommonContactsResponse
        /// </returns>
        public ReadAllCommonContactsResponse ReadAllCommonContacts(ReadAllCommonContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadAllCommonContactsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all common contacts across accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllCommonContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadAllCommonContactsResponse
        /// </returns>
        public async Task<ReadAllCommonContactsResponse> ReadAllCommonContactsAsync(ReadAllCommonContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadAllCommonContactsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all marketing preference configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllMarketingPreferencesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadAllMarketingPreferencesResponse
        /// </returns>
        public ReadAllMarketingPreferencesResponse ReadAllMarketingPreferencesWithOptions(ReadAllMarketingPreferencesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadAllMarketingPreferences",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadAllMarketingPreferencesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all marketing preference configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllMarketingPreferencesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadAllMarketingPreferencesResponse
        /// </returns>
        public async Task<ReadAllMarketingPreferencesResponse> ReadAllMarketingPreferencesWithOptionsAsync(ReadAllMarketingPreferencesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadAllMarketingPreferences",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadAllMarketingPreferencesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all marketing preference configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllMarketingPreferencesRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadAllMarketingPreferencesResponse
        /// </returns>
        public ReadAllMarketingPreferencesResponse ReadAllMarketingPreferences(ReadAllMarketingPreferencesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadAllMarketingPreferencesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all marketing preference configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllMarketingPreferencesRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadAllMarketingPreferencesResponse
        /// </returns>
        public async Task<ReadAllMarketingPreferencesResponse> ReadAllMarketingPreferencesAsync(ReadAllMarketingPreferencesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadAllMarketingPreferencesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marks all messages as read. If no category is specified, all messages are marked as read.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadAllMessageResponse
        /// </returns>
        public ReadAllMessageResponse ReadAllMessageWithOptions(ReadAllMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassId))
            {
                body["ClassId"] = request.ClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadAllMessage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadAllMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marks all messages as read. If no category is specified, all messages are marked as read.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadAllMessageResponse
        /// </returns>
        public async Task<ReadAllMessageResponse> ReadAllMessageWithOptionsAsync(ReadAllMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassId))
            {
                body["ClassId"] = request.ClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadAllMessage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadAllMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marks all messages as read. If no category is specified, all messages are marked as read.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadAllMessageResponse
        /// </returns>
        public ReadAllMessageResponse ReadAllMessage(ReadAllMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadAllMessageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marks all messages as read. If no category is specified, all messages are marked as read.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadAllMessageResponse
        /// </returns>
        public async Task<ReadAllMessageResponse> ReadAllMessageAsync(ReadAllMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadAllMessageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the full list of webhooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllWebhookContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadAllWebhookContactsResponse
        /// </returns>
        public ReadAllWebhookContactsResponse ReadAllWebhookContactsWithOptions(ReadAllWebhookContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadAllWebhookContacts",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadAllWebhookContactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the full list of webhooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllWebhookContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadAllWebhookContactsResponse
        /// </returns>
        public async Task<ReadAllWebhookContactsResponse> ReadAllWebhookContactsWithOptionsAsync(ReadAllWebhookContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadAllWebhookContacts",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadAllWebhookContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the full list of webhooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllWebhookContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadAllWebhookContactsResponse
        /// </returns>
        public ReadAllWebhookContactsResponse ReadAllWebhookContacts(ReadAllWebhookContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadAllWebhookContactsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the full list of webhooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadAllWebhookContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadAllWebhookContactsResponse
        /// </returns>
        public async Task<ReadAllWebhookContactsResponse> ReadAllWebhookContactsAsync(ReadAllWebhookContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadAllWebhookContactsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get category group list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadCategoryGroupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadCategoryGroupListResponse
        /// </returns>
        public ReadCategoryGroupListResponse ReadCategoryGroupListWithOptions(ReadCategoryGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelGroupCode))
            {
                body["ChannelGroupCode"] = request.ChannelGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadCategoryGroupList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadCategoryGroupListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get category group list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadCategoryGroupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadCategoryGroupListResponse
        /// </returns>
        public async Task<ReadCategoryGroupListResponse> ReadCategoryGroupListWithOptionsAsync(ReadCategoryGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelGroupCode))
            {
                body["ChannelGroupCode"] = request.ChannelGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadCategoryGroupList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadCategoryGroupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get category group list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadCategoryGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadCategoryGroupListResponse
        /// </returns>
        public ReadCategoryGroupListResponse ReadCategoryGroupList(ReadCategoryGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadCategoryGroupListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get category group list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadCategoryGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadCategoryGroupListResponse
        /// </returns>
        public async Task<ReadCategoryGroupListResponse> ReadCategoryGroupListAsync(ReadCategoryGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadCategoryGroupListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of read messages for each category.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadClassNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadClassNameResponse
        /// </returns>
        public ReadClassNameResponse ReadClassNameWithOptions(ReadClassNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadClassName",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadClassNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of read messages for each category.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadClassNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadClassNameResponse
        /// </returns>
        public async Task<ReadClassNameResponse> ReadClassNameWithOptionsAsync(ReadClassNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadClassName",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadClassNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of read messages for each category.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadClassNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadClassNameResponse
        /// </returns>
        public ReadClassNameResponse ReadClassName(ReadClassNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadClassNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of read messages for each category.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadClassNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadClassNameResponse
        /// </returns>
        public async Task<ReadClassNameResponse> ReadClassNameAsync(ReadClassNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadClassNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a general contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadCommonContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadCommonContactResponse
        /// </returns>
        public ReadCommonContactResponse ReadCommonContactWithOptions(ReadCommonContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadCommonContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadCommonContactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a general contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadCommonContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadCommonContactResponse
        /// </returns>
        public async Task<ReadCommonContactResponse> ReadCommonContactWithOptionsAsync(ReadCommonContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadCommonContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadCommonContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a general contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadCommonContactRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadCommonContactResponse
        /// </returns>
        public ReadCommonContactResponse ReadCommonContact(ReadCommonContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadCommonContactWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a general contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadCommonContactRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadCommonContactResponse
        /// </returns>
        public async Task<ReadCommonContactResponse> ReadCommonContactAsync(ReadCommonContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadCommonContactWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户营销偏好</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMarketingPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMarketingPreferenceResponse
        /// </returns>
        public ReadMarketingPreferenceResponse ReadMarketingPreferenceWithOptions(ReadMarketingPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMarketingPreference",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMarketingPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户营销偏好</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMarketingPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMarketingPreferenceResponse
        /// </returns>
        public async Task<ReadMarketingPreferenceResponse> ReadMarketingPreferenceWithOptionsAsync(ReadMarketingPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMarketingPreference",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMarketingPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户营销偏好</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMarketingPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMarketingPreferenceResponse
        /// </returns>
        public ReadMarketingPreferenceResponse ReadMarketingPreference(ReadMarketingPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadMarketingPreferenceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户营销偏好</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMarketingPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMarketingPreferenceResponse
        /// </returns>
        public async Task<ReadMarketingPreferenceResponse> ReadMarketingPreferenceAsync(ReadMarketingPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadMarketingPreferenceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marks a message as read.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageResponse
        /// </returns>
        public ReadMessageResponse ReadMessageWithOptions(ReadMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marks a message as read.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageResponse
        /// </returns>
        public async Task<ReadMessageResponse> ReadMessageWithOptionsAsync(ReadMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marks a message as read.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageResponse
        /// </returns>
        public ReadMessageResponse ReadMessage(ReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadMessageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marks a message as read.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageResponse
        /// </returns>
        public async Task<ReadMessageResponse> ReadMessageAsync(ReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadMessageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the body of a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageContentResponse
        /// </returns>
        public ReadMessageContentResponse ReadMessageContentWithOptions(ReadMessageContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassId))
            {
                body["ClassId"] = request.ClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                body["History"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessageContent",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the body of a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageContentResponse
        /// </returns>
        public async Task<ReadMessageContentResponse> ReadMessageContentWithOptionsAsync(ReadMessageContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassId))
            {
                body["ClassId"] = request.ClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                body["History"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessageContent",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the body of a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageContentResponse
        /// </returns>
        public ReadMessageContentResponse ReadMessageContent(ReadMessageContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadMessageContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the body of a message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageContentResponse
        /// </returns>
        public async Task<ReadMessageContentResponse> ReadMessageContentAsync(ReadMessageContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadMessageContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageLanguageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageLanguageResponse
        /// </returns>
        public ReadMessageLanguageResponse ReadMessageLanguageWithOptions(ReadMessageLanguageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnDefaultLang))
            {
                body["ReturnDefaultLang"] = request.ReturnDefaultLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessageLanguage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageLanguageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageLanguageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageLanguageResponse
        /// </returns>
        public async Task<ReadMessageLanguageResponse> ReadMessageLanguageWithOptionsAsync(ReadMessageLanguageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnDefaultLang))
            {
                body["ReturnDefaultLang"] = request.ReturnDefaultLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessageLanguage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageLanguageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageLanguageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageLanguageResponse
        /// </returns>
        public ReadMessageLanguageResponse ReadMessageLanguage(ReadMessageLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadMessageLanguageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageLanguageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageLanguageResponse
        /// </returns>
        public async Task<ReadMessageLanguageResponse> ReadMessageLanguageAsync(ReadMessageLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadMessageLanguageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageListResponse
        /// </returns>
        public ReadMessageListResponse ReadMessageListWithOptions(ReadMessageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassId))
            {
                body["ClassId"] = request.ClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                body["History"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Loc))
            {
                body["Loc"] = request.Loc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessageList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageListResponse
        /// </returns>
        public async Task<ReadMessageListResponse> ReadMessageListWithOptionsAsync(ReadMessageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassId))
            {
                body["ClassId"] = request.ClassId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                body["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                body["History"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Loc))
            {
                body["Loc"] = request.Loc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessageList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageListResponse
        /// </returns>
        public ReadMessageListResponse ReadMessageList(ReadMessageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadMessageListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageListResponse
        /// </returns>
        public async Task<ReadMessageListResponse> ReadMessageListAsync(ReadMessageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadMessageListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the total number of unread messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageNewTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageNewTotalResponse
        /// </returns>
        public ReadMessageNewTotalResponse ReadMessageNewTotalWithOptions(ReadMessageNewTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessageNewTotal",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageNewTotalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the total number of unread messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageNewTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageNewTotalResponse
        /// </returns>
        public async Task<ReadMessageNewTotalResponse> ReadMessageNewTotalWithOptionsAsync(ReadMessageNewTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessageNewTotal",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageNewTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the total number of unread messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageNewTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageNewTotalResponse
        /// </returns>
        public ReadMessageNewTotalResponse ReadMessageNewTotal(ReadMessageNewTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadMessageNewTotalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the total number of unread messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageNewTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageNewTotalResponse
        /// </returns>
        public async Task<ReadMessageNewTotalResponse> ReadMessageNewTotalAsync(ReadMessageNewTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadMessageNewTotalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the count of read messages for each category.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadNumGroupByClassRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadNumGroupByClassResponse
        /// </returns>
        public ReadNumGroupByClassResponse ReadNumGroupByClassWithOptions(ReadNumGroupByClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadNumGroupByClass",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadNumGroupByClassResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the count of read messages for each category.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadNumGroupByClassRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadNumGroupByClassResponse
        /// </returns>
        public async Task<ReadNumGroupByClassResponse> ReadNumGroupByClassWithOptionsAsync(ReadNumGroupByClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadNumGroupByClass",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadNumGroupByClassResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the count of read messages for each category.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadNumGroupByClassRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadNumGroupByClassResponse
        /// </returns>
        public ReadNumGroupByClassResponse ReadNumGroupByClass(ReadNumGroupByClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadNumGroupByClassWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the count of read messages for each category.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadNumGroupByClassRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadNumGroupByClassResponse
        /// </returns>
        public async Task<ReadNumGroupByClassResponse> ReadNumGroupByClassAsync(ReadNumGroupByClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadNumGroupByClassWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Method description: Get information under all categories</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadNumGroupTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadNumGroupTotalResponse
        /// </returns>
        public ReadNumGroupTotalResponse ReadNumGroupTotalWithOptions(ReadNumGroupTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadNumGroupTotal",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadNumGroupTotalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Method description: Get information under all categories</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadNumGroupTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadNumGroupTotalResponse
        /// </returns>
        public async Task<ReadNumGroupTotalResponse> ReadNumGroupTotalWithOptionsAsync(ReadNumGroupTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadNumGroupTotal",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadNumGroupTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Method description: Get information under all categories</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadNumGroupTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadNumGroupTotalResponse
        /// </returns>
        public ReadNumGroupTotalResponse ReadNumGroupTotal(ReadNumGroupTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadNumGroupTotalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Method description: Get information under all categories</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadNumGroupTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadNumGroupTotalResponse
        /// </returns>
        public async Task<ReadNumGroupTotalResponse> ReadNumGroupTotalAsync(ReadNumGroupTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadNumGroupTotalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves revision records.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ReadRevisionHistoryListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadRevisionHistoryListResponse
        /// </returns>
        public ReadRevisionHistoryListResponse ReadRevisionHistoryListWithOptions(ReadRevisionHistoryListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReadRevisionHistoryListShrinkRequest request = new ReadRevisionHistoryListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageInfo))
            {
                request.PageInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageInfo, "PageInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCode))
            {
                body["CategoryCode"] = request.CategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelGroupCode))
            {
                body["ChannelGroupCode"] = request.ChannelGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageInfoShrink))
            {
                body["PageInfo"] = request.PageInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadRevisionHistoryList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadRevisionHistoryListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves revision records.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ReadRevisionHistoryListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadRevisionHistoryListResponse
        /// </returns>
        public async Task<ReadRevisionHistoryListResponse> ReadRevisionHistoryListWithOptionsAsync(ReadRevisionHistoryListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReadRevisionHistoryListShrinkRequest request = new ReadRevisionHistoryListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageInfo))
            {
                request.PageInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageInfo, "PageInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCode))
            {
                body["CategoryCode"] = request.CategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelGroupCode))
            {
                body["ChannelGroupCode"] = request.ChannelGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageInfoShrink))
            {
                body["PageInfo"] = request.PageInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadRevisionHistoryList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadRevisionHistoryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves revision records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadRevisionHistoryListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadRevisionHistoryListResponse
        /// </returns>
        public ReadRevisionHistoryListResponse ReadRevisionHistoryList(ReadRevisionHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadRevisionHistoryListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves revision records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadRevisionHistoryListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadRevisionHistoryListResponse
        /// </returns>
        public async Task<ReadRevisionHistoryListResponse> ReadRevisionHistoryListAsync(ReadRevisionHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadRevisionHistoryListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户订阅列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadUserSubscriptionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadUserSubscriptionListResponse
        /// </returns>
        public ReadUserSubscriptionListResponse ReadUserSubscriptionListWithOptions(ReadUserSubscriptionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryGroupCode))
            {
                body["CategoryGroupCode"] = request.CategoryGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelGroupCode))
            {
                body["ChannelGroupCode"] = request.ChannelGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadUserSubscriptionList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadUserSubscriptionListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户订阅列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadUserSubscriptionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadUserSubscriptionListResponse
        /// </returns>
        public async Task<ReadUserSubscriptionListResponse> ReadUserSubscriptionListWithOptionsAsync(ReadUserSubscriptionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryGroupCode))
            {
                body["CategoryGroupCode"] = request.CategoryGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelGroupCode))
            {
                body["ChannelGroupCode"] = request.ChannelGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadUserSubscriptionList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadUserSubscriptionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户订阅列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadUserSubscriptionListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadUserSubscriptionListResponse
        /// </returns>
        public ReadUserSubscriptionListResponse ReadUserSubscriptionList(ReadUserSubscriptionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadUserSubscriptionListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户订阅列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadUserSubscriptionListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadUserSubscriptionListResponse
        /// </returns>
        public async Task<ReadUserSubscriptionListResponse> ReadUserSubscriptionListAsync(ReadUserSubscriptionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadUserSubscriptionListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadWebhookContactResponse
        /// </returns>
        public ReadWebhookContactResponse ReadWebhookContactWithOptions(ReadWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadWebhookContactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadWebhookContactResponse
        /// </returns>
        public async Task<ReadWebhookContactResponse> ReadWebhookContactWithOptionsAsync(ReadWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadWebhookContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadWebhookContactResponse
        /// </returns>
        public ReadWebhookContactResponse ReadWebhookContact(ReadWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadWebhookContactWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadWebhookContactResponse
        /// </returns>
        public async Task<ReadWebhookContactResponse> ReadWebhookContactAsync(ReadWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadWebhookContactWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of webhook send templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadWebhookContactSendTemplateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadWebhookContactSendTemplateListResponse
        /// </returns>
        public ReadWebhookContactSendTemplateListResponse ReadWebhookContactSendTemplateListWithOptions(ReadWebhookContactSendTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadWebhookContactSendTemplateList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadWebhookContactSendTemplateListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of webhook send templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadWebhookContactSendTemplateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadWebhookContactSendTemplateListResponse
        /// </returns>
        public async Task<ReadWebhookContactSendTemplateListResponse> ReadWebhookContactSendTemplateListWithOptionsAsync(ReadWebhookContactSendTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadWebhookContactSendTemplateList",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadWebhookContactSendTemplateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of webhook send templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadWebhookContactSendTemplateListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadWebhookContactSendTemplateListResponse
        /// </returns>
        public ReadWebhookContactSendTemplateListResponse ReadWebhookContactSendTemplateList(ReadWebhookContactSendTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadWebhookContactSendTemplateListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of webhook send templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadWebhookContactSendTemplateListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadWebhookContactSendTemplateListResponse
        /// </returns>
        public async Task<ReadWebhookContactSendTemplateListResponse> ReadWebhookContactSendTemplateListAsync(ReadWebhookContactSendTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadWebhookContactSendTemplateListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets user subscriptions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ResetUserSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetUserSubscriptionResponse
        /// </returns>
        public ResetUserSubscriptionResponse ResetUserSubscriptionWithOptions(ResetUserSubscriptionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResetUserSubscriptionShrinkRequest request = new ResetUserSubscriptionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryCodes))
            {
                request.CategoryCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryCodes, "CategoryCodes", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCodesShrink))
            {
                body["CategoryCodes"] = request.CategoryCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelGroupCode))
            {
                body["ChannelGroupCode"] = request.ChannelGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["Remarks"] = request.Remarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserSubscription",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets user subscriptions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ResetUserSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetUserSubscriptionResponse
        /// </returns>
        public async Task<ResetUserSubscriptionResponse> ResetUserSubscriptionWithOptionsAsync(ResetUserSubscriptionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResetUserSubscriptionShrinkRequest request = new ResetUserSubscriptionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryCodes))
            {
                request.CategoryCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryCodes, "CategoryCodes", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCodesShrink))
            {
                body["CategoryCodes"] = request.CategoryCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelGroupCode))
            {
                body["ChannelGroupCode"] = request.ChannelGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["Remarks"] = request.Remarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserSubscription",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets user subscriptions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetUserSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetUserSubscriptionResponse
        /// </returns>
        public ResetUserSubscriptionResponse ResetUserSubscription(ResetUserSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetUserSubscriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets user subscriptions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetUserSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetUserSubscriptionResponse
        /// </returns>
        public async Task<ResetUserSubscriptionResponse> ResetUserSubscriptionAsync(ResetUserSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetUserSubscriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests a webhook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TestWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestWebhookContactResponse
        /// </returns>
        public TestWebhookContactResponse TestWebhookContactWithOptions(TestWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotSecurityToken))
            {
                body["BotSecurityToken"] = request.BotSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerUrl))
            {
                body["ServerUrl"] = request.ServerUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["WebhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestWebhookContactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests a webhook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TestWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestWebhookContactResponse
        /// </returns>
        public async Task<TestWebhookContactResponse> TestWebhookContactWithOptionsAsync(TestWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotSecurityToken))
            {
                body["BotSecurityToken"] = request.BotSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerUrl))
            {
                body["ServerUrl"] = request.ServerUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["WebhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestWebhookContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests a webhook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TestWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// TestWebhookContactResponse
        /// </returns>
        public TestWebhookContactResponse TestWebhookContact(TestWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestWebhookContactWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests a webhook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TestWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// TestWebhookContactResponse
        /// </returns>
        public async Task<TestWebhookContactResponse> TestWebhookContactAsync(TestWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestWebhookContactWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新营销偏好</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMarketingPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMarketingPreferenceResponse
        /// </returns>
        public UpdateMarketingPreferenceResponse UpdateMarketingPreferenceWithOptions(UpdateMarketingPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowMarketing))
            {
                body["AllowMarketing"] = request.AllowMarketing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMarketingPreference",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMarketingPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新营销偏好</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMarketingPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMarketingPreferenceResponse
        /// </returns>
        public async Task<UpdateMarketingPreferenceResponse> UpdateMarketingPreferenceWithOptionsAsync(UpdateMarketingPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowMarketing))
            {
                body["AllowMarketing"] = request.AllowMarketing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMarketingPreference",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMarketingPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新营销偏好</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMarketingPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMarketingPreferenceResponse
        /// </returns>
        public UpdateMarketingPreferenceResponse UpdateMarketingPreference(UpdateMarketingPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMarketingPreferenceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新营销偏好</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMarketingPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMarketingPreferenceResponse
        /// </returns>
        public async Task<UpdateMarketingPreferenceResponse> UpdateMarketingPreferenceAsync(UpdateMarketingPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMarketingPreferenceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the message language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMessageLanguageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMessageLanguageResponse
        /// </returns>
        public UpdateMessageLanguageResponse UpdateMessageLanguageWithOptions(UpdateMessageLanguageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferLang))
            {
                body["PreferLang"] = request.PreferLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMessageLanguage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMessageLanguageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the message language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMessageLanguageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMessageLanguageResponse
        /// </returns>
        public async Task<UpdateMessageLanguageResponse> UpdateMessageLanguageWithOptionsAsync(UpdateMessageLanguageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferLang))
            {
                body["PreferLang"] = request.PreferLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMessageLanguage",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMessageLanguageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the message language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMessageLanguageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMessageLanguageResponse
        /// </returns>
        public UpdateMessageLanguageResponse UpdateMessageLanguage(UpdateMessageLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMessageLanguageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the message language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMessageLanguageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMessageLanguageResponse
        /// </returns>
        public async Task<UpdateMessageLanguageResponse> UpdateMessageLanguageAsync(UpdateMessageLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMessageLanguageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebhookContactResponse
        /// </returns>
        public UpdateWebhookContactResponse UpdateWebhookContactWithOptions(UpdateWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotSecurityToken))
            {
                body["BotSecurityToken"] = request.BotSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerUrl))
            {
                body["ServerUrl"] = request.ServerUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                body["VerificationCode"] = request.VerificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["WebhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebhookContactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWebhookContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebhookContactResponse
        /// </returns>
        public async Task<UpdateWebhookContactResponse> UpdateWebhookContactWithOptionsAsync(UpdateWebhookContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotSecurityToken))
            {
                body["BotSecurityToken"] = request.BotSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerProtocol))
            {
                body["CallerProtocol"] = request.CallerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSource))
            {
                body["ClientSource"] = request.ClientSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                body["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookies))
            {
                body["Cookies"] = request.Cookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerUrl))
            {
                body["ServerUrl"] = request.ServerUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUrl))
            {
                body["SrcUrl"] = request.SrcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantCode))
            {
                body["TenantCode"] = request.TenantCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UidType))
            {
                body["UidType"] = request.UidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationCode))
            {
                body["VerificationCode"] = request.VerificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookType))
            {
                body["WebhookType"] = request.WebhookType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebhookContact",
                Version = "2024-12-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebhookContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebhookContactResponse
        /// </returns>
        public UpdateWebhookContactResponse UpdateWebhookContact(UpdateWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWebhookContactWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a webhook contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWebhookContactRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebhookContactResponse
        /// </returns>
        public async Task<UpdateWebhookContactResponse> UpdateWebhookContactAsync(UpdateWebhookContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWebhookContactWithOptionsAsync(request, runtime);
        }

    }
}
