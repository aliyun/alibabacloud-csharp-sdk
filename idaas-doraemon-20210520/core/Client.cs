// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Idaas_doraemon20210520.Models;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "idaas-doraemon.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("idaas-doraemon", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 创建认证器请求
         *
         * @param request CreateAuthenticatorRegistrationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAuthenticatorRegistrationResponse
         */
        public CreateAuthenticatorRegistrationResponse CreateAuthenticatorRegistrationWithOptions(CreateAuthenticatorRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJson))
            {
                query["ClientExtendParamsJson"] = request.ClientExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJsonSign))
            {
                query["ClientExtendParamsJsonSign"] = request.ClientExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationContext))
            {
                query["RegistrationContext"] = request.RegistrationContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDisplayName))
            {
                query["UserDisplayName"] = request.UserDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
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
                Action = "CreateAuthenticatorRegistration",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuthenticatorRegistrationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建认证器请求
         *
         * @param request CreateAuthenticatorRegistrationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAuthenticatorRegistrationResponse
         */
        public async Task<CreateAuthenticatorRegistrationResponse> CreateAuthenticatorRegistrationWithOptionsAsync(CreateAuthenticatorRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJson))
            {
                query["ClientExtendParamsJson"] = request.ClientExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJsonSign))
            {
                query["ClientExtendParamsJsonSign"] = request.ClientExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationContext))
            {
                query["RegistrationContext"] = request.RegistrationContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDisplayName))
            {
                query["UserDisplayName"] = request.UserDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
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
                Action = "CreateAuthenticatorRegistration",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuthenticatorRegistrationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建认证器请求
         *
         * @param request CreateAuthenticatorRegistrationRequest
         * @return CreateAuthenticatorRegistrationResponse
         */
        public CreateAuthenticatorRegistrationResponse CreateAuthenticatorRegistration(CreateAuthenticatorRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuthenticatorRegistrationWithOptions(request, runtime);
        }

        /**
         * @summary 创建认证器请求
         *
         * @param request CreateAuthenticatorRegistrationRequest
         * @return CreateAuthenticatorRegistrationResponse
         */
        public async Task<CreateAuthenticatorRegistrationResponse> CreateAuthenticatorRegistrationAsync(CreateAuthenticatorRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuthenticatorRegistrationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建用户认证请求
         *
         * @param request CreateUserAuthenticateOptionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserAuthenticateOptionsResponse
         */
        public CreateUserAuthenticateOptionsResponse CreateUserAuthenticateOptionsWithOptions(CreateUserAuthenticateOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindHashBase64))
            {
                query["BindHashBase64"] = request.BindHashBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJson))
            {
                query["ClientExtendParamsJson"] = request.ClientExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJsonSign))
            {
                query["ClientExtendParamsJsonSign"] = request.ClientExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
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
                Action = "CreateUserAuthenticateOptions",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserAuthenticateOptionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建用户认证请求
         *
         * @param request CreateUserAuthenticateOptionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserAuthenticateOptionsResponse
         */
        public async Task<CreateUserAuthenticateOptionsResponse> CreateUserAuthenticateOptionsWithOptionsAsync(CreateUserAuthenticateOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindHashBase64))
            {
                query["BindHashBase64"] = request.BindHashBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJson))
            {
                query["ClientExtendParamsJson"] = request.ClientExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJsonSign))
            {
                query["ClientExtendParamsJsonSign"] = request.ClientExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
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
                Action = "CreateUserAuthenticateOptions",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserAuthenticateOptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建用户认证请求
         *
         * @param request CreateUserAuthenticateOptionsRequest
         * @return CreateUserAuthenticateOptionsResponse
         */
        public CreateUserAuthenticateOptionsResponse CreateUserAuthenticateOptions(CreateUserAuthenticateOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserAuthenticateOptionsWithOptions(request, runtime);
        }

        /**
         * @summary 创建用户认证请求
         *
         * @param request CreateUserAuthenticateOptionsRequest
         * @return CreateUserAuthenticateOptionsResponse
         */
        public async Task<CreateUserAuthenticateOptionsResponse> CreateUserAuthenticateOptionsAsync(CreateUserAuthenticateOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserAuthenticateOptionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除认证器
         *
         * @param request DeregisterAuthenticatorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeregisterAuthenticatorResponse
         */
        public DeregisterAuthenticatorResponse DeregisterAuthenticatorWithOptions(DeregisterAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
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
                Action = "DeregisterAuthenticator",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterAuthenticatorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除认证器
         *
         * @param request DeregisterAuthenticatorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeregisterAuthenticatorResponse
         */
        public async Task<DeregisterAuthenticatorResponse> DeregisterAuthenticatorWithOptionsAsync(DeregisterAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
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
                Action = "DeregisterAuthenticator",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterAuthenticatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除认证器
         *
         * @param request DeregisterAuthenticatorRequest
         * @return DeregisterAuthenticatorResponse
         */
        public DeregisterAuthenticatorResponse DeregisterAuthenticator(DeregisterAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeregisterAuthenticatorWithOptions(request, runtime);
        }

        /**
         * @summary 删除认证器
         *
         * @param request DeregisterAuthenticatorRequest
         * @return DeregisterAuthenticatorResponse
         */
        public async Task<DeregisterAuthenticatorResponse> DeregisterAuthenticatorAsync(DeregisterAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeregisterAuthenticatorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取access_token
         *
         * @param request FetchAccessTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchAccessTokenResponse
         */
        public FetchAccessTokenResponse FetchAccessTokenWithOptions(FetchAccessTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileExtendParamsJson))
            {
                query["MobileExtendParamsJson"] = request.MobileExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileExtendParamsJsonSign))
            {
                query["MobileExtendParamsJsonSign"] = request.MobileExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XClientIp))
            {
                query["XClientIp"] = request.XClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchAccessToken",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchAccessTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取access_token
         *
         * @param request FetchAccessTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchAccessTokenResponse
         */
        public async Task<FetchAccessTokenResponse> FetchAccessTokenWithOptionsAsync(FetchAccessTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileExtendParamsJson))
            {
                query["MobileExtendParamsJson"] = request.MobileExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileExtendParamsJsonSign))
            {
                query["MobileExtendParamsJsonSign"] = request.MobileExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XClientIp))
            {
                query["XClientIp"] = request.XClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchAccessToken",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchAccessTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取access_token
         *
         * @param request FetchAccessTokenRequest
         * @return FetchAccessTokenResponse
         */
        public FetchAccessTokenResponse FetchAccessToken(FetchAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchAccessTokenWithOptions(request, runtime);
        }

        /**
         * @summary 获取access_token
         *
         * @param request FetchAccessTokenRequest
         * @return FetchAccessTokenResponse
         */
        public async Task<FetchAccessTokenResponse> FetchAccessTokenAsync(FetchAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchAccessTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询单个认证器
         *
         * @param request GetAuthenticatorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAuthenticatorResponse
         */
        public GetAuthenticatorResponse GetAuthenticatorWithOptions(GetAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
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
                Action = "GetAuthenticator",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthenticatorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询单个认证器
         *
         * @param request GetAuthenticatorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAuthenticatorResponse
         */
        public async Task<GetAuthenticatorResponse> GetAuthenticatorWithOptionsAsync(GetAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
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
                Action = "GetAuthenticator",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthenticatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询单个认证器
         *
         * @param request GetAuthenticatorRequest
         * @return GetAuthenticatorResponse
         */
        public GetAuthenticatorResponse GetAuthenticator(GetAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuthenticatorWithOptions(request, runtime);
        }

        /**
         * @summary 查询单个认证器
         *
         * @param request GetAuthenticatorRequest
         * @return GetAuthenticatorResponse
         */
        public async Task<GetAuthenticatorResponse> GetAuthenticatorAsync(GetAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuthenticatorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列表查询认证事件日志
         *
         * @param request ListAuthenticationLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthenticationLogsResponse
         */
        public ListAuthenticationLogsResponse ListAuthenticationLogsWithOptions(ListAuthenticationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                query["CredentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                query["FromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTag))
            {
                query["LogTag"] = request.LogTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                query["ToTime"] = request.ToTime;
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
                Action = "ListAuthenticationLogs",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthenticationLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列表查询认证事件日志
         *
         * @param request ListAuthenticationLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthenticationLogsResponse
         */
        public async Task<ListAuthenticationLogsResponse> ListAuthenticationLogsWithOptionsAsync(ListAuthenticationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                query["CredentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                query["FromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTag))
            {
                query["LogTag"] = request.LogTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                query["ToTime"] = request.ToTime;
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
                Action = "ListAuthenticationLogs",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthenticationLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列表查询认证事件日志
         *
         * @param request ListAuthenticationLogsRequest
         * @return ListAuthenticationLogsResponse
         */
        public ListAuthenticationLogsResponse ListAuthenticationLogs(ListAuthenticationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthenticationLogsWithOptions(request, runtime);
        }

        /**
         * @summary 列表查询认证事件日志
         *
         * @param request ListAuthenticationLogsRequest
         * @return ListAuthenticationLogsResponse
         */
        public async Task<ListAuthenticationLogsResponse> ListAuthenticationLogsAsync(ListAuthenticationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthenticationLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列表查询认证器操作日志
         *
         * @param request ListAuthenticatorOpsLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthenticatorOpsLogsResponse
         */
        public ListAuthenticatorOpsLogsResponse ListAuthenticatorOpsLogsWithOptions(ListAuthenticatorOpsLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                query["FromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                query["ToTime"] = request.ToTime;
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
                Action = "ListAuthenticatorOpsLogs",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthenticatorOpsLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列表查询认证器操作日志
         *
         * @param request ListAuthenticatorOpsLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthenticatorOpsLogsResponse
         */
        public async Task<ListAuthenticatorOpsLogsResponse> ListAuthenticatorOpsLogsWithOptionsAsync(ListAuthenticatorOpsLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                query["FromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                query["ToTime"] = request.ToTime;
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
                Action = "ListAuthenticatorOpsLogs",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthenticatorOpsLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列表查询认证器操作日志
         *
         * @param request ListAuthenticatorOpsLogsRequest
         * @return ListAuthenticatorOpsLogsResponse
         */
        public ListAuthenticatorOpsLogsResponse ListAuthenticatorOpsLogs(ListAuthenticatorOpsLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthenticatorOpsLogsWithOptions(request, runtime);
        }

        /**
         * @summary 列表查询认证器操作日志
         *
         * @param request ListAuthenticatorOpsLogsRequest
         * @return ListAuthenticatorOpsLogsResponse
         */
        public async Task<ListAuthenticatorOpsLogsResponse> ListAuthenticatorOpsLogsAsync(ListAuthenticatorOpsLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthenticatorOpsLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列表查询认证器
         *
         * @param request ListAuthenticatorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthenticatorsResponse
         */
        public ListAuthenticatorsResponse ListAuthenticatorsWithOptions(ListAuthenticatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListAuthenticators",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthenticatorsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列表查询认证器
         *
         * @param request ListAuthenticatorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthenticatorsResponse
         */
        public async Task<ListAuthenticatorsResponse> ListAuthenticatorsWithOptionsAsync(ListAuthenticatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListAuthenticators",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthenticatorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列表查询认证器
         *
         * @param request ListAuthenticatorsRequest
         * @return ListAuthenticatorsResponse
         */
        public ListAuthenticatorsResponse ListAuthenticators(ListAuthenticatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthenticatorsWithOptions(request, runtime);
        }

        /**
         * @summary 列表查询认证器
         *
         * @param request ListAuthenticatorsRequest
         * @return ListAuthenticatorsResponse
         */
        public async Task<ListAuthenticatorsResponse> ListAuthenticatorsAsync(ListAuthenticatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthenticatorsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询按量计费订单列表
         *
         * @param request ListCostUnitOrdersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCostUnitOrdersResponse
         */
        public ListCostUnitOrdersResponse ListCostUnitOrdersWithOptions(ListCostUnitOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginDate))
            {
                query["BeginDate"] = request.BeginDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalDate))
            {
                query["FinalDate"] = request.FinalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCostUnitOrders",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCostUnitOrdersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询按量计费订单列表
         *
         * @param request ListCostUnitOrdersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCostUnitOrdersResponse
         */
        public async Task<ListCostUnitOrdersResponse> ListCostUnitOrdersWithOptionsAsync(ListCostUnitOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginDate))
            {
                query["BeginDate"] = request.BeginDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalDate))
            {
                query["FinalDate"] = request.FinalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCostUnitOrders",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCostUnitOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询按量计费订单列表
         *
         * @param request ListCostUnitOrdersRequest
         * @return ListCostUnitOrdersResponse
         */
        public ListCostUnitOrdersResponse ListCostUnitOrders(ListCostUnitOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCostUnitOrdersWithOptions(request, runtime);
        }

        /**
         * @summary 查询按量计费订单列表
         *
         * @param request ListCostUnitOrdersRequest
         * @return ListCostUnitOrdersResponse
         */
        public async Task<ListCostUnitOrdersResponse> ListCostUnitOrdersAsync(ListCostUnitOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCostUnitOrdersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用量消费统计记录列表
         *
         * @param request ListOrderConsumeStatisticRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrderConsumeStatisticRecordsResponse
         */
        public ListOrderConsumeStatisticRecordsResponse ListOrderConsumeStatisticRecordsWithOptions(ListOrderConsumeStatisticRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliOrderCode))
            {
                query["AliOrderCode"] = request.AliOrderCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticTimeMax))
            {
                query["StatisticTimeMax"] = request.StatisticTimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticTimeMin))
            {
                query["StatisticTimeMin"] = request.StatisticTimeMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrderConsumeStatisticRecords",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrderConsumeStatisticRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询用量消费统计记录列表
         *
         * @param request ListOrderConsumeStatisticRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrderConsumeStatisticRecordsResponse
         */
        public async Task<ListOrderConsumeStatisticRecordsResponse> ListOrderConsumeStatisticRecordsWithOptionsAsync(ListOrderConsumeStatisticRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliOrderCode))
            {
                query["AliOrderCode"] = request.AliOrderCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticTimeMax))
            {
                query["StatisticTimeMax"] = request.StatisticTimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticTimeMin))
            {
                query["StatisticTimeMin"] = request.StatisticTimeMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrderConsumeStatisticRecords",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrderConsumeStatisticRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用量消费统计记录列表
         *
         * @param request ListOrderConsumeStatisticRecordsRequest
         * @return ListOrderConsumeStatisticRecordsResponse
         */
        public ListOrderConsumeStatisticRecordsResponse ListOrderConsumeStatisticRecords(ListOrderConsumeStatisticRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrderConsumeStatisticRecordsWithOptions(request, runtime);
        }

        /**
         * @summary 查询用量消费统计记录列表
         *
         * @param request ListOrderConsumeStatisticRecordsRequest
         * @return ListOrderConsumeStatisticRecordsResponse
         */
        public async Task<ListOrderConsumeStatisticRecordsResponse> ListOrderConsumeStatisticRecordsAsync(ListOrderConsumeStatisticRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrderConsumeStatisticRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 弱密码检测
         *
         * @param request ListPwnedPasswordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPwnedPasswordsResponse
         */
        public ListPwnedPasswordsResponse ListPwnedPasswordsWithOptions(ListPwnedPasswordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixHexPasswordSha1Hash))
            {
                query["PrefixHexPasswordSha1Hash"] = request.PrefixHexPasswordSha1Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPwnedPasswords",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPwnedPasswordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 弱密码检测
         *
         * @param request ListPwnedPasswordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPwnedPasswordsResponse
         */
        public async Task<ListPwnedPasswordsResponse> ListPwnedPasswordsWithOptionsAsync(ListPwnedPasswordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixHexPasswordSha1Hash))
            {
                query["PrefixHexPasswordSha1Hash"] = request.PrefixHexPasswordSha1Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPwnedPasswords",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPwnedPasswordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 弱密码检测
         *
         * @param request ListPwnedPasswordsRequest
         * @return ListPwnedPasswordsResponse
         */
        public ListPwnedPasswordsResponse ListPwnedPasswords(ListPwnedPasswordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPwnedPasswordsWithOptions(request, runtime);
        }

        /**
         * @summary 弱密码检测
         *
         * @param request ListPwnedPasswordsRequest
         * @return ListPwnedPasswordsResponse
         */
        public async Task<ListPwnedPasswordsResponse> ListPwnedPasswordsAsync(ListPwnedPasswordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPwnedPasswordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询应用用户
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
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
                Action = "ListUsers",
                Version = "2021-05-20",
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

        /**
         * @summary 查询应用用户
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
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
                Action = "ListUsers",
                Version = "2021-05-20",
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

        /**
         * @summary 查询应用用户
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /**
         * @summary 查询应用用户
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 短信回执查询
         *
         * @param request QuerySmsReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySmsReportsResponse
         */
        public QuerySmsReportsResponse QuerySmsReportsWithOptions(QuerySmsReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsReports",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsReportsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 短信回执查询
         *
         * @param request QuerySmsReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySmsReportsResponse
         */
        public async Task<QuerySmsReportsResponse> QuerySmsReportsWithOptionsAsync(QuerySmsReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsReports",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 短信回执查询
         *
         * @param request QuerySmsReportsRequest
         * @return QuerySmsReportsResponse
         */
        public QuerySmsReportsResponse QuerySmsReports(QuerySmsReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsReportsWithOptions(request, runtime);
        }

        /**
         * @summary 短信回执查询
         *
         * @param request QuerySmsReportsRequest
         * @return QuerySmsReportsResponse
         */
        public async Task<QuerySmsReportsResponse> QuerySmsReportsAsync(QuerySmsReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsReportsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 短信上行查询
         *
         * @param request QuerySmsUpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySmsUpsResponse
         */
        public QuerySmsUpsResponse QuerySmsUpsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsUps",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsUpsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 短信上行查询
         *
         * @param request QuerySmsUpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySmsUpsResponse
         */
        public async Task<QuerySmsUpsResponse> QuerySmsUpsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmsUps",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmsUpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 短信上行查询
         *
         * @return QuerySmsUpsResponse
         */
        public QuerySmsUpsResponse QuerySmsUps()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsUpsWithOptions(runtime);
        }

        /**
         * @summary 短信上行查询
         *
         * @return QuerySmsUpsResponse
         */
        public async Task<QuerySmsUpsResponse> QuerySmsUpsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsUpsWithOptionsAsync(runtime);
        }

        /**
         * @summary 注册认证器
         *
         * @param request RegisterAuthenticatorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterAuthenticatorResponse
         */
        public RegisterAuthenticatorResponse RegisterAuthenticatorWithOptions(RegisterAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorName))
            {
                query["AuthenticatorName"] = request.AuthenticatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJson))
            {
                query["ClientExtendParamsJson"] = request.ClientExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJsonSign))
            {
                query["ClientExtendParamsJsonSign"] = request.ClientExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogParams))
            {
                query["LogParams"] = request.LogParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationContext))
            {
                query["RegistrationContext"] = request.RegistrationContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireChallengeBase64))
            {
                query["RequireChallengeBase64"] = request.RequireChallengeBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceIp))
            {
                query["UserSourceIp"] = request.UserSourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterAuthenticator",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAuthenticatorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 注册认证器
         *
         * @param request RegisterAuthenticatorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterAuthenticatorResponse
         */
        public async Task<RegisterAuthenticatorResponse> RegisterAuthenticatorWithOptionsAsync(RegisterAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorName))
            {
                query["AuthenticatorName"] = request.AuthenticatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJson))
            {
                query["ClientExtendParamsJson"] = request.ClientExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJsonSign))
            {
                query["ClientExtendParamsJsonSign"] = request.ClientExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogParams))
            {
                query["LogParams"] = request.LogParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationContext))
            {
                query["RegistrationContext"] = request.RegistrationContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireChallengeBase64))
            {
                query["RequireChallengeBase64"] = request.RequireChallengeBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceIp))
            {
                query["UserSourceIp"] = request.UserSourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterAuthenticator",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAuthenticatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 注册认证器
         *
         * @param request RegisterAuthenticatorRequest
         * @return RegisterAuthenticatorResponse
         */
        public RegisterAuthenticatorResponse RegisterAuthenticator(RegisterAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterAuthenticatorWithOptions(request, runtime);
        }

        /**
         * @summary 注册认证器
         *
         * @param request RegisterAuthenticatorRequest
         * @return RegisterAuthenticatorResponse
         */
        public async Task<RegisterAuthenticatorResponse> RegisterAuthenticatorAsync(RegisterAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterAuthenticatorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 认证接口
         *
         * @param request ServiceInvokeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ServiceInvokeResponse
         */
        public ServiceInvokeResponse ServiceInvokeWithOptions(ServiceInvokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DoraemonAction))
            {
                query["DoraemonAction"] = request.DoraemonAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileExtendParamsJson))
            {
                query["MobileExtendParamsJson"] = request.MobileExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileExtendParamsJsonSign))
            {
                query["MobileExtendParamsJsonSign"] = request.MobileExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestModel))
            {
                query["TestModel"] = request.TestModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XClientIp))
            {
                query["XClientIp"] = request.XClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ServiceInvoke",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ServiceInvokeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 认证接口
         *
         * @param request ServiceInvokeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ServiceInvokeResponse
         */
        public async Task<ServiceInvokeResponse> ServiceInvokeWithOptionsAsync(ServiceInvokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DoraemonAction))
            {
                query["DoraemonAction"] = request.DoraemonAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileExtendParamsJson))
            {
                query["MobileExtendParamsJson"] = request.MobileExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileExtendParamsJsonSign))
            {
                query["MobileExtendParamsJsonSign"] = request.MobileExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestModel))
            {
                query["TestModel"] = request.TestModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XClientIp))
            {
                query["XClientIp"] = request.XClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ServiceInvoke",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ServiceInvokeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 认证接口
         *
         * @param request ServiceInvokeRequest
         * @return ServiceInvokeResponse
         */
        public ServiceInvokeResponse ServiceInvoke(ServiceInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ServiceInvokeWithOptions(request, runtime);
        }

        /**
         * @summary 认证接口
         *
         * @param request ServiceInvokeRequest
         * @return ServiceInvokeResponse
         */
        public async Task<ServiceInvokeResponse> ServiceInvokeAsync(ServiceInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ServiceInvokeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新认证器名字
         *
         * @param request UpdateAuthenticatorAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAuthenticatorAttributeResponse
         */
        public UpdateAuthenticatorAttributeResponse UpdateAuthenticatorAttributeWithOptions(UpdateAuthenticatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorName))
            {
                query["AuthenticatorName"] = request.AuthenticatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
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
                Action = "UpdateAuthenticatorAttribute",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuthenticatorAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新认证器名字
         *
         * @param request UpdateAuthenticatorAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAuthenticatorAttributeResponse
         */
        public async Task<UpdateAuthenticatorAttributeResponse> UpdateAuthenticatorAttributeWithOptionsAsync(UpdateAuthenticatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorName))
            {
                query["AuthenticatorName"] = request.AuthenticatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorUuid))
            {
                query["AuthenticatorUuid"] = request.AuthenticatorUuid;
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
                Action = "UpdateAuthenticatorAttribute",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuthenticatorAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新认证器名字
         *
         * @param request UpdateAuthenticatorAttributeRequest
         * @return UpdateAuthenticatorAttributeResponse
         */
        public UpdateAuthenticatorAttributeResponse UpdateAuthenticatorAttribute(UpdateAuthenticatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAuthenticatorAttributeWithOptions(request, runtime);
        }

        /**
         * @summary 更新认证器名字
         *
         * @param request UpdateAuthenticatorAttributeRequest
         * @return UpdateAuthenticatorAttributeResponse
         */
        public async Task<UpdateAuthenticatorAttributeResponse> UpdateAuthenticatorAttributeAsync(UpdateAuthenticatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAuthenticatorAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 验证id_token
         *
         * @param request VerifyIdTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyIdTokenResponse
         */
        public VerifyIdTokenResponse VerifyIdTokenWithOptions(VerifyIdTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtIdToken))
            {
                query["JwtIdToken"] = request.JwtIdToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyIdToken",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyIdTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 验证id_token
         *
         * @param request VerifyIdTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyIdTokenResponse
         */
        public async Task<VerifyIdTokenResponse> VerifyIdTokenWithOptionsAsync(VerifyIdTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtIdToken))
            {
                query["JwtIdToken"] = request.JwtIdToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyIdToken",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyIdTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 验证id_token
         *
         * @param request VerifyIdTokenRequest
         * @return VerifyIdTokenResponse
         */
        public VerifyIdTokenResponse VerifyIdToken(VerifyIdTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyIdTokenWithOptions(request, runtime);
        }

        /**
         * @summary 验证id_token
         *
         * @param request VerifyIdTokenRequest
         * @return VerifyIdTokenResponse
         */
        public async Task<VerifyIdTokenResponse> VerifyIdTokenAsync(VerifyIdTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyIdTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 认证用户
         *
         * @param request VerifyUserAuthenticationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyUserAuthenticationResponse
         */
        public VerifyUserAuthenticationResponse VerifyUserAuthenticationWithOptions(VerifyUserAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationContext))
            {
                query["AuthenticationContext"] = request.AuthenticationContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJson))
            {
                query["ClientExtendParamsJson"] = request.ClientExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJsonSign))
            {
                query["ClientExtendParamsJsonSign"] = request.ClientExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogParams))
            {
                query["LogParams"] = request.LogParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTag))
            {
                query["LogTag"] = request.LogTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireBindHashBase64))
            {
                query["RequireBindHashBase64"] = request.RequireBindHashBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireChallengeBase64))
            {
                query["RequireChallengeBase64"] = request.RequireChallengeBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceIp))
            {
                query["UserSourceIp"] = request.UserSourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyUserAuthentication",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyUserAuthenticationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 认证用户
         *
         * @param request VerifyUserAuthenticationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyUserAuthenticationResponse
         */
        public async Task<VerifyUserAuthenticationResponse> VerifyUserAuthenticationWithOptionsAsync(VerifyUserAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationExternalId))
            {
                query["ApplicationExternalId"] = request.ApplicationExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationContext))
            {
                query["AuthenticationContext"] = request.AuthenticationContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticatorType))
            {
                query["AuthenticatorType"] = request.AuthenticatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJson))
            {
                query["ClientExtendParamsJson"] = request.ClientExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientExtendParamsJsonSign))
            {
                query["ClientExtendParamsJsonSign"] = request.ClientExtendParamsJsonSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogParams))
            {
                query["LogParams"] = request.LogParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTag))
            {
                query["LogTag"] = request.LogTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireBindHashBase64))
            {
                query["RequireBindHashBase64"] = request.RequireBindHashBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireChallengeBase64))
            {
                query["RequireChallengeBase64"] = request.RequireChallengeBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerExtendParamsJson))
            {
                query["ServerExtendParamsJson"] = request.ServerExtendParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceIp))
            {
                query["UserSourceIp"] = request.UserSourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyUserAuthentication",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyUserAuthenticationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 认证用户
         *
         * @param request VerifyUserAuthenticationRequest
         * @return VerifyUserAuthenticationResponse
         */
        public VerifyUserAuthenticationResponse VerifyUserAuthentication(VerifyUserAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyUserAuthenticationWithOptions(request, runtime);
        }

        /**
         * @summary 认证用户
         *
         * @param request VerifyUserAuthenticationRequest
         * @return VerifyUserAuthenticationResponse
         */
        public async Task<VerifyUserAuthenticationResponse> VerifyUserAuthenticationAsync(VerifyUserAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyUserAuthenticationWithOptionsAsync(request, runtime);
        }

    }
}
