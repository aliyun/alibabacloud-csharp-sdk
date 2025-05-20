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
            this._endpointRule = "";
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
        /// <para>方法描述：删除消息</para>
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
        /// <para>方法描述：删除消息</para>
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
        /// <para>方法描述：删除消息</para>
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
        /// <para>方法描述：删除消息</para>
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
        /// <para>方法描述：站内信全部删除（逻辑删除）</para>
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
        /// <para>方法描述：站内信全部删除（逻辑删除）</para>
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
        /// <para>方法描述：站内信全部删除（逻辑删除）</para>
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
        /// <para>方法描述：站内信全部删除（逻辑删除）</para>
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
        /// <para>方法描述：分类全部标记为已读，不填则全部标记</para>
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
        /// <para>方法描述：分类全部标记为已读，不填则全部标记</para>
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
        /// <para>方法描述：分类全部标记为已读，不填则全部标记</para>
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
        /// <para>方法描述：分类全部标记为已读，不填则全部标记</para>
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
        /// <para>方法描述：获取各分类已读消息数</para>
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
        /// <para>方法描述：获取各分类已读消息数</para>
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
        /// <para>方法描述：获取各分类已读消息数</para>
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
        /// <para>方法描述：获取各分类已读消息数</para>
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
        /// <para>方法描述：消息标记为已读</para>
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
        /// <para>方法描述：消息标记为已读</para>
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
        /// <para>方法描述：消息标记为已读</para>
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
        /// <para>方法描述：消息标记为已读</para>
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
        /// <para>方法描述：获取消息正文</para>
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
        /// <para>方法描述：获取消息正文</para>
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
        /// <para>方法描述：获取消息正文</para>
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
        /// <para>方法描述：获取消息正文</para>
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
        /// <para>方法描述：获取消息列表</para>
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
        /// <para>方法描述：获取消息列表</para>
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
        /// <para>方法描述：获取消息列表</para>
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
        /// <para>方法描述：获取消息列表</para>
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
        /// <para>方法描述：获取未读消息总数</para>
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
        /// <para>方法描述：获取未读消息总数</para>
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
        /// <para>方法描述：获取未读消息总数</para>
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
        /// <para>方法描述：获取未读消息总数</para>
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
        /// <para>方法描述：获取各分类已读消息数</para>
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
        /// <para>方法描述：获取各分类已读消息数</para>
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
        /// <para>方法描述：获取各分类已读消息数</para>
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
        /// <para>方法描述：获取各分类已读消息数</para>
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
        /// <para>方法描述：获取所有分类下的信息</para>
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
        /// <para>方法描述：获取所有分类下的信息</para>
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
        /// <para>方法描述：获取所有分类下的信息</para>
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
        /// <para>方法描述：获取所有分类下的信息</para>
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

    }
}
