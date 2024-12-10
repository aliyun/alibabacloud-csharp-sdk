// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Mssp20161228.Models;

namespace AlibabaCloud.SDK.Mssp20161228
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("mssp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Create Service Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceWorkOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceWorkOrderResponse
        /// </returns>
        public CreateServiceWorkOrderResponse CreateServiceWorkOrderWithOptions(CreateServiceWorkOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationDay))
            {
                body["DurationDay"] = request.DurationDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAttachment))
            {
                body["IsAttachment"] = request.IsAttachment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsWorkOrderNotify))
            {
                body["IsWorkOrderNotify"] = request.IsWorkOrderNotify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyDay))
            {
                body["NotifyDay"] = request.NotifyDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyId))
            {
                body["NotifyId"] = request.NotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateRemark))
            {
                body["OperateRemark"] = request.OperateRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderDetail))
            {
                body["WorkOrderDetail"] = request.WorkOrderDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderName))
            {
                body["WorkOrderName"] = request.WorkOrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderSource))
            {
                body["WorkOrderSource"] = request.WorkOrderSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderStatus))
            {
                body["WorkOrderStatus"] = request.WorkOrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderType))
            {
                body["WorkOrderType"] = request.WorkOrderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceWorkOrder",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceWorkOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Service Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceWorkOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceWorkOrderResponse
        /// </returns>
        public async Task<CreateServiceWorkOrderResponse> CreateServiceWorkOrderWithOptionsAsync(CreateServiceWorkOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationDay))
            {
                body["DurationDay"] = request.DurationDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAttachment))
            {
                body["IsAttachment"] = request.IsAttachment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsWorkOrderNotify))
            {
                body["IsWorkOrderNotify"] = request.IsWorkOrderNotify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyDay))
            {
                body["NotifyDay"] = request.NotifyDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyId))
            {
                body["NotifyId"] = request.NotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateRemark))
            {
                body["OperateRemark"] = request.OperateRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderDetail))
            {
                body["WorkOrderDetail"] = request.WorkOrderDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderName))
            {
                body["WorkOrderName"] = request.WorkOrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderSource))
            {
                body["WorkOrderSource"] = request.WorkOrderSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderStatus))
            {
                body["WorkOrderStatus"] = request.WorkOrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderType))
            {
                body["WorkOrderType"] = request.WorkOrderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceWorkOrder",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceWorkOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Service Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceWorkOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceWorkOrderResponse
        /// </returns>
        public CreateServiceWorkOrderResponse CreateServiceWorkOrder(CreateServiceWorkOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceWorkOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Service Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceWorkOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceWorkOrderResponse
        /// </returns>
        public async Task<CreateServiceWorkOrderResponse> CreateServiceWorkOrderAsync(CreateServiceWorkOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceWorkOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Process Service Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisposeServiceWorkOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisposeServiceWorkOrderResponse
        /// </returns>
        public DisposeServiceWorkOrderResponse DisposeServiceWorkOrderWithOptions(DisposeServiceWorkOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentName))
            {
                body["AttachmentName"] = request.AttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardOwnerId))
            {
                body["ForwardOwnerId"] = request.ForwardOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAttachment))
            {
                body["IsAttachment"] = request.IsAttachment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsWorkOrderNotify))
            {
                body["IsWorkOrderNotify"] = request.IsWorkOrderNotify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyId))
            {
                body["NotifyId"] = request.NotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateRemark))
            {
                body["OperateRemark"] = request.OperateRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeOwnerId))
            {
                body["UpgradeOwnerId"] = request.UpgradeOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderDetail))
            {
                body["WorkOrderDetail"] = request.WorkOrderDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderName))
            {
                body["WorkOrderName"] = request.WorkOrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderStatus))
            {
                body["WorkOrderStatus"] = request.WorkOrderStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisposeServiceWorkOrder",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisposeServiceWorkOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Process Service Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisposeServiceWorkOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisposeServiceWorkOrderResponse
        /// </returns>
        public async Task<DisposeServiceWorkOrderResponse> DisposeServiceWorkOrderWithOptionsAsync(DisposeServiceWorkOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentName))
            {
                body["AttachmentName"] = request.AttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardOwnerId))
            {
                body["ForwardOwnerId"] = request.ForwardOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAttachment))
            {
                body["IsAttachment"] = request.IsAttachment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsWorkOrderNotify))
            {
                body["IsWorkOrderNotify"] = request.IsWorkOrderNotify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyId))
            {
                body["NotifyId"] = request.NotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateRemark))
            {
                body["OperateRemark"] = request.OperateRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeOwnerId))
            {
                body["UpgradeOwnerId"] = request.UpgradeOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderDetail))
            {
                body["WorkOrderDetail"] = request.WorkOrderDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderName))
            {
                body["WorkOrderName"] = request.WorkOrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkOrderStatus))
            {
                body["WorkOrderStatus"] = request.WorkOrderStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisposeServiceWorkOrder",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisposeServiceWorkOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Process Service Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisposeServiceWorkOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DisposeServiceWorkOrderResponse
        /// </returns>
        public DisposeServiceWorkOrderResponse DisposeServiceWorkOrder(DisposeServiceWorkOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisposeServiceWorkOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Process Service Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisposeServiceWorkOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DisposeServiceWorkOrderResponse
        /// </returns>
        public async Task<DisposeServiceWorkOrderResponse> DisposeServiceWorkOrderAsync(DisposeServiceWorkOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisposeServiceWorkOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handle Alert Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisposeWorkTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisposeWorkTaskResponse
        /// </returns>
        public DisposeWorkTaskResponse DisposeWorkTaskWithOptions(DisposeWorkTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptRemark))
            {
                body["OptRemark"] = request.OptRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisposeWorkTask",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisposeWorkTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handle Alert Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisposeWorkTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisposeWorkTaskResponse
        /// </returns>
        public async Task<DisposeWorkTaskResponse> DisposeWorkTaskWithOptionsAsync(DisposeWorkTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptRemark))
            {
                body["OptRemark"] = request.OptRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisposeWorkTask",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisposeWorkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handle Alert Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisposeWorkTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DisposeWorkTaskResponse
        /// </returns>
        public DisposeWorkTaskResponse DisposeWorkTask(DisposeWorkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisposeWorkTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handle Alert Work Order</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisposeWorkTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DisposeWorkTaskResponse
        /// </returns>
        public async Task<DisposeWorkTaskResponse> DisposeWorkTaskAsync(DisposeWorkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisposeWorkTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Alarm Details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlarmDetailByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlarmDetailByIdResponse
        /// </returns>
        public GetAlarmDetailByIdResponse GetAlarmDetailByIdWithOptions(GetAlarmDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlarmDetailById",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlarmDetailByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Alarm Details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlarmDetailByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlarmDetailByIdResponse
        /// </returns>
        public async Task<GetAlarmDetailByIdResponse> GetAlarmDetailByIdWithOptionsAsync(GetAlarmDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlarmDetailById",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlarmDetailByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Alarm Details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlarmDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlarmDetailByIdResponse
        /// </returns>
        public GetAlarmDetailByIdResponse GetAlarmDetailById(GetAlarmDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlarmDetailByIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Alarm Details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlarmDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlarmDetailByIdResponse
        /// </returns>
        public async Task<GetAlarmDetailByIdResponse> GetAlarmDetailByIdAsync(GetAlarmDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlarmDetailByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Trend of Attacked Asset Convergence</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttackedAssetDealRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttackedAssetDealResponse
        /// </returns>
        public GetAttackedAssetDealResponse GetAttackedAssetDealWithOptions(GetAttackedAssetDealRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttackedAssetDeal",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttackedAssetDealResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Trend of Attacked Asset Convergence</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttackedAssetDealRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttackedAssetDealResponse
        /// </returns>
        public async Task<GetAttackedAssetDealResponse> GetAttackedAssetDealWithOptionsAsync(GetAttackedAssetDealRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttackedAssetDeal",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttackedAssetDealResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Trend of Attacked Asset Convergence</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttackedAssetDealRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttackedAssetDealResponse
        /// </returns>
        public GetAttackedAssetDealResponse GetAttackedAssetDeal(GetAttackedAssetDealRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAttackedAssetDealWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Trend of Attacked Asset Convergence</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAttackedAssetDealRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttackedAssetDealResponse
        /// </returns>
        public async Task<GetAttackedAssetDealResponse> GetAttackedAssetDealAsync(GetAttackedAssetDealRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAttackedAssetDealWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Compliance Risk Convergence Trend</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBaselineSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBaselineSummaryResponse
        /// </returns>
        public GetBaselineSummaryResponse GetBaselineSummaryWithOptions(GetBaselineSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBaselineSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBaselineSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Compliance Risk Convergence Trend</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBaselineSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBaselineSummaryResponse
        /// </returns>
        public async Task<GetBaselineSummaryResponse> GetBaselineSummaryWithOptionsAsync(GetBaselineSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBaselineSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBaselineSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Compliance Risk Convergence Trend</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBaselineSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBaselineSummaryResponse
        /// </returns>
        public GetBaselineSummaryResponse GetBaselineSummary(GetBaselineSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBaselineSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Compliance Risk Convergence Trend</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBaselineSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBaselineSummaryResponse
        /// </returns>
        public async Task<GetBaselineSummaryResponse> GetBaselineSummaryAsync(GetBaselineSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBaselineSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Console Score</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsoleScoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConsoleScoreResponse
        /// </returns>
        public GetConsoleScoreResponse GetConsoleScoreWithOptions(GetConsoleScoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsoleScore",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsoleScoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Console Score</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsoleScoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConsoleScoreResponse
        /// </returns>
        public async Task<GetConsoleScoreResponse> GetConsoleScoreWithOptionsAsync(GetConsoleScoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsoleScore",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsoleScoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Console Score</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsoleScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConsoleScoreResponse
        /// </returns>
        public GetConsoleScoreResponse GetConsoleScore(GetConsoleScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConsoleScoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Console Score</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsoleScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConsoleScoreResponse
        /// </returns>
        public async Task<GetConsoleScoreResponse> GetConsoleScoreAsync(GetConsoleScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConsoleScoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Risk Details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDetailByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDetailByIdResponse
        /// </returns>
        public GetDetailByIdResponse GetDetailByIdWithOptions(GetDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDetailById",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDetailByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Risk Details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDetailByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDetailByIdResponse
        /// </returns>
        public async Task<GetDetailByIdResponse> GetDetailByIdWithOptionsAsync(GetDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDetailById",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDetailByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Risk Details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDetailByIdResponse
        /// </returns>
        public GetDetailByIdResponse GetDetailById(GetDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetailByIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Risk Details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDetailByIdResponse
        /// </returns>
        public async Task<GetDetailByIdResponse> GetDetailByIdAsync(GetDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetailByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Single Service Report Download</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentDownloadUrlResponse
        /// </returns>
        public GetDocumentDownloadUrlResponse GetDocumentDownloadUrlWithOptions(GetDocumentDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentDownloadUrl",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Single Service Report Download</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentDownloadUrlResponse
        /// </returns>
        public async Task<GetDocumentDownloadUrlResponse> GetDocumentDownloadUrlWithOptionsAsync(GetDocumentDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentDownloadUrl",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Single Service Report Download</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentDownloadUrlResponse
        /// </returns>
        public GetDocumentDownloadUrlResponse GetDocumentDownloadUrl(GetDocumentDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentDownloadUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Single Service Report Download</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentDownloadUrlResponse
        /// </returns>
        public async Task<GetDocumentDownloadUrlResponse> GetDocumentDownloadUrlAsync(GetDocumentDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentDownloadUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Report Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentPageResponse
        /// </returns>
        public GetDocumentPageResponse GetDocumentPageWithOptions(GetDocumentPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveredBy))
            {
                body["DeliveredBy"] = request.DeliveredBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentType))
            {
                body["DocumentType"] = request.DocumentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                body["ReportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentPage",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Report Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentPageResponse
        /// </returns>
        public async Task<GetDocumentPageResponse> GetDocumentPageWithOptionsAsync(GetDocumentPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveredBy))
            {
                body["DeliveredBy"] = request.DeliveredBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentType))
            {
                body["DocumentType"] = request.DocumentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                body["ReportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentPage",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Report Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentPageResponse
        /// </returns>
        public GetDocumentPageResponse GetDocumentPage(GetDocumentPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Report Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentPageResponse
        /// </returns>
        public async Task<GetDocumentPageResponse> GetDocumentPageAsync(GetDocumentPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Report Home Page Statistics Acquisition</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentSummaryResponse
        /// </returns>
        public GetDocumentSummaryResponse GetDocumentSummaryWithOptions(GetDocumentSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                body["ReportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Report Home Page Statistics Acquisition</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentSummaryResponse
        /// </returns>
        public async Task<GetDocumentSummaryResponse> GetDocumentSummaryWithOptionsAsync(GetDocumentSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                body["ReportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Report Home Page Statistics Acquisition</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentSummaryResponse
        /// </returns>
        public GetDocumentSummaryResponse GetDocumentSummary(GetDocumentSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Report Home Page Statistics Acquisition</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentSummaryResponse
        /// </returns>
        public async Task<GetDocumentSummaryResponse> GetDocumentSummaryAsync(GetDocumentSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Recently Uploaded Service Reports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecentDocumentResponse
        /// </returns>
        public GetRecentDocumentResponse GetRecentDocumentWithOptions(GetRecentDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecentDocument",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecentDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Recently Uploaded Service Reports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecentDocumentResponse
        /// </returns>
        public async Task<GetRecentDocumentResponse> GetRecentDocumentWithOptionsAsync(GetRecentDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecentDocument",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecentDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Recently Uploaded Service Reports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecentDocumentResponse
        /// </returns>
        public GetRecentDocumentResponse GetRecentDocument(GetRecentDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRecentDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Recently Uploaded Service Reports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecentDocumentResponse
        /// </returns>
        public async Task<GetRecentDocumentResponse> GetRecentDocumentAsync(GetRecentDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRecentDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Safety Coverage</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSafetyCoverRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSafetyCoverResponse
        /// </returns>
        public GetSafetyCoverResponse GetSafetyCoverWithOptions(GetSafetyCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSafetyCover",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSafetyCoverResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Safety Coverage</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSafetyCoverRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSafetyCoverResponse
        /// </returns>
        public async Task<GetSafetyCoverResponse> GetSafetyCoverWithOptionsAsync(GetSafetyCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSafetyCover",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSafetyCoverResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Safety Coverage</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSafetyCoverRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSafetyCoverResponse
        /// </returns>
        public GetSafetyCoverResponse GetSafetyCover(GetSafetyCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSafetyCoverWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Safety Coverage</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSafetyCoverRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSafetyCoverResponse
        /// </returns>
        public async Task<GetSafetyCoverResponse> GetSafetyCoverAsync(GetSafetyCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSafetyCoverWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get SOW List</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSowListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSowListResponse
        /// </returns>
        public GetSowListResponse GetSowListWithOptions(GetSowListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSowList",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSowListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get SOW List</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSowListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSowListResponse
        /// </returns>
        public async Task<GetSowListResponse> GetSowListWithOptionsAsync(GetSowListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSowList",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSowListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get SOW List</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSowListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSowListResponse
        /// </returns>
        public GetSowListResponse GetSowList(GetSowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSowListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get SOW List</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSowListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSowListResponse
        /// </returns>
        public async Task<GetSowListResponse> GetSowListAsync(GetSowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSowListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Alarm Disposal Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspEventPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSuspEventPageResponse
        /// </returns>
        public GetSuspEventPageResponse GetSuspEventPageWithOptions(GetSuspEventPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmEndTime))
            {
                body["AlarmEndTime"] = request.AlarmEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmStartTime))
            {
                body["AlarmStartTime"] = request.AlarmStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSuspEventPage",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSuspEventPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Alarm Disposal Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspEventPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSuspEventPageResponse
        /// </returns>
        public async Task<GetSuspEventPageResponse> GetSuspEventPageWithOptionsAsync(GetSuspEventPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmEndTime))
            {
                body["AlarmEndTime"] = request.AlarmEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmStartTime))
            {
                body["AlarmStartTime"] = request.AlarmStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSuspEventPage",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSuspEventPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Alarm Disposal Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspEventPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSuspEventPageResponse
        /// </returns>
        public GetSuspEventPageResponse GetSuspEventPage(GetSuspEventPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSuspEventPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Alarm Disposal Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspEventPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSuspEventPageResponse
        /// </returns>
        public async Task<GetSuspEventPageResponse> GetSuspEventPageAsync(GetSuspEventPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSuspEventPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Alert Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspEventSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSuspEventSummaryResponse
        /// </returns>
        public GetSuspEventSummaryResponse GetSuspEventSummaryWithOptions(GetSuspEventSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSuspEventSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSuspEventSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Alert Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspEventSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSuspEventSummaryResponse
        /// </returns>
        public async Task<GetSuspEventSummaryResponse> GetSuspEventSummaryWithOptionsAsync(GetSuspEventSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSuspEventSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSuspEventSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Alert Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspEventSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSuspEventSummaryResponse
        /// </returns>
        public GetSuspEventSummaryResponse GetSuspEventSummary(GetSuspEventSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSuspEventSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Alert Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspEventSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSuspEventSummaryResponse
        /// </returns>
        public async Task<GetSuspEventSummaryResponse> GetSuspEventSummaryAsync(GetSuspEventSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSuspEventSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Alarm Page Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspPageSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSuspPageSummaryResponse
        /// </returns>
        public GetSuspPageSummaryResponse GetSuspPageSummaryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSuspPageSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSuspPageSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Alarm Page Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuspPageSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSuspPageSummaryResponse
        /// </returns>
        public async Task<GetSuspPageSummaryResponse> GetSuspPageSummaryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSuspPageSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSuspPageSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Alarm Page Statistics</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSuspPageSummaryResponse
        /// </returns>
        public GetSuspPageSummaryResponse GetSuspPageSummary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSuspPageSummaryWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Alarm Page Statistics</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSuspPageSummaryResponse
        /// </returns>
        public async Task<GetSuspPageSummaryResponse> GetSuspPageSummaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSuspPageSummaryWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query User Activation Status</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserStatusResponse
        /// </returns>
        public GetUserStatusResponse GetUserStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserStatus",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query User Activation Status</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserStatusResponse
        /// </returns>
        public async Task<GetUserStatusResponse> GetUserStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserStatus",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query User Activation Status</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserStatusResponse
        /// </returns>
        public GetUserStatusResponse GetUserStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserStatusWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query User Activation Status</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserStatusResponse
        /// </returns>
        public async Task<GetUserStatusResponse> GetUserStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserStatusWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Risk Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulItemPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVulItemPageResponse
        /// </returns>
        public GetVulItemPageResponse GetVulItemPageWithOptions(GetVulItemPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                body["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dealed))
            {
                body["Dealed"] = request.Dealed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                body["ScanType"] = request.ScanType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVulItemPage",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVulItemPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Risk Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulItemPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVulItemPageResponse
        /// </returns>
        public async Task<GetVulItemPageResponse> GetVulItemPageWithOptionsAsync(GetVulItemPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                body["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dealed))
            {
                body["Dealed"] = request.Dealed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                body["ScanType"] = request.ScanType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVulItemPage",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVulItemPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Risk Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulItemPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVulItemPageResponse
        /// </returns>
        public GetVulItemPageResponse GetVulItemPage(GetVulItemPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVulItemPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Risk Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulItemPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVulItemPageResponse
        /// </returns>
        public async Task<GetVulItemPageResponse> GetVulItemPageAsync(GetVulItemPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVulItemPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query processed details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulListByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVulListByIdResponse
        /// </returns>
        public GetVulListByIdResponse GetVulListByIdWithOptions(GetVulListByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dealed))
            {
                body["Dealed"] = request.Dealed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Necessity))
            {
                body["Necessity"] = request.Necessity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                body["Uuids"] = request.Uuids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVulListById",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVulListByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query processed details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulListByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVulListByIdResponse
        /// </returns>
        public async Task<GetVulListByIdResponse> GetVulListByIdWithOptionsAsync(GetVulListByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dealed))
            {
                body["Dealed"] = request.Dealed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Necessity))
            {
                body["Necessity"] = request.Necessity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                body["Uuids"] = request.Uuids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVulListById",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVulListByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query processed details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulListByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVulListByIdResponse
        /// </returns>
        public GetVulListByIdResponse GetVulListById(GetVulListByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVulListByIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query processed details</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulListByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVulListByIdResponse
        /// </returns>
        public async Task<GetVulListByIdResponse> GetVulListByIdAsync(GetVulListByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVulListByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Risk Page Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulPageSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVulPageSummaryResponse
        /// </returns>
        public GetVulPageSummaryResponse GetVulPageSummaryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVulPageSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVulPageSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Risk Page Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulPageSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVulPageSummaryResponse
        /// </returns>
        public async Task<GetVulPageSummaryResponse> GetVulPageSummaryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVulPageSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVulPageSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Risk Page Statistics</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetVulPageSummaryResponse
        /// </returns>
        public GetVulPageSummaryResponse GetVulPageSummary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVulPageSummaryWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Risk Page Statistics</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetVulPageSummaryResponse
        /// </returns>
        public async Task<GetVulPageSummaryResponse> GetVulPageSummaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVulPageSummaryWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Risk Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVulSummaryResponse
        /// </returns>
        public GetVulSummaryResponse GetVulSummaryWithOptions(GetVulSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVulSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVulSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Risk Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVulSummaryResponse
        /// </returns>
        public async Task<GetVulSummaryResponse> GetVulSummaryWithOptionsAsync(GetVulSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVulSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVulSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Risk Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVulSummaryResponse
        /// </returns>
        public GetVulSummaryResponse GetVulSummary(GetVulSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVulSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Risk Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVulSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVulSummaryResponse
        /// </returns>
        public async Task<GetVulSummaryResponse> GetVulSummaryAsync(GetVulSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVulSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the First Line Work Order Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkTaskSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkTaskSummaryResponse
        /// </returns>
        public GetWorkTaskSummaryResponse GetWorkTaskSummaryWithOptions(GetWorkTaskSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkTaskSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkTaskSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the First Line Work Order Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkTaskSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkTaskSummaryResponse
        /// </returns>
        public async Task<GetWorkTaskSummaryResponse> GetWorkTaskSummaryWithOptionsAsync(GetWorkTaskSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["DateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspEventSource))
            {
                body["SuspEventSource"] = request.SuspEventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkTaskSummary",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkTaskSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the First Line Work Order Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkTaskSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkTaskSummaryResponse
        /// </returns>
        public GetWorkTaskSummaryResponse GetWorkTaskSummary(GetWorkTaskSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkTaskSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the First Line Work Order Statistics</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkTaskSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkTaskSummaryResponse
        /// </returns>
        public async Task<GetWorkTaskSummaryResponse> GetWorkTaskSummaryAsync(GetWorkTaskSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkTaskSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Customer Information Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageServiceCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageServiceCustomerResponse
        /// </returns>
        public PageServiceCustomerResponse PageServiceCustomerWithOptions(PageServiceCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                body["AuthStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmAuthStatus))
            {
                body["CmAuthStatus"] = request.CmAuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorAuthStatus))
            {
                body["MonitorAuthStatus"] = request.MonitorAuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageServiceCustomer",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageServiceCustomerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Customer Information Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageServiceCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageServiceCustomerResponse
        /// </returns>
        public async Task<PageServiceCustomerResponse> PageServiceCustomerWithOptionsAsync(PageServiceCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                body["AuthStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmAuthStatus))
            {
                body["CmAuthStatus"] = request.CmAuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorAuthStatus))
            {
                body["MonitorAuthStatus"] = request.MonitorAuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageServiceCustomer",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageServiceCustomerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Customer Information Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageServiceCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// PageServiceCustomerResponse
        /// </returns>
        public PageServiceCustomerResponse PageServiceCustomer(PageServiceCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageServiceCustomerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Service Customer Information Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageServiceCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// PageServiceCustomerResponse
        /// </returns>
        public async Task<PageServiceCustomerResponse> PageServiceCustomerAsync(PageServiceCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageServiceCustomerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Send Custom Alert Event</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendCustomEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCustomEventResponse
        /// </returns>
        public SendCustomEventResponse SendCustomEventWithOptions(SendCustomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                body["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventDescription))
            {
                body["EventDescription"] = request.EventDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventDetails))
            {
                body["EventDetails"] = request.EventDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FindTime))
            {
                body["FindTime"] = request.FindTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSend))
            {
                body["IsSend"] = request.IsSend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccurrenceTime))
            {
                body["OccurrenceTime"] = request.OccurrenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["UniqueId"] = request.UniqueId;
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
                Action = "SendCustomEvent",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCustomEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Send Custom Alert Event</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendCustomEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCustomEventResponse
        /// </returns>
        public async Task<SendCustomEventResponse> SendCustomEventWithOptionsAsync(SendCustomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                body["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventDescription))
            {
                body["EventDescription"] = request.EventDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventDetails))
            {
                body["EventDetails"] = request.EventDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FindTime))
            {
                body["FindTime"] = request.FindTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSend))
            {
                body["IsSend"] = request.IsSend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccurrenceTime))
            {
                body["OccurrenceTime"] = request.OccurrenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["UniqueId"] = request.UniqueId;
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
                Action = "SendCustomEvent",
                Version = "2016-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCustomEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Send Custom Alert Event</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendCustomEventRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCustomEventResponse
        /// </returns>
        public SendCustomEventResponse SendCustomEvent(SendCustomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCustomEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Send Custom Alert Event</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendCustomEventRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCustomEventResponse
        /// </returns>
        public async Task<SendCustomEventResponse> SendCustomEventAsync(SendCustomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCustomEventWithOptionsAsync(request, runtime);
        }

    }
}
