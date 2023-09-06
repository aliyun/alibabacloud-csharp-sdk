// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Aliding20230426.Models;

namespace AlibabaCloud.SDK.Aliding20230426
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aliding", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddAttendeeResponse AddAttendeeWithOptions(AddAttendeeRequest tmpReq, AddAttendeeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddAttendeeShrinkRequest request = new AddAttendeeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            AddAttendeeShrinkHeaders headers = new AddAttendeeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AttendeesToAdd))
            {
                request.AttendeesToAddShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AttendeesToAdd, "AttendeesToAdd", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToAddShrink))
            {
                body["AttendeesToAdd"] = request.AttendeesToAddShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAttendee",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/addAttendee",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAttendeeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddAttendeeResponse> AddAttendeeWithOptionsAsync(AddAttendeeRequest tmpReq, AddAttendeeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddAttendeeShrinkRequest request = new AddAttendeeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            AddAttendeeShrinkHeaders headers = new AddAttendeeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AttendeesToAdd))
            {
                request.AttendeesToAddShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AttendeesToAdd, "AttendeesToAdd", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToAddShrink))
            {
                body["AttendeesToAdd"] = request.AttendeesToAddShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAttendee",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/addAttendee",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAttendeeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddAttendeeResponse AddAttendee(AddAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return AddAttendeeWithOptions(request, headers, runtime);
        }

        public async Task<AddAttendeeResponse> AddAttendeeAsync(AddAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeHeaders headers = new AddAttendeeHeaders();
            return await AddAttendeeWithOptionsAsync(request, headers, runtime);
        }

        public AddWorkspaceResponse AddWorkspaceWithOptions(AddWorkspaceRequest tmpReq, AddWorkspaceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddWorkspaceShrinkRequest request = new AddWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            AddWorkspaceShrinkHeaders headers = new AddWorkspaceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Option))
            {
                request.OptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Option, "Option", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionShrink))
            {
                body["Option"] = request.OptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspace",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/addWorkspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddWorkspaceResponse> AddWorkspaceWithOptionsAsync(AddWorkspaceRequest tmpReq, AddWorkspaceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddWorkspaceShrinkRequest request = new AddWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            AddWorkspaceShrinkHeaders headers = new AddWorkspaceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Option))
            {
                request.OptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Option, "Option", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionShrink))
            {
                body["Option"] = request.OptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspace",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/addWorkspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddWorkspaceResponse AddWorkspace(AddWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceHeaders headers = new AddWorkspaceHeaders();
            return AddWorkspaceWithOptions(request, headers, runtime);
        }

        public async Task<AddWorkspaceResponse> AddWorkspaceAsync(AddWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceHeaders headers = new AddWorkspaceHeaders();
            return await AddWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        public AddWorkspaceDocMembersResponse AddWorkspaceDocMembersWithOptions(AddWorkspaceDocMembersRequest tmpReq, AddWorkspaceDocMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddWorkspaceDocMembersShrinkRequest request = new AddWorkspaceDocMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            AddWorkspaceDocMembersShrinkHeaders headers = new AddWorkspaceDocMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceDocMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/addWorkspaceDocMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceDocMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddWorkspaceDocMembersResponse> AddWorkspaceDocMembersWithOptionsAsync(AddWorkspaceDocMembersRequest tmpReq, AddWorkspaceDocMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddWorkspaceDocMembersShrinkRequest request = new AddWorkspaceDocMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            AddWorkspaceDocMembersShrinkHeaders headers = new AddWorkspaceDocMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceDocMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/addWorkspaceDocMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceDocMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddWorkspaceDocMembersResponse AddWorkspaceDocMembers(AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return AddWorkspaceDocMembersWithOptions(request, headers, runtime);
        }

        public async Task<AddWorkspaceDocMembersResponse> AddWorkspaceDocMembersAsync(AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return await AddWorkspaceDocMembersWithOptionsAsync(request, headers, runtime);
        }

        public AddWorkspaceMembersResponse AddWorkspaceMembersWithOptions(AddWorkspaceMembersRequest tmpReq, AddWorkspaceMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddWorkspaceMembersShrinkRequest request = new AddWorkspaceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            AddWorkspaceMembersShrinkHeaders headers = new AddWorkspaceMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/addWorkspaceMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddWorkspaceMembersResponse> AddWorkspaceMembersWithOptionsAsync(AddWorkspaceMembersRequest tmpReq, AddWorkspaceMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddWorkspaceMembersShrinkRequest request = new AddWorkspaceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            AddWorkspaceMembersShrinkHeaders headers = new AddWorkspaceMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/addWorkspaceMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddWorkspaceMembersResponse AddWorkspaceMembers(AddWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceMembersHeaders headers = new AddWorkspaceMembersHeaders();
            return AddWorkspaceMembersWithOptions(request, headers, runtime);
        }

        public async Task<AddWorkspaceMembersResponse> AddWorkspaceMembersAsync(AddWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceMembersHeaders headers = new AddWorkspaceMembersHeaders();
            return await AddWorkspaceMembersWithOptionsAsync(request, headers, runtime);
        }

        public CancelScheduleConferenceResponse CancelScheduleConferenceWithOptions(CancelScheduleConferenceRequest tmpReq, CancelScheduleConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CancelScheduleConferenceShrinkRequest request = new CancelScheduleConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CancelScheduleConferenceShrinkHeaders headers = new CancelScheduleConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["ScheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelScheduleConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/cancelScheduleConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelScheduleConferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelScheduleConferenceResponse> CancelScheduleConferenceWithOptionsAsync(CancelScheduleConferenceRequest tmpReq, CancelScheduleConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CancelScheduleConferenceShrinkRequest request = new CancelScheduleConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CancelScheduleConferenceShrinkHeaders headers = new CancelScheduleConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["ScheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelScheduleConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/cancelScheduleConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelScheduleConferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelScheduleConferenceResponse CancelScheduleConference(CancelScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelScheduleConferenceHeaders headers = new CancelScheduleConferenceHeaders();
            return CancelScheduleConferenceWithOptions(request, headers, runtime);
        }

        public async Task<CancelScheduleConferenceResponse> CancelScheduleConferenceAsync(CancelScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelScheduleConferenceHeaders headers = new CancelScheduleConferenceHeaders();
            return await CancelScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        public ClearResponse ClearWithOptions(ClearRequest tmpReq, ClearHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ClearShrinkRequest request = new ClearShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ClearShrinkHeaders headers = new ClearShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeAddress))
            {
                body["RangeAddress"] = request.RangeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Clear",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ClearResponse> ClearWithOptionsAsync(ClearRequest tmpReq, ClearHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ClearShrinkRequest request = new ClearShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ClearShrinkHeaders headers = new ClearShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeAddress))
            {
                body["RangeAddress"] = request.RangeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Clear",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ClearResponse Clear(ClearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearHeaders headers = new ClearHeaders();
            return ClearWithOptions(request, headers, runtime);
        }

        public async Task<ClearResponse> ClearAsync(ClearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearHeaders headers = new ClearHeaders();
            return await ClearWithOptionsAsync(request, headers, runtime);
        }

        public ClearDataResponse ClearDataWithOptions(ClearDataRequest tmpReq, ClearDataHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ClearDataShrinkRequest request = new ClearDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ClearDataShrinkHeaders headers = new ClearDataShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeAddress))
            {
                body["RangeAddress"] = request.RangeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearData",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/clearData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ClearDataResponse> ClearDataWithOptionsAsync(ClearDataRequest tmpReq, ClearDataHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ClearDataShrinkRequest request = new ClearDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ClearDataShrinkHeaders headers = new ClearDataShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeAddress))
            {
                body["RangeAddress"] = request.RangeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearData",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/clearData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ClearDataResponse ClearData(ClearDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearDataHeaders headers = new ClearDataHeaders();
            return ClearDataWithOptions(request, headers, runtime);
        }

        public async Task<ClearDataResponse> ClearDataAsync(ClearDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearDataHeaders headers = new ClearDataHeaders();
            return await ClearDataWithOptionsAsync(request, headers, runtime);
        }

        public CommentListReportResponse CommentListReportWithOptions(CommentListReportRequest tmpReq, CommentListReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CommentListReportShrinkRequest request = new CommentListReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CommentListReportShrinkHeaders headers = new CommentListReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommentListReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/commentListReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommentListReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CommentListReportResponse> CommentListReportWithOptionsAsync(CommentListReportRequest tmpReq, CommentListReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CommentListReportShrinkRequest request = new CommentListReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CommentListReportShrinkHeaders headers = new CommentListReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommentListReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/commentListReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommentListReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CommentListReportResponse CommentListReport(CommentListReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommentListReportHeaders headers = new CommentListReportHeaders();
            return CommentListReportWithOptions(request, headers, runtime);
        }

        public async Task<CommentListReportResponse> CommentListReportAsync(CommentListReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommentListReportHeaders headers = new CommentListReportHeaders();
            return await CommentListReportWithOptionsAsync(request, headers, runtime);
        }

        public CreateEventResponse CreateEventWithOptions(CreateEventRequest tmpReq, CreateEventHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventShrinkRequest request = new CreateEventShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateEventShrinkHeaders headers = new CreateEventShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attendees))
            {
                request.AttendeesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attendees, "Attendees", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.End))
            {
                request.EndShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.End, "End", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OnlineMeetingInfo))
            {
                request.OnlineMeetingInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OnlineMeetingInfo, "OnlineMeetingInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Recurrence))
            {
                request.RecurrenceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Recurrence, "Recurrence", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Reminders))
            {
                request.RemindersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Reminders, "Reminders", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UiConfigs))
            {
                request.UiConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UiConfigs, "UiConfigs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Start))
            {
                request.StartShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Start, "start", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesShrink))
            {
                body["Attendees"] = request.AttendeesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndShrink))
            {
                body["End"] = request.EndShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["IsAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfoShrink))
            {
                body["OnlineMeetingInfo"] = request.OnlineMeetingInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceShrink))
            {
                body["Recurrence"] = request.RecurrenceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemindersShrink))
            {
                body["Reminders"] = request.RemindersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiConfigsShrink))
            {
                body["UiConfigs"] = request.UiConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["calendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartShrink))
            {
                body["start"] = request.StartShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/createEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEventResponse> CreateEventWithOptionsAsync(CreateEventRequest tmpReq, CreateEventHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventShrinkRequest request = new CreateEventShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateEventShrinkHeaders headers = new CreateEventShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attendees))
            {
                request.AttendeesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attendees, "Attendees", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.End))
            {
                request.EndShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.End, "End", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OnlineMeetingInfo))
            {
                request.OnlineMeetingInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OnlineMeetingInfo, "OnlineMeetingInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Recurrence))
            {
                request.RecurrenceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Recurrence, "Recurrence", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Reminders))
            {
                request.RemindersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Reminders, "Reminders", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UiConfigs))
            {
                request.UiConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UiConfigs, "UiConfigs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Start))
            {
                request.StartShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Start, "start", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesShrink))
            {
                body["Attendees"] = request.AttendeesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndShrink))
            {
                body["End"] = request.EndShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["IsAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineMeetingInfoShrink))
            {
                body["OnlineMeetingInfo"] = request.OnlineMeetingInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceShrink))
            {
                body["Recurrence"] = request.RecurrenceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemindersShrink))
            {
                body["Reminders"] = request.RemindersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiConfigsShrink))
            {
                body["UiConfigs"] = request.UiConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["calendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartShrink))
            {
                body["start"] = request.StartShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/createEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEventResponse CreateEvent(CreateEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return CreateEventWithOptions(request, headers, runtime);
        }

        public async Task<CreateEventResponse> CreateEventAsync(CreateEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventHeaders headers = new CreateEventHeaders();
            return await CreateEventWithOptionsAsync(request, headers, runtime);
        }

        public CreateLiveResponse CreateLiveWithOptions(CreateLiveRequest tmpReq, CreateLiveHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLiveShrinkRequest request = new CreateLiveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateLiveShrinkHeaders headers = new CreateLiveShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["Introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEndTime))
            {
                body["PreEndTime"] = request.PreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStartTime))
            {
                body["PreStartTime"] = request.PreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicType))
            {
                body["PublicType"] = request.PublicType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLive",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createLive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateLiveResponse> CreateLiveWithOptionsAsync(CreateLiveRequest tmpReq, CreateLiveHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLiveShrinkRequest request = new CreateLiveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateLiveShrinkHeaders headers = new CreateLiveShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["Introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEndTime))
            {
                body["PreEndTime"] = request.PreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStartTime))
            {
                body["PreStartTime"] = request.PreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicType))
            {
                body["PublicType"] = request.PublicType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLive",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createLive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateLiveResponse CreateLive(CreateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateLiveHeaders headers = new CreateLiveHeaders();
            return CreateLiveWithOptions(request, headers, runtime);
        }

        public async Task<CreateLiveResponse> CreateLiveAsync(CreateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateLiveHeaders headers = new CreateLiveHeaders();
            return await CreateLiveWithOptionsAsync(request, headers, runtime);
        }

        public CreateMeetingRoomResponse CreateMeetingRoomWithOptions(CreateMeetingRoomRequest tmpReq, CreateMeetingRoomHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMeetingRoomShrinkRequest request = new CreateMeetingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateMeetingRoomShrinkHeaders headers = new CreateMeetingRoomShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomLabelIds))
            {
                request.RoomLabelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomLabelIds, "RoomLabelIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomLocation))
            {
                request.RoomLocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomLocation, "RoomLocation", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["IsvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["RoomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIdsShrink))
            {
                body["RoomLabelIds"] = request.RoomLabelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocationShrink))
            {
                body["RoomLocation"] = request.RoomLocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["RoomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["RoomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoom",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createMeetingRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMeetingRoomResponse> CreateMeetingRoomWithOptionsAsync(CreateMeetingRoomRequest tmpReq, CreateMeetingRoomHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMeetingRoomShrinkRequest request = new CreateMeetingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateMeetingRoomShrinkHeaders headers = new CreateMeetingRoomShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomLabelIds))
            {
                request.RoomLabelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomLabelIds, "RoomLabelIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomLocation))
            {
                request.RoomLocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomLocation, "RoomLocation", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["IsvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["RoomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIdsShrink))
            {
                body["RoomLabelIds"] = request.RoomLabelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocationShrink))
            {
                body["RoomLocation"] = request.RoomLocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["RoomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["RoomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoom",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createMeetingRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMeetingRoomResponse CreateMeetingRoom(CreateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomHeaders headers = new CreateMeetingRoomHeaders();
            return CreateMeetingRoomWithOptions(request, headers, runtime);
        }

        public async Task<CreateMeetingRoomResponse> CreateMeetingRoomAsync(CreateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomHeaders headers = new CreateMeetingRoomHeaders();
            return await CreateMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        public CreateMeetingRoomGroupResponse CreateMeetingRoomGroupWithOptions(CreateMeetingRoomGroupRequest tmpReq, CreateMeetingRoomGroupHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMeetingRoomGroupShrinkRequest request = new CreateMeetingRoomGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateMeetingRoomGroupShrinkHeaders headers = new CreateMeetingRoomGroupShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["ParentGroupId"] = request.ParentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoomGroup",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createMeetingRoomGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMeetingRoomGroupResponse> CreateMeetingRoomGroupWithOptionsAsync(CreateMeetingRoomGroupRequest tmpReq, CreateMeetingRoomGroupHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMeetingRoomGroupShrinkRequest request = new CreateMeetingRoomGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateMeetingRoomGroupShrinkHeaders headers = new CreateMeetingRoomGroupShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["ParentGroupId"] = request.ParentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoomGroup",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createMeetingRoomGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMeetingRoomGroupResponse CreateMeetingRoomGroup(CreateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomGroupHeaders headers = new CreateMeetingRoomGroupHeaders();
            return CreateMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateMeetingRoomGroupResponse> CreateMeetingRoomGroupAsync(CreateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomGroupHeaders headers = new CreateMeetingRoomGroupHeaders();
            return await CreateMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

        public CreateReportResponse CreateReportWithOptions(CreateReportRequest tmpReq, CreateReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateReportShrinkRequest request = new CreateReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateReportShrinkHeaders headers = new CreateReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "Contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ToCids))
            {
                request.ToCidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ToCids, "ToCids", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ToUserids))
            {
                request.ToUseridsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ToUserids, "ToUserids", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["Contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdFrom))
            {
                body["DdFrom"] = request.DdFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToChat))
            {
                body["ToChat"] = request.ToChat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToCidsShrink))
            {
                body["ToCids"] = request.ToCidsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToUseridsShrink))
            {
                body["ToUserids"] = request.ToUseridsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/createReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateReportResponse> CreateReportWithOptionsAsync(CreateReportRequest tmpReq, CreateReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateReportShrinkRequest request = new CreateReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateReportShrinkHeaders headers = new CreateReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "Contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ToCids))
            {
                request.ToCidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ToCids, "ToCids", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ToUserids))
            {
                request.ToUseridsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ToUserids, "ToUserids", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["Contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdFrom))
            {
                body["DdFrom"] = request.DdFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToChat))
            {
                body["ToChat"] = request.ToChat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToCidsShrink))
            {
                body["ToCids"] = request.ToCidsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToUseridsShrink))
            {
                body["ToUserids"] = request.ToUseridsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/createReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateReportResponse CreateReport(CreateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateReportHeaders headers = new CreateReportHeaders();
            return CreateReportWithOptions(request, headers, runtime);
        }

        public async Task<CreateReportResponse> CreateReportAsync(CreateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateReportHeaders headers = new CreateReportHeaders();
            return await CreateReportWithOptionsAsync(request, headers, runtime);
        }

        public CreateScheduleConferenceResponse CreateScheduleConferenceWithOptions(CreateScheduleConferenceRequest tmpReq, CreateScheduleConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduleConferenceShrinkRequest request = new CreateScheduleConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateScheduleConferenceShrinkHeaders headers = new CreateScheduleConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduleConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createScheduleConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleConferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateScheduleConferenceResponse> CreateScheduleConferenceWithOptionsAsync(CreateScheduleConferenceRequest tmpReq, CreateScheduleConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduleConferenceShrinkRequest request = new CreateScheduleConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateScheduleConferenceShrinkHeaders headers = new CreateScheduleConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduleConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createScheduleConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleConferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateScheduleConferenceResponse CreateScheduleConference(CreateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduleConferenceHeaders headers = new CreateScheduleConferenceHeaders();
            return CreateScheduleConferenceWithOptions(request, headers, runtime);
        }

        public async Task<CreateScheduleConferenceResponse> CreateScheduleConferenceAsync(CreateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduleConferenceHeaders headers = new CreateScheduleConferenceHeaders();
            return await CreateScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        public CreateSheetResponse CreateSheetWithOptions(CreateSheetRequest tmpReq, CreateSheetHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSheetShrinkRequest request = new CreateSheetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateSheetShrinkHeaders headers = new CreateSheetShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSheet",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/createSheet",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSheetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSheetResponse> CreateSheetWithOptionsAsync(CreateSheetRequest tmpReq, CreateSheetHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSheetShrinkRequest request = new CreateSheetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateSheetShrinkHeaders headers = new CreateSheetShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSheet",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/createSheet",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSheetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSheetResponse CreateSheet(CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return CreateSheetWithOptions(request, headers, runtime);
        }

        public async Task<CreateSheetResponse> CreateSheetAsync(CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return await CreateSheetWithOptionsAsync(request, headers, runtime);
        }

        public CreateTodoTaskResponse CreateTodoTaskWithOptions(CreateTodoTaskRequest tmpReq, CreateTodoTaskHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTodoTaskShrinkRequest request = new CreateTodoTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateTodoTaskShrinkHeaders headers = new CreateTodoTaskShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContentFieldList))
            {
                request.ContentFieldListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContentFieldList, "contentFieldList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DetailUrl))
            {
                request.DetailUrlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DetailUrl, "detailUrl", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutorIds))
            {
                request.ExecutorIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutorIds, "executorIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyConfigs))
            {
                request.NotifyConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyConfigs, "notifyConfigs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParticipantIds))
            {
                request.ParticipantIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParticipantIds, "participantIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldListShrink))
            {
                body["contentFieldList"] = request.ContentFieldListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrlShrink))
            {
                body["detailUrl"] = request.DetailUrlShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIdsShrink))
            {
                body["executorIds"] = request.ExecutorIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyShowExecutor))
            {
                body["isOnlyShowExecutor"] = request.IsOnlyShowExecutor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfigsShrink))
            {
                body["notifyConfigs"] = request.NotifyConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIdsShrink))
            {
                body["participantIds"] = request.ParticipantIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTodoTask",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/createTodoTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTodoTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTodoTaskResponse> CreateTodoTaskWithOptionsAsync(CreateTodoTaskRequest tmpReq, CreateTodoTaskHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTodoTaskShrinkRequest request = new CreateTodoTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateTodoTaskShrinkHeaders headers = new CreateTodoTaskShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContentFieldList))
            {
                request.ContentFieldListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContentFieldList, "contentFieldList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DetailUrl))
            {
                request.DetailUrlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DetailUrl, "detailUrl", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutorIds))
            {
                request.ExecutorIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutorIds, "executorIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyConfigs))
            {
                request.NotifyConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyConfigs, "notifyConfigs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParticipantIds))
            {
                request.ParticipantIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParticipantIds, "participantIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldListShrink))
            {
                body["contentFieldList"] = request.ContentFieldListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrlShrink))
            {
                body["detailUrl"] = request.DetailUrlShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIdsShrink))
            {
                body["executorIds"] = request.ExecutorIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyShowExecutor))
            {
                body["isOnlyShowExecutor"] = request.IsOnlyShowExecutor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfigsShrink))
            {
                body["notifyConfigs"] = request.NotifyConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIdsShrink))
            {
                body["participantIds"] = request.ParticipantIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTodoTask",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/createTodoTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTodoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTodoTaskResponse CreateTodoTask(CreateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTaskHeaders headers = new CreateTodoTaskHeaders();
            return CreateTodoTaskWithOptions(request, headers, runtime);
        }

        public async Task<CreateTodoTaskResponse> CreateTodoTaskAsync(CreateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTaskHeaders headers = new CreateTodoTaskHeaders();
            return await CreateTodoTaskWithOptionsAsync(request, headers, runtime);
        }

        public CreateVideoConferenceResponse CreateVideoConferenceWithOptions(CreateVideoConferenceRequest tmpReq, CreateVideoConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVideoConferenceShrinkRequest request = new CreateVideoConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateVideoConferenceShrinkHeaders headers = new CreateVideoConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InviteUserIds))
            {
                request.InviteUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InviteUserIds, "InviteUserIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["ConfTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteCaller))
            {
                body["InviteCaller"] = request.InviteCaller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteUserIdsShrink))
            {
                body["InviteUserIds"] = request.InviteUserIdsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createVideoConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoConferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVideoConferenceResponse> CreateVideoConferenceWithOptionsAsync(CreateVideoConferenceRequest tmpReq, CreateVideoConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVideoConferenceShrinkRequest request = new CreateVideoConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateVideoConferenceShrinkHeaders headers = new CreateVideoConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InviteUserIds))
            {
                request.InviteUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InviteUserIds, "InviteUserIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["ConfTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteCaller))
            {
                body["InviteCaller"] = request.InviteCaller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteUserIdsShrink))
            {
                body["InviteUserIds"] = request.InviteUserIdsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/createVideoConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoConferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVideoConferenceResponse CreateVideoConference(CreateVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
            return CreateVideoConferenceWithOptions(request, headers, runtime);
        }

        public async Task<CreateVideoConferenceResponse> CreateVideoConferenceAsync(CreateVideoConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoConferenceHeaders headers = new CreateVideoConferenceHeaders();
            return await CreateVideoConferenceWithOptionsAsync(request, headers, runtime);
        }

        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest tmpReq, CreateWorkspaceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkspaceShrinkRequest request = new CreateWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateWorkspaceShrinkHeaders headers = new CreateWorkspaceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/createWorkspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest tmpReq, CreateWorkspaceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkspaceShrinkRequest request = new CreateWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateWorkspaceShrinkHeaders headers = new CreateWorkspaceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/createWorkspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceHeaders headers = new CreateWorkspaceHeaders();
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceHeaders headers = new CreateWorkspaceHeaders();
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        public CreateWorkspaceDocResponse CreateWorkspaceDocWithOptions(CreateWorkspaceDocRequest tmpReq, CreateWorkspaceDocHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkspaceDocShrinkRequest request = new CreateWorkspaceDocShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateWorkspaceDocShrinkHeaders headers = new CreateWorkspaceDocShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentNodeId))
            {
                body["ParentNodeId"] = request.ParentNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspaceDoc",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/createWorkspaceDoc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceDocResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateWorkspaceDocResponse> CreateWorkspaceDocWithOptionsAsync(CreateWorkspaceDocRequest tmpReq, CreateWorkspaceDocHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkspaceDocShrinkRequest request = new CreateWorkspaceDocShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateWorkspaceDocShrinkHeaders headers = new CreateWorkspaceDocShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentNodeId))
            {
                body["ParentNodeId"] = request.ParentNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspaceDoc",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/createWorkspaceDoc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceDocResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateWorkspaceDocResponse CreateWorkspaceDoc(CreateWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceDocHeaders headers = new CreateWorkspaceDocHeaders();
            return CreateWorkspaceDocWithOptions(request, headers, runtime);
        }

        public async Task<CreateWorkspaceDocResponse> CreateWorkspaceDocAsync(CreateWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceDocHeaders headers = new CreateWorkspaceDocHeaders();
            return await CreateWorkspaceDocWithOptionsAsync(request, headers, runtime);
        }

        public DeleteColumnsResponse DeleteColumnsWithOptions(DeleteColumnsRequest tmpReq, DeleteColumnsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteColumnsShrinkRequest request = new DeleteColumnsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteColumnsShrinkHeaders headers = new DeleteColumnsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["ColumnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteColumns",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteColumns",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteColumnsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteColumnsResponse> DeleteColumnsWithOptionsAsync(DeleteColumnsRequest tmpReq, DeleteColumnsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteColumnsShrinkRequest request = new DeleteColumnsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteColumnsShrinkHeaders headers = new DeleteColumnsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["ColumnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteColumns",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteColumns",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteColumnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteColumnsResponse DeleteColumns(DeleteColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteColumnsHeaders headers = new DeleteColumnsHeaders();
            return DeleteColumnsWithOptions(request, headers, runtime);
        }

        public async Task<DeleteColumnsResponse> DeleteColumnsAsync(DeleteColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteColumnsHeaders headers = new DeleteColumnsHeaders();
            return await DeleteColumnsWithOptionsAsync(request, headers, runtime);
        }

        public DeleteEventResponse DeleteEventWithOptions(DeleteEventRequest request, DeleteEventHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            DeleteEventShrinkHeaders headers = new DeleteEventShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEvent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/deleteEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEventResponse> DeleteEventWithOptionsAsync(DeleteEventRequest request, DeleteEventHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            DeleteEventShrinkHeaders headers = new DeleteEventShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEvent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/deleteEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEventResponse DeleteEvent(DeleteEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEventHeaders headers = new DeleteEventHeaders();
            return DeleteEventWithOptions(request, headers, runtime);
        }

        public async Task<DeleteEventResponse> DeleteEventAsync(DeleteEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEventHeaders headers = new DeleteEventHeaders();
            return await DeleteEventWithOptionsAsync(request, headers, runtime);
        }

        public DeleteLiveResponse DeleteLiveWithOptions(DeleteLiveRequest tmpReq, DeleteLiveHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteLiveShrinkRequest request = new DeleteLiveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteLiveShrinkHeaders headers = new DeleteLiveShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLive",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/deleteLive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteLiveResponse> DeleteLiveWithOptionsAsync(DeleteLiveRequest tmpReq, DeleteLiveHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteLiveShrinkRequest request = new DeleteLiveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteLiveShrinkHeaders headers = new DeleteLiveShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLive",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/deleteLive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteLiveResponse DeleteLive(DeleteLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveHeaders headers = new DeleteLiveHeaders();
            return DeleteLiveWithOptions(request, headers, runtime);
        }

        public async Task<DeleteLiveResponse> DeleteLiveAsync(DeleteLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLiveHeaders headers = new DeleteLiveHeaders();
            return await DeleteLiveWithOptionsAsync(request, headers, runtime);
        }

        public DeleteMeetingRoomResponse DeleteMeetingRoomWithOptions(DeleteMeetingRoomRequest tmpReq, DeleteMeetingRoomHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteMeetingRoomShrinkRequest request = new DeleteMeetingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteMeetingRoomShrinkHeaders headers = new DeleteMeetingRoomShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["RoomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoom",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/deleteMeetingRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMeetingRoomResponse> DeleteMeetingRoomWithOptionsAsync(DeleteMeetingRoomRequest tmpReq, DeleteMeetingRoomHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteMeetingRoomShrinkRequest request = new DeleteMeetingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteMeetingRoomShrinkHeaders headers = new DeleteMeetingRoomShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["RoomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoom",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/deleteMeetingRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMeetingRoomResponse DeleteMeetingRoom(DeleteMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomHeaders headers = new DeleteMeetingRoomHeaders();
            return DeleteMeetingRoomWithOptions(request, headers, runtime);
        }

        public async Task<DeleteMeetingRoomResponse> DeleteMeetingRoomAsync(DeleteMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomHeaders headers = new DeleteMeetingRoomHeaders();
            return await DeleteMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        public DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroupWithOptions(DeleteMeetingRoomGroupRequest tmpReq, DeleteMeetingRoomGroupHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteMeetingRoomGroupShrinkRequest request = new DeleteMeetingRoomGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteMeetingRoomGroupShrinkHeaders headers = new DeleteMeetingRoomGroupShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoomGroup",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/deleteMeetingRoomGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMeetingRoomGroupResponse> DeleteMeetingRoomGroupWithOptionsAsync(DeleteMeetingRoomGroupRequest tmpReq, DeleteMeetingRoomGroupHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteMeetingRoomGroupShrinkRequest request = new DeleteMeetingRoomGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteMeetingRoomGroupShrinkHeaders headers = new DeleteMeetingRoomGroupShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoomGroup",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/deleteMeetingRoomGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroup(DeleteMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomGroupHeaders headers = new DeleteMeetingRoomGroupHeaders();
            return DeleteMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        public async Task<DeleteMeetingRoomGroupResponse> DeleteMeetingRoomGroupAsync(DeleteMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomGroupHeaders headers = new DeleteMeetingRoomGroupHeaders();
            return await DeleteMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

        public DeleteRowsResponse DeleteRowsWithOptions(DeleteRowsRequest tmpReq, DeleteRowsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteRowsShrinkRequest request = new DeleteRowsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteRowsShrinkHeaders headers = new DeleteRowsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRows",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteRows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRowsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRowsResponse> DeleteRowsWithOptionsAsync(DeleteRowsRequest tmpReq, DeleteRowsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteRowsShrinkRequest request = new DeleteRowsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteRowsShrinkHeaders headers = new DeleteRowsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRows",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteRows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRowsResponse DeleteRows(DeleteRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRowsHeaders headers = new DeleteRowsHeaders();
            return DeleteRowsWithOptions(request, headers, runtime);
        }

        public async Task<DeleteRowsResponse> DeleteRowsAsync(DeleteRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRowsHeaders headers = new DeleteRowsHeaders();
            return await DeleteRowsWithOptionsAsync(request, headers, runtime);
        }

        public DeleteSheetResponse DeleteSheetWithOptions(DeleteSheetRequest tmpReq, DeleteSheetHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteSheetShrinkRequest request = new DeleteSheetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteSheetShrinkHeaders headers = new DeleteSheetShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSheet",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteSheet",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSheetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSheetResponse> DeleteSheetWithOptionsAsync(DeleteSheetRequest tmpReq, DeleteSheetHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteSheetShrinkRequest request = new DeleteSheetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteSheetShrinkHeaders headers = new DeleteSheetShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSheet",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteSheet",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSheetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSheetResponse DeleteSheet(DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return DeleteSheetWithOptions(request, headers, runtime);
        }

        public async Task<DeleteSheetResponse> DeleteSheetAsync(DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return await DeleteSheetWithOptionsAsync(request, headers, runtime);
        }

        public DeleteTodoTaskResponse DeleteTodoTaskWithOptions(DeleteTodoTaskRequest tmpReq, DeleteTodoTaskHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTodoTaskShrinkRequest request = new DeleteTodoTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteTodoTaskShrinkHeaders headers = new DeleteTodoTaskShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTodoTask",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/deleteTodoTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTodoTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTodoTaskResponse> DeleteTodoTaskWithOptionsAsync(DeleteTodoTaskRequest tmpReq, DeleteTodoTaskHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTodoTaskShrinkRequest request = new DeleteTodoTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteTodoTaskShrinkHeaders headers = new DeleteTodoTaskShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTodoTask",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/deleteTodoTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTodoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTodoTaskResponse DeleteTodoTask(DeleteTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTodoTaskHeaders headers = new DeleteTodoTaskHeaders();
            return DeleteTodoTaskWithOptions(request, headers, runtime);
        }

        public async Task<DeleteTodoTaskResponse> DeleteTodoTaskAsync(DeleteTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTodoTaskHeaders headers = new DeleteTodoTaskHeaders();
            return await DeleteTodoTaskWithOptionsAsync(request, headers, runtime);
        }

        public DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembersWithOptions(DeleteWorkspaceDocMembersRequest tmpReq, DeleteWorkspaceDocMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteWorkspaceDocMembersShrinkRequest request = new DeleteWorkspaceDocMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteWorkspaceDocMembersShrinkHeaders headers = new DeleteWorkspaceDocMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceDocMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteWorkspaceDocMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceDocMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteWorkspaceDocMembersResponse> DeleteWorkspaceDocMembersWithOptionsAsync(DeleteWorkspaceDocMembersRequest tmpReq, DeleteWorkspaceDocMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteWorkspaceDocMembersShrinkRequest request = new DeleteWorkspaceDocMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteWorkspaceDocMembersShrinkHeaders headers = new DeleteWorkspaceDocMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceDocMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteWorkspaceDocMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceDocMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembers(DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return DeleteWorkspaceDocMembersWithOptions(request, headers, runtime);
        }

        public async Task<DeleteWorkspaceDocMembersResponse> DeleteWorkspaceDocMembersAsync(DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return await DeleteWorkspaceDocMembersWithOptionsAsync(request, headers, runtime);
        }

        public DeleteWorkspaceMembersResponse DeleteWorkspaceMembersWithOptions(DeleteWorkspaceMembersRequest tmpReq, DeleteWorkspaceMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteWorkspaceMembersShrinkRequest request = new DeleteWorkspaceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteWorkspaceMembersShrinkHeaders headers = new DeleteWorkspaceMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteWorkspaceMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteWorkspaceMembersResponse> DeleteWorkspaceMembersWithOptionsAsync(DeleteWorkspaceMembersRequest tmpReq, DeleteWorkspaceMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteWorkspaceMembersShrinkRequest request = new DeleteWorkspaceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            DeleteWorkspaceMembersShrinkHeaders headers = new DeleteWorkspaceMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/deleteWorkspaceMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteWorkspaceMembersResponse DeleteWorkspaceMembers(DeleteWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceMembersHeaders headers = new DeleteWorkspaceMembersHeaders();
            return DeleteWorkspaceMembersWithOptions(request, headers, runtime);
        }

        public async Task<DeleteWorkspaceMembersResponse> DeleteWorkspaceMembersAsync(DeleteWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceMembersHeaders headers = new DeleteWorkspaceMembersHeaders();
            return await DeleteWorkspaceMembersWithOptionsAsync(request, headers, runtime);
        }

        public GetAllSheetsResponse GetAllSheetsWithOptions(GetAllSheetsRequest tmpReq, GetAllSheetsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAllSheetsShrinkRequest request = new GetAllSheetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetAllSheetsShrinkHeaders headers = new GetAllSheetsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllSheets",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/getAllSheets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllSheetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAllSheetsResponse> GetAllSheetsWithOptionsAsync(GetAllSheetsRequest tmpReq, GetAllSheetsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAllSheetsShrinkRequest request = new GetAllSheetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetAllSheetsShrinkHeaders headers = new GetAllSheetsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllSheets",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/getAllSheets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllSheetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAllSheetsResponse GetAllSheets(GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return GetAllSheetsWithOptions(request, headers, runtime);
        }

        public async Task<GetAllSheetsResponse> GetAllSheetsAsync(GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return await GetAllSheetsWithOptionsAsync(request, headers, runtime);
        }

        public GetEventResponse GetEventWithOptions(GetEventRequest request, GetEventHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            GetEventShrinkHeaders headers = new GetEventShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["MaxAttendees"] = request.MaxAttendees;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/getEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEventResponse> GetEventWithOptionsAsync(GetEventRequest request, GetEventHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            GetEventShrinkHeaders headers = new GetEventShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                query["MaxAttendees"] = request.MaxAttendees;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/getEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEventResponse GetEvent(GetEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return GetEventWithOptions(request, headers, runtime);
        }

        public async Task<GetEventResponse> GetEventAsync(GetEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventHeaders headers = new GetEventHeaders();
            return await GetEventWithOptionsAsync(request, headers, runtime);
        }

        public GetMineWorkspaceResponse GetMineWorkspaceWithOptions(GetMineWorkspaceRequest tmpReq, GetMineWorkspaceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMineWorkspaceShrinkRequest request = new GetMineWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetMineWorkspaceShrinkHeaders headers = new GetMineWorkspaceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMineWorkspace",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getMineWorkspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMineWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMineWorkspaceResponse> GetMineWorkspaceWithOptionsAsync(GetMineWorkspaceRequest tmpReq, GetMineWorkspaceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMineWorkspaceShrinkRequest request = new GetMineWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetMineWorkspaceShrinkHeaders headers = new GetMineWorkspaceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMineWorkspace",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getMineWorkspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMineWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMineWorkspaceResponse GetMineWorkspace(GetMineWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMineWorkspaceHeaders headers = new GetMineWorkspaceHeaders();
            return GetMineWorkspaceWithOptions(request, headers, runtime);
        }

        public async Task<GetMineWorkspaceResponse> GetMineWorkspaceAsync(GetMineWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMineWorkspaceHeaders headers = new GetMineWorkspaceHeaders();
            return await GetMineWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        public GetNodeResponse GetNodeWithOptions(GetNodeRequest tmpReq, GetNodeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNodeShrinkRequest request = new GetNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetNodeShrinkHeaders headers = new GetNodeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                body["WithPermissionRole"] = request.WithPermissionRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatisticalInfo))
            {
                body["WithStatisticalInfo"] = request.WithStatisticalInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNode",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getNode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetNodeResponse> GetNodeWithOptionsAsync(GetNodeRequest tmpReq, GetNodeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNodeShrinkRequest request = new GetNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetNodeShrinkHeaders headers = new GetNodeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                body["WithPermissionRole"] = request.WithPermissionRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatisticalInfo))
            {
                body["WithStatisticalInfo"] = request.WithStatisticalInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNode",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getNode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetNodeResponse GetNode(GetNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodeHeaders headers = new GetNodeHeaders();
            return GetNodeWithOptions(request, headers, runtime);
        }

        public async Task<GetNodeResponse> GetNodeAsync(GetNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodeHeaders headers = new GetNodeHeaders();
            return await GetNodeWithOptionsAsync(request, headers, runtime);
        }

        public GetNodeByUrlResponse GetNodeByUrlWithOptions(GetNodeByUrlRequest tmpReq, GetNodeByUrlHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNodeByUrlShrinkRequest request = new GetNodeByUrlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetNodeByUrlShrinkHeaders headers = new GetNodeByUrlShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Option))
            {
                request.OptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Option, "Option", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionShrink))
            {
                body["Option"] = request.OptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeByUrl",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getNodeByUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeByUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetNodeByUrlResponse> GetNodeByUrlWithOptionsAsync(GetNodeByUrlRequest tmpReq, GetNodeByUrlHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNodeByUrlShrinkRequest request = new GetNodeByUrlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetNodeByUrlShrinkHeaders headers = new GetNodeByUrlShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Option))
            {
                request.OptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Option, "Option", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionShrink))
            {
                body["Option"] = request.OptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeByUrl",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getNodeByUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeByUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetNodeByUrlResponse GetNodeByUrl(GetNodeByUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodeByUrlHeaders headers = new GetNodeByUrlHeaders();
            return GetNodeByUrlWithOptions(request, headers, runtime);
        }

        public async Task<GetNodeByUrlResponse> GetNodeByUrlAsync(GetNodeByUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodeByUrlHeaders headers = new GetNodeByUrlHeaders();
            return await GetNodeByUrlWithOptionsAsync(request, headers, runtime);
        }

        public GetNodesResponse GetNodesWithOptions(GetNodesRequest tmpReq, GetNodesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNodesShrinkRequest request = new GetNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetNodesShrinkHeaders headers = new GetNodesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodeIds))
            {
                request.NodeIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodeIds, "NodeIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Option))
            {
                request.OptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Option, "Option", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIdsShrink))
            {
                body["NodeIds"] = request.NodeIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionShrink))
            {
                body["Option"] = request.OptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodes",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getNodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetNodesResponse> GetNodesWithOptionsAsync(GetNodesRequest tmpReq, GetNodesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNodesShrinkRequest request = new GetNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetNodesShrinkHeaders headers = new GetNodesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodeIds))
            {
                request.NodeIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodeIds, "NodeIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Option))
            {
                request.OptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Option, "Option", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIdsShrink))
            {
                body["NodeIds"] = request.NodeIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionShrink))
            {
                body["Option"] = request.OptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodes",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getNodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetNodesResponse GetNodes(GetNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodesHeaders headers = new GetNodesHeaders();
            return GetNodesWithOptions(request, headers, runtime);
        }

        public async Task<GetNodesResponse> GetNodesAsync(GetNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodesHeaders headers = new GetNodesHeaders();
            return await GetNodesWithOptionsAsync(request, headers, runtime);
        }

        public GetRangeResponse GetRangeWithOptions(GetRangeRequest tmpReq, GetRangeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetRangeShrinkRequest request = new GetRangeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetRangeShrinkHeaders headers = new GetRangeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeAddress))
            {
                body["RangeAddress"] = request.RangeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Select))
            {
                body["Select"] = request.Select;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRange",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/getRange",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRangeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRangeResponse> GetRangeWithOptionsAsync(GetRangeRequest tmpReq, GetRangeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetRangeShrinkRequest request = new GetRangeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetRangeShrinkHeaders headers = new GetRangeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeAddress))
            {
                body["RangeAddress"] = request.RangeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Select))
            {
                body["Select"] = request.Select;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRange",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/getRange",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRangeResponse GetRange(GetRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRangeHeaders headers = new GetRangeHeaders();
            return GetRangeWithOptions(request, headers, runtime);
        }

        public async Task<GetRangeResponse> GetRangeAsync(GetRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRangeHeaders headers = new GetRangeHeaders();
            return await GetRangeWithOptionsAsync(request, headers, runtime);
        }

        public GetReportTemplateByNameResponse GetReportTemplateByNameWithOptions(GetReportTemplateByNameRequest tmpReq, GetReportTemplateByNameHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetReportTemplateByNameShrinkRequest request = new GetReportTemplateByNameShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetReportTemplateByNameShrinkHeaders headers = new GetReportTemplateByNameShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReportTemplateByName",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/getReportTemplateByName",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReportTemplateByNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetReportTemplateByNameResponse> GetReportTemplateByNameWithOptionsAsync(GetReportTemplateByNameRequest tmpReq, GetReportTemplateByNameHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetReportTemplateByNameShrinkRequest request = new GetReportTemplateByNameShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetReportTemplateByNameShrinkHeaders headers = new GetReportTemplateByNameShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReportTemplateByName",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/getReportTemplateByName",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReportTemplateByNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetReportTemplateByNameResponse GetReportTemplateByName(GetReportTemplateByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReportTemplateByNameHeaders headers = new GetReportTemplateByNameHeaders();
            return GetReportTemplateByNameWithOptions(request, headers, runtime);
        }

        public async Task<GetReportTemplateByNameResponse> GetReportTemplateByNameAsync(GetReportTemplateByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReportTemplateByNameHeaders headers = new GetReportTemplateByNameHeaders();
            return await GetReportTemplateByNameWithOptionsAsync(request, headers, runtime);
        }

        public GetReportUnReadCountResponse GetReportUnReadCountWithOptions(GetReportUnReadCountRequest tmpReq, GetReportUnReadCountHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetReportUnReadCountShrinkRequest request = new GetReportUnReadCountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetReportUnReadCountShrinkHeaders headers = new GetReportUnReadCountShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReportUnReadCount",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/getReportUnReadCount",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReportUnReadCountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetReportUnReadCountResponse> GetReportUnReadCountWithOptionsAsync(GetReportUnReadCountRequest tmpReq, GetReportUnReadCountHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetReportUnReadCountShrinkRequest request = new GetReportUnReadCountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetReportUnReadCountShrinkHeaders headers = new GetReportUnReadCountShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReportUnReadCount",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/getReportUnReadCount",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReportUnReadCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetReportUnReadCountResponse GetReportUnReadCount(GetReportUnReadCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReportUnReadCountHeaders headers = new GetReportUnReadCountHeaders();
            return GetReportUnReadCountWithOptions(request, headers, runtime);
        }

        public async Task<GetReportUnReadCountResponse> GetReportUnReadCountAsync(GetReportUnReadCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReportUnReadCountHeaders headers = new GetReportUnReadCountHeaders();
            return await GetReportUnReadCountWithOptionsAsync(request, headers, runtime);
        }

        public GetSheetResponse GetSheetWithOptions(GetSheetRequest tmpReq, GetSheetHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSheetShrinkRequest request = new GetSheetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetSheetShrinkHeaders headers = new GetSheetShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSheet",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/getSheet",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSheetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSheetResponse> GetSheetWithOptionsAsync(GetSheetRequest tmpReq, GetSheetHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSheetShrinkRequest request = new GetSheetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetSheetShrinkHeaders headers = new GetSheetShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSheet",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/getSheet",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSheetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSheetResponse GetSheet(GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return GetSheetWithOptions(request, headers, runtime);
        }

        public async Task<GetSheetResponse> GetSheetAsync(GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return await GetSheetWithOptionsAsync(request, headers, runtime);
        }

        public GetSpaceDirectoriesResponse GetSpaceDirectoriesWithOptions(GetSpaceDirectoriesRequest tmpReq, GetSpaceDirectoriesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSpaceDirectoriesShrinkRequest request = new GetSpaceDirectoriesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetSpaceDirectoriesShrinkHeaders headers = new GetSpaceDirectoriesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["DentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["SpaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpaceDirectories",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getSpaceDirectories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceDirectoriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSpaceDirectoriesResponse> GetSpaceDirectoriesWithOptionsAsync(GetSpaceDirectoriesRequest tmpReq, GetSpaceDirectoriesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSpaceDirectoriesShrinkRequest request = new GetSpaceDirectoriesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetSpaceDirectoriesShrinkHeaders headers = new GetSpaceDirectoriesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["DentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["SpaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpaceDirectories",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getSpaceDirectories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceDirectoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSpaceDirectoriesResponse GetSpaceDirectories(GetSpaceDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceDirectoriesHeaders headers = new GetSpaceDirectoriesHeaders();
            return GetSpaceDirectoriesWithOptions(request, headers, runtime);
        }

        public async Task<GetSpaceDirectoriesResponse> GetSpaceDirectoriesAsync(GetSpaceDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceDirectoriesHeaders headers = new GetSpaceDirectoriesHeaders();
            return await GetSpaceDirectoriesWithOptionsAsync(request, headers, runtime);
        }

        public GetTemplateListByUserIdResponse GetTemplateListByUserIdWithOptions(GetTemplateListByUserIdRequest tmpReq, GetTemplateListByUserIdHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTemplateListByUserIdShrinkRequest request = new GetTemplateListByUserIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetTemplateListByUserIdShrinkHeaders headers = new GetTemplateListByUserIdShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateListByUserId",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/getTemplateListByUserId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateListByUserIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTemplateListByUserIdResponse> GetTemplateListByUserIdWithOptionsAsync(GetTemplateListByUserIdRequest tmpReq, GetTemplateListByUserIdHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTemplateListByUserIdShrinkRequest request = new GetTemplateListByUserIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetTemplateListByUserIdShrinkHeaders headers = new GetTemplateListByUserIdShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateListByUserId",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/getTemplateListByUserId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateListByUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTemplateListByUserIdResponse GetTemplateListByUserId(GetTemplateListByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateListByUserIdHeaders headers = new GetTemplateListByUserIdHeaders();
            return GetTemplateListByUserIdWithOptions(request, headers, runtime);
        }

        public async Task<GetTemplateListByUserIdResponse> GetTemplateListByUserIdAsync(GetTemplateListByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateListByUserIdHeaders headers = new GetTemplateListByUserIdHeaders();
            return await GetTemplateListByUserIdWithOptionsAsync(request, headers, runtime);
        }

        public GetUserResponse GetUserWithOptions(GetUserRequest tmpReq, GetUserHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserShrinkRequest request = new GetUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetUserShrinkHeaders headers = new GetUserShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/im/getUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest tmpReq, GetUserHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserShrinkRequest request = new GetUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetUserShrinkHeaders headers = new GetUserShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/im/getUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return GetUserWithOptions(request, headers, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return await GetUserWithOptionsAsync(request, headers, runtime);
        }

        public GetWorkspaceResponse GetWorkspaceWithOptions(GetWorkspaceRequest tmpReq, GetWorkspaceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetWorkspaceShrinkRequest request = new GetWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetWorkspaceShrinkHeaders headers = new GetWorkspaceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                body["WithPermissionRole"] = request.WithPermissionRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getWorkspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(GetWorkspaceRequest tmpReq, GetWorkspaceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetWorkspaceShrinkRequest request = new GetWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetWorkspaceShrinkHeaders headers = new GetWorkspaceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                body["WithPermissionRole"] = request.WithPermissionRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getWorkspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkspaceResponse GetWorkspace(GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return GetWorkspaceWithOptions(request, headers, runtime);
        }

        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return await GetWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        public GetWorkspacesResponse GetWorkspacesWithOptions(GetWorkspacesRequest tmpReq, GetWorkspacesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetWorkspacesShrinkRequest request = new GetWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetWorkspacesShrinkHeaders headers = new GetWorkspacesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Option))
            {
                request.OptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Option, "Option", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WorkspaceIds))
            {
                request.WorkspaceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WorkspaceIds, "WorkspaceIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionShrink))
            {
                body["Option"] = request.OptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIdsShrink))
            {
                body["WorkspaceIds"] = request.WorkspaceIdsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspaces",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getWorkspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkspacesResponse> GetWorkspacesWithOptionsAsync(GetWorkspacesRequest tmpReq, GetWorkspacesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetWorkspacesShrinkRequest request = new GetWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            GetWorkspacesShrinkHeaders headers = new GetWorkspacesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Option))
            {
                request.OptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Option, "Option", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WorkspaceIds))
            {
                request.WorkspaceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WorkspaceIds, "WorkspaceIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionShrink))
            {
                body["Option"] = request.OptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIdsShrink))
            {
                body["WorkspaceIds"] = request.WorkspaceIdsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspaces",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/getWorkspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkspacesResponse GetWorkspaces(GetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspacesHeaders headers = new GetWorkspacesHeaders();
            return GetWorkspacesWithOptions(request, headers, runtime);
        }

        public async Task<GetWorkspacesResponse> GetWorkspacesAsync(GetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspacesHeaders headers = new GetWorkspacesHeaders();
            return await GetWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        public InsertColumnsBeforeResponse InsertColumnsBeforeWithOptions(InsertColumnsBeforeRequest tmpReq, InsertColumnsBeforeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertColumnsBeforeShrinkRequest request = new InsertColumnsBeforeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            InsertColumnsBeforeShrinkHeaders headers = new InsertColumnsBeforeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["ColumnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertColumnsBefore",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/insertColumnsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertColumnsBeforeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertColumnsBeforeResponse> InsertColumnsBeforeWithOptionsAsync(InsertColumnsBeforeRequest tmpReq, InsertColumnsBeforeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertColumnsBeforeShrinkRequest request = new InsertColumnsBeforeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            InsertColumnsBeforeShrinkHeaders headers = new InsertColumnsBeforeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["ColumnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertColumnsBefore",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/insertColumnsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertColumnsBeforeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertColumnsBeforeResponse InsertColumnsBefore(InsertColumnsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertColumnsBeforeHeaders headers = new InsertColumnsBeforeHeaders();
            return InsertColumnsBeforeWithOptions(request, headers, runtime);
        }

        public async Task<InsertColumnsBeforeResponse> InsertColumnsBeforeAsync(InsertColumnsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertColumnsBeforeHeaders headers = new InsertColumnsBeforeHeaders();
            return await InsertColumnsBeforeWithOptionsAsync(request, headers, runtime);
        }

        public InsertRowsBeforeResponse InsertRowsBeforeWithOptions(InsertRowsBeforeRequest tmpReq, InsertRowsBeforeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertRowsBeforeShrinkRequest request = new InsertRowsBeforeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            InsertRowsBeforeShrinkHeaders headers = new InsertRowsBeforeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRowsBefore",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/insertRowsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRowsBeforeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertRowsBeforeResponse> InsertRowsBeforeWithOptionsAsync(InsertRowsBeforeRequest tmpReq, InsertRowsBeforeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertRowsBeforeShrinkRequest request = new InsertRowsBeforeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            InsertRowsBeforeShrinkHeaders headers = new InsertRowsBeforeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRowsBefore",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/insertRowsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRowsBeforeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertRowsBeforeResponse InsertRowsBefore(InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return InsertRowsBeforeWithOptions(request, headers, runtime);
        }

        public async Task<InsertRowsBeforeResponse> InsertRowsBeforeAsync(InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return await InsertRowsBeforeWithOptionsAsync(request, headers, runtime);
        }

        public InviteUsersResponse InviteUsersWithOptions(InviteUsersRequest tmpReq, InviteUsersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InviteUsersShrinkRequest request = new InviteUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            InviteUsersShrinkHeaders headers = new InviteUsersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InviteeList))
            {
                request.InviteeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InviteeList, "InviteeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteeListShrink))
            {
                body["InviteeList"] = request.InviteeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteUsers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/inviteUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InviteUsersResponse> InviteUsersWithOptionsAsync(InviteUsersRequest tmpReq, InviteUsersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InviteUsersShrinkRequest request = new InviteUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            InviteUsersShrinkHeaders headers = new InviteUsersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InviteeList))
            {
                request.InviteeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InviteeList, "InviteeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteeListShrink))
            {
                body["InviteeList"] = request.InviteeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteUsers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/inviteUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InviteUsersResponse InviteUsers(InviteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InviteUsersHeaders headers = new InviteUsersHeaders();
            return InviteUsersWithOptions(request, headers, runtime);
        }

        public async Task<InviteUsersResponse> InviteUsersAsync(InviteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InviteUsersHeaders headers = new InviteUsersHeaders();
            return await InviteUsersWithOptionsAsync(request, headers, runtime);
        }

        public ListCalendarsResponse ListCalendarsWithOptions(ListCalendarsRequest tmpReq, ListCalendarsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCalendarsShrinkRequest request = new ListCalendarsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ListCalendarsShrinkHeaders headers = new ListCalendarsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCalendars",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/listCalendars",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCalendarsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCalendarsResponse> ListCalendarsWithOptionsAsync(ListCalendarsRequest tmpReq, ListCalendarsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCalendarsShrinkRequest request = new ListCalendarsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ListCalendarsShrinkHeaders headers = new ListCalendarsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCalendars",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/listCalendars",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCalendarsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCalendarsResponse ListCalendars(ListCalendarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCalendarsHeaders headers = new ListCalendarsHeaders();
            return ListCalendarsWithOptions(request, headers, runtime);
        }

        public async Task<ListCalendarsResponse> ListCalendarsAsync(ListCalendarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCalendarsHeaders headers = new ListCalendarsHeaders();
            return await ListCalendarsWithOptionsAsync(request, headers, runtime);
        }

        public ListEventsResponse ListEventsWithOptions(ListEventsRequest request, ListEventsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ListEventsShrinkHeaders headers = new ListEventsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                body["MaxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesMasterId))
            {
                body["SeriesMasterId"] = request.SeriesMasterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeleted))
            {
                body["ShowDeleted"] = request.ShowDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToken))
            {
                body["SyncToken"] = request.SyncToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                body["TimeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                body["TimeMin"] = request.TimeMin;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvents",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/listEvents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEventsResponse> ListEventsWithOptionsAsync(ListEventsRequest request, ListEventsHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ListEventsShrinkHeaders headers = new ListEventsShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttendees))
            {
                body["MaxAttendees"] = request.MaxAttendees;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesMasterId))
            {
                body["SeriesMasterId"] = request.SeriesMasterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeleted))
            {
                body["ShowDeleted"] = request.ShowDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToken))
            {
                body["SyncToken"] = request.SyncToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMax))
            {
                body["TimeMax"] = request.TimeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMin))
            {
                body["TimeMin"] = request.TimeMin;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvents",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/listEvents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEventsResponse ListEvents(ListEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return ListEventsWithOptions(request, headers, runtime);
        }

        public async Task<ListEventsResponse> ListEventsAsync(ListEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventsHeaders headers = new ListEventsHeaders();
            return await ListEventsWithOptionsAsync(request, headers, runtime);
        }

        public ListNodesResponse ListNodesWithOptions(ListNodesRequest tmpReq, ListNodesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNodesShrinkRequest request = new ListNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ListNodesShrinkHeaders headers = new ListNodesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentNodeId))
            {
                body["ParentNodeId"] = request.ParentNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                body["WithPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/listNodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest tmpReq, ListNodesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNodesShrinkRequest request = new ListNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ListNodesShrinkHeaders headers = new ListNodesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentNodeId))
            {
                body["ParentNodeId"] = request.ParentNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                body["WithPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/listNodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListNodesHeaders headers = new ListNodesHeaders();
            return ListNodesWithOptions(request, headers, runtime);
        }

        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListNodesHeaders headers = new ListNodesHeaders();
            return await ListNodesWithOptionsAsync(request, headers, runtime);
        }

        public ListReportResponse ListReportWithOptions(ListReportRequest tmpReq, ListReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListReportShrinkRequest request = new ListReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ListReportShrinkHeaders headers = new ListReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedEndTime))
            {
                body["ModifiedEndTime"] = request.ModifiedEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedStartTime))
            {
                body["ModifiedStartTime"] = request.ModifiedStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/listReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListReportResponse> ListReportWithOptionsAsync(ListReportRequest tmpReq, ListReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListReportShrinkRequest request = new ListReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ListReportShrinkHeaders headers = new ListReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedEndTime))
            {
                body["ModifiedEndTime"] = request.ModifiedEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedStartTime))
            {
                body["ModifiedStartTime"] = request.ModifiedStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/listReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListReportResponse ListReport(ListReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListReportHeaders headers = new ListReportHeaders();
            return ListReportWithOptions(request, headers, runtime);
        }

        public async Task<ListReportResponse> ListReportAsync(ListReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListReportHeaders headers = new ListReportHeaders();
            return await ListReportWithOptionsAsync(request, headers, runtime);
        }

        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest tmpReq, ListWorkspacesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ListWorkspacesShrinkHeaders headers = new ListWorkspacesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                body["TeamId"] = request.TeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                body["WithPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/listWorkspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest tmpReq, ListWorkspacesHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ListWorkspacesShrinkHeaders headers = new ListWorkspacesShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                body["TeamId"] = request.TeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                body["WithPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/listWorkspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListWorkspacesHeaders headers = new ListWorkspacesHeaders();
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListWorkspacesHeaders headers = new ListWorkspacesHeaders();
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        public PatchEventResponse PatchEventWithOptions(PatchEventRequest tmpReq, PatchEventHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PatchEventShrinkRequest request = new PatchEventShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            PatchEventShrinkHeaders headers = new PatchEventShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attendees))
            {
                request.AttendeesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attendees, "Attendees", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.End))
            {
                request.EndShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.End, "End", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Recurrence))
            {
                request.RecurrenceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Recurrence, "Recurrence", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Reminders))
            {
                request.RemindersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Reminders, "Reminders", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Start))
            {
                request.StartShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Start, "Start", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesShrink))
            {
                body["Attendees"] = request.AttendeesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndShrink))
            {
                body["End"] = request.EndShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["IsAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceShrink))
            {
                body["Recurrence"] = request.RecurrenceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemindersShrink))
            {
                body["Reminders"] = request.RemindersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartShrink))
            {
                body["Start"] = request.StartShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["Summary"] = request.Summary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PatchEvent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/patchEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PatchEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PatchEventResponse> PatchEventWithOptionsAsync(PatchEventRequest tmpReq, PatchEventHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PatchEventShrinkRequest request = new PatchEventShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            PatchEventShrinkHeaders headers = new PatchEventShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attendees))
            {
                request.AttendeesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attendees, "Attendees", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.End))
            {
                request.EndShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.End, "End", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Recurrence))
            {
                request.RecurrenceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Recurrence, "Recurrence", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Reminders))
            {
                request.RemindersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Reminders, "Reminders", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Start))
            {
                request.StartShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Start, "Start", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesShrink))
            {
                body["Attendees"] = request.AttendeesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndShrink))
            {
                body["End"] = request.EndShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllDay))
            {
                body["IsAllDay"] = request.IsAllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceShrink))
            {
                body["Recurrence"] = request.RecurrenceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemindersShrink))
            {
                body["Reminders"] = request.RemindersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartShrink))
            {
                body["Start"] = request.StartShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["Summary"] = request.Summary;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PatchEvent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/patchEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PatchEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PatchEventResponse PatchEvent(PatchEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return PatchEventWithOptions(request, headers, runtime);
        }

        public async Task<PatchEventResponse> PatchEventAsync(PatchEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchEventHeaders headers = new PatchEventHeaders();
            return await PatchEventWithOptionsAsync(request, headers, runtime);
        }

        public QueryCloudRecordTextResponse QueryCloudRecordTextWithOptions(QueryCloudRecordTextRequest tmpReq, QueryCloudRecordTextHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCloudRecordTextShrinkRequest request = new QueryCloudRecordTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryCloudRecordTextShrinkHeaders headers = new QueryCloudRecordTextShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                body["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCloudRecordText",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryCloudRecordText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordTextResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryCloudRecordTextResponse> QueryCloudRecordTextWithOptionsAsync(QueryCloudRecordTextRequest tmpReq, QueryCloudRecordTextHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCloudRecordTextShrinkRequest request = new QueryCloudRecordTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryCloudRecordTextShrinkHeaders headers = new QueryCloudRecordTextShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                body["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCloudRecordText",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryCloudRecordText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryCloudRecordTextResponse QueryCloudRecordText(QueryCloudRecordTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
            return QueryCloudRecordTextWithOptions(request, headers, runtime);
        }

        public async Task<QueryCloudRecordTextResponse> QueryCloudRecordTextAsync(QueryCloudRecordTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordTextHeaders headers = new QueryCloudRecordTextHeaders();
            return await QueryCloudRecordTextWithOptionsAsync(request, headers, runtime);
        }

        public QueryCloudRecordVideoResponse QueryCloudRecordVideoWithOptions(QueryCloudRecordVideoRequest tmpReq, QueryCloudRecordVideoHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCloudRecordVideoShrinkRequest request = new QueryCloudRecordVideoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryCloudRecordVideoShrinkHeaders headers = new QueryCloudRecordVideoShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCloudRecordVideo",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryCloudRecordVideo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryCloudRecordVideoResponse> QueryCloudRecordVideoWithOptionsAsync(QueryCloudRecordVideoRequest tmpReq, QueryCloudRecordVideoHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCloudRecordVideoShrinkRequest request = new QueryCloudRecordVideoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryCloudRecordVideoShrinkHeaders headers = new QueryCloudRecordVideoShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCloudRecordVideo",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryCloudRecordVideo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryCloudRecordVideoResponse QueryCloudRecordVideo(QueryCloudRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
            return QueryCloudRecordVideoWithOptions(request, headers, runtime);
        }

        public async Task<QueryCloudRecordVideoResponse> QueryCloudRecordVideoAsync(QueryCloudRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoHeaders headers = new QueryCloudRecordVideoHeaders();
            return await QueryCloudRecordVideoWithOptionsAsync(request, headers, runtime);
        }

        public QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfoWithOptions(QueryCloudRecordVideoPlayInfoRequest tmpReq, QueryCloudRecordVideoPlayInfoHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCloudRecordVideoPlayInfoShrinkRequest request = new QueryCloudRecordVideoPlayInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryCloudRecordVideoPlayInfoShrinkHeaders headers = new QueryCloudRecordVideoPlayInfoShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["ConferenceId"] = request.ConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCloudRecordVideoPlayInfo",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryCloudRecordVideoPlayInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoPlayInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryCloudRecordVideoPlayInfoResponse> QueryCloudRecordVideoPlayInfoWithOptionsAsync(QueryCloudRecordVideoPlayInfoRequest tmpReq, QueryCloudRecordVideoPlayInfoHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCloudRecordVideoPlayInfoShrinkRequest request = new QueryCloudRecordVideoPlayInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryCloudRecordVideoPlayInfoShrinkHeaders headers = new QueryCloudRecordVideoPlayInfoShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["ConferenceId"] = request.ConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCloudRecordVideoPlayInfo",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryCloudRecordVideoPlayInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCloudRecordVideoPlayInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfo(QueryCloudRecordVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
            return QueryCloudRecordVideoPlayInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryCloudRecordVideoPlayInfoResponse> QueryCloudRecordVideoPlayInfoAsync(QueryCloudRecordVideoPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCloudRecordVideoPlayInfoHeaders headers = new QueryCloudRecordVideoPlayInfoHeaders();
            return await QueryCloudRecordVideoPlayInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryConferenceInfoResponse QueryConferenceInfoWithOptions(QueryConferenceInfoRequest request, QueryConferenceInfoHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            QueryConferenceInfoShrinkHeaders headers = new QueryConferenceInfoShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConferenceInfo",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryConferenceInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryConferenceInfoResponse> QueryConferenceInfoWithOptionsAsync(QueryConferenceInfoRequest request, QueryConferenceInfoHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            QueryConferenceInfoShrinkHeaders headers = new QueryConferenceInfoShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConferenceInfo",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryConferenceInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryConferenceInfoResponse QueryConferenceInfo(QueryConferenceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoHeaders headers = new QueryConferenceInfoHeaders();
            return QueryConferenceInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryConferenceInfoResponse> QueryConferenceInfoAsync(QueryConferenceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceInfoHeaders headers = new QueryConferenceInfoHeaders();
            return await QueryConferenceInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryConferenceMembersResponse QueryConferenceMembersWithOptions(QueryConferenceMembersRequest tmpReq, QueryConferenceMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryConferenceMembersShrinkRequest request = new QueryConferenceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryConferenceMembersShrinkHeaders headers = new QueryConferenceMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConferenceMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryConferenceMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryConferenceMembersResponse> QueryConferenceMembersWithOptionsAsync(QueryConferenceMembersRequest tmpReq, QueryConferenceMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryConferenceMembersShrinkRequest request = new QueryConferenceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryConferenceMembersShrinkHeaders headers = new QueryConferenceMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConferenceMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryConferenceMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConferenceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryConferenceMembersResponse QueryConferenceMembers(QueryConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceMembersHeaders headers = new QueryConferenceMembersHeaders();
            return QueryConferenceMembersWithOptions(request, headers, runtime);
        }

        public async Task<QueryConferenceMembersResponse> QueryConferenceMembersAsync(QueryConferenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConferenceMembersHeaders headers = new QueryConferenceMembersHeaders();
            return await QueryConferenceMembersWithOptionsAsync(request, headers, runtime);
        }

        public QueryDentryResponse QueryDentryWithOptions(QueryDentryRequest tmpReq, QueryDentryHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryDentryShrinkRequest request = new QueryDentryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryDentryShrinkHeaders headers = new QueryDentryShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["DentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSpace))
            {
                body["IncludeSpace"] = request.IncludeSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["SpaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDentry",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/queryDentry",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDentryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDentryResponse> QueryDentryWithOptionsAsync(QueryDentryRequest tmpReq, QueryDentryHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryDentryShrinkRequest request = new QueryDentryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryDentryShrinkHeaders headers = new QueryDentryShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["DentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSpace))
            {
                body["IncludeSpace"] = request.IncludeSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["SpaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDentry",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v2/documents/queryDentry",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDentryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDentryResponse QueryDentry(QueryDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDentryHeaders headers = new QueryDentryHeaders();
            return QueryDentryWithOptions(request, headers, runtime);
        }

        public async Task<QueryDentryResponse> QueryDentryAsync(QueryDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDentryHeaders headers = new QueryDentryHeaders();
            return await QueryDentryWithOptionsAsync(request, headers, runtime);
        }

        public QueryLiveInfoResponse QueryLiveInfoWithOptions(QueryLiveInfoRequest tmpReq, QueryLiveInfoHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryLiveInfoShrinkRequest request = new QueryLiveInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryLiveInfoShrinkHeaders headers = new QueryLiveInfoShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveInfo",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryLiveInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLiveInfoResponse> QueryLiveInfoWithOptionsAsync(QueryLiveInfoRequest tmpReq, QueryLiveInfoHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryLiveInfoShrinkRequest request = new QueryLiveInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryLiveInfoShrinkHeaders headers = new QueryLiveInfoShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveInfo",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryLiveInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryLiveInfoResponse QueryLiveInfo(QueryLiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveInfoHeaders headers = new QueryLiveInfoHeaders();
            return QueryLiveInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryLiveInfoResponse> QueryLiveInfoAsync(QueryLiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveInfoHeaders headers = new QueryLiveInfoHeaders();
            return await QueryLiveInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryLiveWatchDetailResponse QueryLiveWatchDetailWithOptions(QueryLiveWatchDetailRequest tmpReq, QueryLiveWatchDetailHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryLiveWatchDetailShrinkRequest request = new QueryLiveWatchDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryLiveWatchDetailShrinkHeaders headers = new QueryLiveWatchDetailShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveWatchDetail",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryLiveWatchDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveWatchDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLiveWatchDetailResponse> QueryLiveWatchDetailWithOptionsAsync(QueryLiveWatchDetailRequest tmpReq, QueryLiveWatchDetailHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryLiveWatchDetailShrinkRequest request = new QueryLiveWatchDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryLiveWatchDetailShrinkHeaders headers = new QueryLiveWatchDetailShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveWatchDetail",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryLiveWatchDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveWatchDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryLiveWatchDetailResponse QueryLiveWatchDetail(QueryLiveWatchDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchDetailHeaders headers = new QueryLiveWatchDetailHeaders();
            return QueryLiveWatchDetailWithOptions(request, headers, runtime);
        }

        public async Task<QueryLiveWatchDetailResponse> QueryLiveWatchDetailAsync(QueryLiveWatchDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchDetailHeaders headers = new QueryLiveWatchDetailHeaders();
            return await QueryLiveWatchDetailWithOptionsAsync(request, headers, runtime);
        }

        public QueryLiveWatchUserListResponse QueryLiveWatchUserListWithOptions(QueryLiveWatchUserListRequest tmpReq, QueryLiveWatchUserListHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryLiveWatchUserListShrinkRequest request = new QueryLiveWatchUserListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryLiveWatchUserListShrinkHeaders headers = new QueryLiveWatchUserListShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveWatchUserList",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryLiveWatchUserList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveWatchUserListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLiveWatchUserListResponse> QueryLiveWatchUserListWithOptionsAsync(QueryLiveWatchUserListRequest tmpReq, QueryLiveWatchUserListHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryLiveWatchUserListShrinkRequest request = new QueryLiveWatchUserListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryLiveWatchUserListShrinkHeaders headers = new QueryLiveWatchUserListShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveWatchUserList",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryLiveWatchUserList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveWatchUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryLiveWatchUserListResponse QueryLiveWatchUserList(QueryLiveWatchUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchUserListHeaders headers = new QueryLiveWatchUserListHeaders();
            return QueryLiveWatchUserListWithOptions(request, headers, runtime);
        }

        public async Task<QueryLiveWatchUserListResponse> QueryLiveWatchUserListAsync(QueryLiveWatchUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryLiveWatchUserListHeaders headers = new QueryLiveWatchUserListHeaders();
            return await QueryLiveWatchUserListWithOptionsAsync(request, headers, runtime);
        }

        public QueryMeetingRoomResponse QueryMeetingRoomWithOptions(QueryMeetingRoomRequest tmpReq, QueryMeetingRoomHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMeetingRoomShrinkRequest request = new QueryMeetingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryMeetingRoomShrinkHeaders headers = new QueryMeetingRoomShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["RoomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoom",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryMeetingRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMeetingRoomResponse> QueryMeetingRoomWithOptionsAsync(QueryMeetingRoomRequest tmpReq, QueryMeetingRoomHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMeetingRoomShrinkRequest request = new QueryMeetingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryMeetingRoomShrinkHeaders headers = new QueryMeetingRoomShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["RoomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoom",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryMeetingRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMeetingRoomResponse QueryMeetingRoom(QueryMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomHeaders headers = new QueryMeetingRoomHeaders();
            return QueryMeetingRoomWithOptions(request, headers, runtime);
        }

        public async Task<QueryMeetingRoomResponse> QueryMeetingRoomAsync(QueryMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomHeaders headers = new QueryMeetingRoomHeaders();
            return await QueryMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        public QueryMeetingRoomGroupResponse QueryMeetingRoomGroupWithOptions(QueryMeetingRoomGroupRequest tmpReq, QueryMeetingRoomGroupHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMeetingRoomGroupShrinkRequest request = new QueryMeetingRoomGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryMeetingRoomGroupShrinkHeaders headers = new QueryMeetingRoomGroupShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroup",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryMeetingRoomGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMeetingRoomGroupResponse> QueryMeetingRoomGroupWithOptionsAsync(QueryMeetingRoomGroupRequest tmpReq, QueryMeetingRoomGroupHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMeetingRoomGroupShrinkRequest request = new QueryMeetingRoomGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryMeetingRoomGroupShrinkHeaders headers = new QueryMeetingRoomGroupShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroup",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryMeetingRoomGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMeetingRoomGroupResponse QueryMeetingRoomGroup(QueryMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupHeaders headers = new QueryMeetingRoomGroupHeaders();
            return QueryMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        public async Task<QueryMeetingRoomGroupResponse> QueryMeetingRoomGroupAsync(QueryMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupHeaders headers = new QueryMeetingRoomGroupHeaders();
            return await QueryMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

        public QueryMeetingRoomGroupListResponse QueryMeetingRoomGroupListWithOptions(QueryMeetingRoomGroupListRequest tmpReq, QueryMeetingRoomGroupListHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMeetingRoomGroupListShrinkRequest request = new QueryMeetingRoomGroupListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryMeetingRoomGroupListShrinkHeaders headers = new QueryMeetingRoomGroupListShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroupList",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryMeetingRoomGroupList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMeetingRoomGroupListResponse> QueryMeetingRoomGroupListWithOptionsAsync(QueryMeetingRoomGroupListRequest tmpReq, QueryMeetingRoomGroupListHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMeetingRoomGroupListShrinkRequest request = new QueryMeetingRoomGroupListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryMeetingRoomGroupListShrinkHeaders headers = new QueryMeetingRoomGroupListShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroupList",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryMeetingRoomGroupList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMeetingRoomGroupListResponse QueryMeetingRoomGroupList(QueryMeetingRoomGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupListHeaders headers = new QueryMeetingRoomGroupListHeaders();
            return QueryMeetingRoomGroupListWithOptions(request, headers, runtime);
        }

        public async Task<QueryMeetingRoomGroupListResponse> QueryMeetingRoomGroupListAsync(QueryMeetingRoomGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupListHeaders headers = new QueryMeetingRoomGroupListHeaders();
            return await QueryMeetingRoomGroupListWithOptionsAsync(request, headers, runtime);
        }

        public QueryMeetingRoomListResponse QueryMeetingRoomListWithOptions(QueryMeetingRoomListRequest tmpReq, QueryMeetingRoomListHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMeetingRoomListShrinkRequest request = new QueryMeetingRoomListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryMeetingRoomListShrinkHeaders headers = new QueryMeetingRoomListShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomList",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryMeetingRoomList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMeetingRoomListResponse> QueryMeetingRoomListWithOptionsAsync(QueryMeetingRoomListRequest tmpReq, QueryMeetingRoomListHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMeetingRoomListShrinkRequest request = new QueryMeetingRoomListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryMeetingRoomListShrinkHeaders headers = new QueryMeetingRoomListShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomList",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryMeetingRoomList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMeetingRoomListResponse QueryMeetingRoomList(QueryMeetingRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomListHeaders headers = new QueryMeetingRoomListHeaders();
            return QueryMeetingRoomListWithOptions(request, headers, runtime);
        }

        public async Task<QueryMeetingRoomListResponse> QueryMeetingRoomListAsync(QueryMeetingRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomListHeaders headers = new QueryMeetingRoomListHeaders();
            return await QueryMeetingRoomListWithOptionsAsync(request, headers, runtime);
        }

        public QueryOrgTodoTasksResponse QueryOrgTodoTasksWithOptions(QueryOrgTodoTasksRequest tmpReq, QueryOrgTodoTasksHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryOrgTodoTasksShrinkRequest request = new QueryOrgTodoTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryOrgTodoTasksShrinkHeaders headers = new QueryOrgTodoTasksShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrgTodoTasks",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/queryOrgTodoTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgTodoTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrgTodoTasksResponse> QueryOrgTodoTasksWithOptionsAsync(QueryOrgTodoTasksRequest tmpReq, QueryOrgTodoTasksHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryOrgTodoTasksShrinkRequest request = new QueryOrgTodoTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryOrgTodoTasksShrinkHeaders headers = new QueryOrgTodoTasksShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrgTodoTasks",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/queryOrgTodoTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgTodoTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOrgTodoTasksResponse QueryOrgTodoTasks(QueryOrgTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTodoTasksHeaders headers = new QueryOrgTodoTasksHeaders();
            return QueryOrgTodoTasksWithOptions(request, headers, runtime);
        }

        public async Task<QueryOrgTodoTasksResponse> QueryOrgTodoTasksAsync(QueryOrgTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTodoTasksHeaders headers = new QueryOrgTodoTasksHeaders();
            return await QueryOrgTodoTasksWithOptionsAsync(request, headers, runtime);
        }

        public QueryScheduleConferenceResponse QueryScheduleConferenceWithOptions(QueryScheduleConferenceRequest tmpReq, QueryScheduleConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryScheduleConferenceShrinkRequest request = new QueryScheduleConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryScheduleConferenceShrinkHeaders headers = new QueryScheduleConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUnionId))
            {
                body["RequestUnionId"] = request.RequestUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScheduleConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryScheduleConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryScheduleConferenceResponse> QueryScheduleConferenceWithOptionsAsync(QueryScheduleConferenceRequest tmpReq, QueryScheduleConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryScheduleConferenceShrinkRequest request = new QueryScheduleConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            QueryScheduleConferenceShrinkHeaders headers = new QueryScheduleConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUnionId))
            {
                body["RequestUnionId"] = request.RequestUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScheduleConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/queryScheduleConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScheduleConferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryScheduleConferenceResponse QueryScheduleConference(QueryScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceHeaders headers = new QueryScheduleConferenceHeaders();
            return QueryScheduleConferenceWithOptions(request, headers, runtime);
        }

        public async Task<QueryScheduleConferenceResponse> QueryScheduleConferenceAsync(QueryScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScheduleConferenceHeaders headers = new QueryScheduleConferenceHeaders();
            return await QueryScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        public ReceiverListReportResponse ReceiverListReportWithOptions(ReceiverListReportRequest tmpReq, ReceiverListReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReceiverListReportShrinkRequest request = new ReceiverListReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ReceiverListReportShrinkHeaders headers = new ReceiverListReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReceiverListReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/receiverListReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReceiverListReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReceiverListReportResponse> ReceiverListReportWithOptionsAsync(ReceiverListReportRequest tmpReq, ReceiverListReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReceiverListReportShrinkRequest request = new ReceiverListReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            ReceiverListReportShrinkHeaders headers = new ReceiverListReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReceiverListReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/receiverListReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReceiverListReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReceiverListReportResponse ReceiverListReport(ReceiverListReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReceiverListReportHeaders headers = new ReceiverListReportHeaders();
            return ReceiverListReportWithOptions(request, headers, runtime);
        }

        public async Task<ReceiverListReportResponse> ReceiverListReportAsync(ReceiverListReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReceiverListReportHeaders headers = new ReceiverListReportHeaders();
            return await ReceiverListReportWithOptionsAsync(request, headers, runtime);
        }

        public RemoveAttendeeResponse RemoveAttendeeWithOptions(RemoveAttendeeRequest tmpReq, RemoveAttendeeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveAttendeeShrinkRequest request = new RemoveAttendeeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            RemoveAttendeeShrinkHeaders headers = new RemoveAttendeeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AttendeesToRemove))
            {
                request.AttendeesToRemoveShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AttendeesToRemove, "AttendeesToRemove", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToRemoveShrink))
            {
                body["AttendeesToRemove"] = request.AttendeesToRemoveShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAttendee",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/removeAttendee",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAttendeeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveAttendeeResponse> RemoveAttendeeWithOptionsAsync(RemoveAttendeeRequest tmpReq, RemoveAttendeeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveAttendeeShrinkRequest request = new RemoveAttendeeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            RemoveAttendeeShrinkHeaders headers = new RemoveAttendeeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AttendeesToRemove))
            {
                request.AttendeesToRemoveShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AttendeesToRemove, "AttendeesToRemove", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttendeesToRemoveShrink))
            {
                body["AttendeesToRemove"] = request.AttendeesToRemoveShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalendarId))
            {
                body["CalendarId"] = request.CalendarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["EventId"] = request.EventId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAttendee",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/calendar/removeAttendee",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAttendeeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveAttendeeResponse RemoveAttendee(RemoveAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return RemoveAttendeeWithOptions(request, headers, runtime);
        }

        public async Task<RemoveAttendeeResponse> RemoveAttendeeAsync(RemoveAttendeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveAttendeeHeaders headers = new RemoveAttendeeHeaders();
            return await RemoveAttendeeWithOptionsAsync(request, headers, runtime);
        }

        public SaveContentResponse SaveContentWithOptions(SaveContentRequest tmpReq, SaveContentHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveContentShrinkRequest request = new SaveContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            SaveContentShrinkHeaders headers = new SaveContentShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "Contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["Contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdFrom))
            {
                body["DdFrom"] = request.DdFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/saveContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveContentResponse> SaveContentWithOptionsAsync(SaveContentRequest tmpReq, SaveContentHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveContentShrinkRequest request = new SaveContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            SaveContentShrinkHeaders headers = new SaveContentShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "Contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["Contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdFrom))
            {
                body["DdFrom"] = request.DdFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContent",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/saveContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveContentResponse SaveContent(SaveContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveContentHeaders headers = new SaveContentHeaders();
            return SaveContentWithOptions(request, headers, runtime);
        }

        public async Task<SaveContentResponse> SaveContentAsync(SaveContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveContentHeaders headers = new SaveContentHeaders();
            return await SaveContentWithOptionsAsync(request, headers, runtime);
        }

        public SetColumnsVisibilityResponse SetColumnsVisibilityWithOptions(SetColumnsVisibilityRequest tmpReq, SetColumnsVisibilityHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetColumnsVisibilityShrinkRequest request = new SetColumnsVisibilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            SetColumnsVisibilityShrinkHeaders headers = new SetColumnsVisibilityShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["ColumnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetColumnsVisibility",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/setColumnsVisibility",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetColumnsVisibilityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetColumnsVisibilityResponse> SetColumnsVisibilityWithOptionsAsync(SetColumnsVisibilityRequest tmpReq, SetColumnsVisibilityHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetColumnsVisibilityShrinkRequest request = new SetColumnsVisibilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            SetColumnsVisibilityShrinkHeaders headers = new SetColumnsVisibilityShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["ColumnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetColumnsVisibility",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/setColumnsVisibility",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetColumnsVisibilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetColumnsVisibilityResponse SetColumnsVisibility(SetColumnsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsVisibilityHeaders headers = new SetColumnsVisibilityHeaders();
            return SetColumnsVisibilityWithOptions(request, headers, runtime);
        }

        public async Task<SetColumnsVisibilityResponse> SetColumnsVisibilityAsync(SetColumnsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsVisibilityHeaders headers = new SetColumnsVisibilityHeaders();
            return await SetColumnsVisibilityWithOptionsAsync(request, headers, runtime);
        }

        public SetRowsVisibilityResponse SetRowsVisibilityWithOptions(SetRowsVisibilityRequest tmpReq, SetRowsVisibilityHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetRowsVisibilityShrinkRequest request = new SetRowsVisibilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            SetRowsVisibilityShrinkHeaders headers = new SetRowsVisibilityShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRowsVisibility",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/setRowsVisibility",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRowsVisibilityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetRowsVisibilityResponse> SetRowsVisibilityWithOptionsAsync(SetRowsVisibilityRequest tmpReq, SetRowsVisibilityHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetRowsVisibilityShrinkRequest request = new SetRowsVisibilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            SetRowsVisibilityShrinkHeaders headers = new SetRowsVisibilityShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRowsVisibility",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/setRowsVisibility",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRowsVisibilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetRowsVisibilityResponse SetRowsVisibility(SetRowsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsVisibilityHeaders headers = new SetRowsVisibilityHeaders();
            return SetRowsVisibilityWithOptions(request, headers, runtime);
        }

        public async Task<SetRowsVisibilityResponse> SetRowsVisibilityAsync(SetRowsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsVisibilityHeaders headers = new SetRowsVisibilityHeaders();
            return await SetRowsVisibilityWithOptionsAsync(request, headers, runtime);
        }

        public SimpleListReportResponse SimpleListReportWithOptions(SimpleListReportRequest tmpReq, SimpleListReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SimpleListReportShrinkRequest request = new SimpleListReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            SimpleListReportShrinkHeaders headers = new SimpleListReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SimpleListReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/simpleListReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SimpleListReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SimpleListReportResponse> SimpleListReportWithOptionsAsync(SimpleListReportRequest tmpReq, SimpleListReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SimpleListReportShrinkRequest request = new SimpleListReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            SimpleListReportShrinkHeaders headers = new SimpleListReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SimpleListReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/simpleListReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SimpleListReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SimpleListReportResponse SimpleListReport(SimpleListReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SimpleListReportHeaders headers = new SimpleListReportHeaders();
            return SimpleListReportWithOptions(request, headers, runtime);
        }

        public async Task<SimpleListReportResponse> SimpleListReportAsync(SimpleListReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SimpleListReportHeaders headers = new SimpleListReportHeaders();
            return await SimpleListReportWithOptionsAsync(request, headers, runtime);
        }

        public StartCloudRecordResponse StartCloudRecordWithOptions(StartCloudRecordRequest tmpReq, StartCloudRecordHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartCloudRecordShrinkRequest request = new StartCloudRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            StartCloudRecordShrinkHeaders headers = new StartCloudRecordShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["SmallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudRecord",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/startCloudRecord",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartCloudRecordResponse> StartCloudRecordWithOptionsAsync(StartCloudRecordRequest tmpReq, StartCloudRecordHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartCloudRecordShrinkRequest request = new StartCloudRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            StartCloudRecordShrinkHeaders headers = new StartCloudRecordShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmallWindowPosition))
            {
                body["SmallWindowPosition"] = request.SmallWindowPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudRecord",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/startCloudRecord",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartCloudRecordResponse StartCloudRecord(StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
            return StartCloudRecordWithOptions(request, headers, runtime);
        }

        public async Task<StartCloudRecordResponse> StartCloudRecordAsync(StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartCloudRecordHeaders headers = new StartCloudRecordHeaders();
            return await StartCloudRecordWithOptionsAsync(request, headers, runtime);
        }

        public StatisticsListByTypeReportResponse StatisticsListByTypeReportWithOptions(StatisticsListByTypeReportRequest tmpReq, StatisticsListByTypeReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StatisticsListByTypeReportShrinkRequest request = new StatisticsListByTypeReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            StatisticsListByTypeReportShrinkHeaders headers = new StatisticsListByTypeReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StatisticsListByTypeReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/statisticsListByTypeReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StatisticsListByTypeReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StatisticsListByTypeReportResponse> StatisticsListByTypeReportWithOptionsAsync(StatisticsListByTypeReportRequest tmpReq, StatisticsListByTypeReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StatisticsListByTypeReportShrinkRequest request = new StatisticsListByTypeReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            StatisticsListByTypeReportShrinkHeaders headers = new StatisticsListByTypeReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StatisticsListByTypeReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/statisticsListByTypeReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StatisticsListByTypeReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StatisticsListByTypeReportResponse StatisticsListByTypeReport(StatisticsListByTypeReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StatisticsListByTypeReportHeaders headers = new StatisticsListByTypeReportHeaders();
            return StatisticsListByTypeReportWithOptions(request, headers, runtime);
        }

        public async Task<StatisticsListByTypeReportResponse> StatisticsListByTypeReportAsync(StatisticsListByTypeReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StatisticsListByTypeReportHeaders headers = new StatisticsListByTypeReportHeaders();
            return await StatisticsListByTypeReportWithOptionsAsync(request, headers, runtime);
        }

        public StatisticsReportResponse StatisticsReportWithOptions(StatisticsReportRequest tmpReq, StatisticsReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StatisticsReportShrinkRequest request = new StatisticsReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            StatisticsReportShrinkHeaders headers = new StatisticsReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StatisticsReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/statisticsReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StatisticsReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StatisticsReportResponse> StatisticsReportWithOptionsAsync(StatisticsReportRequest tmpReq, StatisticsReportHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StatisticsReportShrinkRequest request = new StatisticsReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            StatisticsReportShrinkHeaders headers = new StatisticsReportShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StatisticsReport",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/log/statisticsReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StatisticsReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StatisticsReportResponse StatisticsReport(StatisticsReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StatisticsReportHeaders headers = new StatisticsReportHeaders();
            return StatisticsReportWithOptions(request, headers, runtime);
        }

        public async Task<StatisticsReportResponse> StatisticsReportAsync(StatisticsReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StatisticsReportHeaders headers = new StatisticsReportHeaders();
            return await StatisticsReportWithOptionsAsync(request, headers, runtime);
        }

        public StopCloudRecordResponse StopCloudRecordWithOptions(StopCloudRecordRequest tmpReq, StopCloudRecordHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopCloudRecordShrinkRequest request = new StopCloudRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            StopCloudRecordShrinkHeaders headers = new StopCloudRecordShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCloudRecord",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/stopCloudRecord",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopCloudRecordResponse> StopCloudRecordWithOptionsAsync(StopCloudRecordRequest tmpReq, StopCloudRecordHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopCloudRecordShrinkRequest request = new StopCloudRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            StopCloudRecordShrinkHeaders headers = new StopCloudRecordShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCloudRecord",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/stopCloudRecord",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopCloudRecordResponse StopCloudRecord(StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
            return StopCloudRecordWithOptions(request, headers, runtime);
        }

        public async Task<StopCloudRecordResponse> StopCloudRecordAsync(StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopCloudRecordHeaders headers = new StopCloudRecordHeaders();
            return await StopCloudRecordWithOptionsAsync(request, headers, runtime);
        }

        public UpdateLiveResponse UpdateLiveWithOptions(UpdateLiveRequest tmpReq, UpdateLiveHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLiveShrinkRequest request = new UpdateLiveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateLiveShrinkHeaders headers = new UpdateLiveShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["Introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEndTime))
            {
                body["PreEndTime"] = request.PreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStartTime))
            {
                body["PreStartTime"] = request.PreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLive",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/updateLive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateLiveResponse> UpdateLiveWithOptionsAsync(UpdateLiveRequest tmpReq, UpdateLiveHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLiveShrinkRequest request = new UpdateLiveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateLiveShrinkHeaders headers = new UpdateLiveShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["Introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveId))
            {
                body["LiveId"] = request.LiveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEndTime))
            {
                body["PreEndTime"] = request.PreEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStartTime))
            {
                body["PreStartTime"] = request.PreStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLive",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/updateLive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateLiveResponse UpdateLive(UpdateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveHeaders headers = new UpdateLiveHeaders();
            return UpdateLiveWithOptions(request, headers, runtime);
        }

        public async Task<UpdateLiveResponse> UpdateLiveAsync(UpdateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateLiveHeaders headers = new UpdateLiveHeaders();
            return await UpdateLiveWithOptionsAsync(request, headers, runtime);
        }

        public UpdateMeetingRoomResponse UpdateMeetingRoomWithOptions(UpdateMeetingRoomRequest tmpReq, UpdateMeetingRoomHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMeetingRoomShrinkRequest request = new UpdateMeetingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateMeetingRoomShrinkHeaders headers = new UpdateMeetingRoomShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomLabelIds))
            {
                request.RoomLabelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomLabelIds, "RoomLabelIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomLocation))
            {
                request.RoomLocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomLocation, "RoomLocation", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["IsvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["RoomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["RoomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIdsShrink))
            {
                body["RoomLabelIds"] = request.RoomLabelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocationShrink))
            {
                body["RoomLocation"] = request.RoomLocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["RoomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["RoomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoom",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/updateMeetingRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMeetingRoomResponse> UpdateMeetingRoomWithOptionsAsync(UpdateMeetingRoomRequest tmpReq, UpdateMeetingRoomHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMeetingRoomShrinkRequest request = new UpdateMeetingRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateMeetingRoomShrinkHeaders headers = new UpdateMeetingRoomShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomLabelIds))
            {
                request.RoomLabelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomLabelIds, "RoomLabelIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomLocation))
            {
                request.RoomLocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomLocation, "RoomLocation", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["IsvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["RoomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["RoomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIdsShrink))
            {
                body["RoomLabelIds"] = request.RoomLabelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocationShrink))
            {
                body["RoomLocation"] = request.RoomLocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["RoomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["RoomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoom",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/updateMeetingRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMeetingRoomResponse UpdateMeetingRoom(UpdateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomHeaders headers = new UpdateMeetingRoomHeaders();
            return UpdateMeetingRoomWithOptions(request, headers, runtime);
        }

        public async Task<UpdateMeetingRoomResponse> UpdateMeetingRoomAsync(UpdateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomHeaders headers = new UpdateMeetingRoomHeaders();
            return await UpdateMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        public UpdateMeetingRoomGroupResponse UpdateMeetingRoomGroupWithOptions(UpdateMeetingRoomGroupRequest tmpReq, UpdateMeetingRoomGroupHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMeetingRoomGroupShrinkRequest request = new UpdateMeetingRoomGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateMeetingRoomGroupShrinkHeaders headers = new UpdateMeetingRoomGroupShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoomGroup",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/updateMeetingRoomGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMeetingRoomGroupResponse> UpdateMeetingRoomGroupWithOptionsAsync(UpdateMeetingRoomGroupRequest tmpReq, UpdateMeetingRoomGroupHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMeetingRoomGroupShrinkRequest request = new UpdateMeetingRoomGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateMeetingRoomGroupShrinkHeaders headers = new UpdateMeetingRoomGroupShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoomGroup",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/updateMeetingRoomGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMeetingRoomGroupResponse UpdateMeetingRoomGroup(UpdateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomGroupHeaders headers = new UpdateMeetingRoomGroupHeaders();
            return UpdateMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        public async Task<UpdateMeetingRoomGroupResponse> UpdateMeetingRoomGroupAsync(UpdateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomGroupHeaders headers = new UpdateMeetingRoomGroupHeaders();
            return await UpdateMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

        public UpdateRangeResponse UpdateRangeWithOptions(UpdateRangeRequest tmpReq, UpdateRangeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateRangeShrinkRequest request = new UpdateRangeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateRangeShrinkHeaders headers = new UpdateRangeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BackgroundColors))
            {
                request.BackgroundColorsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BackgroundColors, "BackgroundColors", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Hyperlinks))
            {
                request.HyperlinksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Hyperlinks, "Hyperlinks", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Values))
            {
                request.ValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Values, "Values", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColorsShrink))
            {
                body["BackgroundColors"] = request.BackgroundColorsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HyperlinksShrink))
            {
                body["Hyperlinks"] = request.HyperlinksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberFormat))
            {
                body["NumberFormat"] = request.NumberFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeAddress))
            {
                body["RangeAddress"] = request.RangeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValuesShrink))
            {
                body["Values"] = request.ValuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRange",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/updateRange",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRangeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRangeResponse> UpdateRangeWithOptionsAsync(UpdateRangeRequest tmpReq, UpdateRangeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateRangeShrinkRequest request = new UpdateRangeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateRangeShrinkHeaders headers = new UpdateRangeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BackgroundColors))
            {
                request.BackgroundColorsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BackgroundColors, "BackgroundColors", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Hyperlinks))
            {
                request.HyperlinksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Hyperlinks, "Hyperlinks", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Values))
            {
                request.ValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Values, "Values", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColorsShrink))
            {
                body["BackgroundColors"] = request.BackgroundColorsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HyperlinksShrink))
            {
                body["Hyperlinks"] = request.HyperlinksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberFormat))
            {
                body["NumberFormat"] = request.NumberFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeAddress))
            {
                body["RangeAddress"] = request.RangeAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValuesShrink))
            {
                body["Values"] = request.ValuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRange",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/updateRange",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRangeResponse UpdateRange(UpdateRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRangeHeaders headers = new UpdateRangeHeaders();
            return UpdateRangeWithOptions(request, headers, runtime);
        }

        public async Task<UpdateRangeResponse> UpdateRangeAsync(UpdateRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRangeHeaders headers = new UpdateRangeHeaders();
            return await UpdateRangeWithOptionsAsync(request, headers, runtime);
        }

        public UpdateScheduleConferenceResponse UpdateScheduleConferenceWithOptions(UpdateScheduleConferenceRequest tmpReq, UpdateScheduleConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateScheduleConferenceShrinkRequest request = new UpdateScheduleConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateScheduleConferenceShrinkHeaders headers = new UpdateScheduleConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["ScheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduleConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/updateScheduleConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateScheduleConferenceResponse> UpdateScheduleConferenceWithOptionsAsync(UpdateScheduleConferenceRequest tmpReq, UpdateScheduleConferenceHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateScheduleConferenceShrinkRequest request = new UpdateScheduleConferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateScheduleConferenceShrinkHeaders headers = new UpdateScheduleConferenceShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConferenceId))
            {
                body["ScheduleConferenceId"] = request.ScheduleConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduleConference",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/ysp/updateScheduleConference",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleConferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateScheduleConferenceResponse UpdateScheduleConference(UpdateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConferenceHeaders headers = new UpdateScheduleConferenceHeaders();
            return UpdateScheduleConferenceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateScheduleConferenceResponse> UpdateScheduleConferenceAsync(UpdateScheduleConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduleConferenceHeaders headers = new UpdateScheduleConferenceHeaders();
            return await UpdateScheduleConferenceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateTodoTaskResponse UpdateTodoTaskWithOptions(UpdateTodoTaskRequest tmpReq, UpdateTodoTaskHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTodoTaskShrinkRequest request = new UpdateTodoTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateTodoTaskShrinkHeaders headers = new UpdateTodoTaskShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutorIds))
            {
                request.ExecutorIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutorIds, "executorIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParticipantIds))
            {
                request.ParticipantIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParticipantIds, "participantIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Done))
            {
                body["done"] = request.Done;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIdsShrink))
            {
                body["executorIds"] = request.ExecutorIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIdsShrink))
            {
                body["participantIds"] = request.ParticipantIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTodoTask",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/updateTodoTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTodoTaskResponse> UpdateTodoTaskWithOptionsAsync(UpdateTodoTaskRequest tmpReq, UpdateTodoTaskHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTodoTaskShrinkRequest request = new UpdateTodoTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateTodoTaskShrinkHeaders headers = new UpdateTodoTaskShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutorIds))
            {
                request.ExecutorIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutorIds, "executorIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParticipantIds))
            {
                request.ParticipantIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParticipantIds, "participantIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Done))
            {
                body["done"] = request.Done;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIdsShrink))
            {
                body["executorIds"] = request.ExecutorIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIdsShrink))
            {
                body["participantIds"] = request.ParticipantIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTodoTask",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/updateTodoTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTodoTaskResponse UpdateTodoTask(UpdateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskHeaders headers = new UpdateTodoTaskHeaders();
            return UpdateTodoTaskWithOptions(request, headers, runtime);
        }

        public async Task<UpdateTodoTaskResponse> UpdateTodoTaskAsync(UpdateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskHeaders headers = new UpdateTodoTaskHeaders();
            return await UpdateTodoTaskWithOptionsAsync(request, headers, runtime);
        }

        public UpdateTodoTaskExecutorStatusResponse UpdateTodoTaskExecutorStatusWithOptions(UpdateTodoTaskExecutorStatusRequest tmpReq, UpdateTodoTaskExecutorStatusHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTodoTaskExecutorStatusShrinkRequest request = new UpdateTodoTaskExecutorStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateTodoTaskExecutorStatusShrinkHeaders headers = new UpdateTodoTaskExecutorStatusShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutorStatusList))
            {
                request.ExecutorStatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutorStatusList, "executorStatusList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorStatusListShrink))
            {
                body["executorStatusList"] = request.ExecutorStatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTodoTaskExecutorStatus",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/updateTodoTaskExecutorStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTaskExecutorStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTodoTaskExecutorStatusResponse> UpdateTodoTaskExecutorStatusWithOptionsAsync(UpdateTodoTaskExecutorStatusRequest tmpReq, UpdateTodoTaskExecutorStatusHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTodoTaskExecutorStatusShrinkRequest request = new UpdateTodoTaskExecutorStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateTodoTaskExecutorStatusShrinkHeaders headers = new UpdateTodoTaskExecutorStatusShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutorStatusList))
            {
                request.ExecutorStatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutorStatusList, "executorStatusList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorStatusListShrink))
            {
                body["executorStatusList"] = request.ExecutorStatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTodoTaskExecutorStatus",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/task/updateTodoTaskExecutorStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTaskExecutorStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTodoTaskExecutorStatusResponse UpdateTodoTaskExecutorStatus(UpdateTodoTaskExecutorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskExecutorStatusHeaders headers = new UpdateTodoTaskExecutorStatusHeaders();
            return UpdateTodoTaskExecutorStatusWithOptions(request, headers, runtime);
        }

        public async Task<UpdateTodoTaskExecutorStatusResponse> UpdateTodoTaskExecutorStatusAsync(UpdateTodoTaskExecutorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskExecutorStatusHeaders headers = new UpdateTodoTaskExecutorStatusHeaders();
            return await UpdateTodoTaskExecutorStatusWithOptionsAsync(request, headers, runtime);
        }

        public UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembersWithOptions(UpdateWorkspaceDocMembersRequest tmpReq, UpdateWorkspaceDocMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkspaceDocMembersShrinkRequest request = new UpdateWorkspaceDocMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateWorkspaceDocMembersShrinkHeaders headers = new UpdateWorkspaceDocMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceDocMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/updateWorkspaceDocMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceDocMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateWorkspaceDocMembersResponse> UpdateWorkspaceDocMembersWithOptionsAsync(UpdateWorkspaceDocMembersRequest tmpReq, UpdateWorkspaceDocMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkspaceDocMembersShrinkRequest request = new UpdateWorkspaceDocMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateWorkspaceDocMembersShrinkHeaders headers = new UpdateWorkspaceDocMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceDocMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/updateWorkspaceDocMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceDocMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembers(UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return UpdateWorkspaceDocMembersWithOptions(request, headers, runtime);
        }

        public async Task<UpdateWorkspaceDocMembersResponse> UpdateWorkspaceDocMembersAsync(UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return await UpdateWorkspaceDocMembersWithOptionsAsync(request, headers, runtime);
        }

        public UpdateWorkspaceMembersResponse UpdateWorkspaceMembersWithOptions(UpdateWorkspaceMembersRequest tmpReq, UpdateWorkspaceMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkspaceMembersShrinkRequest request = new UpdateWorkspaceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateWorkspaceMembersShrinkHeaders headers = new UpdateWorkspaceMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/updateWorkspaceMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateWorkspaceMembersResponse> UpdateWorkspaceMembersWithOptionsAsync(UpdateWorkspaceMembersRequest tmpReq, UpdateWorkspaceMembersHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkspaceMembersShrinkRequest request = new UpdateWorkspaceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            UpdateWorkspaceMembersShrinkHeaders headers = new UpdateWorkspaceMembersShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "Members", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["Members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceMembers",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/updateWorkspaceMembers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateWorkspaceMembersResponse UpdateWorkspaceMembers(UpdateWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceMembersHeaders headers = new UpdateWorkspaceMembersHeaders();
            return UpdateWorkspaceMembersWithOptions(request, headers, runtime);
        }

        public async Task<UpdateWorkspaceMembersResponse> UpdateWorkspaceMembersAsync(UpdateWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceMembersHeaders headers = new UpdateWorkspaceMembersHeaders();
            return await UpdateWorkspaceMembersWithOptionsAsync(request, headers, runtime);
        }

    }
}
