// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Pds20220301.Models;

namespace AlibabaCloud.SDK.Pds20220301
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayPds.Client gatewayClient = new AlibabaCloud.GatewayPds.Client();
            this._spi = gatewayClient;
            this._signatureAlgorithm = "v2";
            this._disableHttp2 = true;
            this._endpointRule = "";
        }


        /**
         * @summary Adds a member to a group.
         *
         * @param request AddGroupMemberRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupMemberResponse
         */
        public AddGroupMemberResponse AddGroupMemberWithOptions(AddGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["member_id"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["member_type"] = request.MemberType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGroupMember",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/add_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Adds a member to a group.
         *
         * @param request AddGroupMemberRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupMemberResponse
         */
        public async Task<AddGroupMemberResponse> AddGroupMemberWithOptionsAsync(AddGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["member_id"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["member_type"] = request.MemberType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGroupMember",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/add_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a member to a group.
         *
         * @param request AddGroupMemberRequest
         * @return AddGroupMemberResponse
         */
        public AddGroupMemberResponse AddGroupMember(AddGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddGroupMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary Adds a member to a group.
         *
         * @param request AddGroupMemberRequest
         * @return AddGroupMemberResponse
         */
        public async Task<AddGroupMemberResponse> AddGroupMemberAsync(AddGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故事添加文件
         *
         * @param request AddStoryFilesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddStoryFilesResponse
         */
        public AddStoryFilesResponse AddStoryFilesWithOptions(AddStoryFilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddStoryFiles",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/add_story_files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddStoryFilesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 故事添加文件
         *
         * @param request AddStoryFilesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddStoryFilesResponse
         */
        public async Task<AddStoryFilesResponse> AddStoryFilesWithOptionsAsync(AddStoryFilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddStoryFiles",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/add_story_files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddStoryFilesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 故事添加文件
         *
         * @param request AddStoryFilesRequest
         * @return AddStoryFilesResponse
         */
        public AddStoryFilesResponse AddStoryFiles(AddStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddStoryFilesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故事添加文件
         *
         * @param request AddStoryFilesRequest
         * @return AddStoryFilesResponse
         */
        public async Task<AddStoryFilesResponse> AddStoryFilesAsync(AddStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddStoryFilesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Assigns a group administrator role to a user.
         *
         * @description You can call this operation to assign a group administrator role to a user.
         *
         * @param request AssignRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssignRoleResponse
         */
        public AssignRoleResponse AssignRoleWithOptions(AssignRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceId))
            {
                body["manage_resource_id"] = request.ManageResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceType))
            {
                body["manage_resource_type"] = request.ManageResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["role_id"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignRole",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/role/assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Assigns a group administrator role to a user.
         *
         * @description You can call this operation to assign a group administrator role to a user.
         *
         * @param request AssignRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssignRoleResponse
         */
        public async Task<AssignRoleResponse> AssignRoleWithOptionsAsync(AssignRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceId))
            {
                body["manage_resource_id"] = request.ManageResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceType))
            {
                body["manage_resource_type"] = request.ManageResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["role_id"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignRole",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/role/assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Assigns a group administrator role to a user.
         *
         * @description You can call this operation to assign a group administrator role to a user.
         *
         * @param request AssignRoleRequest
         * @return AssignRoleResponse
         */
        public AssignRoleResponse AssignRole(AssignRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AssignRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary Assigns a group administrator role to a user.
         *
         * @description You can call this operation to assign a group administrator role to a user.
         *
         * @param request AssignRoleRequest
         * @return AssignRoleResponse
         */
        public async Task<AssignRoleResponse> AssignRoleAsync(AssignRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AssignRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Requests permissions by using OAuth 2.0.
         *
         * @description For more information, see "OAuth 2.0 For Web Server Applications" at [OAuth 2.0 For Web Server Applications](https://www.alibabacloud.com/help/en/pds/drive-and-photo-service-dev/user-guide/oauth-2-0-access-process-for-web-server-applications) in User Guide.
         *
         * @param tmpReq AuthorizeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeResponse
         */
        public AuthorizeResponse AuthorizeWithOptions(AuthorizeRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthorizeShrinkRequest request = new AuthorizeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scope))
            {
                request.ScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scope, "scope", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideConsent))
            {
                query["hide_consent"] = request.HideConsent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginType))
            {
                query["login_type"] = request.LoginType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUri))
            {
                query["redirect_uri"] = request.RedirectUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseType))
            {
                query["response_type"] = request.ResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeShrink))
            {
                query["scope"] = request.ScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Authorize",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/oauth/authorize",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "binary",
            };
            return TeaModel.ToObject<AuthorizeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Requests permissions by using OAuth 2.0.
         *
         * @description For more information, see "OAuth 2.0 For Web Server Applications" at [OAuth 2.0 For Web Server Applications](https://www.alibabacloud.com/help/en/pds/drive-and-photo-service-dev/user-guide/oauth-2-0-access-process-for-web-server-applications) in User Guide.
         *
         * @param tmpReq AuthorizeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeResponse
         */
        public async Task<AuthorizeResponse> AuthorizeWithOptionsAsync(AuthorizeRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthorizeShrinkRequest request = new AuthorizeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scope))
            {
                request.ScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scope, "scope", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideConsent))
            {
                query["hide_consent"] = request.HideConsent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginType))
            {
                query["login_type"] = request.LoginType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUri))
            {
                query["redirect_uri"] = request.RedirectUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseType))
            {
                query["response_type"] = request.ResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeShrink))
            {
                query["scope"] = request.ScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Authorize",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/oauth/authorize",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "binary",
            };
            return TeaModel.ToObject<AuthorizeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Requests permissions by using OAuth 2.0.
         *
         * @description For more information, see "OAuth 2.0 For Web Server Applications" at [OAuth 2.0 For Web Server Applications](https://www.alibabacloud.com/help/en/pds/drive-and-photo-service-dev/user-guide/oauth-2-0-access-process-for-web-server-applications) in User Guide.
         *
         * @param request AuthorizeRequest
         * @return AuthorizeResponse
         */
        public AuthorizeResponse Authorize(AuthorizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AuthorizeWithOptions(request, headers, runtime);
        }

        /**
         * @summary Requests permissions by using OAuth 2.0.
         *
         * @description For more information, see "OAuth 2.0 For Web Server Applications" at [OAuth 2.0 For Web Server Applications](https://www.alibabacloud.com/help/en/pds/drive-and-photo-service-dev/user-guide/oauth-2-0-access-process-for-web-server-applications) in User Guide.
         *
         * @param request AuthorizeRequest
         * @return AuthorizeResponse
         */
        public async Task<AuthorizeResponse> AuthorizeAsync(AuthorizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AuthorizeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Calls multiple operations at a time to improve call efficiency.
         *
         * @param request BatchRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchResponse
         */
        public BatchResponse BatchWithOptions(BatchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Requests))
            {
                body["requests"] = request.Requests;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                body["resource"] = request.Resource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Batch",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Calls multiple operations at a time to improve call efficiency.
         *
         * @param request BatchRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchResponse
         */
        public async Task<BatchResponse> BatchWithOptionsAsync(BatchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Requests))
            {
                body["requests"] = request.Requests;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                body["resource"] = request.Resource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Batch",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Calls multiple operations at a time to improve call efficiency.
         *
         * @param request BatchRequest
         * @return BatchResponse
         */
        public BatchResponse Batch(BatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchWithOptions(request, headers, runtime);
        }

        /**
         * @summary Calls multiple operations at a time to improve call efficiency.
         *
         * @param request BatchRequest
         * @return BatchResponse
         */
        public async Task<BatchResponse> BatchAsync(BatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Cancels a role.
         *
         * @description You can cancel only the group administrator role.
         *
         * @param request CancelAssignRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelAssignRoleResponse
         */
        public CancelAssignRoleResponse CancelAssignRoleWithOptions(CancelAssignRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceId))
            {
                body["manage_resource_id"] = request.ManageResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceType))
            {
                body["manage_resource_type"] = request.ManageResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["role_id"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAssignRole",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/role/cancel_assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAssignRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Cancels a role.
         *
         * @description You can cancel only the group administrator role.
         *
         * @param request CancelAssignRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelAssignRoleResponse
         */
        public async Task<CancelAssignRoleResponse> CancelAssignRoleWithOptionsAsync(CancelAssignRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceId))
            {
                body["manage_resource_id"] = request.ManageResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceType))
            {
                body["manage_resource_type"] = request.ManageResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                body["role_id"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAssignRole",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/role/cancel_assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAssignRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels a role.
         *
         * @description You can cancel only the group administrator role.
         *
         * @param request CancelAssignRoleRequest
         * @return CancelAssignRoleResponse
         */
        public CancelAssignRoleResponse CancelAssignRole(CancelAssignRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelAssignRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary Cancels a role.
         *
         * @description You can cancel only the group administrator role.
         *
         * @param request CancelAssignRoleRequest
         * @return CancelAssignRoleResponse
         */
        public async Task<CancelAssignRoleResponse> CancelAssignRoleAsync(CancelAssignRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelAssignRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Deletes a share link.
         *
         * @param request CancelShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelShareLinkResponse
         */
        public CancelShareLinkResponse CancelShareLinkWithOptions(CancelShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelShareLinkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Deletes a share link.
         *
         * @param request CancelShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelShareLinkResponse
         */
        public async Task<CancelShareLinkResponse> CancelShareLinkWithOptionsAsync(CancelShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelShareLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a share link.
         *
         * @param request CancelShareLinkRequest
         * @return CancelShareLinkResponse
         */
        public CancelShareLinkResponse CancelShareLink(CancelShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelShareLinkWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deletes a share link.
         *
         * @param request CancelShareLinkRequest
         * @return CancelShareLinkResponse
         */
        public async Task<CancelShareLinkResponse> CancelShareLinkAsync(CancelShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelShareLinkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Empties the recycle bin.
         *
         * @param request ClearRecyclebinRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearRecyclebinResponse
         */
        public ClearRecyclebinResponse ClearRecyclebinWithOptions(ClearRecyclebinRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearRecyclebin",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/recyclebin/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearRecyclebinResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Empties the recycle bin.
         *
         * @param request ClearRecyclebinRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearRecyclebinResponse
         */
        public async Task<ClearRecyclebinResponse> ClearRecyclebinWithOptionsAsync(ClearRecyclebinRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearRecyclebin",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/recyclebin/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearRecyclebinResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Empties the recycle bin.
         *
         * @param request ClearRecyclebinRequest
         * @return ClearRecyclebinResponse
         */
        public ClearRecyclebinResponse ClearRecyclebin(ClearRecyclebinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ClearRecyclebinWithOptions(request, headers, runtime);
        }

        /**
         * @summary Empties the recycle bin.
         *
         * @param request ClearRecyclebinRequest
         * @return ClearRecyclebinResponse
         */
        public async Task<ClearRecyclebinResponse> ClearRecyclebinAsync(ClearRecyclebinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ClearRecyclebinWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Completes the upload of a file.
         *
         * @param request CompleteFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompleteFileResponse
         */
        public CompleteFileResponse CompleteFileWithOptions(CompleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                body["upload_id"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/complete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Completes the upload of a file.
         *
         * @param request CompleteFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompleteFileResponse
         */
        public async Task<CompleteFileResponse> CompleteFileWithOptionsAsync(CompleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                body["upload_id"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/complete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Completes the upload of a file.
         *
         * @param request CompleteFileRequest
         * @return CompleteFileResponse
         */
        public CompleteFileResponse CompleteFile(CompleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CompleteFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Completes the upload of a file.
         *
         * @param request CompleteFileRequest
         * @return CompleteFileResponse
         */
        public async Task<CompleteFileResponse> CompleteFileAsync(CompleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CompleteFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Copies a file or folder.
         *
         * @param request CopyFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyFileResponse
         */
        public CopyFileResponse CopyFileWithOptions(CopyFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRename))
            {
                body["auto_rename"] = request.AutoRename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDriveId))
            {
                body["to_drive_id"] = request.ToDriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentFileId))
            {
                body["to_parent_file_id"] = request.ToParentFileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Copies a file or folder.
         *
         * @param request CopyFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyFileResponse
         */
        public async Task<CopyFileResponse> CopyFileWithOptionsAsync(CopyFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRename))
            {
                body["auto_rename"] = request.AutoRename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDriveId))
            {
                body["to_drive_id"] = request.ToDriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentFileId))
            {
                body["to_parent_file_id"] = request.ToParentFileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Copies a file or folder.
         *
         * @param request CopyFileRequest
         * @return CopyFileResponse
         */
        public CopyFileResponse CopyFile(CopyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CopyFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Copies a file or folder.
         *
         * @param request CopyFileRequest
         * @return CopyFileResponse
         */
        public async Task<CopyFileResponse> CopyFileAsync(CopyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CopyFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建自定义故事
         *
         * @param request CreateCustomizedStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomizedStoryResponse
         */
        public CreateCustomizedStoryResponse CreateCustomizedStoryWithOptions(CreateCustomizedStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                body["custom_labels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryCover))
            {
                body["story_cover"] = request.StoryCover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryFiles))
            {
                body["story_files"] = request.StoryFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["story_name"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                body["story_sub_type"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["story_type"] = request.StoryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomizedStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/create_customized_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomizedStoryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建自定义故事
         *
         * @param request CreateCustomizedStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomizedStoryResponse
         */
        public async Task<CreateCustomizedStoryResponse> CreateCustomizedStoryWithOptionsAsync(CreateCustomizedStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                body["custom_labels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryCover))
            {
                body["story_cover"] = request.StoryCover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryFiles))
            {
                body["story_files"] = request.StoryFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["story_name"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                body["story_sub_type"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["story_type"] = request.StoryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomizedStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/create_customized_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomizedStoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建自定义故事
         *
         * @param request CreateCustomizedStoryRequest
         * @return CreateCustomizedStoryResponse
         */
        public CreateCustomizedStoryResponse CreateCustomizedStory(CreateCustomizedStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCustomizedStoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建自定义故事
         *
         * @param request CreateCustomizedStoryRequest
         * @return CreateCustomizedStoryResponse
         */
        public async Task<CreateCustomizedStoryResponse> CreateCustomizedStoryAsync(CreateCustomizedStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCustomizedStoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Create domain.
         *
         * @description If you want to perform secondary operations based on Drive and Photo Service and perform fine-grained control on your tenants, you can use the parent-child domain feature of Drive and Photo Service. For more information, join the DingTalk group whose ID is 23146118.
         *
         * @param request CreateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domain_name"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitDriveEnable))
            {
                body["init_drive_enable"] = request.InitDriveEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitDriveSize))
            {
                body["init_drive_size"] = request.InitDriveSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDomainId))
            {
                body["parent_domain_id"] = request.ParentDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeQuota))
            {
                body["size_quota"] = request.SizeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCountQuota))
            {
                body["user_count_quota"] = request.UserCountQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Create domain.
         *
         * @description If you want to perform secondary operations based on Drive and Photo Service and perform fine-grained control on your tenants, you can use the parent-child domain feature of Drive and Photo Service. For more information, join the DingTalk group whose ID is 23146118.
         *
         * @param request CreateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domain_name"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitDriveEnable))
            {
                body["init_drive_enable"] = request.InitDriveEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitDriveSize))
            {
                body["init_drive_size"] = request.InitDriveSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDomainId))
            {
                body["parent_domain_id"] = request.ParentDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeQuota))
            {
                body["size_quota"] = request.SizeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCountQuota))
            {
                body["user_count_quota"] = request.UserCountQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Create domain.
         *
         * @description If you want to perform secondary operations based on Drive and Photo Service and perform fine-grained control on your tenants, you can use the parent-child domain feature of Drive and Photo Service. For more information, join the DingTalk group whose ID is 23146118.
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDomainWithOptions(request, headers, runtime);
        }

        /**
         * @summary Create domain.
         *
         * @description If you want to perform secondary operations based on Drive and Photo Service and perform fine-grained control on your tenants, you can use the parent-child domain feature of Drive and Photo Service. For more information, join the DingTalk group whose ID is 23146118.
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDomainWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a drive.
         *
         * @param request CreateDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDriveResponse
         */
        public CreateDriveResponse CreateDriveWithOptions(CreateDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Default))
            {
                body["default"] = request.Default;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveName))
            {
                body["drive_name"] = request.DriveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveType))
            {
                body["drive_type"] = request.DriveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerType))
            {
                body["owner_type"] = request.OwnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSize))
            {
                body["total_size"] = request.TotalSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDriveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Creates a drive.
         *
         * @param request CreateDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDriveResponse
         */
        public async Task<CreateDriveResponse> CreateDriveWithOptionsAsync(CreateDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Default))
            {
                body["default"] = request.Default;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveName))
            {
                body["drive_name"] = request.DriveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveType))
            {
                body["drive_type"] = request.DriveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerType))
            {
                body["owner_type"] = request.OwnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSize))
            {
                body["total_size"] = request.TotalSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDriveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a drive.
         *
         * @param request CreateDriveRequest
         * @return CreateDriveResponse
         */
        public CreateDriveResponse CreateDrive(CreateDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDriveWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a drive.
         *
         * @param request CreateDriveRequest
         * @return CreateDriveResponse
         */
        public async Task<CreateDriveResponse> CreateDriveAsync(CreateDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDriveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a file or folder.
         *
         * @param request CreateFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileResponse
         */
        public CreateFileResponse CreateFileWithOptions(CreateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNameMode))
            {
                body["check_name_mode"] = request.CheckNameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentHash))
            {
                body["content_hash"] = request.ContentHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentHashName))
            {
                body["content_hash_name"] = request.ContentHashName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["content_type"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                body["hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageMediaMetadata))
            {
                body["image_media_metadata"] = request.ImageMediaMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalCreatedAt))
            {
                body["local_created_at"] = request.LocalCreatedAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalModifiedAt))
            {
                body["local_modified_at"] = request.LocalModifiedAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParallelUpload))
            {
                body["parallel_upload"] = request.ParallelUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFileId))
            {
                body["parent_file_id"] = request.ParentFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartInfoList))
            {
                body["part_info_list"] = request.PartInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreHash))
            {
                body["pre_hash"] = request.PreHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTags))
            {
                body["user_tags"] = request.UserTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoMediaMetadata))
            {
                body["video_media_metadata"] = request.VideoMediaMetadata;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Creates a file or folder.
         *
         * @param request CreateFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileResponse
         */
        public async Task<CreateFileResponse> CreateFileWithOptionsAsync(CreateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNameMode))
            {
                body["check_name_mode"] = request.CheckNameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentHash))
            {
                body["content_hash"] = request.ContentHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentHashName))
            {
                body["content_hash_name"] = request.ContentHashName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["content_type"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                body["hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageMediaMetadata))
            {
                body["image_media_metadata"] = request.ImageMediaMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalCreatedAt))
            {
                body["local_created_at"] = request.LocalCreatedAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalModifiedAt))
            {
                body["local_modified_at"] = request.LocalModifiedAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParallelUpload))
            {
                body["parallel_upload"] = request.ParallelUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFileId))
            {
                body["parent_file_id"] = request.ParentFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartInfoList))
            {
                body["part_info_list"] = request.PartInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreHash))
            {
                body["pre_hash"] = request.PreHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTags))
            {
                body["user_tags"] = request.UserTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoMediaMetadata))
            {
                body["video_media_metadata"] = request.VideoMediaMetadata;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a file or folder.
         *
         * @param request CreateFileRequest
         * @return CreateFileResponse
         */
        public CreateFileResponse CreateFile(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a file or folder.
         *
         * @param request CreateFileRequest
         * @return CreateFileResponse
         */
        public async Task<CreateFileResponse> CreateFileAsync(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a group.
         *
         * @param request CreateGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupResponse
         */
        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["group_name"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRoot))
            {
                body["is_root"] = request.IsRoot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["parent_group_id"] = request.ParentGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Creates a group.
         *
         * @param request CreateGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupResponse
         */
        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["group_name"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRoot))
            {
                body["is_root"] = request.IsRoot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["parent_group_id"] = request.ParentGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a group.
         *
         * @param request CreateGroupRequest
         * @return CreateGroupResponse
         */
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a group.
         *
         * @param request CreateGroupRequest
         * @return CreateGroupResponse
         */
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a mapping between an entity and a benefit package. You can call this operation to associate a benefit package with a user.
         *
         * @description If you need to manage a large number of users based on Drive and Photo Service, you can control the features and quotas that users can use based on the benefits to which they are entitled. For more information, join the DingTalk group (ID 23146118).
         *
         * @param request CreateIdentityToBenefitPkgMappingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIdentityToBenefitPkgMappingResponse
         */
        public CreateIdentityToBenefitPkgMappingResponse CreateIdentityToBenefitPkgMappingWithOptions(CreateIdentityToBenefitPkgMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPkgId))
            {
                body["benefit_pkg_id"] = request.BenefitPkgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expire_time"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                body["identity_id"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["identity_type"] = request.IdentityType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdentityToBenefitPkgMapping",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/benefit/identity_to_benefit_pkg_mapping/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdentityToBenefitPkgMappingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Creates a mapping between an entity and a benefit package. You can call this operation to associate a benefit package with a user.
         *
         * @description If you need to manage a large number of users based on Drive and Photo Service, you can control the features and quotas that users can use based on the benefits to which they are entitled. For more information, join the DingTalk group (ID 23146118).
         *
         * @param request CreateIdentityToBenefitPkgMappingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIdentityToBenefitPkgMappingResponse
         */
        public async Task<CreateIdentityToBenefitPkgMappingResponse> CreateIdentityToBenefitPkgMappingWithOptionsAsync(CreateIdentityToBenefitPkgMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPkgId))
            {
                body["benefit_pkg_id"] = request.BenefitPkgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expire_time"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                body["identity_id"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["identity_type"] = request.IdentityType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdentityToBenefitPkgMapping",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/benefit/identity_to_benefit_pkg_mapping/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdentityToBenefitPkgMappingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a mapping between an entity and a benefit package. You can call this operation to associate a benefit package with a user.
         *
         * @description If you need to manage a large number of users based on Drive and Photo Service, you can control the features and quotas that users can use based on the benefits to which they are entitled. For more information, join the DingTalk group (ID 23146118).
         *
         * @param request CreateIdentityToBenefitPkgMappingRequest
         * @return CreateIdentityToBenefitPkgMappingResponse
         */
        public CreateIdentityToBenefitPkgMappingResponse CreateIdentityToBenefitPkgMapping(CreateIdentityToBenefitPkgMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIdentityToBenefitPkgMappingWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a mapping between an entity and a benefit package. You can call this operation to associate a benefit package with a user.
         *
         * @description If you need to manage a large number of users based on Drive and Photo Service, you can control the features and quotas that users can use based on the benefits to which they are entitled. For more information, join the DingTalk group (ID 23146118).
         *
         * @param request CreateIdentityToBenefitPkgMappingRequest
         * @return CreateIdentityToBenefitPkgMappingResponse
         */
        public async Task<CreateIdentityToBenefitPkgMappingResponse> CreateIdentityToBenefitPkgMappingAsync(CreateIdentityToBenefitPkgMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIdentityToBenefitPkgMappingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建凌霄订单
         *
         * @param request CreateOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOrderResponse
         */
        public CreateOrderResponse CreateOrderWithOptions(CreateOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["auto_pay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["auto_renew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["order_type"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Package))
            {
                body["package"] = request.Package;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["period_unit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSize))
            {
                body["total_size"] = request.TotalSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCount))
            {
                body["user_count"] = request.UserCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/create_order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建凌霄订单
         *
         * @param request CreateOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOrderResponse
         */
        public async Task<CreateOrderResponse> CreateOrderWithOptionsAsync(CreateOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["auto_pay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["auto_renew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["order_type"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Package))
            {
                body["package"] = request.Package;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["period_unit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSize))
            {
                body["total_size"] = request.TotalSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCount))
            {
                body["user_count"] = request.UserCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/create_order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建凌霄订单
         *
         * @param request CreateOrderRequest
         * @return CreateOrderResponse
         */
        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建凌霄订单
         *
         * @param request CreateOrderRequest
         * @return CreateOrderResponse
         */
        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a share URL.
         *
         * @description A share is a file view container. You can grant anonymous users the permissions to access files in the user drive by using the share URL. Anonymous users can access the files based on the granted permissions.
         *
         * @param request CreateShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateShareLinkResponse
         */
        public CreateShareLinkResponse CreateShareLinkWithOptions(CreateShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creatable))
            {
                body["creatable"] = request.Creatable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatableFileIdList))
            {
                body["creatable_file_id_list"] = request.CreatableFileIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableDownload))
            {
                body["disable_download"] = request.DisableDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisablePreview))
            {
                body["disable_preview"] = request.DisablePreview;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSave))
            {
                body["disable_save"] = request.DisableSave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadLimit))
            {
                body["download_limit"] = request.DownloadLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                body["expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdList))
            {
                body["file_id_list"] = request.FileIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewLimit))
            {
                body["preview_limit"] = request.PreviewLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveLimit))
            {
                body["save_limit"] = request.SaveLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareAllFiles))
            {
                body["share_all_files"] = request.ShareAllFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareName))
            {
                body["share_name"] = request.ShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharePwd))
            {
                body["share_pwd"] = request.SharePwd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateShareLinkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Creates a share URL.
         *
         * @description A share is a file view container. You can grant anonymous users the permissions to access files in the user drive by using the share URL. Anonymous users can access the files based on the granted permissions.
         *
         * @param request CreateShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateShareLinkResponse
         */
        public async Task<CreateShareLinkResponse> CreateShareLinkWithOptionsAsync(CreateShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creatable))
            {
                body["creatable"] = request.Creatable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatableFileIdList))
            {
                body["creatable_file_id_list"] = request.CreatableFileIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableDownload))
            {
                body["disable_download"] = request.DisableDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisablePreview))
            {
                body["disable_preview"] = request.DisablePreview;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSave))
            {
                body["disable_save"] = request.DisableSave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadLimit))
            {
                body["download_limit"] = request.DownloadLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                body["expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdList))
            {
                body["file_id_list"] = request.FileIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewLimit))
            {
                body["preview_limit"] = request.PreviewLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveLimit))
            {
                body["save_limit"] = request.SaveLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareAllFiles))
            {
                body["share_all_files"] = request.ShareAllFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareName))
            {
                body["share_name"] = request.ShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharePwd))
            {
                body["share_pwd"] = request.SharePwd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateShareLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a share URL.
         *
         * @description A share is a file view container. You can grant anonymous users the permissions to access files in the user drive by using the share URL. Anonymous users can access the files based on the granted permissions.
         *
         * @param request CreateShareLinkRequest
         * @return CreateShareLinkResponse
         */
        public CreateShareLinkResponse CreateShareLink(CreateShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateShareLinkWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a share URL.
         *
         * @description A share is a file view container. You can grant anonymous users the permissions to access files in the user drive by using the share URL. Anonymous users can access the files based on the granted permissions.
         *
         * @param request CreateShareLinkRequest
         * @return CreateShareLinkResponse
         */
        public async Task<CreateShareLinkResponse> CreateShareLinkAsync(CreateShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateShareLinkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建相似图片聚类任务
         *
         * @param request CreateSimilarImageClusterTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSimilarImageClusterTaskResponse
         */
        public CreateSimilarImageClusterTaskResponse CreateSimilarImageClusterTaskWithOptions(CreateSimilarImageClusterTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSimilarImageClusterTask",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/create_similar_image_cluster_task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSimilarImageClusterTaskResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建相似图片聚类任务
         *
         * @param request CreateSimilarImageClusterTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSimilarImageClusterTaskResponse
         */
        public async Task<CreateSimilarImageClusterTaskResponse> CreateSimilarImageClusterTaskWithOptionsAsync(CreateSimilarImageClusterTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSimilarImageClusterTask",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/create_similar_image_cluster_task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSimilarImageClusterTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建相似图片聚类任务
         *
         * @param request CreateSimilarImageClusterTaskRequest
         * @return CreateSimilarImageClusterTaskResponse
         */
        public CreateSimilarImageClusterTaskResponse CreateSimilarImageClusterTask(CreateSimilarImageClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSimilarImageClusterTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建相似图片聚类任务
         *
         * @param request CreateSimilarImageClusterTaskRequest
         * @return CreateSimilarImageClusterTaskResponse
         */
        public async Task<CreateSimilarImageClusterTaskResponse> CreateSimilarImageClusterTaskAsync(CreateSimilarImageClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSimilarImageClusterTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建推荐故事
         *
         * @param request CreateStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoryResponse
         */
        public CreateStoryResponse CreateStoryWithOptions(CreateStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                body["custom_labels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxImageCount))
            {
                body["max_image_count"] = request.MaxImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinImageCount))
            {
                body["min_image_count"] = request.MinImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryEndTime))
            {
                body["story_end_time"] = request.StoryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["story_name"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryStartTime))
            {
                body["story_start_time"] = request.StoryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                body["story_sub_type"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["story_type"] = request.StoryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/create_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建推荐故事
         *
         * @param request CreateStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoryResponse
         */
        public async Task<CreateStoryResponse> CreateStoryWithOptionsAsync(CreateStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                body["custom_labels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxImageCount))
            {
                body["max_image_count"] = request.MaxImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinImageCount))
            {
                body["min_image_count"] = request.MinImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryEndTime))
            {
                body["story_end_time"] = request.StoryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["story_name"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryStartTime))
            {
                body["story_start_time"] = request.StoryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                body["story_sub_type"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["story_type"] = request.StoryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/create_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建推荐故事
         *
         * @param request CreateStoryRequest
         * @return CreateStoryResponse
         */
        public CreateStoryResponse CreateStory(CreateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateStoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建推荐故事
         *
         * @param request CreateStoryRequest
         * @return CreateStoryResponse
         */
        public async Task<CreateStoryResponse> CreateStoryAsync(CreateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateStoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a user.
         *
         * @param request CreateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfoList))
            {
                body["group_info_list"] = request.GroupInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nick_name"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Creates a user.
         *
         * @param request CreateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfoList))
            {
                body["group_info_list"] = request.GroupInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nick_name"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a user.
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a user.
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取文件内容安全信息
         *
         * @param request CsiGetFileInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CsiGetFileInfoResponse
         */
        public CsiGetFileInfoResponse CsiGetFileInfoWithOptions(CsiGetFileInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CsiGetFileInfo",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/csi/get_file_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CsiGetFileInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取文件内容安全信息
         *
         * @param request CsiGetFileInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CsiGetFileInfoResponse
         */
        public async Task<CsiGetFileInfoResponse> CsiGetFileInfoWithOptionsAsync(CsiGetFileInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CsiGetFileInfo",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/csi/get_file_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CsiGetFileInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文件内容安全信息
         *
         * @param request CsiGetFileInfoRequest
         * @return CsiGetFileInfoResponse
         */
        public CsiGetFileInfoResponse CsiGetFileInfo(CsiGetFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CsiGetFileInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取文件内容安全信息
         *
         * @param request CsiGetFileInfoRequest
         * @return CsiGetFileInfoResponse
         */
        public async Task<CsiGetFileInfoResponse> CsiGetFileInfoAsync(CsiGetFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CsiGetFileInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Delete the domain
         *
         * @param request DeleteDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["domain_id"] = request.DomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Delete the domain
         *
         * @param request DeleteDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["domain_id"] = request.DomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Delete the domain
         *
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDomainWithOptions(request, headers, runtime);
        }

        /**
         * @summary Delete the domain
         *
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDomainWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Deletes a drive.
         *
         * @param request DeleteDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDriveResponse
         */
        public DeleteDriveResponse DeleteDriveWithOptions(DeleteDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDriveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Deletes a drive.
         *
         * @param request DeleteDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDriveResponse
         */
        public async Task<DeleteDriveResponse> DeleteDriveWithOptionsAsync(DeleteDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDriveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a drive.
         *
         * @param request DeleteDriveRequest
         * @return DeleteDriveResponse
         */
        public DeleteDriveResponse DeleteDrive(DeleteDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDriveWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deletes a drive.
         *
         * @param request DeleteDriveRequest
         * @return DeleteDriveResponse
         */
        public async Task<DeleteDriveResponse> DeleteDriveAsync(DeleteDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDriveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Deletes a file or folder.
         *
         * @param request DeleteFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileResponse
         */
        public DeleteFileResponse DeleteFileWithOptions(DeleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Deletes a file or folder.
         *
         * @param request DeleteFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileResponse
         */
        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(DeleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a file or folder.
         *
         * @param request DeleteFileRequest
         * @return DeleteFileResponse
         */
        public DeleteFileResponse DeleteFile(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deletes a file or folder.
         *
         * @param request DeleteFileRequest
         * @return DeleteFileResponse
         */
        public async Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Deletes groups. Before you delete a group, make sure that no other groups or users exist in the group. Otherwise, the group fails to be deleted.
         *
         * @param request DeleteGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupResponse
         */
        public DeleteGroupResponse DeleteGroupWithOptions(DeleteGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Deletes groups. Before you delete a group, make sure that no other groups or users exist in the group. Otherwise, the group fails to be deleted.
         *
         * @param request DeleteGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupResponse
         */
        public async Task<DeleteGroupResponse> DeleteGroupWithOptionsAsync(DeleteGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes groups. Before you delete a group, make sure that no other groups or users exist in the group. Otherwise, the group fails to be deleted.
         *
         * @param request DeleteGroupRequest
         * @return DeleteGroupResponse
         */
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deletes groups. Before you delete a group, make sure that no other groups or users exist in the group. Otherwise, the group fails to be deleted.
         *
         * @param request DeleteGroupRequest
         * @return DeleteGroupResponse
         */
        public async Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Deletes a historical version of a file. You cannot delete the latest version of a file.
         *
         * @param request DeleteRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRevisionResponse
         */
        public DeleteRevisionResponse DeleteRevisionWithOptions(DeleteRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revision_id"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRevisionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Deletes a historical version of a file. You cannot delete the latest version of a file.
         *
         * @param request DeleteRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRevisionResponse
         */
        public async Task<DeleteRevisionResponse> DeleteRevisionWithOptionsAsync(DeleteRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revision_id"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRevisionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a historical version of a file. You cannot delete the latest version of a file.
         *
         * @param request DeleteRevisionRequest
         * @return DeleteRevisionResponse
         */
        public DeleteRevisionResponse DeleteRevision(DeleteRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRevisionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deletes a historical version of a file. You cannot delete the latest version of a file.
         *
         * @param request DeleteRevisionRequest
         * @return DeleteRevisionResponse
         */
        public async Task<DeleteRevisionResponse> DeleteRevisionAsync(DeleteRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRevisionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除故事
         *
         * @param request DeleteStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteStoryResponse
         */
        public DeleteStoryResponse DeleteStoryWithOptions(DeleteStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/delete_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStoryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除故事
         *
         * @param request DeleteStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteStoryResponse
         */
        public async Task<DeleteStoryResponse> DeleteStoryWithOptionsAsync(DeleteStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/delete_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除故事
         *
         * @param request DeleteStoryRequest
         * @return DeleteStoryResponse
         */
        public DeleteStoryResponse DeleteStory(DeleteStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteStoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除故事
         *
         * @param request DeleteStoryRequest
         * @return DeleteStoryResponse
         */
        public async Task<DeleteStoryResponse> DeleteStoryAsync(DeleteStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteStoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Deletes a user.
         *
         * @param request DeleteUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Deletes a user.
         *
         * @param request DeleteUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a user.
         *
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deletes a user.
         *
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the cursor of incremental information.
         *
         * @param request DeltaGetLastCursorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeltaGetLastCursorResponse
         */
        public DeltaGetLastCursorResponse DeltaGetLastCursorWithOptions(DeltaGetLastCursorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRootId))
            {
                body["sync_root_id"] = request.SyncRootId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeltaGetLastCursor",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_last_cursor",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeltaGetLastCursorResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the cursor of incremental information.
         *
         * @param request DeltaGetLastCursorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeltaGetLastCursorResponse
         */
        public async Task<DeltaGetLastCursorResponse> DeltaGetLastCursorWithOptionsAsync(DeltaGetLastCursorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRootId))
            {
                body["sync_root_id"] = request.SyncRootId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeltaGetLastCursor",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_last_cursor",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeltaGetLastCursorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the cursor of incremental information.
         *
         * @param request DeltaGetLastCursorRequest
         * @return DeltaGetLastCursorResponse
         */
        public DeltaGetLastCursorResponse DeltaGetLastCursor(DeltaGetLastCursorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeltaGetLastCursorWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the cursor of incremental information.
         *
         * @param request DeltaGetLastCursorRequest
         * @return DeltaGetLastCursorResponse
         */
        public async Task<DeltaGetLastCursorResponse> DeltaGetLastCursorAsync(DeltaGetLastCursorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeltaGetLastCursorWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Downloads a file.
         *
         * @description For information about best practices for downloading a file.
         *
         * @param request DownloadFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DownloadFileResponse
         */
        public DownloadFileResponse DownloadFileWithOptions(DownloadFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                query["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                query["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeThumbnailProcess))
            {
                query["office_thumbnail_process"] = request.OfficeThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                query["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                query["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/download",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "binary",
            };
            return TeaModel.ToObject<DownloadFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Downloads a file.
         *
         * @description For information about best practices for downloading a file.
         *
         * @param request DownloadFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DownloadFileResponse
         */
        public async Task<DownloadFileResponse> DownloadFileWithOptionsAsync(DownloadFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                query["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                query["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeThumbnailProcess))
            {
                query["office_thumbnail_process"] = request.OfficeThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                query["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                query["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/download",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "binary",
            };
            return TeaModel.ToObject<DownloadFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Downloads a file.
         *
         * @description For information about best practices for downloading a file.
         *
         * @param request DownloadFileRequest
         * @return DownloadFileResponse
         */
        public DownloadFileResponse DownloadFile(DownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DownloadFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Downloads a file.
         *
         * @description For information about best practices for downloading a file.
         *
         * @param request DownloadFileRequest
         * @return DownloadFileResponse
         */
        public async Task<DownloadFileResponse> DownloadFileAsync(DownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DownloadFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Grants permissions to access files to a user or group.
         *
         * @param request FileAddPermissionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileAddPermissionResponse
         */
        public FileAddPermissionResponse FileAddPermissionWithOptions(FileAddPermissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberList))
            {
                body["member_list"] = request.MemberList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileAddPermission",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/add_permission",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileAddPermissionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Grants permissions to access files to a user or group.
         *
         * @param request FileAddPermissionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileAddPermissionResponse
         */
        public async Task<FileAddPermissionResponse> FileAddPermissionWithOptionsAsync(FileAddPermissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberList))
            {
                body["member_list"] = request.MemberList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileAddPermission",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/add_permission",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileAddPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Grants permissions to access files to a user or group.
         *
         * @param request FileAddPermissionRequest
         * @return FileAddPermissionResponse
         */
        public FileAddPermissionResponse FileAddPermission(FileAddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FileAddPermissionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Grants permissions to access files to a user or group.
         *
         * @param request FileAddPermissionRequest
         * @return FileAddPermissionResponse
         */
        public async Task<FileAddPermissionResponse> FileAddPermissionAsync(FileAddPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FileAddPermissionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Removes custom tags from a file.
         *
         * @param request FileDeleteUserTagsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileDeleteUserTagsResponse
         */
        public FileDeleteUserTagsResponse FileDeleteUserTagsWithOptions(FileDeleteUserTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyList))
            {
                body["key_list"] = request.KeyList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileDeleteUserTags",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/delete_usertags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileDeleteUserTagsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Removes custom tags from a file.
         *
         * @param request FileDeleteUserTagsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileDeleteUserTagsResponse
         */
        public async Task<FileDeleteUserTagsResponse> FileDeleteUserTagsWithOptionsAsync(FileDeleteUserTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyList))
            {
                body["key_list"] = request.KeyList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileDeleteUserTags",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/delete_usertags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileDeleteUserTagsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Removes custom tags from a file.
         *
         * @param request FileDeleteUserTagsRequest
         * @return FileDeleteUserTagsResponse
         */
        public FileDeleteUserTagsResponse FileDeleteUserTags(FileDeleteUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FileDeleteUserTagsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Removes custom tags from a file.
         *
         * @param request FileDeleteUserTagsRequest
         * @return FileDeleteUserTagsResponse
         */
        public async Task<FileDeleteUserTagsResponse> FileDeleteUserTagsAsync(FileDeleteUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FileDeleteUserTagsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the sharing authorization records of a file.
         *
         * @param request FileListPermissionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileListPermissionResponse
         */
        public FileListPermissionResponse FileListPermissionWithOptions(FileListPermissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileListPermission",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list_permission",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<FileListPermissionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the sharing authorization records of a file.
         *
         * @param request FileListPermissionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileListPermissionResponse
         */
        public async Task<FileListPermissionResponse> FileListPermissionWithOptionsAsync(FileListPermissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileListPermission",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list_permission",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<FileListPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the sharing authorization records of a file.
         *
         * @param request FileListPermissionRequest
         * @return FileListPermissionResponse
         */
        public FileListPermissionResponse FileListPermission(FileListPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FileListPermissionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the sharing authorization records of a file.
         *
         * @param request FileListPermissionRequest
         * @return FileListPermissionResponse
         */
        public async Task<FileListPermissionResponse> FileListPermissionAsync(FileListPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FileListPermissionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Adds custom tags to a file.
         *
         * @description This operation is an incremental update operation. Take note of the following items:
         * *   If a tag name specified in the request is the same as an existing tag name, the existing tag is overwritten.
         * *   If a tag name specified in the request is different from the existing tag names, the specified tag is added.
         * *   The existing tags with unique names are not affected.
         *
         * @param request FilePutUserTagsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FilePutUserTagsResponse
         */
        public FilePutUserTagsResponse FilePutUserTagsWithOptions(FilePutUserTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTags))
            {
                body["user_tags"] = request.UserTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FilePutUserTags",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/put_usertags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FilePutUserTagsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Adds custom tags to a file.
         *
         * @description This operation is an incremental update operation. Take note of the following items:
         * *   If a tag name specified in the request is the same as an existing tag name, the existing tag is overwritten.
         * *   If a tag name specified in the request is different from the existing tag names, the specified tag is added.
         * *   The existing tags with unique names are not affected.
         *
         * @param request FilePutUserTagsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FilePutUserTagsResponse
         */
        public async Task<FilePutUserTagsResponse> FilePutUserTagsWithOptionsAsync(FilePutUserTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTags))
            {
                body["user_tags"] = request.UserTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FilePutUserTags",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/put_usertags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FilePutUserTagsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Adds custom tags to a file.
         *
         * @description This operation is an incremental update operation. Take note of the following items:
         * *   If a tag name specified in the request is the same as an existing tag name, the existing tag is overwritten.
         * *   If a tag name specified in the request is different from the existing tag names, the specified tag is added.
         * *   The existing tags with unique names are not affected.
         *
         * @param request FilePutUserTagsRequest
         * @return FilePutUserTagsResponse
         */
        public FilePutUserTagsResponse FilePutUserTags(FilePutUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FilePutUserTagsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Adds custom tags to a file.
         *
         * @description This operation is an incremental update operation. Take note of the following items:
         * *   If a tag name specified in the request is the same as an existing tag name, the existing tag is overwritten.
         * *   If a tag name specified in the request is different from the existing tag names, the specified tag is added.
         * *   The existing tags with unique names are not affected.
         *
         * @param request FilePutUserTagsRequest
         * @return FilePutUserTagsResponse
         */
        public async Task<FilePutUserTagsResponse> FilePutUserTagsAsync(FilePutUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FilePutUserTagsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Cancels the permissions on a shared file.
         *
         * @param request FileRemovePermissionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileRemovePermissionResponse
         */
        public FileRemovePermissionResponse FileRemovePermissionWithOptions(FileRemovePermissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberList))
            {
                body["member_list"] = request.MemberList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileRemovePermission",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/remove_permission",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileRemovePermissionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Cancels the permissions on a shared file.
         *
         * @param request FileRemovePermissionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileRemovePermissionResponse
         */
        public async Task<FileRemovePermissionResponse> FileRemovePermissionWithOptionsAsync(FileRemovePermissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberList))
            {
                body["member_list"] = request.MemberList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileRemovePermission",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/remove_permission",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileRemovePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels the permissions on a shared file.
         *
         * @param request FileRemovePermissionRequest
         * @return FileRemovePermissionResponse
         */
        public FileRemovePermissionResponse FileRemovePermission(FileRemovePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FileRemovePermissionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Cancels the permissions on a shared file.
         *
         * @param request FileRemovePermissionRequest
         * @return FileRemovePermissionResponse
         */
        public async Task<FileRemovePermissionResponse> FileRemovePermissionAsync(FileRemovePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FileRemovePermissionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about an asynchronous task.
         *
         * @param request GetAsyncTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsyncTaskResponse
         */
        public GetAsyncTaskResponse GetAsyncTaskWithOptions(GetAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncTaskId))
            {
                body["async_task_id"] = request.AsyncTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTask",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/async_task/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an asynchronous task.
         *
         * @param request GetAsyncTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsyncTaskResponse
         */
        public async Task<GetAsyncTaskResponse> GetAsyncTaskWithOptionsAsync(GetAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncTaskId))
            {
                body["async_task_id"] = request.AsyncTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTask",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/async_task/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an asynchronous task.
         *
         * @param request GetAsyncTaskRequest
         * @return GetAsyncTaskResponse
         */
        public GetAsyncTaskResponse GetAsyncTask(GetAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAsyncTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about an asynchronous task.
         *
         * @param request GetAsyncTaskRequest
         * @return GetAsyncTaskResponse
         */
        public async Task<GetAsyncTaskResponse> GetAsyncTaskAsync(GetAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAsyncTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the default drive of a user.
         *
         * @param request GetDefaultDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDefaultDriveResponse
         */
        public GetDefaultDriveResponse GetDefaultDriveWithOptions(GetDefaultDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/get_default_drive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultDriveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the default drive of a user.
         *
         * @param request GetDefaultDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDefaultDriveResponse
         */
        public async Task<GetDefaultDriveResponse> GetDefaultDriveWithOptionsAsync(GetDefaultDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/get_default_drive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultDriveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the default drive of a user.
         *
         * @param request GetDefaultDriveRequest
         * @return GetDefaultDriveResponse
         */
        public GetDefaultDriveResponse GetDefaultDrive(GetDefaultDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDefaultDriveWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the default drive of a user.
         *
         * @param request GetDefaultDriveRequest
         * @return GetDefaultDriveResponse
         */
        public async Task<GetDefaultDriveResponse> GetDefaultDriveAsync(GetDefaultDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDefaultDriveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Get domain information.
         *
         * @param request GetDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainResponse
         */
        public GetDomainResponse GetDomainWithOptions(GetDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["domain_id"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetQuotaUsed))
            {
                body["get_quota_used"] = request.GetQuotaUsed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Get domain information.
         *
         * @param request GetDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainResponse
         */
        public async Task<GetDomainResponse> GetDomainWithOptionsAsync(GetDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["domain_id"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetQuotaUsed))
            {
                body["get_quota_used"] = request.GetQuotaUsed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Get domain information.
         *
         * @param request GetDomainRequest
         * @return GetDomainResponse
         */
        public GetDomainResponse GetDomain(GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDomainWithOptions(request, headers, runtime);
        }

        /**
         * @summary Get domain information.
         *
         * @param request GetDomainRequest
         * @return GetDomainResponse
         */
        public async Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDomainWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取domain限额
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainQuotaResponse
         */
        public GetDomainQuotaResponse GetDomainQuotaWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomainQuota",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/get_quota",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainQuotaResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取domain限额
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainQuotaResponse
         */
        public async Task<GetDomainQuotaResponse> GetDomainQuotaWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomainQuota",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/get_quota",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainQuotaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取domain限额
         *
         * @return GetDomainQuotaResponse
         */
        public GetDomainQuotaResponse GetDomainQuota()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDomainQuotaWithOptions(headers, runtime);
        }

        /**
         * @summary 获取domain限额
         *
         * @return GetDomainQuotaResponse
         */
        public async Task<GetDomainQuotaResponse> GetDomainQuotaAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDomainQuotaWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Queries the download URL of a file. For more information about best practices, visit https://help.aliyun.com/document_detail/175889.html.
         *
         * @param request GetDownloadUrlRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDownloadUrlResponse
         */
        public GetDownloadUrlResponse GetDownloadUrlWithOptions(GetDownloadUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSec))
            {
                body["expire_sec"] = request.ExpireSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["file_name"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentType))
            {
                body["response_content_type"] = request.ResponseContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDownloadUrl",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_download_url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDownloadUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the download URL of a file. For more information about best practices, visit https://help.aliyun.com/document_detail/175889.html.
         *
         * @param request GetDownloadUrlRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDownloadUrlResponse
         */
        public async Task<GetDownloadUrlResponse> GetDownloadUrlWithOptionsAsync(GetDownloadUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSec))
            {
                body["expire_sec"] = request.ExpireSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["file_name"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentType))
            {
                body["response_content_type"] = request.ResponseContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDownloadUrl",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_download_url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDownloadUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the download URL of a file. For more information about best practices, visit https://help.aliyun.com/document_detail/175889.html.
         *
         * @param request GetDownloadUrlRequest
         * @return GetDownloadUrlResponse
         */
        public GetDownloadUrlResponse GetDownloadUrl(GetDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDownloadUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the download URL of a file. For more information about best practices, visit https://help.aliyun.com/document_detail/175889.html.
         *
         * @param request GetDownloadUrlRequest
         * @return GetDownloadUrlResponse
         */
        public async Task<GetDownloadUrlResponse> GetDownloadUrlAsync(GetDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDownloadUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a drive.
         *
         * @param request GetDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDriveResponse
         */
        public GetDriveResponse GetDriveWithOptions(GetDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDriveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a drive.
         *
         * @param request GetDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDriveResponse
         */
        public async Task<GetDriveResponse> GetDriveWithOptionsAsync(GetDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDriveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a drive.
         *
         * @param request GetDriveRequest
         * @return GetDriveResponse
         */
        public GetDriveResponse GetDrive(GetDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDriveWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a drive.
         *
         * @param request GetDriveRequest
         * @return GetDriveResponse
         */
        public async Task<GetDriveResponse> GetDriveAsync(GetDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDriveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a file.
         *
         * @param request GetFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileResponse
         */
        public GetFileResponse GetFileWithOptions(GetFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbnailProcesses))
            {
                body["thumbnail_processes"] = request.ThumbnailProcesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a file.
         *
         * @param request GetFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileResponse
         */
        public async Task<GetFileResponse> GetFileWithOptionsAsync(GetFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbnailProcesses))
            {
                body["thumbnail_processes"] = request.ThumbnailProcesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a file.
         *
         * @param request GetFileRequest
         * @return GetFileResponse
         */
        public GetFileResponse GetFile(GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a file.
         *
         * @param request GetFileRequest
         * @return GetFileResponse
         */
        public async Task<GetFileResponse> GetFileAsync(GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a group.
         *
         * @param request GetGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupResponse
         */
        public GetGroupResponse GetGroupWithOptions(GetGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a group.
         *
         * @param request GetGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupResponse
         */
        public async Task<GetGroupResponse> GetGroupWithOptionsAsync(GetGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a group.
         *
         * @param request GetGroupRequest
         * @return GetGroupResponse
         */
        public GetGroupResponse GetGroup(GetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a group.
         *
         * @param request GetGroupRequest
         * @return GetGroupResponse
         */
        public async Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the mapping between an entity and a benefit package. You can call this operation to query the benefit package that is associated with a user.
         *
         * @param request GetIdentityToBenefitPkgMappingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIdentityToBenefitPkgMappingResponse
         */
        public GetIdentityToBenefitPkgMappingResponse GetIdentityToBenefitPkgMappingWithOptions(GetIdentityToBenefitPkgMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPkgId))
            {
                body["benefit_pkg_id"] = request.BenefitPkgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                body["identity_id"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["identity_type"] = request.IdentityType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityToBenefitPkgMapping",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/benefit/identity_to_benefit_pkg_mapping/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdentityToBenefitPkgMappingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the mapping between an entity and a benefit package. You can call this operation to query the benefit package that is associated with a user.
         *
         * @param request GetIdentityToBenefitPkgMappingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIdentityToBenefitPkgMappingResponse
         */
        public async Task<GetIdentityToBenefitPkgMappingResponse> GetIdentityToBenefitPkgMappingWithOptionsAsync(GetIdentityToBenefitPkgMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPkgId))
            {
                body["benefit_pkg_id"] = request.BenefitPkgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                body["identity_id"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["identity_type"] = request.IdentityType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityToBenefitPkgMapping",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/benefit/identity_to_benefit_pkg_mapping/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdentityToBenefitPkgMappingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the mapping between an entity and a benefit package. You can call this operation to query the benefit package that is associated with a user.
         *
         * @param request GetIdentityToBenefitPkgMappingRequest
         * @return GetIdentityToBenefitPkgMappingResponse
         */
        public GetIdentityToBenefitPkgMappingResponse GetIdentityToBenefitPkgMapping(GetIdentityToBenefitPkgMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIdentityToBenefitPkgMappingWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the mapping between an entity and a benefit package. You can call this operation to query the benefit package that is associated with a user.
         *
         * @param request GetIdentityToBenefitPkgMappingRequest
         * @return GetIdentityToBenefitPkgMappingResponse
         */
        public async Task<GetIdentityToBenefitPkgMappingResponse> GetIdentityToBenefitPkgMappingAsync(GetIdentityToBenefitPkgMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIdentityToBenefitPkgMappingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户认证方式详情
         *
         * @param request GetLinkInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLinkInfoResponse
         */
        public GetLinkInfoResponse GetLinkInfoWithOptions(GetLinkInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLinkInfo",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/account/get_link_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLinkInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户认证方式详情
         *
         * @param request GetLinkInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLinkInfoResponse
         */
        public async Task<GetLinkInfoResponse> GetLinkInfoWithOptionsAsync(GetLinkInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLinkInfo",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/account/get_link_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLinkInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户认证方式详情
         *
         * @param request GetLinkInfoRequest
         * @return GetLinkInfoResponse
         */
        public GetLinkInfoResponse GetLinkInfo(GetLinkInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLinkInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户认证方式详情
         *
         * @param request GetLinkInfoRequest
         * @return GetLinkInfoResponse
         */
        public async Task<GetLinkInfoResponse> GetLinkInfoAsync(GetLinkInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLinkInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a user based on the user ID.
         *
         * @param request GetLinkInfoByUserIdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLinkInfoByUserIdResponse
         */
        public GetLinkInfoByUserIdResponse GetLinkInfoByUserIdWithOptions(GetLinkInfoByUserIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLinkInfoByUserId",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/account/get_link_info_by_user_id",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLinkInfoByUserIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a user based on the user ID.
         *
         * @param request GetLinkInfoByUserIdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLinkInfoByUserIdResponse
         */
        public async Task<GetLinkInfoByUserIdResponse> GetLinkInfoByUserIdWithOptionsAsync(GetLinkInfoByUserIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLinkInfoByUserId",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/account/get_link_info_by_user_id",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLinkInfoByUserIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a user based on the user ID.
         *
         * @param request GetLinkInfoByUserIdRequest
         * @return GetLinkInfoByUserIdResponse
         */
        public GetLinkInfoByUserIdResponse GetLinkInfoByUserId(GetLinkInfoByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLinkInfoByUserIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a user based on the user ID.
         *
         * @param request GetLinkInfoByUserIdRequest
         * @return GetLinkInfoByUserIdResponse
         */
        public async Task<GetLinkInfoByUserIdResponse> GetLinkInfoByUserIdAsync(GetLinkInfoByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLinkInfoByUserIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a version.
         *
         * @param request GetRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRevisionResponse
         */
        public GetRevisionResponse GetRevisionWithOptions(GetRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revision_id"] = request.RevisionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRevisionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a version.
         *
         * @param request GetRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRevisionResponse
         */
        public async Task<GetRevisionResponse> GetRevisionWithOptionsAsync(GetRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revision_id"] = request.RevisionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRevisionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a version.
         *
         * @param request GetRevisionRequest
         * @return GetRevisionResponse
         */
        public GetRevisionResponse GetRevision(GetRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRevisionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a version.
         *
         * @param request GetRevisionRequest
         * @return GetRevisionResponse
         */
        public async Task<GetRevisionResponse> GetRevisionAsync(GetRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRevisionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the share URL of a file.
         *
         * @param request GetShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShareLinkResponse
         */
        public GetShareLinkResponse GetShareLinkWithOptions(GetShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareLinkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the share URL of a file.
         *
         * @param request GetShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShareLinkResponse
         */
        public async Task<GetShareLinkResponse> GetShareLinkWithOptionsAsync(GetShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the share URL of a file.
         *
         * @param request GetShareLinkRequest
         * @return GetShareLinkResponse
         */
        public GetShareLinkResponse GetShareLink(GetShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetShareLinkWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the share URL of a file.
         *
         * @param request GetShareLinkRequest
         * @return GetShareLinkResponse
         */
        public async Task<GetShareLinkResponse> GetShareLinkAsync(GetShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetShareLinkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a share link anonymously.
         *
         * @param request GetShareLinkByAnonymousRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShareLinkByAnonymousResponse
         */
        public GetShareLinkByAnonymousResponse GetShareLinkByAnonymousWithOptions(GetShareLinkByAnonymousRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareLinkByAnonymous",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/get_by_anonymous",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareLinkByAnonymousResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a share link anonymously.
         *
         * @param request GetShareLinkByAnonymousRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShareLinkByAnonymousResponse
         */
        public async Task<GetShareLinkByAnonymousResponse> GetShareLinkByAnonymousWithOptionsAsync(GetShareLinkByAnonymousRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareLinkByAnonymous",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/get_by_anonymous",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareLinkByAnonymousResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a share link anonymously.
         *
         * @param request GetShareLinkByAnonymousRequest
         * @return GetShareLinkByAnonymousResponse
         */
        public GetShareLinkByAnonymousResponse GetShareLinkByAnonymous(GetShareLinkByAnonymousRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetShareLinkByAnonymousWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a share link anonymously.
         *
         * @param request GetShareLinkByAnonymousRequest
         * @return GetShareLinkByAnonymousResponse
         */
        public async Task<GetShareLinkByAnonymousResponse> GetShareLinkByAnonymousAsync(GetShareLinkByAnonymousRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetShareLinkByAnonymousWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a share token anonymously.
         *
         * @description To access a file by using a share link, you must first obtain a share token, even if the value of share_pwd of this share is an empty string, which specifies that the share is not private.
         *
         * @param request GetShareLinkTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShareLinkTokenResponse
         */
        public GetShareLinkTokenResponse GetShareLinkTokenWithOptions(GetShareLinkTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSec))
            {
                body["expire_sec"] = request.ExpireSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharePwd))
            {
                body["share_pwd"] = request.SharePwd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareLinkToken",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/get_share_token",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareLinkTokenResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries a share token anonymously.
         *
         * @description To access a file by using a share link, you must first obtain a share token, even if the value of share_pwd of this share is an empty string, which specifies that the share is not private.
         *
         * @param request GetShareLinkTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetShareLinkTokenResponse
         */
        public async Task<GetShareLinkTokenResponse> GetShareLinkTokenWithOptionsAsync(GetShareLinkTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSec))
            {
                body["expire_sec"] = request.ExpireSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharePwd))
            {
                body["share_pwd"] = request.SharePwd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareLinkToken",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/get_share_token",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareLinkTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a share token anonymously.
         *
         * @description To access a file by using a share link, you must first obtain a share token, even if the value of share_pwd of this share is an empty string, which specifies that the share is not private.
         *
         * @param request GetShareLinkTokenRequest
         * @return GetShareLinkTokenResponse
         */
        public GetShareLinkTokenResponse GetShareLinkToken(GetShareLinkTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetShareLinkTokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a share token anonymously.
         *
         * @description To access a file by using a share link, you must first obtain a share token, even if the value of share_pwd of this share is an empty string, which specifies that the share is not private.
         *
         * @param request GetShareLinkTokenRequest
         * @return GetShareLinkTokenResponse
         */
        public async Task<GetShareLinkTokenResponse> GetShareLinkTokenAsync(GetShareLinkTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetShareLinkTokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取故事详情
         *
         * @param request GetStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStoryResponse
         */
        public GetStoryResponse GetStoryWithOptions(GetStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverImageThumbnailProcess))
            {
                body["cover_image_thumbnail_process"] = request.CoverImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverVideoThumbnailProcess))
            {
                body["cover_video_thumbnail_process"] = request.CoverVideoThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlProcess))
            {
                body["image_url_process"] = request.ImageUrlProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                body["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/get_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取故事详情
         *
         * @param request GetStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStoryResponse
         */
        public async Task<GetStoryResponse> GetStoryWithOptionsAsync(GetStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverImageThumbnailProcess))
            {
                body["cover_image_thumbnail_process"] = request.CoverImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverVideoThumbnailProcess))
            {
                body["cover_video_thumbnail_process"] = request.CoverVideoThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlProcess))
            {
                body["image_url_process"] = request.ImageUrlProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                body["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/get_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取故事详情
         *
         * @param request GetStoryRequest
         * @return GetStoryResponse
         */
        public GetStoryResponse GetStory(GetStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetStoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取故事详情
         *
         * @param request GetStoryRequest
         * @return GetStoryResponse
         */
        public async Task<GetStoryResponse> GetStoryAsync(GetStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetStoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the execution status of a value-added asynchronous task. You can call this operation to query the execution status of an asynchronous task that is created by calling the CreateSimilarImageClusterTask operation.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/425220.html) of Drive and Photo Service**.
         * To call this operation, make sure that the value-added image processing feature is enabled.
         * Before you call this operation, a value-added asynchronous task must be created. For example, you can call the CreateSimilarImageClusterTask operation to create an asynchronous task. Then, you can call this operation to query the execution status of the asynchronous task based on the task ID.
         *
         * @param request GetTaskStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskStatusResponse
         */
        public GetTaskStatusResponse GetTaskStatusWithOptions(GetTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/get_task_status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the execution status of a value-added asynchronous task. You can call this operation to query the execution status of an asynchronous task that is created by calling the CreateSimilarImageClusterTask operation.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/425220.html) of Drive and Photo Service**.
         * To call this operation, make sure that the value-added image processing feature is enabled.
         * Before you call this operation, a value-added asynchronous task must be created. For example, you can call the CreateSimilarImageClusterTask operation to create an asynchronous task. Then, you can call this operation to query the execution status of the asynchronous task based on the task ID.
         *
         * @param request GetTaskStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskStatusResponse
         */
        public async Task<GetTaskStatusResponse> GetTaskStatusWithOptionsAsync(GetTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/get_task_status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the execution status of a value-added asynchronous task. You can call this operation to query the execution status of an asynchronous task that is created by calling the CreateSimilarImageClusterTask operation.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/425220.html) of Drive and Photo Service**.
         * To call this operation, make sure that the value-added image processing feature is enabled.
         * Before you call this operation, a value-added asynchronous task must be created. For example, you can call the CreateSimilarImageClusterTask operation to create an asynchronous task. Then, you can call this operation to query the execution status of the asynchronous task based on the task ID.
         *
         * @param request GetTaskStatusRequest
         * @return GetTaskStatusResponse
         */
        public GetTaskStatusResponse GetTaskStatus(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the execution status of a value-added asynchronous task. You can call this operation to query the execution status of an asynchronous task that is created by calling the CreateSimilarImageClusterTask operation.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/425220.html) of Drive and Photo Service**.
         * To call this operation, make sure that the value-added image processing feature is enabled.
         * Before you call this operation, a value-added asynchronous task must be created. For example, you can call the CreateSimilarImageClusterTask operation to create an asynchronous task. Then, you can call this operation to query the execution status of the asynchronous task based on the task ID.
         *
         * @param request GetTaskStatusRequest
         * @return GetTaskStatusResponse
         */
        public async Task<GetTaskStatusResponse> GetTaskStatusAsync(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the upload URL of a file.
         *
         * @param request GetUploadUrlRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadUrlResponse
         */
        public GetUploadUrlResponse GetUploadUrlWithOptions(GetUploadUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartInfoList))
            {
                body["part_info_list"] = request.PartInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                body["upload_id"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadUrl",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_upload_url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the upload URL of a file.
         *
         * @param request GetUploadUrlRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadUrlResponse
         */
        public async Task<GetUploadUrlResponse> GetUploadUrlWithOptionsAsync(GetUploadUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartInfoList))
            {
                body["part_info_list"] = request.PartInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                body["upload_id"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadUrl",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_upload_url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the upload URL of a file.
         *
         * @param request GetUploadUrlRequest
         * @return GetUploadUrlResponse
         */
        public GetUploadUrlResponse GetUploadUrl(GetUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUploadUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the upload URL of a file.
         *
         * @param request GetUploadUrlRequest
         * @return GetUploadUrlResponse
         */
        public async Task<GetUploadUrlResponse> GetUploadUrlAsync(GetUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUploadUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a user.
         *
         * @param request GetUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public GetUserResponse GetUserWithOptions(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a user.
         *
         * @param request GetUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a user.
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a user.
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about video playback.
         *
         * @description For more information about best practices, see [Preview videos online](https://help.aliyun.com/document_detail/427477.html).
         *
         * @param request GetVideoPreviewPlayInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoPreviewPlayInfoResponse
         */
        public GetVideoPreviewPlayInfoResponse GetVideoPreviewPlayInfoWithOptions(GetVideoPreviewPlayInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetMasterUrl))
            {
                body["get_master_url"] = request.GetMasterUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetWithoutUrl))
            {
                body["get_without_url"] = request.GetWithoutUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReTranscode))
            {
                body["re_transcode"] = request.ReTranscode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["template_id"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoPreviewPlayInfo",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_video_preview_play_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoPreviewPlayInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about video playback.
         *
         * @description For more information about best practices, see [Preview videos online](https://help.aliyun.com/document_detail/427477.html).
         *
         * @param request GetVideoPreviewPlayInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoPreviewPlayInfoResponse
         */
        public async Task<GetVideoPreviewPlayInfoResponse> GetVideoPreviewPlayInfoWithOptionsAsync(GetVideoPreviewPlayInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetMasterUrl))
            {
                body["get_master_url"] = request.GetMasterUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetWithoutUrl))
            {
                body["get_without_url"] = request.GetWithoutUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReTranscode))
            {
                body["re_transcode"] = request.ReTranscode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["template_id"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoPreviewPlayInfo",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_video_preview_play_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoPreviewPlayInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about video playback.
         *
         * @description For more information about best practices, see [Preview videos online](https://help.aliyun.com/document_detail/427477.html).
         *
         * @param request GetVideoPreviewPlayInfoRequest
         * @return GetVideoPreviewPlayInfoResponse
         */
        public GetVideoPreviewPlayInfoResponse GetVideoPreviewPlayInfo(GetVideoPreviewPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVideoPreviewPlayInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about video playback.
         *
         * @description For more information about best practices, see [Preview videos online](https://help.aliyun.com/document_detail/427477.html).
         *
         * @param request GetVideoPreviewPlayInfoRequest
         * @return GetVideoPreviewPlayInfoResponse
         */
        public async Task<GetVideoPreviewPlayInfoResponse> GetVideoPreviewPlayInfoAsync(GetVideoPreviewPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVideoPreviewPlayInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the preview metadata of a video.
         *
         * @description For more information about best practices, see [Preview videos online](https://help.aliyun.com/document_detail/427477.html).
         *
         * @param request GetVideoPreviewPlayMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoPreviewPlayMetaResponse
         */
        public GetVideoPreviewPlayMetaResponse GetVideoPreviewPlayMetaWithOptions(GetVideoPreviewPlayMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoPreviewPlayMeta",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_video_preview_play_meta",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoPreviewPlayMetaResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the preview metadata of a video.
         *
         * @description For more information about best practices, see [Preview videos online](https://help.aliyun.com/document_detail/427477.html).
         *
         * @param request GetVideoPreviewPlayMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoPreviewPlayMetaResponse
         */
        public async Task<GetVideoPreviewPlayMetaResponse> GetVideoPreviewPlayMetaWithOptionsAsync(GetVideoPreviewPlayMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoPreviewPlayMeta",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/get_video_preview_play_meta",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoPreviewPlayMetaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the preview metadata of a video.
         *
         * @description For more information about best practices, see [Preview videos online](https://help.aliyun.com/document_detail/427477.html).
         *
         * @param request GetVideoPreviewPlayMetaRequest
         * @return GetVideoPreviewPlayMetaResponse
         */
        public GetVideoPreviewPlayMetaResponse GetVideoPreviewPlayMeta(GetVideoPreviewPlayMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVideoPreviewPlayMetaWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the preview metadata of a video.
         *
         * @description For more information about best practices, see [Preview videos online](https://help.aliyun.com/document_detail/427477.html).
         *
         * @param request GetVideoPreviewPlayMetaRequest
         * @return GetVideoPreviewPlayMetaResponse
         */
        public async Task<GetVideoPreviewPlayMetaResponse> GetVideoPreviewPlayMetaAsync(GetVideoPreviewPlayMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVideoPreviewPlayMetaWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新用户组名字
         *
         * @param request GroupUpdateNameRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupUpdateNameResponse
         */
        public GroupUpdateNameResponse GroupUpdateNameWithOptions(GroupUpdateNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupUpdateName",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/update_name",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupUpdateNameResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新用户组名字
         *
         * @param request GroupUpdateNameRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupUpdateNameResponse
         */
        public async Task<GroupUpdateNameResponse> GroupUpdateNameWithOptionsAsync(GroupUpdateNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GroupUpdateName",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/update_name",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupUpdateNameResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新用户组名字
         *
         * @param request GroupUpdateNameRequest
         * @return GroupUpdateNameResponse
         */
        public GroupUpdateNameResponse GroupUpdateName(GroupUpdateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GroupUpdateNameWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新用户组名字
         *
         * @param request GroupUpdateNameRequest
         * @return GroupUpdateNameResponse
         */
        public async Task<GroupUpdateNameResponse> GroupUpdateNameAsync(GroupUpdateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GroupUpdateNameWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Imports a user.
         *
         * @param request ImportUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportUserResponse
         */
        public ImportUserResponse ImportUserWithOptions(ImportUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationDisplayName))
            {
                body["authentication_display_name"] = request.AuthenticationDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationType))
            {
                body["authentication_type"] = request.AuthenticationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateDrive))
            {
                body["auto_create_drive"] = request.AutoCreateDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveTotalSize))
            {
                body["drive_total_size"] = request.DriveTotalSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nick_name"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["parent_group_id"] = request.ParentGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Imports a user.
         *
         * @param request ImportUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportUserResponse
         */
        public async Task<ImportUserResponse> ImportUserWithOptionsAsync(ImportUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationDisplayName))
            {
                body["authentication_display_name"] = request.AuthenticationDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationType))
            {
                body["authentication_type"] = request.AuthenticationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateDrive))
            {
                body["auto_create_drive"] = request.AutoCreateDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveTotalSize))
            {
                body["drive_total_size"] = request.DriveTotalSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nick_name"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["parent_group_id"] = request.ParentGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Imports a user.
         *
         * @param request ImportUserRequest
         * @return ImportUserResponse
         */
        public ImportUserResponse ImportUser(ImportUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImportUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary Imports a user.
         *
         * @param request ImportUserRequest
         * @return ImportUserResponse
         */
        public async Task<ImportUserResponse> ImportUserAsync(ImportUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImportUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 送审文件
         *
         * @param request InvestigateFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvestigateFileResponse
         */
        public InvestigateFileResponse InvestigateFileWithOptions(InvestigateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveFileIds))
            {
                body["drive_file_ids"] = request.DriveFileIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvestigateFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/csi/investigate_file",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvestigateFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 送审文件
         *
         * @param request InvestigateFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvestigateFileResponse
         */
        public async Task<InvestigateFileResponse> InvestigateFileWithOptionsAsync(InvestigateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveFileIds))
            {
                body["drive_file_ids"] = request.DriveFileIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvestigateFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/csi/investigate_file",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvestigateFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 送审文件
         *
         * @param request InvestigateFileRequest
         * @return InvestigateFileResponse
         */
        public InvestigateFileResponse InvestigateFile(InvestigateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvestigateFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 送审文件
         *
         * @param request InvestigateFileRequest
         * @return InvestigateFileResponse
         */
        public async Task<InvestigateFileResponse> InvestigateFileAsync(InvestigateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvestigateFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Associates an account with a user.
         *
         * @param request LinkAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return LinkAccountResponse
         */
        public LinkAccountResponse LinkAccountWithOptions(LinkAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LinkAccount",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/account/link",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LinkAccountResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Associates an account with a user.
         *
         * @param request LinkAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return LinkAccountResponse
         */
        public async Task<LinkAccountResponse> LinkAccountWithOptionsAsync(LinkAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LinkAccount",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/account/link",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LinkAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Associates an account with a user.
         *
         * @param request LinkAccountRequest
         * @return LinkAccountResponse
         */
        public LinkAccountResponse LinkAccount(LinkAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LinkAccountWithOptions(request, headers, runtime);
        }

        /**
         * @summary Associates an account with a user.
         *
         * @param request LinkAccountRequest
         * @return LinkAccountResponse
         */
        public async Task<LinkAccountResponse> LinkAccountAsync(LinkAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LinkAccountWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries location-based groups.
         *
         * @param request ListAddressGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAddressGroupsResponse
         */
        public ListAddressGroupsResponse ListAddressGroupsWithOptions(ListAddressGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                body["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddressGroups",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/list_address_groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddressGroupsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries location-based groups.
         *
         * @param request ListAddressGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAddressGroupsResponse
         */
        public async Task<ListAddressGroupsResponse> ListAddressGroupsWithOptionsAsync(ListAddressGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                body["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddressGroups",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/list_address_groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddressGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries location-based groups.
         *
         * @param request ListAddressGroupsRequest
         * @return ListAddressGroupsResponse
         */
        public ListAddressGroupsResponse ListAddressGroups(ListAddressGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAddressGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries location-based groups.
         *
         * @param request ListAddressGroupsRequest
         * @return ListAddressGroupsResponse
         */
        public async Task<ListAddressGroupsResponse> ListAddressGroupsAsync(ListAddressGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAddressGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of assigned roles. For example, you can query the administrators of a group by group ID.
         *
         * @param request ListAssignmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAssignmentResponse
         */
        public ListAssignmentResponse ListAssignmentWithOptions(ListAssignmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceId))
            {
                body["manage_resource_id"] = request.ManageResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceType))
            {
                body["manage_resource_type"] = request.ManageResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAssignment",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/role/list_assignment",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssignmentResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries a list of assigned roles. For example, you can query the administrators of a group by group ID.
         *
         * @param request ListAssignmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAssignmentResponse
         */
        public async Task<ListAssignmentResponse> ListAssignmentWithOptionsAsync(ListAssignmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceId))
            {
                body["manage_resource_id"] = request.ManageResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageResourceType))
            {
                body["manage_resource_type"] = request.ManageResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAssignment",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/role/list_assignment",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssignmentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of assigned roles. For example, you can query the administrators of a group by group ID.
         *
         * @param request ListAssignmentRequest
         * @return ListAssignmentResponse
         */
        public ListAssignmentResponse ListAssignment(ListAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAssignmentWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of assigned roles. For example, you can query the administrators of a group by group ID.
         *
         * @param request ListAssignmentRequest
         * @return ListAssignmentResponse
         */
        public async Task<ListAssignmentResponse> ListAssignmentAsync(ListAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAssignmentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries incremental information.
         *
         * @param request ListDeltaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeltaResponse
         */
        public ListDeltaResponse ListDeltaWithOptions(ListDeltaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRootId))
            {
                body["sync_root_id"] = request.SyncRootId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelta",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list_delta",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeltaResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries incremental information.
         *
         * @param request ListDeltaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeltaResponse
         */
        public async Task<ListDeltaResponse> ListDeltaWithOptionsAsync(ListDeltaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRootId))
            {
                body["sync_root_id"] = request.SyncRootId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelta",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list_delta",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeltaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries incremental information.
         *
         * @param request ListDeltaRequest
         * @return ListDeltaResponse
         */
        public ListDeltaResponse ListDelta(ListDeltaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDeltaWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries incremental information.
         *
         * @param request ListDeltaRequest
         * @return ListDeltaResponse
         */
        public async Task<ListDeltaResponse> ListDeltaAsync(ListDeltaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDeltaWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 列举 domain
         *
         * @param request ListDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomainsWithOptions(ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDomainId))
            {
                body["parent_domain_id"] = request.ParentDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["service_code"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列举 domain
         *
         * @param request ListDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsWithOptionsAsync(ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDomainId))
            {
                body["parent_domain_id"] = request.ParentDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["service_code"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列举 domain
         *
         * @param request ListDomainsRequest
         * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDomainsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列举 domain
         *
         * @param request ListDomainsRequest
         * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDomainsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of drives.
         *
         * @param request ListDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDriveResponse
         */
        public ListDriveResponse ListDriveWithOptions(ListDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerType))
            {
                body["owner_type"] = request.OwnerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDriveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries a list of drives.
         *
         * @param request ListDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDriveResponse
         */
        public async Task<ListDriveResponse> ListDriveWithOptionsAsync(ListDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerType))
            {
                body["owner_type"] = request.OwnerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDriveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of drives.
         *
         * @param request ListDriveRequest
         * @return ListDriveResponse
         */
        public ListDriveResponse ListDrive(ListDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDriveWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of drives.
         *
         * @param request ListDriveRequest
         * @return ListDriveResponse
         */
        public async Task<ListDriveResponse> ListDriveAsync(ListDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDriveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries face-based groups.
         *
         * @param request ListFacegroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFacegroupsResponse
         */
        public ListFacegroupsResponse ListFacegroupsWithOptions(ListFacegroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["remarks"] = request.Remarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotalCount))
            {
                body["return_total_count"] = request.ReturnTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFacegroups",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/list_facegroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFacegroupsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries face-based groups.
         *
         * @param request ListFacegroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFacegroupsResponse
         */
        public async Task<ListFacegroupsResponse> ListFacegroupsWithOptionsAsync(ListFacegroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["remarks"] = request.Remarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotalCount))
            {
                body["return_total_count"] = request.ReturnTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFacegroups",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/list_facegroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFacegroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries face-based groups.
         *
         * @param request ListFacegroupsRequest
         * @return ListFacegroupsResponse
         */
        public ListFacegroupsResponse ListFacegroups(ListFacegroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFacegroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries face-based groups.
         *
         * @param request ListFacegroupsRequest
         * @return ListFacegroupsResponse
         */
        public async Task<ListFacegroupsResponse> ListFacegroupsAsync(ListFacegroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFacegroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of files and folders.
         *
         * @param request ListFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFileResponse
         */
        public ListFileResponse ListFileWithOptions(ListFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["order_direction"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFileId))
            {
                body["parent_file_id"] = request.ParentFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbnailProcesses))
            {
                body["thumbnail_processes"] = request.ThumbnailProcesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries a list of files and folders.
         *
         * @param request ListFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFileResponse
         */
        public async Task<ListFileResponse> ListFileWithOptionsAsync(ListFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["order_direction"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFileId))
            {
                body["parent_file_id"] = request.ParentFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbnailProcesses))
            {
                body["thumbnail_processes"] = request.ThumbnailProcesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of files and folders.
         *
         * @param request ListFileRequest
         * @return ListFileResponse
         */
        public ListFileResponse ListFile(ListFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of files and folders.
         *
         * @param request ListFileRequest
         * @return ListFileResponse
         */
        public async Task<ListFileResponse> ListFileAsync(ListFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries groups.
         *
         * @param request ListGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupResponse
         */
        public ListGroupResponse ListGroupWithOptions(ListGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries groups.
         *
         * @param request ListGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupResponse
         */
        public async Task<ListGroupResponse> ListGroupWithOptionsAsync(ListGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries groups.
         *
         * @param request ListGroupRequest
         * @return ListGroupResponse
         */
        public ListGroupResponse ListGroup(ListGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries groups.
         *
         * @param request ListGroupRequest
         * @return ListGroupResponse
         */
        public async Task<ListGroupResponse> ListGroupAsync(ListGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the members of a group.
         *
         * @param request ListGroupMemberRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupMemberResponse
         */
        public ListGroupMemberResponse ListGroupMemberWithOptions(ListGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["member_type"] = request.MemberType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupMember",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/list_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the members of a group.
         *
         * @param request ListGroupMemberRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupMemberResponse
         */
        public async Task<ListGroupMemberResponse> ListGroupMemberWithOptionsAsync(ListGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["member_type"] = request.MemberType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupMember",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/list_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the members of a group.
         *
         * @param request ListGroupMemberRequest
         * @return ListGroupMemberResponse
         */
        public ListGroupMemberResponse ListGroupMember(ListGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGroupMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the members of a group.
         *
         * @param request ListGroupMemberRequest
         * @return ListGroupMemberResponse
         */
        public async Task<ListGroupMemberResponse> ListGroupMemberAsync(ListGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 列举用户或团队已分配的角色列表
         *
         * @param request ListIdentityRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIdentityRoleResponse
         */
        public ListIdentityRoleResponse ListIdentityRoleWithOptions(ListIdentityRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentityRole",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/role/list_identity_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentityRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列举用户或团队已分配的角色列表
         *
         * @param request ListIdentityRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIdentityRoleResponse
         */
        public async Task<ListIdentityRoleResponse> ListIdentityRoleWithOptionsAsync(ListIdentityRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentityRole",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/role/list_identity_role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentityRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列举用户或团队已分配的角色列表
         *
         * @param request ListIdentityRoleRequest
         * @return ListIdentityRoleResponse
         */
        public ListIdentityRoleResponse ListIdentityRole(ListIdentityRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIdentityRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列举用户或团队已分配的角色列表
         *
         * @param request ListIdentityRoleRequest
         * @return ListIdentityRoleResponse
         */
        public async Task<ListIdentityRoleResponse> ListIdentityRoleAsync(ListIdentityRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIdentityRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the mappings between entities and benefit packages. You can call this operation to query the benefit packages that are associated with a user.
         *
         * @param request ListIdentityToBenefitPkgMappingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIdentityToBenefitPkgMappingResponse
         */
        public ListIdentityToBenefitPkgMappingResponse ListIdentityToBenefitPkgMappingWithOptions(ListIdentityToBenefitPkgMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                body["identity_id"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["identity_type"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeExpired))
            {
                body["include_expired"] = request.IncludeExpired;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentityToBenefitPkgMapping",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/benefit/identity_to_benefit_pkg_mapping/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentityToBenefitPkgMappingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the mappings between entities and benefit packages. You can call this operation to query the benefit packages that are associated with a user.
         *
         * @param request ListIdentityToBenefitPkgMappingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIdentityToBenefitPkgMappingResponse
         */
        public async Task<ListIdentityToBenefitPkgMappingResponse> ListIdentityToBenefitPkgMappingWithOptionsAsync(ListIdentityToBenefitPkgMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                body["identity_id"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["identity_type"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeExpired))
            {
                body["include_expired"] = request.IncludeExpired;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentityToBenefitPkgMapping",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/benefit/identity_to_benefit_pkg_mapping/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentityToBenefitPkgMappingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the mappings between entities and benefit packages. You can call this operation to query the benefit packages that are associated with a user.
         *
         * @param request ListIdentityToBenefitPkgMappingRequest
         * @return ListIdentityToBenefitPkgMappingResponse
         */
        public ListIdentityToBenefitPkgMappingResponse ListIdentityToBenefitPkgMapping(ListIdentityToBenefitPkgMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIdentityToBenefitPkgMappingWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the mappings between entities and benefit packages. You can call this operation to query the benefit packages that are associated with a user.
         *
         * @param request ListIdentityToBenefitPkgMappingRequest
         * @return ListIdentityToBenefitPkgMappingResponse
         */
        public async Task<ListIdentityToBenefitPkgMappingResponse> ListIdentityToBenefitPkgMappingAsync(ListIdentityToBenefitPkgMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIdentityToBenefitPkgMappingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the drives of the current user.
         *
         * @param request ListMyDrivesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMyDrivesResponse
         */
        public ListMyDrivesResponse ListMyDrivesWithOptions(ListMyDrivesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMyDrives",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/list_my_drives",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMyDrivesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the drives of the current user.
         *
         * @param request ListMyDrivesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMyDrivesResponse
         */
        public async Task<ListMyDrivesResponse> ListMyDrivesWithOptionsAsync(ListMyDrivesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMyDrives",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/list_my_drives",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMyDrivesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the drives of the current user.
         *
         * @param request ListMyDrivesRequest
         * @return ListMyDrivesResponse
         */
        public ListMyDrivesResponse ListMyDrives(ListMyDrivesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMyDrivesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the drives of the current user.
         *
         * @param request ListMyDrivesRequest
         * @return ListMyDrivesResponse
         */
        public async Task<ListMyDrivesResponse> ListMyDrivesAsync(ListMyDrivesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMyDrivesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the team drives that can be accessed by the authorized users.
         *
         * @param request ListMyGroupDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMyGroupDriveResponse
         */
        public ListMyGroupDriveResponse ListMyGroupDriveWithOptions(ListMyGroupDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMyGroupDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/list_my_group_drive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMyGroupDriveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the team drives that can be accessed by the authorized users.
         *
         * @param request ListMyGroupDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMyGroupDriveResponse
         */
        public async Task<ListMyGroupDriveResponse> ListMyGroupDriveWithOptionsAsync(ListMyGroupDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMyGroupDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/list_my_group_drive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMyGroupDriveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the team drives that can be accessed by the authorized users.
         *
         * @param request ListMyGroupDriveRequest
         * @return ListMyGroupDriveResponse
         */
        public ListMyGroupDriveResponse ListMyGroupDrive(ListMyGroupDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMyGroupDriveWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the team drives that can be accessed by the authorized users.
         *
         * @param request ListMyGroupDriveRequest
         * @return ListMyGroupDriveResponse
         */
        public async Task<ListMyGroupDriveResponse> ListMyGroupDriveAsync(ListMyGroupDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMyGroupDriveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of files that are shared with a user. You can call this operation to query a list of files in a personal drive on which a user is granted permissions.
         *
         * @param request ListReceivedFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListReceivedFileResponse
         */
        public ListReceivedFileResponse ListReceivedFileWithOptions(ListReceivedFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReceivedFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list_received_file",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReceivedFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries a list of files that are shared with a user. You can call this operation to query a list of files in a personal drive on which a user is granted permissions.
         *
         * @param request ListReceivedFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListReceivedFileResponse
         */
        public async Task<ListReceivedFileResponse> ListReceivedFileWithOptionsAsync(ListReceivedFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReceivedFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list_received_file",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReceivedFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of files that are shared with a user. You can call this operation to query a list of files in a personal drive on which a user is granted permissions.
         *
         * @param request ListReceivedFileRequest
         * @return ListReceivedFileResponse
         */
        public ListReceivedFileResponse ListReceivedFile(ListReceivedFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListReceivedFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of files that are shared with a user. You can call this operation to query a list of files in a personal drive on which a user is granted permissions.
         *
         * @param request ListReceivedFileRequest
         * @return ListReceivedFileResponse
         */
        public async Task<ListReceivedFileResponse> ListReceivedFileAsync(ListReceivedFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListReceivedFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about files and folders in the recycle bin.
         *
         * @param request ListRecyclebinRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecyclebinResponse
         */
        public ListRecyclebinResponse ListRecyclebinWithOptions(ListRecyclebinRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecyclebin",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/recyclebin/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecyclebinResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the information about files and folders in the recycle bin.
         *
         * @param request ListRecyclebinRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecyclebinResponse
         */
        public async Task<ListRecyclebinResponse> ListRecyclebinWithOptionsAsync(ListRecyclebinRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecyclebin",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/recyclebin/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecyclebinResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about files and folders in the recycle bin.
         *
         * @param request ListRecyclebinRequest
         * @return ListRecyclebinResponse
         */
        public ListRecyclebinResponse ListRecyclebin(ListRecyclebinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRecyclebinWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about files and folders in the recycle bin.
         *
         * @param request ListRecyclebinRequest
         * @return ListRecyclebinResponse
         */
        public async Task<ListRecyclebinResponse> ListRecyclebinAsync(ListRecyclebinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRecyclebinWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the versions of a file.
         *
         * @param request ListRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRevisionResponse
         */
        public ListRevisionResponse ListRevisionWithOptions(ListRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRevisionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the versions of a file.
         *
         * @param request ListRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRevisionResponse
         */
        public async Task<ListRevisionResponse> ListRevisionWithOptionsAsync(ListRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRevisionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the versions of a file.
         *
         * @param request ListRevisionRequest
         * @return ListRevisionResponse
         */
        public ListRevisionResponse ListRevision(ListRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRevisionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the versions of a file.
         *
         * @param request ListRevisionRequest
         * @return ListRevisionResponse
         */
        public async Task<ListRevisionResponse> ListRevisionAsync(ListRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRevisionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries shares.
         *
         * @description This operation is discontinued. To query shares, you can call the SearchShareLink operation.
         *
         * @param request ListShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListShareLinkResponse
         */
        public ListShareLinkResponse ListShareLinkWithOptions(ListShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeCancelled))
            {
                body["include_cancelled"] = request.IncludeCancelled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["order_direction"] = request.OrderDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListShareLinkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries shares.
         *
         * @description This operation is discontinued. To query shares, you can call the SearchShareLink operation.
         *
         * @param request ListShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListShareLinkResponse
         */
        public async Task<ListShareLinkResponse> ListShareLinkWithOptionsAsync(ListShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeCancelled))
            {
                body["include_cancelled"] = request.IncludeCancelled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["order_direction"] = request.OrderDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListShareLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries shares.
         *
         * @description This operation is discontinued. To query shares, you can call the SearchShareLink operation.
         *
         * @param request ListShareLinkRequest
         * @return ListShareLinkResponse
         */
        public ListShareLinkResponse ListShareLink(ListShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListShareLinkWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries shares.
         *
         * @description This operation is discontinued. To query shares, you can call the SearchShareLink operation.
         *
         * @param request ListShareLinkRequest
         * @return ListShareLinkResponse
         */
        public async Task<ListShareLinkResponse> ListShareLinkAsync(ListShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListShareLinkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries tags.
         *
         * @description You can call this operation to query the tags within the specified drive at a time. The top 2,000 tags of the images are returned.
         *
         * @param request ListTagsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagsResponse
         */
        public ListTagsResponse ListTagsWithOptions(ListTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                body["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTags",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/list_tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries tags.
         *
         * @description You can call this operation to query the tags within the specified drive at a time. The top 2,000 tags of the images are returned.
         *
         * @param request ListTagsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagsResponse
         */
        public async Task<ListTagsResponse> ListTagsWithOptionsAsync(ListTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                body["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTags",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/list_tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries tags.
         *
         * @description You can call this operation to query the tags within the specified drive at a time. The top 2,000 tags of the images are returned.
         *
         * @param request ListTagsRequest
         * @return ListTagsResponse
         */
        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries tags.
         *
         * @description You can call this operation to query the tags within the specified drive at a time. The top 2,000 tags of the images are returned.
         *
         * @param request ListTagsRequest
         * @return ListTagsResponse
         */
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the file parts that are uploaded.
         *
         * @param request ListUploadedPartsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUploadedPartsResponse
         */
        public ListUploadedPartsResponse ListUploadedPartsWithOptions(ListUploadedPartsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumberMarker))
            {
                body["part_number_marker"] = request.PartNumberMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                body["upload_id"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUploadedParts",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list_uploaded_parts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUploadedPartsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries the file parts that are uploaded.
         *
         * @param request ListUploadedPartsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUploadedPartsResponse
         */
        public async Task<ListUploadedPartsResponse> ListUploadedPartsWithOptionsAsync(ListUploadedPartsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumberMarker))
            {
                body["part_number_marker"] = request.PartNumberMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                body["upload_id"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUploadedParts",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/list_uploaded_parts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUploadedPartsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the file parts that are uploaded.
         *
         * @param request ListUploadedPartsRequest
         * @return ListUploadedPartsResponse
         */
        public ListUploadedPartsResponse ListUploadedParts(ListUploadedPartsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUploadedPartsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the file parts that are uploaded.
         *
         * @param request ListUploadedPartsRequest
         * @return ListUploadedPartsResponse
         */
        public async Task<ListUploadedPartsResponse> ListUploadedPartsAsync(ListUploadedPartsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUploadedPartsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries users.
         *
         * @param request ListUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserResponse
         */
        public ListUserResponse ListUserWithOptions(ListUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries users.
         *
         * @param request ListUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserResponse
         */
        public async Task<ListUserResponse> ListUserWithOptionsAsync(ListUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries users.
         *
         * @param request ListUserRequest
         * @return ListUserResponse
         */
        public ListUserResponse ListUser(ListUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries users.
         *
         * @param request ListUserRequest
         * @return ListUserResponse
         */
        public async Task<ListUserResponse> ListUserAsync(ListUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Moves files or folders.
         *
         * @param request MoveFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveFileResponse
         */
        public MoveFileResponse MoveFileWithOptions(MoveFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNameMode))
            {
                body["check_name_mode"] = request.CheckNameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentFileId))
            {
                body["to_parent_file_id"] = request.ToParentFileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Moves files or folders.
         *
         * @param request MoveFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveFileResponse
         */
        public async Task<MoveFileResponse> MoveFileWithOptionsAsync(MoveFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNameMode))
            {
                body["check_name_mode"] = request.CheckNameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToParentFileId))
            {
                body["to_parent_file_id"] = request.ToParentFileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Moves files or folders.
         *
         * @param request MoveFileRequest
         * @return MoveFileResponse
         */
        public MoveFileResponse MoveFile(MoveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MoveFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Moves files or folders.
         *
         * @param request MoveFileRequest
         * @return MoveFileResponse
         */
        public async Task<MoveFileResponse> MoveFileAsync(MoveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MoveFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询凌霄订单价格
         *
         * @param request QueryOrderPriceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrderPriceResponse
         */
        public QueryOrderPriceResponse QueryOrderPriceWithOptions(QueryOrderPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["order_type"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Package))
            {
                body["package"] = request.Package;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["period_unit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSize))
            {
                body["total_size"] = request.TotalSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCount))
            {
                body["user_count"] = request.UserCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderPrice",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/query_order_price",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderPriceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询凌霄订单价格
         *
         * @param request QueryOrderPriceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrderPriceResponse
         */
        public async Task<QueryOrderPriceResponse> QueryOrderPriceWithOptionsAsync(QueryOrderPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["order_type"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Package))
            {
                body["package"] = request.Package;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["period_unit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSize))
            {
                body["total_size"] = request.TotalSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCount))
            {
                body["user_count"] = request.UserCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderPrice",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/query_order_price",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderPriceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询凌霄订单价格
         *
         * @param request QueryOrderPriceRequest
         * @return QueryOrderPriceResponse
         */
        public QueryOrderPriceResponse QueryOrderPrice(QueryOrderPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryOrderPriceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询凌霄订单价格
         *
         * @param request QueryOrderPriceRequest
         * @return QueryOrderPriceResponse
         */
        public async Task<QueryOrderPriceResponse> QueryOrderPriceAsync(QueryOrderPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryOrderPriceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 从人脸分组中的移除指定的文件
         *
         * @param request RemoveFaceGroupFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveFaceGroupFileResponse
         */
        public RemoveFaceGroupFileResponse RemoveFaceGroupFileWithOptions(RemoveFaceGroupFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupId))
            {
                body["face_group_id"] = request.FaceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveFaceGroupFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/albums/unassign_facegroup_item",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFaceGroupFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 从人脸分组中的移除指定的文件
         *
         * @param request RemoveFaceGroupFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveFaceGroupFileResponse
         */
        public async Task<RemoveFaceGroupFileResponse> RemoveFaceGroupFileWithOptionsAsync(RemoveFaceGroupFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupId))
            {
                body["face_group_id"] = request.FaceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveFaceGroupFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/albums/unassign_facegroup_item",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFaceGroupFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 从人脸分组中的移除指定的文件
         *
         * @param request RemoveFaceGroupFileRequest
         * @return RemoveFaceGroupFileResponse
         */
        public RemoveFaceGroupFileResponse RemoveFaceGroupFile(RemoveFaceGroupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveFaceGroupFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 从人脸分组中的移除指定的文件
         *
         * @param request RemoveFaceGroupFileRequest
         * @return RemoveFaceGroupFileResponse
         */
        public async Task<RemoveFaceGroupFileResponse> RemoveFaceGroupFileAsync(RemoveFaceGroupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveFaceGroupFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Removes a member from a group.
         *
         * @param request RemoveGroupMemberRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveGroupMemberResponse
         */
        public RemoveGroupMemberResponse RemoveGroupMemberWithOptions(RemoveGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["member_id"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["member_type"] = request.MemberType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveGroupMember",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/remove_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveGroupMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Removes a member from a group.
         *
         * @param request RemoveGroupMemberRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveGroupMemberResponse
         */
        public async Task<RemoveGroupMemberResponse> RemoveGroupMemberWithOptionsAsync(RemoveGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["member_id"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["member_type"] = request.MemberType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveGroupMember",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/remove_member",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Removes a member from a group.
         *
         * @param request RemoveGroupMemberRequest
         * @return RemoveGroupMemberResponse
         */
        public RemoveGroupMemberResponse RemoveGroupMember(RemoveGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveGroupMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary Removes a member from a group.
         *
         * @param request RemoveGroupMemberRequest
         * @return RemoveGroupMemberResponse
         */
        public async Task<RemoveGroupMemberResponse> RemoveGroupMemberAsync(RemoveGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 故事移除文件
         *
         * @param request RemoveStoryFilesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveStoryFilesResponse
         */
        public RemoveStoryFilesResponse RemoveStoryFilesWithOptions(RemoveStoryFilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveStoryFiles",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/remove_story_files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveStoryFilesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 故事移除文件
         *
         * @param request RemoveStoryFilesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveStoryFilesResponse
         */
        public async Task<RemoveStoryFilesResponse> RemoveStoryFilesWithOptionsAsync(RemoveStoryFilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveStoryFiles",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/remove_story_files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveStoryFilesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 故事移除文件
         *
         * @param request RemoveStoryFilesRequest
         * @return RemoveStoryFilesResponse
         */
        public RemoveStoryFilesResponse RemoveStoryFiles(RemoveStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveStoryFilesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 故事移除文件
         *
         * @param request RemoveStoryFilesRequest
         * @return RemoveStoryFilesResponse
         */
        public async Task<RemoveStoryFilesResponse> RemoveStoryFilesAsync(RemoveStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveStoryFilesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Restores a file or folder from the recycle bin.
         *
         * @param request RestoreFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestoreFileResponse
         */
        public RestoreFileResponse RestoreFileWithOptions(RestoreFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/recyclebin/restore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Restores a file or folder from the recycle bin.
         *
         * @param request RestoreFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestoreFileResponse
         */
        public async Task<RestoreFileResponse> RestoreFileWithOptionsAsync(RestoreFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/recyclebin/restore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Restores a file or folder from the recycle bin.
         *
         * @param request RestoreFileRequest
         * @return RestoreFileResponse
         */
        public RestoreFileResponse RestoreFile(RestoreFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestoreFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Restores a file or folder from the recycle bin.
         *
         * @param request RestoreFileRequest
         * @return RestoreFileResponse
         */
        public async Task<RestoreFileResponse> RestoreFileAsync(RestoreFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestoreFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Restores a historical version of a file. You cannot restore the latest version of a file.
         *
         * @param request RestoreRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestoreRevisionResponse
         */
        public RestoreRevisionResponse RestoreRevisionWithOptions(RestoreRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revision_id"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/restore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreRevisionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Restores a historical version of a file. You cannot restore the latest version of a file.
         *
         * @param request RestoreRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestoreRevisionResponse
         */
        public async Task<RestoreRevisionResponse> RestoreRevisionWithOptionsAsync(RestoreRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revision_id"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/restore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreRevisionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Restores a historical version of a file. You cannot restore the latest version of a file.
         *
         * @param request RestoreRevisionRequest
         * @return RestoreRevisionResponse
         */
        public RestoreRevisionResponse RestoreRevision(RestoreRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestoreRevisionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Restores a historical version of a file. You cannot restore the latest version of a file.
         *
         * @param request RestoreRevisionRequest
         * @return RestoreRevisionResponse
         */
        public async Task<RestoreRevisionResponse> RestoreRevisionAsync(RestoreRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestoreRevisionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Scans files.
         *
         * @param request ScanFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScanFileResponse
         */
        public ScanFileResponse ScanFileWithOptions(ScanFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScanFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Scans files.
         *
         * @param request ScanFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScanFileResponse
         */
        public async Task<ScanFileResponse> ScanFileWithOptionsAsync(ScanFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScanFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Scans files.
         *
         * @param request ScanFileRequest
         * @return ScanFileResponse
         */
        public ScanFileResponse ScanFile(ScanFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScanFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Scans files.
         *
         * @param request ScanFileRequest
         * @return ScanFileResponse
         */
        public async Task<ScanFileResponse> ScanFileAsync(ScanFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScanFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries location-based groups based on specific locations.
         *
         * @param request SearchAddressGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchAddressGroupsResponse
         */
        public SearchAddressGroupsResponse SearchAddressGroupsWithOptions(SearchAddressGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressLevel))
            {
                body["address_level"] = request.AddressLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressNames))
            {
                body["address_names"] = request.AddressNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrGeoPoint))
            {
                body["br_geo_point"] = request.BrGeoPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlGeoPoint))
            {
                body["tl_geo_point"] = request.TlGeoPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                body["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchAddressGroups",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/search_address_groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAddressGroupsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries location-based groups based on specific locations.
         *
         * @param request SearchAddressGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchAddressGroupsResponse
         */
        public async Task<SearchAddressGroupsResponse> SearchAddressGroupsWithOptionsAsync(SearchAddressGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressLevel))
            {
                body["address_level"] = request.AddressLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressNames))
            {
                body["address_names"] = request.AddressNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrGeoPoint))
            {
                body["br_geo_point"] = request.BrGeoPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlGeoPoint))
            {
                body["tl_geo_point"] = request.TlGeoPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoThumbnailProcess))
            {
                body["video_thumbnail_process"] = request.VideoThumbnailProcess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchAddressGroups",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/search_address_groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAddressGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries location-based groups based on specific locations.
         *
         * @param request SearchAddressGroupsRequest
         * @return SearchAddressGroupsResponse
         */
        public SearchAddressGroupsResponse SearchAddressGroups(SearchAddressGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchAddressGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries location-based groups based on specific locations.
         *
         * @param request SearchAddressGroupsRequest
         * @return SearchAddressGroupsResponse
         */
        public async Task<SearchAddressGroupsResponse> SearchAddressGroupsAsync(SearchAddressGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchAddressGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Search domain with specified attributes
         *
         * @param request SearchDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchDomainsResponse
         */
        public SearchDomainsResponse SearchDomainsWithOptions(SearchDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDomains",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDomainsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Search domain with specified attributes
         *
         * @param request SearchDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchDomainsResponse
         */
        public async Task<SearchDomainsResponse> SearchDomainsWithOptionsAsync(SearchDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDomains",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDomainsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Search domain with specified attributes
         *
         * @param request SearchDomainsRequest
         * @return SearchDomainsResponse
         */
        public SearchDomainsResponse SearchDomains(SearchDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchDomainsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Search domain with specified attributes
         *
         * @param request SearchDomainsRequest
         * @return SearchDomainsResponse
         */
        public async Task<SearchDomainsResponse> SearchDomainsAsync(SearchDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchDomainsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries drives.
         *
         * @param request SearchDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchDriveResponse
         */
        public SearchDriveResponse SearchDriveWithOptions(SearchDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveName))
            {
                body["drive_name"] = request.DriveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerType))
            {
                body["owner_type"] = request.OwnerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDriveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries drives.
         *
         * @param request SearchDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchDriveResponse
         */
        public async Task<SearchDriveResponse> SearchDriveWithOptionsAsync(SearchDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveName))
            {
                body["drive_name"] = request.DriveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerType))
            {
                body["owner_type"] = request.OwnerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDriveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries drives.
         *
         * @param request SearchDriveRequest
         * @return SearchDriveResponse
         */
        public SearchDriveResponse SearchDrive(SearchDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchDriveWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries drives.
         *
         * @param request SearchDriveRequest
         * @return SearchDriveResponse
         */
        public async Task<SearchDriveResponse> SearchDriveAsync(SearchDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchDriveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries files. For more information about best practices, visit https://help.aliyun.com/document_detail/175890.html.
         *
         * @param request SearchFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchFileResponse
         */
        public SearchFileResponse SearchFileWithOptions(SearchFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                body["recursive"] = request.Recursive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotalCount))
            {
                body["return_total_count"] = request.ReturnTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries files. For more information about best practices, visit https://help.aliyun.com/document_detail/175890.html.
         *
         * @param request SearchFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchFileResponse
         */
        public async Task<SearchFileResponse> SearchFileWithOptionsAsync(SearchFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                body["recursive"] = request.Recursive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotalCount))
            {
                body["return_total_count"] = request.ReturnTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries files. For more information about best practices, visit https://help.aliyun.com/document_detail/175890.html.
         *
         * @param request SearchFileRequest
         * @return SearchFileResponse
         */
        public SearchFileResponse SearchFile(SearchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries files. For more information about best practices, visit https://help.aliyun.com/document_detail/175890.html.
         *
         * @param request SearchFileRequest
         * @return SearchFileResponse
         */
        public async Task<SearchFileResponse> SearchFileAsync(SearchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries share URLs.
         *
         * @param request SearchShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchShareLinkResponse
         */
        public SearchShareLinkResponse SearchShareLinkWithOptions(SearchShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creators))
            {
                body["creators"] = request.Creators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["order_direction"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotalCount))
            {
                body["return_total_count"] = request.ReturnTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchShareLinkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Queries share URLs.
         *
         * @param request SearchShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchShareLinkResponse
         */
        public async Task<SearchShareLinkResponse> SearchShareLinkWithOptionsAsync(SearchShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creators))
            {
                body["creators"] = request.Creators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["order_by"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["order_direction"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotalCount))
            {
                body["return_total_count"] = request.ReturnTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchShareLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Queries share URLs.
         *
         * @param request SearchShareLinkRequest
         * @return SearchShareLinkResponse
         */
        public SearchShareLinkResponse SearchShareLink(SearchShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchShareLinkWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries share URLs.
         *
         * @param request SearchShareLinkRequest
         * @return SearchShareLinkResponse
         */
        public async Task<SearchShareLinkResponse> SearchShareLinkAsync(SearchShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchShareLinkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取相似图片聚类结果
         *
         * @param request SearchSimilarImageClustersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchSimilarImageClustersResponse
         */
        public SearchSimilarImageClustersResponse SearchSimilarImageClustersWithOptions(SearchSimilarImageClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchSimilarImageClusters",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/query_similar_image_clusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchSimilarImageClustersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取相似图片聚类结果
         *
         * @param request SearchSimilarImageClustersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchSimilarImageClustersResponse
         */
        public async Task<SearchSimilarImageClustersResponse> SearchSimilarImageClustersWithOptionsAsync(SearchSimilarImageClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageThumbnailProcess))
            {
                body["image_thumbnail_process"] = request.ImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchSimilarImageClusters",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/query_similar_image_clusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchSimilarImageClustersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取相似图片聚类结果
         *
         * @param request SearchSimilarImageClustersRequest
         * @return SearchSimilarImageClustersResponse
         */
        public SearchSimilarImageClustersResponse SearchSimilarImageClusters(SearchSimilarImageClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchSimilarImageClustersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取相似图片聚类结果
         *
         * @param request SearchSimilarImageClustersRequest
         * @return SearchSimilarImageClustersResponse
         */
        public async Task<SearchSimilarImageClustersResponse> SearchSimilarImageClustersAsync(SearchSimilarImageClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchSimilarImageClustersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询故事列表
         *
         * @param request SearchStoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchStoriesResponse
         */
        public SearchStoriesResponse SearchStoriesWithOptions(SearchStoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverImageThumbnailProcess))
            {
                body["cover_image_thumbnail_process"] = request.CoverImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverVideoThumbnailProcess))
            {
                body["cover_video_thumbnail_process"] = request.CoverVideoThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRange))
            {
                body["create_time_range"] = request.CreateTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                body["custom_labels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupIds))
            {
                body["face_group_ids"] = request.FaceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryEndTimeRange))
            {
                body["story_end_time_range"] = request.StoryEndTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["story_name"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryStartTimeRange))
            {
                body["story_start_time_range"] = request.StoryStartTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["story_type"] = request.StoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEmptyStories))
            {
                body["with_empty_stories"] = request.WithEmptyStories;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchStories",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/find_stories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchStoriesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询故事列表
         *
         * @param request SearchStoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchStoriesResponse
         */
        public async Task<SearchStoriesResponse> SearchStoriesWithOptionsAsync(SearchStoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverImageThumbnailProcess))
            {
                body["cover_image_thumbnail_process"] = request.CoverImageThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverVideoThumbnailProcess))
            {
                body["cover_video_thumbnail_process"] = request.CoverVideoThumbnailProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRange))
            {
                body["create_time_range"] = request.CreateTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                body["custom_labels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupIds))
            {
                body["face_group_ids"] = request.FaceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryEndTimeRange))
            {
                body["story_end_time_range"] = request.StoryEndTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["story_name"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryStartTimeRange))
            {
                body["story_start_time_range"] = request.StoryStartTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["story_type"] = request.StoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireSec))
            {
                body["url_expire_sec"] = request.UrlExpireSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEmptyStories))
            {
                body["with_empty_stories"] = request.WithEmptyStories;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchStories",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/find_stories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchStoriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询故事列表
         *
         * @param request SearchStoriesRequest
         * @return SearchStoriesResponse
         */
        public SearchStoriesResponse SearchStories(SearchStoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchStoriesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询故事列表
         *
         * @param request SearchStoriesRequest
         * @return SearchStoriesResponse
         */
        public async Task<SearchStoriesResponse> SearchStoriesAsync(SearchStoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchStoriesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Searches for users.
         *
         * @param request SearchUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchUserResponse
         */
        public SearchUserResponse SearchUserWithOptions(SearchUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nick_name"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickNameForFuzzy))
            {
                body["nick_name_for_fuzzy"] = request.NickNameForFuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Searches for users.
         *
         * @param request SearchUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchUserResponse
         */
        public async Task<SearchUserResponse> SearchUserWithOptionsAsync(SearchUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                body["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nick_name"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickNameForFuzzy))
            {
                body["nick_name_for_fuzzy"] = request.NickNameForFuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["user_name"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Searches for users.
         *
         * @param request SearchUserRequest
         * @return SearchUserResponse
         */
        public SearchUserResponse SearchUser(SearchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary Searches for users.
         *
         * @param request SearchUserRequest
         * @return SearchUserResponse
         */
        public async Task<SearchUserResponse> SearchUserAsync(SearchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Generates an access token based on Open Authorization (OAuth) 2.0.
         *
         * @description For more information about how to access Drive and Photo Service from a web server application by using OAuth 2.0, visit [OAuth 2.0 For Web Server Applications](https://www.alibabacloud.com/help/zh/pds/drive-and-photo-service-dev/user-guide/oauth-2-0-access-process-for-web-server-applications).
         * For more information about how to access Drive and Photo Service by using a JSON Web Token (JWT) application, visit [Access process for JWT applications](https://www.alibabacloud.com/help/zh/pds/drive-and-photo-service-dev/user-guide/access-process-for-jwt-applications).
         *
         * @param request TokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TokenResponse
         */
        public TokenResponse TokenWithOptions(TokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assertion))
            {
                body["assertion"] = request.Assertion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["client_secret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["grant_type"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUri))
            {
                body["redirect_uri"] = request.RedirectUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                body["refresh_token"] = request.RefreshToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Token",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/oauth/token",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TokenResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Generates an access token based on Open Authorization (OAuth) 2.0.
         *
         * @description For more information about how to access Drive and Photo Service from a web server application by using OAuth 2.0, visit [OAuth 2.0 For Web Server Applications](https://www.alibabacloud.com/help/zh/pds/drive-and-photo-service-dev/user-guide/oauth-2-0-access-process-for-web-server-applications).
         * For more information about how to access Drive and Photo Service by using a JSON Web Token (JWT) application, visit [Access process for JWT applications](https://www.alibabacloud.com/help/zh/pds/drive-and-photo-service-dev/user-guide/access-process-for-jwt-applications).
         *
         * @param request TokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TokenResponse
         */
        public async Task<TokenResponse> TokenWithOptionsAsync(TokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assertion))
            {
                body["assertion"] = request.Assertion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["client_secret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["grant_type"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUri))
            {
                body["redirect_uri"] = request.RedirectUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                body["refresh_token"] = request.RefreshToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Token",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/oauth/token",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Generates an access token based on Open Authorization (OAuth) 2.0.
         *
         * @description For more information about how to access Drive and Photo Service from a web server application by using OAuth 2.0, visit [OAuth 2.0 For Web Server Applications](https://www.alibabacloud.com/help/zh/pds/drive-and-photo-service-dev/user-guide/oauth-2-0-access-process-for-web-server-applications).
         * For more information about how to access Drive and Photo Service by using a JSON Web Token (JWT) application, visit [Access process for JWT applications](https://www.alibabacloud.com/help/zh/pds/drive-and-photo-service-dev/user-guide/access-process-for-jwt-applications).
         *
         * @param request TokenRequest
         * @return TokenResponse
         */
        public TokenResponse Token(TokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary Generates an access token based on Open Authorization (OAuth) 2.0.
         *
         * @description For more information about how to access Drive and Photo Service from a web server application by using OAuth 2.0, visit [OAuth 2.0 For Web Server Applications](https://www.alibabacloud.com/help/zh/pds/drive-and-photo-service-dev/user-guide/oauth-2-0-access-process-for-web-server-applications).
         * For more information about how to access Drive and Photo Service by using a JSON Web Token (JWT) application, visit [Access process for JWT applications](https://www.alibabacloud.com/help/zh/pds/drive-and-photo-service-dev/user-guide/access-process-for-jwt-applications).
         *
         * @param request TokenRequest
         * @return TokenResponse
         */
        public async Task<TokenResponse> TokenAsync(TokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Moves a file or folder to the recycle bin.
         *
         * @param request TrashFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TrashFileResponse
         */
        public TrashFileResponse TrashFileWithOptions(TrashFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrashFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/recyclebin/trash",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrashFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Moves a file or folder to the recycle bin.
         *
         * @param request TrashFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TrashFileResponse
         */
        public async Task<TrashFileResponse> TrashFileWithOptionsAsync(TrashFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrashFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/recyclebin/trash",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrashFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Moves a file or folder to the recycle bin.
         *
         * @param request TrashFileRequest
         * @return TrashFileResponse
         */
        public TrashFileResponse TrashFile(TrashFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TrashFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Moves a file or folder to the recycle bin.
         *
         * @param request TrashFileRequest
         * @return TrashFileResponse
         */
        public async Task<TrashFileResponse> TrashFileAsync(TrashFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TrashFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 取消账号绑定
         *
         * @param request UnLinkAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnLinkAccountResponse
         */
        public UnLinkAccountResponse UnLinkAccountWithOptions(UnLinkAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnLinkAccount",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/account/unlink",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnLinkAccountResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 取消账号绑定
         *
         * @param request UnLinkAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnLinkAccountResponse
         */
        public async Task<UnLinkAccountResponse> UnLinkAccountWithOptionsAsync(UnLinkAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnLinkAccount",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/account/unlink",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnLinkAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 取消账号绑定
         *
         * @param request UnLinkAccountRequest
         * @return UnLinkAccountResponse
         */
        public UnLinkAccountResponse UnLinkAccount(UnLinkAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnLinkAccountWithOptions(request, headers, runtime);
        }

        /**
         * @summary 取消账号绑定
         *
         * @param request UnLinkAccountRequest
         * @return UnLinkAccountResponse
         */
        public async Task<UnLinkAccountResponse> UnLinkAccountAsync(UnLinkAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnLinkAccountWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Update domain information.
         *
         * @param request UpdateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainResponse
         */
        public UpdateDomainResponse UpdateDomainWithOptions(UpdateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["domain_id"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domain_name"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitDriveEnable))
            {
                body["init_drive_enable"] = request.InitDriveEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitDriveSize))
            {
                body["init_drive_size"] = request.InitDriveSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishedAppAccessStrategy))
            {
                body["published_app_access_strategy"] = request.PublishedAppAccessStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeQuota))
            {
                body["size_quota"] = request.SizeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCountQuota))
            {
                body["user_count_quota"] = request.UserCountQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomain",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Update domain information.
         *
         * @param request UpdateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainResponse
         */
        public async Task<UpdateDomainResponse> UpdateDomainWithOptionsAsync(UpdateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["domain_id"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domain_name"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitDriveEnable))
            {
                body["init_drive_enable"] = request.InitDriveEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitDriveSize))
            {
                body["init_drive_size"] = request.InitDriveSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishedAppAccessStrategy))
            {
                body["published_app_access_strategy"] = request.PublishedAppAccessStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeQuota))
            {
                body["size_quota"] = request.SizeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCountQuota))
            {
                body["user_count_quota"] = request.UserCountQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomain",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/domain/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Update domain information.
         *
         * @param request UpdateDomainRequest
         * @return UpdateDomainResponse
         */
        public UpdateDomainResponse UpdateDomain(UpdateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDomainWithOptions(request, headers, runtime);
        }

        /**
         * @summary Update domain information.
         *
         * @param request UpdateDomainRequest
         * @return UpdateDomainResponse
         */
        public async Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDomainWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Modifies a drive.
         *
         * @param request UpdateDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDriveResponse
         */
        public UpdateDriveResponse UpdateDriveWithOptions(UpdateDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveName))
            {
                body["drive_name"] = request.DriveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSize))
            {
                body["total_size"] = request.TotalSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDriveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Modifies a drive.
         *
         * @param request UpdateDriveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDriveResponse
         */
        public async Task<UpdateDriveResponse> UpdateDriveWithOptionsAsync(UpdateDriveRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveName))
            {
                body["drive_name"] = request.DriveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSize))
            {
                body["total_size"] = request.TotalSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDrive",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/drive/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDriveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a drive.
         *
         * @param request UpdateDriveRequest
         * @return UpdateDriveResponse
         */
        public UpdateDriveResponse UpdateDrive(UpdateDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDriveWithOptions(request, headers, runtime);
        }

        /**
         * @summary Modifies a drive.
         *
         * @param request UpdateDriveRequest
         * @return UpdateDriveResponse
         */
        public async Task<UpdateDriveResponse> UpdateDriveAsync(UpdateDriveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDriveWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Updates a face-based group.
         *
         * @param request UpdateFacegroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFacegroupResponse
         */
        public UpdateFacegroupResponse UpdateFacegroupWithOptions(UpdateFacegroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCoverFaceId))
            {
                body["group_cover_face_id"] = request.GroupCoverFaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["group_name"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["remarks"] = request.Remarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFacegroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/update_facegroup_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFacegroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Updates a face-based group.
         *
         * @param request UpdateFacegroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFacegroupResponse
         */
        public async Task<UpdateFacegroupResponse> UpdateFacegroupWithOptionsAsync(UpdateFacegroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCoverFaceId))
            {
                body["group_cover_face_id"] = request.GroupCoverFaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["group_name"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["remarks"] = request.Remarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFacegroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/update_facegroup_info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFacegroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Updates a face-based group.
         *
         * @param request UpdateFacegroupRequest
         * @return UpdateFacegroupResponse
         */
        public UpdateFacegroupResponse UpdateFacegroup(UpdateFacegroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFacegroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary Updates a face-based group.
         *
         * @param request UpdateFacegroupRequest
         * @return UpdateFacegroupResponse
         */
        public async Task<UpdateFacegroupResponse> UpdateFacegroupAsync(UpdateFacegroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFacegroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Modifies the information about a file instead of the file data.
         *
         * @param request UpdateFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFileResponse
         */
        public UpdateFileResponse UpdateFileWithOptions(UpdateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNameMode))
            {
                body["check_name_mode"] = request.CheckNameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                body["hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalModifiedAt))
            {
                body["local_modified_at"] = request.LocalModifiedAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Starred))
            {
                body["starred"] = request.Starred;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about a file instead of the file data.
         *
         * @param request UpdateFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFileResponse
         */
        public async Task<UpdateFileResponse> UpdateFileWithOptionsAsync(UpdateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNameMode))
            {
                body["check_name_mode"] = request.CheckNameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                body["hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalModifiedAt))
            {
                body["local_modified_at"] = request.LocalModifiedAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Starred))
            {
                body["starred"] = request.Starred;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFile",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about a file instead of the file data.
         *
         * @param request UpdateFileRequest
         * @return UpdateFileResponse
         */
        public UpdateFileResponse UpdateFile(UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary Modifies the information about a file instead of the file data.
         *
         * @param request UpdateFileRequest
         * @return UpdateFileResponse
         */
        public async Task<UpdateFileResponse> UpdateFileAsync(UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Modifies the information about a group.
         *
         * @param request UpdateGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupResponse
         */
        public UpdateGroupResponse UpdateGroupWithOptions(UpdateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["group_name"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about a group.
         *
         * @param request UpdateGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupResponse
         */
        public async Task<UpdateGroupResponse> UpdateGroupWithOptionsAsync(UpdateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["group_name"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/group/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about a group.
         *
         * @param request UpdateGroupRequest
         * @return UpdateGroupResponse
         */
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary Modifies the information about a group.
         *
         * @param request UpdateGroupRequest
         * @return UpdateGroupResponse
         */
        public async Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Updates the mapping between an entity and a benefit package. You can call this operation to associate a benefit package with a user.
         *
         * @param request UpdateIdentityToBenefitPkgMappingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIdentityToBenefitPkgMappingResponse
         */
        public UpdateIdentityToBenefitPkgMappingResponse UpdateIdentityToBenefitPkgMappingWithOptions(UpdateIdentityToBenefitPkgMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPkgId))
            {
                body["benefit_pkg_id"] = request.BenefitPkgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expire_time"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                body["identity_id"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["identity_type"] = request.IdentityType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdentityToBenefitPkgMapping",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/benefit/identity_to_benefit_pkg_mapping/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIdentityToBenefitPkgMappingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Updates the mapping between an entity and a benefit package. You can call this operation to associate a benefit package with a user.
         *
         * @param request UpdateIdentityToBenefitPkgMappingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIdentityToBenefitPkgMappingResponse
         */
        public async Task<UpdateIdentityToBenefitPkgMappingResponse> UpdateIdentityToBenefitPkgMappingWithOptionsAsync(UpdateIdentityToBenefitPkgMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPkgId))
            {
                body["benefit_pkg_id"] = request.BenefitPkgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expire_time"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                body["identity_id"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["identity_type"] = request.IdentityType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdentityToBenefitPkgMapping",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/benefit/identity_to_benefit_pkg_mapping/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIdentityToBenefitPkgMappingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the mapping between an entity and a benefit package. You can call this operation to associate a benefit package with a user.
         *
         * @param request UpdateIdentityToBenefitPkgMappingRequest
         * @return UpdateIdentityToBenefitPkgMappingResponse
         */
        public UpdateIdentityToBenefitPkgMappingResponse UpdateIdentityToBenefitPkgMapping(UpdateIdentityToBenefitPkgMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIdentityToBenefitPkgMappingWithOptions(request, headers, runtime);
        }

        /**
         * @summary Updates the mapping between an entity and a benefit package. You can call this operation to associate a benefit package with a user.
         *
         * @param request UpdateIdentityToBenefitPkgMappingRequest
         * @return UpdateIdentityToBenefitPkgMappingResponse
         */
        public async Task<UpdateIdentityToBenefitPkgMappingResponse> UpdateIdentityToBenefitPkgMappingAsync(UpdateIdentityToBenefitPkgMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIdentityToBenefitPkgMappingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Updates the version information. You can call this operation to permanently retain a version or modify the description of a version. You can permanently retain up to 50 versions of a file.
         *
         * @param request UpdateRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRevisionResponse
         */
        public UpdateRevisionResponse UpdateRevisionWithOptions(UpdateRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepForever))
            {
                body["keep_forever"] = request.KeepForever;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionDescription))
            {
                body["revision_description"] = request.RevisionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revision_id"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRevisionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Updates the version information. You can call this operation to permanently retain a version or modify the description of a version. You can permanently retain up to 50 versions of a file.
         *
         * @param request UpdateRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRevisionResponse
         */
        public async Task<UpdateRevisionResponse> UpdateRevisionWithOptionsAsync(UpdateRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["file_id"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepForever))
            {
                body["keep_forever"] = request.KeepForever;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionDescription))
            {
                body["revision_description"] = request.RevisionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revision_id"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRevision",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/file/revision/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRevisionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the version information. You can call this operation to permanently retain a version or modify the description of a version. You can permanently retain up to 50 versions of a file.
         *
         * @param request UpdateRevisionRequest
         * @return UpdateRevisionResponse
         */
        public UpdateRevisionResponse UpdateRevision(UpdateRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRevisionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Updates the version information. You can call this operation to permanently retain a version or modify the description of a version. You can permanently retain up to 50 versions of a file.
         *
         * @param request UpdateRevisionRequest
         * @return UpdateRevisionResponse
         */
        public async Task<UpdateRevisionResponse> UpdateRevisionAsync(UpdateRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRevisionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Modifies a share link.
         *
         * @param request UpdateShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateShareLinkResponse
         */
        public UpdateShareLinkResponse UpdateShareLinkWithOptions(UpdateShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableDownload))
            {
                body["disable_download"] = request.DisableDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisablePreview))
            {
                body["disable_preview"] = request.DisablePreview;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSave))
            {
                body["disable_save"] = request.DisableSave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadCount))
            {
                body["download_count"] = request.DownloadCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadLimit))
            {
                body["download_limit"] = request.DownloadLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                body["expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewCount))
            {
                body["preview_count"] = request.PreviewCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewLimit))
            {
                body["preview_limit"] = request.PreviewLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportCount))
            {
                body["report_count"] = request.ReportCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveCount))
            {
                body["save_count"] = request.SaveCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveLimit))
            {
                body["save_limit"] = request.SaveLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareName))
            {
                body["share_name"] = request.ShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharePwd))
            {
                body["share_pwd"] = request.SharePwd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPreviewCount))
            {
                body["video_preview_count"] = request.VideoPreviewCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateShareLinkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Modifies a share link.
         *
         * @param request UpdateShareLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateShareLinkResponse
         */
        public async Task<UpdateShareLinkResponse> UpdateShareLinkWithOptionsAsync(UpdateShareLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableDownload))
            {
                body["disable_download"] = request.DisableDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisablePreview))
            {
                body["disable_preview"] = request.DisablePreview;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSave))
            {
                body["disable_save"] = request.DisableSave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadCount))
            {
                body["download_count"] = request.DownloadCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadLimit))
            {
                body["download_limit"] = request.DownloadLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                body["expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewCount))
            {
                body["preview_count"] = request.PreviewCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewLimit))
            {
                body["preview_limit"] = request.PreviewLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportCount))
            {
                body["report_count"] = request.ReportCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveCount))
            {
                body["save_count"] = request.SaveCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveLimit))
            {
                body["save_limit"] = request.SaveLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["share_id"] = request.ShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareName))
            {
                body["share_name"] = request.ShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharePwd))
            {
                body["share_pwd"] = request.SharePwd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPreviewCount))
            {
                body["video_preview_count"] = request.VideoPreviewCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateShareLink",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/share_link/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateShareLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a share link.
         *
         * @param request UpdateShareLinkRequest
         * @return UpdateShareLinkResponse
         */
        public UpdateShareLinkResponse UpdateShareLink(UpdateShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateShareLinkWithOptions(request, headers, runtime);
        }

        /**
         * @summary Modifies a share link.
         *
         * @param request UpdateShareLinkRequest
         * @return UpdateShareLinkResponse
         */
        public async Task<UpdateShareLinkResponse> UpdateShareLinkAsync(UpdateShareLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateShareLinkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新故事
         *
         * @param request UpdateStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStoryResponse
         */
        public UpdateStoryResponse UpdateStoryWithOptions(UpdateStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cover))
            {
                body["cover"] = request.Cover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                body["custom_labels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["story_name"] = request.StoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/update_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新故事
         *
         * @param request UpdateStoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStoryResponse
         */
        public async Task<UpdateStoryResponse> UpdateStoryWithOptionsAsync(UpdateStoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cover))
            {
                body["cover"] = request.Cover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                body["custom_labels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriveId))
            {
                body["drive_id"] = request.DriveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryId))
            {
                body["story_id"] = request.StoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["story_name"] = request.StoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStory",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/image/update_story",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新故事
         *
         * @param request UpdateStoryRequest
         * @return UpdateStoryResponse
         */
        public UpdateStoryResponse UpdateStory(UpdateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateStoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新故事
         *
         * @param request UpdateStoryRequest
         * @return UpdateStoryResponse
         */
        public async Task<UpdateStoryResponse> UpdateStoryAsync(UpdateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateStoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Modifies the information about a user.
         *
         * @param request UpdateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfoList))
            {
                body["group_info_list"] = request.GroupInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nick_name"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about a user.
         *
         * @param request UpdateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfoList))
            {
                body["group_info_list"] = request.GroupInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nick_name"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2022-03-01",
                Protocol = "HTTPS",
                Pathname = "/v2/user/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about a user.
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary Modifies the information about a user.
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserWithOptionsAsync(request, headers, runtime);
        }

    }
}
