// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Appstream_center20210901.Models;

namespace AlibabaCloud.SDK.Appstream_center20210901
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
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
        /// <para>Sets the execution time for an OTA upgrade.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveOtaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveOtaTaskResponse
        /// </returns>
        public ApproveOtaTaskResponse ApproveOtaTaskWithOptions(ApproveOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                body["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApproveOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveOtaTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the execution time for an OTA upgrade.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveOtaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveOtaTaskResponse
        /// </returns>
        public async Task<ApproveOtaTaskResponse> ApproveOtaTaskWithOptionsAsync(ApproveOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                body["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApproveOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveOtaTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the execution time for an OTA upgrade.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveOtaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveOtaTaskResponse
        /// </returns>
        public ApproveOtaTaskResponse ApproveOtaTask(ApproveOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveOtaTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the execution time for an OTA upgrade.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveOtaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveOtaTaskResponse
        /// </returns>
        public async Task<ApproveOtaTaskResponse> ApproveOtaTaskAsync(ApproveOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveOtaTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns secondary private IP addresses to a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignWuyingServerPrivateAddressesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignWuyingServerPrivateAddressesResponse
        /// </returns>
        public AssignWuyingServerPrivateAddressesResponse AssignWuyingServerPrivateAddressesWithOptions(AssignWuyingServerPrivateAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryPrivateIpAddressCount))
            {
                body["SecondaryPrivateIpAddressCount"] = request.SecondaryPrivateIpAddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignWuyingServerPrivateAddresses",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignWuyingServerPrivateAddressesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns secondary private IP addresses to a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignWuyingServerPrivateAddressesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignWuyingServerPrivateAddressesResponse
        /// </returns>
        public async Task<AssignWuyingServerPrivateAddressesResponse> AssignWuyingServerPrivateAddressesWithOptionsAsync(AssignWuyingServerPrivateAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryPrivateIpAddressCount))
            {
                body["SecondaryPrivateIpAddressCount"] = request.SecondaryPrivateIpAddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignWuyingServerPrivateAddresses",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignWuyingServerPrivateAddressesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns secondary private IP addresses to a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignWuyingServerPrivateAddressesRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignWuyingServerPrivateAddressesResponse
        /// </returns>
        public AssignWuyingServerPrivateAddressesResponse AssignWuyingServerPrivateAddresses(AssignWuyingServerPrivateAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignWuyingServerPrivateAddressesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns secondary private IP addresses to a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignWuyingServerPrivateAddressesRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignWuyingServerPrivateAddressesResponse
        /// </returns>
        public async Task<AssignWuyingServerPrivateAddressesResponse> AssignWuyingServerPrivateAddressesAsync(AssignWuyingServerPrivateAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignWuyingServerPrivateAddressesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or removes assigned users for a delivery group. Only users added as assigned users can access cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you change assigned users, the selected users receive notification emails. Changes typically take about 2 minutes to take effect on the client.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AuthorizeInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeInstanceGroupResponse
        /// </returns>
        public AuthorizeInstanceGroupResponse AuthorizeInstanceGroupWithOptions(AuthorizeInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthorizeInstanceGroupShrinkRequest request = new AuthorizeInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserMeta))
            {
                request.UserMetaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserMeta, "UserMeta", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                body["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserGroupIds))
            {
                bodyFlat["AuthorizeUserGroupIds"] = request.AuthorizeUserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserIds))
            {
                bodyFlat["AuthorizeUserIds"] = request.AuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                body["AvatarId"] = request.AvatarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserGroupIds))
            {
                bodyFlat["UnAuthorizeUserGroupIds"] = request.UnAuthorizeUserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserIds))
            {
                bodyFlat["UnAuthorizeUserIds"] = request.UnAuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMetaShrink))
            {
                body["UserMeta"] = request.UserMetaShrink;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or removes assigned users for a delivery group. Only users added as assigned users can access cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you change assigned users, the selected users receive notification emails. Changes typically take about 2 minutes to take effect on the client.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AuthorizeInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeInstanceGroupResponse
        /// </returns>
        public async Task<AuthorizeInstanceGroupResponse> AuthorizeInstanceGroupWithOptionsAsync(AuthorizeInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthorizeInstanceGroupShrinkRequest request = new AuthorizeInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserMeta))
            {
                request.UserMetaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserMeta, "UserMeta", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                body["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserGroupIds))
            {
                bodyFlat["AuthorizeUserGroupIds"] = request.AuthorizeUserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserIds))
            {
                bodyFlat["AuthorizeUserIds"] = request.AuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                body["AvatarId"] = request.AvatarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserGroupIds))
            {
                bodyFlat["UnAuthorizeUserGroupIds"] = request.UnAuthorizeUserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserIds))
            {
                bodyFlat["UnAuthorizeUserIds"] = request.UnAuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMetaShrink))
            {
                body["UserMeta"] = request.UserMetaShrink;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or removes assigned users for a delivery group. Only users added as assigned users can access cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you change assigned users, the selected users receive notification emails. Changes typically take about 2 minutes to take effect on the client.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthorizeInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeInstanceGroupResponse
        /// </returns>
        public AuthorizeInstanceGroupResponse AuthorizeInstanceGroup(AuthorizeInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or removes assigned users for a delivery group. Only users added as assigned users can access cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you change assigned users, the selected users receive notification emails. Changes typically take about 2 minutes to take effect on the client.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthorizeInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeInstanceGroupResponse
        /// </returns>
        public async Task<AuthorizeInstanceGroupResponse> AuthorizeInstanceGroupAsync(AuthorizeInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or removes authorized users for a specified application deployed in a delivery group. Only authorized users can access the application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation manages user authorization for a delivery group at the application level. The authorization result applies only to the application specified by AppId and does not affect the authorization of other applications in the delivery group. To authorize users for an entire delivery group, call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The delivery group is created, and <b>the application specified by AppId is deployed in the image used by the delivery group</b>. Otherwise, the error code <c>InvalidAppId.NotFound</c> is returned.</description></item>
        /// <item><description>The delivery group <b>has not been added to a delivery group set that is in effect</b>. A delivery group that has been added to a set cannot be authorized individually. You must authorize it through the set. Otherwise, the error code <c>InvalidAppInstanceGroup.AuthorizeBlockedBySet</c> is returned.</description></item>
        /// <item><description>If the workspace to which the delivery group belongs is an Active Directory (AD) workspace, <b>you must specify UserMeta</b>, with <c>UserMeta.Type</c> set to <c>ad</c> and <c>UserMeta.AdDomain</c> matching the AD domain bound to the workspace.</description></item>
        /// <item><description>If the delivery group has been authorized through user groups and mixed authorization of users and user groups is not supported, you cannot authorize by user. Otherwise, the error code <c>AuthAppInstanceGroup.MixNotSupported</c> is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>At least one of AuthorizeUserIds and UnAuthorizeUserIds must be specified.</b> You can also specify both. If both are empty, this invocation does not change any authorization.</description></item>
        /// <item><description>When adding authorizations, the sum of the currently authorized users for the application and the users to be added cannot exceed the authorized user quota for the application. If the quota is exceeded, the error code <c>ExceedAppAuthUserQuota</c> is returned. Removing authorizations is not subject to quota limits.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> or <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId) and the application IDs of deployed applications in the delivery group (AppId in the Apps list).</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/436936.html">DescribeUsers</a> operation to obtain the usernames of the users to be authorized or unauthorized.</description></item>
        /// <item><description>Call this operation to complete the authorization change.<remarks>
        /// <para>After the authorization is changed, the selected users receive a notification email. It typically takes about 2 minutes for the change to take effect on the client.</para>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AuthorizeUsersForAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeUsersForAppResponse
        /// </returns>
        public AuthorizeUsersForAppResponse AuthorizeUsersForAppWithOptions(AuthorizeUsersForAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthorizeUsersForAppShrinkRequest request = new AuthorizeUsersForAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserMeta))
            {
                request.UserMetaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserMeta, "UserMeta", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserIds))
            {
                body["AuthorizeUserIds"] = request.AuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserIds))
            {
                body["UnAuthorizeUserIds"] = request.UnAuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMetaShrink))
            {
                body["UserMeta"] = request.UserMetaShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeUsersForApp",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeUsersForAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or removes authorized users for a specified application deployed in a delivery group. Only authorized users can access the application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation manages user authorization for a delivery group at the application level. The authorization result applies only to the application specified by AppId and does not affect the authorization of other applications in the delivery group. To authorize users for an entire delivery group, call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The delivery group is created, and <b>the application specified by AppId is deployed in the image used by the delivery group</b>. Otherwise, the error code <c>InvalidAppId.NotFound</c> is returned.</description></item>
        /// <item><description>The delivery group <b>has not been added to a delivery group set that is in effect</b>. A delivery group that has been added to a set cannot be authorized individually. You must authorize it through the set. Otherwise, the error code <c>InvalidAppInstanceGroup.AuthorizeBlockedBySet</c> is returned.</description></item>
        /// <item><description>If the workspace to which the delivery group belongs is an Active Directory (AD) workspace, <b>you must specify UserMeta</b>, with <c>UserMeta.Type</c> set to <c>ad</c> and <c>UserMeta.AdDomain</c> matching the AD domain bound to the workspace.</description></item>
        /// <item><description>If the delivery group has been authorized through user groups and mixed authorization of users and user groups is not supported, you cannot authorize by user. Otherwise, the error code <c>AuthAppInstanceGroup.MixNotSupported</c> is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>At least one of AuthorizeUserIds and UnAuthorizeUserIds must be specified.</b> You can also specify both. If both are empty, this invocation does not change any authorization.</description></item>
        /// <item><description>When adding authorizations, the sum of the currently authorized users for the application and the users to be added cannot exceed the authorized user quota for the application. If the quota is exceeded, the error code <c>ExceedAppAuthUserQuota</c> is returned. Removing authorizations is not subject to quota limits.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> or <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId) and the application IDs of deployed applications in the delivery group (AppId in the Apps list).</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/436936.html">DescribeUsers</a> operation to obtain the usernames of the users to be authorized or unauthorized.</description></item>
        /// <item><description>Call this operation to complete the authorization change.<remarks>
        /// <para>After the authorization is changed, the selected users receive a notification email. It typically takes about 2 minutes for the change to take effect on the client.</para>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AuthorizeUsersForAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeUsersForAppResponse
        /// </returns>
        public async Task<AuthorizeUsersForAppResponse> AuthorizeUsersForAppWithOptionsAsync(AuthorizeUsersForAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthorizeUsersForAppShrinkRequest request = new AuthorizeUsersForAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserMeta))
            {
                request.UserMetaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserMeta, "UserMeta", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserIds))
            {
                body["AuthorizeUserIds"] = request.AuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserIds))
            {
                body["UnAuthorizeUserIds"] = request.UnAuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMetaShrink))
            {
                body["UserMeta"] = request.UserMetaShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeUsersForApp",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeUsersForAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or removes authorized users for a specified application deployed in a delivery group. Only authorized users can access the application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation manages user authorization for a delivery group at the application level. The authorization result applies only to the application specified by AppId and does not affect the authorization of other applications in the delivery group. To authorize users for an entire delivery group, call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The delivery group is created, and <b>the application specified by AppId is deployed in the image used by the delivery group</b>. Otherwise, the error code <c>InvalidAppId.NotFound</c> is returned.</description></item>
        /// <item><description>The delivery group <b>has not been added to a delivery group set that is in effect</b>. A delivery group that has been added to a set cannot be authorized individually. You must authorize it through the set. Otherwise, the error code <c>InvalidAppInstanceGroup.AuthorizeBlockedBySet</c> is returned.</description></item>
        /// <item><description>If the workspace to which the delivery group belongs is an Active Directory (AD) workspace, <b>you must specify UserMeta</b>, with <c>UserMeta.Type</c> set to <c>ad</c> and <c>UserMeta.AdDomain</c> matching the AD domain bound to the workspace.</description></item>
        /// <item><description>If the delivery group has been authorized through user groups and mixed authorization of users and user groups is not supported, you cannot authorize by user. Otherwise, the error code <c>AuthAppInstanceGroup.MixNotSupported</c> is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>At least one of AuthorizeUserIds and UnAuthorizeUserIds must be specified.</b> You can also specify both. If both are empty, this invocation does not change any authorization.</description></item>
        /// <item><description>When adding authorizations, the sum of the currently authorized users for the application and the users to be added cannot exceed the authorized user quota for the application. If the quota is exceeded, the error code <c>ExceedAppAuthUserQuota</c> is returned. Removing authorizations is not subject to quota limits.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> or <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId) and the application IDs of deployed applications in the delivery group (AppId in the Apps list).</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/436936.html">DescribeUsers</a> operation to obtain the usernames of the users to be authorized or unauthorized.</description></item>
        /// <item><description>Call this operation to complete the authorization change.<remarks>
        /// <para>After the authorization is changed, the selected users receive a notification email. It typically takes about 2 minutes for the change to take effect on the client.</para>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthorizeUsersForAppRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeUsersForAppResponse
        /// </returns>
        public AuthorizeUsersForAppResponse AuthorizeUsersForApp(AuthorizeUsersForAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeUsersForAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or removes authorized users for a specified application deployed in a delivery group. Only authorized users can access the application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation manages user authorization for a delivery group at the application level. The authorization result applies only to the application specified by AppId and does not affect the authorization of other applications in the delivery group. To authorize users for an entire delivery group, call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The delivery group is created, and <b>the application specified by AppId is deployed in the image used by the delivery group</b>. Otherwise, the error code <c>InvalidAppId.NotFound</c> is returned.</description></item>
        /// <item><description>The delivery group <b>has not been added to a delivery group set that is in effect</b>. A delivery group that has been added to a set cannot be authorized individually. You must authorize it through the set. Otherwise, the error code <c>InvalidAppInstanceGroup.AuthorizeBlockedBySet</c> is returned.</description></item>
        /// <item><description>If the workspace to which the delivery group belongs is an Active Directory (AD) workspace, <b>you must specify UserMeta</b>, with <c>UserMeta.Type</c> set to <c>ad</c> and <c>UserMeta.AdDomain</c> matching the AD domain bound to the workspace.</description></item>
        /// <item><description>If the delivery group has been authorized through user groups and mixed authorization of users and user groups is not supported, you cannot authorize by user. Otherwise, the error code <c>AuthAppInstanceGroup.MixNotSupported</c> is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>At least one of AuthorizeUserIds and UnAuthorizeUserIds must be specified.</b> You can also specify both. If both are empty, this invocation does not change any authorization.</description></item>
        /// <item><description>When adding authorizations, the sum of the currently authorized users for the application and the users to be added cannot exceed the authorized user quota for the application. If the quota is exceeded, the error code <c>ExceedAppAuthUserQuota</c> is returned. Removing authorizations is not subject to quota limits.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> or <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId) and the application IDs of deployed applications in the delivery group (AppId in the Apps list).</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/436936.html">DescribeUsers</a> operation to obtain the usernames of the users to be authorized or unauthorized.</description></item>
        /// <item><description>Call this operation to complete the authorization change.<remarks>
        /// <para>After the authorization is changed, the selected users receive a notification email. It typically takes about 2 minutes for the change to take effect on the client.</para>
        /// </remarks>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthorizeUsersForAppRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeUsersForAppResponse
        /// </returns>
        public async Task<AuthorizeUsersForAppResponse> AuthorizeUsersForAppAsync(AuthorizeUsersForAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeUsersForAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates LLM templates in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can batch create model templates under a model provider template in the Wuying Agent Management Center. Multiple models can be added at a time, and one of them can be specified as the default model. Existing models are automatically skipped and not created again.
        /// Before using this operation, make sure you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchCreateLlmTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateLlmTemplatesResponse
        /// </returns>
        public BatchCreateLlmTemplatesResponse BatchCreateLlmTemplatesWithOptions(BatchCreateLlmTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmTemplateItems))
            {
                body["LlmTemplateItems"] = request.LlmTemplateItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                body["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateLlmTemplates",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateLlmTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates LLM templates in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can batch create model templates under a model provider template in the Wuying Agent Management Center. Multiple models can be added at a time, and one of them can be specified as the default model. Existing models are automatically skipped and not created again.
        /// Before using this operation, make sure you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchCreateLlmTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateLlmTemplatesResponse
        /// </returns>
        public async Task<BatchCreateLlmTemplatesResponse> BatchCreateLlmTemplatesWithOptionsAsync(BatchCreateLlmTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmTemplateItems))
            {
                body["LlmTemplateItems"] = request.LlmTemplateItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                body["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateLlmTemplates",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateLlmTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates LLM templates in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can batch create model templates under a model provider template in the Wuying Agent Management Center. Multiple models can be added at a time, and one of them can be specified as the default model. Existing models are automatically skipped and not created again.
        /// Before using this operation, make sure you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchCreateLlmTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateLlmTemplatesResponse
        /// </returns>
        public BatchCreateLlmTemplatesResponse BatchCreateLlmTemplates(BatchCreateLlmTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateLlmTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates LLM templates in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can batch create model templates under a model provider template in the Wuying Agent Management Center. Multiple models can be added at a time, and one of them can be specified as the default model. Existing models are automatically skipped and not created again.
        /// Before using this operation, make sure you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchCreateLlmTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateLlmTemplatesResponse
        /// </returns>
        public async Task<BatchCreateLlmTemplatesResponse> BatchCreateLlmTemplatesAsync(BatchCreateLlmTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateLlmTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the model group for a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can assign a model group to the resources that belong to agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model group serves as the inference engine for agents within the resource group to execute tasks.
        /// When an agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting has a higher priority than the agent runtime setting.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigResourceGroupModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigResourceGroupModelTemplateResponse
        /// </returns>
        public ConfigResourceGroupModelTemplateResponse ConfigResourceGroupModelTemplateWithOptions(ConfigResourceGroupModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigResourceGroupModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigResourceGroupModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the model group for a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can assign a model group to the resources that belong to agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model group serves as the inference engine for agents within the resource group to execute tasks.
        /// When an agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting has a higher priority than the agent runtime setting.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigResourceGroupModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigResourceGroupModelTemplateResponse
        /// </returns>
        public async Task<ConfigResourceGroupModelTemplateResponse> ConfigResourceGroupModelTemplateWithOptionsAsync(ConfigResourceGroupModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigResourceGroupModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigResourceGroupModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the model group for a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can assign a model group to the resources that belong to agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model group serves as the inference engine for agents within the resource group to execute tasks.
        /// When an agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting has a higher priority than the agent runtime setting.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigResourceGroupModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigResourceGroupModelTemplateResponse
        /// </returns>
        public ConfigResourceGroupModelTemplateResponse ConfigResourceGroupModelTemplate(ConfigResourceGroupModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigResourceGroupModelTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the model group for a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can assign a model group to the resources that belong to agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model group serves as the inference engine for agents within the resource group to execute tasks.
        /// When an agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting has a higher priority than the agent runtime setting.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigResourceGroupModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigResourceGroupModelTemplateResponse
        /// </returns>
        public async Task<ConfigResourceGroupModelTemplateResponse> ConfigResourceGroupModelTemplateAsync(ConfigResourceGroupModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigResourceGroupModelTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a third-party channel for Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure third-party channels for Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. These channels serve as extended Agent communication methods beyond the AgentIM channel.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigRuntimeChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigRuntimeChannelResponse
        /// </returns>
        public ConfigRuntimeChannelResponse ConfigRuntimeChannelWithOptions(ConfigRuntimeChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                body["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                body["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMode))
            {
                body["ConfigMode"] = request.ConfigMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeIds))
            {
                body["RuntimeIds"] = request.RuntimeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigRuntimeChannel",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigRuntimeChannelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a third-party channel for Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure third-party channels for Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. These channels serve as extended Agent communication methods beyond the AgentIM channel.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigRuntimeChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigRuntimeChannelResponse
        /// </returns>
        public async Task<ConfigRuntimeChannelResponse> ConfigRuntimeChannelWithOptionsAsync(ConfigRuntimeChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                body["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                body["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMode))
            {
                body["ConfigMode"] = request.ConfigMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeIds))
            {
                body["RuntimeIds"] = request.RuntimeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigRuntimeChannel",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigRuntimeChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a third-party channel for Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure third-party channels for Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. These channels serve as extended Agent communication methods beyond the AgentIM channel.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigRuntimeChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigRuntimeChannelResponse
        /// </returns>
        public ConfigRuntimeChannelResponse ConfigRuntimeChannel(ConfigRuntimeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigRuntimeChannelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a third-party channel for Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure third-party channels for Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. These channels serve as extended Agent communication methods beyond the AgentIM channel.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigRuntimeChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigRuntimeChannelResponse
        /// </returns>
        public async Task<ConfigRuntimeChannelResponse> ConfigRuntimeChannelAsync(ConfigRuntimeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigRuntimeChannelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures model groups for Agent runtime resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can authorize model groups for Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. The model groups serve as inference engines for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigRuntimeModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigRuntimeModelTemplateResponse
        /// </returns>
        public ConfigRuntimeModelTemplateResponse ConfigRuntimeModelTemplateWithOptions(ConfigRuntimeModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeIds))
            {
                body["RuntimeIds"] = request.RuntimeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigRuntimeModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigRuntimeModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures model groups for Agent runtime resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can authorize model groups for Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. The model groups serve as inference engines for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigRuntimeModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigRuntimeModelTemplateResponse
        /// </returns>
        public async Task<ConfigRuntimeModelTemplateResponse> ConfigRuntimeModelTemplateWithOptionsAsync(ConfigRuntimeModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeIds))
            {
                body["RuntimeIds"] = request.RuntimeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigRuntimeModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigRuntimeModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures model groups for Agent runtime resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can authorize model groups for Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. The model groups serve as inference engines for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigRuntimeModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigRuntimeModelTemplateResponse
        /// </returns>
        public ConfigRuntimeModelTemplateResponse ConfigRuntimeModelTemplate(ConfigRuntimeModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigRuntimeModelTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures model groups for Agent runtime resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can authorize model groups for Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. The model groups serve as inference engines for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigRuntimeModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigRuntimeModelTemplateResponse
        /// </returns>
        public async Task<ConfigRuntimeModelTemplateResponse> ConfigRuntimeModelTemplateAsync(ConfigRuntimeModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigRuntimeModelTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING CloudApp.
        /// A delivery group is a logical grouping for delivering cloud applications to end users. It includes the underlying cloud application resources, images that contain cloud applications, resource management policies, and user allocation settings. For details, see <a href="https://help.aliyun.com/document_detail/426046.html">Publish a delivery group</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceGroupResponse
        /// </returns>
        public CreateAppInstanceGroupResponse CreateAppInstanceGroupWithOptions(CreateAppInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppInstanceGroupShrinkRequest request = new CreateAppInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RuntimePolicy))
            {
                request.RuntimePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RuntimePolicy, "RuntimePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserDefinePolicy))
            {
                request.UserDefinePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserDefinePolicy, "UserDefinePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoPolicy))
            {
                request.VideoPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoPolicy, "VideoPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDefinePolicyShrink))
            {
                query["UserDefinePolicy"] = request.UserDefinePolicyShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                body["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                body["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPackageType))
            {
                body["AppPackageType"] = request.AppPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                body["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMode))
            {
                body["AuthMode"] = request.AuthMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeResourceMode))
            {
                body["ChargeResourceMode"] = request.ChargeResourceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenAppId))
            {
                body["PreOpenAppId"] = request.PreOpenAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimePolicyShrink))
            {
                body["RuntimePolicy"] = request.RuntimePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                body["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPayType))
            {
                body["SubPayType"] = request.SubPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                body["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPolicyShrink))
            {
                body["VideoPolicy"] = request.VideoPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING CloudApp.
        /// A delivery group is a logical grouping for delivering cloud applications to end users. It includes the underlying cloud application resources, images that contain cloud applications, resource management policies, and user allocation settings. For details, see <a href="https://help.aliyun.com/document_detail/426046.html">Publish a delivery group</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceGroupResponse
        /// </returns>
        public async Task<CreateAppInstanceGroupResponse> CreateAppInstanceGroupWithOptionsAsync(CreateAppInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppInstanceGroupShrinkRequest request = new CreateAppInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RuntimePolicy))
            {
                request.RuntimePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RuntimePolicy, "RuntimePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserDefinePolicy))
            {
                request.UserDefinePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserDefinePolicy, "UserDefinePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoPolicy))
            {
                request.VideoPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoPolicy, "VideoPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDefinePolicyShrink))
            {
                query["UserDefinePolicy"] = request.UserDefinePolicyShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                body["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                body["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPackageType))
            {
                body["AppPackageType"] = request.AppPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                body["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMode))
            {
                body["AuthMode"] = request.AuthMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeResourceMode))
            {
                body["ChargeResourceMode"] = request.ChargeResourceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenAppId))
            {
                body["PreOpenAppId"] = request.PreOpenAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimePolicyShrink))
            {
                body["RuntimePolicy"] = request.RuntimePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                body["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPayType))
            {
                body["SubPayType"] = request.SubPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                body["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPolicyShrink))
            {
                body["VideoPolicy"] = request.VideoPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING CloudApp.
        /// A delivery group is a logical grouping for delivering cloud applications to end users. It includes the underlying cloud application resources, images that contain cloud applications, resource management policies, and user allocation settings. For details, see <a href="https://help.aliyun.com/document_detail/426046.html">Publish a delivery group</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceGroupResponse
        /// </returns>
        public CreateAppInstanceGroupResponse CreateAppInstanceGroup(CreateAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING CloudApp.
        /// A delivery group is a logical grouping for delivering cloud applications to end users. It includes the underlying cloud application resources, images that contain cloud applications, resource management policies, and user allocation settings. For details, see <a href="https://help.aliyun.com/document_detail/426046.html">Publish a delivery group</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceGroupResponse
        /// </returns>
        public async Task<CreateAppInstanceGroupResponse> CreateAppInstanceGroupAsync(CreateAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud browser group that is billed by monthly active users (MAU).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Prepare an available office network, image, and instance type in the target business region. Make sure that the account has the required browser configurations and resource quotas.</description></item>
        /// <item><description>Specify <c>CloudBrowserName</c> and <c>BizRegionId</c>. Set <c>OsType</c> to <c>Windows</c>.</description></item>
        /// <item><description>Authorized users must be created in advance and must match the account type. Authorized user groups must belong to the current account and match the account type of the office network.</description></item>
        /// <item><description><b><c>Users</c> and <c>UserGroupIds</c> cannot both be non-empty.</b></description></item>
        /// </list>
        /// <h2>MAU billing parameters</h2>
        /// <list type="bullet">
        /// <item><description>Set <c>ChargeType</c> to <c>PostPaid</c>.</description></item>
        /// <item><description><b>Set <c>SubPayType</c> to <c>mau</c> explicitly. Omitting this field does not enable MAU billing.</b></description></item>
        /// <item><description>Set <c>ChargeResourceMode</c> to <c>AppInstance</c>.</description></item>
        /// <item><description>Do not specify <c>Period</c>, <c>PeriodUnit</c>, <c>AppPackageType</c>, <c>AutoPay</c>, <c>AutoRenew</c>, or <c>NodePool</c>.</description></item>
        /// </list>
        /// <h2>Post-call processing</h2>
        /// <para><b>A successful response does not indicate that the browser resources are ready.</b> After creation, query the browser group status and confirm that the group is connectable before use.
        /// This operation creates a new cloud browser group. You do not need to create a delivery group in advance.</para>
        /// <h2>Example description</h2>
        /// <para>The example values of fields are provided to demonstrate how to specify the fields. Replace resource identifiers with actual values under your account. Capacity examples do not represent default values or upper limits.
        /// An example value of <c>-</c> indicates that the field does not need to be specified. Omit the corresponding parameter when you call the operation. Do not pass the character <c>-</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateBrowserInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBrowserInstanceGroupResponse
        /// </returns>
        public CreateBrowserInstanceGroupResponse CreateBrowserInstanceGroupWithOptions(CreateBrowserInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBrowserInstanceGroupShrinkRequest request = new CreateBrowserInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BrowserConfig))
            {
                request.BrowserConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BrowserConfig, "BrowserConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Timers))
            {
                request.TimersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Timers, "Timers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Users))
            {
                request.UsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Users, "Users", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPackageType))
            {
                body["AppPackageType"] = request.AppPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthNotificationEnabled))
            {
                body["AuthNotificationEnabled"] = request.AuthNotificationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserConfigShrink))
            {
                body["BrowserConfig"] = request.BrowserConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeResourceMode))
            {
                body["ChargeResourceMode"] = request.ChargeResourceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudBrowserName))
            {
                body["CloudBrowserName"] = request.CloudBrowserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAmount))
            {
                body["MaxAmount"] = request.MaxAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPayType))
            {
                body["SubPayType"] = request.SubPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimersShrink))
            {
                body["Timers"] = request.TimersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                body["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsersShrink))
            {
                body["Users"] = request.UsersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBrowserInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBrowserInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud browser group that is billed by monthly active users (MAU).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Prepare an available office network, image, and instance type in the target business region. Make sure that the account has the required browser configurations and resource quotas.</description></item>
        /// <item><description>Specify <c>CloudBrowserName</c> and <c>BizRegionId</c>. Set <c>OsType</c> to <c>Windows</c>.</description></item>
        /// <item><description>Authorized users must be created in advance and must match the account type. Authorized user groups must belong to the current account and match the account type of the office network.</description></item>
        /// <item><description><b><c>Users</c> and <c>UserGroupIds</c> cannot both be non-empty.</b></description></item>
        /// </list>
        /// <h2>MAU billing parameters</h2>
        /// <list type="bullet">
        /// <item><description>Set <c>ChargeType</c> to <c>PostPaid</c>.</description></item>
        /// <item><description><b>Set <c>SubPayType</c> to <c>mau</c> explicitly. Omitting this field does not enable MAU billing.</b></description></item>
        /// <item><description>Set <c>ChargeResourceMode</c> to <c>AppInstance</c>.</description></item>
        /// <item><description>Do not specify <c>Period</c>, <c>PeriodUnit</c>, <c>AppPackageType</c>, <c>AutoPay</c>, <c>AutoRenew</c>, or <c>NodePool</c>.</description></item>
        /// </list>
        /// <h2>Post-call processing</h2>
        /// <para><b>A successful response does not indicate that the browser resources are ready.</b> After creation, query the browser group status and confirm that the group is connectable before use.
        /// This operation creates a new cloud browser group. You do not need to create a delivery group in advance.</para>
        /// <h2>Example description</h2>
        /// <para>The example values of fields are provided to demonstrate how to specify the fields. Replace resource identifiers with actual values under your account. Capacity examples do not represent default values or upper limits.
        /// An example value of <c>-</c> indicates that the field does not need to be specified. Omit the corresponding parameter when you call the operation. Do not pass the character <c>-</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateBrowserInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBrowserInstanceGroupResponse
        /// </returns>
        public async Task<CreateBrowserInstanceGroupResponse> CreateBrowserInstanceGroupWithOptionsAsync(CreateBrowserInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBrowserInstanceGroupShrinkRequest request = new CreateBrowserInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BrowserConfig))
            {
                request.BrowserConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BrowserConfig, "BrowserConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Timers))
            {
                request.TimersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Timers, "Timers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Users))
            {
                request.UsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Users, "Users", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPackageType))
            {
                body["AppPackageType"] = request.AppPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthNotificationEnabled))
            {
                body["AuthNotificationEnabled"] = request.AuthNotificationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserConfigShrink))
            {
                body["BrowserConfig"] = request.BrowserConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeResourceMode))
            {
                body["ChargeResourceMode"] = request.ChargeResourceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudBrowserName))
            {
                body["CloudBrowserName"] = request.CloudBrowserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAmount))
            {
                body["MaxAmount"] = request.MaxAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPayType))
            {
                body["SubPayType"] = request.SubPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimersShrink))
            {
                body["Timers"] = request.TimersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                body["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsersShrink))
            {
                body["Users"] = request.UsersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBrowserInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBrowserInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud browser group that is billed by monthly active users (MAU).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Prepare an available office network, image, and instance type in the target business region. Make sure that the account has the required browser configurations and resource quotas.</description></item>
        /// <item><description>Specify <c>CloudBrowserName</c> and <c>BizRegionId</c>. Set <c>OsType</c> to <c>Windows</c>.</description></item>
        /// <item><description>Authorized users must be created in advance and must match the account type. Authorized user groups must belong to the current account and match the account type of the office network.</description></item>
        /// <item><description><b><c>Users</c> and <c>UserGroupIds</c> cannot both be non-empty.</b></description></item>
        /// </list>
        /// <h2>MAU billing parameters</h2>
        /// <list type="bullet">
        /// <item><description>Set <c>ChargeType</c> to <c>PostPaid</c>.</description></item>
        /// <item><description><b>Set <c>SubPayType</c> to <c>mau</c> explicitly. Omitting this field does not enable MAU billing.</b></description></item>
        /// <item><description>Set <c>ChargeResourceMode</c> to <c>AppInstance</c>.</description></item>
        /// <item><description>Do not specify <c>Period</c>, <c>PeriodUnit</c>, <c>AppPackageType</c>, <c>AutoPay</c>, <c>AutoRenew</c>, or <c>NodePool</c>.</description></item>
        /// </list>
        /// <h2>Post-call processing</h2>
        /// <para><b>A successful response does not indicate that the browser resources are ready.</b> After creation, query the browser group status and confirm that the group is connectable before use.
        /// This operation creates a new cloud browser group. You do not need to create a delivery group in advance.</para>
        /// <h2>Example description</h2>
        /// <para>The example values of fields are provided to demonstrate how to specify the fields. Replace resource identifiers with actual values under your account. Capacity examples do not represent default values or upper limits.
        /// An example value of <c>-</c> indicates that the field does not need to be specified. Omit the corresponding parameter when you call the operation. Do not pass the character <c>-</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBrowserInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBrowserInstanceGroupResponse
        /// </returns>
        public CreateBrowserInstanceGroupResponse CreateBrowserInstanceGroup(CreateBrowserInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBrowserInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud browser group that is billed by monthly active users (MAU).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Prepare an available office network, image, and instance type in the target business region. Make sure that the account has the required browser configurations and resource quotas.</description></item>
        /// <item><description>Specify <c>CloudBrowserName</c> and <c>BizRegionId</c>. Set <c>OsType</c> to <c>Windows</c>.</description></item>
        /// <item><description>Authorized users must be created in advance and must match the account type. Authorized user groups must belong to the current account and match the account type of the office network.</description></item>
        /// <item><description><b><c>Users</c> and <c>UserGroupIds</c> cannot both be non-empty.</b></description></item>
        /// </list>
        /// <h2>MAU billing parameters</h2>
        /// <list type="bullet">
        /// <item><description>Set <c>ChargeType</c> to <c>PostPaid</c>.</description></item>
        /// <item><description><b>Set <c>SubPayType</c> to <c>mau</c> explicitly. Omitting this field does not enable MAU billing.</b></description></item>
        /// <item><description>Set <c>ChargeResourceMode</c> to <c>AppInstance</c>.</description></item>
        /// <item><description>Do not specify <c>Period</c>, <c>PeriodUnit</c>, <c>AppPackageType</c>, <c>AutoPay</c>, <c>AutoRenew</c>, or <c>NodePool</c>.</description></item>
        /// </list>
        /// <h2>Post-call processing</h2>
        /// <para><b>A successful response does not indicate that the browser resources are ready.</b> After creation, query the browser group status and confirm that the group is connectable before use.
        /// This operation creates a new cloud browser group. You do not need to create a delivery group in advance.</para>
        /// <h2>Example description</h2>
        /// <para>The example values of fields are provided to demonstrate how to specify the fields. Replace resource identifiers with actual values under your account. Capacity examples do not represent default values or upper limits.
        /// An example value of <c>-</c> indicates that the field does not need to be specified. Omit the corresponding parameter when you call the operation. Do not pass the character <c>-</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBrowserInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBrowserInstanceGroupResponse
        /// </returns>
        public async Task<CreateBrowserInstanceGroupResponse> CreateBrowserInstanceGroupAsync(CreateBrowserInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBrowserInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image from a deployed WUYING instance. You can use the custom image to quickly create more WUYING instances with the same configurations, without having to repeatedly configure the instance environment each time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageByInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageByInstanceResponse
        /// </returns>
        public CreateImageByInstanceResponse CreateImageByInstanceWithOptions(CreateImageByInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCleanUserdata))
            {
                body["AutoCleanUserdata"] = request.AutoCleanUserdata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopyProfile))
            {
                body["CopyProfile"] = request.CopyProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                body["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstanceId))
            {
                body["SubInstanceId"] = request.SubInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageByInstance",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageByInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image from a deployed WUYING instance. You can use the custom image to quickly create more WUYING instances with the same configurations, without having to repeatedly configure the instance environment each time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageByInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageByInstanceResponse
        /// </returns>
        public async Task<CreateImageByInstanceResponse> CreateImageByInstanceWithOptionsAsync(CreateImageByInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCleanUserdata))
            {
                body["AutoCleanUserdata"] = request.AutoCleanUserdata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopyProfile))
            {
                body["CopyProfile"] = request.CopyProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                body["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstanceId))
            {
                body["SubInstanceId"] = request.SubInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageByInstance",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageByInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image from a deployed WUYING instance. You can use the custom image to quickly create more WUYING instances with the same configurations, without having to repeatedly configure the instance environment each time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageByInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageByInstanceResponse
        /// </returns>
        public CreateImageByInstanceResponse CreateImageByInstance(CreateImageByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageByInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image from a deployed WUYING instance. You can use the custom image to quickly create more WUYING instances with the same configurations, without having to repeatedly configure the instance environment each time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageByInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageByInstanceResponse
        /// </returns>
        public async Task<CreateImageByInstanceResponse> CreateImageByInstanceAsync(CreateImageByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageByInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new image from a debug delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageFromAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageFromAppInstanceGroupResponse
        /// </returns>
        public CreateImageFromAppInstanceGroupResponse CreateImageFromAppInstanceGroupWithOptions(CreateImageFromAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageName))
            {
                body["AppCenterImageName"] = request.AppCenterImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageFromAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageFromAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new image from a debug delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageFromAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageFromAppInstanceGroupResponse
        /// </returns>
        public async Task<CreateImageFromAppInstanceGroupResponse> CreateImageFromAppInstanceGroupWithOptionsAsync(CreateImageFromAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageName))
            {
                body["AppCenterImageName"] = request.AppCenterImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageFromAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageFromAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new image from a debug delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageFromAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageFromAppInstanceGroupResponse
        /// </returns>
        public CreateImageFromAppInstanceGroupResponse CreateImageFromAppInstanceGroup(CreateImageFromAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageFromAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new image from a debug delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageFromAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageFromAppInstanceGroupResponse
        /// </returns>
        public async Task<CreateImageFromAppInstanceGroupResponse> CreateImageFromAppInstanceGroupAsync(CreateImageFromAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageFromAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model provider template for model creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model provider template under Model Templates in the WUYING Agent Management Center. This template is used to configure connection information and keys for model services (such as Alibaba Cloud Bailian, Token Plan, and Moonshot) that an Agent can invoke. After model creation, the model provider template is automatically associated with the specified model template.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before you invoke this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProviderTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProviderTemplateResponse
        /// </returns>
        public CreateModelProviderTemplateResponse CreateModelProviderTemplateWithOptions(CreateModelProviderTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWuyingProxy))
            {
                query["EnableWuyingProxy"] = request.EnableWuyingProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                query["ProviderName"] = request.ProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderType))
            {
                query["ProviderType"] = request.ProviderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelProviderTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelProviderTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model provider template for model creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model provider template under Model Templates in the WUYING Agent Management Center. This template is used to configure connection information and keys for model services (such as Alibaba Cloud Bailian, Token Plan, and Moonshot) that an Agent can invoke. After model creation, the model provider template is automatically associated with the specified model template.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before you invoke this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProviderTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProviderTemplateResponse
        /// </returns>
        public async Task<CreateModelProviderTemplateResponse> CreateModelProviderTemplateWithOptionsAsync(CreateModelProviderTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWuyingProxy))
            {
                query["EnableWuyingProxy"] = request.EnableWuyingProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                query["ProviderName"] = request.ProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderType))
            {
                query["ProviderType"] = request.ProviderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelProviderTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelProviderTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model provider template for model creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model provider template under Model Templates in the WUYING Agent Management Center. This template is used to configure connection information and keys for model services (such as Alibaba Cloud Bailian, Token Plan, and Moonshot) that an Agent can invoke. After model creation, the model provider template is automatically associated with the specified model template.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before you invoke this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProviderTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProviderTemplateResponse
        /// </returns>
        public CreateModelProviderTemplateResponse CreateModelProviderTemplate(CreateModelProviderTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateModelProviderTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model provider template for model creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model provider template under Model Templates in the WUYING Agent Management Center. This template is used to configure connection information and keys for model services (such as Alibaba Cloud Bailian, Token Plan, and Moonshot) that an Agent can invoke. After model creation, the model provider template is automatically associated with the specified model template.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before you invoke this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProviderTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProviderTemplateResponse
        /// </returns>
        public async Task<CreateModelProviderTemplateResponse> CreateModelProviderTemplateAsync(CreateModelProviderTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateModelProviderTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model group in the Wuying Agent Management Center to manage the model providers and model scope that an Agent can invoke. After model creation, you can attach the model group to a cloud computer as the inference engine configuration for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before invoking this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelTemplateResponse
        /// </returns>
        public CreateModelTemplateResponse CreateModelTemplateWithOptions(CreateModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefScope))
            {
                query["RefScope"] = request.RefScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model group in the Wuying Agent Management Center to manage the model providers and model scope that an Agent can invoke. After model creation, you can attach the model group to a cloud computer as the inference engine configuration for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before invoking this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelTemplateResponse
        /// </returns>
        public async Task<CreateModelTemplateResponse> CreateModelTemplateWithOptionsAsync(CreateModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefScope))
            {
                query["RefScope"] = request.RefScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model group in the Wuying Agent Management Center to manage the model providers and model scope that an Agent can invoke. After model creation, you can attach the model group to a cloud computer as the inference engine configuration for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before invoking this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelTemplateResponse
        /// </returns>
        public CreateModelTemplateResponse CreateModelTemplate(CreateModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateModelTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model group in the Wuying Agent Management Center to manage the model providers and model scope that an Agent can invoke. After model creation, you can attach the model group to a cloud computer as the inference engine configuration for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before invoking this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelTemplateResponse
        /// </returns>
        public async Task<CreateModelTemplateResponse> CreateModelTemplateAsync(CreateModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateModelTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates one or more workstations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A project corresponds to the resource configuration module in the CloudFlow console.</description></item>
        /// <item><description>When the ContentId input parameter has multiple versions, this API <notice>uses the default version</notice> and bindss it at the same time.</description></item>
        /// <item><description>This operation succeeds only when the default version of the Content is in an available state.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWuyingServerResponse
        /// </returns>
        public CreateWuyingServerResponse CreateWuyingServerWithOptions(CreateWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisk))
            {
                bodyFlat["DataDisk"] = request.DataDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErdmaEnabled))
            {
                body["ErdmaEnabled"] = request.ErdmaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuDriverVersion))
            {
                body["GpuDriverVersion"] = request.GpuDriverVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                body["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotenceToken))
            {
                body["IdempotenceToken"] = request.IdempotenceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPrice))
            {
                body["MaxPrice"] = request.MaxPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkStrategyType))
            {
                body["NetworkStrategyType"] = request.NetworkStrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                body["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SavingPlanId))
            {
                body["SavingPlanId"] = request.SavingPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerInstanceType))
            {
                body["ServerInstanceType"] = request.ServerInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerPortRange))
            {
                body["ServerPortRange"] = request.ServerPortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPayType))
            {
                body["SubPayType"] = request.SubPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskCategory))
            {
                body["SystemDiskCategory"] = request.SystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskPerformanceLevel))
            {
                body["SystemDiskPerformanceLevel"] = request.SystemDiskPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskSize))
            {
                body["SystemDiskSize"] = request.SystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                body["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodePoolId))
            {
                body["VirtualNodePoolId"] = request.VirtualNodePoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerName))
            {
                body["WuyingServerName"] = request.WuyingServerName;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWuyingServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates one or more workstations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A project corresponds to the resource configuration module in the CloudFlow console.</description></item>
        /// <item><description>When the ContentId input parameter has multiple versions, this API <notice>uses the default version</notice> and bindss it at the same time.</description></item>
        /// <item><description>This operation succeeds only when the default version of the Content is in an available state.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWuyingServerResponse
        /// </returns>
        public async Task<CreateWuyingServerResponse> CreateWuyingServerWithOptionsAsync(CreateWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisk))
            {
                bodyFlat["DataDisk"] = request.DataDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErdmaEnabled))
            {
                body["ErdmaEnabled"] = request.ErdmaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuDriverVersion))
            {
                body["GpuDriverVersion"] = request.GpuDriverVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                body["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotenceToken))
            {
                body["IdempotenceToken"] = request.IdempotenceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPrice))
            {
                body["MaxPrice"] = request.MaxPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkStrategyType))
            {
                body["NetworkStrategyType"] = request.NetworkStrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                body["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SavingPlanId))
            {
                body["SavingPlanId"] = request.SavingPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerInstanceType))
            {
                body["ServerInstanceType"] = request.ServerInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerPortRange))
            {
                body["ServerPortRange"] = request.ServerPortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPayType))
            {
                body["SubPayType"] = request.SubPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskCategory))
            {
                body["SystemDiskCategory"] = request.SystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskPerformanceLevel))
            {
                body["SystemDiskPerformanceLevel"] = request.SystemDiskPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskSize))
            {
                body["SystemDiskSize"] = request.SystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                body["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodePoolId))
            {
                body["VirtualNodePoolId"] = request.VirtualNodePoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerName))
            {
                body["WuyingServerName"] = request.WuyingServerName;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWuyingServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates one or more workstations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A project corresponds to the resource configuration module in the CloudFlow console.</description></item>
        /// <item><description>When the ContentId input parameter has multiple versions, this API <notice>uses the default version</notice> and bindss it at the same time.</description></item>
        /// <item><description>This operation succeeds only when the default version of the Content is in an available state.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWuyingServerResponse
        /// </returns>
        public CreateWuyingServerResponse CreateWuyingServer(CreateWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWuyingServerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates one or more workstations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A project corresponds to the resource configuration module in the CloudFlow console.</description></item>
        /// <item><description>When the ContentId input parameter has multiple versions, this API <notice>uses the default version</notice> and bindss it at the same time.</description></item>
        /// <item><description>This operation succeeds only when the default version of the Content is in an available state.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWuyingServerResponse
        /// </returns>
        public async Task<CreateWuyingServerResponse> CreateWuyingServerAsync(CreateWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWuyingServerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a pay-as-you-go delivery group of the resource-based type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation does not support deleting delivery groups that use subscription resources.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceGroupResponse
        /// </returns>
        public DeleteAppInstanceGroupResponse DeleteAppInstanceGroupWithOptions(DeleteAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a pay-as-you-go delivery group of the resource-based type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation does not support deleting delivery groups that use subscription resources.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceGroupResponse
        /// </returns>
        public async Task<DeleteAppInstanceGroupResponse> DeleteAppInstanceGroupWithOptionsAsync(DeleteAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a pay-as-you-go delivery group of the resource-based type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation does not support deleting delivery groups that use subscription resources.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceGroupResponse
        /// </returns>
        public DeleteAppInstanceGroupResponse DeleteAppInstanceGroup(DeleteAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a pay-as-you-go delivery group of the resource-based type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation does not support deleting delivery groups that use subscription resources.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceGroupResponse
        /// </returns>
        public async Task<DeleteAppInstanceGroupResponse> DeleteAppInstanceGroupAsync(DeleteAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only instances in the initializing or idle state can be deleted. This operation is available only to specific customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstancesResponse
        /// </returns>
        public DeleteAppInstancesResponse DeleteAppInstancesWithOptions(DeleteAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIds))
            {
                body["AppInstanceIds"] = request.AppInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only instances in the initializing or idle state can be deleted. This operation is available only to specific customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstancesResponse
        /// </returns>
        public async Task<DeleteAppInstancesResponse> DeleteAppInstancesWithOptionsAsync(DeleteAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIds))
            {
                body["AppInstanceIds"] = request.AppInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only instances in the initializing or idle state can be deleted. This operation is available only to specific customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstancesResponse
        /// </returns>
        public DeleteAppInstancesResponse DeleteAppInstances(DeleteAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only instances in the initializing or idle state can be deleted. This operation is available only to specific customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstancesResponse
        /// </returns>
        public async Task<DeleteAppInstancesResponse> DeleteAppInstancesAsync(DeleteAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom WUYING image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete only custom images that belong to your account.</description></item>
        /// <item><description>For images associated with WUYING Cloud Computer Pool, WUYING Cloud Application, or WUYING Workspace product lines, ensure that no WUYING instances are using the image before you delete it.</description></item>
        /// <item><description>If a WUYING Cloud Desktop template references an image, the template is also deleted when the image is deleted.</description></item>
        /// <item><description>For images that span multiple regions, deleting the image removes the image from all regions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageResponse
        /// </returns>
        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom WUYING image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete only custom images that belong to your account.</description></item>
        /// <item><description>For images associated with WUYING Cloud Computer Pool, WUYING Cloud Application, or WUYING Workspace product lines, ensure that no WUYING instances are using the image before you delete it.</description></item>
        /// <item><description>If a WUYING Cloud Desktop template references an image, the template is also deleted when the image is deleted.</description></item>
        /// <item><description>For images that span multiple regions, deleting the image removes the image from all regions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageResponse
        /// </returns>
        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom WUYING image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete only custom images that belong to your account.</description></item>
        /// <item><description>For images associated with WUYING Cloud Computer Pool, WUYING Cloud Application, or WUYING Workspace product lines, ensure that no WUYING instances are using the image before you delete it.</description></item>
        /// <item><description>If a WUYING Cloud Desktop template references an image, the template is also deleted when the image is deleted.</description></item>
        /// <item><description>For images that span multiple regions, deleting the image removes the image from all regions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageResponse
        /// </returns>
        public DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom WUYING image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete only custom images that belong to your account.</description></item>
        /// <item><description>For images associated with WUYING Cloud Computer Pool, WUYING Cloud Application, or WUYING Workspace product lines, ensure that no WUYING instances are using the image before you delete it.</description></item>
        /// <item><description>If a WUYING Cloud Desktop template references an image, the template is also deleted when the image is deleted.</description></item>
        /// <item><description>For images that span multiple regions, deleting the image removes the image from all regions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageResponse
        /// </returns>
        public async Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an LLM template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model template that has been created under a model service provider template in the WUYING Agent Management Center. Before deletion, ensure that the model is not the default model of an associated model group. Otherwise, the deletion fails. After deletion, the model configurations of associated cloud computers are automatically refreshed.
        /// Before using this operation, make sure you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLlmTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLlmTemplateResponse
        /// </returns>
        public DeleteLlmTemplateResponse DeleteLlmTemplateWithOptions(DeleteLlmTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmTemplateId))
            {
                query["LlmTemplateId"] = request.LlmTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLlmTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLlmTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an LLM template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model template that has been created under a model service provider template in the WUYING Agent Management Center. Before deletion, ensure that the model is not the default model of an associated model group. Otherwise, the deletion fails. After deletion, the model configurations of associated cloud computers are automatically refreshed.
        /// Before using this operation, make sure you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLlmTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLlmTemplateResponse
        /// </returns>
        public async Task<DeleteLlmTemplateResponse> DeleteLlmTemplateWithOptionsAsync(DeleteLlmTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmTemplateId))
            {
                query["LlmTemplateId"] = request.LlmTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLlmTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLlmTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an LLM template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model template that has been created under a model service provider template in the WUYING Agent Management Center. Before deletion, ensure that the model is not the default model of an associated model group. Otherwise, the deletion fails. After deletion, the model configurations of associated cloud computers are automatically refreshed.
        /// Before using this operation, make sure you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLlmTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLlmTemplateResponse
        /// </returns>
        public DeleteLlmTemplateResponse DeleteLlmTemplate(DeleteLlmTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLlmTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an LLM template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model template that has been created under a model service provider template in the WUYING Agent Management Center. Before deletion, ensure that the model is not the default model of an associated model group. Otherwise, the deletion fails. After deletion, the model configurations of associated cloud computers are automatically refreshed.
        /// Before using this operation, make sure you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLlmTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLlmTemplateResponse
        /// </returns>
        public async Task<DeleteLlmTemplateResponse> DeleteLlmTemplateAsync(DeleteLlmTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLlmTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model provider template that has been created under model templates in the WUYING Agent Management Center. Before deletion, ensure that the model provider is not the provider of the default model and is not a system preset type provider (such as WUYING credit package). After deletion, the associated models and key configurations are also removed.
        /// Before using this operation, make sure you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelProviderTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProviderTemplateResponse
        /// </returns>
        public DeleteModelProviderTemplateResponse DeleteModelProviderTemplateWithOptions(DeleteModelProviderTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                query["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelProviderTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelProviderTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model provider template that has been created under model templates in the WUYING Agent Management Center. Before deletion, ensure that the model provider is not the provider of the default model and is not a system preset type provider (such as WUYING credit package). After deletion, the associated models and key configurations are also removed.
        /// Before using this operation, make sure you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelProviderTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProviderTemplateResponse
        /// </returns>
        public async Task<DeleteModelProviderTemplateResponse> DeleteModelProviderTemplateWithOptionsAsync(DeleteModelProviderTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                query["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelProviderTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelProviderTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model provider template that has been created under model templates in the WUYING Agent Management Center. Before deletion, ensure that the model provider is not the provider of the default model and is not a system preset type provider (such as WUYING credit package). After deletion, the associated models and key configurations are also removed.
        /// Before using this operation, make sure you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelProviderTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProviderTemplateResponse
        /// </returns>
        public DeleteModelProviderTemplateResponse DeleteModelProviderTemplate(DeleteModelProviderTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteModelProviderTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model provider template that has been created under model templates in the WUYING Agent Management Center. Before deletion, ensure that the model provider is not the provider of the default model and is not a system preset type provider (such as WUYING credit package). After deletion, the associated models and key configurations are also removed.
        /// Before using this operation, make sure you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelProviderTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProviderTemplateResponse
        /// </returns>
        public async Task<DeleteModelProviderTemplateResponse> DeleteModelProviderTemplateAsync(DeleteModelProviderTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteModelProviderTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model group that has been created in the WUYING Agent Management Center. Before deletion, ensure that the template has not been authorized to any resource. Otherwise, the deletion fails. After deletion, the model providers and models under the model group are also removed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelTemplateResponse
        /// </returns>
        public DeleteModelTemplateResponse DeleteModelTemplateWithOptions(DeleteModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model group that has been created in the WUYING Agent Management Center. Before deletion, ensure that the template has not been authorized to any resource. Otherwise, the deletion fails. After deletion, the model providers and models under the model group are also removed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelTemplateResponse
        /// </returns>
        public async Task<DeleteModelTemplateResponse> DeleteModelTemplateWithOptionsAsync(DeleteModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model group that has been created in the WUYING Agent Management Center. Before deletion, ensure that the template has not been authorized to any resource. Otherwise, the deletion fails. After deletion, the model providers and models under the model group are also removed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelTemplateResponse
        /// </returns>
        public DeleteModelTemplateResponse DeleteModelTemplate(DeleteModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteModelTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a model group that has been created in the WUYING Agent Management Center. Before deletion, ensure that the template has not been authorized to any resource. Otherwise, the deletion fails. After deletion, the model providers and models under the model group are also removed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelTemplateResponse
        /// </returns>
        public async Task<DeleteModelTemplateResponse> DeleteModelTemplateAsync(DeleteModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteModelTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cloud graphics workstation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a cloud graphics workstation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWuyingServerResponse
        /// </returns>
        public DeleteWuyingServerResponse DeleteWuyingServerWithOptions(DeleteWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWuyingServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cloud graphics workstation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a cloud graphics workstation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWuyingServerResponse
        /// </returns>
        public async Task<DeleteWuyingServerResponse> DeleteWuyingServerWithOptionsAsync(DeleteWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWuyingServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cloud graphics workstation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a cloud graphics workstation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWuyingServerResponse
        /// </returns>
        public DeleteWuyingServerResponse DeleteWuyingServer(DeleteWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWuyingServerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cloud graphics workstation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a cloud graphics workstation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWuyingServerResponse
        /// </returns>
        public async Task<DeleteWuyingServerResponse> DeleteWuyingServerAsync(DeleteWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWuyingServerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures SLS log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverToUserSlsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliverToUserSlsResponse
        /// </returns>
        public DeliverToUserSlsResponse DeliverToUserSlsWithOptions(DeliverToUserSlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryScopes))
            {
                bodyFlat["DeliveryScopes"] = request.DeliveryScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistedProjectName))
            {
                body["ExistedProjectName"] = request.ExistedProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsRegionId))
            {
                body["SlsRegionId"] = request.SlsRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeliverToUserSls",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverToUserSlsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures SLS log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverToUserSlsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliverToUserSlsResponse
        /// </returns>
        public async Task<DeliverToUserSlsResponse> DeliverToUserSlsWithOptionsAsync(DeliverToUserSlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryScopes))
            {
                bodyFlat["DeliveryScopes"] = request.DeliveryScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistedProjectName))
            {
                body["ExistedProjectName"] = request.ExistedProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsRegionId))
            {
                body["SlsRegionId"] = request.SlsRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeliverToUserSls",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverToUserSlsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures SLS log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverToUserSlsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliverToUserSlsResponse
        /// </returns>
        public DeliverToUserSlsResponse DeliverToUserSls(DeliverToUserSlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeliverToUserSlsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures SLS log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverToUserSlsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliverToUserSlsResponse
        /// </returns>
        public async Task<DeliverToUserSlsResponse> DeliverToUserSlsAsync(DeliverToUserSlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeliverToUserSlsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWuyingServerResponse
        /// </returns>
        public DescribeWuyingServerResponse DescribeWuyingServerWithOptions(DescribeWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWuyingServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWuyingServerResponse
        /// </returns>
        public async Task<DescribeWuyingServerResponse> DescribeWuyingServerWithOptionsAsync(DescribeWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWuyingServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWuyingServerResponse
        /// </returns>
        public DescribeWuyingServerResponse DescribeWuyingServer(DescribeWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWuyingServerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWuyingServerResponse
        /// </returns>
        public async Task<DescribeWuyingServerResponse> DescribeWuyingServerAsync(DescribeWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWuyingServerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Elastic IP Address (EIP) information of a Wuying workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWuyingServerEipInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWuyingServerEipInfoResponse
        /// </returns>
        public DescribeWuyingServerEipInfoResponse DescribeWuyingServerEipInfoWithOptions(DescribeWuyingServerEipInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                body["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWuyingServerEipInfo",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWuyingServerEipInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Elastic IP Address (EIP) information of a Wuying workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWuyingServerEipInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWuyingServerEipInfoResponse
        /// </returns>
        public async Task<DescribeWuyingServerEipInfoResponse> DescribeWuyingServerEipInfoWithOptionsAsync(DescribeWuyingServerEipInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                body["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWuyingServerEipInfo",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWuyingServerEipInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Elastic IP Address (EIP) information of a Wuying workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWuyingServerEipInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWuyingServerEipInfoResponse
        /// </returns>
        public DescribeWuyingServerEipInfoResponse DescribeWuyingServerEipInfo(DescribeWuyingServerEipInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWuyingServerEipInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Elastic IP Address (EIP) information of a Wuying workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWuyingServerEipInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWuyingServerEipInfoResponse
        /// </returns>
        public async Task<DescribeWuyingServerEipInfoResponse> DescribeWuyingServerEipInfoAsync(DescribeWuyingServerEipInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWuyingServerEipInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppInstanceGroupResponse
        /// </returns>
        public GetAppInstanceGroupResponse GetAppInstanceGroupWithOptions(GetAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppInstanceGroupResponse
        /// </returns>
        public async Task<GetAppInstanceGroupResponse> GetAppInstanceGroupWithOptionsAsync(GetAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppInstanceGroupResponse
        /// </returns>
        public GetAppInstanceGroupResponse GetAppInstanceGroup(GetAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppInstanceGroupResponse
        /// </returns>
        public async Task<GetAppInstanceGroupResponse> GetAppInstanceGroupAsync(GetAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration, status, and authorization statistics of a specified cloud browser group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes the query usage for the monthly active user (MAU) billing scenario.</para>
        /// <h2>Before you begin</h2>
        /// <para>Obtain the cloud browser group ID under the current account. Call <c>ListBrowserInstanceGroup</c> to retrieve the ID.</para>
        /// <h2>Response</h2>
        /// <para>The response includes the current configuration, status, and authorization statistics of the browser group. The details return up to 20 bookmarks and 20 website access entries. To retrieve the complete lists, call <c>ListBrowserBookmarks</c> and <c>ListBrowserRestrictedURLs</c>.</para>
        /// <h2>What to do next</h2>
        /// <para>This operation only queries configurations and does not modify resources. After you read the returned status, perform the connection or management operation that corresponds to the status.</para>
        /// <h2>Example description</h2>
        /// <para>The <c>-</c> value in the examples indicates that the field is not applicable or not returned in the current scenario. It is not an actual string returned by the operation. Sample resource IDs are masked. Use the actual query results when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBrowserInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBrowserInstanceGroupResponse
        /// </returns>
        public GetBrowserInstanceGroupResponse GetBrowserInstanceGroupWithOptions(GetBrowserInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBrowserInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBrowserInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration, status, and authorization statistics of a specified cloud browser group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes the query usage for the monthly active user (MAU) billing scenario.</para>
        /// <h2>Before you begin</h2>
        /// <para>Obtain the cloud browser group ID under the current account. Call <c>ListBrowserInstanceGroup</c> to retrieve the ID.</para>
        /// <h2>Response</h2>
        /// <para>The response includes the current configuration, status, and authorization statistics of the browser group. The details return up to 20 bookmarks and 20 website access entries. To retrieve the complete lists, call <c>ListBrowserBookmarks</c> and <c>ListBrowserRestrictedURLs</c>.</para>
        /// <h2>What to do next</h2>
        /// <para>This operation only queries configurations and does not modify resources. After you read the returned status, perform the connection or management operation that corresponds to the status.</para>
        /// <h2>Example description</h2>
        /// <para>The <c>-</c> value in the examples indicates that the field is not applicable or not returned in the current scenario. It is not an actual string returned by the operation. Sample resource IDs are masked. Use the actual query results when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBrowserInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBrowserInstanceGroupResponse
        /// </returns>
        public async Task<GetBrowserInstanceGroupResponse> GetBrowserInstanceGroupWithOptionsAsync(GetBrowserInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBrowserInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBrowserInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration, status, and authorization statistics of a specified cloud browser group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes the query usage for the monthly active user (MAU) billing scenario.</para>
        /// <h2>Before you begin</h2>
        /// <para>Obtain the cloud browser group ID under the current account. Call <c>ListBrowserInstanceGroup</c> to retrieve the ID.</para>
        /// <h2>Response</h2>
        /// <para>The response includes the current configuration, status, and authorization statistics of the browser group. The details return up to 20 bookmarks and 20 website access entries. To retrieve the complete lists, call <c>ListBrowserBookmarks</c> and <c>ListBrowserRestrictedURLs</c>.</para>
        /// <h2>What to do next</h2>
        /// <para>This operation only queries configurations and does not modify resources. After you read the returned status, perform the connection or management operation that corresponds to the status.</para>
        /// <h2>Example description</h2>
        /// <para>The <c>-</c> value in the examples indicates that the field is not applicable or not returned in the current scenario. It is not an actual string returned by the operation. Sample resource IDs are masked. Use the actual query results when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBrowserInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBrowserInstanceGroupResponse
        /// </returns>
        public GetBrowserInstanceGroupResponse GetBrowserInstanceGroup(GetBrowserInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBrowserInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration, status, and authorization statistics of a specified cloud browser group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes the query usage for the monthly active user (MAU) billing scenario.</para>
        /// <h2>Before you begin</h2>
        /// <para>Obtain the cloud browser group ID under the current account. Call <c>ListBrowserInstanceGroup</c> to retrieve the ID.</para>
        /// <h2>Response</h2>
        /// <para>The response includes the current configuration, status, and authorization statistics of the browser group. The details return up to 20 bookmarks and 20 website access entries. To retrieve the complete lists, call <c>ListBrowserBookmarks</c> and <c>ListBrowserRestrictedURLs</c>.</para>
        /// <h2>What to do next</h2>
        /// <para>This operation only queries configurations and does not modify resources. After you read the returned status, perform the connection or management operation that corresponds to the status.</para>
        /// <h2>Example description</h2>
        /// <para>The <c>-</c> value in the examples indicates that the field is not applicable or not returned in the current scenario. It is not an actual string returned by the operation. Sample resource IDs are masked. Use the actual query results when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBrowserInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBrowserInstanceGroupResponse
        /// </returns>
        public async Task<GetBrowserInstanceGroupResponse> GetBrowserInstanceGroupAsync(GetBrowserInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBrowserInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the connection credential for a cloud application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call protocol description: operation_type: polling, required_steps: 1.
        /// This operation may require multiple calls (at least one) to obtain the connection credential.
        /// On the first call, an application instance is allocated to the specified convenience account and the application is started. If a Ticket is returned, the result is obtained synchronously. If a startup task ID (<c>TaskId</c>) is returned, subsequent calls are required.
        /// On subsequent calls, include the <c>TaskId</c> request parameter to invoke the operation and query whether the node is complete. When the returned node status (<c>TaskStatus</c>) is completed (<c>Finished</c>), the connection credential (<c>Ticket</c>) is also returned.</para>
        /// <remarks>
        /// <para>Prerequisites</para>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, make sure that you have created a delivery group and authorized users for the delivery group:</description></item>
        /// <item><description><ol>
        /// <item><description>The API for creating a delivery group is CreateAppInstanceGroup. For more information about the parameters, see the corresponding API documentation.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="2">
        /// <item><description>You can call the ListAppInstanceGroup operation to query the list of delivery groups. If the corresponding delivery group is not found, verify that the delivery group has been created and that the authentication credentials belong to the correct tenant.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="3">
        /// <item><description>The API for authorizing users for a delivery group is AuthorizeInstanceGroup. For more information about the parameters, see the corresponding API documentation.</description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// </remarks>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupIdList))
            {
                body["AppInstanceGroupIdList"] = request.AppInstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                body["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                body["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStartParam))
            {
                body["AppStartParam"] = request.AppStartParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentConfig))
            {
                body["EnvironmentConfig"] = request.EnvironmentConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionTicket",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the connection credential for a cloud application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call protocol description: operation_type: polling, required_steps: 1.
        /// This operation may require multiple calls (at least one) to obtain the connection credential.
        /// On the first call, an application instance is allocated to the specified convenience account and the application is started. If a Ticket is returned, the result is obtained synchronously. If a startup task ID (<c>TaskId</c>) is returned, subsequent calls are required.
        /// On subsequent calls, include the <c>TaskId</c> request parameter to invoke the operation and query whether the node is complete. When the returned node status (<c>TaskStatus</c>) is completed (<c>Finished</c>), the connection credential (<c>Ticket</c>) is also returned.</para>
        /// <remarks>
        /// <para>Prerequisites</para>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, make sure that you have created a delivery group and authorized users for the delivery group:</description></item>
        /// <item><description><ol>
        /// <item><description>The API for creating a delivery group is CreateAppInstanceGroup. For more information about the parameters, see the corresponding API documentation.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="2">
        /// <item><description>You can call the ListAppInstanceGroup operation to query the list of delivery groups. If the corresponding delivery group is not found, verify that the delivery group has been created and that the authentication credentials belong to the correct tenant.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="3">
        /// <item><description>The API for authorizing users for a delivery group is AuthorizeInstanceGroup. For more information about the parameters, see the corresponding API documentation.</description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// </remarks>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupIdList))
            {
                body["AppInstanceGroupIdList"] = request.AppInstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                body["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                body["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStartParam))
            {
                body["AppStartParam"] = request.AppStartParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentConfig))
            {
                body["EnvironmentConfig"] = request.EnvironmentConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionTicket",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the connection credential for a cloud application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call protocol description: operation_type: polling, required_steps: 1.
        /// This operation may require multiple calls (at least one) to obtain the connection credential.
        /// On the first call, an application instance is allocated to the specified convenience account and the application is started. If a Ticket is returned, the result is obtained synchronously. If a startup task ID (<c>TaskId</c>) is returned, subsequent calls are required.
        /// On subsequent calls, include the <c>TaskId</c> request parameter to invoke the operation and query whether the node is complete. When the returned node status (<c>TaskStatus</c>) is completed (<c>Finished</c>), the connection credential (<c>Ticket</c>) is also returned.</para>
        /// <remarks>
        /// <para>Prerequisites</para>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, make sure that you have created a delivery group and authorized users for the delivery group:</description></item>
        /// <item><description><ol>
        /// <item><description>The API for creating a delivery group is CreateAppInstanceGroup. For more information about the parameters, see the corresponding API documentation.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="2">
        /// <item><description>You can call the ListAppInstanceGroup operation to query the list of delivery groups. If the corresponding delivery group is not found, verify that the delivery group has been created and that the authentication credentials belong to the correct tenant.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="3">
        /// <item><description>The API for authorizing users for a delivery group is AuthorizeInstanceGroup. For more information about the parameters, see the corresponding API documentation.</description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// </remarks>
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
        /// <para>Retrieves the connection credential for a cloud application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call protocol description: operation_type: polling, required_steps: 1.
        /// This operation may require multiple calls (at least one) to obtain the connection credential.
        /// On the first call, an application instance is allocated to the specified convenience account and the application is started. If a Ticket is returned, the result is obtained synchronously. If a startup task ID (<c>TaskId</c>) is returned, subsequent calls are required.
        /// On subsequent calls, include the <c>TaskId</c> request parameter to invoke the operation and query whether the node is complete. When the returned node status (<c>TaskStatus</c>) is completed (<c>Finished</c>), the connection credential (<c>Ticket</c>) is also returned.</para>
        /// <remarks>
        /// <para>Prerequisites</para>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, make sure that you have created a delivery group and authorized users for the delivery group:</description></item>
        /// <item><description><ol>
        /// <item><description>The API for creating a delivery group is CreateAppInstanceGroup. For more information about the parameters, see the corresponding API documentation.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="2">
        /// <item><description>You can call the ListAppInstanceGroup operation to query the list of delivery groups. If the corresponding delivery group is not found, verify that the delivery group has been created and that the authentication credentials belong to the correct tenant.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="3">
        /// <item><description>The API for authorizing users for a delivery group is AuthorizeInstanceGroup. For more information about the parameters, see the corresponding API documentation.</description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// </remarks>
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
        /// <para>Retrieves the information about a debug application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDebugAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDebugAppInstanceResponse
        /// </returns>
        public GetDebugAppInstanceResponse GetDebugAppInstanceWithOptions(GetDebugAppInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDebugAppInstance",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDebugAppInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information about a debug application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDebugAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDebugAppInstanceResponse
        /// </returns>
        public async Task<GetDebugAppInstanceResponse> GetDebugAppInstanceWithOptionsAsync(GetDebugAppInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDebugAppInstance",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDebugAppInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information about a debug application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDebugAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDebugAppInstanceResponse
        /// </returns>
        public GetDebugAppInstanceResponse GetDebugAppInstance(GetDebugAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDebugAppInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information about a debug application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDebugAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDebugAppInstanceResponse
        /// </returns>
        public async Task<GetDebugAppInstanceResponse> GetDebugAppInstanceAsync(GetDebugAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDebugAppInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves file upload information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Visitor information is filled in on the lead capture page when visitors execute a cloud flow. Therefore, the usage mode of cloud applications does not generate visitor information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFileUploadInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadInfoResponse
        /// </returns>
        public GetFileUploadInfoResponse GetFileUploadInfoWithOptions(GetFileUploadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileUploadInfo",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves file upload information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Visitor information is filled in on the lead capture page when visitors execute a cloud flow. Therefore, the usage mode of cloud applications does not generate visitor information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFileUploadInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadInfoResponse
        /// </returns>
        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoWithOptionsAsync(GetFileUploadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileUploadInfo",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves file upload information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Visitor information is filled in on the lead capture page when visitors execute a cloud flow. Therefore, the usage mode of cloud applications does not generate visitor information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFileUploadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadInfoResponse
        /// </returns>
        public GetFileUploadInfoResponse GetFileUploadInfo(GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileUploadInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves file upload information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Visitor information is filled in on the lead capture page when visitors execute a cloud flow. Therefore, the usage mode of cloud applications does not generate visitor information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFileUploadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadInfoResponse
        /// </returns>
        public async Task<GetFileUploadInfoResponse> GetFileUploadInfoAsync(GetFileUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileUploadInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of a specified model provider template in the WUYING Agent Management Center, including the provider name, description, and connection configuration list.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelProviderTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelProviderTemplateResponse
        /// </returns>
        public GetModelProviderTemplateResponse GetModelProviderTemplateWithOptions(GetModelProviderTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                query["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelProviderTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelProviderTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of a specified model provider template in the WUYING Agent Management Center, including the provider name, description, and connection configuration list.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelProviderTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelProviderTemplateResponse
        /// </returns>
        public async Task<GetModelProviderTemplateResponse> GetModelProviderTemplateWithOptionsAsync(GetModelProviderTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                query["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelProviderTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelProviderTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of a specified model provider template in the WUYING Agent Management Center, including the provider name, description, and connection configuration list.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelProviderTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelProviderTemplateResponse
        /// </returns>
        public GetModelProviderTemplateResponse GetModelProviderTemplate(GetModelProviderTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelProviderTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of a specified model provider template in the WUYING Agent Management Center, including the provider name, description, and connection configuration list.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelProviderTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelProviderTemplateResponse
        /// </returns>
        public async Task<GetModelProviderTemplateResponse> GetModelProviderTemplateAsync(GetModelProviderTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelProviderTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an over-the-air update task, including the available version and release notes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOtaTaskByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOtaTaskByTaskIdResponse
        /// </returns>
        public GetOtaTaskByTaskIdResponse GetOtaTaskByTaskIdWithOptions(GetOtaTaskByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOtaTaskByTaskId",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOtaTaskByTaskIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an over-the-air update task, including the available version and release notes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOtaTaskByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOtaTaskByTaskIdResponse
        /// </returns>
        public async Task<GetOtaTaskByTaskIdResponse> GetOtaTaskByTaskIdWithOptionsAsync(GetOtaTaskByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOtaTaskByTaskId",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOtaTaskByTaskIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an over-the-air update task, including the available version and release notes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOtaTaskByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOtaTaskByTaskIdResponse
        /// </returns>
        public GetOtaTaskByTaskIdResponse GetOtaTaskByTaskId(GetOtaTaskByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOtaTaskByTaskIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an over-the-air update task, including the available version and release notes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOtaTaskByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOtaTaskByTaskIdResponse
        /// </returns>
        public async Task<GetOtaTaskByTaskIdResponse> GetOtaTaskByTaskIdAsync(GetOtaTaskByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOtaTaskByTaskIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price information of a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePriceResponse
        /// </returns>
        public GetResourcePriceResponse GetResourcePriceWithOptions(GetResourcePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceType))
            {
                query["AppInstanceType"] = request.AppInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourcePrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price information of a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePriceResponse
        /// </returns>
        public async Task<GetResourcePriceResponse> GetResourcePriceWithOptionsAsync(GetResourcePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceType))
            {
                query["AppInstanceType"] = request.AppInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourcePrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price information of a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePriceResponse
        /// </returns>
        public GetResourcePriceResponse GetResourcePrice(GetResourcePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourcePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price information of a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePriceResponse
        /// </returns>
        public async Task<GetResourcePriceResponse> GetResourcePriceAsync(GetResourcePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourcePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal price of WUYING Cloud Application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRenewPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRenewPriceResponse
        /// </returns>
        public GetResourceRenewPriceResponse GetResourceRenewPriceWithOptions(GetResourceRenewPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceRenewPrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceRenewPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal price of WUYING Cloud Application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRenewPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRenewPriceResponse
        /// </returns>
        public async Task<GetResourceRenewPriceResponse> GetResourceRenewPriceWithOptionsAsync(GetResourceRenewPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceRenewPrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceRenewPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal price of WUYING Cloud Application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRenewPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRenewPriceResponse
        /// </returns>
        public GetResourceRenewPriceResponse GetResourceRenewPrice(GetResourceRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceRenewPriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal price of WUYING Cloud Application resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRenewPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRenewPriceResponse
        /// </returns>
        public async Task<GetResourceRenewPriceResponse> GetResourceRenewPriceAsync(GetResourceRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceRenewPriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the third-party channel configurations of an Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the third-party channel configuration status of Agents such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuntimeChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuntimeChannelResponse
        /// </returns>
        public GetRuntimeChannelResponse GetRuntimeChannelWithOptions(GetRuntimeChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRiskInfo))
            {
                query["IncludeRiskInfo"] = request.IncludeRiskInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeId))
            {
                query["RuntimeId"] = request.RuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                query["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuntimeChannel",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuntimeChannelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the third-party channel configurations of an Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the third-party channel configuration status of Agents such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuntimeChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuntimeChannelResponse
        /// </returns>
        public async Task<GetRuntimeChannelResponse> GetRuntimeChannelWithOptionsAsync(GetRuntimeChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRiskInfo))
            {
                query["IncludeRiskInfo"] = request.IncludeRiskInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeId))
            {
                query["RuntimeId"] = request.RuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                query["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuntimeChannel",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuntimeChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the third-party channel configurations of an Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the third-party channel configuration status of Agents such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuntimeChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuntimeChannelResponse
        /// </returns>
        public GetRuntimeChannelResponse GetRuntimeChannel(GetRuntimeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuntimeChannelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the third-party channel configurations of an Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the third-party channel configuration status of Agents such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuntimeChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuntimeChannelResponse
        /// </returns>
        public async Task<GetRuntimeChannelResponse> GetRuntimeChannelAsync(GetRuntimeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuntimeChannelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the model configuration details of a cloud computer.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the model configuration details currently bound to a specified cloud computer in the Wuying Agent Management Center, including model groups, model provider lists, and associated model information. After you enable the risk information mode, you can also identify differences between the end user\&quot;s actual configuration and the configuration delivered by the administrator.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuntimeModelConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuntimeModelConfigResponse
        /// </returns>
        public GetRuntimeModelConfigResponse GetRuntimeModelConfigWithOptions(GetRuntimeModelConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRiskInfo))
            {
                query["IncludeRiskInfo"] = request.IncludeRiskInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeId))
            {
                query["RuntimeId"] = request.RuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                query["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuntimeModelConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuntimeModelConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the model configuration details of a cloud computer.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the model configuration details currently bound to a specified cloud computer in the Wuying Agent Management Center, including model groups, model provider lists, and associated model information. After you enable the risk information mode, you can also identify differences between the end user\&quot;s actual configuration and the configuration delivered by the administrator.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuntimeModelConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuntimeModelConfigResponse
        /// </returns>
        public async Task<GetRuntimeModelConfigResponse> GetRuntimeModelConfigWithOptionsAsync(GetRuntimeModelConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRiskInfo))
            {
                query["IncludeRiskInfo"] = request.IncludeRiskInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeId))
            {
                query["RuntimeId"] = request.RuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                query["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuntimeModelConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuntimeModelConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the model configuration details of a cloud computer.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the model configuration details currently bound to a specified cloud computer in the Wuying Agent Management Center, including model groups, model provider lists, and associated model information. After you enable the risk information mode, you can also identify differences between the end user\&quot;s actual configuration and the configuration delivered by the administrator.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuntimeModelConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuntimeModelConfigResponse
        /// </returns>
        public GetRuntimeModelConfigResponse GetRuntimeModelConfig(GetRuntimeModelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuntimeModelConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the model configuration details of a cloud computer.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the model configuration details currently bound to a specified cloud computer in the Wuying Agent Management Center, including model groups, model provider lists, and associated model information. After you enable the risk information mode, you can also identify differences between the end user\&quot;s actual configuration and the configuration delivered by the administrator.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuntimeModelConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuntimeModelConfigResponse
        /// </returns>
        public async Task<GetRuntimeModelConfigResponse> GetRuntimeModelConfigAsync(GetRuntimeModelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuntimeModelConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of multiple delivery groups. This operation queries all delivery groups that meet the specified conditions instead of a specific delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceGroupResponse
        /// </returns>
        public ListAppInstanceGroupResponse ListAppInstanceGroupWithOptions(ListAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                query["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedUserGroupIds))
            {
                body["ExcludedUserGroupIds"] = request.ExcludedUserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                body["UserGroupIds"] = request.UserGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of multiple delivery groups. This operation queries all delivery groups that meet the specified conditions instead of a specific delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceGroupResponse
        /// </returns>
        public async Task<ListAppInstanceGroupResponse> ListAppInstanceGroupWithOptionsAsync(ListAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                query["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedUserGroupIds))
            {
                body["ExcludedUserGroupIds"] = request.ExcludedUserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                body["UserGroupIds"] = request.UserGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of multiple delivery groups. This operation queries all delivery groups that meet the specified conditions instead of a specific delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceGroupResponse
        /// </returns>
        public ListAppInstanceGroupResponse ListAppInstanceGroup(ListAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of multiple delivery groups. This operation queries all delivery groups that meet the specified conditions instead of a specific delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceGroupResponse
        /// </returns>
        public async Task<ListAppInstanceGroupResponse> ListAppInstanceGroupAsync(ListAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of session instances in a delivery group, including instance IDs, instance statuses, creation time, update time, session statuses, and public IP addresses of primary network interface controllers (NICs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstancesResponse
        /// </returns>
        public ListAppInstancesResponse ListAppInstancesWithOptions(ListAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDeleted))
            {
                query["IncludeDeleted"] = request.IncludeDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIdList))
            {
                body["AppInstanceIdList"] = request.AppInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of session instances in a delivery group, including instance IDs, instance statuses, creation time, update time, session statuses, and public IP addresses of primary network interface controllers (NICs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstancesResponse
        /// </returns>
        public async Task<ListAppInstancesResponse> ListAppInstancesWithOptionsAsync(ListAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDeleted))
            {
                query["IncludeDeleted"] = request.IncludeDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIdList))
            {
                body["AppInstanceIdList"] = request.AppInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of session instances in a delivery group, including instance IDs, instance statuses, creation time, update time, session statuses, and public IP addresses of primary network interface controllers (NICs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstancesResponse
        /// </returns>
        public ListAppInstancesResponse ListAppInstances(ListAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of session instances in a delivery group, including instance IDs, instance statuses, creation time, update time, session statuses, and public IP addresses of primary network interface controllers (NICs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstancesResponse
        /// </returns>
        public async Task<ListAppInstancesResponse> ListAppInstancesAsync(ListAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deployed applications in the image used by a specified delivery group with paging and returns the number of users with per-application authorization for each application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation returns the list of deployed applications in the application image used by a specified delivery group, including the application ID, name, version, icon, and the number of users currently <b>authorized by application</b> for each application (AuthorizedUserCount).
        /// The returned AppId is the input for per-application authorization: when you call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to add or remove authorized users for a specified application in a delivery group, pass in the AppId returned by this operation.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The delivery group is created, and <b>ProductType matches the product type of the delivery group</b>. If the delivery group does not exist or the product type does not match, the error code <c>InvalidAppInstanceGroup.NotFound</c> is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>AppInstanceGroupId is required</b>. This parameter is marked as optional in the parameter table, but the error code <c>InvalidParameter.AppInstanceGroupId</c> is returned if it is not specified.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100. If the values are invalid, the error codes <c>InvalidParameter.PageNumber</c> and <c>InvalidParameter.PageSize</c> are returned respectively.</description></item>
        /// <item><description>If no applications are deployed in the delivery group image, the operation returns normally: Apps is an empty list and TotalCount is 0.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId).</description></item>
        /// <item><description>Call this operation to obtain the list of deployed applications in the delivery group and the AppId of each application.</description></item>
        /// <item><description>To authorize by application, call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation with the returned AppId.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAppsByAppInstanceGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppsByAppInstanceGroupIdResponse
        /// </returns>
        public ListAppsByAppInstanceGroupIdResponse ListAppsByAppInstanceGroupIdWithOptions(ListAppsByAppInstanceGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppsByAppInstanceGroupId",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppsByAppInstanceGroupIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deployed applications in the image used by a specified delivery group with paging and returns the number of users with per-application authorization for each application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation returns the list of deployed applications in the application image used by a specified delivery group, including the application ID, name, version, icon, and the number of users currently <b>authorized by application</b> for each application (AuthorizedUserCount).
        /// The returned AppId is the input for per-application authorization: when you call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to add or remove authorized users for a specified application in a delivery group, pass in the AppId returned by this operation.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The delivery group is created, and <b>ProductType matches the product type of the delivery group</b>. If the delivery group does not exist or the product type does not match, the error code <c>InvalidAppInstanceGroup.NotFound</c> is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>AppInstanceGroupId is required</b>. This parameter is marked as optional in the parameter table, but the error code <c>InvalidParameter.AppInstanceGroupId</c> is returned if it is not specified.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100. If the values are invalid, the error codes <c>InvalidParameter.PageNumber</c> and <c>InvalidParameter.PageSize</c> are returned respectively.</description></item>
        /// <item><description>If no applications are deployed in the delivery group image, the operation returns normally: Apps is an empty list and TotalCount is 0.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId).</description></item>
        /// <item><description>Call this operation to obtain the list of deployed applications in the delivery group and the AppId of each application.</description></item>
        /// <item><description>To authorize by application, call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation with the returned AppId.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAppsByAppInstanceGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppsByAppInstanceGroupIdResponse
        /// </returns>
        public async Task<ListAppsByAppInstanceGroupIdResponse> ListAppsByAppInstanceGroupIdWithOptionsAsync(ListAppsByAppInstanceGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppsByAppInstanceGroupId",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppsByAppInstanceGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deployed applications in the image used by a specified delivery group with paging and returns the number of users with per-application authorization for each application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation returns the list of deployed applications in the application image used by a specified delivery group, including the application ID, name, version, icon, and the number of users currently <b>authorized by application</b> for each application (AuthorizedUserCount).
        /// The returned AppId is the input for per-application authorization: when you call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to add or remove authorized users for a specified application in a delivery group, pass in the AppId returned by this operation.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The delivery group is created, and <b>ProductType matches the product type of the delivery group</b>. If the delivery group does not exist or the product type does not match, the error code <c>InvalidAppInstanceGroup.NotFound</c> is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>AppInstanceGroupId is required</b>. This parameter is marked as optional in the parameter table, but the error code <c>InvalidParameter.AppInstanceGroupId</c> is returned if it is not specified.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100. If the values are invalid, the error codes <c>InvalidParameter.PageNumber</c> and <c>InvalidParameter.PageSize</c> are returned respectively.</description></item>
        /// <item><description>If no applications are deployed in the delivery group image, the operation returns normally: Apps is an empty list and TotalCount is 0.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId).</description></item>
        /// <item><description>Call this operation to obtain the list of deployed applications in the delivery group and the AppId of each application.</description></item>
        /// <item><description>To authorize by application, call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation with the returned AppId.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAppsByAppInstanceGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppsByAppInstanceGroupIdResponse
        /// </returns>
        public ListAppsByAppInstanceGroupIdResponse ListAppsByAppInstanceGroupId(ListAppsByAppInstanceGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppsByAppInstanceGroupIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deployed applications in the image used by a specified delivery group with paging and returns the number of users with per-application authorization for each application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation returns the list of deployed applications in the application image used by a specified delivery group, including the application ID, name, version, icon, and the number of users currently <b>authorized by application</b> for each application (AuthorizedUserCount).
        /// The returned AppId is the input for per-application authorization: when you call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to add or remove authorized users for a specified application in a delivery group, pass in the AppId returned by this operation.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The delivery group is created, and <b>ProductType matches the product type of the delivery group</b>. If the delivery group does not exist or the product type does not match, the error code <c>InvalidAppInstanceGroup.NotFound</c> is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>AppInstanceGroupId is required</b>. This parameter is marked as optional in the parameter table, but the error code <c>InvalidParameter.AppInstanceGroupId</c> is returned if it is not specified.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100. If the values are invalid, the error codes <c>InvalidParameter.PageNumber</c> and <c>InvalidParameter.PageSize</c> are returned respectively.</description></item>
        /// <item><description>If no applications are deployed in the delivery group image, the operation returns normally: Apps is an empty list and TotalCount is 0.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId).</description></item>
        /// <item><description>Call this operation to obtain the list of deployed applications in the delivery group and the AppId of each application.</description></item>
        /// <item><description>To authorize by application, call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation with the returned AppId.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAppsByAppInstanceGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppsByAppInstanceGroupIdResponse
        /// </returns>
        public async Task<ListAppsByAppInstanceGroupIdResponse> ListAppsByAppInstanceGroupIdAsync(ListAppsByAppInstanceGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppsByAppInstanceGroupIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery groups for which a specified user has obtained access permissions through delivery group-level authorization by paging, with support for fuzzy filtering by delivery group ID, delivery group name, application ID, or application name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the list of delivery groups for which a specified user (EndUserId) has been granted <b>delivery group-level authorization</b>. The response includes basic information about each delivery group (ID, name, status, region, creation time, expiration time, and more) and the list of applications deployed in the delivery group.
        /// Scope of returned results:</para>
        /// <list type="bullet">
        /// <item><description>Only delivery groups that are authorized to the user as a whole through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation are returned. Records authorized on a per-application basis through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation are not included.</description></item>
        /// <item><description>Only delivery groups whose product type matches the ProductType parameter and that have not been deleted are returned. A delivery group is not returned if its image contains no deployed applications.</description></item>
        /// <item><description>Results are sorted in reverse chronological order by the update time of the authorization record. The most recently authorized or modified delivery groups appear first.</description></item>
        /// </list>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize the delivery group to the user.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ProductType and EndUserId are required</b>. If ProductType is not specified, the error code <c>InvalidParameter.ProductType</c> is returned. If EndUserId is not specified, the error code <c>InvalidParameter.UserId</c> is returned.</description></item>
        /// <item><description>EndUserId performs an <b>exact match</b> on the username. AppInstanceGroupId, AppInstanceGroupName, AppId, and AppName all perform <b>fuzzy matching</b> (a hit occurs if the value is contained). When multiple filter conditions are specified, all conditions must be met simultaneously.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100.</description></item>
        /// <item><description>If the user has no authorized delivery groups that match the conditions, the operation returns normally: AppInstanceGroupModels is an empty list and TotalCount is 0.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID, and then call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize the delivery group to the user.</description></item>
        /// <item><description>Call this operation to query the delivery groups authorized to the user and the applications deployed in each delivery group.</description></item>
        /// <item><description>To obtain an application connection ticket for the user, call the <a href="~~GetConnectionTicket~~">GetConnectionTicket</a> operation with the AppInstanceGroupId and the AppId from the Apps list in the response.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAppInstanceGroupByUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAppInstanceGroupByUserResponse
        /// </returns>
        public ListAuthorizedAppInstanceGroupByUserResponse ListAuthorizedAppInstanceGroupByUserWithOptions(ListAuthorizedAppInstanceGroupByUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedAppInstanceGroupByUser",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedAppInstanceGroupByUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery groups for which a specified user has obtained access permissions through delivery group-level authorization by paging, with support for fuzzy filtering by delivery group ID, delivery group name, application ID, or application name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the list of delivery groups for which a specified user (EndUserId) has been granted <b>delivery group-level authorization</b>. The response includes basic information about each delivery group (ID, name, status, region, creation time, expiration time, and more) and the list of applications deployed in the delivery group.
        /// Scope of returned results:</para>
        /// <list type="bullet">
        /// <item><description>Only delivery groups that are authorized to the user as a whole through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation are returned. Records authorized on a per-application basis through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation are not included.</description></item>
        /// <item><description>Only delivery groups whose product type matches the ProductType parameter and that have not been deleted are returned. A delivery group is not returned if its image contains no deployed applications.</description></item>
        /// <item><description>Results are sorted in reverse chronological order by the update time of the authorization record. The most recently authorized or modified delivery groups appear first.</description></item>
        /// </list>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize the delivery group to the user.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ProductType and EndUserId are required</b>. If ProductType is not specified, the error code <c>InvalidParameter.ProductType</c> is returned. If EndUserId is not specified, the error code <c>InvalidParameter.UserId</c> is returned.</description></item>
        /// <item><description>EndUserId performs an <b>exact match</b> on the username. AppInstanceGroupId, AppInstanceGroupName, AppId, and AppName all perform <b>fuzzy matching</b> (a hit occurs if the value is contained). When multiple filter conditions are specified, all conditions must be met simultaneously.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100.</description></item>
        /// <item><description>If the user has no authorized delivery groups that match the conditions, the operation returns normally: AppInstanceGroupModels is an empty list and TotalCount is 0.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID, and then call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize the delivery group to the user.</description></item>
        /// <item><description>Call this operation to query the delivery groups authorized to the user and the applications deployed in each delivery group.</description></item>
        /// <item><description>To obtain an application connection ticket for the user, call the <a href="~~GetConnectionTicket~~">GetConnectionTicket</a> operation with the AppInstanceGroupId and the AppId from the Apps list in the response.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAppInstanceGroupByUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAppInstanceGroupByUserResponse
        /// </returns>
        public async Task<ListAuthorizedAppInstanceGroupByUserResponse> ListAuthorizedAppInstanceGroupByUserWithOptionsAsync(ListAuthorizedAppInstanceGroupByUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedAppInstanceGroupByUser",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedAppInstanceGroupByUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery groups for which a specified user has obtained access permissions through delivery group-level authorization by paging, with support for fuzzy filtering by delivery group ID, delivery group name, application ID, or application name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the list of delivery groups for which a specified user (EndUserId) has been granted <b>delivery group-level authorization</b>. The response includes basic information about each delivery group (ID, name, status, region, creation time, expiration time, and more) and the list of applications deployed in the delivery group.
        /// Scope of returned results:</para>
        /// <list type="bullet">
        /// <item><description>Only delivery groups that are authorized to the user as a whole through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation are returned. Records authorized on a per-application basis through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation are not included.</description></item>
        /// <item><description>Only delivery groups whose product type matches the ProductType parameter and that have not been deleted are returned. A delivery group is not returned if its image contains no deployed applications.</description></item>
        /// <item><description>Results are sorted in reverse chronological order by the update time of the authorization record. The most recently authorized or modified delivery groups appear first.</description></item>
        /// </list>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize the delivery group to the user.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ProductType and EndUserId are required</b>. If ProductType is not specified, the error code <c>InvalidParameter.ProductType</c> is returned. If EndUserId is not specified, the error code <c>InvalidParameter.UserId</c> is returned.</description></item>
        /// <item><description>EndUserId performs an <b>exact match</b> on the username. AppInstanceGroupId, AppInstanceGroupName, AppId, and AppName all perform <b>fuzzy matching</b> (a hit occurs if the value is contained). When multiple filter conditions are specified, all conditions must be met simultaneously.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100.</description></item>
        /// <item><description>If the user has no authorized delivery groups that match the conditions, the operation returns normally: AppInstanceGroupModels is an empty list and TotalCount is 0.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID, and then call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize the delivery group to the user.</description></item>
        /// <item><description>Call this operation to query the delivery groups authorized to the user and the applications deployed in each delivery group.</description></item>
        /// <item><description>To obtain an application connection ticket for the user, call the <a href="~~GetConnectionTicket~~">GetConnectionTicket</a> operation with the AppInstanceGroupId and the AppId from the Apps list in the response.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAppInstanceGroupByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAppInstanceGroupByUserResponse
        /// </returns>
        public ListAuthorizedAppInstanceGroupByUserResponse ListAuthorizedAppInstanceGroupByUser(ListAuthorizedAppInstanceGroupByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthorizedAppInstanceGroupByUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery groups for which a specified user has obtained access permissions through delivery group-level authorization by paging, with support for fuzzy filtering by delivery group ID, delivery group name, application ID, or application name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the list of delivery groups for which a specified user (EndUserId) has been granted <b>delivery group-level authorization</b>. The response includes basic information about each delivery group (ID, name, status, region, creation time, expiration time, and more) and the list of applications deployed in the delivery group.
        /// Scope of returned results:</para>
        /// <list type="bullet">
        /// <item><description>Only delivery groups that are authorized to the user as a whole through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation are returned. Records authorized on a per-application basis through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation are not included.</description></item>
        /// <item><description>Only delivery groups whose product type matches the ProductType parameter and that have not been deleted are returned. A delivery group is not returned if its image contains no deployed applications.</description></item>
        /// <item><description>Results are sorted in reverse chronological order by the update time of the authorization record. The most recently authorized or modified delivery groups appear first.</description></item>
        /// </list>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize the delivery group to the user.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ProductType and EndUserId are required</b>. If ProductType is not specified, the error code <c>InvalidParameter.ProductType</c> is returned. If EndUserId is not specified, the error code <c>InvalidParameter.UserId</c> is returned.</description></item>
        /// <item><description>EndUserId performs an <b>exact match</b> on the username. AppInstanceGroupId, AppInstanceGroupName, AppId, and AppName all perform <b>fuzzy matching</b> (a hit occurs if the value is contained). When multiple filter conditions are specified, all conditions must be met simultaneously.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100.</description></item>
        /// <item><description>If the user has no authorized delivery groups that match the conditions, the operation returns normally: AppInstanceGroupModels is an empty list and TotalCount is 0.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID, and then call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize the delivery group to the user.</description></item>
        /// <item><description>Call this operation to query the delivery groups authorized to the user and the applications deployed in each delivery group.</description></item>
        /// <item><description>To obtain an application connection ticket for the user, call the <a href="~~GetConnectionTicket~~">GetConnectionTicket</a> operation with the AppInstanceGroupId and the AppId from the Apps list in the response.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAppInstanceGroupByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAppInstanceGroupByUserResponse
        /// </returns>
        public async Task<ListAuthorizedAppInstanceGroupByUserResponse> ListAuthorizedAppInstanceGroupByUserAsync(ListAuthorizedAppInstanceGroupByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthorizedAppInstanceGroupByUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the applications for which a specified user has obtained access permissions through per-application authorization by paging. You can filter results by delivery group ID, delivery group name, application ID, or application name using fuzzy match.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the applications that a specified user is authorized to access at the application granularity. <b>Only records authorized at the application level are returned</b> (for example, authorizations completed through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation). Authorizations granted to an entire delivery group through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation are not included in the response.
        /// The results are deduplicated by the combination of delivery group and application. Each record corresponds to one application within one delivery group.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The user must already exist under the current account. If the user does not exist, the error code <c>User.NotFound</c> is returned. Call the <a href="https://help.aliyun.com/document_detail/436936.html">DescribeUsers</a> operation to obtain the username.</description></item>
        /// <item><description>The delivery group that contains the application must already be created, and the application must have been authorized to the user at the application level. If no per-application authorization has been performed, an empty application list is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b><c>EndUserId</c> and <c>ProductType</c> are required.</b> Set <c>ProductType</c> to <c>CloudApp</c>, which indicates WUYING Cloud Application.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppId</c>, <c>AppInstanceGroupName</c>, and <c>AppName</c> are optional filter conditions. All of them use fuzzy match and can be combined in any way. If all are omitted, all per-application authorization records for the user are returned.</description></item>
        /// <item><description>Use <c>PageNumber</c> and <c>PageSize</c> for paging. <c>PageNumber</c> starts from 1, and <c>PageSize</c> ranges from 1 to 100. Use the returned <c>TotalCount</c> to determine whether to continue querying.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> or <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId) and the application IDs of deployed applications within the delivery group (AppId in the Apps list).</description></item>
        /// <item><description>Call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to authorize the application to the target user.</description></item>
        /// <item><description>Call this operation to query the applications that the user is authorized to access.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAppsByUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAppsByUserResponse
        /// </returns>
        public ListAuthorizedAppsByUserResponse ListAuthorizedAppsByUserWithOptions(ListAuthorizedAppsByUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedAppsByUser",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedAppsByUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the applications for which a specified user has obtained access permissions through per-application authorization by paging. You can filter results by delivery group ID, delivery group name, application ID, or application name using fuzzy match.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the applications that a specified user is authorized to access at the application granularity. <b>Only records authorized at the application level are returned</b> (for example, authorizations completed through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation). Authorizations granted to an entire delivery group through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation are not included in the response.
        /// The results are deduplicated by the combination of delivery group and application. Each record corresponds to one application within one delivery group.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The user must already exist under the current account. If the user does not exist, the error code <c>User.NotFound</c> is returned. Call the <a href="https://help.aliyun.com/document_detail/436936.html">DescribeUsers</a> operation to obtain the username.</description></item>
        /// <item><description>The delivery group that contains the application must already be created, and the application must have been authorized to the user at the application level. If no per-application authorization has been performed, an empty application list is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b><c>EndUserId</c> and <c>ProductType</c> are required.</b> Set <c>ProductType</c> to <c>CloudApp</c>, which indicates WUYING Cloud Application.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppId</c>, <c>AppInstanceGroupName</c>, and <c>AppName</c> are optional filter conditions. All of them use fuzzy match and can be combined in any way. If all are omitted, all per-application authorization records for the user are returned.</description></item>
        /// <item><description>Use <c>PageNumber</c> and <c>PageSize</c> for paging. <c>PageNumber</c> starts from 1, and <c>PageSize</c> ranges from 1 to 100. Use the returned <c>TotalCount</c> to determine whether to continue querying.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> or <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId) and the application IDs of deployed applications within the delivery group (AppId in the Apps list).</description></item>
        /// <item><description>Call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to authorize the application to the target user.</description></item>
        /// <item><description>Call this operation to query the applications that the user is authorized to access.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAppsByUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAppsByUserResponse
        /// </returns>
        public async Task<ListAuthorizedAppsByUserResponse> ListAuthorizedAppsByUserWithOptionsAsync(ListAuthorizedAppsByUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedAppsByUser",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedAppsByUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the applications for which a specified user has obtained access permissions through per-application authorization by paging. You can filter results by delivery group ID, delivery group name, application ID, or application name using fuzzy match.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the applications that a specified user is authorized to access at the application granularity. <b>Only records authorized at the application level are returned</b> (for example, authorizations completed through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation). Authorizations granted to an entire delivery group through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation are not included in the response.
        /// The results are deduplicated by the combination of delivery group and application. Each record corresponds to one application within one delivery group.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The user must already exist under the current account. If the user does not exist, the error code <c>User.NotFound</c> is returned. Call the <a href="https://help.aliyun.com/document_detail/436936.html">DescribeUsers</a> operation to obtain the username.</description></item>
        /// <item><description>The delivery group that contains the application must already be created, and the application must have been authorized to the user at the application level. If no per-application authorization has been performed, an empty application list is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b><c>EndUserId</c> and <c>ProductType</c> are required.</b> Set <c>ProductType</c> to <c>CloudApp</c>, which indicates WUYING Cloud Application.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppId</c>, <c>AppInstanceGroupName</c>, and <c>AppName</c> are optional filter conditions. All of them use fuzzy match and can be combined in any way. If all are omitted, all per-application authorization records for the user are returned.</description></item>
        /// <item><description>Use <c>PageNumber</c> and <c>PageSize</c> for paging. <c>PageNumber</c> starts from 1, and <c>PageSize</c> ranges from 1 to 100. Use the returned <c>TotalCount</c> to determine whether to continue querying.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> or <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId) and the application IDs of deployed applications within the delivery group (AppId in the Apps list).</description></item>
        /// <item><description>Call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to authorize the application to the target user.</description></item>
        /// <item><description>Call this operation to query the applications that the user is authorized to access.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAppsByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAppsByUserResponse
        /// </returns>
        public ListAuthorizedAppsByUserResponse ListAuthorizedAppsByUser(ListAuthorizedAppsByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthorizedAppsByUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the applications for which a specified user has obtained access permissions through per-application authorization by paging. You can filter results by delivery group ID, delivery group name, application ID, or application name using fuzzy match.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the applications that a specified user is authorized to access at the application granularity. <b>Only records authorized at the application level are returned</b> (for example, authorizations completed through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation). Authorizations granted to an entire delivery group through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation are not included in the response.
        /// The results are deduplicated by the combination of delivery group and application. Each record corresponds to one application within one delivery group.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The user must already exist under the current account. If the user does not exist, the error code <c>User.NotFound</c> is returned. Call the <a href="https://help.aliyun.com/document_detail/436936.html">DescribeUsers</a> operation to obtain the username.</description></item>
        /// <item><description>The delivery group that contains the application must already be created, and the application must have been authorized to the user at the application level. If no per-application authorization has been performed, an empty application list is returned.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b><c>EndUserId</c> and <c>ProductType</c> are required.</b> Set <c>ProductType</c> to <c>CloudApp</c>, which indicates WUYING Cloud Application.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppId</c>, <c>AppInstanceGroupName</c>, and <c>AppName</c> are optional filter conditions. All of them use fuzzy match and can be combined in any way. If all are omitted, all per-application authorization records for the user are returned.</description></item>
        /// <item><description>Use <c>PageNumber</c> and <c>PageSize</c> for paging. <c>PageNumber</c> starts from 1, and <c>PageSize</c> ranges from 1 to 100. Use the returned <c>TotalCount</c> to determine whether to continue querying.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> or <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation to obtain the delivery group ID (AppInstanceGroupId) and the application IDs of deployed applications within the delivery group (AppId in the Apps list).</description></item>
        /// <item><description>Call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to authorize the application to the target user.</description></item>
        /// <item><description>Call this operation to query the applications that the user is authorized to access.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAppsByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAppsByUserResponse
        /// </returns>
        public async Task<ListAuthorizedAppsByUserResponse> ListAuthorizedAppsByUserAsync(ListAuthorizedAppsByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthorizedAppsByUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of user groups authorized by a specified delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedUserGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUserGroupsResponse
        /// </returns>
        public ListAuthorizedUserGroupsResponse ListAuthorizedUserGroupsWithOptions(ListAuthorizedUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                body["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedUserGroups",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedUserGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of user groups authorized by a specified delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedUserGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUserGroupsResponse
        /// </returns>
        public async Task<ListAuthorizedUserGroupsResponse> ListAuthorizedUserGroupsWithOptionsAsync(ListAuthorizedUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                body["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedUserGroups",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedUserGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of user groups authorized by a specified delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedUserGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUserGroupsResponse
        /// </returns>
        public ListAuthorizedUserGroupsResponse ListAuthorizedUserGroups(ListAuthorizedUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthorizedUserGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of user groups authorized by a specified delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedUserGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUserGroupsResponse
        /// </returns>
        public async Task<ListAuthorizedUserGroupsResponse> ListAuthorizedUserGroupsAsync(ListAuthorizedUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthorizedUserGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of authorized users for a specified delivery group or delivery group set by using paging. Supports exact or fuzzy filtering by username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the currently authorized users of a specified delivery group (AppInstanceGroupId) or delivery group set (AppInstanceGroupSetId). It returns each user\&quot;s username, account type, email address, phone number, and the authorization mode of the associated delivery group.</para>
        /// <list type="bullet">
        /// <item><description>This operation returns <b>authorization relationships</b> and does not indicate whether users are currently online or have established connections.</description></item>
        /// <item><description>In the Cloud Browser product, a delivery group corresponds to a cloud browser group, and a delivery group ID corresponds to a browser group ID.
        /// The scope of results depends on the authorization mode of the delivery group (response parameter AuthMode):</description></item>
        /// <item><description>When the authorization mode is <c>App</c> (application-level authorization) or <c>AppInstanceGroup</c> (delivery group-level authorization): Returns users authorized through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation at the delivery group level, as well as users authorized through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation at the application level. If AppId is specified, only users <b>authorized for that specific application</b> are returned.</description></item>
        /// <item><description>When the authorization mode is <c>Session</c> (session-level authorization): Returns users who have been granted persistent sessions. The AppInstancePersistentIds field lists all persistent session IDs granted to each user. If AppInstancePersistentId is specified, only users granted that session are returned.</description></item>
        /// <item><description>When querying by delivery group set: Returns users authorized for the set. The response parameter AppInstanceGroupId is the primary delivery group ID of the set, and AppInstanceGroupSetId is the queried set ID.
        /// When querying by delivery group, results are sorted in descending order by authorization time, with the most recently authorized users listed first.</description></item>
        /// </list>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The target delivery group or delivery group set must be created, belong to the current account, and match the specified ProductType. Otherwise, a resource-not-found error code is returned.</description></item>
        /// <item><description>Users must have been authorized through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> or <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation. If no users have been authorized, the operation returns normally with an empty Users list and TotalCount of 0.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ProductType, PageNumber, and PageSize are required</b>. If ProductType has an invalid value, the error code <c>ProductTypeInvalid</c> is returned.</description></item>
        /// <item><description><b>Exactly one of AppInstanceGroupId and AppInstanceGroupSetId must be specified</b>. If both or neither are specified, the error code <c>InvalidParameter.AppInstanceGroupId/AppInstanceGroupSetId</c> is returned.</description></item>
        /// <item><description><b>AppId and AppInstancePersistentId are not supported when querying by delivery group set</b>. If specified, the error codes <c>InvalidParameter.AppId</c> and <c>InvalidParameter.AppInstancePersistentId</c> are returned respectively.</description></item>
        /// <item><description>EndUserId performs <b>exact matching</b> by username. UserIdFuzzy performs <b>fuzzy matching</b> by username (a hit occurs if the username contains the keyword). Both can be specified simultaneously, in which case both conditions must be met.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100.</description></item>
        /// <item><description>When the authorization mode is <c>App</c> or <c>AppInstanceGroup</c>, TotalCount is the number of <b>authorization records</b> that match the conditions. If the same user has multiple authorization records (for example, authorized for multiple applications), the records are merged into a single user entry in Users. Therefore, the number of users returned on the current page may be less than PageSize. Use TotalCount to determine whether to continue paging. When the authorization mode is <c>Session</c>, TotalCount is the deduplicated user count.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID. For cloud browser groups, call the <a href="~~ListBrowserInstanceGroup~~">ListBrowserInstanceGroup</a> operation.</description></item>
        /// <item><description>Call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize at the delivery group level, or call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to authorize at the application level.</description></item>
        /// <item><description>Call this operation to query authorized users. To remove authorization, pass the returned EndUserId values to the UnAuthorizeUserIds parameter of the authorization operations mentioned above.</description></item>
        /// </ol>
        /// <h2>Error codes</h2>
        /// <list type="bullet">
        /// <item><description><c>ProductTypeInvalid</c>: The value of ProductType is invalid.</description></item>
        /// <item><description><c>InvalidParameter.AppInstanceGroupId/AppInstanceGroupSetId</c>: Both AppInstanceGroupId and AppInstanceGroupSetId are specified, or neither is specified.</description></item>
        /// <item><description><c>InvalidParameter.AppId</c>: AppId is specified when querying by delivery group set.</description></item>
        /// <item><description><c>InvalidParameter.AppInstancePersistentId</c>: AppInstancePersistentId is specified when querying by delivery group set.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSpecItem.NotFound</c>: The delivery group does not exist, does not belong to the current account, or the product type does not match.</description></item>
        /// <item><description><c>InvalidBrowserInstanceGroup.NotFound</c>: When ProductType is <c>CloudBrowser</c>, the cloud browser group does not exist, does not belong to the current account, or the product type does not match.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSet.NotFound</c>: The delivery group set does not exist, does not belong to the current account, the product type does not match, or the set does not have an available primary delivery group.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSet.ActivationFailed</c>: The delivery group set is not in an available state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUsersResponse
        /// </returns>
        public ListAuthorizedUsersResponse ListAuthorizedUsersWithOptions(ListAuthorizedUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdFuzzy))
            {
                query["UserIdFuzzy"] = request.UserIdFuzzy;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                body["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedUsers",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of authorized users for a specified delivery group or delivery group set by using paging. Supports exact or fuzzy filtering by username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the currently authorized users of a specified delivery group (AppInstanceGroupId) or delivery group set (AppInstanceGroupSetId). It returns each user\&quot;s username, account type, email address, phone number, and the authorization mode of the associated delivery group.</para>
        /// <list type="bullet">
        /// <item><description>This operation returns <b>authorization relationships</b> and does not indicate whether users are currently online or have established connections.</description></item>
        /// <item><description>In the Cloud Browser product, a delivery group corresponds to a cloud browser group, and a delivery group ID corresponds to a browser group ID.
        /// The scope of results depends on the authorization mode of the delivery group (response parameter AuthMode):</description></item>
        /// <item><description>When the authorization mode is <c>App</c> (application-level authorization) or <c>AppInstanceGroup</c> (delivery group-level authorization): Returns users authorized through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation at the delivery group level, as well as users authorized through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation at the application level. If AppId is specified, only users <b>authorized for that specific application</b> are returned.</description></item>
        /// <item><description>When the authorization mode is <c>Session</c> (session-level authorization): Returns users who have been granted persistent sessions. The AppInstancePersistentIds field lists all persistent session IDs granted to each user. If AppInstancePersistentId is specified, only users granted that session are returned.</description></item>
        /// <item><description>When querying by delivery group set: Returns users authorized for the set. The response parameter AppInstanceGroupId is the primary delivery group ID of the set, and AppInstanceGroupSetId is the queried set ID.
        /// When querying by delivery group, results are sorted in descending order by authorization time, with the most recently authorized users listed first.</description></item>
        /// </list>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The target delivery group or delivery group set must be created, belong to the current account, and match the specified ProductType. Otherwise, a resource-not-found error code is returned.</description></item>
        /// <item><description>Users must have been authorized through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> or <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation. If no users have been authorized, the operation returns normally with an empty Users list and TotalCount of 0.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ProductType, PageNumber, and PageSize are required</b>. If ProductType has an invalid value, the error code <c>ProductTypeInvalid</c> is returned.</description></item>
        /// <item><description><b>Exactly one of AppInstanceGroupId and AppInstanceGroupSetId must be specified</b>. If both or neither are specified, the error code <c>InvalidParameter.AppInstanceGroupId/AppInstanceGroupSetId</c> is returned.</description></item>
        /// <item><description><b>AppId and AppInstancePersistentId are not supported when querying by delivery group set</b>. If specified, the error codes <c>InvalidParameter.AppId</c> and <c>InvalidParameter.AppInstancePersistentId</c> are returned respectively.</description></item>
        /// <item><description>EndUserId performs <b>exact matching</b> by username. UserIdFuzzy performs <b>fuzzy matching</b> by username (a hit occurs if the username contains the keyword). Both can be specified simultaneously, in which case both conditions must be met.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100.</description></item>
        /// <item><description>When the authorization mode is <c>App</c> or <c>AppInstanceGroup</c>, TotalCount is the number of <b>authorization records</b> that match the conditions. If the same user has multiple authorization records (for example, authorized for multiple applications), the records are merged into a single user entry in Users. Therefore, the number of users returned on the current page may be less than PageSize. Use TotalCount to determine whether to continue paging. When the authorization mode is <c>Session</c>, TotalCount is the deduplicated user count.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID. For cloud browser groups, call the <a href="~~ListBrowserInstanceGroup~~">ListBrowserInstanceGroup</a> operation.</description></item>
        /// <item><description>Call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize at the delivery group level, or call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to authorize at the application level.</description></item>
        /// <item><description>Call this operation to query authorized users. To remove authorization, pass the returned EndUserId values to the UnAuthorizeUserIds parameter of the authorization operations mentioned above.</description></item>
        /// </ol>
        /// <h2>Error codes</h2>
        /// <list type="bullet">
        /// <item><description><c>ProductTypeInvalid</c>: The value of ProductType is invalid.</description></item>
        /// <item><description><c>InvalidParameter.AppInstanceGroupId/AppInstanceGroupSetId</c>: Both AppInstanceGroupId and AppInstanceGroupSetId are specified, or neither is specified.</description></item>
        /// <item><description><c>InvalidParameter.AppId</c>: AppId is specified when querying by delivery group set.</description></item>
        /// <item><description><c>InvalidParameter.AppInstancePersistentId</c>: AppInstancePersistentId is specified when querying by delivery group set.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSpecItem.NotFound</c>: The delivery group does not exist, does not belong to the current account, or the product type does not match.</description></item>
        /// <item><description><c>InvalidBrowserInstanceGroup.NotFound</c>: When ProductType is <c>CloudBrowser</c>, the cloud browser group does not exist, does not belong to the current account, or the product type does not match.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSet.NotFound</c>: The delivery group set does not exist, does not belong to the current account, the product type does not match, or the set does not have an available primary delivery group.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSet.ActivationFailed</c>: The delivery group set is not in an available state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUsersResponse
        /// </returns>
        public async Task<ListAuthorizedUsersResponse> ListAuthorizedUsersWithOptionsAsync(ListAuthorizedUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdFuzzy))
            {
                query["UserIdFuzzy"] = request.UserIdFuzzy;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                body["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedUsers",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of authorized users for a specified delivery group or delivery group set by using paging. Supports exact or fuzzy filtering by username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the currently authorized users of a specified delivery group (AppInstanceGroupId) or delivery group set (AppInstanceGroupSetId). It returns each user\&quot;s username, account type, email address, phone number, and the authorization mode of the associated delivery group.</para>
        /// <list type="bullet">
        /// <item><description>This operation returns <b>authorization relationships</b> and does not indicate whether users are currently online or have established connections.</description></item>
        /// <item><description>In the Cloud Browser product, a delivery group corresponds to a cloud browser group, and a delivery group ID corresponds to a browser group ID.
        /// The scope of results depends on the authorization mode of the delivery group (response parameter AuthMode):</description></item>
        /// <item><description>When the authorization mode is <c>App</c> (application-level authorization) or <c>AppInstanceGroup</c> (delivery group-level authorization): Returns users authorized through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation at the delivery group level, as well as users authorized through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation at the application level. If AppId is specified, only users <b>authorized for that specific application</b> are returned.</description></item>
        /// <item><description>When the authorization mode is <c>Session</c> (session-level authorization): Returns users who have been granted persistent sessions. The AppInstancePersistentIds field lists all persistent session IDs granted to each user. If AppInstancePersistentId is specified, only users granted that session are returned.</description></item>
        /// <item><description>When querying by delivery group set: Returns users authorized for the set. The response parameter AppInstanceGroupId is the primary delivery group ID of the set, and AppInstanceGroupSetId is the queried set ID.
        /// When querying by delivery group, results are sorted in descending order by authorization time, with the most recently authorized users listed first.</description></item>
        /// </list>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The target delivery group or delivery group set must be created, belong to the current account, and match the specified ProductType. Otherwise, a resource-not-found error code is returned.</description></item>
        /// <item><description>Users must have been authorized through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> or <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation. If no users have been authorized, the operation returns normally with an empty Users list and TotalCount of 0.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ProductType, PageNumber, and PageSize are required</b>. If ProductType has an invalid value, the error code <c>ProductTypeInvalid</c> is returned.</description></item>
        /// <item><description><b>Exactly one of AppInstanceGroupId and AppInstanceGroupSetId must be specified</b>. If both or neither are specified, the error code <c>InvalidParameter.AppInstanceGroupId/AppInstanceGroupSetId</c> is returned.</description></item>
        /// <item><description><b>AppId and AppInstancePersistentId are not supported when querying by delivery group set</b>. If specified, the error codes <c>InvalidParameter.AppId</c> and <c>InvalidParameter.AppInstancePersistentId</c> are returned respectively.</description></item>
        /// <item><description>EndUserId performs <b>exact matching</b> by username. UserIdFuzzy performs <b>fuzzy matching</b> by username (a hit occurs if the username contains the keyword). Both can be specified simultaneously, in which case both conditions must be met.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100.</description></item>
        /// <item><description>When the authorization mode is <c>App</c> or <c>AppInstanceGroup</c>, TotalCount is the number of <b>authorization records</b> that match the conditions. If the same user has multiple authorization records (for example, authorized for multiple applications), the records are merged into a single user entry in Users. Therefore, the number of users returned on the current page may be less than PageSize. Use TotalCount to determine whether to continue paging. When the authorization mode is <c>Session</c>, TotalCount is the deduplicated user count.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID. For cloud browser groups, call the <a href="~~ListBrowserInstanceGroup~~">ListBrowserInstanceGroup</a> operation.</description></item>
        /// <item><description>Call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize at the delivery group level, or call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to authorize at the application level.</description></item>
        /// <item><description>Call this operation to query authorized users. To remove authorization, pass the returned EndUserId values to the UnAuthorizeUserIds parameter of the authorization operations mentioned above.</description></item>
        /// </ol>
        /// <h2>Error codes</h2>
        /// <list type="bullet">
        /// <item><description><c>ProductTypeInvalid</c>: The value of ProductType is invalid.</description></item>
        /// <item><description><c>InvalidParameter.AppInstanceGroupId/AppInstanceGroupSetId</c>: Both AppInstanceGroupId and AppInstanceGroupSetId are specified, or neither is specified.</description></item>
        /// <item><description><c>InvalidParameter.AppId</c>: AppId is specified when querying by delivery group set.</description></item>
        /// <item><description><c>InvalidParameter.AppInstancePersistentId</c>: AppInstancePersistentId is specified when querying by delivery group set.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSpecItem.NotFound</c>: The delivery group does not exist, does not belong to the current account, or the product type does not match.</description></item>
        /// <item><description><c>InvalidBrowserInstanceGroup.NotFound</c>: When ProductType is <c>CloudBrowser</c>, the cloud browser group does not exist, does not belong to the current account, or the product type does not match.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSet.NotFound</c>: The delivery group set does not exist, does not belong to the current account, the product type does not match, or the set does not have an available primary delivery group.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSet.ActivationFailed</c>: The delivery group set is not in an available state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUsersResponse
        /// </returns>
        public ListAuthorizedUsersResponse ListAuthorizedUsers(ListAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthorizedUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of authorized users for a specified delivery group or delivery group set by using paging. Supports exact or fuzzy filtering by username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation queries the currently authorized users of a specified delivery group (AppInstanceGroupId) or delivery group set (AppInstanceGroupSetId). It returns each user\&quot;s username, account type, email address, phone number, and the authorization mode of the associated delivery group.</para>
        /// <list type="bullet">
        /// <item><description>This operation returns <b>authorization relationships</b> and does not indicate whether users are currently online or have established connections.</description></item>
        /// <item><description>In the Cloud Browser product, a delivery group corresponds to a cloud browser group, and a delivery group ID corresponds to a browser group ID.
        /// The scope of results depends on the authorization mode of the delivery group (response parameter AuthMode):</description></item>
        /// <item><description>When the authorization mode is <c>App</c> (application-level authorization) or <c>AppInstanceGroup</c> (delivery group-level authorization): Returns users authorized through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation at the delivery group level, as well as users authorized through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation at the application level. If AppId is specified, only users <b>authorized for that specific application</b> are returned.</description></item>
        /// <item><description>When the authorization mode is <c>Session</c> (session-level authorization): Returns users who have been granted persistent sessions. The AppInstancePersistentIds field lists all persistent session IDs granted to each user. If AppInstancePersistentId is specified, only users granted that session are returned.</description></item>
        /// <item><description>When querying by delivery group set: Returns users authorized for the set. The response parameter AppInstanceGroupId is the primary delivery group ID of the set, and AppInstanceGroupSetId is the queried set ID.
        /// When querying by delivery group, results are sorted in descending order by authorization time, with the most recently authorized users listed first.</description></item>
        /// </list>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>The target delivery group or delivery group set must be created, belong to the current account, and match the specified ProductType. Otherwise, a resource-not-found error code is returned.</description></item>
        /// <item><description>Users must have been authorized through the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> or <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation. If no users have been authorized, the operation returns normally with an empty Users list and TotalCount of 0.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ProductType, PageNumber, and PageSize are required</b>. If ProductType has an invalid value, the error code <c>ProductTypeInvalid</c> is returned.</description></item>
        /// <item><description><b>Exactly one of AppInstanceGroupId and AppInstanceGroupSetId must be specified</b>. If both or neither are specified, the error code <c>InvalidParameter.AppInstanceGroupId/AppInstanceGroupSetId</c> is returned.</description></item>
        /// <item><description><b>AppId and AppInstancePersistentId are not supported when querying by delivery group set</b>. If specified, the error codes <c>InvalidParameter.AppId</c> and <c>InvalidParameter.AppInstancePersistentId</c> are returned respectively.</description></item>
        /// <item><description>EndUserId performs <b>exact matching</b> by username. UserIdFuzzy performs <b>fuzzy matching</b> by username (a hit occurs if the username contains the keyword). Both can be specified simultaneously, in which case both conditions must be met.</description></item>
        /// <item><description>PageNumber starts from 1. Valid values of PageSize: 1 to 100.</description></item>
        /// <item><description>When the authorization mode is <c>App</c> or <c>AppInstanceGroup</c>, TotalCount is the number of <b>authorization records</b> that match the conditions. If the same user has multiple authorization records (for example, authorized for multiple applications), the records are merged into a single user entry in Users. Therefore, the number of users returned on the current page may be less than PageSize. Use TotalCount to determine whether to continue paging. When the authorization mode is <c>Session</c>, TotalCount is the deduplicated user count.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID. For cloud browser groups, call the <a href="~~ListBrowserInstanceGroup~~">ListBrowserInstanceGroup</a> operation.</description></item>
        /// <item><description>Call the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> operation to authorize at the delivery group level, or call the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to authorize at the application level.</description></item>
        /// <item><description>Call this operation to query authorized users. To remove authorization, pass the returned EndUserId values to the UnAuthorizeUserIds parameter of the authorization operations mentioned above.</description></item>
        /// </ol>
        /// <h2>Error codes</h2>
        /// <list type="bullet">
        /// <item><description><c>ProductTypeInvalid</c>: The value of ProductType is invalid.</description></item>
        /// <item><description><c>InvalidParameter.AppInstanceGroupId/AppInstanceGroupSetId</c>: Both AppInstanceGroupId and AppInstanceGroupSetId are specified, or neither is specified.</description></item>
        /// <item><description><c>InvalidParameter.AppId</c>: AppId is specified when querying by delivery group set.</description></item>
        /// <item><description><c>InvalidParameter.AppInstancePersistentId</c>: AppInstancePersistentId is specified when querying by delivery group set.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSpecItem.NotFound</c>: The delivery group does not exist, does not belong to the current account, or the product type does not match.</description></item>
        /// <item><description><c>InvalidBrowserInstanceGroup.NotFound</c>: When ProductType is <c>CloudBrowser</c>, the cloud browser group does not exist, does not belong to the current account, or the product type does not match.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSet.NotFound</c>: The delivery group set does not exist, does not belong to the current account, the product type does not match, or the set does not have an available primary delivery group.</description></item>
        /// <item><description><c>InvalidAppInstanceGroupSet.ActivationFailed</c>: The delivery group set is not in an available state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUsersResponse
        /// </returns>
        public async Task<ListAuthorizedUsersResponse> ListAuthorizedUsersAsync(ListAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthorizedUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bindng information between users and resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindInfoResponse
        /// </returns>
        public ListBindInfoResponse ListBindInfoWithOptions(ListBindInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                body["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupIdList))
            {
                body["AppInstanceGroupIdList"] = request.AppInstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIdList))
            {
                body["AppInstanceIdList"] = request.AppInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["UserIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyIdList))
            {
                body["WyIdList"] = request.WyIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindInfo",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bindng information between users and resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindInfoResponse
        /// </returns>
        public async Task<ListBindInfoResponse> ListBindInfoWithOptionsAsync(ListBindInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                body["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupIdList))
            {
                body["AppInstanceGroupIdList"] = request.AppInstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIdList))
            {
                body["AppInstanceIdList"] = request.AppInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["UserIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyIdList))
            {
                body["WyIdList"] = request.WyIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindInfo",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bindng information between users and resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindInfoResponse
        /// </returns>
        public ListBindInfoResponse ListBindInfo(ListBindInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bindng information between users and resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindInfoResponse
        /// </returns>
        public async Task<ListBindInfoResponse> ListBindInfoAsync(ListBindInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cloud browser groups and their current status by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to use this operation in the monthly active user (MAU) billing scenario.</para>
        /// <h2>Query conditions</h2>
        /// <para>You can filter by browser group identity, name, business region, office network, set, authorized user group, and status. Only one status value can be specified at a time.</para>
        /// <h2>Paging</h2>
        /// <para>Use <c>PageNumber</c> and <c>PageSize</c> for paging. Use the returned <c>TotalCount</c> to determine whether to continue querying the next page.</para>
        /// <h2>What to do next</h2>
        /// <para>To view the detailed configuration of a single browser group, invoke <c>GetBrowserInstanceGroup</c> with the returned identity.</para>
        /// <h2>Example notes</h2>
        /// <para>The <c>-</c> in the examples indicates that the field is not applicable or not returned in the current scenario. It is not an actual character string returned by the operation. Resource identities in the examples are masked. Use the actual query results in your environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBrowserInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBrowserInstanceGroupResponse
        /// </returns>
        public ListBrowserInstanceGroupResponse ListBrowserInstanceGroupWithOptions(ListBrowserInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                query["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserInstanceGroupId))
            {
                query["BrowserInstanceGroupId"] = request.BrowserInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserInstanceGroupName))
            {
                query["BrowserInstanceGroupName"] = request.BrowserInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudBrowserName))
            {
                query["CloudBrowserName"] = request.CloudBrowserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tier))
            {
                query["Tier"] = request.Tier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedUserGroupIds))
            {
                body["ExcludedUserGroupIds"] = request.ExcludedUserGroupIds;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                bodyFlat["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                body["UserGroupIds"] = request.UserGroupIds;
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
                Action = "ListBrowserInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBrowserInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cloud browser groups and their current status by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to use this operation in the monthly active user (MAU) billing scenario.</para>
        /// <h2>Query conditions</h2>
        /// <para>You can filter by browser group identity, name, business region, office network, set, authorized user group, and status. Only one status value can be specified at a time.</para>
        /// <h2>Paging</h2>
        /// <para>Use <c>PageNumber</c> and <c>PageSize</c> for paging. Use the returned <c>TotalCount</c> to determine whether to continue querying the next page.</para>
        /// <h2>What to do next</h2>
        /// <para>To view the detailed configuration of a single browser group, invoke <c>GetBrowserInstanceGroup</c> with the returned identity.</para>
        /// <h2>Example notes</h2>
        /// <para>The <c>-</c> in the examples indicates that the field is not applicable or not returned in the current scenario. It is not an actual character string returned by the operation. Resource identities in the examples are masked. Use the actual query results in your environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBrowserInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBrowserInstanceGroupResponse
        /// </returns>
        public async Task<ListBrowserInstanceGroupResponse> ListBrowserInstanceGroupWithOptionsAsync(ListBrowserInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupSetId))
            {
                query["AppInstanceGroupSetId"] = request.AppInstanceGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserInstanceGroupId))
            {
                query["BrowserInstanceGroupId"] = request.BrowserInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserInstanceGroupName))
            {
                query["BrowserInstanceGroupName"] = request.BrowserInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudBrowserName))
            {
                query["CloudBrowserName"] = request.CloudBrowserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tier))
            {
                query["Tier"] = request.Tier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedUserGroupIds))
            {
                body["ExcludedUserGroupIds"] = request.ExcludedUserGroupIds;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                bodyFlat["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                body["UserGroupIds"] = request.UserGroupIds;
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
                Action = "ListBrowserInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBrowserInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cloud browser groups and their current status by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to use this operation in the monthly active user (MAU) billing scenario.</para>
        /// <h2>Query conditions</h2>
        /// <para>You can filter by browser group identity, name, business region, office network, set, authorized user group, and status. Only one status value can be specified at a time.</para>
        /// <h2>Paging</h2>
        /// <para>Use <c>PageNumber</c> and <c>PageSize</c> for paging. Use the returned <c>TotalCount</c> to determine whether to continue querying the next page.</para>
        /// <h2>What to do next</h2>
        /// <para>To view the detailed configuration of a single browser group, invoke <c>GetBrowserInstanceGroup</c> with the returned identity.</para>
        /// <h2>Example notes</h2>
        /// <para>The <c>-</c> in the examples indicates that the field is not applicable or not returned in the current scenario. It is not an actual character string returned by the operation. Resource identities in the examples are masked. Use the actual query results in your environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBrowserInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBrowserInstanceGroupResponse
        /// </returns>
        public ListBrowserInstanceGroupResponse ListBrowserInstanceGroup(ListBrowserInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBrowserInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cloud browser groups and their current status by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to use this operation in the monthly active user (MAU) billing scenario.</para>
        /// <h2>Query conditions</h2>
        /// <para>You can filter by browser group identity, name, business region, office network, set, authorized user group, and status. Only one status value can be specified at a time.</para>
        /// <h2>Paging</h2>
        /// <para>Use <c>PageNumber</c> and <c>PageSize</c> for paging. Use the returned <c>TotalCount</c> to determine whether to continue querying the next page.</para>
        /// <h2>What to do next</h2>
        /// <para>To view the detailed configuration of a single browser group, invoke <c>GetBrowserInstanceGroup</c> with the returned identity.</para>
        /// <h2>Example notes</h2>
        /// <para>The <c>-</c> in the examples indicates that the field is not applicable or not returned in the current scenario. It is not an actual character string returned by the operation. Resource identities in the examples are masked. Use the actual query results in your environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBrowserInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBrowserInstanceGroupResponse
        /// </returns>
        public async Task<ListBrowserInstanceGroupResponse> ListBrowserInstanceGroupAsync(ListBrowserInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBrowserInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of desktop agent runtimes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDesktopAgentRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDesktopAgentRuntimeResponse
        /// </returns>
        public ListDesktopAgentRuntimeResponse ListDesktopAgentRuntimeWithOptions(ListDesktopAgentRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentImOnlineStatus))
            {
                query["AgentImOnlineStatus"] = request.AgentImOnlineStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentInstanceStatuses))
            {
                query["AgentInstanceStatuses"] = request.AgentInstanceStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentInstanceVersions))
            {
                query["AgentInstanceVersions"] = request.AgentInstanceVersions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatformList))
            {
                query["AgentPlatformList"] = request.AgentPlatformList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProviderList))
            {
                query["AgentProviderList"] = request.AgentProviderList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTemplateIds))
            {
                query["AgentTemplateIds"] = request.AgentTemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthUsers))
            {
                query["AuthUsers"] = request.AuthUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelConfigure))
            {
                query["ChannelConfigure"] = request.ChannelConfigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentSource))
            {
                query["DeploymentSource"] = request.DeploymentSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopIds))
            {
                query["DesktopIds"] = request.DesktopIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopNames))
            {
                query["DesktopNames"] = request.DesktopNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopStatuses))
            {
                query["DesktopStatuses"] = request.DesktopStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasAuthUser))
            {
                query["HasAuthUser"] = request.HasAuthUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasRisk))
            {
                query["HasRisk"] = request.HasRisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRiskInfo))
            {
                query["IncludeRiskInfo"] = request.IncludeRiskInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagementStatus))
            {
                query["ManagementStatus"] = request.ManagementStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfigure))
            {
                query["ModelConfigure"] = request.ModelConfigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDesktopAgentRuntime",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDesktopAgentRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of desktop agent runtimes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDesktopAgentRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDesktopAgentRuntimeResponse
        /// </returns>
        public async Task<ListDesktopAgentRuntimeResponse> ListDesktopAgentRuntimeWithOptionsAsync(ListDesktopAgentRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentImOnlineStatus))
            {
                query["AgentImOnlineStatus"] = request.AgentImOnlineStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentInstanceStatuses))
            {
                query["AgentInstanceStatuses"] = request.AgentInstanceStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentInstanceVersions))
            {
                query["AgentInstanceVersions"] = request.AgentInstanceVersions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatformList))
            {
                query["AgentPlatformList"] = request.AgentPlatformList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProviderList))
            {
                query["AgentProviderList"] = request.AgentProviderList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTemplateIds))
            {
                query["AgentTemplateIds"] = request.AgentTemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthUsers))
            {
                query["AuthUsers"] = request.AuthUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelConfigure))
            {
                query["ChannelConfigure"] = request.ChannelConfigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentSource))
            {
                query["DeploymentSource"] = request.DeploymentSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopIds))
            {
                query["DesktopIds"] = request.DesktopIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopNames))
            {
                query["DesktopNames"] = request.DesktopNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopStatuses))
            {
                query["DesktopStatuses"] = request.DesktopStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasAuthUser))
            {
                query["HasAuthUser"] = request.HasAuthUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasRisk))
            {
                query["HasRisk"] = request.HasRisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRiskInfo))
            {
                query["IncludeRiskInfo"] = request.IncludeRiskInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagementStatus))
            {
                query["ManagementStatus"] = request.ManagementStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfigure))
            {
                query["ModelConfigure"] = request.ModelConfigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDesktopAgentRuntime",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDesktopAgentRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of desktop agent runtimes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDesktopAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDesktopAgentRuntimeResponse
        /// </returns>
        public ListDesktopAgentRuntimeResponse ListDesktopAgentRuntime(ListDesktopAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDesktopAgentRuntimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of desktop agent runtimes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDesktopAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDesktopAgentRuntimeResponse
        /// </returns>
        public async Task<ListDesktopAgentRuntimeResponse> ListDesktopAgentRuntimeAsync(ListDesktopAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDesktopAgentRuntimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImageResponse
        /// </returns>
        public ListImageResponse ListImageWithOptions(ListImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distro))
            {
                query["Distro"] = request.Distro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionIdList))
            {
                body["BizRegionIdList"] = request.BizRegionIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypeList))
            {
                body["BizTypeList"] = request.BizTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureList))
            {
                body["FeatureList"] = request.FeatureList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FotaVersion))
            {
                body["FotaVersion"] = request.FotaVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageType))
            {
                body["LanguageType"] = request.LanguageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                body["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformNameList))
            {
                body["PlatformNameList"] = request.PlatformNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTypeList))
            {
                body["ProductTypeList"] = request.ProductTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                body["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceType))
            {
                body["ResourceInstanceType"] = request.ResourceInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImageResponse
        /// </returns>
        public async Task<ListImageResponse> ListImageWithOptionsAsync(ListImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distro))
            {
                query["Distro"] = request.Distro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionIdList))
            {
                body["BizRegionIdList"] = request.BizRegionIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypeList))
            {
                body["BizTypeList"] = request.BizTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureList))
            {
                body["FeatureList"] = request.FeatureList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FotaVersion))
            {
                body["FotaVersion"] = request.FotaVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageType))
            {
                body["LanguageType"] = request.LanguageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                body["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformNameList))
            {
                body["PlatformNameList"] = request.PlatformNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTypeList))
            {
                body["ProductTypeList"] = request.ProductTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                body["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceType))
            {
                body["ResourceInstanceType"] = request.ResourceInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImageResponse
        /// </returns>
        public ListImageResponse ListImage(ListImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImageResponse
        /// </returns>
        public async Task<ListImageResponse> ListImageAsync(ListImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of LLM templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the list of model templates under a model provider template in the WUYING Agent Management Center with paging. Filtering by model group ID, model provider template ID, model template ID, and model encoding is supported. When querying by model group dimension, the default model is automatically pinned to the top.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListLlmTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLlmTemplatesResponse
        /// </returns>
        public ListLlmTemplatesResponse ListLlmTemplatesWithOptions(ListLlmTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListLlmTemplatesShrinkRequest request = new ListLlmTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LlmTemplateIds))
            {
                request.LlmTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LlmTemplateIds, "LlmTemplateIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmCode))
            {
                query["LlmCode"] = request.LlmCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmTemplateIdsShrink))
            {
                query["LlmTemplateIds"] = request.LlmTemplateIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                query["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartModel))
            {
                query["SmartModel"] = request.SmartModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLlmTemplates",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLlmTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of LLM templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the list of model templates under a model provider template in the WUYING Agent Management Center with paging. Filtering by model group ID, model provider template ID, model template ID, and model encoding is supported. When querying by model group dimension, the default model is automatically pinned to the top.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListLlmTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLlmTemplatesResponse
        /// </returns>
        public async Task<ListLlmTemplatesResponse> ListLlmTemplatesWithOptionsAsync(ListLlmTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListLlmTemplatesShrinkRequest request = new ListLlmTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LlmTemplateIds))
            {
                request.LlmTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LlmTemplateIds, "LlmTemplateIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmCode))
            {
                query["LlmCode"] = request.LlmCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmTemplateIdsShrink))
            {
                query["LlmTemplateIds"] = request.LlmTemplateIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                query["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartModel))
            {
                query["SmartModel"] = request.SmartModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLlmTemplates",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLlmTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of LLM templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the list of model templates under a model provider template in the WUYING Agent Management Center with paging. Filtering by model group ID, model provider template ID, model template ID, and model encoding is supported. When querying by model group dimension, the default model is automatically pinned to the top.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLlmTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLlmTemplatesResponse
        /// </returns>
        public ListLlmTemplatesResponse ListLlmTemplates(ListLlmTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLlmTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of LLM templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the list of model templates under a model provider template in the WUYING Agent Management Center with paging. Filtering by model group ID, model provider template ID, model template ID, and model encoding is supported. When querying by model group dimension, the default model is automatically pinned to the top.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLlmTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLlmTemplatesResponse
        /// </returns>
        public async Task<ListLlmTemplatesResponse> ListLlmTemplatesAsync(ListLlmTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLlmTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model provider endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelProviderEndpointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProviderEndpointsResponse
        /// </returns>
        public ListModelProviderEndpointsResponse ListModelProviderEndpointsWithOptions(ListModelProviderEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                query["ProviderName"] = request.ProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProviderEndpoints",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProviderEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model provider endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelProviderEndpointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProviderEndpointsResponse
        /// </returns>
        public async Task<ListModelProviderEndpointsResponse> ListModelProviderEndpointsWithOptionsAsync(ListModelProviderEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                query["ProviderName"] = request.ProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProviderEndpoints",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProviderEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model provider endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelProviderEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProviderEndpointsResponse
        /// </returns>
        public ListModelProviderEndpointsResponse ListModelProviderEndpoints(ListModelProviderEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelProviderEndpointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model provider endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelProviderEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProviderEndpointsResponse
        /// </returns>
        public async Task<ListModelProviderEndpointsResponse> ListModelProviderEndpointsAsync(ListModelProviderEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelProviderEndpointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model provider templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can perform a paged query to retrieve the list of model provider templates under a specified model group in the WUYING Agent Management Center. You can filter results by provider name, model group ID, and provider template ID. Paging is supported.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListModelProviderTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProviderTemplatesResponse
        /// </returns>
        public ListModelProviderTemplatesResponse ListModelProviderTemplatesWithOptions(ListModelProviderTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelProviderTemplatesShrinkRequest request = new ListModelProviderTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProviderTemplateIds))
            {
                request.ProviderTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProviderTemplateIds, "ProviderTemplateIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                query["ProviderName"] = request.ProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateIdsShrink))
            {
                query["ProviderTemplateIds"] = request.ProviderTemplateIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProviderTemplates",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProviderTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model provider templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can perform a paged query to retrieve the list of model provider templates under a specified model group in the WUYING Agent Management Center. You can filter results by provider name, model group ID, and provider template ID. Paging is supported.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListModelProviderTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProviderTemplatesResponse
        /// </returns>
        public async Task<ListModelProviderTemplatesResponse> ListModelProviderTemplatesWithOptionsAsync(ListModelProviderTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelProviderTemplatesShrinkRequest request = new ListModelProviderTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProviderTemplateIds))
            {
                request.ProviderTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProviderTemplateIds, "ProviderTemplateIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderName))
            {
                query["ProviderName"] = request.ProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateIdsShrink))
            {
                query["ProviderTemplateIds"] = request.ProviderTemplateIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProviderTemplates",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProviderTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model provider templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can perform a paged query to retrieve the list of model provider templates under a specified model group in the WUYING Agent Management Center. You can filter results by provider name, model group ID, and provider template ID. Paging is supported.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProviderTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProviderTemplatesResponse
        /// </returns>
        public ListModelProviderTemplatesResponse ListModelProviderTemplates(ListModelProviderTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelProviderTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model provider templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can perform a paged query to retrieve the list of model provider templates under a specified model group in the WUYING Agent Management Center. You can filter results by provider name, model group ID, and provider template ID. Paging is supported.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProviderTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProviderTemplatesResponse
        /// </returns>
        public async Task<ListModelProviderTemplatesResponse> ListModelProviderTemplatesAsync(ListModelProviderTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelProviderTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource groups associated with a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the list of resource groups authorized by a model group in the WUYING Agent Management Center.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelTemplateResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelTemplateResourceGroupResponse
        /// </returns>
        public ListModelTemplateResourceGroupResponse ListModelTemplateResourceGroupWithOptions(ListModelTemplateResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelTemplateResourceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelTemplateResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource groups associated with a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the list of resource groups authorized by a model group in the WUYING Agent Management Center.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelTemplateResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelTemplateResourceGroupResponse
        /// </returns>
        public async Task<ListModelTemplateResourceGroupResponse> ListModelTemplateResourceGroupWithOptionsAsync(ListModelTemplateResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelTemplateResourceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelTemplateResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource groups associated with a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the list of resource groups authorized by a model group in the WUYING Agent Management Center.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelTemplateResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelTemplateResourceGroupResponse
        /// </returns>
        public ListModelTemplateResourceGroupResponse ListModelTemplateResourceGroup(ListModelTemplateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelTemplateResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource groups associated with a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the list of resource groups authorized by a model group in the WUYING Agent Management Center.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelTemplateResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelTemplateResourceGroupResponse
        /// </returns>
        public async Task<ListModelTemplateResourceGroupResponse> ListModelTemplateResourceGroupAsync(ListModelTemplateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelTemplateResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of model templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use paged query to retrieve the list of model groups created in the Wuying Agent Management Center. You can filter results by Agent provider, Agent platform, template group ID, and whether models have been configured. Paging is supported.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListModelTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelTemplatesResponse
        /// </returns>
        public ListModelTemplatesResponse ListModelTemplatesWithOptions(ListModelTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelTemplatesShrinkRequest request = new ListModelTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelTemplateIdList))
            {
                request.ModelTemplateIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelTemplateIdList, "ModelTemplateIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatformList))
            {
                query["AgentPlatformList"] = request.AgentPlatformList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProviderList))
            {
                query["AgentProviderList"] = request.AgentProviderList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasModel))
            {
                query["HasModel"] = request.HasModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateIdListShrink))
            {
                query["ModelTemplateIdList"] = request.ModelTemplateIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefScope))
            {
                query["RefScope"] = request.RefScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelTemplates",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of model templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use paged query to retrieve the list of model groups created in the Wuying Agent Management Center. You can filter results by Agent provider, Agent platform, template group ID, and whether models have been configured. Paging is supported.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListModelTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelTemplatesResponse
        /// </returns>
        public async Task<ListModelTemplatesResponse> ListModelTemplatesWithOptionsAsync(ListModelTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelTemplatesShrinkRequest request = new ListModelTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelTemplateIdList))
            {
                request.ModelTemplateIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelTemplateIdList, "ModelTemplateIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                query["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatformList))
            {
                query["AgentPlatformList"] = request.AgentPlatformList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProviderList))
            {
                query["AgentProviderList"] = request.AgentProviderList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasModel))
            {
                query["HasModel"] = request.HasModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateIdListShrink))
            {
                query["ModelTemplateIdList"] = request.ModelTemplateIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefScope))
            {
                query["RefScope"] = request.RefScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelTemplates",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of model templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use paged query to retrieve the list of model groups created in the Wuying Agent Management Center. You can filter results by Agent provider, Agent platform, template group ID, and whether models have been configured. Paging is supported.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelTemplatesResponse
        /// </returns>
        public ListModelTemplatesResponse ListModelTemplates(ListModelTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of model templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use paged query to retrieve the list of model groups created in the Wuying Agent Management Center. You can filter results by Agent provider, Agent platform, template group ID, and whether models have been configured. Paging is supported.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelTemplatesResponse
        /// </returns>
        public async Task<ListModelTemplatesResponse> ListModelTemplatesAsync(ListModelTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource specifications available for selection when creating a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInstanceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInstanceTypeResponse
        /// </returns>
        public ListNodeInstanceTypeResponse ListNodeInstanceTypeWithOptions(ListNodeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gpu))
            {
                query["Gpu"] = request.Gpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuMemory))
            {
                query["GpuMemory"] = request.GpuMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypeForModify))
            {
                query["InstanceTypeForModify"] = request.InstanceTypeForModify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceTypeFamily))
            {
                query["NodeInstanceTypeFamily"] = request.NodeInstanceTypeFamily;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
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
                Action = "ListNodeInstanceType",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeInstanceTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource specifications available for selection when creating a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInstanceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInstanceTypeResponse
        /// </returns>
        public async Task<ListNodeInstanceTypeResponse> ListNodeInstanceTypeWithOptionsAsync(ListNodeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gpu))
            {
                query["Gpu"] = request.Gpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuMemory))
            {
                query["GpuMemory"] = request.GpuMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypeForModify))
            {
                query["InstanceTypeForModify"] = request.InstanceTypeForModify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceTypeFamily))
            {
                query["NodeInstanceTypeFamily"] = request.NodeInstanceTypeFamily;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
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
                Action = "ListNodeInstanceType",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeInstanceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource specifications available for selection when creating a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInstanceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInstanceTypeResponse
        /// </returns>
        public ListNodeInstanceTypeResponse ListNodeInstanceType(ListNodeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeInstanceTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource specifications available for selection when creating a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInstanceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInstanceTypeResponse
        /// </returns>
        public async Task<ListNodeInstanceTypeResponse> ListNodeInstanceTypeAsync(ListNodeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeInstanceTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public ListNodesResponse ListNodesWithOptions(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of over-the-air updates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOtaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOtaTaskResponse
        /// </returns>
        public ListOtaTaskResponse ListOtaTaskWithOptions(ListOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                body["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOtaTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of over-the-air updates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOtaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOtaTaskResponse
        /// </returns>
        public async Task<ListOtaTaskResponse> ListOtaTaskWithOptionsAsync(ListOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                body["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOtaTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of over-the-air updates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOtaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOtaTaskResponse
        /// </returns>
        public ListOtaTaskResponse ListOtaTask(ListOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOtaTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history of over-the-air updates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOtaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOtaTaskResponse
        /// </returns>
        public async Task<ListOtaTaskResponse> ListOtaTaskAsync(ListOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOtaTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of persistent session application instances in a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPersistentAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPersistentAppInstancesResponse
        /// </returns>
        public ListPersistentAppInstancesResponse ListPersistentAppInstancesWithOptions(ListPersistentAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentIds))
            {
                query["AppInstancePersistentIds"] = request.AppInstancePersistentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPersistentAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPersistentAppInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of persistent session application instances in a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPersistentAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPersistentAppInstancesResponse
        /// </returns>
        public async Task<ListPersistentAppInstancesResponse> ListPersistentAppInstancesWithOptionsAsync(ListPersistentAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentIds))
            {
                query["AppInstancePersistentIds"] = request.AppInstancePersistentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPersistentAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPersistentAppInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of persistent session application instances in a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPersistentAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPersistentAppInstancesResponse
        /// </returns>
        public ListPersistentAppInstancesResponse ListPersistentAppInstances(ListPersistentAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersistentAppInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of persistent session application instances in a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPersistentAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPersistentAppInstancesResponse
        /// </returns>
        public async Task<ListPersistentAppInstancesResponse> ListPersistentAppInstancesAsync(ListPersistentAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersistentAppInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries published delivery groups and their application information for a specified product type under the current Alibaba Cloud account by using paging. Supports filtering by delivery group, application, and user authorization status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When calling this operation with a RAM user or STS credential, the <c>appstreaming:ListPublishedAppInstanceGroup</c> permission is required.
        /// A delivery group must be in the published state and have deployed applications in its image to appear in the query results. This operation only queries information. It does not create delivery groups, assign users, or grant application access permissions.</para>
        /// <h2>Query and pagination</h2>
        /// <list type="bullet">
        /// <item><description><b>You must explicitly pass in <c>ProductType</c>, <c>PageNumber</c>, and <c>PageSize</c>.</b> Page numbers start from <c>1</c>, and the page size ranges from <c>1</c> to <c>100</c>.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppInstanceGroupName</c>, <c>AppId</c>, and <c>AppName</c> all support substring matching. You can pass them individually or in combination. When multiple conditions are specified, all conditions must be met simultaneously. When both <c>AppId</c> and <c>AppName</c> are specified, the same application must satisfy both conditions.</description></item>
        /// <item><description>If an optional filter parameter is not specified or is set to an empty string, that condition is not applied. Query results are sorted by delivery group creation time from newest to oldest. A delivery group is not returned multiple times even if it contains multiple matching applications.</description></item>
        /// <item><description><c>ExcludeUserId</c> excludes delivery groups in which all applications have been directly authorized to the specified user. It cannot be used to determine whether the user has no access permissions at all.</description></item>
        /// <item><description><c>AppId</c> and <c>AppName</c> only filter delivery groups. <b>They do not restrict the returned <c>Apps</c> list to only the matched applications.</b></description></item>
        /// </list>
        /// <h2>Invoke sequence</h2>
        /// <ol>
        /// <item><description>Invoke a query with <c>PageNumber=1</c> and the desired <c>PageSize</c>. For WUYING Cloud Application common scenarios, use <c>ProductType=CloudApp</c>.</description></item>
        /// <item><description>Read <c>AppInstanceGroupModels</c>. To retrieve the next page, keep the product type and filter conditions unchanged and increment <c>PageNumber</c>. If no delivery groups match, the total count is <c>0</c> and the list is empty. If the page number exceeds the result range, the list may also be empty, but the total count still represents the total number of matching delivery groups.</description></item>
        /// <item><description>To retrieve details of a single delivery group, pass the full <c>AppInstanceGroupId</c> from the response and the same <c>ProductType</c> to <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a>.
        /// The masked identifiers in the examples are for format demonstration purposes. Replace them with your actual identifiers when invoking the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPublishedAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppInstanceGroupResponse
        /// </returns>
        public ListPublishedAppInstanceGroupResponse ListPublishedAppInstanceGroupWithOptions(ListPublishedAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserId))
            {
                query["ExcludeUserId"] = request.ExcludeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries published delivery groups and their application information for a specified product type under the current Alibaba Cloud account by using paging. Supports filtering by delivery group, application, and user authorization status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When calling this operation with a RAM user or STS credential, the <c>appstreaming:ListPublishedAppInstanceGroup</c> permission is required.
        /// A delivery group must be in the published state and have deployed applications in its image to appear in the query results. This operation only queries information. It does not create delivery groups, assign users, or grant application access permissions.</para>
        /// <h2>Query and pagination</h2>
        /// <list type="bullet">
        /// <item><description><b>You must explicitly pass in <c>ProductType</c>, <c>PageNumber</c>, and <c>PageSize</c>.</b> Page numbers start from <c>1</c>, and the page size ranges from <c>1</c> to <c>100</c>.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppInstanceGroupName</c>, <c>AppId</c>, and <c>AppName</c> all support substring matching. You can pass them individually or in combination. When multiple conditions are specified, all conditions must be met simultaneously. When both <c>AppId</c> and <c>AppName</c> are specified, the same application must satisfy both conditions.</description></item>
        /// <item><description>If an optional filter parameter is not specified or is set to an empty string, that condition is not applied. Query results are sorted by delivery group creation time from newest to oldest. A delivery group is not returned multiple times even if it contains multiple matching applications.</description></item>
        /// <item><description><c>ExcludeUserId</c> excludes delivery groups in which all applications have been directly authorized to the specified user. It cannot be used to determine whether the user has no access permissions at all.</description></item>
        /// <item><description><c>AppId</c> and <c>AppName</c> only filter delivery groups. <b>They do not restrict the returned <c>Apps</c> list to only the matched applications.</b></description></item>
        /// </list>
        /// <h2>Invoke sequence</h2>
        /// <ol>
        /// <item><description>Invoke a query with <c>PageNumber=1</c> and the desired <c>PageSize</c>. For WUYING Cloud Application common scenarios, use <c>ProductType=CloudApp</c>.</description></item>
        /// <item><description>Read <c>AppInstanceGroupModels</c>. To retrieve the next page, keep the product type and filter conditions unchanged and increment <c>PageNumber</c>. If no delivery groups match, the total count is <c>0</c> and the list is empty. If the page number exceeds the result range, the list may also be empty, but the total count still represents the total number of matching delivery groups.</description></item>
        /// <item><description>To retrieve details of a single delivery group, pass the full <c>AppInstanceGroupId</c> from the response and the same <c>ProductType</c> to <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a>.
        /// The masked identifiers in the examples are for format demonstration purposes. Replace them with your actual identifiers when invoking the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPublishedAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppInstanceGroupResponse
        /// </returns>
        public async Task<ListPublishedAppInstanceGroupResponse> ListPublishedAppInstanceGroupWithOptionsAsync(ListPublishedAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserId))
            {
                query["ExcludeUserId"] = request.ExcludeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries published delivery groups and their application information for a specified product type under the current Alibaba Cloud account by using paging. Supports filtering by delivery group, application, and user authorization status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When calling this operation with a RAM user or STS credential, the <c>appstreaming:ListPublishedAppInstanceGroup</c> permission is required.
        /// A delivery group must be in the published state and have deployed applications in its image to appear in the query results. This operation only queries information. It does not create delivery groups, assign users, or grant application access permissions.</para>
        /// <h2>Query and pagination</h2>
        /// <list type="bullet">
        /// <item><description><b>You must explicitly pass in <c>ProductType</c>, <c>PageNumber</c>, and <c>PageSize</c>.</b> Page numbers start from <c>1</c>, and the page size ranges from <c>1</c> to <c>100</c>.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppInstanceGroupName</c>, <c>AppId</c>, and <c>AppName</c> all support substring matching. You can pass them individually or in combination. When multiple conditions are specified, all conditions must be met simultaneously. When both <c>AppId</c> and <c>AppName</c> are specified, the same application must satisfy both conditions.</description></item>
        /// <item><description>If an optional filter parameter is not specified or is set to an empty string, that condition is not applied. Query results are sorted by delivery group creation time from newest to oldest. A delivery group is not returned multiple times even if it contains multiple matching applications.</description></item>
        /// <item><description><c>ExcludeUserId</c> excludes delivery groups in which all applications have been directly authorized to the specified user. It cannot be used to determine whether the user has no access permissions at all.</description></item>
        /// <item><description><c>AppId</c> and <c>AppName</c> only filter delivery groups. <b>They do not restrict the returned <c>Apps</c> list to only the matched applications.</b></description></item>
        /// </list>
        /// <h2>Invoke sequence</h2>
        /// <ol>
        /// <item><description>Invoke a query with <c>PageNumber=1</c> and the desired <c>PageSize</c>. For WUYING Cloud Application common scenarios, use <c>ProductType=CloudApp</c>.</description></item>
        /// <item><description>Read <c>AppInstanceGroupModels</c>. To retrieve the next page, keep the product type and filter conditions unchanged and increment <c>PageNumber</c>. If no delivery groups match, the total count is <c>0</c> and the list is empty. If the page number exceeds the result range, the list may also be empty, but the total count still represents the total number of matching delivery groups.</description></item>
        /// <item><description>To retrieve details of a single delivery group, pass the full <c>AppInstanceGroupId</c> from the response and the same <c>ProductType</c> to <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a>.
        /// The masked identifiers in the examples are for format demonstration purposes. Replace them with your actual identifiers when invoking the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPublishedAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppInstanceGroupResponse
        /// </returns>
        public ListPublishedAppInstanceGroupResponse ListPublishedAppInstanceGroup(ListPublishedAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublishedAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries published delivery groups and their application information for a specified product type under the current Alibaba Cloud account by using paging. Supports filtering by delivery group, application, and user authorization status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When calling this operation with a RAM user or STS credential, the <c>appstreaming:ListPublishedAppInstanceGroup</c> permission is required.
        /// A delivery group must be in the published state and have deployed applications in its image to appear in the query results. This operation only queries information. It does not create delivery groups, assign users, or grant application access permissions.</para>
        /// <h2>Query and pagination</h2>
        /// <list type="bullet">
        /// <item><description><b>You must explicitly pass in <c>ProductType</c>, <c>PageNumber</c>, and <c>PageSize</c>.</b> Page numbers start from <c>1</c>, and the page size ranges from <c>1</c> to <c>100</c>.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppInstanceGroupName</c>, <c>AppId</c>, and <c>AppName</c> all support substring matching. You can pass them individually or in combination. When multiple conditions are specified, all conditions must be met simultaneously. When both <c>AppId</c> and <c>AppName</c> are specified, the same application must satisfy both conditions.</description></item>
        /// <item><description>If an optional filter parameter is not specified or is set to an empty string, that condition is not applied. Query results are sorted by delivery group creation time from newest to oldest. A delivery group is not returned multiple times even if it contains multiple matching applications.</description></item>
        /// <item><description><c>ExcludeUserId</c> excludes delivery groups in which all applications have been directly authorized to the specified user. It cannot be used to determine whether the user has no access permissions at all.</description></item>
        /// <item><description><c>AppId</c> and <c>AppName</c> only filter delivery groups. <b>They do not restrict the returned <c>Apps</c> list to only the matched applications.</b></description></item>
        /// </list>
        /// <h2>Invoke sequence</h2>
        /// <ol>
        /// <item><description>Invoke a query with <c>PageNumber=1</c> and the desired <c>PageSize</c>. For WUYING Cloud Application common scenarios, use <c>ProductType=CloudApp</c>.</description></item>
        /// <item><description>Read <c>AppInstanceGroupModels</c>. To retrieve the next page, keep the product type and filter conditions unchanged and increment <c>PageNumber</c>. If no delivery groups match, the total count is <c>0</c> and the list is empty. If the page number exceeds the result range, the list may also be empty, but the total count still represents the total number of matching delivery groups.</description></item>
        /// <item><description>To retrieve details of a single delivery group, pass the full <c>AppInstanceGroupId</c> from the response and the same <c>ProductType</c> to <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a>.
        /// The masked identifiers in the examples are for format demonstration purposes. Replace them with your actual identifiers when invoking the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPublishedAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppInstanceGroupResponse
        /// </returns>
        public async Task<ListPublishedAppInstanceGroupResponse> ListPublishedAppInstanceGroupAsync(ListPublishedAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublishedAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deployed applications in published delivery groups under the current Alibaba Cloud account for a specified product type by paging, and returns each application along with its delivery group and the number of authorized users by application. Supports filtering by delivery group, application, and user authorization status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When you call this operation by using a RAM user or Security Token Service (STS) credential, you must have the <c>appstreaming:ListPublishedApps</c> permission.
        /// Only delivery groups in the published state whose images contain deployed applications are included in the query results. This operation only queries information. It does not create delivery groups or grant or revoke application access permissions.</para>
        /// <h2>Response granularity</h2>
        /// <para>Results are returned on a per-delivery-group-plus-application basis. If the same application is deployed in multiple published delivery groups, a separate record is returned for each combination. <c>TotalCount</c> also reflects the number of such combinations. The list is sorted by the creation time of the delivery group in descending order.</para>
        /// <h2>Query and pagination</h2>
        /// <list type="bullet">
        /// <item><description><b>You must explicitly specify <c>ProductType</c>, <c>PageNumber</c>, and <c>PageSize</c>.</b> Page numbers start from <c>1</c>, and the page size ranges from <c>1</c> to <c>100</c>. Invalid values return error codes <c>InvalidParameter.PageNumber</c> and <c>InvalidParameter.PageSize</c>, respectively.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppInstanceGroupName</c>, <c>AppId</c>, and <c>AppName</c> all support substring matching. You can specify them individually or in combination. When multiple conditions are specified, all conditions must be met.</description></item>
        /// <item><description>If an optional filter parameter is not specified or is set to an empty string, filtering is not applied for that condition.</description></item>
        /// <item><description><c>ExcludeUserId</c> excludes applications that have been authorized to the specified user by application, which helps you find applications that can still be authorized to that user. <b>Access permissions granted through delivery-group-level authorization or user groups are not evaluated by this condition.</b></description></item>
        /// </list>
        /// <h2>Invocation sequence</h2>
        /// <ol>
        /// <item><description>Initiate a query with <c>PageNumber=1</c> and the desired <c>PageSize</c>. For WUYING Cloud Application common scenarios, use <c>ProductType=CloudApp</c>.</description></item>
        /// <item><description>Read <c>Apps</c>. To retrieve the next page, increment <c>PageNumber</c> while keeping the product type and filter conditions unchanged. If no results match, <c>TotalCount</c> is <c>0</c> and <c>Apps</c> is an empty list. If the page number exceeds the result range, <c>Apps</c> may also be empty, but <c>TotalCount</c> still indicates the total number of matching records.</description></item>
        /// <item><description>To authorize users for a specific application by application, pass the returned <c>AppInstanceGroupId</c>, <c>AppId</c>, and the same <c>ProductType</c> to <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a>. To view delivery group details, pass <c>AppInstanceGroupId</c> and <c>ProductType</c> to <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a>.
        /// The masked identities in the examples are for format demonstration purposes. Replace them with your actual identities when you invoke the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPublishedAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppsResponse
        /// </returns>
        public ListPublishedAppsResponse ListPublishedAppsWithOptions(ListPublishedAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserId))
            {
                query["ExcludeUserId"] = request.ExcludeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedApps",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deployed applications in published delivery groups under the current Alibaba Cloud account for a specified product type by paging, and returns each application along with its delivery group and the number of authorized users by application. Supports filtering by delivery group, application, and user authorization status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When you call this operation by using a RAM user or Security Token Service (STS) credential, you must have the <c>appstreaming:ListPublishedApps</c> permission.
        /// Only delivery groups in the published state whose images contain deployed applications are included in the query results. This operation only queries information. It does not create delivery groups or grant or revoke application access permissions.</para>
        /// <h2>Response granularity</h2>
        /// <para>Results are returned on a per-delivery-group-plus-application basis. If the same application is deployed in multiple published delivery groups, a separate record is returned for each combination. <c>TotalCount</c> also reflects the number of such combinations. The list is sorted by the creation time of the delivery group in descending order.</para>
        /// <h2>Query and pagination</h2>
        /// <list type="bullet">
        /// <item><description><b>You must explicitly specify <c>ProductType</c>, <c>PageNumber</c>, and <c>PageSize</c>.</b> Page numbers start from <c>1</c>, and the page size ranges from <c>1</c> to <c>100</c>. Invalid values return error codes <c>InvalidParameter.PageNumber</c> and <c>InvalidParameter.PageSize</c>, respectively.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppInstanceGroupName</c>, <c>AppId</c>, and <c>AppName</c> all support substring matching. You can specify them individually or in combination. When multiple conditions are specified, all conditions must be met.</description></item>
        /// <item><description>If an optional filter parameter is not specified or is set to an empty string, filtering is not applied for that condition.</description></item>
        /// <item><description><c>ExcludeUserId</c> excludes applications that have been authorized to the specified user by application, which helps you find applications that can still be authorized to that user. <b>Access permissions granted through delivery-group-level authorization or user groups are not evaluated by this condition.</b></description></item>
        /// </list>
        /// <h2>Invocation sequence</h2>
        /// <ol>
        /// <item><description>Initiate a query with <c>PageNumber=1</c> and the desired <c>PageSize</c>. For WUYING Cloud Application common scenarios, use <c>ProductType=CloudApp</c>.</description></item>
        /// <item><description>Read <c>Apps</c>. To retrieve the next page, increment <c>PageNumber</c> while keeping the product type and filter conditions unchanged. If no results match, <c>TotalCount</c> is <c>0</c> and <c>Apps</c> is an empty list. If the page number exceeds the result range, <c>Apps</c> may also be empty, but <c>TotalCount</c> still indicates the total number of matching records.</description></item>
        /// <item><description>To authorize users for a specific application by application, pass the returned <c>AppInstanceGroupId</c>, <c>AppId</c>, and the same <c>ProductType</c> to <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a>. To view delivery group details, pass <c>AppInstanceGroupId</c> and <c>ProductType</c> to <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a>.
        /// The masked identities in the examples are for format demonstration purposes. Replace them with your actual identities when you invoke the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPublishedAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppsResponse
        /// </returns>
        public async Task<ListPublishedAppsResponse> ListPublishedAppsWithOptionsAsync(ListPublishedAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserId))
            {
                query["ExcludeUserId"] = request.ExcludeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedApps",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deployed applications in published delivery groups under the current Alibaba Cloud account for a specified product type by paging, and returns each application along with its delivery group and the number of authorized users by application. Supports filtering by delivery group, application, and user authorization status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When you call this operation by using a RAM user or Security Token Service (STS) credential, you must have the <c>appstreaming:ListPublishedApps</c> permission.
        /// Only delivery groups in the published state whose images contain deployed applications are included in the query results. This operation only queries information. It does not create delivery groups or grant or revoke application access permissions.</para>
        /// <h2>Response granularity</h2>
        /// <para>Results are returned on a per-delivery-group-plus-application basis. If the same application is deployed in multiple published delivery groups, a separate record is returned for each combination. <c>TotalCount</c> also reflects the number of such combinations. The list is sorted by the creation time of the delivery group in descending order.</para>
        /// <h2>Query and pagination</h2>
        /// <list type="bullet">
        /// <item><description><b>You must explicitly specify <c>ProductType</c>, <c>PageNumber</c>, and <c>PageSize</c>.</b> Page numbers start from <c>1</c>, and the page size ranges from <c>1</c> to <c>100</c>. Invalid values return error codes <c>InvalidParameter.PageNumber</c> and <c>InvalidParameter.PageSize</c>, respectively.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppInstanceGroupName</c>, <c>AppId</c>, and <c>AppName</c> all support substring matching. You can specify them individually or in combination. When multiple conditions are specified, all conditions must be met.</description></item>
        /// <item><description>If an optional filter parameter is not specified or is set to an empty string, filtering is not applied for that condition.</description></item>
        /// <item><description><c>ExcludeUserId</c> excludes applications that have been authorized to the specified user by application, which helps you find applications that can still be authorized to that user. <b>Access permissions granted through delivery-group-level authorization or user groups are not evaluated by this condition.</b></description></item>
        /// </list>
        /// <h2>Invocation sequence</h2>
        /// <ol>
        /// <item><description>Initiate a query with <c>PageNumber=1</c> and the desired <c>PageSize</c>. For WUYING Cloud Application common scenarios, use <c>ProductType=CloudApp</c>.</description></item>
        /// <item><description>Read <c>Apps</c>. To retrieve the next page, increment <c>PageNumber</c> while keeping the product type and filter conditions unchanged. If no results match, <c>TotalCount</c> is <c>0</c> and <c>Apps</c> is an empty list. If the page number exceeds the result range, <c>Apps</c> may also be empty, but <c>TotalCount</c> still indicates the total number of matching records.</description></item>
        /// <item><description>To authorize users for a specific application by application, pass the returned <c>AppInstanceGroupId</c>, <c>AppId</c>, and the same <c>ProductType</c> to <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a>. To view delivery group details, pass <c>AppInstanceGroupId</c> and <c>ProductType</c> to <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a>.
        /// The masked identities in the examples are for format demonstration purposes. Replace them with your actual identities when you invoke the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPublishedAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppsResponse
        /// </returns>
        public ListPublishedAppsResponse ListPublishedApps(ListPublishedAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublishedAppsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deployed applications in published delivery groups under the current Alibaba Cloud account for a specified product type by paging, and returns each application along with its delivery group and the number of authorized users by application. Supports filtering by delivery group, application, and user authorization status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When you call this operation by using a RAM user or Security Token Service (STS) credential, you must have the <c>appstreaming:ListPublishedApps</c> permission.
        /// Only delivery groups in the published state whose images contain deployed applications are included in the query results. This operation only queries information. It does not create delivery groups or grant or revoke application access permissions.</para>
        /// <h2>Response granularity</h2>
        /// <para>Results are returned on a per-delivery-group-plus-application basis. If the same application is deployed in multiple published delivery groups, a separate record is returned for each combination. <c>TotalCount</c> also reflects the number of such combinations. The list is sorted by the creation time of the delivery group in descending order.</para>
        /// <h2>Query and pagination</h2>
        /// <list type="bullet">
        /// <item><description><b>You must explicitly specify <c>ProductType</c>, <c>PageNumber</c>, and <c>PageSize</c>.</b> Page numbers start from <c>1</c>, and the page size ranges from <c>1</c> to <c>100</c>. Invalid values return error codes <c>InvalidParameter.PageNumber</c> and <c>InvalidParameter.PageSize</c>, respectively.</description></item>
        /// <item><description><c>AppInstanceGroupId</c>, <c>AppInstanceGroupName</c>, <c>AppId</c>, and <c>AppName</c> all support substring matching. You can specify them individually or in combination. When multiple conditions are specified, all conditions must be met.</description></item>
        /// <item><description>If an optional filter parameter is not specified or is set to an empty string, filtering is not applied for that condition.</description></item>
        /// <item><description><c>ExcludeUserId</c> excludes applications that have been authorized to the specified user by application, which helps you find applications that can still be authorized to that user. <b>Access permissions granted through delivery-group-level authorization or user groups are not evaluated by this condition.</b></description></item>
        /// </list>
        /// <h2>Invocation sequence</h2>
        /// <ol>
        /// <item><description>Initiate a query with <c>PageNumber=1</c> and the desired <c>PageSize</c>. For WUYING Cloud Application common scenarios, use <c>ProductType=CloudApp</c>.</description></item>
        /// <item><description>Read <c>Apps</c>. To retrieve the next page, increment <c>PageNumber</c> while keeping the product type and filter conditions unchanged. If no results match, <c>TotalCount</c> is <c>0</c> and <c>Apps</c> is an empty list. If the page number exceeds the result range, <c>Apps</c> may also be empty, but <c>TotalCount</c> still indicates the total number of matching records.</description></item>
        /// <item><description>To authorize users for a specific application by application, pass the returned <c>AppInstanceGroupId</c>, <c>AppId</c>, and the same <c>ProductType</c> to <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a>. To view delivery group details, pass <c>AppInstanceGroupId</c> and <c>ProductType</c> to <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a>.
        /// The masked identities in the examples are for format demonstration purposes. Replace them with your actual identities when you invoke the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPublishedAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAppsResponse
        /// </returns>
        public async Task<ListPublishedAppsResponse> ListPublishedAppsAsync(ListPublishedAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublishedAppsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions supported by WUYING Cloud Application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The regions returned by this operation are not all available regions. For information about available regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegionsWithOptions(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSource))
            {
                query["BizSource"] = request.BizSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions supported by WUYING Cloud Application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The regions returned by this operation are not all available regions. For information about available regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSource))
            {
                query["BizSource"] = request.BizSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions supported by WUYING Cloud Application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The regions returned by this operation are not all available regions. For information about available regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions supported by WUYING Cloud Application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The regions returned by this operation are not all available regions. For information about available regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of one or more specified cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagCloudResourcesResponse
        /// </returns>
        public ListTagCloudResourcesResponse ListTagCloudResourcesWithOptions(ListTagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagCloudResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of one or more specified cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagCloudResourcesResponse
        /// </returns>
        public async Task<ListTagCloudResourcesResponse> ListTagCloudResourcesWithOptionsAsync(ListTagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagCloudResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of one or more specified cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagCloudResourcesResponse
        /// </returns>
        public ListTagCloudResourcesResponse ListTagCloudResources(ListTagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagCloudResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of one or more specified cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagCloudResourcesResponse
        /// </returns>
        public async Task<ListTagCloudResourcesResponse> ListTagCloudResourcesAsync(ListTagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagCloudResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags bound to one or more delivery groups, or filters delivery groups that have specific tags bound by tag key-value pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation complies with the Alibaba Cloud tagging standard and is used to query tags bound to Elastic Cloud Application (China) delivery groups. You can query tags bound to resources by resource ID, or filter resources that have specific tags bound by tag key-value pairs.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>A delivery group is created. You can call the ListAppInstanceGroup operation to obtain the delivery group ID.</description></item>
        /// <item><description>Tags are bound to the delivery group. You can bind tags by calling the TagResources operation, or by using the console or the Tag service.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ResourceType is required</b>. Only <c>APPINSTANCEGROUP</c> (delivery group) is supported. If you specify other values, the error code <c>InvalidResourceType.Invalid</c> is returned.</description></item>
        /// <item><description><b>Specify at least one of ResourceId.N and Tag.N</b>. If neither is specified, the error code <c>MissingParameter.ResourceIdsOrTags</c> is returned.<list type="bullet">
        /// <item><description>If only ResourceId.N is specified: all tags attached to the specified resources are returned.</description></item>
        /// <item><description>If only Tag.N is specified: all resources that have the specified tags attached and their matching tags are returned.</description></item>
        /// <item><description>If both are specified: only records of the specified resources that have the specified tags attached are returned.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Tag.N.Key is required. If it is empty, the error code <c>InvalidTagPolicy.KeyInvalid</c> is returned. Tag.N.Value is optional. If it is not specified, the value of the tag key is not restricted, which means any tag value under the key is matched.</description></item>
        /// <item><description>Multiple Tag.N conditions have an AND relationship. A resource is returned only if it has all specified tags attached.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <list type="bullet">
        /// <item><description>Each record in the response corresponds to a resource-tag key-value pair. If a resource has multiple tags bound, multiple records are returned.</description></item>
        /// <item><description>TotalCount indicates the number of records returned.</description></item>
        /// <item><description>This operation returns all matching results at a time. An empty NextToken value indicates that no more data is available.</description></item>
        /// </list>
        /// <h2>Invocation sequence</h2>
        /// <ol>
        /// <item><description>Invoke the ListAppInstanceGroup operation to obtain the delivery group ID.</description></item>
        /// <item><description>Invoke the TagResources operation to attach tags to the delivery group.</description></item>
        /// <item><description>Invoke this operation to query tag bindings by resource ID or tag conditions.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags bound to one or more delivery groups, or filters delivery groups that have specific tags bound by tag key-value pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation complies with the Alibaba Cloud tagging standard and is used to query tags bound to Elastic Cloud Application (China) delivery groups. You can query tags bound to resources by resource ID, or filter resources that have specific tags bound by tag key-value pairs.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>A delivery group is created. You can call the ListAppInstanceGroup operation to obtain the delivery group ID.</description></item>
        /// <item><description>Tags are bound to the delivery group. You can bind tags by calling the TagResources operation, or by using the console or the Tag service.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ResourceType is required</b>. Only <c>APPINSTANCEGROUP</c> (delivery group) is supported. If you specify other values, the error code <c>InvalidResourceType.Invalid</c> is returned.</description></item>
        /// <item><description><b>Specify at least one of ResourceId.N and Tag.N</b>. If neither is specified, the error code <c>MissingParameter.ResourceIdsOrTags</c> is returned.<list type="bullet">
        /// <item><description>If only ResourceId.N is specified: all tags attached to the specified resources are returned.</description></item>
        /// <item><description>If only Tag.N is specified: all resources that have the specified tags attached and their matching tags are returned.</description></item>
        /// <item><description>If both are specified: only records of the specified resources that have the specified tags attached are returned.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Tag.N.Key is required. If it is empty, the error code <c>InvalidTagPolicy.KeyInvalid</c> is returned. Tag.N.Value is optional. If it is not specified, the value of the tag key is not restricted, which means any tag value under the key is matched.</description></item>
        /// <item><description>Multiple Tag.N conditions have an AND relationship. A resource is returned only if it has all specified tags attached.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <list type="bullet">
        /// <item><description>Each record in the response corresponds to a resource-tag key-value pair. If a resource has multiple tags bound, multiple records are returned.</description></item>
        /// <item><description>TotalCount indicates the number of records returned.</description></item>
        /// <item><description>This operation returns all matching results at a time. An empty NextToken value indicates that no more data is available.</description></item>
        /// </list>
        /// <h2>Invocation sequence</h2>
        /// <ol>
        /// <item><description>Invoke the ListAppInstanceGroup operation to obtain the delivery group ID.</description></item>
        /// <item><description>Invoke the TagResources operation to attach tags to the delivery group.</description></item>
        /// <item><description>Invoke this operation to query tag bindings by resource ID or tag conditions.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags bound to one or more delivery groups, or filters delivery groups that have specific tags bound by tag key-value pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation complies with the Alibaba Cloud tagging standard and is used to query tags bound to Elastic Cloud Application (China) delivery groups. You can query tags bound to resources by resource ID, or filter resources that have specific tags bound by tag key-value pairs.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>A delivery group is created. You can call the ListAppInstanceGroup operation to obtain the delivery group ID.</description></item>
        /// <item><description>Tags are bound to the delivery group. You can bind tags by calling the TagResources operation, or by using the console or the Tag service.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ResourceType is required</b>. Only <c>APPINSTANCEGROUP</c> (delivery group) is supported. If you specify other values, the error code <c>InvalidResourceType.Invalid</c> is returned.</description></item>
        /// <item><description><b>Specify at least one of ResourceId.N and Tag.N</b>. If neither is specified, the error code <c>MissingParameter.ResourceIdsOrTags</c> is returned.<list type="bullet">
        /// <item><description>If only ResourceId.N is specified: all tags attached to the specified resources are returned.</description></item>
        /// <item><description>If only Tag.N is specified: all resources that have the specified tags attached and their matching tags are returned.</description></item>
        /// <item><description>If both are specified: only records of the specified resources that have the specified tags attached are returned.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Tag.N.Key is required. If it is empty, the error code <c>InvalidTagPolicy.KeyInvalid</c> is returned. Tag.N.Value is optional. If it is not specified, the value of the tag key is not restricted, which means any tag value under the key is matched.</description></item>
        /// <item><description>Multiple Tag.N conditions have an AND relationship. A resource is returned only if it has all specified tags attached.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <list type="bullet">
        /// <item><description>Each record in the response corresponds to a resource-tag key-value pair. If a resource has multiple tags bound, multiple records are returned.</description></item>
        /// <item><description>TotalCount indicates the number of records returned.</description></item>
        /// <item><description>This operation returns all matching results at a time. An empty NextToken value indicates that no more data is available.</description></item>
        /// </list>
        /// <h2>Invocation sequence</h2>
        /// <ol>
        /// <item><description>Invoke the ListAppInstanceGroup operation to obtain the delivery group ID.</description></item>
        /// <item><description>Invoke the TagResources operation to attach tags to the delivery group.</description></item>
        /// <item><description>Invoke this operation to query tag bindings by resource ID or tag conditions.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags bound to one or more delivery groups, or filters delivery groups that have specific tags bound by tag key-value pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation complies with the Alibaba Cloud tagging standard and is used to query tags bound to Elastic Cloud Application (China) delivery groups. You can query tags bound to resources by resource ID, or filter resources that have specific tags bound by tag key-value pairs.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>A delivery group is created. You can call the ListAppInstanceGroup operation to obtain the delivery group ID.</description></item>
        /// <item><description>Tags are bound to the delivery group. You can bind tags by calling the TagResources operation, or by using the console or the Tag service.</description></item>
        /// </list>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description><b>ResourceType is required</b>. Only <c>APPINSTANCEGROUP</c> (delivery group) is supported. If you specify other values, the error code <c>InvalidResourceType.Invalid</c> is returned.</description></item>
        /// <item><description><b>Specify at least one of ResourceId.N and Tag.N</b>. If neither is specified, the error code <c>MissingParameter.ResourceIdsOrTags</c> is returned.<list type="bullet">
        /// <item><description>If only ResourceId.N is specified: all tags attached to the specified resources are returned.</description></item>
        /// <item><description>If only Tag.N is specified: all resources that have the specified tags attached and their matching tags are returned.</description></item>
        /// <item><description>If both are specified: only records of the specified resources that have the specified tags attached are returned.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Tag.N.Key is required. If it is empty, the error code <c>InvalidTagPolicy.KeyInvalid</c> is returned. Tag.N.Value is optional. If it is not specified, the value of the tag key is not restricted, which means any tag value under the key is matched.</description></item>
        /// <item><description>Multiple Tag.N conditions have an AND relationship. A resource is returned only if it has all specified tags attached.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <list type="bullet">
        /// <item><description>Each record in the response corresponds to a resource-tag key-value pair. If a resource has multiple tags bound, multiple records are returned.</description></item>
        /// <item><description>TotalCount indicates the number of records returned.</description></item>
        /// <item><description>This operation returns all matching results at a time. An empty NextToken value indicates that no more data is available.</description></item>
        /// </list>
        /// <h2>Invocation sequence</h2>
        /// <ol>
        /// <item><description>Invoke the ListAppInstanceGroup operation to obtain the delivery group ID.</description></item>
        /// <item><description>Invoke the TagResources operation to attach tags to the delivery group.</description></item>
        /// <item><description>Invoke this operation to query tag bindings by resource ID or tag conditions.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information of an administrator account, such as whether resource expiration reminders are enabled.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantConfigResponse
        /// </returns>
        public ListTenantConfigResponse ListTenantConfigWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information of an administrator account, such as whether resource expiration reminders are enabled.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantConfigResponse
        /// </returns>
        public async Task<ListTenantConfigResponse> ListTenantConfigWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information of an administrator account, such as whether resource expiration reminders are enabled.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTenantConfigResponse
        /// </returns>
        public ListTenantConfigResponse ListTenantConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTenantConfigWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information of an administrator account, such as whether resource expiration reminders are enabled.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTenantConfigResponse
        /// </returns>
        public async Task<ListTenantConfigResponse> ListTenantConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTenantConfigWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workstations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of WUYING workstations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWuyingServerResponse
        /// </returns>
        public ListWuyingServerResponse ListWuyingServerWithOptions(ListWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddVirtualNodePoolStatusList))
            {
                bodyFlat["AddVirtualNodePoolStatusList"] = request.AddVirtualNodePoolStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTimeEnd))
            {
                body["ExpiredTimeEnd"] = request.ExpiredTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTimeStart))
            {
                body["ExpiredTimeStart"] = request.ExpiredTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIp))
            {
                body["NetworkInterfaceIp"] = request.NetworkInterfaceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                body["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerInstanceType))
            {
                body["ServerInstanceType"] = request.ServerInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                bodyFlat["Users"] = request.Users;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodePoolId))
            {
                body["VirtualNodePoolId"] = request.VirtualNodePoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerIdList))
            {
                bodyFlat["WuyingServerIdList"] = request.WuyingServerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerNameOrId))
            {
                body["WuyingServerNameOrId"] = request.WuyingServerNameOrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWuyingServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workstations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of WUYING workstations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWuyingServerResponse
        /// </returns>
        public async Task<ListWuyingServerResponse> ListWuyingServerWithOptionsAsync(ListWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddVirtualNodePoolStatusList))
            {
                bodyFlat["AddVirtualNodePoolStatusList"] = request.AddVirtualNodePoolStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTimeEnd))
            {
                body["ExpiredTimeEnd"] = request.ExpiredTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTimeStart))
            {
                body["ExpiredTimeStart"] = request.ExpiredTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIp))
            {
                body["NetworkInterfaceIp"] = request.NetworkInterfaceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                body["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerInstanceType))
            {
                body["ServerInstanceType"] = request.ServerInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                bodyFlat["Users"] = request.Users;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodePoolId))
            {
                body["VirtualNodePoolId"] = request.VirtualNodePoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerIdList))
            {
                bodyFlat["WuyingServerIdList"] = request.WuyingServerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerNameOrId))
            {
                body["WuyingServerNameOrId"] = request.WuyingServerNameOrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWuyingServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workstations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of WUYING workstations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWuyingServerResponse
        /// </returns>
        public ListWuyingServerResponse ListWuyingServer(ListWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWuyingServerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workstations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of WUYING workstations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWuyingServerResponse
        /// </returns>
        public async Task<ListWuyingServerResponse> ListWuyingServerAsync(ListWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWuyingServerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available zone IDs for a specified region, product type, and operating system type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation returns the list of available zone IDs for the current Alibaba Cloud account based on the specified region, product type, and operating system type. A typical use case is to check which zones are available before creating a resource that requires a vSwitch, and then select a vSwitch in one of those zones.
        /// This operation only queries information. It does not create resources or incur fees.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>When calling this operation with a RAM user or STS credential, the <c>appstreaming:ListAppInstanceType</c> permission is required. If the permission is insufficient, the error code <c>Forbidden.NoPermission</c> is returned.</description></item>
        /// <item><description><b><c>ProductType</c>, <c>BizRegionId</c>, and <c>OsType</c> are all required.</b> If any of these parameters is missing, empty, or set to an unrecognized value, the error code <c>InvalidParameter.ValueInvalid</c> is returned.</description></item>
        /// <item><description><c>BizRegionId</c> must be a region ID supported by WUYING Cloud Application. Call <a href="~~ListRegions~~">ListRegions</a> first to obtain the supported region IDs.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListRegions~~">ListRegions</a> to obtain the supported region IDs.</description></item>
        /// <item><description>Call this operation with the region ID, target product type, and operating system type, and read the returned <c>ListZonesModel.Zones</c>.</description></item>
        /// <item><description>When creating a resource that requires a vSwitch, select a vSwitch in one of the returned zones. For example, pass the corresponding vSwitch ID when calling <a href="~~CreateAppInstanceGroup~~">CreateAppInstanceGroup</a> or <a href="~~CreateWuyingServer~~">CreateWuyingServer</a>.
        /// The returned zone list is determined by the available resources in the current region and may change over time. Query the list in real time before creating resources instead of caching it for extended periods.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListZonesResponse
        /// </returns>
        public ListZonesResponse ListZonesWithOptions(ListZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListZones",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available zone IDs for a specified region, product type, and operating system type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation returns the list of available zone IDs for the current Alibaba Cloud account based on the specified region, product type, and operating system type. A typical use case is to check which zones are available before creating a resource that requires a vSwitch, and then select a vSwitch in one of those zones.
        /// This operation only queries information. It does not create resources or incur fees.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>When calling this operation with a RAM user or STS credential, the <c>appstreaming:ListAppInstanceType</c> permission is required. If the permission is insufficient, the error code <c>Forbidden.NoPermission</c> is returned.</description></item>
        /// <item><description><b><c>ProductType</c>, <c>BizRegionId</c>, and <c>OsType</c> are all required.</b> If any of these parameters is missing, empty, or set to an unrecognized value, the error code <c>InvalidParameter.ValueInvalid</c> is returned.</description></item>
        /// <item><description><c>BizRegionId</c> must be a region ID supported by WUYING Cloud Application. Call <a href="~~ListRegions~~">ListRegions</a> first to obtain the supported region IDs.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListRegions~~">ListRegions</a> to obtain the supported region IDs.</description></item>
        /// <item><description>Call this operation with the region ID, target product type, and operating system type, and read the returned <c>ListZonesModel.Zones</c>.</description></item>
        /// <item><description>When creating a resource that requires a vSwitch, select a vSwitch in one of the returned zones. For example, pass the corresponding vSwitch ID when calling <a href="~~CreateAppInstanceGroup~~">CreateAppInstanceGroup</a> or <a href="~~CreateWuyingServer~~">CreateWuyingServer</a>.
        /// The returned zone list is determined by the available resources in the current region and may change over time. Query the list in real time before creating resources instead of caching it for extended periods.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListZonesResponse
        /// </returns>
        public async Task<ListZonesResponse> ListZonesWithOptionsAsync(ListZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListZones",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available zone IDs for a specified region, product type, and operating system type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation returns the list of available zone IDs for the current Alibaba Cloud account based on the specified region, product type, and operating system type. A typical use case is to check which zones are available before creating a resource that requires a vSwitch, and then select a vSwitch in one of those zones.
        /// This operation only queries information. It does not create resources or incur fees.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>When calling this operation with a RAM user or STS credential, the <c>appstreaming:ListAppInstanceType</c> permission is required. If the permission is insufficient, the error code <c>Forbidden.NoPermission</c> is returned.</description></item>
        /// <item><description><b><c>ProductType</c>, <c>BizRegionId</c>, and <c>OsType</c> are all required.</b> If any of these parameters is missing, empty, or set to an unrecognized value, the error code <c>InvalidParameter.ValueInvalid</c> is returned.</description></item>
        /// <item><description><c>BizRegionId</c> must be a region ID supported by WUYING Cloud Application. Call <a href="~~ListRegions~~">ListRegions</a> first to obtain the supported region IDs.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListRegions~~">ListRegions</a> to obtain the supported region IDs.</description></item>
        /// <item><description>Call this operation with the region ID, target product type, and operating system type, and read the returned <c>ListZonesModel.Zones</c>.</description></item>
        /// <item><description>When creating a resource that requires a vSwitch, select a vSwitch in one of the returned zones. For example, pass the corresponding vSwitch ID when calling <a href="~~CreateAppInstanceGroup~~">CreateAppInstanceGroup</a> or <a href="~~CreateWuyingServer~~">CreateWuyingServer</a>.
        /// The returned zone list is determined by the available resources in the current region and may change over time. Query the list in real time before creating resources instead of caching it for extended periods.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListZonesResponse
        /// </returns>
        public ListZonesResponse ListZones(ListZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available zone IDs for a specified region, product type, and operating system type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation returns the list of available zone IDs for the current Alibaba Cloud account based on the specified region, product type, and operating system type. A typical use case is to check which zones are available before creating a resource that requires a vSwitch, and then select a vSwitch in one of those zones.
        /// This operation only queries information. It does not create resources or incur fees.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>When calling this operation with a RAM user or STS credential, the <c>appstreaming:ListAppInstanceType</c> permission is required. If the permission is insufficient, the error code <c>Forbidden.NoPermission</c> is returned.</description></item>
        /// <item><description><b><c>ProductType</c>, <c>BizRegionId</c>, and <c>OsType</c> are all required.</b> If any of these parameters is missing, empty, or set to an unrecognized value, the error code <c>InvalidParameter.ValueInvalid</c> is returned.</description></item>
        /// <item><description><c>BizRegionId</c> must be a region ID supported by WUYING Cloud Application. Call <a href="~~ListRegions~~">ListRegions</a> first to obtain the supported region IDs.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListRegions~~">ListRegions</a> to obtain the supported region IDs.</description></item>
        /// <item><description>Call this operation with the region ID, target product type, and operating system type, and read the returned <c>ListZonesModel.Zones</c>.</description></item>
        /// <item><description>When creating a resource that requires a vSwitch, select a vSwitch in one of the returned zones. For example, pass the corresponding vSwitch ID when calling <a href="~~CreateAppInstanceGroup~~">CreateAppInstanceGroup</a> or <a href="~~CreateWuyingServer~~">CreateWuyingServer</a>.
        /// The returned zone list is determined by the available resources in the current region and may change over time. Query the list in real time before creating resources instead of caching it for extended periods.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ListZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListZonesResponse
        /// </returns>
        public async Task<ListZonesResponse> ListZonesAsync(ListZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs off all sessions in a pay-as-you-go delivery group that has scheduled auto scaling enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation applies only to pay-as-you-go resource delivery groups that have scheduled auto scaling enabled. The operation can be called only outside the scaling time periods specified in the scheduled auto scaling policy.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LogOffAllSessionsInAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LogOffAllSessionsInAppInstanceGroupResponse
        /// </returns>
        public LogOffAllSessionsInAppInstanceGroupResponse LogOffAllSessionsInAppInstanceGroupWithOptions(LogOffAllSessionsInAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogOffAllSessionsInAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogOffAllSessionsInAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs off all sessions in a pay-as-you-go delivery group that has scheduled auto scaling enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation applies only to pay-as-you-go resource delivery groups that have scheduled auto scaling enabled. The operation can be called only outside the scaling time periods specified in the scheduled auto scaling policy.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LogOffAllSessionsInAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LogOffAllSessionsInAppInstanceGroupResponse
        /// </returns>
        public async Task<LogOffAllSessionsInAppInstanceGroupResponse> LogOffAllSessionsInAppInstanceGroupWithOptionsAsync(LogOffAllSessionsInAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogOffAllSessionsInAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogOffAllSessionsInAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs off all sessions in a pay-as-you-go delivery group that has scheduled auto scaling enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation applies only to pay-as-you-go resource delivery groups that have scheduled auto scaling enabled. The operation can be called only outside the scaling time periods specified in the scheduled auto scaling policy.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LogOffAllSessionsInAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// LogOffAllSessionsInAppInstanceGroupResponse
        /// </returns>
        public LogOffAllSessionsInAppInstanceGroupResponse LogOffAllSessionsInAppInstanceGroup(LogOffAllSessionsInAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LogOffAllSessionsInAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs off all sessions in a pay-as-you-go delivery group that has scheduled auto scaling enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation applies only to pay-as-you-go resource delivery groups that have scheduled auto scaling enabled. The operation can be called only outside the scaling time periods specified in the scheduled auto scaling policy.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LogOffAllSessionsInAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// LogOffAllSessionsInAppInstanceGroupResponse
        /// </returns>
        public async Task<LogOffAllSessionsInAppInstanceGroupResponse> LogOffAllSessionsInAppInstanceGroupAsync(LogOffAllSessionsInAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LogOffAllSessionsInAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the General Policy of a delivery group, including the number of concurrent sessions and the session retention duration after disconnection.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppInstanceGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceGroupAttributeResponse
        /// </returns>
        public ModifyAppInstanceGroupAttributeResponse ModifyAppInstanceGroupAttributeWithOptions(ModifyAppInstanceGroupAttributeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppInstanceGroupAttributeShrinkRequest request = new ModifyAppInstanceGroupAttributeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                query["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerSessionPerApp))
            {
                body["PerSessionPerApp"] = request.PerSessionPerApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenAppId))
            {
                body["PreOpenAppId"] = request.PreOpenAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenMode))
            {
                body["PreOpenMode"] = request.PreOpenMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppInstanceGroupAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppInstanceGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the General Policy of a delivery group, including the number of concurrent sessions and the session retention duration after disconnection.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppInstanceGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceGroupAttributeResponse
        /// </returns>
        public async Task<ModifyAppInstanceGroupAttributeResponse> ModifyAppInstanceGroupAttributeWithOptionsAsync(ModifyAppInstanceGroupAttributeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppInstanceGroupAttributeShrinkRequest request = new ModifyAppInstanceGroupAttributeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                query["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerSessionPerApp))
            {
                body["PerSessionPerApp"] = request.PerSessionPerApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenAppId))
            {
                body["PreOpenAppId"] = request.PreOpenAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenMode))
            {
                body["PreOpenMode"] = request.PreOpenMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppInstanceGroupAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppInstanceGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the General Policy of a delivery group, including the number of concurrent sessions and the session retention duration after disconnection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppInstanceGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceGroupAttributeResponse
        /// </returns>
        public ModifyAppInstanceGroupAttributeResponse ModifyAppInstanceGroupAttribute(ModifyAppInstanceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppInstanceGroupAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the General Policy of a delivery group, including the number of concurrent sessions and the session retention duration after disconnection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppInstanceGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceGroupAttributeResponse
        /// </returns>
        public async Task<ModifyAppInstanceGroupAttributeResponse> ModifyAppInstanceGroupAttributeAsync(ModifyAppInstanceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppInstanceGroupAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the display policy of a delivery group, including settings such as frame rate, resolution, and protocol type.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppPolicyResponse
        /// </returns>
        public ModifyAppPolicyResponse ModifyAppPolicyWithOptions(ModifyAppPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppPolicyShrinkRequest request = new ModifyAppPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoPolicy))
            {
                request.VideoPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoPolicy, "VideoPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                query["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPolicyShrink))
            {
                query["VideoPolicy"] = request.VideoPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppPolicy",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the display policy of a delivery group, including settings such as frame rate, resolution, and protocol type.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppPolicyResponse
        /// </returns>
        public async Task<ModifyAppPolicyResponse> ModifyAppPolicyWithOptionsAsync(ModifyAppPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppPolicyShrinkRequest request = new ModifyAppPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoPolicy))
            {
                request.VideoPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoPolicy, "VideoPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                query["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPolicyShrink))
            {
                query["VideoPolicy"] = request.VideoPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppPolicy",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the display policy of a delivery group, including settings such as frame rate, resolution, and protocol type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppPolicyResponse
        /// </returns>
        public ModifyAppPolicyResponse ModifyAppPolicy(ModifyAppPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the display policy of a delivery group, including settings such as frame rate, resolution, and protocol type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppPolicyResponse
        /// </returns>
        public async Task<ModifyAppPolicyResponse> ModifyAppPolicyAsync(ModifyAppPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a Wuying Cloud Browser.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the attributes of a Wuying Cloud Browser.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyBrowserInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBrowserInstanceGroupResponse
        /// </returns>
        public ModifyBrowserInstanceGroupResponse ModifyBrowserInstanceGroupWithOptions(ModifyBrowserInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBrowserInstanceGroupShrinkRequest request = new ModifyBrowserInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BrowserConfig))
            {
                request.BrowserConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BrowserConfig, "BrowserConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Timers))
            {
                request.TimersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Timers, "Timers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserConfigShrink))
            {
                query["BrowserConfig"] = request.BrowserConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserInstanceGroupId))
            {
                query["BrowserInstanceGroupId"] = request.BrowserInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                query["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimersShrink))
            {
                query["Timers"] = request.TimersShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthNotificationEnabled))
            {
                body["AuthNotificationEnabled"] = request.AuthNotificationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudBrowserName))
            {
                body["CloudBrowserName"] = request.CloudBrowserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAmount))
            {
                body["MaxAmount"] = request.MaxAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBrowserInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBrowserInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a Wuying Cloud Browser.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the attributes of a Wuying Cloud Browser.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyBrowserInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBrowserInstanceGroupResponse
        /// </returns>
        public async Task<ModifyBrowserInstanceGroupResponse> ModifyBrowserInstanceGroupWithOptionsAsync(ModifyBrowserInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBrowserInstanceGroupShrinkRequest request = new ModifyBrowserInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BrowserConfig))
            {
                request.BrowserConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BrowserConfig, "BrowserConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Timers))
            {
                request.TimersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Timers, "Timers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserConfigShrink))
            {
                query["BrowserConfig"] = request.BrowserConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserInstanceGroupId))
            {
                query["BrowserInstanceGroupId"] = request.BrowserInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                query["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimersShrink))
            {
                query["Timers"] = request.TimersShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthNotificationEnabled))
            {
                body["AuthNotificationEnabled"] = request.AuthNotificationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudBrowserName))
            {
                body["CloudBrowserName"] = request.CloudBrowserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAmount))
            {
                body["MaxAmount"] = request.MaxAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBrowserInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBrowserInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a Wuying Cloud Browser.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the attributes of a Wuying Cloud Browser.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyBrowserInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBrowserInstanceGroupResponse
        /// </returns>
        public ModifyBrowserInstanceGroupResponse ModifyBrowserInstanceGroup(ModifyBrowserInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBrowserInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a Wuying Cloud Browser.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the attributes of a Wuying Cloud Browser.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyBrowserInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBrowserInstanceGroupResponse
        /// </returns>
        public async Task<ModifyBrowserInstanceGroupResponse> ModifyBrowserInstanceGroupAsync(ModifyBrowserInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBrowserInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the number of nodes in a subscription delivery group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyNodePoolAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAmountResponse
        /// </returns>
        public ModifyNodePoolAmountResponse ModifyNodePoolAmountWithOptions(ModifyNodePoolAmountRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNodePoolAmountShrinkRequest request = new ModifyNodePoolAmountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodePoolAmount",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodePoolAmountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the number of nodes in a subscription delivery group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyNodePoolAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAmountResponse
        /// </returns>
        public async Task<ModifyNodePoolAmountResponse> ModifyNodePoolAmountWithOptionsAsync(ModifyNodePoolAmountRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNodePoolAmountShrinkRequest request = new ModifyNodePoolAmountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodePoolAmount",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodePoolAmountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the number of nodes in a subscription delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNodePoolAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAmountResponse
        /// </returns>
        public ModifyNodePoolAmountResponse ModifyNodePoolAmount(ModifyNodePoolAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNodePoolAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the number of nodes in a subscription delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNodePoolAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAmountResponse
        /// </returns>
        public async Task<ModifyNodePoolAmountResponse> ModifyNodePoolAmountAsync(ModifyNodePoolAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNodePoolAmountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the elastic mode of a delivery group, including fixed quantity (no elastic scaling), scheduled scaling, and automatic scaling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure the elastic pattern for WUYING Cloud Application resources in Settings:</para>
        /// <list type="bullet">
        /// <item><description>Fixed quantity: Elastic scaling is not used.</description></item>
        /// <item><description>Automatic scaling: Automatically scales resources based on the number of connected sessions and the duration without session connections.</description></item>
        /// <item><description>Scheduled scaling: Executes resource scaling during specified time periods on specified dates.
        /// Before using this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing method and pricing</a> of WUYING Cloud Application.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyNodePoolAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAttributeResponse
        /// </returns>
        public ModifyNodePoolAttributeResponse ModifyNodePoolAttributeWithOptions(ModifyNodePoolAttributeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNodePoolAttributeShrinkRequest request = new ModifyNodePoolAttributeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePoolStrategy))
            {
                request.NodePoolStrategyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePoolStrategy, "NodePoolStrategy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCapacity))
            {
                body["NodeCapacity"] = request.NodeCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolStrategyShrink))
            {
                body["NodePoolStrategy"] = request.NodePoolStrategyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolId))
            {
                body["PoolId"] = request.PoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodePoolAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodePoolAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the elastic mode of a delivery group, including fixed quantity (no elastic scaling), scheduled scaling, and automatic scaling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure the elastic pattern for WUYING Cloud Application resources in Settings:</para>
        /// <list type="bullet">
        /// <item><description>Fixed quantity: Elastic scaling is not used.</description></item>
        /// <item><description>Automatic scaling: Automatically scales resources based on the number of connected sessions and the duration without session connections.</description></item>
        /// <item><description>Scheduled scaling: Executes resource scaling during specified time periods on specified dates.
        /// Before using this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing method and pricing</a> of WUYING Cloud Application.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyNodePoolAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAttributeResponse
        /// </returns>
        public async Task<ModifyNodePoolAttributeResponse> ModifyNodePoolAttributeWithOptionsAsync(ModifyNodePoolAttributeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNodePoolAttributeShrinkRequest request = new ModifyNodePoolAttributeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePoolStrategy))
            {
                request.NodePoolStrategyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePoolStrategy, "NodePoolStrategy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCapacity))
            {
                body["NodeCapacity"] = request.NodeCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolStrategyShrink))
            {
                body["NodePoolStrategy"] = request.NodePoolStrategyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolId))
            {
                body["PoolId"] = request.PoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodePoolAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodePoolAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the elastic mode of a delivery group, including fixed quantity (no elastic scaling), scheduled scaling, and automatic scaling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure the elastic pattern for WUYING Cloud Application resources in Settings:</para>
        /// <list type="bullet">
        /// <item><description>Fixed quantity: Elastic scaling is not used.</description></item>
        /// <item><description>Automatic scaling: Automatically scales resources based on the number of connected sessions and the duration without session connections.</description></item>
        /// <item><description>Scheduled scaling: Executes resource scaling during specified time periods on specified dates.
        /// Before using this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing method and pricing</a> of WUYING Cloud Application.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodePoolAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAttributeResponse
        /// </returns>
        public ModifyNodePoolAttributeResponse ModifyNodePoolAttribute(ModifyNodePoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNodePoolAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the elastic mode of a delivery group, including fixed quantity (no elastic scaling), scheduled scaling, and automatic scaling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure the elastic pattern for WUYING Cloud Application resources in Settings:</para>
        /// <list type="bullet">
        /// <item><description>Fixed quantity: Elastic scaling is not used.</description></item>
        /// <item><description>Automatic scaling: Automatically scales resources based on the number of connected sessions and the duration without session connections.</description></item>
        /// <item><description>Scheduled scaling: Executes resource scaling during specified time periods on specified dates.
        /// Before using this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing method and pricing</a> of WUYING Cloud Application.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodePoolAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAttributeResponse
        /// </returns>
        public async Task<ModifyNodePoolAttributeResponse> ModifyNodePoolAttributeAsync(ModifyNodePoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNodePoolAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the administrator account configuration, such as whether to enable resource expiration reminders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTenantConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTenantConfigResponse
        /// </returns>
        public ModifyTenantConfigResponse ModifyTenantConfigWithOptions(ModifyTenantConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupExpireRemind))
            {
                body["AppInstanceGroupExpireRemind"] = request.AppInstanceGroupExpireRemind;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the administrator account configuration, such as whether to enable resource expiration reminders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTenantConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTenantConfigResponse
        /// </returns>
        public async Task<ModifyTenantConfigResponse> ModifyTenantConfigWithOptionsAsync(ModifyTenantConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupExpireRemind))
            {
                body["AppInstanceGroupExpireRemind"] = request.AppInstanceGroupExpireRemind;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the administrator account configuration, such as whether to enable resource expiration reminders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTenantConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTenantConfigResponse
        /// </returns>
        public ModifyTenantConfigResponse ModifyTenantConfig(ModifyTenantConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the administrator account configuration, such as whether to enable resource expiration reminders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTenantConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTenantConfigResponse
        /// </returns>
        public async Task<ModifyTenantConfigResponse> ModifyTenantConfigAsync(ModifyTenantConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the properties of a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyWuyingServerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyWuyingServerAttributeResponse
        /// </returns>
        public ModifyWuyingServerAttributeResponse ModifyWuyingServerAttributeWithOptions(ModifyWuyingServerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErdmaEnabled))
            {
                body["ErdmaEnabled"] = request.ErdmaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerName))
            {
                body["WuyingServerName"] = request.WuyingServerName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyWuyingServerAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWuyingServerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the properties of a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyWuyingServerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyWuyingServerAttributeResponse
        /// </returns>
        public async Task<ModifyWuyingServerAttributeResponse> ModifyWuyingServerAttributeWithOptionsAsync(ModifyWuyingServerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErdmaEnabled))
            {
                body["ErdmaEnabled"] = request.ErdmaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerName))
            {
                body["WuyingServerName"] = request.WuyingServerName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyWuyingServerAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWuyingServerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the properties of a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyWuyingServerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyWuyingServerAttributeResponse
        /// </returns>
        public ModifyWuyingServerAttributeResponse ModifyWuyingServerAttribute(ModifyWuyingServerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWuyingServerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the properties of a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyWuyingServerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyWuyingServerAttributeResponse
        /// </returns>
        public async Task<ModifyWuyingServerAttributeResponse> ModifyWuyingServerAttributeAsync(ModifyWuyingServerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWuyingServerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the allocated users added to a delivery group by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListAppInstanceGroupUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListAppInstanceGroupUserResponse
        /// </returns>
        public PageListAppInstanceGroupUserResponse PageListAppInstanceGroupUserWithOptions(PageListAppInstanceGroupUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListAppInstanceGroupUser",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListAppInstanceGroupUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the allocated users added to a delivery group by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListAppInstanceGroupUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListAppInstanceGroupUserResponse
        /// </returns>
        public async Task<PageListAppInstanceGroupUserResponse> PageListAppInstanceGroupUserWithOptionsAsync(PageListAppInstanceGroupUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListAppInstanceGroupUser",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListAppInstanceGroupUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the allocated users added to a delivery group by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListAppInstanceGroupUserRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListAppInstanceGroupUserResponse
        /// </returns>
        public PageListAppInstanceGroupUserResponse PageListAppInstanceGroupUser(PageListAppInstanceGroupUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageListAppInstanceGroupUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the allocated users added to a delivery group by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListAppInstanceGroupUserRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListAppInstanceGroupUserResponse
        /// </returns>
        public async Task<PageListAppInstanceGroupUserResponse> PageListAppInstanceGroupUserAsync(PageListAppInstanceGroupUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageListAppInstanceGroupUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes model groups from a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can authorize model groups for resources that belong to Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. These model groups serve as inference engines for Agents to execute tasks within the resource group.
        /// When an Agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting has a higher priority than the Agent runtime setting.
        /// When you remove the model group from the resource group to which an Agent runtime belongs, the model group configured on the Agent runtime itself automatically takes effect.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveResourceGroupModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveResourceGroupModelTemplateResponse
        /// </returns>
        public RemoveResourceGroupModelTemplateResponse RemoveResourceGroupModelTemplateWithOptions(RemoveResourceGroupModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                body["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveResourceGroupModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveResourceGroupModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes model groups from a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can authorize model groups for resources that belong to Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. These model groups serve as inference engines for Agents to execute tasks within the resource group.
        /// When an Agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting has a higher priority than the Agent runtime setting.
        /// When you remove the model group from the resource group to which an Agent runtime belongs, the model group configured on the Agent runtime itself automatically takes effect.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveResourceGroupModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveResourceGroupModelTemplateResponse
        /// </returns>
        public async Task<RemoveResourceGroupModelTemplateResponse> RemoveResourceGroupModelTemplateWithOptionsAsync(RemoveResourceGroupModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                body["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveResourceGroupModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveResourceGroupModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes model groups from a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can authorize model groups for resources that belong to Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. These model groups serve as inference engines for Agents to execute tasks within the resource group.
        /// When an Agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting has a higher priority than the Agent runtime setting.
        /// When you remove the model group from the resource group to which an Agent runtime belongs, the model group configured on the Agent runtime itself automatically takes effect.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveResourceGroupModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveResourceGroupModelTemplateResponse
        /// </returns>
        public RemoveResourceGroupModelTemplateResponse RemoveResourceGroupModelTemplate(RemoveResourceGroupModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveResourceGroupModelTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes model groups from a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can authorize model groups for resources that belong to Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. These model groups serve as inference engines for Agents to execute tasks within the resource group.
        /// When an Agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting has a higher priority than the Agent runtime setting.
        /// When you remove the model group from the resource group to which an Agent runtime belongs, the model group configured on the Agent runtime itself automatically takes effect.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveResourceGroupModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveResourceGroupModelTemplateResponse
        /// </returns>
        public async Task<RemoveResourceGroupModelTemplateResponse> RemoveResourceGroupModelTemplateAsync(RemoveResourceGroupModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveResourceGroupModelTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a third-party channel configuration from the Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove a specific third-party channel configuration from Agents such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. After the removal, the Agent cannot use the third-party channel for conversations.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveRuntimeChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveRuntimeChannelResponse
        /// </returns>
        public RemoveRuntimeChannelResponse RemoveRuntimeChannelWithOptions(RemoveRuntimeChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                body["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                body["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeIds))
            {
                body["RuntimeIds"] = request.RuntimeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveRuntimeChannel",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveRuntimeChannelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a third-party channel configuration from the Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove a specific third-party channel configuration from Agents such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. After the removal, the Agent cannot use the third-party channel for conversations.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveRuntimeChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveRuntimeChannelResponse
        /// </returns>
        public async Task<RemoveRuntimeChannelResponse> RemoveRuntimeChannelWithOptionsAsync(RemoveRuntimeChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPlatform))
            {
                body["AgentPlatform"] = request.AgentPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                body["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeIds))
            {
                body["RuntimeIds"] = request.RuntimeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveRuntimeChannel",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveRuntimeChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a third-party channel configuration from the Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove a specific third-party channel configuration from Agents such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. After the removal, the Agent cannot use the third-party channel for conversations.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveRuntimeChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveRuntimeChannelResponse
        /// </returns>
        public RemoveRuntimeChannelResponse RemoveRuntimeChannel(RemoveRuntimeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveRuntimeChannelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a third-party channel configuration from the Agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove a specific third-party channel configuration from Agents such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. After the removal, the Agent cannot use the third-party channel for conversations.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveRuntimeChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveRuntimeChannelResponse
        /// </returns>
        public async Task<RemoveRuntimeChannelResponse> RemoveRuntimeChannelAsync(RemoveRuntimeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveRuntimeChannelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a model group from an Agent runtime resource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can remove model groups from Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. When an Agent runtime resource needs to switch to a different model group, call this operation first to remove the authorization relationship between the Agent runtime resource and the existing model group.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveRuntimeModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveRuntimeModelTemplateResponse
        /// </returns>
        public RemoveRuntimeModelTemplateResponse RemoveRuntimeModelTemplateWithOptions(RemoveRuntimeModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeIds))
            {
                body["RuntimeIds"] = request.RuntimeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveRuntimeModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveRuntimeModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a model group from an Agent runtime resource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can remove model groups from Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. When an Agent runtime resource needs to switch to a different model group, call this operation first to remove the authorization relationship between the Agent runtime resource and the existing model group.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveRuntimeModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveRuntimeModelTemplateResponse
        /// </returns>
        public async Task<RemoveRuntimeModelTemplateResponse> RemoveRuntimeModelTemplateWithOptionsAsync(RemoveRuntimeModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                body["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeIds))
            {
                body["RuntimeIds"] = request.RuntimeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["RuntimeType"] = request.RuntimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveRuntimeModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveRuntimeModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a model group from an Agent runtime resource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can remove model groups from Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. When an Agent runtime resource needs to switch to a different model group, call this operation first to remove the authorization relationship between the Agent runtime resource and the existing model group.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveRuntimeModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveRuntimeModelTemplateResponse
        /// </returns>
        public RemoveRuntimeModelTemplateResponse RemoveRuntimeModelTemplate(RemoveRuntimeModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveRuntimeModelTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a model group from an Agent runtime resource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can remove model groups from Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. When an Agent runtime resource needs to switch to a different model group, call this operation first to remove the authorization relationship between the Agent runtime resource and the existing model group.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveRuntimeModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveRuntimeModelTemplateResponse
        /// </returns>
        public async Task<RemoveRuntimeModelTemplateResponse> RemoveRuntimeModelTemplateAsync(RemoveRuntimeModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveRuntimeModelTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING Workspace.</para>
        /// <remarks>
        /// <para>Prerequisites:</para>
        /// <list type="bullet">
        /// <item><description>The delivery group must be in the PUBLISHED state, and ChargeType must be set to PrePaid.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RenewAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewAppInstanceGroupResponse
        /// </returns>
        public RenewAppInstanceGroupResponse RenewAppInstanceGroupWithOptions(RenewAppInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RenewAppInstanceGroupShrinkRequest request = new RenewAppInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RenewNodes))
            {
                request.RenewNodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RenewNodes, "RenewNodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                query["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewAmount))
            {
                query["RenewAmount"] = request.RenewAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewMode))
            {
                query["RenewMode"] = request.RenewMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewNodesShrink))
            {
                query["RenewNodes"] = request.RenewNodesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING Workspace.</para>
        /// <remarks>
        /// <para>Prerequisites:</para>
        /// <list type="bullet">
        /// <item><description>The delivery group must be in the PUBLISHED state, and ChargeType must be set to PrePaid.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RenewAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewAppInstanceGroupResponse
        /// </returns>
        public async Task<RenewAppInstanceGroupResponse> RenewAppInstanceGroupWithOptionsAsync(RenewAppInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RenewAppInstanceGroupShrinkRequest request = new RenewAppInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RenewNodes))
            {
                request.RenewNodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RenewNodes, "RenewNodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                query["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewAmount))
            {
                query["RenewAmount"] = request.RenewAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewMode))
            {
                query["RenewMode"] = request.RenewMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewNodesShrink))
            {
                query["RenewNodes"] = request.RenewNodesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING Workspace.</para>
        /// <remarks>
        /// <para>Prerequisites:</para>
        /// <list type="bullet">
        /// <item><description>The delivery group must be in the PUBLISHED state, and ChargeType must be set to PrePaid.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewAppInstanceGroupResponse
        /// </returns>
        public RenewAppInstanceGroupResponse RenewAppInstanceGroup(RenewAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING Workspace.</para>
        /// <remarks>
        /// <para>Prerequisites:</para>
        /// <list type="bullet">
        /// <item><description>The delivery group must be in the PUBLISHED state, and ChargeType must be set to PrePaid.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewAppInstanceGroupResponse
        /// </returns>
        public async Task<RenewAppInstanceGroupResponse> RenewAppInstanceGroupAsync(RenewAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewWuyingServerResponse
        /// </returns>
        public RenewWuyingServerResponse RenewWuyingServerWithOptions(RenewWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewWuyingServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewWuyingServerResponse
        /// </returns>
        public async Task<RenewWuyingServerResponse> RenewWuyingServerWithOptionsAsync(RenewWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewWuyingServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewWuyingServerResponse
        /// </returns>
        public RenewWuyingServerResponse RenewWuyingServer(RenewWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewWuyingServerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewWuyingServerResponse
        /// </returns>
        public async Task<RenewWuyingServerResponse> RenewWuyingServerAsync(RenewWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewWuyingServerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartWuyingServerResponse
        /// </returns>
        public RestartWuyingServerResponse RestartWuyingServerWithOptions(RestartWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerIdList))
            {
                bodyFlat["WuyingServerIdList"] = request.WuyingServerIdList;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartWuyingServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartWuyingServerResponse
        /// </returns>
        public async Task<RestartWuyingServerResponse> RestartWuyingServerWithOptionsAsync(RestartWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerIdList))
            {
                bodyFlat["WuyingServerIdList"] = request.WuyingServerIdList;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartWuyingServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartWuyingServerResponse
        /// </returns>
        public RestartWuyingServerResponse RestartWuyingServer(RestartWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartWuyingServerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartWuyingServerResponse
        /// </returns>
        public async Task<RestartWuyingServerResponse> RestartWuyingServerAsync(RestartWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartWuyingServerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a task to copy an image to other regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTaskForDistributeImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTaskForDistributeImageResponse
        /// </returns>
        public StartTaskForDistributeImageResponse StartTaskForDistributeImageWithOptions(StartTaskForDistributeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegionList))
            {
                body["DestinationRegionList"] = request.DestinationRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryType))
            {
                body["RetryType"] = request.RetryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegion))
            {
                body["SourceRegion"] = request.SourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTaskForDistributeImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTaskForDistributeImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a task to copy an image to other regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTaskForDistributeImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTaskForDistributeImageResponse
        /// </returns>
        public async Task<StartTaskForDistributeImageResponse> StartTaskForDistributeImageWithOptionsAsync(StartTaskForDistributeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegionList))
            {
                body["DestinationRegionList"] = request.DestinationRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryType))
            {
                body["RetryType"] = request.RetryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegion))
            {
                body["SourceRegion"] = request.SourceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTaskForDistributeImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTaskForDistributeImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a task to copy an image to other regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTaskForDistributeImageRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTaskForDistributeImageResponse
        /// </returns>
        public StartTaskForDistributeImageResponse StartTaskForDistributeImage(StartTaskForDistributeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartTaskForDistributeImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a task to copy an image to other regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTaskForDistributeImageRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTaskForDistributeImageResponse
        /// </returns>
        public async Task<StartTaskForDistributeImageResponse> StartTaskForDistributeImageAsync(StartTaskForDistributeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartTaskForDistributeImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartWuyingServerResponse
        /// </returns>
        public StartWuyingServerResponse StartWuyingServerWithOptions(StartWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerIdList))
            {
                bodyFlat["WuyingServerIdList"] = request.WuyingServerIdList;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartWuyingServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartWuyingServerResponse
        /// </returns>
        public async Task<StartWuyingServerResponse> StartWuyingServerWithOptionsAsync(StartWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerIdList))
            {
                bodyFlat["WuyingServerIdList"] = request.WuyingServerIdList;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartWuyingServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// StartWuyingServerResponse
        /// </returns>
        public StartWuyingServerResponse StartWuyingServer(StartWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartWuyingServerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// StartWuyingServerResponse
        /// </returns>
        public async Task<StartWuyingServerResponse> StartWuyingServerAsync(StartWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartWuyingServerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopWuyingServerResponse
        /// </returns>
        public StopWuyingServerResponse StopWuyingServerWithOptions(StopWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerIdList))
            {
                bodyFlat["WuyingServerIdList"] = request.WuyingServerIdList;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopWuyingServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopWuyingServerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopWuyingServerResponse
        /// </returns>
        public async Task<StopWuyingServerResponse> StopWuyingServerWithOptionsAsync(StopWuyingServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerIdList))
            {
                bodyFlat["WuyingServerIdList"] = request.WuyingServerIdList;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopWuyingServer",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopWuyingServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// StopWuyingServerResponse
        /// </returns>
        public StopWuyingServerResponse StopWuyingServer(StopWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopWuyingServerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a workstation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopWuyingServerRequest
        /// </param>
        /// 
        /// <returns>
        /// StopWuyingServerResponse
        /// </returns>
        public async Task<StopWuyingServerResponse> StopWuyingServerAsync(StopWuyingServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopWuyingServerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and attaches tags to cloud resources. For resources that already have the specified tags, updates the tag values.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagCloudResourcesResponse
        /// </returns>
        public TagCloudResourcesResponse TagCloudResourcesWithOptions(TagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagCloudResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and attaches tags to cloud resources. For resources that already have the specified tags, updates the tag values.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagCloudResourcesResponse
        /// </returns>
        public async Task<TagCloudResourcesResponse> TagCloudResourcesWithOptionsAsync(TagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagCloudResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and attaches tags to cloud resources. For resources that already have the specified tags, updates the tag values.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagCloudResourcesResponse
        /// </returns>
        public TagCloudResourcesResponse TagCloudResources(TagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagCloudResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and attaches tags to cloud resources. For resources that already have the specified tags, updates the tag values.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagCloudResourcesResponse
        /// </returns>
        public async Task<TagCloudResourcesResponse> TagCloudResourcesAsync(TagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagCloudResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and binds tags to specified China Office (Chinese: Wuying) delivery groups in compliance with Alibaba Cloud tag specifications. If a tag key already exists on a resource, the tag value is updated to the value specified in the current request. Currently, only delivery group (<c>APPINSTANCEGROUP</c>) resource types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When you use a RAM user or Security Token Service (STS) credential to call this operation, you must have the <c>appstreaming:TagResources</c> permission.
        /// The resources to which you want to bind tags must belong to the current Alibaba Cloud account. <b>This operation currently supports only delivery group resources.</b> You can set <c>ResourceType</c> only to <c>APPINSTANCEGROUP</c>. You can call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain delivery group IDs.</para>
        /// <h2>Tag rules</h2>
        /// <list type="bullet">
        /// <item><description>In a single request, you can bind up to <b>20 tags</b> to up to <b>50 resources</b>. Duplicate resource IDs are automatically deduplicated.</description></item>
        /// <item><description>A tag key must be 1 to 128 characters in length. A tag value must be 0 to 256 characters in length. Both are case-sensitive.</description></item>
        /// <item><description>A tag key cannot start with <c>aliyun</c> or <c>acs:</c> (case-insensitive). Neither tag keys nor tag values can contain <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>Tag keys in the same request must be unique. Otherwise, the error code <c>InvalidTag.Duplicated</c> is returned.</description></item>
        /// <item><description>Each tag key on a resource can correspond to only one tag value. If the tag key already exists on the resource, the tag value is updated to the new value.</description></item>
        /// <item><description>A maximum of 20 custom tags can be bound to a single resource. If this limit is exceeded, the error code <c>ResourceTag.CustomTagCountExceed</c> is returned.</description></item>
        /// </list>
        /// <h2>Results</h2>
        /// <list type="bullet">
        /// <item><description><b>If any specified delivery group does not exist or does not belong to the current account, the entire request fails.</b> The error code <c>InvalidAppInstanceGroup.NotFound</c> is returned, and no tags are bound to any resource.</description></item>
        /// <item><description>If the binding succeeds, the response contains only <c>RequestId</c> and does not return tag details.</description></item>
        /// <item><description>If multiple resources are specified and only some of them fail to be bound, the operation still returns a success response without failure details. Call <c>ListTagResources</c> to verify the binding results. If only one resource is specified and the binding fails, the operation returns the corresponding error code.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain the IDs of the delivery groups to which you want to add tags.</description></item>
        /// <item><description>Call this operation with <c>ResourceType=APPINSTANCEGROUP</c>, <c>ResourceId.N</c>, and <c>Tag.N.Key</c>/<c>Tag.N.Value</c>.</description></item>
        /// <item><description>To view the tags bound to resources, call <c>ListTagResources</c>. To unbind tags, call <c>UntagResources</c>.
        /// The masked identifiers in the examples are used to demonstrate the format. Replace them with your actual identifiers when you call the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and binds tags to specified China Office (Chinese: Wuying) delivery groups in compliance with Alibaba Cloud tag specifications. If a tag key already exists on a resource, the tag value is updated to the value specified in the current request. Currently, only delivery group (<c>APPINSTANCEGROUP</c>) resource types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When you use a RAM user or Security Token Service (STS) credential to call this operation, you must have the <c>appstreaming:TagResources</c> permission.
        /// The resources to which you want to bind tags must belong to the current Alibaba Cloud account. <b>This operation currently supports only delivery group resources.</b> You can set <c>ResourceType</c> only to <c>APPINSTANCEGROUP</c>. You can call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain delivery group IDs.</para>
        /// <h2>Tag rules</h2>
        /// <list type="bullet">
        /// <item><description>In a single request, you can bind up to <b>20 tags</b> to up to <b>50 resources</b>. Duplicate resource IDs are automatically deduplicated.</description></item>
        /// <item><description>A tag key must be 1 to 128 characters in length. A tag value must be 0 to 256 characters in length. Both are case-sensitive.</description></item>
        /// <item><description>A tag key cannot start with <c>aliyun</c> or <c>acs:</c> (case-insensitive). Neither tag keys nor tag values can contain <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>Tag keys in the same request must be unique. Otherwise, the error code <c>InvalidTag.Duplicated</c> is returned.</description></item>
        /// <item><description>Each tag key on a resource can correspond to only one tag value. If the tag key already exists on the resource, the tag value is updated to the new value.</description></item>
        /// <item><description>A maximum of 20 custom tags can be bound to a single resource. If this limit is exceeded, the error code <c>ResourceTag.CustomTagCountExceed</c> is returned.</description></item>
        /// </list>
        /// <h2>Results</h2>
        /// <list type="bullet">
        /// <item><description><b>If any specified delivery group does not exist or does not belong to the current account, the entire request fails.</b> The error code <c>InvalidAppInstanceGroup.NotFound</c> is returned, and no tags are bound to any resource.</description></item>
        /// <item><description>If the binding succeeds, the response contains only <c>RequestId</c> and does not return tag details.</description></item>
        /// <item><description>If multiple resources are specified and only some of them fail to be bound, the operation still returns a success response without failure details. Call <c>ListTagResources</c> to verify the binding results. If only one resource is specified and the binding fails, the operation returns the corresponding error code.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain the IDs of the delivery groups to which you want to add tags.</description></item>
        /// <item><description>Call this operation with <c>ResourceType=APPINSTANCEGROUP</c>, <c>ResourceId.N</c>, and <c>Tag.N.Key</c>/<c>Tag.N.Value</c>.</description></item>
        /// <item><description>To view the tags bound to resources, call <c>ListTagResources</c>. To unbind tags, call <c>UntagResources</c>.
        /// The masked identifiers in the examples are used to demonstrate the format. Replace them with your actual identifiers when you call the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and binds tags to specified China Office (Chinese: Wuying) delivery groups in compliance with Alibaba Cloud tag specifications. If a tag key already exists on a resource, the tag value is updated to the value specified in the current request. Currently, only delivery group (<c>APPINSTANCEGROUP</c>) resource types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When you use a RAM user or Security Token Service (STS) credential to call this operation, you must have the <c>appstreaming:TagResources</c> permission.
        /// The resources to which you want to bind tags must belong to the current Alibaba Cloud account. <b>This operation currently supports only delivery group resources.</b> You can set <c>ResourceType</c> only to <c>APPINSTANCEGROUP</c>. You can call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain delivery group IDs.</para>
        /// <h2>Tag rules</h2>
        /// <list type="bullet">
        /// <item><description>In a single request, you can bind up to <b>20 tags</b> to up to <b>50 resources</b>. Duplicate resource IDs are automatically deduplicated.</description></item>
        /// <item><description>A tag key must be 1 to 128 characters in length. A tag value must be 0 to 256 characters in length. Both are case-sensitive.</description></item>
        /// <item><description>A tag key cannot start with <c>aliyun</c> or <c>acs:</c> (case-insensitive). Neither tag keys nor tag values can contain <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>Tag keys in the same request must be unique. Otherwise, the error code <c>InvalidTag.Duplicated</c> is returned.</description></item>
        /// <item><description>Each tag key on a resource can correspond to only one tag value. If the tag key already exists on the resource, the tag value is updated to the new value.</description></item>
        /// <item><description>A maximum of 20 custom tags can be bound to a single resource. If this limit is exceeded, the error code <c>ResourceTag.CustomTagCountExceed</c> is returned.</description></item>
        /// </list>
        /// <h2>Results</h2>
        /// <list type="bullet">
        /// <item><description><b>If any specified delivery group does not exist or does not belong to the current account, the entire request fails.</b> The error code <c>InvalidAppInstanceGroup.NotFound</c> is returned, and no tags are bound to any resource.</description></item>
        /// <item><description>If the binding succeeds, the response contains only <c>RequestId</c> and does not return tag details.</description></item>
        /// <item><description>If multiple resources are specified and only some of them fail to be bound, the operation still returns a success response without failure details. Call <c>ListTagResources</c> to verify the binding results. If only one resource is specified and the binding fails, the operation returns the corresponding error code.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain the IDs of the delivery groups to which you want to add tags.</description></item>
        /// <item><description>Call this operation with <c>ResourceType=APPINSTANCEGROUP</c>, <c>ResourceId.N</c>, and <c>Tag.N.Key</c>/<c>Tag.N.Value</c>.</description></item>
        /// <item><description>To view the tags bound to resources, call <c>ListTagResources</c>. To unbind tags, call <c>UntagResources</c>.
        /// The masked identifiers in the examples are used to demonstrate the format. Replace them with your actual identifiers when you call the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and binds tags to specified China Office (Chinese: Wuying) delivery groups in compliance with Alibaba Cloud tag specifications. If a tag key already exists on a resource, the tag value is updated to the value specified in the current request. Currently, only delivery group (<c>APPINSTANCEGROUP</c>) resource types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When you use a RAM user or Security Token Service (STS) credential to call this operation, you must have the <c>appstreaming:TagResources</c> permission.
        /// The resources to which you want to bind tags must belong to the current Alibaba Cloud account. <b>This operation currently supports only delivery group resources.</b> You can set <c>ResourceType</c> only to <c>APPINSTANCEGROUP</c>. You can call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain delivery group IDs.</para>
        /// <h2>Tag rules</h2>
        /// <list type="bullet">
        /// <item><description>In a single request, you can bind up to <b>20 tags</b> to up to <b>50 resources</b>. Duplicate resource IDs are automatically deduplicated.</description></item>
        /// <item><description>A tag key must be 1 to 128 characters in length. A tag value must be 0 to 256 characters in length. Both are case-sensitive.</description></item>
        /// <item><description>A tag key cannot start with <c>aliyun</c> or <c>acs:</c> (case-insensitive). Neither tag keys nor tag values can contain <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>Tag keys in the same request must be unique. Otherwise, the error code <c>InvalidTag.Duplicated</c> is returned.</description></item>
        /// <item><description>Each tag key on a resource can correspond to only one tag value. If the tag key already exists on the resource, the tag value is updated to the new value.</description></item>
        /// <item><description>A maximum of 20 custom tags can be bound to a single resource. If this limit is exceeded, the error code <c>ResourceTag.CustomTagCountExceed</c> is returned.</description></item>
        /// </list>
        /// <h2>Results</h2>
        /// <list type="bullet">
        /// <item><description><b>If any specified delivery group does not exist or does not belong to the current account, the entire request fails.</b> The error code <c>InvalidAppInstanceGroup.NotFound</c> is returned, and no tags are bound to any resource.</description></item>
        /// <item><description>If the binding succeeds, the response contains only <c>RequestId</c> and does not return tag details.</description></item>
        /// <item><description>If multiple resources are specified and only some of them fail to be bound, the operation still returns a success response without failure details. Call <c>ListTagResources</c> to verify the binding results. If only one resource is specified and the binding fails, the operation returns the corresponding error code.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain the IDs of the delivery groups to which you want to add tags.</description></item>
        /// <item><description>Call this operation with <c>ResourceType=APPINSTANCEGROUP</c>, <c>ResourceId.N</c>, and <c>Tag.N.Key</c>/<c>Tag.N.Value</c>.</description></item>
        /// <item><description>To view the tags bound to resources, call <c>ListTagResources</c>. To unbind tags, call <c>UntagResources</c>.
        /// The masked identifiers in the examples are used to demonstrate the format. Replace them with your actual identifiers when you call the operation.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds secondary private IP addresses from a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassignWuyingServerPrivateAddressesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnassignWuyingServerPrivateAddressesResponse
        /// </returns>
        public UnassignWuyingServerPrivateAddressesResponse UnassignWuyingServerPrivateAddressesWithOptions(UnassignWuyingServerPrivateAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddresses))
            {
                body["PrivateIpAddresses"] = request.PrivateIpAddresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassignWuyingServerPrivateAddresses",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassignWuyingServerPrivateAddressesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds secondary private IP addresses from a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassignWuyingServerPrivateAddressesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnassignWuyingServerPrivateAddressesResponse
        /// </returns>
        public async Task<UnassignWuyingServerPrivateAddressesResponse> UnassignWuyingServerPrivateAddressesWithOptionsAsync(UnassignWuyingServerPrivateAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddresses))
            {
                body["PrivateIpAddresses"] = request.PrivateIpAddresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassignWuyingServerPrivateAddresses",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassignWuyingServerPrivateAddressesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds secondary private IP addresses from a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassignWuyingServerPrivateAddressesRequest
        /// </param>
        /// 
        /// <returns>
        /// UnassignWuyingServerPrivateAddressesResponse
        /// </returns>
        public UnassignWuyingServerPrivateAddressesResponse UnassignWuyingServerPrivateAddresses(UnassignWuyingServerPrivateAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassignWuyingServerPrivateAddressesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds secondary private IP addresses from a development host.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnassignWuyingServerPrivateAddressesRequest
        /// </param>
        /// 
        /// <returns>
        /// UnassignWuyingServerPrivateAddressesResponse
        /// </returns>
        public async Task<UnassignWuyingServerPrivateAddressesResponse> UnassignWuyingServerPrivateAddressesAsync(UnassignWuyingServerPrivateAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassignWuyingServerPrivateAddressesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a user from a session.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Unbind",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a user from a session.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Unbind",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a user from a session.</para>
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
        /// <para>Unbinds a user from a session.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds tags from cloud resources in a unified manner.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagCloudResourcesResponse
        /// </returns>
        public UntagCloudResourcesResponse UntagCloudResourcesWithOptions(UntagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                body["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagCloudResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds tags from cloud resources in a unified manner.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagCloudResourcesResponse
        /// </returns>
        public async Task<UntagCloudResourcesResponse> UntagCloudResourcesWithOptionsAsync(UntagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                body["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagCloudResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds tags from cloud resources in a unified manner.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagCloudResourcesResponse
        /// </returns>
        public UntagCloudResourcesResponse UntagCloudResources(UntagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagCloudResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds tags from cloud resources in a unified manner.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagCloudResourcesResponse
        /// </returns>
        public async Task<UntagCloudResourcesResponse> UntagCloudResourcesAsync(UntagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagCloudResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds tags from specified Wuying delivery groups in compliance with Alibaba Cloud tagging standards. You can unbind specific tags by tag key or unbind all custom tags from a resource at once by setting <c>All=true</c> without specifying tag keys. Currently, only the delivery group (<c>APPINSTANCEGROUP</c>) resource type is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When calling this operation with a RAM user or STS credential, the <c>appstreaming:UntagResources</c> permission is required.
        /// The resources from which you want to unbind tags must belong to the current Alibaba Cloud account. <b>This operation currently supports only delivery group resources.</b> You can set <c>ResourceType</c> only to <c>APPINSTANCEGROUP</c>. You can obtain delivery group IDs by calling <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a>, and query tags that are bound to a resource by calling <a href="~~ListTagResources~~">ListTagResources</a>.</para>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description>You can unbind tags from up to <b>50 resources</b> in a single request. Duplicate resource IDs are automatically deduplicated.</description></item>
        /// <item><description><b>Specify at least one of <c>TagKey.N</c> and <c>All</c>.</b> If neither is specified, or if <c>TagKey.N</c> is not specified and <c>All</c> is set to <c>false</c>, the error code <c>InvalidParameter.TagKeyListOrAll</c> is returned.<list type="bullet">
        /// <item><description>If <c>TagKey.N</c> is specified: only the tags that correspond to the specified tag keys are unbound. You can specify up to 20 tag keys at a time. The <c>All</c> parameter is ignored.</description></item>
        /// <item><description>If <c>TagKey.N</c> is not specified and <c>All=true</c>: all custom tags on the resource are unbound, including Wuying system tags that start with <c>System/</c> and were attached by calling <a href="~~TagResources~~">TagResources</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If a specified tag key does not exist on the resource, the tag key is skipped and no error is returned.</description></item>
        /// <item><description>Tag keys that start with <c>System/</c> are Wuying system tags. Only <c>System/Scheduler/GRAYSCALE</c> and <c>System/Scheduler/STOP_NEW_USER_CONNECTION</c> are supported. If you specify other tag keys that start with <c>System/</c>, the error code <c>InvalidTagPolicy.KeyInvalid</c> or <c>InvalidTag.SystemKeyNotAllow</c> is returned.</description></item>
        /// </list>
        /// <h2>Execution results</h2>
        /// <list type="bullet">
        /// <item><description><b>If any specified delivery group does not exist or does not belong to the current account, the entire request fails</b> with the error code <c>InvalidAppInstanceGroup.NotFound</c>, and no tags are unbound from any resource.</description></item>
        /// <item><description>On success, the response contains only <c>RequestId</c> and does not return tag details.</description></item>
        /// <item><description>When multiple resources are specified and only some fail to have tags unbound, the operation still returns success and the response does not contain failure details. Call <a href="~~ListTagResources~~">ListTagResources</a> to verify the unbinding results. When only one resource is specified and the unbinding fails, the operation returns the corresponding error code directly.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain delivery group IDs. To check which tag keys are bound to a resource, call <a href="~~ListTagResources~~">ListTagResources</a>.</description></item>
        /// <item><description>Call this operation with <c>ResourceType=APPINSTANCEGROUP</c> and <c>ResourceId.N</c>, and specify <c>TagKey.N</c> or <c>All=true</c> to indicate the tags to unbind.</description></item>
        /// <item><description>To rebind tags, call <a href="~~TagResources~~">TagResources</a>.
        /// The masked identifiers in the examples are for format demonstration purposes only. Replace them with your actual identifiers when making calls.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds tags from specified Wuying delivery groups in compliance with Alibaba Cloud tagging standards. You can unbind specific tags by tag key or unbind all custom tags from a resource at once by setting <c>All=true</c> without specifying tag keys. Currently, only the delivery group (<c>APPINSTANCEGROUP</c>) resource type is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When calling this operation with a RAM user or STS credential, the <c>appstreaming:UntagResources</c> permission is required.
        /// The resources from which you want to unbind tags must belong to the current Alibaba Cloud account. <b>This operation currently supports only delivery group resources.</b> You can set <c>ResourceType</c> only to <c>APPINSTANCEGROUP</c>. You can obtain delivery group IDs by calling <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a>, and query tags that are bound to a resource by calling <a href="~~ListTagResources~~">ListTagResources</a>.</para>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description>You can unbind tags from up to <b>50 resources</b> in a single request. Duplicate resource IDs are automatically deduplicated.</description></item>
        /// <item><description><b>Specify at least one of <c>TagKey.N</c> and <c>All</c>.</b> If neither is specified, or if <c>TagKey.N</c> is not specified and <c>All</c> is set to <c>false</c>, the error code <c>InvalidParameter.TagKeyListOrAll</c> is returned.<list type="bullet">
        /// <item><description>If <c>TagKey.N</c> is specified: only the tags that correspond to the specified tag keys are unbound. You can specify up to 20 tag keys at a time. The <c>All</c> parameter is ignored.</description></item>
        /// <item><description>If <c>TagKey.N</c> is not specified and <c>All=true</c>: all custom tags on the resource are unbound, including Wuying system tags that start with <c>System/</c> and were attached by calling <a href="~~TagResources~~">TagResources</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If a specified tag key does not exist on the resource, the tag key is skipped and no error is returned.</description></item>
        /// <item><description>Tag keys that start with <c>System/</c> are Wuying system tags. Only <c>System/Scheduler/GRAYSCALE</c> and <c>System/Scheduler/STOP_NEW_USER_CONNECTION</c> are supported. If you specify other tag keys that start with <c>System/</c>, the error code <c>InvalidTagPolicy.KeyInvalid</c> or <c>InvalidTag.SystemKeyNotAllow</c> is returned.</description></item>
        /// </list>
        /// <h2>Execution results</h2>
        /// <list type="bullet">
        /// <item><description><b>If any specified delivery group does not exist or does not belong to the current account, the entire request fails</b> with the error code <c>InvalidAppInstanceGroup.NotFound</c>, and no tags are unbound from any resource.</description></item>
        /// <item><description>On success, the response contains only <c>RequestId</c> and does not return tag details.</description></item>
        /// <item><description>When multiple resources are specified and only some fail to have tags unbound, the operation still returns success and the response does not contain failure details. Call <a href="~~ListTagResources~~">ListTagResources</a> to verify the unbinding results. When only one resource is specified and the unbinding fails, the operation returns the corresponding error code directly.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain delivery group IDs. To check which tag keys are bound to a resource, call <a href="~~ListTagResources~~">ListTagResources</a>.</description></item>
        /// <item><description>Call this operation with <c>ResourceType=APPINSTANCEGROUP</c> and <c>ResourceId.N</c>, and specify <c>TagKey.N</c> or <c>All=true</c> to indicate the tags to unbind.</description></item>
        /// <item><description>To rebind tags, call <a href="~~TagResources~~">TagResources</a>.
        /// The masked identifiers in the examples are for format demonstration purposes only. Replace them with your actual identifiers when making calls.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds tags from specified Wuying delivery groups in compliance with Alibaba Cloud tagging standards. You can unbind specific tags by tag key or unbind all custom tags from a resource at once by setting <c>All=true</c> without specifying tag keys. Currently, only the delivery group (<c>APPINSTANCEGROUP</c>) resource type is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When calling this operation with a RAM user or STS credential, the <c>appstreaming:UntagResources</c> permission is required.
        /// The resources from which you want to unbind tags must belong to the current Alibaba Cloud account. <b>This operation currently supports only delivery group resources.</b> You can set <c>ResourceType</c> only to <c>APPINSTANCEGROUP</c>. You can obtain delivery group IDs by calling <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a>, and query tags that are bound to a resource by calling <a href="~~ListTagResources~~">ListTagResources</a>.</para>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description>You can unbind tags from up to <b>50 resources</b> in a single request. Duplicate resource IDs are automatically deduplicated.</description></item>
        /// <item><description><b>Specify at least one of <c>TagKey.N</c> and <c>All</c>.</b> If neither is specified, or if <c>TagKey.N</c> is not specified and <c>All</c> is set to <c>false</c>, the error code <c>InvalidParameter.TagKeyListOrAll</c> is returned.<list type="bullet">
        /// <item><description>If <c>TagKey.N</c> is specified: only the tags that correspond to the specified tag keys are unbound. You can specify up to 20 tag keys at a time. The <c>All</c> parameter is ignored.</description></item>
        /// <item><description>If <c>TagKey.N</c> is not specified and <c>All=true</c>: all custom tags on the resource are unbound, including Wuying system tags that start with <c>System/</c> and were attached by calling <a href="~~TagResources~~">TagResources</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If a specified tag key does not exist on the resource, the tag key is skipped and no error is returned.</description></item>
        /// <item><description>Tag keys that start with <c>System/</c> are Wuying system tags. Only <c>System/Scheduler/GRAYSCALE</c> and <c>System/Scheduler/STOP_NEW_USER_CONNECTION</c> are supported. If you specify other tag keys that start with <c>System/</c>, the error code <c>InvalidTagPolicy.KeyInvalid</c> or <c>InvalidTag.SystemKeyNotAllow</c> is returned.</description></item>
        /// </list>
        /// <h2>Execution results</h2>
        /// <list type="bullet">
        /// <item><description><b>If any specified delivery group does not exist or does not belong to the current account, the entire request fails</b> with the error code <c>InvalidAppInstanceGroup.NotFound</c>, and no tags are unbound from any resource.</description></item>
        /// <item><description>On success, the response contains only <c>RequestId</c> and does not return tag details.</description></item>
        /// <item><description>When multiple resources are specified and only some fail to have tags unbound, the operation still returns success and the response does not contain failure details. Call <a href="~~ListTagResources~~">ListTagResources</a> to verify the unbinding results. When only one resource is specified and the unbinding fails, the operation returns the corresponding error code directly.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain delivery group IDs. To check which tag keys are bound to a resource, call <a href="~~ListTagResources~~">ListTagResources</a>.</description></item>
        /// <item><description>Call this operation with <c>ResourceType=APPINSTANCEGROUP</c> and <c>ResourceId.N</c>, and specify <c>TagKey.N</c> or <c>All=true</c> to indicate the tags to unbind.</description></item>
        /// <item><description>To rebind tags, call <a href="~~TagResources~~">TagResources</a>.
        /// The masked identifiers in the examples are for format demonstration purposes only. Replace them with your actual identifiers when making calls.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds tags from specified Wuying delivery groups in compliance with Alibaba Cloud tagging standards. You can unbind specific tags by tag key or unbind all custom tags from a resource at once by setting <c>All=true</c> without specifying tag keys. Currently, only the delivery group (<c>APPINSTANCEGROUP</c>) resource type is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Before you begin</h2>
        /// <para>When calling this operation with a RAM user or STS credential, the <c>appstreaming:UntagResources</c> permission is required.
        /// The resources from which you want to unbind tags must belong to the current Alibaba Cloud account. <b>This operation currently supports only delivery group resources.</b> You can set <c>ResourceType</c> only to <c>APPINSTANCEGROUP</c>. You can obtain delivery group IDs by calling <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a>, and query tags that are bound to a resource by calling <a href="~~ListTagResources~~">ListTagResources</a>.</para>
        /// <h2>Parameter description</h2>
        /// <list type="bullet">
        /// <item><description>You can unbind tags from up to <b>50 resources</b> in a single request. Duplicate resource IDs are automatically deduplicated.</description></item>
        /// <item><description><b>Specify at least one of <c>TagKey.N</c> and <c>All</c>.</b> If neither is specified, or if <c>TagKey.N</c> is not specified and <c>All</c> is set to <c>false</c>, the error code <c>InvalidParameter.TagKeyListOrAll</c> is returned.<list type="bullet">
        /// <item><description>If <c>TagKey.N</c> is specified: only the tags that correspond to the specified tag keys are unbound. You can specify up to 20 tag keys at a time. The <c>All</c> parameter is ignored.</description></item>
        /// <item><description>If <c>TagKey.N</c> is not specified and <c>All=true</c>: all custom tags on the resource are unbound, including Wuying system tags that start with <c>System/</c> and were attached by calling <a href="~~TagResources~~">TagResources</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If a specified tag key does not exist on the resource, the tag key is skipped and no error is returned.</description></item>
        /// <item><description>Tag keys that start with <c>System/</c> are Wuying system tags. Only <c>System/Scheduler/GRAYSCALE</c> and <c>System/Scheduler/STOP_NEW_USER_CONNECTION</c> are supported. If you specify other tag keys that start with <c>System/</c>, the error code <c>InvalidTagPolicy.KeyInvalid</c> or <c>InvalidTag.SystemKeyNotAllow</c> is returned.</description></item>
        /// </list>
        /// <h2>Execution results</h2>
        /// <list type="bullet">
        /// <item><description><b>If any specified delivery group does not exist or does not belong to the current account, the entire request fails</b> with the error code <c>InvalidAppInstanceGroup.NotFound</c>, and no tags are unbound from any resource.</description></item>
        /// <item><description>On success, the response contains only <c>RequestId</c> and does not return tag details.</description></item>
        /// <item><description>When multiple resources are specified and only some fail to have tags unbound, the operation still returns success and the response does not contain failure details. Call <a href="~~ListTagResources~~">ListTagResources</a> to verify the unbinding results. When only one resource is specified and the unbinding fails, the operation returns the corresponding error code directly.</description></item>
        /// </list>
        /// <h2>Call sequence</h2>
        /// <ol>
        /// <item><description>Call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain delivery group IDs. To check which tag keys are bound to a resource, call <a href="~~ListTagResources~~">ListTagResources</a>.</description></item>
        /// <item><description>Call this operation with <c>ResourceType=APPINSTANCEGROUP</c> and <c>ResourceId.N</c>, and specify <c>TagKey.N</c> or <c>All=true</c> to indicate the tags to unbind.</description></item>
        /// <item><description>To rebind tags, call <a href="~~TagResources~~">TagResources</a>.
        /// The masked identifiers in the examples are for format demonstration purposes only. Replace them with your actual identifiers when making calls.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the image of a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Warning: After the image update starts, sessions of end users who are accessing cloud applications will be disconnected. Proceed with caution to avoid data loss for end users.
        /// Before calling this API, the delivery group must be in the PUBLISHED, DEPLOYED, or MAINTAIN_FAILED state. You can call GetAppInstanceGroup to query the current state of the delivery group.
        /// After the update is published, you typically need to wait about 2 minutes for the changes to take effect on the client.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAppInstanceGroupImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppInstanceGroupImageResponse
        /// </returns>
        public UpdateAppInstanceGroupImageResponse UpdateAppInstanceGroupImageWithOptions(UpdateAppInstanceGroupImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                query["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppInstanceGroupImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppInstanceGroupImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the image of a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Warning: After the image update starts, sessions of end users who are accessing cloud applications will be disconnected. Proceed with caution to avoid data loss for end users.
        /// Before calling this API, the delivery group must be in the PUBLISHED, DEPLOYED, or MAINTAIN_FAILED state. You can call GetAppInstanceGroup to query the current state of the delivery group.
        /// After the update is published, you typically need to wait about 2 minutes for the changes to take effect on the client.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAppInstanceGroupImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppInstanceGroupImageResponse
        /// </returns>
        public async Task<UpdateAppInstanceGroupImageResponse> UpdateAppInstanceGroupImageWithOptionsAsync(UpdateAppInstanceGroupImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                query["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppInstanceGroupImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppInstanceGroupImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the image of a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Warning: After the image update starts, sessions of end users who are accessing cloud applications will be disconnected. Proceed with caution to avoid data loss for end users.
        /// Before calling this API, the delivery group must be in the PUBLISHED, DEPLOYED, or MAINTAIN_FAILED state. You can call GetAppInstanceGroup to query the current state of the delivery group.
        /// After the update is published, you typically need to wait about 2 minutes for the changes to take effect on the client.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAppInstanceGroupImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppInstanceGroupImageResponse
        /// </returns>
        public UpdateAppInstanceGroupImageResponse UpdateAppInstanceGroupImage(UpdateAppInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppInstanceGroupImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the image of a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Warning: After the image update starts, sessions of end users who are accessing cloud applications will be disconnected. Proceed with caution to avoid data loss for end users.
        /// Before calling this API, the delivery group must be in the PUBLISHED, DEPLOYED, or MAINTAIN_FAILED state. You can call GetAppInstanceGroup to query the current state of the delivery group.
        /// After the update is published, you typically need to wait about 2 minutes for the changes to take effect on the client.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAppInstanceGroupImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppInstanceGroupImageResponse
        /// </returns>
        public async Task<UpdateAppInstanceGroupImageResponse> UpdateAppInstanceGroupImageAsync(UpdateAppInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppInstanceGroupImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can update a model provider template that has been created in the WUYING Agent Management Center, including the template name, description, model service connection configuration, and WUYING security proxy switch. Partial field updates are supported. You only need to pass in the fields that you want to modify.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateModelProviderTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProviderTemplateResponse
        /// </returns>
        public UpdateModelProviderTemplateResponse UpdateModelProviderTemplateWithOptions(UpdateModelProviderTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateModelProviderTemplateShrinkRequest request = new UpdateModelProviderTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                query["Config"] = request.ConfigShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWuyingProxy))
            {
                body["EnableWuyingProxy"] = request.EnableWuyingProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                body["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelProviderTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelProviderTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can update a model provider template that has been created in the WUYING Agent Management Center, including the template name, description, model service connection configuration, and WUYING security proxy switch. Partial field updates are supported. You only need to pass in the fields that you want to modify.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateModelProviderTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProviderTemplateResponse
        /// </returns>
        public async Task<UpdateModelProviderTemplateResponse> UpdateModelProviderTemplateWithOptionsAsync(UpdateModelProviderTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateModelProviderTemplateShrinkRequest request = new UpdateModelProviderTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                query["Config"] = request.ConfigShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWuyingProxy))
            {
                body["EnableWuyingProxy"] = request.EnableWuyingProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderTemplateId))
            {
                body["ProviderTemplateId"] = request.ProviderTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelProviderTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelProviderTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can update a model provider template that has been created in the WUYING Agent Management Center, including the template name, description, model service connection configuration, and WUYING security proxy switch. Partial field updates are supported. You only need to pass in the fields that you want to modify.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelProviderTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProviderTemplateResponse
        /// </returns>
        public UpdateModelProviderTemplateResponse UpdateModelProviderTemplate(UpdateModelProviderTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateModelProviderTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can update a model provider template that has been created in the WUYING Agent Management Center, including the template name, description, model service connection configuration, and WUYING security proxy switch. Partial field updates are supported. You only need to pass in the fields that you want to modify.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelProviderTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProviderTemplateResponse
        /// </returns>
        public async Task<UpdateModelProviderTemplateResponse> UpdateModelProviderTemplateAsync(UpdateModelProviderTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateModelProviderTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can update a model group that has been created in the Wuying Agent Management Center, including the group name, description, and model configuration information. You can modify the default model of a model group by updating the Config field. The updated configuration automatically takes effect on associated cloud desktops.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelTemplateResponse
        /// </returns>
        public UpdateModelTemplateResponse UpdateModelTemplateWithOptions(UpdateModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefScope))
            {
                query["RefScope"] = request.RefScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can update a model group that has been created in the Wuying Agent Management Center, including the group name, description, and model configuration information. You can modify the default model of a model group by updating the Config field. The updated configuration automatically takes effect on associated cloud desktops.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelTemplateResponse
        /// </returns>
        public async Task<UpdateModelTemplateResponse> UpdateModelTemplateWithOptionsAsync(UpdateModelTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTemplateId))
            {
                query["ModelTemplateId"] = request.ModelTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefScope))
            {
                query["RefScope"] = request.RefScope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelTemplate",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can update a model group that has been created in the Wuying Agent Management Center, including the group name, description, and model configuration information. You can modify the default model of a model group by updating the Config field. The updated configuration automatically takes effect on associated cloud desktops.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelTemplateResponse
        /// </returns>
        public UpdateModelTemplateResponse UpdateModelTemplate(UpdateModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateModelTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can update a model group that has been created in the Wuying Agent Management Center, including the group name, description, and model configuration information. You can modify the default model of a model group by updating the Config field. The updated configuration automatically takes effect on associated cloud desktops.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelTemplateResponse
        /// </returns>
        public async Task<UpdateModelTemplateResponse> UpdateModelTemplateAsync(UpdateModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateModelTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workstation image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWuyingServerImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWuyingServerImageResponse
        /// </returns>
        public UpdateWuyingServerImageResponse UpdateWuyingServerImageWithOptions(UpdateWuyingServerImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWuyingServerImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWuyingServerImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workstation image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWuyingServerImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWuyingServerImageResponse
        /// </returns>
        public async Task<UpdateWuyingServerImageResponse> UpdateWuyingServerImageWithOptionsAsync(UpdateWuyingServerImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWuyingServerImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWuyingServerImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workstation image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWuyingServerImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWuyingServerImageResponse
        /// </returns>
        public UpdateWuyingServerImageResponse UpdateWuyingServerImage(UpdateWuyingServerImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWuyingServerImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workstation image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWuyingServerImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWuyingServerImageResponse
        /// </returns>
        public async Task<UpdateWuyingServerImageResponse> UpdateWuyingServerImageAsync(UpdateWuyingServerImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWuyingServerImageWithOptionsAsync(request, runtime);
        }

    }
}
