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

        public DescribeAppsResponse DescribeAppsWithOptions(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppsResponse>(DoRPCRequest("DescribeApps", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppsResponse> DescribeAppsWithOptionsAsync(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppsResponse>(await DoRPCRequestAsync("DescribeApps", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppsWithOptions(request, runtime);
        }

        public async Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppsWithOptionsAsync(request, runtime);
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

        public DescribeWhiteBoardsResponse DescribeWhiteBoardsWithOptions(DescribeWhiteBoardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWhiteBoardsResponse>(DoRPCRequest("DescribeWhiteBoards", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWhiteBoardsResponse> DescribeWhiteBoardsWithOptionsAsync(DescribeWhiteBoardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWhiteBoardsResponse>(await DoRPCRequestAsync("DescribeWhiteBoards", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWhiteBoardsResponse DescribeWhiteBoards(DescribeWhiteBoardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWhiteBoardsWithOptions(request, runtime);
        }

        public async Task<DescribeWhiteBoardsResponse> DescribeWhiteBoardsAsync(DescribeWhiteBoardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWhiteBoardsWithOptionsAsync(request, runtime);
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

        public SetUsersPermissionsResponse SetUsersPermissionsWithOptions(SetUsersPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetUsersPermissionsResponse>(DoRPCRequest("SetUsersPermissions", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetUsersPermissionsResponse> SetUsersPermissionsWithOptionsAsync(SetUsersPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetUsersPermissionsResponse>(await DoRPCRequestAsync("SetUsersPermissions", "2020-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetUsersPermissionsResponse SetUsersPermissions(SetUsersPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetUsersPermissionsWithOptions(request, runtime);
        }

        public async Task<SetUsersPermissionsResponse> SetUsersPermissionsAsync(SetUsersPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetUsersPermissionsWithOptionsAsync(request, runtime);
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
