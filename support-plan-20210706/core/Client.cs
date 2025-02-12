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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加客户服务主群人员进子群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddEnterpriseGroupMemberToTaskGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddEnterpriseGroupMemberToTaskGroupResponse
        /// </returns>
        public AddEnterpriseGroupMemberToTaskGroupResponse AddEnterpriseGroupMemberToTaskGroupWithOptions(AddEnterpriseGroupMemberToTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskOrderId))
            {
                query["TaskOrderId"] = request.TaskOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEnterpriseGroupMemberToTaskGroup",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddEnterpriseGroupMemberToTaskGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddEnterpriseGroupMemberToTaskGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加客户服务主群人员进子群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddEnterpriseGroupMemberToTaskGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddEnterpriseGroupMemberToTaskGroupResponse
        /// </returns>
        public async Task<AddEnterpriseGroupMemberToTaskGroupResponse> AddEnterpriseGroupMemberToTaskGroupWithOptionsAsync(AddEnterpriseGroupMemberToTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskOrderId))
            {
                query["TaskOrderId"] = request.TaskOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEnterpriseGroupMemberToTaskGroup",
                Version = "2021-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddEnterpriseGroupMemberToTaskGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddEnterpriseGroupMemberToTaskGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加客户服务主群人员进子群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddEnterpriseGroupMemberToTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddEnterpriseGroupMemberToTaskGroupResponse
        /// </returns>
        public AddEnterpriseGroupMemberToTaskGroupResponse AddEnterpriseGroupMemberToTaskGroup(AddEnterpriseGroupMemberToTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEnterpriseGroupMemberToTaskGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加客户服务主群人员进子群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddEnterpriseGroupMemberToTaskGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddEnterpriseGroupMemberToTaskGroupResponse
        /// </returns>
        public async Task<AddEnterpriseGroupMemberToTaskGroupResponse> AddEnterpriseGroupMemberToTaskGroupAsync(AddEnterpriseGroupMemberToTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEnterpriseGroupMemberToTaskGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateTaskOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateTaskOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateTaskOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskOrderResponse
        /// </returns>
        public CreateTaskOrderResponse CreateTaskOrder(CreateTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskOrderResponse
        /// </returns>
        public async Task<CreateTaskOrderResponse> CreateTaskOrderAsync(CreateTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListDdTaskOrder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDdTaskOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDdTaskOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListDdTaskOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListDdTaskOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListDdTaskOrder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDdTaskOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDdTaskOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListDdTaskOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListDdTaskOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListDdTaskOrder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDdTaskOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDdTaskOrderResponse
        /// </returns>
        public ListDdTaskOrderResponse ListDdTaskOrder(ListDdTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDdTaskOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListDdTaskOrder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDdTaskOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDdTaskOrderResponse
        /// </returns>
        public async Task<ListDdTaskOrderResponse> ListDdTaskOrderAsync(ListDdTaskOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDdTaskOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取钉群中所有客户侧人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseDingtalkGroupCustomerMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseDingtalkGroupCustomerMembersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListEnterpriseDingtalkGroupCustomerMembersResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListEnterpriseDingtalkGroupCustomerMembersResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取钉群中所有客户侧人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseDingtalkGroupCustomerMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseDingtalkGroupCustomerMembersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListEnterpriseDingtalkGroupCustomerMembersResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListEnterpriseDingtalkGroupCustomerMembersResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取钉群中所有客户侧人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseDingtalkGroupCustomerMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseDingtalkGroupCustomerMembersResponse
        /// </returns>
        public ListEnterpriseDingtalkGroupCustomerMembersResponse ListEnterpriseDingtalkGroupCustomerMembers(ListEnterpriseDingtalkGroupCustomerMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnterpriseDingtalkGroupCustomerMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取钉群中所有客户侧人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseDingtalkGroupCustomerMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseDingtalkGroupCustomerMembersResponse
        /// </returns>
        public async Task<ListEnterpriseDingtalkGroupCustomerMembersResponse> ListEnterpriseDingtalkGroupCustomerMembersAsync(ListEnterpriseDingtalkGroupCustomerMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnterpriseDingtalkGroupCustomerMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有企业钉群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseDingtalkGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseDingtalkGroupsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有企业钉群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseDingtalkGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseDingtalkGroupsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListEnterpriseDingtalkGroupsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有企业钉群成员</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListEnterpriseDingtalkGroupsResponse
        /// </returns>
        public ListEnterpriseDingtalkGroupsResponse ListEnterpriseDingtalkGroups()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnterpriseDingtalkGroupsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有企业钉群成员</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListEnterpriseDingtalkGroupsResponse
        /// </returns>
        public async Task<ListEnterpriseDingtalkGroupsResponse> ListEnterpriseDingtalkGroupsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnterpriseDingtalkGroupsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取问题分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductByGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductByGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListProductByGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListProductByGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取问题分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductByGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductByGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListProductByGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListProductByGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取问题分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductByGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductByGroupResponse
        /// </returns>
        public ListProductByGroupResponse ListProductByGroup(ListProductByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductByGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取问题分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductByGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductByGroupResponse
        /// </returns>
        public async Task<ListProductByGroupResponse> ListProductByGroupAsync(ListProductByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductByGroupWithOptionsAsync(request, runtime);
        }

    }
}
