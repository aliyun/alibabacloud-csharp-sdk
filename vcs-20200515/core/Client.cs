// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Vcs20200515.Models;

namespace AlibabaCloud.SDK.Vcs20200515
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("vcs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public UnsubscribeDeviceEventResponse UnsubscribeDeviceEventWithOptions(UnsubscribeDeviceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnsubscribeDeviceEventResponse>(DoRequest("UnsubscribeDeviceEvent", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnsubscribeDeviceEventResponse> UnsubscribeDeviceEventWithOptionsAsync(UnsubscribeDeviceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnsubscribeDeviceEventResponse>(await DoRequestAsync("UnsubscribeDeviceEvent", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UnsubscribeDeviceEventResponse UnsubscribeDeviceEvent(UnsubscribeDeviceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnsubscribeDeviceEventWithOptions(request, runtime);
        }

        public async Task<UnsubscribeDeviceEventResponse> UnsubscribeDeviceEventAsync(UnsubscribeDeviceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnsubscribeDeviceEventWithOptionsAsync(request, runtime);
        }

        public ListSubscribeDeviceResponse ListSubscribeDeviceWithOptions(ListSubscribeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSubscribeDeviceResponse>(DoRequest("ListSubscribeDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListSubscribeDeviceResponse> ListSubscribeDeviceWithOptionsAsync(ListSubscribeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSubscribeDeviceResponse>(await DoRequestAsync("ListSubscribeDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListSubscribeDeviceResponse ListSubscribeDevice(ListSubscribeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSubscribeDeviceWithOptions(request, runtime);
        }

        public async Task<ListSubscribeDeviceResponse> ListSubscribeDeviceAsync(ListSubscribeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSubscribeDeviceWithOptionsAsync(request, runtime);
        }

        public SubscribeDeviceEventResponse SubscribeDeviceEventWithOptions(SubscribeDeviceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubscribeDeviceEventResponse>(DoRequest("SubscribeDeviceEvent", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SubscribeDeviceEventResponse> SubscribeDeviceEventWithOptionsAsync(SubscribeDeviceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubscribeDeviceEventResponse>(await DoRequestAsync("SubscribeDeviceEvent", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public SubscribeDeviceEventResponse SubscribeDeviceEvent(SubscribeDeviceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubscribeDeviceEventWithOptions(request, runtime);
        }

        public async Task<SubscribeDeviceEventResponse> SubscribeDeviceEventAsync(SubscribeDeviceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubscribeDeviceEventWithOptionsAsync(request, runtime);
        }

        public SubscribeSpaceEventResponse SubscribeSpaceEventWithOptions(SubscribeSpaceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubscribeSpaceEventResponse>(DoRequest("SubscribeSpaceEvent", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SubscribeSpaceEventResponse> SubscribeSpaceEventWithOptionsAsync(SubscribeSpaceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubscribeSpaceEventResponse>(await DoRequestAsync("SubscribeSpaceEvent", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public SubscribeSpaceEventResponse SubscribeSpaceEvent(SubscribeSpaceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubscribeSpaceEventWithOptions(request, runtime);
        }

        public async Task<SubscribeSpaceEventResponse> SubscribeSpaceEventAsync(SubscribeSpaceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubscribeSpaceEventWithOptionsAsync(request, runtime);
        }

        public UnsubscribeSpaceEventResponse UnsubscribeSpaceEventWithOptions(UnsubscribeSpaceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnsubscribeSpaceEventResponse>(DoRequest("UnsubscribeSpaceEvent", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnsubscribeSpaceEventResponse> UnsubscribeSpaceEventWithOptionsAsync(UnsubscribeSpaceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnsubscribeSpaceEventResponse>(await DoRequestAsync("UnsubscribeSpaceEvent", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UnsubscribeSpaceEventResponse UnsubscribeSpaceEvent(UnsubscribeSpaceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnsubscribeSpaceEventWithOptions(request, runtime);
        }

        public async Task<UnsubscribeSpaceEventResponse> UnsubscribeSpaceEventAsync(UnsubscribeSpaceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnsubscribeSpaceEventWithOptionsAsync(request, runtime);
        }

        public ListPersonTraceDetailsResponse ListPersonTraceDetailsWithOptions(ListPersonTraceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPersonTraceDetailsResponse>(DoRequest("ListPersonTraceDetails", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListPersonTraceDetailsResponse> ListPersonTraceDetailsWithOptionsAsync(ListPersonTraceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPersonTraceDetailsResponse>(await DoRequestAsync("ListPersonTraceDetails", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public ListPersonTraceDetailsResponse ListPersonTraceDetails(ListPersonTraceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonTraceDetailsWithOptions(request, runtime);
        }

        public async Task<ListPersonTraceDetailsResponse> ListPersonTraceDetailsAsync(ListPersonTraceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonTraceDetailsWithOptionsAsync(request, runtime);
        }

        public GetMonitorListResponse GetMonitorListWithOptions(GetMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMonitorListResponse>(DoRequest("GetMonitorList", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMonitorListResponse> GetMonitorListWithOptionsAsync(GetMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMonitorListResponse>(await DoRequestAsync("GetMonitorList", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetMonitorListResponse GetMonitorList(GetMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonitorListWithOptions(request, runtime);
        }

        public async Task<GetMonitorListResponse> GetMonitorListAsync(GetMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonitorListWithOptionsAsync(request, runtime);
        }

        public ListDeviceGroupsResponse ListDeviceGroupsWithOptions(ListDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDeviceGroupsResponse>(DoRequest("ListDeviceGroups", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDeviceGroupsResponse> ListDeviceGroupsWithOptionsAsync(ListDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDeviceGroupsResponse>(await DoRequestAsync("ListDeviceGroups", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListDeviceGroupsResponse ListDeviceGroups(ListDeviceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceGroupsWithOptions(request, runtime);
        }

        public async Task<ListDeviceGroupsResponse> ListDeviceGroupsAsync(ListDeviceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceGroupsWithOptionsAsync(request, runtime);
        }

        public SearchObjectResponse SearchObjectWithOptions(SearchObjectRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            SearchObjectShrinkRequest request = new SearchObjectShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.DeviceList))
            {
                request.DeviceListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.DeviceList);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Conditions);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.ImagePath))
            {
                request.ImagePathShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.ImagePath);
            }
            return TeaModel.ToObject<SearchObjectResponse>(DoRequest("SearchObject", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SearchObjectResponse> SearchObjectWithOptionsAsync(SearchObjectRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            SearchObjectShrinkRequest request = new SearchObjectShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.DeviceList))
            {
                request.DeviceListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.DeviceList);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Conditions);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.ImagePath))
            {
                request.ImagePathShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.ImagePath);
            }
            return TeaModel.ToObject<SearchObjectResponse>(await DoRequestAsync("SearchObject", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public SearchObjectResponse SearchObject(SearchObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchObjectWithOptions(request, runtime);
        }

        public async Task<SearchObjectResponse> SearchObjectAsync(SearchObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchObjectWithOptionsAsync(request, runtime);
        }

        public DescribeDevicesResponse DescribeDevicesWithOptions(DescribeDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDevicesResponse>(DoRequest("DescribeDevices", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDevicesResponse> DescribeDevicesWithOptionsAsync(DescribeDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDevicesResponse>(await DoRequestAsync("DescribeDevices", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDevicesResponse DescribeDevices(DescribeDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDevicesWithOptions(request, runtime);
        }

        public async Task<DescribeDevicesResponse> DescribeDevicesAsync(DescribeDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDevicesWithOptionsAsync(request, runtime);
        }

        public GetProfileListResponse GetProfileListWithOptions(GetProfileListRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            GetProfileListShrinkRequest request = new GetProfileListShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.PersonIdList))
            {
                request.PersonIdListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.PersonIdList);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.ProfileIdList))
            {
                request.ProfileIdListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.ProfileIdList);
            }
            return TeaModel.ToObject<GetProfileListResponse>(DoRequest("GetProfileList", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetProfileListResponse> GetProfileListWithOptionsAsync(GetProfileListRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            GetProfileListShrinkRequest request = new GetProfileListShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.PersonIdList))
            {
                request.PersonIdListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.PersonIdList);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.ProfileIdList))
            {
                request.ProfileIdListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.ProfileIdList);
            }
            return TeaModel.ToObject<GetProfileListResponse>(await DoRequestAsync("GetProfileList", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetProfileListResponse GetProfileList(GetProfileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProfileListWithOptions(request, runtime);
        }

        public async Task<GetProfileListResponse> GetProfileListAsync(GetProfileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProfileListWithOptionsAsync(request, runtime);
        }

        public GetProfileDetailResponse GetProfileDetailWithOptions(GetProfileDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetProfileDetailResponse>(DoRequest("GetProfileDetail", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetProfileDetailResponse> GetProfileDetailWithOptionsAsync(GetProfileDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetProfileDetailResponse>(await DoRequestAsync("GetProfileDetail", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetProfileDetailResponse GetProfileDetail(GetProfileDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProfileDetailWithOptions(request, runtime);
        }

        public async Task<GetProfileDetailResponse> GetProfileDetailAsync(GetProfileDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProfileDetailWithOptionsAsync(request, runtime);
        }

        public DeleteProfileCatalogResponse DeleteProfileCatalogWithOptions(DeleteProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProfileCatalogResponse>(DoRequest("DeleteProfileCatalog", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProfileCatalogResponse> DeleteProfileCatalogWithOptionsAsync(DeleteProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProfileCatalogResponse>(await DoRequestAsync("DeleteProfileCatalog", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProfileCatalogResponse DeleteProfileCatalog(DeleteProfileCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProfileCatalogWithOptions(request, runtime);
        }

        public async Task<DeleteProfileCatalogResponse> DeleteProfileCatalogAsync(DeleteProfileCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProfileCatalogWithOptionsAsync(request, runtime);
        }

        public BindPersonResponse BindPersonWithOptions(BindPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindPersonResponse>(DoRequest("BindPerson", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindPersonResponse> BindPersonWithOptionsAsync(BindPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindPersonResponse>(await DoRequestAsync("BindPerson", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public BindPersonResponse BindPerson(BindPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindPersonWithOptions(request, runtime);
        }

        public async Task<BindPersonResponse> BindPersonAsync(BindPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindPersonWithOptionsAsync(request, runtime);
        }

        public UpdateProfileResponse UpdateProfileWithOptions(UpdateProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProfileResponse>(DoRequest("UpdateProfile", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProfileResponse> UpdateProfileWithOptionsAsync(UpdateProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProfileResponse>(await DoRequestAsync("UpdateProfile", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProfileWithOptions(request, runtime);
        }

        public async Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProfileWithOptionsAsync(request, runtime);
        }

        public UnbindPersonResponse UnbindPersonWithOptions(UnbindPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindPersonResponse>(DoRequest("UnbindPerson", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindPersonResponse> UnbindPersonWithOptionsAsync(UnbindPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindPersonResponse>(await DoRequestAsync("UnbindPerson", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UnbindPersonResponse UnbindPerson(UnbindPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindPersonWithOptions(request, runtime);
        }

        public async Task<UnbindPersonResponse> UnbindPersonAsync(UnbindPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindPersonWithOptionsAsync(request, runtime);
        }

        public AddProfileResponse AddProfileWithOptions(AddProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddProfileResponse>(DoRequest("AddProfile", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddProfileResponse> AddProfileWithOptionsAsync(AddProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddProfileResponse>(await DoRequestAsync("AddProfile", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public AddProfileResponse AddProfile(AddProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddProfileWithOptions(request, runtime);
        }

        public async Task<AddProfileResponse> AddProfileAsync(AddProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddProfileWithOptionsAsync(request, runtime);
        }

        public UpdateProfileCatalogResponse UpdateProfileCatalogWithOptions(UpdateProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProfileCatalogResponse>(DoRequest("UpdateProfileCatalog", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProfileCatalogResponse> UpdateProfileCatalogWithOptionsAsync(UpdateProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProfileCatalogResponse>(await DoRequestAsync("UpdateProfileCatalog", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProfileCatalogResponse UpdateProfileCatalog(UpdateProfileCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProfileCatalogWithOptions(request, runtime);
        }

        public async Task<UpdateProfileCatalogResponse> UpdateProfileCatalogAsync(UpdateProfileCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProfileCatalogWithOptionsAsync(request, runtime);
        }

        public AddProfileCatalogResponse AddProfileCatalogWithOptions(AddProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddProfileCatalogResponse>(DoRequest("AddProfileCatalog", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddProfileCatalogResponse> AddProfileCatalogWithOptionsAsync(AddProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddProfileCatalogResponse>(await DoRequestAsync("AddProfileCatalog", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public AddProfileCatalogResponse AddProfileCatalog(AddProfileCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddProfileCatalogWithOptions(request, runtime);
        }

        public async Task<AddProfileCatalogResponse> AddProfileCatalogAsync(AddProfileCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddProfileCatalogWithOptionsAsync(request, runtime);
        }

        public GetCatalogListResponse GetCatalogListWithOptions(GetCatalogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetCatalogListResponse>(DoRequest("GetCatalogList", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetCatalogListResponse> GetCatalogListWithOptionsAsync(GetCatalogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetCatalogListResponse>(await DoRequestAsync("GetCatalogList", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetCatalogListResponse GetCatalogList(GetCatalogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCatalogListWithOptions(request, runtime);
        }

        public async Task<GetCatalogListResponse> GetCatalogListAsync(GetCatalogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCatalogListWithOptionsAsync(request, runtime);
        }

        public DeleteProfileResponse DeleteProfileWithOptions(DeleteProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProfileResponse>(DoRequest("DeleteProfile", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProfileResponse> DeleteProfileWithOptionsAsync(DeleteProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProfileResponse>(await DoRequestAsync("DeleteProfile", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProfileWithOptions(request, runtime);
        }

        public async Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProfileWithOptionsAsync(request, runtime);
        }

        public UnbindCorpGroupResponse UnbindCorpGroupWithOptions(UnbindCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindCorpGroupResponse>(DoRequest("UnbindCorpGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindCorpGroupResponse> UnbindCorpGroupWithOptionsAsync(UnbindCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindCorpGroupResponse>(await DoRequestAsync("UnbindCorpGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UnbindCorpGroupResponse UnbindCorpGroup(UnbindCorpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindCorpGroupWithOptions(request, runtime);
        }

        public async Task<UnbindCorpGroupResponse> UnbindCorpGroupAsync(UnbindCorpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindCorpGroupWithOptionsAsync(request, runtime);
        }

        public BindCorpGroupResponse BindCorpGroupWithOptions(BindCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindCorpGroupResponse>(DoRequest("BindCorpGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindCorpGroupResponse> BindCorpGroupWithOptionsAsync(BindCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindCorpGroupResponse>(await DoRequestAsync("BindCorpGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public BindCorpGroupResponse BindCorpGroup(BindCorpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindCorpGroupWithOptions(request, runtime);
        }

        public async Task<BindCorpGroupResponse> BindCorpGroupAsync(BindCorpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindCorpGroupWithOptionsAsync(request, runtime);
        }

        public ListUserGroupsResponse ListUserGroupsWithOptions(ListUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListUserGroupsResponse>(DoRequest("ListUserGroups", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListUserGroupsResponse> ListUserGroupsWithOptionsAsync(ListUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListUserGroupsResponse>(await DoRequestAsync("ListUserGroups", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsWithOptions(request, runtime);
        }

        public async Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsWithOptionsAsync(request, runtime);
        }

        public GetPersonListResponse GetPersonListWithOptions(GetPersonListRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            GetPersonListShrinkRequest request = new GetPersonListShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.CorpIdList))
            {
                request.CorpIdListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.CorpIdList);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.PersonIdList))
            {
                request.PersonIdListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.PersonIdList);
            }
            return TeaModel.ToObject<GetPersonListResponse>(DoRequest("GetPersonList", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPersonListResponse> GetPersonListWithOptionsAsync(GetPersonListRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            GetPersonListShrinkRequest request = new GetPersonListShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.CorpIdList))
            {
                request.CorpIdListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.CorpIdList);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.PersonIdList))
            {
                request.PersonIdListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.PersonIdList);
            }
            return TeaModel.ToObject<GetPersonListResponse>(await DoRequestAsync("GetPersonList", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetPersonListResponse GetPersonList(GetPersonListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPersonListWithOptions(request, runtime);
        }

        public async Task<GetPersonListResponse> GetPersonListAsync(GetPersonListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPersonListWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            ListUsersShrinkRequest request = new ListUsersShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.PersonList))
            {
                request.PersonListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.PersonList);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.UserList))
            {
                request.UserListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.UserList);
            }
            return TeaModel.ToObject<ListUsersResponse>(DoRequest("ListUsers", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            ListUsersShrinkRequest request = new ListUsersShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.PersonList))
            {
                request.PersonListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.PersonList);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.UserList))
            {
                request.UserListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.UserList);
            }
            return TeaModel.ToObject<ListUsersResponse>(await DoRequestAsync("ListUsers", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateUserResponse>(DoRequest("CreateUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateUserResponse>(await DoRequestAsync("CreateUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        public BindUserResponse BindUserWithOptions(BindUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindUserResponse>(DoRequest("BindUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindUserResponse> BindUserWithOptionsAsync(BindUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindUserResponse>(await DoRequestAsync("BindUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public BindUserResponse BindUser(BindUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindUserWithOptions(request, runtime);
        }

        public async Task<BindUserResponse> BindUserAsync(BindUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindUserWithOptionsAsync(request, runtime);
        }

        public GetUserDetailResponse GetUserDetailWithOptions(GetUserDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetUserDetailResponse>(DoRequest("GetUserDetail", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetUserDetailResponse> GetUserDetailWithOptionsAsync(GetUserDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetUserDetailResponse>(await DoRequestAsync("GetUserDetail", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetUserDetailResponse GetUserDetail(GetUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserDetailWithOptions(request, runtime);
        }

        public async Task<GetUserDetailResponse> GetUserDetailAsync(GetUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserDetailWithOptionsAsync(request, runtime);
        }

        public UploadImageResponse UploadImageWithOptions(UploadImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UploadImageResponse>(DoRequest("UploadImage", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UploadImageResponse> UploadImageWithOptionsAsync(UploadImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UploadImageResponse>(await DoRequestAsync("UploadImage", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UploadImageResponse UploadImage(UploadImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadImageWithOptions(request, runtime);
        }

        public async Task<UploadImageResponse> UploadImageAsync(UploadImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadImageWithOptionsAsync(request, runtime);
        }

        public UpdateUserGroupResponse UpdateUserGroupWithOptions(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateUserGroupResponse>(DoRequest("UpdateUserGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateUserGroupResponse> UpdateUserGroupWithOptionsAsync(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateUserGroupResponse>(await DoRequestAsync("UpdateUserGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UpdateUserGroupResponse UpdateUserGroup(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserGroupWithOptions(request, runtime);
        }

        public async Task<UpdateUserGroupResponse> UpdateUserGroupAsync(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserGroupWithOptionsAsync(request, runtime);
        }

        public CreateUserGroupResponse CreateUserGroupWithOptions(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateUserGroupResponse>(DoRequest("CreateUserGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateUserGroupResponse> CreateUserGroupWithOptionsAsync(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateUserGroupResponse>(await DoRequestAsync("CreateUserGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public CreateUserGroupResponse CreateUserGroup(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserGroupWithOptions(request, runtime);
        }

        public async Task<CreateUserGroupResponse> CreateUserGroupAsync(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserGroupWithOptionsAsync(request, runtime);
        }

        public UnbindUserResponse UnbindUserWithOptions(UnbindUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindUserResponse>(DoRequest("UnbindUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindUserResponse> UnbindUserWithOptionsAsync(UnbindUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindUserResponse>(await DoRequestAsync("UnbindUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UnbindUserResponse UnbindUser(UnbindUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindUserWithOptions(request, runtime);
        }

        public async Task<UnbindUserResponse> UnbindUserAsync(UnbindUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindUserWithOptionsAsync(request, runtime);
        }

        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateUserResponse>(DoRequest("UpdateUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateUserResponse>(await DoRequestAsync("UpdateUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteUserResponse>(DoRequest("DeleteUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteUserResponse>(await DoRequestAsync("DeleteUser", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        public DeleteUserGroupResponse DeleteUserGroupWithOptions(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteUserGroupResponse>(DoRequest("DeleteUserGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteUserGroupResponse> DeleteUserGroupWithOptionsAsync(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteUserGroupResponse>(await DoRequestAsync("DeleteUserGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupWithOptions(request, runtime);
        }

        public async Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupWithOptionsAsync(request, runtime);
        }

        public ListPersonVisitCountResponse ListPersonVisitCountWithOptions(ListPersonVisitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPersonVisitCountResponse>(DoRequest("ListPersonVisitCount", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListPersonVisitCountResponse> ListPersonVisitCountWithOptionsAsync(ListPersonVisitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPersonVisitCountResponse>(await DoRequestAsync("ListPersonVisitCount", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public ListPersonVisitCountResponse ListPersonVisitCount(ListPersonVisitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonVisitCountWithOptions(request, runtime);
        }

        public async Task<ListPersonVisitCountResponse> ListPersonVisitCountAsync(ListPersonVisitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonVisitCountWithOptionsAsync(request, runtime);
        }

        public ListEventAlgorithmDetailsResponse ListEventAlgorithmDetailsWithOptions(ListEventAlgorithmDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListEventAlgorithmDetailsResponse>(DoRequest("ListEventAlgorithmDetails", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListEventAlgorithmDetailsResponse> ListEventAlgorithmDetailsWithOptionsAsync(ListEventAlgorithmDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListEventAlgorithmDetailsResponse>(await DoRequestAsync("ListEventAlgorithmDetails", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public ListEventAlgorithmDetailsResponse ListEventAlgorithmDetails(ListEventAlgorithmDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEventAlgorithmDetailsWithOptions(request, runtime);
        }

        public async Task<ListEventAlgorithmDetailsResponse> ListEventAlgorithmDetailsAsync(ListEventAlgorithmDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEventAlgorithmDetailsWithOptionsAsync(request, runtime);
        }

        public ListCorpMetricsResponse ListCorpMetricsWithOptions(ListCorpMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCorpMetricsResponse>(DoRequest("ListCorpMetrics", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListCorpMetricsResponse> ListCorpMetricsWithOptionsAsync(ListCorpMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCorpMetricsResponse>(await DoRequestAsync("ListCorpMetrics", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public ListCorpMetricsResponse ListCorpMetrics(ListCorpMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCorpMetricsWithOptions(request, runtime);
        }

        public async Task<ListCorpMetricsResponse> ListCorpMetricsAsync(ListCorpMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCorpMetricsWithOptionsAsync(request, runtime);
        }

        public ListPersonTraceResponse ListPersonTraceWithOptions(ListPersonTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPersonTraceResponse>(DoRequest("ListPersonTrace", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListPersonTraceResponse> ListPersonTraceWithOptionsAsync(ListPersonTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPersonTraceResponse>(await DoRequestAsync("ListPersonTrace", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public ListPersonTraceResponse ListPersonTrace(ListPersonTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonTraceWithOptions(request, runtime);
        }

        public async Task<ListPersonTraceResponse> ListPersonTraceAsync(ListPersonTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonTraceWithOptionsAsync(request, runtime);
        }

        public ListCorpGroupMetricsResponse ListCorpGroupMetricsWithOptions(ListCorpGroupMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCorpGroupMetricsResponse>(DoRequest("ListCorpGroupMetrics", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListCorpGroupMetricsResponse> ListCorpGroupMetricsWithOptionsAsync(ListCorpGroupMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCorpGroupMetricsResponse>(await DoRequestAsync("ListCorpGroupMetrics", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public ListCorpGroupMetricsResponse ListCorpGroupMetrics(ListCorpGroupMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCorpGroupMetricsWithOptions(request, runtime);
        }

        public async Task<ListCorpGroupMetricsResponse> ListCorpGroupMetricsAsync(ListCorpGroupMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCorpGroupMetricsWithOptionsAsync(request, runtime);
        }

        public GetFaceModelResultResponse GetFaceModelResultWithOptions(GetFaceModelResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFaceModelResultResponse>(DoRequest("GetFaceModelResult", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetFaceModelResultResponse> GetFaceModelResultWithOptionsAsync(GetFaceModelResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFaceModelResultResponse>(await DoRequestAsync("GetFaceModelResult", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetFaceModelResultResponse GetFaceModelResult(GetFaceModelResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFaceModelResultWithOptions(request, runtime);
        }

        public async Task<GetFaceModelResultResponse> GetFaceModelResultAsync(GetFaceModelResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFaceModelResultWithOptionsAsync(request, runtime);
        }

        public CreateCorpGroupResponse CreateCorpGroupWithOptions(CreateCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateCorpGroupResponse>(DoRequest("CreateCorpGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateCorpGroupResponse> CreateCorpGroupWithOptionsAsync(CreateCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateCorpGroupResponse>(await DoRequestAsync("CreateCorpGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public CreateCorpGroupResponse CreateCorpGroup(CreateCorpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCorpGroupWithOptions(request, runtime);
        }

        public async Task<CreateCorpGroupResponse> CreateCorpGroupAsync(CreateCorpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCorpGroupWithOptionsAsync(request, runtime);
        }

        public ListCorpGroupsResponse ListCorpGroupsWithOptions(ListCorpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCorpGroupsResponse>(DoRequest("ListCorpGroups", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListCorpGroupsResponse> ListCorpGroupsWithOptionsAsync(ListCorpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCorpGroupsResponse>(await DoRequestAsync("ListCorpGroups", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public ListCorpGroupsResponse ListCorpGroups(ListCorpGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCorpGroupsWithOptions(request, runtime);
        }

        public async Task<ListCorpGroupsResponse> ListCorpGroupsAsync(ListCorpGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCorpGroupsWithOptionsAsync(request, runtime);
        }

        public DeleteCorpGroupResponse DeleteCorpGroupWithOptions(DeleteCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCorpGroupResponse>(DoRequest("DeleteCorpGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteCorpGroupResponse> DeleteCorpGroupWithOptionsAsync(DeleteCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCorpGroupResponse>(await DoRequestAsync("DeleteCorpGroup", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DeleteCorpGroupResponse DeleteCorpGroup(DeleteCorpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCorpGroupWithOptions(request, runtime);
        }

        public async Task<DeleteCorpGroupResponse> DeleteCorpGroupAsync(DeleteCorpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCorpGroupWithOptionsAsync(request, runtime);
        }

        public InvokeMotorModelResponse InvokeMotorModelWithOptions(InvokeMotorModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeMotorModelResponse>(DoRequest("InvokeMotorModel", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InvokeMotorModelResponse> InvokeMotorModelWithOptionsAsync(InvokeMotorModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeMotorModelResponse>(await DoRequestAsync("InvokeMotorModel", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public InvokeMotorModelResponse InvokeMotorModel(InvokeMotorModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeMotorModelWithOptions(request, runtime);
        }

        public async Task<InvokeMotorModelResponse> InvokeMotorModelAsync(InvokeMotorModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeMotorModelWithOptionsAsync(request, runtime);
        }

        public GetDeviceConfigResponse GetDeviceConfigWithOptions(GetDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceConfigResponse>(DoRequest("GetDeviceConfig", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeviceConfigResponse> GetDeviceConfigWithOptionsAsync(GetDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceConfigResponse>(await DoRequestAsync("GetDeviceConfig", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetDeviceConfigResponse GetDeviceConfig(GetDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceConfigWithOptions(request, runtime);
        }

        public async Task<GetDeviceConfigResponse> GetDeviceConfigAsync(GetDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceConfigWithOptionsAsync(request, runtime);
        }

        public SyncDeviceTimeResponse SyncDeviceTimeWithOptions(SyncDeviceTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SyncDeviceTimeResponse>(DoRequest("SyncDeviceTime", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SyncDeviceTimeResponse> SyncDeviceTimeWithOptionsAsync(SyncDeviceTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SyncDeviceTimeResponse>(await DoRequestAsync("SyncDeviceTime", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public SyncDeviceTimeResponse SyncDeviceTime(SyncDeviceTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncDeviceTimeWithOptions(request, runtime);
        }

        public async Task<SyncDeviceTimeResponse> SyncDeviceTimeAsync(SyncDeviceTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncDeviceTimeWithOptionsAsync(request, runtime);
        }

        public RegisterDeviceResponse RegisterDeviceWithOptions(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RegisterDeviceResponse>(DoRequest("RegisterDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceWithOptionsAsync(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RegisterDeviceResponse>(await DoRequestAsync("RegisterDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceWithOptions(request, runtime);
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceWithOptionsAsync(request, runtime);
        }

        public ReportDeviceCapacityResponse ReportDeviceCapacityWithOptions(ReportDeviceCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReportDeviceCapacityResponse>(DoRequest("ReportDeviceCapacity", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReportDeviceCapacityResponse> ReportDeviceCapacityWithOptionsAsync(ReportDeviceCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReportDeviceCapacityResponse>(await DoRequestAsync("ReportDeviceCapacity", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ReportDeviceCapacityResponse ReportDeviceCapacity(ReportDeviceCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportDeviceCapacityWithOptions(request, runtime);
        }

        public async Task<ReportDeviceCapacityResponse> ReportDeviceCapacityAsync(ReportDeviceCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportDeviceCapacityWithOptionsAsync(request, runtime);
        }

        public SaveVideoSummaryTaskVideoResponse SaveVideoSummaryTaskVideoWithOptions(SaveVideoSummaryTaskVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveVideoSummaryTaskVideoResponse>(DoRequest("SaveVideoSummaryTaskVideo", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SaveVideoSummaryTaskVideoResponse> SaveVideoSummaryTaskVideoWithOptionsAsync(SaveVideoSummaryTaskVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveVideoSummaryTaskVideoResponse>(await DoRequestAsync("SaveVideoSummaryTaskVideo", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public SaveVideoSummaryTaskVideoResponse SaveVideoSummaryTaskVideo(SaveVideoSummaryTaskVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveVideoSummaryTaskVideoWithOptions(request, runtime);
        }

        public async Task<SaveVideoSummaryTaskVideoResponse> SaveVideoSummaryTaskVideoAsync(SaveVideoSummaryTaskVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveVideoSummaryTaskVideoWithOptionsAsync(request, runtime);
        }

        public ListBodyAlgorithmResultsResponse ListBodyAlgorithmResultsWithOptions(ListBodyAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListBodyAlgorithmResultsResponse>(DoRequest("ListBodyAlgorithmResults", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListBodyAlgorithmResultsResponse> ListBodyAlgorithmResultsWithOptionsAsync(ListBodyAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListBodyAlgorithmResultsResponse>(await DoRequestAsync("ListBodyAlgorithmResults", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListBodyAlgorithmResultsResponse ListBodyAlgorithmResults(ListBodyAlgorithmResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBodyAlgorithmResultsWithOptions(request, runtime);
        }

        public async Task<ListBodyAlgorithmResultsResponse> ListBodyAlgorithmResultsAsync(ListBodyAlgorithmResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBodyAlgorithmResultsWithOptionsAsync(request, runtime);
        }

        public AddDataSourceResponse AddDataSourceWithOptions(AddDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddDataSourceResponse>(DoRequest("AddDataSource", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddDataSourceResponse> AddDataSourceWithOptionsAsync(AddDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddDataSourceResponse>(await DoRequestAsync("AddDataSource", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public AddDataSourceResponse AddDataSource(AddDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDataSourceWithOptions(request, runtime);
        }

        public async Task<AddDataSourceResponse> AddDataSourceAsync(AddDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDataSourceWithOptionsAsync(request, runtime);
        }

        public GetVideoComposeResultResponse GetVideoComposeResultWithOptions(GetVideoComposeResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetVideoComposeResultResponse>(DoRequest("GetVideoComposeResult", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetVideoComposeResultResponse> GetVideoComposeResultWithOptionsAsync(GetVideoComposeResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetVideoComposeResultResponse>(await DoRequestAsync("GetVideoComposeResult", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetVideoComposeResultResponse GetVideoComposeResult(GetVideoComposeResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoComposeResultWithOptions(request, runtime);
        }

        public async Task<GetVideoComposeResultResponse> GetVideoComposeResultAsync(GetVideoComposeResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoComposeResultWithOptionsAsync(request, runtime);
        }

        public CreateVideoComposeTaskResponse CreateVideoComposeTaskWithOptions(CreateVideoComposeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVideoComposeTaskResponse>(DoRequest("CreateVideoComposeTask", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateVideoComposeTaskResponse> CreateVideoComposeTaskWithOptionsAsync(CreateVideoComposeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVideoComposeTaskResponse>(await DoRequestAsync("CreateVideoComposeTask", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public CreateVideoComposeTaskResponse CreateVideoComposeTask(CreateVideoComposeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoComposeTaskWithOptions(request, runtime);
        }

        public async Task<CreateVideoComposeTaskResponse> CreateVideoComposeTaskAsync(CreateVideoComposeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoComposeTaskWithOptionsAsync(request, runtime);
        }

        public DeleteDataSourceResponse DeleteDataSourceWithOptions(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataSourceResponse>(DoRequest("DeleteDataSource", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceWithOptionsAsync(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataSourceResponse>(await DoRequestAsync("DeleteDataSource", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceWithOptions(request, runtime);
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceWithOptionsAsync(request, runtime);
        }

        public UploadFileResponse UploadFileWithOptions(UploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UploadFileResponse>(DoRequest("UploadFile", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UploadFileResponse> UploadFileWithOptionsAsync(UploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UploadFileResponse>(await DoRequestAsync("UploadFile", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UploadFileResponse UploadFile(UploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadFileWithOptions(request, runtime);
        }

        public async Task<UploadFileResponse> UploadFileAsync(UploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadFileWithOptionsAsync(request, runtime);
        }

        public ListEventAlgorithmResultsResponse ListEventAlgorithmResultsWithOptions(ListEventAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListEventAlgorithmResultsResponse>(DoRequest("ListEventAlgorithmResults", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListEventAlgorithmResultsResponse> ListEventAlgorithmResultsWithOptionsAsync(ListEventAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListEventAlgorithmResultsResponse>(await DoRequestAsync("ListEventAlgorithmResults", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListEventAlgorithmResultsResponse ListEventAlgorithmResults(ListEventAlgorithmResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEventAlgorithmResultsWithOptions(request, runtime);
        }

        public async Task<ListEventAlgorithmResultsResponse> ListEventAlgorithmResultsAsync(ListEventAlgorithmResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEventAlgorithmResultsWithOptionsAsync(request, runtime);
        }

        public DeleteVideoSummaryTaskResponse DeleteVideoSummaryTaskWithOptions(DeleteVideoSummaryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteVideoSummaryTaskResponse>(DoRequest("DeleteVideoSummaryTask", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteVideoSummaryTaskResponse> DeleteVideoSummaryTaskWithOptionsAsync(DeleteVideoSummaryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteVideoSummaryTaskResponse>(await DoRequestAsync("DeleteVideoSummaryTask", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DeleteVideoSummaryTaskResponse DeleteVideoSummaryTask(DeleteVideoSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVideoSummaryTaskWithOptions(request, runtime);
        }

        public async Task<DeleteVideoSummaryTaskResponse> DeleteVideoSummaryTaskAsync(DeleteVideoSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVideoSummaryTaskWithOptionsAsync(request, runtime);
        }

        public GetVideoSummaryTaskResultResponse GetVideoSummaryTaskResultWithOptions(GetVideoSummaryTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetVideoSummaryTaskResultResponse>(DoRequest("GetVideoSummaryTaskResult", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetVideoSummaryTaskResultResponse> GetVideoSummaryTaskResultWithOptionsAsync(GetVideoSummaryTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetVideoSummaryTaskResultResponse>(await DoRequestAsync("GetVideoSummaryTaskResult", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetVideoSummaryTaskResultResponse GetVideoSummaryTaskResult(GetVideoSummaryTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoSummaryTaskResultWithOptions(request, runtime);
        }

        public async Task<GetVideoSummaryTaskResultResponse> GetVideoSummaryTaskResultAsync(GetVideoSummaryTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoSummaryTaskResultWithOptionsAsync(request, runtime);
        }

        public CreateVideoSummaryTaskResponse CreateVideoSummaryTaskWithOptions(CreateVideoSummaryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVideoSummaryTaskResponse>(DoRequest("CreateVideoSummaryTask", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateVideoSummaryTaskResponse> CreateVideoSummaryTaskWithOptionsAsync(CreateVideoSummaryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVideoSummaryTaskResponse>(await DoRequestAsync("CreateVideoSummaryTask", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public CreateVideoSummaryTaskResponse CreateVideoSummaryTask(CreateVideoSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoSummaryTaskWithOptions(request, runtime);
        }

        public async Task<CreateVideoSummaryTaskResponse> CreateVideoSummaryTaskAsync(CreateVideoSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoSummaryTaskWithOptionsAsync(request, runtime);
        }

        public ListMotorAlgorithmResultsResponse ListMotorAlgorithmResultsWithOptions(ListMotorAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListMotorAlgorithmResultsResponse>(DoRequest("ListMotorAlgorithmResults", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListMotorAlgorithmResultsResponse> ListMotorAlgorithmResultsWithOptionsAsync(ListMotorAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListMotorAlgorithmResultsResponse>(await DoRequestAsync("ListMotorAlgorithmResults", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListMotorAlgorithmResultsResponse ListMotorAlgorithmResults(ListMotorAlgorithmResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMotorAlgorithmResultsWithOptions(request, runtime);
        }

        public async Task<ListMotorAlgorithmResultsResponse> ListMotorAlgorithmResultsAsync(ListMotorAlgorithmResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMotorAlgorithmResultsWithOptionsAsync(request, runtime);
        }

        public ListFaceAlgorithmResultsResponse ListFaceAlgorithmResultsWithOptions(ListFaceAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFaceAlgorithmResultsResponse>(DoRequest("ListFaceAlgorithmResults", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListFaceAlgorithmResultsResponse> ListFaceAlgorithmResultsWithOptionsAsync(ListFaceAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFaceAlgorithmResultsResponse>(await DoRequestAsync("ListFaceAlgorithmResults", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListFaceAlgorithmResultsResponse ListFaceAlgorithmResults(ListFaceAlgorithmResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFaceAlgorithmResultsWithOptions(request, runtime);
        }

        public async Task<ListFaceAlgorithmResultsResponse> ListFaceAlgorithmResultsAsync(ListFaceAlgorithmResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFaceAlgorithmResultsWithOptionsAsync(request, runtime);
        }

        public ListMetricsResponse ListMetricsWithOptions(ListMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListMetricsResponse>(DoRequest("ListMetrics", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListMetricsResponse> ListMetricsWithOptionsAsync(ListMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListMetricsResponse>(await DoRequestAsync("ListMetrics", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListMetricsResponse ListMetrics(ListMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMetricsWithOptions(request, runtime);
        }

        public async Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMetricsWithOptionsAsync(request, runtime);
        }

        public DeleteRecordsResponse DeleteRecordsWithOptions(DeleteRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRecordsResponse>(DoRequest("DeleteRecords", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteRecordsResponse> DeleteRecordsWithOptionsAsync(DeleteRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRecordsResponse>(await DoRequestAsync("DeleteRecords", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DeleteRecordsResponse DeleteRecords(DeleteRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordsWithOptions(request, runtime);
        }

        public async Task<DeleteRecordsResponse> DeleteRecordsAsync(DeleteRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordsWithOptionsAsync(request, runtime);
        }

        public RecognizeFaceQualityResponse RecognizeFaceQualityWithOptions(RecognizeFaceQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RecognizeFaceQualityResponse>(DoRequest("RecognizeFaceQuality", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RecognizeFaceQualityResponse> RecognizeFaceQualityWithOptionsAsync(RecognizeFaceQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RecognizeFaceQualityResponse>(await DoRequestAsync("RecognizeFaceQuality", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public RecognizeFaceQualityResponse RecognizeFaceQuality(RecognizeFaceQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeFaceQualityWithOptions(request, runtime);
        }

        public async Task<RecognizeFaceQualityResponse> RecognizeFaceQualityAsync(RecognizeFaceQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeFaceQualityWithOptionsAsync(request, runtime);
        }

        public ListPersonsResponse ListPersonsWithOptions(ListPersonsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPersonsResponse>(DoRequest("ListPersons", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPersonsResponse> ListPersonsWithOptionsAsync(ListPersonsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPersonsResponse>(await DoRequestAsync("ListPersons", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListPersonsResponse ListPersons(ListPersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonsWithOptions(request, runtime);
        }

        public async Task<ListPersonsResponse> ListPersonsAsync(ListPersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonsWithOptionsAsync(request, runtime);
        }

        public GetPersonDetailResponse GetPersonDetailWithOptions(GetPersonDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPersonDetailResponse>(DoRequest("GetPersonDetail", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPersonDetailResponse> GetPersonDetailWithOptionsAsync(GetPersonDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPersonDetailResponse>(await DoRequestAsync("GetPersonDetail", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetPersonDetailResponse GetPersonDetail(GetPersonDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPersonDetailWithOptions(request, runtime);
        }

        public async Task<GetPersonDetailResponse> GetPersonDetailAsync(GetPersonDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPersonDetailWithOptionsAsync(request, runtime);
        }

        public GetFaceOptionsResponse GetFaceOptionsWithOptions(GetFaceOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFaceOptionsResponse>(DoRequest("GetFaceOptions", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetFaceOptionsResponse> GetFaceOptionsWithOptionsAsync(GetFaceOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFaceOptionsResponse>(await DoRequestAsync("GetFaceOptions", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetFaceOptionsResponse GetFaceOptions(GetFaceOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFaceOptionsWithOptions(request, runtime);
        }

        public async Task<GetFaceOptionsResponse> GetFaceOptionsAsync(GetFaceOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFaceOptionsWithOptionsAsync(request, runtime);
        }

        public GetBodyOptionsResponse GetBodyOptionsWithOptions(GetBodyOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBodyOptionsResponse>(DoRequest("GetBodyOptions", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetBodyOptionsResponse> GetBodyOptionsWithOptionsAsync(GetBodyOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBodyOptionsResponse>(await DoRequestAsync("GetBodyOptions", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetBodyOptionsResponse GetBodyOptions(GetBodyOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBodyOptionsWithOptions(request, runtime);
        }

        public async Task<GetBodyOptionsResponse> GetBodyOptionsAsync(GetBodyOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBodyOptionsWithOptionsAsync(request, runtime);
        }

        public StopMonitorResponse StopMonitorWithOptions(StopMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopMonitorResponse>(DoRequest("StopMonitor", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopMonitorResponse> StopMonitorWithOptionsAsync(StopMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopMonitorResponse>(await DoRequestAsync("StopMonitor", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public StopMonitorResponse StopMonitor(StopMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMonitorWithOptions(request, runtime);
        }

        public async Task<StopMonitorResponse> StopMonitorAsync(StopMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMonitorWithOptionsAsync(request, runtime);
        }

        public SearchBodyResponse SearchBodyWithOptions(SearchBodyRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            SearchBodyShrinkRequest request = new SearchBodyShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.OptionList))
            {
                request.OptionListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.OptionList);
            }
            return TeaModel.ToObject<SearchBodyResponse>(DoRequest("SearchBody", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SearchBodyResponse> SearchBodyWithOptionsAsync(SearchBodyRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            SearchBodyShrinkRequest request = new SearchBodyShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.OptionList))
            {
                request.OptionListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.OptionList);
            }
            return TeaModel.ToObject<SearchBodyResponse>(await DoRequestAsync("SearchBody", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public SearchBodyResponse SearchBody(SearchBodyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchBodyWithOptions(request, runtime);
        }

        public async Task<SearchBodyResponse> SearchBodyAsync(SearchBodyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchBodyWithOptionsAsync(request, runtime);
        }

        public AddMonitorResponse AddMonitorWithOptions(AddMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddMonitorResponse>(DoRequest("AddMonitor", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddMonitorResponse> AddMonitorWithOptionsAsync(AddMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddMonitorResponse>(await DoRequestAsync("AddMonitor", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public AddMonitorResponse AddMonitor(AddMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMonitorWithOptions(request, runtime);
        }

        public async Task<AddMonitorResponse> AddMonitorAsync(AddMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMonitorWithOptionsAsync(request, runtime);
        }

        public GetMonitorResultResponse GetMonitorResultWithOptions(GetMonitorResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMonitorResultResponse>(DoRequest("GetMonitorResult", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMonitorResultResponse> GetMonitorResultWithOptionsAsync(GetMonitorResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMonitorResultResponse>(await DoRequestAsync("GetMonitorResult", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetMonitorResultResponse GetMonitorResult(GetMonitorResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonitorResultWithOptions(request, runtime);
        }

        public async Task<GetMonitorResultResponse> GetMonitorResultAsync(GetMonitorResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonitorResultWithOptionsAsync(request, runtime);
        }

        public UpdateMonitorResponse UpdateMonitorWithOptions(UpdateMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMonitorResponse>(DoRequest("UpdateMonitor", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateMonitorResponse> UpdateMonitorWithOptionsAsync(UpdateMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMonitorResponse>(await DoRequestAsync("UpdateMonitor", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMonitorWithOptions(request, runtime);
        }

        public async Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMonitorWithOptionsAsync(request, runtime);
        }

        public GetDeviceVideoUrlResponse GetDeviceVideoUrlWithOptions(GetDeviceVideoUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceVideoUrlResponse>(DoRequest("GetDeviceVideoUrl", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeviceVideoUrlResponse> GetDeviceVideoUrlWithOptionsAsync(GetDeviceVideoUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceVideoUrlResponse>(await DoRequestAsync("GetDeviceVideoUrl", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetDeviceVideoUrlResponse GetDeviceVideoUrl(GetDeviceVideoUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceVideoUrlWithOptions(request, runtime);
        }

        public async Task<GetDeviceVideoUrlResponse> GetDeviceVideoUrlAsync(GetDeviceVideoUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceVideoUrlWithOptionsAsync(request, runtime);
        }

        public GetInventoryResponse GetInventoryWithOptions(GetInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInventoryResponse>(DoRequest("GetInventory", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetInventoryResponse> GetInventoryWithOptionsAsync(GetInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInventoryResponse>(await DoRequestAsync("GetInventory", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetInventoryResponse GetInventory(GetInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInventoryWithOptions(request, runtime);
        }

        public async Task<GetInventoryResponse> GetInventoryAsync(GetInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInventoryWithOptionsAsync(request, runtime);
        }

        public RecognizeImageResponse RecognizeImageWithOptions(RecognizeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RecognizeImageResponse>(DoRequest("RecognizeImage", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RecognizeImageResponse> RecognizeImageWithOptionsAsync(RecognizeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RecognizeImageResponse>(await DoRequestAsync("RecognizeImage", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public RecognizeImageResponse RecognizeImage(RecognizeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeImageWithOptions(request, runtime);
        }

        public async Task<RecognizeImageResponse> RecognizeImageAsync(RecognizeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeImageWithOptionsAsync(request, runtime);
        }

        public ListCorpsResponse ListCorpsWithOptions(ListCorpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCorpsResponse>(DoRequest("ListCorps", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListCorpsResponse> ListCorpsWithOptionsAsync(ListCorpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCorpsResponse>(await DoRequestAsync("ListCorps", "HTTPS", "POST", "2020-05-15", "AK,APP", null, request.ToMap(), runtime));
        }

        public ListCorpsResponse ListCorps(ListCorpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCorpsWithOptions(request, runtime);
        }

        public async Task<ListCorpsResponse> ListCorpsAsync(ListCorpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCorpsWithOptionsAsync(request, runtime);
        }

        public UpdateCorpResponse UpdateCorpWithOptions(UpdateCorpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateCorpResponse>(DoRequest("UpdateCorp", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateCorpResponse> UpdateCorpWithOptionsAsync(UpdateCorpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateCorpResponse>(await DoRequestAsync("UpdateCorp", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UpdateCorpResponse UpdateCorp(UpdateCorpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCorpWithOptions(request, runtime);
        }

        public async Task<UpdateCorpResponse> UpdateCorpAsync(UpdateCorpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCorpWithOptionsAsync(request, runtime);
        }

        public UpdateDeviceResponse UpdateDeviceWithOptions(UpdateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceResponse>(DoRequest("UpdateDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDeviceResponse> UpdateDeviceWithOptionsAsync(UpdateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceResponse>(await DoRequestAsync("UpdateDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceWithOptions(request, runtime);
        }

        public async Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceWithOptionsAsync(request, runtime);
        }

        public ListDevicesResponse ListDevicesWithOptions(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDevicesResponse>(DoRequest("ListDevices", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDevicesResponse> ListDevicesWithOptionsAsync(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDevicesResponse>(await DoRequestAsync("ListDevices", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevicesWithOptions(request, runtime);
        }

        public async Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevicesWithOptionsAsync(request, runtime);
        }

        public GetDeviceLiveUrlResponse GetDeviceLiveUrlWithOptions(GetDeviceLiveUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceLiveUrlResponse>(DoRequest("GetDeviceLiveUrl", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeviceLiveUrlResponse> GetDeviceLiveUrlWithOptionsAsync(GetDeviceLiveUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceLiveUrlResponse>(await DoRequestAsync("GetDeviceLiveUrl", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public GetDeviceLiveUrlResponse GetDeviceLiveUrl(GetDeviceLiveUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceLiveUrlWithOptions(request, runtime);
        }

        public async Task<GetDeviceLiveUrlResponse> GetDeviceLiveUrlAsync(GetDeviceLiveUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceLiveUrlWithOptionsAsync(request, runtime);
        }

        public SearchFaceResponse SearchFaceWithOptions(SearchFaceRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            SearchFaceShrinkRequest request = new SearchFaceShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.OptionList))
            {
                request.OptionListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.OptionList);
            }
            return TeaModel.ToObject<SearchFaceResponse>(DoRequest("SearchFace", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SearchFaceResponse> SearchFaceWithOptionsAsync(SearchFaceRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            SearchFaceShrinkRequest request = new SearchFaceShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.OptionList))
            {
                request.OptionListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.OptionList);
            }
            return TeaModel.ToObject<SearchFaceResponse>(await DoRequestAsync("SearchFace", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public SearchFaceResponse SearchFace(SearchFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchFaceWithOptions(request, runtime);
        }

        public async Task<SearchFaceResponse> SearchFaceAsync(SearchFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchFaceWithOptionsAsync(request, runtime);
        }

        public AddDeviceResponse AddDeviceWithOptions(AddDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddDeviceResponse>(DoRequest("AddDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddDeviceResponse> AddDeviceWithOptionsAsync(AddDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddDeviceResponse>(await DoRequestAsync("AddDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public AddDeviceResponse AddDevice(AddDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDeviceWithOptions(request, runtime);
        }

        public async Task<AddDeviceResponse> AddDeviceAsync(AddDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDeviceWithOptionsAsync(request, runtime);
        }

        public CreateCorpResponse CreateCorpWithOptions(CreateCorpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateCorpResponse>(DoRequest("CreateCorp", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateCorpResponse> CreateCorpWithOptionsAsync(CreateCorpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateCorpResponse>(await DoRequestAsync("CreateCorp", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public CreateCorpResponse CreateCorp(CreateCorpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCorpWithOptions(request, runtime);
        }

        public async Task<CreateCorpResponse> CreateCorpAsync(CreateCorpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCorpWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceResponse DeleteDeviceWithOptions(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceResponse>(DoRequest("DeleteDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceWithOptionsAsync(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceResponse>(await DoRequestAsync("DeleteDevice", "HTTPS", "POST", "2020-05-15", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceWithOptionsAsync(request, runtime);
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

    }
}
