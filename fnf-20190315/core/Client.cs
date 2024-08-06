// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Fnf20190315.Models;

namespace AlibabaCloud.SDK.Fnf20190315
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "cn-beijing.fnf.aliyuncs.com"},
                {"cn-hangzhou", "cn-hangzhou.fnf.aliyuncs.com"},
                {"cn-shanghai", "cn-shanghai.fnf.aliyuncs.com"},
                {"cn-shenzhen", "cn-shenzhen.fnf.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("fnf", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Creates a flow.
         *
         * @description ## [](#)Usage notes
         * *   The number of flows that each user can create is restricted by resources. For more information, see [Limits](https://help.aliyun.com/document_detail/122093.html). If you want to create more flows, submit a ticket.
         * *   At the user level, flows are distinguished by name. The name of a flow within one account must be unique.
         *
         * @param request CreateFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFlowResponse
         */
        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                body["ExecutionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStorageLocation))
            {
                body["ExternalStorageLocation"] = request.ExternalStorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a flow.
         *
         * @description ## [](#)Usage notes
         * *   The number of flows that each user can create is restricted by resources. For more information, see [Limits](https://help.aliyun.com/document_detail/122093.html). If you want to create more flows, submit a ticket.
         * *   At the user level, flows are distinguished by name. The name of a flow within one account must be unique.
         *
         * @param request CreateFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFlowResponse
         */
        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                body["ExecutionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStorageLocation))
            {
                body["ExternalStorageLocation"] = request.ExternalStorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a flow.
         *
         * @description ## [](#)Usage notes
         * *   The number of flows that each user can create is restricted by resources. For more information, see [Limits](https://help.aliyun.com/document_detail/122093.html). If you want to create more flows, submit a ticket.
         * *   At the user level, flows are distinguished by name. The name of a flow within one account must be unique.
         *
         * @param request CreateFlowRequest
         * @return CreateFlowResponse
         */
        public CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowWithOptions(request, runtime);
        }

        /**
         * @summary Creates a flow.
         *
         * @description ## [](#)Usage notes
         * *   The number of flows that each user can create is restricted by resources. For more information, see [Limits](https://help.aliyun.com/document_detail/122093.html). If you want to create more flows, submit a ticket.
         * *   At the user level, flows are distinguished by name. The name of a flow within one account must be unique.
         *
         * @param request CreateFlowRequest
         * @return CreateFlowResponse
         */
        public async Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a time-based schedule.
         *
         * @param request CreateScheduleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduleResponse
         */
        public CreateScheduleResponse CreateScheduleWithOptions(CreateScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureVersion))
            {
                query["SignatureVersion"] = request.SignatureVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpression))
            {
                body["CronExpression"] = request.CronExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleName))
            {
                body["ScheduleName"] = request.ScheduleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSchedule",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a time-based schedule.
         *
         * @param request CreateScheduleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduleResponse
         */
        public async Task<CreateScheduleResponse> CreateScheduleWithOptionsAsync(CreateScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureVersion))
            {
                query["SignatureVersion"] = request.SignatureVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpression))
            {
                body["CronExpression"] = request.CronExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleName))
            {
                body["ScheduleName"] = request.ScheduleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSchedule",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a time-based schedule.
         *
         * @param request CreateScheduleRequest
         * @return CreateScheduleResponse
         */
        public CreateScheduleResponse CreateSchedule(CreateScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduleWithOptions(request, runtime);
        }

        /**
         * @summary Creates a time-based schedule.
         *
         * @param request CreateScheduleRequest
         * @return CreateScheduleResponse
         */
        public async Task<CreateScheduleResponse> CreateScheduleAsync(CreateScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an existing flow.
         *
         * @description ## [](#)Usage notes
         * A delete operation is asynchronous. If this operation is successful, the system returns a successful response. If an existing flow is pending to be deleted, a new flow of the same name will not be affected by the existing one. After you delete a flow, you cannot query its historical executions. All executions in progress will stop after their most recent steps are complete.
         *
         * @param request DeleteFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFlowResponse
         */
        public DeleteFlowResponse DeleteFlowWithOptions(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an existing flow.
         *
         * @description ## [](#)Usage notes
         * A delete operation is asynchronous. If this operation is successful, the system returns a successful response. If an existing flow is pending to be deleted, a new flow of the same name will not be affected by the existing one. After you delete a flow, you cannot query its historical executions. All executions in progress will stop after their most recent steps are complete.
         *
         * @param request DeleteFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFlowResponse
         */
        public async Task<DeleteFlowResponse> DeleteFlowWithOptionsAsync(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an existing flow.
         *
         * @description ## [](#)Usage notes
         * A delete operation is asynchronous. If this operation is successful, the system returns a successful response. If an existing flow is pending to be deleted, a new flow of the same name will not be affected by the existing one. After you delete a flow, you cannot query its historical executions. All executions in progress will stop after their most recent steps are complete.
         *
         * @param request DeleteFlowRequest
         * @return DeleteFlowResponse
         */
        public DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an existing flow.
         *
         * @description ## [](#)Usage notes
         * A delete operation is asynchronous. If this operation is successful, the system returns a successful response. If an existing flow is pending to be deleted, a new flow of the same name will not be affected by the existing one. After you delete a flow, you cannot query its historical executions. All executions in progress will stop after their most recent steps are complete.
         *
         * @param request DeleteFlowRequest
         * @return DeleteFlowResponse
         */
        public async Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a time-based scheduling task.
         *
         * @param request DeleteScheduleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduleResponse
         */
        public DeleteScheduleResponse DeleteScheduleWithOptions(DeleteScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleName))
            {
                body["ScheduleName"] = request.ScheduleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSchedule",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a time-based scheduling task.
         *
         * @param request DeleteScheduleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduleResponse
         */
        public async Task<DeleteScheduleResponse> DeleteScheduleWithOptionsAsync(DeleteScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleName))
            {
                body["ScheduleName"] = request.ScheduleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSchedule",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a time-based scheduling task.
         *
         * @param request DeleteScheduleRequest
         * @return DeleteScheduleResponse
         */
        public DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduleWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a time-based scheduling task.
         *
         * @param request DeleteScheduleRequest
         * @return DeleteScheduleResponse
         */
        public async Task<DeleteScheduleResponse> DeleteScheduleAsync(DeleteScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries an execution in a flow. The long polling mode is supported. The maximum waiting period for long polling depends on the value of the WaitTimeSeconds parameter.
         *
         * @param request DescribeExecutionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExecutionResponse
         */
        public DescribeExecutionResponse DescribeExecutionWithOptions(DescribeExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExecution",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExecutionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries an execution in a flow. The long polling mode is supported. The maximum waiting period for long polling depends on the value of the WaitTimeSeconds parameter.
         *
         * @param request DescribeExecutionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExecutionResponse
         */
        public async Task<DescribeExecutionResponse> DescribeExecutionWithOptionsAsync(DescribeExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExecution",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries an execution in a flow. The long polling mode is supported. The maximum waiting period for long polling depends on the value of the WaitTimeSeconds parameter.
         *
         * @param request DescribeExecutionRequest
         * @return DescribeExecutionResponse
         */
        public DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExecutionWithOptions(request, runtime);
        }

        /**
         * @summary Queries an execution in a flow. The long polling mode is supported. The maximum waiting period for long polling depends on the value of the WaitTimeSeconds parameter.
         *
         * @param request DescribeExecutionRequest
         * @return DescribeExecutionResponse
         */
        public async Task<DescribeExecutionResponse> DescribeExecutionAsync(DescribeExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExecutionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a flow.
         *
         * @param request DescribeFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFlowResponse
         */
        public DescribeFlowResponse DescribeFlowWithOptions(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlow",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a flow.
         *
         * @param request DescribeFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFlowResponse
         */
        public async Task<DescribeFlowResponse> DescribeFlowWithOptionsAsync(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlow",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a flow.
         *
         * @param request DescribeFlowRequest
         * @return DescribeFlowResponse
         */
        public DescribeFlowResponse DescribeFlow(DescribeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a flow.
         *
         * @param request DescribeFlowRequest
         * @return DescribeFlowResponse
         */
        public async Task<DescribeFlowResponse> DescribeFlowAsync(DescribeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the detailed information about a time-based schedule.
         *
         * @param request DescribeScheduleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScheduleResponse
         */
        public DescribeScheduleResponse DescribeScheduleWithOptions(DescribeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSchedule",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScheduleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed information about a time-based schedule.
         *
         * @param request DescribeScheduleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScheduleResponse
         */
        public async Task<DescribeScheduleResponse> DescribeScheduleWithOptionsAsync(DescribeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSchedule",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed information about a time-based schedule.
         *
         * @param request DescribeScheduleRequest
         * @return DescribeScheduleResponse
         */
        public DescribeScheduleResponse DescribeSchedule(DescribeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScheduleWithOptions(request, runtime);
        }

        /**
         * @summary Queries the detailed information about a time-based schedule.
         *
         * @param request DescribeScheduleRequest
         * @return DescribeScheduleResponse
         */
        public async Task<DescribeScheduleResponse> DescribeScheduleAsync(DescribeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScheduleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about each step in an execution process.
         *
         * @param request GetExecutionHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExecutionHistoryResponse
         */
        public GetExecutionHistoryResponse GetExecutionHistoryWithOptions(GetExecutionHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExecutionHistory",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExecutionHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about each step in an execution process.
         *
         * @param request GetExecutionHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExecutionHistoryResponse
         */
        public async Task<GetExecutionHistoryResponse> GetExecutionHistoryWithOptionsAsync(GetExecutionHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExecutionHistory",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExecutionHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about each step in an execution process.
         *
         * @param request GetExecutionHistoryRequest
         * @return GetExecutionHistoryResponse
         */
        public GetExecutionHistoryResponse GetExecutionHistory(GetExecutionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExecutionHistoryWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about each step in an execution process.
         *
         * @param request GetExecutionHistoryRequest
         * @return GetExecutionHistoryResponse
         */
        public async Task<GetExecutionHistoryResponse> GetExecutionHistoryAsync(GetExecutionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExecutionHistoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all historical executions of a flow.
         *
         * @description ## [](#)Usage notes
         * After you delete a flow, you cannot query its historical executions, even if you create a flow of the same name.
         *
         * @param request ListExecutionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExecutionsResponse
         */
        public ListExecutionsResponse ListExecutionsWithOptions(ListExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutions",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all historical executions of a flow.
         *
         * @description ## [](#)Usage notes
         * After you delete a flow, you cannot query its historical executions, even if you create a flow of the same name.
         *
         * @param request ListExecutionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExecutionsResponse
         */
        public async Task<ListExecutionsResponse> ListExecutionsWithOptionsAsync(ListExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutions",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all historical executions of a flow.
         *
         * @description ## [](#)Usage notes
         * After you delete a flow, you cannot query its historical executions, even if you create a flow of the same name.
         *
         * @param request ListExecutionsRequest
         * @return ListExecutionsResponse
         */
        public ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all historical executions of a flow.
         *
         * @description ## [](#)Usage notes
         * After you delete a flow, you cannot query its historical executions, even if you create a flow of the same name.
         *
         * @param request ListExecutionsRequest
         * @return ListExecutionsResponse
         */
        public async Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of flows.
         *
         * @param request ListFlowsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFlowsResponse
         */
        public ListFlowsResponse ListFlowsWithOptions(ListFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlows",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of flows.
         *
         * @param request ListFlowsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFlowsResponse
         */
        public async Task<ListFlowsResponse> ListFlowsWithOptionsAsync(ListFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlows",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of flows.
         *
         * @param request ListFlowsRequest
         * @return ListFlowsResponse
         */
        public ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowsWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of flows.
         *
         * @param request ListFlowsRequest
         * @return ListFlowsResponse
         */
        public async Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries time-based schedules in a flow.
         *
         * @param request ListSchedulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSchedulesResponse
         */
        public ListSchedulesResponse ListSchedulesWithOptions(ListSchedulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSchedules",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSchedulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries time-based schedules in a flow.
         *
         * @param request ListSchedulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSchedulesResponse
         */
        public async Task<ListSchedulesResponse> ListSchedulesWithOptionsAsync(ListSchedulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSchedules",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSchedulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries time-based schedules in a flow.
         *
         * @param request ListSchedulesRequest
         * @return ListSchedulesResponse
         */
        public ListSchedulesResponse ListSchedules(ListSchedulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSchedulesWithOptions(request, runtime);
        }

        /**
         * @summary Queries time-based schedules in a flow.
         *
         * @param request ListSchedulesRequest
         * @return ListSchedulesResponse
         */
        public async Task<ListSchedulesResponse> ListSchedulesAsync(ListSchedulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSchedulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Reports a failed task.
         *
         * @description ## [](#)Usage notes
         * In the previous service (Serverless Workflow), the task step that ReportTaskFailed is used to call back `pattern: waitForCallback` indicates that the current task fails to be executed.
         * In the new service (CloudFlow), the task step that ReportTaskFailed is used to call back `TaskMode: WaitForCustomCallback` indicates that the current task fails to be executed.
         *
         * @param request ReportTaskFailedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportTaskFailedResponse
         */
        public ReportTaskFailedResponse ReportTaskFailedWithOptions(ReportTaskFailedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskToken))
            {
                query["TaskToken"] = request.TaskToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["Cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Error))
            {
                body["Error"] = request.Error;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportTaskFailed",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportTaskFailedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Reports a failed task.
         *
         * @description ## [](#)Usage notes
         * In the previous service (Serverless Workflow), the task step that ReportTaskFailed is used to call back `pattern: waitForCallback` indicates that the current task fails to be executed.
         * In the new service (CloudFlow), the task step that ReportTaskFailed is used to call back `TaskMode: WaitForCustomCallback` indicates that the current task fails to be executed.
         *
         * @param request ReportTaskFailedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportTaskFailedResponse
         */
        public async Task<ReportTaskFailedResponse> ReportTaskFailedWithOptionsAsync(ReportTaskFailedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskToken))
            {
                query["TaskToken"] = request.TaskToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["Cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Error))
            {
                body["Error"] = request.Error;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportTaskFailed",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportTaskFailedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Reports a failed task.
         *
         * @description ## [](#)Usage notes
         * In the previous service (Serverless Workflow), the task step that ReportTaskFailed is used to call back `pattern: waitForCallback` indicates that the current task fails to be executed.
         * In the new service (CloudFlow), the task step that ReportTaskFailed is used to call back `TaskMode: WaitForCustomCallback` indicates that the current task fails to be executed.
         *
         * @param request ReportTaskFailedRequest
         * @return ReportTaskFailedResponse
         */
        public ReportTaskFailedResponse ReportTaskFailed(ReportTaskFailedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportTaskFailedWithOptions(request, runtime);
        }

        /**
         * @summary Reports a failed task.
         *
         * @description ## [](#)Usage notes
         * In the previous service (Serverless Workflow), the task step that ReportTaskFailed is used to call back `pattern: waitForCallback` indicates that the current task fails to be executed.
         * In the new service (CloudFlow), the task step that ReportTaskFailed is used to call back `TaskMode: WaitForCustomCallback` indicates that the current task fails to be executed.
         *
         * @param request ReportTaskFailedRequest
         * @return ReportTaskFailedResponse
         */
        public async Task<ReportTaskFailedResponse> ReportTaskFailedAsync(ReportTaskFailedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportTaskFailedWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Reports a successful task.
         *
         * @description ## [](#)Usage notes
         * In the previous service (Serverless Workflow), the task step that ReportTaskSucceeded is used to call back pattern: waitForCallback indicates that the current task is successfully executed.
         * In the new service (CloudFlow), the task step that ReportTaskSucceeded is used to call back TaskMode: WaitForCustomCallback indicates that the current task is successfully executed.
         *
         * @param request ReportTaskSucceededRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportTaskSucceededResponse
         */
        public ReportTaskSucceededResponse ReportTaskSucceededWithOptions(ReportTaskSucceededRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskToken))
            {
                query["TaskToken"] = request.TaskToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["Output"] = request.Output;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportTaskSucceeded",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportTaskSucceededResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Reports a successful task.
         *
         * @description ## [](#)Usage notes
         * In the previous service (Serverless Workflow), the task step that ReportTaskSucceeded is used to call back pattern: waitForCallback indicates that the current task is successfully executed.
         * In the new service (CloudFlow), the task step that ReportTaskSucceeded is used to call back TaskMode: WaitForCustomCallback indicates that the current task is successfully executed.
         *
         * @param request ReportTaskSucceededRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportTaskSucceededResponse
         */
        public async Task<ReportTaskSucceededResponse> ReportTaskSucceededWithOptionsAsync(ReportTaskSucceededRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskToken))
            {
                query["TaskToken"] = request.TaskToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["Output"] = request.Output;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportTaskSucceeded",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportTaskSucceededResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Reports a successful task.
         *
         * @description ## [](#)Usage notes
         * In the previous service (Serverless Workflow), the task step that ReportTaskSucceeded is used to call back pattern: waitForCallback indicates that the current task is successfully executed.
         * In the new service (CloudFlow), the task step that ReportTaskSucceeded is used to call back TaskMode: WaitForCustomCallback indicates that the current task is successfully executed.
         *
         * @param request ReportTaskSucceededRequest
         * @return ReportTaskSucceededResponse
         */
        public ReportTaskSucceededResponse ReportTaskSucceeded(ReportTaskSucceededRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportTaskSucceededWithOptions(request, runtime);
        }

        /**
         * @summary Reports a successful task.
         *
         * @description ## [](#)Usage notes
         * In the previous service (Serverless Workflow), the task step that ReportTaskSucceeded is used to call back pattern: waitForCallback indicates that the current task is successfully executed.
         * In the new service (CloudFlow), the task step that ReportTaskSucceeded is used to call back TaskMode: WaitForCustomCallback indicates that the current task is successfully executed.
         *
         * @param request ReportTaskSucceededRequest
         * @return ReportTaskSucceededResponse
         */
        public async Task<ReportTaskSucceededResponse> ReportTaskSucceededAsync(ReportTaskSucceededRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportTaskSucceededWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Starts the execution of a workflow.
         *
         * @description ## [](#)Usage notes
         * *   The flow is created. A flow only in standard mode is supported.
         * *   If you do not specify an execution, the system automatically generates an execution and starts the execution.
         * *   If an ongoing execution has the same name as that of the execution to be started, the system directly returns the ongoing execution.
         * *   If the ongoing execution with the same name has ended (succeeded or failed), `ExecutionAlreadyExists` is returned.
         * *   If no execution with the same name exists, the system starts a new execution.
         *
         * @param request StartExecutionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartExecutionResponse
         */
        public StartExecutionResponse StartExecutionWithOptions(StartExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackFnFTaskToken))
            {
                body["CallbackFnFTaskToken"] = request.CallbackFnFTaskToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionName))
            {
                body["ExecutionName"] = request.ExecutionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartExecution",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartExecutionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Starts the execution of a workflow.
         *
         * @description ## [](#)Usage notes
         * *   The flow is created. A flow only in standard mode is supported.
         * *   If you do not specify an execution, the system automatically generates an execution and starts the execution.
         * *   If an ongoing execution has the same name as that of the execution to be started, the system directly returns the ongoing execution.
         * *   If the ongoing execution with the same name has ended (succeeded or failed), `ExecutionAlreadyExists` is returned.
         * *   If no execution with the same name exists, the system starts a new execution.
         *
         * @param request StartExecutionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartExecutionResponse
         */
        public async Task<StartExecutionResponse> StartExecutionWithOptionsAsync(StartExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackFnFTaskToken))
            {
                body["CallbackFnFTaskToken"] = request.CallbackFnFTaskToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionName))
            {
                body["ExecutionName"] = request.ExecutionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartExecution",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Starts the execution of a workflow.
         *
         * @description ## [](#)Usage notes
         * *   The flow is created. A flow only in standard mode is supported.
         * *   If you do not specify an execution, the system automatically generates an execution and starts the execution.
         * *   If an ongoing execution has the same name as that of the execution to be started, the system directly returns the ongoing execution.
         * *   If the ongoing execution with the same name has ended (succeeded or failed), `ExecutionAlreadyExists` is returned.
         * *   If no execution with the same name exists, the system starts a new execution.
         *
         * @param request StartExecutionRequest
         * @return StartExecutionResponse
         */
        public StartExecutionResponse StartExecution(StartExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartExecutionWithOptions(request, runtime);
        }

        /**
         * @summary Starts the execution of a workflow.
         *
         * @description ## [](#)Usage notes
         * *   The flow is created. A flow only in standard mode is supported.
         * *   If you do not specify an execution, the system automatically generates an execution and starts the execution.
         * *   If an ongoing execution has the same name as that of the execution to be started, the system directly returns the ongoing execution.
         * *   If the ongoing execution with the same name has ended (succeeded or failed), `ExecutionAlreadyExists` is returned.
         * *   If no execution with the same name exists, the system starts a new execution.
         *
         * @param request StartExecutionRequest
         * @return StartExecutionResponse
         */
        public async Task<StartExecutionResponse> StartExecutionAsync(StartExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartExecutionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Synchronously starts an execution in a flow.
         *
         * @description *   Only flows of the express execution mode are supported.
         *
         * @param request StartSyncExecutionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartSyncExecutionResponse
         */
        public StartSyncExecutionResponse StartSyncExecutionWithOptions(StartSyncExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionName))
            {
                body["ExecutionName"] = request.ExecutionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSyncExecution",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSyncExecutionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Synchronously starts an execution in a flow.
         *
         * @description *   Only flows of the express execution mode are supported.
         *
         * @param request StartSyncExecutionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartSyncExecutionResponse
         */
        public async Task<StartSyncExecutionResponse> StartSyncExecutionWithOptionsAsync(StartSyncExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionName))
            {
                body["ExecutionName"] = request.ExecutionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSyncExecution",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSyncExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Synchronously starts an execution in a flow.
         *
         * @description *   Only flows of the express execution mode are supported.
         *
         * @param request StartSyncExecutionRequest
         * @return StartSyncExecutionResponse
         */
        public StartSyncExecutionResponse StartSyncExecution(StartSyncExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartSyncExecutionWithOptions(request, runtime);
        }

        /**
         * @summary Synchronously starts an execution in a flow.
         *
         * @description *   Only flows of the express execution mode are supported.
         *
         * @param request StartSyncExecutionRequest
         * @return StartSyncExecutionResponse
         */
        public async Task<StartSyncExecutionResponse> StartSyncExecutionAsync(StartSyncExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartSyncExecutionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Stops an execution that is in progress in a flow.
         *
         * @description ## [](#)Usage notes
         * The flow must be in progress.
         *
         * @param request StopExecutionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopExecutionResponse
         */
        public StopExecutionResponse StopExecutionWithOptions(StopExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["Cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Error))
            {
                body["Error"] = request.Error;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionName))
            {
                body["ExecutionName"] = request.ExecutionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopExecution",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopExecutionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Stops an execution that is in progress in a flow.
         *
         * @description ## [](#)Usage notes
         * The flow must be in progress.
         *
         * @param request StopExecutionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopExecutionResponse
         */
        public async Task<StopExecutionResponse> StopExecutionWithOptionsAsync(StopExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["Cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Error))
            {
                body["Error"] = request.Error;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionName))
            {
                body["ExecutionName"] = request.ExecutionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopExecution",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Stops an execution that is in progress in a flow.
         *
         * @description ## [](#)Usage notes
         * The flow must be in progress.
         *
         * @param request StopExecutionRequest
         * @return StopExecutionResponse
         */
        public StopExecutionResponse StopExecution(StopExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopExecutionWithOptions(request, runtime);
        }

        /**
         * @summary Stops an execution that is in progress in a flow.
         *
         * @description ## [](#)Usage notes
         * The flow must be in progress.
         *
         * @param request StopExecutionRequest
         * @return StopExecutionResponse
         */
        public async Task<StopExecutionResponse> StopExecutionAsync(StopExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopExecutionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates a flow.
         *
         * @param request UpdateFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFlowResponse
         */
        public UpdateFlowResponse UpdateFlowWithOptions(UpdateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlow",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates a flow.
         *
         * @param request UpdateFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFlowResponse
         */
        public async Task<UpdateFlowResponse> UpdateFlowWithOptionsAsync(UpdateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlow",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates a flow.
         *
         * @param request UpdateFlowRequest
         * @return UpdateFlowResponse
         */
        public UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlowWithOptions(request, runtime);
        }

        /**
         * @summary Updates a flow.
         *
         * @param request UpdateFlowRequest
         * @return UpdateFlowResponse
         */
        public async Task<UpdateFlowResponse> UpdateFlowAsync(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates a time-based schedule.
         *
         * @param request UpdateScheduleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScheduleResponse
         */
        public UpdateScheduleResponse UpdateScheduleWithOptions(UpdateScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpression))
            {
                body["CronExpression"] = request.CronExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleName))
            {
                body["ScheduleName"] = request.ScheduleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSchedule",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates a time-based schedule.
         *
         * @param request UpdateScheduleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScheduleResponse
         */
        public async Task<UpdateScheduleResponse> UpdateScheduleWithOptionsAsync(UpdateScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpression))
            {
                body["CronExpression"] = request.CronExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleName))
            {
                body["ScheduleName"] = request.ScheduleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSchedule",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates a time-based schedule.
         *
         * @param request UpdateScheduleRequest
         * @return UpdateScheduleResponse
         */
        public UpdateScheduleResponse UpdateSchedule(UpdateScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateScheduleWithOptions(request, runtime);
        }

        /**
         * @summary Updates a time-based schedule.
         *
         * @param request UpdateScheduleRequest
         * @return UpdateScheduleResponse
         */
        public async Task<UpdateScheduleResponse> UpdateScheduleAsync(UpdateScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateScheduleWithOptionsAsync(request, runtime);
        }

    }
}
