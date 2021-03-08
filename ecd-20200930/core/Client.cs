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
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ecd", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateADConnectorDirectoryResponse CreateADConnectorDirectoryWithOptions(CreateADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateADConnectorDirectoryResponse>(DoRPCRequest("CreateADConnectorDirectory", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateADConnectorDirectoryResponse> CreateADConnectorDirectoryWithOptionsAsync(CreateADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateADConnectorDirectoryResponse>(await DoRPCRequestAsync("CreateADConnectorDirectory", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateBundleResponse CreateBundleWithOptions(CreateBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBundleResponse>(DoRPCRequest("CreateBundle", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBundleResponse> CreateBundleWithOptionsAsync(CreateBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBundleResponse>(await DoRPCRequestAsync("CreateBundle", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateDesktopsResponse CreateDesktopsWithOptions(CreateDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDesktopsResponse>(DoRPCRequest("CreateDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDesktopsResponse> CreateDesktopsWithOptionsAsync(CreateDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDesktopsResponse>(await DoRPCRequestAsync("CreateDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateImageResponse CreateImageWithOptions(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageResponse>(DoRPCRequest("CreateImage", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateImageResponse> CreateImageWithOptionsAsync(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageResponse>(await DoRPCRequestAsync("CreateImage", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreatePolicyGroupResponse CreatePolicyGroupWithOptions(CreatePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePolicyGroupResponse>(DoRPCRequest("CreatePolicyGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupWithOptionsAsync(CreatePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePolicyGroupResponse>(await DoRPCRequestAsync("CreatePolicyGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateRAMDirectoryResponse CreateRAMDirectoryWithOptions(CreateRAMDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRAMDirectoryResponse>(DoRPCRequest("CreateRAMDirectory", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRAMDirectoryResponse> CreateRAMDirectoryWithOptionsAsync(CreateRAMDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRAMDirectoryResponse>(await DoRPCRequestAsync("CreateRAMDirectory", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateSnapshotResponse CreateSnapshotWithOptions(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(DoRPCRequest("CreateSnapshot", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSnapshotResponse> CreateSnapshotWithOptionsAsync(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(await DoRPCRequestAsync("CreateSnapshot", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteBundlesResponse DeleteBundlesWithOptions(DeleteBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBundlesResponse>(DoRPCRequest("DeleteBundles", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBundlesResponse> DeleteBundlesWithOptionsAsync(DeleteBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBundlesResponse>(await DoRPCRequestAsync("DeleteBundles", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDesktopsResponse DeleteDesktopsWithOptions(DeleteDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDesktopsResponse>(DoRPCRequest("DeleteDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDesktopsResponse> DeleteDesktopsWithOptionsAsync(DeleteDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDesktopsResponse>(await DoRPCRequestAsync("DeleteDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDirectoriesResponse DeleteDirectoriesWithOptions(DeleteDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDirectoriesResponse>(DoRPCRequest("DeleteDirectories", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDirectoriesResponse> DeleteDirectoriesWithOptionsAsync(DeleteDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDirectoriesResponse>(await DoRPCRequestAsync("DeleteDirectories", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteImagesResponse DeleteImagesWithOptions(DeleteImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImagesResponse>(DoRPCRequest("DeleteImages", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteImagesResponse> DeleteImagesWithOptionsAsync(DeleteImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImagesResponse>(await DoRPCRequestAsync("DeleteImages", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeletePolicyGroupsResponse DeletePolicyGroupsWithOptions(DeletePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePolicyGroupsResponse>(DoRPCRequest("DeletePolicyGroups", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePolicyGroupsResponse> DeletePolicyGroupsWithOptionsAsync(DeletePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePolicyGroupsResponse>(await DoRPCRequestAsync("DeletePolicyGroups", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteSnapshotResponse DeleteSnapshotWithOptions(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(DoRPCRequest("DeleteSnapshot", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSnapshotResponse> DeleteSnapshotWithOptionsAsync(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(await DoRPCRequestAsync("DeleteSnapshot", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADeviceWithOptions(DeleteVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVirtualMFADeviceResponse>(DoRPCRequest("DeleteVirtualMFADevice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceWithOptionsAsync(DeleteVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVirtualMFADeviceResponse>(await DoRPCRequestAsync("DeleteVirtualMFADevice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBundlesResponse DescribeBundlesWithOptions(DescribeBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBundlesResponse>(DoRPCRequest("DescribeBundles", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBundlesResponse> DescribeBundlesWithOptionsAsync(DescribeBundlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBundlesResponse>(await DoRPCRequestAsync("DescribeBundles", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeClientEventsResponse DescribeClientEventsWithOptions(DescribeClientEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClientEventsResponse>(DoRPCRequest("DescribeClientEvents", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClientEventsResponse> DescribeClientEventsWithOptionsAsync(DescribeClientEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClientEventsResponse>(await DoRPCRequestAsync("DescribeClientEvents", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDesktopPolicysResponse DescribeDesktopPolicysWithOptions(DescribeDesktopPolicysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopPolicysResponse>(DoRPCRequest("DescribeDesktopPolicys", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDesktopPolicysResponse> DescribeDesktopPolicysWithOptionsAsync(DescribeDesktopPolicysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopPolicysResponse>(await DoRPCRequestAsync("DescribeDesktopPolicys", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDesktopPolicysResponse DescribeDesktopPolicys(DescribeDesktopPolicysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDesktopPolicysWithOptions(request, runtime);
        }

        public async Task<DescribeDesktopPolicysResponse> DescribeDesktopPolicysAsync(DescribeDesktopPolicysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDesktopPolicysWithOptionsAsync(request, runtime);
        }

        public DescribeDesktopsResponse DescribeDesktopsWithOptions(DescribeDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopsResponse>(DoRPCRequest("DescribeDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDesktopsResponse> DescribeDesktopsWithOptionsAsync(DescribeDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopsResponse>(await DoRPCRequestAsync("DescribeDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDesktopTypesResponse DescribeDesktopTypesWithOptions(DescribeDesktopTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopTypesResponse>(DoRPCRequest("DescribeDesktopTypes", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDesktopTypesResponse> DescribeDesktopTypesWithOptionsAsync(DescribeDesktopTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopTypesResponse>(await DoRPCRequestAsync("DescribeDesktopTypes", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDirectoriesResponse>(DoRPCRequest("DescribeDirectories", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDirectoriesResponse> DescribeDirectoriesWithOptionsAsync(DescribeDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDirectoriesResponse>(await DoRPCRequestAsync("DescribeDirectories", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeImagesResponse DescribeImagesWithOptions(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImagesResponse>(DoRPCRequest("DescribeImages", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImagesResponse> DescribeImagesWithOptionsAsync(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImagesResponse>(await DoRPCRequestAsync("DescribeImages", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeInvocationsResponse DescribeInvocationsWithOptions(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInvocationsResponse>(DoRPCRequest("DescribeInvocations", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInvocationsResponse> DescribeInvocationsWithOptionsAsync(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInvocationsResponse>(await DoRPCRequestAsync("DescribeInvocations", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribePolicyGroupsResponse DescribePolicyGroupsWithOptions(DescribePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePolicyGroupsResponse>(DoRPCRequest("DescribePolicyGroups", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePolicyGroupsResponse> DescribePolicyGroupsWithOptionsAsync(DescribePolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePolicyGroupsResponse>(await DoRPCRequestAsync("DescribePolicyGroups", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSnapshotsResponse DescribeSnapshotsWithOptions(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotsResponse>(DoRPCRequest("DescribeSnapshots", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsWithOptionsAsync(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotsResponse>(await DoRPCRequestAsync("DescribeSnapshots", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeVirtualMFADevicesResponse DescribeVirtualMFADevicesWithOptions(DescribeVirtualMFADevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualMFADevicesResponse>(DoRPCRequest("DescribeVirtualMFADevices", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVirtualMFADevicesResponse> DescribeVirtualMFADevicesWithOptionsAsync(DescribeVirtualMFADevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualMFADevicesResponse>(await DoRPCRequestAsync("DescribeVirtualMFADevices", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(DoRPCRequest("DescribeZones", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await DoRPCRequestAsync("DescribeZones", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DoCheckResourceResponse DoCheckResourceWithOptions(DoCheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoCheckResourceResponse>(DoRPCRequest("DoCheckResource", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoCheckResourceResponse> DoCheckResourceWithOptionsAsync(DoCheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoCheckResourceResponse>(await DoRPCRequestAsync("DoCheckResource", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoCheckResourceResponse DoCheckResource(DoCheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoCheckResourceWithOptions(request, runtime);
        }

        public async Task<DoCheckResourceResponse> DoCheckResourceAsync(DoCheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoCheckResourceWithOptionsAsync(request, runtime);
        }

        public DoLogicalDeleteResourceResponse DoLogicalDeleteResourceWithOptions(DoLogicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoLogicalDeleteResourceResponse>(DoRPCRequest("DoLogicalDeleteResource", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoLogicalDeleteResourceResponse> DoLogicalDeleteResourceWithOptionsAsync(DoLogicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoLogicalDeleteResourceResponse>(await DoRPCRequestAsync("DoLogicalDeleteResource", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoLogicalDeleteResourceResponse DoLogicalDeleteResource(DoLogicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoLogicalDeleteResourceWithOptions(request, runtime);
        }

        public async Task<DoLogicalDeleteResourceResponse> DoLogicalDeleteResourceAsync(DoLogicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoLogicalDeleteResourceWithOptionsAsync(request, runtime);
        }

        public DoPhysicalDeleteResourceResponse DoPhysicalDeleteResourceWithOptions(DoPhysicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoPhysicalDeleteResourceResponse>(DoRPCRequest("DoPhysicalDeleteResource", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoPhysicalDeleteResourceResponse> DoPhysicalDeleteResourceWithOptionsAsync(DoPhysicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoPhysicalDeleteResourceResponse>(await DoRPCRequestAsync("DoPhysicalDeleteResource", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoPhysicalDeleteResourceResponse DoPhysicalDeleteResource(DoPhysicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoPhysicalDeleteResourceWithOptions(request, runtime);
        }

        public async Task<DoPhysicalDeleteResourceResponse> DoPhysicalDeleteResourceAsync(DoPhysicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoPhysicalDeleteResourceWithOptionsAsync(request, runtime);
        }

        public GetConnectionTicketResponse GetConnectionTicketWithOptions(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(DoRPCRequest("GetConnectionTicket", "2020-09-30", "HTTP", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConnectionTicketResponse> GetConnectionTicketWithOptionsAsync(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(await DoRPCRequestAsync("GetConnectionTicket", "2020-09-30", "HTTP", "POST", "AK", "json", req, runtime));
        }

        public GetConnectionTicketResponse GetConnectionTicket(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionTicketWithOptions(request, runtime);
        }

        public async Task<GetConnectionTicketResponse> GetConnectionTicketAsync(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionTicketWithOptionsAsync(request, runtime);
        }

        public ListDirectoryUsersResponse ListDirectoryUsersWithOptions(ListDirectoryUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDirectoryUsersResponse>(DoRPCRequest("ListDirectoryUsers", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDirectoryUsersResponse> ListDirectoryUsersWithOptionsAsync(ListDirectoryUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDirectoryUsersResponse>(await DoRPCRequestAsync("ListDirectoryUsers", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public LockVirtualMFADeviceResponse LockVirtualMFADeviceWithOptions(LockVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LockVirtualMFADeviceResponse>(DoRPCRequest("LockVirtualMFADevice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LockVirtualMFADeviceResponse> LockVirtualMFADeviceWithOptionsAsync(LockVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LockVirtualMFADeviceResponse>(await DoRPCRequestAsync("LockVirtualMFADevice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyADConnectorDirectoryResponse ModifyADConnectorDirectoryWithOptions(ModifyADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyADConnectorDirectoryResponse>(DoRPCRequest("ModifyADConnectorDirectory", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyADConnectorDirectoryResponse> ModifyADConnectorDirectoryWithOptionsAsync(ModifyADConnectorDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyADConnectorDirectoryResponse>(await DoRPCRequestAsync("ModifyADConnectorDirectory", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDesktopNameResponse ModifyDesktopNameWithOptions(ModifyDesktopNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopNameResponse>(DoRPCRequest("ModifyDesktopName", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDesktopNameResponse> ModifyDesktopNameWithOptionsAsync(ModifyDesktopNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopNameResponse>(await DoRPCRequestAsync("ModifyDesktopName", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDesktopPolicysResponse ModifyDesktopPolicysWithOptions(ModifyDesktopPolicysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopPolicysResponse>(DoRPCRequest("ModifyDesktopPolicys", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDesktopPolicysResponse> ModifyDesktopPolicysWithOptionsAsync(ModifyDesktopPolicysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopPolicysResponse>(await DoRPCRequestAsync("ModifyDesktopPolicys", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDesktopPolicysResponse ModifyDesktopPolicys(ModifyDesktopPolicysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDesktopPolicysWithOptions(request, runtime);
        }

        public async Task<ModifyDesktopPolicysResponse> ModifyDesktopPolicysAsync(ModifyDesktopPolicysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDesktopPolicysWithOptionsAsync(request, runtime);
        }

        public ModifyDesktopsPolicyGroupResponse ModifyDesktopsPolicyGroupWithOptions(ModifyDesktopsPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopsPolicyGroupResponse>(DoRPCRequest("ModifyDesktopsPolicyGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDesktopsPolicyGroupResponse> ModifyDesktopsPolicyGroupWithOptionsAsync(ModifyDesktopsPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopsPolicyGroupResponse>(await DoRPCRequestAsync("ModifyDesktopsPolicyGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyEntitlementResponse ModifyEntitlementWithOptions(ModifyEntitlementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEntitlementResponse>(DoRPCRequest("ModifyEntitlement", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyEntitlementResponse> ModifyEntitlementWithOptionsAsync(ModifyEntitlementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEntitlementResponse>(await DoRPCRequestAsync("ModifyEntitlement", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyImageAttributeResponse ModifyImageAttributeWithOptions(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageAttributeResponse>(DoRPCRequest("ModifyImageAttribute", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeWithOptionsAsync(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageAttributeResponse>(await DoRPCRequestAsync("ModifyImageAttribute", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyPolicyGroupResponse ModifyPolicyGroupWithOptions(ModifyPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(DoRPCRequest("ModifyPolicyGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroupWithOptionsAsync(ModifyPolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(await DoRPCRequestAsync("ModifyPolicyGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public PayOrderCallbackResponse PayOrderCallbackWithOptions(PayOrderCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PayOrderCallbackResponse>(DoRPCRequest("PayOrderCallback", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PayOrderCallbackResponse> PayOrderCallbackWithOptionsAsync(PayOrderCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PayOrderCallbackResponse>(await DoRPCRequestAsync("PayOrderCallback", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PayOrderCallbackResponse PayOrderCallback(PayOrderCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PayOrderCallbackWithOptions(request, runtime);
        }

        public async Task<PayOrderCallbackResponse> PayOrderCallbackAsync(PayOrderCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PayOrderCallbackWithOptionsAsync(request, runtime);
        }

        public RebootDesktopsResponse RebootDesktopsWithOptions(RebootDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootDesktopsResponse>(DoRPCRequest("RebootDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RebootDesktopsResponse> RebootDesktopsWithOptionsAsync(RebootDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootDesktopsResponse>(await DoRPCRequestAsync("RebootDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RenewDesktopsResponse RenewDesktopsWithOptions(RenewDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewDesktopsResponse>(DoRPCRequest("RenewDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewDesktopsResponse> RenewDesktopsWithOptionsAsync(RenewDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewDesktopsResponse>(await DoRPCRequestAsync("RenewDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ResetSnapshotResponse ResetSnapshotWithOptions(ResetSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetSnapshotResponse>(DoRPCRequest("ResetSnapshot", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetSnapshotResponse> ResetSnapshotWithOptionsAsync(ResetSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetSnapshotResponse>(await DoRPCRequestAsync("ResetSnapshot", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RunCommandResponse RunCommandWithOptions(RunCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunCommandResponse>(DoRPCRequest("RunCommand", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunCommandResponse> RunCommandWithOptionsAsync(RunCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunCommandResponse>(await DoRPCRequestAsync("RunCommand", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StartDesktopsResponse StartDesktopsWithOptions(StartDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDesktopsResponse>(DoRPCRequest("StartDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDesktopsResponse> StartDesktopsWithOptionsAsync(StartDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDesktopsResponse>(await DoRPCRequestAsync("StartDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StopDesktopsResponse StopDesktopsWithOptions(StopDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDesktopsResponse>(DoRPCRequest("StopDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDesktopsResponse> StopDesktopsWithOptionsAsync(StopDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDesktopsResponse>(await DoRPCRequestAsync("StopDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StopInvocationResponse StopInvocationWithOptions(StopInvocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInvocationResponse>(DoRPCRequest("StopInvocation", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopInvocationResponse> StopInvocationWithOptionsAsync(StopInvocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInvocationResponse>(await DoRPCRequestAsync("StopInvocation", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UnlockVirtualMFADeviceResponse UnlockVirtualMFADeviceWithOptions(UnlockVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockVirtualMFADeviceResponse>(DoRPCRequest("UnlockVirtualMFADevice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnlockVirtualMFADeviceResponse> UnlockVirtualMFADeviceWithOptionsAsync(UnlockVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockVirtualMFADeviceResponse>(await DoRPCRequestAsync("UnlockVirtualMFADevice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

    }
}
