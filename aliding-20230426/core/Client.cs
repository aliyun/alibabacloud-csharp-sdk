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
