// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Support_plan20210706.Models;

namespace AlibabaCloud.SDK.Support_plan20210706
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("support-plan", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 关闭任务单
         *
         * @param request CloseTaskOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseTaskOrderResponse
         */
        public CloseTaskOrderResponse CloseTaskOrderWithOptions(CloseTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseTaskOrder",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTaskOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 关闭任务单
         *
         * @param request CloseTaskOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseTaskOrderResponse
         */
        public async Task<CloseTaskOrderResponse> CloseTaskOrderWithOptionsAsync(CloseTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseTaskOrder",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 关闭任务单
         *
         * @param request CloseTaskOrderRequest
         * @return CloseTaskOrderResponse
         */
        public CloseTaskOrderResponse CloseTaskOrder(CloseTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseTaskOrderWithOptions(request, runtime);
        }

        /**
         * @summary 关闭任务单
         *
         * @param request CloseTaskOrderRequest
         * @return CloseTaskOrderResponse
         */
        public async Task<CloseTaskOrderResponse> CloseTaskOrderAsync(CloseTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseTaskOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建工单
         *
         * @param request CreateTaskOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskOrderResponse
         */
        public CreateTaskOrderResponse CreateTaskOrderWithOptions(CreateTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                query["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsUrgent))
            {
                query["IsUrgent"] = request.IsUrgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overview))
            {
                query["Overview"] = request.Overview;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrgentDescription))
            {
                query["UrgentDescription"] = request.UrgentDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTaskOrder",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建工单
         *
         * @param request CreateTaskOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskOrderResponse
         */
        public async Task<CreateTaskOrderResponse> CreateTaskOrderWithOptionsAsync(CreateTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                query["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsUrgent))
            {
                query["IsUrgent"] = request.IsUrgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overview))
            {
                query["Overview"] = request.Overview;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrgentDescription))
            {
                query["UrgentDescription"] = request.UrgentDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTaskOrder",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建工单
         *
         * @param request CreateTaskOrderRequest
         * @return CreateTaskOrderResponse
         */
        public CreateTaskOrderResponse CreateTaskOrder(CreateTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskOrderWithOptions(request, runtime);
        }

        /**
         * @summary 创建工单
         *
         * @param request CreateTaskOrderRequest
         * @return CreateTaskOrderResponse
         */
        public async Task<CreateTaskOrderResponse> CreateTaskOrderAsync(CreateTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 告警建单
         *
         * @param tmpReq CreateTaskOrderByEventReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskOrderByEventReportResponse
         */
        public CreateTaskOrderByEventReportResponse CreateTaskOrderByEventReportWithOptions(CreateTaskOrderByEventReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTaskOrderByEventReportShrinkRequest request = new CreateTaskOrderByEventReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventBody))
            {
                request.EventBodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventBody, "EventBody", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extinfo))
            {
                request.ExtinfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extinfo, "Extinfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateRealName))
            {
                query["CreateRealName"] = request.CreateRealName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                query["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBodyShrink))
            {
                query["EventBody"] = request.EventBodyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtinfoShrink))
            {
                query["Extinfo"] = request.ExtinfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportantDesc))
            {
                query["ImportantDesc"] = request.ImportantDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinChildGroupUserIds))
            {
                query["JoinChildGroupUserIds"] = request.JoinChildGroupUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorCongregation))
            {
                query["MonitorCongregation"] = request.MonitorCongregation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
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
                Action = "CreateTaskOrderByEventReport",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskOrderByEventReportResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 告警建单
         *
         * @param tmpReq CreateTaskOrderByEventReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskOrderByEventReportResponse
         */
        public async Task<CreateTaskOrderByEventReportResponse> CreateTaskOrderByEventReportWithOptionsAsync(CreateTaskOrderByEventReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTaskOrderByEventReportShrinkRequest request = new CreateTaskOrderByEventReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventBody))
            {
                request.EventBodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventBody, "EventBody", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extinfo))
            {
                request.ExtinfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extinfo, "Extinfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateRealName))
            {
                query["CreateRealName"] = request.CreateRealName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                query["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBodyShrink))
            {
                query["EventBody"] = request.EventBodyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtinfoShrink))
            {
                query["Extinfo"] = request.ExtinfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportantDesc))
            {
                query["ImportantDesc"] = request.ImportantDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinChildGroupUserIds))
            {
                query["JoinChildGroupUserIds"] = request.JoinChildGroupUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorCongregation))
            {
                query["MonitorCongregation"] = request.MonitorCongregation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
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
                Action = "CreateTaskOrderByEventReport",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskOrderByEventReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 告警建单
         *
         * @param request CreateTaskOrderByEventReportRequest
         * @return CreateTaskOrderByEventReportResponse
         */
        public CreateTaskOrderByEventReportResponse CreateTaskOrderByEventReport(CreateTaskOrderByEventReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskOrderByEventReportWithOptions(request, runtime);
        }

        /**
         * @summary 告警建单
         *
         * @param request CreateTaskOrderByEventReportRequest
         * @return CreateTaskOrderByEventReportResponse
         */
        public async Task<CreateTaskOrderByEventReportResponse> CreateTaskOrderByEventReportAsync(CreateTaskOrderByEventReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskOrderByEventReportWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除企业钉群客户侧成员
         *
         * @param tmpReq DeleteEnterpriseDingtalkGroupCustomerMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEnterpriseDingtalkGroupCustomerMemberResponse
         */
        public DeleteEnterpriseDingtalkGroupCustomerMemberResponse DeleteEnterpriseDingtalkGroupCustomerMemberWithOptions(DeleteEnterpriseDingtalkGroupCustomerMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest request = new DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Mobiles))
            {
                request.MobilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Mobiles, "Mobiles", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilesShrink))
            {
                body["Mobiles"] = request.MobilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                body["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnterpriseDingtalkGroupCustomerMember",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnterpriseDingtalkGroupCustomerMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除企业钉群客户侧成员
         *
         * @param tmpReq DeleteEnterpriseDingtalkGroupCustomerMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEnterpriseDingtalkGroupCustomerMemberResponse
         */
        public async Task<DeleteEnterpriseDingtalkGroupCustomerMemberResponse> DeleteEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(DeleteEnterpriseDingtalkGroupCustomerMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest request = new DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Mobiles))
            {
                request.MobilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Mobiles, "Mobiles", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilesShrink))
            {
                body["Mobiles"] = request.MobilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                body["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnterpriseDingtalkGroupCustomerMember",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnterpriseDingtalkGroupCustomerMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除企业钉群客户侧成员
         *
         * @param request DeleteEnterpriseDingtalkGroupCustomerMemberRequest
         * @return DeleteEnterpriseDingtalkGroupCustomerMemberResponse
         */
        public DeleteEnterpriseDingtalkGroupCustomerMemberResponse DeleteEnterpriseDingtalkGroupCustomerMember(DeleteEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEnterpriseDingtalkGroupCustomerMemberWithOptions(request, runtime);
        }

        /**
         * @summary 删除企业钉群客户侧成员
         *
         * @param request DeleteEnterpriseDingtalkGroupCustomerMemberRequest
         * @return DeleteEnterpriseDingtalkGroupCustomerMemberResponse
         */
        public async Task<DeleteEnterpriseDingtalkGroupCustomerMemberResponse> DeleteEnterpriseDingtalkGroupCustomerMemberAsync(DeleteEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询企业钉群
         *
         * @param request GetEnterpriseDingtalkGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnterpriseDingtalkGroupResponse
         */
        public GetEnterpriseDingtalkGroupResponse GetEnterpriseDingtalkGroupWithOptions(GetEnterpriseDingtalkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                body["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnterpriseDingtalkGroup",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnterpriseDingtalkGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询企业钉群
         *
         * @param request GetEnterpriseDingtalkGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnterpriseDingtalkGroupResponse
         */
        public async Task<GetEnterpriseDingtalkGroupResponse> GetEnterpriseDingtalkGroupWithOptionsAsync(GetEnterpriseDingtalkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                body["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnterpriseDingtalkGroup",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnterpriseDingtalkGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询企业钉群
         *
         * @param request GetEnterpriseDingtalkGroupRequest
         * @return GetEnterpriseDingtalkGroupResponse
         */
        public GetEnterpriseDingtalkGroupResponse GetEnterpriseDingtalkGroup(GetEnterpriseDingtalkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEnterpriseDingtalkGroupWithOptions(request, runtime);
        }

        /**
         * @summary 查询企业钉群
         *
         * @param request GetEnterpriseDingtalkGroupRequest
         * @return GetEnterpriseDingtalkGroupResponse
         */
        public async Task<GetEnterpriseDingtalkGroupResponse> GetEnterpriseDingtalkGroupAsync(GetEnterpriseDingtalkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEnterpriseDingtalkGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取企业钉群客户侧成员
         *
         * @param request GetEnterpriseDingtalkGroupCustomerMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnterpriseDingtalkGroupCustomerMemberResponse
         */
        public GetEnterpriseDingtalkGroupCustomerMemberResponse GetEnterpriseDingtalkGroupCustomerMemberWithOptions(GetEnterpriseDingtalkGroupCustomerMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                body["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnterpriseDingtalkGroupCustomerMember",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnterpriseDingtalkGroupCustomerMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取企业钉群客户侧成员
         *
         * @param request GetEnterpriseDingtalkGroupCustomerMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnterpriseDingtalkGroupCustomerMemberResponse
         */
        public async Task<GetEnterpriseDingtalkGroupCustomerMemberResponse> GetEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(GetEnterpriseDingtalkGroupCustomerMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                body["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnterpriseDingtalkGroupCustomerMember",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnterpriseDingtalkGroupCustomerMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业钉群客户侧成员
         *
         * @param request GetEnterpriseDingtalkGroupCustomerMemberRequest
         * @return GetEnterpriseDingtalkGroupCustomerMemberResponse
         */
        public GetEnterpriseDingtalkGroupCustomerMemberResponse GetEnterpriseDingtalkGroupCustomerMember(GetEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEnterpriseDingtalkGroupCustomerMemberWithOptions(request, runtime);
        }

        /**
         * @summary 获取企业钉群客户侧成员
         *
         * @param request GetEnterpriseDingtalkGroupCustomerMemberRequest
         * @return GetEnterpriseDingtalkGroupCustomerMemberResponse
         */
        public async Task<GetEnterpriseDingtalkGroupCustomerMemberResponse> GetEnterpriseDingtalkGroupCustomerMemberAsync(GetEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(request, runtime);
        }

        /**
         * @summary ListDdTaskOrder
         *
         * @param request ListDdTaskOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDdTaskOrderResponse
         */
        public ListDdTaskOrderResponse ListDdTaskOrderWithOptions(ListDdTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateRealName))
            {
                query["CreateRealName"] = request.CreateRealName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsUrgent))
            {
                query["IsUrgent"] = request.IsUrgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDdTaskOrder",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDdTaskOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ListDdTaskOrder
         *
         * @param request ListDdTaskOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDdTaskOrderResponse
         */
        public async Task<ListDdTaskOrderResponse> ListDdTaskOrderWithOptionsAsync(ListDdTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateRealName))
            {
                query["CreateRealName"] = request.CreateRealName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsUrgent))
            {
                query["IsUrgent"] = request.IsUrgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDdTaskOrder",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDdTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ListDdTaskOrder
         *
         * @param request ListDdTaskOrderRequest
         * @return ListDdTaskOrderResponse
         */
        public ListDdTaskOrderResponse ListDdTaskOrder(ListDdTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDdTaskOrderWithOptions(request, runtime);
        }

        /**
         * @summary ListDdTaskOrder
         *
         * @param request ListDdTaskOrderRequest
         * @return ListDdTaskOrderResponse
         */
        public async Task<ListDdTaskOrderResponse> ListDdTaskOrderAsync(ListDdTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDdTaskOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取钉群中所有客户侧人员信息
         *
         * @param request ListEnterpriseDingtalkGroupCustomerMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnterpriseDingtalkGroupCustomerMembersResponse
         */
        public ListEnterpriseDingtalkGroupCustomerMembersResponse ListEnterpriseDingtalkGroupCustomerMembersWithOptions(ListEnterpriseDingtalkGroupCustomerMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseDingtalkGroupCustomerMembers",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupCustomerMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取钉群中所有客户侧人员信息
         *
         * @param request ListEnterpriseDingtalkGroupCustomerMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnterpriseDingtalkGroupCustomerMembersResponse
         */
        public async Task<ListEnterpriseDingtalkGroupCustomerMembersResponse> ListEnterpriseDingtalkGroupCustomerMembersWithOptionsAsync(ListEnterpriseDingtalkGroupCustomerMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseDingtalkGroupCustomerMembers",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupCustomerMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取钉群中所有客户侧人员信息
         *
         * @param request ListEnterpriseDingtalkGroupCustomerMembersRequest
         * @return ListEnterpriseDingtalkGroupCustomerMembersResponse
         */
        public ListEnterpriseDingtalkGroupCustomerMembersResponse ListEnterpriseDingtalkGroupCustomerMembers(ListEnterpriseDingtalkGroupCustomerMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnterpriseDingtalkGroupCustomerMembersWithOptions(request, runtime);
        }

        /**
         * @summary 获取钉群中所有客户侧人员信息
         *
         * @param request ListEnterpriseDingtalkGroupCustomerMembersRequest
         * @return ListEnterpriseDingtalkGroupCustomerMembersResponse
         */
        public async Task<ListEnterpriseDingtalkGroupCustomerMembersResponse> ListEnterpriseDingtalkGroupCustomerMembersAsync(ListEnterpriseDingtalkGroupCustomerMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnterpriseDingtalkGroupCustomerMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询所有企业钉群成员
         *
         * @param request ListEnterpriseDingtalkGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnterpriseDingtalkGroupsResponse
         */
        public ListEnterpriseDingtalkGroupsResponse ListEnterpriseDingtalkGroupsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseDingtalkGroups",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询所有企业钉群成员
         *
         * @param request ListEnterpriseDingtalkGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnterpriseDingtalkGroupsResponse
         */
        public async Task<ListEnterpriseDingtalkGroupsResponse> ListEnterpriseDingtalkGroupsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseDingtalkGroups",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询所有企业钉群成员
         *
         * @return ListEnterpriseDingtalkGroupsResponse
         */
        public ListEnterpriseDingtalkGroupsResponse ListEnterpriseDingtalkGroups()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnterpriseDingtalkGroupsWithOptions(runtime);
        }

        /**
         * @summary 查询所有企业钉群成员
         *
         * @return ListEnterpriseDingtalkGroupsResponse
         */
        public async Task<ListEnterpriseDingtalkGroupsResponse> ListEnterpriseDingtalkGroupsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnterpriseDingtalkGroupsWithOptionsAsync(runtime);
        }

        /**
         * @summary 获取问题分类
         *
         * @param request ListProductByGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductByGroupResponse
         */
        public ListProductByGroupResponse ListProductByGroupWithOptions(ListProductByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductByGroup",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductByGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取问题分类
         *
         * @param request ListProductByGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductByGroupResponse
         */
        public async Task<ListProductByGroupResponse> ListProductByGroupWithOptionsAsync(ListProductByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductByGroup",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductByGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取问题分类
         *
         * @param request ListProductByGroupRequest
         * @return ListProductByGroupResponse
         */
        public ListProductByGroupResponse ListProductByGroup(ListProductByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductByGroupWithOptions(request, runtime);
        }

        /**
         * @summary 获取问题分类
         *
         * @param request ListProductByGroupRequest
         * @return ListProductByGroupResponse
         */
        public async Task<ListProductByGroupResponse> ListProductByGroupAsync(ListProductByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductByGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取工单状态
         *
         * @param request QueryTaskInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskInfoResponse
         */
        public QueryTaskInfoResponse QueryTaskInfoWithOptions(QueryTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskInfo",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取工单状态
         *
         * @param request QueryTaskInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskInfoResponse
         */
        public async Task<QueryTaskInfoResponse> QueryTaskInfoWithOptionsAsync(QueryTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskInfo",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工单状态
         *
         * @param request QueryTaskInfoRequest
         * @return QueryTaskInfoResponse
         */
        public QueryTaskInfoResponse QueryTaskInfo(QueryTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取工单状态
         *
         * @param request QueryTaskInfoRequest
         * @return QueryTaskInfoResponse
         */
        public async Task<QueryTaskInfoResponse> QueryTaskInfoAsync(QueryTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 客户回复消息
         *
         * @param request ReplyMessageApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReplyMessageApiResponse
         */
        public ReplyMessageApiResponse ReplyMessageApiWithOptions(ReplyMessageApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgContent))
            {
                query["MsgContent"] = request.MsgContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgType))
            {
                query["MsgType"] = request.MsgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplyMessageApi",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplyMessageApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 客户回复消息
         *
         * @param request ReplyMessageApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReplyMessageApiResponse
         */
        public async Task<ReplyMessageApiResponse> ReplyMessageApiWithOptionsAsync(ReplyMessageApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgContent))
            {
                query["MsgContent"] = request.MsgContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgType))
            {
                query["MsgType"] = request.MsgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplyMessageApi",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplyMessageApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 客户回复消息
         *
         * @param request ReplyMessageApiRequest
         * @return ReplyMessageApiResponse
         */
        public ReplyMessageApiResponse ReplyMessageApi(ReplyMessageApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplyMessageApiWithOptions(request, runtime);
        }

        /**
         * @summary 客户回复消息
         *
         * @param request ReplyMessageApiRequest
         * @return ReplyMessageApiResponse
         */
        public async Task<ReplyMessageApiResponse> ReplyMessageApiAsync(ReplyMessageApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplyMessageApiWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 重开任务单(待客户确认状态)
         *
         * @param request RestOpenTaskOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestOpenTaskOrderResponse
         */
        public RestOpenTaskOrderResponse RestOpenTaskOrderWithOptions(RestOpenTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetContent))
            {
                query["ResetContent"] = request.ResetContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetType))
            {
                query["ResetType"] = request.ResetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestOpenTaskOrder",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestOpenTaskOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 重开任务单(待客户确认状态)
         *
         * @param request RestOpenTaskOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestOpenTaskOrderResponse
         */
        public async Task<RestOpenTaskOrderResponse> RestOpenTaskOrderWithOptionsAsync(RestOpenTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupId))
            {
                query["OpenGroupId"] = request.OpenGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetContent))
            {
                query["ResetContent"] = request.ResetContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetType))
            {
                query["ResetType"] = request.ResetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestOpenTaskOrder",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestOpenTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 重开任务单(待客户确认状态)
         *
         * @param request RestOpenTaskOrderRequest
         * @return RestOpenTaskOrderResponse
         */
        public RestOpenTaskOrderResponse RestOpenTaskOrder(RestOpenTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestOpenTaskOrderWithOptions(request, runtime);
        }

        /**
         * @summary 重开任务单(待客户确认状态)
         *
         * @param request RestOpenTaskOrderRequest
         * @return RestOpenTaskOrderResponse
         */
        public async Task<RestOpenTaskOrderResponse> RestOpenTaskOrderAsync(RestOpenTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestOpenTaskOrderWithOptionsAsync(request, runtime);
        }

    }
}
