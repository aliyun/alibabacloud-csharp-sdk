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

        public CloseTaskOrderResponse CloseTaskOrderWithOptions(CloseTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OrderId"] = request.OrderId;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTaskOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CloseTaskOrderResponse> CloseTaskOrderWithOptionsAsync(CloseTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OrderId"] = request.OrderId;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CloseTaskOrderResponse CloseTaskOrder(CloseTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseTaskOrderWithOptions(request, runtime);
        }

        public async Task<CloseTaskOrderResponse> CloseTaskOrderAsync(CloseTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseTaskOrderWithOptionsAsync(request, runtime);
        }

        public CreateTaskOrderResponse CreateTaskOrderWithOptions(CreateTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CustomerRealName"] = request.CustomerRealName;
            query["CustomerUserId"] = request.CustomerUserId;
            query["ImportantDescription"] = request.ImportantDescription;
            query["IsImportant"] = request.IsImportant;
            query["OpenGroupId"] = request.OpenGroupId;
            query["ProductType"] = request.ProductType;
            query["ProductTypeName"] = request.ProductTypeName;
            query["TaskTitle"] = request.TaskTitle;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTaskOrderResponse> CreateTaskOrderWithOptionsAsync(CreateTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CustomerRealName"] = request.CustomerRealName;
            query["CustomerUserId"] = request.CustomerUserId;
            query["ImportantDescription"] = request.ImportantDescription;
            query["IsImportant"] = request.IsImportant;
            query["OpenGroupId"] = request.OpenGroupId;
            query["ProductType"] = request.ProductType;
            query["ProductTypeName"] = request.ProductTypeName;
            query["TaskTitle"] = request.TaskTitle;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTaskOrderResponse CreateTaskOrder(CreateTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskOrderWithOptions(request, runtime);
        }

        public async Task<CreateTaskOrderResponse> CreateTaskOrderAsync(CreateTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskOrderWithOptionsAsync(request, runtime);
        }

        public CreateTaskOrderByEventReportResponse CreateTaskOrderByEventReportWithOptions(CreateTaskOrderByEventReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTaskOrderByEventReportShrinkRequest request = new CreateTaskOrderByEventReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventBody.ToMap()))
            {
                request.EventBodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventBody.ToMap(), "EventBody", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extinfo))
            {
                request.ExtinfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extinfo, "Extinfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Business"] = request.Business;
            query["CreateRealName"] = request.CreateRealName;
            query["CreateUserId"] = request.CreateUserId;
            query["EventBody"] = request.EventBodyShrink;
            query["Extinfo"] = request.ExtinfoShrink;
            query["ImportantDesc"] = request.ImportantDesc;
            query["JoinChildGroupUserIds"] = request.JoinChildGroupUserIds;
            query["MonitorCongregation"] = request.MonitorCongregation;
            query["OpenGroupId"] = request.OpenGroupId;
            query["ProductType"] = request.ProductType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskOrderByEventReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTaskOrderByEventReportResponse> CreateTaskOrderByEventReportWithOptionsAsync(CreateTaskOrderByEventReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTaskOrderByEventReportShrinkRequest request = new CreateTaskOrderByEventReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventBody.ToMap()))
            {
                request.EventBodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventBody.ToMap(), "EventBody", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extinfo))
            {
                request.ExtinfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extinfo, "Extinfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Business"] = request.Business;
            query["CreateRealName"] = request.CreateRealName;
            query["CreateUserId"] = request.CreateUserId;
            query["EventBody"] = request.EventBodyShrink;
            query["Extinfo"] = request.ExtinfoShrink;
            query["ImportantDesc"] = request.ImportantDesc;
            query["JoinChildGroupUserIds"] = request.JoinChildGroupUserIds;
            query["MonitorCongregation"] = request.MonitorCongregation;
            query["OpenGroupId"] = request.OpenGroupId;
            query["ProductType"] = request.ProductType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskOrderByEventReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTaskOrderByEventReportResponse CreateTaskOrderByEventReport(CreateTaskOrderByEventReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskOrderByEventReportWithOptions(request, runtime);
        }

        public async Task<CreateTaskOrderByEventReportResponse> CreateTaskOrderByEventReportAsync(CreateTaskOrderByEventReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskOrderByEventReportWithOptionsAsync(request, runtime);
        }

        public DeleteEnterpriseDingtalkGroupCustomerMemberResponse DeleteEnterpriseDingtalkGroupCustomerMemberWithOptions(DeleteEnterpriseDingtalkGroupCustomerMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest request = new DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Mobiles))
            {
                request.MobilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Mobiles, "Mobiles", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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

        public async Task<DeleteEnterpriseDingtalkGroupCustomerMemberResponse> DeleteEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(DeleteEnterpriseDingtalkGroupCustomerMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest request = new DeleteEnterpriseDingtalkGroupCustomerMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Mobiles))
            {
                request.MobilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Mobiles, "Mobiles", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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

        public DeleteEnterpriseDingtalkGroupCustomerMemberResponse DeleteEnterpriseDingtalkGroupCustomerMember(DeleteEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEnterpriseDingtalkGroupCustomerMemberWithOptions(request, runtime);
        }

        public async Task<DeleteEnterpriseDingtalkGroupCustomerMemberResponse> DeleteEnterpriseDingtalkGroupCustomerMemberAsync(DeleteEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(request, runtime);
        }

        public GetEnterpriseDingtalkGroupResponse GetEnterpriseDingtalkGroupWithOptions(GetEnterpriseDingtalkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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

        public async Task<GetEnterpriseDingtalkGroupResponse> GetEnterpriseDingtalkGroupWithOptionsAsync(GetEnterpriseDingtalkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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

        public GetEnterpriseDingtalkGroupResponse GetEnterpriseDingtalkGroup(GetEnterpriseDingtalkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEnterpriseDingtalkGroupWithOptions(request, runtime);
        }

        public async Task<GetEnterpriseDingtalkGroupResponse> GetEnterpriseDingtalkGroupAsync(GetEnterpriseDingtalkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEnterpriseDingtalkGroupWithOptionsAsync(request, runtime);
        }

        public GetEnterpriseDingtalkGroupCustomerMemberResponse GetEnterpriseDingtalkGroupCustomerMemberWithOptions(GetEnterpriseDingtalkGroupCustomerMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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

        public async Task<GetEnterpriseDingtalkGroupCustomerMemberResponse> GetEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(GetEnterpriseDingtalkGroupCustomerMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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

        public GetEnterpriseDingtalkGroupCustomerMemberResponse GetEnterpriseDingtalkGroupCustomerMember(GetEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEnterpriseDingtalkGroupCustomerMemberWithOptions(request, runtime);
        }

        public async Task<GetEnterpriseDingtalkGroupCustomerMemberResponse> GetEnterpriseDingtalkGroupCustomerMemberAsync(GetEnterpriseDingtalkGroupCustomerMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEnterpriseDingtalkGroupCustomerMemberWithOptionsAsync(request, runtime);
        }

        public ListDdTaskOrderResponse ListDdTaskOrderWithOptions(ListDdTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallerParentId"] = request.CallerParentId;
            query["CallerType"] = request.CallerType;
            query["CallerUid"] = request.CallerUid;
            query["OpenGroupId"] = request.OpenGroupId;
            query["OrderId"] = request.OrderId;
            query["RequestId"] = request.RequestId;
            query["TaskStatus"] = request.TaskStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDdTaskOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDdTaskOrderResponse> ListDdTaskOrderWithOptionsAsync(ListDdTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallerParentId"] = request.CallerParentId;
            query["CallerType"] = request.CallerType;
            query["CallerUid"] = request.CallerUid;
            query["OpenGroupId"] = request.OpenGroupId;
            query["OrderId"] = request.OrderId;
            query["RequestId"] = request.RequestId;
            query["TaskStatus"] = request.TaskStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDdTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDdTaskOrderResponse ListDdTaskOrder(ListDdTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDdTaskOrderWithOptions(request, runtime);
        }

        public async Task<ListDdTaskOrderResponse> ListDdTaskOrderAsync(ListDdTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDdTaskOrderWithOptionsAsync(request, runtime);
        }

        public ListEnterpriseDingtalkGroupCustomerMembersResponse ListEnterpriseDingtalkGroupCustomerMembersWithOptions(ListEnterpriseDingtalkGroupCustomerMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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

        public async Task<ListEnterpriseDingtalkGroupCustomerMembersResponse> ListEnterpriseDingtalkGroupCustomerMembersWithOptionsAsync(ListEnterpriseDingtalkGroupCustomerMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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

        public ListEnterpriseDingtalkGroupCustomerMembersResponse ListEnterpriseDingtalkGroupCustomerMembers(ListEnterpriseDingtalkGroupCustomerMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnterpriseDingtalkGroupCustomerMembersWithOptions(request, runtime);
        }

        public async Task<ListEnterpriseDingtalkGroupCustomerMembersResponse> ListEnterpriseDingtalkGroupCustomerMembersAsync(ListEnterpriseDingtalkGroupCustomerMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnterpriseDingtalkGroupCustomerMembersWithOptionsAsync(request, runtime);
        }

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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(CallApi(params_, req, runtime));
        }

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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEnterpriseDingtalkGroupsResponse ListEnterpriseDingtalkGroups()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnterpriseDingtalkGroupsWithOptions(runtime);
        }

        public async Task<ListEnterpriseDingtalkGroupsResponse> ListEnterpriseDingtalkGroupsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnterpriseDingtalkGroupsWithOptionsAsync(runtime);
        }

        public ListProductByGroupResponse ListProductByGroupWithOptions(ListProductByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OpenGroupId"] = request.OpenGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductByGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductByGroupResponse> ListProductByGroupWithOptionsAsync(ListProductByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OpenGroupId"] = request.OpenGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductByGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductByGroupResponse ListProductByGroup(ListProductByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductByGroupWithOptions(request, runtime);
        }

        public async Task<ListProductByGroupResponse> ListProductByGroupAsync(ListProductByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductByGroupWithOptionsAsync(request, runtime);
        }

        public QueryTaskInfoResponse QueryTaskInfoWithOptions(QueryTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OrderId"] = request.OrderId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTaskInfoResponse> QueryTaskInfoWithOptionsAsync(QueryTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OrderId"] = request.OrderId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTaskInfoResponse QueryTaskInfo(QueryTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskInfoWithOptions(request, runtime);
        }

        public async Task<QueryTaskInfoResponse> QueryTaskInfoAsync(QueryTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskInfoWithOptionsAsync(request, runtime);
        }

        public ReplyMessageApiResponse ReplyMessageApiWithOptions(ReplyMessageApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MsgContent"] = request.MsgContent;
            query["MsgType"] = request.MsgType;
            query["OpenGroupId"] = request.OpenGroupId;
            query["OrderId"] = request.OrderId;
            query["UserId"] = request.UserId;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplyMessageApiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReplyMessageApiResponse> ReplyMessageApiWithOptionsAsync(ReplyMessageApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MsgContent"] = request.MsgContent;
            query["MsgType"] = request.MsgType;
            query["OpenGroupId"] = request.OpenGroupId;
            query["OrderId"] = request.OrderId;
            query["UserId"] = request.UserId;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplyMessageApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReplyMessageApiResponse ReplyMessageApi(ReplyMessageApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplyMessageApiWithOptions(request, runtime);
        }

        public async Task<ReplyMessageApiResponse> ReplyMessageApiAsync(ReplyMessageApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplyMessageApiWithOptionsAsync(request, runtime);
        }

        public RestOpenTaskOrderResponse RestOpenTaskOrderWithOptions(RestOpenTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OpenGroupId"] = request.OpenGroupId;
            query["OrderId"] = request.OrderId;
            query["ResetContent"] = request.ResetContent;
            query["ResetType"] = request.ResetType;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestOpenTaskOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestOpenTaskOrderResponse> RestOpenTaskOrderWithOptionsAsync(RestOpenTaskOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OpenGroupId"] = request.OpenGroupId;
            query["OrderId"] = request.OrderId;
            query["ResetContent"] = request.ResetContent;
            query["ResetType"] = request.ResetType;
            query["UserName"] = request.UserName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestOpenTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestOpenTaskOrderResponse RestOpenTaskOrder(RestOpenTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestOpenTaskOrderWithOptions(request, runtime);
        }

        public async Task<RestOpenTaskOrderResponse> RestOpenTaskOrderAsync(RestOpenTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestOpenTaskOrderWithOptionsAsync(request, runtime);
        }

    }
}
