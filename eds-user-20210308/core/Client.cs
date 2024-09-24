// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eds_user20210308.Models;

namespace AlibabaCloud.SDK.Eds_user20210308
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eds-user", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 批量设置桌面管理员
         *
         * @param request BatchSetDesktopManagerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSetDesktopManagerResponse
         */
        public BatchSetDesktopManagerResponse BatchSetDesktopManagerWithOptions(BatchSetDesktopManagerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDesktopManager))
            {
                body["IsDesktopManager"] = request.IsDesktopManager;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetDesktopManager",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetDesktopManagerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量设置桌面管理员
         *
         * @param request BatchSetDesktopManagerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSetDesktopManagerResponse
         */
        public async Task<BatchSetDesktopManagerResponse> BatchSetDesktopManagerWithOptionsAsync(BatchSetDesktopManagerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDesktopManager))
            {
                body["IsDesktopManager"] = request.IsDesktopManager;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetDesktopManager",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetDesktopManagerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量设置桌面管理员
         *
         * @param request BatchSetDesktopManagerRequest
         * @return BatchSetDesktopManagerResponse
         */
        public BatchSetDesktopManagerResponse BatchSetDesktopManager(BatchSetDesktopManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetDesktopManagerWithOptions(request, runtime);
        }

        /**
         * @summary 批量设置桌面管理员
         *
         * @param request BatchSetDesktopManagerRequest
         * @return BatchSetDesktopManagerResponse
         */
        public async Task<BatchSetDesktopManagerResponse> BatchSetDesktopManagerAsync(BatchSetDesktopManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetDesktopManagerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether a property is associated with one or more convenience users.
         *
         * @param request CheckUsedPropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUsedPropertyResponse
         */
        public CheckUsedPropertyResponse CheckUsedPropertyWithOptions(CheckUsedPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                query["PropertyId"] = request.PropertyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUsedProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUsedPropertyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether a property is associated with one or more convenience users.
         *
         * @param request CheckUsedPropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUsedPropertyResponse
         */
        public async Task<CheckUsedPropertyResponse> CheckUsedPropertyWithOptionsAsync(CheckUsedPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                query["PropertyId"] = request.PropertyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUsedProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUsedPropertyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether a property is associated with one or more convenience users.
         *
         * @param request CheckUsedPropertyRequest
         * @return CheckUsedPropertyResponse
         */
        public CheckUsedPropertyResponse CheckUsedProperty(CheckUsedPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckUsedPropertyWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether a property is associated with one or more convenience users.
         *
         * @param request CheckUsedPropertyRequest
         * @return CheckUsedPropertyResponse
         */
        public async Task<CheckUsedPropertyResponse> CheckUsedPropertyAsync(CheckUsedPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckUsedPropertyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Checks whether a property value is associated with a user.
         *
         * @description Before you call the operation, you can call the [ListProperty](https://help.aliyun.com/document_detail/410890.html) operation to query the existing user properties and their IDs (PropertyId) and values (PropertyValueId).
         *
         * @param request CheckUsedPropertyValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUsedPropertyValueResponse
         */
        public CheckUsedPropertyValueResponse CheckUsedPropertyValueWithOptions(CheckUsedPropertyValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                query["PropertyId"] = request.PropertyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValueId))
            {
                query["PropertyValueId"] = request.PropertyValueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUsedPropertyValue",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUsedPropertyValueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Checks whether a property value is associated with a user.
         *
         * @description Before you call the operation, you can call the [ListProperty](https://help.aliyun.com/document_detail/410890.html) operation to query the existing user properties and their IDs (PropertyId) and values (PropertyValueId).
         *
         * @param request CheckUsedPropertyValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUsedPropertyValueResponse
         */
        public async Task<CheckUsedPropertyValueResponse> CheckUsedPropertyValueWithOptionsAsync(CheckUsedPropertyValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                query["PropertyId"] = request.PropertyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValueId))
            {
                query["PropertyValueId"] = request.PropertyValueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUsedPropertyValue",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUsedPropertyValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Checks whether a property value is associated with a user.
         *
         * @description Before you call the operation, you can call the [ListProperty](https://help.aliyun.com/document_detail/410890.html) operation to query the existing user properties and their IDs (PropertyId) and values (PropertyValueId).
         *
         * @param request CheckUsedPropertyValueRequest
         * @return CheckUsedPropertyValueResponse
         */
        public CheckUsedPropertyValueResponse CheckUsedPropertyValue(CheckUsedPropertyValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckUsedPropertyValueWithOptions(request, runtime);
        }

        /**
         * @summary Checks whether a property value is associated with a user.
         *
         * @description Before you call the operation, you can call the [ListProperty](https://help.aliyun.com/document_detail/410890.html) operation to query the existing user properties and their IDs (PropertyId) and values (PropertyValueId).
         *
         * @param request CheckUsedPropertyValueRequest
         * @return CheckUsedPropertyValueResponse
         */
        public async Task<CheckUsedPropertyValueResponse> CheckUsedPropertyValueAsync(CheckUsedPropertyValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckUsedPropertyValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a user property.
         *
         * @param request CreatePropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePropertyResponse
         */
        public CreatePropertyResponse CreatePropertyWithOptions(CreatePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKey))
            {
                body["PropertyKey"] = request.PropertyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValues))
            {
                body["PropertyValues"] = request.PropertyValues;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePropertyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a user property.
         *
         * @param request CreatePropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePropertyResponse
         */
        public async Task<CreatePropertyResponse> CreatePropertyWithOptionsAsync(CreatePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKey))
            {
                body["PropertyKey"] = request.PropertyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValues))
            {
                body["PropertyValues"] = request.PropertyValues;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePropertyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a user property.
         *
         * @param request CreatePropertyRequest
         * @return CreatePropertyResponse
         */
        public CreatePropertyResponse CreateProperty(CreatePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePropertyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a user property.
         *
         * @param request CreatePropertyRequest
         * @return CreatePropertyResponse
         */
        public async Task<CreatePropertyResponse> CreatePropertyAsync(CreatePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePropertyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a convenience user.
         *
         * @description Convenience users are dedicated Elastic Desktop Service (EDS) user accounts and are suitable for scenarios in which you do not need to connect to enterprise Active Directory (AD) systems. The information about a convenience user includes the username, email address, and mobile number. You must specify the username or email address.
         *
         * @param request CreateUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUsersResponse
         */
        public CreateUsersResponse CreateUsersWithOptions(CreateUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoLockTime))
            {
                query["AutoLockTime"] = request.AutoLockTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsLocalAdmin))
            {
                query["IsLocalAdmin"] = request.IsLocalAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpireDays))
            {
                query["PasswordExpireDays"] = request.PasswordExpireDays;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a convenience user.
         *
         * @description Convenience users are dedicated Elastic Desktop Service (EDS) user accounts and are suitable for scenarios in which you do not need to connect to enterprise Active Directory (AD) systems. The information about a convenience user includes the username, email address, and mobile number. You must specify the username or email address.
         *
         * @param request CreateUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUsersResponse
         */
        public async Task<CreateUsersResponse> CreateUsersWithOptionsAsync(CreateUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoLockTime))
            {
                query["AutoLockTime"] = request.AutoLockTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsLocalAdmin))
            {
                query["IsLocalAdmin"] = request.IsLocalAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpireDays))
            {
                query["PasswordExpireDays"] = request.PasswordExpireDays;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a convenience user.
         *
         * @description Convenience users are dedicated Elastic Desktop Service (EDS) user accounts and are suitable for scenarios in which you do not need to connect to enterprise Active Directory (AD) systems. The information about a convenience user includes the username, email address, and mobile number. You must specify the username or email address.
         *
         * @param request CreateUsersRequest
         * @return CreateUsersResponse
         */
        public CreateUsersResponse CreateUsers(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUsersWithOptions(request, runtime);
        }

        /**
         * @summary Creates a convenience user.
         *
         * @description Convenience users are dedicated Elastic Desktop Service (EDS) user accounts and are suitable for scenarios in which you do not need to connect to enterprise Active Directory (AD) systems. The information about a convenience user includes the username, email address, and mobile number. You must specify the username or email address.
         *
         * @param request CreateUsersRequest
         * @return CreateUsersResponse
         */
        public async Task<CreateUsersResponse> CreateUsersAsync(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Dissociates a user property from a user.
         *
         * @description Before you call this operation, you can call the FilterUsers operation to query the users that are associated with user properties.
         *
         * @param request DeleteUserPropertyValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserPropertyValueResponse
         */
        public DeleteUserPropertyValueResponse DeleteUserPropertyValueWithOptions(DeleteUserPropertyValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                body["PropertyId"] = request.PropertyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValueId))
            {
                body["PropertyValueId"] = request.PropertyValueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserPropertyValue",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserPropertyValueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Dissociates a user property from a user.
         *
         * @description Before you call this operation, you can call the FilterUsers operation to query the users that are associated with user properties.
         *
         * @param request DeleteUserPropertyValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserPropertyValueResponse
         */
        public async Task<DeleteUserPropertyValueResponse> DeleteUserPropertyValueWithOptionsAsync(DeleteUserPropertyValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                body["PropertyId"] = request.PropertyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValueId))
            {
                body["PropertyValueId"] = request.PropertyValueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserPropertyValue",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserPropertyValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Dissociates a user property from a user.
         *
         * @description Before you call this operation, you can call the FilterUsers operation to query the users that are associated with user properties.
         *
         * @param request DeleteUserPropertyValueRequest
         * @return DeleteUserPropertyValueResponse
         */
        public DeleteUserPropertyValueResponse DeleteUserPropertyValue(DeleteUserPropertyValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserPropertyValueWithOptions(request, runtime);
        }

        /**
         * @summary Dissociates a user property from a user.
         *
         * @description Before you call this operation, you can call the FilterUsers operation to query the users that are associated with user properties.
         *
         * @param request DeleteUserPropertyValueRequest
         * @return DeleteUserPropertyValueResponse
         */
        public async Task<DeleteUserPropertyValueResponse> DeleteUserPropertyValueAsync(DeleteUserPropertyValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserPropertyValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about virtual multi-factor authentication (MFA) devices that are bound to convenience users.
         *
         * @param request DescribeMfaDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMfaDevicesResponse
         */
        public DescribeMfaDevicesResponse DescribeMfaDevicesWithOptions(DescribeMfaDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdDomain))
            {
                query["AdDomain"] = request.AdDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                query["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumbers))
            {
                query["SerialNumbers"] = request.SerialNumbers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMfaDevices",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMfaDevicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about virtual multi-factor authentication (MFA) devices that are bound to convenience users.
         *
         * @param request DescribeMfaDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMfaDevicesResponse
         */
        public async Task<DescribeMfaDevicesResponse> DescribeMfaDevicesWithOptionsAsync(DescribeMfaDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdDomain))
            {
                query["AdDomain"] = request.AdDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                query["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumbers))
            {
                query["SerialNumbers"] = request.SerialNumbers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMfaDevices",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMfaDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about virtual multi-factor authentication (MFA) devices that are bound to convenience users.
         *
         * @param request DescribeMfaDevicesRequest
         * @return DescribeMfaDevicesResponse
         */
        public DescribeMfaDevicesResponse DescribeMfaDevices(DescribeMfaDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMfaDevicesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about virtual multi-factor authentication (MFA) devices that are bound to convenience users.
         *
         * @param request DescribeMfaDevicesRequest
         * @return DescribeMfaDevicesResponse
         */
        public async Task<DescribeMfaDevicesResponse> DescribeMfaDevicesAsync(DescribeMfaDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMfaDevicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries organizations.
         *
         * @description An organization is in a tree structure. The root organization ID is in the following format: org-aliyun-wy-org-id.
         *
         * @param request DescribeOrgsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOrgsResponse
         */
        public DescribeOrgsResponse DescribeOrgsWithOptions(DescribeOrgsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                query["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentOrgId))
            {
                query["ParentOrgId"] = request.ParentOrgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOrgs",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOrgsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries organizations.
         *
         * @description An organization is in a tree structure. The root organization ID is in the following format: org-aliyun-wy-org-id.
         *
         * @param request DescribeOrgsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOrgsResponse
         */
        public async Task<DescribeOrgsResponse> DescribeOrgsWithOptionsAsync(DescribeOrgsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                query["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentOrgId))
            {
                query["ParentOrgId"] = request.ParentOrgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOrgs",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOrgsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries organizations.
         *
         * @description An organization is in a tree structure. The root organization ID is in the following format: org-aliyun-wy-org-id.
         *
         * @param request DescribeOrgsRequest
         * @return DescribeOrgsResponse
         */
        public DescribeOrgsResponse DescribeOrgs(DescribeOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOrgsWithOptions(request, runtime);
        }

        /**
         * @summary Queries organizations.
         *
         * @description An organization is in a tree structure. The root organization ID is in the following format: org-aliyun-wy-org-id.
         *
         * @param request DescribeOrgsRequest
         * @return DescribeOrgsResponse
         */
        public async Task<DescribeOrgsResponse> DescribeOrgsAsync(DescribeOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOrgsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about convenience users. The information of a convenience user includes a username, an email address, and a description.
         *
         * @param tmpReq DescribeUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsersResponse
         */
        public DescribeUsersResponse DescribeUsersWithOptions(DescribeUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeUsersShrinkRequest request = new DescribeUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterWithAssignedResources))
            {
                request.FilterWithAssignedResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterWithAssignedResources, "FilterWithAssignedResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ShowExtras))
            {
                request.ShowExtrasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ShowExtras, "ShowExtras", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                body["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeEndUserIds))
            {
                body["ExcludeEndUserIds"] = request.ExcludeEndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterWithAssignedResourcesShrink))
            {
                body["FilterWithAssignedResources"] = request.FilterWithAssignedResourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowExtrasShrink))
            {
                body["ShowExtras"] = request.ShowExtrasShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["SolutionId"] = request.SolutionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about convenience users. The information of a convenience user includes a username, an email address, and a description.
         *
         * @param tmpReq DescribeUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsersResponse
         */
        public async Task<DescribeUsersResponse> DescribeUsersWithOptionsAsync(DescribeUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeUsersShrinkRequest request = new DescribeUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterWithAssignedResources))
            {
                request.FilterWithAssignedResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterWithAssignedResources, "FilterWithAssignedResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ShowExtras))
            {
                request.ShowExtrasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ShowExtras, "ShowExtras", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                body["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeEndUserIds))
            {
                body["ExcludeEndUserIds"] = request.ExcludeEndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterWithAssignedResourcesShrink))
            {
                body["FilterWithAssignedResources"] = request.FilterWithAssignedResourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowExtrasShrink))
            {
                body["ShowExtras"] = request.ShowExtrasShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["SolutionId"] = request.SolutionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about convenience users. The information of a convenience user includes a username, an email address, and a description.
         *
         * @param request DescribeUsersRequest
         * @return DescribeUsersResponse
         */
        public DescribeUsersResponse DescribeUsers(DescribeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about convenience users. The information of a convenience user includes a username, an email address, and a description.
         *
         * @param request DescribeUsersRequest
         * @return DescribeUsersResponse
         */
        public async Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Filters convenience users by property.
         *
         * @param tmpReq FilterUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FilterUsersResponse
         */
        public FilterUsersResponse FilterUsersWithOptions(FilterUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FilterUsersShrinkRequest request = new FilterUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderParam))
            {
                request.OrderParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderParam, "OrderParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeEndUserIds))
            {
                query["ExcludeEndUserIds"] = request.ExcludeEndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDesktopCount))
            {
                query["IncludeDesktopCount"] = request.IncludeDesktopCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDesktopGroupCount))
            {
                query["IncludeDesktopGroupCount"] = request.IncludeDesktopGroupCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParamShrink))
            {
                query["OrderParam"] = request.OrderParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerType))
            {
                query["OwnerType"] = request.OwnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyFilterParam))
            {
                query["PropertyFilterParam"] = request.PropertyFilterParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKeyValueFilterParam))
            {
                query["PropertyKeyValueFilterParam"] = request.PropertyKeyValueFilterParam;
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
                Action = "FilterUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FilterUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Filters convenience users by property.
         *
         * @param tmpReq FilterUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FilterUsersResponse
         */
        public async Task<FilterUsersResponse> FilterUsersWithOptionsAsync(FilterUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FilterUsersShrinkRequest request = new FilterUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderParam))
            {
                request.OrderParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderParam, "OrderParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeEndUserIds))
            {
                query["ExcludeEndUserIds"] = request.ExcludeEndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDesktopCount))
            {
                query["IncludeDesktopCount"] = request.IncludeDesktopCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDesktopGroupCount))
            {
                query["IncludeDesktopGroupCount"] = request.IncludeDesktopGroupCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParamShrink))
            {
                query["OrderParam"] = request.OrderParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerType))
            {
                query["OwnerType"] = request.OwnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyFilterParam))
            {
                query["PropertyFilterParam"] = request.PropertyFilterParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKeyValueFilterParam))
            {
                query["PropertyKeyValueFilterParam"] = request.PropertyKeyValueFilterParam;
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
                Action = "FilterUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FilterUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Filters convenience users by property.
         *
         * @param request FilterUsersRequest
         * @return FilterUsersResponse
         */
        public FilterUsersResponse FilterUsers(FilterUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FilterUsersWithOptions(request, runtime);
        }

        /**
         * @summary Filters convenience users by property.
         *
         * @param request FilterUsersRequest
         * @return FilterUsersResponse
         */
        public async Task<FilterUsersResponse> FilterUsersAsync(FilterUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FilterUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the information about the current logon administrator based on the authorization code.
         *
         * @param request GetManagerInfoByAuthCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetManagerInfoByAuthCodeResponse
         */
        public GetManagerInfoByAuthCodeResponse GetManagerInfoByAuthCodeWithOptions(GetManagerInfoByAuthCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetManagerInfoByAuthCode",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManagerInfoByAuthCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about the current logon administrator based on the authorization code.
         *
         * @param request GetManagerInfoByAuthCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetManagerInfoByAuthCodeResponse
         */
        public async Task<GetManagerInfoByAuthCodeResponse> GetManagerInfoByAuthCodeWithOptionsAsync(GetManagerInfoByAuthCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetManagerInfoByAuthCode",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManagerInfoByAuthCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about the current logon administrator based on the authorization code.
         *
         * @param request GetManagerInfoByAuthCodeRequest
         * @return GetManagerInfoByAuthCodeResponse
         */
        public GetManagerInfoByAuthCodeResponse GetManagerInfoByAuthCode(GetManagerInfoByAuthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetManagerInfoByAuthCodeWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the information about the current logon administrator based on the authorization code.
         *
         * @param request GetManagerInfoByAuthCodeRequest
         * @return GetManagerInfoByAuthCodeResponse
         */
        public async Task<GetManagerInfoByAuthCodeResponse> GetManagerInfoByAuthCodeAsync(GetManagerInfoByAuthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetManagerInfoByAuthCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all user properties within an Alibaba Cloud account.
         *
         * @param request ListPropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPropertyResponse
         */
        public ListPropertyResponse ListPropertyWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPropertyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all user properties within an Alibaba Cloud account.
         *
         * @param request ListPropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPropertyResponse
         */
        public async Task<ListPropertyResponse> ListPropertyWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPropertyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all user properties within an Alibaba Cloud account.
         *
         * @return ListPropertyResponse
         */
        public ListPropertyResponse ListProperty()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPropertyWithOptions(runtime);
        }

        /**
         * @summary Queries all user properties within an Alibaba Cloud account.
         *
         * @return ListPropertyResponse
         */
        public async Task<ListPropertyResponse> ListPropertyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPropertyWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries property values of a user property.
         *
         * @param request ListPropertyValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPropertyValueResponse
         */
        public ListPropertyValueResponse ListPropertyValueWithOptions(ListPropertyValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                query["PropertyId"] = request.PropertyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPropertyValue",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPropertyValueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries property values of a user property.
         *
         * @param request ListPropertyValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPropertyValueResponse
         */
        public async Task<ListPropertyValueResponse> ListPropertyValueWithOptionsAsync(ListPropertyValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                query["PropertyId"] = request.PropertyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPropertyValue",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPropertyValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries property values of a user property.
         *
         * @param request ListPropertyValueRequest
         * @return ListPropertyValueResponse
         */
        public ListPropertyValueResponse ListPropertyValue(ListPropertyValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPropertyValueWithOptions(request, runtime);
        }

        /**
         * @summary Queries property values of a user property.
         *
         * @param request ListPropertyValueRequest
         * @return ListPropertyValueResponse
         */
        public async Task<ListPropertyValueResponse> ListPropertyValueAsync(ListPropertyValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPropertyValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Locks a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @description After a virtual MFA device is locked, the status of the virtual MFA device changes to LOCKED. The convenience user to which the MFA device is bound cannot log on to the cloud desktop that resides in the workspace with the MFA feature enabled because the identity of the convenience user cannot be verified based on the virtual MFA device. You can call the [UnlockMfaDevice](https://help.aliyun.com/document_detail/286534.html) operation to unlock the virtual MFA device.
         *
         * @param request LockMfaDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockMfaDeviceResponse
         */
        public LockMfaDeviceResponse LockMfaDeviceWithOptions(LockMfaDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdDomain))
            {
                query["AdDomain"] = request.AdDomain;
            }
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
                Action = "LockMfaDevice",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockMfaDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Locks a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @description After a virtual MFA device is locked, the status of the virtual MFA device changes to LOCKED. The convenience user to which the MFA device is bound cannot log on to the cloud desktop that resides in the workspace with the MFA feature enabled because the identity of the convenience user cannot be verified based on the virtual MFA device. You can call the [UnlockMfaDevice](https://help.aliyun.com/document_detail/286534.html) operation to unlock the virtual MFA device.
         *
         * @param request LockMfaDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockMfaDeviceResponse
         */
        public async Task<LockMfaDeviceResponse> LockMfaDeviceWithOptionsAsync(LockMfaDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdDomain))
            {
                query["AdDomain"] = request.AdDomain;
            }
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
                Action = "LockMfaDevice",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockMfaDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Locks a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @description After a virtual MFA device is locked, the status of the virtual MFA device changes to LOCKED. The convenience user to which the MFA device is bound cannot log on to the cloud desktop that resides in the workspace with the MFA feature enabled because the identity of the convenience user cannot be verified based on the virtual MFA device. You can call the [UnlockMfaDevice](https://help.aliyun.com/document_detail/286534.html) operation to unlock the virtual MFA device.
         *
         * @param request LockMfaDeviceRequest
         * @return LockMfaDeviceResponse
         */
        public LockMfaDeviceResponse LockMfaDevice(LockMfaDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockMfaDeviceWithOptions(request, runtime);
        }

        /**
         * @summary Locks a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @description After a virtual MFA device is locked, the status of the virtual MFA device changes to LOCKED. The convenience user to which the MFA device is bound cannot log on to the cloud desktop that resides in the workspace with the MFA feature enabled because the identity of the convenience user cannot be verified based on the virtual MFA device. You can call the [UnlockMfaDevice](https://help.aliyun.com/document_detail/286534.html) operation to unlock the virtual MFA device.
         *
         * @param request LockMfaDeviceRequest
         * @return LockMfaDeviceResponse
         */
        public async Task<LockMfaDeviceResponse> LockMfaDeviceAsync(LockMfaDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockMfaDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Locks one or more convenience users.
         *
         * @param request LockUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockUsersResponse
         */
        public LockUsersResponse LockUsersWithOptions(LockUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Locks one or more convenience users.
         *
         * @param request LockUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockUsersResponse
         */
        public async Task<LockUsersResponse> LockUsersWithOptionsAsync(LockUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Locks one or more convenience users.
         *
         * @param request LockUsersRequest
         * @return LockUsersResponse
         */
        public LockUsersResponse LockUsers(LockUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockUsersWithOptions(request, runtime);
        }

        /**
         * @summary Locks one or more convenience users.
         *
         * @param request LockUsersRequest
         * @return LockUsersResponse
         */
        public async Task<LockUsersResponse> LockUsersAsync(LockUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies user information.
         *
         * @param request ModifyUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyUserResponse
         */
        public ModifyUserResponse ModifyUserWithOptions(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUser",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies user information.
         *
         * @param request ModifyUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyUserResponse
         */
        public async Task<ModifyUserResponse> ModifyUserWithOptionsAsync(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUser",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies user information.
         *
         * @param request ModifyUserRequest
         * @return ModifyUserResponse
         */
        public ModifyUserResponse ModifyUser(ModifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserWithOptions(request, runtime);
        }

        /**
         * @summary Modifies user information.
         *
         * @param request ModifyUserRequest
         * @return ModifyUserResponse
         */
        public async Task<ModifyUserResponse> ModifyUserAsync(ModifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询edu同步信息
         *
         * @param request QuerySyncStatusByAliUidRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySyncStatusByAliUidResponse
         */
        public QuerySyncStatusByAliUidResponse QuerySyncStatusByAliUidWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySyncStatusByAliUid",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySyncStatusByAliUidResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询edu同步信息
         *
         * @param request QuerySyncStatusByAliUidRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySyncStatusByAliUidResponse
         */
        public async Task<QuerySyncStatusByAliUidResponse> QuerySyncStatusByAliUidWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySyncStatusByAliUid",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySyncStatusByAliUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询edu同步信息
         *
         * @return QuerySyncStatusByAliUidResponse
         */
        public QuerySyncStatusByAliUidResponse QuerySyncStatusByAliUid()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySyncStatusByAliUidWithOptions(runtime);
        }

        /**
         * @summary 查询edu同步信息
         *
         * @return QuerySyncStatusByAliUidResponse
         */
        public async Task<QuerySyncStatusByAliUidResponse> QuerySyncStatusByAliUidAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySyncStatusByAliUidWithOptionsAsync(runtime);
        }

        /**
         * @summary Removes a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @description If you remove a virtual MFA device that is bound to a convenience user, the convenience user can no longer use the virtual MFA device to log on to cloud desktops. Before the convenience user can log on to cloud desktops again, a new virtual MFA device must be bound to the convenience user.
         *
         * @param request RemoveMfaDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveMfaDeviceResponse
         */
        public RemoveMfaDeviceResponse RemoveMfaDeviceWithOptions(RemoveMfaDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdDomain))
            {
                query["AdDomain"] = request.AdDomain;
            }
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
                Action = "RemoveMfaDevice",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMfaDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @description If you remove a virtual MFA device that is bound to a convenience user, the convenience user can no longer use the virtual MFA device to log on to cloud desktops. Before the convenience user can log on to cloud desktops again, a new virtual MFA device must be bound to the convenience user.
         *
         * @param request RemoveMfaDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveMfaDeviceResponse
         */
        public async Task<RemoveMfaDeviceResponse> RemoveMfaDeviceWithOptionsAsync(RemoveMfaDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdDomain))
            {
                query["AdDomain"] = request.AdDomain;
            }
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
                Action = "RemoveMfaDevice",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMfaDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @description If you remove a virtual MFA device that is bound to a convenience user, the convenience user can no longer use the virtual MFA device to log on to cloud desktops. Before the convenience user can log on to cloud desktops again, a new virtual MFA device must be bound to the convenience user.
         *
         * @param request RemoveMfaDeviceRequest
         * @return RemoveMfaDeviceResponse
         */
        public RemoveMfaDeviceResponse RemoveMfaDevice(RemoveMfaDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveMfaDeviceWithOptions(request, runtime);
        }

        /**
         * @summary Removes a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @description If you remove a virtual MFA device that is bound to a convenience user, the convenience user can no longer use the virtual MFA device to log on to cloud desktops. Before the convenience user can log on to cloud desktops again, a new virtual MFA device must be bound to the convenience user.
         *
         * @param request RemoveMfaDeviceRequest
         * @return RemoveMfaDeviceResponse
         */
        public async Task<RemoveMfaDeviceResponse> RemoveMfaDeviceAsync(RemoveMfaDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveMfaDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a user property.
         *
         * @param request RemovePropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemovePropertyResponse
         */
        public RemovePropertyResponse RemovePropertyWithOptions(RemovePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                body["PropertyId"] = request.PropertyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePropertyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a user property.
         *
         * @param request RemovePropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemovePropertyResponse
         */
        public async Task<RemovePropertyResponse> RemovePropertyWithOptionsAsync(RemovePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                body["PropertyId"] = request.PropertyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePropertyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a user property.
         *
         * @param request RemovePropertyRequest
         * @return RemovePropertyResponse
         */
        public RemovePropertyResponse RemoveProperty(RemovePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePropertyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a user property.
         *
         * @param request RemovePropertyRequest
         * @return RemovePropertyResponse
         */
        public async Task<RemovePropertyResponse> RemovePropertyAsync(RemovePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePropertyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes one or more convenience users.
         *
         * @param request RemoveUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUsersResponse
         */
        public RemoveUsersResponse RemoveUsersWithOptions(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes one or more convenience users.
         *
         * @param request RemoveUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUsersResponse
         */
        public async Task<RemoveUsersResponse> RemoveUsersWithOptionsAsync(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes one or more convenience users.
         *
         * @param request RemoveUsersRequest
         * @return RemoveUsersResponse
         */
        public RemoveUsersResponse RemoveUsers(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUsersWithOptions(request, runtime);
        }

        /**
         * @summary Removes one or more convenience users.
         *
         * @param request RemoveUsersRequest
         * @return RemoveUsersResponse
         */
        public async Task<RemoveUsersResponse> RemoveUsersAsync(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Resets the password for a convenience user. If you call this operation, a token that is used to reset the password is generated, and the system sends a password reset email that includes the token to the email address of the convenience user.
         *
         * @param request ResetUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetUserPasswordResponse
         */
        public ResetUserPasswordResponse ResetUserPasswordWithOptions(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserPassword",
                Version = "2021-03-08",
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

        /**
         * @summary Resets the password for a convenience user. If you call this operation, a token that is used to reset the password is generated, and the system sends a password reset email that includes the token to the email address of the convenience user.
         *
         * @param request ResetUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetUserPasswordResponse
         */
        public async Task<ResetUserPasswordResponse> ResetUserPasswordWithOptionsAsync(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserPassword",
                Version = "2021-03-08",
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

        /**
         * @summary Resets the password for a convenience user. If you call this operation, a token that is used to reset the password is generated, and the system sends a password reset email that includes the token to the email address of the convenience user.
         *
         * @param request ResetUserPasswordRequest
         * @return ResetUserPasswordResponse
         */
        public ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetUserPasswordWithOptions(request, runtime);
        }

        /**
         * @summary Resets the password for a convenience user. If you call this operation, a token that is used to reset the password is generated, and the system sends a password reset email that includes the token to the email address of the convenience user.
         *
         * @param request ResetUserPasswordRequest
         * @return ResetUserPasswordResponse
         */
        public async Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetUserPasswordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Associates a user property with a convenience user.
         *
         * @param request SetUserPropertyValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetUserPropertyValueResponse
         */
        public SetUserPropertyValueResponse SetUserPropertyValueWithOptions(SetUserPropertyValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                body["PropertyId"] = request.PropertyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValueId))
            {
                body["PropertyValueId"] = request.PropertyValueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetUserPropertyValue",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserPropertyValueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Associates a user property with a convenience user.
         *
         * @param request SetUserPropertyValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetUserPropertyValueResponse
         */
        public async Task<SetUserPropertyValueResponse> SetUserPropertyValueWithOptionsAsync(SetUserPropertyValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                body["PropertyId"] = request.PropertyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValueId))
            {
                body["PropertyValueId"] = request.PropertyValueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetUserPropertyValue",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserPropertyValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Associates a user property with a convenience user.
         *
         * @param request SetUserPropertyValueRequest
         * @return SetUserPropertyValueResponse
         */
        public SetUserPropertyValueResponse SetUserPropertyValue(SetUserPropertyValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetUserPropertyValueWithOptions(request, runtime);
        }

        /**
         * @summary Associates a user property with a convenience user.
         *
         * @param request SetUserPropertyValueRequest
         * @return SetUserPropertyValueResponse
         */
        public async Task<SetUserPropertyValueResponse> SetUserPropertyValueAsync(SetUserPropertyValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetUserPropertyValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 从钉钉手动同步老师学生信息
         *
         * @param request SyncAllEduInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncAllEduInfoResponse
         */
        public SyncAllEduInfoResponse SyncAllEduInfoWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncAllEduInfo",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncAllEduInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 从钉钉手动同步老师学生信息
         *
         * @param request SyncAllEduInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncAllEduInfoResponse
         */
        public async Task<SyncAllEduInfoResponse> SyncAllEduInfoWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncAllEduInfo",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncAllEduInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 从钉钉手动同步老师学生信息
         *
         * @return SyncAllEduInfoResponse
         */
        public SyncAllEduInfoResponse SyncAllEduInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncAllEduInfoWithOptions(runtime);
        }

        /**
         * @summary 从钉钉手动同步老师学生信息
         *
         * @return SyncAllEduInfoResponse
         */
        public async Task<SyncAllEduInfoResponse> SyncAllEduInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncAllEduInfoWithOptionsAsync(runtime);
        }

        /**
         * @summary Unlocks a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @param request UnlockMfaDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockMfaDeviceResponse
         */
        public UnlockMfaDeviceResponse UnlockMfaDeviceWithOptions(UnlockMfaDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdDomain))
            {
                query["AdDomain"] = request.AdDomain;
            }
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
                Action = "UnlockMfaDevice",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockMfaDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unlocks a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @param request UnlockMfaDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockMfaDeviceResponse
         */
        public async Task<UnlockMfaDeviceResponse> UnlockMfaDeviceWithOptionsAsync(UnlockMfaDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdDomain))
            {
                query["AdDomain"] = request.AdDomain;
            }
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
                Action = "UnlockMfaDevice",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockMfaDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unlocks a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @param request UnlockMfaDeviceRequest
         * @return UnlockMfaDeviceResponse
         */
        public UnlockMfaDeviceResponse UnlockMfaDevice(UnlockMfaDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockMfaDeviceWithOptions(request, runtime);
        }

        /**
         * @summary Unlocks a virtual multi-factor authentication (MFA) device that is bound to a convenience user.
         *
         * @param request UnlockMfaDeviceRequest
         * @return UnlockMfaDeviceResponse
         */
        public async Task<UnlockMfaDeviceResponse> UnlockMfaDeviceAsync(UnlockMfaDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockMfaDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Unlocks one or more convenience users.
         *
         * @param request UnlockUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockUsersResponse
         */
        public UnlockUsersResponse UnlockUsersWithOptions(UnlockUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoLockTime))
            {
                query["AutoLockTime"] = request.AutoLockTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnlockUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unlocks one or more convenience users.
         *
         * @param request UnlockUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockUsersResponse
         */
        public async Task<UnlockUsersResponse> UnlockUsersWithOptionsAsync(UnlockUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoLockTime))
            {
                query["AutoLockTime"] = request.AutoLockTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnlockUsers",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unlocks one or more convenience users.
         *
         * @param request UnlockUsersRequest
         * @return UnlockUsersResponse
         */
        public UnlockUsersResponse UnlockUsers(UnlockUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockUsersWithOptions(request, runtime);
        }

        /**
         * @summary Unlocks one or more convenience users.
         *
         * @param request UnlockUsersRequest
         * @return UnlockUsersResponse
         */
        public async Task<UnlockUsersResponse> UnlockUsersAsync(UnlockUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a user property.
         *
         * @param request UpdatePropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePropertyResponse
         */
        public UpdatePropertyResponse UpdatePropertyWithOptions(UpdatePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                body["PropertyId"] = request.PropertyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKey))
            {
                body["PropertyKey"] = request.PropertyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValues))
            {
                body["PropertyValues"] = request.PropertyValues;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePropertyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a user property.
         *
         * @param request UpdatePropertyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePropertyResponse
         */
        public async Task<UpdatePropertyResponse> UpdatePropertyWithOptionsAsync(UpdatePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyId))
            {
                body["PropertyId"] = request.PropertyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKey))
            {
                body["PropertyKey"] = request.PropertyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValues))
            {
                body["PropertyValues"] = request.PropertyValues;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProperty",
                Version = "2021-03-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePropertyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a user property.
         *
         * @param request UpdatePropertyRequest
         * @return UpdatePropertyResponse
         */
        public UpdatePropertyResponse UpdateProperty(UpdatePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePropertyWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a user property.
         *
         * @param request UpdatePropertyRequest
         * @return UpdatePropertyResponse
         */
        public async Task<UpdatePropertyResponse> UpdatePropertyAsync(UpdatePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePropertyWithOptionsAsync(request, runtime);
        }

    }
}
