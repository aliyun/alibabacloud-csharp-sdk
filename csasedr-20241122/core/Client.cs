// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CsasEdr20241122.Models;

namespace AlibabaCloud.SDK.CsasEdr20241122
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("csasedr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Queries security alert types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNsasSuspEventTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNsasSuspEventTypeResponse
        /// </returns>
        public DescribeNsasSuspEventTypeResponse DescribeNsasSuspEventTypeWithOptions(DescribeNsasSuspEventTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldName))
            {
                query["ContainerFieldName"] = request.ContainerFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldValue))
            {
                query["ContainerFieldValue"] = request.ContainerFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNsasSuspEventType",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNsasSuspEventTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries security alert types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNsasSuspEventTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNsasSuspEventTypeResponse
        /// </returns>
        public async Task<DescribeNsasSuspEventTypeResponse> DescribeNsasSuspEventTypeWithOptionsAsync(DescribeNsasSuspEventTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldName))
            {
                query["ContainerFieldName"] = request.ContainerFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldValue))
            {
                query["ContainerFieldValue"] = request.ContainerFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNsasSuspEventType",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNsasSuspEventTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries security alert types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNsasSuspEventTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNsasSuspEventTypeResponse
        /// </returns>
        public DescribeNsasSuspEventTypeResponse DescribeNsasSuspEventType(DescribeNsasSuspEventTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNsasSuspEventTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries security alert types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNsasSuspEventTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNsasSuspEventTypeResponse
        /// </returns>
        public async Task<DescribeNsasSuspEventTypeResponse> DescribeNsasSuspEventTypeAsync(DescribeNsasSuspEventTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNsasSuspEventTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling operations, operability, and whitelist rule configurations for a specified endpoint alert in its current state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the handling operations that can be displayed for a specified endpoint alert. When initiating a subsequent response, you must select the operation items returned in this response where UserCanOperate is true, and submit parameters as required by the response operation. The query result does not guarantee that the subsequent response will succeed.
        /// The actual returned results are affected by feature switches, canary releases, dynamic allowlists, alert templates, alert statuses, and filter conditions. The list may be empty. The examples are used to illustrate field formats or rule combinations and do not represent that a specific alert will definitely return these values. MappingMarkFields and its subfields are generic compatibility structures. The current query pipeline does not populate their elements, and you should not infer that this operation supports the corresponding capabilities based on them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationsResponse
        /// </returns>
        public DescribeSecurityEventOperationsResponse DescribeSecurityEventOperationsWithOptions(DescribeSecurityEventOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventId))
            {
                query["SecurityEventId"] = request.SecurityEventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityEventOperations",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling operations, operability, and whitelist rule configurations for a specified endpoint alert in its current state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the handling operations that can be displayed for a specified endpoint alert. When initiating a subsequent response, you must select the operation items returned in this response where UserCanOperate is true, and submit parameters as required by the response operation. The query result does not guarantee that the subsequent response will succeed.
        /// The actual returned results are affected by feature switches, canary releases, dynamic allowlists, alert templates, alert statuses, and filter conditions. The list may be empty. The examples are used to illustrate field formats or rule combinations and do not represent that a specific alert will definitely return these values. MappingMarkFields and its subfields are generic compatibility structures. The current query pipeline does not populate their elements, and you should not infer that this operation supports the corresponding capabilities based on them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationsResponse
        /// </returns>
        public async Task<DescribeSecurityEventOperationsResponse> DescribeSecurityEventOperationsWithOptionsAsync(DescribeSecurityEventOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventId))
            {
                query["SecurityEventId"] = request.SecurityEventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityEventOperations",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling operations, operability, and whitelist rule configurations for a specified endpoint alert in its current state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the handling operations that can be displayed for a specified endpoint alert. When initiating a subsequent response, you must select the operation items returned in this response where UserCanOperate is true, and submit parameters as required by the response operation. The query result does not guarantee that the subsequent response will succeed.
        /// The actual returned results are affected by feature switches, canary releases, dynamic allowlists, alert templates, alert statuses, and filter conditions. The list may be empty. The examples are used to illustrate field formats or rule combinations and do not represent that a specific alert will definitely return these values. MappingMarkFields and its subfields are generic compatibility structures. The current query pipeline does not populate their elements, and you should not infer that this operation supports the corresponding capabilities based on them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationsResponse
        /// </returns>
        public DescribeSecurityEventOperationsResponse DescribeSecurityEventOperations(DescribeSecurityEventOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityEventOperationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling operations, operability, and whitelist rule configurations for a specified endpoint alert in its current state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the handling operations that can be displayed for a specified endpoint alert. When initiating a subsequent response, you must select the operation items returned in this response where UserCanOperate is true, and submit parameters as required by the response operation. The query result does not guarantee that the subsequent response will succeed.
        /// The actual returned results are affected by feature switches, canary releases, dynamic allowlists, alert templates, alert statuses, and filter conditions. The list may be empty. The examples are used to illustrate field formats or rule combinations and do not represent that a specific alert will definitely return these values. MappingMarkFields and its subfields are generic compatibility structures. The current query pipeline does not populate their elements, and you should not infer that this operation supports the corresponding capabilities based on them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationsResponse
        /// </returns>
        public async Task<DescribeSecurityEventOperationsResponse> DescribeSecurityEventOperationsAsync(DescribeSecurityEventOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityEventOperationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint security alerts and supports filtering by alert, endpoint, and processing status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public DescribeSuspEventsResponse DescribeSuspEventsWithOptions(DescribeSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmEventName))
            {
                query["AlarmEventName"] = request.AlarmEventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmUniqueInfo))
            {
                query["AlarmUniqueInfo"] = request.AlarmUniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsTypeList))
            {
                query["AssetsTypeList"] = request.AssetsTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldName))
            {
                query["ContainerFieldName"] = request.ContainerFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldValue))
            {
                query["ContainerFieldValue"] = request.ContainerFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dealed))
            {
                query["Dealed"] = request.Dealed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                query["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventNames))
            {
                query["EventNames"] = request.EventNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerIp))
            {
                query["InnerIp"] = request.InnerIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Levels))
            {
                query["Levels"] = request.Levels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateErrorCodeList))
            {
                query["OperateErrorCodeList"] = request.OperateErrorCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTimeEnd))
            {
                query["OperateTimeEnd"] = request.OperateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTimeStart))
            {
                query["OperateTimeStart"] = request.OperateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentEventTypes))
            {
                query["ParentEventTypes"] = request.ParentEventTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                query["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIp))
            {
                query["SrcIp"] = request.SrcIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrictMode))
            {
                query["StrictMode"] = request.StrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeEnd))
            {
                query["TimeEnd"] = request.TimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStart))
            {
                query["TimeStart"] = request.TimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueInfo))
            {
                query["UniqueInfo"] = request.UniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TacticId))
            {
                body["TacticId"] = request.TacticId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSuspEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint security alerts and supports filtering by alert, endpoint, and processing status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsWithOptionsAsync(DescribeSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmEventName))
            {
                query["AlarmEventName"] = request.AlarmEventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmUniqueInfo))
            {
                query["AlarmUniqueInfo"] = request.AlarmUniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsTypeList))
            {
                query["AssetsTypeList"] = request.AssetsTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldName))
            {
                query["ContainerFieldName"] = request.ContainerFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldValue))
            {
                query["ContainerFieldValue"] = request.ContainerFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dealed))
            {
                query["Dealed"] = request.Dealed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                query["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventNames))
            {
                query["EventNames"] = request.EventNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerIp))
            {
                query["InnerIp"] = request.InnerIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Levels))
            {
                query["Levels"] = request.Levels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateErrorCodeList))
            {
                query["OperateErrorCodeList"] = request.OperateErrorCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTimeEnd))
            {
                query["OperateTimeEnd"] = request.OperateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTimeStart))
            {
                query["OperateTimeStart"] = request.OperateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentEventTypes))
            {
                query["ParentEventTypes"] = request.ParentEventTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                query["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIp))
            {
                query["SrcIp"] = request.SrcIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrictMode))
            {
                query["StrictMode"] = request.StrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeEnd))
            {
                query["TimeEnd"] = request.TimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStart))
            {
                query["TimeStart"] = request.TimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueInfo))
            {
                query["UniqueInfo"] = request.UniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TacticId))
            {
                body["TacticId"] = request.TacticId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSuspEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint security alerts and supports filtering by alert, endpoint, and processing status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public DescribeSuspEventsResponse DescribeSuspEvents(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSuspEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint security alerts and supports filtering by alert, endpoint, and processing status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsAsync(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSuspEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandleSecurityEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandleSecurityEventsResponse
        /// </returns>
        public HandleSecurityEventsResponse HandleSecurityEventsWithOptions(HandleSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkBatch))
            {
                query["MarkBatch"] = request.MarkBatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkMissParam))
            {
                query["MarkMissParam"] = request.MarkMissParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationCode))
            {
                query["OperationCode"] = request.OperationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationParams))
            {
                query["OperationParams"] = request.OperationParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventIds))
            {
                query["SecurityEventIds"] = request.SecurityEventIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HandleSecurityEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandleSecurityEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandleSecurityEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandleSecurityEventsResponse
        /// </returns>
        public async Task<HandleSecurityEventsResponse> HandleSecurityEventsWithOptionsAsync(HandleSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkBatch))
            {
                query["MarkBatch"] = request.MarkBatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkMissParam))
            {
                query["MarkMissParam"] = request.MarkMissParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationCode))
            {
                query["OperationCode"] = request.OperationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationParams))
            {
                query["OperationParams"] = request.OperationParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventIds))
            {
                query["SecurityEventIds"] = request.SecurityEventIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HandleSecurityEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandleSecurityEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandleSecurityEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// HandleSecurityEventsResponse
        /// </returns>
        public HandleSecurityEventsResponse HandleSecurityEvents(HandleSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HandleSecurityEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandleSecurityEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// HandleSecurityEventsResponse
        /// </returns>
        public async Task<HandleSecurityEventsResponse> HandleSecurityEventsAsync(HandleSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HandleSecurityEventsWithOptionsAsync(request, runtime);
        }

    }
}
