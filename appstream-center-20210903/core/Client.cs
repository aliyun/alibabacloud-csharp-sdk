// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Appstream_center20210903.Models;

namespace AlibabaCloud.SDK.Appstream_center20210903
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("appstream-center", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary 获取连接信息
         *
         * @param request GetConnectionTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConnectionTicketResponse
         */
        public GetConnectionTicketResponse GetConnectionTicketWithOptions(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionProperties))
            {
                body["ConnectionProperties"] = request.ConnectionProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionTicket",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取连接信息
         *
         * @param request GetConnectionTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConnectionTicketResponse
         */
        public async Task<GetConnectionTicketResponse> GetConnectionTicketWithOptionsAsync(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionProperties))
            {
                body["ConnectionProperties"] = request.ConnectionProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionTicket",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取连接信息
         *
         * @param request GetConnectionTicketRequest
         * @return GetConnectionTicketResponse
         */
        public GetConnectionTicketResponse GetConnectionTicket(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionTicketWithOptions(request, runtime);
        }

        /**
         * @summary 获取连接信息
         *
         * @param request GetConnectionTicketRequest
         * @return GetConnectionTicketResponse
         */
        public async Task<GetConnectionTicketResponse> GetConnectionTicketAsync(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionTicketWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListLFUAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLFUAppResponse
         */
        public ListLFUAppResponse ListLFUAppWithOptions(ListLFUAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                body["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                body["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientChannel))
            {
                body["ClientChannel"] = request.ClientChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendsAccessToken))
            {
                body["ExtendsAccessToken"] = request.ExtendsAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpId))
            {
                body["IdpId"] = request.IdpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                body["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                body["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLFUApp",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLFUAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListLFUAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLFUAppResponse
         */
        public async Task<ListLFUAppResponse> ListLFUAppWithOptionsAsync(ListLFUAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                body["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                body["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientChannel))
            {
                body["ClientChannel"] = request.ClientChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendsAccessToken))
            {
                body["ExtendsAccessToken"] = request.ExtendsAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpId))
            {
                body["IdpId"] = request.IdpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                body["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                body["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLFUApp",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLFUAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListLFUAppRequest
         * @return ListLFUAppResponse
         */
        public ListLFUAppResponse ListLFUApp(ListLFUAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLFUAppWithOptions(request, runtime);
        }

        /**
         * @param request ListLFUAppRequest
         * @return ListLFUAppResponse
         */
        public async Task<ListLFUAppResponse> ListLFUAppAsync(ListLFUAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLFUAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 已上架应用列表
         *
         * @param request ListPublishedAppInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublishedAppInfoResponse
         */
        public ListPublishedAppInfoResponse ListPublishedAppInfoWithOptions(ListPublishedAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                query["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                query["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParam))
            {
                query["OrderParam"] = request.OrderParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedAppInfo",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAppInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 已上架应用列表
         *
         * @param request ListPublishedAppInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublishedAppInfoResponse
         */
        public async Task<ListPublishedAppInfoResponse> ListPublishedAppInfoWithOptionsAsync(ListPublishedAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                query["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                query["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParam))
            {
                query["OrderParam"] = request.OrderParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedAppInfo",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAppInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 已上架应用列表
         *
         * @param request ListPublishedAppInfoRequest
         * @return ListPublishedAppInfoResponse
         */
        public ListPublishedAppInfoResponse ListPublishedAppInfo(ListPublishedAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublishedAppInfoWithOptions(request, runtime);
        }

        /**
         * @summary 已上架应用列表
         *
         * @param request ListPublishedAppInfoRequest
         * @return ListPublishedAppInfoResponse
         */
        public async Task<ListPublishedAppInfoResponse> ListPublishedAppInfoAsync(ListPublishedAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublishedAppInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 运行中应用列表
         *
         * @param request ListRunningAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRunningAppsResponse
         */
        public ListRunningAppsResponse ListRunningAppsWithOptions(ListRunningAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                query["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRunningApps",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRunningAppsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 运行中应用列表
         *
         * @param request ListRunningAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRunningAppsResponse
         */
        public async Task<ListRunningAppsResponse> ListRunningAppsWithOptionsAsync(ListRunningAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                query["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRunningApps",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRunningAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 运行中应用列表
         *
         * @param request ListRunningAppsRequest
         * @return ListRunningAppsResponse
         */
        public ListRunningAppsResponse ListRunningApps(ListRunningAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRunningAppsWithOptions(request, runtime);
        }

        /**
         * @summary 运行中应用列表
         *
         * @param request ListRunningAppsRequest
         * @return ListRunningAppsResponse
         */
        public async Task<ListRunningAppsResponse> ListRunningAppsAsync(ListRunningAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRunningAppsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 停止应用
         *
         * @param request StopAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAppResponse
         */
        public StopAppResponse StopAppWithOptions(StopAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                body["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                body["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientChannel))
            {
                body["ClientChannel"] = request.ClientChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                body["ForceStop"] = request.ForceStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpId))
            {
                body["IdpId"] = request.IdpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                body["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApp",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 停止应用
         *
         * @param request StopAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAppResponse
         */
        public async Task<StopAppResponse> StopAppWithOptionsAsync(StopAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                body["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                body["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientChannel))
            {
                body["ClientChannel"] = request.ClientChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                body["ForceStop"] = request.ForceStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpId))
            {
                body["IdpId"] = request.IdpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                body["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApp",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 停止应用
         *
         * @param request StopAppRequest
         * @return StopAppResponse
         */
        public StopAppResponse StopApp(StopAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAppWithOptions(request, runtime);
        }

        /**
         * @summary 停止应用
         *
         * @param request StopAppRequest
         * @return StopAppResponse
         */
        public async Task<StopAppResponse> StopAppAsync(StopAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解绑实例
         *
         * @param request UnbindRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindResponse
         */
        public UnbindResponse UnbindWithOptions(UnbindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Unbind",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解绑实例
         *
         * @param request UnbindRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindResponse
         */
        public async Task<UnbindResponse> UnbindWithOptionsAsync(UnbindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Unbind",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解绑实例
         *
         * @param request UnbindRequest
         * @return UnbindResponse
         */
        public UnbindResponse Unbind(UnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindWithOptions(request, runtime);
        }

        /**
         * @summary 解绑实例
         *
         * @param request UnbindRequest
         * @return UnbindResponse
         */
        public async Task<UnbindResponse> UnbindAsync(UnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindWithOptionsAsync(request, runtime);
        }

    }
}
