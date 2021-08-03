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

        public AddUserToDesktopGroupResponse AddUserToDesktopGroupWithOptions(AddUserToDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUserToDesktopGroupResponse>(DoRPCRequest("AddUserToDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddUserToDesktopGroupResponse> AddUserToDesktopGroupWithOptionsAsync(AddUserToDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUserToDesktopGroupResponse>(await DoRPCRequestAsync("AddUserToDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddUserToDesktopGroupResponse AddUserToDesktopGroup(AddUserToDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserToDesktopGroupWithOptions(request, runtime);
        }

        public async Task<AddUserToDesktopGroupResponse> AddUserToDesktopGroupAsync(AddUserToDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserToDesktopGroupWithOptionsAsync(request, runtime);
        }

        public AddUserToSecurityCenterWhiteListResponse AddUserToSecurityCenterWhiteListWithOptions(AddUserToSecurityCenterWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUserToSecurityCenterWhiteListResponse>(DoRPCRequest("AddUserToSecurityCenterWhiteList", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddUserToSecurityCenterWhiteListResponse> AddUserToSecurityCenterWhiteListWithOptionsAsync(AddUserToSecurityCenterWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUserToSecurityCenterWhiteListResponse>(await DoRPCRequestAsync("AddUserToSecurityCenterWhiteList", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddUserToSecurityCenterWhiteListResponse AddUserToSecurityCenterWhiteList(AddUserToSecurityCenterWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserToSecurityCenterWhiteListWithOptions(request, runtime);
        }

        public async Task<AddUserToSecurityCenterWhiteListResponse> AddUserToSecurityCenterWhiteListAsync(AddUserToSecurityCenterWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserToSecurityCenterWhiteListWithOptionsAsync(request, runtime);
        }

        public AttachCenResponse AttachCenWithOptions(AttachCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachCenResponse>(DoRPCRequest("AttachCen", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachCenResponse> AttachCenWithOptionsAsync(AttachCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachCenResponse>(await DoRPCRequestAsync("AttachCen", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachCenResponse AttachCen(AttachCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachCenWithOptions(request, runtime);
        }

        public async Task<AttachCenResponse> AttachCenAsync(AttachCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachCenWithOptionsAsync(request, runtime);
        }

        public CheckUserInSecurityCenterWhiteListResponse CheckUserInSecurityCenterWhiteListWithOptions(CheckUserInSecurityCenterWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckUserInSecurityCenterWhiteListResponse>(DoRPCRequest("CheckUserInSecurityCenterWhiteList", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckUserInSecurityCenterWhiteListResponse> CheckUserInSecurityCenterWhiteListWithOptionsAsync(CheckUserInSecurityCenterWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckUserInSecurityCenterWhiteListResponse>(await DoRPCRequestAsync("CheckUserInSecurityCenterWhiteList", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckUserInSecurityCenterWhiteListResponse CheckUserInSecurityCenterWhiteList(CheckUserInSecurityCenterWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckUserInSecurityCenterWhiteListWithOptions(request, runtime);
        }

        public async Task<CheckUserInSecurityCenterWhiteListResponse> CheckUserInSecurityCenterWhiteListAsync(CheckUserInSecurityCenterWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckUserInSecurityCenterWhiteListWithOptionsAsync(request, runtime);
        }

        public ClonePolicyGroupResponse ClonePolicyGroupWithOptions(ClonePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClonePolicyGroupResponse>(DoRPCRequest("ClonePolicyGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClonePolicyGroupResponse> ClonePolicyGroupWithOptionsAsync(ClonePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClonePolicyGroupResponse>(await DoRPCRequestAsync("ClonePolicyGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ClonePolicyGroupResponse ClonePolicyGroup(ClonePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClonePolicyGroupWithOptions(request, runtime);
        }

        public async Task<ClonePolicyGroupResponse> ClonePolicyGroupAsync(ClonePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClonePolicyGroupWithOptionsAsync(request, runtime);
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

        public CreateADConnectorOfficeSiteResponse CreateADConnectorOfficeSiteWithOptions(CreateADConnectorOfficeSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateADConnectorOfficeSiteResponse>(DoRPCRequest("CreateADConnectorOfficeSite", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateADConnectorOfficeSiteResponse> CreateADConnectorOfficeSiteWithOptionsAsync(CreateADConnectorOfficeSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateADConnectorOfficeSiteResponse>(await DoRPCRequestAsync("CreateADConnectorOfficeSite", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateADConnectorOfficeSiteResponse CreateADConnectorOfficeSite(CreateADConnectorOfficeSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateADConnectorOfficeSiteWithOptions(request, runtime);
        }

        public async Task<CreateADConnectorOfficeSiteResponse> CreateADConnectorOfficeSiteAsync(CreateADConnectorOfficeSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateADConnectorOfficeSiteWithOptionsAsync(request, runtime);
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

        public CreateDesktopGroupResponse CreateDesktopGroupWithOptions(CreateDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDesktopGroupResponse>(DoRPCRequest("CreateDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDesktopGroupResponse> CreateDesktopGroupWithOptionsAsync(CreateDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDesktopGroupResponse>(await DoRPCRequestAsync("CreateDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDesktopGroupResponse CreateDesktopGroup(CreateDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDesktopGroupWithOptions(request, runtime);
        }

        public async Task<CreateDesktopGroupResponse> CreateDesktopGroupAsync(CreateDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDesktopGroupWithOptionsAsync(request, runtime);
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

        public CreateDesktopsLiteResponse CreateDesktopsLiteWithOptions(CreateDesktopsLiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDesktopsLiteResponse>(DoRPCRequest("CreateDesktopsLite", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDesktopsLiteResponse> CreateDesktopsLiteWithOptionsAsync(CreateDesktopsLiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDesktopsLiteResponse>(await DoRPCRequestAsync("CreateDesktopsLite", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDesktopsLiteResponse CreateDesktopsLite(CreateDesktopsLiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDesktopsLiteWithOptions(request, runtime);
        }

        public async Task<CreateDesktopsLiteResponse> CreateDesktopsLiteAsync(CreateDesktopsLiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDesktopsLiteWithOptionsAsync(request, runtime);
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

        public CreateNASFileSystemResponse CreateNASFileSystemWithOptions(CreateNASFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNASFileSystemResponse>(DoRPCRequest("CreateNASFileSystem", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNASFileSystemResponse> CreateNASFileSystemWithOptionsAsync(CreateNASFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNASFileSystemResponse>(await DoRPCRequestAsync("CreateNASFileSystem", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNASFileSystemResponse CreateNASFileSystem(CreateNASFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNASFileSystemWithOptions(request, runtime);
        }

        public async Task<CreateNASFileSystemResponse> CreateNASFileSystemAsync(CreateNASFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNASFileSystemWithOptionsAsync(request, runtime);
        }

        public CreateNetworkPackageResponse CreateNetworkPackageWithOptions(CreateNetworkPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkPackageResponse>(DoRPCRequest("CreateNetworkPackage", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNetworkPackageResponse> CreateNetworkPackageWithOptionsAsync(CreateNetworkPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkPackageResponse>(await DoRPCRequestAsync("CreateNetworkPackage", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNetworkPackageResponse CreateNetworkPackage(CreateNetworkPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkPackageWithOptions(request, runtime);
        }

        public async Task<CreateNetworkPackageResponse> CreateNetworkPackageAsync(CreateNetworkPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkPackageWithOptionsAsync(request, runtime);
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

        public CreateScaleStrategyResponse CreateScaleStrategyWithOptions(CreateScaleStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScaleStrategyResponse>(DoRPCRequest("CreateScaleStrategy", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScaleStrategyResponse> CreateScaleStrategyWithOptionsAsync(CreateScaleStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScaleStrategyResponse>(await DoRPCRequestAsync("CreateScaleStrategy", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScaleStrategyResponse CreateScaleStrategy(CreateScaleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScaleStrategyWithOptions(request, runtime);
        }

        public async Task<CreateScaleStrategyResponse> CreateScaleStrategyAsync(CreateScaleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScaleStrategyWithOptionsAsync(request, runtime);
        }

        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleWithOptions(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(DoRPCRequest("CreateServiceLinkedRole", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleWithOptionsAsync(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(await DoRPCRequestAsync("CreateServiceLinkedRole", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateServiceLinkedRoleResponse CreateServiceLinkedRole(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public CreateSimpleOfficeSiteResponse CreateSimpleOfficeSiteWithOptions(CreateSimpleOfficeSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSimpleOfficeSiteResponse>(DoRPCRequest("CreateSimpleOfficeSite", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSimpleOfficeSiteResponse> CreateSimpleOfficeSiteWithOptionsAsync(CreateSimpleOfficeSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSimpleOfficeSiteResponse>(await DoRPCRequestAsync("CreateSimpleOfficeSite", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSimpleOfficeSiteResponse CreateSimpleOfficeSite(CreateSimpleOfficeSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSimpleOfficeSiteWithOptions(request, runtime);
        }

        public async Task<CreateSimpleOfficeSiteResponse> CreateSimpleOfficeSiteAsync(CreateSimpleOfficeSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSimpleOfficeSiteWithOptionsAsync(request, runtime);
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

        public DeleteDesktopGroupResponse DeleteDesktopGroupWithOptions(DeleteDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDesktopGroupResponse>(DoRPCRequest("DeleteDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDesktopGroupResponse> DeleteDesktopGroupWithOptionsAsync(DeleteDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDesktopGroupResponse>(await DoRPCRequestAsync("DeleteDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDesktopGroupResponse DeleteDesktopGroup(DeleteDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDesktopGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDesktopGroupResponse> DeleteDesktopGroupAsync(DeleteDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDesktopGroupWithOptionsAsync(request, runtime);
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

        public DeleteNASFileSystemsResponse DeleteNASFileSystemsWithOptions(DeleteNASFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNASFileSystemsResponse>(DoRPCRequest("DeleteNASFileSystems", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNASFileSystemsResponse> DeleteNASFileSystemsWithOptionsAsync(DeleteNASFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNASFileSystemsResponse>(await DoRPCRequestAsync("DeleteNASFileSystems", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNASFileSystemsResponse DeleteNASFileSystems(DeleteNASFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNASFileSystemsWithOptions(request, runtime);
        }

        public async Task<DeleteNASFileSystemsResponse> DeleteNASFileSystemsAsync(DeleteNASFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNASFileSystemsWithOptionsAsync(request, runtime);
        }

        public DeleteNetworkPackagesResponse DeleteNetworkPackagesWithOptions(DeleteNetworkPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkPackagesResponse>(DoRPCRequest("DeleteNetworkPackages", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNetworkPackagesResponse> DeleteNetworkPackagesWithOptionsAsync(DeleteNetworkPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkPackagesResponse>(await DoRPCRequestAsync("DeleteNetworkPackages", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNetworkPackagesResponse DeleteNetworkPackages(DeleteNetworkPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkPackagesWithOptions(request, runtime);
        }

        public async Task<DeleteNetworkPackagesResponse> DeleteNetworkPackagesAsync(DeleteNetworkPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkPackagesWithOptionsAsync(request, runtime);
        }

        public DeleteOfficeSitesResponse DeleteOfficeSitesWithOptions(DeleteOfficeSitesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOfficeSitesResponse>(DoRPCRequest("DeleteOfficeSites", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteOfficeSitesResponse> DeleteOfficeSitesWithOptionsAsync(DeleteOfficeSitesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOfficeSitesResponse>(await DoRPCRequestAsync("DeleteOfficeSites", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteOfficeSitesResponse DeleteOfficeSites(DeleteOfficeSitesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOfficeSitesWithOptions(request, runtime);
        }

        public async Task<DeleteOfficeSitesResponse> DeleteOfficeSitesAsync(DeleteOfficeSitesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOfficeSitesWithOptionsAsync(request, runtime);
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

        public DeleteScaleStrategyResponse DeleteScaleStrategyWithOptions(DeleteScaleStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScaleStrategyResponse>(DoRPCRequest("DeleteScaleStrategy", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteScaleStrategyResponse> DeleteScaleStrategyWithOptionsAsync(DeleteScaleStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScaleStrategyResponse>(await DoRPCRequestAsync("DeleteScaleStrategy", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteScaleStrategyResponse DeleteScaleStrategy(DeleteScaleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScaleStrategyWithOptions(request, runtime);
        }

        public async Task<DeleteScaleStrategyResponse> DeleteScaleStrategyAsync(DeleteScaleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScaleStrategyWithOptionsAsync(request, runtime);
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

        public DescribeAlarmEventStackInfoResponse DescribeAlarmEventStackInfoWithOptions(DescribeAlarmEventStackInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlarmEventStackInfoResponse>(DoRPCRequest("DescribeAlarmEventStackInfo", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlarmEventStackInfoResponse> DescribeAlarmEventStackInfoWithOptionsAsync(DescribeAlarmEventStackInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlarmEventStackInfoResponse>(await DoRPCRequestAsync("DescribeAlarmEventStackInfo", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlarmEventStackInfoResponse DescribeAlarmEventStackInfo(DescribeAlarmEventStackInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlarmEventStackInfoWithOptions(request, runtime);
        }

        public async Task<DescribeAlarmEventStackInfoResponse> DescribeAlarmEventStackInfoAsync(DescribeAlarmEventStackInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlarmEventStackInfoWithOptionsAsync(request, runtime);
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

        public DescribeCensResponse DescribeCensWithOptions(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCensResponse>(DoRPCRequest("DescribeCens", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCensResponse> DescribeCensWithOptionsAsync(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCensResponse>(await DoRPCRequestAsync("DescribeCens", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCensResponse DescribeCens(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCensWithOptions(request, runtime);
        }

        public async Task<DescribeCensResponse> DescribeCensAsync(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCensWithOptionsAsync(request, runtime);
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

        public DescribeDesktopIdsByVulNamesResponse DescribeDesktopIdsByVulNamesWithOptions(DescribeDesktopIdsByVulNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopIdsByVulNamesResponse>(DoRPCRequest("DescribeDesktopIdsByVulNames", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDesktopIdsByVulNamesResponse> DescribeDesktopIdsByVulNamesWithOptionsAsync(DescribeDesktopIdsByVulNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopIdsByVulNamesResponse>(await DoRPCRequestAsync("DescribeDesktopIdsByVulNames", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDesktopIdsByVulNamesResponse DescribeDesktopIdsByVulNames(DescribeDesktopIdsByVulNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDesktopIdsByVulNamesWithOptions(request, runtime);
        }

        public async Task<DescribeDesktopIdsByVulNamesResponse> DescribeDesktopIdsByVulNamesAsync(DescribeDesktopIdsByVulNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDesktopIdsByVulNamesWithOptionsAsync(request, runtime);
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

        public DescribeDesktopsInGroupResponse DescribeDesktopsInGroupWithOptions(DescribeDesktopsInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopsInGroupResponse>(DoRPCRequest("DescribeDesktopsInGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDesktopsInGroupResponse> DescribeDesktopsInGroupWithOptionsAsync(DescribeDesktopsInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDesktopsInGroupResponse>(await DoRPCRequestAsync("DescribeDesktopsInGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDesktopsInGroupResponse DescribeDesktopsInGroup(DescribeDesktopsInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDesktopsInGroupWithOptions(request, runtime);
        }

        public async Task<DescribeDesktopsInGroupResponse> DescribeDesktopsInGroupAsync(DescribeDesktopsInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDesktopsInGroupWithOptionsAsync(request, runtime);
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

        public DescribeFrontVulPatchListResponse DescribeFrontVulPatchListWithOptions(DescribeFrontVulPatchListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFrontVulPatchListResponse>(DoRPCRequest("DescribeFrontVulPatchList", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFrontVulPatchListResponse> DescribeFrontVulPatchListWithOptionsAsync(DescribeFrontVulPatchListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFrontVulPatchListResponse>(await DoRPCRequestAsync("DescribeFrontVulPatchList", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFrontVulPatchListResponse DescribeFrontVulPatchList(DescribeFrontVulPatchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFrontVulPatchListWithOptions(request, runtime);
        }

        public async Task<DescribeFrontVulPatchListResponse> DescribeFrontVulPatchListAsync(DescribeFrontVulPatchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFrontVulPatchListWithOptionsAsync(request, runtime);
        }

        public DescribeGroupedVulResponse DescribeGroupedVulWithOptions(DescribeGroupedVulRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedVulResponse>(DoRPCRequest("DescribeGroupedVul", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupedVulResponse> DescribeGroupedVulWithOptionsAsync(DescribeGroupedVulRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedVulResponse>(await DoRPCRequestAsync("DescribeGroupedVul", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupedVulResponse DescribeGroupedVul(DescribeGroupedVulRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupedVulWithOptions(request, runtime);
        }

        public async Task<DescribeGroupedVulResponse> DescribeGroupedVulAsync(DescribeGroupedVulRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupedVulWithOptionsAsync(request, runtime);
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

        public DescribeModificationPriceResponse DescribeModificationPriceWithOptions(DescribeModificationPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeModificationPriceResponse>(DoRPCRequest("DescribeModificationPrice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeModificationPriceResponse> DescribeModificationPriceWithOptionsAsync(DescribeModificationPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeModificationPriceResponse>(await DoRPCRequestAsync("DescribeModificationPrice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeModificationPriceResponse DescribeModificationPrice(DescribeModificationPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModificationPriceWithOptions(request, runtime);
        }

        public async Task<DescribeModificationPriceResponse> DescribeModificationPriceAsync(DescribeModificationPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModificationPriceWithOptionsAsync(request, runtime);
        }

        public DescribeNASFileSystemsResponse DescribeNASFileSystemsWithOptions(DescribeNASFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNASFileSystemsResponse>(DoRPCRequest("DescribeNASFileSystems", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNASFileSystemsResponse> DescribeNASFileSystemsWithOptionsAsync(DescribeNASFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNASFileSystemsResponse>(await DoRPCRequestAsync("DescribeNASFileSystems", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNASFileSystemsResponse DescribeNASFileSystems(DescribeNASFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNASFileSystemsWithOptions(request, runtime);
        }

        public async Task<DescribeNASFileSystemsResponse> DescribeNASFileSystemsAsync(DescribeNASFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNASFileSystemsWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkPackagesResponse DescribeNetworkPackagesWithOptions(DescribeNetworkPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkPackagesResponse>(DoRPCRequest("DescribeNetworkPackages", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkPackagesResponse> DescribeNetworkPackagesWithOptionsAsync(DescribeNetworkPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkPackagesResponse>(await DoRPCRequestAsync("DescribeNetworkPackages", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkPackagesResponse DescribeNetworkPackages(DescribeNetworkPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkPackagesWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkPackagesResponse> DescribeNetworkPackagesAsync(DescribeNetworkPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkPackagesWithOptionsAsync(request, runtime);
        }

        public DescribeOfficeSitesResponse DescribeOfficeSitesWithOptions(DescribeOfficeSitesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOfficeSitesResponse>(DoRPCRequest("DescribeOfficeSites", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOfficeSitesResponse> DescribeOfficeSitesWithOptionsAsync(DescribeOfficeSitesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOfficeSitesResponse>(await DoRPCRequestAsync("DescribeOfficeSites", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOfficeSitesResponse DescribeOfficeSites(DescribeOfficeSitesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOfficeSitesWithOptions(request, runtime);
        }

        public async Task<DescribeOfficeSitesResponse> DescribeOfficeSitesAsync(DescribeOfficeSitesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOfficeSitesWithOptionsAsync(request, runtime);
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

        public DescribePostPaidDesktopBillsResponse DescribePostPaidDesktopBillsWithOptions(DescribePostPaidDesktopBillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePostPaidDesktopBillsResponse>(DoRPCRequest("DescribePostPaidDesktopBills", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePostPaidDesktopBillsResponse> DescribePostPaidDesktopBillsWithOptionsAsync(DescribePostPaidDesktopBillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePostPaidDesktopBillsResponse>(await DoRPCRequestAsync("DescribePostPaidDesktopBills", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePostPaidDesktopBillsResponse DescribePostPaidDesktopBills(DescribePostPaidDesktopBillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePostPaidDesktopBillsWithOptions(request, runtime);
        }

        public async Task<DescribePostPaidDesktopBillsResponse> DescribePostPaidDesktopBillsAsync(DescribePostPaidDesktopBillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePostPaidDesktopBillsWithOptionsAsync(request, runtime);
        }

        public DescribePriceResponse DescribePriceWithOptions(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePriceResponse>(DoRPCRequest("DescribePrice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePriceResponse>(await DoRPCRequestAsync("DescribePrice", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeScaleStrategysResponse DescribeScaleStrategysWithOptions(DescribeScaleStrategysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScaleStrategysResponse>(DoRPCRequest("DescribeScaleStrategys", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScaleStrategysResponse> DescribeScaleStrategysWithOptionsAsync(DescribeScaleStrategysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScaleStrategysResponse>(await DoRPCRequestAsync("DescribeScaleStrategys", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScaleStrategysResponse DescribeScaleStrategys(DescribeScaleStrategysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScaleStrategysWithOptions(request, runtime);
        }

        public async Task<DescribeScaleStrategysResponse> DescribeScaleStrategysAsync(DescribeScaleStrategysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScaleStrategysWithOptionsAsync(request, runtime);
        }

        public DescribeScanTaskProgressResponse DescribeScanTaskProgressWithOptions(DescribeScanTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScanTaskProgressResponse>(DoRPCRequest("DescribeScanTaskProgress", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScanTaskProgressResponse> DescribeScanTaskProgressWithOptionsAsync(DescribeScanTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScanTaskProgressResponse>(await DoRPCRequestAsync("DescribeScanTaskProgress", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScanTaskProgressResponse DescribeScanTaskProgress(DescribeScanTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScanTaskProgressWithOptions(request, runtime);
        }

        public async Task<DescribeScanTaskProgressResponse> DescribeScanTaskProgressAsync(DescribeScanTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScanTaskProgressWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityEventOperationsResponse DescribeSecurityEventOperationsWithOptions(DescribeSecurityEventOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationsResponse>(DoRPCRequest("DescribeSecurityEventOperations", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityEventOperationsResponse> DescribeSecurityEventOperationsWithOptionsAsync(DescribeSecurityEventOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationsResponse>(await DoRPCRequestAsync("DescribeSecurityEventOperations", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityEventOperationsResponse DescribeSecurityEventOperations(DescribeSecurityEventOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityEventOperationsWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityEventOperationsResponse> DescribeSecurityEventOperationsAsync(DescribeSecurityEventOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityEventOperationsWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityEventOperationStatusResponse DescribeSecurityEventOperationStatusWithOptions(DescribeSecurityEventOperationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationStatusResponse>(DoRPCRequest("DescribeSecurityEventOperationStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityEventOperationStatusResponse> DescribeSecurityEventOperationStatusWithOptionsAsync(DescribeSecurityEventOperationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationStatusResponse>(await DoRPCRequestAsync("DescribeSecurityEventOperationStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityEventOperationStatusResponse DescribeSecurityEventOperationStatus(DescribeSecurityEventOperationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityEventOperationStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityEventOperationStatusResponse> DescribeSecurityEventOperationStatusAsync(DescribeSecurityEventOperationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityEventOperationStatusWithOptionsAsync(request, runtime);
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

        public DescribeSuspEventOverviewResponse DescribeSuspEventOverviewWithOptions(DescribeSuspEventOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventOverviewResponse>(DoRPCRequest("DescribeSuspEventOverview", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSuspEventOverviewResponse> DescribeSuspEventOverviewWithOptionsAsync(DescribeSuspEventOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventOverviewResponse>(await DoRPCRequestAsync("DescribeSuspEventOverview", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSuspEventOverviewResponse DescribeSuspEventOverview(DescribeSuspEventOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSuspEventOverviewWithOptions(request, runtime);
        }

        public async Task<DescribeSuspEventOverviewResponse> DescribeSuspEventOverviewAsync(DescribeSuspEventOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSuspEventOverviewWithOptionsAsync(request, runtime);
        }

        public DescribeSuspEventQuaraFilesResponse DescribeSuspEventQuaraFilesWithOptions(DescribeSuspEventQuaraFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventQuaraFilesResponse>(DoRPCRequest("DescribeSuspEventQuaraFiles", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSuspEventQuaraFilesResponse> DescribeSuspEventQuaraFilesWithOptionsAsync(DescribeSuspEventQuaraFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventQuaraFilesResponse>(await DoRPCRequestAsync("DescribeSuspEventQuaraFiles", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSuspEventQuaraFilesResponse DescribeSuspEventQuaraFiles(DescribeSuspEventQuaraFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSuspEventQuaraFilesWithOptions(request, runtime);
        }

        public async Task<DescribeSuspEventQuaraFilesResponse> DescribeSuspEventQuaraFilesAsync(DescribeSuspEventQuaraFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSuspEventQuaraFilesWithOptionsAsync(request, runtime);
        }

        public DescribeSuspEventsResponse DescribeSuspEventsWithOptions(DescribeSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(DoRPCRequest("DescribeSuspEvents", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsWithOptionsAsync(DescribeSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(await DoRPCRequestAsync("DescribeSuspEvents", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSuspEventsResponse DescribeSuspEvents(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSuspEventsWithOptions(request, runtime);
        }

        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsAsync(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSuspEventsWithOptionsAsync(request, runtime);
        }

        public DescribeUserConnectionRecordsResponse DescribeUserConnectionRecordsWithOptions(DescribeUserConnectionRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserConnectionRecordsResponse>(DoRPCRequest("DescribeUserConnectionRecords", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserConnectionRecordsResponse> DescribeUserConnectionRecordsWithOptionsAsync(DescribeUserConnectionRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserConnectionRecordsResponse>(await DoRPCRequestAsync("DescribeUserConnectionRecords", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserConnectionRecordsResponse DescribeUserConnectionRecords(DescribeUserConnectionRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserConnectionRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeUserConnectionRecordsResponse> DescribeUserConnectionRecordsAsync(DescribeUserConnectionRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserConnectionRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeUsersInGroupResponse DescribeUsersInGroupWithOptions(DescribeUsersInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUsersInGroupResponse>(DoRPCRequest("DescribeUsersInGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUsersInGroupResponse> DescribeUsersInGroupWithOptionsAsync(DescribeUsersInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUsersInGroupResponse>(await DoRPCRequestAsync("DescribeUsersInGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUsersInGroupResponse DescribeUsersInGroup(DescribeUsersInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsersInGroupWithOptions(request, runtime);
        }

        public async Task<DescribeUsersInGroupResponse> DescribeUsersInGroupAsync(DescribeUsersInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsersInGroupWithOptionsAsync(request, runtime);
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

        public DescribeVulDetailsResponse DescribeVulDetailsWithOptions(DescribeVulDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulDetailsResponse>(DoRPCRequest("DescribeVulDetails", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVulDetailsResponse> DescribeVulDetailsWithOptionsAsync(DescribeVulDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulDetailsResponse>(await DoRPCRequestAsync("DescribeVulDetails", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVulDetailsResponse DescribeVulDetails(DescribeVulDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVulDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeVulDetailsResponse> DescribeVulDetailsAsync(DescribeVulDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVulDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeVulListResponse DescribeVulListWithOptions(DescribeVulListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulListResponse>(DoRPCRequest("DescribeVulList", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVulListResponse> DescribeVulListWithOptionsAsync(DescribeVulListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulListResponse>(await DoRPCRequestAsync("DescribeVulList", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVulListResponse DescribeVulList(DescribeVulListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVulListWithOptions(request, runtime);
        }

        public async Task<DescribeVulListResponse> DescribeVulListAsync(DescribeVulListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVulListWithOptionsAsync(request, runtime);
        }

        public DescribeVulOverviewResponse DescribeVulOverviewWithOptions(DescribeVulOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulOverviewResponse>(DoRPCRequest("DescribeVulOverview", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVulOverviewResponse> DescribeVulOverviewWithOptionsAsync(DescribeVulOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulOverviewResponse>(await DoRPCRequestAsync("DescribeVulOverview", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVulOverviewResponse DescribeVulOverview(DescribeVulOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVulOverviewWithOptions(request, runtime);
        }

        public async Task<DescribeVulOverviewResponse> DescribeVulOverviewAsync(DescribeVulOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVulOverviewWithOptionsAsync(request, runtime);
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

        public DetachCenResponse DetachCenWithOptions(DetachCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachCenResponse>(DoRPCRequest("DetachCen", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachCenResponse> DetachCenWithOptionsAsync(DetachCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachCenResponse>(await DoRPCRequestAsync("DetachCen", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachCenResponse DetachCen(DetachCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachCenWithOptions(request, runtime);
        }

        public async Task<DetachCenResponse> DetachCenAsync(DetachCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachCenWithOptionsAsync(request, runtime);
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

        public GetDesktopGroupDetailResponse GetDesktopGroupDetailWithOptions(GetDesktopGroupDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDesktopGroupDetailResponse>(DoRPCRequest("GetDesktopGroupDetail", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDesktopGroupDetailResponse> GetDesktopGroupDetailWithOptionsAsync(GetDesktopGroupDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDesktopGroupDetailResponse>(await DoRPCRequestAsync("GetDesktopGroupDetail", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDesktopGroupDetailResponse GetDesktopGroupDetail(GetDesktopGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDesktopGroupDetailWithOptions(request, runtime);
        }

        public async Task<GetDesktopGroupDetailResponse> GetDesktopGroupDetailAsync(GetDesktopGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDesktopGroupDetailWithOptionsAsync(request, runtime);
        }

        public GetDesktopUsersResponse GetDesktopUsersWithOptions(GetDesktopUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDesktopUsersResponse>(DoRPCRequest("GetDesktopUsers", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDesktopUsersResponse> GetDesktopUsersWithOptionsAsync(GetDesktopUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDesktopUsersResponse>(await DoRPCRequestAsync("GetDesktopUsers", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDesktopUsersResponse GetDesktopUsers(GetDesktopUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDesktopUsersWithOptions(request, runtime);
        }

        public async Task<GetDesktopUsersResponse> GetDesktopUsersAsync(GetDesktopUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDesktopUsersWithOptionsAsync(request, runtime);
        }

        public GetDirectorySsoStatusResponse GetDirectorySsoStatusWithOptions(GetDirectorySsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDirectorySsoStatusResponse>(DoRPCRequest("GetDirectorySsoStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDirectorySsoStatusResponse> GetDirectorySsoStatusWithOptionsAsync(GetDirectorySsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDirectorySsoStatusResponse>(await DoRPCRequestAsync("GetDirectorySsoStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetOfficeSiteSsoStatusResponse GetOfficeSiteSsoStatusWithOptions(GetOfficeSiteSsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOfficeSiteSsoStatusResponse>(DoRPCRequest("GetOfficeSiteSsoStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOfficeSiteSsoStatusResponse> GetOfficeSiteSsoStatusWithOptionsAsync(GetOfficeSiteSsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOfficeSiteSsoStatusResponse>(await DoRPCRequestAsync("GetOfficeSiteSsoStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOfficeSiteSsoStatusResponse GetOfficeSiteSsoStatus(GetOfficeSiteSsoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOfficeSiteSsoStatusWithOptions(request, runtime);
        }

        public async Task<GetOfficeSiteSsoStatusResponse> GetOfficeSiteSsoStatusAsync(GetOfficeSiteSsoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOfficeSiteSsoStatusWithOptionsAsync(request, runtime);
        }

        public GetSpMetadataResponse GetSpMetadataWithOptions(GetSpMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSpMetadataResponse>(DoRPCRequest("GetSpMetadata", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSpMetadataResponse> GetSpMetadataWithOptionsAsync(GetSpMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSpMetadataResponse>(await DoRPCRequestAsync("GetSpMetadata", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public HandleSecurityEventsResponse HandleSecurityEventsWithOptions(HandleSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HandleSecurityEventsResponse>(DoRPCRequest("HandleSecurityEvents", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HandleSecurityEventsResponse> HandleSecurityEventsWithOptionsAsync(HandleSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HandleSecurityEventsResponse>(await DoRPCRequestAsync("HandleSecurityEvents", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HandleSecurityEventsResponse HandleSecurityEvents(HandleSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HandleSecurityEventsWithOptions(request, runtime);
        }

        public async Task<HandleSecurityEventsResponse> HandleSecurityEventsAsync(HandleSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HandleSecurityEventsWithOptionsAsync(request, runtime);
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

        public ListOfficeSiteOverviewResponse ListOfficeSiteOverviewWithOptions(ListOfficeSiteOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOfficeSiteOverviewResponse>(DoRPCRequest("ListOfficeSiteOverview", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOfficeSiteOverviewResponse> ListOfficeSiteOverviewWithOptionsAsync(ListOfficeSiteOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOfficeSiteOverviewResponse>(await DoRPCRequestAsync("ListOfficeSiteOverview", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOfficeSiteOverviewResponse ListOfficeSiteOverview(ListOfficeSiteOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOfficeSiteOverviewWithOptions(request, runtime);
        }

        public async Task<ListOfficeSiteOverviewResponse> ListOfficeSiteOverviewAsync(ListOfficeSiteOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOfficeSiteOverviewWithOptionsAsync(request, runtime);
        }

        public ListOfficeSiteUsersResponse ListOfficeSiteUsersWithOptions(ListOfficeSiteUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOfficeSiteUsersResponse>(DoRPCRequest("ListOfficeSiteUsers", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOfficeSiteUsersResponse> ListOfficeSiteUsersWithOptionsAsync(ListOfficeSiteUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOfficeSiteUsersResponse>(await DoRPCRequestAsync("ListOfficeSiteUsers", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOfficeSiteUsersResponse ListOfficeSiteUsers(ListOfficeSiteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOfficeSiteUsersWithOptions(request, runtime);
        }

        public async Task<ListOfficeSiteUsersResponse> ListOfficeSiteUsersAsync(ListOfficeSiteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOfficeSiteUsersWithOptionsAsync(request, runtime);
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

        public ModifyADConnectorOfficeSiteResponse ModifyADConnectorOfficeSiteWithOptions(ModifyADConnectorOfficeSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyADConnectorOfficeSiteResponse>(DoRPCRequest("ModifyADConnectorOfficeSite", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyADConnectorOfficeSiteResponse> ModifyADConnectorOfficeSiteWithOptionsAsync(ModifyADConnectorOfficeSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyADConnectorOfficeSiteResponse>(await DoRPCRequestAsync("ModifyADConnectorOfficeSite", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyADConnectorOfficeSiteResponse ModifyADConnectorOfficeSite(ModifyADConnectorOfficeSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyADConnectorOfficeSiteWithOptions(request, runtime);
        }

        public async Task<ModifyADConnectorOfficeSiteResponse> ModifyADConnectorOfficeSiteAsync(ModifyADConnectorOfficeSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyADConnectorOfficeSiteWithOptionsAsync(request, runtime);
        }

        public ModifyBundleResponse ModifyBundleWithOptions(ModifyBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBundleResponse>(DoRPCRequest("ModifyBundle", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBundleResponse> ModifyBundleWithOptionsAsync(ModifyBundleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBundleResponse>(await DoRPCRequestAsync("ModifyBundle", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDesktopGroupResponse ModifyDesktopGroupWithOptions(ModifyDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopGroupResponse>(DoRPCRequest("ModifyDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDesktopGroupResponse> ModifyDesktopGroupWithOptionsAsync(ModifyDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopGroupResponse>(await DoRPCRequestAsync("ModifyDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDesktopGroupResponse ModifyDesktopGroup(ModifyDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDesktopGroupWithOptions(request, runtime);
        }

        public async Task<ModifyDesktopGroupResponse> ModifyDesktopGroupAsync(ModifyDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDesktopGroupWithOptionsAsync(request, runtime);
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

        public ModifyDesktopSpecResponse ModifyDesktopSpecWithOptions(ModifyDesktopSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopSpecResponse>(DoRPCRequest("ModifyDesktopSpec", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDesktopSpecResponse> ModifyDesktopSpecWithOptionsAsync(ModifyDesktopSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDesktopSpecResponse>(await DoRPCRequestAsync("ModifyDesktopSpec", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDesktopSpecResponse ModifyDesktopSpec(ModifyDesktopSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDesktopSpecWithOptions(request, runtime);
        }

        public async Task<ModifyDesktopSpecResponse> ModifyDesktopSpecAsync(ModifyDesktopSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDesktopSpecWithOptionsAsync(request, runtime);
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

        public ModifyNASDefaultMountTargetResponse ModifyNASDefaultMountTargetWithOptions(ModifyNASDefaultMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNASDefaultMountTargetResponse>(DoRPCRequest("ModifyNASDefaultMountTarget", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNASDefaultMountTargetResponse> ModifyNASDefaultMountTargetWithOptionsAsync(ModifyNASDefaultMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNASDefaultMountTargetResponse>(await DoRPCRequestAsync("ModifyNASDefaultMountTarget", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNASDefaultMountTargetResponse ModifyNASDefaultMountTarget(ModifyNASDefaultMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNASDefaultMountTargetWithOptions(request, runtime);
        }

        public async Task<ModifyNASDefaultMountTargetResponse> ModifyNASDefaultMountTargetAsync(ModifyNASDefaultMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNASDefaultMountTargetWithOptionsAsync(request, runtime);
        }

        public ModifyNetworkPackageResponse ModifyNetworkPackageWithOptions(ModifyNetworkPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkPackageResponse>(DoRPCRequest("ModifyNetworkPackage", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNetworkPackageResponse> ModifyNetworkPackageWithOptionsAsync(ModifyNetworkPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkPackageResponse>(await DoRPCRequestAsync("ModifyNetworkPackage", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNetworkPackageResponse ModifyNetworkPackage(ModifyNetworkPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNetworkPackageWithOptions(request, runtime);
        }

        public async Task<ModifyNetworkPackageResponse> ModifyNetworkPackageAsync(ModifyNetworkPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNetworkPackageWithOptionsAsync(request, runtime);
        }

        public ModifyNetworkPackageEnabledResponse ModifyNetworkPackageEnabledWithOptions(ModifyNetworkPackageEnabledRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkPackageEnabledResponse>(DoRPCRequest("ModifyNetworkPackageEnabled", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNetworkPackageEnabledResponse> ModifyNetworkPackageEnabledWithOptionsAsync(ModifyNetworkPackageEnabledRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkPackageEnabledResponse>(await DoRPCRequestAsync("ModifyNetworkPackageEnabled", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNetworkPackageEnabledResponse ModifyNetworkPackageEnabled(ModifyNetworkPackageEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNetworkPackageEnabledWithOptions(request, runtime);
        }

        public async Task<ModifyNetworkPackageEnabledResponse> ModifyNetworkPackageEnabledAsync(ModifyNetworkPackageEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNetworkPackageEnabledWithOptionsAsync(request, runtime);
        }

        public ModifyOfficeSiteAttributeResponse ModifyOfficeSiteAttributeWithOptions(ModifyOfficeSiteAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOfficeSiteAttributeResponse>(DoRPCRequest("ModifyOfficeSiteAttribute", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyOfficeSiteAttributeResponse> ModifyOfficeSiteAttributeWithOptionsAsync(ModifyOfficeSiteAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOfficeSiteAttributeResponse>(await DoRPCRequestAsync("ModifyOfficeSiteAttribute", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyOfficeSiteAttributeResponse ModifyOfficeSiteAttribute(ModifyOfficeSiteAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyOfficeSiteAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyOfficeSiteAttributeResponse> ModifyOfficeSiteAttributeAsync(ModifyOfficeSiteAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyOfficeSiteAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyOfficeSiteCrossDesktopAccessResponse ModifyOfficeSiteCrossDesktopAccessWithOptions(ModifyOfficeSiteCrossDesktopAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOfficeSiteCrossDesktopAccessResponse>(DoRPCRequest("ModifyOfficeSiteCrossDesktopAccess", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyOfficeSiteCrossDesktopAccessResponse> ModifyOfficeSiteCrossDesktopAccessWithOptionsAsync(ModifyOfficeSiteCrossDesktopAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOfficeSiteCrossDesktopAccessResponse>(await DoRPCRequestAsync("ModifyOfficeSiteCrossDesktopAccess", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyOfficeSiteCrossDesktopAccessResponse ModifyOfficeSiteCrossDesktopAccess(ModifyOfficeSiteCrossDesktopAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyOfficeSiteCrossDesktopAccessWithOptions(request, runtime);
        }

        public async Task<ModifyOfficeSiteCrossDesktopAccessResponse> ModifyOfficeSiteCrossDesktopAccessAsync(ModifyOfficeSiteCrossDesktopAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyOfficeSiteCrossDesktopAccessWithOptionsAsync(request, runtime);
        }

        public ModifyOfficeSiteMfaEnabledResponse ModifyOfficeSiteMfaEnabledWithOptions(ModifyOfficeSiteMfaEnabledRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOfficeSiteMfaEnabledResponse>(DoRPCRequest("ModifyOfficeSiteMfaEnabled", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyOfficeSiteMfaEnabledResponse> ModifyOfficeSiteMfaEnabledWithOptionsAsync(ModifyOfficeSiteMfaEnabledRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOfficeSiteMfaEnabledResponse>(await DoRPCRequestAsync("ModifyOfficeSiteMfaEnabled", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyOfficeSiteMfaEnabledResponse ModifyOfficeSiteMfaEnabled(ModifyOfficeSiteMfaEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyOfficeSiteMfaEnabledWithOptions(request, runtime);
        }

        public async Task<ModifyOfficeSiteMfaEnabledResponse> ModifyOfficeSiteMfaEnabledAsync(ModifyOfficeSiteMfaEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyOfficeSiteMfaEnabledWithOptionsAsync(request, runtime);
        }

        public ModifyOperateVulResponse ModifyOperateVulWithOptions(ModifyOperateVulRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOperateVulResponse>(DoRPCRequest("ModifyOperateVul", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyOperateVulResponse> ModifyOperateVulWithOptionsAsync(ModifyOperateVulRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOperateVulResponse>(await DoRPCRequestAsync("ModifyOperateVul", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyOperateVulResponse ModifyOperateVul(ModifyOperateVulRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyOperateVulWithOptions(request, runtime);
        }

        public async Task<ModifyOperateVulResponse> ModifyOperateVulAsync(ModifyOperateVulRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyOperateVulWithOptionsAsync(request, runtime);
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

        public ModifyScaleStrategyResponse ModifyScaleStrategyWithOptions(ModifyScaleStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScaleStrategyResponse>(DoRPCRequest("ModifyScaleStrategy", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScaleStrategyResponse> ModifyScaleStrategyWithOptionsAsync(ModifyScaleStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScaleStrategyResponse>(await DoRPCRequestAsync("ModifyScaleStrategy", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScaleStrategyResponse ModifyScaleStrategy(ModifyScaleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScaleStrategyWithOptions(request, runtime);
        }

        public async Task<ModifyScaleStrategyResponse> ModifyScaleStrategyAsync(ModifyScaleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScaleStrategyWithOptionsAsync(request, runtime);
        }

        public ModifyUserToDesktopGroupResponse ModifyUserToDesktopGroupWithOptions(ModifyUserToDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserToDesktopGroupResponse>(DoRPCRequest("ModifyUserToDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserToDesktopGroupResponse> ModifyUserToDesktopGroupWithOptionsAsync(ModifyUserToDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserToDesktopGroupResponse>(await DoRPCRequestAsync("ModifyUserToDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUserToDesktopGroupResponse ModifyUserToDesktopGroup(ModifyUserToDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserToDesktopGroupWithOptions(request, runtime);
        }

        public async Task<ModifyUserToDesktopGroupResponse> ModifyUserToDesktopGroupAsync(ModifyUserToDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserToDesktopGroupWithOptionsAsync(request, runtime);
        }

        public OperateVulsResponse OperateVulsWithOptions(OperateVulsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateVulsResponse>(DoRPCRequest("OperateVuls", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OperateVulsResponse> OperateVulsWithOptionsAsync(OperateVulsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateVulsResponse>(await DoRPCRequestAsync("OperateVuls", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OperateVulsResponse OperateVuls(OperateVulsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateVulsWithOptions(request, runtime);
        }

        public async Task<OperateVulsResponse> OperateVulsAsync(OperateVulsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateVulsWithOptionsAsync(request, runtime);
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

        public RebuildDesktopsResponse RebuildDesktopsWithOptions(RebuildDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebuildDesktopsResponse>(DoRPCRequest("RebuildDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RebuildDesktopsResponse> RebuildDesktopsWithOptionsAsync(RebuildDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebuildDesktopsResponse>(await DoRPCRequestAsync("RebuildDesktops", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RecreateDesktopGroupResponse RecreateDesktopGroupWithOptions(RecreateDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecreateDesktopGroupResponse>(DoRPCRequest("RecreateDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecreateDesktopGroupResponse> RecreateDesktopGroupWithOptionsAsync(RecreateDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecreateDesktopGroupResponse>(await DoRPCRequestAsync("RecreateDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecreateDesktopGroupResponse RecreateDesktopGroup(RecreateDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecreateDesktopGroupWithOptions(request, runtime);
        }

        public async Task<RecreateDesktopGroupResponse> RecreateDesktopGroupAsync(RecreateDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecreateDesktopGroupWithOptionsAsync(request, runtime);
        }

        public RemoveUserFromDesktopGroupResponse RemoveUserFromDesktopGroupWithOptions(RemoveUserFromDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUserFromDesktopGroupResponse>(DoRPCRequest("RemoveUserFromDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveUserFromDesktopGroupResponse> RemoveUserFromDesktopGroupWithOptionsAsync(RemoveUserFromDesktopGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUserFromDesktopGroupResponse>(await DoRPCRequestAsync("RemoveUserFromDesktopGroup", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveUserFromDesktopGroupResponse RemoveUserFromDesktopGroup(RemoveUserFromDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUserFromDesktopGroupWithOptions(request, runtime);
        }

        public async Task<RemoveUserFromDesktopGroupResponse> RemoveUserFromDesktopGroupAsync(RemoveUserFromDesktopGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUserFromDesktopGroupWithOptionsAsync(request, runtime);
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

        public ResetNASDefaultMountTargetResponse ResetNASDefaultMountTargetWithOptions(ResetNASDefaultMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetNASDefaultMountTargetResponse>(DoRPCRequest("ResetNASDefaultMountTarget", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetNASDefaultMountTargetResponse> ResetNASDefaultMountTargetWithOptionsAsync(ResetNASDefaultMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetNASDefaultMountTargetResponse>(await DoRPCRequestAsync("ResetNASDefaultMountTarget", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetNASDefaultMountTargetResponse ResetNASDefaultMountTarget(ResetNASDefaultMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetNASDefaultMountTargetWithOptions(request, runtime);
        }

        public async Task<ResetNASDefaultMountTargetResponse> ResetNASDefaultMountTargetAsync(ResetNASDefaultMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetNASDefaultMountTargetWithOptionsAsync(request, runtime);
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

        public RollbackSuspEventQuaraFileResponse RollbackSuspEventQuaraFileWithOptions(RollbackSuspEventQuaraFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackSuspEventQuaraFileResponse>(DoRPCRequest("RollbackSuspEventQuaraFile", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RollbackSuspEventQuaraFileResponse> RollbackSuspEventQuaraFileWithOptionsAsync(RollbackSuspEventQuaraFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackSuspEventQuaraFileResponse>(await DoRPCRequestAsync("RollbackSuspEventQuaraFile", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RollbackSuspEventQuaraFileResponse RollbackSuspEventQuaraFile(RollbackSuspEventQuaraFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackSuspEventQuaraFileWithOptions(request, runtime);
        }

        public async Task<RollbackSuspEventQuaraFileResponse> RollbackSuspEventQuaraFileAsync(RollbackSuspEventQuaraFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackSuspEventQuaraFileWithOptionsAsync(request, runtime);
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

        public SetDirectorySsoStatusResponse SetDirectorySsoStatusWithOptions(SetDirectorySsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDirectorySsoStatusResponse>(DoRPCRequest("SetDirectorySsoStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDirectorySsoStatusResponse> SetDirectorySsoStatusWithOptionsAsync(SetDirectorySsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDirectorySsoStatusResponse>(await DoRPCRequestAsync("SetDirectorySsoStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SetIdpMetadataResponse SetIdpMetadataWithOptions(SetIdpMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIdpMetadataResponse>(DoRPCRequest("SetIdpMetadata", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetIdpMetadataResponse> SetIdpMetadataWithOptionsAsync(SetIdpMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIdpMetadataResponse>(await DoRPCRequestAsync("SetIdpMetadata", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SetOfficeSiteSsoStatusResponse SetOfficeSiteSsoStatusWithOptions(SetOfficeSiteSsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetOfficeSiteSsoStatusResponse>(DoRPCRequest("SetOfficeSiteSsoStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetOfficeSiteSsoStatusResponse> SetOfficeSiteSsoStatusWithOptionsAsync(SetOfficeSiteSsoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetOfficeSiteSsoStatusResponse>(await DoRPCRequestAsync("SetOfficeSiteSsoStatus", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetOfficeSiteSsoStatusResponse SetOfficeSiteSsoStatus(SetOfficeSiteSsoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetOfficeSiteSsoStatusWithOptions(request, runtime);
        }

        public async Task<SetOfficeSiteSsoStatusResponse> SetOfficeSiteSsoStatusAsync(SetOfficeSiteSsoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetOfficeSiteSsoStatusWithOptionsAsync(request, runtime);
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

        public StartVirusScanTaskResponse StartVirusScanTaskWithOptions(StartVirusScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartVirusScanTaskResponse>(DoRPCRequest("StartVirusScanTask", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartVirusScanTaskResponse> StartVirusScanTaskWithOptionsAsync(StartVirusScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartVirusScanTaskResponse>(await DoRPCRequestAsync("StartVirusScanTask", "2020-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartVirusScanTaskResponse StartVirusScanTask(StartVirusScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartVirusScanTaskWithOptions(request, runtime);
        }

        public async Task<StartVirusScanTaskResponse> StartVirusScanTaskAsync(StartVirusScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartVirusScanTaskWithOptionsAsync(request, runtime);
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
