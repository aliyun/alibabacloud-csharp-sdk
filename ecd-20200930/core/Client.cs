// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ecd20200930.Models;

namespace AlibabaCloud.SDK.Ecd20200930
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ecd", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public GetDirectorySsoStatusResponse GetDirectorySsoStatusWithOptions(GetDirectorySsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDirectorySsoStatusResponse>(DoRequest("GetDirectorySsoStatus", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDirectorySsoStatusResponse> GetDirectorySsoStatusWithOptionsAsync(GetDirectorySsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDirectorySsoStatusResponse>(await DoRequestAsync("GetDirectorySsoStatus", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public GetDirectorySsoStatusResponse GetDirectorySsoStatus(GetDirectorySsoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDirectorySsoStatusWithOptions(request, runtime);
        }

        public async Task<GetDirectorySsoStatusResponse> GetDirectorySsoStatusAsync(GetDirectorySsoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDirectorySsoStatusWithOptionsAsync(request, runtime);
        }

        public SetDirectorySsoStatusResponse SetDirectorySsoStatusWithOptions(SetDirectorySsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDirectorySsoStatusResponse>(DoRequest("SetDirectorySsoStatus", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDirectorySsoStatusResponse> SetDirectorySsoStatusWithOptionsAsync(SetDirectorySsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDirectorySsoStatusResponse>(await DoRequestAsync("SetDirectorySsoStatus", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public SetDirectorySsoStatusResponse SetDirectorySsoStatus(SetDirectorySsoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDirectorySsoStatusWithOptions(request, runtime);
        }

        public async Task<SetDirectorySsoStatusResponse> SetDirectorySsoStatusAsync(SetDirectorySsoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDirectorySsoStatusWithOptionsAsync(request, runtime);
        }

        public GetSpMetadataResponse GetSpMetadataWithOptions(GetSpMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSpMetadataResponse>(DoRequest("GetSpMetadata", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSpMetadataResponse> GetSpMetadataWithOptionsAsync(GetSpMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSpMetadataResponse>(await DoRequestAsync("GetSpMetadata", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public GetSpMetadataResponse GetSpMetadata(GetSpMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSpMetadataWithOptions(request, runtime);
        }

        public async Task<GetSpMetadataResponse> GetSpMetadataAsync(GetSpMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSpMetadataWithOptionsAsync(request, runtime);
        }

        public SetIdpMetadataResponse SetIdpMetadataWithOptions(SetIdpMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetIdpMetadataResponse>(DoRequest("SetIdpMetadata", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetIdpMetadataResponse> SetIdpMetadataWithOptionsAsync(SetIdpMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetIdpMetadataResponse>(await DoRequestAsync("SetIdpMetadata", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public SetIdpMetadataResponse SetIdpMetadata(SetIdpMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetIdpMetadataWithOptions(request, runtime);
        }

        public async Task<SetIdpMetadataResponse> SetIdpMetadataAsync(SetIdpMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetIdpMetadataWithOptionsAsync(request, runtime);
        }

        public RebuildDesktopsResponse RebuildDesktopsWithOptions(RebuildDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RebuildDesktopsResponse>(DoRequest("RebuildDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RebuildDesktopsResponse> RebuildDesktopsWithOptionsAsync(RebuildDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RebuildDesktopsResponse>(await DoRequestAsync("RebuildDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public RebuildDesktopsResponse RebuildDesktops(RebuildDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebuildDesktopsWithOptions(request, runtime);
        }

        public async Task<RebuildDesktopsResponse> RebuildDesktopsAsync(RebuildDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebuildDesktopsWithOptionsAsync(request, runtime);
        }

        public ModifyBundleResponse ModifyBundleWithOptions(ModifyBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyBundleResponse>(DoRequest("ModifyBundle", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyBundleResponse> ModifyBundleWithOptionsAsync(ModifyBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyBundleResponse>(await DoRequestAsync("ModifyBundle", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyBundleResponse ModifyBundle(ModifyBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBundleWithOptions(request, runtime);
        }

        public async Task<ModifyBundleResponse> ModifyBundleAsync(ModifyBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBundleWithOptionsAsync(request, runtime);
        }

        public UnlockVirtualMFADeviceResponse UnlockVirtualMFADeviceWithOptions(UnlockVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnlockVirtualMFADeviceResponse>(DoRequest("UnlockVirtualMFADevice", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnlockVirtualMFADeviceResponse> UnlockVirtualMFADeviceWithOptionsAsync(UnlockVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnlockVirtualMFADeviceResponse>(await DoRequestAsync("UnlockVirtualMFADevice", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public UnlockVirtualMFADeviceResponse UnlockVirtualMFADevice(UnlockVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockVirtualMFADeviceWithOptions(request, runtime);
        }

        public async Task<UnlockVirtualMFADeviceResponse> UnlockVirtualMFADeviceAsync(UnlockVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockVirtualMFADeviceWithOptionsAsync(request, runtime);
        }

        public DescribeVirtualMFADevicesResponse DescribeVirtualMFADevicesWithOptions(DescribeVirtualMFADevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVirtualMFADevicesResponse>(DoRequest("DescribeVirtualMFADevices", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeVirtualMFADevicesResponse> DescribeVirtualMFADevicesWithOptionsAsync(DescribeVirtualMFADevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVirtualMFADevicesResponse>(await DoRequestAsync("DescribeVirtualMFADevices", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeVirtualMFADevicesResponse DescribeVirtualMFADevices(DescribeVirtualMFADevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVirtualMFADevicesWithOptions(request, runtime);
        }

        public async Task<DescribeVirtualMFADevicesResponse> DescribeVirtualMFADevicesAsync(DescribeVirtualMFADevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVirtualMFADevicesWithOptionsAsync(request, runtime);
        }

        public LockVirtualMFADeviceResponse LockVirtualMFADeviceWithOptions(LockVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<LockVirtualMFADeviceResponse>(DoRequest("LockVirtualMFADevice", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<LockVirtualMFADeviceResponse> LockVirtualMFADeviceWithOptionsAsync(LockVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<LockVirtualMFADeviceResponse>(await DoRequestAsync("LockVirtualMFADevice", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public LockVirtualMFADeviceResponse LockVirtualMFADevice(LockVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockVirtualMFADeviceWithOptions(request, runtime);
        }

        public async Task<LockVirtualMFADeviceResponse> LockVirtualMFADeviceAsync(LockVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockVirtualMFADeviceWithOptionsAsync(request, runtime);
        }

        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADeviceWithOptions(DeleteVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteVirtualMFADeviceResponse>(DoRequest("DeleteVirtualMFADevice", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceWithOptionsAsync(DeleteVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteVirtualMFADeviceResponse>(await DoRequestAsync("DeleteVirtualMFADevice", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualMFADeviceWithOptions(request, runtime);
        }

        public async Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualMFADeviceWithOptionsAsync(request, runtime);
        }

        public ModifyADConnectorDirectoryResponse ModifyADConnectorDirectoryWithOptions(ModifyADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyADConnectorDirectoryResponse>(DoRequest("ModifyADConnectorDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyADConnectorDirectoryResponse> ModifyADConnectorDirectoryWithOptionsAsync(ModifyADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyADConnectorDirectoryResponse>(await DoRequestAsync("ModifyADConnectorDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyADConnectorDirectoryResponse ModifyADConnectorDirectory(ModifyADConnectorDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyADConnectorDirectoryWithOptions(request, runtime);
        }

        public async Task<ModifyADConnectorDirectoryResponse> ModifyADConnectorDirectoryAsync(ModifyADConnectorDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyADConnectorDirectoryWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRequest("ListTagResources", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRequestAsync("ListTagResources", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UntagResourcesResponse>(DoRequest("UntagResources", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRequestAsync("UntagResources", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TagResourcesResponse>(DoRequest("TagResources", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TagResourcesResponse>(await DoRequestAsync("TagResources", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public ModifyDesktopNameResponse ModifyDesktopNameWithOptions(ModifyDesktopNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDesktopNameResponse>(DoRequest("ModifyDesktopName", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyDesktopNameResponse> ModifyDesktopNameWithOptionsAsync(ModifyDesktopNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDesktopNameResponse>(await DoRequestAsync("ModifyDesktopName", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyDesktopNameResponse ModifyDesktopName(ModifyDesktopNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDesktopNameWithOptions(request, runtime);
        }

        public async Task<ModifyDesktopNameResponse> ModifyDesktopNameAsync(ModifyDesktopNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDesktopNameWithOptionsAsync(request, runtime);
        }

        public RunCommandResponse RunCommandWithOptions(RunCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunCommandResponse>(DoRequest("RunCommand", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RunCommandResponse> RunCommandWithOptionsAsync(RunCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunCommandResponse>(await DoRequestAsync("RunCommand", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public RunCommandResponse RunCommand(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCommandWithOptions(request, runtime);
        }

        public async Task<RunCommandResponse> RunCommandAsync(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCommandWithOptionsAsync(request, runtime);
        }

        public StopInvocationResponse StopInvocationWithOptions(StopInvocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopInvocationResponse>(DoRequest("StopInvocation", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopInvocationResponse> StopInvocationWithOptionsAsync(StopInvocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopInvocationResponse>(await DoRequestAsync("StopInvocation", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public StopInvocationResponse StopInvocation(StopInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInvocationWithOptions(request, runtime);
        }

        public async Task<StopInvocationResponse> StopInvocationAsync(StopInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInvocationWithOptionsAsync(request, runtime);
        }

        public DescribeInvocationsResponse DescribeInvocationsWithOptions(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInvocationsResponse>(DoRequest("DescribeInvocations", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInvocationsResponse> DescribeInvocationsWithOptionsAsync(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInvocationsResponse>(await DoRequestAsync("DescribeInvocations", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInvocationsResponse DescribeInvocations(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvocationsWithOptions(request, runtime);
        }

        public async Task<DescribeInvocationsResponse> DescribeInvocationsAsync(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvocationsWithOptionsAsync(request, runtime);
        }

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeZonesResponse>(DoRequest("DescribeZones", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeZonesResponse>(await DoRequestAsync("DescribeZones", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRequest("DescribeRegions", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRequestAsync("DescribeRegions", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeClientEventsResponse DescribeClientEventsWithOptions(DescribeClientEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClientEventsResponse>(DoRequest("DescribeClientEvents", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeClientEventsResponse> DescribeClientEventsWithOptionsAsync(DescribeClientEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClientEventsResponse>(await DoRequestAsync("DescribeClientEvents", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeClientEventsResponse DescribeClientEvents(DescribeClientEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientEventsWithOptions(request, runtime);
        }

        public async Task<DescribeClientEventsResponse> DescribeClientEventsAsync(DescribeClientEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientEventsWithOptionsAsync(request, runtime);
        }

        public ResetSnapshotResponse ResetSnapshotWithOptions(ResetSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetSnapshotResponse>(DoRequest("ResetSnapshot", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResetSnapshotResponse> ResetSnapshotWithOptionsAsync(ResetSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetSnapshotResponse>(await DoRequestAsync("ResetSnapshot", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ResetSnapshotResponse ResetSnapshot(ResetSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetSnapshotWithOptions(request, runtime);
        }

        public async Task<ResetSnapshotResponse> ResetSnapshotAsync(ResetSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetSnapshotWithOptionsAsync(request, runtime);
        }

        public DeleteSnapshotResponse DeleteSnapshotWithOptions(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSnapshotResponse>(DoRequest("DeleteSnapshot", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSnapshotResponse> DeleteSnapshotWithOptionsAsync(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSnapshotResponse>(await DoRequestAsync("DeleteSnapshot", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotWithOptions(request, runtime);
        }

        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotWithOptionsAsync(request, runtime);
        }

        public CreateSnapshotResponse CreateSnapshotWithOptions(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSnapshotResponse>(DoRequest("CreateSnapshot", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSnapshotResponse> CreateSnapshotWithOptionsAsync(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSnapshotResponse>(await DoRequestAsync("CreateSnapshot", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSnapshotWithOptions(request, runtime);
        }

        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSnapshotWithOptionsAsync(request, runtime);
        }

        public DescribeSnapshotsResponse DescribeSnapshotsWithOptions(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSnapshotsResponse>(DoRequest("DescribeSnapshots", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsWithOptionsAsync(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSnapshotsResponse>(await DoRequestAsync("DescribeSnapshots", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnapshotsWithOptions(request, runtime);
        }

        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnapshotsWithOptionsAsync(request, runtime);
        }

        public RenewDesktopsResponse RenewDesktopsWithOptions(RenewDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RenewDesktopsResponse>(DoRequest("RenewDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RenewDesktopsResponse> RenewDesktopsWithOptionsAsync(RenewDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RenewDesktopsResponse>(await DoRequestAsync("RenewDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public RenewDesktopsResponse RenewDesktops(RenewDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewDesktopsWithOptions(request, runtime);
        }

        public async Task<RenewDesktopsResponse> RenewDesktopsAsync(RenewDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewDesktopsWithOptionsAsync(request, runtime);
        }

        public StopDesktopsResponse StopDesktopsWithOptions(StopDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopDesktopsResponse>(DoRequest("StopDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopDesktopsResponse> StopDesktopsWithOptionsAsync(StopDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopDesktopsResponse>(await DoRequestAsync("StopDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public StopDesktopsResponse StopDesktops(StopDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDesktopsWithOptions(request, runtime);
        }

        public async Task<StopDesktopsResponse> StopDesktopsAsync(StopDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDesktopsWithOptionsAsync(request, runtime);
        }

        public StartDesktopsResponse StartDesktopsWithOptions(StartDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartDesktopsResponse>(DoRequest("StartDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartDesktopsResponse> StartDesktopsWithOptionsAsync(StartDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartDesktopsResponse>(await DoRequestAsync("StartDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public StartDesktopsResponse StartDesktops(StartDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDesktopsWithOptions(request, runtime);
        }

        public async Task<StartDesktopsResponse> StartDesktopsAsync(StartDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDesktopsWithOptionsAsync(request, runtime);
        }

        public ModifyPolicyGroupResponse ModifyPolicyGroupWithOptions(ModifyPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(DoRequest("ModifyPolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroupWithOptionsAsync(ModifyPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(await DoRequestAsync("ModifyPolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyPolicyGroupResponse ModifyPolicyGroup(ModifyPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolicyGroupWithOptions(request, runtime);
        }

        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroupAsync(ModifyPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolicyGroupWithOptionsAsync(request, runtime);
        }

        public DescribeDesktopTypesResponse DescribeDesktopTypesWithOptions(DescribeDesktopTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopTypesResponse>(DoRequest("DescribeDesktopTypes", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDesktopTypesResponse> DescribeDesktopTypesWithOptionsAsync(DescribeDesktopTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopTypesResponse>(await DoRequestAsync("DescribeDesktopTypes", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDesktopTypesResponse DescribeDesktopTypes(DescribeDesktopTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDesktopTypesWithOptions(request, runtime);
        }

        public async Task<DescribeDesktopTypesResponse> DescribeDesktopTypesAsync(DescribeDesktopTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDesktopTypesWithOptionsAsync(request, runtime);
        }

        public DescribeDirectoriesResponse DescribeDirectoriesWithOptions(DescribeDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDirectoriesResponse>(DoRequest("DescribeDirectories", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDirectoriesResponse> DescribeDirectoriesWithOptionsAsync(DescribeDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDirectoriesResponse>(await DoRequestAsync("DescribeDirectories", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDirectoriesWithOptions(request, runtime);
        }

        public async Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(DescribeDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDirectoriesWithOptionsAsync(request, runtime);
        }

        public DeleteDirectoriesResponse DeleteDirectoriesWithOptions(DeleteDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDirectoriesResponse>(DoRequest("DeleteDirectories", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDirectoriesResponse> DeleteDirectoriesWithOptionsAsync(DeleteDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDirectoriesResponse>(await DoRequestAsync("DeleteDirectories", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDirectoriesResponse DeleteDirectories(DeleteDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDirectoriesWithOptions(request, runtime);
        }

        public async Task<DeleteDirectoriesResponse> DeleteDirectoriesAsync(DeleteDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDirectoriesWithOptionsAsync(request, runtime);
        }

        public ListDirectoryUsersResponse ListDirectoryUsersWithOptions(ListDirectoryUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDirectoryUsersResponse>(DoRequest("ListDirectoryUsers", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDirectoryUsersResponse> ListDirectoryUsersWithOptionsAsync(ListDirectoryUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDirectoryUsersResponse>(await DoRequestAsync("ListDirectoryUsers", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ListDirectoryUsersResponse ListDirectoryUsers(ListDirectoryUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDirectoryUsersWithOptions(request, runtime);
        }

        public async Task<ListDirectoryUsersResponse> ListDirectoryUsersAsync(ListDirectoryUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDirectoryUsersWithOptionsAsync(request, runtime);
        }

        public CreateImageResponse CreateImageWithOptions(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageResponse>(DoRequest("CreateImage", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateImageResponse> CreateImageWithOptionsAsync(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageResponse>(await DoRequestAsync("CreateImage", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
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

        public CreateRAMDirectoryResponse CreateRAMDirectoryWithOptions(CreateRAMDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRAMDirectoryResponse>(DoRequest("CreateRAMDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRAMDirectoryResponse> CreateRAMDirectoryWithOptionsAsync(CreateRAMDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRAMDirectoryResponse>(await DoRequestAsync("CreateRAMDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateRAMDirectoryResponse CreateRAMDirectory(CreateRAMDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRAMDirectoryWithOptions(request, runtime);
        }

        public async Task<CreateRAMDirectoryResponse> CreateRAMDirectoryAsync(CreateRAMDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRAMDirectoryWithOptionsAsync(request, runtime);
        }

        public DeletePolicyGroupsResponse DeletePolicyGroupsWithOptions(DeletePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePolicyGroupsResponse>(DoRequest("DeletePolicyGroups", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeletePolicyGroupsResponse> DeletePolicyGroupsWithOptionsAsync(DeletePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePolicyGroupsResponse>(await DoRequestAsync("DeletePolicyGroups", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeletePolicyGroupsResponse DeletePolicyGroups(DeletePolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyGroupsWithOptions(request, runtime);
        }

        public async Task<DeletePolicyGroupsResponse> DeletePolicyGroupsAsync(DeletePolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyGroupsWithOptionsAsync(request, runtime);
        }

        public DescribePolicyGroupsResponse DescribePolicyGroupsWithOptions(DescribePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePolicyGroupsResponse>(DoRequest("DescribePolicyGroups", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribePolicyGroupsResponse> DescribePolicyGroupsWithOptionsAsync(DescribePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePolicyGroupsResponse>(await DoRequestAsync("DescribePolicyGroups", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribePolicyGroupsResponse DescribePolicyGroups(DescribePolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyGroupsWithOptions(request, runtime);
        }

        public async Task<DescribePolicyGroupsResponse> DescribePolicyGroupsAsync(DescribePolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyGroupsWithOptionsAsync(request, runtime);
        }

        public DeleteDesktopsResponse DeleteDesktopsWithOptions(DeleteDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDesktopsResponse>(DoRequest("DeleteDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDesktopsResponse> DeleteDesktopsWithOptionsAsync(DeleteDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDesktopsResponse>(await DoRequestAsync("DeleteDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDesktopsResponse DeleteDesktops(DeleteDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDesktopsWithOptions(request, runtime);
        }

        public async Task<DeleteDesktopsResponse> DeleteDesktopsAsync(DeleteDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDesktopsWithOptionsAsync(request, runtime);
        }

        public ModifyImageAttributeResponse ModifyImageAttributeWithOptions(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyImageAttributeResponse>(DoRequest("ModifyImageAttribute", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeWithOptionsAsync(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyImageAttributeResponse>(await DoRequestAsync("ModifyImageAttribute", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
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

        public ModifyEntitlementResponse ModifyEntitlementWithOptions(ModifyEntitlementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyEntitlementResponse>(DoRequest("ModifyEntitlement", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyEntitlementResponse> ModifyEntitlementWithOptionsAsync(ModifyEntitlementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyEntitlementResponse>(await DoRequestAsync("ModifyEntitlement", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyEntitlementResponse ModifyEntitlement(ModifyEntitlementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEntitlementWithOptions(request, runtime);
        }

        public async Task<ModifyEntitlementResponse> ModifyEntitlementAsync(ModifyEntitlementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEntitlementWithOptionsAsync(request, runtime);
        }

        public DeleteBundlesResponse DeleteBundlesWithOptions(DeleteBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBundlesResponse>(DoRequest("DeleteBundles", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteBundlesResponse> DeleteBundlesWithOptionsAsync(DeleteBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBundlesResponse>(await DoRequestAsync("DeleteBundles", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteBundlesResponse DeleteBundles(DeleteBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBundlesWithOptions(request, runtime);
        }

        public async Task<DeleteBundlesResponse> DeleteBundlesAsync(DeleteBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBundlesWithOptionsAsync(request, runtime);
        }

        public DescribeDesktopsResponse DescribeDesktopsWithOptions(DescribeDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopsResponse>(DoRequest("DescribeDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDesktopsResponse> DescribeDesktopsWithOptionsAsync(DescribeDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDesktopsResponse>(await DoRequestAsync("DescribeDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDesktopsResponse DescribeDesktops(DescribeDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDesktopsWithOptions(request, runtime);
        }

        public async Task<DescribeDesktopsResponse> DescribeDesktopsAsync(DescribeDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDesktopsWithOptionsAsync(request, runtime);
        }

        public RebootDesktopsResponse RebootDesktopsWithOptions(RebootDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RebootDesktopsResponse>(DoRequest("RebootDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RebootDesktopsResponse> RebootDesktopsWithOptionsAsync(RebootDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RebootDesktopsResponse>(await DoRequestAsync("RebootDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public RebootDesktopsResponse RebootDesktops(RebootDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootDesktopsWithOptions(request, runtime);
        }

        public async Task<RebootDesktopsResponse> RebootDesktopsAsync(RebootDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootDesktopsWithOptionsAsync(request, runtime);
        }

        public CreateBundleResponse CreateBundleWithOptions(CreateBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateBundleResponse>(DoRequest("CreateBundle", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateBundleResponse> CreateBundleWithOptionsAsync(CreateBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateBundleResponse>(await DoRequestAsync("CreateBundle", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateBundleResponse CreateBundle(CreateBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBundleWithOptions(request, runtime);
        }

        public async Task<CreateBundleResponse> CreateBundleAsync(CreateBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBundleWithOptionsAsync(request, runtime);
        }

        public ModifyDesktopsPolicyGroupResponse ModifyDesktopsPolicyGroupWithOptions(ModifyDesktopsPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDesktopsPolicyGroupResponse>(DoRequest("ModifyDesktopsPolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyDesktopsPolicyGroupResponse> ModifyDesktopsPolicyGroupWithOptionsAsync(ModifyDesktopsPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDesktopsPolicyGroupResponse>(await DoRequestAsync("ModifyDesktopsPolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public ModifyDesktopsPolicyGroupResponse ModifyDesktopsPolicyGroup(ModifyDesktopsPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDesktopsPolicyGroupWithOptions(request, runtime);
        }

        public async Task<ModifyDesktopsPolicyGroupResponse> ModifyDesktopsPolicyGroupAsync(ModifyDesktopsPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDesktopsPolicyGroupWithOptionsAsync(request, runtime);
        }

        public CreatePolicyGroupResponse CreatePolicyGroupWithOptions(CreatePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePolicyGroupResponse>(DoRequest("CreatePolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupWithOptionsAsync(CreatePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePolicyGroupResponse>(await DoRequestAsync("CreatePolicyGroup", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreatePolicyGroupResponse CreatePolicyGroup(CreatePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyGroupWithOptions(request, runtime);
        }

        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupAsync(CreatePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyGroupWithOptionsAsync(request, runtime);
        }

        public CreateADConnectorDirectoryResponse CreateADConnectorDirectoryWithOptions(CreateADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateADConnectorDirectoryResponse>(DoRequest("CreateADConnectorDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateADConnectorDirectoryResponse> CreateADConnectorDirectoryWithOptionsAsync(CreateADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateADConnectorDirectoryResponse>(await DoRequestAsync("CreateADConnectorDirectory", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateADConnectorDirectoryResponse CreateADConnectorDirectory(CreateADConnectorDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateADConnectorDirectoryWithOptions(request, runtime);
        }

        public async Task<CreateADConnectorDirectoryResponse> CreateADConnectorDirectoryAsync(CreateADConnectorDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateADConnectorDirectoryWithOptionsAsync(request, runtime);
        }

        public DescribeBundlesResponse DescribeBundlesWithOptions(DescribeBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBundlesResponse>(DoRequest("DescribeBundles", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeBundlesResponse> DescribeBundlesWithOptionsAsync(DescribeBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBundlesResponse>(await DoRequestAsync("DescribeBundles", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DescribeBundlesResponse DescribeBundles(DescribeBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBundlesWithOptions(request, runtime);
        }

        public async Task<DescribeBundlesResponse> DescribeBundlesAsync(DescribeBundlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBundlesWithOptionsAsync(request, runtime);
        }

        public DeleteImagesResponse DeleteImagesWithOptions(DeleteImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteImagesResponse>(DoRequest("DeleteImages", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteImagesResponse> DeleteImagesWithOptionsAsync(DeleteImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteImagesResponse>(await DoRequestAsync("DeleteImages", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public DeleteImagesResponse DeleteImages(DeleteImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImagesWithOptions(request, runtime);
        }

        public async Task<DeleteImagesResponse> DeleteImagesAsync(DeleteImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImagesWithOptionsAsync(request, runtime);
        }

        public CreateDesktopsResponse CreateDesktopsWithOptions(CreateDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDesktopsResponse>(DoRequest("CreateDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDesktopsResponse> CreateDesktopsWithOptionsAsync(CreateDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDesktopsResponse>(await DoRequestAsync("CreateDesktops", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public CreateDesktopsResponse CreateDesktops(CreateDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDesktopsWithOptions(request, runtime);
        }

        public async Task<CreateDesktopsResponse> CreateDesktopsAsync(CreateDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDesktopsWithOptionsAsync(request, runtime);
        }

        public DescribeImagesResponse DescribeImagesWithOptions(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(DoRequest("DescribeImages", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeImagesResponse> DescribeImagesWithOptionsAsync(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(await DoRequestAsync("DescribeImages", "HTTPS", "POST", "2020-09-30", "AK", null, request.ToMap(), runtime));
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
