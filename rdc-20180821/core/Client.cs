// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Rdc20180821.Models;

namespace AlibabaCloud.SDK.Rdc20180821
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("rdc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddEnterpriseMemberResponse AddEnterpriseMemberWithOptions(AddEnterpriseMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddEnterpriseMemberResponse>(DoRPCRequest("AddEnterpriseMember", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddEnterpriseMemberResponse> AddEnterpriseMemberWithOptionsAsync(AddEnterpriseMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddEnterpriseMemberResponse>(await DoRPCRequestAsync("AddEnterpriseMember", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddEnterpriseMemberResponse AddEnterpriseMember(AddEnterpriseMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEnterpriseMemberWithOptions(request, runtime);
        }

        public async Task<AddEnterpriseMemberResponse> AddEnterpriseMemberAsync(AddEnterpriseMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEnterpriseMemberWithOptionsAsync(request, runtime);
        }

        public AddRamMemberResponse AddRamMemberWithOptions(AddRamMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRamMemberResponse>(DoRPCRequest("AddRamMember", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddRamMemberResponse> AddRamMemberWithOptionsAsync(AddRamMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRamMemberResponse>(await DoRPCRequestAsync("AddRamMember", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddRamMemberResponse AddRamMember(AddRamMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRamMemberWithOptions(request, runtime);
        }

        public async Task<AddRamMemberResponse> AddRamMemberAsync(AddRamMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRamMemberWithOptionsAsync(request, runtime);
        }

        public ApproveJoinCompanyResponse ApproveJoinCompanyWithOptions(ApproveJoinCompanyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveJoinCompanyResponse>(DoRPCRequest("ApproveJoinCompany", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApproveJoinCompanyResponse> ApproveJoinCompanyWithOptionsAsync(ApproveJoinCompanyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveJoinCompanyResponse>(await DoRPCRequestAsync("ApproveJoinCompany", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApproveJoinCompanyResponse ApproveJoinCompany(ApproveJoinCompanyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveJoinCompanyWithOptions(request, runtime);
        }

        public async Task<ApproveJoinCompanyResponse> ApproveJoinCompanyAsync(ApproveJoinCompanyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveJoinCompanyWithOptionsAsync(request, runtime);
        }

        public CreateEnterpriseResponse CreateEnterpriseWithOptions(CreateEnterpriseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEnterpriseShrinkRequest request = new CreateEnterpriseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Emails))
            {
                request.EmailsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Emails, "Emails", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEnterpriseResponse>(DoRPCRequest("CreateEnterprise", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEnterpriseResponse> CreateEnterpriseWithOptionsAsync(CreateEnterpriseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEnterpriseShrinkRequest request = new CreateEnterpriseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Emails))
            {
                request.EmailsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Emails, "Emails", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEnterpriseResponse>(await DoRPCRequestAsync("CreateEnterprise", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEnterpriseResponse CreateEnterprise(CreateEnterpriseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEnterpriseWithOptions(request, runtime);
        }

        public async Task<CreateEnterpriseResponse> CreateEnterpriseAsync(CreateEnterpriseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEnterpriseWithOptionsAsync(request, runtime);
        }

        public CreateWorkitemResponse CreateWorkitemWithOptions(CreateWorkitemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWorkitemResponse>(DoRPCRequest("CreateWorkitem", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateWorkitemResponse> CreateWorkitemWithOptionsAsync(CreateWorkitemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWorkitemResponse>(await DoRPCRequestAsync("CreateWorkitem", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateWorkitemResponse CreateWorkitem(CreateWorkitemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkitemWithOptions(request, runtime);
        }

        public async Task<CreateWorkitemResponse> CreateWorkitemAsync(CreateWorkitemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkitemWithOptionsAsync(request, runtime);
        }

        public GetBindedUserByDingIdResponse GetBindedUserByDingIdWithOptions(GetBindedUserByDingIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetBindedUserByDingIdResponse>(DoRPCRequest("GetBindedUserByDingId", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetBindedUserByDingIdResponse> GetBindedUserByDingIdWithOptionsAsync(GetBindedUserByDingIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetBindedUserByDingIdResponse>(await DoRPCRequestAsync("GetBindedUserByDingId", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetBindedUserByDingIdResponse GetBindedUserByDingId(GetBindedUserByDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBindedUserByDingIdWithOptions(request, runtime);
        }

        public async Task<GetBindedUserByDingIdResponse> GetBindedUserByDingIdAsync(GetBindedUserByDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBindedUserByDingIdWithOptionsAsync(request, runtime);
        }

        public GetChangeLogResponse GetChangeLogWithOptions(GetChangeLogRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetChangeLogShrinkRequest request = new GetChangeLogShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TargetIds))
            {
                request.TargetIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TargetIds, "TargetIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetChangeLogResponse>(DoRPCRequest("GetChangeLog", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetChangeLogResponse> GetChangeLogWithOptionsAsync(GetChangeLogRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetChangeLogShrinkRequest request = new GetChangeLogShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TargetIds))
            {
                request.TargetIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TargetIds, "TargetIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetChangeLogResponse>(await DoRPCRequestAsync("GetChangeLog", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetChangeLogResponse GetChangeLog(GetChangeLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChangeLogWithOptions(request, runtime);
        }

        public async Task<GetChangeLogResponse> GetChangeLogAsync(GetChangeLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChangeLogWithOptionsAsync(request, runtime);
        }

        public GetCustomFieldsByTemplateIdResponse GetCustomFieldsByTemplateIdWithOptions(GetCustomFieldsByTemplateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCustomFieldsByTemplateIdResponse>(DoRPCRequest("GetCustomFieldsByTemplateId", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCustomFieldsByTemplateIdResponse> GetCustomFieldsByTemplateIdWithOptionsAsync(GetCustomFieldsByTemplateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCustomFieldsByTemplateIdResponse>(await DoRPCRequestAsync("GetCustomFieldsByTemplateId", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCustomFieldsByTemplateIdResponse GetCustomFieldsByTemplateId(GetCustomFieldsByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomFieldsByTemplateIdWithOptions(request, runtime);
        }

        public async Task<GetCustomFieldsByTemplateIdResponse> GetCustomFieldsByTemplateIdAsync(GetCustomFieldsByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomFieldsByTemplateIdWithOptionsAsync(request, runtime);
        }

        public GetIssueByIdResponse GetIssueByIdWithOptions(GetIssueByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetIssueByIdResponse>(DoRPCRequest("GetIssueById", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetIssueByIdResponse> GetIssueByIdWithOptionsAsync(GetIssueByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetIssueByIdResponse>(await DoRPCRequestAsync("GetIssueById", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetIssueByIdResponse GetIssueById(GetIssueByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIssueByIdWithOptions(request, runtime);
        }

        public async Task<GetIssueByIdResponse> GetIssueByIdAsync(GetIssueByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIssueByIdWithOptionsAsync(request, runtime);
        }

        public GetJoinCodeResponse GetJoinCodeWithOptions(GetJoinCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJoinCodeResponse>(DoRPCRequest("GetJoinCode", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJoinCodeResponse> GetJoinCodeWithOptionsAsync(GetJoinCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJoinCodeResponse>(await DoRPCRequestAsync("GetJoinCode", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJoinCodeResponse GetJoinCode(GetJoinCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJoinCodeWithOptions(request, runtime);
        }

        public async Task<GetJoinCodeResponse> GetJoinCodeAsync(GetJoinCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJoinCodeWithOptionsAsync(request, runtime);
        }

        public GetProjectMembersResponse GetProjectMembersWithOptions(GetProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetProjectMembersResponse>(DoRPCRequest("GetProjectMembers", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetProjectMembersResponse> GetProjectMembersWithOptionsAsync(GetProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetProjectMembersResponse>(await DoRPCRequestAsync("GetProjectMembers", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetProjectMembersResponse GetProjectMembers(GetProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectMembersWithOptions(request, runtime);
        }

        public async Task<GetProjectMembersResponse> GetProjectMembersAsync(GetProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectMembersWithOptionsAsync(request, runtime);
        }

        public GetUserByAliyunPkResponse GetUserByAliyunPkWithOptions(GetUserByAliyunPkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetUserByAliyunPkResponse>(DoRPCRequest("GetUserByAliyunPk", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetUserByAliyunPkResponse> GetUserByAliyunPkWithOptionsAsync(GetUserByAliyunPkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetUserByAliyunPkResponse>(await DoRPCRequestAsync("GetUserByAliyunPk", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetUserByAliyunPkResponse GetUserByAliyunPk(GetUserByAliyunPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserByAliyunPkWithOptions(request, runtime);
        }

        public async Task<GetUserByAliyunPkResponse> GetUserByAliyunPkAsync(GetUserByAliyunPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserByAliyunPkWithOptionsAsync(request, runtime);
        }

        public GetWorkitemByIdResponse GetWorkitemByIdWithOptions(GetWorkitemByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWorkitemByIdResponse>(DoRPCRequest("GetWorkitemById", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWorkitemByIdResponse> GetWorkitemByIdWithOptionsAsync(GetWorkitemByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWorkitemByIdResponse>(await DoRPCRequestAsync("GetWorkitemById", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWorkitemByIdResponse GetWorkitemById(GetWorkitemByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkitemByIdWithOptions(request, runtime);
        }

        public async Task<GetWorkitemByIdResponse> GetWorkitemByIdAsync(GetWorkitemByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkitemByIdWithOptionsAsync(request, runtime);
        }

        public JoinCompanyResponse JoinCompanyWithOptions(JoinCompanyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinCompanyResponse>(DoRPCRequest("JoinCompany", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinCompanyResponse> JoinCompanyWithOptionsAsync(JoinCompanyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinCompanyResponse>(await DoRPCRequestAsync("JoinCompany", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinCompanyResponse JoinCompany(JoinCompanyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinCompanyWithOptions(request, runtime);
        }

        public async Task<JoinCompanyResponse> JoinCompanyAsync(JoinCompanyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinCompanyWithOptionsAsync(request, runtime);
        }

        public SearchProjectsByRegionResponse SearchProjectsByRegionWithOptions(SearchProjectsByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SearchProjectsByRegionResponse>(DoRPCRequest("SearchProjectsByRegion", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SearchProjectsByRegionResponse> SearchProjectsByRegionWithOptionsAsync(SearchProjectsByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SearchProjectsByRegionResponse>(await DoRPCRequestAsync("SearchProjectsByRegion", "2018-08-21", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SearchProjectsByRegionResponse SearchProjectsByRegion(SearchProjectsByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchProjectsByRegionWithOptions(request, runtime);
        }

        public async Task<SearchProjectsByRegionResponse> SearchProjectsByRegionAsync(SearchProjectsByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchProjectsByRegionWithOptionsAsync(request, runtime);
        }

        public SearchTestCaseResponse SearchTestCaseWithOptions(SearchTestCaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTestCaseResponse>(DoRPCRequest("SearchTestCase", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchTestCaseResponse> SearchTestCaseWithOptionsAsync(SearchTestCaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTestCaseResponse>(await DoRPCRequestAsync("SearchTestCase", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchTestCaseResponse SearchTestCase(SearchTestCaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTestCaseWithOptions(request, runtime);
        }

        public async Task<SearchTestCaseResponse> SearchTestCaseAsync(SearchTestCaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTestCaseWithOptionsAsync(request, runtime);
        }

        public SearchWorkitemResponse SearchWorkitemWithOptions(SearchWorkitemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchWorkitemResponse>(DoRPCRequest("SearchWorkitem", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchWorkitemResponse> SearchWorkitemWithOptionsAsync(SearchWorkitemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchWorkitemResponse>(await DoRPCRequestAsync("SearchWorkitem", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchWorkitemResponse SearchWorkitem(SearchWorkitemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchWorkitemWithOptions(request, runtime);
        }

        public async Task<SearchWorkitemResponse> SearchWorkitemAsync(SearchWorkitemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchWorkitemWithOptionsAsync(request, runtime);
        }

        public SearchWorkitemWithTotalCountResponse SearchWorkitemWithTotalCountWithOptions(SearchWorkitemWithTotalCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchWorkitemWithTotalCountResponse>(DoRPCRequest("SearchWorkitemWithTotalCount", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchWorkitemWithTotalCountResponse> SearchWorkitemWithTotalCountWithOptionsAsync(SearchWorkitemWithTotalCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchWorkitemWithTotalCountResponse>(await DoRPCRequestAsync("SearchWorkitemWithTotalCount", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchWorkitemWithTotalCountResponse SearchWorkitemWithTotalCount(SearchWorkitemWithTotalCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchWorkitemWithTotalCountWithOptions(request, runtime);
        }

        public async Task<SearchWorkitemWithTotalCountResponse> SearchWorkitemWithTotalCountAsync(SearchWorkitemWithTotalCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchWorkitemWithTotalCountWithOptionsAsync(request, runtime);
        }

        public SyncUserToRdcResponse SyncUserToRdcWithOptions(SyncUserToRdcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncUserToRdcResponse>(DoRPCRequest("SyncUserToRdc", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SyncUserToRdcResponse> SyncUserToRdcWithOptionsAsync(SyncUserToRdcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncUserToRdcResponse>(await DoRPCRequestAsync("SyncUserToRdc", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SyncUserToRdcResponse SyncUserToRdc(SyncUserToRdcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncUserToRdcWithOptions(request, runtime);
        }

        public async Task<SyncUserToRdcResponse> SyncUserToRdcAsync(SyncUserToRdcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncUserToRdcWithOptionsAsync(request, runtime);
        }

        public UpdateWorkitemResponse UpdateWorkitemWithOptions(UpdateWorkitemRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkitemShrinkRequest request = new UpdateWorkitemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CfList))
            {
                request.CfListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CfList, "CfList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cfs))
            {
                request.CfsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cfs, "Cfs", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateWorkitemResponse>(DoRPCRequest("UpdateWorkitem", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateWorkitemResponse> UpdateWorkitemWithOptionsAsync(UpdateWorkitemRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkitemShrinkRequest request = new UpdateWorkitemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CfList))
            {
                request.CfListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CfList, "CfList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cfs))
            {
                request.CfsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cfs, "Cfs", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateWorkitemResponse>(await DoRPCRequestAsync("UpdateWorkitem", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateWorkitemResponse UpdateWorkitem(UpdateWorkitemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkitemWithOptions(request, runtime);
        }

        public async Task<UpdateWorkitemResponse> UpdateWorkitemAsync(UpdateWorkitemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkitemWithOptionsAsync(request, runtime);
        }

    }
}
