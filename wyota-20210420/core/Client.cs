// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Wyota20210420.Models;

namespace AlibabaCloud.SDK.Wyota20210420
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("wyota", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalResponse
        /// </returns>
        public AddTerminalResponse AddTerminalWithOptions(AddTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
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
                Action = "AddTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalResponse
        /// </returns>
        public async Task<AddTerminalResponse> AddTerminalWithOptionsAsync(AddTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
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
                Action = "AddTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalResponse
        /// </returns>
        public AddTerminalResponse AddTerminal(AddTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTerminalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalResponse
        /// </returns>
        public async Task<AddTerminalResponse> AddTerminalAsync(AddTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTerminalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalsResponse
        /// </returns>
        public AddTerminalsResponse AddTerminalsWithOptions(AddTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTerminalParams))
            {
                bodyFlat["AddTerminalParams"] = request.AddTerminalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalsResponse
        /// </returns>
        public async Task<AddTerminalsResponse> AddTerminalsWithOptionsAsync(AddTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTerminalParams))
            {
                bodyFlat["AddTerminalParams"] = request.AddTerminalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalsResponse
        /// </returns>
        public AddTerminalsResponse AddTerminals(AddTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTerminalsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalsResponse
        /// </returns>
        public async Task<AddTerminalsResponse> AddTerminalsAsync(AddTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTerminalsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountLessLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAccountLessLoginUserResponse
        /// </returns>
        public BindAccountLessLoginUserResponse BindAccountLessLoginUserWithOptions(BindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
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
                Action = "BindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountLessLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountLessLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAccountLessLoginUserResponse
        /// </returns>
        public async Task<BindAccountLessLoginUserResponse> BindAccountLessLoginUserWithOptionsAsync(BindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
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
                Action = "BindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountLessLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountLessLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAccountLessLoginUserResponse
        /// </returns>
        public BindAccountLessLoginUserResponse BindAccountLessLoginUser(BindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAccountLessLoginUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountLessLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAccountLessLoginUserResponse
        /// </returns>
        public async Task<BindAccountLessLoginUserResponse> BindAccountLessLoginUserAsync(BindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAccountLessLoginUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPasswordFreeLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindPasswordFreeLoginUserResponse
        /// </returns>
        public BindPasswordFreeLoginUserResponse BindPasswordFreeLoginUserWithOptions(BindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
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
                Action = "BindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPasswordFreeLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPasswordFreeLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindPasswordFreeLoginUserResponse
        /// </returns>
        public async Task<BindPasswordFreeLoginUserResponse> BindPasswordFreeLoginUserWithOptionsAsync(BindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
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
                Action = "BindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPasswordFreeLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPasswordFreeLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BindPasswordFreeLoginUserResponse
        /// </returns>
        public BindPasswordFreeLoginUserResponse BindPasswordFreeLoginUser(BindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindPasswordFreeLoginUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPasswordFreeLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BindPasswordFreeLoginUserResponse
        /// </returns>
        public async Task<BindPasswordFreeLoginUserResponse> BindPasswordFreeLoginUserAsync(BindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindPasswordFreeLoginUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates dedicated terminal management invitation codes for one or more users under the current Alibaba Cloud account, generates an eight-digit code for each user, and uniformly specifies the terminal group and validity period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation over HTTPS POST, sign the request with an AccessKey pair or STS credentials, and grant the ecd:CreateUserInvitationCode permission. You can only create management codes for users and terminal groups that belong to the Alibaba Cloud account of the caller identity.</description></item>
        /// <item><description>You must specify either EndUserIds or the single-user compatible parameter EndUserId. Batch requests support 1 to 100 users. An independent eight-digit management code is generated for each user. Empty items or duplicate users are not supported.</description></item>
        /// <item><description>Users in a single request share the same TerminalGroupId and ValidityMinutes. Repeated calls can create multiple different management codes for the same user.</description></item>
        /// <item><description>Both users and groups must already exist and belong to the current account. The group cannot be in a deleted state. After parameter and user validation passes, the entire batch is written. The system does not create codes user by user and return partial results.</description></item>
        /// <item><description>A management code is a terminal redemption credential. Provide it to the corresponding user only through trusted channels and avoid recording the complete code in public logs.</description></item>
        /// <item><description>The returned Data is always an array, even if only one code is created, in which case it is a single-element array. Creating a code does not mean that the terminal has completed management. A UUID and binding time are generated only after the device uses the code to complete management.</description></item>
        /// <item><description>Status indicates only the usage status: ACTIVE means unused, and USED means used. To determine whether a code has expired, refer to the Expired field returned by the server. The EXPIRED status is not used.</description></item>
        /// <item><description>This operation does not have a ClientToken parameter for business idempotence. Resending a creation request may generate a new management code. If you encounter uncertain results such as timeouts, check whether the code has been created before retrying unconditionally.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserInvitationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserInvitationCodeResponse
        /// </returns>
        public CreateUserInvitationCodeResponse CreateUserInvitationCodeWithOptions(CreateUserInvitationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                body["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityMinutes))
            {
                body["ValidityMinutes"] = request.ValidityMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserInvitationCode",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserInvitationCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates dedicated terminal management invitation codes for one or more users under the current Alibaba Cloud account, generates an eight-digit code for each user, and uniformly specifies the terminal group and validity period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation over HTTPS POST, sign the request with an AccessKey pair or STS credentials, and grant the ecd:CreateUserInvitationCode permission. You can only create management codes for users and terminal groups that belong to the Alibaba Cloud account of the caller identity.</description></item>
        /// <item><description>You must specify either EndUserIds or the single-user compatible parameter EndUserId. Batch requests support 1 to 100 users. An independent eight-digit management code is generated for each user. Empty items or duplicate users are not supported.</description></item>
        /// <item><description>Users in a single request share the same TerminalGroupId and ValidityMinutes. Repeated calls can create multiple different management codes for the same user.</description></item>
        /// <item><description>Both users and groups must already exist and belong to the current account. The group cannot be in a deleted state. After parameter and user validation passes, the entire batch is written. The system does not create codes user by user and return partial results.</description></item>
        /// <item><description>A management code is a terminal redemption credential. Provide it to the corresponding user only through trusted channels and avoid recording the complete code in public logs.</description></item>
        /// <item><description>The returned Data is always an array, even if only one code is created, in which case it is a single-element array. Creating a code does not mean that the terminal has completed management. A UUID and binding time are generated only after the device uses the code to complete management.</description></item>
        /// <item><description>Status indicates only the usage status: ACTIVE means unused, and USED means used. To determine whether a code has expired, refer to the Expired field returned by the server. The EXPIRED status is not used.</description></item>
        /// <item><description>This operation does not have a ClientToken parameter for business idempotence. Resending a creation request may generate a new management code. If you encounter uncertain results such as timeouts, check whether the code has been created before retrying unconditionally.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserInvitationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserInvitationCodeResponse
        /// </returns>
        public async Task<CreateUserInvitationCodeResponse> CreateUserInvitationCodeWithOptionsAsync(CreateUserInvitationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                body["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityMinutes))
            {
                body["ValidityMinutes"] = request.ValidityMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserInvitationCode",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserInvitationCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates dedicated terminal management invitation codes for one or more users under the current Alibaba Cloud account, generates an eight-digit code for each user, and uniformly specifies the terminal group and validity period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation over HTTPS POST, sign the request with an AccessKey pair or STS credentials, and grant the ecd:CreateUserInvitationCode permission. You can only create management codes for users and terminal groups that belong to the Alibaba Cloud account of the caller identity.</description></item>
        /// <item><description>You must specify either EndUserIds or the single-user compatible parameter EndUserId. Batch requests support 1 to 100 users. An independent eight-digit management code is generated for each user. Empty items or duplicate users are not supported.</description></item>
        /// <item><description>Users in a single request share the same TerminalGroupId and ValidityMinutes. Repeated calls can create multiple different management codes for the same user.</description></item>
        /// <item><description>Both users and groups must already exist and belong to the current account. The group cannot be in a deleted state. After parameter and user validation passes, the entire batch is written. The system does not create codes user by user and return partial results.</description></item>
        /// <item><description>A management code is a terminal redemption credential. Provide it to the corresponding user only through trusted channels and avoid recording the complete code in public logs.</description></item>
        /// <item><description>The returned Data is always an array, even if only one code is created, in which case it is a single-element array. Creating a code does not mean that the terminal has completed management. A UUID and binding time are generated only after the device uses the code to complete management.</description></item>
        /// <item><description>Status indicates only the usage status: ACTIVE means unused, and USED means used. To determine whether a code has expired, refer to the Expired field returned by the server. The EXPIRED status is not used.</description></item>
        /// <item><description>This operation does not have a ClientToken parameter for business idempotence. Resending a creation request may generate a new management code. If you encounter uncertain results such as timeouts, check whether the code has been created before retrying unconditionally.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserInvitationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserInvitationCodeResponse
        /// </returns>
        public CreateUserInvitationCodeResponse CreateUserInvitationCode(CreateUserInvitationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserInvitationCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates dedicated terminal management invitation codes for one or more users under the current Alibaba Cloud account, generates an eight-digit code for each user, and uniformly specifies the terminal group and validity period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation over HTTPS POST, sign the request with an AccessKey pair or STS credentials, and grant the ecd:CreateUserInvitationCode permission. You can only create management codes for users and terminal groups that belong to the Alibaba Cloud account of the caller identity.</description></item>
        /// <item><description>You must specify either EndUserIds or the single-user compatible parameter EndUserId. Batch requests support 1 to 100 users. An independent eight-digit management code is generated for each user. Empty items or duplicate users are not supported.</description></item>
        /// <item><description>Users in a single request share the same TerminalGroupId and ValidityMinutes. Repeated calls can create multiple different management codes for the same user.</description></item>
        /// <item><description>Both users and groups must already exist and belong to the current account. The group cannot be in a deleted state. After parameter and user validation passes, the entire batch is written. The system does not create codes user by user and return partial results.</description></item>
        /// <item><description>A management code is a terminal redemption credential. Provide it to the corresponding user only through trusted channels and avoid recording the complete code in public logs.</description></item>
        /// <item><description>The returned Data is always an array, even if only one code is created, in which case it is a single-element array. Creating a code does not mean that the terminal has completed management. A UUID and binding time are generated only after the device uses the code to complete management.</description></item>
        /// <item><description>Status indicates only the usage status: ACTIVE means unused, and USED means used. To determine whether a code has expired, refer to the Expired field returned by the server. The EXPIRED status is not used.</description></item>
        /// <item><description>This operation does not have a ClientToken parameter for business idempotence. Resending a creation request may generate a new management code. If you encounter uncertain results such as timeouts, check whether the code has been created before retrying unconditionally.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserInvitationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserInvitationCodeResponse
        /// </returns>
        public async Task<CreateUserInvitationCodeResponse> CreateUserInvitationCodeAsync(CreateUserInvitationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserInvitationCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes managed terminal devices by UUID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientsResponse
        /// </returns>
        public DeleteClientsResponse DeleteClientsWithOptions(DeleteClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerAliUid))
            {
                query["CallerAliUid"] = request.CallerAliUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClients",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes managed terminal devices by UUID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientsResponse
        /// </returns>
        public async Task<DeleteClientsResponse> DeleteClientsWithOptionsAsync(DeleteClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerAliUid))
            {
                query["CallerAliUid"] = request.CallerAliUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClients",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes managed terminal devices by UUID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientsResponse
        /// </returns>
        public DeleteClientsResponse DeleteClients(DeleteClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes managed terminal devices by UUID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientsResponse
        /// </returns>
        public async Task<DeleteClientsResponse> DeleteClientsAsync(DeleteClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all managed clients.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientsResponse
        /// </returns>
        public DescribeClientsResponse DescribeClientsWithOptions(DescribeClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerAliUid))
            {
                query["CallerAliUid"] = request.CallerAliUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomResourceId))
            {
                body["CustomResourceId"] = request.CustomResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomResourceStatus))
            {
                body["CustomResourceStatus"] = request.CustomResourceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSubGroups))
            {
                body["IncludeSubGroups"] = request.IncludeSubGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineStatus))
            {
                body["OnlineStatus"] = request.OnlineStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithBindUser))
            {
                body["WithBindUser"] = request.WithBindUser;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClients",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all managed clients.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientsResponse
        /// </returns>
        public async Task<DescribeClientsResponse> DescribeClientsWithOptionsAsync(DescribeClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerAliUid))
            {
                query["CallerAliUid"] = request.CallerAliUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomResourceId))
            {
                body["CustomResourceId"] = request.CustomResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomResourceStatus))
            {
                body["CustomResourceStatus"] = request.CustomResourceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSubGroups))
            {
                body["IncludeSubGroups"] = request.IncludeSubGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineStatus))
            {
                body["OnlineStatus"] = request.OnlineStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithBindUser))
            {
                body["WithBindUser"] = request.WithBindUser;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClients",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all managed clients.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientsResponse
        /// </returns>
        public DescribeClientsResponse DescribeClients(DescribeClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all managed clients.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientsResponse
        /// </returns>
        public async Task<DescribeClientsResponse> DescribeClientsAsync(DescribeClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves custom resource statistics information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomResourceStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomResourceStatsResponse
        /// </returns>
        public GetCustomResourceStatsResponse GetCustomResourceStatsWithOptions(GetCustomResourceStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomResourceStats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomResourceStatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves custom resource statistics information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomResourceStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomResourceStatsResponse
        /// </returns>
        public async Task<GetCustomResourceStatsResponse> GetCustomResourceStatsWithOptionsAsync(GetCustomResourceStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomResourceStats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomResourceStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves custom resource statistics information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomResourceStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomResourceStatsResponse
        /// </returns>
        public GetCustomResourceStatsResponse GetCustomResourceStats(GetCustomResourceStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomResourceStatsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves custom resource statistics information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomResourceStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomResourceStatsResponse
        /// </returns>
        public async Task<GetCustomResourceStatsResponse> GetCustomResourceStatsAsync(GetCustomResourceStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomResourceStatsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves or creates an invitation code for desktop device enrollment.
        /// Query mode: Pass only terminalGroupId to return the current invitation code and its expiration status in read-only mode.
        /// Creation mode: Pass terminalGroupId along with an expiration duration (expireDays or expireMinutes) to generate a new code that overwrites the existing invitation code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrCreateInvitationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrCreateInvitationCodeResponse
        /// </returns>
        public GetOrCreateInvitationCodeResponse GetOrCreateInvitationCodeWithOptions(GetOrCreateInvitationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDays))
            {
                body["ExpireDays"] = request.ExpireDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMinutes))
            {
                body["ExpireMinutes"] = request.ExpireMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrCreateInvitationCode",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrCreateInvitationCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves or creates an invitation code for desktop device enrollment.
        /// Query mode: Pass only terminalGroupId to return the current invitation code and its expiration status in read-only mode.
        /// Creation mode: Pass terminalGroupId along with an expiration duration (expireDays or expireMinutes) to generate a new code that overwrites the existing invitation code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrCreateInvitationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrCreateInvitationCodeResponse
        /// </returns>
        public async Task<GetOrCreateInvitationCodeResponse> GetOrCreateInvitationCodeWithOptionsAsync(GetOrCreateInvitationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDays))
            {
                body["ExpireDays"] = request.ExpireDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMinutes))
            {
                body["ExpireMinutes"] = request.ExpireMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrCreateInvitationCode",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrCreateInvitationCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves or creates an invitation code for desktop device enrollment.
        /// Query mode: Pass only terminalGroupId to return the current invitation code and its expiration status in read-only mode.
        /// Creation mode: Pass terminalGroupId along with an expiration duration (expireDays or expireMinutes) to generate a new code that overwrites the existing invitation code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrCreateInvitationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrCreateInvitationCodeResponse
        /// </returns>
        public GetOrCreateInvitationCodeResponse GetOrCreateInvitationCode(GetOrCreateInvitationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrCreateInvitationCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves or creates an invitation code for desktop device enrollment.
        /// Query mode: Pass only terminalGroupId to return the current invitation code and its expiration status in read-only mode.
        /// Creation mode: Pass terminalGroupId along with an expiration duration (expireDays or expireMinutes) to generate a new code that overwrites the existing invitation code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrCreateInvitationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrCreateInvitationCodeResponse
        /// </returns>
        public async Task<GetOrCreateInvitationCodeResponse> GetOrCreateInvitationCodeAsync(GetOrCreateInvitationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrCreateInvitationCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of terminals.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTerminalCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTerminalCountResponse
        /// </returns>
        public GetTerminalCountResponse GetTerminalCountWithOptions(GetTerminalCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTerminalCount",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTerminalCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of terminals.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTerminalCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTerminalCountResponse
        /// </returns>
        public async Task<GetTerminalCountResponse> GetTerminalCountWithOptionsAsync(GetTerminalCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTerminalCount",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTerminalCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of terminals.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTerminalCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTerminalCountResponse
        /// </returns>
        public GetTerminalCountResponse GetTerminalCount(GetTerminalCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTerminalCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of terminals.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTerminalCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTerminalCountResponse
        /// </returns>
        public async Task<GetTerminalCountResponse> GetTerminalCountAsync(GetTerminalCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTerminalCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTerminalResponse
        /// </returns>
        public ListTerminalResponse ListTerminalWithOptions(ListTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv4))
            {
                body["Ipv4"] = request.Ipv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationInfo))
            {
                body["LocationInfo"] = request.LocationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
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
                Action = "ListTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerminalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTerminalResponse
        /// </returns>
        public async Task<ListTerminalResponse> ListTerminalWithOptionsAsync(ListTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv4))
            {
                body["Ipv4"] = request.Ipv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationInfo))
            {
                body["LocationInfo"] = request.LocationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
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
                Action = "ListTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTerminalResponse
        /// </returns>
        public ListTerminalResponse ListTerminal(ListTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTerminalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTerminalResponse
        /// </returns>
        public async Task<ListTerminalResponse> ListTerminalAsync(ListTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTerminalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version distribution of terminals.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVersionDistributionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVersionDistributionResponse
        /// </returns>
        public ListVersionDistributionResponse ListVersionDistributionWithOptions(ListVersionDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                body["VersionType"] = request.VersionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVersionDistribution",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVersionDistributionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version distribution of terminals.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVersionDistributionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVersionDistributionResponse
        /// </returns>
        public async Task<ListVersionDistributionResponse> ListVersionDistributionWithOptionsAsync(ListVersionDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                body["VersionType"] = request.VersionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVersionDistribution",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVersionDistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version distribution of terminals.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVersionDistributionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVersionDistributionResponse
        /// </returns>
        public ListVersionDistributionResponse ListVersionDistribution(ListVersionDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVersionDistributionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version distribution of terminals.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVersionDistributionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVersionDistributionResponse
        /// </returns>
        public async Task<ListVersionDistributionResponse> ListVersionDistributionAsync(ListVersionDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVersionDistributionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向终端发送运维命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalsResponse
        /// </returns>
        public SendOpsMessageToTerminalsResponse SendOpsMessageToTerminalsWithOptions(SendOpsMessageToTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                query["Delay"] = request.Delay;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["Msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpDomain))
            {
                body["OpDomain"] = request.OpDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsAction))
            {
                body["OpsAction"] = request.OpsAction;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForAck))
            {
                body["WaitForAck"] = request.WaitForAck;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendOpsMessageToTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOpsMessageToTerminalsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向终端发送运维命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalsResponse
        /// </returns>
        public async Task<SendOpsMessageToTerminalsResponse> SendOpsMessageToTerminalsWithOptionsAsync(SendOpsMessageToTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                query["Delay"] = request.Delay;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["Msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpDomain))
            {
                body["OpDomain"] = request.OpDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsAction))
            {
                body["OpsAction"] = request.OpsAction;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForAck))
            {
                body["WaitForAck"] = request.WaitForAck;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendOpsMessageToTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOpsMessageToTerminalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向终端发送运维命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalsResponse
        /// </returns>
        public SendOpsMessageToTerminalsResponse SendOpsMessageToTerminals(SendOpsMessageToTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendOpsMessageToTerminalsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向终端发送运维命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalsResponse
        /// </returns>
        public async Task<SendOpsMessageToTerminalsResponse> SendOpsMessageToTerminalsAsync(SendOpsMessageToTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendOpsMessageToTerminalsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAccountLessLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAccountLessLoginUserResponse
        /// </returns>
        public UnbindAccountLessLoginUserResponse UnbindAccountLessLoginUserWithOptions(UnbindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
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
                Action = "UnbindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAccountLessLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAccountLessLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAccountLessLoginUserResponse
        /// </returns>
        public async Task<UnbindAccountLessLoginUserResponse> UnbindAccountLessLoginUserWithOptionsAsync(UnbindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
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
                Action = "UnbindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAccountLessLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAccountLessLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAccountLessLoginUserResponse
        /// </returns>
        public UnbindAccountLessLoginUserResponse UnbindAccountLessLoginUser(UnbindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAccountLessLoginUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAccountLessLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAccountLessLoginUserResponse
        /// </returns>
        public async Task<UnbindAccountLessLoginUserResponse> UnbindAccountLessLoginUserAsync(UnbindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAccountLessLoginUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免密登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPasswordFreeLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindPasswordFreeLoginUserResponse
        /// </returns>
        public UnbindPasswordFreeLoginUserResponse UnbindPasswordFreeLoginUserWithOptions(UnbindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
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
                Action = "UnbindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPasswordFreeLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免密登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPasswordFreeLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindPasswordFreeLoginUserResponse
        /// </returns>
        public async Task<UnbindPasswordFreeLoginUserResponse> UnbindPasswordFreeLoginUserWithOptionsAsync(UnbindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
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
                Action = "UnbindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPasswordFreeLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免密登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPasswordFreeLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindPasswordFreeLoginUserResponse
        /// </returns>
        public UnbindPasswordFreeLoginUserResponse UnbindPasswordFreeLoginUser(UnbindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindPasswordFreeLoginUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免密登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPasswordFreeLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindPasswordFreeLoginUserResponse
        /// </returns>
        public async Task<UnbindPasswordFreeLoginUserResponse> UnbindPasswordFreeLoginUserAsync(UnbindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindPasswordFreeLoginUserWithOptionsAsync(request, runtime);
        }

    }
}
