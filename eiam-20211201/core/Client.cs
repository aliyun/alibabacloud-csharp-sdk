// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eiam20211201.Models;

namespace AlibabaCloud.SDK.Eiam20211201
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eiam", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Adds an Employee Identity and Access Management (EIAM) account to multiple EIAM organizations of Identity as a Service (IDaaS). If the account already exists in the organizational unit, the system directly returns a success response.
         *
         * @param request AddUserToOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserToOrganizationalUnitsResponse
         */
        public AddUserToOrganizationalUnitsResponse AddUserToOrganizationalUnitsWithOptions(AddUserToOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "AddUserToOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToOrganizationalUnitsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds an Employee Identity and Access Management (EIAM) account to multiple EIAM organizations of Identity as a Service (IDaaS). If the account already exists in the organizational unit, the system directly returns a success response.
         *
         * @param request AddUserToOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserToOrganizationalUnitsResponse
         */
        public async Task<AddUserToOrganizationalUnitsResponse> AddUserToOrganizationalUnitsWithOptionsAsync(AddUserToOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "AddUserToOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToOrganizationalUnitsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds an Employee Identity and Access Management (EIAM) account to multiple EIAM organizations of Identity as a Service (IDaaS). If the account already exists in the organizational unit, the system directly returns a success response.
         *
         * @param request AddUserToOrganizationalUnitsRequest
         * @return AddUserToOrganizationalUnitsResponse
         */
        public AddUserToOrganizationalUnitsResponse AddUserToOrganizationalUnits(AddUserToOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserToOrganizationalUnitsWithOptions(request, runtime);
        }

        /**
         * @summary Adds an Employee Identity and Access Management (EIAM) account to multiple EIAM organizations of Identity as a Service (IDaaS). If the account already exists in the organizational unit, the system directly returns a success response.
         *
         * @param request AddUserToOrganizationalUnitsRequest
         * @return AddUserToOrganizationalUnitsResponse
         */
        public async Task<AddUserToOrganizationalUnitsResponse> AddUserToOrganizationalUnitsAsync(AddUserToOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserToOrganizationalUnitsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds Employee Identity and Access Management (EIAM) accounts to an EIAM group of Identity as a Service (IDaaS).
         *
         * @param request AddUsersToGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUsersToGroupResponse
         */
        public AddUsersToGroupResponse AddUsersToGroupWithOptions(AddUsersToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "AddUsersToGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUsersToGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds Employee Identity and Access Management (EIAM) accounts to an EIAM group of Identity as a Service (IDaaS).
         *
         * @param request AddUsersToGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUsersToGroupResponse
         */
        public async Task<AddUsersToGroupResponse> AddUsersToGroupWithOptionsAsync(AddUsersToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "AddUsersToGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUsersToGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds Employee Identity and Access Management (EIAM) accounts to an EIAM group of Identity as a Service (IDaaS).
         *
         * @param request AddUsersToGroupRequest
         * @return AddUsersToGroupResponse
         */
        public AddUsersToGroupResponse AddUsersToGroup(AddUsersToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUsersToGroupWithOptions(request, runtime);
        }

        /**
         * @summary Adds Employee Identity and Access Management (EIAM) accounts to an EIAM group of Identity as a Service (IDaaS).
         *
         * @param request AddUsersToGroupRequest
         * @return AddUsersToGroupResponse
         */
        public async Task<AddUsersToGroupResponse> AddUsersToGroupAsync(AddUsersToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUsersToGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Grants the permissions to access an application to multiple account groups at a time in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request AuthorizeApplicationToGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeApplicationToGroupsResponse
         */
        public AuthorizeApplicationToGroupsResponse AuthorizeApplicationToGroupsWithOptions(AuthorizeApplicationToGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeApplicationToGroups",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeApplicationToGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Grants the permissions to access an application to multiple account groups at a time in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request AuthorizeApplicationToGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeApplicationToGroupsResponse
         */
        public async Task<AuthorizeApplicationToGroupsResponse> AuthorizeApplicationToGroupsWithOptionsAsync(AuthorizeApplicationToGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeApplicationToGroups",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeApplicationToGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Grants the permissions to access an application to multiple account groups at a time in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request AuthorizeApplicationToGroupsRequest
         * @return AuthorizeApplicationToGroupsResponse
         */
        public AuthorizeApplicationToGroupsResponse AuthorizeApplicationToGroups(AuthorizeApplicationToGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeApplicationToGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Grants the permissions to access an application to multiple account groups at a time in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request AuthorizeApplicationToGroupsRequest
         * @return AuthorizeApplicationToGroupsResponse
         */
        public async Task<AuthorizeApplicationToGroupsResponse> AuthorizeApplicationToGroupsAsync(AuthorizeApplicationToGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeApplicationToGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Grants the access permissions on an application to multiple Employee Identity and Access Management (EIAM) organizations at a time.
         *
         * @param request AuthorizeApplicationToOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeApplicationToOrganizationalUnitsResponse
         */
        public AuthorizeApplicationToOrganizationalUnitsResponse AuthorizeApplicationToOrganizationalUnitsWithOptions(AuthorizeApplicationToOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeApplicationToOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeApplicationToOrganizationalUnitsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Grants the access permissions on an application to multiple Employee Identity and Access Management (EIAM) organizations at a time.
         *
         * @param request AuthorizeApplicationToOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeApplicationToOrganizationalUnitsResponse
         */
        public async Task<AuthorizeApplicationToOrganizationalUnitsResponse> AuthorizeApplicationToOrganizationalUnitsWithOptionsAsync(AuthorizeApplicationToOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeApplicationToOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeApplicationToOrganizationalUnitsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Grants the access permissions on an application to multiple Employee Identity and Access Management (EIAM) organizations at a time.
         *
         * @param request AuthorizeApplicationToOrganizationalUnitsRequest
         * @return AuthorizeApplicationToOrganizationalUnitsResponse
         */
        public AuthorizeApplicationToOrganizationalUnitsResponse AuthorizeApplicationToOrganizationalUnits(AuthorizeApplicationToOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeApplicationToOrganizationalUnitsWithOptions(request, runtime);
        }

        /**
         * @summary Grants the access permissions on an application to multiple Employee Identity and Access Management (EIAM) organizations at a time.
         *
         * @param request AuthorizeApplicationToOrganizationalUnitsRequest
         * @return AuthorizeApplicationToOrganizationalUnitsResponse
         */
        public async Task<AuthorizeApplicationToOrganizationalUnitsResponse> AuthorizeApplicationToOrganizationalUnitsAsync(AuthorizeApplicationToOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeApplicationToOrganizationalUnitsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Grants the access permissions on an application to multiple Employee Identity and Access Management (EIAM) accounts at a time.
         *
         * @param request AuthorizeApplicationToUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeApplicationToUsersResponse
         */
        public AuthorizeApplicationToUsersResponse AuthorizeApplicationToUsersWithOptions(AuthorizeApplicationToUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "AuthorizeApplicationToUsers",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeApplicationToUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Grants the access permissions on an application to multiple Employee Identity and Access Management (EIAM) accounts at a time.
         *
         * @param request AuthorizeApplicationToUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeApplicationToUsersResponse
         */
        public async Task<AuthorizeApplicationToUsersResponse> AuthorizeApplicationToUsersWithOptionsAsync(AuthorizeApplicationToUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "AuthorizeApplicationToUsers",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeApplicationToUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Grants the access permissions on an application to multiple Employee Identity and Access Management (EIAM) accounts at a time.
         *
         * @param request AuthorizeApplicationToUsersRequest
         * @return AuthorizeApplicationToUsersResponse
         */
        public AuthorizeApplicationToUsersResponse AuthorizeApplicationToUsers(AuthorizeApplicationToUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeApplicationToUsersWithOptions(request, runtime);
        }

        /**
         * @summary Grants the access permissions on an application to multiple Employee Identity and Access Management (EIAM) accounts at a time.
         *
         * @param request AuthorizeApplicationToUsersRequest
         * @return AuthorizeApplicationToUsersResponse
         */
        public async Task<AuthorizeApplicationToUsersResponse> AuthorizeApplicationToUsersAsync(AuthorizeApplicationToUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeApplicationToUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds an application to an Enterprise Identity Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @description IDaaS EIAM supports the following two standard single sign-on (SSO) protocols for adding applications: SAML 2.0 and OIDC. You can select an SSO protocol based on your business requirements when you add an application. You cannot change the SSO protocol that you selected after the application is added.
         *
         * @param request CreateApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationResponse
         */
        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationSourceType))
            {
                query["ApplicationSourceType"] = request.ApplicationSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationTemplateId))
            {
                query["ApplicationTemplateId"] = request.ApplicationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoUrl))
            {
                query["LogoUrl"] = request.LogoUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoType))
            {
                query["SsoType"] = request.SsoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2021-12-01",
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

        /**
         * @summary Adds an application to an Enterprise Identity Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @description IDaaS EIAM supports the following two standard single sign-on (SSO) protocols for adding applications: SAML 2.0 and OIDC. You can select an SSO protocol based on your business requirements when you add an application. You cannot change the SSO protocol that you selected after the application is added.
         *
         * @param request CreateApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationResponse
         */
        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationSourceType))
            {
                query["ApplicationSourceType"] = request.ApplicationSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationTemplateId))
            {
                query["ApplicationTemplateId"] = request.ApplicationTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoUrl))
            {
                query["LogoUrl"] = request.LogoUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoType))
            {
                query["SsoType"] = request.SsoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2021-12-01",
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

        /**
         * @summary Adds an application to an Enterprise Identity Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @description IDaaS EIAM supports the following two standard single sign-on (SSO) protocols for adding applications: SAML 2.0 and OIDC. You can select an SSO protocol based on your business requirements when you add an application. You cannot change the SSO protocol that you selected after the application is added.
         *
         * @param request CreateApplicationRequest
         * @return CreateApplicationResponse
         */
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Adds an application to an Enterprise Identity Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @description IDaaS EIAM supports the following two standard single sign-on (SSO) protocols for adding applications: SAML 2.0 and OIDC. You can select an SSO protocol based on your business requirements when you add an application. You cannot change the SSO protocol that you selected after the application is added.
         *
         * @param request CreateApplicationRequest
         * @return CreateApplicationResponse
         */
        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a client key for an Employee Identity and Access Management (EIAM) application. An EIAM application can have up to two client keys.
         *
         * @param request CreateApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationClientSecretResponse
         */
        public CreateApplicationClientSecretResponse CreateApplicationClientSecretWithOptions(CreateApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationClientSecretResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a client key for an Employee Identity and Access Management (EIAM) application. An EIAM application can have up to two client keys.
         *
         * @param request CreateApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationClientSecretResponse
         */
        public async Task<CreateApplicationClientSecretResponse> CreateApplicationClientSecretWithOptionsAsync(CreateApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationClientSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a client key for an Employee Identity and Access Management (EIAM) application. An EIAM application can have up to two client keys.
         *
         * @param request CreateApplicationClientSecretRequest
         * @return CreateApplicationClientSecretResponse
         */
        public CreateApplicationClientSecretResponse CreateApplicationClientSecret(CreateApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationClientSecretWithOptions(request, runtime);
        }

        /**
         * @summary Creates a client key for an Employee Identity and Access Management (EIAM) application. An EIAM application can have up to two client keys.
         *
         * @param request CreateApplicationClientSecretRequest
         * @return CreateApplicationClientSecretResponse
         */
        public async Task<CreateApplicationClientSecretResponse> CreateApplicationClientSecretAsync(CreateApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationClientSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建域名。
         *
         * @param request CreateDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filing))
            {
                query["Filing"] = request.Filing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建域名。
         *
         * @param request CreateDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filing))
            {
                query["Filing"] = request.Filing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建域名。
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainWithOptions(request, runtime);
        }

        /**
         * @summary 创建域名。
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建域名代理Token。
         *
         * @param request CreateDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainProxyTokenResponse
         */
        public CreateDomainProxyTokenResponse CreateDomainProxyTokenWithOptions(CreateDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainProxyTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建域名代理Token。
         *
         * @param request CreateDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainProxyTokenResponse
         */
        public async Task<CreateDomainProxyTokenResponse> CreateDomainProxyTokenWithOptionsAsync(CreateDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainProxyTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建域名代理Token。
         *
         * @param request CreateDomainProxyTokenRequest
         * @return CreateDomainProxyTokenResponse
         */
        public CreateDomainProxyTokenResponse CreateDomainProxyToken(CreateDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainProxyTokenWithOptions(request, runtime);
        }

        /**
         * @summary 创建域名代理Token。
         *
         * @param request CreateDomainProxyTokenRequest
         * @return CreateDomainProxyTokenResponse
         */
        public async Task<CreateDomainProxyTokenResponse> CreateDomainProxyTokenAsync(CreateDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainProxyTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request CreateGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupResponse
         */
        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupExternalId))
            {
                query["GroupExternalId"] = request.GroupExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Creates an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request CreateGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupResponse
         */
        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupExternalId))
            {
                query["GroupExternalId"] = request.GroupExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Creates an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request CreateGroupRequest
         * @return CreateGroupResponse
         */
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request CreateGroupRequest
         * @return CreateGroupResponse
         */
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an instance based on which all capabilities of Identity as a Service (IDaaS) Enterprise Identity and Access Management (EIAM) are provided.
         *
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an instance based on which all capabilities of Identity as a Service (IDaaS) Enterprise Identity and Access Management (EIAM) are provided.
         *
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an instance based on which all capabilities of Identity as a Service (IDaaS) Enterprise Identity and Access Management (EIAM) are provided.
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Creates an instance based on which all capabilities of Identity as a Service (IDaaS) Enterprise Identity and Access Management (EIAM) are provided.
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建一个专属网络端点。
         *
         * @param request CreateNetworkAccessEndpointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNetworkAccessEndpointResponse
         */
        public CreateNetworkAccessEndpointResponse CreateNetworkAccessEndpointWithOptions(CreateNetworkAccessEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointName))
            {
                query["NetworkAccessEndpointName"] = request.NetworkAccessEndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                query["VpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNetworkAccessEndpoint",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNetworkAccessEndpointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建一个专属网络端点。
         *
         * @param request CreateNetworkAccessEndpointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNetworkAccessEndpointResponse
         */
        public async Task<CreateNetworkAccessEndpointResponse> CreateNetworkAccessEndpointWithOptionsAsync(CreateNetworkAccessEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointName))
            {
                query["NetworkAccessEndpointName"] = request.NetworkAccessEndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                query["VpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNetworkAccessEndpoint",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNetworkAccessEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建一个专属网络端点。
         *
         * @param request CreateNetworkAccessEndpointRequest
         * @return CreateNetworkAccessEndpointResponse
         */
        public CreateNetworkAccessEndpointResponse CreateNetworkAccessEndpoint(CreateNetworkAccessEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkAccessEndpointWithOptions(request, runtime);
        }

        /**
         * @summary 创建一个专属网络端点。
         *
         * @param request CreateNetworkAccessEndpointRequest
         * @return CreateNetworkAccessEndpointResponse
         */
        public async Task<CreateNetworkAccessEndpointResponse> CreateNetworkAccessEndpointAsync(CreateNetworkAccessEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkAccessEndpointWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request CreateOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOrganizationalUnitResponse
         */
        public CreateOrganizationalUnitResponse CreateOrganizationalUnitWithOptions(CreateOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitExternalId))
            {
                query["OrganizationalUnitExternalId"] = request.OrganizationalUnitExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                query["OrganizationalUnitName"] = request.OrganizationalUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request CreateOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOrganizationalUnitResponse
         */
        public async Task<CreateOrganizationalUnitResponse> CreateOrganizationalUnitWithOptionsAsync(CreateOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitExternalId))
            {
                query["OrganizationalUnitExternalId"] = request.OrganizationalUnitExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                query["OrganizationalUnitName"] = request.OrganizationalUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request CreateOrganizationalUnitRequest
         * @return CreateOrganizationalUnitResponse
         */
        public CreateOrganizationalUnitResponse CreateOrganizationalUnit(CreateOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrganizationalUnitWithOptions(request, runtime);
        }

        /**
         * @summary Creates an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request CreateOrganizationalUnitRequest
         * @return CreateOrganizationalUnitResponse
         */
        public async Task<CreateOrganizationalUnitResponse> CreateOrganizationalUnitAsync(CreateOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrganizationalUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an account in an Identity as a Service (IDaaS) Enterprise Identity Access Management (EIAM) instance.
         *
         * @param request CreateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                query["CustomFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailVerified))
            {
                query["EmailVerified"] = request.EmailVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationConfig))
            {
                query["PasswordInitializationConfig"] = request.PasswordInitializationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberVerified))
            {
                query["PhoneNumberVerified"] = request.PhoneNumberVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                query["PhoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryOrganizationalUnitId))
            {
                query["PrimaryOrganizationalUnitId"] = request.PrimaryOrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExternalId))
            {
                query["UserExternalId"] = request.UserExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2021-12-01",
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

        /**
         * @summary Creates an account in an Identity as a Service (IDaaS) Enterprise Identity Access Management (EIAM) instance.
         *
         * @param request CreateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                query["CustomFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailVerified))
            {
                query["EmailVerified"] = request.EmailVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationConfig))
            {
                query["PasswordInitializationConfig"] = request.PasswordInitializationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberVerified))
            {
                query["PhoneNumberVerified"] = request.PhoneNumberVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                query["PhoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryOrganizationalUnitId))
            {
                query["PrimaryOrganizationalUnitId"] = request.PrimaryOrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExternalId))
            {
                query["UserExternalId"] = request.UserExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2021-12-01",
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

        /**
         * @summary Creates an account in an Identity as a Service (IDaaS) Enterprise Identity Access Management (EIAM) instance.
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        /**
         * @summary Creates an account in an Identity as a Service (IDaaS) Enterprise Identity Access Management (EIAM) instance.
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an Employee Identity and Access Management (EIAM) application.
         *
         * @description Make sure that the EIAM application that you want to delete is not used before you delete the EIAM application. After you delete the EIAM application, all configurations are deleted and cannot be restored.
         *
         * @param request DeleteApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationResponse
         */
        public DeleteApplicationResponse DeleteApplicationWithOptions(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2021-12-01",
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

        /**
         * @summary Deletes an Employee Identity and Access Management (EIAM) application.
         *
         * @description Make sure that the EIAM application that you want to delete is not used before you delete the EIAM application. After you delete the EIAM application, all configurations are deleted and cannot be restored.
         *
         * @param request DeleteApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationResponse
         */
        public async Task<DeleteApplicationResponse> DeleteApplicationWithOptionsAsync(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2021-12-01",
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

        /**
         * @summary Deletes an Employee Identity and Access Management (EIAM) application.
         *
         * @description Make sure that the EIAM application that you want to delete is not used before you delete the EIAM application. After you delete the EIAM application, all configurations are deleted and cannot be restored.
         *
         * @param request DeleteApplicationRequest
         * @return DeleteApplicationResponse
         */
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an Employee Identity and Access Management (EIAM) application.
         *
         * @description Make sure that the EIAM application that you want to delete is not used before you delete the EIAM application. After you delete the EIAM application, all configurations are deleted and cannot be restored.
         *
         * @param request DeleteApplicationRequest
         * @return DeleteApplicationResponse
         */
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a client key for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DeleteApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationClientSecretResponse
         */
        public DeleteApplicationClientSecretResponse DeleteApplicationClientSecretWithOptions(DeleteApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationClientSecretResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a client key for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DeleteApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationClientSecretResponse
         */
        public async Task<DeleteApplicationClientSecretResponse> DeleteApplicationClientSecretWithOptionsAsync(DeleteApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationClientSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a client key for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DeleteApplicationClientSecretRequest
         * @return DeleteApplicationClientSecretResponse
         */
        public DeleteApplicationClientSecretResponse DeleteApplicationClientSecret(DeleteApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationClientSecretWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a client key for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DeleteApplicationClientSecretRequest
         * @return DeleteApplicationClientSecretResponse
         */
        public async Task<DeleteApplicationClientSecretResponse> DeleteApplicationClientSecretAsync(DeleteApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationClientSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除域名。
         *
         * @param request DeleteDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除域名。
         *
         * @param request DeleteDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除域名。
         *
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainWithOptions(request, runtime);
        }

        /**
         * @summary 删除域名。
         *
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除指定域名代理Token，删除之前请保证代理Token处于禁用状态。
         *
         * @param request DeleteDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainProxyTokenResponse
         */
        public DeleteDomainProxyTokenResponse DeleteDomainProxyTokenWithOptions(DeleteDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainProxyTokenId))
            {
                query["DomainProxyTokenId"] = request.DomainProxyTokenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainProxyTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定域名代理Token，删除之前请保证代理Token处于禁用状态。
         *
         * @param request DeleteDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainProxyTokenResponse
         */
        public async Task<DeleteDomainProxyTokenResponse> DeleteDomainProxyTokenWithOptionsAsync(DeleteDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainProxyTokenId))
            {
                query["DomainProxyTokenId"] = request.DomainProxyTokenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainProxyTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定域名代理Token，删除之前请保证代理Token处于禁用状态。
         *
         * @param request DeleteDomainProxyTokenRequest
         * @return DeleteDomainProxyTokenResponse
         */
        public DeleteDomainProxyTokenResponse DeleteDomainProxyToken(DeleteDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainProxyTokenWithOptions(request, runtime);
        }

        /**
         * @summary 删除指定域名代理Token，删除之前请保证代理Token处于禁用状态。
         *
         * @param request DeleteDomainProxyTokenRequest
         * @return DeleteDomainProxyTokenResponse
         */
        public async Task<DeleteDomainProxyTokenResponse> DeleteDomainProxyTokenAsync(DeleteDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainProxyTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes the information of an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request DeleteGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupResponse
         */
        public DeleteGroupResponse DeleteGroupWithOptions(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Deletes the information of an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request DeleteGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupResponse
         */
        public async Task<DeleteGroupResponse> DeleteGroupWithOptionsAsync(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Deletes the information of an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request DeleteGroupRequest
         * @return DeleteGroupResponse
         */
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes the information of an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request DeleteGroupRequest
         * @return DeleteGroupResponse
         */
        public async Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS) that you do not need.
         *
         * @description Make sure that the instance to be deleted is no longer used. If the instance is deleted, all data related to the instance will be deleted.
         *
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS) that you do not need.
         *
         * @description Make sure that the instance to be deleted is no longer used. If the instance is deleted, all data related to the instance will be deleted.
         *
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS) that you do not need.
         *
         * @description Make sure that the instance to be deleted is no longer used. If the instance is deleted, all data related to the instance will be deleted.
         *
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS) that you do not need.
         *
         * @description Make sure that the instance to be deleted is no longer used. If the instance is deleted, all data related to the instance will be deleted.
         *
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除一个专属网络端点。
         *
         * @param request DeleteNetworkAccessEndpointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNetworkAccessEndpointResponse
         */
        public DeleteNetworkAccessEndpointResponse DeleteNetworkAccessEndpointWithOptions(DeleteNetworkAccessEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointId))
            {
                query["NetworkAccessEndpointId"] = request.NetworkAccessEndpointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNetworkAccessEndpoint",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNetworkAccessEndpointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除一个专属网络端点。
         *
         * @param request DeleteNetworkAccessEndpointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNetworkAccessEndpointResponse
         */
        public async Task<DeleteNetworkAccessEndpointResponse> DeleteNetworkAccessEndpointWithOptionsAsync(DeleteNetworkAccessEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointId))
            {
                query["NetworkAccessEndpointId"] = request.NetworkAccessEndpointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNetworkAccessEndpoint",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNetworkAccessEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除一个专属网络端点。
         *
         * @param request DeleteNetworkAccessEndpointRequest
         * @return DeleteNetworkAccessEndpointResponse
         */
        public DeleteNetworkAccessEndpointResponse DeleteNetworkAccessEndpoint(DeleteNetworkAccessEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkAccessEndpointWithOptions(request, runtime);
        }

        /**
         * @summary 删除一个专属网络端点。
         *
         * @param request DeleteNetworkAccessEndpointRequest
         * @return DeleteNetworkAccessEndpointResponse
         */
        public async Task<DeleteNetworkAccessEndpointResponse> DeleteNetworkAccessEndpointAsync(DeleteNetworkAccessEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkAccessEndpointWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). If the organization has EIAM accounts or child organizations, the delete operation fails.
         *
         * @param request DeleteOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOrganizationalUnitResponse
         */
        public DeleteOrganizationalUnitResponse DeleteOrganizationalUnitWithOptions(DeleteOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). If the organization has EIAM accounts or child organizations, the delete operation fails.
         *
         * @param request DeleteOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOrganizationalUnitResponse
         */
        public async Task<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitWithOptionsAsync(DeleteOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). If the organization has EIAM accounts or child organizations, the delete operation fails.
         *
         * @param request DeleteOrganizationalUnitRequest
         * @return DeleteOrganizationalUnitResponse
         */
        public DeleteOrganizationalUnitResponse DeleteOrganizationalUnit(DeleteOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOrganizationalUnitWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). If the organization has EIAM accounts or child organizations, the delete operation fails.
         *
         * @param request DeleteOrganizationalUnitRequest
         * @return DeleteOrganizationalUnitResponse
         */
        public async Task<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitAsync(DeleteOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOrganizationalUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS). The information related to the account is cleared.
         *
         * @param request DeleteUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Version = "2021-12-01",
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
         * @summary Deletes an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS). The information related to the account is cleared.
         *
         * @param request DeleteUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Version = "2021-12-01",
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
         * @summary Deletes an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS). The information related to the account is cleared.
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
         * @summary Deletes an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS). The information related to the account is cleared.
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
         * @summary Disables an enabled Employee Identity and Access Management (EIAM) application. All features of the EIAM application cannot be used if you disable the EIAM application.
         *
         * @description All features of the EIAM application cannot be used if you disable the EIAM application, such as single sign-on (SSO) and account synchronization. Make sure that you acknowledge the risks of the delete operation.
         *
         * @param request DisableApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationResponse
         */
        public DisableApplicationResponse DisableApplicationWithOptions(DisableApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables an enabled Employee Identity and Access Management (EIAM) application. All features of the EIAM application cannot be used if you disable the EIAM application.
         *
         * @description All features of the EIAM application cannot be used if you disable the EIAM application, such as single sign-on (SSO) and account synchronization. Make sure that you acknowledge the risks of the delete operation.
         *
         * @param request DisableApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationResponse
         */
        public async Task<DisableApplicationResponse> DisableApplicationWithOptionsAsync(DisableApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables an enabled Employee Identity and Access Management (EIAM) application. All features of the EIAM application cannot be used if you disable the EIAM application.
         *
         * @description All features of the EIAM application cannot be used if you disable the EIAM application, such as single sign-on (SSO) and account synchronization. Make sure that you acknowledge the risks of the delete operation.
         *
         * @param request DisableApplicationRequest
         * @return DisableApplicationResponse
         */
        public DisableApplicationResponse DisableApplication(DisableApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Disables an enabled Employee Identity and Access Management (EIAM) application. All features of the EIAM application cannot be used if you disable the EIAM application.
         *
         * @description All features of the EIAM application cannot be used if you disable the EIAM application, such as single sign-on (SSO) and account synchronization. Make sure that you acknowledge the risks of the delete operation.
         *
         * @param request DisableApplicationRequest
         * @return DisableApplicationResponse
         */
        public async Task<DisableApplicationResponse> DisableApplicationAsync(DisableApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DisableApplicationApiInvokeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationApiInvokeResponse
         */
        public DisableApplicationApiInvokeResponse DisableApplicationApiInvokeWithOptions(DisableApplicationApiInvokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationApiInvoke",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationApiInvokeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DisableApplicationApiInvokeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationApiInvokeResponse
         */
        public async Task<DisableApplicationApiInvokeResponse> DisableApplicationApiInvokeWithOptionsAsync(DisableApplicationApiInvokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationApiInvoke",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationApiInvokeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DisableApplicationApiInvokeRequest
         * @return DisableApplicationApiInvokeResponse
         */
        public DisableApplicationApiInvokeResponse DisableApplicationApiInvoke(DisableApplicationApiInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableApplicationApiInvokeWithOptions(request, runtime);
        }

        /**
         * @summary Disables the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DisableApplicationApiInvokeRequest
         * @return DisableApplicationApiInvokeResponse
         */
        public async Task<DisableApplicationApiInvokeResponse> DisableApplicationApiInvokeAsync(DisableApplicationApiInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableApplicationApiInvokeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables a client key of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DisableApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationClientSecretResponse
         */
        public DisableApplicationClientSecretResponse DisableApplicationClientSecretWithOptions(DisableApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationClientSecretResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables a client key of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DisableApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationClientSecretResponse
         */
        public async Task<DisableApplicationClientSecretResponse> DisableApplicationClientSecretWithOptionsAsync(DisableApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationClientSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables a client key of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DisableApplicationClientSecretRequest
         * @return DisableApplicationClientSecretResponse
         */
        public DisableApplicationClientSecretResponse DisableApplicationClientSecret(DisableApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableApplicationClientSecretWithOptions(request, runtime);
        }

        /**
         * @summary Disables a client key of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request DisableApplicationClientSecretRequest
         * @return DisableApplicationClientSecretResponse
         */
        public async Task<DisableApplicationClientSecretResponse> DisableApplicationClientSecretAsync(DisableApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableApplicationClientSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request DisableApplicationProvisioningRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationProvisioningResponse
         */
        public DisableApplicationProvisioningResponse DisableApplicationProvisioningWithOptions(DisableApplicationProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationProvisioning",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationProvisioningResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request DisableApplicationProvisioningRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationProvisioningResponse
         */
        public async Task<DisableApplicationProvisioningResponse> DisableApplicationProvisioningWithOptionsAsync(DisableApplicationProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationProvisioning",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationProvisioningResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request DisableApplicationProvisioningRequest
         * @return DisableApplicationProvisioningResponse
         */
        public DisableApplicationProvisioningResponse DisableApplicationProvisioning(DisableApplicationProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableApplicationProvisioningWithOptions(request, runtime);
        }

        /**
         * @summary Disables the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request DisableApplicationProvisioningRequest
         * @return DisableApplicationProvisioningResponse
         */
        public async Task<DisableApplicationProvisioningResponse> DisableApplicationProvisioningAsync(DisableApplicationProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableApplicationProvisioningWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 禁用应用SSO能力
         *
         * @param request DisableApplicationSsoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationSsoResponse
         */
        public DisableApplicationSsoResponse DisableApplicationSsoWithOptions(DisableApplicationSsoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationSso",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationSsoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 禁用应用SSO能力
         *
         * @param request DisableApplicationSsoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationSsoResponse
         */
        public async Task<DisableApplicationSsoResponse> DisableApplicationSsoWithOptionsAsync(DisableApplicationSsoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationSso",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationSsoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 禁用应用SSO能力
         *
         * @param request DisableApplicationSsoRequest
         * @return DisableApplicationSsoResponse
         */
        public DisableApplicationSsoResponse DisableApplicationSso(DisableApplicationSsoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableApplicationSsoWithOptions(request, runtime);
        }

        /**
         * @summary 禁用应用SSO能力
         *
         * @param request DisableApplicationSsoRequest
         * @return DisableApplicationSsoResponse
         */
        public async Task<DisableApplicationSsoResponse> DisableApplicationSsoAsync(DisableApplicationSsoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableApplicationSsoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 禁用指定域名代理Token。
         *
         * @param request DisableDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableDomainProxyTokenResponse
         */
        public DisableDomainProxyTokenResponse DisableDomainProxyTokenWithOptions(DisableDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainProxyTokenId))
            {
                query["DomainProxyTokenId"] = request.DomainProxyTokenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDomainProxyTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 禁用指定域名代理Token。
         *
         * @param request DisableDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableDomainProxyTokenResponse
         */
        public async Task<DisableDomainProxyTokenResponse> DisableDomainProxyTokenWithOptionsAsync(DisableDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainProxyTokenId))
            {
                query["DomainProxyTokenId"] = request.DomainProxyTokenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDomainProxyTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 禁用指定域名代理Token。
         *
         * @param request DisableDomainProxyTokenRequest
         * @return DisableDomainProxyTokenResponse
         */
        public DisableDomainProxyTokenResponse DisableDomainProxyToken(DisableDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDomainProxyTokenWithOptions(request, runtime);
        }

        /**
         * @summary 禁用指定域名代理Token。
         *
         * @param request DisableDomainProxyTokenRequest
         * @return DisableDomainProxyTokenResponse
         */
        public async Task<DisableDomainProxyTokenResponse> DisableDomainProxyTokenAsync(DisableDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDomainProxyTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 关闭初始化域名自动跳转。
         *
         * @param request DisableInitDomainAutoRedirectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableInitDomainAutoRedirectResponse
         */
        public DisableInitDomainAutoRedirectResponse DisableInitDomainAutoRedirectWithOptions(DisableInitDomainAutoRedirectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableInitDomainAutoRedirect",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableInitDomainAutoRedirectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 关闭初始化域名自动跳转。
         *
         * @param request DisableInitDomainAutoRedirectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableInitDomainAutoRedirectResponse
         */
        public async Task<DisableInitDomainAutoRedirectResponse> DisableInitDomainAutoRedirectWithOptionsAsync(DisableInitDomainAutoRedirectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableInitDomainAutoRedirect",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableInitDomainAutoRedirectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 关闭初始化域名自动跳转。
         *
         * @param request DisableInitDomainAutoRedirectRequest
         * @return DisableInitDomainAutoRedirectResponse
         */
        public DisableInitDomainAutoRedirectResponse DisableInitDomainAutoRedirect(DisableInitDomainAutoRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableInitDomainAutoRedirectWithOptions(request, runtime);
        }

        /**
         * @summary 关闭初始化域名自动跳转。
         *
         * @param request DisableInitDomainAutoRedirectRequest
         * @return DisableInitDomainAutoRedirectResponse
         */
        public async Task<DisableInitDomainAutoRedirectResponse> DisableInitDomainAutoRedirectAsync(DisableInitDomainAutoRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableInitDomainAutoRedirectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account. If the account is disabled, a success message is returned.
         *
         * @param request DisableUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableUserResponse
         */
        public DisableUserResponse DisableUserWithOptions(DisableUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DisableUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account. If the account is disabled, a success message is returned.
         *
         * @param request DisableUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableUserResponse
         */
        public async Task<DisableUserResponse> DisableUserWithOptionsAsync(DisableUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DisableUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account. If the account is disabled, a success message is returned.
         *
         * @param request DisableUserRequest
         * @return DisableUserResponse
         */
        public DisableUserResponse DisableUser(DisableUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableUserWithOptions(request, runtime);
        }

        /**
         * @summary Disables an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account. If the account is disabled, a success message is returned.
         *
         * @param request DisableUserRequest
         * @return DisableUserResponse
         */
        public async Task<DisableUserResponse> DisableUserAsync(DisableUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables a disabled Employee Identity and Access Management (EIAM) application.
         *
         * @param request EnableApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationResponse
         */
        public EnableApplicationResponse EnableApplicationWithOptions(EnableApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables a disabled Employee Identity and Access Management (EIAM) application.
         *
         * @param request EnableApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationResponse
         */
        public async Task<EnableApplicationResponse> EnableApplicationWithOptionsAsync(EnableApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables a disabled Employee Identity and Access Management (EIAM) application.
         *
         * @param request EnableApplicationRequest
         * @return EnableApplicationResponse
         */
        public EnableApplicationResponse EnableApplication(EnableApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Enables a disabled Employee Identity and Access Management (EIAM) application.
         *
         * @param request EnableApplicationRequest
         * @return EnableApplicationResponse
         */
        public async Task<EnableApplicationResponse> EnableApplicationAsync(EnableApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request EnableApplicationApiInvokeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationApiInvokeResponse
         */
        public EnableApplicationApiInvokeResponse EnableApplicationApiInvokeWithOptions(EnableApplicationApiInvokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationApiInvoke",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationApiInvokeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request EnableApplicationApiInvokeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationApiInvokeResponse
         */
        public async Task<EnableApplicationApiInvokeResponse> EnableApplicationApiInvokeWithOptionsAsync(EnableApplicationApiInvokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationApiInvoke",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationApiInvokeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request EnableApplicationApiInvokeRequest
         * @return EnableApplicationApiInvokeResponse
         */
        public EnableApplicationApiInvokeResponse EnableApplicationApiInvoke(EnableApplicationApiInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableApplicationApiInvokeWithOptions(request, runtime);
        }

        /**
         * @summary Enables the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request EnableApplicationApiInvokeRequest
         * @return EnableApplicationApiInvokeResponse
         */
        public async Task<EnableApplicationApiInvokeResponse> EnableApplicationApiInvokeAsync(EnableApplicationApiInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableApplicationApiInvokeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables the client key of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request EnableApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationClientSecretResponse
         */
        public EnableApplicationClientSecretResponse EnableApplicationClientSecretWithOptions(EnableApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationClientSecretResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables the client key of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request EnableApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationClientSecretResponse
         */
        public async Task<EnableApplicationClientSecretResponse> EnableApplicationClientSecretWithOptionsAsync(EnableApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationClientSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables the client key of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request EnableApplicationClientSecretRequest
         * @return EnableApplicationClientSecretResponse
         */
        public EnableApplicationClientSecretResponse EnableApplicationClientSecret(EnableApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableApplicationClientSecretWithOptions(request, runtime);
        }

        /**
         * @summary Enables the client key of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request EnableApplicationClientSecretRequest
         * @return EnableApplicationClientSecretResponse
         */
        public async Task<EnableApplicationClientSecretResponse> EnableApplicationClientSecretAsync(EnableApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableApplicationClientSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request EnableApplicationProvisioningRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationProvisioningResponse
         */
        public EnableApplicationProvisioningResponse EnableApplicationProvisioningWithOptions(EnableApplicationProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationProvisioning",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationProvisioningResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request EnableApplicationProvisioningRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationProvisioningResponse
         */
        public async Task<EnableApplicationProvisioningResponse> EnableApplicationProvisioningWithOptionsAsync(EnableApplicationProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationProvisioning",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationProvisioningResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request EnableApplicationProvisioningRequest
         * @return EnableApplicationProvisioningResponse
         */
        public EnableApplicationProvisioningResponse EnableApplicationProvisioning(EnableApplicationProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableApplicationProvisioningWithOptions(request, runtime);
        }

        /**
         * @summary Enables the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request EnableApplicationProvisioningRequest
         * @return EnableApplicationProvisioningResponse
         */
        public async Task<EnableApplicationProvisioningResponse> EnableApplicationProvisioningAsync(EnableApplicationProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableApplicationProvisioningWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 启用应用SSO能力
         *
         * @param request EnableApplicationSsoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationSsoResponse
         */
        public EnableApplicationSsoResponse EnableApplicationSsoWithOptions(EnableApplicationSsoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationSso",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationSsoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启用应用SSO能力
         *
         * @param request EnableApplicationSsoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationSsoResponse
         */
        public async Task<EnableApplicationSsoResponse> EnableApplicationSsoWithOptionsAsync(EnableApplicationSsoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationSso",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationSsoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启用应用SSO能力
         *
         * @param request EnableApplicationSsoRequest
         * @return EnableApplicationSsoResponse
         */
        public EnableApplicationSsoResponse EnableApplicationSso(EnableApplicationSsoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableApplicationSsoWithOptions(request, runtime);
        }

        /**
         * @summary 启用应用SSO能力
         *
         * @param request EnableApplicationSsoRequest
         * @return EnableApplicationSsoResponse
         */
        public async Task<EnableApplicationSsoResponse> EnableApplicationSsoAsync(EnableApplicationSsoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableApplicationSsoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 启用指定域名代理Token。
         *
         * @param request EnableDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableDomainProxyTokenResponse
         */
        public EnableDomainProxyTokenResponse EnableDomainProxyTokenWithOptions(EnableDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainProxyTokenId))
            {
                query["DomainProxyTokenId"] = request.DomainProxyTokenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDomainProxyTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启用指定域名代理Token。
         *
         * @param request EnableDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableDomainProxyTokenResponse
         */
        public async Task<EnableDomainProxyTokenResponse> EnableDomainProxyTokenWithOptionsAsync(EnableDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainProxyTokenId))
            {
                query["DomainProxyTokenId"] = request.DomainProxyTokenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDomainProxyTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启用指定域名代理Token。
         *
         * @param request EnableDomainProxyTokenRequest
         * @return EnableDomainProxyTokenResponse
         */
        public EnableDomainProxyTokenResponse EnableDomainProxyToken(EnableDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDomainProxyTokenWithOptions(request, runtime);
        }

        /**
         * @summary 启用指定域名代理Token。
         *
         * @param request EnableDomainProxyTokenRequest
         * @return EnableDomainProxyTokenResponse
         */
        public async Task<EnableDomainProxyTokenResponse> EnableDomainProxyTokenAsync(EnableDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDomainProxyTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 开启初始化域名自动跳转。开启后，访问初始化域名将会自动跳转至默认域名。
         *
         * @param request EnableInitDomainAutoRedirectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableInitDomainAutoRedirectResponse
         */
        public EnableInitDomainAutoRedirectResponse EnableInitDomainAutoRedirectWithOptions(EnableInitDomainAutoRedirectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInitDomainAutoRedirect",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInitDomainAutoRedirectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开启初始化域名自动跳转。开启后，访问初始化域名将会自动跳转至默认域名。
         *
         * @param request EnableInitDomainAutoRedirectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableInitDomainAutoRedirectResponse
         */
        public async Task<EnableInitDomainAutoRedirectResponse> EnableInitDomainAutoRedirectWithOptionsAsync(EnableInitDomainAutoRedirectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInitDomainAutoRedirect",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInitDomainAutoRedirectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开启初始化域名自动跳转。开启后，访问初始化域名将会自动跳转至默认域名。
         *
         * @param request EnableInitDomainAutoRedirectRequest
         * @return EnableInitDomainAutoRedirectResponse
         */
        public EnableInitDomainAutoRedirectResponse EnableInitDomainAutoRedirect(EnableInitDomainAutoRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableInitDomainAutoRedirectWithOptions(request, runtime);
        }

        /**
         * @summary 开启初始化域名自动跳转。开启后，访问初始化域名将会自动跳转至默认域名。
         *
         * @param request EnableInitDomainAutoRedirectRequest
         * @return EnableInitDomainAutoRedirectResponse
         */
        public async Task<EnableInitDomainAutoRedirectResponse> EnableInitDomainAutoRedirectAsync(EnableInitDomainAutoRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableInitDomainAutoRedirectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS).
         *
         * @param request EnableUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableUserResponse
         */
        public EnableUserResponse EnableUserWithOptions(EnableUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "EnableUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS).
         *
         * @param request EnableUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableUserResponse
         */
        public async Task<EnableUserResponse> EnableUserWithOptionsAsync(EnableUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "EnableUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS).
         *
         * @param request EnableUserRequest
         * @return EnableUserResponse
         */
        public EnableUserResponse EnableUser(EnableUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableUserWithOptions(request, runtime);
        }

        /**
         * @summary Enables an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS).
         *
         * @param request EnableUserRequest
         * @return EnableUserResponse
         */
        public async Task<EnableUserResponse> EnableUserAsync(EnableUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request GetApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationResponse
         */
        public GetApplicationResponse GetApplicationWithOptions(GetApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the details of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request GetApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationResponse
         */
        public async Task<GetApplicationResponse> GetApplicationWithOptionsAsync(GetApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the details of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request GetApplicationRequest
         * @return GetApplicationResponse
         */
        public GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request GetApplicationRequest
         * @return GetApplicationResponse
         */
        public async Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the permissions of the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request GetApplicationGrantScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationGrantScopeResponse
         */
        public GetApplicationGrantScopeResponse GetApplicationGrantScopeWithOptions(GetApplicationGrantScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationGrantScope",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationGrantScopeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the permissions of the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request GetApplicationGrantScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationGrantScopeResponse
         */
        public async Task<GetApplicationGrantScopeResponse> GetApplicationGrantScopeWithOptionsAsync(GetApplicationGrantScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationGrantScope",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationGrantScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the permissions of the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request GetApplicationGrantScopeRequest
         * @return GetApplicationGrantScopeResponse
         */
        public GetApplicationGrantScopeResponse GetApplicationGrantScope(GetApplicationGrantScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationGrantScopeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the permissions of the Developer API feature for an Employee Identity and Access Management (EIAM) application.
         *
         * @param request GetApplicationGrantScopeRequest
         * @return GetApplicationGrantScopeResponse
         */
        public async Task<GetApplicationGrantScopeResponse> GetApplicationGrantScopeAsync(GetApplicationGrantScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationGrantScopeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the configuration of the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetApplicationProvisioningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationProvisioningConfigResponse
         */
        public GetApplicationProvisioningConfigResponse GetApplicationProvisioningConfigWithOptions(GetApplicationProvisioningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationProvisioningConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationProvisioningConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the configuration of the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetApplicationProvisioningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationProvisioningConfigResponse
         */
        public async Task<GetApplicationProvisioningConfigResponse> GetApplicationProvisioningConfigWithOptionsAsync(GetApplicationProvisioningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationProvisioningConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationProvisioningConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the configuration of the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetApplicationProvisioningConfigRequest
         * @return GetApplicationProvisioningConfigResponse
         */
        public GetApplicationProvisioningConfigResponse GetApplicationProvisioningConfig(GetApplicationProvisioningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationProvisioningConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configuration of the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetApplicationProvisioningConfigRequest
         * @return GetApplicationProvisioningConfigResponse
         */
        public async Task<GetApplicationProvisioningConfigResponse> GetApplicationProvisioningConfigAsync(GetApplicationProvisioningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationProvisioningConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the account synchronization scope of applications in Identity as a Service (IDaaS) Employee IAM (EIAM). This scope is the same as the scope within which developers can call the DeveloperAPI to query and manage accounts.
         *
         * @param request GetApplicationProvisioningScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationProvisioningScopeResponse
         */
        public GetApplicationProvisioningScopeResponse GetApplicationProvisioningScopeWithOptions(GetApplicationProvisioningScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationProvisioningScope",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationProvisioningScopeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the account synchronization scope of applications in Identity as a Service (IDaaS) Employee IAM (EIAM). This scope is the same as the scope within which developers can call the DeveloperAPI to query and manage accounts.
         *
         * @param request GetApplicationProvisioningScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationProvisioningScopeResponse
         */
        public async Task<GetApplicationProvisioningScopeResponse> GetApplicationProvisioningScopeWithOptionsAsync(GetApplicationProvisioningScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationProvisioningScope",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationProvisioningScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the account synchronization scope of applications in Identity as a Service (IDaaS) Employee IAM (EIAM). This scope is the same as the scope within which developers can call the DeveloperAPI to query and manage accounts.
         *
         * @param request GetApplicationProvisioningScopeRequest
         * @return GetApplicationProvisioningScopeResponse
         */
        public GetApplicationProvisioningScopeResponse GetApplicationProvisioningScope(GetApplicationProvisioningScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationProvisioningScopeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the account synchronization scope of applications in Identity as a Service (IDaaS) Employee IAM (EIAM). This scope is the same as the scope within which developers can call the DeveloperAPI to query and manage accounts.
         *
         * @param request GetApplicationProvisioningScopeRequest
         * @return GetApplicationProvisioningScopeResponse
         */
        public async Task<GetApplicationProvisioningScopeResponse> GetApplicationProvisioningScopeAsync(GetApplicationProvisioningScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationProvisioningScopeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the single sign-on (SSO) configuration attributes of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetApplicationSsoConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationSsoConfigResponse
         */
        public GetApplicationSsoConfigResponse GetApplicationSsoConfigWithOptions(GetApplicationSsoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationSsoConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationSsoConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the single sign-on (SSO) configuration attributes of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetApplicationSsoConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationSsoConfigResponse
         */
        public async Task<GetApplicationSsoConfigResponse> GetApplicationSsoConfigWithOptionsAsync(GetApplicationSsoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationSsoConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationSsoConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the single sign-on (SSO) configuration attributes of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetApplicationSsoConfigRequest
         * @return GetApplicationSsoConfigResponse
         */
        public GetApplicationSsoConfigResponse GetApplicationSsoConfig(GetApplicationSsoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationSsoConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the single sign-on (SSO) configuration attributes of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetApplicationSsoConfigRequest
         * @return GetApplicationSsoConfigResponse
         */
        public async Task<GetApplicationSsoConfigResponse> GetApplicationSsoConfigAsync(GetApplicationSsoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationSsoConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询一个域名的详细信息。
         *
         * @param request GetDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainResponse
         */
        public GetDomainResponse GetDomainWithOptions(GetDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询一个域名的详细信息。
         *
         * @param request GetDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainResponse
         */
        public async Task<GetDomainResponse> GetDomainWithOptionsAsync(GetDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询一个域名的详细信息。
         *
         * @param request GetDomainRequest
         * @return GetDomainResponse
         */
        public GetDomainResponse GetDomain(GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDomainWithOptions(request, runtime);
        }

        /**
         * @summary 查询一个域名的详细信息。
         *
         * @param request GetDomainRequest
         * @return GetDomainResponse
         */
        public async Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看域名的DNS Challenge记录。
         *
         * @param request GetDomainDnsChallengeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainDnsChallengeResponse
         */
        public GetDomainDnsChallengeResponse GetDomainDnsChallengeWithOptions(GetDomainDnsChallengeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomainDnsChallenge",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainDnsChallengeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看域名的DNS Challenge记录。
         *
         * @param request GetDomainDnsChallengeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainDnsChallengeResponse
         */
        public async Task<GetDomainDnsChallengeResponse> GetDomainDnsChallengeWithOptionsAsync(GetDomainDnsChallengeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomainDnsChallenge",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainDnsChallengeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看域名的DNS Challenge记录。
         *
         * @param request GetDomainDnsChallengeRequest
         * @return GetDomainDnsChallengeResponse
         */
        public GetDomainDnsChallengeResponse GetDomainDnsChallenge(GetDomainDnsChallengeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDomainDnsChallengeWithOptions(request, runtime);
        }

        /**
         * @summary 查看域名的DNS Challenge记录。
         *
         * @param request GetDomainDnsChallengeRequest
         * @return GetDomainDnsChallengeResponse
         */
        public async Task<GetDomainDnsChallengeResponse> GetDomainDnsChallengeAsync(GetDomainDnsChallengeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDomainDnsChallengeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the forgot password configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetForgetPasswordConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetForgetPasswordConfigurationResponse
         */
        public GetForgetPasswordConfigurationResponse GetForgetPasswordConfigurationWithOptions(GetForgetPasswordConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetForgetPasswordConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetForgetPasswordConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the forgot password configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetForgetPasswordConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetForgetPasswordConfigurationResponse
         */
        public async Task<GetForgetPasswordConfigurationResponse> GetForgetPasswordConfigurationWithOptionsAsync(GetForgetPasswordConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetForgetPasswordConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetForgetPasswordConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the forgot password configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetForgetPasswordConfigurationRequest
         * @return GetForgetPasswordConfigurationResponse
         */
        public GetForgetPasswordConfigurationResponse GetForgetPasswordConfiguration(GetForgetPasswordConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetForgetPasswordConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the forgot password configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetForgetPasswordConfigurationRequest
         * @return GetForgetPasswordConfigurationResponse
         */
        public async Task<GetForgetPasswordConfigurationResponse> GetForgetPasswordConfigurationAsync(GetForgetPasswordConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetForgetPasswordConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request GetGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupResponse
         */
        public GetGroupResponse GetGroupWithOptions(GetGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the information of an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request GetGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupResponse
         */
        public async Task<GetGroupResponse> GetGroupWithOptionsAsync(GetGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the information of an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request GetGroupRequest
         * @return GetGroupResponse
         */
        public GetGroupResponse GetGroup(GetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGroupWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request GetGroupRequest
         * @return GetGroupResponse
         */
        public async Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetInstanceRequest
         * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetInstanceRequest
         * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询一个专属网络端点的详细信息。
         *
         * @param request GetNetworkAccessEndpointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNetworkAccessEndpointResponse
         */
        public GetNetworkAccessEndpointResponse GetNetworkAccessEndpointWithOptions(GetNetworkAccessEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointId))
            {
                query["NetworkAccessEndpointId"] = request.NetworkAccessEndpointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetworkAccessEndpoint",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetworkAccessEndpointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询一个专属网络端点的详细信息。
         *
         * @param request GetNetworkAccessEndpointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNetworkAccessEndpointResponse
         */
        public async Task<GetNetworkAccessEndpointResponse> GetNetworkAccessEndpointWithOptionsAsync(GetNetworkAccessEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointId))
            {
                query["NetworkAccessEndpointId"] = request.NetworkAccessEndpointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetworkAccessEndpoint",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetworkAccessEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询一个专属网络端点的详细信息。
         *
         * @param request GetNetworkAccessEndpointRequest
         * @return GetNetworkAccessEndpointResponse
         */
        public GetNetworkAccessEndpointResponse GetNetworkAccessEndpoint(GetNetworkAccessEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNetworkAccessEndpointWithOptions(request, runtime);
        }

        /**
         * @summary 查询一个专属网络端点的详细信息。
         *
         * @param request GetNetworkAccessEndpointRequest
         * @return GetNetworkAccessEndpointResponse
         */
        public async Task<GetNetworkAccessEndpointResponse> GetNetworkAccessEndpointAsync(GetNetworkAccessEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNetworkAccessEndpointWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about an organizational unit in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrganizationalUnitResponse
         */
        public GetOrganizationalUnitResponse GetOrganizationalUnitWithOptions(GetOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an organizational unit in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrganizationalUnitResponse
         */
        public async Task<GetOrganizationalUnitResponse> GetOrganizationalUnitWithOptionsAsync(GetOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an organizational unit in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetOrganizationalUnitRequest
         * @return GetOrganizationalUnitResponse
         */
        public GetOrganizationalUnitResponse GetOrganizationalUnit(GetOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrganizationalUnitWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about an organizational unit in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetOrganizationalUnitRequest
         * @return GetOrganizationalUnitResponse
         */
        public async Task<GetOrganizationalUnitResponse> GetOrganizationalUnitAsync(GetOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrganizationalUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the password complexity configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordComplexityConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordComplexityConfigurationResponse
         */
        public GetPasswordComplexityConfigurationResponse GetPasswordComplexityConfigurationWithOptions(GetPasswordComplexityConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordComplexityConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordComplexityConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the password complexity configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordComplexityConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordComplexityConfigurationResponse
         */
        public async Task<GetPasswordComplexityConfigurationResponse> GetPasswordComplexityConfigurationWithOptionsAsync(GetPasswordComplexityConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordComplexityConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordComplexityConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the password complexity configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordComplexityConfigurationRequest
         * @return GetPasswordComplexityConfigurationResponse
         */
        public GetPasswordComplexityConfigurationResponse GetPasswordComplexityConfiguration(GetPasswordComplexityConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPasswordComplexityConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the password complexity configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordComplexityConfigurationRequest
         * @return GetPasswordComplexityConfigurationResponse
         */
        public async Task<GetPasswordComplexityConfigurationResponse> GetPasswordComplexityConfigurationAsync(GetPasswordComplexityConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPasswordComplexityConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the password expiration configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordExpirationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordExpirationConfigurationResponse
         */
        public GetPasswordExpirationConfigurationResponse GetPasswordExpirationConfigurationWithOptions(GetPasswordExpirationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordExpirationConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordExpirationConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the password expiration configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordExpirationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordExpirationConfigurationResponse
         */
        public async Task<GetPasswordExpirationConfigurationResponse> GetPasswordExpirationConfigurationWithOptionsAsync(GetPasswordExpirationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordExpirationConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordExpirationConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the password expiration configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordExpirationConfigurationRequest
         * @return GetPasswordExpirationConfigurationResponse
         */
        public GetPasswordExpirationConfigurationResponse GetPasswordExpirationConfiguration(GetPasswordExpirationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPasswordExpirationConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the password expiration configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordExpirationConfigurationRequest
         * @return GetPasswordExpirationConfigurationResponse
         */
        public async Task<GetPasswordExpirationConfigurationResponse> GetPasswordExpirationConfigurationAsync(GetPasswordExpirationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPasswordExpirationConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the password history configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordHistoryConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordHistoryConfigurationResponse
         */
        public GetPasswordHistoryConfigurationResponse GetPasswordHistoryConfigurationWithOptions(GetPasswordHistoryConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordHistoryConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordHistoryConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the password history configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordHistoryConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordHistoryConfigurationResponse
         */
        public async Task<GetPasswordHistoryConfigurationResponse> GetPasswordHistoryConfigurationWithOptionsAsync(GetPasswordHistoryConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordHistoryConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordHistoryConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the password history configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordHistoryConfigurationRequest
         * @return GetPasswordHistoryConfigurationResponse
         */
        public GetPasswordHistoryConfigurationResponse GetPasswordHistoryConfiguration(GetPasswordHistoryConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPasswordHistoryConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the password history configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordHistoryConfigurationRequest
         * @return GetPasswordHistoryConfigurationResponse
         */
        public async Task<GetPasswordHistoryConfigurationResponse> GetPasswordHistoryConfigurationAsync(GetPasswordHistoryConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPasswordHistoryConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the password initialization configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordInitializationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordInitializationConfigurationResponse
         */
        public GetPasswordInitializationConfigurationResponse GetPasswordInitializationConfigurationWithOptions(GetPasswordInitializationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordInitializationConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordInitializationConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the password initialization configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordInitializationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordInitializationConfigurationResponse
         */
        public async Task<GetPasswordInitializationConfigurationResponse> GetPasswordInitializationConfigurationWithOptionsAsync(GetPasswordInitializationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordInitializationConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordInitializationConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the password initialization configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordInitializationConfigurationRequest
         * @return GetPasswordInitializationConfigurationResponse
         */
        public GetPasswordInitializationConfigurationResponse GetPasswordInitializationConfiguration(GetPasswordInitializationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPasswordInitializationConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the password initialization configurations of an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request GetPasswordInitializationConfigurationRequest
         * @return GetPasswordInitializationConfigurationResponse
         */
        public async Task<GetPasswordInitializationConfigurationResponse> GetPasswordInitializationConfigurationAsync(GetPasswordInitializationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPasswordInitializationConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the root organizational unit in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetRootOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRootOrganizationalUnitResponse
         */
        public GetRootOrganizationalUnitResponse GetRootOrganizationalUnitWithOptions(GetRootOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRootOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRootOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the root organizational unit in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetRootOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRootOrganizationalUnitResponse
         */
        public async Task<GetRootOrganizationalUnitResponse> GetRootOrganizationalUnitWithOptionsAsync(GetRootOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRootOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRootOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the root organizational unit in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetRootOrganizationalUnitRequest
         * @return GetRootOrganizationalUnitResponse
         */
        public GetRootOrganizationalUnitResponse GetRootOrganizationalUnit(GetRootOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRootOrganizationalUnitWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the root organizational unit in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetRootOrganizationalUnitRequest
         * @return GetRootOrganizationalUnitResponse
         */
        public async Task<GetRootOrganizationalUnitResponse> GetRootOrganizationalUnitAsync(GetRootOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRootOrganizationalUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an account in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetUser",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the details of an account in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetUser",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the details of an account in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an account in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all client keys of an Employee Identity and Access Management (EIAM) application. The returned key secret is not masked. If you want to query the key secret that is masked, call the ObtainApplicationClientSecret operation.
         *
         * @param request ListApplicationClientSecretsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationClientSecretsResponse
         */
        public ListApplicationClientSecretsResponse ListApplicationClientSecretsWithOptions(ListApplicationClientSecretsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationClientSecrets",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationClientSecretsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all client keys of an Employee Identity and Access Management (EIAM) application. The returned key secret is not masked. If you want to query the key secret that is masked, call the ObtainApplicationClientSecret operation.
         *
         * @param request ListApplicationClientSecretsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationClientSecretsResponse
         */
        public async Task<ListApplicationClientSecretsResponse> ListApplicationClientSecretsWithOptionsAsync(ListApplicationClientSecretsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationClientSecrets",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationClientSecretsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all client keys of an Employee Identity and Access Management (EIAM) application. The returned key secret is not masked. If you want to query the key secret that is masked, call the ObtainApplicationClientSecret operation.
         *
         * @param request ListApplicationClientSecretsRequest
         * @return ListApplicationClientSecretsResponse
         */
        public ListApplicationClientSecretsResponse ListApplicationClientSecrets(ListApplicationClientSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationClientSecretsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all client keys of an Employee Identity and Access Management (EIAM) application. The returned key secret is not masked. If you want to query the key secret that is masked, call the ObtainApplicationClientSecret operation.
         *
         * @param request ListApplicationClientSecretsRequest
         * @return ListApplicationClientSecretsResponse
         */
        public async Task<ListApplicationClientSecretsResponse> ListApplicationClientSecretsAsync(ListApplicationClientSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationClientSecretsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about one or multiple Employee Identity and Access Management (EIAM) applications by page.
         *
         * @param request ListApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsResponse
         */
        public ListApplicationsResponse ListApplicationsWithOptions(ListApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                query["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationType))
            {
                query["AuthorizationType"] = request.AuthorizationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListApplications",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the information about one or multiple Employee Identity and Access Management (EIAM) applications by page.
         *
         * @param request ListApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsResponse
         */
        public async Task<ListApplicationsResponse> ListApplicationsWithOptionsAsync(ListApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                query["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationType))
            {
                query["AuthorizationType"] = request.AuthorizationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListApplications",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the information about one or multiple Employee Identity and Access Management (EIAM) applications by page.
         *
         * @param request ListApplicationsRequest
         * @return ListApplicationsResponse
         */
        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about one or multiple Employee Identity and Access Management (EIAM) applications by page.
         *
         * @param request ListApplicationsRequest
         * @return ListApplicationsResponse
         */
        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the applications that an Employee Identity and Access Management (EIAM) organization can access. The return result includes the IDs of the applications. If you want to obtain the details of the applications, call the GetApplication operation.
         *
         * @description You can only query the permissions that are directly granted to the EIAM organization by calling the ListApplicationsForOrganizationalUnit operation. You can filter applications by configuring the **ApplicationIds** parameter when you call this operation.
         *
         * @param request ListApplicationsForOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsForOrganizationalUnitResponse
         */
        public ListApplicationsForOrganizationalUnitResponse ListApplicationsForOrganizationalUnitWithOptions(ListApplicationsForOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                query["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
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
                Action = "ListApplicationsForOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the applications that an Employee Identity and Access Management (EIAM) organization can access. The return result includes the IDs of the applications. If you want to obtain the details of the applications, call the GetApplication operation.
         *
         * @description You can only query the permissions that are directly granted to the EIAM organization by calling the ListApplicationsForOrganizationalUnit operation. You can filter applications by configuring the **ApplicationIds** parameter when you call this operation.
         *
         * @param request ListApplicationsForOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsForOrganizationalUnitResponse
         */
        public async Task<ListApplicationsForOrganizationalUnitResponse> ListApplicationsForOrganizationalUnitWithOptionsAsync(ListApplicationsForOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                query["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
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
                Action = "ListApplicationsForOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the applications that an Employee Identity and Access Management (EIAM) organization can access. The return result includes the IDs of the applications. If you want to obtain the details of the applications, call the GetApplication operation.
         *
         * @description You can only query the permissions that are directly granted to the EIAM organization by calling the ListApplicationsForOrganizationalUnit operation. You can filter applications by configuring the **ApplicationIds** parameter when you call this operation.
         *
         * @param request ListApplicationsForOrganizationalUnitRequest
         * @return ListApplicationsForOrganizationalUnitResponse
         */
        public ListApplicationsForOrganizationalUnitResponse ListApplicationsForOrganizationalUnit(ListApplicationsForOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsForOrganizationalUnitWithOptions(request, runtime);
        }

        /**
         * @summary Queries the applications that an Employee Identity and Access Management (EIAM) organization can access. The return result includes the IDs of the applications. If you want to obtain the details of the applications, call the GetApplication operation.
         *
         * @description You can only query the permissions that are directly granted to the EIAM organization by calling the ListApplicationsForOrganizationalUnit operation. You can filter applications by configuring the **ApplicationIds** parameter when you call this operation.
         *
         * @param request ListApplicationsForOrganizationalUnitRequest
         * @return ListApplicationsForOrganizationalUnitResponse
         */
        public async Task<ListApplicationsForOrganizationalUnitResponse> ListApplicationsForOrganizationalUnitAsync(ListApplicationsForOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsForOrganizationalUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the applications that an Employee Identity and Access Management (EIAM) account can access. The return result includes the IDs of the applications. If you want to obtain the details of the applications, call the GetApplication operation.
         *
         * @param request ListApplicationsForUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsForUserResponse
         */
        public ListApplicationsForUserResponse ListApplicationsForUserWithOptions(ListApplicationsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                query["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
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
                Action = "ListApplicationsForUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the applications that an Employee Identity and Access Management (EIAM) account can access. The return result includes the IDs of the applications. If you want to obtain the details of the applications, call the GetApplication operation.
         *
         * @param request ListApplicationsForUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsForUserResponse
         */
        public async Task<ListApplicationsForUserResponse> ListApplicationsForUserWithOptionsAsync(ListApplicationsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                query["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
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
                Action = "ListApplicationsForUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the applications that an Employee Identity and Access Management (EIAM) account can access. The return result includes the IDs of the applications. If you want to obtain the details of the applications, call the GetApplication operation.
         *
         * @param request ListApplicationsForUserRequest
         * @return ListApplicationsForUserResponse
         */
        public ListApplicationsForUserResponse ListApplicationsForUser(ListApplicationsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsForUserWithOptions(request, runtime);
        }

        /**
         * @summary Queries the applications that an Employee Identity and Access Management (EIAM) account can access. The return result includes the IDs of the applications. If you want to obtain the details of the applications, call the GetApplication operation.
         *
         * @param request ListApplicationsForUserRequest
         * @return ListApplicationsForUserResponse
         */
        public async Task<ListApplicationsForUserResponse> ListApplicationsForUserAsync(ListApplicationsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsForUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列表查询域名代理Token信息。
         *
         * @param request ListDomainProxyTokensRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainProxyTokensResponse
         */
        public ListDomainProxyTokensResponse ListDomainProxyTokensWithOptions(ListDomainProxyTokensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomainProxyTokens",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainProxyTokensResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列表查询域名代理Token信息。
         *
         * @param request ListDomainProxyTokensRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainProxyTokensResponse
         */
        public async Task<ListDomainProxyTokensResponse> ListDomainProxyTokensWithOptionsAsync(ListDomainProxyTokensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomainProxyTokens",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainProxyTokensResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列表查询域名代理Token信息。
         *
         * @param request ListDomainProxyTokensRequest
         * @return ListDomainProxyTokensResponse
         */
        public ListDomainProxyTokensResponse ListDomainProxyTokens(ListDomainProxyTokensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDomainProxyTokensWithOptions(request, runtime);
        }

        /**
         * @summary 列表查询域名代理Token信息。
         *
         * @param request ListDomainProxyTokensRequest
         * @return ListDomainProxyTokensResponse
         */
        public async Task<ListDomainProxyTokensResponse> ListDomainProxyTokensAsync(ListDomainProxyTokensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDomainProxyTokensWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列表查询域名记录。
         *
         * @param request ListDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomainsWithOptions(ListDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列表查询域名记录。
         *
         * @param request ListDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsWithOptionsAsync(ListDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列表查询域名记录。
         *
         * @param request ListDomainsRequest
         * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDomainsWithOptions(request, runtime);
        }

        /**
         * @summary 列表查询域名记录。
         *
         * @param request ListDomainsRequest
         * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询EIAM2.0/EIAM1.0实例列表
         *
         * @param request ListEiamInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEiamInstancesResponse
         */
        public ListEiamInstancesResponse ListEiamInstancesWithOptions(ListEiamInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                query["InstanceRegionId"] = request.InstanceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEiamInstances",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEiamInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询EIAM2.0/EIAM1.0实例列表
         *
         * @param request ListEiamInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEiamInstancesResponse
         */
        public async Task<ListEiamInstancesResponse> ListEiamInstancesWithOptionsAsync(ListEiamInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                query["InstanceRegionId"] = request.InstanceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEiamInstances",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEiamInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询EIAM2.0/EIAM1.0实例列表
         *
         * @param request ListEiamInstancesRequest
         * @return ListEiamInstancesResponse
         */
        public ListEiamInstancesResponse ListEiamInstances(ListEiamInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEiamInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 查询EIAM2.0/EIAM1.0实例列表
         *
         * @param request ListEiamInstancesRequest
         * @return ListEiamInstancesResponse
         */
        public async Task<ListEiamInstancesResponse> ListEiamInstancesAsync(ListEiamInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEiamInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询EIAM2.0/EIAM1.0地域列表
         *
         * @param request ListEiamRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEiamRegionsResponse
         */
        public ListEiamRegionsResponse ListEiamRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEiamRegions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEiamRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询EIAM2.0/EIAM1.0地域列表
         *
         * @param request ListEiamRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEiamRegionsResponse
         */
        public async Task<ListEiamRegionsResponse> ListEiamRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEiamRegions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEiamRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询EIAM2.0/EIAM1.0地域列表
         *
         * @return ListEiamRegionsResponse
         */
        public ListEiamRegionsResponse ListEiamRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEiamRegionsWithOptions(runtime);
        }

        /**
         * @summary 查询EIAM2.0/EIAM1.0地域列表
         *
         * @return ListEiamRegionsResponse
         */
        public async Task<ListEiamRegionsResponse> ListEiamRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEiamRegionsWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries a list of account groups in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request ListGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsResponse
         */
        public ListGroupsResponse ListGroupsWithOptions(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupExternalId))
            {
                query["GroupExternalId"] = request.GroupExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNameStartsWith))
            {
                query["GroupNameStartsWith"] = request.GroupNameStartsWith;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListGroups",
                Version = "2021-12-01",
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

        /**
         * @summary Queries a list of account groups in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request ListGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsResponse
         */
        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupExternalId))
            {
                query["GroupExternalId"] = request.GroupExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNameStartsWith))
            {
                query["GroupNameStartsWith"] = request.GroupNameStartsWith;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListGroups",
                Version = "2021-12-01",
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

        /**
         * @summary Queries a list of account groups in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request ListGroupsRequest
         * @return ListGroupsResponse
         */
        public ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of account groups in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request ListGroupsRequest
         * @return ListGroupsResponse
         */
        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of account groups to which the permissions to access an application are granted. The returned results contain the group IDs. You can call the GetGroup operation to query the information about an account group based on the group ID.
         *
         * @param request ListGroupsForApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsForApplicationResponse
         */
        public ListGroupsForApplicationResponse ListGroupsForApplicationWithOptions(ListGroupsForApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListGroupsForApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsForApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of account groups to which the permissions to access an application are granted. The returned results contain the group IDs. You can call the GetGroup operation to query the information about an account group based on the group ID.
         *
         * @param request ListGroupsForApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsForApplicationResponse
         */
        public async Task<ListGroupsForApplicationResponse> ListGroupsForApplicationWithOptionsAsync(ListGroupsForApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListGroupsForApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsForApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of account groups to which the permissions to access an application are granted. The returned results contain the group IDs. You can call the GetGroup operation to query the information about an account group based on the group ID.
         *
         * @param request ListGroupsForApplicationRequest
         * @return ListGroupsForApplicationResponse
         */
        public ListGroupsForApplicationResponse ListGroupsForApplication(ListGroupsForApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupsForApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of account groups to which the permissions to access an application are granted. The returned results contain the group IDs. You can call the GetGroup operation to query the information about an account group based on the group ID.
         *
         * @param request ListGroupsForApplicationRequest
         * @return ListGroupsForApplicationResponse
         */
        public async Task<ListGroupsForApplicationResponse> ListGroupsForApplicationAsync(ListGroupsForApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupsForApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of account groups to which an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS) belongs.
         *
         * @param request ListGroupsForUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsForUserResponse
         */
        public ListGroupsForUserResponse ListGroupsForUserWithOptions(ListGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListGroupsForUser",
                Version = "2021-12-01",
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

        /**
         * @summary Queries a list of account groups to which an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS) belongs.
         *
         * @param request ListGroupsForUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsForUserResponse
         */
        public async Task<ListGroupsForUserResponse> ListGroupsForUserWithOptionsAsync(ListGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListGroupsForUser",
                Version = "2021-12-01",
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

        /**
         * @summary Queries a list of account groups to which an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS) belongs.
         *
         * @param request ListGroupsForUserRequest
         * @return ListGroupsForUserResponse
         */
        public ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupsForUserWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of account groups to which an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS) belongs.
         *
         * @param request ListGroupsForUserRequest
         * @return ListGroupsForUserResponse
         */
        public async Task<ListGroupsForUserResponse> ListGroupsForUserAsync(ListGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupsForUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of one or more Enterprise Identity and Access Management (EIAM) instances of Identity as a Service (IDaaS).
         *
         * @param request ListInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListInstances",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of one or more Enterprise Identity and Access Management (EIAM) instances of Identity as a Service (IDaaS).
         *
         * @param request ListInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListInstances",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of one or more Enterprise Identity and Access Management (EIAM) instances of Identity as a Service (IDaaS).
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of one or more Enterprise Identity and Access Management (EIAM) instances of Identity as a Service (IDaaS).
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取支持专属端点的region列表
         *
         * @param request ListNetworkAccessEndpointAvailableRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkAccessEndpointAvailableRegionsResponse
         */
        public ListNetworkAccessEndpointAvailableRegionsResponse ListNetworkAccessEndpointAvailableRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkAccessEndpointAvailableRegions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkAccessEndpointAvailableRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取支持专属端点的region列表
         *
         * @param request ListNetworkAccessEndpointAvailableRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkAccessEndpointAvailableRegionsResponse
         */
        public async Task<ListNetworkAccessEndpointAvailableRegionsResponse> ListNetworkAccessEndpointAvailableRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkAccessEndpointAvailableRegions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkAccessEndpointAvailableRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取支持专属端点的region列表
         *
         * @return ListNetworkAccessEndpointAvailableRegionsResponse
         */
        public ListNetworkAccessEndpointAvailableRegionsResponse ListNetworkAccessEndpointAvailableRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNetworkAccessEndpointAvailableRegionsWithOptions(runtime);
        }

        /**
         * @summary 获取支持专属端点的region列表
         *
         * @return ListNetworkAccessEndpointAvailableRegionsResponse
         */
        public async Task<ListNetworkAccessEndpointAvailableRegionsResponse> ListNetworkAccessEndpointAvailableRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNetworkAccessEndpointAvailableRegionsWithOptionsAsync(runtime);
        }

        /**
         * @summary 获取支持NAE的可用区列表
         *
         * @param request ListNetworkAccessEndpointAvailableZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkAccessEndpointAvailableZonesResponse
         */
        public ListNetworkAccessEndpointAvailableZonesResponse ListNetworkAccessEndpointAvailableZonesWithOptions(ListNetworkAccessEndpointAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NaeRegionId))
            {
                query["NaeRegionId"] = request.NaeRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkAccessEndpointAvailableZones",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkAccessEndpointAvailableZonesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取支持NAE的可用区列表
         *
         * @param request ListNetworkAccessEndpointAvailableZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkAccessEndpointAvailableZonesResponse
         */
        public async Task<ListNetworkAccessEndpointAvailableZonesResponse> ListNetworkAccessEndpointAvailableZonesWithOptionsAsync(ListNetworkAccessEndpointAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NaeRegionId))
            {
                query["NaeRegionId"] = request.NaeRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkAccessEndpointAvailableZones",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkAccessEndpointAvailableZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取支持NAE的可用区列表
         *
         * @param request ListNetworkAccessEndpointAvailableZonesRequest
         * @return ListNetworkAccessEndpointAvailableZonesResponse
         */
        public ListNetworkAccessEndpointAvailableZonesResponse ListNetworkAccessEndpointAvailableZones(ListNetworkAccessEndpointAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNetworkAccessEndpointAvailableZonesWithOptions(request, runtime);
        }

        /**
         * @summary 获取支持NAE的可用区列表
         *
         * @param request ListNetworkAccessEndpointAvailableZonesRequest
         * @return ListNetworkAccessEndpointAvailableZonesResponse
         */
        public async Task<ListNetworkAccessEndpointAvailableZonesResponse> ListNetworkAccessEndpointAvailableZonesAsync(ListNetworkAccessEndpointAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNetworkAccessEndpointAvailableZonesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列表查询专属网络端点。
         *
         * @param request ListNetworkAccessEndpointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkAccessEndpointsResponse
         */
        public ListNetworkAccessEndpointsResponse ListNetworkAccessEndpointsWithOptions(ListNetworkAccessEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointStatus))
            {
                query["NetworkAccessEndpointStatus"] = request.NetworkAccessEndpointStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointType))
            {
                query["NetworkAccessEndpointType"] = request.NetworkAccessEndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                query["VpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkAccessEndpoints",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkAccessEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列表查询专属网络端点。
         *
         * @param request ListNetworkAccessEndpointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkAccessEndpointsResponse
         */
        public async Task<ListNetworkAccessEndpointsResponse> ListNetworkAccessEndpointsWithOptionsAsync(ListNetworkAccessEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointStatus))
            {
                query["NetworkAccessEndpointStatus"] = request.NetworkAccessEndpointStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointType))
            {
                query["NetworkAccessEndpointType"] = request.NetworkAccessEndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegionId))
            {
                query["VpcRegionId"] = request.VpcRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkAccessEndpoints",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkAccessEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列表查询专属网络端点。
         *
         * @param request ListNetworkAccessEndpointsRequest
         * @return ListNetworkAccessEndpointsResponse
         */
        public ListNetworkAccessEndpointsResponse ListNetworkAccessEndpoints(ListNetworkAccessEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNetworkAccessEndpointsWithOptions(request, runtime);
        }

        /**
         * @summary 列表查询专属网络端点。
         *
         * @param request ListNetworkAccessEndpointsRequest
         * @return ListNetworkAccessEndpointsResponse
         */
        public async Task<ListNetworkAccessEndpointsResponse> ListNetworkAccessEndpointsAsync(ListNetworkAccessEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNetworkAccessEndpointsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列表某个网络访问端点下的访问路径。
         *
         * @param request ListNetworkAccessPathsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkAccessPathsResponse
         */
        public ListNetworkAccessPathsResponse ListNetworkAccessPathsWithOptions(ListNetworkAccessPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointId))
            {
                query["NetworkAccessEndpointId"] = request.NetworkAccessEndpointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkAccessPaths",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkAccessPathsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列表某个网络访问端点下的访问路径。
         *
         * @param request ListNetworkAccessPathsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkAccessPathsResponse
         */
        public async Task<ListNetworkAccessPathsResponse> ListNetworkAccessPathsWithOptionsAsync(ListNetworkAccessPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointId))
            {
                query["NetworkAccessEndpointId"] = request.NetworkAccessEndpointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkAccessPaths",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNetworkAccessPathsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列表某个网络访问端点下的访问路径。
         *
         * @param request ListNetworkAccessPathsRequest
         * @return ListNetworkAccessPathsResponse
         */
        public ListNetworkAccessPathsResponse ListNetworkAccessPaths(ListNetworkAccessPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNetworkAccessPathsWithOptions(request, runtime);
        }

        /**
         * @summary 列表某个网络访问端点下的访问路径。
         *
         * @param request ListNetworkAccessPathsRequest
         * @return ListNetworkAccessPathsResponse
         */
        public async Task<ListNetworkAccessPathsResponse> ListNetworkAccessPathsAsync(ListNetworkAccessPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNetworkAccessPathsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询组织的所有父级路径
         *
         * @param request ListOrganizationalUnitParentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationalUnitParentsResponse
         */
        public ListOrganizationalUnitParentsResponse ListOrganizationalUnitParentsWithOptions(ListOrganizationalUnitParentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationalUnitParents",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitParentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询组织的所有父级路径
         *
         * @param request ListOrganizationalUnitParentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationalUnitParentsResponse
         */
        public async Task<ListOrganizationalUnitParentsResponse> ListOrganizationalUnitParentsWithOptionsAsync(ListOrganizationalUnitParentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationalUnitParents",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitParentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询组织的所有父级路径
         *
         * @param request ListOrganizationalUnitParentsRequest
         * @return ListOrganizationalUnitParentsResponse
         */
        public ListOrganizationalUnitParentsResponse ListOrganizationalUnitParents(ListOrganizationalUnitParentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrganizationalUnitParentsWithOptions(request, runtime);
        }

        /**
         * @summary 查询组织的所有父级路径
         *
         * @param request ListOrganizationalUnitParentsRequest
         * @return ListOrganizationalUnitParentsResponse
         */
        public async Task<ListOrganizationalUnitParentsResponse> ListOrganizationalUnitParentsAsync(ListOrganizationalUnitParentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrganizationalUnitParentsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about organizational units in Identity as a Service (IDaaS) Employee IAM (EIAM) by page.
         *
         * @param request ListOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationalUnitsResponse
         */
        public ListOrganizationalUnitsResponse ListOrganizationalUnitsWithOptions(ListOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                query["OrganizationalUnitName"] = request.OrganizationalUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitNameStartsWith))
            {
                query["OrganizationalUnitNameStartsWith"] = request.OrganizationalUnitNameStartsWith;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about organizational units in Identity as a Service (IDaaS) Employee IAM (EIAM) by page.
         *
         * @param request ListOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationalUnitsResponse
         */
        public async Task<ListOrganizationalUnitsResponse> ListOrganizationalUnitsWithOptionsAsync(ListOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                query["OrganizationalUnitName"] = request.OrganizationalUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitNameStartsWith))
            {
                query["OrganizationalUnitNameStartsWith"] = request.OrganizationalUnitNameStartsWith;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about organizational units in Identity as a Service (IDaaS) Employee IAM (EIAM) by page.
         *
         * @param request ListOrganizationalUnitsRequest
         * @return ListOrganizationalUnitsResponse
         */
        public ListOrganizationalUnitsResponse ListOrganizationalUnits(ListOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrganizationalUnitsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about organizational units in Identity as a Service (IDaaS) Employee IAM (EIAM) by page.
         *
         * @param request ListOrganizationalUnitsRequest
         * @return ListOrganizationalUnitsResponse
         */
        public async Task<ListOrganizationalUnitsResponse> ListOrganizationalUnitsAsync(ListOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrganizationalUnitsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the organizations that are allowed to access an Employee Identity and Access Management (EIAM) application by page. The return result includes the IDs of the organizations. If you want to obtain the details of the organizations, call the GetOrganizationalUnit operation.
         *
         * @param request ListOrganizationalUnitsForApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationalUnitsForApplicationResponse
         */
        public ListOrganizationalUnitsForApplicationResponse ListOrganizationalUnitsForApplicationWithOptions(ListOrganizationalUnitsForApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "ListOrganizationalUnitsForApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitsForApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the organizations that are allowed to access an Employee Identity and Access Management (EIAM) application by page. The return result includes the IDs of the organizations. If you want to obtain the details of the organizations, call the GetOrganizationalUnit operation.
         *
         * @param request ListOrganizationalUnitsForApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrganizationalUnitsForApplicationResponse
         */
        public async Task<ListOrganizationalUnitsForApplicationResponse> ListOrganizationalUnitsForApplicationWithOptionsAsync(ListOrganizationalUnitsForApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "ListOrganizationalUnitsForApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitsForApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the organizations that are allowed to access an Employee Identity and Access Management (EIAM) application by page. The return result includes the IDs of the organizations. If you want to obtain the details of the organizations, call the GetOrganizationalUnit operation.
         *
         * @param request ListOrganizationalUnitsForApplicationRequest
         * @return ListOrganizationalUnitsForApplicationResponse
         */
        public ListOrganizationalUnitsForApplicationResponse ListOrganizationalUnitsForApplication(ListOrganizationalUnitsForApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrganizationalUnitsForApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the organizations that are allowed to access an Employee Identity and Access Management (EIAM) application by page. The return result includes the IDs of the organizations. If you want to obtain the details of the organizations, call the GetOrganizationalUnit operation.
         *
         * @param request ListOrganizationalUnitsForApplicationRequest
         * @return ListOrganizationalUnitsForApplicationResponse
         */
        public async Task<ListOrganizationalUnitsForApplicationResponse> ListOrganizationalUnitsForApplicationAsync(ListOrganizationalUnitsForApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrganizationalUnitsForApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the supported Alibaba Cloud regions.
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the supported Alibaba Cloud regions.
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the supported Alibaba Cloud regions.
         *
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(runtime);
        }

        /**
         * @summary Queries the supported Alibaba Cloud regions.
         *
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the details of accounts in Identity as a Service (IDaaS) Employee IAM (EIAM) by page.
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayNameStartsWith))
            {
                query["DisplayNameStartsWith"] = request.DisplayNameStartsWith;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                query["PhoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExternalId))
            {
                query["UserExternalId"] = request.UserExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceId))
            {
                query["UserSourceId"] = request.UserSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceType))
            {
                query["UserSourceType"] = request.UserSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsernameStartsWith))
            {
                query["UsernameStartsWith"] = request.UsernameStartsWith;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2021-12-01",
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
         * @summary Queries the details of accounts in Identity as a Service (IDaaS) Employee IAM (EIAM) by page.
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayNameStartsWith))
            {
                query["DisplayNameStartsWith"] = request.DisplayNameStartsWith;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                query["PhoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExternalId))
            {
                query["UserExternalId"] = request.UserExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["UserIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceId))
            {
                query["UserSourceId"] = request.UserSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceType))
            {
                query["UserSourceType"] = request.UserSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsernameStartsWith))
            {
                query["UsernameStartsWith"] = request.UsernameStartsWith;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2021-12-01",
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
         * @summary Queries the details of accounts in Identity as a Service (IDaaS) Employee IAM (EIAM) by page.
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
         * @summary Queries the details of accounts in Identity as a Service (IDaaS) Employee IAM (EIAM) by page.
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
         * @summary Queries the accounts that are allowed to access an Employee Identity and Access Management (EIAM) application. The return results include the IDs of the accounts. If you need to obtain the details of the accounts, call the GetUser operation.
         *
         * @param request ListUsersForApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersForApplicationResponse
         */
        public ListUsersForApplicationResponse ListUsersForApplicationWithOptions(ListUsersForApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListUsersForApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersForApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the accounts that are allowed to access an Employee Identity and Access Management (EIAM) application. The return results include the IDs of the accounts. If you need to obtain the details of the accounts, call the GetUser operation.
         *
         * @param request ListUsersForApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersForApplicationResponse
         */
        public async Task<ListUsersForApplicationResponse> ListUsersForApplicationWithOptionsAsync(ListUsersForApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListUsersForApplication",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersForApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the accounts that are allowed to access an Employee Identity and Access Management (EIAM) application. The return results include the IDs of the accounts. If you need to obtain the details of the accounts, call the GetUser operation.
         *
         * @param request ListUsersForApplicationRequest
         * @return ListUsersForApplicationResponse
         */
        public ListUsersForApplicationResponse ListUsersForApplication(ListUsersForApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersForApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the accounts that are allowed to access an Employee Identity and Access Management (EIAM) application. The return results include the IDs of the accounts. If you need to obtain the details of the accounts, call the GetUser operation.
         *
         * @param request ListUsersForApplicationRequest
         * @return ListUsersForApplicationResponse
         */
        public async Task<ListUsersForApplicationResponse> ListUsersForApplicationAsync(ListUsersForApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersForApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of accounts in an Employee Identity and Access Management (EIAM) group of Identity as a Service (IDaaS).
         *
         * @param request ListUsersForGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersForGroupResponse
         */
        public ListUsersForGroupResponse ListUsersForGroupWithOptions(ListUsersForGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListUsersForGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the information of accounts in an Employee Identity and Access Management (EIAM) group of Identity as a Service (IDaaS).
         *
         * @param request ListUsersForGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersForGroupResponse
         */
        public async Task<ListUsersForGroupResponse> ListUsersForGroupWithOptionsAsync(ListUsersForGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListUsersForGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Queries the information of accounts in an Employee Identity and Access Management (EIAM) group of Identity as a Service (IDaaS).
         *
         * @param request ListUsersForGroupRequest
         * @return ListUsersForGroupResponse
         */
        public ListUsersForGroupResponse ListUsersForGroup(ListUsersForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersForGroupWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of accounts in an Employee Identity and Access Management (EIAM) group of Identity as a Service (IDaaS).
         *
         * @param request ListUsersForGroupRequest
         * @return ListUsersForGroupResponse
         */
        public async Task<ListUsersForGroupResponse> ListUsersForGroupAsync(ListUsersForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersForGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a client key of an Employee Identity and Access Management (EIAM) application. The returned key secret is masked. If you want to query the key secret that is not masked, call the ListApplicationClientSecrets operation.
         *
         * @param request ObtainApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ObtainApplicationClientSecretResponse
         */
        public ObtainApplicationClientSecretResponse ObtainApplicationClientSecretWithOptions(ObtainApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ObtainApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ObtainApplicationClientSecretResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a client key of an Employee Identity and Access Management (EIAM) application. The returned key secret is masked. If you want to query the key secret that is not masked, call the ListApplicationClientSecrets operation.
         *
         * @param request ObtainApplicationClientSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ObtainApplicationClientSecretResponse
         */
        public async Task<ObtainApplicationClientSecretResponse> ObtainApplicationClientSecretWithOptionsAsync(ObtainApplicationClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ObtainApplicationClientSecret",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ObtainApplicationClientSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a client key of an Employee Identity and Access Management (EIAM) application. The returned key secret is masked. If you want to query the key secret that is not masked, call the ListApplicationClientSecrets operation.
         *
         * @param request ObtainApplicationClientSecretRequest
         * @return ObtainApplicationClientSecretResponse
         */
        public ObtainApplicationClientSecretResponse ObtainApplicationClientSecret(ObtainApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ObtainApplicationClientSecretWithOptions(request, runtime);
        }

        /**
         * @summary Queries a client key of an Employee Identity and Access Management (EIAM) application. The returned key secret is masked. If you want to query the key secret that is not masked, call the ListApplicationClientSecrets operation.
         *
         * @param request ObtainApplicationClientSecretRequest
         * @return ObtainApplicationClientSecretResponse
         */
        public async Task<ObtainApplicationClientSecretResponse> ObtainApplicationClientSecretAsync(ObtainApplicationClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ObtainApplicationClientSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看指定域名安全代理Token。
         *
         * @param request ObtainDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ObtainDomainProxyTokenResponse
         */
        public ObtainDomainProxyTokenResponse ObtainDomainProxyTokenWithOptions(ObtainDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainProxyTokenId))
            {
                query["DomainProxyTokenId"] = request.DomainProxyTokenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ObtainDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ObtainDomainProxyTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看指定域名安全代理Token。
         *
         * @param request ObtainDomainProxyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ObtainDomainProxyTokenResponse
         */
        public async Task<ObtainDomainProxyTokenResponse> ObtainDomainProxyTokenWithOptionsAsync(ObtainDomainProxyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainProxyTokenId))
            {
                query["DomainProxyTokenId"] = request.DomainProxyTokenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ObtainDomainProxyToken",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ObtainDomainProxyTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看指定域名安全代理Token。
         *
         * @param request ObtainDomainProxyTokenRequest
         * @return ObtainDomainProxyTokenResponse
         */
        public ObtainDomainProxyTokenResponse ObtainDomainProxyToken(ObtainDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ObtainDomainProxyTokenWithOptions(request, runtime);
        }

        /**
         * @summary 查看指定域名安全代理Token。
         *
         * @param request ObtainDomainProxyTokenRequest
         * @return ObtainDomainProxyTokenResponse
         */
        public async Task<ObtainDomainProxyTokenResponse> ObtainDomainProxyTokenAsync(ObtainDomainProxyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ObtainDomainProxyTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes an Employee Identity and Access Management (EIAM) account from multiple EIAM organizations of Identity as a Service (IDaaS). You cannot remove an account from a primary organization.
         *
         * @param request RemoveUserFromOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUserFromOrganizationalUnitsResponse
         */
        public RemoveUserFromOrganizationalUnitsResponse RemoveUserFromOrganizationalUnitsWithOptions(RemoveUserFromOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "RemoveUserFromOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromOrganizationalUnitsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes an Employee Identity and Access Management (EIAM) account from multiple EIAM organizations of Identity as a Service (IDaaS). You cannot remove an account from a primary organization.
         *
         * @param request RemoveUserFromOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUserFromOrganizationalUnitsResponse
         */
        public async Task<RemoveUserFromOrganizationalUnitsResponse> RemoveUserFromOrganizationalUnitsWithOptionsAsync(RemoveUserFromOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "RemoveUserFromOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromOrganizationalUnitsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes an Employee Identity and Access Management (EIAM) account from multiple EIAM organizations of Identity as a Service (IDaaS). You cannot remove an account from a primary organization.
         *
         * @param request RemoveUserFromOrganizationalUnitsRequest
         * @return RemoveUserFromOrganizationalUnitsResponse
         */
        public RemoveUserFromOrganizationalUnitsResponse RemoveUserFromOrganizationalUnits(RemoveUserFromOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUserFromOrganizationalUnitsWithOptions(request, runtime);
        }

        /**
         * @summary Removes an Employee Identity and Access Management (EIAM) account from multiple EIAM organizations of Identity as a Service (IDaaS). You cannot remove an account from a primary organization.
         *
         * @param request RemoveUserFromOrganizationalUnitsRequest
         * @return RemoveUserFromOrganizationalUnitsResponse
         */
        public async Task<RemoveUserFromOrganizationalUnitsResponse> RemoveUserFromOrganizationalUnitsAsync(RemoveUserFromOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUserFromOrganizationalUnitsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes Employee Identity and Access Management (EIAM) accounts from an EIAM group of Identity as a Service (IDaaS).
         *
         * @param request RemoveUsersFromGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUsersFromGroupResponse
         */
        public RemoveUsersFromGroupResponse RemoveUsersFromGroupWithOptions(RemoveUsersFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "RemoveUsersFromGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersFromGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes Employee Identity and Access Management (EIAM) accounts from an EIAM group of Identity as a Service (IDaaS).
         *
         * @param request RemoveUsersFromGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUsersFromGroupResponse
         */
        public async Task<RemoveUsersFromGroupResponse> RemoveUsersFromGroupWithOptionsAsync(RemoveUsersFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "RemoveUsersFromGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersFromGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes Employee Identity and Access Management (EIAM) accounts from an EIAM group of Identity as a Service (IDaaS).
         *
         * @param request RemoveUsersFromGroupRequest
         * @return RemoveUsersFromGroupResponse
         */
        public RemoveUsersFromGroupResponse RemoveUsersFromGroup(RemoveUsersFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUsersFromGroupWithOptions(request, runtime);
        }

        /**
         * @summary Removes Employee Identity and Access Management (EIAM) accounts from an EIAM group of Identity as a Service (IDaaS).
         *
         * @param request RemoveUsersFromGroupRequest
         * @return RemoveUsersFromGroupResponse
         */
        public async Task<RemoveUsersFromGroupResponse> RemoveUsersFromGroupAsync(RemoveUsersFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUsersFromGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Revokes the permissions to access an application from multiple account groups at a time in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request RevokeApplicationFromGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeApplicationFromGroupsResponse
         */
        public RevokeApplicationFromGroupsResponse RevokeApplicationFromGroupsWithOptions(RevokeApplicationFromGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeApplicationFromGroups",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeApplicationFromGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Revokes the permissions to access an application from multiple account groups at a time in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request RevokeApplicationFromGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeApplicationFromGroupsResponse
         */
        public async Task<RevokeApplicationFromGroupsResponse> RevokeApplicationFromGroupsWithOptionsAsync(RevokeApplicationFromGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeApplicationFromGroups",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeApplicationFromGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Revokes the permissions to access an application from multiple account groups at a time in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request RevokeApplicationFromGroupsRequest
         * @return RevokeApplicationFromGroupsResponse
         */
        public RevokeApplicationFromGroupsResponse RevokeApplicationFromGroups(RevokeApplicationFromGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeApplicationFromGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Revokes the permissions to access an application from multiple account groups at a time in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM).
         *
         * @param request RevokeApplicationFromGroupsRequest
         * @return RevokeApplicationFromGroupsResponse
         */
        public async Task<RevokeApplicationFromGroupsResponse> RevokeApplicationFromGroupsAsync(RevokeApplicationFromGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeApplicationFromGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Revokes the permissions to access an application from multiple Employee Identity and Access Management (EIAM) organizations at a time.
         *
         * @param request RevokeApplicationFromOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeApplicationFromOrganizationalUnitsResponse
         */
        public RevokeApplicationFromOrganizationalUnitsResponse RevokeApplicationFromOrganizationalUnitsWithOptions(RevokeApplicationFromOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeApplicationFromOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeApplicationFromOrganizationalUnitsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Revokes the permissions to access an application from multiple Employee Identity and Access Management (EIAM) organizations at a time.
         *
         * @param request RevokeApplicationFromOrganizationalUnitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeApplicationFromOrganizationalUnitsResponse
         */
        public async Task<RevokeApplicationFromOrganizationalUnitsResponse> RevokeApplicationFromOrganizationalUnitsWithOptionsAsync(RevokeApplicationFromOrganizationalUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeApplicationFromOrganizationalUnits",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeApplicationFromOrganizationalUnitsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Revokes the permissions to access an application from multiple Employee Identity and Access Management (EIAM) organizations at a time.
         *
         * @param request RevokeApplicationFromOrganizationalUnitsRequest
         * @return RevokeApplicationFromOrganizationalUnitsResponse
         */
        public RevokeApplicationFromOrganizationalUnitsResponse RevokeApplicationFromOrganizationalUnits(RevokeApplicationFromOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeApplicationFromOrganizationalUnitsWithOptions(request, runtime);
        }

        /**
         * @summary Revokes the permissions to access an application from multiple Employee Identity and Access Management (EIAM) organizations at a time.
         *
         * @param request RevokeApplicationFromOrganizationalUnitsRequest
         * @return RevokeApplicationFromOrganizationalUnitsResponse
         */
        public async Task<RevokeApplicationFromOrganizationalUnitsResponse> RevokeApplicationFromOrganizationalUnitsAsync(RevokeApplicationFromOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeApplicationFromOrganizationalUnitsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Revokes the permissions to access an application from multiple Employee Identity and Access Management (EIAM) accounts at a time.
         *
         * @param request RevokeApplicationFromUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeApplicationFromUsersResponse
         */
        public RevokeApplicationFromUsersResponse RevokeApplicationFromUsersWithOptions(RevokeApplicationFromUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "RevokeApplicationFromUsers",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeApplicationFromUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Revokes the permissions to access an application from multiple Employee Identity and Access Management (EIAM) accounts at a time.
         *
         * @param request RevokeApplicationFromUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeApplicationFromUsersResponse
         */
        public async Task<RevokeApplicationFromUsersResponse> RevokeApplicationFromUsersWithOptionsAsync(RevokeApplicationFromUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "RevokeApplicationFromUsers",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeApplicationFromUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Revokes the permissions to access an application from multiple Employee Identity and Access Management (EIAM) accounts at a time.
         *
         * @param request RevokeApplicationFromUsersRequest
         * @return RevokeApplicationFromUsersResponse
         */
        public RevokeApplicationFromUsersResponse RevokeApplicationFromUsers(RevokeApplicationFromUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeApplicationFromUsersWithOptions(request, runtime);
        }

        /**
         * @summary Revokes the permissions to access an application from multiple Employee Identity and Access Management (EIAM) accounts at a time.
         *
         * @param request RevokeApplicationFromUsersRequest
         * @return RevokeApplicationFromUsersResponse
         */
        public async Task<RevokeApplicationFromUsersResponse> RevokeApplicationFromUsersAsync(RevokeApplicationFromUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeApplicationFromUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Configures the permissions of the Developer API feature of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request SetApplicationGrantScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetApplicationGrantScopeResponse
         */
        public SetApplicationGrantScopeResponse SetApplicationGrantScopeWithOptions(SetApplicationGrantScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantScopes))
            {
                query["GrantScopes"] = request.GrantScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApplicationGrantScope",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApplicationGrantScopeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Configures the permissions of the Developer API feature of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request SetApplicationGrantScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetApplicationGrantScopeResponse
         */
        public async Task<SetApplicationGrantScopeResponse> SetApplicationGrantScopeWithOptionsAsync(SetApplicationGrantScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantScopes))
            {
                query["GrantScopes"] = request.GrantScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApplicationGrantScope",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApplicationGrantScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Configures the permissions of the Developer API feature of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request SetApplicationGrantScopeRequest
         * @return SetApplicationGrantScopeResponse
         */
        public SetApplicationGrantScopeResponse SetApplicationGrantScope(SetApplicationGrantScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetApplicationGrantScopeWithOptions(request, runtime);
        }

        /**
         * @summary Configures the permissions of the Developer API feature of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request SetApplicationGrantScopeRequest
         * @return SetApplicationGrantScopeResponse
         */
        public async Task<SetApplicationGrantScopeResponse> SetApplicationGrantScopeAsync(SetApplicationGrantScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetApplicationGrantScopeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Configures the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request SetApplicationProvisioningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetApplicationProvisioningConfigResponse
         */
        public SetApplicationProvisioningConfigResponse SetApplicationProvisioningConfigWithOptions(SetApplicationProvisioningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackProvisioningConfig))
            {
                query["CallbackProvisioningConfig"] = request.CallbackProvisioningConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionPassword))
            {
                query["ProvisionPassword"] = request.ProvisionPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionProtocolType))
            {
                query["ProvisionProtocolType"] = request.ProvisionProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScimProvisioningConfig))
            {
                query["ScimProvisioningConfig"] = request.ScimProvisioningConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApplicationProvisioningConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApplicationProvisioningConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Configures the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request SetApplicationProvisioningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetApplicationProvisioningConfigResponse
         */
        public async Task<SetApplicationProvisioningConfigResponse> SetApplicationProvisioningConfigWithOptionsAsync(SetApplicationProvisioningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackProvisioningConfig))
            {
                query["CallbackProvisioningConfig"] = request.CallbackProvisioningConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionPassword))
            {
                query["ProvisionPassword"] = request.ProvisionPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionProtocolType))
            {
                query["ProvisionProtocolType"] = request.ProvisionProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScimProvisioningConfig))
            {
                query["ScimProvisioningConfig"] = request.ScimProvisioningConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApplicationProvisioningConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApplicationProvisioningConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Configures the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request SetApplicationProvisioningConfigRequest
         * @return SetApplicationProvisioningConfigResponse
         */
        public SetApplicationProvisioningConfigResponse SetApplicationProvisioningConfig(SetApplicationProvisioningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetApplicationProvisioningConfigWithOptions(request, runtime);
        }

        /**
         * @summary Configures the account synchronization feature for an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @param request SetApplicationProvisioningConfigRequest
         * @return SetApplicationProvisioningConfigResponse
         */
        public async Task<SetApplicationProvisioningConfigResponse> SetApplicationProvisioningConfigAsync(SetApplicationProvisioningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetApplicationProvisioningConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets the account synchronization scope of applications in Identity as a Service (IDaaS) Employee IAM (EIAM). This scope is the same as the scope within which developers can call the DeveloperAPI to query and manage accounts.
         *
         * @param request SetApplicationProvisioningScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetApplicationProvisioningScopeResponse
         */
        public SetApplicationProvisioningScopeResponse SetApplicationProvisioningScopeWithOptions(SetApplicationProvisioningScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApplicationProvisioningScope",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApplicationProvisioningScopeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sets the account synchronization scope of applications in Identity as a Service (IDaaS) Employee IAM (EIAM). This scope is the same as the scope within which developers can call the DeveloperAPI to query and manage accounts.
         *
         * @param request SetApplicationProvisioningScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetApplicationProvisioningScopeResponse
         */
        public async Task<SetApplicationProvisioningScopeResponse> SetApplicationProvisioningScopeWithOptionsAsync(SetApplicationProvisioningScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                query["OrganizationalUnitIds"] = request.OrganizationalUnitIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApplicationProvisioningScope",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApplicationProvisioningScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sets the account synchronization scope of applications in Identity as a Service (IDaaS) Employee IAM (EIAM). This scope is the same as the scope within which developers can call the DeveloperAPI to query and manage accounts.
         *
         * @param request SetApplicationProvisioningScopeRequest
         * @return SetApplicationProvisioningScopeResponse
         */
        public SetApplicationProvisioningScopeResponse SetApplicationProvisioningScope(SetApplicationProvisioningScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetApplicationProvisioningScopeWithOptions(request, runtime);
        }

        /**
         * @summary Sets the account synchronization scope of applications in Identity as a Service (IDaaS) Employee IAM (EIAM). This scope is the same as the scope within which developers can call the DeveloperAPI to query and manage accounts.
         *
         * @param request SetApplicationProvisioningScopeRequest
         * @return SetApplicationProvisioningScopeResponse
         */
        public async Task<SetApplicationProvisioningScopeResponse> SetApplicationProvisioningScopeAsync(SetApplicationProvisioningScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetApplicationProvisioningScopeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Specifies the single sign-on (SSO) configuration attributes of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @description In IDaaS EIAM, the application management feature supports multiple SSO protocols for applications, including SAML 2.0 and OIDC protocols. Each application supports only one protocol, and the protocol cannot be changed after the application is created. You can specify the SSO configuration attributes of an application based on the supported SSO protocol.
         *
         * @param request SetApplicationSsoConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetApplicationSsoConfigResponse
         */
        public SetApplicationSsoConfigResponse SetApplicationSsoConfigWithOptions(SetApplicationSsoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitLoginType))
            {
                query["InitLoginType"] = request.InitLoginType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitLoginUrl))
            {
                query["InitLoginUrl"] = request.InitLoginUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OidcSsoConfig))
            {
                query["OidcSsoConfig"] = request.OidcSsoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamlSsoConfig))
            {
                query["SamlSsoConfig"] = request.SamlSsoConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApplicationSsoConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApplicationSsoConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Specifies the single sign-on (SSO) configuration attributes of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @description In IDaaS EIAM, the application management feature supports multiple SSO protocols for applications, including SAML 2.0 and OIDC protocols. Each application supports only one protocol, and the protocol cannot be changed after the application is created. You can specify the SSO configuration attributes of an application based on the supported SSO protocol.
         *
         * @param request SetApplicationSsoConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetApplicationSsoConfigResponse
         */
        public async Task<SetApplicationSsoConfigResponse> SetApplicationSsoConfigWithOptionsAsync(SetApplicationSsoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitLoginType))
            {
                query["InitLoginType"] = request.InitLoginType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitLoginUrl))
            {
                query["InitLoginUrl"] = request.InitLoginUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OidcSsoConfig))
            {
                query["OidcSsoConfig"] = request.OidcSsoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamlSsoConfig))
            {
                query["SamlSsoConfig"] = request.SamlSsoConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApplicationSsoConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApplicationSsoConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Specifies the single sign-on (SSO) configuration attributes of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @description In IDaaS EIAM, the application management feature supports multiple SSO protocols for applications, including SAML 2.0 and OIDC protocols. Each application supports only one protocol, and the protocol cannot be changed after the application is created. You can specify the SSO configuration attributes of an application based on the supported SSO protocol.
         *
         * @param request SetApplicationSsoConfigRequest
         * @return SetApplicationSsoConfigResponse
         */
        public SetApplicationSsoConfigResponse SetApplicationSsoConfig(SetApplicationSsoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetApplicationSsoConfigWithOptions(request, runtime);
        }

        /**
         * @summary Specifies the single sign-on (SSO) configuration attributes of an application in Identity as a Service (IDaaS) Employee IAM (EIAM).
         *
         * @description In IDaaS EIAM, the application management feature supports multiple SSO protocols for applications, including SAML 2.0 and OIDC protocols. Each application supports only one protocol, and the protocol cannot be changed after the application is created. You can specify the SSO configuration attributes of an application based on the supported SSO protocol.
         *
         * @param request SetApplicationSsoConfigRequest
         * @return SetApplicationSsoConfigResponse
         */
        public async Task<SetApplicationSsoConfigResponse> SetApplicationSsoConfigAsync(SetApplicationSsoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetApplicationSsoConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置默认域名。
         *
         * @param request SetDefaultDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultDomainResponse
         */
        public SetDefaultDomainResponse SetDefaultDomainWithOptions(SetDefaultDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultDomain",
                Version = "2021-12-01",
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

        /**
         * @summary 设置默认域名。
         *
         * @param request SetDefaultDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultDomainResponse
         */
        public async Task<SetDefaultDomainResponse> SetDefaultDomainWithOptionsAsync(SetDefaultDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultDomain",
                Version = "2021-12-01",
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

        /**
         * @summary 设置默认域名。
         *
         * @param request SetDefaultDomainRequest
         * @return SetDefaultDomainResponse
         */
        public SetDefaultDomainResponse SetDefaultDomain(SetDefaultDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultDomainWithOptions(request, runtime);
        }

        /**
         * @summary 设置默认域名。
         *
         * @param request SetDefaultDomainRequest
         * @return SetDefaultDomainResponse
         */
        public async Task<SetDefaultDomainResponse> SetDefaultDomainAsync(SetDefaultDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Configures a forgot password policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetForgetPasswordConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetForgetPasswordConfigurationResponse
         */
        public SetForgetPasswordConfigurationResponse SetForgetPasswordConfigurationWithOptions(SetForgetPasswordConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationChannels))
            {
                query["AuthenticationChannels"] = request.AuthenticationChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForgetPasswordStatus))
            {
                query["ForgetPasswordStatus"] = request.ForgetPasswordStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetForgetPasswordConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetForgetPasswordConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Configures a forgot password policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetForgetPasswordConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetForgetPasswordConfigurationResponse
         */
        public async Task<SetForgetPasswordConfigurationResponse> SetForgetPasswordConfigurationWithOptionsAsync(SetForgetPasswordConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationChannels))
            {
                query["AuthenticationChannels"] = request.AuthenticationChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForgetPasswordStatus))
            {
                query["ForgetPasswordStatus"] = request.ForgetPasswordStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetForgetPasswordConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetForgetPasswordConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Configures a forgot password policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetForgetPasswordConfigurationRequest
         * @return SetForgetPasswordConfigurationResponse
         */
        public SetForgetPasswordConfigurationResponse SetForgetPasswordConfiguration(SetForgetPasswordConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetForgetPasswordConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Configures a forgot password policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetForgetPasswordConfigurationRequest
         * @return SetForgetPasswordConfigurationResponse
         */
        public async Task<SetForgetPasswordConfigurationResponse> SetForgetPasswordConfigurationAsync(SetForgetPasswordConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetForgetPasswordConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Configures a password complexity policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordComplexityConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordComplexityConfigurationResponse
         */
        public SetPasswordComplexityConfigurationResponse SetPasswordComplexityConfigurationWithOptions(SetPasswordComplexityConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordComplexityRules))
            {
                query["PasswordComplexityRules"] = request.PasswordComplexityRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordMinLength))
            {
                query["PasswordMinLength"] = request.PasswordMinLength;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordComplexityConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordComplexityConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Configures a password complexity policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordComplexityConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordComplexityConfigurationResponse
         */
        public async Task<SetPasswordComplexityConfigurationResponse> SetPasswordComplexityConfigurationWithOptionsAsync(SetPasswordComplexityConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordComplexityRules))
            {
                query["PasswordComplexityRules"] = request.PasswordComplexityRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordMinLength))
            {
                query["PasswordMinLength"] = request.PasswordMinLength;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordComplexityConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordComplexityConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Configures a password complexity policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordComplexityConfigurationRequest
         * @return SetPasswordComplexityConfigurationResponse
         */
        public SetPasswordComplexityConfigurationResponse SetPasswordComplexityConfiguration(SetPasswordComplexityConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetPasswordComplexityConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Configures a password complexity policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordComplexityConfigurationRequest
         * @return SetPasswordComplexityConfigurationResponse
         */
        public async Task<SetPasswordComplexityConfigurationResponse> SetPasswordComplexityConfigurationAsync(SetPasswordComplexityConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetPasswordComplexityConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Configures a password expiration policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordExpirationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordExpirationConfigurationResponse
         */
        public SetPasswordExpirationConfigurationResponse SetPasswordExpirationConfigurationWithOptions(SetPasswordExpirationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationAction))
            {
                query["PasswordExpirationAction"] = request.PasswordExpirationAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationNotificationChannels))
            {
                query["PasswordExpirationNotificationChannels"] = request.PasswordExpirationNotificationChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationNotificationDuration))
            {
                query["PasswordExpirationNotificationDuration"] = request.PasswordExpirationNotificationDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationNotificationStatus))
            {
                query["PasswordExpirationNotificationStatus"] = request.PasswordExpirationNotificationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationStatus))
            {
                query["PasswordExpirationStatus"] = request.PasswordExpirationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordForcedUpdateDuration))
            {
                query["PasswordForcedUpdateDuration"] = request.PasswordForcedUpdateDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordValidMaxDay))
            {
                query["PasswordValidMaxDay"] = request.PasswordValidMaxDay;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordExpirationConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordExpirationConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Configures a password expiration policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordExpirationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordExpirationConfigurationResponse
         */
        public async Task<SetPasswordExpirationConfigurationResponse> SetPasswordExpirationConfigurationWithOptionsAsync(SetPasswordExpirationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationAction))
            {
                query["PasswordExpirationAction"] = request.PasswordExpirationAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationNotificationChannels))
            {
                query["PasswordExpirationNotificationChannels"] = request.PasswordExpirationNotificationChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationNotificationDuration))
            {
                query["PasswordExpirationNotificationDuration"] = request.PasswordExpirationNotificationDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationNotificationStatus))
            {
                query["PasswordExpirationNotificationStatus"] = request.PasswordExpirationNotificationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordExpirationStatus))
            {
                query["PasswordExpirationStatus"] = request.PasswordExpirationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordForcedUpdateDuration))
            {
                query["PasswordForcedUpdateDuration"] = request.PasswordForcedUpdateDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordValidMaxDay))
            {
                query["PasswordValidMaxDay"] = request.PasswordValidMaxDay;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordExpirationConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordExpirationConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Configures a password expiration policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordExpirationConfigurationRequest
         * @return SetPasswordExpirationConfigurationResponse
         */
        public SetPasswordExpirationConfigurationResponse SetPasswordExpirationConfiguration(SetPasswordExpirationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetPasswordExpirationConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Configures a password expiration policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordExpirationConfigurationRequest
         * @return SetPasswordExpirationConfigurationResponse
         */
        public async Task<SetPasswordExpirationConfigurationResponse> SetPasswordExpirationConfigurationAsync(SetPasswordExpirationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetPasswordExpirationConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Configures a password history policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordHistoryConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordHistoryConfigurationResponse
         */
        public SetPasswordHistoryConfigurationResponse SetPasswordHistoryConfigurationWithOptions(SetPasswordHistoryConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordHistoryMaxRetention))
            {
                query["PasswordHistoryMaxRetention"] = request.PasswordHistoryMaxRetention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordHistoryStatus))
            {
                query["PasswordHistoryStatus"] = request.PasswordHistoryStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordHistoryConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordHistoryConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Configures a password history policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordHistoryConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordHistoryConfigurationResponse
         */
        public async Task<SetPasswordHistoryConfigurationResponse> SetPasswordHistoryConfigurationWithOptionsAsync(SetPasswordHistoryConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordHistoryMaxRetention))
            {
                query["PasswordHistoryMaxRetention"] = request.PasswordHistoryMaxRetention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordHistoryStatus))
            {
                query["PasswordHistoryStatus"] = request.PasswordHistoryStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordHistoryConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordHistoryConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Configures a password history policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordHistoryConfigurationRequest
         * @return SetPasswordHistoryConfigurationResponse
         */
        public SetPasswordHistoryConfigurationResponse SetPasswordHistoryConfiguration(SetPasswordHistoryConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetPasswordHistoryConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Configures a password history policy for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordHistoryConfigurationRequest
         * @return SetPasswordHistoryConfigurationResponse
         */
        public async Task<SetPasswordHistoryConfigurationResponse> SetPasswordHistoryConfigurationAsync(SetPasswordHistoryConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetPasswordHistoryConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets the password initialization configurations for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordInitializationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordInitializationConfigurationResponse
         */
        public SetPasswordInitializationConfigurationResponse SetPasswordInitializationConfigurationWithOptions(SetPasswordInitializationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordForcedUpdateStatus))
            {
                query["PasswordForcedUpdateStatus"] = request.PasswordForcedUpdateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationNotificationChannels))
            {
                query["PasswordInitializationNotificationChannels"] = request.PasswordInitializationNotificationChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationStatus))
            {
                query["PasswordInitializationStatus"] = request.PasswordInitializationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationType))
            {
                query["PasswordInitializationType"] = request.PasswordInitializationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordInitializationConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordInitializationConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sets the password initialization configurations for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordInitializationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordInitializationConfigurationResponse
         */
        public async Task<SetPasswordInitializationConfigurationResponse> SetPasswordInitializationConfigurationWithOptionsAsync(SetPasswordInitializationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordForcedUpdateStatus))
            {
                query["PasswordForcedUpdateStatus"] = request.PasswordForcedUpdateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationNotificationChannels))
            {
                query["PasswordInitializationNotificationChannels"] = request.PasswordInitializationNotificationChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationStatus))
            {
                query["PasswordInitializationStatus"] = request.PasswordInitializationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationType))
            {
                query["PasswordInitializationType"] = request.PasswordInitializationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordInitializationConfiguration",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordInitializationConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sets the password initialization configurations for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordInitializationConfigurationRequest
         * @return SetPasswordInitializationConfigurationResponse
         */
        public SetPasswordInitializationConfigurationResponse SetPasswordInitializationConfiguration(SetPasswordInitializationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetPasswordInitializationConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Sets the password initialization configurations for an Employee Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request SetPasswordInitializationConfigurationRequest
         * @return SetPasswordInitializationConfigurationResponse
         */
        public async Task<SetPasswordInitializationConfigurationResponse> SetPasswordInitializationConfigurationAsync(SetPasswordInitializationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetPasswordInitializationConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the primary organizational unit to which an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account belongs. This account will be removed from the previous primary organizational unit and added to the new primary organization.
         *
         * @param request SetUserPrimaryOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetUserPrimaryOrganizationalUnitResponse
         */
        public SetUserPrimaryOrganizationalUnitResponse SetUserPrimaryOrganizationalUnitWithOptions(SetUserPrimaryOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
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
                Action = "SetUserPrimaryOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserPrimaryOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the primary organizational unit to which an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account belongs. This account will be removed from the previous primary organizational unit and added to the new primary organization.
         *
         * @param request SetUserPrimaryOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetUserPrimaryOrganizationalUnitResponse
         */
        public async Task<SetUserPrimaryOrganizationalUnitResponse> SetUserPrimaryOrganizationalUnitWithOptionsAsync(SetUserPrimaryOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
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
                Action = "SetUserPrimaryOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserPrimaryOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the primary organizational unit to which an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account belongs. This account will be removed from the previous primary organizational unit and added to the new primary organization.
         *
         * @param request SetUserPrimaryOrganizationalUnitRequest
         * @return SetUserPrimaryOrganizationalUnitResponse
         */
        public SetUserPrimaryOrganizationalUnitResponse SetUserPrimaryOrganizationalUnit(SetUserPrimaryOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetUserPrimaryOrganizationalUnitWithOptions(request, runtime);
        }

        /**
         * @summary Updates the primary organizational unit to which an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account belongs. This account will be removed from the previous primary organizational unit and added to the new primary organization.
         *
         * @param request SetUserPrimaryOrganizationalUnitRequest
         * @return SetUserPrimaryOrganizationalUnitResponse
         */
        public async Task<SetUserPrimaryOrganizationalUnitResponse> SetUserPrimaryOrganizationalUnitAsync(SetUserPrimaryOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetUserPrimaryOrganizationalUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Unlocks an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS) that is locked.
         *
         * @param request UnlockUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockUserResponse
         */
        public UnlockUserResponse UnlockUserWithOptions(UnlockUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UnlockUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unlocks an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS) that is locked.
         *
         * @param request UnlockUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockUserResponse
         */
        public async Task<UnlockUserResponse> UnlockUserWithOptionsAsync(UnlockUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UnlockUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unlocks an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS) that is locked.
         *
         * @param request UnlockUserRequest
         * @return UnlockUserResponse
         */
        public UnlockUserResponse UnlockUser(UnlockUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockUserWithOptions(request, runtime);
        }

        /**
         * @summary Unlocks an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS) that is locked.
         *
         * @param request UnlockUserRequest
         * @return UnlockUserResponse
         */
        public async Task<UnlockUserResponse> UnlockUserAsync(UnlockUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the authorization type of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request UpdateApplicationAuthorizationTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationAuthorizationTypeResponse
         */
        public UpdateApplicationAuthorizationTypeResponse UpdateApplicationAuthorizationTypeWithOptions(UpdateApplicationAuthorizationTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationType))
            {
                query["AuthorizationType"] = request.AuthorizationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationAuthorizationType",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationAuthorizationTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the authorization type of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request UpdateApplicationAuthorizationTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationAuthorizationTypeResponse
         */
        public async Task<UpdateApplicationAuthorizationTypeResponse> UpdateApplicationAuthorizationTypeWithOptionsAsync(UpdateApplicationAuthorizationTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationType))
            {
                query["AuthorizationType"] = request.AuthorizationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationAuthorizationType",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationAuthorizationTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the authorization type of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request UpdateApplicationAuthorizationTypeRequest
         * @return UpdateApplicationAuthorizationTypeResponse
         */
        public UpdateApplicationAuthorizationTypeResponse UpdateApplicationAuthorizationType(UpdateApplicationAuthorizationTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicationAuthorizationTypeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the authorization type of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request UpdateApplicationAuthorizationTypeRequest
         * @return UpdateApplicationAuthorizationTypeResponse
         */
        public async Task<UpdateApplicationAuthorizationTypeResponse> UpdateApplicationAuthorizationTypeAsync(UpdateApplicationAuthorizationTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicationAuthorizationTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request UpdateApplicationDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationDescriptionResponse
         */
        public UpdateApplicationDescriptionResponse UpdateApplicationDescriptionWithOptions(UpdateApplicationDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request UpdateApplicationDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationDescriptionResponse
         */
        public async Task<UpdateApplicationDescriptionResponse> UpdateApplicationDescriptionWithOptionsAsync(UpdateApplicationDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request UpdateApplicationDescriptionRequest
         * @return UpdateApplicationDescriptionResponse
         */
        public UpdateApplicationDescriptionResponse UpdateApplicationDescription(UpdateApplicationDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicationDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of an Employee Identity and Access Management (EIAM) application.
         *
         * @param request UpdateApplicationDescriptionRequest
         * @return UpdateApplicationDescriptionResponse
         */
        public async Task<UpdateApplicationDescriptionResponse> UpdateApplicationDescriptionAsync(UpdateApplicationDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicationDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the information about an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). If the information is empty, the information is not updated by default.
         *
         * @param request UpdateGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupResponse
         */
        public UpdateGroupResponse UpdateGroupWithOptions(UpdateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupExternalId))
            {
                query["GroupExternalId"] = request.GroupExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Updates the information about an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). If the information is empty, the information is not updated by default.
         *
         * @param request UpdateGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupResponse
         */
        public async Task<UpdateGroupResponse> UpdateGroupWithOptionsAsync(UpdateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupExternalId))
            {
                query["GroupExternalId"] = request.GroupExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2021-12-01",
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

        /**
         * @summary Updates the information about an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). If the information is empty, the information is not updated by default.
         *
         * @param request UpdateGroupRequest
         * @return UpdateGroupResponse
         */
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupWithOptions(request, runtime);
        }

        /**
         * @summary Updates the information about an account group in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). If the information is empty, the information is not updated by default.
         *
         * @param request UpdateGroupRequest
         * @return UpdateGroupResponse
         */
        public async Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the description of an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account group.
         *
         * @param request UpdateGroupDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupDescriptionResponse
         */
        public UpdateGroupDescriptionResponse UpdateGroupDescriptionWithOptions(UpdateGroupDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the description of an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account group.
         *
         * @param request UpdateGroupDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupDescriptionResponse
         */
        public async Task<UpdateGroupDescriptionResponse> UpdateGroupDescriptionWithOptionsAsync(UpdateGroupDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the description of an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account group.
         *
         * @param request UpdateGroupDescriptionRequest
         * @return UpdateGroupDescriptionResponse
         */
        public UpdateGroupDescriptionResponse UpdateGroupDescription(UpdateGroupDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary Updates the description of an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account group.
         *
         * @param request UpdateGroupDescriptionRequest
         * @return UpdateGroupDescriptionResponse
         */
        public async Task<UpdateGroupDescriptionResponse> UpdateGroupDescriptionAsync(UpdateGroupDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request UpdateInstanceDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceDescriptionResponse
         */
        public UpdateInstanceDescriptionResponse UpdateInstanceDescriptionWithOptions(UpdateInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request UpdateInstanceDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceDescriptionResponse
         */
        public async Task<UpdateInstanceDescriptionResponse> UpdateInstanceDescriptionWithOptionsAsync(UpdateInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request UpdateInstanceDescriptionRequest
         * @return UpdateInstanceDescriptionResponse
         */
        public UpdateInstanceDescriptionResponse UpdateInstanceDescription(UpdateInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of an Enterprise Identity and Access Management (EIAM) instance of Identity as a Service (IDaaS).
         *
         * @param request UpdateInstanceDescriptionRequest
         * @return UpdateInstanceDescriptionResponse
         */
        public async Task<UpdateInstanceDescriptionResponse> UpdateInstanceDescriptionAsync(UpdateInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新一个专属网络端点的名称。
         *
         * @param request UpdateNetworkAccessEndpointNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNetworkAccessEndpointNameResponse
         */
        public UpdateNetworkAccessEndpointNameResponse UpdateNetworkAccessEndpointNameWithOptions(UpdateNetworkAccessEndpointNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointId))
            {
                query["NetworkAccessEndpointId"] = request.NetworkAccessEndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointName))
            {
                query["NetworkAccessEndpointName"] = request.NetworkAccessEndpointName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNetworkAccessEndpointName",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNetworkAccessEndpointNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新一个专属网络端点的名称。
         *
         * @param request UpdateNetworkAccessEndpointNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNetworkAccessEndpointNameResponse
         */
        public async Task<UpdateNetworkAccessEndpointNameResponse> UpdateNetworkAccessEndpointNameWithOptionsAsync(UpdateNetworkAccessEndpointNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointId))
            {
                query["NetworkAccessEndpointId"] = request.NetworkAccessEndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkAccessEndpointName))
            {
                query["NetworkAccessEndpointName"] = request.NetworkAccessEndpointName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNetworkAccessEndpointName",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNetworkAccessEndpointNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新一个专属网络端点的名称。
         *
         * @param request UpdateNetworkAccessEndpointNameRequest
         * @return UpdateNetworkAccessEndpointNameResponse
         */
        public UpdateNetworkAccessEndpointNameResponse UpdateNetworkAccessEndpointName(UpdateNetworkAccessEndpointNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNetworkAccessEndpointNameWithOptions(request, runtime);
        }

        /**
         * @summary 更新一个专属网络端点的名称。
         *
         * @param request UpdateNetworkAccessEndpointNameRequest
         * @return UpdateNetworkAccessEndpointNameResponse
         */
        public async Task<UpdateNetworkAccessEndpointNameResponse> UpdateNetworkAccessEndpointNameAsync(UpdateNetworkAccessEndpointNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNetworkAccessEndpointNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the basic information about an Employee Identity and Access Management (EIAM) organization. The basic information about the organization is not updated by default if no parameter is specified.
         *
         * @param request UpdateOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationalUnitResponse
         */
        public UpdateOrganizationalUnitResponse UpdateOrganizationalUnitWithOptions(UpdateOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                query["OrganizationalUnitName"] = request.OrganizationalUnitName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the basic information about an Employee Identity and Access Management (EIAM) organization. The basic information about the organization is not updated by default if no parameter is specified.
         *
         * @param request UpdateOrganizationalUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationalUnitResponse
         */
        public async Task<UpdateOrganizationalUnitResponse> UpdateOrganizationalUnitWithOptionsAsync(UpdateOrganizationalUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                query["OrganizationalUnitName"] = request.OrganizationalUnitName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganizationalUnit",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the basic information about an Employee Identity and Access Management (EIAM) organization. The basic information about the organization is not updated by default if no parameter is specified.
         *
         * @param request UpdateOrganizationalUnitRequest
         * @return UpdateOrganizationalUnitResponse
         */
        public UpdateOrganizationalUnitResponse UpdateOrganizationalUnit(UpdateOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOrganizationalUnitWithOptions(request, runtime);
        }

        /**
         * @summary Updates the basic information about an Employee Identity and Access Management (EIAM) organization. The basic information about the organization is not updated by default if no parameter is specified.
         *
         * @param request UpdateOrganizationalUnitRequest
         * @return UpdateOrganizationalUnitResponse
         */
        public async Task<UpdateOrganizationalUnitResponse> UpdateOrganizationalUnitAsync(UpdateOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOrganizationalUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of an Employee Identity and Access Management (EIAM) organization.
         *
         * @param request UpdateOrganizationalUnitDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationalUnitDescriptionResponse
         */
        public UpdateOrganizationalUnitDescriptionResponse UpdateOrganizationalUnitDescriptionWithOptions(UpdateOrganizationalUnitDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganizationalUnitDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationalUnitDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an Employee Identity and Access Management (EIAM) organization.
         *
         * @param request UpdateOrganizationalUnitDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationalUnitDescriptionResponse
         */
        public async Task<UpdateOrganizationalUnitDescriptionResponse> UpdateOrganizationalUnitDescriptionWithOptionsAsync(UpdateOrganizationalUnitDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganizationalUnitDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationalUnitDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an Employee Identity and Access Management (EIAM) organization.
         *
         * @param request UpdateOrganizationalUnitDescriptionRequest
         * @return UpdateOrganizationalUnitDescriptionResponse
         */
        public UpdateOrganizationalUnitDescriptionResponse UpdateOrganizationalUnitDescription(UpdateOrganizationalUnitDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOrganizationalUnitDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of an Employee Identity and Access Management (EIAM) organization.
         *
         * @param request UpdateOrganizationalUnitDescriptionRequest
         * @return UpdateOrganizationalUnitDescriptionResponse
         */
        public async Task<UpdateOrganizationalUnitDescriptionResponse> UpdateOrganizationalUnitDescriptionAsync(UpdateOrganizationalUnitDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOrganizationalUnitDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the parent organization ID of an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). In this case, the organization is moved from a parent node to a new node.
         *
         * @param request UpdateOrganizationalUnitParentIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationalUnitParentIdResponse
         */
        public UpdateOrganizationalUnitParentIdResponse UpdateOrganizationalUnitParentIdWithOptions(UpdateOrganizationalUnitParentIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganizationalUnitParentId",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationalUnitParentIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the parent organization ID of an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). In this case, the organization is moved from a parent node to a new node.
         *
         * @param request UpdateOrganizationalUnitParentIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationalUnitParentIdResponse
         */
        public async Task<UpdateOrganizationalUnitParentIdResponse> UpdateOrganizationalUnitParentIdWithOptionsAsync(UpdateOrganizationalUnitParentIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["OrganizationalUnitId"] = request.OrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganizationalUnitParentId",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationalUnitParentIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the parent organization ID of an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). In this case, the organization is moved from a parent node to a new node.
         *
         * @param request UpdateOrganizationalUnitParentIdRequest
         * @return UpdateOrganizationalUnitParentIdResponse
         */
        public UpdateOrganizationalUnitParentIdResponse UpdateOrganizationalUnitParentId(UpdateOrganizationalUnitParentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOrganizationalUnitParentIdWithOptions(request, runtime);
        }

        /**
         * @summary Updates the parent organization ID of an organization in Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM). In this case, the organization is moved from a parent node to a new node.
         *
         * @param request UpdateOrganizationalUnitParentIdRequest
         * @return UpdateOrganizationalUnitParentIdResponse
         */
        public async Task<UpdateOrganizationalUnitParentIdResponse> UpdateOrganizationalUnitParentIdAsync(UpdateOrganizationalUnitParentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOrganizationalUnitParentIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the basic information about an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS).
         *
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                query["CustomFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailVerified))
            {
                query["EmailVerified"] = request.EmailVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberVerified))
            {
                query["PhoneNumberVerified"] = request.PhoneNumberVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                query["PhoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2021-12-01",
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
         * @summary Updates the basic information about an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS).
         *
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                query["CustomFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailVerified))
            {
                query["EmailVerified"] = request.EmailVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberVerified))
            {
                query["PhoneNumberVerified"] = request.PhoneNumberVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                query["PhoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2021-12-01",
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
         * @summary Updates the basic information about an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS).
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
         * @summary Updates the basic information about an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS).
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
         * @summary Modifies the description of an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account.
         *
         * @param request UpdateUserDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserDescriptionResponse
         */
        public UpdateUserDescriptionResponse UpdateUserDescriptionWithOptions(UpdateUserDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UpdateUserDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account.
         *
         * @param request UpdateUserDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserDescriptionResponse
         */
        public async Task<UpdateUserDescriptionResponse> UpdateUserDescriptionWithOptionsAsync(UpdateUserDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UpdateUserDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account.
         *
         * @param request UpdateUserDescriptionRequest
         * @return UpdateUserDescriptionResponse
         */
        public UpdateUserDescriptionResponse UpdateUserDescription(UpdateUserDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of an Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM) account.
         *
         * @param request UpdateUserDescriptionRequest
         * @return UpdateUserDescriptionResponse
         */
        public async Task<UpdateUserDescriptionResponse> UpdateUserDescriptionAsync(UpdateUserDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the password information of an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS). The password must meet the requirements of the password policies that are configured in the IDaaS console.
         *
         * @param request UpdateUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserPasswordResponse
         */
        public UpdateUserPasswordResponse UpdateUserPasswordWithOptions(UpdateUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordForcedUpdateStatus))
            {
                query["PasswordForcedUpdateStatus"] = request.PasswordForcedUpdateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNotificationChannels))
            {
                query["UserNotificationChannels"] = request.UserNotificationChannels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPassword",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the password information of an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS). The password must meet the requirements of the password policies that are configured in the IDaaS console.
         *
         * @param request UpdateUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserPasswordResponse
         */
        public async Task<UpdateUserPasswordResponse> UpdateUserPasswordWithOptionsAsync(UpdateUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordForcedUpdateStatus))
            {
                query["PasswordForcedUpdateStatus"] = request.PasswordForcedUpdateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNotificationChannels))
            {
                query["UserNotificationChannels"] = request.UserNotificationChannels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPassword",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the password information of an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS). The password must meet the requirements of the password policies that are configured in the IDaaS console.
         *
         * @param request UpdateUserPasswordRequest
         * @return UpdateUserPasswordResponse
         */
        public UpdateUserPasswordResponse UpdateUserPassword(UpdateUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserPasswordWithOptions(request, runtime);
        }

        /**
         * @summary Updates the password information of an Employee Identity and Access Management (EIAM) account of Identity as a Service (IDaaS). The password must meet the requirements of the password policies that are configured in the IDaaS console.
         *
         * @param request UpdateUserPasswordRequest
         * @return UpdateUserPasswordResponse
         */
        public async Task<UpdateUserPasswordResponse> UpdateUserPasswordAsync(UpdateUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserPasswordWithOptionsAsync(request, runtime);
        }

    }
}
