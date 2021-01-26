// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Rtc_white_board20201214.Models;

namespace AlibabaCloud.SDK.Rtc_white_board20201214
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("rtc-white-board", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CheckWhiteBoardHostResponse CheckWhiteBoardHostWithOptions(CheckWhiteBoardHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckWhiteBoardHostResponse>(DoRPCRequest("CheckWhiteBoardHost", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckWhiteBoardHostResponse> CheckWhiteBoardHostWithOptionsAsync(CheckWhiteBoardHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckWhiteBoardHostResponse>(await DoRPCRequestAsync("CheckWhiteBoardHost", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckWhiteBoardHostResponse CheckWhiteBoardHost(CheckWhiteBoardHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckWhiteBoardHostWithOptions(request, runtime);
        }

        public async Task<CheckWhiteBoardHostResponse> CheckWhiteBoardHostAsync(CheckWhiteBoardHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckWhiteBoardHostWithOptionsAsync(request, runtime);
        }

        public CreateAppResponse CreateAppWithOptions(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppResponse>(DoRPCRequest("CreateApp", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppResponse>(await DoRPCRequestAsync("CreateApp", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppWithOptions(request, runtime);
        }

        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppWithOptionsAsync(request, runtime);
        }

        public CreateWhiteBoardResponse CreateWhiteBoardWithOptions(CreateWhiteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWhiteBoardResponse>(DoRPCRequest("CreateWhiteBoard", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateWhiteBoardResponse> CreateWhiteBoardWithOptionsAsync(CreateWhiteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWhiteBoardResponse>(await DoRPCRequestAsync("CreateWhiteBoard", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateWhiteBoardResponse CreateWhiteBoard(CreateWhiteBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWhiteBoardWithOptions(request, runtime);
        }

        public async Task<CreateWhiteBoardResponse> CreateWhiteBoardAsync(CreateWhiteBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWhiteBoardWithOptionsAsync(request, runtime);
        }

        public GetUserPermissionCallbackResponse GetUserPermissionCallbackWithOptions(GetUserPermissionCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserPermissionCallbackResponse>(DoRPCRequest("GetUserPermissionCallback", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserPermissionCallbackResponse> GetUserPermissionCallbackWithOptionsAsync(GetUserPermissionCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserPermissionCallbackResponse>(await DoRPCRequestAsync("GetUserPermissionCallback", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserPermissionCallbackResponse GetUserPermissionCallback(GetUserPermissionCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserPermissionCallbackWithOptions(request, runtime);
        }

        public async Task<GetUserPermissionCallbackResponse> GetUserPermissionCallbackAsync(GetUserPermissionCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserPermissionCallbackWithOptionsAsync(request, runtime);
        }

        public GetUserProfileCallbackResponse GetUserProfileCallbackWithOptions(GetUserProfileCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserProfileCallbackResponse>(DoRPCRequest("GetUserProfileCallback", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserProfileCallbackResponse> GetUserProfileCallbackWithOptionsAsync(GetUserProfileCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserProfileCallbackResponse>(await DoRPCRequestAsync("GetUserProfileCallback", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserProfileCallbackResponse GetUserProfileCallback(GetUserProfileCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserProfileCallbackWithOptions(request, runtime);
        }

        public async Task<GetUserProfileCallbackResponse> GetUserProfileCallbackAsync(GetUserProfileCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserProfileCallbackWithOptionsAsync(request, runtime);
        }

        public GetWhiteBoardProfileCallbackResponse GetWhiteBoardProfileCallbackWithOptions(GetWhiteBoardProfileCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWhiteBoardProfileCallbackResponse>(DoRPCRequest("GetWhiteBoardProfileCallback", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWhiteBoardProfileCallbackResponse> GetWhiteBoardProfileCallbackWithOptionsAsync(GetWhiteBoardProfileCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWhiteBoardProfileCallbackResponse>(await DoRPCRequestAsync("GetWhiteBoardProfileCallback", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWhiteBoardProfileCallbackResponse GetWhiteBoardProfileCallback(GetWhiteBoardProfileCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWhiteBoardProfileCallbackWithOptions(request, runtime);
        }

        public async Task<GetWhiteBoardProfileCallbackResponse> GetWhiteBoardProfileCallbackAsync(GetWhiteBoardProfileCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWhiteBoardProfileCallbackWithOptionsAsync(request, runtime);
        }

        public OpenWhiteBoardResponse OpenWhiteBoardWithOptions(OpenWhiteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenWhiteBoardResponse>(DoRPCRequest("OpenWhiteBoard", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenWhiteBoardResponse> OpenWhiteBoardWithOptionsAsync(OpenWhiteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenWhiteBoardResponse>(await DoRPCRequestAsync("OpenWhiteBoard", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenWhiteBoardResponse OpenWhiteBoard(OpenWhiteBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenWhiteBoardWithOptions(request, runtime);
        }

        public async Task<OpenWhiteBoardResponse> OpenWhiteBoardAsync(OpenWhiteBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenWhiteBoardWithOptionsAsync(request, runtime);
        }

        public RefreshUsersPermissionsResponse RefreshUsersPermissionsWithOptions(RefreshUsersPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshUsersPermissionsResponse>(DoRPCRequest("RefreshUsersPermissions", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshUsersPermissionsResponse> RefreshUsersPermissionsWithOptionsAsync(RefreshUsersPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshUsersPermissionsResponse>(await DoRPCRequestAsync("RefreshUsersPermissions", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshUsersPermissionsResponse RefreshUsersPermissions(RefreshUsersPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshUsersPermissionsWithOptions(request, runtime);
        }

        public async Task<RefreshUsersPermissionsResponse> RefreshUsersPermissionsAsync(RefreshUsersPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshUsersPermissionsWithOptionsAsync(request, runtime);
        }

        public SetAppCallbackUrlResponse SetAppCallbackUrlWithOptions(SetAppCallbackUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppCallbackUrlResponse>(DoRPCRequest("SetAppCallbackUrl", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetAppCallbackUrlResponse> SetAppCallbackUrlWithOptionsAsync(SetAppCallbackUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppCallbackUrlResponse>(await DoRPCRequestAsync("SetAppCallbackUrl", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetAppCallbackUrlResponse SetAppCallbackUrl(SetAppCallbackUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAppCallbackUrlWithOptions(request, runtime);
        }

        public async Task<SetAppCallbackUrlResponse> SetAppCallbackUrlAsync(SetAppCallbackUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAppCallbackUrlWithOptionsAsync(request, runtime);
        }

        public SetAppDomainNamesResponse SetAppDomainNamesWithOptions(SetAppDomainNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppDomainNamesResponse>(DoRPCRequest("SetAppDomainNames", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetAppDomainNamesResponse> SetAppDomainNamesWithOptionsAsync(SetAppDomainNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppDomainNamesResponse>(await DoRPCRequestAsync("SetAppDomainNames", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetAppDomainNamesResponse SetAppDomainNames(SetAppDomainNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAppDomainNamesWithOptions(request, runtime);
        }

        public async Task<SetAppDomainNamesResponse> SetAppDomainNamesAsync(SetAppDomainNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAppDomainNamesWithOptionsAsync(request, runtime);
        }

        public SetAppNameResponse SetAppNameWithOptions(SetAppNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppNameResponse>(DoRPCRequest("SetAppName", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetAppNameResponse> SetAppNameWithOptionsAsync(SetAppNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppNameResponse>(await DoRPCRequestAsync("SetAppName", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetAppNameResponse SetAppName(SetAppNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAppNameWithOptions(request, runtime);
        }

        public async Task<SetAppNameResponse> SetAppNameAsync(SetAppNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAppNameWithOptionsAsync(request, runtime);
        }

        public SetAppStatusResponse SetAppStatusWithOptions(SetAppStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppStatusResponse>(DoRPCRequest("SetAppStatus", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetAppStatusResponse> SetAppStatusWithOptionsAsync(SetAppStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppStatusResponse>(await DoRPCRequestAsync("SetAppStatus", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetAppStatusResponse SetAppStatus(SetAppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAppStatusWithOptions(request, runtime);
        }

        public async Task<SetAppStatusResponse> SetAppStatusAsync(SetAppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAppStatusWithOptionsAsync(request, runtime);
        }

    }
}
