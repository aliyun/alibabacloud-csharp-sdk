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
            this._productId = "appstream-center";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the connection credentials for cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>It is a time-consuming operation to issue connection credentials. Therefore, you may need to invoke this API operation multiple times to obtain the connection credentials.</para>
        /// <ol>
        /// <item><description>When you invoke the API for the first time, an application instance is allocated to the specified convenience account, and the application is started. The start node ID (<c>TaskId</c>) is returned.</description></item>
        /// <item><description>When you invoke the API subsequently, you must pass the <c>TaskId</c> parameter as a request parameter to check whether the node is completed. When the returned node status (<c>TaskStatus</c>) is <c>Finished</c>, the connection ticket (<c>Ticket</c>) is also returned.<remarks>
        /// <list type="bullet">
        /// <item><description>If the startup process is fast enough, the connection ticket (<c>Ticket</c>) may also be returned when you invoke the API for the first time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public GetConnectionTicketResponse GetConnectionTicketWithOptions(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                body["AccessType"] = request.AccessType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                body["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConnectInQueue))
            {
                body["AutoConnectInQueue"] = request.AutoConnectInQueue;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentConfig))
            {
                body["EnvironmentConfig"] = request.EnvironmentConfig;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireUuidValidation))
            {
                body["RequireUuidValidation"] = request.RequireUuidValidation;
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
            return TeaModel.ToObject<GetConnectionTicketResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the connection credentials for cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>It is a time-consuming operation to issue connection credentials. Therefore, you may need to invoke this API operation multiple times to obtain the connection credentials.</para>
        /// <ol>
        /// <item><description>When you invoke the API for the first time, an application instance is allocated to the specified convenience account, and the application is started. The start node ID (<c>TaskId</c>) is returned.</description></item>
        /// <item><description>When you invoke the API subsequently, you must pass the <c>TaskId</c> parameter as a request parameter to check whether the node is completed. When the returned node status (<c>TaskStatus</c>) is <c>Finished</c>, the connection ticket (<c>Ticket</c>) is also returned.<remarks>
        /// <list type="bullet">
        /// <item><description>If the startup process is fast enough, the connection ticket (<c>Ticket</c>) may also be returned when you invoke the API for the first time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public async Task<GetConnectionTicketResponse> GetConnectionTicketWithOptionsAsync(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                body["AccessType"] = request.AccessType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                body["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConnectInQueue))
            {
                body["AutoConnectInQueue"] = request.AutoConnectInQueue;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentConfig))
            {
                body["EnvironmentConfig"] = request.EnvironmentConfig;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireUuidValidation))
            {
                body["RequireUuidValidation"] = request.RequireUuidValidation;
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
            return TeaModel.ToObject<GetConnectionTicketResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the connection credentials for cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>It is a time-consuming operation to issue connection credentials. Therefore, you may need to invoke this API operation multiple times to obtain the connection credentials.</para>
        /// <ol>
        /// <item><description>When you invoke the API for the first time, an application instance is allocated to the specified convenience account, and the application is started. The start node ID (<c>TaskId</c>) is returned.</description></item>
        /// <item><description>When you invoke the API subsequently, you must pass the <c>TaskId</c> parameter as a request parameter to check whether the node is completed. When the returned node status (<c>TaskStatus</c>) is <c>Finished</c>, the connection ticket (<c>Ticket</c>) is also returned.<remarks>
        /// <list type="bullet">
        /// <item><description>If the startup process is fast enough, the connection ticket (<c>Ticket</c>) may also be returned when you invoke the API for the first time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public GetConnectionTicketResponse GetConnectionTicket(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionTicketWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the connection credentials for cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>It is a time-consuming operation to issue connection credentials. Therefore, you may need to invoke this API operation multiple times to obtain the connection credentials.</para>
        /// <ol>
        /// <item><description>When you invoke the API for the first time, an application instance is allocated to the specified convenience account, and the application is started. The start node ID (<c>TaskId</c>) is returned.</description></item>
        /// <item><description>When you invoke the API subsequently, you must pass the <c>TaskId</c> parameter as a request parameter to check whether the node is completed. When the returned node status (<c>TaskStatus</c>) is <c>Finished</c>, the connection ticket (<c>Ticket</c>) is also returned.<remarks>
        /// <list type="bullet">
        /// <item><description>If the startup process is fast enough, the connection ticket (<c>Ticket</c>) may also be returned when you invoke the API for the first time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public async Task<GetConnectionTicketResponse> GetConnectionTicketAsync(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionTicketWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of published applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedAppInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppInfoResponse
        /// </returns>
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
            return TeaModel.ToObject<ListPublishedAppInfoResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of published applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedAppInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppInfoResponse
        /// </returns>
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
            return TeaModel.ToObject<ListPublishedAppInfoResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of published applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedAppInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppInfoResponse
        /// </returns>
        public ListPublishedAppInfoResponse ListPublishedAppInfo(ListPublishedAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublishedAppInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of published applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedAppInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppInfoResponse
        /// </returns>
        public async Task<ListPublishedAppInfoResponse> ListPublishedAppInfoAsync(ListPublishedAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublishedAppInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries running applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Prerequisites</h2>
        /// <para>This operation is an anonymous API operation, but the server still verifies the logon status. The <c>LoginToken</c> and <c>SessionId</c> request parameters are actually required. If either parameter is missing, an HTTP 400 error is returned with the error code <c>InvalidParameter.loginToken</c> or <c>InvalidParameter.sessionId</c>.</para>
        /// <h2>Obtain credentials</h2>
        /// <para>To obtain the <c>LoginToken</c> and <c>SessionId</c> by using <c>GetLoginToken</c>, call the <c>GetLoginToken</c> operation of the <c>appstream-center</c> 2021-02-20 version. The 2021-09-03 version does not provide this operation. You can also call <c>RefreshLoginToken</c> to update and obtain the <c>LoginToken</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRunningAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRunningAppsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListRunningAppsResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries running applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Prerequisites</h2>
        /// <para>This operation is an anonymous API operation, but the server still verifies the logon status. The <c>LoginToken</c> and <c>SessionId</c> request parameters are actually required. If either parameter is missing, an HTTP 400 error is returned with the error code <c>InvalidParameter.loginToken</c> or <c>InvalidParameter.sessionId</c>.</para>
        /// <h2>Obtain credentials</h2>
        /// <para>To obtain the <c>LoginToken</c> and <c>SessionId</c> by using <c>GetLoginToken</c>, call the <c>GetLoginToken</c> operation of the <c>appstream-center</c> 2021-02-20 version. The 2021-09-03 version does not provide this operation. You can also call <c>RefreshLoginToken</c> to update and obtain the <c>LoginToken</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRunningAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRunningAppsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListRunningAppsResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries running applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Prerequisites</h2>
        /// <para>This operation is an anonymous API operation, but the server still verifies the logon status. The <c>LoginToken</c> and <c>SessionId</c> request parameters are actually required. If either parameter is missing, an HTTP 400 error is returned with the error code <c>InvalidParameter.loginToken</c> or <c>InvalidParameter.sessionId</c>.</para>
        /// <h2>Obtain credentials</h2>
        /// <para>To obtain the <c>LoginToken</c> and <c>SessionId</c> by using <c>GetLoginToken</c>, call the <c>GetLoginToken</c> operation of the <c>appstream-center</c> 2021-02-20 version. The 2021-09-03 version does not provide this operation. You can also call <c>RefreshLoginToken</c> to update and obtain the <c>LoginToken</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRunningAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRunningAppsResponse
        /// </returns>
        public ListRunningAppsResponse ListRunningApps(ListRunningAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRunningAppsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries running applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Prerequisites</h2>
        /// <para>This operation is an anonymous API operation, but the server still verifies the logon status. The <c>LoginToken</c> and <c>SessionId</c> request parameters are actually required. If either parameter is missing, an HTTP 400 error is returned with the error code <c>InvalidParameter.loginToken</c> or <c>InvalidParameter.sessionId</c>.</para>
        /// <h2>Obtain credentials</h2>
        /// <para>To obtain the <c>LoginToken</c> and <c>SessionId</c> by using <c>GetLoginToken</c>, call the <c>GetLoginToken</c> operation of the <c>appstream-center</c> 2021-02-20 version. The 2021-09-03 version does not provide this operation. You can also call <c>RefreshLoginToken</c> to update and obtain the <c>LoginToken</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRunningAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRunningAppsResponse
        /// </returns>
        public async Task<ListRunningAppsResponse> ListRunningAppsAsync(ListRunningAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRunningAppsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetAppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetAppResourcesResponse
        /// </returns>
        public ResetAppResourcesResponse ResetAppResourcesWithOptions(ResetAppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "ResetAppResources",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAppResourcesResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetAppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetAppResourcesResponse
        /// </returns>
        public async Task<ResetAppResourcesResponse> ResetAppResourcesWithOptionsAsync(ResetAppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "ResetAppResources",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAppResourcesResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetAppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetAppResourcesResponse
        /// </returns>
        public ResetAppResourcesResponse ResetAppResources(ResetAppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAppResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetAppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetAppResourcesResponse
        /// </returns>
        public async Task<ResetAppResourcesResponse> ResetAppResourcesAsync(ResetAppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAppResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartAppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartAppResourcesResponse
        /// </returns>
        public RestartAppResourcesResponse RestartAppResourcesWithOptions(RestartAppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "RestartAppResources",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartAppResourcesResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartAppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartAppResourcesResponse
        /// </returns>
        public async Task<RestartAppResourcesResponse> RestartAppResourcesWithOptionsAsync(RestartAppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "RestartAppResources",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartAppResourcesResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartAppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartAppResourcesResponse
        /// </returns>
        public RestartAppResourcesResponse RestartAppResources(RestartAppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartAppResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartAppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartAppResourcesResponse
        /// </returns>
        public async Task<RestartAppResourcesResponse> RestartAppResourcesAsync(RestartAppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartAppResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAppResourcesResponse
        /// </returns>
        public StartAppResourcesResponse StartAppResourcesWithOptions(StartAppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "StartAppResources",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAppResourcesResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAppResourcesResponse
        /// </returns>
        public async Task<StartAppResourcesResponse> StartAppResourcesWithOptionsAsync(StartAppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "StartAppResources",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAppResourcesResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAppResourcesResponse
        /// </returns>
        public StartAppResourcesResponse StartAppResources(StartAppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAppResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAppResourcesResponse
        /// </returns>
        public async Task<StartAppResourcesResponse> StartAppResourcesAsync(StartAppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAppResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a specified application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Credential acquisition</h2>
        /// <para>To obtain the <c>LoginToken</c> and <c>SessionId</c> by using <c>GetLoginToken</c>, call the <c>GetLoginToken</c> operation of the <c>appstream-center</c> 2021-02-20 version. The 2021-09-03 version does not provide this operation. You can also update and obtain the <c>LoginToken</c> by using <c>RefreshLoginToken</c>.</para>
        /// <h3>Required parameters and authentication invocation flow for GetLoginToken (2021-02-20 version)</h3>
        /// <para>API documentation: <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-getlogintoken">GetLoginToken (2021-02-20)</a>
        /// Required metric descriptions:</para>
        /// <list type="bullet">
        /// <item><description><c>ClientId</c>: Required. The unique ID generated by the client, serving as the identity for the client that initiates the logon. Reuse the same value within the same session.</description></item>
        /// <item><description><c>LoginIdentifier</c>: The enterprise identity (i.e., enterprise alias). This parameter is required when you use the enterprise identity logon method. Note that the parameter name is <c>LoginIdentifier</c>, not <c>TenantAlias</c>.</description></item>
        /// <item><description>When you use a convenience account or an AD domain account for authentication, the Settings for <c>CurrentStage</c> must be <c>ADPassword</c>, and you must provide both <c>EndUserId</c> (username) and <c>Password</c> (password).
        /// Complete authentication invocation flow:</description></item>
        /// </list>
        /// <ol>
        /// <item><description>Invoke <c>GetLoginToken</c> for the first time with <c>ClientId</c>, <c>LoginIdentifier</c>, <c>CurrentStage</c> based on the logon method, and the corresponding credentials. Save the returned <c>LoginToken</c> and <c>SessionId</c>. <c>SessionId</c> is returned only during the first invocation in the same session and must be reused in subsequent stage invocations.</description></item>
        /// <item><description>If <c>NextStage</c> (such as <c>MFAVerify</c>, <c>TokenVerify</c>, or <c>ChangePassword</c>) is returned, carry the same <c>SessionId</c> and <c>ClientId</c>, update the Settings of <c>CurrentStage</c> to the value of <c>NextStage</c>, and provide the parameters required for this stage (such as <c>AuthenticationCode</c> for the <c>MFAVerify</c> stage and <c>TokenCode</c> for the <c>TokenVerify</c> stage). Repeat the invocation until the final <c>LoginToken</c> is obtained.</description></item>
        /// <item><description>Use the final <c>LoginToken</c> and <c>SessionId</c> to invoke this operation (<c>StopApp</c>).</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAppResponse
        /// </returns>
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
            return TeaModel.ToObject<StopAppResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a specified application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Credential acquisition</h2>
        /// <para>To obtain the <c>LoginToken</c> and <c>SessionId</c> by using <c>GetLoginToken</c>, call the <c>GetLoginToken</c> operation of the <c>appstream-center</c> 2021-02-20 version. The 2021-09-03 version does not provide this operation. You can also update and obtain the <c>LoginToken</c> by using <c>RefreshLoginToken</c>.</para>
        /// <h3>Required parameters and authentication invocation flow for GetLoginToken (2021-02-20 version)</h3>
        /// <para>API documentation: <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-getlogintoken">GetLoginToken (2021-02-20)</a>
        /// Required metric descriptions:</para>
        /// <list type="bullet">
        /// <item><description><c>ClientId</c>: Required. The unique ID generated by the client, serving as the identity for the client that initiates the logon. Reuse the same value within the same session.</description></item>
        /// <item><description><c>LoginIdentifier</c>: The enterprise identity (i.e., enterprise alias). This parameter is required when you use the enterprise identity logon method. Note that the parameter name is <c>LoginIdentifier</c>, not <c>TenantAlias</c>.</description></item>
        /// <item><description>When you use a convenience account or an AD domain account for authentication, the Settings for <c>CurrentStage</c> must be <c>ADPassword</c>, and you must provide both <c>EndUserId</c> (username) and <c>Password</c> (password).
        /// Complete authentication invocation flow:</description></item>
        /// </list>
        /// <ol>
        /// <item><description>Invoke <c>GetLoginToken</c> for the first time with <c>ClientId</c>, <c>LoginIdentifier</c>, <c>CurrentStage</c> based on the logon method, and the corresponding credentials. Save the returned <c>LoginToken</c> and <c>SessionId</c>. <c>SessionId</c> is returned only during the first invocation in the same session and must be reused in subsequent stage invocations.</description></item>
        /// <item><description>If <c>NextStage</c> (such as <c>MFAVerify</c>, <c>TokenVerify</c>, or <c>ChangePassword</c>) is returned, carry the same <c>SessionId</c> and <c>ClientId</c>, update the Settings of <c>CurrentStage</c> to the value of <c>NextStage</c>, and provide the parameters required for this stage (such as <c>AuthenticationCode</c> for the <c>MFAVerify</c> stage and <c>TokenCode</c> for the <c>TokenVerify</c> stage). Repeat the invocation until the final <c>LoginToken</c> is obtained.</description></item>
        /// <item><description>Use the final <c>LoginToken</c> and <c>SessionId</c> to invoke this operation (<c>StopApp</c>).</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAppResponse
        /// </returns>
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
            return TeaModel.ToObject<StopAppResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a specified application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Credential acquisition</h2>
        /// <para>To obtain the <c>LoginToken</c> and <c>SessionId</c> by using <c>GetLoginToken</c>, call the <c>GetLoginToken</c> operation of the <c>appstream-center</c> 2021-02-20 version. The 2021-09-03 version does not provide this operation. You can also update and obtain the <c>LoginToken</c> by using <c>RefreshLoginToken</c>.</para>
        /// <h3>Required parameters and authentication invocation flow for GetLoginToken (2021-02-20 version)</h3>
        /// <para>API documentation: <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-getlogintoken">GetLoginToken (2021-02-20)</a>
        /// Required metric descriptions:</para>
        /// <list type="bullet">
        /// <item><description><c>ClientId</c>: Required. The unique ID generated by the client, serving as the identity for the client that initiates the logon. Reuse the same value within the same session.</description></item>
        /// <item><description><c>LoginIdentifier</c>: The enterprise identity (i.e., enterprise alias). This parameter is required when you use the enterprise identity logon method. Note that the parameter name is <c>LoginIdentifier</c>, not <c>TenantAlias</c>.</description></item>
        /// <item><description>When you use a convenience account or an AD domain account for authentication, the Settings for <c>CurrentStage</c> must be <c>ADPassword</c>, and you must provide both <c>EndUserId</c> (username) and <c>Password</c> (password).
        /// Complete authentication invocation flow:</description></item>
        /// </list>
        /// <ol>
        /// <item><description>Invoke <c>GetLoginToken</c> for the first time with <c>ClientId</c>, <c>LoginIdentifier</c>, <c>CurrentStage</c> based on the logon method, and the corresponding credentials. Save the returned <c>LoginToken</c> and <c>SessionId</c>. <c>SessionId</c> is returned only during the first invocation in the same session and must be reused in subsequent stage invocations.</description></item>
        /// <item><description>If <c>NextStage</c> (such as <c>MFAVerify</c>, <c>TokenVerify</c>, or <c>ChangePassword</c>) is returned, carry the same <c>SessionId</c> and <c>ClientId</c>, update the Settings of <c>CurrentStage</c> to the value of <c>NextStage</c>, and provide the parameters required for this stage (such as <c>AuthenticationCode</c> for the <c>MFAVerify</c> stage and <c>TokenCode</c> for the <c>TokenVerify</c> stage). Repeat the invocation until the final <c>LoginToken</c> is obtained.</description></item>
        /// <item><description>Use the final <c>LoginToken</c> and <c>SessionId</c> to invoke this operation (<c>StopApp</c>).</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAppRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAppResponse
        /// </returns>
        public StopAppResponse StopApp(StopAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a specified application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Credential acquisition</h2>
        /// <para>To obtain the <c>LoginToken</c> and <c>SessionId</c> by using <c>GetLoginToken</c>, call the <c>GetLoginToken</c> operation of the <c>appstream-center</c> 2021-02-20 version. The 2021-09-03 version does not provide this operation. You can also update and obtain the <c>LoginToken</c> by using <c>RefreshLoginToken</c>.</para>
        /// <h3>Required parameters and authentication invocation flow for GetLoginToken (2021-02-20 version)</h3>
        /// <para>API documentation: <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-getlogintoken">GetLoginToken (2021-02-20)</a>
        /// Required metric descriptions:</para>
        /// <list type="bullet">
        /// <item><description><c>ClientId</c>: Required. The unique ID generated by the client, serving as the identity for the client that initiates the logon. Reuse the same value within the same session.</description></item>
        /// <item><description><c>LoginIdentifier</c>: The enterprise identity (i.e., enterprise alias). This parameter is required when you use the enterprise identity logon method. Note that the parameter name is <c>LoginIdentifier</c>, not <c>TenantAlias</c>.</description></item>
        /// <item><description>When you use a convenience account or an AD domain account for authentication, the Settings for <c>CurrentStage</c> must be <c>ADPassword</c>, and you must provide both <c>EndUserId</c> (username) and <c>Password</c> (password).
        /// Complete authentication invocation flow:</description></item>
        /// </list>
        /// <ol>
        /// <item><description>Invoke <c>GetLoginToken</c> for the first time with <c>ClientId</c>, <c>LoginIdentifier</c>, <c>CurrentStage</c> based on the logon method, and the corresponding credentials. Save the returned <c>LoginToken</c> and <c>SessionId</c>. <c>SessionId</c> is returned only during the first invocation in the same session and must be reused in subsequent stage invocations.</description></item>
        /// <item><description>If <c>NextStage</c> (such as <c>MFAVerify</c>, <c>TokenVerify</c>, or <c>ChangePassword</c>) is returned, carry the same <c>SessionId</c> and <c>ClientId</c>, update the Settings of <c>CurrentStage</c> to the value of <c>NextStage</c>, and provide the parameters required for this stage (such as <c>AuthenticationCode</c> for the <c>MFAVerify</c> stage and <c>TokenCode</c> for the <c>TokenVerify</c> stage). Repeat the invocation until the final <c>LoginToken</c> is obtained.</description></item>
        /// <item><description>Use the final <c>LoginToken</c> and <c>SessionId</c> to invoke this operation (<c>StopApp</c>).</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAppRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAppResponse
        /// </returns>
        public async Task<StopAppResponse> StopAppAsync(StopAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops application resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>Before you call this operation, you must complete user logon authentication to obtain the <c>LoginToken</c> and <c>SessionId</c>. This <c>StopAppResources</c> operation uses the <b>2021-09-03</b> version of <c>appstream-center</c>. The prerequisite logon operation uses the <b>2021-02-20</b> version of <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-getlogintoken">GetLoginToken</a>. Use the respective API versions for each operation.</para>
        /// <h3>1. Prepare the enterprise identifier and account information</h3>
        /// <para>The following procedure applies to password authentication for convenience accounts or AD domain accounts that log on by using an enterprise identifier.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Parameter</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><c>ClientId</c></td>
        /// <td>The unique ID generated by the client. This parameter is required when you call <c>GetLoginToken</c>. The same client ID is reused in the following call sequence.</td>
        /// </tr>
        /// <tr>
        /// <td><c>LoginIdentifier</c></td>
        /// <td>The enterprise identifier for logon, which is the <c>TenantAlias</c>. The parameter name in the logon request is <c>LoginIdentifier</c>, not <c>TenantAlias</c>. To query the logon configuration of this identifier, you can call <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-findidplistbyloginidentifier">FindIdpListByLoginIdentifier (2021-02-20)</a>. The <c>TenantAliasInfo.TenantAlias</c> field in the response indicates the enterprise identifier.</td>
        /// </tr>
        /// <tr>
        /// <td><c>CurrentStage</c></td>
        /// <td>Set this parameter to <c>ADPassword</c> for password authentication. This value applies to both convenience accounts and AD domain accounts, not only AD domain accounts.</td>
        /// </tr>
        /// <tr>
        /// <td><c>EndUserId</c></td>
        /// <td>The username of the convenience account or AD domain account. This parameter is required when <c>CurrentStage</c> is set to <c>ADPassword</c>.</td>
        /// </tr>
        /// <tr>
        /// <td><c>Password</c></td>
        /// <td>The password of the corresponding account. This parameter is required when <c>CurrentStage</c> is set to <c>ADPassword</c>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h3>2. Continue logon based on the returned authentication stage</h3>
        /// <para>After you invoke <c>GetLoginToken</c> for the first time, save the returned <c>SessionId</c>. This value is returned only during the first invocation in the same logon session. If you need to authenticate further, include the saved <c>SessionId</c> in subsequent requests. Do not clear this value even if it is not returned in subsequent responses.
        /// Determine whether you still need to authenticate based on the <c>NextStage</c> field in the response, and set the required next authentication stage as the <c>CurrentStage</c> for subsequent requests. Examples:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Next authentication stage</th>
        /// <th>What to do next</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><c>MFAVerify</c></td>
        /// <td>Include the <c>SessionId</c> and the <c>AuthenticationCode</c> generated by the virtual MFA device to continue to invoke <c>GetLoginToken</c>.</td>
        /// </tr>
        /// <tr>
        /// <td><c>TokenVerify</c></td>
        /// <td>Include the <c>SessionId</c> and the client secondary authentication verification code <c>TokenCode</c> to continue to authenticate.</td>
        /// </tr>
        /// <tr>
        /// <td><c>ChangePassword</c></td>
        /// <td>Specify <c>OldPassword</c> and <c>NewPassword</c> as required to complete the password change stage.</td>
        /// </tr>
        /// <tr>
        /// <td><c>MFABind</c> or other authentication stages</td>
        /// <td>Complete the corresponding operations based on the actual returned stage and the <c>GetLoginToken</c> documentation. Do not directly apply the request parameters of <c>MFAVerify</c>.</td>
        /// </tr>
        /// <tr>
        /// <td>The authentication stages are determined by the account configuration and the result of the current logon. Not every logon must go through all the preceding stages in sequence. Invoke <c>StopAppResources</c> only after logon authentication is complete and the <c>LoginToken</c> is obtained. Do not proceed with the shutdown of resources if authentication failed or if there are pending authentication stages.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>3. Call sequence example</h3>
        /// <para>The following is pseudocode for parameter passing and is not an executable SDK example. <c>clientId</c>, <c>tenantAlias</c>, <c>endUserId</c>, <c>password</c>, and <c>authenticationCode</c> are runtime variables of the caller. <c>resourceIds</c>, <c>productType</c>, and <c>appInstanceGroupId</c> are business parameters for this operation. Do not write real passwords, verification codes, or logon credentials in examples or logs.</para>
        /// <pre><code class="language-text">login1 = GetLoginToken(version=&quot;2021-02-20&quot;,
        ///     ClientId=clientId, LoginIdentifier=tenantAlias,
        ///     CurrentStage=&quot;ADPassword&quot;, EndUserId=endUserId, Password=password)
        /// sessionId = login1.SessionId
        /// loginResult = login1
        /// if loginResult.NextStage == &quot;MFAVerify&quot;:
        ///     loginResult = GetLoginToken(version=&quot;2021-02-20&quot;,
        ///         ClientId=clientId, LoginIdentifier=tenantAlias,
        ///         SessionId=sessionId, CurrentStage=&quot;MFAVerify&quot;,
        ///         AuthenticationCode=authenticationCode)
        /// </c></pre>
        /// <para>If other authentication stages are still required, continue processing based on <c>NextStage</c>. Do not treat the preceding single MFA call as a fixed endpoint. After logon is complete, call this operation by using the <c>LoginToken</c> obtained during this logon and the saved <c>SessionId</c>:</para>
        /// <pre><code class="language-text">StopAppResources(version=&quot;2021-09-03&quot;,
        ///     ClientId=clientId, LoginToken=loginResult.LoginToken, SessionId=sessionId,
        ///     ProductType=productType, AppInstanceGroupId=appInstanceGroupId,
        ///     ResourceIds=resourceIds)
        /// </c></pre>
        /// <para><c>Password</c>, <c>LoginIdentifier</c>, and <c>CurrentStage</c> belong to the prerequisite logon request and are not request parameters of <c>StopAppResources</c>. For the rules on how to specify other parameters and resource IDs for this operation, see the request parameter table below.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAppResourcesResponse
        /// </returns>
        public StopAppResourcesResponse StopAppResourcesWithOptions(StopAppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "StopAppResources",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAppResourcesResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops application resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>Before you call this operation, you must complete user logon authentication to obtain the <c>LoginToken</c> and <c>SessionId</c>. This <c>StopAppResources</c> operation uses the <b>2021-09-03</b> version of <c>appstream-center</c>. The prerequisite logon operation uses the <b>2021-02-20</b> version of <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-getlogintoken">GetLoginToken</a>. Use the respective API versions for each operation.</para>
        /// <h3>1. Prepare the enterprise identifier and account information</h3>
        /// <para>The following procedure applies to password authentication for convenience accounts or AD domain accounts that log on by using an enterprise identifier.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Parameter</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><c>ClientId</c></td>
        /// <td>The unique ID generated by the client. This parameter is required when you call <c>GetLoginToken</c>. The same client ID is reused in the following call sequence.</td>
        /// </tr>
        /// <tr>
        /// <td><c>LoginIdentifier</c></td>
        /// <td>The enterprise identifier for logon, which is the <c>TenantAlias</c>. The parameter name in the logon request is <c>LoginIdentifier</c>, not <c>TenantAlias</c>. To query the logon configuration of this identifier, you can call <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-findidplistbyloginidentifier">FindIdpListByLoginIdentifier (2021-02-20)</a>. The <c>TenantAliasInfo.TenantAlias</c> field in the response indicates the enterprise identifier.</td>
        /// </tr>
        /// <tr>
        /// <td><c>CurrentStage</c></td>
        /// <td>Set this parameter to <c>ADPassword</c> for password authentication. This value applies to both convenience accounts and AD domain accounts, not only AD domain accounts.</td>
        /// </tr>
        /// <tr>
        /// <td><c>EndUserId</c></td>
        /// <td>The username of the convenience account or AD domain account. This parameter is required when <c>CurrentStage</c> is set to <c>ADPassword</c>.</td>
        /// </tr>
        /// <tr>
        /// <td><c>Password</c></td>
        /// <td>The password of the corresponding account. This parameter is required when <c>CurrentStage</c> is set to <c>ADPassword</c>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h3>2. Continue logon based on the returned authentication stage</h3>
        /// <para>After you invoke <c>GetLoginToken</c> for the first time, save the returned <c>SessionId</c>. This value is returned only during the first invocation in the same logon session. If you need to authenticate further, include the saved <c>SessionId</c> in subsequent requests. Do not clear this value even if it is not returned in subsequent responses.
        /// Determine whether you still need to authenticate based on the <c>NextStage</c> field in the response, and set the required next authentication stage as the <c>CurrentStage</c> for subsequent requests. Examples:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Next authentication stage</th>
        /// <th>What to do next</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><c>MFAVerify</c></td>
        /// <td>Include the <c>SessionId</c> and the <c>AuthenticationCode</c> generated by the virtual MFA device to continue to invoke <c>GetLoginToken</c>.</td>
        /// </tr>
        /// <tr>
        /// <td><c>TokenVerify</c></td>
        /// <td>Include the <c>SessionId</c> and the client secondary authentication verification code <c>TokenCode</c> to continue to authenticate.</td>
        /// </tr>
        /// <tr>
        /// <td><c>ChangePassword</c></td>
        /// <td>Specify <c>OldPassword</c> and <c>NewPassword</c> as required to complete the password change stage.</td>
        /// </tr>
        /// <tr>
        /// <td><c>MFABind</c> or other authentication stages</td>
        /// <td>Complete the corresponding operations based on the actual returned stage and the <c>GetLoginToken</c> documentation. Do not directly apply the request parameters of <c>MFAVerify</c>.</td>
        /// </tr>
        /// <tr>
        /// <td>The authentication stages are determined by the account configuration and the result of the current logon. Not every logon must go through all the preceding stages in sequence. Invoke <c>StopAppResources</c> only after logon authentication is complete and the <c>LoginToken</c> is obtained. Do not proceed with the shutdown of resources if authentication failed or if there are pending authentication stages.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>3. Call sequence example</h3>
        /// <para>The following is pseudocode for parameter passing and is not an executable SDK example. <c>clientId</c>, <c>tenantAlias</c>, <c>endUserId</c>, <c>password</c>, and <c>authenticationCode</c> are runtime variables of the caller. <c>resourceIds</c>, <c>productType</c>, and <c>appInstanceGroupId</c> are business parameters for this operation. Do not write real passwords, verification codes, or logon credentials in examples or logs.</para>
        /// <pre><code class="language-text">login1 = GetLoginToken(version=&quot;2021-02-20&quot;,
        ///     ClientId=clientId, LoginIdentifier=tenantAlias,
        ///     CurrentStage=&quot;ADPassword&quot;, EndUserId=endUserId, Password=password)
        /// sessionId = login1.SessionId
        /// loginResult = login1
        /// if loginResult.NextStage == &quot;MFAVerify&quot;:
        ///     loginResult = GetLoginToken(version=&quot;2021-02-20&quot;,
        ///         ClientId=clientId, LoginIdentifier=tenantAlias,
        ///         SessionId=sessionId, CurrentStage=&quot;MFAVerify&quot;,
        ///         AuthenticationCode=authenticationCode)
        /// </c></pre>
        /// <para>If other authentication stages are still required, continue processing based on <c>NextStage</c>. Do not treat the preceding single MFA call as a fixed endpoint. After logon is complete, call this operation by using the <c>LoginToken</c> obtained during this logon and the saved <c>SessionId</c>:</para>
        /// <pre><code class="language-text">StopAppResources(version=&quot;2021-09-03&quot;,
        ///     ClientId=clientId, LoginToken=loginResult.LoginToken, SessionId=sessionId,
        ///     ProductType=productType, AppInstanceGroupId=appInstanceGroupId,
        ///     ResourceIds=resourceIds)
        /// </c></pre>
        /// <para><c>Password</c>, <c>LoginIdentifier</c>, and <c>CurrentStage</c> belong to the prerequisite logon request and are not request parameters of <c>StopAppResources</c>. For the rules on how to specify other parameters and resource IDs for this operation, see the request parameter table below.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAppResourcesResponse
        /// </returns>
        public async Task<StopAppResourcesResponse> StopAppResourcesWithOptionsAsync(StopAppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "StopAppResources",
                Version = "2021-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAppResourcesResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops application resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>Before you call this operation, you must complete user logon authentication to obtain the <c>LoginToken</c> and <c>SessionId</c>. This <c>StopAppResources</c> operation uses the <b>2021-09-03</b> version of <c>appstream-center</c>. The prerequisite logon operation uses the <b>2021-02-20</b> version of <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-getlogintoken">GetLoginToken</a>. Use the respective API versions for each operation.</para>
        /// <h3>1. Prepare the enterprise identifier and account information</h3>
        /// <para>The following procedure applies to password authentication for convenience accounts or AD domain accounts that log on by using an enterprise identifier.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Parameter</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><c>ClientId</c></td>
        /// <td>The unique ID generated by the client. This parameter is required when you call <c>GetLoginToken</c>. The same client ID is reused in the following call sequence.</td>
        /// </tr>
        /// <tr>
        /// <td><c>LoginIdentifier</c></td>
        /// <td>The enterprise identifier for logon, which is the <c>TenantAlias</c>. The parameter name in the logon request is <c>LoginIdentifier</c>, not <c>TenantAlias</c>. To query the logon configuration of this identifier, you can call <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-findidplistbyloginidentifier">FindIdpListByLoginIdentifier (2021-02-20)</a>. The <c>TenantAliasInfo.TenantAlias</c> field in the response indicates the enterprise identifier.</td>
        /// </tr>
        /// <tr>
        /// <td><c>CurrentStage</c></td>
        /// <td>Set this parameter to <c>ADPassword</c> for password authentication. This value applies to both convenience accounts and AD domain accounts, not only AD domain accounts.</td>
        /// </tr>
        /// <tr>
        /// <td><c>EndUserId</c></td>
        /// <td>The username of the convenience account or AD domain account. This parameter is required when <c>CurrentStage</c> is set to <c>ADPassword</c>.</td>
        /// </tr>
        /// <tr>
        /// <td><c>Password</c></td>
        /// <td>The password of the corresponding account. This parameter is required when <c>CurrentStage</c> is set to <c>ADPassword</c>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h3>2. Continue logon based on the returned authentication stage</h3>
        /// <para>After you invoke <c>GetLoginToken</c> for the first time, save the returned <c>SessionId</c>. This value is returned only during the first invocation in the same logon session. If you need to authenticate further, include the saved <c>SessionId</c> in subsequent requests. Do not clear this value even if it is not returned in subsequent responses.
        /// Determine whether you still need to authenticate based on the <c>NextStage</c> field in the response, and set the required next authentication stage as the <c>CurrentStage</c> for subsequent requests. Examples:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Next authentication stage</th>
        /// <th>What to do next</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><c>MFAVerify</c></td>
        /// <td>Include the <c>SessionId</c> and the <c>AuthenticationCode</c> generated by the virtual MFA device to continue to invoke <c>GetLoginToken</c>.</td>
        /// </tr>
        /// <tr>
        /// <td><c>TokenVerify</c></td>
        /// <td>Include the <c>SessionId</c> and the client secondary authentication verification code <c>TokenCode</c> to continue to authenticate.</td>
        /// </tr>
        /// <tr>
        /// <td><c>ChangePassword</c></td>
        /// <td>Specify <c>OldPassword</c> and <c>NewPassword</c> as required to complete the password change stage.</td>
        /// </tr>
        /// <tr>
        /// <td><c>MFABind</c> or other authentication stages</td>
        /// <td>Complete the corresponding operations based on the actual returned stage and the <c>GetLoginToken</c> documentation. Do not directly apply the request parameters of <c>MFAVerify</c>.</td>
        /// </tr>
        /// <tr>
        /// <td>The authentication stages are determined by the account configuration and the result of the current logon. Not every logon must go through all the preceding stages in sequence. Invoke <c>StopAppResources</c> only after logon authentication is complete and the <c>LoginToken</c> is obtained. Do not proceed with the shutdown of resources if authentication failed or if there are pending authentication stages.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>3. Call sequence example</h3>
        /// <para>The following is pseudocode for parameter passing and is not an executable SDK example. <c>clientId</c>, <c>tenantAlias</c>, <c>endUserId</c>, <c>password</c>, and <c>authenticationCode</c> are runtime variables of the caller. <c>resourceIds</c>, <c>productType</c>, and <c>appInstanceGroupId</c> are business parameters for this operation. Do not write real passwords, verification codes, or logon credentials in examples or logs.</para>
        /// <pre><code class="language-text">login1 = GetLoginToken(version=&quot;2021-02-20&quot;,
        ///     ClientId=clientId, LoginIdentifier=tenantAlias,
        ///     CurrentStage=&quot;ADPassword&quot;, EndUserId=endUserId, Password=password)
        /// sessionId = login1.SessionId
        /// loginResult = login1
        /// if loginResult.NextStage == &quot;MFAVerify&quot;:
        ///     loginResult = GetLoginToken(version=&quot;2021-02-20&quot;,
        ///         ClientId=clientId, LoginIdentifier=tenantAlias,
        ///         SessionId=sessionId, CurrentStage=&quot;MFAVerify&quot;,
        ///         AuthenticationCode=authenticationCode)
        /// </c></pre>
        /// <para>If other authentication stages are still required, continue processing based on <c>NextStage</c>. Do not treat the preceding single MFA call as a fixed endpoint. After logon is complete, call this operation by using the <c>LoginToken</c> obtained during this logon and the saved <c>SessionId</c>:</para>
        /// <pre><code class="language-text">StopAppResources(version=&quot;2021-09-03&quot;,
        ///     ClientId=clientId, LoginToken=loginResult.LoginToken, SessionId=sessionId,
        ///     ProductType=productType, AppInstanceGroupId=appInstanceGroupId,
        ///     ResourceIds=resourceIds)
        /// </c></pre>
        /// <para><c>Password</c>, <c>LoginIdentifier</c>, and <c>CurrentStage</c> belong to the prerequisite logon request and are not request parameters of <c>StopAppResources</c>. For the rules on how to specify other parameters and resource IDs for this operation, see the request parameter table below.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAppResourcesResponse
        /// </returns>
        public StopAppResourcesResponse StopAppResources(StopAppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAppResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops application resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>Before you call this operation, you must complete user logon authentication to obtain the <c>LoginToken</c> and <c>SessionId</c>. This <c>StopAppResources</c> operation uses the <b>2021-09-03</b> version of <c>appstream-center</c>. The prerequisite logon operation uses the <b>2021-02-20</b> version of <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-getlogintoken">GetLoginToken</a>. Use the respective API versions for each operation.</para>
        /// <h3>1. Prepare the enterprise identifier and account information</h3>
        /// <para>The following procedure applies to password authentication for convenience accounts or AD domain accounts that log on by using an enterprise identifier.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Parameter</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><c>ClientId</c></td>
        /// <td>The unique ID generated by the client. This parameter is required when you call <c>GetLoginToken</c>. The same client ID is reused in the following call sequence.</td>
        /// </tr>
        /// <tr>
        /// <td><c>LoginIdentifier</c></td>
        /// <td>The enterprise identifier for logon, which is the <c>TenantAlias</c>. The parameter name in the logon request is <c>LoginIdentifier</c>, not <c>TenantAlias</c>. To query the logon configuration of this identifier, you can call <a href="https://www.alibabacloud.com/help/en/wuying-appstreaming/developer-reference/api-appstream-center-2021-02-20-findidplistbyloginidentifier">FindIdpListByLoginIdentifier (2021-02-20)</a>. The <c>TenantAliasInfo.TenantAlias</c> field in the response indicates the enterprise identifier.</td>
        /// </tr>
        /// <tr>
        /// <td><c>CurrentStage</c></td>
        /// <td>Set this parameter to <c>ADPassword</c> for password authentication. This value applies to both convenience accounts and AD domain accounts, not only AD domain accounts.</td>
        /// </tr>
        /// <tr>
        /// <td><c>EndUserId</c></td>
        /// <td>The username of the convenience account or AD domain account. This parameter is required when <c>CurrentStage</c> is set to <c>ADPassword</c>.</td>
        /// </tr>
        /// <tr>
        /// <td><c>Password</c></td>
        /// <td>The password of the corresponding account. This parameter is required when <c>CurrentStage</c> is set to <c>ADPassword</c>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h3>2. Continue logon based on the returned authentication stage</h3>
        /// <para>After you invoke <c>GetLoginToken</c> for the first time, save the returned <c>SessionId</c>. This value is returned only during the first invocation in the same logon session. If you need to authenticate further, include the saved <c>SessionId</c> in subsequent requests. Do not clear this value even if it is not returned in subsequent responses.
        /// Determine whether you still need to authenticate based on the <c>NextStage</c> field in the response, and set the required next authentication stage as the <c>CurrentStage</c> for subsequent requests. Examples:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Next authentication stage</th>
        /// <th>What to do next</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><c>MFAVerify</c></td>
        /// <td>Include the <c>SessionId</c> and the <c>AuthenticationCode</c> generated by the virtual MFA device to continue to invoke <c>GetLoginToken</c>.</td>
        /// </tr>
        /// <tr>
        /// <td><c>TokenVerify</c></td>
        /// <td>Include the <c>SessionId</c> and the client secondary authentication verification code <c>TokenCode</c> to continue to authenticate.</td>
        /// </tr>
        /// <tr>
        /// <td><c>ChangePassword</c></td>
        /// <td>Specify <c>OldPassword</c> and <c>NewPassword</c> as required to complete the password change stage.</td>
        /// </tr>
        /// <tr>
        /// <td><c>MFABind</c> or other authentication stages</td>
        /// <td>Complete the corresponding operations based on the actual returned stage and the <c>GetLoginToken</c> documentation. Do not directly apply the request parameters of <c>MFAVerify</c>.</td>
        /// </tr>
        /// <tr>
        /// <td>The authentication stages are determined by the account configuration and the result of the current logon. Not every logon must go through all the preceding stages in sequence. Invoke <c>StopAppResources</c> only after logon authentication is complete and the <c>LoginToken</c> is obtained. Do not proceed with the shutdown of resources if authentication failed or if there are pending authentication stages.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>3. Call sequence example</h3>
        /// <para>The following is pseudocode for parameter passing and is not an executable SDK example. <c>clientId</c>, <c>tenantAlias</c>, <c>endUserId</c>, <c>password</c>, and <c>authenticationCode</c> are runtime variables of the caller. <c>resourceIds</c>, <c>productType</c>, and <c>appInstanceGroupId</c> are business parameters for this operation. Do not write real passwords, verification codes, or logon credentials in examples or logs.</para>
        /// <pre><code class="language-text">login1 = GetLoginToken(version=&quot;2021-02-20&quot;,
        ///     ClientId=clientId, LoginIdentifier=tenantAlias,
        ///     CurrentStage=&quot;ADPassword&quot;, EndUserId=endUserId, Password=password)
        /// sessionId = login1.SessionId
        /// loginResult = login1
        /// if loginResult.NextStage == &quot;MFAVerify&quot;:
        ///     loginResult = GetLoginToken(version=&quot;2021-02-20&quot;,
        ///         ClientId=clientId, LoginIdentifier=tenantAlias,
        ///         SessionId=sessionId, CurrentStage=&quot;MFAVerify&quot;,
        ///         AuthenticationCode=authenticationCode)
        /// </c></pre>
        /// <para>If other authentication stages are still required, continue processing based on <c>NextStage</c>. Do not treat the preceding single MFA call as a fixed endpoint. After logon is complete, call this operation by using the <c>LoginToken</c> obtained during this logon and the saved <c>SessionId</c>:</para>
        /// <pre><code class="language-text">StopAppResources(version=&quot;2021-09-03&quot;,
        ///     ClientId=clientId, LoginToken=loginResult.LoginToken, SessionId=sessionId,
        ///     ProductType=productType, AppInstanceGroupId=appInstanceGroupId,
        ///     ResourceIds=resourceIds)
        /// </c></pre>
        /// <para><c>Password</c>, <c>LoginIdentifier</c>, and <c>CurrentStage</c> belong to the prerequisite logon request and are not request parameters of <c>StopAppResources</c>. For the rules on how to specify other parameters and resource IDs for this operation, see the request parameter table below.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAppResourcesResponse
        /// </returns>
        public async Task<StopAppResourcesResponse> StopAppResourcesAsync(StopAppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAppResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds an application instance from a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionToken))
            {
                body["SessionToken"] = request.SessionToken;
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
            return TeaModel.ToObject<UnbindResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds an application instance from a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionToken))
            {
                body["SessionToken"] = request.SessionToken;
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
            return TeaModel.ToObject<UnbindResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds an application instance from a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindResponse
        /// </returns>
        public UnbindResponse Unbind(UnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds an application instance from a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindResponse
        /// </returns>
        public async Task<UnbindResponse> UnbindAsync(UnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindWithOptionsAsync(request, runtime);
        }

    }
}
