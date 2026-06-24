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
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shanghai", "appstream-center.cn-shanghai.aliyuncs.com"},
                {"ap-southeast-1", "appstream-center.ap-southeast-1.aliyuncs.com"},
            };
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
        /// <para>Sets the execution time for an over-the-air update.</para>
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
        /// <para>Sets the execution time for an over-the-air update.</para>
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
        /// <para>Sets the execution time for an over-the-air update.</para>
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
        /// <para>Sets the execution time for an over-the-air update.</para>
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
        /// <para>为研发主机分配辅助私有IP</para>
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
        /// <para>为研发主机分配辅助私有IP</para>
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
        /// <para>为研发主机分配辅助私有IP</para>
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
        /// <para>为研发主机分配辅助私有IP</para>
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
        /// <para>Add or remove assigned users for a delivery group. Only users added as assigned users can access cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After changing the assigned users, the selected users will receive corresponding notification emails. Generally, it takes about 2 minutes for the changes to take effect on the client.</para>
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
        /// <para>Add or remove assigned users for a delivery group. Only users added as assigned users can access cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After changing the assigned users, the selected users will receive corresponding notification emails. Generally, it takes about 2 minutes for the changes to take effect on the client.</para>
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
        /// <para>Add or remove assigned users for a delivery group. Only users added as assigned users can access cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After changing the assigned users, the selected users will receive corresponding notification emails. Generally, it takes about 2 minutes for the changes to take effect on the client.</para>
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
        /// <para>Add or remove assigned users for a delivery group. Only users added as assigned users can access cloud applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After changing the assigned users, the selected users will receive corresponding notification emails. Generally, it takes about 2 minutes for the changes to take effect on the client.</para>
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
        /// <para>Creates LLM templates in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create model templates in batches under a model provider template in the Wuying Agent Management Center. You can add multiple models at a time and specify one of them as the default model. Existing models are automatically skipped and are not created again.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can create model templates in batches under a model provider template in the Wuying Agent Management Center. You can add multiple models at a time and specify one of them as the default model. Existing models are automatically skipped and are not created again.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can create model templates in batches under a model provider template in the Wuying Agent Management Center. You can add multiple models at a time and specify one of them as the default model. Existing models are automatically skipped and are not created again.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can create model templates in batches under a model provider template in the Wuying Agent Management Center. You can add multiple models at a time and specify one of them as the default model. Existing models are automatically skipped and are not created again.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can assign a model group to resources associated with agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model group serves as the inference engine for tasks executed by agents within the resource group.
        /// When both an agent runtime and its resource group have model groups configured, the model group bound to the resource group takes effect. The resource group setting takes priority over the agent runtime setting.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// <para>You can assign a model group to resources associated with agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model group serves as the inference engine for tasks executed by agents within the resource group.
        /// When both an agent runtime and its resource group have model groups configured, the model group bound to the resource group takes effect. The resource group setting takes priority over the agent runtime setting.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// <para>You can assign a model group to resources associated with agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model group serves as the inference engine for tasks executed by agents within the resource group.
        /// When both an agent runtime and its resource group have model groups configured, the model group bound to the resource group takes effect. The resource group setting takes priority over the agent runtime setting.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// <para>You can assign a model group to resources associated with agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model group serves as the inference engine for tasks executed by agents within the resource group.
        /// When both an agent runtime and its resource group have model groups configured, the model group bound to the resource group takes effect. The resource group setting takes priority over the agent runtime setting.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// Before using this operation, make sure you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// Before using this operation, make sure you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// Before using this operation, make sure you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// Before using this operation, make sure you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>Make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING Cloud Application before you call this operation.
        /// A delivery group is a logical grouping for delivering cloud applications to end users. It includes the underlying cloud application resources, images that contain cloud applications, resource management policies, and user assignment settings. For details, see <a href="https://help.aliyun.com/document_detail/426046.html">Publish a delivery group</a>.</para>
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
        /// <para>Make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING Cloud Application before you call this operation.
        /// A delivery group is a logical grouping for delivering cloud applications to end users. It includes the underlying cloud application resources, images that contain cloud applications, resource management policies, and user assignment settings. For details, see <a href="https://help.aliyun.com/document_detail/426046.html">Publish a delivery group</a>.</para>
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
        /// <para>Make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING Cloud Application before you call this operation.
        /// A delivery group is a logical grouping for delivering cloud applications to end users. It includes the underlying cloud application resources, images that contain cloud applications, resource management policies, and user assignment settings. For details, see <a href="https://help.aliyun.com/document_detail/426046.html">Publish a delivery group</a>.</para>
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
        /// <para>Make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/426039.html">billing and pricing</a> of WUYING Cloud Application before you call this operation.
        /// A delivery group is a logical grouping for delivering cloud applications to end users. It includes the underlying cloud application resources, images that contain cloud applications, resource management policies, and user assignment settings. For details, see <a href="https://help.aliyun.com/document_detail/426046.html">Publish a delivery group</a>.</para>
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
        /// <para>Create Model Provider Template</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model provider template under a model template in the Wuying Agent Management Center. This template is used to configure the connection information and keys for model services (such as Alibaba Cloud Bailian, Token Plan, and Moonshot) that Agents can call. After creation, the model provider template is automatically associated with the specified model template.
        /// Make sure you are fully familiar with the operations and usage of the Wuying Agent Management Center before calling this API.</para>
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
        /// <para>Create Model Provider Template</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model provider template under a model template in the Wuying Agent Management Center. This template is used to configure the connection information and keys for model services (such as Alibaba Cloud Bailian, Token Plan, and Moonshot) that Agents can call. After creation, the model provider template is automatically associated with the specified model template.
        /// Make sure you are fully familiar with the operations and usage of the Wuying Agent Management Center before calling this API.</para>
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
        /// <para>Create Model Provider Template</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model provider template under a model template in the Wuying Agent Management Center. This template is used to configure the connection information and keys for model services (such as Alibaba Cloud Bailian, Token Plan, and Moonshot) that Agents can call. After creation, the model provider template is automatically associated with the specified model template.
        /// Make sure you are fully familiar with the operations and usage of the Wuying Agent Management Center before calling this API.</para>
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
        /// <para>Create Model Provider Template</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model provider template under a model template in the Wuying Agent Management Center. This template is used to configure the connection information and keys for model services (such as Alibaba Cloud Bailian, Token Plan, and Moonshot) that Agents can call. After creation, the model provider template is automatically associated with the specified model template.
        /// Make sure you are fully familiar with the operations and usage of the Wuying Agent Management Center before calling this API.</para>
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
        /// <para>Creates a model creation template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model group in the WUYING Agent Management Center to manage the model providers and model scope that an Agent can invoke. After creation, you can attach the model group to a cloud computer as the inference engine configuration for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
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
        /// <para>Creates a model creation template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model group in the WUYING Agent Management Center to manage the model providers and model scope that an Agent can invoke. After creation, you can attach the model group to a cloud computer as the inference engine configuration for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
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
        /// <para>Creates a model creation template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model group in the WUYING Agent Management Center to manage the model providers and model scope that an Agent can invoke. After creation, you can attach the model group to a cloud computer as the inference engine configuration for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
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
        /// <para>Creates a model creation template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a model group in the WUYING Agent Management Center to manage the model providers and model scope that an Agent can invoke. After creation, you can attach the model group to a cloud computer as the inference engine configuration for Agent task execution.
        /// Make sure that you are familiar with the operations and usage of the WUYING Agent Management Center before calling this operation.</para>
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
        /// <item><description>If the ContentId specified in the request parameters has multiple versions, this API operation <notice>uses the default version</notice> for binding.</description></item>
        /// <item><description>This operation succeeds only when the default version of the content is in an available state.</description></item>
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
        /// <item><description>If the ContentId specified in the request parameters has multiple versions, this API operation <notice>uses the default version</notice> for binding.</description></item>
        /// <item><description>This operation succeeds only when the default version of the content is in an available state.</description></item>
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
        /// <item><description>If the ContentId specified in the request parameters has multiple versions, this API operation <notice>uses the default version</notice> for binding.</description></item>
        /// <item><description>This operation succeeds only when the default version of the content is in an available state.</description></item>
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
        /// <item><description>If the ContentId specified in the request parameters has multiple versions, this API operation <notice>uses the default version</notice> for binding.</description></item>
        /// <item><description>This operation succeeds only when the default version of the content is in an available state.</description></item>
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
        /// <para>Deletes a pay-as-you-go resource-based delivery group.</para>
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
        /// <para>Deletes a pay-as-you-go resource-based delivery group.</para>
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
        /// <para>Deletes a pay-as-you-go resource-based delivery group.</para>
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
        /// <para>Deletes a pay-as-you-go resource-based delivery group.</para>
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
        /// <para>Only instances in the init or idle state can be deleted. This operation is available only to specific customers.</para>
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
        /// <para>Only instances in the init or idle state can be deleted. This operation is available only to specific customers.</para>
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
        /// <para>Only instances in the init or idle state can be deleted. This operation is available only to specific customers.</para>
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
        /// <para>Only instances in the init or idle state can be deleted. This operation is available only to specific customers.</para>
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
        /// <para>Deletes a custom AppStream image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete only custom images that belong to you.</description></item>
        /// <item><description>For images associated with the AppStream Cloud Computer Pool, AppStream Cloud Application, or AppStream Workstation product lines, you must ensure that no AppStream instances are using the image before you can delete it.</description></item>
        /// <item><description>If an AppStream Cloud Desktop template references an image, the template is also deleted when the image is deleted.</description></item>
        /// <item><description>If an image is available in multiple regions, deleting the image removes it from all regions.</description></item>
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
        /// <para>Deletes a custom AppStream image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete only custom images that belong to you.</description></item>
        /// <item><description>For images associated with the AppStream Cloud Computer Pool, AppStream Cloud Application, or AppStream Workstation product lines, you must ensure that no AppStream instances are using the image before you can delete it.</description></item>
        /// <item><description>If an AppStream Cloud Desktop template references an image, the template is also deleted when the image is deleted.</description></item>
        /// <item><description>If an image is available in multiple regions, deleting the image removes it from all regions.</description></item>
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
        /// <para>Deletes a custom AppStream image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete only custom images that belong to you.</description></item>
        /// <item><description>For images associated with the AppStream Cloud Computer Pool, AppStream Cloud Application, or AppStream Workstation product lines, you must ensure that no AppStream instances are using the image before you can delete it.</description></item>
        /// <item><description>If an AppStream Cloud Desktop template references an image, the template is also deleted when the image is deleted.</description></item>
        /// <item><description>If an image is available in multiple regions, deleting the image removes it from all regions.</description></item>
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
        /// <para>Deletes a custom AppStream image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete only custom images that belong to you.</description></item>
        /// <item><description>For images associated with the AppStream Cloud Computer Pool, AppStream Cloud Application, or AppStream Workstation product lines, you must ensure that no AppStream instances are using the image before you can delete it.</description></item>
        /// <item><description>If an AppStream Cloud Desktop template references an image, the template is also deleted when the image is deleted.</description></item>
        /// <item><description>If an image is available in multiple regions, deleting the image removes it from all regions.</description></item>
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
        /// <para>You can delete a model template that has been created under a model provider template in the Wuying Agent Management Center. Before deletion, ensure that the model is not the default model of an associated model group. Otherwise, the deletion fails. After deletion, the model configurations of associated cloud computers are automatically refreshed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can delete a model template that has been created under a model provider template in the Wuying Agent Management Center. Before deletion, ensure that the model is not the default model of an associated model group. Otherwise, the deletion fails. After deletion, the model configurations of associated cloud computers are automatically refreshed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can delete a model template that has been created under a model provider template in the Wuying Agent Management Center. Before deletion, ensure that the model is not the default model of an associated model group. Otherwise, the deletion fails. After deletion, the model configurations of associated cloud computers are automatically refreshed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can delete a model template that has been created under a model provider template in the Wuying Agent Management Center. Before deletion, ensure that the model is not the default model of an associated model group. Otherwise, the deletion fails. After deletion, the model configurations of associated cloud computers are automatically refreshed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can delete a model provider template that has been created under model templates in the WUYING Agent Management Center. Before deletion, make sure that the model provider is not the provider of the default model and is not a system preset type provider (such as WUYING credits package). After deletion, the associated models and key configurations are also removed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// <para>You can delete a model provider template that has been created under model templates in the WUYING Agent Management Center. Before deletion, make sure that the model provider is not the provider of the default model and is not a system preset type provider (such as WUYING credits package). After deletion, the associated models and key configurations are also removed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// <para>You can delete a model provider template that has been created under model templates in the WUYING Agent Management Center. Before deletion, make sure that the model provider is not the provider of the default model and is not a system preset type provider (such as WUYING credits package). After deletion, the associated models and key configurations are also removed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// <para>You can delete a model provider template that has been created under model templates in the WUYING Agent Management Center. Before deletion, make sure that the model provider is not the provider of the default model and is not a system preset type provider (such as WUYING credits package). After deletion, the associated models and key configurations are also removed.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// <para>Configure LogShipper for Simple Log Service</para>
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
        /// <para>Configure LogShipper for Simple Log Service</para>
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
        /// <para>Configure LogShipper for Simple Log Service</para>
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
        /// <para>Configure LogShipper for Simple Log Service</para>
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
        /// <para>查询研发主机详情</para>
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
        /// <para>查询研发主机详情</para>
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
        /// <para>查询研发主机详情</para>
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
        /// <para>查询研发主机详情</para>
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
        /// <para>Retrieves connection credentials for a cloud application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation requires multiple invokes (at least two) to obtain the connection credentials.
        /// On the first invoke, an application instance is allocated to the specified convenience account and the application is started. A startup task ID (<c>TaskID</c>) is returned.
        /// On subsequent invokes, pass the <c>TaskID</c> request parameter to query whether the task is complete. When the returned task status (<c>TaskStatus</c>) is completed (<c>Finished</c>), the connection credentials (<c>Ticket</c>) are also returned.</para>
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
        /// <para>Retrieves connection credentials for a cloud application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation requires multiple invokes (at least two) to obtain the connection credentials.
        /// On the first invoke, an application instance is allocated to the specified convenience account and the application is started. A startup task ID (<c>TaskID</c>) is returned.
        /// On subsequent invokes, pass the <c>TaskID</c> request parameter to query whether the task is complete. When the returned task status (<c>TaskStatus</c>) is completed (<c>Finished</c>), the connection credentials (<c>Ticket</c>) are also returned.</para>
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
        /// <para>Retrieves connection credentials for a cloud application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation requires multiple invokes (at least two) to obtain the connection credentials.
        /// On the first invoke, an application instance is allocated to the specified convenience account and the application is started. A startup task ID (<c>TaskID</c>) is returned.
        /// On subsequent invokes, pass the <c>TaskID</c> request parameter to query whether the task is complete. When the returned task status (<c>TaskStatus</c>) is completed (<c>Finished</c>), the connection credentials (<c>Ticket</c>) are also returned.</para>
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
        /// <para>Retrieves connection credentials for a cloud application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation requires multiple invokes (at least two) to obtain the connection credentials.
        /// On the first invoke, an application instance is allocated to the specified convenience account and the application is started. A startup task ID (<c>TaskID</c>) is returned.
        /// On subsequent invokes, pass the <c>TaskID</c> request parameter to query whether the task is complete. When the returned task status (<c>TaskStatus</c>) is completed (<c>Finished</c>), the connection credentials (<c>Ticket</c>) are also returned.</para>
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
        /// <para>Queries the details of a model provider template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of a specified model provider template in the WUYING Agent Management Center, including the provider name, description, and connection configuration list.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// <para>Queries the details of an over-the-air update task, including the available version and version description.</para>
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
        /// <para>Queries the details of an over-the-air update task, including the available version and version description.</para>
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
        /// <para>Queries the details of an over-the-air update task, including the available version and version description.</para>
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
        /// <para>Queries the details of an over-the-air update task, including the available version and version description.</para>
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
        /// <para>You can query the third-party channel configuration status of Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center.
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
        /// <para>You can query the third-party channel configuration status of Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center.
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
        /// <para>You can query the third-party channel configuration status of Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center.
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
        /// <para>You can query the third-party channel configuration status of Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center.
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
        /// <para>Queries the details of multiple delivery groups. This operation does not specify a particular delivery group but queries the details of all delivery groups that meet the specified conditions.</para>
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
        /// <para>Queries the details of multiple delivery groups. This operation does not specify a particular delivery group but queries the details of all delivery groups that meet the specified conditions.</para>
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
        /// <para>Queries the details of multiple delivery groups. This operation does not specify a particular delivery group but queries the details of all delivery groups that meet the specified conditions.</para>
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
        /// <para>Queries the details of multiple delivery groups. This operation does not specify a particular delivery group but queries the details of all delivery groups that meet the specified conditions.</para>
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
        /// <para>Queries the details of session instances in a delivery group, including instance IDs, instance statuses, creation time, update time, session statuses, and public IP addresses of primary network interfaces.</para>
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
        /// <para>Queries the details of session instances in a delivery group, including instance IDs, instance statuses, creation time, update time, session statuses, and public IP addresses of primary network interfaces.</para>
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
        /// <para>Queries the details of session instances in a delivery group, including instance IDs, instance statuses, creation time, update time, session statuses, and public IP addresses of primary network interfaces.</para>
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
        /// <para>Queries the details of session instances in a delivery group, including instance IDs, instance statuses, creation time, update time, session statuses, and public IP addresses of primary network interfaces.</para>
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
        /// <para>Queries the binding information between users and resources.</para>
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
        /// <para>Queries the binding information between users and resources.</para>
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
        /// <para>Queries the binding information between users and resources.</para>
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
        /// <para>Queries the binding information between users and resources.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthUsers))
            {
                query["AuthUsers"] = request.AuthUsers;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthUsers))
            {
                query["AuthUsers"] = request.AuthUsers;
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
        /// <para>Queries a list of LLM templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use paging to retrieve the list of model templates under a model provider template in the Wuying Agent Management Center. You can filter results by model group ID, model provider template ID, model template ID, and model encoding. When you query by model group dimension, the default model is automatically pinned to the top.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>Queries a list of LLM templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use paging to retrieve the list of model templates under a model provider template in the Wuying Agent Management Center. You can filter results by model group ID, model provider template ID, model template ID, and model encoding. When you query by model group dimension, the default model is automatically pinned to the top.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>Queries a list of LLM templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use paging to retrieve the list of model templates under a model provider template in the Wuying Agent Management Center. You can filter results by model group ID, model provider template ID, model template ID, and model encoding. When you query by model group dimension, the default model is automatically pinned to the top.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>Queries a list of LLM templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use paging to retrieve the list of model templates under a model provider template in the Wuying Agent Management Center. You can filter results by model group ID, model provider template ID, model template ID, and model encoding. When you query by model group dimension, the default model is automatically pinned to the top.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>查询模型提供商 Endpoint 列表</para>
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
        /// <para>查询模型提供商 Endpoint 列表</para>
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
        /// <para>查询模型提供商 Endpoint 列表</para>
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
        /// <para>查询模型提供商 Endpoint 列表</para>
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
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the WUYING Agent Management Center.</para>
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
        /// <para>You can call this operation to query the list of resource groups authorized by a model group in the Wuying Agent Management Center.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can call this operation to query the list of resource groups authorized by a model group in the Wuying Agent Management Center.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can call this operation to query the list of resource groups authorized by a model group in the Wuying Agent Management Center.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can call this operation to query the list of resource groups authorized by a model group in the Wuying Agent Management Center.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can use paged query to retrieve model groups that have been created in the Wuying Agent Management Center, with paging support. You can filter results by Agent provider, Agent platform, template group ID, and whether models have been configured.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
        /// <para>You can use paged query to retrieve model groups that have been created in the Wuying Agent Management Center, with paging support. You can filter results by Agent provider, Agent platform, template group ID, and whether models have been configured.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentProvider))
            {
                query["AgentProvider"] = request.AgentProvider;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
        /// <para>You can use paged query to retrieve model groups that have been created in the Wuying Agent Management Center, with paging support. You can filter results by Agent provider, Agent platform, template group ID, and whether models have been configured.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can use paged query to retrieve model groups that have been created in the Wuying Agent Management Center, with paging support. You can filter results by Agent provider, Agent platform, template group ID, and whether models have been configured.
        /// Before calling this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>Queries the regions supported by WUYING Cloud Application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The regions returned by this operation are not necessarily all available regions. For information about available regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
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
        /// <para>The regions returned by this operation are not necessarily all available regions. For information about available regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
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
        /// <para>The regions returned by this operation are not necessarily all available regions. For information about available regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
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
        /// <para>The regions returned by this operation are not necessarily all available regions. For information about available regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
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
        /// <para>Queries the tag list of one or more specified cloud resources.</para>
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
        /// <para>Queries the tag list of one or more specified cloud resources.</para>
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
        /// <para>Queries the tag list of one or more specified cloud resources.</para>
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
        /// <para>Queries the tag list of one or more specified cloud resources.</para>
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
        /// <para>Queries the list of workstations.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
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
        /// <para>Queries the list of workstations.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
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
        /// <para>Queries the list of workstations.</para>
        /// </summary>
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
        /// <para>Queries the list of workstations.</para>
        /// </summary>
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
        /// <para>Logs off all sessions in a pay-as-you-go delivery group that has scheduled auto scaling policies enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation is applicable only to pay-as-you-go resource delivery groups that have scheduled auto scaling policies enabled, and can be called successfully only outside the scaling time periods configured in the scheduled auto scaling policies.</para>
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
        /// <para>Logs off all sessions in a pay-as-you-go delivery group that has scheduled auto scaling policies enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation is applicable only to pay-as-you-go resource delivery groups that have scheduled auto scaling policies enabled, and can be called successfully only outside the scaling time periods configured in the scheduled auto scaling policies.</para>
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
        /// <para>Logs off all sessions in a pay-as-you-go delivery group that has scheduled auto scaling policies enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation is applicable only to pay-as-you-go resource delivery groups that have scheduled auto scaling policies enabled, and can be called successfully only outside the scaling time periods configured in the scheduled auto scaling policies.</para>
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
        /// <para>Logs off all sessions in a pay-as-you-go delivery group that has scheduled auto scaling policies enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation is applicable only to pay-as-you-go resource delivery groups that have scheduled auto scaling policies enabled, and can be called successfully only outside the scaling time periods configured in the scheduled auto scaling policies.</para>
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
        /// <para>Modifies the scaling mode of a delivery group, including fixed quantity (no elastic scaling), scheduled scaling, and automatic scaling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure the scaling pattern for WUYING Cloud Application resources in Settings:</para>
        /// <list type="bullet">
        /// <item><description>Fixed quantity: Elastic scaling is not used.</description></item>
        /// <item><description>Automatic scaling: Automatically scales resources based on the number of connected sessions and the idle duration without session connections.</description></item>
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
        /// <para>Modifies the scaling mode of a delivery group, including fixed quantity (no elastic scaling), scheduled scaling, and automatic scaling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure the scaling pattern for WUYING Cloud Application resources in Settings:</para>
        /// <list type="bullet">
        /// <item><description>Fixed quantity: Elastic scaling is not used.</description></item>
        /// <item><description>Automatic scaling: Automatically scales resources based on the number of connected sessions and the idle duration without session connections.</description></item>
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
        /// <para>Modifies the scaling mode of a delivery group, including fixed quantity (no elastic scaling), scheduled scaling, and automatic scaling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure the scaling pattern for WUYING Cloud Application resources in Settings:</para>
        /// <list type="bullet">
        /// <item><description>Fixed quantity: Elastic scaling is not used.</description></item>
        /// <item><description>Automatic scaling: Automatically scales resources based on the number of connected sessions and the idle duration without session connections.</description></item>
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
        /// <para>Modifies the scaling mode of a delivery group, including fixed quantity (no elastic scaling), scheduled scaling, and automatic scaling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can configure the scaling pattern for WUYING Cloud Application resources in Settings:</para>
        /// <list type="bullet">
        /// <item><description>Fixed quantity: Elastic scaling is not used.</description></item>
        /// <item><description>Automatic scaling: Automatically scales resources based on the number of connected sessions and the idle duration without session connections.</description></item>
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
        /// <para>Modifies the configuration of an administrator account, such as whether to enable resource expiration reminders.</para>
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
        /// <para>Modifies the configuration of an administrator account, such as whether to enable resource expiration reminders.</para>
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
        /// <para>Modifies the configuration of an administrator account, such as whether to enable resource expiration reminders.</para>
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
        /// <para>Modifies the configuration of an administrator account, such as whether to enable resource expiration reminders.</para>
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
        /// <para>Modifies the properties of a cloud graphics workstation.</para>
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
        /// <para>Modifies the properties of a cloud graphics workstation.</para>
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
        /// <para>Modifies the properties of a cloud graphics workstation.</para>
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
        /// <para>Modifies the properties of a cloud graphics workstation.</para>
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
        /// <para>Performs a paged query on allocated users added to a delivery group.</para>
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
        /// <para>Performs a paged query on allocated users added to a delivery group.</para>
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
        /// <para>Performs a paged query on allocated users added to a delivery group.</para>
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
        /// <para>Performs a paged query on allocated users added to a delivery group.</para>
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
        /// <para>You can authorize model groups for resources that belong to Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model groups serve as inference engines for Agents to execute tasks within the resource group.
        /// When an Agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting takes priority over the Agent runtime setting.
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
        /// <para>You can authorize model groups for resources that belong to Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model groups serve as inference engines for Agents to execute tasks within the resource group.
        /// When an Agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting takes priority over the Agent runtime setting.
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
        /// <para>You can authorize model groups for resources that belong to Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model groups serve as inference engines for Agents to execute tasks within the resource group.
        /// When an Agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting takes priority over the Agent runtime setting.
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
        /// <para>You can authorize model groups for resources that belong to Agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the WUYING Agent Management Center. The model groups serve as inference engines for Agents to execute tasks within the resource group.
        /// When an Agent runtime has its own model group configured and the resource group it belongs to also has a model group configured, the model group bound to the resource group takes effect. The resource group setting takes priority over the Agent runtime setting.
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
        /// <para>Removes a third-party channel configuration from an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove a specific third-party channel configuration from agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. After the configuration is removed, the agent can no longer use the third-party channel for conversations.
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
        /// <para>Removes a third-party channel configuration from an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove a specific third-party channel configuration from agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. After the configuration is removed, the agent can no longer use the third-party channel for conversations.
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
        /// <para>Removes a third-party channel configuration from an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove a specific third-party channel configuration from agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. After the configuration is removed, the agent can no longer use the third-party channel for conversations.
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
        /// <para>Removes a third-party channel configuration from an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove a specific third-party channel configuration from agent runtimes such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. After the configuration is removed, the agent can no longer use the third-party channel for conversations.
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
        /// <para>You can remove model groups from Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. When an Agent runtime resource needs to switch to a different model group, call this operation first to remove the authorization relationship between the Agent runtime resource and the existing model group.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before calling this operation.</para>
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
        /// <para>You can remove model groups from Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. When an Agent runtime resource needs to switch to a different model group, call this operation first to remove the authorization relationship between the Agent runtime resource and the existing model group.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before calling this operation.</para>
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
        /// <para>You can remove model groups from Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. When an Agent runtime resource needs to switch to a different model group, call this operation first to remove the authorization relationship between the Agent runtime resource and the existing model group.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before calling this operation.</para>
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
        /// <para>You can remove model groups from Agent runtime resources such as JVS Computer, OpenClaw, and Hermes Agent in the Wuying Agent Management Center. When an Agent runtime resource needs to switch to a different model group, call this operation first to remove the authorization relationship between the Agent runtime resource and the existing model group.
        /// Make sure that you are familiar with the operations and usage of the Wuying Agent Management Center before calling this operation.</para>
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
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/426039.html">Billable methods and pricing</a> of WUYING Workspace.</para>
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
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/426039.html">Billable methods and pricing</a> of WUYING Workspace.</para>
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
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/426039.html">Billable methods and pricing</a> of WUYING Workspace.</para>
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
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/426039.html">Billable methods and pricing</a> of WUYING Workspace.</para>
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
        /// <para>Creates and attaches tags to cloud resources. If a tag already exists on a resource, the tag value is updated.</para>
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
        /// <para>Creates and attaches tags to cloud resources. If a tag already exists on a resource, the tag value is updated.</para>
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
        /// <para>Creates and attaches tags to cloud resources. If a tag already exists on a resource, the tag value is updated.</para>
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
        /// <para>Creates and attaches tags to cloud resources. If a tag already exists on a resource, the tag value is updated.</para>
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
        /// <para>解绑研发主机的辅助私有IP</para>
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
        /// <para>解绑研发主机的辅助私有IP</para>
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
        /// <para>解绑研发主机的辅助私有IP</para>
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
        /// <para>解绑研发主机的辅助私有IP</para>
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
        /// <para>Updates the image of a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Warning: After the image update starts, sessions of end users who are accessing cloud applications will be disconnected. Proceed with caution to avoid data loss for end users.
        /// After the update is published, changes typically take about 2 minutes to take effect on the end user side.</para>
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
        /// After the update is published, changes typically take about 2 minutes to take effect on the end user side.</para>
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
        /// After the update is published, changes typically take about 2 minutes to take effect on the end user side.</para>
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
        /// After the update is published, changes typically take about 2 minutes to take effect on the end user side.</para>
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
        /// <para>You can update a model provider template that has been created in the Wuying Agent Management Center, including the template name, description, model service connection configuration, and Wuying security proxy switch. Partial field updates are supported. You only need to pass in the fields that you want to modify.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can update a model provider template that has been created in the Wuying Agent Management Center, including the template name, description, model service connection configuration, and Wuying security proxy switch. Partial field updates are supported. You only need to pass in the fields that you want to modify.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can update a model provider template that has been created in the Wuying Agent Management Center, including the template name, description, model service connection configuration, and Wuying security proxy switch. Partial field updates are supported. You only need to pass in the fields that you want to modify.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can update a model provider template that has been created in the Wuying Agent Management Center, including the template name, description, model service connection configuration, and Wuying security proxy switch. Partial field updates are supported. You only need to pass in the fields that you want to modify.
        /// Before you call this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can update a model group that has been created in the Wuying Agent Management Center, including the group name, description, and model configuration information. The updated configuration automatically takes effect on associated cloud desktops.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can update a model group that has been created in the Wuying Agent Management Center, including the group name, description, and model configuration information. The updated configuration automatically takes effect on associated cloud desktops.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can update a model group that has been created in the Wuying Agent Management Center, including the group name, description, and model configuration information. The updated configuration automatically takes effect on associated cloud desktops.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
        /// <para>You can update a model group that has been created in the Wuying Agent Management Center, including the group name, description, and model configuration information. The updated configuration automatically takes effect on associated cloud desktops.
        /// Before using this operation, make sure that you are familiar with the operations and usage of the Wuying Agent Management Center.</para>
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
