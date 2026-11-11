// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EcdBiz20240929.Models;

namespace AlibabaCloud.SDK.EcdBiz20240929
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "EcdBiz";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ecdbiz", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Activates the commercial edition rights under the current account. First, query the rights by calling ListRights, and then select the target region, office network, image, and user. A Success response indicates that the request is processed. To check the resource creation result, query the RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId parameters returned by ListRights.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Activates the commercial edition rights under the current account. First, query the rights by calling ListRights, and then select the target region, office network, image, and user. A Success response indicates that the request is processed. To check the resource creation result, query the RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId parameters returned by ListRights.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveRightsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActiveRightsResponse
        /// </returns>
        public ActiveRightsResponse ActiveRightsWithOptions(ActiveRightsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDiskSize))
            {
                query["DataDiskSize"] = request.DataDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopType))
            {
                query["DesktopType"] = request.DesktopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootDiskSize))
            {
                query["RootDiskSize"] = request.RootDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyidList))
            {
                query["WyidList"] = request.WyidList;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomImageId))
            {
                body["CustomImageId"] = request.CustomImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hibernate))
            {
                body["Hibernate"] = request.Hibernate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                body["OfficeSiteId"] = request.OfficeSiteId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsAssignedUser))
            {
                bodyFlat["RightsAssignedUser"] = request.RightsAssignedUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsGpuSpec))
            {
                body["RightsGpuSpec"] = request.RightsGpuSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsIds))
            {
                bodyFlat["RightsIds"] = request.RightsIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceArea))
            {
                body["RightsResourceArea"] = request.RightsResourceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceImageOs))
            {
                body["RightsResourceImageOs"] = request.RightsResourceImageOs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceRegion))
            {
                body["RightsResourceRegion"] = request.RightsResourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceType))
            {
                body["RightsResourceType"] = request.RightsResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsSpec))
            {
                body["RightsSpec"] = request.RightsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveRights",
                Version = "2024-09-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveRightsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the commercial edition rights under the current account. First, query the rights by calling ListRights, and then select the target region, office network, image, and user. A Success response indicates that the request is processed. To check the resource creation result, query the RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId parameters returned by ListRights.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Activates the commercial edition rights under the current account. First, query the rights by calling ListRights, and then select the target region, office network, image, and user. A Success response indicates that the request is processed. To check the resource creation result, query the RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId parameters returned by ListRights.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveRightsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActiveRightsResponse
        /// </returns>
        public async Task<ActiveRightsResponse> ActiveRightsWithOptionsAsync(ActiveRightsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDiskSize))
            {
                query["DataDiskSize"] = request.DataDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopType))
            {
                query["DesktopType"] = request.DesktopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootDiskSize))
            {
                query["RootDiskSize"] = request.RootDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyidList))
            {
                query["WyidList"] = request.WyidList;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomImageId))
            {
                body["CustomImageId"] = request.CustomImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hibernate))
            {
                body["Hibernate"] = request.Hibernate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                body["OfficeSiteId"] = request.OfficeSiteId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsAssignedUser))
            {
                bodyFlat["RightsAssignedUser"] = request.RightsAssignedUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsGpuSpec))
            {
                body["RightsGpuSpec"] = request.RightsGpuSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsIds))
            {
                bodyFlat["RightsIds"] = request.RightsIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceArea))
            {
                body["RightsResourceArea"] = request.RightsResourceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceImageOs))
            {
                body["RightsResourceImageOs"] = request.RightsResourceImageOs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceRegion))
            {
                body["RightsResourceRegion"] = request.RightsResourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceType))
            {
                body["RightsResourceType"] = request.RightsResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsSpec))
            {
                body["RightsSpec"] = request.RightsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveRights",
                Version = "2024-09-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveRightsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the commercial edition rights under the current account. First, query the rights by calling ListRights, and then select the target region, office network, image, and user. A Success response indicates that the request is processed. To check the resource creation result, query the RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId parameters returned by ListRights.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Activates the commercial edition rights under the current account. First, query the rights by calling ListRights, and then select the target region, office network, image, and user. A Success response indicates that the request is processed. To check the resource creation result, query the RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId parameters returned by ListRights.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveRightsRequest
        /// </param>
        /// 
        /// <returns>
        /// ActiveRightsResponse
        /// </returns>
        public ActiveRightsResponse ActiveRights(ActiveRightsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveRightsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the commercial edition rights under the current account. First, query the rights by calling ListRights, and then select the target region, office network, image, and user. A Success response indicates that the request is processed. To check the resource creation result, query the RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId parameters returned by ListRights.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Activates the commercial edition rights under the current account. First, query the rights by calling ListRights, and then select the target region, office network, image, and user. A Success response indicates that the request is processed. To check the resource creation result, query the RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId parameters returned by ListRights.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveRightsRequest
        /// </param>
        /// 
        /// <returns>
        /// ActiveRightsResponse
        /// </returns>
        public async Task<ActiveRightsResponse> ActiveRightsAsync(ActiveRightsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveRightsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commercial edition rights accessible to the current caller identity by using paging. Use this operation to select rights before activation. After you call ActiveRights, you can query the processing results by using RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the commercial edition rights accessible to the current caller identity by using paging. Use this operation to select rights before activation. After you call ActiveRights, you can query the processing results by using RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRightsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRightsResponse
        /// </returns>
        public ListRightsResponse ListRightsWithOptions(ListRightsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessSceneCode))
            {
                query["BusinessSceneCode"] = request.BusinessSceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsIds))
            {
                query["RightsIds"] = request.RightsIds;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiDesktop))
            {
                body["AiDesktop"] = request.AiDesktop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overseas))
            {
                body["Overseas"] = request.Overseas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsActiveStatus))
            {
                body["RightsActiveStatus"] = request.RightsActiveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsAssignedUser))
            {
                body["RightsAssignedUser"] = request.RightsAssignedUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsPeriod))
            {
                body["RightsPeriod"] = request.RightsPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceId))
            {
                body["RightsResourceId"] = request.RightsResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceType))
            {
                body["RightsResourceType"] = request.RightsResourceType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceTypes))
            {
                bodyFlat["RightsResourceTypes"] = request.RightsResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsSpec))
            {
                body["RightsSpec"] = request.RightsSpec;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRights",
                Version = "2024-09-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRightsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commercial edition rights accessible to the current caller identity by using paging. Use this operation to select rights before activation. After you call ActiveRights, you can query the processing results by using RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the commercial edition rights accessible to the current caller identity by using paging. Use this operation to select rights before activation. After you call ActiveRights, you can query the processing results by using RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRightsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRightsResponse
        /// </returns>
        public async Task<ListRightsResponse> ListRightsWithOptionsAsync(ListRightsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessSceneCode))
            {
                query["BusinessSceneCode"] = request.BusinessSceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsIds))
            {
                query["RightsIds"] = request.RightsIds;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiDesktop))
            {
                body["AiDesktop"] = request.AiDesktop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overseas))
            {
                body["Overseas"] = request.Overseas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsActiveStatus))
            {
                body["RightsActiveStatus"] = request.RightsActiveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsAssignedUser))
            {
                body["RightsAssignedUser"] = request.RightsAssignedUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsPeriod))
            {
                body["RightsPeriod"] = request.RightsPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceId))
            {
                body["RightsResourceId"] = request.RightsResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceType))
            {
                body["RightsResourceType"] = request.RightsResourceType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsResourceTypes))
            {
                bodyFlat["RightsResourceTypes"] = request.RightsResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightsSpec))
            {
                body["RightsSpec"] = request.RightsSpec;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRights",
                Version = "2024-09-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRightsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commercial edition rights accessible to the current caller identity by using paging. Use this operation to select rights before activation. After you call ActiveRights, you can query the processing results by using RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the commercial edition rights accessible to the current caller identity by using paging. Use this operation to select rights before activation. After you call ActiveRights, you can query the processing results by using RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRightsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRightsResponse
        /// </returns>
        public ListRightsResponse ListRights(ListRightsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRightsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commercial edition rights accessible to the current caller identity by using paging. Use this operation to select rights before activation. After you call ActiveRights, you can query the processing results by using RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the commercial edition rights accessible to the current caller identity by using paging. Use this operation to select rights before activation. After you call ActiveRights, you can query the processing results by using RightsActiveStatus, RightsActiveFailureCause, and RightsResourceId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRightsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRightsResponse
        /// </returns>
        public async Task<ListRightsResponse> ListRightsAsync(ListRightsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRightsWithOptionsAsync(request, runtime);
        }

    }
}
