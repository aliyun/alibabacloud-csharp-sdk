// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Iovcc20180501.Models;

namespace AlibabaCloud.SDK.Iovcc20180501
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("iovcc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddUploadedFunctionFileInfoResponse AddUploadedFunctionFileInfoWithOptions(AddUploadedFunctionFileInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUploadedFunctionFileInfoResponse>(DoRPCRequest("AddUploadedFunctionFileInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddUploadedFunctionFileInfoResponse> AddUploadedFunctionFileInfoWithOptionsAsync(AddUploadedFunctionFileInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUploadedFunctionFileInfoResponse>(await DoRPCRequestAsync("AddUploadedFunctionFileInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddUploadedFunctionFileInfoResponse AddUploadedFunctionFileInfo(AddUploadedFunctionFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUploadedFunctionFileInfoWithOptions(request, runtime);
        }

        public async Task<AddUploadedFunctionFileInfoResponse> AddUploadedFunctionFileInfoAsync(AddUploadedFunctionFileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUploadedFunctionFileInfoWithOptionsAsync(request, runtime);
        }

        public AddVersionBlackDevicesResponse AddVersionBlackDevicesWithOptions(AddVersionBlackDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVersionBlackDevicesResponse>(DoRPCRequest("AddVersionBlackDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddVersionBlackDevicesResponse> AddVersionBlackDevicesWithOptionsAsync(AddVersionBlackDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVersionBlackDevicesResponse>(await DoRPCRequestAsync("AddVersionBlackDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddVersionBlackDevicesResponse AddVersionBlackDevices(AddVersionBlackDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVersionBlackDevicesWithOptions(request, runtime);
        }

        public async Task<AddVersionBlackDevicesResponse> AddVersionBlackDevicesAsync(AddVersionBlackDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVersionBlackDevicesWithOptionsAsync(request, runtime);
        }

        public AddVersionGroupDevicesResponse AddVersionGroupDevicesWithOptions(AddVersionGroupDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVersionGroupDevicesResponse>(DoRPCRequest("AddVersionGroupDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddVersionGroupDevicesResponse> AddVersionGroupDevicesWithOptionsAsync(AddVersionGroupDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVersionGroupDevicesResponse>(await DoRPCRequestAsync("AddVersionGroupDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddVersionGroupDevicesResponse AddVersionGroupDevices(AddVersionGroupDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVersionGroupDevicesWithOptions(request, runtime);
        }

        public async Task<AddVersionGroupDevicesResponse> AddVersionGroupDevicesAsync(AddVersionGroupDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVersionGroupDevicesWithOptionsAsync(request, runtime);
        }

        public AddVersionWhiteDevicesResponse AddVersionWhiteDevicesWithOptions(AddVersionWhiteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVersionWhiteDevicesResponse>(DoRPCRequest("AddVersionWhiteDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddVersionWhiteDevicesResponse> AddVersionWhiteDevicesWithOptionsAsync(AddVersionWhiteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVersionWhiteDevicesResponse>(await DoRPCRequestAsync("AddVersionWhiteDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddVersionWhiteDevicesResponse AddVersionWhiteDevices(AddVersionWhiteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVersionWhiteDevicesWithOptions(request, runtime);
        }

        public async Task<AddVersionWhiteDevicesResponse> AddVersionWhiteDevicesAsync(AddVersionWhiteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVersionWhiteDevicesWithOptionsAsync(request, runtime);
        }

        public AddVersionWhiteDevicesByDeviceGroupsResponse AddVersionWhiteDevicesByDeviceGroupsWithOptions(AddVersionWhiteDevicesByDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVersionWhiteDevicesByDeviceGroupsResponse>(DoRPCRequest("AddVersionWhiteDevicesByDeviceGroups", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddVersionWhiteDevicesByDeviceGroupsResponse> AddVersionWhiteDevicesByDeviceGroupsWithOptionsAsync(AddVersionWhiteDevicesByDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVersionWhiteDevicesByDeviceGroupsResponse>(await DoRPCRequestAsync("AddVersionWhiteDevicesByDeviceGroups", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddVersionWhiteDevicesByDeviceGroupsResponse AddVersionWhiteDevicesByDeviceGroups(AddVersionWhiteDevicesByDeviceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVersionWhiteDevicesByDeviceGroupsWithOptions(request, runtime);
        }

        public async Task<AddVersionWhiteDevicesByDeviceGroupsResponse> AddVersionWhiteDevicesByDeviceGroupsAsync(AddVersionWhiteDevicesByDeviceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVersionWhiteDevicesByDeviceGroupsWithOptionsAsync(request, runtime);
        }

        public ConnectAssistDeviceResponse ConnectAssistDeviceWithOptions(ConnectAssistDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConnectAssistDeviceResponse>(DoRPCRequest("ConnectAssistDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConnectAssistDeviceResponse> ConnectAssistDeviceWithOptionsAsync(ConnectAssistDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConnectAssistDeviceResponse>(await DoRPCRequestAsync("ConnectAssistDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConnectAssistDeviceResponse ConnectAssistDevice(ConnectAssistDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConnectAssistDeviceWithOptions(request, runtime);
        }

        public async Task<ConnectAssistDeviceResponse> ConnectAssistDeviceAsync(ConnectAssistDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConnectAssistDeviceWithOptionsAsync(request, runtime);
        }

        public CountActivatedOrNewRegistrationDeviceResponse CountActivatedOrNewRegistrationDeviceWithOptions(CountActivatedOrNewRegistrationDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CountActivatedOrNewRegistrationDeviceResponse>(DoRPCRequest("CountActivatedOrNewRegistrationDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CountActivatedOrNewRegistrationDeviceResponse> CountActivatedOrNewRegistrationDeviceWithOptionsAsync(CountActivatedOrNewRegistrationDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CountActivatedOrNewRegistrationDeviceResponse>(await DoRPCRequestAsync("CountActivatedOrNewRegistrationDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CountActivatedOrNewRegistrationDeviceResponse CountActivatedOrNewRegistrationDevice(CountActivatedOrNewRegistrationDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CountActivatedOrNewRegistrationDeviceWithOptions(request, runtime);
        }

        public async Task<CountActivatedOrNewRegistrationDeviceResponse> CountActivatedOrNewRegistrationDeviceAsync(CountActivatedOrNewRegistrationDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CountActivatedOrNewRegistrationDeviceWithOptionsAsync(request, runtime);
        }

        public CountDeviceBrandsResponse CountDeviceBrandsWithOptions(CountDeviceBrandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CountDeviceBrandsResponse>(DoRPCRequest("CountDeviceBrands", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CountDeviceBrandsResponse> CountDeviceBrandsWithOptionsAsync(CountDeviceBrandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CountDeviceBrandsResponse>(await DoRPCRequestAsync("CountDeviceBrands", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CountDeviceBrandsResponse CountDeviceBrands(CountDeviceBrandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CountDeviceBrandsWithOptions(request, runtime);
        }

        public async Task<CountDeviceBrandsResponse> CountDeviceBrandsAsync(CountDeviceBrandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CountDeviceBrandsWithOptionsAsync(request, runtime);
        }

        public CountDeviceModelsResponse CountDeviceModelsWithOptions(CountDeviceModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CountDeviceModelsResponse>(DoRPCRequest("CountDeviceModels", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CountDeviceModelsResponse> CountDeviceModelsWithOptionsAsync(CountDeviceModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CountDeviceModelsResponse>(await DoRPCRequestAsync("CountDeviceModels", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CountDeviceModelsResponse CountDeviceModels(CountDeviceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CountDeviceModelsWithOptions(request, runtime);
        }

        public async Task<CountDeviceModelsResponse> CountDeviceModelsAsync(CountDeviceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CountDeviceModelsWithOptionsAsync(request, runtime);
        }

        public CountDevicesResponse CountDevicesWithOptions(CountDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CountDevicesResponse>(DoRPCRequest("CountDevices", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CountDevicesResponse> CountDevicesWithOptionsAsync(CountDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CountDevicesResponse>(await DoRPCRequestAsync("CountDevices", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CountDevicesResponse CountDevices(CountDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CountDevicesWithOptions(request, runtime);
        }

        public async Task<CountDevicesResponse> CountDevicesAsync(CountDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CountDevicesWithOptionsAsync(request, runtime);
        }

        public CountProjectsResponse CountProjectsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<CountProjectsResponse>(DoRPCRequest("CountProjects", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CountProjectsResponse> CountProjectsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<CountProjectsResponse>(await DoRPCRequestAsync("CountProjects", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CountProjectsResponse CountProjects()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CountProjectsWithOptions(runtime);
        }

        public async Task<CountProjectsResponse> CountProjectsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CountProjectsWithOptionsAsync(runtime);
        }

        public CountYunIdInfoResponse CountYunIdInfoWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<CountYunIdInfoResponse>(DoRPCRequest("CountYunIdInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CountYunIdInfoResponse> CountYunIdInfoWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<CountYunIdInfoResponse>(await DoRPCRequestAsync("CountYunIdInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CountYunIdInfoResponse CountYunIdInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CountYunIdInfoWithOptions(runtime);
        }

        public async Task<CountYunIdInfoResponse> CountYunIdInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CountYunIdInfoWithOptionsAsync(runtime);
        }

        public CreateAppVersionResponse CreateAppVersionWithOptions(CreateAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppVersionResponse>(DoRPCRequest("CreateAppVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAppVersionResponse> CreateAppVersionWithOptionsAsync(CreateAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppVersionResponse>(await DoRPCRequestAsync("CreateAppVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAppVersionResponse CreateAppVersion(CreateAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppVersionWithOptions(request, runtime);
        }

        public async Task<CreateAppVersionResponse> CreateAppVersionAsync(CreateAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppVersionWithOptionsAsync(request, runtime);
        }

        public CreateCustomizedFilterResponse CreateCustomizedFilterWithOptions(CreateCustomizedFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomizedFilterResponse>(DoRPCRequest("CreateCustomizedFilter", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCustomizedFilterResponse> CreateCustomizedFilterWithOptionsAsync(CreateCustomizedFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomizedFilterResponse>(await DoRPCRequestAsync("CreateCustomizedFilter", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCustomizedFilterResponse CreateCustomizedFilter(CreateCustomizedFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomizedFilterWithOptions(request, runtime);
        }

        public async Task<CreateCustomizedFilterResponse> CreateCustomizedFilterAsync(CreateCustomizedFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomizedFilterWithOptionsAsync(request, runtime);
        }

        public CreateCustomizedPropertyResponse CreateCustomizedPropertyWithOptions(CreateCustomizedPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomizedPropertyResponse>(DoRPCRequest("CreateCustomizedProperty", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCustomizedPropertyResponse> CreateCustomizedPropertyWithOptionsAsync(CreateCustomizedPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomizedPropertyResponse>(await DoRPCRequestAsync("CreateCustomizedProperty", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCustomizedPropertyResponse CreateCustomizedProperty(CreateCustomizedPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomizedPropertyWithOptions(request, runtime);
        }

        public async Task<CreateCustomizedPropertyResponse> CreateCustomizedPropertyAsync(CreateCustomizedPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomizedPropertyWithOptionsAsync(request, runtime);
        }

        public CreateDeviceResponse CreateDeviceWithOptions(CreateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceResponse>(DoRPCRequest("CreateDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDeviceResponse> CreateDeviceWithOptionsAsync(CreateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceResponse>(await DoRPCRequestAsync("CreateDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateDeviceBrandResponse CreateDeviceBrandWithOptions(CreateDeviceBrandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceBrandResponse>(DoRPCRequest("CreateDeviceBrand", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDeviceBrandResponse> CreateDeviceBrandWithOptionsAsync(CreateDeviceBrandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceBrandResponse>(await DoRPCRequestAsync("CreateDeviceBrand", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDeviceBrandResponse CreateDeviceBrand(CreateDeviceBrandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceBrandWithOptions(request, runtime);
        }

        public async Task<CreateDeviceBrandResponse> CreateDeviceBrandAsync(CreateDeviceBrandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceBrandWithOptionsAsync(request, runtime);
        }

        public CreateDeviceModelResponse CreateDeviceModelWithOptions(CreateDeviceModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceModelResponse>(DoRPCRequest("CreateDeviceModel", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDeviceModelResponse> CreateDeviceModelWithOptionsAsync(CreateDeviceModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceModelResponse>(await DoRPCRequestAsync("CreateDeviceModel", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDeviceModelResponse CreateDeviceModel(CreateDeviceModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceModelWithOptions(request, runtime);
        }

        public async Task<CreateDeviceModelResponse> CreateDeviceModelAsync(CreateDeviceModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceModelWithOptionsAsync(request, runtime);
        }

        public CreateMqttRootTopicResponse CreateMqttRootTopicWithOptions(CreateMqttRootTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMqttRootTopicResponse>(DoRPCRequest("CreateMqttRootTopic", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMqttRootTopicResponse> CreateMqttRootTopicWithOptionsAsync(CreateMqttRootTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMqttRootTopicResponse>(await DoRPCRequestAsync("CreateMqttRootTopic", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMqttRootTopicResponse CreateMqttRootTopic(CreateMqttRootTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMqttRootTopicWithOptions(request, runtime);
        }

        public async Task<CreateMqttRootTopicResponse> CreateMqttRootTopicAsync(CreateMqttRootTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMqttRootTopicWithOptionsAsync(request, runtime);
        }

        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(DoRPCRequest("CreateNamespace", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await DoRPCRequestAsync("CreateNamespace", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNamespaceWithOptions(request, runtime);
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNamespaceWithOptionsAsync(request, runtime);
        }

        public CreateOsVersionResponse CreateOsVersionWithOptions(CreateOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOsVersionResponse>(DoRPCRequest("CreateOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOsVersionResponse> CreateOsVersionWithOptionsAsync(CreateOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOsVersionResponse>(await DoRPCRequestAsync("CreateOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateOsVersionResponse CreateOsVersion(CreateOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOsVersionWithOptions(request, runtime);
        }

        public async Task<CreateOsVersionResponse> CreateOsVersionAsync(CreateOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOsVersionWithOptionsAsync(request, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(DoRPCRequest("CreateProject", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(await DoRPCRequestAsync("CreateProject", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        public CreateProjectAppResponse CreateProjectAppWithOptions(CreateProjectAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectAppResponse>(DoRPCRequest("CreateProjectApp", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectAppResponse> CreateProjectAppWithOptionsAsync(CreateProjectAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectAppResponse>(await DoRPCRequestAsync("CreateProjectApp", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProjectAppResponse CreateProjectApp(CreateProjectAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectAppWithOptions(request, runtime);
        }

        public async Task<CreateProjectAppResponse> CreateProjectAppAsync(CreateProjectAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectAppWithOptionsAsync(request, runtime);
        }

        public CreateRpcServiceResponse CreateRpcServiceWithOptions(CreateRpcServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRpcServiceResponse>(DoRPCRequest("CreateRpcService", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRpcServiceResponse> CreateRpcServiceWithOptionsAsync(CreateRpcServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRpcServiceResponse>(await DoRPCRequestAsync("CreateRpcService", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRpcServiceResponse CreateRpcService(CreateRpcServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRpcServiceWithOptions(request, runtime);
        }

        public async Task<CreateRpcServiceResponse> CreateRpcServiceAsync(CreateRpcServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRpcServiceWithOptionsAsync(request, runtime);
        }

        public CreateSchemaSubscribeResponse CreateSchemaSubscribeWithOptions(CreateSchemaSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSchemaSubscribeResponse>(DoRPCRequest("CreateSchemaSubscribe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSchemaSubscribeResponse> CreateSchemaSubscribeWithOptionsAsync(CreateSchemaSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSchemaSubscribeResponse>(await DoRPCRequestAsync("CreateSchemaSubscribe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSchemaSubscribeResponse CreateSchemaSubscribe(CreateSchemaSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSchemaSubscribeWithOptions(request, runtime);
        }

        public async Task<CreateSchemaSubscribeResponse> CreateSchemaSubscribeAsync(CreateSchemaSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSchemaSubscribeWithOptionsAsync(request, runtime);
        }

        public CreateShadowSchemaResponse CreateShadowSchemaWithOptions(CreateShadowSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateShadowSchemaResponse>(DoRPCRequest("CreateShadowSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateShadowSchemaResponse> CreateShadowSchemaWithOptionsAsync(CreateShadowSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateShadowSchemaResponse>(await DoRPCRequestAsync("CreateShadowSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateShadowSchemaResponse CreateShadowSchema(CreateShadowSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateShadowSchemaWithOptions(request, runtime);
        }

        public async Task<CreateShadowSchemaResponse> CreateShadowSchemaAsync(CreateShadowSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateShadowSchemaWithOptionsAsync(request, runtime);
        }

        public CreateTriggerResponse CreateTriggerWithOptions(CreateTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTriggerResponse>(DoRPCRequest("CreateTrigger", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTriggerResponse> CreateTriggerWithOptionsAsync(CreateTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTriggerResponse>(await DoRPCRequestAsync("CreateTrigger", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTriggerWithOptions(request, runtime);
        }

        public async Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTriggerWithOptionsAsync(request, runtime);
        }

        public CreateUpstreamAppKeyRelationResponse CreateUpstreamAppKeyRelationWithOptions(CreateUpstreamAppKeyRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUpstreamAppKeyRelationResponse>(DoRPCRequest("CreateUpstreamAppKeyRelation", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUpstreamAppKeyRelationResponse> CreateUpstreamAppKeyRelationWithOptionsAsync(CreateUpstreamAppKeyRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUpstreamAppKeyRelationResponse>(await DoRPCRequestAsync("CreateUpstreamAppKeyRelation", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUpstreamAppKeyRelationResponse CreateUpstreamAppKeyRelation(CreateUpstreamAppKeyRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUpstreamAppKeyRelationWithOptions(request, runtime);
        }

        public async Task<CreateUpstreamAppKeyRelationResponse> CreateUpstreamAppKeyRelationAsync(CreateUpstreamAppKeyRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUpstreamAppKeyRelationWithOptionsAsync(request, runtime);
        }

        public CreateUpstreamAppKeyRelationsResponse CreateUpstreamAppKeyRelationsWithOptions(CreateUpstreamAppKeyRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUpstreamAppKeyRelationsResponse>(DoRPCRequest("CreateUpstreamAppKeyRelations", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUpstreamAppKeyRelationsResponse> CreateUpstreamAppKeyRelationsWithOptionsAsync(CreateUpstreamAppKeyRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUpstreamAppKeyRelationsResponse>(await DoRPCRequestAsync("CreateUpstreamAppKeyRelations", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUpstreamAppKeyRelationsResponse CreateUpstreamAppKeyRelations(CreateUpstreamAppKeyRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUpstreamAppKeyRelationsWithOptions(request, runtime);
        }

        public async Task<CreateUpstreamAppKeyRelationsResponse> CreateUpstreamAppKeyRelationsAsync(CreateUpstreamAppKeyRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUpstreamAppKeyRelationsWithOptionsAsync(request, runtime);
        }

        public CreateUpstreamAppServerResponse CreateUpstreamAppServerWithOptions(CreateUpstreamAppServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUpstreamAppServerResponse>(DoRPCRequest("CreateUpstreamAppServer", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUpstreamAppServerResponse> CreateUpstreamAppServerWithOptionsAsync(CreateUpstreamAppServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUpstreamAppServerResponse>(await DoRPCRequestAsync("CreateUpstreamAppServer", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUpstreamAppServerResponse CreateUpstreamAppServer(CreateUpstreamAppServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUpstreamAppServerWithOptions(request, runtime);
        }

        public async Task<CreateUpstreamAppServerResponse> CreateUpstreamAppServerAsync(CreateUpstreamAppServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUpstreamAppServerWithOptionsAsync(request, runtime);
        }

        public CreateVersionDeviceGroupResponse CreateVersionDeviceGroupWithOptions(CreateVersionDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVersionDeviceGroupResponse>(DoRPCRequest("CreateVersionDeviceGroup", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVersionDeviceGroupResponse> CreateVersionDeviceGroupWithOptionsAsync(CreateVersionDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVersionDeviceGroupResponse>(await DoRPCRequestAsync("CreateVersionDeviceGroup", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVersionDeviceGroupResponse CreateVersionDeviceGroup(CreateVersionDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVersionDeviceGroupWithOptions(request, runtime);
        }

        public async Task<CreateVersionDeviceGroupResponse> CreateVersionDeviceGroupAsync(CreateVersionDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVersionDeviceGroupWithOptionsAsync(request, runtime);
        }

        public CreateVersionPrepublishResponse CreateVersionPrepublishWithOptions(CreateVersionPrepublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVersionPrepublishResponse>(DoRPCRequest("CreateVersionPrepublish", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVersionPrepublishResponse> CreateVersionPrepublishWithOptionsAsync(CreateVersionPrepublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVersionPrepublishResponse>(await DoRPCRequestAsync("CreateVersionPrepublish", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVersionPrepublishResponse CreateVersionPrepublish(CreateVersionPrepublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVersionPrepublishWithOptions(request, runtime);
        }

        public async Task<CreateVersionPrepublishResponse> CreateVersionPrepublishAsync(CreateVersionPrepublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVersionPrepublishWithOptionsAsync(request, runtime);
        }

        public CreateVersionTestResponse CreateVersionTestWithOptions(CreateVersionTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVersionTestResponse>(DoRPCRequest("CreateVersionTest", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVersionTestResponse> CreateVersionTestWithOptionsAsync(CreateVersionTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVersionTestResponse>(await DoRPCRequestAsync("CreateVersionTest", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVersionTestResponse CreateVersionTest(CreateVersionTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVersionTestWithOptions(request, runtime);
        }

        public async Task<CreateVersionTestResponse> CreateVersionTestAsync(CreateVersionTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVersionTestWithOptionsAsync(request, runtime);
        }

        public DelayPublishOsVersionResponse DelayPublishOsVersionWithOptions(DelayPublishOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DelayPublishOsVersionResponse>(DoRPCRequest("DelayPublishOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DelayPublishOsVersionResponse> DelayPublishOsVersionWithOptionsAsync(DelayPublishOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DelayPublishOsVersionResponse>(await DoRPCRequestAsync("DelayPublishOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DelayPublishOsVersionResponse DelayPublishOsVersion(DelayPublishOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DelayPublishOsVersionWithOptions(request, runtime);
        }

        public async Task<DelayPublishOsVersionResponse> DelayPublishOsVersionAsync(DelayPublishOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DelayPublishOsVersionWithOptionsAsync(request, runtime);
        }

        public DeleteAllCustomizedFiltersResponse DeleteAllCustomizedFiltersWithOptions(DeleteAllCustomizedFiltersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAllCustomizedFiltersResponse>(DoRPCRequest("DeleteAllCustomizedFilters", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAllCustomizedFiltersResponse> DeleteAllCustomizedFiltersWithOptionsAsync(DeleteAllCustomizedFiltersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAllCustomizedFiltersResponse>(await DoRPCRequestAsync("DeleteAllCustomizedFilters", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAllCustomizedFiltersResponse DeleteAllCustomizedFilters(DeleteAllCustomizedFiltersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAllCustomizedFiltersWithOptions(request, runtime);
        }

        public async Task<DeleteAllCustomizedFiltersResponse> DeleteAllCustomizedFiltersAsync(DeleteAllCustomizedFiltersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAllCustomizedFiltersWithOptionsAsync(request, runtime);
        }

        public DeleteAllVersionGroupDevicesResponse DeleteAllVersionGroupDevicesWithOptions(DeleteAllVersionGroupDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAllVersionGroupDevicesResponse>(DoRPCRequest("DeleteAllVersionGroupDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAllVersionGroupDevicesResponse> DeleteAllVersionGroupDevicesWithOptionsAsync(DeleteAllVersionGroupDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAllVersionGroupDevicesResponse>(await DoRPCRequestAsync("DeleteAllVersionGroupDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAllVersionGroupDevicesResponse DeleteAllVersionGroupDevices(DeleteAllVersionGroupDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAllVersionGroupDevicesWithOptions(request, runtime);
        }

        public async Task<DeleteAllVersionGroupDevicesResponse> DeleteAllVersionGroupDevicesAsync(DeleteAllVersionGroupDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAllVersionGroupDevicesWithOptionsAsync(request, runtime);
        }

        public DeleteCustomizedFilterResponse DeleteCustomizedFilterWithOptions(DeleteCustomizedFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomizedFilterResponse>(DoRPCRequest("DeleteCustomizedFilter", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCustomizedFilterResponse> DeleteCustomizedFilterWithOptionsAsync(DeleteCustomizedFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomizedFilterResponse>(await DoRPCRequestAsync("DeleteCustomizedFilter", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCustomizedFilterResponse DeleteCustomizedFilter(DeleteCustomizedFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomizedFilterWithOptions(request, runtime);
        }

        public async Task<DeleteCustomizedFilterResponse> DeleteCustomizedFilterAsync(DeleteCustomizedFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomizedFilterWithOptionsAsync(request, runtime);
        }

        public DeleteCustomizedPropertyResponse DeleteCustomizedPropertyWithOptions(DeleteCustomizedPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomizedPropertyResponse>(DoRPCRequest("DeleteCustomizedProperty", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCustomizedPropertyResponse> DeleteCustomizedPropertyWithOptionsAsync(DeleteCustomizedPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomizedPropertyResponse>(await DoRPCRequestAsync("DeleteCustomizedProperty", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCustomizedPropertyResponse DeleteCustomizedProperty(DeleteCustomizedPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomizedPropertyWithOptions(request, runtime);
        }

        public async Task<DeleteCustomizedPropertyResponse> DeleteCustomizedPropertyAsync(DeleteCustomizedPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomizedPropertyWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceResponse DeleteDeviceWithOptions(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeviceResponse>(DoRPCRequest("DeleteDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceWithOptionsAsync(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeviceResponse>(await DoRPCRequestAsync("DeleteDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteFunctionFileResponse DeleteFunctionFileWithOptions(DeleteFunctionFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFunctionFileResponse>(DoRPCRequest("DeleteFunctionFile", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFunctionFileResponse> DeleteFunctionFileWithOptionsAsync(DeleteFunctionFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFunctionFileResponse>(await DoRPCRequestAsync("DeleteFunctionFile", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFunctionFileResponse DeleteFunctionFile(DeleteFunctionFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFunctionFileWithOptions(request, runtime);
        }

        public async Task<DeleteFunctionFileResponse> DeleteFunctionFileAsync(DeleteFunctionFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFunctionFileWithOptionsAsync(request, runtime);
        }

        public DeleteMqttRootTopicResponse DeleteMqttRootTopicWithOptions(DeleteMqttRootTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMqttRootTopicResponse>(DoRPCRequest("DeleteMqttRootTopic", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMqttRootTopicResponse> DeleteMqttRootTopicWithOptionsAsync(DeleteMqttRootTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMqttRootTopicResponse>(await DoRPCRequestAsync("DeleteMqttRootTopic", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMqttRootTopicResponse DeleteMqttRootTopic(DeleteMqttRootTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMqttRootTopicWithOptions(request, runtime);
        }

        public async Task<DeleteMqttRootTopicResponse> DeleteMqttRootTopicAsync(DeleteMqttRootTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMqttRootTopicWithOptionsAsync(request, runtime);
        }

        public DeleteNamespaceResponse DeleteNamespaceWithOptions(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(DoRPCRequest("DeleteNamespace", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await DoRPCRequestAsync("DeleteNamespace", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNamespaceWithOptions(request, runtime);
        }

        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNamespaceWithOptionsAsync(request, runtime);
        }

        public DeleteOpenAccountResponse DeleteOpenAccountWithOptions(DeleteOpenAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteOpenAccountResponse>(DoRPCRequest("DeleteOpenAccount", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteOpenAccountResponse> DeleteOpenAccountWithOptionsAsync(DeleteOpenAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteOpenAccountResponse>(await DoRPCRequestAsync("DeleteOpenAccount", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteOpenAccountResponse DeleteOpenAccount(DeleteOpenAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOpenAccountWithOptions(request, runtime);
        }

        public async Task<DeleteOpenAccountResponse> DeleteOpenAccountAsync(DeleteOpenAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOpenAccountWithOptionsAsync(request, runtime);
        }

        public DeleteProjectAppResponse DeleteProjectAppWithOptions(DeleteProjectAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectAppResponse>(DoRPCRequest("DeleteProjectApp", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectAppResponse> DeleteProjectAppWithOptionsAsync(DeleteProjectAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectAppResponse>(await DoRPCRequestAsync("DeleteProjectApp", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProjectAppResponse DeleteProjectApp(DeleteProjectAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectAppWithOptions(request, runtime);
        }

        public async Task<DeleteProjectAppResponse> DeleteProjectAppAsync(DeleteProjectAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectAppWithOptionsAsync(request, runtime);
        }

        public DeleteRpcServiceResponse DeleteRpcServiceWithOptions(DeleteRpcServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRpcServiceResponse>(DoRPCRequest("DeleteRpcService", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRpcServiceResponse> DeleteRpcServiceWithOptionsAsync(DeleteRpcServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRpcServiceResponse>(await DoRPCRequestAsync("DeleteRpcService", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRpcServiceResponse DeleteRpcService(DeleteRpcServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRpcServiceWithOptions(request, runtime);
        }

        public async Task<DeleteRpcServiceResponse> DeleteRpcServiceAsync(DeleteRpcServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRpcServiceWithOptionsAsync(request, runtime);
        }

        public DeleteSchemaSubscribeResponse DeleteSchemaSubscribeWithOptions(DeleteSchemaSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSchemaSubscribeResponse>(DoRPCRequest("DeleteSchemaSubscribe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSchemaSubscribeResponse> DeleteSchemaSubscribeWithOptionsAsync(DeleteSchemaSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSchemaSubscribeResponse>(await DoRPCRequestAsync("DeleteSchemaSubscribe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSchemaSubscribeResponse DeleteSchemaSubscribe(DeleteSchemaSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSchemaSubscribeWithOptions(request, runtime);
        }

        public async Task<DeleteSchemaSubscribeResponse> DeleteSchemaSubscribeAsync(DeleteSchemaSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSchemaSubscribeWithOptionsAsync(request, runtime);
        }

        public DeleteShadowSchemaResponse DeleteShadowSchemaWithOptions(DeleteShadowSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteShadowSchemaResponse>(DoRPCRequest("DeleteShadowSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteShadowSchemaResponse> DeleteShadowSchemaWithOptionsAsync(DeleteShadowSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteShadowSchemaResponse>(await DoRPCRequestAsync("DeleteShadowSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteShadowSchemaResponse DeleteShadowSchema(DeleteShadowSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteShadowSchemaWithOptions(request, runtime);
        }

        public async Task<DeleteShadowSchemaResponse> DeleteShadowSchemaAsync(DeleteShadowSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteShadowSchemaWithOptionsAsync(request, runtime);
        }

        public DeleteTriggerResponse DeleteTriggerWithOptions(DeleteTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(DoRPCRequest("DeleteTrigger", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerWithOptionsAsync(DeleteTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(await DoRPCRequestAsync("DeleteTrigger", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTriggerWithOptions(request, runtime);
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTriggerWithOptionsAsync(request, runtime);
        }

        public DeleteUpstreamAppKeyRelationResponse DeleteUpstreamAppKeyRelationWithOptions(DeleteUpstreamAppKeyRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUpstreamAppKeyRelationResponse>(DoRPCRequest("DeleteUpstreamAppKeyRelation", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUpstreamAppKeyRelationResponse> DeleteUpstreamAppKeyRelationWithOptionsAsync(DeleteUpstreamAppKeyRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUpstreamAppKeyRelationResponse>(await DoRPCRequestAsync("DeleteUpstreamAppKeyRelation", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUpstreamAppKeyRelationResponse DeleteUpstreamAppKeyRelation(DeleteUpstreamAppKeyRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUpstreamAppKeyRelationWithOptions(request, runtime);
        }

        public async Task<DeleteUpstreamAppKeyRelationResponse> DeleteUpstreamAppKeyRelationAsync(DeleteUpstreamAppKeyRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUpstreamAppKeyRelationWithOptionsAsync(request, runtime);
        }

        public DeleteUpstreamAppServerResponse DeleteUpstreamAppServerWithOptions(DeleteUpstreamAppServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUpstreamAppServerResponse>(DoRPCRequest("DeleteUpstreamAppServer", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUpstreamAppServerResponse> DeleteUpstreamAppServerWithOptionsAsync(DeleteUpstreamAppServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUpstreamAppServerResponse>(await DoRPCRequestAsync("DeleteUpstreamAppServer", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUpstreamAppServerResponse DeleteUpstreamAppServer(DeleteUpstreamAppServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUpstreamAppServerWithOptions(request, runtime);
        }

        public async Task<DeleteUpstreamAppServerResponse> DeleteUpstreamAppServerAsync(DeleteUpstreamAppServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUpstreamAppServerWithOptionsAsync(request, runtime);
        }

        public DeleteVersionAllBlackDevicesResponse DeleteVersionAllBlackDevicesWithOptions(DeleteVersionAllBlackDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionAllBlackDevicesResponse>(DoRPCRequest("DeleteVersionAllBlackDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionAllBlackDevicesResponse> DeleteVersionAllBlackDevicesWithOptionsAsync(DeleteVersionAllBlackDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionAllBlackDevicesResponse>(await DoRPCRequestAsync("DeleteVersionAllBlackDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionAllBlackDevicesResponse DeleteVersionAllBlackDevices(DeleteVersionAllBlackDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionAllBlackDevicesWithOptions(request, runtime);
        }

        public async Task<DeleteVersionAllBlackDevicesResponse> DeleteVersionAllBlackDevicesAsync(DeleteVersionAllBlackDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionAllBlackDevicesWithOptionsAsync(request, runtime);
        }

        public DeleteVersionAllWhiteDevicesResponse DeleteVersionAllWhiteDevicesWithOptions(DeleteVersionAllWhiteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionAllWhiteDevicesResponse>(DoRPCRequest("DeleteVersionAllWhiteDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionAllWhiteDevicesResponse> DeleteVersionAllWhiteDevicesWithOptionsAsync(DeleteVersionAllWhiteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionAllWhiteDevicesResponse>(await DoRPCRequestAsync("DeleteVersionAllWhiteDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionAllWhiteDevicesResponse DeleteVersionAllWhiteDevices(DeleteVersionAllWhiteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionAllWhiteDevicesWithOptions(request, runtime);
        }

        public async Task<DeleteVersionAllWhiteDevicesResponse> DeleteVersionAllWhiteDevicesAsync(DeleteVersionAllWhiteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionAllWhiteDevicesWithOptionsAsync(request, runtime);
        }

        public DeleteVersionBlackDevicesResponse DeleteVersionBlackDevicesWithOptions(DeleteVersionBlackDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionBlackDevicesResponse>(DoRPCRequest("DeleteVersionBlackDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionBlackDevicesResponse> DeleteVersionBlackDevicesWithOptionsAsync(DeleteVersionBlackDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionBlackDevicesResponse>(await DoRPCRequestAsync("DeleteVersionBlackDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionBlackDevicesResponse DeleteVersionBlackDevices(DeleteVersionBlackDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionBlackDevicesWithOptions(request, runtime);
        }

        public async Task<DeleteVersionBlackDevicesResponse> DeleteVersionBlackDevicesAsync(DeleteVersionBlackDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionBlackDevicesWithOptionsAsync(request, runtime);
        }

        public DeleteVersionBlackDevicesByIdResponse DeleteVersionBlackDevicesByIdWithOptions(DeleteVersionBlackDevicesByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionBlackDevicesByIdResponse>(DoRPCRequest("DeleteVersionBlackDevicesById", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionBlackDevicesByIdResponse> DeleteVersionBlackDevicesByIdWithOptionsAsync(DeleteVersionBlackDevicesByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionBlackDevicesByIdResponse>(await DoRPCRequestAsync("DeleteVersionBlackDevicesById", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionBlackDevicesByIdResponse DeleteVersionBlackDevicesById(DeleteVersionBlackDevicesByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionBlackDevicesByIdWithOptions(request, runtime);
        }

        public async Task<DeleteVersionBlackDevicesByIdResponse> DeleteVersionBlackDevicesByIdAsync(DeleteVersionBlackDevicesByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionBlackDevicesByIdWithOptionsAsync(request, runtime);
        }

        public DeleteVersionDeviceGroupResponse DeleteVersionDeviceGroupWithOptions(DeleteVersionDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionDeviceGroupResponse>(DoRPCRequest("DeleteVersionDeviceGroup", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionDeviceGroupResponse> DeleteVersionDeviceGroupWithOptionsAsync(DeleteVersionDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionDeviceGroupResponse>(await DoRPCRequestAsync("DeleteVersionDeviceGroup", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionDeviceGroupResponse DeleteVersionDeviceGroup(DeleteVersionDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionDeviceGroupWithOptions(request, runtime);
        }

        public async Task<DeleteVersionDeviceGroupResponse> DeleteVersionDeviceGroupAsync(DeleteVersionDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionDeviceGroupWithOptionsAsync(request, runtime);
        }

        public DeleteVersionGroupDeviceResponse DeleteVersionGroupDeviceWithOptions(DeleteVersionGroupDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionGroupDeviceResponse>(DoRPCRequest("DeleteVersionGroupDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionGroupDeviceResponse> DeleteVersionGroupDeviceWithOptionsAsync(DeleteVersionGroupDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionGroupDeviceResponse>(await DoRPCRequestAsync("DeleteVersionGroupDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionGroupDeviceResponse DeleteVersionGroupDevice(DeleteVersionGroupDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionGroupDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteVersionGroupDeviceResponse> DeleteVersionGroupDeviceAsync(DeleteVersionGroupDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionGroupDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteVersionGroupDeviceByIdResponse DeleteVersionGroupDeviceByIdWithOptions(DeleteVersionGroupDeviceByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionGroupDeviceByIdResponse>(DoRPCRequest("DeleteVersionGroupDeviceById", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionGroupDeviceByIdResponse> DeleteVersionGroupDeviceByIdWithOptionsAsync(DeleteVersionGroupDeviceByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionGroupDeviceByIdResponse>(await DoRPCRequestAsync("DeleteVersionGroupDeviceById", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionGroupDeviceByIdResponse DeleteVersionGroupDeviceById(DeleteVersionGroupDeviceByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionGroupDeviceByIdWithOptions(request, runtime);
        }

        public async Task<DeleteVersionGroupDeviceByIdResponse> DeleteVersionGroupDeviceByIdAsync(DeleteVersionGroupDeviceByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionGroupDeviceByIdWithOptionsAsync(request, runtime);
        }

        public DeleteVersionTestResponse DeleteVersionTestWithOptions(DeleteVersionTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionTestResponse>(DoRPCRequest("DeleteVersionTest", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionTestResponse> DeleteVersionTestWithOptionsAsync(DeleteVersionTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionTestResponse>(await DoRPCRequestAsync("DeleteVersionTest", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionTestResponse DeleteVersionTest(DeleteVersionTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionTestWithOptions(request, runtime);
        }

        public async Task<DeleteVersionTestResponse> DeleteVersionTestAsync(DeleteVersionTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionTestWithOptionsAsync(request, runtime);
        }

        public DeleteVersionWhiteDevicesResponse DeleteVersionWhiteDevicesWithOptions(DeleteVersionWhiteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionWhiteDevicesResponse>(DoRPCRequest("DeleteVersionWhiteDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionWhiteDevicesResponse> DeleteVersionWhiteDevicesWithOptionsAsync(DeleteVersionWhiteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionWhiteDevicesResponse>(await DoRPCRequestAsync("DeleteVersionWhiteDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionWhiteDevicesResponse DeleteVersionWhiteDevices(DeleteVersionWhiteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionWhiteDevicesWithOptions(request, runtime);
        }

        public async Task<DeleteVersionWhiteDevicesResponse> DeleteVersionWhiteDevicesAsync(DeleteVersionWhiteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionWhiteDevicesWithOptionsAsync(request, runtime);
        }

        public DeleteVersionWhiteDevicesByIdResponse DeleteVersionWhiteDevicesByIdWithOptions(DeleteVersionWhiteDevicesByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionWhiteDevicesByIdResponse>(DoRPCRequest("DeleteVersionWhiteDevicesById", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVersionWhiteDevicesByIdResponse> DeleteVersionWhiteDevicesByIdWithOptionsAsync(DeleteVersionWhiteDevicesByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVersionWhiteDevicesByIdResponse>(await DoRPCRequestAsync("DeleteVersionWhiteDevicesById", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVersionWhiteDevicesByIdResponse DeleteVersionWhiteDevicesById(DeleteVersionWhiteDevicesByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVersionWhiteDevicesByIdWithOptions(request, runtime);
        }

        public async Task<DeleteVersionWhiteDevicesByIdResponse> DeleteVersionWhiteDevicesByIdAsync(DeleteVersionWhiteDevicesByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVersionWhiteDevicesByIdWithOptionsAsync(request, runtime);
        }

        public DeployFunctionFileResponse DeployFunctionFileWithOptions(DeployFunctionFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployFunctionFileResponse>(DoRPCRequest("DeployFunctionFile", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployFunctionFileResponse> DeployFunctionFileWithOptionsAsync(DeployFunctionFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployFunctionFileResponse>(await DoRPCRequestAsync("DeployFunctionFile", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployFunctionFileResponse DeployFunctionFile(DeployFunctionFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployFunctionFileWithOptions(request, runtime);
        }

        public async Task<DeployFunctionFileResponse> DeployFunctionFileAsync(DeployFunctionFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployFunctionFileWithOptionsAsync(request, runtime);
        }

        public DescribeApiGatewayAppSecurityResponse DescribeApiGatewayAppSecurityWithOptions(DescribeApiGatewayAppSecurityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiGatewayAppSecurityResponse>(DoRPCRequest("DescribeApiGatewayAppSecurity", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiGatewayAppSecurityResponse> DescribeApiGatewayAppSecurityWithOptionsAsync(DescribeApiGatewayAppSecurityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiGatewayAppSecurityResponse>(await DoRPCRequestAsync("DescribeApiGatewayAppSecurity", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiGatewayAppSecurityResponse DescribeApiGatewayAppSecurity(DescribeApiGatewayAppSecurityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiGatewayAppSecurityWithOptions(request, runtime);
        }

        public async Task<DescribeApiGatewayAppSecurityResponse> DescribeApiGatewayAppSecurityAsync(DescribeApiGatewayAppSecurityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiGatewayAppSecurityWithOptionsAsync(request, runtime);
        }

        public DescribeAppVersionResponse DescribeAppVersionWithOptions(DescribeAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppVersionResponse>(DoRPCRequest("DescribeAppVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppVersionResponse> DescribeAppVersionWithOptionsAsync(DescribeAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppVersionResponse>(await DoRPCRequestAsync("DescribeAppVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppVersionResponse DescribeAppVersion(DescribeAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppVersionWithOptions(request, runtime);
        }

        public async Task<DescribeAppVersionResponse> DescribeAppVersionAsync(DescribeAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppVersionWithOptionsAsync(request, runtime);
        }

        public DescribeAssistReportResponse DescribeAssistReportWithOptions(DescribeAssistReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAssistReportResponse>(DoRPCRequest("DescribeAssistReport", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeAssistReportResponse> DescribeAssistReportWithOptionsAsync(DescribeAssistReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAssistReportResponse>(await DoRPCRequestAsync("DescribeAssistReport", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeAssistReportResponse DescribeAssistReport(DescribeAssistReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssistReportWithOptions(request, runtime);
        }

        public async Task<DescribeAssistReportResponse> DescribeAssistReportAsync(DescribeAssistReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssistReportWithOptionsAsync(request, runtime);
        }

        public DescribeAssistRTMPServerAddressResponse DescribeAssistRTMPServerAddressWithOptions(DescribeAssistRTMPServerAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAssistRTMPServerAddressResponse>(DoRPCRequest("DescribeAssistRTMPServerAddress", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeAssistRTMPServerAddressResponse> DescribeAssistRTMPServerAddressWithOptionsAsync(DescribeAssistRTMPServerAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAssistRTMPServerAddressResponse>(await DoRPCRequestAsync("DescribeAssistRTMPServerAddress", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeAssistRTMPServerAddressResponse DescribeAssistRTMPServerAddress(DescribeAssistRTMPServerAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssistRTMPServerAddressWithOptions(request, runtime);
        }

        public async Task<DescribeAssistRTMPServerAddressResponse> DescribeAssistRTMPServerAddressAsync(DescribeAssistRTMPServerAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssistRTMPServerAddressWithOptionsAsync(request, runtime);
        }

        public DescribeAssistWSServerAddressResponse DescribeAssistWSServerAddressWithOptions(DescribeAssistWSServerAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAssistWSServerAddressResponse>(DoRPCRequest("DescribeAssistWSServerAddress", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeAssistWSServerAddressResponse> DescribeAssistWSServerAddressWithOptionsAsync(DescribeAssistWSServerAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAssistWSServerAddressResponse>(await DoRPCRequestAsync("DescribeAssistWSServerAddress", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeAssistWSServerAddressResponse DescribeAssistWSServerAddress(DescribeAssistWSServerAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssistWSServerAddressWithOptions(request, runtime);
        }

        public async Task<DescribeAssistWSServerAddressResponse> DescribeAssistWSServerAddressAsync(DescribeAssistWSServerAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssistWSServerAddressWithOptionsAsync(request, runtime);
        }

        public DescribeCustomizedFilterResponse DescribeCustomizedFilterWithOptions(DescribeCustomizedFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomizedFilterResponse>(DoRPCRequest("DescribeCustomizedFilter", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomizedFilterResponse> DescribeCustomizedFilterWithOptionsAsync(DescribeCustomizedFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomizedFilterResponse>(await DoRPCRequestAsync("DescribeCustomizedFilter", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomizedFilterResponse DescribeCustomizedFilter(DescribeCustomizedFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomizedFilterWithOptions(request, runtime);
        }

        public async Task<DescribeCustomizedFilterResponse> DescribeCustomizedFilterAsync(DescribeCustomizedFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomizedFilterWithOptionsAsync(request, runtime);
        }

        public DescribeDefaultSchemaResponse DescribeDefaultSchemaWithOptions(DescribeDefaultSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDefaultSchemaResponse>(DoRPCRequest("DescribeDefaultSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDefaultSchemaResponse> DescribeDefaultSchemaWithOptionsAsync(DescribeDefaultSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDefaultSchemaResponse>(await DoRPCRequestAsync("DescribeDefaultSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDefaultSchemaResponse DescribeDefaultSchema(DescribeDefaultSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefaultSchemaWithOptions(request, runtime);
        }

        public async Task<DescribeDefaultSchemaResponse> DescribeDefaultSchemaAsync(DescribeDefaultSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefaultSchemaWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceResponse DescribeDeviceWithOptions(DescribeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceResponse>(DoRPCRequest("DescribeDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceResponse> DescribeDeviceWithOptionsAsync(DescribeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceResponse>(await DoRPCRequestAsync("DescribeDevice", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceBrandResponse DescribeDeviceBrandWithOptions(DescribeDeviceBrandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeviceBrandResponse>(DoRPCRequest("DescribeDeviceBrand", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceBrandResponse> DescribeDeviceBrandWithOptionsAsync(DescribeDeviceBrandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeviceBrandResponse>(await DoRPCRequestAsync("DescribeDeviceBrand", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDeviceBrandResponse DescribeDeviceBrand(DescribeDeviceBrandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceBrandWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceBrandResponse> DescribeDeviceBrandAsync(DescribeDeviceBrandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceBrandWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceIdByOuterInfoResponse DescribeDeviceIdByOuterInfoWithOptions(DescribeDeviceIdByOuterInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeviceIdByOuterInfoResponse>(DoRPCRequest("DescribeDeviceIdByOuterInfo", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceIdByOuterInfoResponse> DescribeDeviceIdByOuterInfoWithOptionsAsync(DescribeDeviceIdByOuterInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeviceIdByOuterInfoResponse>(await DoRPCRequestAsync("DescribeDeviceIdByOuterInfo", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDeviceIdByOuterInfoResponse DescribeDeviceIdByOuterInfo(DescribeDeviceIdByOuterInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceIdByOuterInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceIdByOuterInfoResponse> DescribeDeviceIdByOuterInfoAsync(DescribeDeviceIdByOuterInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceIdByOuterInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceInfoResponse DescribeDeviceInfoWithOptions(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(DoRPCRequest("DescribeDeviceInfo", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoWithOptionsAsync(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(await DoRPCRequestAsync("DescribeDeviceInfo", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDeviceInfoResponse DescribeDeviceInfo(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoAsync(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceModelResponse DescribeDeviceModelWithOptions(DescribeDeviceModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeviceModelResponse>(DoRPCRequest("DescribeDeviceModel", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceModelResponse> DescribeDeviceModelWithOptionsAsync(DescribeDeviceModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeviceModelResponse>(await DoRPCRequestAsync("DescribeDeviceModel", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDeviceModelResponse DescribeDeviceModel(DescribeDeviceModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceModelWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceModelResponse> DescribeDeviceModelAsync(DescribeDeviceModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceModelWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceOnlineInfoResponse DescribeDeviceOnlineInfoWithOptions(DescribeDeviceOnlineInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceOnlineInfoResponse>(DoRPCRequest("DescribeDeviceOnlineInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceOnlineInfoResponse> DescribeDeviceOnlineInfoWithOptionsAsync(DescribeDeviceOnlineInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceOnlineInfoResponse>(await DoRPCRequestAsync("DescribeDeviceOnlineInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceOnlineInfoResponse DescribeDeviceOnlineInfo(DescribeDeviceOnlineInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceOnlineInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceOnlineInfoResponse> DescribeDeviceOnlineInfoAsync(DescribeDeviceOnlineInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceOnlineInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceShadowResponse DescribeDeviceShadowWithOptions(DescribeDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceShadowResponse>(DoRPCRequest("DescribeDeviceShadow", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceShadowResponse> DescribeDeviceShadowWithOptionsAsync(DescribeDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceShadowResponse>(await DoRPCRequestAsync("DescribeDeviceShadow", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceShadowResponse DescribeDeviceShadow(DescribeDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceShadowWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceShadowResponse> DescribeDeviceShadowAsync(DescribeDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceShadowWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceValiditySchemaResponse DescribeDeviceValiditySchemaWithOptions(DescribeDeviceValiditySchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceValiditySchemaResponse>(DoRPCRequest("DescribeDeviceValiditySchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceValiditySchemaResponse> DescribeDeviceValiditySchemaWithOptionsAsync(DescribeDeviceValiditySchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceValiditySchemaResponse>(await DoRPCRequestAsync("DescribeDeviceValiditySchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceValiditySchemaResponse DescribeDeviceValiditySchema(DescribeDeviceValiditySchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceValiditySchemaWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceValiditySchemaResponse> DescribeDeviceValiditySchemaAsync(DescribeDeviceValiditySchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceValiditySchemaWithOptionsAsync(request, runtime);
        }

        public DescribeMessageResponse DescribeMessageWithOptions(DescribeMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMessageResponse>(DoRPCRequest("DescribeMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMessageResponse> DescribeMessageWithOptionsAsync(DescribeMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMessageResponse>(await DoRPCRequestAsync("DescribeMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMessageResponse DescribeMessage(DescribeMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMessageWithOptions(request, runtime);
        }

        public async Task<DescribeMessageResponse> DescribeMessageAsync(DescribeMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMessageWithOptionsAsync(request, runtime);
        }

        public DescribeMqttClientStatusResponse DescribeMqttClientStatusWithOptions(DescribeMqttClientStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMqttClientStatusResponse>(DoRPCRequest("DescribeMqttClientStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMqttClientStatusResponse> DescribeMqttClientStatusWithOptionsAsync(DescribeMqttClientStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMqttClientStatusResponse>(await DoRPCRequestAsync("DescribeMqttClientStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMqttClientStatusResponse DescribeMqttClientStatus(DescribeMqttClientStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMqttClientStatusWithOptions(request, runtime);
        }

        public async Task<DescribeMqttClientStatusResponse> DescribeMqttClientStatusAsync(DescribeMqttClientStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMqttClientStatusWithOptionsAsync(request, runtime);
        }

        public DescribeMqttMessageResponse DescribeMqttMessageWithOptions(DescribeMqttMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMqttMessageResponse>(DoRPCRequest("DescribeMqttMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMqttMessageResponse> DescribeMqttMessageWithOptionsAsync(DescribeMqttMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMqttMessageResponse>(await DoRPCRequestAsync("DescribeMqttMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMqttMessageResponse DescribeMqttMessage(DescribeMqttMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMqttMessageWithOptions(request, runtime);
        }

        public async Task<DescribeMqttMessageResponse> DescribeMqttMessageAsync(DescribeMqttMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMqttMessageWithOptionsAsync(request, runtime);
        }

        public DescribeMqttTopicSubscriptionResponse DescribeMqttTopicSubscriptionWithOptions(DescribeMqttTopicSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMqttTopicSubscriptionResponse>(DoRPCRequest("DescribeMqttTopicSubscription", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMqttTopicSubscriptionResponse> DescribeMqttTopicSubscriptionWithOptionsAsync(DescribeMqttTopicSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMqttTopicSubscriptionResponse>(await DoRPCRequestAsync("DescribeMqttTopicSubscription", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMqttTopicSubscriptionResponse DescribeMqttTopicSubscription(DescribeMqttTopicSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMqttTopicSubscriptionWithOptions(request, runtime);
        }

        public async Task<DescribeMqttTopicSubscriptionResponse> DescribeMqttTopicSubscriptionAsync(DescribeMqttTopicSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMqttTopicSubscriptionWithOptionsAsync(request, runtime);
        }

        public DescribeOpenAccountResponse DescribeOpenAccountWithOptions(DescribeOpenAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeOpenAccountResponse>(DoRPCRequest("DescribeOpenAccount", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeOpenAccountResponse> DescribeOpenAccountWithOptionsAsync(DescribeOpenAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeOpenAccountResponse>(await DoRPCRequestAsync("DescribeOpenAccount", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeOpenAccountResponse DescribeOpenAccount(DescribeOpenAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOpenAccountWithOptions(request, runtime);
        }

        public async Task<DescribeOpenAccountResponse> DescribeOpenAccountAsync(DescribeOpenAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOpenAccountWithOptionsAsync(request, runtime);
        }

        public DescribeOsVersionResponse DescribeOsVersionWithOptions(DescribeOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOsVersionResponse>(DoRPCRequest("DescribeOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOsVersionResponse> DescribeOsVersionWithOptionsAsync(DescribeOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOsVersionResponse>(await DoRPCRequestAsync("DescribeOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOsVersionResponse DescribeOsVersion(DescribeOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOsVersionWithOptions(request, runtime);
        }

        public async Task<DescribeOsVersionResponse> DescribeOsVersionAsync(DescribeOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOsVersionWithOptionsAsync(request, runtime);
        }

        public DescribeProjectResponse DescribeProjectWithOptions(DescribeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProjectResponse>(DoRPCRequest("DescribeProject", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProjectResponse> DescribeProjectWithOptionsAsync(DescribeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProjectResponse>(await DoRPCRequestAsync("DescribeProject", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectWithOptions(request, runtime);
        }

        public async Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectWithOptionsAsync(request, runtime);
        }

        public DescribeProjectAppSecurityResponse DescribeProjectAppSecurityWithOptions(DescribeProjectAppSecurityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProjectAppSecurityResponse>(DoRPCRequest("DescribeProjectAppSecurity", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProjectAppSecurityResponse> DescribeProjectAppSecurityWithOptionsAsync(DescribeProjectAppSecurityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProjectAppSecurityResponse>(await DoRPCRequestAsync("DescribeProjectAppSecurity", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProjectAppSecurityResponse DescribeProjectAppSecurity(DescribeProjectAppSecurityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectAppSecurityWithOptions(request, runtime);
        }

        public async Task<DescribeProjectAppSecurityResponse> DescribeProjectAppSecurityAsync(DescribeProjectAppSecurityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectAppSecurityWithOptionsAsync(request, runtime);
        }

        public DescribeShadowSchemaResponse DescribeShadowSchemaWithOptions(DescribeShadowSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeShadowSchemaResponse>(DoRPCRequest("DescribeShadowSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeShadowSchemaResponse> DescribeShadowSchemaWithOptionsAsync(DescribeShadowSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeShadowSchemaResponse>(await DoRPCRequestAsync("DescribeShadowSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeShadowSchemaResponse DescribeShadowSchema(DescribeShadowSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShadowSchemaWithOptions(request, runtime);
        }

        public async Task<DescribeShadowSchemaResponse> DescribeShadowSchemaAsync(DescribeShadowSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShadowSchemaWithOptionsAsync(request, runtime);
        }

        public DescribeVersionDeviceGroupResponse DescribeVersionDeviceGroupWithOptions(DescribeVersionDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVersionDeviceGroupResponse>(DoRPCRequest("DescribeVersionDeviceGroup", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVersionDeviceGroupResponse> DescribeVersionDeviceGroupWithOptionsAsync(DescribeVersionDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVersionDeviceGroupResponse>(await DoRPCRequestAsync("DescribeVersionDeviceGroup", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVersionDeviceGroupResponse DescribeVersionDeviceGroup(DescribeVersionDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVersionDeviceGroupWithOptions(request, runtime);
        }

        public async Task<DescribeVersionDeviceGroupResponse> DescribeVersionDeviceGroupAsync(DescribeVersionDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVersionDeviceGroupWithOptionsAsync(request, runtime);
        }

        public DiagnosisVersionResponse DiagnosisVersionWithOptions(DiagnosisVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DiagnosisVersionResponse>(DoRPCRequest("DiagnosisVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DiagnosisVersionResponse> DiagnosisVersionWithOptionsAsync(DiagnosisVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DiagnosisVersionResponse>(await DoRPCRequestAsync("DiagnosisVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DiagnosisVersionResponse DiagnosisVersion(DiagnosisVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DiagnosisVersionWithOptions(request, runtime);
        }

        public async Task<DiagnosisVersionResponse> DiagnosisVersionAsync(DiagnosisVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DiagnosisVersionWithOptionsAsync(request, runtime);
        }

        public FindAppVersionsResponse FindAppVersionsWithOptions(FindAppVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindAppVersionsResponse>(DoRPCRequest("FindAppVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindAppVersionsResponse> FindAppVersionsWithOptionsAsync(FindAppVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindAppVersionsResponse>(await DoRPCRequestAsync("FindAppVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindAppVersionsResponse FindAppVersions(FindAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindAppVersionsWithOptions(request, runtime);
        }

        public async Task<FindAppVersionsResponse> FindAppVersionsAsync(FindAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindAppVersionsWithOptionsAsync(request, runtime);
        }

        public FindCustomizedFiltersResponse FindCustomizedFiltersWithOptions(FindCustomizedFiltersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindCustomizedFiltersResponse>(DoRPCRequest("FindCustomizedFilters", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindCustomizedFiltersResponse> FindCustomizedFiltersWithOptionsAsync(FindCustomizedFiltersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindCustomizedFiltersResponse>(await DoRPCRequestAsync("FindCustomizedFilters", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindCustomizedFiltersResponse FindCustomizedFilters(FindCustomizedFiltersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindCustomizedFiltersWithOptions(request, runtime);
        }

        public async Task<FindCustomizedFiltersResponse> FindCustomizedFiltersAsync(FindCustomizedFiltersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindCustomizedFiltersWithOptionsAsync(request, runtime);
        }

        public FindCustomizedPropertiesResponse FindCustomizedPropertiesWithOptions(FindCustomizedPropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindCustomizedPropertiesResponse>(DoRPCRequest("FindCustomizedProperties", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindCustomizedPropertiesResponse> FindCustomizedPropertiesWithOptionsAsync(FindCustomizedPropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindCustomizedPropertiesResponse>(await DoRPCRequestAsync("FindCustomizedProperties", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindCustomizedPropertiesResponse FindCustomizedProperties(FindCustomizedPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindCustomizedPropertiesWithOptions(request, runtime);
        }

        public async Task<FindCustomizedPropertiesResponse> FindCustomizedPropertiesAsync(FindCustomizedPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindCustomizedPropertiesWithOptionsAsync(request, runtime);
        }

        public FindOsVersionsResponse FindOsVersionsWithOptions(FindOsVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindOsVersionsResponse>(DoRPCRequest("FindOsVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindOsVersionsResponse> FindOsVersionsWithOptionsAsync(FindOsVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindOsVersionsResponse>(await DoRPCRequestAsync("FindOsVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindOsVersionsResponse FindOsVersions(FindOsVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindOsVersionsWithOptions(request, runtime);
        }

        public async Task<FindOsVersionsResponse> FindOsVersionsAsync(FindOsVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindOsVersionsWithOptionsAsync(request, runtime);
        }

        public FindPrepublishesByParentIdResponse FindPrepublishesByParentIdWithOptions(FindPrepublishesByParentIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindPrepublishesByParentIdResponse>(DoRPCRequest("FindPrepublishesByParentId", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindPrepublishesByParentIdResponse> FindPrepublishesByParentIdWithOptionsAsync(FindPrepublishesByParentIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindPrepublishesByParentIdResponse>(await DoRPCRequestAsync("FindPrepublishesByParentId", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindPrepublishesByParentIdResponse FindPrepublishesByParentId(FindPrepublishesByParentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindPrepublishesByParentIdWithOptions(request, runtime);
        }

        public async Task<FindPrepublishesByParentIdResponse> FindPrepublishesByParentIdAsync(FindPrepublishesByParentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindPrepublishesByParentIdWithOptionsAsync(request, runtime);
        }

        public FindPrepublishesByVersionIdResponse FindPrepublishesByVersionIdWithOptions(FindPrepublishesByVersionIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindPrepublishesByVersionIdResponse>(DoRPCRequest("FindPrepublishesByVersionId", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindPrepublishesByVersionIdResponse> FindPrepublishesByVersionIdWithOptionsAsync(FindPrepublishesByVersionIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindPrepublishesByVersionIdResponse>(await DoRPCRequestAsync("FindPrepublishesByVersionId", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindPrepublishesByVersionIdResponse FindPrepublishesByVersionId(FindPrepublishesByVersionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindPrepublishesByVersionIdWithOptions(request, runtime);
        }

        public async Task<FindPrepublishesByVersionIdResponse> FindPrepublishesByVersionIdAsync(FindPrepublishesByVersionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindPrepublishesByVersionIdWithOptionsAsync(request, runtime);
        }

        public FindPrepublishPassedDevicesResponse FindPrepublishPassedDevicesWithOptions(FindPrepublishPassedDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindPrepublishPassedDevicesResponse>(DoRPCRequest("FindPrepublishPassedDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindPrepublishPassedDevicesResponse> FindPrepublishPassedDevicesWithOptionsAsync(FindPrepublishPassedDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindPrepublishPassedDevicesResponse>(await DoRPCRequestAsync("FindPrepublishPassedDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindPrepublishPassedDevicesResponse FindPrepublishPassedDevices(FindPrepublishPassedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindPrepublishPassedDevicesWithOptions(request, runtime);
        }

        public async Task<FindPrepublishPassedDevicesResponse> FindPrepublishPassedDevicesAsync(FindPrepublishPassedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindPrepublishPassedDevicesWithOptionsAsync(request, runtime);
        }

        public FindVersionBlackDevicesResponse FindVersionBlackDevicesWithOptions(FindVersionBlackDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionBlackDevicesResponse>(DoRPCRequest("FindVersionBlackDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindVersionBlackDevicesResponse> FindVersionBlackDevicesWithOptionsAsync(FindVersionBlackDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionBlackDevicesResponse>(await DoRPCRequestAsync("FindVersionBlackDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindVersionBlackDevicesResponse FindVersionBlackDevices(FindVersionBlackDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindVersionBlackDevicesWithOptions(request, runtime);
        }

        public async Task<FindVersionBlackDevicesResponse> FindVersionBlackDevicesAsync(FindVersionBlackDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindVersionBlackDevicesWithOptionsAsync(request, runtime);
        }

        public FindVersionDeviceGroupsResponse FindVersionDeviceGroupsWithOptions(FindVersionDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionDeviceGroupsResponse>(DoRPCRequest("FindVersionDeviceGroups", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindVersionDeviceGroupsResponse> FindVersionDeviceGroupsWithOptionsAsync(FindVersionDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionDeviceGroupsResponse>(await DoRPCRequestAsync("FindVersionDeviceGroups", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindVersionDeviceGroupsResponse FindVersionDeviceGroups(FindVersionDeviceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindVersionDeviceGroupsWithOptions(request, runtime);
        }

        public async Task<FindVersionDeviceGroupsResponse> FindVersionDeviceGroupsAsync(FindVersionDeviceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindVersionDeviceGroupsWithOptionsAsync(request, runtime);
        }

        public FindVersionGroupDevicesResponse FindVersionGroupDevicesWithOptions(FindVersionGroupDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionGroupDevicesResponse>(DoRPCRequest("FindVersionGroupDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindVersionGroupDevicesResponse> FindVersionGroupDevicesWithOptionsAsync(FindVersionGroupDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionGroupDevicesResponse>(await DoRPCRequestAsync("FindVersionGroupDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindVersionGroupDevicesResponse FindVersionGroupDevices(FindVersionGroupDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindVersionGroupDevicesWithOptions(request, runtime);
        }

        public async Task<FindVersionGroupDevicesResponse> FindVersionGroupDevicesAsync(FindVersionGroupDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindVersionGroupDevicesWithOptionsAsync(request, runtime);
        }

        public FindVersionMessagesResponse FindVersionMessagesWithOptions(FindVersionMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionMessagesResponse>(DoRPCRequest("FindVersionMessages", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindVersionMessagesResponse> FindVersionMessagesWithOptionsAsync(FindVersionMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionMessagesResponse>(await DoRPCRequestAsync("FindVersionMessages", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindVersionMessagesResponse FindVersionMessages(FindVersionMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindVersionMessagesWithOptions(request, runtime);
        }

        public async Task<FindVersionMessagesResponse> FindVersionMessagesAsync(FindVersionMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindVersionMessagesWithOptionsAsync(request, runtime);
        }

        public FindVersionMessageSendRecordsResponse FindVersionMessageSendRecordsWithOptions(FindVersionMessageSendRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionMessageSendRecordsResponse>(DoRPCRequest("FindVersionMessageSendRecords", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindVersionMessageSendRecordsResponse> FindVersionMessageSendRecordsWithOptionsAsync(FindVersionMessageSendRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionMessageSendRecordsResponse>(await DoRPCRequestAsync("FindVersionMessageSendRecords", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindVersionMessageSendRecordsResponse FindVersionMessageSendRecords(FindVersionMessageSendRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindVersionMessageSendRecordsWithOptions(request, runtime);
        }

        public async Task<FindVersionMessageSendRecordsResponse> FindVersionMessageSendRecordsAsync(FindVersionMessageSendRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindVersionMessageSendRecordsWithOptionsAsync(request, runtime);
        }

        public FindVersionTestsResponse FindVersionTestsWithOptions(FindVersionTestsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionTestsResponse>(DoRPCRequest("FindVersionTests", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindVersionTestsResponse> FindVersionTestsWithOptionsAsync(FindVersionTestsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionTestsResponse>(await DoRPCRequestAsync("FindVersionTests", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindVersionTestsResponse FindVersionTests(FindVersionTestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindVersionTestsWithOptions(request, runtime);
        }

        public async Task<FindVersionTestsResponse> FindVersionTestsAsync(FindVersionTestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindVersionTestsWithOptionsAsync(request, runtime);
        }

        public FindVersionWhiteDevicesResponse FindVersionWhiteDevicesWithOptions(FindVersionWhiteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionWhiteDevicesResponse>(DoRPCRequest("FindVersionWhiteDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindVersionWhiteDevicesResponse> FindVersionWhiteDevicesWithOptionsAsync(FindVersionWhiteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindVersionWhiteDevicesResponse>(await DoRPCRequestAsync("FindVersionWhiteDevices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindVersionWhiteDevicesResponse FindVersionWhiteDevices(FindVersionWhiteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindVersionWhiteDevicesWithOptions(request, runtime);
        }

        public async Task<FindVersionWhiteDevicesResponse> FindVersionWhiteDevicesAsync(FindVersionWhiteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindVersionWhiteDevicesWithOptionsAsync(request, runtime);
        }

        public GenerateAssistFileUploadUrlResponse GenerateAssistFileUploadUrlWithOptions(GenerateAssistFileUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAssistFileUploadUrlResponse>(DoRPCRequest("GenerateAssistFileUploadUrl", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateAssistFileUploadUrlResponse> GenerateAssistFileUploadUrlWithOptionsAsync(GenerateAssistFileUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAssistFileUploadUrlResponse>(await DoRPCRequestAsync("GenerateAssistFileUploadUrl", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateAssistFileUploadUrlResponse GenerateAssistFileUploadUrl(GenerateAssistFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAssistFileUploadUrlWithOptions(request, runtime);
        }

        public async Task<GenerateAssistFileUploadUrlResponse> GenerateAssistFileUploadUrlAsync(GenerateAssistFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAssistFileUploadUrlWithOptionsAsync(request, runtime);
        }

        public GenerateFunctionFileUploadMetaResponse GenerateFunctionFileUploadMetaWithOptions(GenerateFunctionFileUploadMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateFunctionFileUploadMetaResponse>(DoRPCRequest("GenerateFunctionFileUploadMeta", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateFunctionFileUploadMetaResponse> GenerateFunctionFileUploadMetaWithOptionsAsync(GenerateFunctionFileUploadMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateFunctionFileUploadMetaResponse>(await DoRPCRequestAsync("GenerateFunctionFileUploadMeta", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateFunctionFileUploadMetaResponse GenerateFunctionFileUploadMeta(GenerateFunctionFileUploadMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateFunctionFileUploadMetaWithOptions(request, runtime);
        }

        public async Task<GenerateFunctionFileUploadMetaResponse> GenerateFunctionFileUploadMetaAsync(GenerateFunctionFileUploadMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateFunctionFileUploadMetaWithOptionsAsync(request, runtime);
        }

        public GenerateOssPostPolicyResponse GenerateOssPostPolicyWithOptions(GenerateOssPostPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateOssPostPolicyResponse>(DoRPCRequest("GenerateOssPostPolicy", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateOssPostPolicyResponse> GenerateOssPostPolicyWithOptionsAsync(GenerateOssPostPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateOssPostPolicyResponse>(await DoRPCRequestAsync("GenerateOssPostPolicy", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateOssPostPolicyResponse GenerateOssPostPolicy(GenerateOssPostPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateOssPostPolicyWithOptions(request, runtime);
        }

        public async Task<GenerateOssPostPolicyResponse> GenerateOssPostPolicyAsync(GenerateOssPostPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateOssPostPolicyWithOptionsAsync(request, runtime);
        }

        public GenerateOssUploadMetaResponse GenerateOssUploadMetaWithOptions(GenerateOssUploadMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateOssUploadMetaResponse>(DoRPCRequest("GenerateOssUploadMeta", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateOssUploadMetaResponse> GenerateOssUploadMetaWithOptionsAsync(GenerateOssUploadMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateOssUploadMetaResponse>(await DoRPCRequestAsync("GenerateOssUploadMeta", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateOssUploadMetaResponse GenerateOssUploadMeta(GenerateOssUploadMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateOssUploadMetaWithOptions(request, runtime);
        }

        public async Task<GenerateOssUploadMetaResponse> GenerateOssUploadMetaAsync(GenerateOssUploadMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateOssUploadMetaWithOptionsAsync(request, runtime);
        }

        public GenerateSdkDownloadInfoResponse GenerateSdkDownloadInfoWithOptions(GenerateSdkDownloadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateSdkDownloadInfoResponse>(DoRPCRequest("GenerateSdkDownloadInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateSdkDownloadInfoResponse> GenerateSdkDownloadInfoWithOptionsAsync(GenerateSdkDownloadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateSdkDownloadInfoResponse>(await DoRPCRequestAsync("GenerateSdkDownloadInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateSdkDownloadInfoResponse GenerateSdkDownloadInfo(GenerateSdkDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateSdkDownloadInfoWithOptions(request, runtime);
        }

        public async Task<GenerateSdkDownloadInfoResponse> GenerateSdkDownloadInfoAsync(GenerateSdkDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateSdkDownloadInfoWithOptionsAsync(request, runtime);
        }

        public GenerateSysAppDownloadInfoResponse GenerateSysAppDownloadInfoWithOptions(GenerateSysAppDownloadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateSysAppDownloadInfoResponse>(DoRPCRequest("GenerateSysAppDownloadInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateSysAppDownloadInfoResponse> GenerateSysAppDownloadInfoWithOptionsAsync(GenerateSysAppDownloadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateSysAppDownloadInfoResponse>(await DoRPCRequestAsync("GenerateSysAppDownloadInfo", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateSysAppDownloadInfoResponse GenerateSysAppDownloadInfo(GenerateSysAppDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateSysAppDownloadInfoWithOptions(request, runtime);
        }

        public async Task<GenerateSysAppDownloadInfoResponse> GenerateSysAppDownloadInfoAsync(GenerateSysAppDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateSysAppDownloadInfoWithOptionsAsync(request, runtime);
        }

        public GetDeviceAppUpdateFunnelEventsResponse GetDeviceAppUpdateFunnelEventsWithOptions(GetDeviceAppUpdateFunnelEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceAppUpdateFunnelEventsResponse>(DoRPCRequest("GetDeviceAppUpdateFunnelEvents", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDeviceAppUpdateFunnelEventsResponse> GetDeviceAppUpdateFunnelEventsWithOptionsAsync(GetDeviceAppUpdateFunnelEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceAppUpdateFunnelEventsResponse>(await DoRPCRequestAsync("GetDeviceAppUpdateFunnelEvents", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDeviceAppUpdateFunnelEventsResponse GetDeviceAppUpdateFunnelEvents(GetDeviceAppUpdateFunnelEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceAppUpdateFunnelEventsWithOptions(request, runtime);
        }

        public async Task<GetDeviceAppUpdateFunnelEventsResponse> GetDeviceAppUpdateFunnelEventsAsync(GetDeviceAppUpdateFunnelEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceAppUpdateFunnelEventsWithOptionsAsync(request, runtime);
        }

        public GetDeviceSystemUpdateFunnelEventsResponse GetDeviceSystemUpdateFunnelEventsWithOptions(GetDeviceSystemUpdateFunnelEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceSystemUpdateFunnelEventsResponse>(DoRPCRequest("GetDeviceSystemUpdateFunnelEvents", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDeviceSystemUpdateFunnelEventsResponse> GetDeviceSystemUpdateFunnelEventsWithOptionsAsync(GetDeviceSystemUpdateFunnelEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceSystemUpdateFunnelEventsResponse>(await DoRPCRequestAsync("GetDeviceSystemUpdateFunnelEvents", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDeviceSystemUpdateFunnelEventsResponse GetDeviceSystemUpdateFunnelEvents(GetDeviceSystemUpdateFunnelEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceSystemUpdateFunnelEventsWithOptions(request, runtime);
        }

        public async Task<GetDeviceSystemUpdateFunnelEventsResponse> GetDeviceSystemUpdateFunnelEventsAsync(GetDeviceSystemUpdateFunnelEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceSystemUpdateFunnelEventsWithOptionsAsync(request, runtime);
        }

        public GetNamespaceDataResponse GetNamespaceDataWithOptions(GetNamespaceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNamespaceDataResponse>(DoRPCRequest("GetNamespaceData", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNamespaceDataResponse> GetNamespaceDataWithOptionsAsync(GetNamespaceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNamespaceDataResponse>(await DoRPCRequestAsync("GetNamespaceData", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNamespaceDataResponse GetNamespaceData(GetNamespaceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNamespaceDataWithOptions(request, runtime);
        }

        public async Task<GetNamespaceDataResponse> GetNamespaceDataAsync(GetNamespaceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNamespaceDataWithOptionsAsync(request, runtime);
        }

        public GetNamespaceStatisticsDataResponse GetNamespaceStatisticsDataWithOptions(GetNamespaceStatisticsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNamespaceStatisticsDataResponse>(DoRPCRequest("GetNamespaceStatisticsData", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNamespaceStatisticsDataResponse> GetNamespaceStatisticsDataWithOptionsAsync(GetNamespaceStatisticsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNamespaceStatisticsDataResponse>(await DoRPCRequestAsync("GetNamespaceStatisticsData", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNamespaceStatisticsDataResponse GetNamespaceStatisticsData(GetNamespaceStatisticsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNamespaceStatisticsDataWithOptions(request, runtime);
        }

        public async Task<GetNamespaceStatisticsDataResponse> GetNamespaceStatisticsDataAsync(GetNamespaceStatisticsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNamespaceStatisticsDataWithOptionsAsync(request, runtime);
        }

        public GetOssUploadMetaResponse GetOssUploadMetaWithOptions(GetOssUploadMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOssUploadMetaResponse>(DoRPCRequest("GetOssUploadMeta", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOssUploadMetaResponse> GetOssUploadMetaWithOptionsAsync(GetOssUploadMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOssUploadMetaResponse>(await DoRPCRequestAsync("GetOssUploadMeta", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOssUploadMetaResponse GetOssUploadMeta(GetOssUploadMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOssUploadMetaWithOptions(request, runtime);
        }

        public async Task<GetOssUploadMetaResponse> GetOssUploadMetaAsync(GetOssUploadMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOssUploadMetaWithOptionsAsync(request, runtime);
        }

        public InvokeFunctionResponse InvokeFunctionWithOptions(InvokeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InvokeFunctionResponse>(DoRPCRequest("InvokeFunction", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InvokeFunctionResponse> InvokeFunctionWithOptionsAsync(InvokeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InvokeFunctionResponse>(await DoRPCRequestAsync("InvokeFunction", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InvokeFunctionResponse InvokeFunction(InvokeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeFunctionWithOptions(request, runtime);
        }

        public async Task<InvokeFunctionResponse> InvokeFunctionAsync(InvokeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeFunctionWithOptionsAsync(request, runtime);
        }

        public ListApiGatewayAppsResponse ListApiGatewayAppsWithOptions(ListApiGatewayAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListApiGatewayAppsResponse>(DoRPCRequest("ListApiGatewayApps", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListApiGatewayAppsResponse> ListApiGatewayAppsWithOptionsAsync(ListApiGatewayAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListApiGatewayAppsResponse>(await DoRPCRequestAsync("ListApiGatewayApps", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListApiGatewayAppsResponse ListApiGatewayApps(ListApiGatewayAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApiGatewayAppsWithOptions(request, runtime);
        }

        public async Task<ListApiGatewayAppsResponse> ListApiGatewayAppsAsync(ListApiGatewayAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApiGatewayAppsWithOptionsAsync(request, runtime);
        }

        public ListAppsResponse ListAppsWithOptions(ListAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAppsResponse>(DoRPCRequest("ListApps", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAppsResponse> ListAppsWithOptionsAsync(ListAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAppsResponse>(await DoRPCRequestAsync("ListApps", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAppsResponse ListApps(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppsWithOptions(request, runtime);
        }

        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppsWithOptionsAsync(request, runtime);
        }

        public ListAssistActionDetailsResponse ListAssistActionDetailsWithOptions(ListAssistActionDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAssistActionDetailsResponse>(DoRPCRequest("ListAssistActionDetails", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAssistActionDetailsResponse> ListAssistActionDetailsWithOptionsAsync(ListAssistActionDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAssistActionDetailsResponse>(await DoRPCRequestAsync("ListAssistActionDetails", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAssistActionDetailsResponse ListAssistActionDetails(ListAssistActionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAssistActionDetailsWithOptions(request, runtime);
        }

        public async Task<ListAssistActionDetailsResponse> ListAssistActionDetailsAsync(ListAssistActionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAssistActionDetailsWithOptionsAsync(request, runtime);
        }

        public ListAssistDevicesResponse ListAssistDevicesWithOptions(ListAssistDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAssistDevicesResponse>(DoRPCRequest("ListAssistDevices", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAssistDevicesResponse> ListAssistDevicesWithOptionsAsync(ListAssistDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAssistDevicesResponse>(await DoRPCRequestAsync("ListAssistDevices", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAssistDevicesResponse ListAssistDevices(ListAssistDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAssistDevicesWithOptions(request, runtime);
        }

        public async Task<ListAssistDevicesResponse> ListAssistDevicesAsync(ListAssistDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAssistDevicesWithOptionsAsync(request, runtime);
        }

        public ListAssistHistoriesResponse ListAssistHistoriesWithOptions(ListAssistHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAssistHistoriesResponse>(DoRPCRequest("ListAssistHistories", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAssistHistoriesResponse> ListAssistHistoriesWithOptionsAsync(ListAssistHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAssistHistoriesResponse>(await DoRPCRequestAsync("ListAssistHistories", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAssistHistoriesResponse ListAssistHistories(ListAssistHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAssistHistoriesWithOptions(request, runtime);
        }

        public async Task<ListAssistHistoriesResponse> ListAssistHistoriesAsync(ListAssistHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAssistHistoriesWithOptionsAsync(request, runtime);
        }

        public ListAssistHistoryDetailsResponse ListAssistHistoryDetailsWithOptions(ListAssistHistoryDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAssistHistoryDetailsResponse>(DoRPCRequest("ListAssistHistoryDetails", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAssistHistoryDetailsResponse> ListAssistHistoryDetailsWithOptionsAsync(ListAssistHistoryDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAssistHistoryDetailsResponse>(await DoRPCRequestAsync("ListAssistHistoryDetails", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAssistHistoryDetailsResponse ListAssistHistoryDetails(ListAssistHistoryDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAssistHistoryDetailsWithOptions(request, runtime);
        }

        public async Task<ListAssistHistoryDetailsResponse> ListAssistHistoryDetailsAsync(ListAssistHistoryDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAssistHistoryDetailsWithOptionsAsync(request, runtime);
        }

        public ListClientPluginsResponse ListClientPluginsWithOptions(ListClientPluginsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClientPluginsResponse>(DoRPCRequest("ListClientPlugins", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClientPluginsResponse> ListClientPluginsWithOptionsAsync(ListClientPluginsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClientPluginsResponse>(await DoRPCRequestAsync("ListClientPlugins", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClientPluginsResponse ListClientPlugins(ListClientPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientPluginsWithOptions(request, runtime);
        }

        public async Task<ListClientPluginsResponse> ListClientPluginsAsync(ListClientPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientPluginsWithOptionsAsync(request, runtime);
        }

        public ListClientPluginVersionsResponse ListClientPluginVersionsWithOptions(ListClientPluginVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClientPluginVersionsResponse>(DoRPCRequest("ListClientPluginVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClientPluginVersionsResponse> ListClientPluginVersionsWithOptionsAsync(ListClientPluginVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClientPluginVersionsResponse>(await DoRPCRequestAsync("ListClientPluginVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClientPluginVersionsResponse ListClientPluginVersions(ListClientPluginVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientPluginVersionsWithOptions(request, runtime);
        }

        public async Task<ListClientPluginVersionsResponse> ListClientPluginVersionsAsync(ListClientPluginVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientPluginVersionsWithOptionsAsync(request, runtime);
        }

        public ListClientSdksResponse ListClientSdksWithOptions(ListClientSdksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClientSdksResponse>(DoRPCRequest("ListClientSdks", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClientSdksResponse> ListClientSdksWithOptionsAsync(ListClientSdksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClientSdksResponse>(await DoRPCRequestAsync("ListClientSdks", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClientSdksResponse ListClientSdks(ListClientSdksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientSdksWithOptions(request, runtime);
        }

        public async Task<ListClientSdksResponse> ListClientSdksAsync(ListClientSdksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientSdksWithOptionsAsync(request, runtime);
        }

        public ListConnectLogsResponse ListConnectLogsWithOptions(ListConnectLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConnectLogsResponse>(DoRPCRequest("ListConnectLogs", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListConnectLogsResponse> ListConnectLogsWithOptionsAsync(ListConnectLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConnectLogsResponse>(await DoRPCRequestAsync("ListConnectLogs", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListConnectLogsResponse ListConnectLogs(ListConnectLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectLogsWithOptions(request, runtime);
        }

        public async Task<ListConnectLogsResponse> ListConnectLogsAsync(ListConnectLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectLogsWithOptionsAsync(request, runtime);
        }

        public ListDeployedFunctionsResponse ListDeployedFunctionsWithOptions(ListDeployedFunctionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeployedFunctionsResponse>(DoRPCRequest("ListDeployedFunctions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDeployedFunctionsResponse> ListDeployedFunctionsWithOptionsAsync(ListDeployedFunctionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeployedFunctionsResponse>(await DoRPCRequestAsync("ListDeployedFunctions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDeployedFunctionsResponse ListDeployedFunctions(ListDeployedFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeployedFunctionsWithOptions(request, runtime);
        }

        public async Task<ListDeployedFunctionsResponse> ListDeployedFunctionsAsync(ListDeployedFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeployedFunctionsWithOptionsAsync(request, runtime);
        }

        public ListDeviceBrandsResponse ListDeviceBrandsWithOptions(ListDeviceBrandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDeviceBrandsResponse>(DoRPCRequest("ListDeviceBrands", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceBrandsResponse> ListDeviceBrandsWithOptionsAsync(ListDeviceBrandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDeviceBrandsResponse>(await DoRPCRequestAsync("ListDeviceBrands", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListDeviceBrandsResponse ListDeviceBrands(ListDeviceBrandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceBrandsWithOptions(request, runtime);
        }

        public async Task<ListDeviceBrandsResponse> ListDeviceBrandsAsync(ListDeviceBrandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceBrandsWithOptionsAsync(request, runtime);
        }

        public ListDeviceModelResponse ListDeviceModelWithOptions(ListDeviceModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDeviceModelResponse>(DoRPCRequest("ListDeviceModel", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceModelResponse> ListDeviceModelWithOptionsAsync(ListDeviceModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDeviceModelResponse>(await DoRPCRequestAsync("ListDeviceModel", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListDeviceModelResponse ListDeviceModel(ListDeviceModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceModelWithOptions(request, runtime);
        }

        public async Task<ListDeviceModelResponse> ListDeviceModelAsync(ListDeviceModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceModelWithOptionsAsync(request, runtime);
        }

        public ListDeviceModelsResponse ListDeviceModelsWithOptions(ListDeviceModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDeviceModelsResponse>(DoRPCRequest("ListDeviceModels", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceModelsResponse> ListDeviceModelsWithOptionsAsync(ListDeviceModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDeviceModelsResponse>(await DoRPCRequestAsync("ListDeviceModels", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListDeviceModelsResponse ListDeviceModels(ListDeviceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceModelsWithOptions(request, runtime);
        }

        public async Task<ListDeviceModelsResponse> ListDeviceModelsAsync(ListDeviceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceModelsWithOptionsAsync(request, runtime);
        }

        public ListDevicesResponse ListDevicesWithOptions(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDevicesResponse>(DoRPCRequest("ListDevices", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListDevicesResponse> ListDevicesWithOptionsAsync(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDevicesResponse>(await DoRPCRequestAsync("ListDevices", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public ListDeviceTypesResponse ListDeviceTypesWithOptions(ListDeviceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDeviceTypesResponse>(DoRPCRequest("ListDeviceTypes", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceTypesResponse> ListDeviceTypesWithOptionsAsync(ListDeviceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDeviceTypesResponse>(await DoRPCRequestAsync("ListDeviceTypes", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListDeviceTypesResponse ListDeviceTypes(ListDeviceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceTypesWithOptions(request, runtime);
        }

        public async Task<ListDeviceTypesResponse> ListDeviceTypesAsync(ListDeviceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceTypesWithOptionsAsync(request, runtime);
        }

        public ListFunctionExecuteLogResponse ListFunctionExecuteLogWithOptions(ListFunctionExecuteLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionExecuteLogResponse>(DoRPCRequest("ListFunctionExecuteLog", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFunctionExecuteLogResponse> ListFunctionExecuteLogWithOptionsAsync(ListFunctionExecuteLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionExecuteLogResponse>(await DoRPCRequestAsync("ListFunctionExecuteLog", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFunctionExecuteLogResponse ListFunctionExecuteLog(ListFunctionExecuteLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFunctionExecuteLogWithOptions(request, runtime);
        }

        public async Task<ListFunctionExecuteLogResponse> ListFunctionExecuteLogAsync(ListFunctionExecuteLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFunctionExecuteLogWithOptionsAsync(request, runtime);
        }

        public ListFunctionFilesResponse ListFunctionFilesWithOptions(ListFunctionFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionFilesResponse>(DoRPCRequest("ListFunctionFiles", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFunctionFilesResponse> ListFunctionFilesWithOptionsAsync(ListFunctionFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionFilesResponse>(await DoRPCRequestAsync("ListFunctionFiles", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFunctionFilesResponse ListFunctionFiles(ListFunctionFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFunctionFilesWithOptions(request, runtime);
        }

        public async Task<ListFunctionFilesResponse> ListFunctionFilesAsync(ListFunctionFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFunctionFilesWithOptionsAsync(request, runtime);
        }

        public ListFunctionFilesByProjectIdResponse ListFunctionFilesByProjectIdWithOptions(ListFunctionFilesByProjectIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionFilesByProjectIdResponse>(DoRPCRequest("ListFunctionFilesByProjectId", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFunctionFilesByProjectIdResponse> ListFunctionFilesByProjectIdWithOptionsAsync(ListFunctionFilesByProjectIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionFilesByProjectIdResponse>(await DoRPCRequestAsync("ListFunctionFilesByProjectId", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFunctionFilesByProjectIdResponse ListFunctionFilesByProjectId(ListFunctionFilesByProjectIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFunctionFilesByProjectIdWithOptions(request, runtime);
        }

        public async Task<ListFunctionFilesByProjectIdResponse> ListFunctionFilesByProjectIdAsync(ListFunctionFilesByProjectIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFunctionFilesByProjectIdWithOptionsAsync(request, runtime);
        }

        public ListMessageAcksResponse ListMessageAcksWithOptions(ListMessageAcksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMessageAcksResponse>(DoRPCRequest("ListMessageAcks", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMessageAcksResponse> ListMessageAcksWithOptionsAsync(ListMessageAcksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMessageAcksResponse>(await DoRPCRequestAsync("ListMessageAcks", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMessageAcksResponse ListMessageAcks(ListMessageAcksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMessageAcksWithOptions(request, runtime);
        }

        public async Task<ListMessageAcksResponse> ListMessageAcksAsync(ListMessageAcksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMessageAcksWithOptionsAsync(request, runtime);
        }

        public ListMessageReceiversResponse ListMessageReceiversWithOptions(ListMessageReceiversRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMessageReceiversResponse>(DoRPCRequest("ListMessageReceivers", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMessageReceiversResponse> ListMessageReceiversWithOptionsAsync(ListMessageReceiversRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMessageReceiversResponse>(await DoRPCRequestAsync("ListMessageReceivers", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMessageReceiversResponse ListMessageReceivers(ListMessageReceiversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMessageReceiversWithOptions(request, runtime);
        }

        public async Task<ListMessageReceiversResponse> ListMessageReceiversAsync(ListMessageReceiversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMessageReceiversWithOptionsAsync(request, runtime);
        }

        public ListMqttClientSubscriptionsResponse ListMqttClientSubscriptionsWithOptions(ListMqttClientSubscriptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMqttClientSubscriptionsResponse>(DoRPCRequest("ListMqttClientSubscriptions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMqttClientSubscriptionsResponse> ListMqttClientSubscriptionsWithOptionsAsync(ListMqttClientSubscriptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMqttClientSubscriptionsResponse>(await DoRPCRequestAsync("ListMqttClientSubscriptions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMqttClientSubscriptionsResponse ListMqttClientSubscriptions(ListMqttClientSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMqttClientSubscriptionsWithOptions(request, runtime);
        }

        public async Task<ListMqttClientSubscriptionsResponse> ListMqttClientSubscriptionsAsync(ListMqttClientSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMqttClientSubscriptionsWithOptionsAsync(request, runtime);
        }

        public ListMqttMessageLogsResponse ListMqttMessageLogsWithOptions(ListMqttMessageLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMqttMessageLogsResponse>(DoRPCRequest("ListMqttMessageLogs", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMqttMessageLogsResponse> ListMqttMessageLogsWithOptionsAsync(ListMqttMessageLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMqttMessageLogsResponse>(await DoRPCRequestAsync("ListMqttMessageLogs", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMqttMessageLogsResponse ListMqttMessageLogs(ListMqttMessageLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMqttMessageLogsWithOptions(request, runtime);
        }

        public async Task<ListMqttMessageLogsResponse> ListMqttMessageLogsAsync(ListMqttMessageLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMqttMessageLogsWithOptionsAsync(request, runtime);
        }

        public ListMqttRootTopicsResponse ListMqttRootTopicsWithOptions(ListMqttRootTopicsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMqttRootTopicsResponse>(DoRPCRequest("ListMqttRootTopics", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMqttRootTopicsResponse> ListMqttRootTopicsWithOptionsAsync(ListMqttRootTopicsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMqttRootTopicsResponse>(await DoRPCRequestAsync("ListMqttRootTopics", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMqttRootTopicsResponse ListMqttRootTopics(ListMqttRootTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMqttRootTopicsWithOptions(request, runtime);
        }

        public async Task<ListMqttRootTopicsResponse> ListMqttRootTopicsAsync(ListMqttRootTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMqttRootTopicsWithOptionsAsync(request, runtime);
        }

        public ListNamespacesResponse ListNamespacesWithOptions(ListNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNamespacesResponse>(DoRPCRequest("ListNamespaces", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNamespacesResponse> ListNamespacesWithOptionsAsync(ListNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNamespacesResponse>(await DoRPCRequestAsync("ListNamespaces", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNamespacesWithOptions(request, runtime);
        }

        public async Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNamespacesWithOptionsAsync(request, runtime);
        }

        public ListOfflineMessagesResponse ListOfflineMessagesWithOptions(ListOfflineMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOfflineMessagesResponse>(DoRPCRequest("ListOfflineMessages", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOfflineMessagesResponse> ListOfflineMessagesWithOptionsAsync(ListOfflineMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOfflineMessagesResponse>(await DoRPCRequestAsync("ListOfflineMessages", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOfflineMessagesResponse ListOfflineMessages(ListOfflineMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOfflineMessagesWithOptions(request, runtime);
        }

        public async Task<ListOfflineMessagesResponse> ListOfflineMessagesAsync(ListOfflineMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOfflineMessagesWithOptionsAsync(request, runtime);
        }

        public ListOpenAccountLinksResponse ListOpenAccountLinksWithOptions(ListOpenAccountLinksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListOpenAccountLinksResponse>(DoRPCRequest("ListOpenAccountLinks", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListOpenAccountLinksResponse> ListOpenAccountLinksWithOptionsAsync(ListOpenAccountLinksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListOpenAccountLinksResponse>(await DoRPCRequestAsync("ListOpenAccountLinks", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListOpenAccountLinksResponse ListOpenAccountLinks(ListOpenAccountLinksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOpenAccountLinksWithOptions(request, runtime);
        }

        public async Task<ListOpenAccountLinksResponse> ListOpenAccountLinksAsync(ListOpenAccountLinksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOpenAccountLinksWithOptionsAsync(request, runtime);
        }

        public ListOpenAccountsResponse ListOpenAccountsWithOptions(ListOpenAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListOpenAccountsResponse>(DoRPCRequest("ListOpenAccounts", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListOpenAccountsResponse> ListOpenAccountsWithOptionsAsync(ListOpenAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListOpenAccountsResponse>(await DoRPCRequestAsync("ListOpenAccounts", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListOpenAccountsResponse ListOpenAccounts(ListOpenAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOpenAccountsWithOptions(request, runtime);
        }

        public async Task<ListOpenAccountsResponse> ListOpenAccountsAsync(ListOpenAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOpenAccountsWithOptionsAsync(request, runtime);
        }

        public ListPreChecksResponse ListPreChecksWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListPreChecksResponse>(DoRPCRequest("ListPreChecks", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPreChecksResponse> ListPreChecksWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListPreChecksResponse>(await DoRPCRequestAsync("ListPreChecks", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPreChecksResponse ListPreChecks()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPreChecksWithOptions(runtime);
        }

        public async Task<ListPreChecksResponse> ListPreChecksAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPreChecksWithOptionsAsync(runtime);
        }

        public ListProjectAppsResponse ListProjectAppsWithOptions(ListProjectAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectAppsResponse>(DoRPCRequest("ListProjectApps", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectAppsResponse> ListProjectAppsWithOptionsAsync(ListProjectAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectAppsResponse>(await DoRPCRequestAsync("ListProjectApps", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectAppsResponse ListProjectApps(ListProjectAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectAppsWithOptions(request, runtime);
        }

        public async Task<ListProjectAppsResponse> ListProjectAppsAsync(ListProjectAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectAppsWithOptionsAsync(request, runtime);
        }

        public ListProjectsResponse ListProjectsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListProjectsResponse>(DoRPCRequest("ListProjects", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListProjectsResponse>(await DoRPCRequestAsync("ListProjects", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectsResponse ListProjects()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectsWithOptions(runtime);
        }

        public async Task<ListProjectsResponse> ListProjectsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectsWithOptionsAsync(runtime);
        }

        public ListRpcServicesResponse ListRpcServicesWithOptions(ListRpcServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRpcServicesResponse>(DoRPCRequest("ListRpcServices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRpcServicesResponse> ListRpcServicesWithOptionsAsync(ListRpcServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRpcServicesResponse>(await DoRPCRequestAsync("ListRpcServices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRpcServicesResponse ListRpcServices(ListRpcServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRpcServicesWithOptions(request, runtime);
        }

        public async Task<ListRpcServicesResponse> ListRpcServicesAsync(ListRpcServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRpcServicesWithOptionsAsync(request, runtime);
        }

        public ListSchemaSubscribesResponse ListSchemaSubscribesWithOptions(ListSchemaSubscribesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSchemaSubscribesResponse>(DoRPCRequest("ListSchemaSubscribes", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListSchemaSubscribesResponse> ListSchemaSubscribesWithOptionsAsync(ListSchemaSubscribesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSchemaSubscribesResponse>(await DoRPCRequestAsync("ListSchemaSubscribes", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListSchemaSubscribesResponse ListSchemaSubscribes(ListSchemaSubscribesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSchemaSubscribesWithOptions(request, runtime);
        }

        public async Task<ListSchemaSubscribesResponse> ListSchemaSubscribesAsync(ListSchemaSubscribesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSchemaSubscribesWithOptionsAsync(request, runtime);
        }

        public ListServicesResponse ListServicesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListServicesResponse>(DoRPCRequest("ListServices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListServicesResponse>(await DoRPCRequestAsync("ListServices", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListServicesResponse ListServices()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServicesWithOptions(runtime);
        }

        public async Task<ListServicesResponse> ListServicesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServicesWithOptionsAsync(runtime);
        }

        public ListShadowSchemaDeviceModelsResponse ListShadowSchemaDeviceModelsWithOptions(ListShadowSchemaDeviceModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListShadowSchemaDeviceModelsResponse>(DoRPCRequest("ListShadowSchemaDeviceModels", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListShadowSchemaDeviceModelsResponse> ListShadowSchemaDeviceModelsWithOptionsAsync(ListShadowSchemaDeviceModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListShadowSchemaDeviceModelsResponse>(await DoRPCRequestAsync("ListShadowSchemaDeviceModels", "2018-05-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListShadowSchemaDeviceModelsResponse ListShadowSchemaDeviceModels(ListShadowSchemaDeviceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListShadowSchemaDeviceModelsWithOptions(request, runtime);
        }

        public async Task<ListShadowSchemaDeviceModelsResponse> ListShadowSchemaDeviceModelsAsync(ListShadowSchemaDeviceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListShadowSchemaDeviceModelsWithOptionsAsync(request, runtime);
        }

        public ListShadowSchemasResponse ListShadowSchemasWithOptions(ListShadowSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListShadowSchemasResponse>(DoRPCRequest("ListShadowSchemas", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListShadowSchemasResponse> ListShadowSchemasWithOptionsAsync(ListShadowSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListShadowSchemasResponse>(await DoRPCRequestAsync("ListShadowSchemas", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListShadowSchemasResponse ListShadowSchemas(ListShadowSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListShadowSchemasWithOptions(request, runtime);
        }

        public async Task<ListShadowSchemasResponse> ListShadowSchemasAsync(ListShadowSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListShadowSchemasWithOptionsAsync(request, runtime);
        }

        public ListSupportFeaturesResponse ListSupportFeaturesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListSupportFeaturesResponse>(DoRPCRequest("ListSupportFeatures", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSupportFeaturesResponse> ListSupportFeaturesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListSupportFeaturesResponse>(await DoRPCRequestAsync("ListSupportFeatures", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSupportFeaturesResponse ListSupportFeatures()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSupportFeaturesWithOptions(runtime);
        }

        public async Task<ListSupportFeaturesResponse> ListSupportFeaturesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSupportFeaturesWithOptionsAsync(runtime);
        }

        public ListTriggersResponse ListTriggersWithOptions(ListTriggersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTriggersResponse>(DoRPCRequest("ListTriggers", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTriggersResponse> ListTriggersWithOptionsAsync(ListTriggersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTriggersResponse>(await DoRPCRequestAsync("ListTriggers", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTriggersResponse ListTriggers(ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTriggersWithOptions(request, runtime);
        }

        public async Task<ListTriggersResponse> ListTriggersAsync(ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTriggersWithOptionsAsync(request, runtime);
        }

        public ListUpstreamAppKeyRelationsResponse ListUpstreamAppKeyRelationsWithOptions(ListUpstreamAppKeyRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUpstreamAppKeyRelationsResponse>(DoRPCRequest("ListUpstreamAppKeyRelations", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUpstreamAppKeyRelationsResponse> ListUpstreamAppKeyRelationsWithOptionsAsync(ListUpstreamAppKeyRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUpstreamAppKeyRelationsResponse>(await DoRPCRequestAsync("ListUpstreamAppKeyRelations", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUpstreamAppKeyRelationsResponse ListUpstreamAppKeyRelations(ListUpstreamAppKeyRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUpstreamAppKeyRelationsWithOptions(request, runtime);
        }

        public async Task<ListUpstreamAppKeyRelationsResponse> ListUpstreamAppKeyRelationsAsync(ListUpstreamAppKeyRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUpstreamAppKeyRelationsWithOptionsAsync(request, runtime);
        }

        public ListUpstreamAppServersResponse ListUpstreamAppServersWithOptions(ListUpstreamAppServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUpstreamAppServersResponse>(DoRPCRequest("ListUpstreamAppServers", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUpstreamAppServersResponse> ListUpstreamAppServersWithOptionsAsync(ListUpstreamAppServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUpstreamAppServersResponse>(await DoRPCRequestAsync("ListUpstreamAppServers", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUpstreamAppServersResponse ListUpstreamAppServers(ListUpstreamAppServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUpstreamAppServersWithOptions(request, runtime);
        }

        public async Task<ListUpstreamAppServersResponse> ListUpstreamAppServersAsync(ListUpstreamAppServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUpstreamAppServersWithOptionsAsync(request, runtime);
        }

        public ListVersionDeviceGroupsResponse ListVersionDeviceGroupsWithOptions(ListVersionDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVersionDeviceGroupsResponse>(DoRPCRequest("ListVersionDeviceGroups", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVersionDeviceGroupsResponse> ListVersionDeviceGroupsWithOptionsAsync(ListVersionDeviceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVersionDeviceGroupsResponse>(await DoRPCRequestAsync("ListVersionDeviceGroups", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVersionDeviceGroupsResponse ListVersionDeviceGroups(ListVersionDeviceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVersionDeviceGroupsWithOptions(request, runtime);
        }

        public async Task<ListVersionDeviceGroupsResponse> ListVersionDeviceGroupsAsync(ListVersionDeviceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVersionDeviceGroupsWithOptionsAsync(request, runtime);
        }

        public PublishAppVersionResponse PublishAppVersionWithOptions(PublishAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishAppVersionResponse>(DoRPCRequest("PublishAppVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishAppVersionResponse> PublishAppVersionWithOptionsAsync(PublishAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishAppVersionResponse>(await DoRPCRequestAsync("PublishAppVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishAppVersionResponse PublishAppVersion(PublishAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishAppVersionWithOptions(request, runtime);
        }

        public async Task<PublishAppVersionResponse> PublishAppVersionAsync(PublishAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishAppVersionWithOptionsAsync(request, runtime);
        }

        public PublishMqttMessageResponse PublishMqttMessageWithOptions(PublishMqttMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishMqttMessageResponse>(DoRPCRequest("PublishMqttMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishMqttMessageResponse> PublishMqttMessageWithOptionsAsync(PublishMqttMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishMqttMessageResponse>(await DoRPCRequestAsync("PublishMqttMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishMqttMessageResponse PublishMqttMessage(PublishMqttMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishMqttMessageWithOptions(request, runtime);
        }

        public async Task<PublishMqttMessageResponse> PublishMqttMessageAsync(PublishMqttMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishMqttMessageWithOptionsAsync(request, runtime);
        }

        public PublishOsVersionResponse PublishOsVersionWithOptions(PublishOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishOsVersionResponse>(DoRPCRequest("PublishOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishOsVersionResponse> PublishOsVersionWithOptionsAsync(PublishOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishOsVersionResponse>(await DoRPCRequestAsync("PublishOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishOsVersionResponse PublishOsVersion(PublishOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishOsVersionWithOptions(request, runtime);
        }

        public async Task<PublishOsVersionResponse> PublishOsVersionAsync(PublishOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishOsVersionWithOptionsAsync(request, runtime);
        }

        public PushMessageResponse PushMessageWithOptions(PushMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushMessageResponse>(DoRPCRequest("PushMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushMessageResponse> PushMessageWithOptionsAsync(PushMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushMessageResponse>(await DoRPCRequestAsync("PushMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushMessageResponse PushMessage(PushMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMessageWithOptions(request, runtime);
        }

        public async Task<PushMessageResponse> PushMessageAsync(PushMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMessageWithOptionsAsync(request, runtime);
        }

        public PushVersionMessageResponse PushVersionMessageWithOptions(PushVersionMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushVersionMessageResponse>(DoRPCRequest("PushVersionMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushVersionMessageResponse> PushVersionMessageWithOptionsAsync(PushVersionMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushVersionMessageResponse>(await DoRPCRequestAsync("PushVersionMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushVersionMessageResponse PushVersionMessage(PushVersionMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushVersionMessageWithOptions(request, runtime);
        }

        public async Task<PushVersionMessageResponse> PushVersionMessageAsync(PushVersionMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushVersionMessageWithOptionsAsync(request, runtime);
        }

        public QueryPrepublishPassedDeviceCountResponse QueryPrepublishPassedDeviceCountWithOptions(QueryPrepublishPassedDeviceCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPrepublishPassedDeviceCountResponse>(DoRPCRequest("QueryPrepublishPassedDeviceCount", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPrepublishPassedDeviceCountResponse> QueryPrepublishPassedDeviceCountWithOptionsAsync(QueryPrepublishPassedDeviceCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPrepublishPassedDeviceCountResponse>(await DoRPCRequestAsync("QueryPrepublishPassedDeviceCount", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPrepublishPassedDeviceCountResponse QueryPrepublishPassedDeviceCount(QueryPrepublishPassedDeviceCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPrepublishPassedDeviceCountWithOptions(request, runtime);
        }

        public async Task<QueryPrepublishPassedDeviceCountResponse> QueryPrepublishPassedDeviceCountAsync(QueryPrepublishPassedDeviceCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPrepublishPassedDeviceCountWithOptionsAsync(request, runtime);
        }

        public SubmitAssistReportResponse SubmitAssistReportWithOptions(SubmitAssistReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAssistReportResponse>(DoRPCRequest("SubmitAssistReport", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitAssistReportResponse> SubmitAssistReportWithOptionsAsync(SubmitAssistReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAssistReportResponse>(await DoRPCRequestAsync("SubmitAssistReport", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitAssistReportResponse SubmitAssistReport(SubmitAssistReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAssistReportWithOptions(request, runtime);
        }

        public async Task<SubmitAssistReportResponse> SubmitAssistReportAsync(SubmitAssistReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAssistReportWithOptionsAsync(request, runtime);
        }

        public UpdateApiGatewayAppStatusResponse UpdateApiGatewayAppStatusWithOptions(UpdateApiGatewayAppStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateApiGatewayAppStatusResponse>(DoRPCRequest("UpdateApiGatewayAppStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateApiGatewayAppStatusResponse> UpdateApiGatewayAppStatusWithOptionsAsync(UpdateApiGatewayAppStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateApiGatewayAppStatusResponse>(await DoRPCRequestAsync("UpdateApiGatewayAppStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateApiGatewayAppStatusResponse UpdateApiGatewayAppStatus(UpdateApiGatewayAppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApiGatewayAppStatusWithOptions(request, runtime);
        }

        public async Task<UpdateApiGatewayAppStatusResponse> UpdateApiGatewayAppStatusAsync(UpdateApiGatewayAppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApiGatewayAppStatusWithOptionsAsync(request, runtime);
        }

        public UpdateAppBlackWhiteVersionsResponse UpdateAppBlackWhiteVersionsWithOptions(UpdateAppBlackWhiteVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppBlackWhiteVersionsResponse>(DoRPCRequest("UpdateAppBlackWhiteVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppBlackWhiteVersionsResponse> UpdateAppBlackWhiteVersionsWithOptionsAsync(UpdateAppBlackWhiteVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppBlackWhiteVersionsResponse>(await DoRPCRequestAsync("UpdateAppBlackWhiteVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppBlackWhiteVersionsResponse UpdateAppBlackWhiteVersions(UpdateAppBlackWhiteVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppBlackWhiteVersionsWithOptions(request, runtime);
        }

        public async Task<UpdateAppBlackWhiteVersionsResponse> UpdateAppBlackWhiteVersionsAsync(UpdateAppBlackWhiteVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppBlackWhiteVersionsWithOptionsAsync(request, runtime);
        }

        public UpdateAppVersionResponse UpdateAppVersionWithOptions(UpdateAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppVersionResponse>(DoRPCRequest("UpdateAppVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppVersionResponse> UpdateAppVersionWithOptionsAsync(UpdateAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppVersionResponse>(await DoRPCRequestAsync("UpdateAppVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppVersionResponse UpdateAppVersion(UpdateAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppVersionWithOptions(request, runtime);
        }

        public async Task<UpdateAppVersionResponse> UpdateAppVersionAsync(UpdateAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppVersionWithOptionsAsync(request, runtime);
        }

        public UpdateAppVersionReleaseNoteResponse UpdateAppVersionReleaseNoteWithOptions(UpdateAppVersionReleaseNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppVersionReleaseNoteResponse>(DoRPCRequest("UpdateAppVersionReleaseNote", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppVersionReleaseNoteResponse> UpdateAppVersionReleaseNoteWithOptionsAsync(UpdateAppVersionReleaseNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppVersionReleaseNoteResponse>(await DoRPCRequestAsync("UpdateAppVersionReleaseNote", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppVersionReleaseNoteResponse UpdateAppVersionReleaseNote(UpdateAppVersionReleaseNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppVersionReleaseNoteWithOptions(request, runtime);
        }

        public async Task<UpdateAppVersionReleaseNoteResponse> UpdateAppVersionReleaseNoteAsync(UpdateAppVersionReleaseNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppVersionReleaseNoteWithOptionsAsync(request, runtime);
        }

        public UpdateAppVersionRemarkResponse UpdateAppVersionRemarkWithOptions(UpdateAppVersionRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppVersionRemarkResponse>(DoRPCRequest("UpdateAppVersionRemark", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppVersionRemarkResponse> UpdateAppVersionRemarkWithOptionsAsync(UpdateAppVersionRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppVersionRemarkResponse>(await DoRPCRequestAsync("UpdateAppVersionRemark", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppVersionRemarkResponse UpdateAppVersionRemark(UpdateAppVersionRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppVersionRemarkWithOptions(request, runtime);
        }

        public async Task<UpdateAppVersionRemarkResponse> UpdateAppVersionRemarkAsync(UpdateAppVersionRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppVersionRemarkWithOptionsAsync(request, runtime);
        }

        public UpdateAppVersionStatusResponse UpdateAppVersionStatusWithOptions(UpdateAppVersionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppVersionStatusResponse>(DoRPCRequest("UpdateAppVersionStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppVersionStatusResponse> UpdateAppVersionStatusWithOptionsAsync(UpdateAppVersionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppVersionStatusResponse>(await DoRPCRequestAsync("UpdateAppVersionStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppVersionStatusResponse UpdateAppVersionStatus(UpdateAppVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppVersionStatusWithOptions(request, runtime);
        }

        public async Task<UpdateAppVersionStatusResponse> UpdateAppVersionStatusAsync(UpdateAppVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppVersionStatusWithOptionsAsync(request, runtime);
        }

        public UpdateCustomizedFilterResponse UpdateCustomizedFilterWithOptions(UpdateCustomizedFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCustomizedFilterResponse>(DoRPCRequest("UpdateCustomizedFilter", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCustomizedFilterResponse> UpdateCustomizedFilterWithOptionsAsync(UpdateCustomizedFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCustomizedFilterResponse>(await DoRPCRequestAsync("UpdateCustomizedFilter", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCustomizedFilterResponse UpdateCustomizedFilter(UpdateCustomizedFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomizedFilterWithOptions(request, runtime);
        }

        public async Task<UpdateCustomizedFilterResponse> UpdateCustomizedFilterAsync(UpdateCustomizedFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomizedFilterWithOptionsAsync(request, runtime);
        }

        public UpdateDeviceModelResponse UpdateDeviceModelWithOptions(UpdateDeviceModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceModelResponse>(DoRPCRequest("UpdateDeviceModel", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDeviceModelResponse> UpdateDeviceModelWithOptionsAsync(UpdateDeviceModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceModelResponse>(await DoRPCRequestAsync("UpdateDeviceModel", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDeviceModelResponse UpdateDeviceModel(UpdateDeviceModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceModelWithOptions(request, runtime);
        }

        public async Task<UpdateDeviceModelResponse> UpdateDeviceModelAsync(UpdateDeviceModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceModelWithOptionsAsync(request, runtime);
        }

        public UpdateNamespaceDataResponse UpdateNamespaceDataWithOptions(UpdateNamespaceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNamespaceDataResponse>(DoRPCRequest("UpdateNamespaceData", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateNamespaceDataResponse> UpdateNamespaceDataWithOptionsAsync(UpdateNamespaceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNamespaceDataResponse>(await DoRPCRequestAsync("UpdateNamespaceData", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateNamespaceDataResponse UpdateNamespaceData(UpdateNamespaceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNamespaceDataWithOptions(request, runtime);
        }

        public async Task<UpdateNamespaceDataResponse> UpdateNamespaceDataAsync(UpdateNamespaceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNamespaceDataWithOptionsAsync(request, runtime);
        }

        public UpdateOsBlackWhiteVersionsResponse UpdateOsBlackWhiteVersionsWithOptions(UpdateOsBlackWhiteVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsBlackWhiteVersionsResponse>(DoRPCRequest("UpdateOsBlackWhiteVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateOsBlackWhiteVersionsResponse> UpdateOsBlackWhiteVersionsWithOptionsAsync(UpdateOsBlackWhiteVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsBlackWhiteVersionsResponse>(await DoRPCRequestAsync("UpdateOsBlackWhiteVersions", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateOsBlackWhiteVersionsResponse UpdateOsBlackWhiteVersions(UpdateOsBlackWhiteVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOsBlackWhiteVersionsWithOptions(request, runtime);
        }

        public async Task<UpdateOsBlackWhiteVersionsResponse> UpdateOsBlackWhiteVersionsAsync(UpdateOsBlackWhiteVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOsBlackWhiteVersionsWithOptionsAsync(request, runtime);
        }

        public UpdateOsVersionResponse UpdateOsVersionWithOptions(UpdateOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsVersionResponse>(DoRPCRequest("UpdateOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateOsVersionResponse> UpdateOsVersionWithOptionsAsync(UpdateOsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsVersionResponse>(await DoRPCRequestAsync("UpdateOsVersion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateOsVersionResponse UpdateOsVersion(UpdateOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOsVersionWithOptions(request, runtime);
        }

        public async Task<UpdateOsVersionResponse> UpdateOsVersionAsync(UpdateOsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOsVersionWithOptionsAsync(request, runtime);
        }

        public UpdateOsVersionReleaseNoteResponse UpdateOsVersionReleaseNoteWithOptions(UpdateOsVersionReleaseNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsVersionReleaseNoteResponse>(DoRPCRequest("UpdateOsVersionReleaseNote", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateOsVersionReleaseNoteResponse> UpdateOsVersionReleaseNoteWithOptionsAsync(UpdateOsVersionReleaseNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsVersionReleaseNoteResponse>(await DoRPCRequestAsync("UpdateOsVersionReleaseNote", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateOsVersionReleaseNoteResponse UpdateOsVersionReleaseNote(UpdateOsVersionReleaseNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOsVersionReleaseNoteWithOptions(request, runtime);
        }

        public async Task<UpdateOsVersionReleaseNoteResponse> UpdateOsVersionReleaseNoteAsync(UpdateOsVersionReleaseNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOsVersionReleaseNoteWithOptionsAsync(request, runtime);
        }

        public UpdateOsVersionRemarkResponse UpdateOsVersionRemarkWithOptions(UpdateOsVersionRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsVersionRemarkResponse>(DoRPCRequest("UpdateOsVersionRemark", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateOsVersionRemarkResponse> UpdateOsVersionRemarkWithOptionsAsync(UpdateOsVersionRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsVersionRemarkResponse>(await DoRPCRequestAsync("UpdateOsVersionRemark", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateOsVersionRemarkResponse UpdateOsVersionRemark(UpdateOsVersionRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOsVersionRemarkWithOptions(request, runtime);
        }

        public async Task<UpdateOsVersionRemarkResponse> UpdateOsVersionRemarkAsync(UpdateOsVersionRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOsVersionRemarkWithOptionsAsync(request, runtime);
        }

        public UpdateOsVersionStatusResponse UpdateOsVersionStatusWithOptions(UpdateOsVersionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsVersionStatusResponse>(DoRPCRequest("UpdateOsVersionStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateOsVersionStatusResponse> UpdateOsVersionStatusWithOptionsAsync(UpdateOsVersionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateOsVersionStatusResponse>(await DoRPCRequestAsync("UpdateOsVersionStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateOsVersionStatusResponse UpdateOsVersionStatus(UpdateOsVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOsVersionStatusWithOptions(request, runtime);
        }

        public async Task<UpdateOsVersionStatusResponse> UpdateOsVersionStatusAsync(UpdateOsVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOsVersionStatusWithOptionsAsync(request, runtime);
        }

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(DoRPCRequest("UpdateProject", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await DoRPCRequestAsync("UpdateProject", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectWithOptions(request, runtime);
        }

        public async Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectWithOptionsAsync(request, runtime);
        }

        public UpdateSchemaSubscribeResponse UpdateSchemaSubscribeWithOptions(UpdateSchemaSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSchemaSubscribeResponse>(DoRPCRequest("UpdateSchemaSubscribe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSchemaSubscribeResponse> UpdateSchemaSubscribeWithOptionsAsync(UpdateSchemaSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSchemaSubscribeResponse>(await DoRPCRequestAsync("UpdateSchemaSubscribe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSchemaSubscribeResponse UpdateSchemaSubscribe(UpdateSchemaSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSchemaSubscribeWithOptions(request, runtime);
        }

        public async Task<UpdateSchemaSubscribeResponse> UpdateSchemaSubscribeAsync(UpdateSchemaSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSchemaSubscribeWithOptionsAsync(request, runtime);
        }

        public UpdateShadowSchemaResponse UpdateShadowSchemaWithOptions(UpdateShadowSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateShadowSchemaResponse>(DoRPCRequest("UpdateShadowSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateShadowSchemaResponse> UpdateShadowSchemaWithOptionsAsync(UpdateShadowSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateShadowSchemaResponse>(await DoRPCRequestAsync("UpdateShadowSchema", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateShadowSchemaResponse UpdateShadowSchema(UpdateShadowSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateShadowSchemaWithOptions(request, runtime);
        }

        public async Task<UpdateShadowSchemaResponse> UpdateShadowSchemaAsync(UpdateShadowSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateShadowSchemaWithOptionsAsync(request, runtime);
        }

        public UpdateTriggerResponse UpdateTriggerWithOptions(UpdateTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(DoRPCRequest("UpdateTrigger", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerWithOptionsAsync(UpdateTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(await DoRPCRequestAsync("UpdateTrigger", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTriggerWithOptions(request, runtime);
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTriggerWithOptionsAsync(request, runtime);
        }

        public UpdateUpstreamAppServerResponse UpdateUpstreamAppServerWithOptions(UpdateUpstreamAppServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUpstreamAppServerResponse>(DoRPCRequest("UpdateUpstreamAppServer", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUpstreamAppServerResponse> UpdateUpstreamAppServerWithOptionsAsync(UpdateUpstreamAppServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUpstreamAppServerResponse>(await DoRPCRequestAsync("UpdateUpstreamAppServer", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateUpstreamAppServerResponse UpdateUpstreamAppServer(UpdateUpstreamAppServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUpstreamAppServerWithOptions(request, runtime);
        }

        public async Task<UpdateUpstreamAppServerResponse> UpdateUpstreamAppServerAsync(UpdateUpstreamAppServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUpstreamAppServerWithOptionsAsync(request, runtime);
        }

        public UpdateVersionDeviceGroupResponse UpdateVersionDeviceGroupWithOptions(UpdateVersionDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVersionDeviceGroupResponse>(DoRPCRequest("UpdateVersionDeviceGroup", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateVersionDeviceGroupResponse> UpdateVersionDeviceGroupWithOptionsAsync(UpdateVersionDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVersionDeviceGroupResponse>(await DoRPCRequestAsync("UpdateVersionDeviceGroup", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateVersionDeviceGroupResponse UpdateVersionDeviceGroup(UpdateVersionDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVersionDeviceGroupWithOptions(request, runtime);
        }

        public async Task<UpdateVersionDeviceGroupResponse> UpdateVersionDeviceGroupAsync(UpdateVersionDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVersionDeviceGroupWithOptionsAsync(request, runtime);
        }

        public UpdateVersionPrepublishActiveStatusResponse UpdateVersionPrepublishActiveStatusWithOptions(UpdateVersionPrepublishActiveStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVersionPrepublishActiveStatusResponse>(DoRPCRequest("UpdateVersionPrepublishActiveStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateVersionPrepublishActiveStatusResponse> UpdateVersionPrepublishActiveStatusWithOptionsAsync(UpdateVersionPrepublishActiveStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVersionPrepublishActiveStatusResponse>(await DoRPCRequestAsync("UpdateVersionPrepublishActiveStatus", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateVersionPrepublishActiveStatusResponse UpdateVersionPrepublishActiveStatus(UpdateVersionPrepublishActiveStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVersionPrepublishActiveStatusWithOptions(request, runtime);
        }

        public async Task<UpdateVersionPrepublishActiveStatusResponse> UpdateVersionPrepublishActiveStatusAsync(UpdateVersionPrepublishActiveStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVersionPrepublishActiveStatusWithOptionsAsync(request, runtime);
        }

    }
}
