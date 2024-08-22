// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Aiccs20230516.Models;

namespace AlibabaCloud.SDK.Aiccs20230516
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aiccs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 添加黑名单接口
         *
         * @param tmpReq AddBlacklistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddBlacklistResponse
         */
        public AddBlacklistResponse AddBlacklistWithOptions(AddBlacklistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddBlacklistShrinkRequest request = new AddBlacklistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredDay))
            {
                query["ExpiredDay"] = request.ExpiredDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBlacklist",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBlacklistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加黑名单接口
         *
         * @param tmpReq AddBlacklistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddBlacklistResponse
         */
        public async Task<AddBlacklistResponse> AddBlacklistWithOptionsAsync(AddBlacklistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddBlacklistShrinkRequest request = new AddBlacklistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredDay))
            {
                query["ExpiredDay"] = request.ExpiredDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBlacklist",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBlacklistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加黑名单接口
         *
         * @param request AddBlacklistRequest
         * @return AddBlacklistResponse
         */
        public AddBlacklistResponse AddBlacklist(AddBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBlacklistWithOptions(request, runtime);
        }

        /**
         * @summary 添加黑名单接口
         *
         * @param request AddBlacklistRequest
         * @return AddBlacklistResponse
         */
        public async Task<AddBlacklistResponse> AddBlacklistAsync(AddBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBlacklistWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建任务接口
         *
         * @param tmpReq AddTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTaskResponse
         */
        public AddTaskResponse AddTaskWithOptions(AddTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddTaskShrinkRequest request = new AddTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallTimeList))
            {
                request.CallTimeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallTimeList, "CallTimeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatReason))
            {
                request.RepeatReasonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatReason, "RepeatReason", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatTimes))
            {
                request.RepeatTimesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatTimes, "RepeatTimes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SendSmsPlan))
            {
                request.SendSmsPlanShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SendSmsPlan, "SendSmsPlan", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTimeListShrink))
            {
                query["CallTimeList"] = request.CallTimeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsTemplateId))
            {
                query["FlashSmsTemplateId"] = request.FlashSmsTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsType))
            {
                query["FlashSmsType"] = request.FlashSmsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaySleepVal))
            {
                query["PlaySleepVal"] = request.PlaySleepVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallType))
            {
                query["RecallType"] = request.RecallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordPath))
            {
                query["RecordPath"] = request.RecordPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatCount))
            {
                query["RepeatCount"] = request.RepeatCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatInterval))
            {
                query["RepeatInterval"] = request.RepeatInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatReasonShrink))
            {
                query["RepeatReason"] = request.RepeatReasonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatTimesShrink))
            {
                query["RepeatTimes"] = request.RepeatTimesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendSmsPlanShrink))
            {
                query["SendSmsPlan"] = request.SendSmsPlanShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTask",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建任务接口
         *
         * @param tmpReq AddTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTaskResponse
         */
        public async Task<AddTaskResponse> AddTaskWithOptionsAsync(AddTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddTaskShrinkRequest request = new AddTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallTimeList))
            {
                request.CallTimeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallTimeList, "CallTimeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatReason))
            {
                request.RepeatReasonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatReason, "RepeatReason", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatTimes))
            {
                request.RepeatTimesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatTimes, "RepeatTimes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SendSmsPlan))
            {
                request.SendSmsPlanShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SendSmsPlan, "SendSmsPlan", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTimeListShrink))
            {
                query["CallTimeList"] = request.CallTimeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsTemplateId))
            {
                query["FlashSmsTemplateId"] = request.FlashSmsTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsType))
            {
                query["FlashSmsType"] = request.FlashSmsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaySleepVal))
            {
                query["PlaySleepVal"] = request.PlaySleepVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallType))
            {
                query["RecallType"] = request.RecallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordPath))
            {
                query["RecordPath"] = request.RecordPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatCount))
            {
                query["RepeatCount"] = request.RepeatCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatInterval))
            {
                query["RepeatInterval"] = request.RepeatInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatReasonShrink))
            {
                query["RepeatReason"] = request.RepeatReasonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatTimesShrink))
            {
                query["RepeatTimes"] = request.RepeatTimesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendSmsPlanShrink))
            {
                query["SendSmsPlan"] = request.SendSmsPlanShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTask",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建任务接口
         *
         * @param request AddTaskRequest
         * @return AddTaskResponse
         */
        public AddTaskResponse AddTask(AddTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建任务接口
         *
         * @param request AddTaskRequest
         * @return AddTaskResponse
         */
        public async Task<AddTaskResponse> AddTaskAsync(AddTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 坐席取消号码外呼
         *
         * @param tmpReq AgentCancelCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgentCancelCallResponse
         */
        public AgentCancelCallResponse AgentCancelCallWithOptions(AgentCancelCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgentCancelCallShrinkRequest request = new AgentCancelCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTag))
            {
                query["AgentTag"] = request.AgentTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AgentCancelCall",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgentCancelCallResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 坐席取消号码外呼
         *
         * @param tmpReq AgentCancelCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgentCancelCallResponse
         */
        public async Task<AgentCancelCallResponse> AgentCancelCallWithOptionsAsync(AgentCancelCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgentCancelCallShrinkRequest request = new AgentCancelCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTag))
            {
                query["AgentTag"] = request.AgentTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AgentCancelCall",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgentCancelCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 坐席取消号码外呼
         *
         * @param request AgentCancelCallRequest
         * @return AgentCancelCallResponse
         */
        public AgentCancelCallResponse AgentCancelCall(AgentCancelCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AgentCancelCallWithOptions(request, runtime);
        }

        /**
         * @summary 坐席取消号码外呼
         *
         * @param request AgentCancelCallRequest
         * @return AgentCancelCallResponse
         */
        public async Task<AgentCancelCallResponse> AgentCancelCallAsync(AgentCancelCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AgentCancelCallWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 坐席任务恢复号码
         *
         * @param tmpReq AgentRecoverCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgentRecoverCallResponse
         */
        public AgentRecoverCallResponse AgentRecoverCallWithOptions(AgentRecoverCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgentRecoverCallShrinkRequest request = new AgentRecoverCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTag))
            {
                query["AgentTag"] = request.AgentTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginImportTime))
            {
                query["BeginImportTime"] = request.BeginImportTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndImportTime))
            {
                query["EndImportTime"] = request.EndImportTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AgentRecoverCall",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgentRecoverCallResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 坐席任务恢复号码
         *
         * @param tmpReq AgentRecoverCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgentRecoverCallResponse
         */
        public async Task<AgentRecoverCallResponse> AgentRecoverCallWithOptionsAsync(AgentRecoverCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AgentRecoverCallShrinkRequest request = new AgentRecoverCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTag))
            {
                query["AgentTag"] = request.AgentTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginImportTime))
            {
                query["BeginImportTime"] = request.BeginImportTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndImportTime))
            {
                query["EndImportTime"] = request.EndImportTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AgentRecoverCall",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgentRecoverCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 坐席任务恢复号码
         *
         * @param request AgentRecoverCallRequest
         * @return AgentRecoverCallResponse
         */
        public AgentRecoverCallResponse AgentRecoverCall(AgentRecoverCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AgentRecoverCallWithOptions(request, runtime);
        }

        /**
         * @summary 坐席任务恢复号码
         *
         * @param request AgentRecoverCallRequest
         * @return AgentRecoverCallResponse
         */
        public async Task<AgentRecoverCallResponse> AgentRecoverCallAsync(AgentRecoverCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AgentRecoverCallWithOptionsAsync(request, runtime);
        }

        /**
         * @summary AI批量任务查询号码状态接口
         *
         * @param tmpReq DetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetailsResponse
         */
        public DetailsResponse DetailsWithOptions(DetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetailsShrinkRequest request = new DetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberStatus))
            {
                query["NumberStatus"] = request.NumberStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Details",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary AI批量任务查询号码状态接口
         *
         * @param tmpReq DetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetailsResponse
         */
        public async Task<DetailsResponse> DetailsWithOptionsAsync(DetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetailsShrinkRequest request = new DetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberStatus))
            {
                query["NumberStatus"] = request.NumberStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Details",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary AI批量任务查询号码状态接口
         *
         * @param request DetailsRequest
         * @return DetailsResponse
         */
        public DetailsResponse Details(DetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetailsWithOptions(request, runtime);
        }

        /**
         * @summary AI批量任务查询号码状态接口
         *
         * @param request DetailsRequest
         * @return DetailsResponse
         */
        public async Task<DetailsResponse> DetailsAsync(DetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 编辑任务接口
         *
         * @param tmpReq EditTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditTaskResponse
         */
        public EditTaskResponse EditTaskWithOptions(EditTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EditTaskShrinkRequest request = new EditTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallTimeList))
            {
                request.CallTimeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallTimeList, "CallTimeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatReason))
            {
                request.RepeatReasonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatReason, "RepeatReason", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatTimes))
            {
                request.RepeatTimesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatTimes, "RepeatTimes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SendSmsPlan))
            {
                request.SendSmsPlanShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SendSmsPlan, "SendSmsPlan", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTimeListShrink))
            {
                query["CallTimeList"] = request.CallTimeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsTemplateId))
            {
                query["FlashSmsTemplateId"] = request.FlashSmsTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsType))
            {
                query["FlashSmsType"] = request.FlashSmsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaySleepVal))
            {
                query["PlaySleepVal"] = request.PlaySleepVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallType))
            {
                query["RecallType"] = request.RecallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordPath))
            {
                query["RecordPath"] = request.RecordPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatCount))
            {
                query["RepeatCount"] = request.RepeatCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatInterval))
            {
                query["RepeatInterval"] = request.RepeatInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatReasonShrink))
            {
                query["RepeatReason"] = request.RepeatReasonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatTimesShrink))
            {
                query["RepeatTimes"] = request.RepeatTimesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendSmsPlanShrink))
            {
                query["SendSmsPlan"] = request.SendSmsPlanShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditTask",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编辑任务接口
         *
         * @param tmpReq EditTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditTaskResponse
         */
        public async Task<EditTaskResponse> EditTaskWithOptionsAsync(EditTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EditTaskShrinkRequest request = new EditTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallTimeList))
            {
                request.CallTimeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallTimeList, "CallTimeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatReason))
            {
                request.RepeatReasonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatReason, "RepeatReason", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatTimes))
            {
                request.RepeatTimesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatTimes, "RepeatTimes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SendSmsPlan))
            {
                request.SendSmsPlanShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SendSmsPlan, "SendSmsPlan", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTimeListShrink))
            {
                query["CallTimeList"] = request.CallTimeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsTemplateId))
            {
                query["FlashSmsTemplateId"] = request.FlashSmsTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsType))
            {
                query["FlashSmsType"] = request.FlashSmsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaySleepVal))
            {
                query["PlaySleepVal"] = request.PlaySleepVal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallType))
            {
                query["RecallType"] = request.RecallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordPath))
            {
                query["RecordPath"] = request.RecordPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatCount))
            {
                query["RepeatCount"] = request.RepeatCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatInterval))
            {
                query["RepeatInterval"] = request.RepeatInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatReasonShrink))
            {
                query["RepeatReason"] = request.RepeatReasonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatTimesShrink))
            {
                query["RepeatTimes"] = request.RepeatTimesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendSmsPlanShrink))
            {
                query["SendSmsPlan"] = request.SendSmsPlanShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditTask",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑任务接口
         *
         * @param request EditTaskRequest
         * @return EditTaskResponse
         */
        public EditTaskResponse EditTask(EditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditTaskWithOptions(request, runtime);
        }

        /**
         * @summary 编辑任务接口
         *
         * @param request EditTaskRequest
         * @return EditTaskResponse
         */
        public async Task<EditTaskResponse> EditTaskAsync(EditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导入号码
         *
         * @param tmpReq ImportNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportNumberResponse
         */
        public ImportNumberResponse ImportNumberWithOptions(ImportNumberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportNumberShrinkRequest request = new ImportNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Customers))
            {
                request.CustomersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Customers, "Customers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomersShrink))
            {
                query["Customers"] = request.CustomersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailReturn))
            {
                query["FailReturn"] = request.FailReturn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportNumber",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportNumberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导入号码
         *
         * @param tmpReq ImportNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportNumberResponse
         */
        public async Task<ImportNumberResponse> ImportNumberWithOptionsAsync(ImportNumberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportNumberShrinkRequest request = new ImportNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Customers))
            {
                request.CustomersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Customers, "Customers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomersShrink))
            {
                query["Customers"] = request.CustomersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailReturn))
            {
                query["FailReturn"] = request.FailReturn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportNumber",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导入号码
         *
         * @param request ImportNumberRequest
         * @return ImportNumberResponse
         */
        public ImportNumberResponse ImportNumber(ImportNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportNumberWithOptions(request, runtime);
        }

        /**
         * @summary 导入号码
         *
         * @param request ImportNumberRequest
         * @return ImportNumberResponse
         */
        public async Task<ImportNumberResponse> ImportNumberAsync(ImportNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportNumberWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询企业黑名单
         *
         * @param tmpReq PageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageResponse
         */
        public PageResponse PageWithOptions(PageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PageShrinkRequest request = new PageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Page",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询企业黑名单
         *
         * @param tmpReq PageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageResponse
         */
        public async Task<PageResponse> PageWithOptionsAsync(PageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PageShrinkRequest request = new PageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Page",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询企业黑名单
         *
         * @param request PageRequest
         * @return PageResponse
         */
        public PageResponse Page(PageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageWithOptions(request, runtime);
        }

        /**
         * @summary 查询企业黑名单
         *
         * @param request PageRequest
         * @return PageResponse
         */
        public async Task<PageResponse> PageAsync(PageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 短信模板创建
         *
         * @param request SmsTemplateCreateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SmsTemplateCreateResponse
         */
        public SmsTemplateCreateResponse SmsTemplateCreateWithOptions(SmsTemplateCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sign))
            {
                query["Sign"] = request.Sign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsType))
            {
                query["SmsType"] = request.SmsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmsTemplateCreate",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmsTemplateCreateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 短信模板创建
         *
         * @param request SmsTemplateCreateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SmsTemplateCreateResponse
         */
        public async Task<SmsTemplateCreateResponse> SmsTemplateCreateWithOptionsAsync(SmsTemplateCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sign))
            {
                query["Sign"] = request.Sign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsType))
            {
                query["SmsType"] = request.SmsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmsTemplateCreate",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmsTemplateCreateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 短信模板创建
         *
         * @param request SmsTemplateCreateRequest
         * @return SmsTemplateCreateResponse
         */
        public SmsTemplateCreateResponse SmsTemplateCreate(SmsTemplateCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SmsTemplateCreateWithOptions(request, runtime);
        }

        /**
         * @summary 短信模板创建
         *
         * @param request SmsTemplateCreateRequest
         * @return SmsTemplateCreateResponse
         */
        public async Task<SmsTemplateCreateResponse> SmsTemplateCreateAsync(SmsTemplateCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SmsTemplateCreateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 短信模板列表查询
         *
         * @param request SmsTemplatePageListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SmsTemplatePageListResponse
         */
        public SmsTemplatePageListResponse SmsTemplatePageListWithOptions(SmsTemplatePageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sign))
            {
                query["Sign"] = request.Sign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsType))
            {
                query["SmsType"] = request.SmsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmsTemplatePageList",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmsTemplatePageListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 短信模板列表查询
         *
         * @param request SmsTemplatePageListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SmsTemplatePageListResponse
         */
        public async Task<SmsTemplatePageListResponse> SmsTemplatePageListWithOptionsAsync(SmsTemplatePageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sign))
            {
                query["Sign"] = request.Sign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsType))
            {
                query["SmsType"] = request.SmsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmsTemplatePageList",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmsTemplatePageListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 短信模板列表查询
         *
         * @param request SmsTemplatePageListRequest
         * @return SmsTemplatePageListResponse
         */
        public SmsTemplatePageListResponse SmsTemplatePageList(SmsTemplatePageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SmsTemplatePageListWithOptions(request, runtime);
        }

        /**
         * @summary 短信模板列表查询
         *
         * @param request SmsTemplatePageListRequest
         * @return SmsTemplatePageListResponse
         */
        public async Task<SmsTemplatePageListResponse> SmsTemplatePageListAsync(SmsTemplatePageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SmsTemplatePageListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询聊天记录接口
         *
         * @param request TaskCallChatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskCallChatsResponse
         */
        public TaskCallChatsResponse TaskCallChatsWithOptions(TaskCallChatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTag))
            {
                query["AgentTag"] = request.AgentTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskCallChats",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskCallChatsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询聊天记录接口
         *
         * @param request TaskCallChatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskCallChatsResponse
         */
        public async Task<TaskCallChatsResponse> TaskCallChatsWithOptionsAsync(TaskCallChatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTag))
            {
                query["AgentTag"] = request.AgentTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskCallChats",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskCallChatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询聊天记录接口
         *
         * @param request TaskCallChatsRequest
         * @return TaskCallChatsResponse
         */
        public TaskCallChatsResponse TaskCallChats(TaskCallChatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaskCallChatsWithOptions(request, runtime);
        }

        /**
         * @summary 查询聊天记录接口
         *
         * @param request TaskCallChatsRequest
         * @return TaskCallChatsResponse
         */
        public async Task<TaskCallChatsResponse> TaskCallChatsAsync(TaskCallChatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaskCallChatsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取任务外呼情况接口
         *
         * @param request TaskCallInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskCallInfoResponse
         */
        public TaskCallInfoResponse TaskCallInfoWithOptions(TaskCallInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskCallInfo",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskCallInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务外呼情况接口
         *
         * @param request TaskCallInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskCallInfoResponse
         */
        public async Task<TaskCallInfoResponse> TaskCallInfoWithOptionsAsync(TaskCallInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskCallInfo",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskCallInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务外呼情况接口
         *
         * @param request TaskCallInfoRequest
         * @return TaskCallInfoResponse
         */
        public TaskCallInfoResponse TaskCallInfo(TaskCallInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaskCallInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取任务外呼情况接口
         *
         * @param request TaskCallInfoRequest
         * @return TaskCallInfoResponse
         */
        public async Task<TaskCallInfoResponse> TaskCallInfoAsync(TaskCallInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaskCallInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary AI批量任务查询外呼记录接口
         *
         * @param tmpReq TaskCallListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskCallListResponse
         */
        public TaskCallListResponse TaskCallListWithOptions(TaskCallListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TaskCallListShrinkRequest request = new TaskCallListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentTags))
            {
                request.IntentTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentTags, "IntentTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDate))
            {
                query["CallDate"] = request.CallDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCallDate))
            {
                query["EndCallDate"] = request.EndCallDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentTagsShrink))
            {
                query["IntentTags"] = request.IntentTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskCallList",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskCallListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary AI批量任务查询外呼记录接口
         *
         * @param tmpReq TaskCallListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskCallListResponse
         */
        public async Task<TaskCallListResponse> TaskCallListWithOptionsAsync(TaskCallListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TaskCallListShrinkRequest request = new TaskCallListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IntentTags))
            {
                request.IntentTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IntentTags, "IntentTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallDate))
            {
                query["CallDate"] = request.CallDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCallDate))
            {
                query["EndCallDate"] = request.EndCallDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentTagsShrink))
            {
                query["IntentTags"] = request.IntentTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskCallList",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskCallListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary AI批量任务查询外呼记录接口
         *
         * @param request TaskCallListRequest
         * @return TaskCallListResponse
         */
        public TaskCallListResponse TaskCallList(TaskCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaskCallListWithOptions(request, runtime);
        }

        /**
         * @summary AI批量任务查询外呼记录接口
         *
         * @param request TaskCallListRequest
         * @return TaskCallListResponse
         */
        public async Task<TaskCallListResponse> TaskCallListAsync(TaskCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaskCallListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量任务取消号码外呼
         *
         * @param tmpReq TaskCancelCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskCancelCallResponse
         */
        public TaskCancelCallResponse TaskCancelCallWithOptions(TaskCancelCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TaskCancelCallShrinkRequest request = new TaskCancelCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskCancelCall",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskCancelCallResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量任务取消号码外呼
         *
         * @param tmpReq TaskCancelCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskCancelCallResponse
         */
        public async Task<TaskCancelCallResponse> TaskCancelCallWithOptionsAsync(TaskCancelCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TaskCancelCallShrinkRequest request = new TaskCancelCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskCancelCall",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskCancelCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量任务取消号码外呼
         *
         * @param request TaskCancelCallRequest
         * @return TaskCancelCallResponse
         */
        public TaskCancelCallResponse TaskCancelCall(TaskCancelCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaskCancelCallWithOptions(request, runtime);
        }

        /**
         * @summary 批量任务取消号码外呼
         *
         * @param request TaskCancelCallRequest
         * @return TaskCancelCallResponse
         */
        public async Task<TaskCancelCallResponse> TaskCancelCallAsync(TaskCancelCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaskCancelCallWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询任务列表接口
         *
         * @param request TaskListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskListResponse
         */
        public TaskListResponse TaskListWithOptions(TaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastCallTime))
            {
                query["LastCallTime"] = request.LastCallTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskList",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询任务列表接口
         *
         * @param request TaskListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskListResponse
         */
        public async Task<TaskListResponse> TaskListWithOptionsAsync(TaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastCallTime))
            {
                query["LastCallTime"] = request.LastCallTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskList",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询任务列表接口
         *
         * @param request TaskListRequest
         * @return TaskListResponse
         */
        public TaskListResponse TaskList(TaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaskListWithOptions(request, runtime);
        }

        /**
         * @summary 查询任务列表接口
         *
         * @param request TaskListRequest
         * @return TaskListResponse
         */
        public async Task<TaskListResponse> TaskListAsync(TaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaskListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量任务恢复号码
         *
         * @param tmpReq TaskRecoverCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskRecoverCallResponse
         */
        public TaskRecoverCallResponse TaskRecoverCallWithOptions(TaskRecoverCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TaskRecoverCallShrinkRequest request = new TaskRecoverCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginImportTime))
            {
                query["BeginImportTime"] = request.BeginImportTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndImportTime))
            {
                query["EndImportTime"] = request.EndImportTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskRecoverCall",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskRecoverCallResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量任务恢复号码
         *
         * @param tmpReq TaskRecoverCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskRecoverCallResponse
         */
        public async Task<TaskRecoverCallResponse> TaskRecoverCallWithOptionsAsync(TaskRecoverCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TaskRecoverCallShrinkRequest request = new TaskRecoverCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Numbers))
            {
                request.NumbersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Numbers, "Numbers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginImportTime))
            {
                query["BeginImportTime"] = request.BeginImportTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndImportTime))
            {
                query["EndImportTime"] = request.EndImportTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumbersShrink))
            {
                query["Numbers"] = request.NumbersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaskRecoverCall",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskRecoverCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量任务恢复号码
         *
         * @param request TaskRecoverCallRequest
         * @return TaskRecoverCallResponse
         */
        public TaskRecoverCallResponse TaskRecoverCall(TaskRecoverCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaskRecoverCallWithOptions(request, runtime);
        }

        /**
         * @summary 批量任务恢复号码
         *
         * @param request TaskRecoverCallRequest
         * @return TaskRecoverCallResponse
         */
        public async Task<TaskRecoverCallResponse> TaskRecoverCallAsync(TaskRecoverCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaskRecoverCallWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 话术模板列表查询接口
         *
         * @param request TemplateListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TemplateListResponse
         */
        public TemplateListResponse TemplateListWithOptions(TemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TemplateList",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TemplateListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 话术模板列表查询接口
         *
         * @param request TemplateListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TemplateListResponse
         */
        public async Task<TemplateListResponse> TemplateListWithOptionsAsync(TemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TemplateList",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TemplateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 话术模板列表查询接口
         *
         * @param request TemplateListRequest
         * @return TemplateListResponse
         */
        public TemplateListResponse TemplateList(TemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TemplateListWithOptions(request, runtime);
        }

        /**
         * @summary 话术模板列表查询接口
         *
         * @param request TemplateListRequest
         * @return TemplateListResponse
         */
        public async Task<TemplateListResponse> TemplateListAsync(TemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TemplateListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改坐席状态
         *
         * @param request UpdateAgentStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAgentStatusResponse
         */
        public UpdateAgentStatusResponse UpdateAgentStatusWithOptions(UpdateAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentStatus))
            {
                query["AgentStatus"] = request.AgentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTag))
            {
                query["AgentTag"] = request.AgentTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentStatus",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改坐席状态
         *
         * @param request UpdateAgentStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAgentStatusResponse
         */
        public async Task<UpdateAgentStatusResponse> UpdateAgentStatusWithOptionsAsync(UpdateAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentStatus))
            {
                query["AgentStatus"] = request.AgentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTag))
            {
                query["AgentTag"] = request.AgentTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentStatus",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改坐席状态
         *
         * @param request UpdateAgentStatusRequest
         * @return UpdateAgentStatusResponse
         */
        public UpdateAgentStatusResponse UpdateAgentStatus(UpdateAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgentStatusWithOptions(request, runtime);
        }

        /**
         * @summary 修改坐席状态
         *
         * @param request UpdateAgentStatusRequest
         * @return UpdateAgentStatusResponse
         */
        public async Task<UpdateAgentStatusResponse> UpdateAgentStatusAsync(UpdateAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgentStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新当天导入的号码
         *
         * @param tmpReq UpdateTaskCustomerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskCustomerResponse
         */
        public UpdateTaskCustomerResponse UpdateTaskCustomerWithOptions(UpdateTaskCustomerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTaskCustomerShrinkRequest request = new UpdateTaskCustomerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Customers))
            {
                request.CustomersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Customers, "Customers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomersShrink))
            {
                query["Customers"] = request.CustomersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskCustomer",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskCustomerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新当天导入的号码
         *
         * @param tmpReq UpdateTaskCustomerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskCustomerResponse
         */
        public async Task<UpdateTaskCustomerResponse> UpdateTaskCustomerWithOptionsAsync(UpdateTaskCustomerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTaskCustomerShrinkRequest request = new UpdateTaskCustomerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Customers))
            {
                request.CustomersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Customers, "Customers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomersShrink))
            {
                query["Customers"] = request.CustomersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskCustomer",
                Version = "2023-05-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskCustomerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新当天导入的号码
         *
         * @param request UpdateTaskCustomerRequest
         * @return UpdateTaskCustomerResponse
         */
        public UpdateTaskCustomerResponse UpdateTaskCustomer(UpdateTaskCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTaskCustomerWithOptions(request, runtime);
        }

        /**
         * @summary 更新当天导入的号码
         *
         * @param request UpdateTaskCustomerRequest
         * @return UpdateTaskCustomerResponse
         */
        public async Task<UpdateTaskCustomerResponse> UpdateTaskCustomerAsync(UpdateTaskCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTaskCustomerWithOptionsAsync(request, runtime);
        }

    }
}
