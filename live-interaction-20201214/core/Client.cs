// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Live_interaction20201214.Models;

namespace AlibabaCloud.SDK.Live_interaction20201214
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("live-interaction", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddGroupMembersResponse AddGroupMembersWithOptions(AddGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddGroupMembersShrinkRequest request = new AddGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGroupMembersResponse>(DoRPCRequest("AddGroupMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddGroupMembersResponse> AddGroupMembersWithOptionsAsync(AddGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddGroupMembersShrinkRequest request = new AddGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGroupMembersResponse>(await DoRPCRequestAsync("AddGroupMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddGroupMembersResponse AddGroupMembers(AddGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGroupMembersWithOptions(request, runtime);
        }

        public async Task<AddGroupMembersResponse> AddGroupMembersAsync(AddGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGroupMembersWithOptionsAsync(request, runtime);
        }

        public AddGroupSilenceBlacklistResponse AddGroupSilenceBlacklistWithOptions(AddGroupSilenceBlacklistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddGroupSilenceBlacklistShrinkRequest request = new AddGroupSilenceBlacklistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGroupSilenceBlacklistResponse>(DoRPCRequest("AddGroupSilenceBlacklist", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddGroupSilenceBlacklistResponse> AddGroupSilenceBlacklistWithOptionsAsync(AddGroupSilenceBlacklistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddGroupSilenceBlacklistShrinkRequest request = new AddGroupSilenceBlacklistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGroupSilenceBlacklistResponse>(await DoRPCRequestAsync("AddGroupSilenceBlacklist", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddGroupSilenceBlacklistResponse AddGroupSilenceBlacklist(AddGroupSilenceBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGroupSilenceBlacklistWithOptions(request, runtime);
        }

        public async Task<AddGroupSilenceBlacklistResponse> AddGroupSilenceBlacklistAsync(AddGroupSilenceBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGroupSilenceBlacklistWithOptionsAsync(request, runtime);
        }

        public AddGroupSilenceWhitelistResponse AddGroupSilenceWhitelistWithOptions(AddGroupSilenceWhitelistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddGroupSilenceWhitelistShrinkRequest request = new AddGroupSilenceWhitelistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGroupSilenceWhitelistResponse>(DoRPCRequest("AddGroupSilenceWhitelist", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddGroupSilenceWhitelistResponse> AddGroupSilenceWhitelistWithOptionsAsync(AddGroupSilenceWhitelistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddGroupSilenceWhitelistShrinkRequest request = new AddGroupSilenceWhitelistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGroupSilenceWhitelistResponse>(await DoRPCRequestAsync("AddGroupSilenceWhitelist", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddGroupSilenceWhitelistResponse AddGroupSilenceWhitelist(AddGroupSilenceWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGroupSilenceWhitelistWithOptions(request, runtime);
        }

        public async Task<AddGroupSilenceWhitelistResponse> AddGroupSilenceWhitelistAsync(AddGroupSilenceWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGroupSilenceWhitelistWithOptionsAsync(request, runtime);
        }

        public CancelSilenceAllGroupMembersResponse CancelSilenceAllGroupMembersWithOptions(CancelSilenceAllGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CancelSilenceAllGroupMembersShrinkRequest request = new CancelSilenceAllGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelSilenceAllGroupMembersResponse>(DoRPCRequest("CancelSilenceAllGroupMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelSilenceAllGroupMembersResponse> CancelSilenceAllGroupMembersWithOptionsAsync(CancelSilenceAllGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CancelSilenceAllGroupMembersShrinkRequest request = new CancelSilenceAllGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelSilenceAllGroupMembersResponse>(await DoRPCRequestAsync("CancelSilenceAllGroupMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelSilenceAllGroupMembersResponse CancelSilenceAllGroupMembers(CancelSilenceAllGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelSilenceAllGroupMembersWithOptions(request, runtime);
        }

        public async Task<CancelSilenceAllGroupMembersResponse> CancelSilenceAllGroupMembersAsync(CancelSilenceAllGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelSilenceAllGroupMembersWithOptionsAsync(request, runtime);
        }

        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateGroupShrinkRequest request = new CreateGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupResponse>(DoRPCRequest("CreateGroup", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateGroupShrinkRequest request = new CreateGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupResponse>(await DoRPCRequestAsync("CreateGroup", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupWithOptions(request, runtime);
        }

        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupWithOptionsAsync(request, runtime);
        }

        public CreateRoomResponse CreateRoomWithOptions(CreateRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRoomResponse>(DoRPCRequest("CreateRoom", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRoomResponse> CreateRoomWithOptionsAsync(CreateRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRoomResponse>(await DoRPCRequestAsync("CreateRoom", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRoomResponse CreateRoom(CreateRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRoomWithOptions(request, runtime);
        }

        public async Task<CreateRoomResponse> CreateRoomAsync(CreateRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRoomWithOptionsAsync(request, runtime);
        }

        public DestroyRoomResponse DestroyRoomWithOptions(DestroyRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DestroyRoomResponse>(DoRPCRequest("DestroyRoom", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DestroyRoomResponse> DestroyRoomWithOptionsAsync(DestroyRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DestroyRoomResponse>(await DoRPCRequestAsync("DestroyRoom", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DestroyRoomResponse DestroyRoom(DestroyRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DestroyRoomWithOptions(request, runtime);
        }

        public async Task<DestroyRoomResponse> DestroyRoomAsync(DestroyRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DestroyRoomWithOptionsAsync(request, runtime);
        }

        public DismissGroupResponse DismissGroupWithOptions(DismissGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DismissGroupShrinkRequest request = new DismissGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DismissGroupResponse>(DoRPCRequest("DismissGroup", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DismissGroupResponse> DismissGroupWithOptionsAsync(DismissGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DismissGroupShrinkRequest request = new DismissGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DismissGroupResponse>(await DoRPCRequestAsync("DismissGroup", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DismissGroupResponse DismissGroup(DismissGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DismissGroupWithOptions(request, runtime);
        }

        public async Task<DismissGroupResponse> DismissGroupAsync(DismissGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DismissGroupWithOptionsAsync(request, runtime);
        }

        public GetGroupMemberByIdsResponse GetGroupMemberByIdsWithOptions(GetGroupMemberByIdsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetGroupMemberByIdsShrinkRequest request = new GetGroupMemberByIdsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetGroupMemberByIdsResponse>(DoRPCRequest("GetGroupMemberByIds", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetGroupMemberByIdsResponse> GetGroupMemberByIdsWithOptionsAsync(GetGroupMemberByIdsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetGroupMemberByIdsShrinkRequest request = new GetGroupMemberByIdsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetGroupMemberByIdsResponse>(await DoRPCRequestAsync("GetGroupMemberByIds", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetGroupMemberByIdsResponse GetGroupMemberByIds(GetGroupMemberByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGroupMemberByIdsWithOptions(request, runtime);
        }

        public async Task<GetGroupMemberByIdsResponse> GetGroupMemberByIdsAsync(GetGroupMemberByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGroupMemberByIdsWithOptionsAsync(request, runtime);
        }

        public GetLoginTokenResponse GetLoginTokenWithOptions(GetLoginTokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetLoginTokenShrinkRequest request = new GetLoginTokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLoginTokenResponse>(DoRPCRequest("GetLoginToken", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLoginTokenResponse> GetLoginTokenWithOptionsAsync(GetLoginTokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetLoginTokenShrinkRequest request = new GetLoginTokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLoginTokenResponse>(await DoRPCRequestAsync("GetLoginToken", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLoginTokenResponse GetLoginToken(GetLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginTokenWithOptions(request, runtime);
        }

        public async Task<GetLoginTokenResponse> GetLoginTokenAsync(GetLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginTokenWithOptionsAsync(request, runtime);
        }

        public GetMediaUploadUrlResponse GetMediaUploadUrlWithOptions(GetMediaUploadUrlRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMediaUploadUrlShrinkRequest request = new GetMediaUploadUrlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaUploadUrlResponse>(DoRPCRequest("GetMediaUploadUrl", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMediaUploadUrlResponse> GetMediaUploadUrlWithOptionsAsync(GetMediaUploadUrlRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMediaUploadUrlShrinkRequest request = new GetMediaUploadUrlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaUploadUrlResponse>(await DoRPCRequestAsync("GetMediaUploadUrl", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMediaUploadUrlResponse GetMediaUploadUrl(GetMediaUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaUploadUrlWithOptions(request, runtime);
        }

        public async Task<GetMediaUploadUrlResponse> GetMediaUploadUrlAsync(GetMediaUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaUploadUrlWithOptionsAsync(request, runtime);
        }

        public GetMediaUrlResponse GetMediaUrlWithOptions(GetMediaUrlRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMediaUrlShrinkRequest request = new GetMediaUrlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaUrlResponse>(DoRPCRequest("GetMediaUrl", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMediaUrlResponse> GetMediaUrlWithOptionsAsync(GetMediaUrlRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMediaUrlShrinkRequest request = new GetMediaUrlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaUrlResponse>(await DoRPCRequestAsync("GetMediaUrl", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMediaUrlResponse GetMediaUrl(GetMediaUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaUrlWithOptions(request, runtime);
        }

        public async Task<GetMediaUrlResponse> GetMediaUrlAsync(GetMediaUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaUrlWithOptionsAsync(request, runtime);
        }

        public GetMessageByIdResponse GetMessageByIdWithOptions(GetMessageByIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMessageByIdShrinkRequest request = new GetMessageByIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMessageByIdResponse>(DoRPCRequest("GetMessageById", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMessageByIdResponse> GetMessageByIdWithOptionsAsync(GetMessageByIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMessageByIdShrinkRequest request = new GetMessageByIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMessageByIdResponse>(await DoRPCRequestAsync("GetMessageById", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMessageByIdResponse GetMessageById(GetMessageByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMessageByIdWithOptions(request, runtime);
        }

        public async Task<GetMessageByIdResponse> GetMessageByIdAsync(GetMessageByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMessageByIdWithOptionsAsync(request, runtime);
        }

        public ImportGroupChatConversationResponse ImportGroupChatConversationWithOptions(ImportGroupChatConversationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportGroupChatConversationShrinkRequest request = new ImportGroupChatConversationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportGroupChatConversationResponse>(DoRPCRequest("ImportGroupChatConversation", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportGroupChatConversationResponse> ImportGroupChatConversationWithOptionsAsync(ImportGroupChatConversationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportGroupChatConversationShrinkRequest request = new ImportGroupChatConversationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportGroupChatConversationResponse>(await DoRPCRequestAsync("ImportGroupChatConversation", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportGroupChatConversationResponse ImportGroupChatConversation(ImportGroupChatConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportGroupChatConversationWithOptions(request, runtime);
        }

        public async Task<ImportGroupChatConversationResponse> ImportGroupChatConversationAsync(ImportGroupChatConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportGroupChatConversationWithOptionsAsync(request, runtime);
        }

        public ImportGroupChatMemberResponse ImportGroupChatMemberWithOptions(ImportGroupChatMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportGroupChatMemberShrinkRequest request = new ImportGroupChatMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportGroupChatMemberResponse>(DoRPCRequest("ImportGroupChatMember", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportGroupChatMemberResponse> ImportGroupChatMemberWithOptionsAsync(ImportGroupChatMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportGroupChatMemberShrinkRequest request = new ImportGroupChatMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportGroupChatMemberResponse>(await DoRPCRequestAsync("ImportGroupChatMember", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportGroupChatMemberResponse ImportGroupChatMember(ImportGroupChatMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportGroupChatMemberWithOptions(request, runtime);
        }

        public async Task<ImportGroupChatMemberResponse> ImportGroupChatMemberAsync(ImportGroupChatMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportGroupChatMemberWithOptionsAsync(request, runtime);
        }

        public ImportMessageResponse ImportMessageWithOptions(ImportMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportMessageShrinkRequest request = new ImportMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportMessageResponse>(DoRPCRequest("ImportMessage", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportMessageResponse> ImportMessageWithOptionsAsync(ImportMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportMessageShrinkRequest request = new ImportMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportMessageResponse>(await DoRPCRequestAsync("ImportMessage", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportMessageResponse ImportMessage(ImportMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportMessageWithOptions(request, runtime);
        }

        public async Task<ImportMessageResponse> ImportMessageAsync(ImportMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportMessageWithOptionsAsync(request, runtime);
        }

        public ImportSingleConversationResponse ImportSingleConversationWithOptions(ImportSingleConversationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportSingleConversationShrinkRequest request = new ImportSingleConversationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportSingleConversationResponse>(DoRPCRequest("ImportSingleConversation", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportSingleConversationResponse> ImportSingleConversationWithOptionsAsync(ImportSingleConversationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportSingleConversationShrinkRequest request = new ImportSingleConversationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportSingleConversationResponse>(await DoRPCRequestAsync("ImportSingleConversation", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportSingleConversationResponse ImportSingleConversation(ImportSingleConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportSingleConversationWithOptions(request, runtime);
        }

        public async Task<ImportSingleConversationResponse> ImportSingleConversationAsync(ImportSingleConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportSingleConversationWithOptionsAsync(request, runtime);
        }

        public InitTenantResponse InitTenantWithOptions(InitTenantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitTenantResponse>(DoRPCRequest("InitTenant", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitTenantResponse> InitTenantWithOptionsAsync(InitTenantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitTenantResponse>(await DoRPCRequestAsync("InitTenant", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InitTenantResponse InitTenant(InitTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitTenantWithOptions(request, runtime);
        }

        public async Task<InitTenantResponse> InitTenantAsync(InitTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitTenantWithOptionsAsync(request, runtime);
        }

        public KickOffResponse KickOffWithOptions(KickOffRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            KickOffShrinkRequest request = new KickOffShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KickOffResponse>(DoRPCRequest("KickOff", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<KickOffResponse> KickOffWithOptionsAsync(KickOffRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            KickOffShrinkRequest request = new KickOffShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KickOffResponse>(await DoRPCRequestAsync("KickOff", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public KickOffResponse KickOff(KickOffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KickOffWithOptions(request, runtime);
        }

        public async Task<KickOffResponse> KickOffAsync(KickOffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KickOffWithOptionsAsync(request, runtime);
        }

        public ListGroupSilenceMembersResponse ListGroupSilenceMembersWithOptions(ListGroupSilenceMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListGroupSilenceMembersShrinkRequest request = new ListGroupSilenceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListGroupSilenceMembersResponse>(DoRPCRequest("ListGroupSilenceMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListGroupSilenceMembersResponse> ListGroupSilenceMembersWithOptionsAsync(ListGroupSilenceMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListGroupSilenceMembersShrinkRequest request = new ListGroupSilenceMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListGroupSilenceMembersResponse>(await DoRPCRequestAsync("ListGroupSilenceMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListGroupSilenceMembersResponse ListGroupSilenceMembers(ListGroupSilenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupSilenceMembersWithOptions(request, runtime);
        }

        public async Task<ListGroupSilenceMembersResponse> ListGroupSilenceMembersAsync(ListGroupSilenceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupSilenceMembersWithOptionsAsync(request, runtime);
        }

        public RecallMessageResponse RecallMessageWithOptions(RecallMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecallMessageShrinkRequest request = new RecallMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecallMessageResponse>(DoRPCRequest("RecallMessage", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecallMessageResponse> RecallMessageWithOptionsAsync(RecallMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecallMessageShrinkRequest request = new RecallMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecallMessageResponse>(await DoRPCRequestAsync("RecallMessage", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecallMessageResponse RecallMessage(RecallMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecallMessageWithOptions(request, runtime);
        }

        public async Task<RecallMessageResponse> RecallMessageAsync(RecallMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecallMessageWithOptionsAsync(request, runtime);
        }

        public RemoveExtensionByKeysResponse RemoveExtensionByKeysWithOptions(RemoveExtensionByKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveExtensionByKeysResponse>(DoRPCRequest("RemoveExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveExtensionByKeysResponse> RemoveExtensionByKeysWithOptionsAsync(RemoveExtensionByKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveExtensionByKeysResponse>(await DoRPCRequestAsync("RemoveExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveExtensionByKeysResponse RemoveExtensionByKeys(RemoveExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<RemoveExtensionByKeysResponse> RemoveExtensionByKeysAsync(RemoveExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public RemoveGroupExtensionByKeysResponse RemoveGroupExtensionByKeysWithOptions(RemoveGroupExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupExtensionByKeysShrinkRequest request = new RemoveGroupExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupExtensionByKeysResponse>(DoRPCRequest("RemoveGroupExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveGroupExtensionByKeysResponse> RemoveGroupExtensionByKeysWithOptionsAsync(RemoveGroupExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupExtensionByKeysShrinkRequest request = new RemoveGroupExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupExtensionByKeysResponse>(await DoRPCRequestAsync("RemoveGroupExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveGroupExtensionByKeysResponse RemoveGroupExtensionByKeys(RemoveGroupExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveGroupExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<RemoveGroupExtensionByKeysResponse> RemoveGroupExtensionByKeysAsync(RemoveGroupExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveGroupExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public RemoveGroupMembersResponse RemoveGroupMembersWithOptions(RemoveGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupMembersShrinkRequest request = new RemoveGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupMembersResponse>(DoRPCRequest("RemoveGroupMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveGroupMembersResponse> RemoveGroupMembersWithOptionsAsync(RemoveGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupMembersShrinkRequest request = new RemoveGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupMembersResponse>(await DoRPCRequestAsync("RemoveGroupMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveGroupMembersResponse RemoveGroupMembers(RemoveGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveGroupMembersWithOptions(request, runtime);
        }

        public async Task<RemoveGroupMembersResponse> RemoveGroupMembersAsync(RemoveGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveGroupMembersWithOptionsAsync(request, runtime);
        }

        public RemoveGroupSilenceBlacklistResponse RemoveGroupSilenceBlacklistWithOptions(RemoveGroupSilenceBlacklistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupSilenceBlacklistShrinkRequest request = new RemoveGroupSilenceBlacklistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupSilenceBlacklistResponse>(DoRPCRequest("RemoveGroupSilenceBlacklist", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveGroupSilenceBlacklistResponse> RemoveGroupSilenceBlacklistWithOptionsAsync(RemoveGroupSilenceBlacklistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupSilenceBlacklistShrinkRequest request = new RemoveGroupSilenceBlacklistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupSilenceBlacklistResponse>(await DoRPCRequestAsync("RemoveGroupSilenceBlacklist", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveGroupSilenceBlacklistResponse RemoveGroupSilenceBlacklist(RemoveGroupSilenceBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveGroupSilenceBlacklistWithOptions(request, runtime);
        }

        public async Task<RemoveGroupSilenceBlacklistResponse> RemoveGroupSilenceBlacklistAsync(RemoveGroupSilenceBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveGroupSilenceBlacklistWithOptionsAsync(request, runtime);
        }

        public RemoveGroupSilenceWhitelistResponse RemoveGroupSilenceWhitelistWithOptions(RemoveGroupSilenceWhitelistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupSilenceWhitelistShrinkRequest request = new RemoveGroupSilenceWhitelistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupSilenceWhitelistResponse>(DoRPCRequest("RemoveGroupSilenceWhitelist", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveGroupSilenceWhitelistResponse> RemoveGroupSilenceWhitelistWithOptionsAsync(RemoveGroupSilenceWhitelistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupSilenceWhitelistShrinkRequest request = new RemoveGroupSilenceWhitelistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupSilenceWhitelistResponse>(await DoRPCRequestAsync("RemoveGroupSilenceWhitelist", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveGroupSilenceWhitelistResponse RemoveGroupSilenceWhitelist(RemoveGroupSilenceWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveGroupSilenceWhitelistWithOptions(request, runtime);
        }

        public async Task<RemoveGroupSilenceWhitelistResponse> RemoveGroupSilenceWhitelistAsync(RemoveGroupSilenceWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveGroupSilenceWhitelistWithOptionsAsync(request, runtime);
        }

        public RemoveMessageExtensionByKeysResponse RemoveMessageExtensionByKeysWithOptions(RemoveMessageExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveMessageExtensionByKeysShrinkRequest request = new RemoveMessageExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveMessageExtensionByKeysResponse>(DoRPCRequest("RemoveMessageExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveMessageExtensionByKeysResponse> RemoveMessageExtensionByKeysWithOptionsAsync(RemoveMessageExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveMessageExtensionByKeysShrinkRequest request = new RemoveMessageExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveMessageExtensionByKeysResponse>(await DoRPCRequestAsync("RemoveMessageExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveMessageExtensionByKeysResponse RemoveMessageExtensionByKeys(RemoveMessageExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveMessageExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<RemoveMessageExtensionByKeysResponse> RemoveMessageExtensionByKeysAsync(RemoveMessageExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveMessageExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public RemoveSingleChatExtensionByKeysResponse RemoveSingleChatExtensionByKeysWithOptions(RemoveSingleChatExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveSingleChatExtensionByKeysShrinkRequest request = new RemoveSingleChatExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSingleChatExtensionByKeysResponse>(DoRPCRequest("RemoveSingleChatExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveSingleChatExtensionByKeysResponse> RemoveSingleChatExtensionByKeysWithOptionsAsync(RemoveSingleChatExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveSingleChatExtensionByKeysShrinkRequest request = new RemoveSingleChatExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSingleChatExtensionByKeysResponse>(await DoRPCRequestAsync("RemoveSingleChatExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveSingleChatExtensionByKeysResponse RemoveSingleChatExtensionByKeys(RemoveSingleChatExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveSingleChatExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<RemoveSingleChatExtensionByKeysResponse> RemoveSingleChatExtensionByKeysAsync(RemoveSingleChatExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveSingleChatExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public RemoveUserConversationExtensionByKeysResponse RemoveUserConversationExtensionByKeysWithOptions(RemoveUserConversationExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveUserConversationExtensionByKeysShrinkRequest request = new RemoveUserConversationExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUserConversationExtensionByKeysResponse>(DoRPCRequest("RemoveUserConversationExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveUserConversationExtensionByKeysResponse> RemoveUserConversationExtensionByKeysWithOptionsAsync(RemoveUserConversationExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveUserConversationExtensionByKeysShrinkRequest request = new RemoveUserConversationExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUserConversationExtensionByKeysResponse>(await DoRPCRequestAsync("RemoveUserConversationExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveUserConversationExtensionByKeysResponse RemoveUserConversationExtensionByKeys(RemoveUserConversationExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUserConversationExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<RemoveUserConversationExtensionByKeysResponse> RemoveUserConversationExtensionByKeysAsync(RemoveUserConversationExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUserConversationExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public RemoveUserExtensionByKeysResponse RemoveUserExtensionByKeysWithOptions(RemoveUserExtensionByKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUserExtensionByKeysResponse>(DoRPCRequest("RemoveUserExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveUserExtensionByKeysResponse> RemoveUserExtensionByKeysWithOptionsAsync(RemoveUserExtensionByKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUserExtensionByKeysResponse>(await DoRPCRequestAsync("RemoveUserExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveUserExtensionByKeysResponse RemoveUserExtensionByKeys(RemoveUserExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUserExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<RemoveUserExtensionByKeysResponse> RemoveUserExtensionByKeysAsync(RemoveUserExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUserExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public SendMessageResponse SendMessageWithOptions(SendMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendMessageShrinkRequest request = new SendMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageResponse>(DoRPCRequest("SendMessage", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendMessageResponse> SendMessageWithOptionsAsync(SendMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendMessageShrinkRequest request = new SendMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageResponse>(await DoRPCRequestAsync("SendMessage", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageWithOptions(request, runtime);
        }

        public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageWithOptionsAsync(request, runtime);
        }

        public SetExtensionByKeysResponse SetExtensionByKeysWithOptions(SetExtensionByKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetExtensionByKeysResponse>(DoRPCRequest("SetExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetExtensionByKeysResponse> SetExtensionByKeysWithOptionsAsync(SetExtensionByKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetExtensionByKeysResponse>(await DoRPCRequestAsync("SetExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetExtensionByKeysResponse SetExtensionByKeys(SetExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<SetExtensionByKeysResponse> SetExtensionByKeysAsync(SetExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public SetGroupExtensionByKeysResponse SetGroupExtensionByKeysWithOptions(SetGroupExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetGroupExtensionByKeysShrinkRequest request = new SetGroupExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupExtensionByKeysResponse>(DoRPCRequest("SetGroupExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetGroupExtensionByKeysResponse> SetGroupExtensionByKeysWithOptionsAsync(SetGroupExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetGroupExtensionByKeysShrinkRequest request = new SetGroupExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupExtensionByKeysResponse>(await DoRPCRequestAsync("SetGroupExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetGroupExtensionByKeysResponse SetGroupExtensionByKeys(SetGroupExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGroupExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<SetGroupExtensionByKeysResponse> SetGroupExtensionByKeysAsync(SetGroupExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGroupExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public SetMessageExtensionByKeysResponse SetMessageExtensionByKeysWithOptions(SetMessageExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetMessageExtensionByKeysShrinkRequest request = new SetMessageExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetMessageExtensionByKeysResponse>(DoRPCRequest("SetMessageExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetMessageExtensionByKeysResponse> SetMessageExtensionByKeysWithOptionsAsync(SetMessageExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetMessageExtensionByKeysShrinkRequest request = new SetMessageExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetMessageExtensionByKeysResponse>(await DoRPCRequestAsync("SetMessageExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetMessageExtensionByKeysResponse SetMessageExtensionByKeys(SetMessageExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetMessageExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<SetMessageExtensionByKeysResponse> SetMessageExtensionByKeysAsync(SetMessageExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetMessageExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public SetSingleChatExtensionByKeysResponse SetSingleChatExtensionByKeysWithOptions(SetSingleChatExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetSingleChatExtensionByKeysShrinkRequest request = new SetSingleChatExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetSingleChatExtensionByKeysResponse>(DoRPCRequest("SetSingleChatExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetSingleChatExtensionByKeysResponse> SetSingleChatExtensionByKeysWithOptionsAsync(SetSingleChatExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetSingleChatExtensionByKeysShrinkRequest request = new SetSingleChatExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetSingleChatExtensionByKeysResponse>(await DoRPCRequestAsync("SetSingleChatExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetSingleChatExtensionByKeysResponse SetSingleChatExtensionByKeys(SetSingleChatExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSingleChatExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<SetSingleChatExtensionByKeysResponse> SetSingleChatExtensionByKeysAsync(SetSingleChatExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSingleChatExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public SetUserConversationExtensionByKeysResponse SetUserConversationExtensionByKeysWithOptions(SetUserConversationExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetUserConversationExtensionByKeysShrinkRequest request = new SetUserConversationExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetUserConversationExtensionByKeysResponse>(DoRPCRequest("SetUserConversationExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetUserConversationExtensionByKeysResponse> SetUserConversationExtensionByKeysWithOptionsAsync(SetUserConversationExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetUserConversationExtensionByKeysShrinkRequest request = new SetUserConversationExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetUserConversationExtensionByKeysResponse>(await DoRPCRequestAsync("SetUserConversationExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetUserConversationExtensionByKeysResponse SetUserConversationExtensionByKeys(SetUserConversationExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetUserConversationExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<SetUserConversationExtensionByKeysResponse> SetUserConversationExtensionByKeysAsync(SetUserConversationExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetUserConversationExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public SetUserExtensionByKeysResponse SetUserExtensionByKeysWithOptions(SetUserExtensionByKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetUserExtensionByKeysResponse>(DoRPCRequest("SetUserExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetUserExtensionByKeysResponse> SetUserExtensionByKeysWithOptionsAsync(SetUserExtensionByKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetUserExtensionByKeysResponse>(await DoRPCRequestAsync("SetUserExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetUserExtensionByKeysResponse SetUserExtensionByKeys(SetUserExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetUserExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<SetUserExtensionByKeysResponse> SetUserExtensionByKeysAsync(SetUserExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetUserExtensionByKeysWithOptionsAsync(request, runtime);
        }

        public SilenceAllGroupMembersResponse SilenceAllGroupMembersWithOptions(SilenceAllGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SilenceAllGroupMembersShrinkRequest request = new SilenceAllGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SilenceAllGroupMembersResponse>(DoRPCRequest("SilenceAllGroupMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SilenceAllGroupMembersResponse> SilenceAllGroupMembersWithOptionsAsync(SilenceAllGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SilenceAllGroupMembersShrinkRequest request = new SilenceAllGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SilenceAllGroupMembersResponse>(await DoRPCRequestAsync("SilenceAllGroupMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SilenceAllGroupMembersResponse SilenceAllGroupMembers(SilenceAllGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SilenceAllGroupMembersWithOptions(request, runtime);
        }

        public async Task<SilenceAllGroupMembersResponse> SilenceAllGroupMembersAsync(SilenceAllGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SilenceAllGroupMembersWithOptionsAsync(request, runtime);
        }

        public UpdateGroupIconResponse UpdateGroupIconWithOptions(UpdateGroupIconRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateGroupIconShrinkRequest request = new UpdateGroupIconShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupIconResponse>(DoRPCRequest("UpdateGroupIcon", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGroupIconResponse> UpdateGroupIconWithOptionsAsync(UpdateGroupIconRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateGroupIconShrinkRequest request = new UpdateGroupIconShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupIconResponse>(await DoRPCRequestAsync("UpdateGroupIcon", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGroupIconResponse UpdateGroupIcon(UpdateGroupIconRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupIconWithOptions(request, runtime);
        }

        public async Task<UpdateGroupIconResponse> UpdateGroupIconAsync(UpdateGroupIconRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupIconWithOptionsAsync(request, runtime);
        }

        public UpdateGroupMembersRoleResponse UpdateGroupMembersRoleWithOptions(UpdateGroupMembersRoleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateGroupMembersRoleShrinkRequest request = new UpdateGroupMembersRoleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupMembersRoleResponse>(DoRPCRequest("UpdateGroupMembersRole", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGroupMembersRoleResponse> UpdateGroupMembersRoleWithOptionsAsync(UpdateGroupMembersRoleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateGroupMembersRoleShrinkRequest request = new UpdateGroupMembersRoleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupMembersRoleResponse>(await DoRPCRequestAsync("UpdateGroupMembersRole", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGroupMembersRoleResponse UpdateGroupMembersRole(UpdateGroupMembersRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupMembersRoleWithOptions(request, runtime);
        }

        public async Task<UpdateGroupMembersRoleResponse> UpdateGroupMembersRoleAsync(UpdateGroupMembersRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupMembersRoleWithOptionsAsync(request, runtime);
        }

        public UpdateGroupTitleResponse UpdateGroupTitleWithOptions(UpdateGroupTitleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateGroupTitleShrinkRequest request = new UpdateGroupTitleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupTitleResponse>(DoRPCRequest("UpdateGroupTitle", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGroupTitleResponse> UpdateGroupTitleWithOptionsAsync(UpdateGroupTitleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateGroupTitleShrinkRequest request = new UpdateGroupTitleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGroupTitleResponse>(await DoRPCRequestAsync("UpdateGroupTitle", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGroupTitleResponse UpdateGroupTitle(UpdateGroupTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupTitleWithOptions(request, runtime);
        }

        public async Task<UpdateGroupTitleResponse> UpdateGroupTitleAsync(UpdateGroupTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupTitleWithOptionsAsync(request, runtime);
        }

        public UpdateTenantStatusResponse UpdateTenantStatusWithOptions(UpdateTenantStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTenantStatusResponse>(DoRPCRequest("UpdateTenantStatus", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTenantStatusResponse> UpdateTenantStatusWithOptionsAsync(UpdateTenantStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTenantStatusResponse>(await DoRPCRequestAsync("UpdateTenantStatus", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTenantStatusResponse UpdateTenantStatus(UpdateTenantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTenantStatusWithOptions(request, runtime);
        }

        public async Task<UpdateTenantStatusResponse> UpdateTenantStatusAsync(UpdateTenantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTenantStatusWithOptionsAsync(request, runtime);
        }

    }
}
