// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Quickbi_public20220101.Models;

namespace AlibabaCloud.SDK.Quickbi_public20220101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("quickbi-public", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Add selected groups of people incrementally for a single row and column permission rule.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.\\n
         *
         * @param request AddDataLevelPermissionRuleUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDataLevelPermissionRuleUsersResponse
         */
        public AddDataLevelPermissionRuleUsersResponse AddDataLevelPermissionRuleUsersWithOptions(AddDataLevelPermissionRuleUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddUserModel))
            {
                query["AddUserModel"] = request.AddUserModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataLevelPermissionRuleUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataLevelPermissionRuleUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Add selected groups of people incrementally for a single row and column permission rule.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.\\n
         *
         * @param request AddDataLevelPermissionRuleUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDataLevelPermissionRuleUsersResponse
         */
        public async Task<AddDataLevelPermissionRuleUsersResponse> AddDataLevelPermissionRuleUsersWithOptionsAsync(AddDataLevelPermissionRuleUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddUserModel))
            {
                query["AddUserModel"] = request.AddUserModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataLevelPermissionRuleUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataLevelPermissionRuleUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Add selected groups of people incrementally for a single row and column permission rule.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.\\n
         *
         * @param request AddDataLevelPermissionRuleUsersRequest
         * @return AddDataLevelPermissionRuleUsersResponse
         */
        public AddDataLevelPermissionRuleUsersResponse AddDataLevelPermissionRuleUsers(AddDataLevelPermissionRuleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDataLevelPermissionRuleUsersWithOptions(request, runtime);
        }

        /**
         * @summary Add selected groups of people incrementally for a single row and column permission rule.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.\\n
         *
         * @param request AddDataLevelPermissionRuleUsersRequest
         * @return AddDataLevelPermissionRuleUsersResponse
         */
        public async Task<AddDataLevelPermissionRuleUsersResponse> AddDataLevelPermissionRuleUsersAsync(AddDataLevelPermissionRuleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDataLevelPermissionRuleUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 43342***435,1553a****41231
         *
         * @description ROW_LEVEL
         *
         * @param request AddDataLevelPermissionWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDataLevelPermissionWhiteListResponse
         */
        public AddDataLevelPermissionWhiteListResponse AddDataLevelPermissionWhiteListWithOptions(AddDataLevelPermissionWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIds))
            {
                query["TargetIds"] = request.TargetIds;
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
                Action = "AddDataLevelPermissionWhiteList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataLevelPermissionWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 43342***435,1553a****41231
         *
         * @description ROW_LEVEL
         *
         * @param request AddDataLevelPermissionWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDataLevelPermissionWhiteListResponse
         */
        public async Task<AddDataLevelPermissionWhiteListResponse> AddDataLevelPermissionWhiteListWithOptionsAsync(AddDataLevelPermissionWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIds))
            {
                query["TargetIds"] = request.TargetIds;
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
                Action = "AddDataLevelPermissionWhiteList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataLevelPermissionWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 43342***435,1553a****41231
         *
         * @description ROW_LEVEL
         *
         * @param request AddDataLevelPermissionWhiteListRequest
         * @return AddDataLevelPermissionWhiteListResponse
         */
        public AddDataLevelPermissionWhiteListResponse AddDataLevelPermissionWhiteList(AddDataLevelPermissionWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDataLevelPermissionWhiteListWithOptions(request, runtime);
        }

        /**
         * @summary 43342***435,1553a****41231
         *
         * @description ROW_LEVEL
         *
         * @param request AddDataLevelPermissionWhiteListRequest
         * @return AddDataLevelPermissionWhiteListResponse
         */
        public async Task<AddDataLevelPermissionWhiteListResponse> AddDataLevelPermissionWhiteListAsync(AddDataLevelPermissionWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDataLevelPermissionWhiteListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Add a sharing configuration for data works.
         *
         * @param request AddShareReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddShareReportResponse
         */
        public AddShareReportResponse AddShareReportWithOptions(AddShareReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPoint))
            {
                query["AuthPoint"] = request.AuthPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDate))
            {
                query["ExpireDate"] = request.ExpireDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareToId))
            {
                query["ShareToId"] = request.ShareToId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareToType))
            {
                query["ShareToType"] = request.ShareToType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddShareReport",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddShareReportResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Add a sharing configuration for data works.
         *
         * @param request AddShareReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddShareReportResponse
         */
        public async Task<AddShareReportResponse> AddShareReportWithOptionsAsync(AddShareReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPoint))
            {
                query["AuthPoint"] = request.AuthPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDate))
            {
                query["ExpireDate"] = request.ExpireDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareToId))
            {
                query["ShareToId"] = request.ShareToId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareToType))
            {
                query["ShareToType"] = request.ShareToType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddShareReport",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddShareReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Add a sharing configuration for data works.
         *
         * @param request AddShareReportRequest
         * @return AddShareReportResponse
         */
        public AddShareReportResponse AddShareReport(AddShareReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddShareReportWithOptions(request, runtime);
        }

        /**
         * @summary Add a sharing configuration for data works.
         *
         * @param request AddShareReportRequest
         * @return AddShareReportResponse
         */
        public async Task<AddShareReportResponse> AddShareReportAsync(AddShareReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddShareReportWithOptionsAsync(request, runtime);
        }

        /**
         * @summary auditing
         *
         * @param request AddUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserResponse
         */
        public AddUserResponse AddUserWithOptions(AddUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminUser))
            {
                query["AdminUser"] = request.AdminUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthAdminUser))
            {
                query["AuthAdminUser"] = request.AuthAdminUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                query["NickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                body["RoleIds"] = request.RoleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUser",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary auditing
         *
         * @param request AddUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserResponse
         */
        public async Task<AddUserResponse> AddUserWithOptionsAsync(AddUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminUser))
            {
                query["AdminUser"] = request.AdminUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthAdminUser))
            {
                query["AuthAdminUser"] = request.AuthAdminUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                query["NickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                body["RoleIds"] = request.RoleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUser",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary auditing
         *
         * @param request AddUserRequest
         * @return AddUserResponse
         */
        public AddUserResponse AddUser(AddUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserWithOptions(request, runtime);
        }

        /**
         * @summary auditing
         *
         * @param request AddUserRequest
         * @return AddUserResponse
         */
        public async Task<AddUserResponse> AddUserAsync(AddUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the request.
         *
         * @param request AddUserGroupMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserGroupMemberResponse
         */
        public AddUserGroupMemberResponse AddUserGroupMemberWithOptions(AddUserGroupMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserGroupMember",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserGroupMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the request.
         *
         * @param request AddUserGroupMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserGroupMemberResponse
         */
        public async Task<AddUserGroupMemberResponse> AddUserGroupMemberWithOptionsAsync(AddUserGroupMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserGroupMember",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserGroupMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the request.
         *
         * @param request AddUserGroupMemberRequest
         * @return AddUserGroupMemberResponse
         */
        public AddUserGroupMemberResponse AddUserGroupMember(AddUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserGroupMemberWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the request.
         *
         * @param request AddUserGroupMemberRequest
         * @return AddUserGroupMemberResponse
         */
        public async Task<AddUserGroupMemberResponse> AddUserGroupMemberAsync(AddUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserGroupMemberWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Add users to a specified user group at a time.
         *
         * @param request AddUserGroupMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserGroupMembersResponse
         */
        public AddUserGroupMembersResponse AddUserGroupMembersWithOptions(AddUserGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
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
                Action = "AddUserGroupMembers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserGroupMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Add users to a specified user group at a time.
         *
         * @param request AddUserGroupMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserGroupMembersResponse
         */
        public async Task<AddUserGroupMembersResponse> AddUserGroupMembersWithOptionsAsync(AddUserGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
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
                Action = "AddUserGroupMembers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserGroupMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Add users to a specified user group at a time.
         *
         * @param request AddUserGroupMembersRequest
         * @return AddUserGroupMembersResponse
         */
        public AddUserGroupMembersResponse AddUserGroupMembers(AddUserGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserGroupMembersWithOptions(request, runtime);
        }

        /**
         * @summary Add users to a specified user group at a time.
         *
         * @param request AddUserGroupMembersRequest
         * @return AddUserGroupMembersResponse
         */
        public async Task<AddUserGroupMembersResponse> AddUserGroupMembersAsync(AddUserGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserGroupMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Add the metadata of an organization member tag.
         *
         * @param request AddUserTagMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserTagMetaResponse
         */
        public AddUserTagMetaResponse AddUserTagMetaWithOptions(AddUserTagMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagDescription))
            {
                query["TagDescription"] = request.TagDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserTagMeta",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserTagMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Add the metadata of an organization member tag.
         *
         * @param request AddUserTagMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserTagMetaResponse
         */
        public async Task<AddUserTagMetaResponse> AddUserTagMetaWithOptionsAsync(AddUserTagMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagDescription))
            {
                query["TagDescription"] = request.TagDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserTagMeta",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserTagMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Add the metadata of an organization member tag.
         *
         * @param request AddUserTagMetaRequest
         * @return AddUserTagMetaResponse
         */
        public AddUserTagMetaResponse AddUserTagMeta(AddUserTagMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserTagMetaWithOptions(request, runtime);
        }

        /**
         * @summary Add the metadata of an organization member tag.
         *
         * @param request AddUserTagMetaRequest
         * @return AddUserTagMetaResponse
         */
        public async Task<AddUserTagMetaResponse> AddUserTagMetaAsync(AddUserTagMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserTagMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加成员到指定工作空间。
         *
         * @param request AddUserToWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserToWorkspaceResponse
         */
        public AddUserToWorkspaceResponse AddUserToWorkspaceWithOptions(AddUserToWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserToWorkspace",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加成员到指定工作空间。
         *
         * @param request AddUserToWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserToWorkspaceResponse
         */
        public async Task<AddUserToWorkspaceResponse> AddUserToWorkspaceWithOptionsAsync(AddUserToWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserToWorkspace",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加成员到指定工作空间。
         *
         * @param request AddUserToWorkspaceRequest
         * @return AddUserToWorkspaceResponse
         */
        public AddUserToWorkspaceResponse AddUserToWorkspace(AddUserToWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserToWorkspaceWithOptions(request, runtime);
        }

        /**
         * @summary 添加成员到指定工作空间。
         *
         * @param request AddUserToWorkspaceRequest
         * @return AddUserToWorkspaceResponse
         */
        public async Task<AddUserToWorkspaceResponse> AddUserToWorkspaceAsync(AddUserToWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserToWorkspaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量添加成员到工作空间。
         *
         * @param request AddWorkspaceUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkspaceUsersResponse
         */
        public AddWorkspaceUsersResponse AddWorkspaceUsersWithOptions(AddWorkspaceUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量添加成员到工作空间。
         *
         * @param request AddWorkspaceUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkspaceUsersResponse
         */
        public async Task<AddWorkspaceUsersResponse> AddWorkspaceUsersWithOptionsAsync(AddWorkspaceUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量添加成员到工作空间。
         *
         * @param request AddWorkspaceUsersRequest
         * @return AddWorkspaceUsersResponse
         */
        public AddWorkspaceUsersResponse AddWorkspaceUsers(AddWorkspaceUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddWorkspaceUsersWithOptions(request, runtime);
        }

        /**
         * @summary 批量添加成员到工作空间。
         *
         * @param request AddWorkspaceUsersRequest
         * @return AddWorkspaceUsersResponse
         */
        public async Task<AddWorkspaceUsersResponse> AddWorkspaceUsersAsync(AddWorkspaceUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddWorkspaceUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 触发数据集抽取加速。
         *
         * @param request AllotDatasetAccelerationTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllotDatasetAccelerationTaskResponse
         */
        public AllotDatasetAccelerationTaskResponse AllotDatasetAccelerationTaskWithOptions(AllotDatasetAccelerationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllotDatasetAccelerationTask",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllotDatasetAccelerationTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 触发数据集抽取加速。
         *
         * @param request AllotDatasetAccelerationTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllotDatasetAccelerationTaskResponse
         */
        public async Task<AllotDatasetAccelerationTaskResponse> AllotDatasetAccelerationTaskWithOptionsAsync(AllotDatasetAccelerationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllotDatasetAccelerationTask",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllotDatasetAccelerationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 触发数据集抽取加速。
         *
         * @param request AllotDatasetAccelerationTaskRequest
         * @return AllotDatasetAccelerationTaskResponse
         */
        public AllotDatasetAccelerationTaskResponse AllotDatasetAccelerationTask(AllotDatasetAccelerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllotDatasetAccelerationTaskWithOptions(request, runtime);
        }

        /**
         * @summary 触发数据集抽取加速。
         *
         * @param request AllotDatasetAccelerationTaskRequest
         * @return AllotDatasetAccelerationTaskResponse
         */
        public async Task<AllotDatasetAccelerationTaskResponse> AllotDatasetAccelerationTaskAsync(AllotDatasetAccelerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllotDatasetAccelerationTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Batch authorization of BI portal menu will be skipped automatically.
         *
         * @param request AuthorizeMenuRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeMenuResponse
         */
        public AuthorizeMenuResponse AuthorizeMenuWithOptions(AuthorizeMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPointsValue))
            {
                query["AuthPointsValue"] = request.AuthPointsValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuIds))
            {
                query["MenuIds"] = request.MenuIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeMenu",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeMenuResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Batch authorization of BI portal menu will be skipped automatically.
         *
         * @param request AuthorizeMenuRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeMenuResponse
         */
        public async Task<AuthorizeMenuResponse> AuthorizeMenuWithOptionsAsync(AuthorizeMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPointsValue))
            {
                query["AuthPointsValue"] = request.AuthPointsValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuIds))
            {
                query["MenuIds"] = request.MenuIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeMenu",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeMenuResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Batch authorization of BI portal menu will be skipped automatically.
         *
         * @param request AuthorizeMenuRequest
         * @return AuthorizeMenuResponse
         */
        public AuthorizeMenuResponse AuthorizeMenu(AuthorizeMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeMenuWithOptions(request, runtime);
        }

        /**
         * @summary Batch authorization of BI portal menu will be skipped automatically.
         *
         * @param request AuthorizeMenuRequest
         * @return AuthorizeMenuResponse
         */
        public async Task<AuthorizeMenuResponse> AuthorizeMenuAsync(AuthorizeMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeMenuWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量添加飞书用户。
         *
         * @param request BatchAddFeishuUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchAddFeishuUsersResponse
         */
        public BatchAddFeishuUsersResponse BatchAddFeishuUsersWithOptions(BatchAddFeishuUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeishuUsers))
            {
                query["FeishuUsers"] = request.FeishuUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAdmin))
            {
                query["IsAdmin"] = request.IsAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAuthAdmin))
            {
                query["IsAuthAdmin"] = request.IsAuthAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddFeishuUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddFeishuUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量添加飞书用户。
         *
         * @param request BatchAddFeishuUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchAddFeishuUsersResponse
         */
        public async Task<BatchAddFeishuUsersResponse> BatchAddFeishuUsersWithOptionsAsync(BatchAddFeishuUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeishuUsers))
            {
                query["FeishuUsers"] = request.FeishuUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAdmin))
            {
                query["IsAdmin"] = request.IsAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAuthAdmin))
            {
                query["IsAuthAdmin"] = request.IsAuthAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddFeishuUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddFeishuUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量添加飞书用户。
         *
         * @param request BatchAddFeishuUsersRequest
         * @return BatchAddFeishuUsersResponse
         */
        public BatchAddFeishuUsersResponse BatchAddFeishuUsers(BatchAddFeishuUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddFeishuUsersWithOptions(request, runtime);
        }

        /**
         * @summary 批量添加飞书用户。
         *
         * @param request BatchAddFeishuUsersRequest
         * @return BatchAddFeishuUsersResponse
         */
        public async Task<BatchAddFeishuUsersResponse> BatchAddFeishuUsersAsync(BatchAddFeishuUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddFeishuUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据门户菜单ID，取消指定用户、用户组的授权记录。
         *
         * @param request CancelAuthorizationMenuRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelAuthorizationMenuResponse
         */
        public CancelAuthorizationMenuResponse CancelAuthorizationMenuWithOptions(CancelAuthorizationMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuIds))
            {
                query["MenuIds"] = request.MenuIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAuthorizationMenu",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAuthorizationMenuResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据门户菜单ID，取消指定用户、用户组的授权记录。
         *
         * @param request CancelAuthorizationMenuRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelAuthorizationMenuResponse
         */
        public async Task<CancelAuthorizationMenuResponse> CancelAuthorizationMenuWithOptionsAsync(CancelAuthorizationMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuIds))
            {
                query["MenuIds"] = request.MenuIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAuthorizationMenu",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAuthorizationMenuResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据门户菜单ID，取消指定用户、用户组的授权记录。
         *
         * @param request CancelAuthorizationMenuRequest
         * @return CancelAuthorizationMenuResponse
         */
        public CancelAuthorizationMenuResponse CancelAuthorizationMenu(CancelAuthorizationMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAuthorizationMenuWithOptions(request, runtime);
        }

        /**
         * @summary 根据门户菜单ID，取消指定用户、用户组的授权记录。
         *
         * @param request CancelAuthorizationMenuRequest
         * @return CancelAuthorizationMenuResponse
         */
        public async Task<CancelAuthorizationMenuResponse> CancelAuthorizationMenuAsync(CancelAuthorizationMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAuthorizationMenuWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancel the data works from the user\\"s collection.
         *
         * @param request CancelCollectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelCollectionResponse
         */
        public CancelCollectionResponse CancelCollectionWithOptions(CancelCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelCollection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCollectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancel the data works from the user\\"s collection.
         *
         * @param request CancelCollectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelCollectionResponse
         */
        public async Task<CancelCollectionResponse> CancelCollectionWithOptionsAsync(CancelCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelCollection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancel the data works from the user\\"s collection.
         *
         * @param request CancelCollectionRequest
         * @return CancelCollectionResponse
         */
        public CancelCollectionResponse CancelCollection(CancelCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelCollectionWithOptions(request, runtime);
        }

        /**
         * @summary Cancel the data works from the user\\"s collection.
         *
         * @param request CancelCollectionRequest
         * @return CancelCollectionResponse
         */
        public async Task<CancelCollectionResponse> CancelCollectionAsync(CancelCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelCollectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Delete a share authorization for a data work.
         *
         * @param request CancelReportShareRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelReportShareResponse
         */
        public CancelReportShareResponse CancelReportShareWithOptions(CancelReportShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareToIds))
            {
                query["ShareToIds"] = request.ShareToIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareToType))
            {
                query["ShareToType"] = request.ShareToType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelReportShare",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelReportShareResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Delete a share authorization for a data work.
         *
         * @param request CancelReportShareRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelReportShareResponse
         */
        public async Task<CancelReportShareResponse> CancelReportShareWithOptionsAsync(CancelReportShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareToIds))
            {
                query["ShareToIds"] = request.ShareToIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareToType))
            {
                query["ShareToType"] = request.ShareToType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelReportShare",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelReportShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Delete a share authorization for a data work.
         *
         * @param request CancelReportShareRequest
         * @return CancelReportShareResponse
         */
        public CancelReportShareResponse CancelReportShare(CancelReportShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelReportShareWithOptions(request, runtime);
        }

        /**
         * @summary Delete a share authorization for a data work.
         *
         * @param request CancelReportShareRequest
         * @return CancelReportShareResponse
         */
        public async Task<CancelReportShareResponse> CancelReportShareAsync(CancelReportShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelReportShareWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the request.
         *
         * @param request ChangeVisibilityModelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeVisibilityModelResponse
         */
        public ChangeVisibilityModelResponse ChangeVisibilityModelWithOptions(ChangeVisibilityModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuIds))
            {
                query["MenuIds"] = request.MenuIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOnlyWithAccess))
            {
                query["ShowOnlyWithAccess"] = request.ShowOnlyWithAccess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeVisibilityModel",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeVisibilityModelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the request.
         *
         * @param request ChangeVisibilityModelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeVisibilityModelResponse
         */
        public async Task<ChangeVisibilityModelResponse> ChangeVisibilityModelWithOptionsAsync(ChangeVisibilityModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuIds))
            {
                query["MenuIds"] = request.MenuIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOnlyWithAccess))
            {
                query["ShowOnlyWithAccess"] = request.ShowOnlyWithAccess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeVisibilityModel",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeVisibilityModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the request.
         *
         * @param request ChangeVisibilityModelRequest
         * @return ChangeVisibilityModelResponse
         */
        public ChangeVisibilityModelResponse ChangeVisibilityModel(ChangeVisibilityModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeVisibilityModelWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the request.
         *
         * @param request ChangeVisibilityModelRequest
         * @return ChangeVisibilityModelResponse
         */
        public async Task<ChangeVisibilityModelResponse> ChangeVisibilityModelAsync(ChangeVisibilityModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeVisibilityModelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether a user has permissions to view data works, such as dashboards and workbooks.
         *
         * @param request CheckReadableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckReadableResponse
         */
        public CheckReadableResponse CheckReadableWithOptions(CheckReadableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckReadable",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckReadableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether a user has permissions to view data works, such as dashboards and workbooks.
         *
         * @param request CheckReadableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckReadableResponse
         */
        public async Task<CheckReadableResponse> CheckReadableWithOptionsAsync(CheckReadableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckReadable",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckReadableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether a user has permissions to view data works, such as dashboards and workbooks.
         *
         * @param request CheckReadableRequest
         * @return CheckReadableResponse
         */
        public CheckReadableResponse CheckReadable(CheckReadableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckReadableWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether a user has permissions to view data works, such as dashboards and workbooks.
         *
         * @param request CheckReadableRequest
         * @return CheckReadableResponse
         */
        public async Task<CheckReadableResponse> CheckReadableAsync(CheckReadableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckReadableWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 生成三方嵌入的ticket。
         *
         * @param request CreateTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTicketResponse
         */
        public CreateTicketResponse CreateTicketWithOptions(CreateTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmptId))
            {
                query["CmptId"] = request.CmptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParam))
            {
                query["GlobalParam"] = request.GlobalParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNum))
            {
                query["TicketNum"] = request.TicketNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkParam))
            {
                query["WatermarkParam"] = request.WatermarkParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 生成三方嵌入的ticket。
         *
         * @param request CreateTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTicketResponse
         */
        public async Task<CreateTicketResponse> CreateTicketWithOptionsAsync(CreateTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmptId))
            {
                query["CmptId"] = request.CmptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParam))
            {
                query["GlobalParam"] = request.GlobalParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNum))
            {
                query["TicketNum"] = request.TicketNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkParam))
            {
                query["WatermarkParam"] = request.WatermarkParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 生成三方嵌入的ticket。
         *
         * @param request CreateTicketRequest
         * @return CreateTicketResponse
         */
        public CreateTicketResponse CreateTicket(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTicketWithOptions(request, runtime);
        }

        /**
         * @summary 生成三方嵌入的ticket。
         *
         * @param request CreateTicketRequest
         * @return CreateTicketResponse
         */
        public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTicketWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 生成智能小Q嵌入ticket。
         *
         * @param request CreateTicket4CopilotRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTicket4CopilotResponse
         */
        public CreateTicket4CopilotResponse CreateTicket4CopilotWithOptions(CreateTicket4CopilotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopilotId))
            {
                query["CopilotId"] = request.CopilotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNum))
            {
                query["TicketNum"] = request.TicketNum;
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
                Action = "CreateTicket4Copilot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicket4CopilotResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 生成智能小Q嵌入ticket。
         *
         * @param request CreateTicket4CopilotRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTicket4CopilotResponse
         */
        public async Task<CreateTicket4CopilotResponse> CreateTicket4CopilotWithOptionsAsync(CreateTicket4CopilotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopilotId))
            {
                query["CopilotId"] = request.CopilotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNum))
            {
                query["TicketNum"] = request.TicketNum;
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
                Action = "CreateTicket4Copilot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicket4CopilotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 生成智能小Q嵌入ticket。
         *
         * @param request CreateTicket4CopilotRequest
         * @return CreateTicket4CopilotResponse
         */
        public CreateTicket4CopilotResponse CreateTicket4Copilot(CreateTicket4CopilotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTicket4CopilotWithOptions(request, runtime);
        }

        /**
         * @summary 生成智能小Q嵌入ticket。
         *
         * @param request CreateTicket4CopilotRequest
         * @return CreateTicket4CopilotResponse
         */
        public async Task<CreateTicket4CopilotResponse> CreateTicket4CopilotAsync(CreateTicket4CopilotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTicket4CopilotWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Create a user group. You can specify a parent user group.
         *
         * @param request CreateUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserGroupResponse
         */
        public CreateUserGroupResponse CreateUserGroupWithOptions(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserGroupId))
            {
                query["ParentUserGroupId"] = request.ParentUserGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupDescription))
            {
                query["UserGroupDescription"] = request.UserGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupName))
            {
                query["UserGroupName"] = request.UserGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserGroup",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Create a user group. You can specify a parent user group.
         *
         * @param request CreateUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserGroupResponse
         */
        public async Task<CreateUserGroupResponse> CreateUserGroupWithOptionsAsync(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserGroupId))
            {
                query["ParentUserGroupId"] = request.ParentUserGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupDescription))
            {
                query["UserGroupDescription"] = request.UserGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupName))
            {
                query["UserGroupName"] = request.UserGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserGroup",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Create a user group. You can specify a parent user group.
         *
         * @param request CreateUserGroupRequest
         * @return CreateUserGroupResponse
         */
        public CreateUserGroupResponse CreateUserGroup(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserGroupWithOptions(request, runtime);
        }

        /**
         * @summary Create a user group. You can specify a parent user group.
         *
         * @param request CreateUserGroupRequest
         * @return CreateUserGroupResponse
         */
        public async Task<CreateUserGroupResponse> CreateUserGroupAsync(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询引用指定数据集下的作品信息。
         *
         * @param request DataSetBloodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DataSetBloodResponse
         */
        public DataSetBloodResponse DataSetBloodWithOptions(DataSetBloodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetIds))
            {
                query["DataSetIds"] = request.DataSetIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksType))
            {
                query["WorksType"] = request.WorksType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DataSetBlood",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataSetBloodResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询引用指定数据集下的作品信息。
         *
         * @param request DataSetBloodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DataSetBloodResponse
         */
        public async Task<DataSetBloodResponse> DataSetBloodWithOptionsAsync(DataSetBloodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetIds))
            {
                query["DataSetIds"] = request.DataSetIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksType))
            {
                query["WorksType"] = request.WorksType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DataSetBlood",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataSetBloodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询引用指定数据集下的作品信息。
         *
         * @param request DataSetBloodRequest
         * @return DataSetBloodResponse
         */
        public DataSetBloodResponse DataSetBlood(DataSetBloodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DataSetBloodWithOptions(request, runtime);
        }

        /**
         * @summary 查询引用指定数据集下的作品信息。
         *
         * @param request DataSetBloodRequest
         * @return DataSetBloodResponse
         */
        public async Task<DataSetBloodResponse> DataSetBloodAsync(DataSetBloodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DataSetBloodWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询引用指定数据源下的数据集信息。
         *
         * @param request DataSourceBloodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DataSourceBloodResponse
         */
        public DataSourceBloodResponse DataSourceBloodWithOptions(DataSourceBloodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DataSourceBlood",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataSourceBloodResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询引用指定数据源下的数据集信息。
         *
         * @param request DataSourceBloodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DataSourceBloodResponse
         */
        public async Task<DataSourceBloodResponse> DataSourceBloodWithOptionsAsync(DataSourceBloodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DataSourceBlood",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataSourceBloodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询引用指定数据源下的数据集信息。
         *
         * @param request DataSourceBloodRequest
         * @return DataSourceBloodResponse
         */
        public DataSourceBloodResponse DataSourceBlood(DataSourceBloodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DataSourceBloodWithOptions(request, runtime);
        }

        /**
         * @summary 查询引用指定数据源下的数据集信息。
         *
         * @param request DataSourceBloodRequest
         * @return DataSourceBloodResponse
         */
        public async Task<DataSourceBloodResponse> DataSourceBloodAsync(DataSourceBloodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DataSourceBloodWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Update the expiration time of the ticket embedded in the report.
         *
         * @param request DelayTicketExpireTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DelayTicketExpireTimeResponse
         */
        public DelayTicketExpireTimeResponse DelayTicketExpireTimeWithOptions(DelayTicketExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["Ticket"] = request.Ticket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelayTicketExpireTime",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelayTicketExpireTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Update the expiration time of the ticket embedded in the report.
         *
         * @param request DelayTicketExpireTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DelayTicketExpireTimeResponse
         */
        public async Task<DelayTicketExpireTimeResponse> DelayTicketExpireTimeWithOptionsAsync(DelayTicketExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["Ticket"] = request.Ticket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelayTicketExpireTime",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelayTicketExpireTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Update the expiration time of the ticket embedded in the report.
         *
         * @param request DelayTicketExpireTimeRequest
         * @return DelayTicketExpireTimeResponse
         */
        public DelayTicketExpireTimeResponse DelayTicketExpireTime(DelayTicketExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DelayTicketExpireTimeWithOptions(request, runtime);
        }

        /**
         * @summary Update the expiration time of the ticket embedded in the report.
         *
         * @param request DelayTicketExpireTimeRequest
         * @return DelayTicketExpireTimeResponse
         */
        public async Task<DelayTicketExpireTimeResponse> DelayTicketExpireTimeAsync(DelayTicketExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DelayTicketExpireTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary { "ruleId": "a5bb24da- ***-a891683e14da", // The ID of the row-column permission rule. "cubeId": "7c7223ae- ***-3c744528014b", // The ID of the dataset. "delModel": { "userGroups": [ "0d5fb19b- ***-1248 fc27ca51", // Delete the user group ID of the user group. "3d2c23d4-***-f6390f325c2d" ], "users": [ "4334 ***358", // Delete the UserID of the user group. "Huang***3fa822" ] } }
         *
         * @description {"ruleId":"a5bb24da-***-a891683e14da","cubeId":"7c7223ae-***-3c744528014b","delModel":{"userGroups":["0d5fb19b-***-1248fc27ca51","3d2c23d4-***-f6390f325c2d"],"users":["4334***358","Huang***3fa822"]}}
         *
         * @param request DeleteDataLevelPermissionRuleUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataLevelPermissionRuleUsersResponse
         */
        public DeleteDataLevelPermissionRuleUsersResponse DeleteDataLevelPermissionRuleUsersWithOptions(DeleteDataLevelPermissionRuleUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteUserModel))
            {
                query["DeleteUserModel"] = request.DeleteUserModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLevelPermissionRuleUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLevelPermissionRuleUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary { "ruleId": "a5bb24da- ***-a891683e14da", // The ID of the row-column permission rule. "cubeId": "7c7223ae- ***-3c744528014b", // The ID of the dataset. "delModel": { "userGroups": [ "0d5fb19b- ***-1248 fc27ca51", // Delete the user group ID of the user group. "3d2c23d4-***-f6390f325c2d" ], "users": [ "4334 ***358", // Delete the UserID of the user group. "Huang***3fa822" ] } }
         *
         * @description {"ruleId":"a5bb24da-***-a891683e14da","cubeId":"7c7223ae-***-3c744528014b","delModel":{"userGroups":["0d5fb19b-***-1248fc27ca51","3d2c23d4-***-f6390f325c2d"],"users":["4334***358","Huang***3fa822"]}}
         *
         * @param request DeleteDataLevelPermissionRuleUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataLevelPermissionRuleUsersResponse
         */
        public async Task<DeleteDataLevelPermissionRuleUsersResponse> DeleteDataLevelPermissionRuleUsersWithOptionsAsync(DeleteDataLevelPermissionRuleUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteUserModel))
            {
                query["DeleteUserModel"] = request.DeleteUserModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLevelPermissionRuleUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLevelPermissionRuleUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary { "ruleId": "a5bb24da- ***-a891683e14da", // The ID of the row-column permission rule. "cubeId": "7c7223ae- ***-3c744528014b", // The ID of the dataset. "delModel": { "userGroups": [ "0d5fb19b- ***-1248 fc27ca51", // Delete the user group ID of the user group. "3d2c23d4-***-f6390f325c2d" ], "users": [ "4334 ***358", // Delete the UserID of the user group. "Huang***3fa822" ] } }
         *
         * @description {"ruleId":"a5bb24da-***-a891683e14da","cubeId":"7c7223ae-***-3c744528014b","delModel":{"userGroups":["0d5fb19b-***-1248fc27ca51","3d2c23d4-***-f6390f325c2d"],"users":["4334***358","Huang***3fa822"]}}
         *
         * @param request DeleteDataLevelPermissionRuleUsersRequest
         * @return DeleteDataLevelPermissionRuleUsersResponse
         */
        public DeleteDataLevelPermissionRuleUsersResponse DeleteDataLevelPermissionRuleUsers(DeleteDataLevelPermissionRuleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataLevelPermissionRuleUsersWithOptions(request, runtime);
        }

        /**
         * @summary { "ruleId": "a5bb24da- ***-a891683e14da", // The ID of the row-column permission rule. "cubeId": "7c7223ae- ***-3c744528014b", // The ID of the dataset. "delModel": { "userGroups": [ "0d5fb19b- ***-1248 fc27ca51", // Delete the user group ID of the user group. "3d2c23d4-***-f6390f325c2d" ], "users": [ "4334 ***358", // Delete the UserID of the user group. "Huang***3fa822" ] } }
         *
         * @description {"ruleId":"a5bb24da-***-a891683e14da","cubeId":"7c7223ae-***-3c744528014b","delModel":{"userGroups":["0d5fb19b-***-1248fc27ca51","3d2c23d4-***-f6390f325c2d"],"users":["4334***358","Huang***3fa822"]}}
         *
         * @param request DeleteDataLevelPermissionRuleUsersRequest
         * @return DeleteDataLevelPermissionRuleUsersResponse
         */
        public async Task<DeleteDataLevelPermissionRuleUsersResponse> DeleteDataLevelPermissionRuleUsersAsync(DeleteDataLevelPermissionRuleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataLevelPermissionRuleUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the request.
         *
         * @description The ID of the training dataset that you want to remove from the specified custom linguistic model.
         *
         * @param request DeleteDataLevelRuleConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataLevelRuleConfigResponse
         */
        public DeleteDataLevelRuleConfigResponse DeleteDataLevelRuleConfigWithOptions(DeleteDataLevelRuleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLevelRuleConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLevelRuleConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the request.
         *
         * @description The ID of the training dataset that you want to remove from the specified custom linguistic model.
         *
         * @param request DeleteDataLevelRuleConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataLevelRuleConfigResponse
         */
        public async Task<DeleteDataLevelRuleConfigResponse> DeleteDataLevelRuleConfigWithOptionsAsync(DeleteDataLevelRuleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLevelRuleConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLevelRuleConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the request.
         *
         * @description The ID of the training dataset that you want to remove from the specified custom linguistic model.
         *
         * @param request DeleteDataLevelRuleConfigRequest
         * @return DeleteDataLevelRuleConfigResponse
         */
        public DeleteDataLevelRuleConfigResponse DeleteDataLevelRuleConfig(DeleteDataLevelRuleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataLevelRuleConfigWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the request.
         *
         * @description The ID of the training dataset that you want to remove from the specified custom linguistic model.
         *
         * @param request DeleteDataLevelRuleConfigRequest
         * @return DeleteDataLevelRuleConfigResponse
         */
        public async Task<DeleteDataLevelRuleConfigResponse> DeleteDataLevelRuleConfigAsync(DeleteDataLevelRuleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataLevelRuleConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary auditing
         *
         * @param request DeleteTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTicketResponse
         */
        public DeleteTicketResponse DeleteTicketWithOptions(DeleteTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["Ticket"] = request.Ticket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTicket",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTicketResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary auditing
         *
         * @param request DeleteTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTicketResponse
         */
        public async Task<DeleteTicketResponse> DeleteTicketWithOptionsAsync(DeleteTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["Ticket"] = request.Ticket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTicket",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary auditing
         *
         * @param request DeleteTicketRequest
         * @return DeleteTicketResponse
         */
        public DeleteTicketResponse DeleteTicket(DeleteTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTicketWithOptions(request, runtime);
        }

        /**
         * @summary auditing
         *
         * @param request DeleteTicketRequest
         * @return DeleteTicketResponse
         */
        public async Task<DeleteTicketResponse> DeleteTicketAsync(DeleteTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTicketWithOptionsAsync(request, runtime);
        }

        /**
         * @summary auditing
         *
         * @param request DeleteUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferUserId))
            {
                query["TransferUserId"] = request.TransferUserId;
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
                Version = "2022-01-01",
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

        /**
         * @summary auditing
         *
         * @param request DeleteUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferUserId))
            {
                query["TransferUserId"] = request.TransferUserId;
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
                Version = "2022-01-01",
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

        /**
         * @summary auditing
         *
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        /**
         * @summary auditing
         *
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除指定工作空间的成员。
         *
         * @param request DeleteUserFromWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserFromWorkspaceResponse
         */
        public DeleteUserFromWorkspaceResponse DeleteUserFromWorkspaceWithOptions(DeleteUserFromWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserFromWorkspace",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserFromWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定工作空间的成员。
         *
         * @param request DeleteUserFromWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserFromWorkspaceResponse
         */
        public async Task<DeleteUserFromWorkspaceResponse> DeleteUserFromWorkspaceWithOptionsAsync(DeleteUserFromWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserFromWorkspace",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserFromWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定工作空间的成员。
         *
         * @param request DeleteUserFromWorkspaceRequest
         * @return DeleteUserFromWorkspaceResponse
         */
        public DeleteUserFromWorkspaceResponse DeleteUserFromWorkspace(DeleteUserFromWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserFromWorkspaceWithOptions(request, runtime);
        }

        /**
         * @summary 删除指定工作空间的成员。
         *
         * @param request DeleteUserFromWorkspaceRequest
         * @return DeleteUserFromWorkspaceResponse
         */
        public async Task<DeleteUserFromWorkspaceResponse> DeleteUserFromWorkspaceAsync(DeleteUserFromWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserFromWorkspaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a user group in an organization.
         *
         * @param request DeleteUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserGroupResponse
         */
        public DeleteUserGroupResponse DeleteUserGroupWithOptions(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserGroup",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a user group in an organization.
         *
         * @param request DeleteUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserGroupResponse
         */
        public async Task<DeleteUserGroupResponse> DeleteUserGroupWithOptionsAsync(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserGroup",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a user group in an organization.
         *
         * @param request DeleteUserGroupRequest
         * @return DeleteUserGroupResponse
         */
        public DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a user group in an organization.
         *
         * @param request DeleteUserGroupRequest
         * @return DeleteUserGroupResponse
         */
        public async Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a specified member from a specified user group.
         *
         * @param request DeleteUserGroupMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserGroupMemberResponse
         */
        public DeleteUserGroupMemberResponse DeleteUserGroupMemberWithOptions(DeleteUserGroupMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
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
                Action = "DeleteUserGroupMember",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a specified member from a specified user group.
         *
         * @param request DeleteUserGroupMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserGroupMemberResponse
         */
        public async Task<DeleteUserGroupMemberResponse> DeleteUserGroupMemberWithOptionsAsync(DeleteUserGroupMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
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
                Action = "DeleteUserGroupMember",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a specified member from a specified user group.
         *
         * @param request DeleteUserGroupMemberRequest
         * @return DeleteUserGroupMemberResponse
         */
        public DeleteUserGroupMemberResponse DeleteUserGroupMember(DeleteUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupMemberWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a specified member from a specified user group.
         *
         * @param request DeleteUserGroupMemberRequest
         * @return DeleteUserGroupMemberResponse
         */
        public async Task<DeleteUserGroupMemberResponse> DeleteUserGroupMemberAsync(DeleteUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupMemberWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Indicates whether the request is successful. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @param request DeleteUserGroupMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserGroupMembersResponse
         */
        public DeleteUserGroupMembersResponse DeleteUserGroupMembersWithOptions(DeleteUserGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
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
                Action = "DeleteUserGroupMembers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the request is successful. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @param request DeleteUserGroupMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserGroupMembersResponse
         */
        public async Task<DeleteUserGroupMembersResponse> DeleteUserGroupMembersWithOptionsAsync(DeleteUserGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
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
                Action = "DeleteUserGroupMembers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the request is successful. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @param request DeleteUserGroupMembersRequest
         * @return DeleteUserGroupMembersResponse
         */
        public DeleteUserGroupMembersResponse DeleteUserGroupMembers(DeleteUserGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupMembersWithOptions(request, runtime);
        }

        /**
         * @summary Indicates whether the request is successful. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @param request DeleteUserGroupMembersRequest
         * @return DeleteUserGroupMembersResponse
         */
        public async Task<DeleteUserGroupMembersResponse> DeleteUserGroupMembersAsync(DeleteUserGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes the tag metadata of an organization member.
         *
         * @param request DeleteUserTagMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserTagMetaResponse
         */
        public DeleteUserTagMetaResponse DeleteUserTagMetaWithOptions(DeleteUserTagMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserTagMeta",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserTagMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes the tag metadata of an organization member.
         *
         * @param request DeleteUserTagMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserTagMetaResponse
         */
        public async Task<DeleteUserTagMetaResponse> DeleteUserTagMetaWithOptionsAsync(DeleteUserTagMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserTagMeta",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserTagMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes the tag metadata of an organization member.
         *
         * @param request DeleteUserTagMetaRequest
         * @return DeleteUserTagMetaResponse
         */
        public DeleteUserTagMetaResponse DeleteUserTagMeta(DeleteUserTagMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserTagMetaWithOptions(request, runtime);
        }

        /**
         * @summary Deletes the tag metadata of an organization member.
         *
         * @param request DeleteUserTagMetaRequest
         * @return DeleteUserTagMetaResponse
         */
        public async Task<DeleteUserTagMetaResponse> DeleteUserTagMetaAsync(DeleteUserTagMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserTagMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Test description
         *
         * @param request GetUserGroupInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserGroupInfoResponse
         */
        public GetUserGroupInfoResponse GetUserGroupInfoWithOptions(GetUserGroupInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGroupInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGroupInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Test description
         *
         * @param request GetUserGroupInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserGroupInfoResponse
         */
        public async Task<GetUserGroupInfoResponse> GetUserGroupInfoWithOptionsAsync(GetUserGroupInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGroupInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGroupInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Test description
         *
         * @param request GetUserGroupInfoRequest
         * @return GetUserGroupInfoResponse
         */
        public GetUserGroupInfoResponse GetUserGroupInfo(GetUserGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserGroupInfoWithOptions(request, runtime);
        }

        /**
         * @summary Test description
         *
         * @param request GetUserGroupInfoRequest
         * @return GetUserGroupInfoResponse
         */
        public async Task<GetUserGroupInfoResponse> GetUserGroupInfoAsync(GetUserGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserGroupInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询API数据源列表。
         *
         * @param request ListApiDatasourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApiDatasourceResponse
         */
        public ListApiDatasourceResponse ListApiDatasourceWithOptions(ListApiDatasourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiDatasource",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiDatasourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询API数据源列表。
         *
         * @param request ListApiDatasourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApiDatasourceResponse
         */
        public async Task<ListApiDatasourceResponse> ListApiDatasourceWithOptionsAsync(ListApiDatasourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiDatasource",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiDatasourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询API数据源列表。
         *
         * @param request ListApiDatasourceRequest
         * @return ListApiDatasourceResponse
         */
        public ListApiDatasourceResponse ListApiDatasource(ListApiDatasourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApiDatasourceWithOptions(request, runtime);
        }

        /**
         * @summary 查询API数据源列表。
         *
         * @param request ListApiDatasourceRequest
         * @return ListApiDatasourceResponse
         */
        public async Task<ListApiDatasourceResponse> ListApiDatasourceAsync(ListApiDatasourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApiDatasourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries user group information at a time by user group ID.
         *
         * @param request ListByUserGroupIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListByUserGroupIdResponse
         */
        public ListByUserGroupIdResponse ListByUserGroupIdWithOptions(ListByUserGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListByUserGroupId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListByUserGroupIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries user group information at a time by user group ID.
         *
         * @param request ListByUserGroupIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListByUserGroupIdResponse
         */
        public async Task<ListByUserGroupIdResponse> ListByUserGroupIdWithOptionsAsync(ListByUserGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                query["UserGroupIds"] = request.UserGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListByUserGroupId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListByUserGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries user group information at a time by user group ID.
         *
         * @param request ListByUserGroupIdRequest
         * @return ListByUserGroupIdResponse
         */
        public ListByUserGroupIdResponse ListByUserGroupId(ListByUserGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListByUserGroupIdWithOptions(request, runtime);
        }

        /**
         * @summary Queries user group information at a time by user group ID.
         *
         * @param request ListByUserGroupIdRequest
         * @return ListByUserGroupIdResponse
         */
        public async Task<ListByUserGroupIdResponse> ListByUserGroupIdAsync(ListByUserGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListByUserGroupIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the work.
         *
         * @param request ListCollectionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCollectionsResponse
         */
        public ListCollectionsResponse ListCollectionsWithOptions(ListCollectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCollections",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCollectionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the work.
         *
         * @param request ListCollectionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCollectionsResponse
         */
        public async Task<ListCollectionsResponse> ListCollectionsWithOptionsAsync(ListCollectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCollections",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCollectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the work.
         *
         * @param request ListCollectionsRequest
         * @return ListCollectionsResponse
         */
        public ListCollectionsResponse ListCollections(ListCollectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCollectionsWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the work.
         *
         * @param request ListCollectionsRequest
         * @return ListCollectionsResponse
         */
        public async Task<ListCollectionsResponse> ListCollectionsAsync(ListCollectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCollectionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can this operation to obtain a list of row and column permission configurations for a specified dataset.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.
         *
         * @param request ListCubeDataLevelPermissionConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCubeDataLevelPermissionConfigResponse
         */
        public ListCubeDataLevelPermissionConfigResponse ListCubeDataLevelPermissionConfigWithOptions(ListCubeDataLevelPermissionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCubeDataLevelPermissionConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCubeDataLevelPermissionConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can this operation to obtain a list of row and column permission configurations for a specified dataset.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.
         *
         * @param request ListCubeDataLevelPermissionConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCubeDataLevelPermissionConfigResponse
         */
        public async Task<ListCubeDataLevelPermissionConfigResponse> ListCubeDataLevelPermissionConfigWithOptionsAsync(ListCubeDataLevelPermissionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCubeDataLevelPermissionConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCubeDataLevelPermissionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can this operation to obtain a list of row and column permission configurations for a specified dataset.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.
         *
         * @param request ListCubeDataLevelPermissionConfigRequest
         * @return ListCubeDataLevelPermissionConfigResponse
         */
        public ListCubeDataLevelPermissionConfigResponse ListCubeDataLevelPermissionConfig(ListCubeDataLevelPermissionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCubeDataLevelPermissionConfigWithOptions(request, runtime);
        }

        /**
         * @summary You can this operation to obtain a list of row and column permission configurations for a specified dataset.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.
         *
         * @param request ListCubeDataLevelPermissionConfigRequest
         * @return ListCubeDataLevelPermissionConfigResponse
         */
        public async Task<ListCubeDataLevelPermissionConfigResponse> ListCubeDataLevelPermissionConfigAsync(ListCubeDataLevelPermissionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCubeDataLevelPermissionConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据行列权限种类，获取数据集行列权限的白名单列表。
         *
         * @param request ListDataLevelPermissionWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataLevelPermissionWhiteListResponse
         */
        public ListDataLevelPermissionWhiteListResponse ListDataLevelPermissionWhiteListWithOptions(ListDataLevelPermissionWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLevelPermissionWhiteList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLevelPermissionWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据行列权限种类，获取数据集行列权限的白名单列表。
         *
         * @param request ListDataLevelPermissionWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataLevelPermissionWhiteListResponse
         */
        public async Task<ListDataLevelPermissionWhiteListResponse> ListDataLevelPermissionWhiteListWithOptionsAsync(ListDataLevelPermissionWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLevelPermissionWhiteList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLevelPermissionWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据行列权限种类，获取数据集行列权限的白名单列表。
         *
         * @param request ListDataLevelPermissionWhiteListRequest
         * @return ListDataLevelPermissionWhiteListResponse
         */
        public ListDataLevelPermissionWhiteListResponse ListDataLevelPermissionWhiteList(ListDataLevelPermissionWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLevelPermissionWhiteListWithOptions(request, runtime);
        }

        /**
         * @summary 根据行列权限种类，获取数据集行列权限的白名单列表。
         *
         * @param request ListDataLevelPermissionWhiteListRequest
         * @return ListDataLevelPermissionWhiteListResponse
         */
        public async Task<ListDataLevelPermissionWhiteListResponse> ListDataLevelPermissionWhiteListAsync(ListDataLevelPermissionWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLevelPermissionWhiteListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取指定用户在首页看板中展示的收藏作品列表。
         *
         * @param request ListFavoriteReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFavoriteReportsResponse
         */
        public ListFavoriteReportsResponse ListFavoriteReportsWithOptions(ListFavoriteReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TreeType))
            {
                query["TreeType"] = request.TreeType;
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
                Action = "ListFavoriteReports",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFavoriteReportsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定用户在首页看板中展示的收藏作品列表。
         *
         * @param request ListFavoriteReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFavoriteReportsResponse
         */
        public async Task<ListFavoriteReportsResponse> ListFavoriteReportsWithOptionsAsync(ListFavoriteReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TreeType))
            {
                query["TreeType"] = request.TreeType;
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
                Action = "ListFavoriteReports",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFavoriteReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定用户在首页看板中展示的收藏作品列表。
         *
         * @param request ListFavoriteReportsRequest
         * @return ListFavoriteReportsResponse
         */
        public ListFavoriteReportsResponse ListFavoriteReports(ListFavoriteReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFavoriteReportsWithOptions(request, runtime);
        }

        /**
         * @summary 获取指定用户在首页看板中展示的收藏作品列表。
         *
         * @param request ListFavoriteReportsRequest
         * @return ListFavoriteReportsResponse
         */
        public async Task<ListFavoriteReportsResponse> ListFavoriteReportsAsync(ListFavoriteReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFavoriteReportsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取指定组织角色下的用户列表。
         *
         * @param request ListOrganizationRoleUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationRoleUsersResponse
         */
        public ListOrganizationRoleUsersResponse ListOrganizationRoleUsersWithOptions(ListOrganizationRoleUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationRoleUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationRoleUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定组织角色下的用户列表。
         *
         * @param request ListOrganizationRoleUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationRoleUsersResponse
         */
        public async Task<ListOrganizationRoleUsersResponse> ListOrganizationRoleUsersWithOptionsAsync(ListOrganizationRoleUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationRoleUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationRoleUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定组织角色下的用户列表。
         *
         * @param request ListOrganizationRoleUsersRequest
         * @return ListOrganizationRoleUsersResponse
         */
        public ListOrganizationRoleUsersResponse ListOrganizationRoleUsers(ListOrganizationRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrganizationRoleUsersWithOptions(request, runtime);
        }

        /**
         * @summary 获取指定组织角色下的用户列表。
         *
         * @param request ListOrganizationRoleUsersRequest
         * @return ListOrganizationRoleUsersResponse
         */
        public async Task<ListOrganizationRoleUsersResponse> ListOrganizationRoleUsersAsync(ListOrganizationRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrganizationRoleUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取组织级别自定义角色列表。
         *
         * @param request ListOrganizationRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationRolesResponse
         */
        public ListOrganizationRolesResponse ListOrganizationRolesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationRoles",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationRolesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取组织级别自定义角色列表。
         *
         * @param request ListOrganizationRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationRolesResponse
         */
        public async Task<ListOrganizationRolesResponse> ListOrganizationRolesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationRoles",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取组织级别自定义角色列表。
         *
         * @return ListOrganizationRolesResponse
         */
        public ListOrganizationRolesResponse ListOrganizationRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrganizationRolesWithOptions(runtime);
        }

        /**
         * @summary 获取组织级别自定义角色列表。
         *
         * @return ListOrganizationRolesResponse
         */
        public async Task<ListOrganizationRolesResponse> ListOrganizationRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrganizationRolesWithOptionsAsync(runtime);
        }

        /**
         * @summary Obtains the list of authorization details for a BI portal menu.
         *
         * @param request ListPortalMenuAuthorizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPortalMenuAuthorizationResponse
         */
        public ListPortalMenuAuthorizationResponse ListPortalMenuAuthorizationWithOptions(ListPortalMenuAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPortalMenuAuthorization",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPortalMenuAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the list of authorization details for a BI portal menu.
         *
         * @param request ListPortalMenuAuthorizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPortalMenuAuthorizationResponse
         */
        public async Task<ListPortalMenuAuthorizationResponse> ListPortalMenuAuthorizationWithOptionsAsync(ListPortalMenuAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPortalMenuAuthorization",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPortalMenuAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the list of authorization details for a BI portal menu.
         *
         * @param request ListPortalMenuAuthorizationRequest
         * @return ListPortalMenuAuthorizationResponse
         */
        public ListPortalMenuAuthorizationResponse ListPortalMenuAuthorization(ListPortalMenuAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPortalMenuAuthorizationWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the list of authorization details for a BI portal menu.
         *
         * @param request ListPortalMenuAuthorizationRequest
         * @return ListPortalMenuAuthorizationResponse
         */
        public async Task<ListPortalMenuAuthorizationResponse> ListPortalMenuAuthorizationAsync(ListPortalMenuAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPortalMenuAuthorizationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Gets a hierarchical list of menus under a specific BI portal.
         *
         * @param request ListPortalMenusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPortalMenusResponse
         */
        public ListPortalMenusResponse ListPortalMenusWithOptions(ListPortalMenusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
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
                Action = "ListPortalMenus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPortalMenusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Gets a hierarchical list of menus under a specific BI portal.
         *
         * @param request ListPortalMenusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPortalMenusResponse
         */
        public async Task<ListPortalMenusResponse> ListPortalMenusWithOptionsAsync(ListPortalMenusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPortalId))
            {
                query["DataPortalId"] = request.DataPortalId;
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
                Action = "ListPortalMenus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPortalMenusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Gets a hierarchical list of menus under a specific BI portal.
         *
         * @param request ListPortalMenusRequest
         * @return ListPortalMenusResponse
         */
        public ListPortalMenusResponse ListPortalMenus(ListPortalMenusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPortalMenusWithOptions(request, runtime);
        }

        /**
         * @summary Gets a hierarchical list of menus under a specific BI portal.
         *
         * @param request ListPortalMenusRequest
         * @return ListPortalMenusResponse
         */
        public async Task<ListPortalMenusResponse> ListPortalMenusAsync(ListPortalMenusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPortalMenusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取首页看板常看和足迹列表。
         *
         * @param request ListRecentViewReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecentViewReportsResponse
         */
        public ListRecentViewReportsResponse ListRecentViewReportsWithOptions(ListRecentViewReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OffsetDay))
            {
                query["OffsetDay"] = request.OffsetDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TreeType))
            {
                query["TreeType"] = request.TreeType;
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
                Action = "ListRecentViewReports",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentViewReportsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取首页看板常看和足迹列表。
         *
         * @param request ListRecentViewReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecentViewReportsResponse
         */
        public async Task<ListRecentViewReportsResponse> ListRecentViewReportsWithOptionsAsync(ListRecentViewReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OffsetDay))
            {
                query["OffsetDay"] = request.OffsetDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TreeType))
            {
                query["TreeType"] = request.TreeType;
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
                Action = "ListRecentViewReports",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentViewReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取首页看板常看和足迹列表。
         *
         * @param request ListRecentViewReportsRequest
         * @return ListRecentViewReportsResponse
         */
        public ListRecentViewReportsResponse ListRecentViewReports(ListRecentViewReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecentViewReportsWithOptions(request, runtime);
        }

        /**
         * @summary 获取首页看板常看和足迹列表。
         *
         * @param request ListRecentViewReportsRequest
         * @return ListRecentViewReportsResponse
         */
        public async Task<ListRecentViewReportsResponse> ListRecentViewReportsAsync(ListRecentViewReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecentViewReportsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取指定用户在首页看板中展示的被授权的作品列表。
         *
         * @param request ListSharedReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSharedReportsResponse
         */
        public ListSharedReportsResponse ListSharedReportsWithOptions(ListSharedReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TreeType))
            {
                query["TreeType"] = request.TreeType;
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
                Action = "ListSharedReports",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSharedReportsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定用户在首页看板中展示的被授权的作品列表。
         *
         * @param request ListSharedReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSharedReportsResponse
         */
        public async Task<ListSharedReportsResponse> ListSharedReportsWithOptionsAsync(ListSharedReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TreeType))
            {
                query["TreeType"] = request.TreeType;
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
                Action = "ListSharedReports",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSharedReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定用户在首页看板中展示的被授权的作品列表。
         *
         * @param request ListSharedReportsRequest
         * @return ListSharedReportsResponse
         */
        public ListSharedReportsResponse ListSharedReports(ListSharedReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedReportsWithOptions(request, runtime);
        }

        /**
         * @summary 获取指定用户在首页看板中展示的被授权的作品列表。
         *
         * @param request ListSharedReportsRequest
         * @return ListSharedReportsResponse
         */
        public async Task<ListSharedReportsResponse> ListSharedReportsAsync(ListSharedReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedReportsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Description
         *
         * @param request ListUserGroupsByUserIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserGroupsByUserIdResponse
         */
        public ListUserGroupsByUserIdResponse ListUserGroupsByUserIdWithOptions(ListUserGroupsByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListUserGroupsByUserId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsByUserIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Description
         *
         * @param request ListUserGroupsByUserIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserGroupsByUserIdResponse
         */
        public async Task<ListUserGroupsByUserIdResponse> ListUserGroupsByUserIdWithOptionsAsync(ListUserGroupsByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListUserGroupsByUserId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsByUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Description
         *
         * @param request ListUserGroupsByUserIdRequest
         * @return ListUserGroupsByUserIdResponse
         */
        public ListUserGroupsByUserIdResponse ListUserGroupsByUserId(ListUserGroupsByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsByUserIdWithOptions(request, runtime);
        }

        /**
         * @summary Description
         *
         * @param request ListUserGroupsByUserIdRequest
         * @return ListUserGroupsByUserIdResponse
         */
        public async Task<ListUserGroupsByUserIdResponse> ListUserGroupsByUserIdAsync(ListUserGroupsByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsByUserIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取指定空间角色下的用户列表。
         *
         * @param request ListWorkspaceRoleUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkspaceRoleUsersResponse
         */
        public ListWorkspaceRoleUsersResponse ListWorkspaceRoleUsersWithOptions(ListWorkspaceRoleUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaceRoleUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceRoleUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定空间角色下的用户列表。
         *
         * @param request ListWorkspaceRoleUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkspaceRoleUsersResponse
         */
        public async Task<ListWorkspaceRoleUsersResponse> ListWorkspaceRoleUsersWithOptionsAsync(ListWorkspaceRoleUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaceRoleUsers",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceRoleUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定空间角色下的用户列表。
         *
         * @param request ListWorkspaceRoleUsersRequest
         * @return ListWorkspaceRoleUsersResponse
         */
        public ListWorkspaceRoleUsersResponse ListWorkspaceRoleUsers(ListWorkspaceRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkspaceRoleUsersWithOptions(request, runtime);
        }

        /**
         * @summary 获取指定空间角色下的用户列表。
         *
         * @param request ListWorkspaceRoleUsersRequest
         * @return ListWorkspaceRoleUsersResponse
         */
        public async Task<ListWorkspaceRoleUsersResponse> ListWorkspaceRoleUsersAsync(ListWorkspaceRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkspaceRoleUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取空间角色列表。
         *
         * @param request ListWorkspaceRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkspaceRolesResponse
         */
        public ListWorkspaceRolesResponse ListWorkspaceRolesWithOptions(ListWorkspaceRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaceRoles",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceRolesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取空间角色列表。
         *
         * @param request ListWorkspaceRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkspaceRolesResponse
         */
        public async Task<ListWorkspaceRolesResponse> ListWorkspaceRolesWithOptionsAsync(ListWorkspaceRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaceRoles",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取空间角色列表。
         *
         * @param request ListWorkspaceRolesRequest
         * @return ListWorkspaceRolesResponse
         */
        public ListWorkspaceRolesResponse ListWorkspaceRoles(ListWorkspaceRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkspaceRolesWithOptions(request, runtime);
        }

        /**
         * @summary 获取空间角色列表。
         *
         * @param request ListWorkspaceRolesRequest
         * @return ListWorkspaceRolesResponse
         */
        public async Task<ListWorkspaceRolesResponse> ListWorkspaceRolesAsync(ListWorkspaceRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkspaceRolesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改指定API数据源参数值。
         *
         * @param request ModifyApiDatasourceParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyApiDatasourceParametersResponse
         */
        public ModifyApiDatasourceParametersResponse ModifyApiDatasourceParametersWithOptions(ModifyApiDatasourceParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApiDatasourceParameters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyApiDatasourceParametersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改指定API数据源参数值。
         *
         * @param request ModifyApiDatasourceParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyApiDatasourceParametersResponse
         */
        public async Task<ModifyApiDatasourceParametersResponse> ModifyApiDatasourceParametersWithOptionsAsync(ModifyApiDatasourceParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApiDatasourceParameters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyApiDatasourceParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改指定API数据源参数值。
         *
         * @param request ModifyApiDatasourceParametersRequest
         * @return ModifyApiDatasourceParametersResponse
         */
        public ModifyApiDatasourceParametersResponse ModifyApiDatasourceParameters(ModifyApiDatasourceParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyApiDatasourceParametersWithOptions(request, runtime);
        }

        /**
         * @summary 修改指定API数据源参数值。
         *
         * @param request ModifyApiDatasourceParametersRequest
         * @return ModifyApiDatasourceParametersResponse
         */
        public async Task<ModifyApiDatasourceParametersResponse> ModifyApiDatasourceParametersAsync(ModifyApiDatasourceParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyApiDatasourceParametersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改智能问数嵌入配置。
         *
         * @param request ModifyCopilotEmbedConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyCopilotEmbedConfigResponse
         */
        public ModifyCopilotEmbedConfigResponse ModifyCopilotEmbedConfigWithOptions(ModifyCopilotEmbedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                query["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopilotId))
            {
                query["CopilotId"] = request.CopilotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataRange))
            {
                query["DataRange"] = request.DataRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCopilotEmbedConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCopilotEmbedConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改智能问数嵌入配置。
         *
         * @param request ModifyCopilotEmbedConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyCopilotEmbedConfigResponse
         */
        public async Task<ModifyCopilotEmbedConfigResponse> ModifyCopilotEmbedConfigWithOptionsAsync(ModifyCopilotEmbedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                query["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopilotId))
            {
                query["CopilotId"] = request.CopilotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataRange))
            {
                query["DataRange"] = request.DataRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCopilotEmbedConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCopilotEmbedConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改智能问数嵌入配置。
         *
         * @param request ModifyCopilotEmbedConfigRequest
         * @return ModifyCopilotEmbedConfigResponse
         */
        public ModifyCopilotEmbedConfigResponse ModifyCopilotEmbedConfig(ModifyCopilotEmbedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCopilotEmbedConfigWithOptions(request, runtime);
        }

        /**
         * @summary 修改智能问数嵌入配置。
         *
         * @param request ModifyCopilotEmbedConfigRequest
         * @return ModifyCopilotEmbedConfigResponse
         */
        public async Task<ModifyCopilotEmbedConfigResponse> ModifyCopilotEmbedConfigAsync(ModifyCopilotEmbedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCopilotEmbedConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据审批人获取相应的审批流信息。
         *
         * @param request QueryApprovalInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryApprovalInfoResponse
         */
        public QueryApprovalInfoResponse QueryApprovalInfoWithOptions(QueryApprovalInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "QueryApprovalInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApprovalInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据审批人获取相应的审批流信息。
         *
         * @param request QueryApprovalInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryApprovalInfoResponse
         */
        public async Task<QueryApprovalInfoResponse> QueryApprovalInfoWithOptionsAsync(QueryApprovalInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "QueryApprovalInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApprovalInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据审批人获取相应的审批流信息。
         *
         * @param request QueryApprovalInfoRequest
         * @return QueryApprovalInfoResponse
         */
        public QueryApprovalInfoResponse QueryApprovalInfo(QueryApprovalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryApprovalInfoWithOptions(request, runtime);
        }

        /**
         * @summary 根据审批人获取相应的审批流信息。
         *
         * @param request QueryApprovalInfoRequest
         * @return QueryApprovalInfoResponse
         */
        public async Task<QueryApprovalInfoResponse> QueryApprovalInfoAsync(QueryApprovalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryApprovalInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询审计日志信息。
         *
         * @param request QueryAuditLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAuditLogResponse
         */
        public QueryAuditLogResponse QueryAuditLogWithOptions(QueryAuditLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["OperatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorTypes))
            {
                query["OperatorTypes"] = request.OperatorTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuditLog",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuditLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询审计日志信息。
         *
         * @param request QueryAuditLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAuditLogResponse
         */
        public async Task<QueryAuditLogResponse> QueryAuditLogWithOptionsAsync(QueryAuditLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["OperatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorTypes))
            {
                query["OperatorTypes"] = request.OperatorTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuditLog",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuditLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询审计日志信息。
         *
         * @param request QueryAuditLogRequest
         * @return QueryAuditLogResponse
         */
        public QueryAuditLogResponse QueryAuditLog(QueryAuditLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAuditLogWithOptions(request, runtime);
        }

        /**
         * @summary 查询审计日志信息。
         *
         * @param request QueryAuditLogRequest
         * @return QueryAuditLogResponse
         */
        public async Task<QueryAuditLogResponse> QueryAuditLogAsync(QueryAuditLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAuditLogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询组件性能列表。
         *
         * @param request QueryComponentPerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryComponentPerformanceResponse
         */
        public QueryComponentPerformanceResponse QueryComponentPerformanceWithOptions(QueryComponentPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostTimeAvgMin))
            {
                query["CostTimeAvgMin"] = request.CostTimeAvgMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryComponentPerformance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryComponentPerformanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询组件性能列表。
         *
         * @param request QueryComponentPerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryComponentPerformanceResponse
         */
        public async Task<QueryComponentPerformanceResponse> QueryComponentPerformanceWithOptionsAsync(QueryComponentPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostTimeAvgMin))
            {
                query["CostTimeAvgMin"] = request.CostTimeAvgMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryComponentPerformance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryComponentPerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询组件性能列表。
         *
         * @param request QueryComponentPerformanceRequest
         * @return QueryComponentPerformanceResponse
         */
        public QueryComponentPerformanceResponse QueryComponentPerformance(QueryComponentPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryComponentPerformanceWithOptions(request, runtime);
        }

        /**
         * @summary 查询组件性能列表。
         *
         * @param request QueryComponentPerformanceRequest
         * @return QueryComponentPerformanceResponse
         */
        public async Task<QueryComponentPerformanceResponse> QueryComponentPerformanceAsync(QueryComponentPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryComponentPerformanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取开通小Q嵌入的配置列表。
         *
         * @param request QueryCopilotEmbedConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCopilotEmbedConfigResponse
         */
        public QueryCopilotEmbedConfigResponse QueryCopilotEmbedConfigWithOptions(QueryCopilotEmbedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCopilotEmbedConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCopilotEmbedConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取开通小Q嵌入的配置列表。
         *
         * @param request QueryCopilotEmbedConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCopilotEmbedConfigResponse
         */
        public async Task<QueryCopilotEmbedConfigResponse> QueryCopilotEmbedConfigWithOptionsAsync(QueryCopilotEmbedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCopilotEmbedConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCopilotEmbedConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取开通小Q嵌入的配置列表。
         *
         * @param request QueryCopilotEmbedConfigRequest
         * @return QueryCopilotEmbedConfigResponse
         */
        public QueryCopilotEmbedConfigResponse QueryCopilotEmbedConfig(QueryCopilotEmbedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCopilotEmbedConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取开通小Q嵌入的配置列表。
         *
         * @param request QueryCopilotEmbedConfigRequest
         * @return QueryCopilotEmbedConfigResponse
         */
        public async Task<QueryCopilotEmbedConfigResponse> QueryCopilotEmbedConfigAsync(QueryCopilotEmbedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCopilotEmbedConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询数据集优化建议。
         *
         * @param request QueryCubeOptimizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCubeOptimizationResponse
         */
        public QueryCubeOptimizationResponse QueryCubeOptimizationWithOptions(QueryCubeOptimizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCubeOptimization",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCubeOptimizationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询数据集优化建议。
         *
         * @param request QueryCubeOptimizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCubeOptimizationResponse
         */
        public async Task<QueryCubeOptimizationResponse> QueryCubeOptimizationWithOptionsAsync(QueryCubeOptimizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCubeOptimization",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCubeOptimizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数据集优化建议。
         *
         * @param request QueryCubeOptimizationRequest
         * @return QueryCubeOptimizationResponse
         */
        public QueryCubeOptimizationResponse QueryCubeOptimization(QueryCubeOptimizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCubeOptimizationWithOptions(request, runtime);
        }

        /**
         * @summary 查询数据集优化建议。
         *
         * @param request QueryCubeOptimizationRequest
         * @return QueryCubeOptimizationResponse
         */
        public async Task<QueryCubeOptimizationResponse> QueryCubeOptimizationAsync(QueryCubeOptimizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCubeOptimizationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询数据集性能。
         *
         * @param request QueryCubePerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCubePerformanceResponse
         */
        public QueryCubePerformanceResponse QueryCubePerformanceWithOptions(QueryCubePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostTimeAvgMin))
            {
                query["CostTimeAvgMin"] = request.CostTimeAvgMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCubePerformance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCubePerformanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询数据集性能。
         *
         * @param request QueryCubePerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCubePerformanceResponse
         */
        public async Task<QueryCubePerformanceResponse> QueryCubePerformanceWithOptionsAsync(QueryCubePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostTimeAvgMin))
            {
                query["CostTimeAvgMin"] = request.CostTimeAvgMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCubePerformance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCubePerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数据集性能。
         *
         * @param request QueryCubePerformanceRequest
         * @return QueryCubePerformanceResponse
         */
        public QueryCubePerformanceResponse QueryCubePerformance(QueryCubePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCubePerformanceWithOptions(request, runtime);
        }

        /**
         * @summary 查询数据集性能。
         *
         * @param request QueryCubePerformanceRequest
         * @return QueryCubePerformanceResponse
         */
        public async Task<QueryCubePerformanceResponse> QueryCubePerformanceAsync(QueryCubePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCubePerformanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用开放数据服务API。
         *
         * @param request QueryDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDataResponse
         */
        public QueryDataResponse QueryDataWithOptions(QueryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conditions))
            {
                query["Conditions"] = request.Conditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFields))
            {
                query["ReturnFields"] = request.ReturnFields;
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
                Action = "QueryData",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用开放数据服务API。
         *
         * @param request QueryDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDataResponse
         */
        public async Task<QueryDataResponse> QueryDataWithOptionsAsync(QueryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conditions))
            {
                query["Conditions"] = request.Conditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFields))
            {
                query["ReturnFields"] = request.ReturnFields;
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
                Action = "QueryData",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用开放数据服务API。
         *
         * @param request QueryDataRequest
         * @return QueryDataResponse
         */
        public QueryDataResponse QueryData(QueryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDataWithOptions(request, runtime);
        }

        /**
         * @summary 调用开放数据服务API。
         *
         * @param request QueryDataRequest
         * @return QueryDataResponse
         */
        public async Task<QueryDataResponse> QueryDataAsync(QueryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取数据范围目录列表。
         *
         * @param request QueryDataRangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDataRangeResponse
         */
        public QueryDataRangeResponse QueryDataRangeWithOptions(QueryDataRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDataRange",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataRangeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取数据范围目录列表。
         *
         * @param request QueryDataRangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDataRangeResponse
         */
        public async Task<QueryDataRangeResponse> QueryDataRangeWithOptionsAsync(QueryDataRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDataRange",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataRangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取数据范围目录列表。
         *
         * @param request QueryDataRangeRequest
         * @return QueryDataRangeResponse
         */
        public QueryDataRangeResponse QueryDataRange(QueryDataRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDataRangeWithOptions(request, runtime);
        }

        /**
         * @summary 获取数据范围目录列表。
         *
         * @param request QueryDataRangeRequest
         * @return QueryDataRangeResponse
         */
        public async Task<QueryDataRangeResponse> QueryDataRangeAsync(QueryDataRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDataRangeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The operator for the aggregate operation. Metric fields are available, such as SUM, AVG, and MAX.
         *
         * @description f4cc43bc3***
         *
         * @param request QueryDataServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDataServiceResponse
         */
        public QueryDataServiceResponse QueryDataServiceWithOptions(QueryDataServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conditions))
            {
                query["Conditions"] = request.Conditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFields))
            {
                query["ReturnFields"] = request.ReturnFields;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDataService",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The operator for the aggregate operation. Metric fields are available, such as SUM, AVG, and MAX.
         *
         * @description f4cc43bc3***
         *
         * @param request QueryDataServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDataServiceResponse
         */
        public async Task<QueryDataServiceResponse> QueryDataServiceWithOptionsAsync(QueryDataServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conditions))
            {
                query["Conditions"] = request.Conditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFields))
            {
                query["ReturnFields"] = request.ReturnFields;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDataService",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The operator for the aggregate operation. Metric fields are available, such as SUM, AVG, and MAX.
         *
         * @description f4cc43bc3***
         *
         * @param request QueryDataServiceRequest
         * @return QueryDataServiceResponse
         */
        public QueryDataServiceResponse QueryDataService(QueryDataServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDataServiceWithOptions(request, runtime);
        }

        /**
         * @summary The operator for the aggregate operation. Metric fields are available, such as SUM, AVG, and MAX.
         *
         * @description f4cc43bc3***
         *
         * @param request QueryDataServiceRequest
         * @return QueryDataServiceResponse
         */
        public async Task<QueryDataServiceResponse> QueryDataServiceAsync(QueryDataServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDataServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询数据服务API列表。
         *
         * @param request QueryDataServiceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDataServiceListResponse
         */
        public QueryDataServiceListResponse QueryDataServiceListWithOptions(QueryDataServiceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "QueryDataServiceList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataServiceListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询数据服务API列表。
         *
         * @param request QueryDataServiceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDataServiceListResponse
         */
        public async Task<QueryDataServiceListResponse> QueryDataServiceListWithOptionsAsync(QueryDataServiceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "QueryDataServiceList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataServiceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数据服务API列表。
         *
         * @param request QueryDataServiceListRequest
         * @return QueryDataServiceListResponse
         */
        public QueryDataServiceListResponse QueryDataServiceList(QueryDataServiceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDataServiceListWithOptions(request, runtime);
        }

        /**
         * @summary 查询数据服务API列表。
         *
         * @param request QueryDataServiceListRequest
         * @return QueryDataServiceListResponse
         */
        public async Task<QueryDataServiceListResponse> QueryDataServiceListAsync(QueryDataServiceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDataServiceListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a specified dataset, including the data source, directory, and dataset model.
         *
         * @description The data source, directory, and dataset model (including dimensions, measures, physical fields, custom SQL text, and association relationships).
         *
         * @param request QueryDatasetDetailInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDatasetDetailInfoResponse
         */
        public QueryDatasetDetailInfoResponse QueryDatasetDetailInfoWithOptions(QueryDatasetDetailInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["DatasetId"] = request.DatasetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDatasetDetailInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDatasetDetailInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a specified dataset, including the data source, directory, and dataset model.
         *
         * @description The data source, directory, and dataset model (including dimensions, measures, physical fields, custom SQL text, and association relationships).
         *
         * @param request QueryDatasetDetailInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDatasetDetailInfoResponse
         */
        public async Task<QueryDatasetDetailInfoResponse> QueryDatasetDetailInfoWithOptionsAsync(QueryDatasetDetailInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["DatasetId"] = request.DatasetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDatasetDetailInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDatasetDetailInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a specified dataset, including the data source, directory, and dataset model.
         *
         * @description The data source, directory, and dataset model (including dimensions, measures, physical fields, custom SQL text, and association relationships).
         *
         * @param request QueryDatasetDetailInfoRequest
         * @return QueryDatasetDetailInfoResponse
         */
        public QueryDatasetDetailInfoResponse QueryDatasetDetailInfo(QueryDatasetDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDatasetDetailInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a specified dataset, including the data source, directory, and dataset model.
         *
         * @description The data source, directory, and dataset model (including dimensions, measures, physical fields, custom SQL text, and association relationships).
         *
         * @param request QueryDatasetDetailInfoRequest
         * @return QueryDatasetDetailInfoResponse
         */
        public async Task<QueryDatasetDetailInfoResponse> QueryDatasetDetailInfoAsync(QueryDatasetDetailInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDatasetDetailInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Indicates whether the table is a custom SQL table. Valid values:
         * *   true: custom SQL table
         * *   false: non-custom SQL table
         *
         * @param request QueryDatasetInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDatasetInfoResponse
         */
        public QueryDatasetInfoResponse QueryDatasetInfoWithOptions(QueryDatasetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["DatasetId"] = request.DatasetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDatasetInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDatasetInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the table is a custom SQL table. Valid values:
         * *   true: custom SQL table
         * *   false: non-custom SQL table
         *
         * @param request QueryDatasetInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDatasetInfoResponse
         */
        public async Task<QueryDatasetInfoResponse> QueryDatasetInfoWithOptionsAsync(QueryDatasetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["DatasetId"] = request.DatasetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDatasetInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDatasetInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the table is a custom SQL table. Valid values:
         * *   true: custom SQL table
         * *   false: non-custom SQL table
         *
         * @param request QueryDatasetInfoRequest
         * @return QueryDatasetInfoResponse
         */
        public QueryDatasetInfoResponse QueryDatasetInfo(QueryDatasetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDatasetInfoWithOptions(request, runtime);
        }

        /**
         * @summary Indicates whether the table is a custom SQL table. Valid values:
         * *   true: custom SQL table
         * *   false: non-custom SQL table
         *
         * @param request QueryDatasetInfoRequest
         * @return QueryDatasetInfoResponse
         */
        public async Task<QueryDatasetInfoResponse> QueryDatasetInfoAsync(QueryDatasetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDatasetInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The name of the training dataset.
         *
         * @param request QueryDatasetListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDatasetListResponse
         */
        public QueryDatasetListResponse QueryDatasetListWithOptions(QueryDatasetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithChildren))
            {
                query["WithChildren"] = request.WithChildren;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDatasetList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDatasetListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The name of the training dataset.
         *
         * @param request QueryDatasetListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDatasetListResponse
         */
        public async Task<QueryDatasetListResponse> QueryDatasetListWithOptionsAsync(QueryDatasetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithChildren))
            {
                query["WithChildren"] = request.WithChildren;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDatasetList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDatasetListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The name of the training dataset.
         *
         * @param request QueryDatasetListRequest
         * @return QueryDatasetListResponse
         */
        public QueryDatasetListResponse QueryDatasetList(QueryDatasetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDatasetListWithOptions(request, runtime);
        }

        /**
         * @summary The name of the training dataset.
         *
         * @param request QueryDatasetListRequest
         * @return QueryDatasetListResponse
         */
        public async Task<QueryDatasetListResponse> QueryDatasetListAsync(QueryDatasetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDatasetListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取指定数据集的行级权限开关状态。
         *
         * @param request QueryDatasetSwitchInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDatasetSwitchInfoResponse
         */
        public QueryDatasetSwitchInfoResponse QueryDatasetSwitchInfoWithOptions(QueryDatasetSwitchInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDatasetSwitchInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDatasetSwitchInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定数据集的行级权限开关状态。
         *
         * @param request QueryDatasetSwitchInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDatasetSwitchInfoResponse
         */
        public async Task<QueryDatasetSwitchInfoResponse> QueryDatasetSwitchInfoWithOptionsAsync(QueryDatasetSwitchInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDatasetSwitchInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDatasetSwitchInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定数据集的行级权限开关状态。
         *
         * @param request QueryDatasetSwitchInfoRequest
         * @return QueryDatasetSwitchInfoResponse
         */
        public QueryDatasetSwitchInfoResponse QueryDatasetSwitchInfo(QueryDatasetSwitchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDatasetSwitchInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取指定数据集的行级权限开关状态。
         *
         * @param request QueryDatasetSwitchInfoRequest
         * @return QueryDatasetSwitchInfoResponse
         */
        public async Task<QueryDatasetSwitchInfoResponse> QueryDatasetSwitchInfoAsync(QueryDatasetSwitchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDatasetSwitchInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The number of reports that are currently embedded.
         *
         * @param request QueryEmbeddedInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEmbeddedInfoResponse
         */
        public QueryEmbeddedInfoResponse QueryEmbeddedInfoWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEmbeddedInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmbeddedInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The number of reports that are currently embedded.
         *
         * @param request QueryEmbeddedInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEmbeddedInfoResponse
         */
        public async Task<QueryEmbeddedInfoResponse> QueryEmbeddedInfoWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEmbeddedInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmbeddedInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The number of reports that are currently embedded.
         *
         * @return QueryEmbeddedInfoResponse
         */
        public QueryEmbeddedInfoResponse QueryEmbeddedInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEmbeddedInfoWithOptions(runtime);
        }

        /**
         * @summary The number of reports that are currently embedded.
         *
         * @return QueryEmbeddedInfoResponse
         */
        public async Task<QueryEmbeddedInfoResponse> QueryEmbeddedInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEmbeddedInfoWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries whether embedding is enabled for a report.
         *
         * @param request QueryEmbeddedStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEmbeddedStatusResponse
         */
        public QueryEmbeddedStatusResponse QueryEmbeddedStatusWithOptions(QueryEmbeddedStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEmbeddedStatus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmbeddedStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether embedding is enabled for a report.
         *
         * @param request QueryEmbeddedStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEmbeddedStatusResponse
         */
        public async Task<QueryEmbeddedStatusResponse> QueryEmbeddedStatusWithOptionsAsync(QueryEmbeddedStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEmbeddedStatus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmbeddedStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether embedding is enabled for a report.
         *
         * @param request QueryEmbeddedStatusRequest
         * @return QueryEmbeddedStatusResponse
         */
        public QueryEmbeddedStatusResponse QueryEmbeddedStatus(QueryEmbeddedStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEmbeddedStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether embedding is enabled for a report.
         *
         * @param request QueryEmbeddedStatusRequest
         * @return QueryEmbeddedStatusResponse
         */
        public async Task<QueryEmbeddedStatusResponse> QueryEmbeddedStatusAsync(QueryEmbeddedStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEmbeddedStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取指定组织角色的配置信息
         *
         * @param request QueryOrganizationRoleConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrganizationRoleConfigResponse
         */
        public QueryOrganizationRoleConfigResponse QueryOrganizationRoleConfigWithOptions(QueryOrganizationRoleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrganizationRoleConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrganizationRoleConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定组织角色的配置信息
         *
         * @param request QueryOrganizationRoleConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrganizationRoleConfigResponse
         */
        public async Task<QueryOrganizationRoleConfigResponse> QueryOrganizationRoleConfigWithOptionsAsync(QueryOrganizationRoleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrganizationRoleConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrganizationRoleConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定组织角色的配置信息
         *
         * @param request QueryOrganizationRoleConfigRequest
         * @return QueryOrganizationRoleConfigResponse
         */
        public QueryOrganizationRoleConfigResponse QueryOrganizationRoleConfig(QueryOrganizationRoleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrganizationRoleConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取指定组织角色的配置信息
         *
         * @param request QueryOrganizationRoleConfigRequest
         * @return QueryOrganizationRoleConfigResponse
         */
        public async Task<QueryOrganizationRoleConfigResponse> QueryOrganizationRoleConfigAsync(QueryOrganizationRoleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrganizationRoleConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取当前组织下的工作空间列表信息。
         *
         * @param request QueryOrganizationWorkspaceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrganizationWorkspaceListResponse
         */
        public QueryOrganizationWorkspaceListResponse QueryOrganizationWorkspaceListWithOptions(QueryOrganizationWorkspaceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "QueryOrganizationWorkspaceList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrganizationWorkspaceListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取当前组织下的工作空间列表信息。
         *
         * @param request QueryOrganizationWorkspaceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrganizationWorkspaceListResponse
         */
        public async Task<QueryOrganizationWorkspaceListResponse> QueryOrganizationWorkspaceListWithOptionsAsync(QueryOrganizationWorkspaceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "QueryOrganizationWorkspaceList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrganizationWorkspaceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取当前组织下的工作空间列表信息。
         *
         * @param request QueryOrganizationWorkspaceListRequest
         * @return QueryOrganizationWorkspaceListResponse
         */
        public QueryOrganizationWorkspaceListResponse QueryOrganizationWorkspaceList(QueryOrganizationWorkspaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrganizationWorkspaceListWithOptions(request, runtime);
        }

        /**
         * @summary 获取当前组织下的工作空间列表信息。
         *
         * @param request QueryOrganizationWorkspaceListRequest
         * @return QueryOrganizationWorkspaceListResponse
         */
        public async Task<QueryOrganizationWorkspaceListResponse> QueryOrganizationWorkspaceListAsync(QueryOrganizationWorkspaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrganizationWorkspaceListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The Alibaba Cloud account name of the owner.
         *
         * @param request QueryReadableResourcesListByUserIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReadableResourcesListByUserIdResponse
         */
        public QueryReadableResourcesListByUserIdResponse QueryReadableResourcesListByUserIdWithOptions(QueryReadableResourcesListByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryReadableResourcesListByUserId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReadableResourcesListByUserIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The Alibaba Cloud account name of the owner.
         *
         * @param request QueryReadableResourcesListByUserIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReadableResourcesListByUserIdResponse
         */
        public async Task<QueryReadableResourcesListByUserIdResponse> QueryReadableResourcesListByUserIdWithOptionsAsync(QueryReadableResourcesListByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryReadableResourcesListByUserId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReadableResourcesListByUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The Alibaba Cloud account name of the owner.
         *
         * @param request QueryReadableResourcesListByUserIdRequest
         * @return QueryReadableResourcesListByUserIdResponse
         */
        public QueryReadableResourcesListByUserIdResponse QueryReadableResourcesListByUserId(QueryReadableResourcesListByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryReadableResourcesListByUserIdWithOptions(request, runtime);
        }

        /**
         * @summary The Alibaba Cloud account name of the owner.
         *
         * @param request QueryReadableResourcesListByUserIdRequest
         * @return QueryReadableResourcesListByUserIdResponse
         */
        public async Task<QueryReadableResourcesListByUserIdResponse> QueryReadableResourcesListByUserIdAsync(QueryReadableResourcesListByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryReadableResourcesListByUserIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询报表性能列表
         *
         * @param request QueryReportPerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReportPerformanceResponse
         */
        public QueryReportPerformanceResponse QueryReportPerformanceWithOptions(QueryReportPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostTimeAvgMin))
            {
                query["CostTimeAvgMin"] = request.CostTimeAvgMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryReportPerformance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReportPerformanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询报表性能列表
         *
         * @param request QueryReportPerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReportPerformanceResponse
         */
        public async Task<QueryReportPerformanceResponse> QueryReportPerformanceWithOptionsAsync(QueryReportPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostTimeAvgMin))
            {
                query["CostTimeAvgMin"] = request.CostTimeAvgMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryReportPerformance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReportPerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询报表性能列表
         *
         * @param request QueryReportPerformanceRequest
         * @return QueryReportPerformanceResponse
         */
        public QueryReportPerformanceResponse QueryReportPerformance(QueryReportPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryReportPerformanceWithOptions(request, runtime);
        }

        /**
         * @summary 查询报表性能列表
         *
         * @param request QueryReportPerformanceRequest
         * @return QueryReportPerformanceResponse
         */
        public async Task<QueryReportPerformanceResponse> QueryReportPerformanceAsync(QueryReportPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryReportPerformanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Xiao Zhang
         *
         * @param request QueryShareListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryShareListResponse
         */
        public QueryShareListResponse QueryShareListWithOptions(QueryShareListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryShareList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryShareListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Xiao Zhang
         *
         * @param request QueryShareListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryShareListResponse
         */
        public async Task<QueryShareListResponse> QueryShareListWithOptionsAsync(QueryShareListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryShareList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryShareListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Xiao Zhang
         *
         * @param request QueryShareListRequest
         * @return QueryShareListResponse
         */
        public QueryShareListResponse QueryShareList(QueryShareListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryShareListWithOptions(request, runtime);
        }

        /**
         * @summary Xiao Zhang
         *
         * @param request QueryShareListRequest
         * @return QueryShareListResponse
         */
        public async Task<QueryShareListResponse> QueryShareListAsync(QueryShareListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryShareListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the list of works authorized to a user.
         *
         * @param request QuerySharesToUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySharesToUserListResponse
         */
        public QuerySharesToUserListResponse QuerySharesToUserListWithOptions(QuerySharesToUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QuerySharesToUserList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySharesToUserListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the list of works authorized to a user.
         *
         * @param request QuerySharesToUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySharesToUserListResponse
         */
        public async Task<QuerySharesToUserListResponse> QuerySharesToUserListWithOptionsAsync(QuerySharesToUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QuerySharesToUserList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySharesToUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the list of works authorized to a user.
         *
         * @param request QuerySharesToUserListRequest
         * @return QuerySharesToUserListResponse
         */
        public QuerySharesToUserListResponse QuerySharesToUserList(QuerySharesToUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySharesToUserListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the list of works authorized to a user.
         *
         * @param request QuerySharesToUserListRequest
         * @return QuerySharesToUserListResponse
         */
        public async Task<QuerySharesToUserListResponse> QuerySharesToUserListAsync(QuerySharesToUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySharesToUserListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary auditing
         *
         * @param request QueryTicketInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTicketInfoResponse
         */
        public QueryTicketInfoResponse QueryTicketInfoWithOptions(QueryTicketInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["Ticket"] = request.Ticket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTicketInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTicketInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary auditing
         *
         * @param request QueryTicketInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTicketInfoResponse
         */
        public async Task<QueryTicketInfoResponse> QueryTicketInfoWithOptionsAsync(QueryTicketInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["Ticket"] = request.Ticket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTicketInfo",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTicketInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary auditing
         *
         * @param request QueryTicketInfoRequest
         * @return QueryTicketInfoResponse
         */
        public QueryTicketInfoResponse QueryTicketInfo(QueryTicketInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTicketInfoWithOptions(request, runtime);
        }

        /**
         * @summary auditing
         *
         * @param request QueryTicketInfoRequest
         * @return QueryTicketInfoResponse
         */
        public async Task<QueryTicketInfoResponse> QueryTicketInfoAsync(QueryTicketInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTicketInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can this operation to obtain information about child user groups under a specified parent user group.
         *
         * @param request QueryUserGroupListByParentIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserGroupListByParentIdResponse
         */
        public QueryUserGroupListByParentIdResponse QueryUserGroupListByParentIdWithOptions(QueryUserGroupListByParentIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserGroupId))
            {
                query["ParentUserGroupId"] = request.ParentUserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserGroupListByParentId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserGroupListByParentIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can this operation to obtain information about child user groups under a specified parent user group.
         *
         * @param request QueryUserGroupListByParentIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserGroupListByParentIdResponse
         */
        public async Task<QueryUserGroupListByParentIdResponse> QueryUserGroupListByParentIdWithOptionsAsync(QueryUserGroupListByParentIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserGroupId))
            {
                query["ParentUserGroupId"] = request.ParentUserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserGroupListByParentId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserGroupListByParentIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can this operation to obtain information about child user groups under a specified parent user group.
         *
         * @param request QueryUserGroupListByParentIdRequest
         * @return QueryUserGroupListByParentIdResponse
         */
        public QueryUserGroupListByParentIdResponse QueryUserGroupListByParentId(QueryUserGroupListByParentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserGroupListByParentIdWithOptions(request, runtime);
        }

        /**
         * @summary You can this operation to obtain information about child user groups under a specified parent user group.
         *
         * @param request QueryUserGroupListByParentIdRequest
         * @return QueryUserGroupListByParentIdResponse
         */
        public async Task<QueryUserGroupListByParentIdResponse> QueryUserGroupListByParentIdAsync(QueryUserGroupListByParentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserGroupListByParentIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用户组下的成员列表信息。
         *
         * @param request QueryUserGroupMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserGroupMemberResponse
         */
        public QueryUserGroupMemberResponse QueryUserGroupMemberWithOptions(QueryUserGroupMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserGroupMember",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserGroupMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户组下的成员列表信息。
         *
         * @param request QueryUserGroupMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserGroupMemberResponse
         */
        public async Task<QueryUserGroupMemberResponse> QueryUserGroupMemberWithOptionsAsync(QueryUserGroupMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserGroupMember",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserGroupMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户组下的成员列表信息。
         *
         * @param request QueryUserGroupMemberRequest
         * @return QueryUserGroupMemberResponse
         */
        public QueryUserGroupMemberResponse QueryUserGroupMember(QueryUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserGroupMemberWithOptions(request, runtime);
        }

        /**
         * @summary 获取用户组下的成员列表信息。
         *
         * @param request QueryUserGroupMemberRequest
         * @return QueryUserGroupMemberResponse
         */
        public async Task<QueryUserGroupMemberResponse> QueryUserGroupMemberAsync(QueryUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserGroupMemberWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries user information based on the Alibaba Cloud ID or Alibaba Cloud account name.
         *
         * @param request QueryUserInfoByAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserInfoByAccountResponse
         */
        public QueryUserInfoByAccountResponse QueryUserInfoByAccountWithOptions(QueryUserInfoByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentAccountName))
            {
                query["ParentAccountName"] = request.ParentAccountName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserInfoByAccount",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserInfoByAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries user information based on the Alibaba Cloud ID or Alibaba Cloud account name.
         *
         * @param request QueryUserInfoByAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserInfoByAccountResponse
         */
        public async Task<QueryUserInfoByAccountResponse> QueryUserInfoByAccountWithOptionsAsync(QueryUserInfoByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentAccountName))
            {
                query["ParentAccountName"] = request.ParentAccountName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserInfoByAccount",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserInfoByAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries user information based on the Alibaba Cloud ID or Alibaba Cloud account name.
         *
         * @param request QueryUserInfoByAccountRequest
         * @return QueryUserInfoByAccountResponse
         */
        public QueryUserInfoByAccountResponse QueryUserInfoByAccount(QueryUserInfoByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserInfoByAccountWithOptions(request, runtime);
        }

        /**
         * @summary Queries user information based on the Alibaba Cloud ID or Alibaba Cloud account name.
         *
         * @param request QueryUserInfoByAccountRequest
         * @return QueryUserInfoByAccountResponse
         */
        public async Task<QueryUserInfoByAccountResponse> QueryUserInfoByAccountAsync(QueryUserInfoByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserInfoByAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries user information based on the user ID.
         *
         * @param request QueryUserInfoByUserIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserInfoByUserIdResponse
         */
        public QueryUserInfoByUserIdResponse QueryUserInfoByUserIdWithOptions(QueryUserInfoByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserInfoByUserId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserInfoByUserIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries user information based on the user ID.
         *
         * @param request QueryUserInfoByUserIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserInfoByUserIdResponse
         */
        public async Task<QueryUserInfoByUserIdResponse> QueryUserInfoByUserIdWithOptionsAsync(QueryUserInfoByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserInfoByUserId",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserInfoByUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries user information based on the user ID.
         *
         * @param request QueryUserInfoByUserIdRequest
         * @return QueryUserInfoByUserIdResponse
         */
        public QueryUserInfoByUserIdResponse QueryUserInfoByUserId(QueryUserInfoByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserInfoByUserIdWithOptions(request, runtime);
        }

        /**
         * @summary Queries user information based on the user ID.
         *
         * @param request QueryUserInfoByUserIdRequest
         * @return QueryUserInfoByUserIdResponse
         */
        public async Task<QueryUserInfoByUserIdResponse> QueryUserInfoByUserIdAsync(QueryUserInfoByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserInfoByUserIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询组织成员列表信息。
         *
         * @param request QueryUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserListResponse
         */
        public QueryUserListResponse QueryUserListWithOptions(QueryUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询组织成员列表信息。
         *
         * @param request QueryUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserListResponse
         */
        public async Task<QueryUserListResponse> QueryUserListWithOptionsAsync(QueryUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询组织成员列表信息。
         *
         * @param request QueryUserListRequest
         * @return QueryUserListResponse
         */
        public QueryUserListResponse QueryUserList(QueryUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserListWithOptions(request, runtime);
        }

        /**
         * @summary 查询组织成员列表信息。
         *
         * @param request QueryUserListRequest
         * @return QueryUserListResponse
         */
        public async Task<QueryUserListResponse> QueryUserListAsync(QueryUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取指定工作空间成员的预置空间角色信息。
         *
         * @param request QueryUserRoleInfoInWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserRoleInfoInWorkspaceResponse
         */
        public QueryUserRoleInfoInWorkspaceResponse QueryUserRoleInfoInWorkspaceWithOptions(QueryUserRoleInfoInWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserRoleInfoInWorkspace",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserRoleInfoInWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定工作空间成员的预置空间角色信息。
         *
         * @param request QueryUserRoleInfoInWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserRoleInfoInWorkspaceResponse
         */
        public async Task<QueryUserRoleInfoInWorkspaceResponse> QueryUserRoleInfoInWorkspaceWithOptionsAsync(QueryUserRoleInfoInWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserRoleInfoInWorkspace",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserRoleInfoInWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定工作空间成员的预置空间角色信息。
         *
         * @param request QueryUserRoleInfoInWorkspaceRequest
         * @return QueryUserRoleInfoInWorkspaceResponse
         */
        public QueryUserRoleInfoInWorkspaceResponse QueryUserRoleInfoInWorkspace(QueryUserRoleInfoInWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserRoleInfoInWorkspaceWithOptions(request, runtime);
        }

        /**
         * @summary 获取指定工作空间成员的预置空间角色信息。
         *
         * @param request QueryUserRoleInfoInWorkspaceRequest
         * @return QueryUserRoleInfoInWorkspaceResponse
         */
        public async Task<QueryUserRoleInfoInWorkspaceResponse> QueryUserRoleInfoInWorkspaceAsync(QueryUserRoleInfoInWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserRoleInfoInWorkspaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary auditing
         *
         * @param request QueryUserTagMetaListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserTagMetaListResponse
         */
        public QueryUserTagMetaListResponse QueryUserTagMetaListWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserTagMetaList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserTagMetaListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary auditing
         *
         * @param request QueryUserTagMetaListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserTagMetaListResponse
         */
        public async Task<QueryUserTagMetaListResponse> QueryUserTagMetaListWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserTagMetaList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserTagMetaListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary auditing
         *
         * @return QueryUserTagMetaListResponse
         */
        public QueryUserTagMetaListResponse QueryUserTagMetaList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserTagMetaListWithOptions(runtime);
        }

        /**
         * @summary auditing
         *
         * @return QueryUserTagMetaListResponse
         */
        public async Task<QueryUserTagMetaListResponse> QueryUserTagMetaListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserTagMetaListWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the list of tag values for a specific user.
         *
         * @param request QueryUserTagValueListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserTagValueListResponse
         */
        public QueryUserTagValueListResponse QueryUserTagValueListWithOptions(QueryUserTagValueListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserTagValueList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserTagValueListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the list of tag values for a specific user.
         *
         * @param request QueryUserTagValueListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserTagValueListResponse
         */
        public async Task<QueryUserTagValueListResponse> QueryUserTagValueListWithOptionsAsync(QueryUserTagValueListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserTagValueList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserTagValueListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the list of tag values for a specific user.
         *
         * @param request QueryUserTagValueListRequest
         * @return QueryUserTagValueListResponse
         */
        public QueryUserTagValueListResponse QueryUserTagValueList(QueryUserTagValueListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserTagValueListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the list of tag values for a specific user.
         *
         * @param request QueryUserTagValueListRequest
         * @return QueryUserTagValueListResponse
         */
        public async Task<QueryUserTagValueListResponse> QueryUserTagValueListAsync(QueryUserTagValueListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserTagValueListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取报表详情
         *
         * @param request QueryWorksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorksResponse
         */
        public QueryWorksResponse QueryWorksWithOptions(QueryWorksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorks",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取报表详情
         *
         * @param request QueryWorksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorksResponse
         */
        public async Task<QueryWorksResponse> QueryWorksWithOptionsAsync(QueryWorksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorks",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取报表详情
         *
         * @param request QueryWorksRequest
         * @return QueryWorksResponse
         */
        public QueryWorksResponse QueryWorks(QueryWorksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWorksWithOptions(request, runtime);
        }

        /**
         * @summary 获取报表详情
         *
         * @param request QueryWorksRequest
         * @return QueryWorksResponse
         */
        public async Task<QueryWorksResponse> QueryWorksAsync(QueryWorksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWorksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary abcd****
         *
         * @param request QueryWorksBloodRelationshipRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorksBloodRelationshipResponse
         */
        public QueryWorksBloodRelationshipResponse QueryWorksBloodRelationshipWithOptions(QueryWorksBloodRelationshipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorksBloodRelationship",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorksBloodRelationshipResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary abcd****
         *
         * @param request QueryWorksBloodRelationshipRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorksBloodRelationshipResponse
         */
        public async Task<QueryWorksBloodRelationshipResponse> QueryWorksBloodRelationshipWithOptionsAsync(QueryWorksBloodRelationshipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorksBloodRelationship",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorksBloodRelationshipResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary abcd****
         *
         * @param request QueryWorksBloodRelationshipRequest
         * @return QueryWorksBloodRelationshipResponse
         */
        public QueryWorksBloodRelationshipResponse QueryWorksBloodRelationship(QueryWorksBloodRelationshipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWorksBloodRelationshipWithOptions(request, runtime);
        }

        /**
         * @summary abcd****
         *
         * @param request QueryWorksBloodRelationshipRequest
         * @return QueryWorksBloodRelationshipResponse
         */
        public async Task<QueryWorksBloodRelationshipResponse> QueryWorksBloodRelationshipAsync(QueryWorksBloodRelationshipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWorksBloodRelationshipWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The total number of rows in the table.
         *
         * @param request QueryWorksByOrganizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorksByOrganizationResponse
         */
        public QueryWorksByOrganizationResponse QueryWorksByOrganizationWithOptions(QueryWorksByOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartAuthFlag))
            {
                query["ThirdPartAuthFlag"] = request.ThirdPartAuthFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksType))
            {
                query["WorksType"] = request.WorksType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorksByOrganization",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorksByOrganizationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The total number of rows in the table.
         *
         * @param request QueryWorksByOrganizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorksByOrganizationResponse
         */
        public async Task<QueryWorksByOrganizationResponse> QueryWorksByOrganizationWithOptionsAsync(QueryWorksByOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartAuthFlag))
            {
                query["ThirdPartAuthFlag"] = request.ThirdPartAuthFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksType))
            {
                query["WorksType"] = request.WorksType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorksByOrganization",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorksByOrganizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The total number of rows in the table.
         *
         * @param request QueryWorksByOrganizationRequest
         * @return QueryWorksByOrganizationResponse
         */
        public QueryWorksByOrganizationResponse QueryWorksByOrganization(QueryWorksByOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWorksByOrganizationWithOptions(request, runtime);
        }

        /**
         * @summary The total number of rows in the table.
         *
         * @param request QueryWorksByOrganizationRequest
         * @return QueryWorksByOrganizationResponse
         */
        public async Task<QueryWorksByOrganizationResponse> QueryWorksByOrganizationAsync(QueryWorksByOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWorksByOrganizationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The name of the directory.
         *
         * @param request QueryWorksByWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorksByWorkspaceResponse
         */
        public QueryWorksByWorkspaceResponse QueryWorksByWorkspaceWithOptions(QueryWorksByWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartAuthFlag))
            {
                query["ThirdPartAuthFlag"] = request.ThirdPartAuthFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksType))
            {
                query["WorksType"] = request.WorksType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorksByWorkspace",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorksByWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The name of the directory.
         *
         * @param request QueryWorksByWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorksByWorkspaceResponse
         */
        public async Task<QueryWorksByWorkspaceResponse> QueryWorksByWorkspaceWithOptionsAsync(QueryWorksByWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartAuthFlag))
            {
                query["ThirdPartAuthFlag"] = request.ThirdPartAuthFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksType))
            {
                query["WorksType"] = request.WorksType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorksByWorkspace",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorksByWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The name of the directory.
         *
         * @param request QueryWorksByWorkspaceRequest
         * @return QueryWorksByWorkspaceResponse
         */
        public QueryWorksByWorkspaceResponse QueryWorksByWorkspace(QueryWorksByWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWorksByWorkspaceWithOptions(request, runtime);
        }

        /**
         * @summary The name of the directory.
         *
         * @param request QueryWorksByWorkspaceRequest
         * @return QueryWorksByWorkspaceResponse
         */
        public async Task<QueryWorksByWorkspaceResponse> QueryWorksByWorkspaceAsync(QueryWorksByWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWorksByWorkspaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取指定空间角色的配置信息
         *
         * @param request QueryWorkspaceRoleConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorkspaceRoleConfigResponse
         */
        public QueryWorkspaceRoleConfigResponse QueryWorkspaceRoleConfigWithOptions(QueryWorkspaceRoleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorkspaceRoleConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorkspaceRoleConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定空间角色的配置信息
         *
         * @param request QueryWorkspaceRoleConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorkspaceRoleConfigResponse
         */
        public async Task<QueryWorkspaceRoleConfigResponse> QueryWorkspaceRoleConfigWithOptionsAsync(QueryWorkspaceRoleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorkspaceRoleConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorkspaceRoleConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定空间角色的配置信息
         *
         * @param request QueryWorkspaceRoleConfigRequest
         * @return QueryWorkspaceRoleConfigResponse
         */
        public QueryWorkspaceRoleConfigResponse QueryWorkspaceRoleConfig(QueryWorkspaceRoleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWorkspaceRoleConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取指定空间角色的配置信息
         *
         * @param request QueryWorkspaceRoleConfigRequest
         * @return QueryWorkspaceRoleConfigResponse
         */
        public async Task<QueryWorkspaceRoleConfigResponse> QueryWorkspaceRoleConfigAsync(QueryWorkspaceRoleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWorkspaceRoleConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询指定工作空间下的成员列表信息。
         *
         * @param request QueryWorkspaceUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorkspaceUserListResponse
         */
        public QueryWorkspaceUserListResponse QueryWorkspaceUserListWithOptions(QueryWorkspaceUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorkspaceUserList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorkspaceUserListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询指定工作空间下的成员列表信息。
         *
         * @param request QueryWorkspaceUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWorkspaceUserListResponse
         */
        public async Task<QueryWorkspaceUserListResponse> QueryWorkspaceUserListWithOptionsAsync(QueryWorkspaceUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWorkspaceUserList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWorkspaceUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询指定工作空间下的成员列表信息。
         *
         * @param request QueryWorkspaceUserListRequest
         * @return QueryWorkspaceUserListResponse
         */
        public QueryWorkspaceUserListResponse QueryWorkspaceUserList(QueryWorkspaceUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWorkspaceUserListWithOptions(request, runtime);
        }

        /**
         * @summary 查询指定工作空间下的成员列表信息。
         *
         * @param request QueryWorkspaceUserListRequest
         * @return QueryWorkspaceUserListResponse
         */
        public async Task<QueryWorkspaceUserListResponse> QueryWorkspaceUserListAsync(QueryWorkspaceUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWorkspaceUserListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 第三方资源审批回调接口
         *
         * @param request ResultCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResultCallbackResponse
         */
        public ResultCallbackResponse ResultCallbackWithOptions(ResultCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleReason))
            {
                query["HandleReason"] = request.HandleReason;
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
                Action = "ResultCallback",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResultCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 第三方资源审批回调接口
         *
         * @param request ResultCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResultCallbackResponse
         */
        public async Task<ResultCallbackResponse> ResultCallbackWithOptionsAsync(ResultCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleReason))
            {
                query["HandleReason"] = request.HandleReason;
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
                Action = "ResultCallback",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResultCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 第三方资源审批回调接口
         *
         * @param request ResultCallbackRequest
         * @return ResultCallbackResponse
         */
        public ResultCallbackResponse ResultCallback(ResultCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResultCallbackWithOptions(request, runtime);
        }

        /**
         * @summary 第三方资源审批回调接口
         *
         * @param request ResultCallbackRequest
         * @return ResultCallbackResponse
         */
        public async Task<ResultCallbackResponse> ResultCallbackAsync(ResultCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResultCallbackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Add the user\\"s collection data works.
         *
         * @param request SaveFavoritesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveFavoritesResponse
         */
        public SaveFavoritesResponse SaveFavoritesWithOptions(SaveFavoritesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveFavorites",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFavoritesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Add the user\\"s collection data works.
         *
         * @param request SaveFavoritesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveFavoritesResponse
         */
        public async Task<SaveFavoritesResponse> SaveFavoritesWithOptionsAsync(SaveFavoritesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveFavorites",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFavoritesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Add the user\\"s collection data works.
         *
         * @param request SaveFavoritesRequest
         * @return SaveFavoritesResponse
         */
        public SaveFavoritesResponse SaveFavorites(SaveFavoritesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveFavoritesWithOptions(request, runtime);
        }

        /**
         * @summary Add the user\\"s collection data works.
         *
         * @param request SaveFavoritesRequest
         * @return SaveFavoritesResponse
         */
        public async Task<SaveFavoritesResponse> SaveFavoritesAsync(SaveFavoritesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveFavoritesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置行列权限的额外配置
         *
         * @param request SetDataLevelPermissionExtraConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDataLevelPermissionExtraConfigResponse
         */
        public SetDataLevelPermissionExtraConfigResponse SetDataLevelPermissionExtraConfigWithOptions(SetDataLevelPermissionExtraConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MissHitPolicy))
            {
                query["MissHitPolicy"] = request.MissHitPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDataLevelPermissionExtraConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataLevelPermissionExtraConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置行列权限的额外配置
         *
         * @param request SetDataLevelPermissionExtraConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDataLevelPermissionExtraConfigResponse
         */
        public async Task<SetDataLevelPermissionExtraConfigResponse> SetDataLevelPermissionExtraConfigWithOptionsAsync(SetDataLevelPermissionExtraConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MissHitPolicy))
            {
                query["MissHitPolicy"] = request.MissHitPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDataLevelPermissionExtraConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataLevelPermissionExtraConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置行列权限的额外配置
         *
         * @param request SetDataLevelPermissionExtraConfigRequest
         * @return SetDataLevelPermissionExtraConfigResponse
         */
        public SetDataLevelPermissionExtraConfigResponse SetDataLevelPermissionExtraConfig(SetDataLevelPermissionExtraConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDataLevelPermissionExtraConfigWithOptions(request, runtime);
        }

        /**
         * @summary 设置行列权限的额外配置
         *
         * @param request SetDataLevelPermissionExtraConfigRequest
         * @return SetDataLevelPermissionExtraConfigResponse
         */
        public async Task<SetDataLevelPermissionExtraConfigResponse> SetDataLevelPermissionExtraConfigAsync(SetDataLevelPermissionExtraConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDataLevelPermissionExtraConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置单条数据集行列权限配置信息（新增和更新）
         *
         * @param request SetDataLevelPermissionRuleConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDataLevelPermissionRuleConfigResponse
         */
        public SetDataLevelPermissionRuleConfigResponse SetDataLevelPermissionRuleConfigWithOptions(SetDataLevelPermissionRuleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleModel))
            {
                query["RuleModel"] = request.RuleModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDataLevelPermissionRuleConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataLevelPermissionRuleConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置单条数据集行列权限配置信息（新增和更新）
         *
         * @param request SetDataLevelPermissionRuleConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDataLevelPermissionRuleConfigResponse
         */
        public async Task<SetDataLevelPermissionRuleConfigResponse> SetDataLevelPermissionRuleConfigWithOptionsAsync(SetDataLevelPermissionRuleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleModel))
            {
                query["RuleModel"] = request.RuleModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDataLevelPermissionRuleConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataLevelPermissionRuleConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置单条数据集行列权限配置信息（新增和更新）
         *
         * @param request SetDataLevelPermissionRuleConfigRequest
         * @return SetDataLevelPermissionRuleConfigResponse
         */
        public SetDataLevelPermissionRuleConfigResponse SetDataLevelPermissionRuleConfig(SetDataLevelPermissionRuleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDataLevelPermissionRuleConfigWithOptions(request, runtime);
        }

        /**
         * @summary 设置单条数据集行列权限配置信息（新增和更新）
         *
         * @param request SetDataLevelPermissionRuleConfigRequest
         * @return SetDataLevelPermissionRuleConfigResponse
         */
        public async Task<SetDataLevelPermissionRuleConfigResponse> SetDataLevelPermissionRuleConfigAsync(SetDataLevelPermissionRuleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDataLevelPermissionRuleConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets the whitelist for the specified row-level permissions.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.
         *
         * @param request SetDataLevelPermissionWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDataLevelPermissionWhiteListResponse
         */
        public SetDataLevelPermissionWhiteListResponse SetDataLevelPermissionWhiteListWithOptions(SetDataLevelPermissionWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListModel))
            {
                query["WhiteListModel"] = request.WhiteListModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDataLevelPermissionWhiteList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataLevelPermissionWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sets the whitelist for the specified row-level permissions.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.
         *
         * @param request SetDataLevelPermissionWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDataLevelPermissionWhiteListResponse
         */
        public async Task<SetDataLevelPermissionWhiteListResponse> SetDataLevelPermissionWhiteListWithOptionsAsync(SetDataLevelPermissionWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListModel))
            {
                query["WhiteListModel"] = request.WhiteListModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDataLevelPermissionWhiteList",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataLevelPermissionWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sets the whitelist for the specified row-level permissions.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.
         *
         * @param request SetDataLevelPermissionWhiteListRequest
         * @return SetDataLevelPermissionWhiteListResponse
         */
        public SetDataLevelPermissionWhiteListResponse SetDataLevelPermissionWhiteList(SetDataLevelPermissionWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDataLevelPermissionWhiteListWithOptions(request, runtime);
        }

        /**
         * @summary Sets the whitelist for the specified row-level permissions.
         *
         * @description > : You can only Quick BI the new row-column permission model. If you are still using the old row-column permission model, migrate to the new row-column permission model before you call this operation. To migrate row-level permissions to the new row-level permission model, perform the following steps: Choose Organizations> Security Configurations> Upgrade Row-Level Permissions. On the Upgrade Row-Level Permissions page, click **Upgrade**.
         *
         * @param request SetDataLevelPermissionWhiteListRequest
         * @return SetDataLevelPermissionWhiteListResponse
         */
        public async Task<SetDataLevelPermissionWhiteListResponse> SetDataLevelPermissionWhiteListAsync(SetDataLevelPermissionWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDataLevelPermissionWhiteListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Indicates whether the request is successful. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @description The execution result of the interface. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @param request UpdateDataLevelPermissionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDataLevelPermissionStatusResponse
         */
        public UpdateDataLevelPermissionStatusResponse UpdateDataLevelPermissionStatusWithOptions(UpdateDataLevelPermissionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpen))
            {
                query["IsOpen"] = request.IsOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLevelPermissionStatus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLevelPermissionStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the request is successful. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @description The execution result of the interface. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @param request UpdateDataLevelPermissionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDataLevelPermissionStatusResponse
         */
        public async Task<UpdateDataLevelPermissionStatusResponse> UpdateDataLevelPermissionStatusWithOptionsAsync(UpdateDataLevelPermissionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CubeId))
            {
                query["CubeId"] = request.CubeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpen))
            {
                query["IsOpen"] = request.IsOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLevelPermissionStatus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLevelPermissionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the request is successful. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @description The execution result of the interface. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @param request UpdateDataLevelPermissionStatusRequest
         * @return UpdateDataLevelPermissionStatusResponse
         */
        public UpdateDataLevelPermissionStatusResponse UpdateDataLevelPermissionStatus(UpdateDataLevelPermissionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataLevelPermissionStatusWithOptions(request, runtime);
        }

        /**
         * @summary Indicates whether the request is successful. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @description The execution result of the interface. Valid values:
         * *   true: The request was successful.
         * *   false: The request failed.
         *
         * @param request UpdateDataLevelPermissionStatusRequest
         * @return UpdateDataLevelPermissionStatusResponse
         */
        public async Task<UpdateDataLevelPermissionStatusResponse> UpdateDataLevelPermissionStatusAsync(UpdateDataLevelPermissionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataLevelPermissionStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the request.
         *
         * @param request UpdateEmbeddedStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEmbeddedStatusResponse
         */
        public UpdateEmbeddedStatusResponse UpdateEmbeddedStatusWithOptions(UpdateEmbeddedStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartAuthFlag))
            {
                query["ThirdPartAuthFlag"] = request.ThirdPartAuthFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEmbeddedStatus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEmbeddedStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the request.
         *
         * @param request UpdateEmbeddedStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEmbeddedStatusResponse
         */
        public async Task<UpdateEmbeddedStatusResponse> UpdateEmbeddedStatusWithOptionsAsync(UpdateEmbeddedStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartAuthFlag))
            {
                query["ThirdPartAuthFlag"] = request.ThirdPartAuthFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorksId))
            {
                query["WorksId"] = request.WorksId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEmbeddedStatus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEmbeddedStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the request.
         *
         * @param request UpdateEmbeddedStatusRequest
         * @return UpdateEmbeddedStatusResponse
         */
        public UpdateEmbeddedStatusResponse UpdateEmbeddedStatus(UpdateEmbeddedStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEmbeddedStatusWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the request.
         *
         * @param request UpdateEmbeddedStatusRequest
         * @return UpdateEmbeddedStatusResponse
         */
        public async Task<UpdateEmbeddedStatusResponse> UpdateEmbeddedStatusAsync(UpdateEmbeddedStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEmbeddedStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新三方嵌入ticket的票据数量
         *
         * @param request UpdateTicketNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTicketNumResponse
         */
        public UpdateTicketNumResponse UpdateTicketNumWithOptions(UpdateTicketNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["Ticket"] = request.Ticket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNum))
            {
                query["TicketNum"] = request.TicketNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTicketNum",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTicketNumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新三方嵌入ticket的票据数量
         *
         * @param request UpdateTicketNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTicketNumResponse
         */
        public async Task<UpdateTicketNumResponse> UpdateTicketNumWithOptionsAsync(UpdateTicketNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["Ticket"] = request.Ticket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketNum))
            {
                query["TicketNum"] = request.TicketNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTicketNum",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTicketNumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新三方嵌入ticket的票据数量
         *
         * @param request UpdateTicketNumRequest
         * @return UpdateTicketNumResponse
         */
        public UpdateTicketNumResponse UpdateTicketNum(UpdateTicketNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTicketNumWithOptions(request, runtime);
        }

        /**
         * @summary 更新三方嵌入ticket的票据数量
         *
         * @param request UpdateTicketNumRequest
         * @return UpdateTicketNumResponse
         */
        public async Task<UpdateTicketNumResponse> UpdateTicketNumAsync(UpdateTicketNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTicketNumWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the information of a specified member in an organization.
         *
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminUser))
            {
                query["AdminUser"] = request.AdminUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthAdminUser))
            {
                query["AuthAdminUser"] = request.AuthAdminUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDeleted))
            {
                query["IsDeleted"] = request.IsDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                query["NickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                query["RoleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2022-01-01",
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

        /**
         * @summary Updates the information of a specified member in an organization.
         *
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminUser))
            {
                query["AdminUser"] = request.AdminUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthAdminUser))
            {
                query["AuthAdminUser"] = request.AuthAdminUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDeleted))
            {
                query["IsDeleted"] = request.IsDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                query["NickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                query["RoleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2022-01-01",
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

        /**
         * @summary Updates the information of a specified member in an organization.
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        /**
         * @summary Updates the information of a specified member in an organization.
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates information about a specified user group in an organization.
         *
         * @param request UpdateUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserGroupResponse
         */
        public UpdateUserGroupResponse UpdateUserGroupWithOptions(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupDescription))
            {
                query["UserGroupDescription"] = request.UserGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupName))
            {
                query["UserGroupName"] = request.UserGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserGroup",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates information about a specified user group in an organization.
         *
         * @param request UpdateUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserGroupResponse
         */
        public async Task<UpdateUserGroupResponse> UpdateUserGroupWithOptionsAsync(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupDescription))
            {
                query["UserGroupDescription"] = request.UserGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupName))
            {
                query["UserGroupName"] = request.UserGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserGroup",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates information about a specified user group in an organization.
         *
         * @param request UpdateUserGroupRequest
         * @return UpdateUserGroupResponse
         */
        public UpdateUserGroupResponse UpdateUserGroup(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserGroupWithOptions(request, runtime);
        }

        /**
         * @summary Updates information about a specified user group in an organization.
         *
         * @param request UpdateUserGroupRequest
         * @return UpdateUserGroupResponse
         */
        public async Task<UpdateUserGroupResponse> UpdateUserGroupAsync(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 用于更新组织成员标签元信息
         *
         * @param request UpdateUserTagMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserTagMetaResponse
         */
        public UpdateUserTagMetaResponse UpdateUserTagMetaWithOptions(UpdateUserTagMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagDescription))
            {
                query["TagDescription"] = request.TagDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserTagMeta",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserTagMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 用于更新组织成员标签元信息
         *
         * @param request UpdateUserTagMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserTagMetaResponse
         */
        public async Task<UpdateUserTagMetaResponse> UpdateUserTagMetaWithOptionsAsync(UpdateUserTagMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagDescription))
            {
                query["TagDescription"] = request.TagDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserTagMeta",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserTagMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 用于更新组织成员标签元信息
         *
         * @param request UpdateUserTagMetaRequest
         * @return UpdateUserTagMetaResponse
         */
        public UpdateUserTagMetaResponse UpdateUserTagMeta(UpdateUserTagMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserTagMetaWithOptions(request, runtime);
        }

        /**
         * @summary 用于更新组织成员标签元信息
         *
         * @param request UpdateUserTagMetaRequest
         * @return UpdateUserTagMetaResponse
         */
        public async Task<UpdateUserTagMetaResponse> UpdateUserTagMetaAsync(UpdateUserTagMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserTagMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新组织成员标签值
         *
         * @param request UpdateUserTagValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserTagValueResponse
         */
        public UpdateUserTagValueResponse UpdateUserTagValueWithOptions(UpdateUserTagValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValue))
            {
                query["TagValue"] = request.TagValue;
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
                Action = "UpdateUserTagValue",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserTagValueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新组织成员标签值
         *
         * @param request UpdateUserTagValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserTagValueResponse
         */
        public async Task<UpdateUserTagValueResponse> UpdateUserTagValueWithOptionsAsync(UpdateUserTagValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValue))
            {
                query["TagValue"] = request.TagValue;
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
                Action = "UpdateUserTagValue",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserTagValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新组织成员标签值
         *
         * @param request UpdateUserTagValueRequest
         * @return UpdateUserTagValueResponse
         */
        public UpdateUserTagValueResponse UpdateUserTagValue(UpdateUserTagValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserTagValueWithOptions(request, runtime);
        }

        /**
         * @summary 更新组织成员标签值
         *
         * @param request UpdateUserTagValueRequest
         * @return UpdateUserTagValueResponse
         */
        public async Task<UpdateUserTagValueResponse> UpdateUserTagValueAsync(UpdateUserTagValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserTagValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改工作空间下指定成员的角色，已有的角色会被覆盖
         *
         * @param request UpdateWorkspaceUserRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceUserRoleResponse
         */
        public UpdateWorkspaceUserRoleResponse UpdateWorkspaceUserRoleWithOptions(UpdateWorkspaceUserRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceUserRole",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceUserRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改工作空间下指定成员的角色，已有的角色会被覆盖
         *
         * @param request UpdateWorkspaceUserRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceUserRoleResponse
         */
        public async Task<UpdateWorkspaceUserRoleResponse> UpdateWorkspaceUserRoleWithOptionsAsync(UpdateWorkspaceUserRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceUserRole",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceUserRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改工作空间下指定成员的角色，已有的角色会被覆盖
         *
         * @param request UpdateWorkspaceUserRoleRequest
         * @return UpdateWorkspaceUserRoleResponse
         */
        public UpdateWorkspaceUserRoleResponse UpdateWorkspaceUserRole(UpdateWorkspaceUserRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkspaceUserRoleWithOptions(request, runtime);
        }

        /**
         * @summary 修改工作空间下指定成员的角色，已有的角色会被覆盖
         *
         * @param request UpdateWorkspaceUserRoleRequest
         * @return UpdateWorkspaceUserRoleResponse
         */
        public async Task<UpdateWorkspaceUserRoleResponse> UpdateWorkspaceUserRoleAsync(UpdateWorkspaceUserRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkspaceUserRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量更新工作空间成员的角色信息，已有角色会被覆盖
         *
         * @param request UpdateWorkspaceUsersRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceUsersRoleResponse
         */
        public UpdateWorkspaceUsersRoleResponse UpdateWorkspaceUsersRoleWithOptions(UpdateWorkspaceUsersRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceUsersRole",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceUsersRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量更新工作空间成员的角色信息，已有角色会被覆盖
         *
         * @param request UpdateWorkspaceUsersRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceUsersRoleResponse
         */
        public async Task<UpdateWorkspaceUsersRoleResponse> UpdateWorkspaceUsersRoleWithOptionsAsync(UpdateWorkspaceUsersRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceUsersRole",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceUsersRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量更新工作空间成员的角色信息，已有角色会被覆盖
         *
         * @param request UpdateWorkspaceUsersRoleRequest
         * @return UpdateWorkspaceUsersRoleResponse
         */
        public UpdateWorkspaceUsersRoleResponse UpdateWorkspaceUsersRole(UpdateWorkspaceUsersRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkspaceUsersRoleWithOptions(request, runtime);
        }

        /**
         * @summary 批量更新工作空间成员的角色信息，已有角色会被覆盖
         *
         * @param request UpdateWorkspaceUsersRoleRequest
         * @return UpdateWorkspaceUsersRoleResponse
         */
        public async Task<UpdateWorkspaceUsersRoleResponse> UpdateWorkspaceUsersRoleAsync(UpdateWorkspaceUsersRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkspaceUsersRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Make the user exit all user groups. This process is irreversible. Exercise caution when performing this operation.
         *
         * @param request WithdrawAllUserGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return WithdrawAllUserGroupsResponse
         */
        public WithdrawAllUserGroupsResponse WithdrawAllUserGroupsWithOptions(WithdrawAllUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "WithdrawAllUserGroups",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawAllUserGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Make the user exit all user groups. This process is irreversible. Exercise caution when performing this operation.
         *
         * @param request WithdrawAllUserGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return WithdrawAllUserGroupsResponse
         */
        public async Task<WithdrawAllUserGroupsResponse> WithdrawAllUserGroupsWithOptionsAsync(WithdrawAllUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "WithdrawAllUserGroups",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawAllUserGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Make the user exit all user groups. This process is irreversible. Exercise caution when performing this operation.
         *
         * @param request WithdrawAllUserGroupsRequest
         * @return WithdrawAllUserGroupsResponse
         */
        public WithdrawAllUserGroupsResponse WithdrawAllUserGroups(WithdrawAllUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WithdrawAllUserGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Make the user exit all user groups. This process is irreversible. Exercise caution when performing this operation.
         *
         * @param request WithdrawAllUserGroupsRequest
         * @return WithdrawAllUserGroupsResponse
         */
        public async Task<WithdrawAllUserGroupsResponse> WithdrawAllUserGroupsAsync(WithdrawAllUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WithdrawAllUserGroupsWithOptionsAsync(request, runtime);
        }

    }
}
