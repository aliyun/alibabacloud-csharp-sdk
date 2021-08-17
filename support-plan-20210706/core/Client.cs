// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Support_plan20210706.Models;

namespace AlibabaCloud.SDK.Support_plan20210706
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("support-plan", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ListEnterpriseDingtalkGroupCustomerMembersResponse ListEnterpriseDingtalkGroupCustomerMembersWithOptions(ListEnterpriseDingtalkGroupCustomerMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupCustomerMembersResponse>(DoRPCRequest("ListEnterpriseDingtalkGroupCustomerMembers", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEnterpriseDingtalkGroupCustomerMembersResponse> ListEnterpriseDingtalkGroupCustomerMembersWithOptionsAsync(ListEnterpriseDingtalkGroupCustomerMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupCustomerMembersResponse>(await DoRPCRequestAsync("ListEnterpriseDingtalkGroupCustomerMembers", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListEnterpriseDingtalkGroupCustomerMembersResponse ListEnterpriseDingtalkGroupCustomerMembers(ListEnterpriseDingtalkGroupCustomerMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnterpriseDingtalkGroupCustomerMembersWithOptions(request, runtime);
        }

        public async Task<ListEnterpriseDingtalkGroupCustomerMembersResponse> ListEnterpriseDingtalkGroupCustomerMembersAsync(ListEnterpriseDingtalkGroupCustomerMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnterpriseDingtalkGroupCustomerMembersWithOptionsAsync(request, runtime);
        }

        public ListEnterpriseDingtalkGroupsResponse ListEnterpriseDingtalkGroupsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(DoRPCRequest("ListEnterpriseDingtalkGroups", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEnterpriseDingtalkGroupsResponse> ListEnterpriseDingtalkGroupsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(await DoRPCRequestAsync("ListEnterpriseDingtalkGroups", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListEnterpriseDingtalkGroupsResponse ListEnterpriseDingtalkGroups()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnterpriseDingtalkGroupsWithOptions(runtime);
        }

        public async Task<ListEnterpriseDingtalkGroupsResponse> ListEnterpriseDingtalkGroupsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnterpriseDingtalkGroupsWithOptionsAsync(runtime);
        }

        public DeleteEnterpriseDingtalkGroupCustomerMemberResponse DeleteEnterpriseDingtalkGroupCustomerMemberWithOptions(DeleteEnterpriseDingtalkGroupCustomerMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest request = new DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Mobiles))
            {
                request.MobilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Mobiles, "Mobiles", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEnterpriseDingtalkGroupCustomerMemberResponse>(DoRPCRequest("DeleteEnterpriseDingtalkGroupCustomerMember", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEnterpriseDingtalkGroupCustomerMemberResponse> DeleteEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(DeleteEnterpriseDingtalkGroupCustomerMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest request = new DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Mobiles))
            {
                request.MobilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Mobiles, "Mobiles", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEnterpriseDingtalkGroupCustomerMemberResponse>(await DoRPCRequestAsync("DeleteEnterpriseDingtalkGroupCustomerMember", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEnterpriseDingtalkGroupCustomerMemberResponse DeleteEnterpriseDingtalkGroupCustomerMember(DeleteEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEnterpriseDingtalkGroupCustomerMemberWithOptions(request, runtime);
        }

        public async Task<DeleteEnterpriseDingtalkGroupCustomerMemberResponse> DeleteEnterpriseDingtalkGroupCustomerMemberAsync(DeleteEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(request, runtime);
        }

        public GetEnterpriseDingtalkGroupCustomerMemberResponse GetEnterpriseDingtalkGroupCustomerMemberWithOptions(GetEnterpriseDingtalkGroupCustomerMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetEnterpriseDingtalkGroupCustomerMemberResponse>(DoRPCRequest("GetEnterpriseDingtalkGroupCustomerMember", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetEnterpriseDingtalkGroupCustomerMemberResponse> GetEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(GetEnterpriseDingtalkGroupCustomerMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetEnterpriseDingtalkGroupCustomerMemberResponse>(await DoRPCRequestAsync("GetEnterpriseDingtalkGroupCustomerMember", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetEnterpriseDingtalkGroupCustomerMemberResponse GetEnterpriseDingtalkGroupCustomerMember(GetEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEnterpriseDingtalkGroupCustomerMemberWithOptions(request, runtime);
        }

        public async Task<GetEnterpriseDingtalkGroupCustomerMemberResponse> GetEnterpriseDingtalkGroupCustomerMemberAsync(GetEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(request, runtime);
        }

        public GetEnterpriseDingtalkGroupResponse GetEnterpriseDingtalkGroupWithOptions(GetEnterpriseDingtalkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetEnterpriseDingtalkGroupResponse>(DoRPCRequest("GetEnterpriseDingtalkGroup", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetEnterpriseDingtalkGroupResponse> GetEnterpriseDingtalkGroupWithOptionsAsync(GetEnterpriseDingtalkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetEnterpriseDingtalkGroupResponse>(await DoRPCRequestAsync("GetEnterpriseDingtalkGroup", "2021-07-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetEnterpriseDingtalkGroupResponse GetEnterpriseDingtalkGroup(GetEnterpriseDingtalkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEnterpriseDingtalkGroupWithOptions(request, runtime);
        }

        public async Task<GetEnterpriseDingtalkGroupResponse> GetEnterpriseDingtalkGroupAsync(GetEnterpriseDingtalkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEnterpriseDingtalkGroupWithOptionsAsync(request, runtime);
        }

    }
}
