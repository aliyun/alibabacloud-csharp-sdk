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

        public ListAppInfosResponse ListAppInfosWithOptions(ListAppInfosRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAppInfosShrinkRequest request = new ListAppInfosShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAppInfosResponse>(DoRPCRequest("ListAppInfos", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAppInfosResponse> ListAppInfosWithOptionsAsync(ListAppInfosRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAppInfosShrinkRequest request = new ListAppInfosShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAppInfosResponse>(await DoRPCRequestAsync("ListAppInfos", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAppInfosResponse ListAppInfos(ListAppInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInfosWithOptions(request, runtime);
        }

        public async Task<ListAppInfosResponse> ListAppInfosAsync(ListAppInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInfosWithOptionsAsync(request, runtime);
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

        public UnbindInterconnectionUidResponse UnbindInterconnectionUidWithOptions(UnbindInterconnectionUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnbindInterconnectionUidShrinkRequest request = new UnbindInterconnectionUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindInterconnectionUidResponse>(DoRPCRequest("UnbindInterconnectionUid", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindInterconnectionUidResponse> UnbindInterconnectionUidWithOptionsAsync(UnbindInterconnectionUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnbindInterconnectionUidShrinkRequest request = new UnbindInterconnectionUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindInterconnectionUidResponse>(await DoRPCRequestAsync("UnbindInterconnectionUid", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindInterconnectionUidResponse UnbindInterconnectionUid(UnbindInterconnectionUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindInterconnectionUidWithOptions(request, runtime);
        }

        public async Task<UnbindInterconnectionUidResponse> UnbindInterconnectionUidAsync(UnbindInterconnectionUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindInterconnectionUidWithOptionsAsync(request, runtime);
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

        public ListRoomMessagesResponse ListRoomMessagesWithOptions(ListRoomMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRoomMessagesResponse>(DoRPCRequest("ListRoomMessages", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRoomMessagesResponse> ListRoomMessagesWithOptionsAsync(ListRoomMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRoomMessagesResponse>(await DoRPCRequestAsync("ListRoomMessages", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRoomMessagesResponse ListRoomMessages(ListRoomMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRoomMessagesWithOptions(request, runtime);
        }

        public async Task<ListRoomMessagesResponse> ListRoomMessagesAsync(ListRoomMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRoomMessagesWithOptionsAsync(request, runtime);
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

        public RemoveGroupMemberExtensionByKeysResponse RemoveGroupMemberExtensionByKeysWithOptions(RemoveGroupMemberExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupMemberExtensionByKeysShrinkRequest request = new RemoveGroupMemberExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupMemberExtensionByKeysResponse>(DoRPCRequest("RemoveGroupMemberExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveGroupMemberExtensionByKeysResponse> RemoveGroupMemberExtensionByKeysWithOptionsAsync(RemoveGroupMemberExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveGroupMemberExtensionByKeysShrinkRequest request = new RemoveGroupMemberExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGroupMemberExtensionByKeysResponse>(await DoRPCRequestAsync("RemoveGroupMemberExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveGroupMemberExtensionByKeysResponse RemoveGroupMemberExtensionByKeys(RemoveGroupMemberExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveGroupMemberExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<RemoveGroupMemberExtensionByKeysResponse> RemoveGroupMemberExtensionByKeysAsync(RemoveGroupMemberExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveGroupMemberExtensionByKeysWithOptionsAsync(request, runtime);
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

        public ListDetailReportStatisticsResponse ListDetailReportStatisticsWithOptions(ListDetailReportStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDetailReportStatisticsShrinkRequest request = new ListDetailReportStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDetailReportStatisticsResponse>(DoRPCRequest("ListDetailReportStatistics", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDetailReportStatisticsResponse> ListDetailReportStatisticsWithOptionsAsync(ListDetailReportStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDetailReportStatisticsShrinkRequest request = new ListDetailReportStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDetailReportStatisticsResponse>(await DoRPCRequestAsync("ListDetailReportStatistics", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDetailReportStatisticsResponse ListDetailReportStatistics(ListDetailReportStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDetailReportStatisticsWithOptions(request, runtime);
        }

        public async Task<ListDetailReportStatisticsResponse> ListDetailReportStatisticsAsync(ListDetailReportStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDetailReportStatisticsWithOptionsAsync(request, runtime);
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

        public GetGroupByIdResponse GetGroupByIdWithOptions(GetGroupByIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetGroupByIdShrinkRequest request = new GetGroupByIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetGroupByIdResponse>(DoRPCRequest("GetGroupById", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetGroupByIdResponse> GetGroupByIdWithOptionsAsync(GetGroupByIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetGroupByIdShrinkRequest request = new GetGroupByIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetGroupByIdResponse>(await DoRPCRequestAsync("GetGroupById", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetGroupByIdResponse GetGroupById(GetGroupByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGroupByIdWithOptions(request, runtime);
        }

        public async Task<GetGroupByIdResponse> GetGroupByIdAsync(GetGroupByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGroupByIdWithOptionsAsync(request, runtime);
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

        public GetCommonConfigResponse GetCommonConfigWithOptions(GetCommonConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCommonConfigResponse>(DoRPCRequest("GetCommonConfig", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCommonConfigResponse> GetCommonConfigWithOptionsAsync(GetCommonConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCommonConfigResponse>(await DoRPCRequestAsync("GetCommonConfig", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCommonConfigResponse GetCommonConfig(GetCommonConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCommonConfigWithOptions(request, runtime);
        }

        public async Task<GetCommonConfigResponse> GetCommonConfigAsync(GetCommonConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCommonConfigWithOptionsAsync(request, runtime);
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

        public ListGroupAllMembersResponse ListGroupAllMembersWithOptions(ListGroupAllMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListGroupAllMembersShrinkRequest request = new ListGroupAllMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListGroupAllMembersResponse>(DoRPCRequest("ListGroupAllMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListGroupAllMembersResponse> ListGroupAllMembersWithOptionsAsync(ListGroupAllMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListGroupAllMembersShrinkRequest request = new ListGroupAllMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListGroupAllMembersResponse>(await DoRPCRequestAsync("ListGroupAllMembers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListGroupAllMembersResponse ListGroupAllMembers(ListGroupAllMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupAllMembersWithOptions(request, runtime);
        }

        public async Task<ListGroupAllMembersResponse> ListGroupAllMembersAsync(ListGroupAllMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupAllMembersWithOptionsAsync(request, runtime);
        }

        public GetUserMuteSettingResponse GetUserMuteSettingWithOptions(GetUserMuteSettingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserMuteSettingShrinkRequest request = new GetUserMuteSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserMuteSettingResponse>(DoRPCRequest("GetUserMuteSetting", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserMuteSettingResponse> GetUserMuteSettingWithOptionsAsync(GetUserMuteSettingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserMuteSettingShrinkRequest request = new GetUserMuteSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserMuteSettingResponse>(await DoRPCRequestAsync("GetUserMuteSetting", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserMuteSettingResponse GetUserMuteSetting(GetUserMuteSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserMuteSettingWithOptions(request, runtime);
        }

        public async Task<GetUserMuteSettingResponse> GetUserMuteSettingAsync(GetUserMuteSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserMuteSettingWithOptionsAsync(request, runtime);
        }

        public GetRoomStatisticsResponse GetRoomStatisticsWithOptions(GetRoomStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRoomStatisticsResponse>(DoRPCRequest("GetRoomStatistics", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRoomStatisticsResponse> GetRoomStatisticsWithOptionsAsync(GetRoomStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRoomStatisticsResponse>(await DoRPCRequestAsync("GetRoomStatistics", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRoomStatisticsResponse GetRoomStatistics(GetRoomStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRoomStatisticsWithOptions(request, runtime);
        }

        public async Task<GetRoomStatisticsResponse> GetRoomStatisticsAsync(GetRoomStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRoomStatisticsWithOptionsAsync(request, runtime);
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

        public SendCustomMessageResponse SendCustomMessageWithOptions(SendCustomMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCustomMessageResponse>(DoRPCRequest("SendCustomMessage", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendCustomMessageResponse> SendCustomMessageWithOptionsAsync(SendCustomMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCustomMessageResponse>(await DoRPCRequestAsync("SendCustomMessage", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendCustomMessageResponse SendCustomMessage(SendCustomMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCustomMessageWithOptions(request, runtime);
        }

        public async Task<SendCustomMessageResponse> SendCustomMessageAsync(SendCustomMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCustomMessageWithOptionsAsync(request, runtime);
        }

        public UpdateAppNameResponse UpdateAppNameWithOptions(UpdateAppNameRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAppNameShrinkRequest request = new UpdateAppNameShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppNameResponse>(DoRPCRequest("UpdateAppName", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppNameResponse> UpdateAppNameWithOptionsAsync(UpdateAppNameRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAppNameShrinkRequest request = new UpdateAppNameShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppNameResponse>(await DoRPCRequestAsync("UpdateAppName", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppNameResponse UpdateAppName(UpdateAppNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppNameWithOptions(request, runtime);
        }

        public async Task<UpdateAppNameResponse> UpdateAppNameAsync(UpdateAppNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppNameWithOptionsAsync(request, runtime);
        }

        public GetIMConfigResponse GetIMConfigWithOptions(GetIMConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIMConfigResponse>(DoRPCRequest("GetIMConfig", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetIMConfigResponse> GetIMConfigWithOptionsAsync(GetIMConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIMConfigResponse>(await DoRPCRequestAsync("GetIMConfig", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetIMConfigResponse GetIMConfig(GetIMConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIMConfigWithOptions(request, runtime);
        }

        public async Task<GetIMConfigResponse> GetIMConfigAsync(GetIMConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIMConfigWithOptionsAsync(request, runtime);
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

        public UpdateAppStatusResponse UpdateAppStatusWithOptions(UpdateAppStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAppStatusShrinkRequest request = new UpdateAppStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppStatusResponse>(DoRPCRequest("UpdateAppStatus", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppStatusResponse> UpdateAppStatusWithOptionsAsync(UpdateAppStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAppStatusShrinkRequest request = new UpdateAppStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppStatusResponse>(await DoRPCRequestAsync("UpdateAppStatus", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppStatusResponse UpdateAppStatus(UpdateAppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppStatusWithOptions(request, runtime);
        }

        public async Task<UpdateAppStatusResponse> UpdateAppStatusAsync(UpdateAppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppStatusWithOptionsAsync(request, runtime);
        }

        public MuteUsersResponse MuteUsersWithOptions(MuteUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MuteUsersShrinkRequest request = new MuteUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MuteUsersResponse>(DoRPCRequest("MuteUsers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MuteUsersResponse> MuteUsersWithOptionsAsync(MuteUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MuteUsersShrinkRequest request = new MuteUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MuteUsersResponse>(await DoRPCRequestAsync("MuteUsers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MuteUsersResponse MuteUsers(MuteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MuteUsersWithOptions(request, runtime);
        }

        public async Task<MuteUsersResponse> MuteUsersAsync(MuteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MuteUsersWithOptionsAsync(request, runtime);
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

        public SetGroupOwnerResponse SetGroupOwnerWithOptions(SetGroupOwnerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetGroupOwnerShrinkRequest request = new SetGroupOwnerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupOwnerResponse>(DoRPCRequest("SetGroupOwner", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetGroupOwnerResponse> SetGroupOwnerWithOptionsAsync(SetGroupOwnerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetGroupOwnerShrinkRequest request = new SetGroupOwnerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupOwnerResponse>(await DoRPCRequestAsync("SetGroupOwner", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetGroupOwnerResponse SetGroupOwner(SetGroupOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGroupOwnerWithOptions(request, runtime);
        }

        public async Task<SetGroupOwnerResponse> SetGroupOwnerAsync(SetGroupOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGroupOwnerWithOptionsAsync(request, runtime);
        }

        public ListRoomUsersResponse ListRoomUsersWithOptions(ListRoomUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRoomUsersResponse>(DoRPCRequest("ListRoomUsers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRoomUsersResponse> ListRoomUsersWithOptionsAsync(ListRoomUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRoomUsersResponse>(await DoRPCRequestAsync("ListRoomUsers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRoomUsersResponse ListRoomUsers(ListRoomUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRoomUsersWithOptions(request, runtime);
        }

        public async Task<ListRoomUsersResponse> ListRoomUsersAsync(ListRoomUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRoomUsersWithOptionsAsync(request, runtime);
        }

        public DeleteAppResponse DeleteAppWithOptions(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppResponse>(DoRPCRequest("DeleteApp", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAppResponse> DeleteAppWithOptionsAsync(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppResponse>(await DoRPCRequestAsync("DeleteApp", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppWithOptions(request, runtime);
        }

        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppWithOptionsAsync(request, runtime);
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

        public BindInterconnectionUidResponse BindInterconnectionUidWithOptions(BindInterconnectionUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BindInterconnectionUidShrinkRequest request = new BindInterconnectionUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindInterconnectionUidResponse>(DoRPCRequest("BindInterconnectionUid", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindInterconnectionUidResponse> BindInterconnectionUidWithOptionsAsync(BindInterconnectionUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BindInterconnectionUidShrinkRequest request = new BindInterconnectionUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindInterconnectionUidResponse>(await DoRPCRequestAsync("BindInterconnectionUid", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindInterconnectionUidResponse BindInterconnectionUid(BindInterconnectionUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindInterconnectionUidWithOptions(request, runtime);
        }

        public async Task<BindInterconnectionUidResponse> BindInterconnectionUidAsync(BindInterconnectionUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindInterconnectionUidWithOptionsAsync(request, runtime);
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

        public UpdateCallbackConfigResponse UpdateCallbackConfigWithOptions(UpdateCallbackConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCallbackConfigShrinkRequest request = new UpdateCallbackConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCallbackConfigResponse>(DoRPCRequest("UpdateCallbackConfig", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCallbackConfigResponse> UpdateCallbackConfigWithOptionsAsync(UpdateCallbackConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCallbackConfigShrinkRequest request = new UpdateCallbackConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCallbackConfigResponse>(await DoRPCRequestAsync("UpdateCallbackConfig", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCallbackConfigResponse UpdateCallbackConfig(UpdateCallbackConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCallbackConfigWithOptions(request, runtime);
        }

        public async Task<UpdateCallbackConfigResponse> UpdateCallbackConfigAsync(UpdateCallbackConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCallbackConfigWithOptionsAsync(request, runtime);
        }

        public BindInterconnectionCidResponse BindInterconnectionCidWithOptions(BindInterconnectionCidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BindInterconnectionCidShrinkRequest request = new BindInterconnectionCidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindInterconnectionCidResponse>(DoRPCRequest("BindInterconnectionCid", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindInterconnectionCidResponse> BindInterconnectionCidWithOptionsAsync(BindInterconnectionCidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BindInterconnectionCidShrinkRequest request = new BindInterconnectionCidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindInterconnectionCidResponse>(await DoRPCRequestAsync("BindInterconnectionCid", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindInterconnectionCidResponse BindInterconnectionCid(BindInterconnectionCidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindInterconnectionCidWithOptions(request, runtime);
        }

        public async Task<BindInterconnectionCidResponse> BindInterconnectionCidAsync(BindInterconnectionCidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindInterconnectionCidWithOptionsAsync(request, runtime);
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

        public SetGroupMemberExtensionByKeysResponse SetGroupMemberExtensionByKeysWithOptions(SetGroupMemberExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetGroupMemberExtensionByKeysShrinkRequest request = new SetGroupMemberExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupMemberExtensionByKeysResponse>(DoRPCRequest("SetGroupMemberExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetGroupMemberExtensionByKeysResponse> SetGroupMemberExtensionByKeysWithOptionsAsync(SetGroupMemberExtensionByKeysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetGroupMemberExtensionByKeysShrinkRequest request = new SetGroupMemberExtensionByKeysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupMemberExtensionByKeysResponse>(await DoRPCRequestAsync("SetGroupMemberExtensionByKeys", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetGroupMemberExtensionByKeysResponse SetGroupMemberExtensionByKeys(SetGroupMemberExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGroupMemberExtensionByKeysWithOptions(request, runtime);
        }

        public async Task<SetGroupMemberExtensionByKeysResponse> SetGroupMemberExtensionByKeysAsync(SetGroupMemberExtensionByKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGroupMemberExtensionByKeysWithOptionsAsync(request, runtime);
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

        public ListCallbackApiIdsResponse ListCallbackApiIdsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListCallbackApiIdsResponse>(DoRPCRequest("ListCallbackApiIds", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCallbackApiIdsResponse> ListCallbackApiIdsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListCallbackApiIdsResponse>(await DoRPCRequestAsync("ListCallbackApiIds", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCallbackApiIdsResponse ListCallbackApiIds()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCallbackApiIdsWithOptions(runtime);
        }

        public async Task<ListCallbackApiIdsResponse> ListCallbackApiIdsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCallbackApiIdsWithOptionsAsync(runtime);
        }

        public SetMessageReadResponse SetMessageReadWithOptions(SetMessageReadRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetMessageReadShrinkRequest request = new SetMessageReadShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetMessageReadResponse>(DoRPCRequest("SetMessageRead", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetMessageReadResponse> SetMessageReadWithOptionsAsync(SetMessageReadRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetMessageReadShrinkRequest request = new SetMessageReadShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetMessageReadResponse>(await DoRPCRequestAsync("SetMessageRead", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetMessageReadResponse SetMessageRead(SetMessageReadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetMessageReadWithOptions(request, runtime);
        }

        public async Task<SetMessageReadResponse> SetMessageReadAsync(SetMessageReadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetMessageReadWithOptionsAsync(request, runtime);
        }

        public UpdateMsgRecallIntervalResponse UpdateMsgRecallIntervalWithOptions(UpdateMsgRecallIntervalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMsgRecallIntervalShrinkRequest request = new UpdateMsgRecallIntervalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMsgRecallIntervalResponse>(DoRPCRequest("UpdateMsgRecallInterval", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMsgRecallIntervalResponse> UpdateMsgRecallIntervalWithOptionsAsync(UpdateMsgRecallIntervalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMsgRecallIntervalShrinkRequest request = new UpdateMsgRecallIntervalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMsgRecallIntervalResponse>(await DoRPCRequestAsync("UpdateMsgRecallInterval", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMsgRecallIntervalResponse UpdateMsgRecallInterval(UpdateMsgRecallIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMsgRecallIntervalWithOptions(request, runtime);
        }

        public async Task<UpdateMsgRecallIntervalResponse> UpdateMsgRecallIntervalAsync(UpdateMsgRecallIntervalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMsgRecallIntervalWithOptionsAsync(request, runtime);
        }

        public SendCustomMessageToRoomUsersResponse SendCustomMessageToRoomUsersWithOptions(SendCustomMessageToRoomUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCustomMessageToRoomUsersResponse>(DoRPCRequest("SendCustomMessageToRoomUsers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendCustomMessageToRoomUsersResponse> SendCustomMessageToRoomUsersWithOptionsAsync(SendCustomMessageToRoomUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCustomMessageToRoomUsersResponse>(await DoRPCRequestAsync("SendCustomMessageToRoomUsers", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendCustomMessageToRoomUsersResponse SendCustomMessageToRoomUsers(SendCustomMessageToRoomUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCustomMessageToRoomUsersWithOptions(request, runtime);
        }

        public async Task<SendCustomMessageToRoomUsersResponse> SendCustomMessageToRoomUsersAsync(SendCustomMessageToRoomUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCustomMessageToRoomUsersWithOptionsAsync(request, runtime);
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

        public QueryInterconnectionCidMappingResponse QueryInterconnectionCidMappingWithOptions(QueryInterconnectionCidMappingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryInterconnectionCidMappingShrinkRequest request = new QueryInterconnectionCidMappingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInterconnectionCidMappingResponse>(DoRPCRequest("QueryInterconnectionCidMapping", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryInterconnectionCidMappingResponse> QueryInterconnectionCidMappingWithOptionsAsync(QueryInterconnectionCidMappingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryInterconnectionCidMappingShrinkRequest request = new QueryInterconnectionCidMappingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RequestParams.ToMap()))
            {
                request.RequestParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RequestParams.ToMap(), "RequestParams", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInterconnectionCidMappingResponse>(await DoRPCRequestAsync("QueryInterconnectionCidMapping", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryInterconnectionCidMappingResponse QueryInterconnectionCidMapping(QueryInterconnectionCidMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInterconnectionCidMappingWithOptions(request, runtime);
        }

        public async Task<QueryInterconnectionCidMappingResponse> QueryInterconnectionCidMappingAsync(QueryInterconnectionCidMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInterconnectionCidMappingWithOptionsAsync(request, runtime);
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

    }
}
