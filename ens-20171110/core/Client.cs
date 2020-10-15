// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ens20171110.Models;

namespace AlibabaCloud.SDK.Ens20171110
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ens", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public DescribeEpnBandwitdhByInternetChargeTypeResponse DescribeEpnBandwitdhByInternetChargeTypeWithOptions(DescribeEpnBandwitdhByInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnBandwitdhByInternetChargeTypeResponse>(DoRequest("DescribeEpnBandwitdhByInternetChargeType", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEpnBandwitdhByInternetChargeTypeResponse> DescribeEpnBandwitdhByInternetChargeTypeWithOptionsAsync(DescribeEpnBandwitdhByInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnBandwitdhByInternetChargeTypeResponse>(await DoRequestAsync("DescribeEpnBandwitdhByInternetChargeType", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEpnBandwitdhByInternetChargeTypeResponse DescribeEpnBandwitdhByInternetChargeType(DescribeEpnBandwitdhByInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnBandwitdhByInternetChargeTypeWithOptions(request, runtime);
        }

        public async Task<DescribeEpnBandwitdhByInternetChargeTypeResponse> DescribeEpnBandwitdhByInternetChargeTypeAsync(DescribeEpnBandwitdhByInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnBandwitdhByInternetChargeTypeWithOptionsAsync(request, runtime);
        }

        public DescribeEpnBandWidthDataResponse DescribeEpnBandWidthDataWithOptions(DescribeEpnBandWidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnBandWidthDataResponse>(DoRequest("DescribeEpnBandWidthData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEpnBandWidthDataResponse> DescribeEpnBandWidthDataWithOptionsAsync(DescribeEpnBandWidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnBandWidthDataResponse>(await DoRequestAsync("DescribeEpnBandWidthData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEpnBandWidthDataResponse DescribeEpnBandWidthData(DescribeEpnBandWidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnBandWidthDataWithOptions(request, runtime);
        }

        public async Task<DescribeEpnBandWidthDataResponse> DescribeEpnBandWidthDataAsync(DescribeEpnBandWidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnBandWidthDataWithOptionsAsync(request, runtime);
        }

        public DescribeEpnMeasurementDataResponse DescribeEpnMeasurementDataWithOptions(DescribeEpnMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnMeasurementDataResponse>(DoRequest("DescribeEpnMeasurementData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEpnMeasurementDataResponse> DescribeEpnMeasurementDataWithOptionsAsync(DescribeEpnMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnMeasurementDataResponse>(await DoRequestAsync("DescribeEpnMeasurementData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEpnMeasurementDataResponse DescribeEpnMeasurementData(DescribeEpnMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnMeasurementDataWithOptions(request, runtime);
        }

        public async Task<DescribeEpnMeasurementDataResponse> DescribeEpnMeasurementDataAsync(DescribeEpnMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnMeasurementDataWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkInterfacesResponse DescribeNetworkInterfacesWithOptions(DescribeNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeNetworkInterfacesResponse>(DoRequest("DescribeNetworkInterfaces", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesWithOptionsAsync(DescribeNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeNetworkInterfacesResponse>(await DoRequestAsync("DescribeNetworkInterfaces", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkInterfacesWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkInterfacesWithOptionsAsync(request, runtime);
        }

        public CreateEPInstanceResponse CreateEPInstanceWithOptions(CreateEPInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEPInstanceResponse>(DoRequest("CreateEPInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEPInstanceResponse> CreateEPInstanceWithOptionsAsync(CreateEPInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEPInstanceResponse>(await DoRequestAsync("CreateEPInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateEPInstanceResponse CreateEPInstance(CreateEPInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEPInstanceWithOptions(request, runtime);
        }

        public async Task<CreateEPInstanceResponse> CreateEPInstanceAsync(CreateEPInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEPInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyImageSharePermissionResponse ModifyImageSharePermissionWithOptions(ModifyImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyImageSharePermissionResponse>(DoRequest("ModifyImageSharePermission", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyImageSharePermissionResponse> ModifyImageSharePermissionWithOptionsAsync(ModifyImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyImageSharePermissionResponse>(await DoRequestAsync("ModifyImageSharePermission", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ModifyImageSharePermissionResponse ModifyImageSharePermission(ModifyImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageSharePermissionWithOptions(request, runtime);
        }

        public async Task<ModifyImageSharePermissionResponse> ModifyImageSharePermissionAsync(ModifyImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageSharePermissionWithOptionsAsync(request, runtime);
        }

        public AddNetworkInterfaceToInstanceResponse AddNetworkInterfaceToInstanceWithOptions(AddNetworkInterfaceToInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddNetworkInterfaceToInstanceResponse>(DoRequest("AddNetworkInterfaceToInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddNetworkInterfaceToInstanceResponse> AddNetworkInterfaceToInstanceWithOptionsAsync(AddNetworkInterfaceToInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddNetworkInterfaceToInstanceResponse>(await DoRequestAsync("AddNetworkInterfaceToInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public AddNetworkInterfaceToInstanceResponse AddNetworkInterfaceToInstance(AddNetworkInterfaceToInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddNetworkInterfaceToInstanceWithOptions(request, runtime);
        }

        public async Task<AddNetworkInterfaceToInstanceResponse> AddNetworkInterfaceToInstanceAsync(AddNetworkInterfaceToInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddNetworkInterfaceToInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeImageSharePermissionResponse DescribeImageSharePermissionWithOptions(DescribeImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImageSharePermissionResponse>(DoRequest("DescribeImageSharePermission", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeImageSharePermissionResponse> DescribeImageSharePermissionWithOptionsAsync(DescribeImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImageSharePermissionResponse>(await DoRequestAsync("DescribeImageSharePermission", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeImageSharePermissionResponse DescribeImageSharePermission(DescribeImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageSharePermissionWithOptions(request, runtime);
        }

        public async Task<DescribeImageSharePermissionResponse> DescribeImageSharePermissionAsync(DescribeImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageSharePermissionWithOptionsAsync(request, runtime);
        }

        public RemoveVSwitchesFromEpnInstanceResponse RemoveVSwitchesFromEpnInstanceWithOptions(RemoveVSwitchesFromEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveVSwitchesFromEpnInstanceResponse>(DoRequest("RemoveVSwitchesFromEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RemoveVSwitchesFromEpnInstanceResponse> RemoveVSwitchesFromEpnInstanceWithOptionsAsync(RemoveVSwitchesFromEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveVSwitchesFromEpnInstanceResponse>(await DoRequestAsync("RemoveVSwitchesFromEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public RemoveVSwitchesFromEpnInstanceResponse RemoveVSwitchesFromEpnInstance(RemoveVSwitchesFromEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVSwitchesFromEpnInstanceWithOptions(request, runtime);
        }

        public async Task<RemoveVSwitchesFromEpnInstanceResponse> RemoveVSwitchesFromEpnInstanceAsync(RemoveVSwitchesFromEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveVSwitchesFromEpnInstanceWithOptionsAsync(request, runtime);
        }

        public DistApplicationDataResponse DistApplicationDataWithOptions(DistApplicationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DistApplicationDataResponse>(DoRequest("DistApplicationData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DistApplicationDataResponse> DistApplicationDataWithOptionsAsync(DistApplicationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DistApplicationDataResponse>(await DoRequestAsync("DistApplicationData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DistApplicationDataResponse DistApplicationData(DistApplicationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DistApplicationDataWithOptions(request, runtime);
        }

        public async Task<DistApplicationDataResponse> DistApplicationDataAsync(DistApplicationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DistApplicationDataWithOptionsAsync(request, runtime);
        }

        public JoinVSwitchesToEpnInstanceResponse JoinVSwitchesToEpnInstanceWithOptions(JoinVSwitchesToEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<JoinVSwitchesToEpnInstanceResponse>(DoRequest("JoinVSwitchesToEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<JoinVSwitchesToEpnInstanceResponse> JoinVSwitchesToEpnInstanceWithOptionsAsync(JoinVSwitchesToEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<JoinVSwitchesToEpnInstanceResponse>(await DoRequestAsync("JoinVSwitchesToEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public JoinVSwitchesToEpnInstanceResponse JoinVSwitchesToEpnInstance(JoinVSwitchesToEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinVSwitchesToEpnInstanceWithOptions(request, runtime);
        }

        public async Task<JoinVSwitchesToEpnInstanceResponse> JoinVSwitchesToEpnInstanceAsync(JoinVSwitchesToEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinVSwitchesToEpnInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeApplicationResponse DescribeApplicationWithOptions(DescribeApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeApplicationResponse>(DoRequest("DescribeApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeApplicationResponse> DescribeApplicationWithOptionsAsync(DescribeApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeApplicationResponse>(await DoRequestAsync("DescribeApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApplicationWithOptions(request, runtime);
        }

        public async Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApplicationWithOptionsAsync(request, runtime);
        }

        public DescribeDataPushResultResponse DescribeDataPushResultWithOptions(DescribeDataPushResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDataPushResultResponse>(DoRequest("DescribeDataPushResult", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDataPushResultResponse> DescribeDataPushResultWithOptionsAsync(DescribeDataPushResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDataPushResultResponse>(await DoRequestAsync("DescribeDataPushResult", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDataPushResultResponse DescribeDataPushResult(DescribeDataPushResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataPushResultWithOptions(request, runtime);
        }

        public async Task<DescribeDataPushResultResponse> DescribeDataPushResultAsync(DescribeDataPushResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataPushResultWithOptionsAsync(request, runtime);
        }

        public PushApplicationDataResponse PushApplicationDataWithOptions(PushApplicationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PushApplicationDataResponse>(DoRequest("PushApplicationData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PushApplicationDataResponse> PushApplicationDataWithOptionsAsync(PushApplicationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PushApplicationDataResponse>(await DoRequestAsync("PushApplicationData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public PushApplicationDataResponse PushApplicationData(PushApplicationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushApplicationDataWithOptions(request, runtime);
        }

        public async Task<PushApplicationDataResponse> PushApplicationDataAsync(PushApplicationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushApplicationDataWithOptionsAsync(request, runtime);
        }

        public UpgradeApplicationResponse UpgradeApplicationWithOptions(UpgradeApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpgradeApplicationResponse>(DoRequest("UpgradeApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpgradeApplicationResponse> UpgradeApplicationWithOptionsAsync(UpgradeApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpgradeApplicationResponse>(await DoRequestAsync("UpgradeApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public UpgradeApplicationResponse UpgradeApplication(UpgradeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeApplicationWithOptions(request, runtime);
        }

        public async Task<UpgradeApplicationResponse> UpgradeApplicationAsync(UpgradeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeApplicationWithOptionsAsync(request, runtime);
        }

        public RescaleApplicationResponse RescaleApplicationWithOptions(RescaleApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RescaleApplicationResponse>(DoRequest("RescaleApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RescaleApplicationResponse> RescaleApplicationWithOptionsAsync(RescaleApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RescaleApplicationResponse>(await DoRequestAsync("RescaleApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public RescaleApplicationResponse RescaleApplication(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RescaleApplicationWithOptions(request, runtime);
        }

        public async Task<RescaleApplicationResponse> RescaleApplicationAsync(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RescaleApplicationWithOptionsAsync(request, runtime);
        }

        public DeleteEpnInstanceResponse DeleteEpnInstanceWithOptions(DeleteEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEpnInstanceResponse>(DoRequest("DeleteEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteEpnInstanceResponse> DeleteEpnInstanceWithOptionsAsync(DeleteEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEpnInstanceResponse>(await DoRequestAsync("DeleteEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DeleteEpnInstanceResponse DeleteEpnInstance(DeleteEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEpnInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteEpnInstanceResponse> DeleteEpnInstanceAsync(DeleteEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEpnInstanceWithOptionsAsync(request, runtime);
        }

        public ListApplicationsResponse ListApplicationsWithOptions(ListApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListApplicationsResponse>(DoRequest("ListApplications", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListApplicationsResponse> ListApplicationsWithOptionsAsync(ListApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListApplicationsResponse>(await DoRequestAsync("ListApplications", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsWithOptions(request, runtime);
        }

        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsWithOptionsAsync(request, runtime);
        }

        public DescribeServcieScheduleResponse DescribeServcieScheduleWithOptions(DescribeServcieScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServcieScheduleResponse>(DoRequest("DescribeServcieSchedule", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeServcieScheduleResponse> DescribeServcieScheduleWithOptionsAsync(DescribeServcieScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServcieScheduleResponse>(await DoRequestAsync("DescribeServcieSchedule", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeServcieScheduleResponse DescribeServcieSchedule(DescribeServcieScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServcieScheduleWithOptions(request, runtime);
        }

        public async Task<DescribeServcieScheduleResponse> DescribeServcieScheduleAsync(DescribeServcieScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServcieScheduleWithOptionsAsync(request, runtime);
        }

        public DeleteApplicationResponse DeleteApplicationWithOptions(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteApplicationResponse>(DoRequest("DeleteApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationWithOptionsAsync(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteApplicationResponse>(await DoRequestAsync("DeleteApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationWithOptions(request, runtime);
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationWithOptionsAsync(request, runtime);
        }

        public ModifyEpnInstanceResponse ModifyEpnInstanceWithOptions(ModifyEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyEpnInstanceResponse>(DoRequest("ModifyEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyEpnInstanceResponse> ModifyEpnInstanceWithOptionsAsync(ModifyEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyEpnInstanceResponse>(await DoRequestAsync("ModifyEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ModifyEpnInstanceResponse ModifyEpnInstance(ModifyEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEpnInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyEpnInstanceResponse> ModifyEpnInstanceAsync(ModifyEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEpnInstanceWithOptionsAsync(request, runtime);
        }

        public RollbackApplicationResponse RollbackApplicationWithOptions(RollbackApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RollbackApplicationResponse>(DoRequest("RollbackApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RollbackApplicationResponse> RollbackApplicationWithOptionsAsync(RollbackApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RollbackApplicationResponse>(await DoRequestAsync("RollbackApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public RollbackApplicationResponse RollbackApplication(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackApplicationWithOptions(request, runtime);
        }

        public async Task<RollbackApplicationResponse> RollbackApplicationAsync(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackApplicationWithOptionsAsync(request, runtime);
        }

        public DescribeEpnInstanceAttributeResponse DescribeEpnInstanceAttributeWithOptions(DescribeEpnInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnInstanceAttributeResponse>(DoRequest("DescribeEpnInstanceAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEpnInstanceAttributeResponse> DescribeEpnInstanceAttributeWithOptionsAsync(DescribeEpnInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnInstanceAttributeResponse>(await DoRequestAsync("DescribeEpnInstanceAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEpnInstanceAttributeResponse DescribeEpnInstanceAttribute(DescribeEpnInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeEpnInstanceAttributeResponse> DescribeEpnInstanceAttributeAsync(DescribeEpnInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public RunServiceScheduleResponse RunServiceScheduleWithOptions(RunServiceScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunServiceScheduleResponse>(DoRequest("RunServiceSchedule", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RunServiceScheduleResponse> RunServiceScheduleWithOptionsAsync(RunServiceScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunServiceScheduleResponse>(await DoRequestAsync("RunServiceSchedule", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public RunServiceScheduleResponse RunServiceSchedule(RunServiceScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunServiceScheduleWithOptions(request, runtime);
        }

        public async Task<RunServiceScheduleResponse> RunServiceScheduleAsync(RunServiceScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunServiceScheduleWithOptionsAsync(request, runtime);
        }

        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateApplicationResponse>(DoRequest("CreateApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateApplicationResponse>(await DoRequestAsync("CreateApplication", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationWithOptions(request, runtime);
        }

        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationWithOptionsAsync(request, runtime);
        }

        public CreateEpnInstanceResponse CreateEpnInstanceWithOptions(CreateEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEpnInstanceResponse>(DoRequest("CreateEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEpnInstanceResponse> CreateEpnInstanceWithOptionsAsync(CreateEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEpnInstanceResponse>(await DoRequestAsync("CreateEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateEpnInstanceResponse CreateEpnInstance(CreateEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEpnInstanceWithOptions(request, runtime);
        }

        public async Task<CreateEpnInstanceResponse> CreateEpnInstanceAsync(CreateEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEpnInstanceWithOptionsAsync(request, runtime);
        }

        public StopEpnInstanceResponse StopEpnInstanceWithOptions(StopEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopEpnInstanceResponse>(DoRequest("StopEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopEpnInstanceResponse> StopEpnInstanceWithOptionsAsync(StopEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopEpnInstanceResponse>(await DoRequestAsync("StopEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public StopEpnInstanceResponse StopEpnInstance(StopEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopEpnInstanceWithOptions(request, runtime);
        }

        public async Task<StopEpnInstanceResponse> StopEpnInstanceAsync(StopEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopEpnInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDataDistResultResponse DescribeDataDistResultWithOptions(DescribeDataDistResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDataDistResultResponse>(DoRequest("DescribeDataDistResult", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDataDistResultResponse> DescribeDataDistResultWithOptionsAsync(DescribeDataDistResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDataDistResultResponse>(await DoRequestAsync("DescribeDataDistResult", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDataDistResultResponse DescribeDataDistResult(DescribeDataDistResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataDistResultWithOptions(request, runtime);
        }

        public async Task<DescribeDataDistResultResponse> DescribeDataDistResultAsync(DescribeDataDistResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataDistResultWithOptionsAsync(request, runtime);
        }

        public DescribeEpnInstancesResponse DescribeEpnInstancesWithOptions(DescribeEpnInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnInstancesResponse>(DoRequest("DescribeEpnInstances", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEpnInstancesResponse> DescribeEpnInstancesWithOptionsAsync(DescribeEpnInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEpnInstancesResponse>(await DoRequestAsync("DescribeEpnInstances", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEpnInstancesResponse DescribeEpnInstances(DescribeEpnInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeEpnInstancesResponse> DescribeEpnInstancesAsync(DescribeEpnInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnInstancesWithOptionsAsync(request, runtime);
        }

        public RemovePublicIpsFromEpnInstanceResponse RemovePublicIpsFromEpnInstanceWithOptions(RemovePublicIpsFromEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemovePublicIpsFromEpnInstanceResponse>(DoRequest("RemovePublicIpsFromEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RemovePublicIpsFromEpnInstanceResponse> RemovePublicIpsFromEpnInstanceWithOptionsAsync(RemovePublicIpsFromEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemovePublicIpsFromEpnInstanceResponse>(await DoRequestAsync("RemovePublicIpsFromEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public RemovePublicIpsFromEpnInstanceResponse RemovePublicIpsFromEpnInstance(RemovePublicIpsFromEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePublicIpsFromEpnInstanceWithOptions(request, runtime);
        }

        public async Task<RemovePublicIpsFromEpnInstanceResponse> RemovePublicIpsFromEpnInstanceAsync(RemovePublicIpsFromEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePublicIpsFromEpnInstanceWithOptionsAsync(request, runtime);
        }

        public JoinPublicIpsToEpnInstanceResponse JoinPublicIpsToEpnInstanceWithOptions(JoinPublicIpsToEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<JoinPublicIpsToEpnInstanceResponse>(DoRequest("JoinPublicIpsToEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<JoinPublicIpsToEpnInstanceResponse> JoinPublicIpsToEpnInstanceWithOptionsAsync(JoinPublicIpsToEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<JoinPublicIpsToEpnInstanceResponse>(await DoRequestAsync("JoinPublicIpsToEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public JoinPublicIpsToEpnInstanceResponse JoinPublicIpsToEpnInstance(JoinPublicIpsToEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinPublicIpsToEpnInstanceWithOptions(request, runtime);
        }

        public async Task<JoinPublicIpsToEpnInstanceResponse> JoinPublicIpsToEpnInstanceAsync(JoinPublicIpsToEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinPublicIpsToEpnInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeApplicationResourceSummaryResponse DescribeApplicationResourceSummaryWithOptions(DescribeApplicationResourceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeApplicationResourceSummaryResponse>(DoRequest("DescribeApplicationResourceSummary", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeApplicationResourceSummaryResponse> DescribeApplicationResourceSummaryWithOptionsAsync(DescribeApplicationResourceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeApplicationResourceSummaryResponse>(await DoRequestAsync("DescribeApplicationResourceSummary", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeApplicationResourceSummaryResponse DescribeApplicationResourceSummary(DescribeApplicationResourceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApplicationResourceSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeApplicationResourceSummaryResponse> DescribeApplicationResourceSummaryAsync(DescribeApplicationResourceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApplicationResourceSummaryWithOptionsAsync(request, runtime);
        }

        public StartEpnInstanceResponse StartEpnInstanceWithOptions(StartEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartEpnInstanceResponse>(DoRequest("StartEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartEpnInstanceResponse> StartEpnInstanceWithOptionsAsync(StartEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartEpnInstanceResponse>(await DoRequestAsync("StartEpnInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public StartEpnInstanceResponse StartEpnInstance(StartEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartEpnInstanceWithOptions(request, runtime);
        }

        public async Task<StartEpnInstanceResponse> StartEpnInstanceAsync(StartEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartEpnInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeExportImageInfoResponse DescribeExportImageInfoWithOptions(DescribeExportImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeExportImageInfoResponse>(DoRequest("DescribeExportImageInfo", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeExportImageInfoResponse> DescribeExportImageInfoWithOptionsAsync(DescribeExportImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeExportImageInfoResponse>(await DoRequestAsync("DescribeExportImageInfo", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeExportImageInfoResponse DescribeExportImageInfo(DescribeExportImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExportImageInfoWithOptions(request, runtime);
        }

        public async Task<DescribeExportImageInfoResponse> DescribeExportImageInfoAsync(DescribeExportImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExportImageInfoWithOptionsAsync(request, runtime);
        }

        public DescribeVSwitchesResponse DescribeVSwitchesWithOptions(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVSwitchesResponse>(DoRequest("DescribeVSwitches", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesWithOptionsAsync(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVSwitchesResponse>(await DoRequestAsync("DescribeVSwitches", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeVSwitchesResponse DescribeVSwitches(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVSwitchesWithOptions(request, runtime);
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesAsync(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVSwitchesWithOptionsAsync(request, runtime);
        }

        public DeleteVSwitchResponse DeleteVSwitchWithOptions(DeleteVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteVSwitchResponse>(DoRequest("DeleteVSwitch", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteVSwitchResponse> DeleteVSwitchWithOptionsAsync(DeleteVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteVSwitchResponse>(await DoRequestAsync("DeleteVSwitch", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DeleteVSwitchResponse DeleteVSwitch(DeleteVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVSwitchWithOptions(request, runtime);
        }

        public async Task<DeleteVSwitchResponse> DeleteVSwitchAsync(DeleteVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVSwitchWithOptionsAsync(request, runtime);
        }

        public CreateVSwitchResponse CreateVSwitchWithOptions(CreateVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVSwitchResponse>(DoRequest("CreateVSwitch", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateVSwitchResponse> CreateVSwitchWithOptionsAsync(CreateVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVSwitchResponse>(await DoRequestAsync("CreateVSwitch", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateVSwitchResponse CreateVSwitch(CreateVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVSwitchWithOptions(request, runtime);
        }

        public async Task<CreateVSwitchResponse> CreateVSwitchAsync(CreateVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVSwitchWithOptionsAsync(request, runtime);
        }

        public DescribeExportImageStatusResponse DescribeExportImageStatusWithOptions(DescribeExportImageStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeExportImageStatusResponse>(DoRequest("DescribeExportImageStatus", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeExportImageStatusResponse> DescribeExportImageStatusWithOptionsAsync(DescribeExportImageStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeExportImageStatusResponse>(await DoRequestAsync("DescribeExportImageStatus", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeExportImageStatusResponse DescribeExportImageStatus(DescribeExportImageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExportImageStatusWithOptions(request, runtime);
        }

        public async Task<DescribeExportImageStatusResponse> DescribeExportImageStatusAsync(DescribeExportImageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExportImageStatusWithOptionsAsync(request, runtime);
        }

        public ExportImageResponse ExportImageWithOptions(ExportImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportImageResponse>(DoRequest("ExportImage", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ExportImageResponse> ExportImageWithOptionsAsync(ExportImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportImageResponse>(await DoRequestAsync("ExportImage", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ExportImageResponse ExportImage(ExportImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportImageWithOptions(request, runtime);
        }

        public async Task<ExportImageResponse> ExportImageAsync(ExportImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportImageWithOptionsAsync(request, runtime);
        }

        public ImportKeyPairResponse ImportKeyPairWithOptions(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportKeyPairResponse>(DoRequest("ImportKeyPair", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ImportKeyPairResponse> ImportKeyPairWithOptionsAsync(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportKeyPairResponse>(await DoRequestAsync("ImportKeyPair", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportKeyPairWithOptions(request, runtime);
        }

        public async Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportKeyPairWithOptionsAsync(request, runtime);
        }

        public DescribeKeyPairsResponse DescribeKeyPairsWithOptions(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeKeyPairsResponse>(DoRequest("DescribeKeyPairs", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsWithOptionsAsync(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeKeyPairsResponse>(await DoRequestAsync("DescribeKeyPairs", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyPairsWithOptions(request, runtime);
        }

        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyPairsWithOptionsAsync(request, runtime);
        }

        public DeleteKeyPairsResponse DeleteKeyPairsWithOptions(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteKeyPairsResponse>(DoRequest("DeleteKeyPairs", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsWithOptionsAsync(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteKeyPairsResponse>(await DoRequestAsync("DeleteKeyPairs", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DeleteKeyPairsResponse DeleteKeyPairs(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeyPairsWithOptions(request, runtime);
        }

        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsAsync(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeyPairsWithOptionsAsync(request, runtime);
        }

        public CreateKeyPairResponse CreateKeyPairWithOptions(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateKeyPairResponse>(DoRequest("CreateKeyPair", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateKeyPairResponse> CreateKeyPairWithOptionsAsync(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateKeyPairResponse>(await DoRequestAsync("CreateKeyPair", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyPairWithOptions(request, runtime);
        }

        public async Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyPairWithOptionsAsync(request, runtime);
        }

        public ExportBillDetailDataResponse ExportBillDetailDataWithOptions(ExportBillDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportBillDetailDataResponse>(DoRequest("ExportBillDetailData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ExportBillDetailDataResponse> ExportBillDetailDataWithOptionsAsync(ExportBillDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportBillDetailDataResponse>(await DoRequestAsync("ExportBillDetailData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ExportBillDetailDataResponse ExportBillDetailData(ExportBillDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportBillDetailDataWithOptions(request, runtime);
        }

        public async Task<ExportBillDetailDataResponse> ExportBillDetailDataAsync(ExportBillDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportBillDetailDataWithOptionsAsync(request, runtime);
        }

        public DescribeEnsRegionIdResourceResponse DescribeEnsRegionIdResourceWithOptions(DescribeEnsRegionIdResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsRegionIdResourceResponse>(DoRequest("DescribeEnsRegionIdResource", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEnsRegionIdResourceResponse> DescribeEnsRegionIdResourceWithOptionsAsync(DescribeEnsRegionIdResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsRegionIdResourceResponse>(await DoRequestAsync("DescribeEnsRegionIdResource", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEnsRegionIdResourceResponse DescribeEnsRegionIdResource(DescribeEnsRegionIdResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsRegionIdResourceWithOptions(request, runtime);
        }

        public async Task<DescribeEnsRegionIdResourceResponse> DescribeEnsRegionIdResourceAsync(DescribeEnsRegionIdResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsRegionIdResourceWithOptionsAsync(request, runtime);
        }

        public DescribeBandwitdhByInternetChargeTypeResponse DescribeBandwitdhByInternetChargeTypeWithOptions(DescribeBandwitdhByInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBandwitdhByInternetChargeTypeResponse>(DoRequest("DescribeBandwitdhByInternetChargeType", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeBandwitdhByInternetChargeTypeResponse> DescribeBandwitdhByInternetChargeTypeWithOptionsAsync(DescribeBandwitdhByInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBandwitdhByInternetChargeTypeResponse>(await DoRequestAsync("DescribeBandwitdhByInternetChargeType", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeBandwitdhByInternetChargeTypeResponse DescribeBandwitdhByInternetChargeType(DescribeBandwitdhByInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBandwitdhByInternetChargeTypeWithOptions(request, runtime);
        }

        public async Task<DescribeBandwitdhByInternetChargeTypeResponse> DescribeBandwitdhByInternetChargeTypeAsync(DescribeBandwitdhByInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBandwitdhByInternetChargeTypeWithOptionsAsync(request, runtime);
        }

        public AuthorizeSecurityGroupResponse AuthorizeSecurityGroupWithOptions(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(DoRequest("AuthorizeSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AuthorizeSecurityGroupResponse> AuthorizeSecurityGroupWithOptionsAsync(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(await DoRequestAsync("AuthorizeSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public AuthorizeSecurityGroupResponse AuthorizeSecurityGroup(AuthorizeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeSecurityGroupWithOptions(request, runtime);
        }

        public async Task<AuthorizeSecurityGroupResponse> AuthorizeSecurityGroupAsync(AuthorizeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeSecurityGroupWithOptionsAsync(request, runtime);
        }

        public RevokeSecurityGroupResponse RevokeSecurityGroupWithOptions(RevokeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RevokeSecurityGroupResponse>(DoRequest("RevokeSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RevokeSecurityGroupResponse> RevokeSecurityGroupWithOptionsAsync(RevokeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RevokeSecurityGroupResponse>(await DoRequestAsync("RevokeSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public RevokeSecurityGroupResponse RevokeSecurityGroup(RevokeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeSecurityGroupWithOptions(request, runtime);
        }

        public async Task<RevokeSecurityGroupResponse> RevokeSecurityGroupAsync(RevokeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeSecurityGroupWithOptionsAsync(request, runtime);
        }

        public DeleteSecurityGroupResponse DeleteSecurityGroupWithOptions(DeleteSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSecurityGroupResponse>(DoRequest("DeleteSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupWithOptionsAsync(DeleteSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSecurityGroupResponse>(await DoRequestAsync("DeleteSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecurityGroupWithOptions(request, runtime);
        }

        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecurityGroupWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupAttributeResponse DescribeSecurityGroupAttributeWithOptions(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(DoRequest("DescribeSecurityGroupAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeSecurityGroupAttributeResponse> DescribeSecurityGroupAttributeWithOptionsAsync(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(await DoRequestAsync("DescribeSecurityGroupAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeSecurityGroupAttributeResponse DescribeSecurityGroupAttribute(DescribeSecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupAttributeResponse> DescribeSecurityGroupAttributeAsync(DescribeSecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupAttributeWithOptionsAsync(request, runtime);
        }

        public LeaveSecurityGroupResponse LeaveSecurityGroupWithOptions(LeaveSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<LeaveSecurityGroupResponse>(DoRequest("LeaveSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<LeaveSecurityGroupResponse> LeaveSecurityGroupWithOptionsAsync(LeaveSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<LeaveSecurityGroupResponse>(await DoRequestAsync("LeaveSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public LeaveSecurityGroupResponse LeaveSecurityGroup(LeaveSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LeaveSecurityGroupWithOptions(request, runtime);
        }

        public async Task<LeaveSecurityGroupResponse> LeaveSecurityGroupAsync(LeaveSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LeaveSecurityGroupWithOptionsAsync(request, runtime);
        }

        public JoinSecurityGroupResponse JoinSecurityGroupWithOptions(JoinSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<JoinSecurityGroupResponse>(DoRequest("JoinSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<JoinSecurityGroupResponse> JoinSecurityGroupWithOptionsAsync(JoinSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<JoinSecurityGroupResponse>(await DoRequestAsync("JoinSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public JoinSecurityGroupResponse JoinSecurityGroup(JoinSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinSecurityGroupWithOptions(request, runtime);
        }

        public async Task<JoinSecurityGroupResponse> JoinSecurityGroupAsync(JoinSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinSecurityGroupWithOptionsAsync(request, runtime);
        }

        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgressWithOptions(AuthorizeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AuthorizeSecurityGroupEgressResponse>(DoRequest("AuthorizeSecurityGroupEgress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressWithOptionsAsync(AuthorizeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AuthorizeSecurityGroupEgressResponse>(await DoRequestAsync("AuthorizeSecurityGroupEgress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeSecurityGroupEgressWithOptions(request, runtime);
        }

        public async Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeSecurityGroupEgressWithOptionsAsync(request, runtime);
        }

        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgressWithOptions(RevokeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RevokeSecurityGroupEgressResponse>(DoRequest("RevokeSecurityGroupEgress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressWithOptionsAsync(RevokeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RevokeSecurityGroupEgressResponse>(await DoRequestAsync("RevokeSecurityGroupEgress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeSecurityGroupEgressWithOptions(request, runtime);
        }

        public async Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeSecurityGroupEgressWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupsResponse DescribeSecurityGroupsWithOptions(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(DoRequest("DescribeSecurityGroups", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsWithOptionsAsync(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(await DoRequestAsync("DescribeSecurityGroups", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupsWithOptionsAsync(request, runtime);
        }

        public CreateSecurityGroupResponse CreateSecurityGroupWithOptions(CreateSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSecurityGroupResponse>(DoRequest("CreateSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupWithOptionsAsync(CreateSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSecurityGroupResponse>(await DoRequestAsync("CreateSecurityGroup", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecurityGroupWithOptions(request, runtime);
        }

        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecurityGroupWithOptionsAsync(request, runtime);
        }

        public DescribeEnsRegionIdIpv6InfoResponse DescribeEnsRegionIdIpv6InfoWithOptions(DescribeEnsRegionIdIpv6InfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsRegionIdIpv6InfoResponse>(DoRequest("DescribeEnsRegionIdIpv6Info", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEnsRegionIdIpv6InfoResponse> DescribeEnsRegionIdIpv6InfoWithOptionsAsync(DescribeEnsRegionIdIpv6InfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsRegionIdIpv6InfoResponse>(await DoRequestAsync("DescribeEnsRegionIdIpv6Info", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEnsRegionIdIpv6InfoResponse DescribeEnsRegionIdIpv6Info(DescribeEnsRegionIdIpv6InfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsRegionIdIpv6InfoWithOptions(request, runtime);
        }

        public async Task<DescribeEnsRegionIdIpv6InfoResponse> DescribeEnsRegionIdIpv6InfoAsync(DescribeEnsRegionIdIpv6InfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsRegionIdIpv6InfoWithOptionsAsync(request, runtime);
        }

        public DescribeCreatePrePaidInstanceResultResponse DescribeCreatePrePaidInstanceResultWithOptions(DescribeCreatePrePaidInstanceResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCreatePrePaidInstanceResultResponse>(DoRequest("DescribeCreatePrePaidInstanceResult", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCreatePrePaidInstanceResultResponse> DescribeCreatePrePaidInstanceResultWithOptionsAsync(DescribeCreatePrePaidInstanceResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCreatePrePaidInstanceResultResponse>(await DoRequestAsync("DescribeCreatePrePaidInstanceResult", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeCreatePrePaidInstanceResultResponse DescribeCreatePrePaidInstanceResult(DescribeCreatePrePaidInstanceResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCreatePrePaidInstanceResultWithOptions(request, runtime);
        }

        public async Task<DescribeCreatePrePaidInstanceResultResponse> DescribeCreatePrePaidInstanceResultAsync(DescribeCreatePrePaidInstanceResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCreatePrePaidInstanceResultWithOptionsAsync(request, runtime);
        }

        public DescribePriceResponse DescribePriceWithOptions(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePriceResponse>(DoRequest("DescribePrice", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePriceResponse>(await DoRequestAsync("DescribePrice", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribePriceResponse DescribePrice(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePriceWithOptions(request, runtime);
        }

        public async Task<DescribePriceResponse> DescribePriceAsync(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePriceWithOptionsAsync(request, runtime);
        }

        public ExportMeasurementDataResponse ExportMeasurementDataWithOptions(ExportMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportMeasurementDataResponse>(DoRequest("ExportMeasurementData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ExportMeasurementDataResponse> ExportMeasurementDataWithOptionsAsync(ExportMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportMeasurementDataResponse>(await DoRequestAsync("ExportMeasurementData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ExportMeasurementDataResponse ExportMeasurementData(ExportMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportMeasurementDataWithOptions(request, runtime);
        }

        public async Task<ExportMeasurementDataResponse> ExportMeasurementDataAsync(ExportMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportMeasurementDataWithOptionsAsync(request, runtime);
        }

        public DescribeMeasurementDataResponse DescribeMeasurementDataWithOptions(DescribeMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeMeasurementDataResponse>(DoRequest("DescribeMeasurementData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeMeasurementDataResponse> DescribeMeasurementDataWithOptionsAsync(DescribeMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeMeasurementDataResponse>(await DoRequestAsync("DescribeMeasurementData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeMeasurementDataResponse DescribeMeasurementData(DescribeMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeasurementDataWithOptions(request, runtime);
        }

        public async Task<DescribeMeasurementDataResponse> DescribeMeasurementDataAsync(DescribeMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeasurementDataWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceInfoResponse DescribeAvailableResourceInfoWithOptions(DescribeAvailableResourceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAvailableResourceInfoResponse>(DoRequest("DescribeAvailableResourceInfo", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeAvailableResourceInfoResponse> DescribeAvailableResourceInfoWithOptionsAsync(DescribeAvailableResourceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAvailableResourceInfoResponse>(await DoRequestAsync("DescribeAvailableResourceInfo", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeAvailableResourceInfoResponse DescribeAvailableResourceInfo(DescribeAvailableResourceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceInfoWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableResourceInfoResponse> DescribeAvailableResourceInfoAsync(DescribeAvailableResourceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceInfoWithOptionsAsync(request, runtime);
        }

        public DescribePrePaidInstanceStockResponse DescribePrePaidInstanceStockWithOptions(DescribePrePaidInstanceStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePrePaidInstanceStockResponse>(DoRequest("DescribePrePaidInstanceStock", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribePrePaidInstanceStockResponse> DescribePrePaidInstanceStockWithOptionsAsync(DescribePrePaidInstanceStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePrePaidInstanceStockResponse>(await DoRequestAsync("DescribePrePaidInstanceStock", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribePrePaidInstanceStockResponse DescribePrePaidInstanceStock(DescribePrePaidInstanceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePrePaidInstanceStockWithOptions(request, runtime);
        }

        public async Task<DescribePrePaidInstanceStockResponse> DescribePrePaidInstanceStockAsync(DescribePrePaidInstanceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePrePaidInstanceStockWithOptionsAsync(request, runtime);
        }

        public UnassociateEipAddressResponse UnassociateEipAddressWithOptions(UnassociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnassociateEipAddressResponse>(DoRequest("UnassociateEipAddress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnassociateEipAddressResponse> UnassociateEipAddressWithOptionsAsync(UnassociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnassociateEipAddressResponse>(await DoRequestAsync("UnassociateEipAddress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public UnassociateEipAddressResponse UnassociateEipAddress(UnassociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateEipAddressWithOptions(request, runtime);
        }

        public async Task<UnassociateEipAddressResponse> UnassociateEipAddressAsync(UnassociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateEipAddressWithOptionsAsync(request, runtime);
        }

        public ReleaseEipAddressResponse ReleaseEipAddressWithOptions(ReleaseEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseEipAddressResponse>(DoRequest("ReleaseEipAddress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReleaseEipAddressResponse> ReleaseEipAddressWithOptionsAsync(ReleaseEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseEipAddressResponse>(await DoRequestAsync("ReleaseEipAddress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ReleaseEipAddressResponse ReleaseEipAddress(ReleaseEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseEipAddressWithOptions(request, runtime);
        }

        public async Task<ReleaseEipAddressResponse> ReleaseEipAddressAsync(ReleaseEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseEipAddressWithOptionsAsync(request, runtime);
        }

        public DescribeEipAddressesResponse DescribeEipAddressesWithOptions(DescribeEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEipAddressesResponse>(DoRequest("DescribeEipAddresses", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEipAddressesResponse> DescribeEipAddressesWithOptionsAsync(DescribeEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEipAddressesResponse>(await DoRequestAsync("DescribeEipAddresses", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEipAddressesResponse DescribeEipAddresses(DescribeEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEipAddressesWithOptions(request, runtime);
        }

        public async Task<DescribeEipAddressesResponse> DescribeEipAddressesAsync(DescribeEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEipAddressesWithOptionsAsync(request, runtime);
        }

        public AssociateEipAddressResponse AssociateEipAddressWithOptions(AssociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AssociateEipAddressResponse>(DoRequest("AssociateEipAddress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AssociateEipAddressResponse> AssociateEipAddressWithOptionsAsync(AssociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AssociateEipAddressResponse>(await DoRequestAsync("AssociateEipAddress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public AssociateEipAddressResponse AssociateEipAddress(AssociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateEipAddressWithOptions(request, runtime);
        }

        public async Task<AssociateEipAddressResponse> AssociateEipAddressAsync(AssociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateEipAddressWithOptionsAsync(request, runtime);
        }

        public AllocateEipAddressResponse AllocateEipAddressWithOptions(AllocateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AllocateEipAddressResponse>(DoRequest("AllocateEipAddress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AllocateEipAddressResponse> AllocateEipAddressWithOptionsAsync(AllocateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AllocateEipAddressResponse>(await DoRequestAsync("AllocateEipAddress", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public AllocateEipAddressResponse AllocateEipAddress(AllocateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateEipAddressWithOptions(request, runtime);
        }

        public async Task<AllocateEipAddressResponse> AllocateEipAddressAsync(AllocateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateEipAddressWithOptionsAsync(request, runtime);
        }

        public ReleasePostPaidInstanceResponse ReleasePostPaidInstanceWithOptions(ReleasePostPaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleasePostPaidInstanceResponse>(DoRequest("ReleasePostPaidInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReleasePostPaidInstanceResponse> ReleasePostPaidInstanceWithOptionsAsync(ReleasePostPaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleasePostPaidInstanceResponse>(await DoRequestAsync("ReleasePostPaidInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ReleasePostPaidInstanceResponse ReleasePostPaidInstance(ReleasePostPaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePostPaidInstanceWithOptions(request, runtime);
        }

        public async Task<ReleasePostPaidInstanceResponse> ReleasePostPaidInstanceAsync(ReleasePostPaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePostPaidInstanceWithOptionsAsync(request, runtime);
        }

        public ReleasePrePaidInstanceResponse ReleasePrePaidInstanceWithOptions(ReleasePrePaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleasePrePaidInstanceResponse>(DoRequest("ReleasePrePaidInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReleasePrePaidInstanceResponse> ReleasePrePaidInstanceWithOptionsAsync(ReleasePrePaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleasePrePaidInstanceResponse>(await DoRequestAsync("ReleasePrePaidInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ReleasePrePaidInstanceResponse ReleasePrePaidInstance(ReleasePrePaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePrePaidInstanceWithOptions(request, runtime);
        }

        public async Task<ReleasePrePaidInstanceResponse> ReleasePrePaidInstanceAsync(ReleasePrePaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePrePaidInstanceWithOptionsAsync(request, runtime);
        }

        public AttachEnsInstancesResponse AttachEnsInstancesWithOptions(AttachEnsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AttachEnsInstancesResponse>(DoRequest("AttachEnsInstances", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AttachEnsInstancesResponse> AttachEnsInstancesWithOptionsAsync(AttachEnsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AttachEnsInstancesResponse>(await DoRequestAsync("AttachEnsInstances", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public AttachEnsInstancesResponse AttachEnsInstances(AttachEnsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachEnsInstancesWithOptions(request, runtime);
        }

        public async Task<AttachEnsInstancesResponse> AttachEnsInstancesAsync(AttachEnsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachEnsInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeReservedResourceResponse DescribeReservedResourceWithOptions(DescribeReservedResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeReservedResourceResponse>(DoRequest("DescribeReservedResource", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeReservedResourceResponse> DescribeReservedResourceWithOptionsAsync(DescribeReservedResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeReservedResourceResponse>(await DoRequestAsync("DescribeReservedResource", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeReservedResourceResponse DescribeReservedResource(DescribeReservedResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReservedResourceWithOptions(request, runtime);
        }

        public async Task<DescribeReservedResourceResponse> DescribeReservedResourceAsync(DescribeReservedResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReservedResourceWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceTypesResponse DescribeInstanceTypesWithOptions(DescribeInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceTypesResponse>(DoRequest("DescribeInstanceTypes", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypesWithOptionsAsync(DescribeInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceTypesResponse>(await DoRequestAsync("DescribeInstanceTypes", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstanceTypesResponse DescribeInstanceTypes(DescribeInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTypesWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypesAsync(DescribeInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTypesWithOptionsAsync(request, runtime);
        }

        public CreateImageResponse CreateImageWithOptions(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageResponse>(DoRequest("CreateImage", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateImageResponse> CreateImageWithOptionsAsync(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageResponse>(await DoRequestAsync("CreateImage", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageWithOptions(request, runtime);
        }

        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageWithOptionsAsync(request, runtime);
        }

        public DescribeEnsNetSaleDistrictResponse DescribeEnsNetSaleDistrictWithOptions(DescribeEnsNetSaleDistrictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsNetSaleDistrictResponse>(DoRequest("DescribeEnsNetSaleDistrict", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEnsNetSaleDistrictResponse> DescribeEnsNetSaleDistrictWithOptionsAsync(DescribeEnsNetSaleDistrictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsNetSaleDistrictResponse>(await DoRequestAsync("DescribeEnsNetSaleDistrict", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEnsNetSaleDistrictResponse DescribeEnsNetSaleDistrict(DescribeEnsNetSaleDistrictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsNetSaleDistrictWithOptions(request, runtime);
        }

        public async Task<DescribeEnsNetSaleDistrictResponse> DescribeEnsNetSaleDistrictAsync(DescribeEnsNetSaleDistrictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsNetSaleDistrictWithOptionsAsync(request, runtime);
        }

        public DescribeEnsNetDistrictResponse DescribeEnsNetDistrictWithOptions(DescribeEnsNetDistrictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsNetDistrictResponse>(DoRequest("DescribeEnsNetDistrict", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEnsNetDistrictResponse> DescribeEnsNetDistrictWithOptionsAsync(DescribeEnsNetDistrictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsNetDistrictResponse>(await DoRequestAsync("DescribeEnsNetDistrict", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEnsNetDistrictResponse DescribeEnsNetDistrict(DescribeEnsNetDistrictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsNetDistrictWithOptions(request, runtime);
        }

        public async Task<DescribeEnsNetDistrictResponse> DescribeEnsNetDistrictAsync(DescribeEnsNetDistrictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsNetDistrictWithOptionsAsync(request, runtime);
        }

        public PreCreateEnsServiceResponse PreCreateEnsServiceWithOptions(PreCreateEnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PreCreateEnsServiceResponse>(DoRequest("PreCreateEnsService", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PreCreateEnsServiceResponse> PreCreateEnsServiceWithOptionsAsync(PreCreateEnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PreCreateEnsServiceResponse>(await DoRequestAsync("PreCreateEnsService", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public PreCreateEnsServiceResponse PreCreateEnsService(PreCreateEnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreCreateEnsServiceWithOptions(request, runtime);
        }

        public async Task<PreCreateEnsServiceResponse> PreCreateEnsServiceAsync(PreCreateEnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreCreateEnsServiceWithOptionsAsync(request, runtime);
        }

        public DescribeBandWithdChargeTypeResponse DescribeBandWithdChargeTypeWithOptions(DescribeBandWithdChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBandWithdChargeTypeResponse>(DoRequest("DescribeBandWithdChargeType", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeBandWithdChargeTypeResponse> DescribeBandWithdChargeTypeWithOptionsAsync(DescribeBandWithdChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBandWithdChargeTypeResponse>(await DoRequestAsync("DescribeBandWithdChargeType", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeBandWithdChargeTypeResponse DescribeBandWithdChargeType(DescribeBandWithdChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBandWithdChargeTypeWithOptions(request, runtime);
        }

        public async Task<DescribeBandWithdChargeTypeResponse> DescribeBandWithdChargeTypeAsync(DescribeBandWithdChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBandWithdChargeTypeWithOptionsAsync(request, runtime);
        }

        public ModifyImageAttributeResponse ModifyImageAttributeWithOptions(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyImageAttributeResponse>(DoRequest("ModifyImageAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeWithOptionsAsync(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyImageAttributeResponse>(await DoRequestAsync("ModifyImageAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageAttributeWithOptionsAsync(request, runtime);
        }

        public CreateEnsServiceResponse CreateEnsServiceWithOptions(CreateEnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEnsServiceResponse>(DoRequest("CreateEnsService", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEnsServiceResponse> CreateEnsServiceWithOptionsAsync(CreateEnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEnsServiceResponse>(await DoRequestAsync("CreateEnsService", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateEnsServiceResponse CreateEnsService(CreateEnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEnsServiceWithOptions(request, runtime);
        }

        public async Task<CreateEnsServiceResponse> CreateEnsServiceAsync(CreateEnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEnsServiceWithOptionsAsync(request, runtime);
        }

        public DescribeEnsNetLevelResponse DescribeEnsNetLevelWithOptions(DescribeEnsNetLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsNetLevelResponse>(DoRequest("DescribeEnsNetLevel", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEnsNetLevelResponse> DescribeEnsNetLevelWithOptionsAsync(DescribeEnsNetLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsNetLevelResponse>(await DoRequestAsync("DescribeEnsNetLevel", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEnsNetLevelResponse DescribeEnsNetLevel(DescribeEnsNetLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsNetLevelWithOptions(request, runtime);
        }

        public async Task<DescribeEnsNetLevelResponse> DescribeEnsNetLevelAsync(DescribeEnsNetLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsNetLevelWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSpecResponse DescribeInstanceSpecWithOptions(DescribeInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceSpecResponse>(DoRequest("DescribeInstanceSpec", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceSpecResponse> DescribeInstanceSpecWithOptionsAsync(DescribeInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceSpecResponse>(await DoRequestAsync("DescribeInstanceSpec", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstanceSpecResponse DescribeInstanceSpec(DescribeInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSpecWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSpecResponse> DescribeInstanceSpecAsync(DescribeInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSpecWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAutoRenewAttributeResponse DescribeInstanceAutoRenewAttributeWithOptions(DescribeInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceAutoRenewAttributeResponse>(DoRequest("DescribeInstanceAutoRenewAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceAutoRenewAttributeResponse> DescribeInstanceAutoRenewAttributeWithOptionsAsync(DescribeInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceAutoRenewAttributeResponse>(await DoRequestAsync("DescribeInstanceAutoRenewAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstanceAutoRenewAttributeResponse DescribeInstanceAutoRenewAttribute(DescribeInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAutoRenewAttributeResponse> DescribeInstanceAutoRenewAttributeAsync(DescribeInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(DoRequest("DescribeAvailableResource", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await DoRequestAsync("DescribeAvailableResource", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateInstanceResponse>(DoRequest("CreateInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRequestAsync("CreateInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public ReInitDiskResponse ReInitDiskWithOptions(ReInitDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReInitDiskResponse>(DoRequest("ReInitDisk", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReInitDiskResponse> ReInitDiskWithOptionsAsync(ReInitDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReInitDiskResponse>(await DoRequestAsync("ReInitDisk", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ReInitDiskResponse ReInitDisk(ReInitDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReInitDiskWithOptions(request, runtime);
        }

        public async Task<ReInitDiskResponse> ReInitDiskAsync(ReInitDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReInitDiskWithOptionsAsync(request, runtime);
        }

        public DescribeImageInfosResponse DescribeImageInfosWithOptions(DescribeImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImageInfosResponse>(DoRequest("DescribeImageInfos", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeImageInfosResponse> DescribeImageInfosWithOptionsAsync(DescribeImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImageInfosResponse>(await DoRequestAsync("DescribeImageInfos", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeImageInfosResponse DescribeImageInfos(DescribeImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageInfosWithOptions(request, runtime);
        }

        public async Task<DescribeImageInfosResponse> DescribeImageInfosAsync(DescribeImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageInfosWithOptionsAsync(request, runtime);
        }

        public DescribeUserBandWidthDataResponse DescribeUserBandWidthDataWithOptions(DescribeUserBandWidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUserBandWidthDataResponse>(DoRequest("DescribeUserBandWidthData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeUserBandWidthDataResponse> DescribeUserBandWidthDataWithOptionsAsync(DescribeUserBandWidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUserBandWidthDataResponse>(await DoRequestAsync("DescribeUserBandWidthData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeUserBandWidthDataResponse DescribeUserBandWidthData(DescribeUserBandWidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserBandWidthDataWithOptions(request, runtime);
        }

        public async Task<DescribeUserBandWidthDataResponse> DescribeUserBandWidthDataAsync(DescribeUserBandWidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserBandWidthDataWithOptionsAsync(request, runtime);
        }

        public RebootInstanceResponse RebootInstanceWithOptions(RebootInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RebootInstanceResponse>(DoRequest("RebootInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RebootInstanceResponse> RebootInstanceWithOptionsAsync(RebootInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RebootInstanceResponse>(await DoRequestAsync("RebootInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootInstanceWithOptions(request, runtime);
        }

        public async Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeEnsRegionsResponse DescribeEnsRegionsWithOptions(DescribeEnsRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsRegionsResponse>(DoRequest("DescribeEnsRegions", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeEnsRegionsResponse> DescribeEnsRegionsWithOptionsAsync(DescribeEnsRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEnsRegionsResponse>(await DoRequestAsync("DescribeEnsRegions", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeEnsRegionsResponse DescribeEnsRegions(DescribeEnsRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeEnsRegionsResponse> DescribeEnsRegionsAsync(DescribeEnsRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsRegionsWithOptionsAsync(request, runtime);
        }

        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartInstanceResponse>(DoRequest("StartInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartInstanceResponse>(await DoRequestAsync("StartInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceMonitorDataResponse DescribeInstanceMonitorDataWithOptions(DescribeInstanceMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceMonitorDataResponse>(DoRequest("DescribeInstanceMonitorData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceMonitorDataResponse> DescribeInstanceMonitorDataWithOptionsAsync(DescribeInstanceMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceMonitorDataResponse>(await DoRequestAsync("DescribeInstanceMonitorData", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstanceMonitorDataResponse DescribeInstanceMonitorData(DescribeInstanceMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceMonitorDataResponse> DescribeInstanceMonitorDataAsync(DescribeInstanceMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRequest("DescribeInstances", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRequestAsync("DescribeInstances", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeImagesResponse DescribeImagesWithOptions(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(DoRequest("DescribeImages", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeImagesResponse> DescribeImagesWithOptionsAsync(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(await DoRequestAsync("DescribeImages", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImagesWithOptions(request, runtime);
        }

        public async Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImagesWithOptionsAsync(request, runtime);
        }

        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopInstanceResponse>(DoRequest("StopInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopInstanceResponse>(await DoRequestAsync("StopInstance", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttributeWithOptions(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(DoRequest("ModifyInstanceAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeWithOptionsAsync(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(await DoRequestAsync("ModifyInstanceAttribute", "HTTPS", "POST", "2017-11-10", "AK", null, request.ToMap(), runtime));
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAttributeWithOptionsAsync(request, runtime);
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
