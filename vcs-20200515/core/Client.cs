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
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("vcs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public UnbindPersonResponse UnbindPersonWithOptions(UnbindPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindPersonResponse>(DoRPCRequest("UnbindPerson", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindPersonResponse> UnbindPersonWithOptionsAsync(UnbindPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindPersonResponse>(await DoRPCRequestAsync("UnbindPerson", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUsersShrinkRequest request = new ListUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonList))
            {
                request.PersonListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonList, "PersonList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserList))
            {
                request.UserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserList, "UserList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUsersShrinkRequest request = new ListUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonList))
            {
                request.PersonListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonList, "PersonList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserList))
            {
                request.UserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserList, "UserList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SearchObjectResponse SearchObjectWithOptions(SearchObjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchObjectShrinkRequest request = new SearchObjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceList))
            {
                request.DeviceListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceList, "DeviceList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImagePath))
            {
                request.ImagePathShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImagePath, "ImagePath", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchObjectResponse>(DoRPCRequest("SearchObject", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchObjectResponse> SearchObjectWithOptionsAsync(SearchObjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchObjectShrinkRequest request = new SearchObjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceList))
            {
                request.DeviceListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceList, "DeviceList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImagePath))
            {
                request.ImagePathShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImagePath, "ImagePath", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchObjectResponse>(await DoRPCRequestAsync("SearchObject", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteRecordsResponse DeleteRecordsWithOptions(DeleteRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordsResponse>(DoRPCRequest("DeleteRecords", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRecordsResponse> DeleteRecordsWithOptionsAsync(DeleteRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordsResponse>(await DoRPCRequestAsync("DeleteRecords", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StartDeployResponse StartDeployWithOptions(StartDeployRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDeployResponse>(DoRPCRequest("StartDeploy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDeployResponse> StartDeployWithOptionsAsync(StartDeployRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDeployResponse>(await DoRPCRequestAsync("StartDeploy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartDeployResponse StartDeploy(StartDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDeployWithOptions(request, runtime);
        }

        public async Task<StartDeployResponse> StartDeployAsync(StartDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDeployWithOptionsAsync(request, runtime);
        }

        public GetInventoryResponse GetInventoryWithOptions(GetInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInventoryResponse>(DoRPCRequest("GetInventory", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInventoryResponse> GetInventoryWithOptionsAsync(GetInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInventoryResponse>(await DoRPCRequestAsync("GetInventory", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UploadImageResponse UploadImageWithOptions(UploadImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadImageResponse>(DoRPCRequest("UploadImage", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadImageResponse> UploadImageWithOptionsAsync(UploadImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadImageResponse>(await DoRPCRequestAsync("UploadImage", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public BindUserResponse BindUserWithOptions(BindUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindUserResponse>(DoRPCRequest("BindUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindUserResponse> BindUserWithOptionsAsync(BindUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindUserResponse>(await DoRPCRequestAsync("BindUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDeviceResponse DeleteDeviceWithOptions(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeviceResponse>(DoRPCRequest("DeleteDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceWithOptionsAsync(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeviceResponse>(await DoRPCRequestAsync("DeleteDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public VerifyTrainLabelResponse VerifyTrainLabelWithOptions(VerifyTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyTrainLabelResponse>(DoRPCRequest("VerifyTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyTrainLabelResponse> VerifyTrainLabelWithOptionsAsync(VerifyTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyTrainLabelResponse>(await DoRPCRequestAsync("VerifyTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyTrainLabelResponse VerifyTrainLabel(VerifyTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyTrainLabelWithOptions(request, runtime);
        }

        public async Task<VerifyTrainLabelResponse> VerifyTrainLabelAsync(VerifyTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyTrainLabelWithOptionsAsync(request, runtime);
        }

        public UpdateMonitorResponse UpdateMonitorWithOptions(UpdateMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMonitorResponse>(DoRPCRequest("UpdateMonitor", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMonitorResponse> UpdateMonitorWithOptionsAsync(UpdateMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMonitorResponse>(await DoRPCRequestAsync("UpdateMonitor", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetPersonDetailResponse GetPersonDetailWithOptions(GetPersonDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPersonDetailResponse>(DoRPCRequest("GetPersonDetail", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPersonDetailResponse> GetPersonDetailWithOptionsAsync(GetPersonDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPersonDetailResponse>(await DoRPCRequestAsync("GetPersonDetail", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteSampleResponse DeleteSampleWithOptions(DeleteSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSampleResponse>(DoRPCRequest("DeleteSample", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSampleResponse> DeleteSampleWithOptionsAsync(DeleteSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSampleResponse>(await DoRPCRequestAsync("DeleteSample", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSampleResponse DeleteSample(DeleteSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSampleWithOptions(request, runtime);
        }

        public async Task<DeleteSampleResponse> DeleteSampleAsync(DeleteSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSampleWithOptionsAsync(request, runtime);
        }

        public ListCorpGroupMetricsResponse ListCorpGroupMetricsWithOptions(ListCorpGroupMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpGroupMetricsResponse>(DoRPCRequest("ListCorpGroupMetrics", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCorpGroupMetricsResponse> ListCorpGroupMetricsWithOptionsAsync(ListCorpGroupMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpGroupMetricsResponse>(await DoRPCRequestAsync("ListCorpGroupMetrics", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveVideoSummaryTaskVideoResponse SaveVideoSummaryTaskVideoWithOptions(SaveVideoSummaryTaskVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveVideoSummaryTaskVideoResponse>(DoRPCRequest("SaveVideoSummaryTaskVideo", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveVideoSummaryTaskVideoResponse> SaveVideoSummaryTaskVideoWithOptionsAsync(SaveVideoSummaryTaskVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveVideoSummaryTaskVideoResponse>(await DoRPCRequestAsync("SaveVideoSummaryTaskVideo", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(DoRPCRequest("DeleteProject", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await DoRPCRequestAsync("DeleteProject", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectWithOptions(request, runtime);
        }

        public async Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectWithOptionsAsync(request, runtime);
        }

        public SearchFaceResponse SearchFaceWithOptions(SearchFaceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchFaceShrinkRequest request = new SearchFaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptionList))
            {
                request.OptionListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptionList, "OptionList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchFaceResponse>(DoRPCRequest("SearchFace", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchFaceResponse> SearchFaceWithOptionsAsync(SearchFaceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchFaceShrinkRequest request = new SearchFaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptionList))
            {
                request.OptionListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptionList, "OptionList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchFaceResponse>(await DoRPCRequestAsync("SearchFace", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListAccessNumberResponse ListAccessNumberWithOptions(ListAccessNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAccessNumberResponse>(DoRPCRequest("ListAccessNumber", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAccessNumberResponse> ListAccessNumberWithOptionsAsync(ListAccessNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAccessNumberResponse>(await DoRPCRequestAsync("ListAccessNumber", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAccessNumberResponse ListAccessNumber(ListAccessNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessNumberWithOptions(request, runtime);
        }

        public async Task<ListAccessNumberResponse> ListAccessNumberAsync(ListAccessNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessNumberWithOptionsAsync(request, runtime);
        }

        public GetDevicePictureResponse GetDevicePictureWithOptions(GetDevicePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevicePictureResponse>(DoRPCRequest("GetDevicePicture", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDevicePictureResponse> GetDevicePictureWithOptionsAsync(GetDevicePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevicePictureResponse>(await DoRPCRequestAsync("GetDevicePicture", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDevicePictureResponse GetDevicePicture(GetDevicePictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDevicePictureWithOptions(request, runtime);
        }

        public async Task<GetDevicePictureResponse> GetDevicePictureAsync(GetDevicePictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDevicePictureWithOptionsAsync(request, runtime);
        }

        public GetMonitorListResponse GetMonitorListWithOptions(GetMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonitorListResponse>(DoRPCRequest("GetMonitorList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMonitorListResponse> GetMonitorListWithOptionsAsync(GetMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonitorListResponse>(await DoRPCRequestAsync("GetMonitorList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTrainLabelResponse ListTrainLabelWithOptions(ListTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTrainLabelResponse>(DoRPCRequest("ListTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTrainLabelResponse> ListTrainLabelWithOptionsAsync(ListTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTrainLabelResponse>(await DoRPCRequestAsync("ListTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTrainLabelResponse ListTrainLabel(ListTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrainLabelWithOptions(request, runtime);
        }

        public async Task<ListTrainLabelResponse> ListTrainLabelAsync(ListTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrainLabelWithOptionsAsync(request, runtime);
        }

        public UpdateTrainLabelResponse UpdateTrainLabelWithOptions(UpdateTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTrainLabelResponse>(DoRPCRequest("UpdateTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTrainLabelResponse> UpdateTrainLabelWithOptionsAsync(UpdateTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTrainLabelResponse>(await DoRPCRequestAsync("UpdateTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTrainLabelResponse UpdateTrainLabel(UpdateTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTrainLabelWithOptions(request, runtime);
        }

        public async Task<UpdateTrainLabelResponse> UpdateTrainLabelAsync(UpdateTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTrainLabelWithOptionsAsync(request, runtime);
        }

        public DeleteTrainLabelResponse DeleteTrainLabelWithOptions(DeleteTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrainLabelResponse>(DoRPCRequest("DeleteTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTrainLabelResponse> DeleteTrainLabelWithOptionsAsync(DeleteTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrainLabelResponse>(await DoRPCRequestAsync("DeleteTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTrainLabelResponse DeleteTrainLabel(DeleteTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrainLabelWithOptions(request, runtime);
        }

        public async Task<DeleteTrainLabelResponse> DeleteTrainLabelAsync(DeleteTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrainLabelWithOptionsAsync(request, runtime);
        }

        public StopDeployResponse StopDeployWithOptions(StopDeployRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDeployResponse>(DoRPCRequest("StopDeploy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDeployResponse> StopDeployWithOptionsAsync(StopDeployRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDeployResponse>(await DoRPCRequestAsync("StopDeploy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDeployResponse StopDeploy(StopDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDeployWithOptions(request, runtime);
        }

        public async Task<StopDeployResponse> StopDeployAsync(StopDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDeployWithOptionsAsync(request, runtime);
        }

        public StopMonitorResponse StopMonitorWithOptions(StopMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMonitorResponse>(DoRPCRequest("StopMonitor", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopMonitorResponse> StopMonitorWithOptionsAsync(StopMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMonitorResponse>(await DoRPCRequestAsync("StopMonitor", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetProfileListResponse GetProfileListWithOptions(GetProfileListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetProfileListShrinkRequest request = new GetProfileListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonIdList))
            {
                request.PersonIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonIdList, "PersonIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProfileIdList))
            {
                request.ProfileIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProfileIdList, "ProfileIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProfileListResponse>(DoRPCRequest("GetProfileList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProfileListResponse> GetProfileListWithOptionsAsync(GetProfileListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetProfileListShrinkRequest request = new GetProfileListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonIdList))
            {
                request.PersonIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonIdList, "PersonIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProfileIdList))
            {
                request.ProfileIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProfileIdList, "ProfileIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProfileListResponse>(await DoRPCRequestAsync("GetProfileList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDataSourceResponse DeleteDataSourceWithOptions(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(DoRPCRequest("DeleteDataSource", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceWithOptionsAsync(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(await DoRPCRequestAsync("DeleteDataSource", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetVideoComposeResultResponse GetVideoComposeResultWithOptions(GetVideoComposeResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoComposeResultResponse>(DoRPCRequest("GetVideoComposeResult", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetVideoComposeResultResponse> GetVideoComposeResultWithOptionsAsync(GetVideoComposeResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoComposeResultResponse>(await DoRPCRequestAsync("GetVideoComposeResult", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFaceAlgorithmResultsResponse ListFaceAlgorithmResultsWithOptions(ListFaceAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceAlgorithmResultsResponse>(DoRPCRequest("ListFaceAlgorithmResults", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFaceAlgorithmResultsResponse> ListFaceAlgorithmResultsWithOptionsAsync(ListFaceAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceAlgorithmResultsResponse>(await DoRPCRequestAsync("ListFaceAlgorithmResults", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetFaceOptionsResponse GetFaceOptionsWithOptions(GetFaceOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFaceOptionsResponse>(DoRPCRequest("GetFaceOptions", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFaceOptionsResponse> GetFaceOptionsWithOptionsAsync(GetFaceOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFaceOptionsResponse>(await DoRPCRequestAsync("GetFaceOptions", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetProfileDetailResponse GetProfileDetailWithOptions(GetProfileDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProfileDetailResponse>(DoRPCRequest("GetProfileDetail", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProfileDetailResponse> GetProfileDetailWithOptionsAsync(GetProfileDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProfileDetailResponse>(await DoRPCRequestAsync("GetProfileDetail", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateDeviceResponse CreateDeviceWithOptions(CreateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceResponse>(DoRPCRequest("CreateDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDeviceResponse> CreateDeviceWithOptionsAsync(CreateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceResponse>(await DoRPCRequestAsync("CreateDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDeviceResponse CreateDevice(CreateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceWithOptions(request, runtime);
        }

        public async Task<CreateDeviceResponse> CreateDeviceAsync(CreateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceWithOptionsAsync(request, runtime);
        }

        public CreateMarkerResponse CreateMarkerWithOptions(CreateMarkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMarkerResponse>(DoRPCRequest("CreateMarker", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMarkerResponse> CreateMarkerWithOptionsAsync(CreateMarkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMarkerResponse>(await DoRPCRequestAsync("CreateMarker", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMarkerResponse CreateMarker(CreateMarkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMarkerWithOptions(request, runtime);
        }

        public async Task<CreateMarkerResponse> CreateMarkerAsync(CreateMarkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMarkerWithOptionsAsync(request, runtime);
        }

        public CreateCorpResponse CreateCorpWithOptions(CreateCorpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCorpResponse>(DoRPCRequest("CreateCorp", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCorpResponse> CreateCorpWithOptionsAsync(CreateCorpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCorpResponse>(await DoRPCRequestAsync("CreateCorp", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateProfileResponse UpdateProfileWithOptions(UpdateProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProfileResponse>(DoRPCRequest("UpdateProfile", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProfileResponse> UpdateProfileWithOptionsAsync(UpdateProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProfileResponse>(await DoRPCRequestAsync("UpdateProfile", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetDeviceCaptureStrategyResponse GetDeviceCaptureStrategyWithOptions(GetDeviceCaptureStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceCaptureStrategyResponse>(DoRPCRequest("GetDeviceCaptureStrategy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDeviceCaptureStrategyResponse> GetDeviceCaptureStrategyWithOptionsAsync(GetDeviceCaptureStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceCaptureStrategyResponse>(await DoRPCRequestAsync("GetDeviceCaptureStrategy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDeviceCaptureStrategyResponse GetDeviceCaptureStrategy(GetDeviceCaptureStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceCaptureStrategyWithOptions(request, runtime);
        }

        public async Task<GetDeviceCaptureStrategyResponse> GetDeviceCaptureStrategyAsync(GetDeviceCaptureStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceCaptureStrategyWithOptionsAsync(request, runtime);
        }

        public StartTrainResponse StartTrainWithOptions(StartTrainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartTrainResponse>(DoRPCRequest("StartTrain", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartTrainResponse> StartTrainWithOptionsAsync(StartTrainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartTrainResponse>(await DoRPCRequestAsync("StartTrain", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartTrainResponse StartTrain(StartTrainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartTrainWithOptions(request, runtime);
        }

        public async Task<StartTrainResponse> StartTrainAsync(StartTrainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartTrainWithOptionsAsync(request, runtime);
        }

        public DeleteVideoSummaryTaskResponse DeleteVideoSummaryTaskWithOptions(DeleteVideoSummaryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVideoSummaryTaskResponse>(DoRPCRequest("DeleteVideoSummaryTask", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVideoSummaryTaskResponse> DeleteVideoSummaryTaskWithOptionsAsync(DeleteVideoSummaryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVideoSummaryTaskResponse>(await DoRPCRequestAsync("DeleteVideoSummaryTask", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UnbindUserResponse UnbindUserWithOptions(UnbindUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindUserResponse>(DoRPCRequest("UnbindUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindUserResponse> UnbindUserWithOptionsAsync(UnbindUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindUserResponse>(await DoRPCRequestAsync("UnbindUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListPersonsResponse ListPersonsWithOptions(ListPersonsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonsResponse>(DoRPCRequest("ListPersons", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonsResponse> ListPersonsWithOptionsAsync(ListPersonsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonsResponse>(await DoRPCRequestAsync("ListPersons", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListMotorAlgorithmResultsResponse ListMotorAlgorithmResultsWithOptions(ListMotorAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMotorAlgorithmResultsResponse>(DoRPCRequest("ListMotorAlgorithmResults", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMotorAlgorithmResultsResponse> ListMotorAlgorithmResultsWithOptionsAsync(ListMotorAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMotorAlgorithmResultsResponse>(await DoRPCRequestAsync("ListMotorAlgorithmResults", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListPersonTraceResponse ListPersonTraceWithOptions(ListPersonTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTraceResponse>(DoRPCRequest("ListPersonTrace", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonTraceResponse> ListPersonTraceWithOptionsAsync(ListPersonTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTraceResponse>(await DoRPCRequestAsync("ListPersonTrace", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListDevicesResponse ListDevicesWithOptions(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevicesResponse>(DoRPCRequest("ListDevices", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevicesResponse> ListDevicesWithOptionsAsync(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevicesResponse>(await DoRPCRequestAsync("ListDevices", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ReportDeviceCapacityResponse ReportDeviceCapacityWithOptions(ReportDeviceCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportDeviceCapacityResponse>(DoRPCRequest("ReportDeviceCapacity", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportDeviceCapacityResponse> ReportDeviceCapacityWithOptionsAsync(ReportDeviceCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportDeviceCapacityResponse>(await DoRPCRequestAsync("ReportDeviceCapacity", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteMarkerResponse DeleteMarkerWithOptions(DeleteMarkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMarkerResponse>(DoRPCRequest("DeleteMarker", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMarkerResponse> DeleteMarkerWithOptionsAsync(DeleteMarkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMarkerResponse>(await DoRPCRequestAsync("DeleteMarker", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMarkerResponse DeleteMarker(DeleteMarkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMarkerWithOptions(request, runtime);
        }

        public async Task<DeleteMarkerResponse> DeleteMarkerAsync(DeleteMarkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMarkerWithOptionsAsync(request, runtime);
        }

        public ListPersonTraceDetailsResponse ListPersonTraceDetailsWithOptions(ListPersonTraceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTraceDetailsResponse>(DoRPCRequest("ListPersonTraceDetails", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonTraceDetailsResponse> ListPersonTraceDetailsWithOptionsAsync(ListPersonTraceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTraceDetailsResponse>(await DoRPCRequestAsync("ListPersonTraceDetails", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListMetricsResponse ListMetricsWithOptions(ListMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMetricsResponse>(DoRPCRequest("ListMetrics", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMetricsResponse> ListMetricsWithOptionsAsync(ListMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMetricsResponse>(await DoRPCRequestAsync("ListMetrics", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteNVRDeviceResponse DeleteNVRDeviceWithOptions(DeleteNVRDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNVRDeviceResponse>(DoRPCRequest("DeleteNVRDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNVRDeviceResponse> DeleteNVRDeviceWithOptionsAsync(DeleteNVRDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNVRDeviceResponse>(await DoRPCRequestAsync("DeleteNVRDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNVRDeviceResponse DeleteNVRDevice(DeleteNVRDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNVRDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteNVRDeviceResponse> DeleteNVRDeviceAsync(DeleteNVRDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNVRDeviceWithOptionsAsync(request, runtime);
        }

        public AddProfileCatalogResponse AddProfileCatalogWithOptions(AddProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProfileCatalogResponse>(DoRPCRequest("AddProfileCatalog", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddProfileCatalogResponse> AddProfileCatalogWithOptionsAsync(AddProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProfileCatalogResponse>(await DoRPCRequestAsync("AddProfileCatalog", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SampleListResponse SampleListWithOptions(SampleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SampleListResponse>(DoRPCRequest("SampleList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SampleListResponse> SampleListWithOptionsAsync(SampleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SampleListResponse>(await DoRPCRequestAsync("SampleList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SampleListResponse SampleList(SampleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SampleListWithOptions(request, runtime);
        }

        public async Task<SampleListResponse> SampleListAsync(SampleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SampleListWithOptionsAsync(request, runtime);
        }

        public RecognizeFaceQualityResponse RecognizeFaceQualityWithOptions(RecognizeFaceQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeFaceQualityResponse>(DoRPCRequest("RecognizeFaceQuality", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecognizeFaceQualityResponse> RecognizeFaceQualityWithOptionsAsync(RecognizeFaceQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeFaceQualityResponse>(await DoRPCRequestAsync("RecognizeFaceQuality", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetTrainAlgorithmResponse GetTrainAlgorithmWithOptions(GetTrainAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrainAlgorithmResponse>(DoRPCRequest("GetTrainAlgorithm", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTrainAlgorithmResponse> GetTrainAlgorithmWithOptionsAsync(GetTrainAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrainAlgorithmResponse>(await DoRPCRequestAsync("GetTrainAlgorithm", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTrainAlgorithmResponse GetTrainAlgorithm(GetTrainAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrainAlgorithmWithOptions(request, runtime);
        }

        public async Task<GetTrainAlgorithmResponse> GetTrainAlgorithmAsync(GetTrainAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrainAlgorithmWithOptionsAsync(request, runtime);
        }

        public DeleteTrainAlgorithmResponse DeleteTrainAlgorithmWithOptions(DeleteTrainAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrainAlgorithmResponse>(DoRPCRequest("DeleteTrainAlgorithm", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTrainAlgorithmResponse> DeleteTrainAlgorithmWithOptionsAsync(DeleteTrainAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrainAlgorithmResponse>(await DoRPCRequestAsync("DeleteTrainAlgorithm", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTrainAlgorithmResponse DeleteTrainAlgorithm(DeleteTrainAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrainAlgorithmWithOptions(request, runtime);
        }

        public async Task<DeleteTrainAlgorithmResponse> DeleteTrainAlgorithmAsync(DeleteTrainAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrainAlgorithmWithOptionsAsync(request, runtime);
        }

        public UpdateMarkerResponse UpdateMarkerWithOptions(UpdateMarkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMarkerResponse>(DoRPCRequest("UpdateMarker", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMarkerResponse> UpdateMarkerWithOptionsAsync(UpdateMarkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMarkerResponse>(await DoRPCRequestAsync("UpdateMarker", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMarkerResponse UpdateMarker(UpdateMarkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMarkerWithOptions(request, runtime);
        }

        public async Task<UpdateMarkerResponse> UpdateMarkerAsync(UpdateMarkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMarkerWithOptionsAsync(request, runtime);
        }

        public ListCorpGroupsResponse ListCorpGroupsWithOptions(ListCorpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpGroupsResponse>(DoRPCRequest("ListCorpGroups", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCorpGroupsResponse> ListCorpGroupsWithOptionsAsync(ListCorpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpGroupsResponse>(await DoRPCRequestAsync("ListCorpGroups", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StopTrainResponse StopTrainWithOptions(StopTrainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopTrainResponse>(DoRPCRequest("StopTrain", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopTrainResponse> StopTrainWithOptionsAsync(StopTrainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopTrainResponse>(await DoRPCRequestAsync("StopTrain", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopTrainResponse StopTrain(StopTrainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopTrainWithOptions(request, runtime);
        }

        public async Task<StopTrainResponse> StopTrainAsync(StopTrainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopTrainWithOptionsAsync(request, runtime);
        }

        public DescribeDevicesResponse DescribeDevicesWithOptions(DescribeDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDevicesResponse>(DoRPCRequest("DescribeDevices", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDevicesResponse> DescribeDevicesWithOptionsAsync(DescribeDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDevicesResponse>(await DoRPCRequestAsync("DescribeDevices", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetDeviceVideoUrlResponse GetDeviceVideoUrlWithOptions(GetDeviceVideoUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceVideoUrlResponse>(DoRPCRequest("GetDeviceVideoUrl", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDeviceVideoUrlResponse> GetDeviceVideoUrlWithOptionsAsync(GetDeviceVideoUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceVideoUrlResponse>(await DoRPCRequestAsync("GetDeviceVideoUrl", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListCorpsResponse ListCorpsWithOptions(ListCorpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpsResponse>(DoRPCRequest("ListCorps", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCorpsResponse> ListCorpsWithOptionsAsync(ListCorpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpsResponse>(await DoRPCRequestAsync("ListCorps", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListBodyAlgorithmResultsResponse ListBodyAlgorithmResultsWithOptions(ListBodyAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBodyAlgorithmResultsResponse>(DoRPCRequest("ListBodyAlgorithmResults", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBodyAlgorithmResultsResponse> ListBodyAlgorithmResultsWithOptionsAsync(ListBodyAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBodyAlgorithmResultsResponse>(await DoRPCRequestAsync("ListBodyAlgorithmResults", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetDeviceConfigResponse GetDeviceConfigWithOptions(GetDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceConfigResponse>(DoRPCRequest("GetDeviceConfig", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDeviceConfigResponse> GetDeviceConfigWithOptionsAsync(GetDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceConfigResponse>(await DoRPCRequestAsync("GetDeviceConfig", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateCorpResponse UpdateCorpWithOptions(UpdateCorpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCorpResponse>(DoRPCRequest("UpdateCorp", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCorpResponse> UpdateCorpWithOptionsAsync(UpdateCorpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCorpResponse>(await DoRPCRequestAsync("UpdateCorp", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateCorpGroupResponse CreateCorpGroupWithOptions(CreateCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCorpGroupResponse>(DoRPCRequest("CreateCorpGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCorpGroupResponse> CreateCorpGroupWithOptionsAsync(CreateCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCorpGroupResponse>(await DoRPCRequestAsync("CreateCorpGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public AddDeviceResponse AddDeviceWithOptions(AddDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDeviceResponse>(DoRPCRequest("AddDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDeviceResponse> AddDeviceWithOptionsAsync(AddDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDeviceResponse>(await DoRPCRequestAsync("AddDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetPersonListResponse GetPersonListWithOptions(GetPersonListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPersonListShrinkRequest request = new GetPersonListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CorpIdList))
            {
                request.CorpIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CorpIdList, "CorpIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonIdList))
            {
                request.PersonIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonIdList, "PersonIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPersonListResponse>(DoRPCRequest("GetPersonList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPersonListResponse> GetPersonListWithOptionsAsync(GetPersonListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPersonListShrinkRequest request = new GetPersonListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CorpIdList))
            {
                request.CorpIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CorpIdList, "CorpIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonIdList))
            {
                request.PersonIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonIdList, "PersonIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPersonListResponse>(await DoRPCRequestAsync("GetPersonList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateTrainLabelResponse CreateTrainLabelWithOptions(CreateTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTrainLabelResponse>(DoRPCRequest("CreateTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTrainLabelResponse> CreateTrainLabelWithOptionsAsync(CreateTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTrainLabelResponse>(await DoRPCRequestAsync("CreateTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTrainLabelResponse CreateTrainLabel(CreateTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrainLabelWithOptions(request, runtime);
        }

        public async Task<CreateTrainLabelResponse> CreateTrainLabelAsync(CreateTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrainLabelWithOptionsAsync(request, runtime);
        }

        public UpdateProfileCatalogResponse UpdateProfileCatalogWithOptions(UpdateProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProfileCatalogResponse>(DoRPCRequest("UpdateProfileCatalog", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProfileCatalogResponse> UpdateProfileCatalogWithOptionsAsync(UpdateProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProfileCatalogResponse>(await DoRPCRequestAsync("UpdateProfileCatalog", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListPersonVisitCountResponse ListPersonVisitCountWithOptions(ListPersonVisitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonVisitCountResponse>(DoRPCRequest("ListPersonVisitCount", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonVisitCountResponse> ListPersonVisitCountWithOptionsAsync(ListPersonVisitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonVisitCountResponse>(await DoRPCRequestAsync("ListPersonVisitCount", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateSampleResponse UpdateSampleWithOptions(UpdateSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSampleResponse>(DoRPCRequest("UpdateSample", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSampleResponse> UpdateSampleWithOptionsAsync(UpdateSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSampleResponse>(await DoRPCRequestAsync("UpdateSample", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSampleResponse UpdateSample(UpdateSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSampleWithOptions(request, runtime);
        }

        public async Task<UpdateSampleResponse> UpdateSampleAsync(UpdateSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSampleWithOptionsAsync(request, runtime);
        }

        public CreateVideoSummaryTaskResponse CreateVideoSummaryTaskWithOptions(CreateVideoSummaryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoSummaryTaskResponse>(DoRPCRequest("CreateVideoSummaryTask", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVideoSummaryTaskResponse> CreateVideoSummaryTaskWithOptionsAsync(CreateVideoSummaryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoSummaryTaskResponse>(await DoRPCRequestAsync("CreateVideoSummaryTask", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListCorpMetricsResponse ListCorpMetricsWithOptions(ListCorpMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpMetricsResponse>(DoRPCRequest("ListCorpMetrics", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCorpMetricsResponse> ListCorpMetricsWithOptionsAsync(ListCorpMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpMetricsResponse>(await DoRPCRequestAsync("ListCorpMetrics", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListEventAlgorithmDetailsResponse ListEventAlgorithmDetailsWithOptions(ListEventAlgorithmDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEventAlgorithmDetailsResponse>(DoRPCRequest("ListEventAlgorithmDetails", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEventAlgorithmDetailsResponse> ListEventAlgorithmDetailsWithOptionsAsync(ListEventAlgorithmDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEventAlgorithmDetailsResponse>(await DoRPCRequestAsync("ListEventAlgorithmDetails", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetCatalogListResponse GetCatalogListWithOptions(GetCatalogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCatalogListResponse>(DoRPCRequest("GetCatalogList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCatalogListResponse> GetCatalogListWithOptionsAsync(GetCatalogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCatalogListResponse>(await DoRPCRequestAsync("GetCatalogList", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListNVRDeviceResponse ListNVRDeviceWithOptions(ListNVRDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNVRDeviceResponse>(DoRPCRequest("ListNVRDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNVRDeviceResponse> ListNVRDeviceWithOptionsAsync(ListNVRDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNVRDeviceResponse>(await DoRPCRequestAsync("ListNVRDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNVRDeviceResponse ListNVRDevice(ListNVRDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNVRDeviceWithOptions(request, runtime);
        }

        public async Task<ListNVRDeviceResponse> ListNVRDeviceAsync(ListNVRDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNVRDeviceWithOptionsAsync(request, runtime);
        }

        public GetDeviceLiveUrlResponse GetDeviceLiveUrlWithOptions(GetDeviceLiveUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceLiveUrlResponse>(DoRPCRequest("GetDeviceLiveUrl", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDeviceLiveUrlResponse> GetDeviceLiveUrlWithOptionsAsync(GetDeviceLiveUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceLiveUrlResponse>(await DoRPCRequestAsync("GetDeviceLiveUrl", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteCorpGroupResponse DeleteCorpGroupWithOptions(DeleteCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCorpGroupResponse>(DoRPCRequest("DeleteCorpGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCorpGroupResponse> DeleteCorpGroupWithOptionsAsync(DeleteCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCorpGroupResponse>(await DoRPCRequestAsync("DeleteCorpGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateTrainAlgorithmResponse UpdateTrainAlgorithmWithOptions(UpdateTrainAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTrainAlgorithmResponse>(DoRPCRequest("UpdateTrainAlgorithm", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTrainAlgorithmResponse> UpdateTrainAlgorithmWithOptionsAsync(UpdateTrainAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTrainAlgorithmResponse>(await DoRPCRequestAsync("UpdateTrainAlgorithm", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTrainAlgorithmResponse UpdateTrainAlgorithm(UpdateTrainAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTrainAlgorithmWithOptions(request, runtime);
        }

        public async Task<UpdateTrainAlgorithmResponse> UpdateTrainAlgorithmAsync(UpdateTrainAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTrainAlgorithmWithOptionsAsync(request, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(DoRPCRequest("CreateUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(await DoRPCRequestAsync("CreateUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListAlgorithmNamesByDeviceIdsResponse ListAlgorithmNamesByDeviceIdsWithOptions(ListAlgorithmNamesByDeviceIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlgorithmNamesByDeviceIdsResponse>(DoRPCRequest("ListAlgorithmNamesByDeviceIds", "2020-05-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAlgorithmNamesByDeviceIdsResponse> ListAlgorithmNamesByDeviceIdsWithOptionsAsync(ListAlgorithmNamesByDeviceIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlgorithmNamesByDeviceIdsResponse>(await DoRPCRequestAsync("ListAlgorithmNamesByDeviceIds", "2020-05-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAlgorithmNamesByDeviceIdsResponse ListAlgorithmNamesByDeviceIds(ListAlgorithmNamesByDeviceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlgorithmNamesByDeviceIdsWithOptions(request, runtime);
        }

        public async Task<ListAlgorithmNamesByDeviceIdsResponse> ListAlgorithmNamesByDeviceIdsAsync(ListAlgorithmNamesByDeviceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlgorithmNamesByDeviceIdsWithOptionsAsync(request, runtime);
        }

        public AddDataSourceResponse AddDataSourceWithOptions(AddDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDataSourceResponse>(DoRPCRequest("AddDataSource", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDataSourceResponse> AddDataSourceWithOptionsAsync(AddDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDataSourceResponse>(await DoRPCRequestAsync("AddDataSource", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UnbindCorpGroupResponse UnbindCorpGroupWithOptions(UnbindCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindCorpGroupResponse>(DoRPCRequest("UnbindCorpGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindCorpGroupResponse> UnbindCorpGroupWithOptionsAsync(UnbindCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindCorpGroupResponse>(await DoRPCRequestAsync("UnbindCorpGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UploadFileResponse UploadFileWithOptions(UploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadFileResponse>(DoRPCRequest("UploadFile", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadFileResponse> UploadFileWithOptionsAsync(UploadFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadFileResponse>(await DoRPCRequestAsync("UploadFile", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserResponse>(DoRPCRequest("UpdateUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserResponse>(await DoRPCRequestAsync("UpdateUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetTrainAlgorithResponse GetTrainAlgorithWithOptions(GetTrainAlgorithRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrainAlgorithResponse>(DoRPCRequest("GetTrainAlgorith", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTrainAlgorithResponse> GetTrainAlgorithWithOptionsAsync(GetTrainAlgorithRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrainAlgorithResponse>(await DoRPCRequestAsync("GetTrainAlgorith", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTrainAlgorithResponse GetTrainAlgorith(GetTrainAlgorithRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrainAlgorithWithOptions(request, runtime);
        }

        public async Task<GetTrainAlgorithResponse> GetTrainAlgorithAsync(GetTrainAlgorithRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrainAlgorithWithOptionsAsync(request, runtime);
        }

        public GetVideoSummaryTaskResultResponse GetVideoSummaryTaskResultWithOptions(GetVideoSummaryTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoSummaryTaskResultResponse>(DoRPCRequest("GetVideoSummaryTaskResult", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetVideoSummaryTaskResultResponse> GetVideoSummaryTaskResultWithOptionsAsync(GetVideoSummaryTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoSummaryTaskResultResponse>(await DoRPCRequestAsync("GetVideoSummaryTaskResult", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListDeviceGroupsResponse ListDeviceGroupsWithOptions(ListDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceGroupsResponse>(DoRPCRequest("ListDeviceGroups", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceGroupsResponse> ListDeviceGroupsWithOptionsAsync(ListDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceGroupsResponse>(await DoRPCRequestAsync("ListDeviceGroups", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetUserDetailResponse GetUserDetailWithOptions(GetUserDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserDetailResponse>(DoRPCRequest("GetUserDetail", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserDetailResponse> GetUserDetailWithOptionsAsync(GetUserDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserDetailResponse>(await DoRPCRequestAsync("GetUserDetail", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateDeviceCaptureStrategyResponse UpdateDeviceCaptureStrategyWithOptions(UpdateDeviceCaptureStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceCaptureStrategyResponse>(DoRPCRequest("UpdateDeviceCaptureStrategy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDeviceCaptureStrategyResponse> UpdateDeviceCaptureStrategyWithOptionsAsync(UpdateDeviceCaptureStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceCaptureStrategyResponse>(await DoRPCRequestAsync("UpdateDeviceCaptureStrategy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDeviceCaptureStrategyResponse UpdateDeviceCaptureStrategy(UpdateDeviceCaptureStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceCaptureStrategyWithOptions(request, runtime);
        }

        public async Task<UpdateDeviceCaptureStrategyResponse> UpdateDeviceCaptureStrategyAsync(UpdateDeviceCaptureStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceCaptureStrategyWithOptionsAsync(request, runtime);
        }

        public CreateUserGroupResponse CreateUserGroupWithOptions(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(DoRPCRequest("CreateUserGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserGroupResponse> CreateUserGroupWithOptionsAsync(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(await DoRPCRequestAsync("CreateUserGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public InvokeMotorModelResponse InvokeMotorModelWithOptions(InvokeMotorModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InvokeMotorModelResponse>(DoRPCRequest("InvokeMotorModel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InvokeMotorModelResponse> InvokeMotorModelWithOptionsAsync(InvokeMotorModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InvokeMotorModelResponse>(await DoRPCRequestAsync("InvokeMotorModel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListEventAlgorithmResultsResponse ListEventAlgorithmResultsWithOptions(ListEventAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEventAlgorithmResultsResponse>(DoRPCRequest("ListEventAlgorithmResults", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEventAlgorithmResultsResponse> ListEventAlgorithmResultsWithOptionsAsync(ListEventAlgorithmResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEventAlgorithmResultsResponse>(await DoRPCRequestAsync("ListEventAlgorithmResults", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetFaceModelResultResponse GetFaceModelResultWithOptions(GetFaceModelResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFaceModelResultResponse>(DoRPCRequest("GetFaceModelResult", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFaceModelResultResponse> GetFaceModelResultWithOptionsAsync(GetFaceModelResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFaceModelResultResponse>(await DoRPCRequestAsync("GetFaceModelResult", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RetryStartDeployResponse RetryStartDeployWithOptions(RetryStartDeployRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetryStartDeployResponse>(DoRPCRequest("RetryStartDeploy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RetryStartDeployResponse> RetryStartDeployWithOptionsAsync(RetryStartDeployRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetryStartDeployResponse>(await DoRPCRequestAsync("RetryStartDeploy", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RetryStartDeployResponse RetryStartDeploy(RetryStartDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryStartDeployWithOptions(request, runtime);
        }

        public async Task<RetryStartDeployResponse> RetryStartDeployAsync(RetryStartDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryStartDeployWithOptionsAsync(request, runtime);
        }

        public SyncDeviceTimeResponse SyncDeviceTimeWithOptions(SyncDeviceTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncDeviceTimeResponse>(DoRPCRequest("SyncDeviceTime", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SyncDeviceTimeResponse> SyncDeviceTimeWithOptionsAsync(SyncDeviceTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncDeviceTimeResponse>(await DoRPCRequestAsync("SyncDeviceTime", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateSampleResponse CreateSampleWithOptions(CreateSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSampleResponse>(DoRPCRequest("CreateSample", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSampleResponse> CreateSampleWithOptionsAsync(CreateSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSampleResponse>(await DoRPCRequestAsync("CreateSample", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSampleResponse CreateSample(CreateSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSampleWithOptions(request, runtime);
        }

        public async Task<CreateSampleResponse> CreateSampleAsync(CreateSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSampleWithOptionsAsync(request, runtime);
        }

        public AddMonitorResponse AddMonitorWithOptions(AddMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMonitorResponse>(DoRPCRequest("AddMonitor", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddMonitorResponse> AddMonitorWithOptionsAsync(AddMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMonitorResponse>(await DoRPCRequestAsync("AddMonitor", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteProfileResponse DeleteProfileWithOptions(DeleteProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProfileResponse>(DoRPCRequest("DeleteProfile", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProfileResponse> DeleteProfileWithOptionsAsync(DeleteProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProfileResponse>(await DoRPCRequestAsync("DeleteProfile", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteProfileCatalogResponse DeleteProfileCatalogWithOptions(DeleteProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProfileCatalogResponse>(DoRPCRequest("DeleteProfileCatalog", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProfileCatalogResponse> DeleteProfileCatalogWithOptionsAsync(DeleteProfileCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProfileCatalogResponse>(await DoRPCRequestAsync("DeleteProfileCatalog", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteIPCDeviceResponse DeleteIPCDeviceWithOptions(DeleteIPCDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIPCDeviceResponse>(DoRPCRequest("DeleteIPCDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIPCDeviceResponse> DeleteIPCDeviceWithOptionsAsync(DeleteIPCDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIPCDeviceResponse>(await DoRPCRequestAsync("DeleteIPCDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIPCDeviceResponse DeleteIPCDevice(DeleteIPCDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIPCDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteIPCDeviceResponse> DeleteIPCDeviceAsync(DeleteIPCDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIPCDeviceWithOptionsAsync(request, runtime);
        }

        public GetMonitorResultResponse GetMonitorResultWithOptions(GetMonitorResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonitorResultResponse>(DoRPCRequest("GetMonitorResult", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMonitorResultResponse> GetMonitorResultWithOptionsAsync(GetMonitorResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonitorResultResponse>(await DoRPCRequestAsync("GetMonitorResult", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RecognizeImageResponse RecognizeImageWithOptions(RecognizeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeImageResponse>(DoRPCRequest("RecognizeImage", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecognizeImageResponse> RecognizeImageWithOptionsAsync(RecognizeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeImageResponse>(await DoRPCRequestAsync("RecognizeImage", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(DoRPCRequest("DeleteUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(await DoRPCRequestAsync("DeleteUser", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateDeviceResponse UpdateDeviceWithOptions(UpdateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceResponse>(DoRPCRequest("UpdateDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDeviceResponse> UpdateDeviceWithOptionsAsync(UpdateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceResponse>(await DoRPCRequestAsync("UpdateDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RegisterDeviceResponse RegisterDeviceWithOptions(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(DoRPCRequest("RegisterDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceWithOptionsAsync(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(await DoRPCRequestAsync("RegisterDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteChannelResponse DeleteChannelWithOptions(DeleteChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChannelResponse>(DoRPCRequest("DeleteChannel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteChannelResponse> DeleteChannelWithOptionsAsync(DeleteChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChannelResponse>(await DoRPCRequestAsync("DeleteChannel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChannelWithOptions(request, runtime);
        }

        public async Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChannelWithOptionsAsync(request, runtime);
        }

        public GetTrainLabelResponse GetTrainLabelWithOptions(GetTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrainLabelResponse>(DoRPCRequest("GetTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTrainLabelResponse> GetTrainLabelWithOptionsAsync(GetTrainLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrainLabelResponse>(await DoRPCRequestAsync("GetTrainLabel", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTrainLabelResponse GetTrainLabel(GetTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrainLabelWithOptions(request, runtime);
        }

        public async Task<GetTrainLabelResponse> GetTrainLabelAsync(GetTrainLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrainLabelWithOptionsAsync(request, runtime);
        }

        public ListMarkerResponse ListMarkerWithOptions(ListMarkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMarkerResponse>(DoRPCRequest("ListMarker", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMarkerResponse> ListMarkerWithOptionsAsync(ListMarkerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMarkerResponse>(await DoRPCRequestAsync("ListMarker", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMarkerResponse ListMarker(ListMarkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMarkerWithOptions(request, runtime);
        }

        public async Task<ListMarkerResponse> ListMarkerAsync(ListMarkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMarkerWithOptionsAsync(request, runtime);
        }

        public CreateVideoComposeTaskResponse CreateVideoComposeTaskWithOptions(CreateVideoComposeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoComposeTaskResponse>(DoRPCRequest("CreateVideoComposeTask", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVideoComposeTaskResponse> CreateVideoComposeTaskWithOptionsAsync(CreateVideoComposeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoComposeTaskResponse>(await DoRPCRequestAsync("CreateVideoComposeTask", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDeviceForInstanceResponse DeleteDeviceForInstanceWithOptions(DeleteDeviceForInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDeviceForInstanceShrinkRequest request = new DeleteDeviceForInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Devices))
            {
                request.DevicesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Devices, "Devices", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeviceForInstanceResponse>(DoRPCRequest("DeleteDeviceForInstance", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDeviceForInstanceResponse> DeleteDeviceForInstanceWithOptionsAsync(DeleteDeviceForInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDeviceForInstanceShrinkRequest request = new DeleteDeviceForInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Devices))
            {
                request.DevicesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Devices, "Devices", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeviceForInstanceResponse>(await DoRPCRequestAsync("DeleteDeviceForInstance", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDeviceForInstanceResponse DeleteDeviceForInstance(DeleteDeviceForInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceForInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceForInstanceResponse> DeleteDeviceForInstanceAsync(DeleteDeviceForInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceForInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateUserGroupResponse UpdateUserGroupWithOptions(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(DoRPCRequest("UpdateUserGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUserGroupResponse> UpdateUserGroupWithOptionsAsync(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(await DoRPCRequestAsync("UpdateUserGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public BindPersonResponse BindPersonWithOptions(BindPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindPersonResponse>(DoRPCRequest("BindPerson", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindPersonResponse> BindPersonWithOptionsAsync(BindPersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindPersonResponse>(await DoRPCRequestAsync("BindPerson", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetBodyOptionsResponse GetBodyOptionsWithOptions(GetBodyOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBodyOptionsResponse>(DoRPCRequest("GetBodyOptions", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBodyOptionsResponse> GetBodyOptionsWithOptionsAsync(GetBodyOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBodyOptionsResponse>(await DoRPCRequestAsync("GetBodyOptions", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public BindCorpGroupResponse BindCorpGroupWithOptions(BindCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindCorpGroupResponse>(DoRPCRequest("BindCorpGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindCorpGroupResponse> BindCorpGroupWithOptionsAsync(BindCorpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindCorpGroupResponse>(await DoRPCRequestAsync("BindCorpGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListNVRChannelDeviceResponse ListNVRChannelDeviceWithOptions(ListNVRChannelDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNVRChannelDeviceResponse>(DoRPCRequest("ListNVRChannelDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNVRChannelDeviceResponse> ListNVRChannelDeviceWithOptionsAsync(ListNVRChannelDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNVRChannelDeviceResponse>(await DoRPCRequestAsync("ListNVRChannelDevice", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNVRChannelDeviceResponse ListNVRChannelDevice(ListNVRChannelDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNVRChannelDeviceWithOptions(request, runtime);
        }

        public async Task<ListNVRChannelDeviceResponse> ListNVRChannelDeviceAsync(ListNVRChannelDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNVRChannelDeviceWithOptionsAsync(request, runtime);
        }

        public AddProfileResponse AddProfileWithOptions(AddProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProfileResponse>(DoRPCRequest("AddProfile", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddProfileResponse> AddProfileWithOptionsAsync(AddProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProfileResponse>(await DoRPCRequestAsync("AddProfile", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteUserGroupResponse DeleteUserGroupWithOptions(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(DoRPCRequest("DeleteUserGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserGroupResponse> DeleteUserGroupWithOptionsAsync(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(await DoRPCRequestAsync("DeleteUserGroup", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListUserGroupsResponse ListUserGroupsWithOptions(ListUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserGroupsResponse>(DoRPCRequest("ListUserGroups", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserGroupsResponse> ListUserGroupsWithOptionsAsync(ListUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserGroupsResponse>(await DoRPCRequestAsync("ListUserGroups", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SearchBodyResponse SearchBodyWithOptions(SearchBodyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchBodyShrinkRequest request = new SearchBodyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptionList))
            {
                request.OptionListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptionList, "OptionList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchBodyResponse>(DoRPCRequest("SearchBody", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchBodyResponse> SearchBodyWithOptionsAsync(SearchBodyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchBodyShrinkRequest request = new SearchBodyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptionList))
            {
                request.OptionListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptionList, "OptionList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchBodyResponse>(await DoRPCRequestAsync("SearchBody", "2020-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

    }
}
