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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>The number of flows that each user can create is restricted by resources. For more information, see <a href="https://help.aliyun.com/document_detail/122093.html">Limits</a>. If you want to create more flows, submit a ticket.</description></item>
        /// <item><description>At the user level, flows are distinguished by name. The name of a flow within one account must be unique.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlowShrinkRequest request = new CreateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Environment))
            {
                request.EnvironmentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Environment, "Environment", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentShrink))
            {
                body["Environment"] = request.EnvironmentShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>The number of flows that each user can create is restricted by resources. For more information, see <a href="https://help.aliyun.com/document_detail/122093.html">Limits</a>. If you want to create more flows, submit a ticket.</description></item>
        /// <item><description>At the user level, flows are distinguished by name. The name of a flow within one account must be unique.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlowShrinkRequest request = new CreateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Environment))
            {
                request.EnvironmentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Environment, "Environment", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentShrink))
            {
                body["Environment"] = request.EnvironmentShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>The number of flows that each user can create is restricted by resources. For more information, see <a href="https://help.aliyun.com/document_detail/122093.html">Limits</a>. If you want to create more flows, submit a ticket.</description></item>
        /// <item><description>At the user level, flows are distinguished by name. The name of a flow within one account must be unique.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>The number of flows that each user can create is restricted by resources. For more information, see <a href="https://help.aliyun.com/document_detail/122093.html">Limits</a>. If you want to create more flows, submit a ticket.</description></item>
        /// <item><description>At the user level, flows are distinguished by name. The name of a flow within one account must be unique.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public async Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程版本别名</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateFlowAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowAliasResponse
        /// </returns>
        public CreateFlowAliasResponse CreateFlowAliasWithOptions(CreateFlowAliasRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlowAliasShrinkRequest request = new CreateFlowAliasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoutingConfigurations))
            {
                request.RoutingConfigurationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoutingConfigurations, "RoutingConfigurations", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutingConfigurationsShrink))
            {
                body["RoutingConfigurations"] = request.RoutingConfigurationsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowAlias",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程版本别名</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateFlowAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowAliasResponse
        /// </returns>
        public async Task<CreateFlowAliasResponse> CreateFlowAliasWithOptionsAsync(CreateFlowAliasRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlowAliasShrinkRequest request = new CreateFlowAliasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoutingConfigurations))
            {
                request.RoutingConfigurationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoutingConfigurations, "RoutingConfigurations", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutingConfigurationsShrink))
            {
                body["RoutingConfigurations"] = request.RoutingConfigurationsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowAlias",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程版本别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowAliasResponse
        /// </returns>
        public CreateFlowAliasResponse CreateFlowAlias(CreateFlowAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowAliasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流程版本别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowAliasResponse
        /// </returns>
        public async Task<CreateFlowAliasResponse> CreateFlowAliasAsync(CreateFlowAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleResponse
        /// </returns>
        public CreateScheduleResponse CreateSchedule(CreateScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleResponse
        /// </returns>
        public async Task<CreateScheduleResponse> CreateScheduleAsync(CreateScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an existing flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>A delete operation is asynchronous. If this operation is successful, the system returns a successful response. If an existing flow is pending to be deleted, a new flow of the same name will not be affected by the existing one. After you delete a flow, you cannot query its historical executions. All executions in progress will stop after their most recent steps are complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an existing flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>A delete operation is asynchronous. If this operation is successful, the system returns a successful response. If an existing flow is pending to be deleted, a new flow of the same name will not be affected by the existing one. After you delete a flow, you cannot query its historical executions. All executions in progress will stop after their most recent steps are complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an existing flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>A delete operation is asynchronous. If this operation is successful, the system returns a successful response. If an existing flow is pending to be deleted, a new flow of the same name will not be affected by the existing one. After you delete a flow, you cannot query its historical executions. All executions in progress will stop after their most recent steps are complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an existing flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>A delete operation is asynchronous. If this operation is successful, the system returns a successful response. If an existing flow is pending to be deleted, a new flow of the same name will not be affected by the existing one. After you delete a flow, you cannot query its historical executions. All executions in progress will stop after their most recent steps are complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public async Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowAliasResponse
        /// </returns>
        public DeleteFlowAliasResponse DeleteFlowAliasWithOptions(DeleteFlowAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
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
                Action = "DeleteFlowAlias",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowAliasResponse
        /// </returns>
        public async Task<DeleteFlowAliasResponse> DeleteFlowAliasWithOptionsAsync(DeleteFlowAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
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
                Action = "DeleteFlowAlias",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowAliasResponse
        /// </returns>
        public DeleteFlowAliasResponse DeleteFlowAlias(DeleteFlowAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowAliasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程别名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowAliasResponse
        /// </returns>
        public async Task<DeleteFlowAliasResponse> DeleteFlowAliasAsync(DeleteFlowAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowVersionResponse
        /// </returns>
        public DeleteFlowVersionResponse DeleteFlowVersionWithOptions(DeleteFlowVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                body["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowVersion",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowVersionResponse
        /// </returns>
        public async Task<DeleteFlowVersionResponse> DeleteFlowVersionWithOptionsAsync(DeleteFlowVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                body["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowVersion",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowVersionResponse
        /// </returns>
        public DeleteFlowVersionResponse DeleteFlowVersion(DeleteFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流程版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowVersionResponse
        /// </returns>
        public async Task<DeleteFlowVersionResponse> DeleteFlowVersionAsync(DeleteFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a time-based scheduling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a time-based scheduling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a time-based scheduling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduleResponse
        /// </returns>
        public DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a time-based scheduling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduleResponse
        /// </returns>
        public async Task<DeleteScheduleResponse> DeleteScheduleAsync(DeleteScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an execution in a flow. The long polling mode is supported. The maximum waiting period for long polling depends on the value of the WaitTimeSeconds parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExecutionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an execution in a flow. The long polling mode is supported. The maximum waiting period for long polling depends on the value of the WaitTimeSeconds parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExecutionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an execution in a flow. The long polling mode is supported. The maximum waiting period for long polling depends on the value of the WaitTimeSeconds parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExecutionResponse
        /// </returns>
        public DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an execution in a flow. The long polling mode is supported. The maximum waiting period for long polling depends on the value of the WaitTimeSeconds parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExecutionResponse
        /// </returns>
        public async Task<DescribeExecutionResponse> DescribeExecutionAsync(DescribeExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowResponse
        /// </returns>
        public DescribeFlowResponse DescribeFlow(DescribeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowResponse
        /// </returns>
        public async Task<DescribeFlowResponse> DescribeFlowAsync(DescribeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本别名详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowAliasResponse
        /// </returns>
        public DescribeFlowAliasResponse DescribeFlowAliasWithOptions(DescribeFlowAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowAlias",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本别名详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowAliasResponse
        /// </returns>
        public async Task<DescribeFlowAliasResponse> DescribeFlowAliasWithOptionsAsync(DescribeFlowAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowAlias",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本别名详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowAliasResponse
        /// </returns>
        public DescribeFlowAliasResponse DescribeFlowAlias(DescribeFlowAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowAliasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本别名详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowAliasResponse
        /// </returns>
        public async Task<DescribeFlowAliasResponse> DescribeFlowAliasAsync(DescribeFlowAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 MapRun 详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMapRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMapRunResponse
        /// </returns>
        public DescribeMapRunResponse DescribeMapRunWithOptions(DescribeMapRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMapRun",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMapRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 MapRun 详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMapRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMapRunResponse
        /// </returns>
        public async Task<DescribeMapRunResponse> DescribeMapRunWithOptionsAsync(DescribeMapRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMapRun",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMapRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 MapRun 详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMapRunRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMapRunResponse
        /// </returns>
        public DescribeMapRunResponse DescribeMapRun(DescribeMapRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMapRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 MapRun 详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMapRunRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMapRunResponse
        /// </returns>
        public async Task<DescribeMapRunResponse> DescribeMapRunAsync(DescribeMapRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMapRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地域信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地域信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地域信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地域信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScheduleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScheduleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScheduleResponse
        /// </returns>
        public DescribeScheduleResponse DescribeSchedule(DescribeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScheduleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScheduleResponse
        /// </returns>
        public async Task<DescribeScheduleResponse> DescribeScheduleAsync(DescribeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScheduleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about each step in an execution process.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecutionHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExecutionHistoryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about each step in an execution process.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecutionHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExecutionHistoryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about each step in an execution process.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecutionHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExecutionHistoryResponse
        /// </returns>
        public GetExecutionHistoryResponse GetExecutionHistory(GetExecutionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExecutionHistoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about each step in an execution process.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecutionHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExecutionHistoryResponse
        /// </returns>
        public async Task<GetExecutionHistoryResponse> GetExecutionHistoryAsync(GetExecutionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExecutionHistoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all historical executions of a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>After you delete a flow, you cannot query its historical executions, even if you create a flow of the same name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all historical executions of a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>After you delete a flow, you cannot query its historical executions, even if you create a flow of the same name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all historical executions of a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>After you delete a flow, you cannot query its historical executions, even if you create a flow of the same name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionsResponse
        /// </returns>
        public ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all historical executions of a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>After you delete a flow, you cannot query its historical executions, even if you create a flow of the same name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionsResponse
        /// </returns>
        public async Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本别名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowAliasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowAliasesResponse
        /// </returns>
        public ListFlowAliasesResponse ListFlowAliasesWithOptions(ListFlowAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowAliases",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowAliasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本别名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowAliasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowAliasesResponse
        /// </returns>
        public async Task<ListFlowAliasesResponse> ListFlowAliasesWithOptionsAsync(ListFlowAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowAliases",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowAliasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本别名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowAliasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowAliasesResponse
        /// </returns>
        public ListFlowAliasesResponse ListFlowAliases(ListFlowAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowAliasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本别名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowAliasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowAliasesResponse
        /// </returns>
        public async Task<ListFlowAliasesResponse> ListFlowAliasesAsync(ListFlowAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowAliasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowVersionsResponse
        /// </returns>
        public ListFlowVersionsResponse ListFlowVersionsWithOptions(ListFlowVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowVersions",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowVersionsResponse
        /// </returns>
        public async Task<ListFlowVersionsResponse> ListFlowVersionsWithOptionsAsync(ListFlowVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowVersions",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowVersionsResponse
        /// </returns>
        public ListFlowVersionsResponse ListFlowVersions(ListFlowVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流程版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowVersionsResponse
        /// </returns>
        public async Task<ListFlowVersionsResponse> ListFlowVersionsAsync(ListFlowVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of flows.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of flows.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of flows.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowsResponse
        /// </returns>
        public ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of flows.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowsResponse
        /// </returns>
        public async Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries time-based schedules in a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchedulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSchedulesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries time-based schedules in a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchedulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSchedulesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries time-based schedules in a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchedulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSchedulesResponse
        /// </returns>
        public ListSchedulesResponse ListSchedules(ListSchedulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSchedulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries time-based schedules in a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchedulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSchedulesResponse
        /// </returns>
        public async Task<ListSchedulesResponse> ListSchedulesAsync(ListSchedulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSchedulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流程版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishFlowVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowVersionResponse
        /// </returns>
        public PublishFlowVersionResponse PublishFlowVersionWithOptions(PublishFlowVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
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
                Action = "PublishFlowVersion",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFlowVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流程版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishFlowVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowVersionResponse
        /// </returns>
        public async Task<PublishFlowVersionResponse> PublishFlowVersionWithOptionsAsync(PublishFlowVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
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
                Action = "PublishFlowVersion",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFlowVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流程版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowVersionResponse
        /// </returns>
        public PublishFlowVersionResponse PublishFlowVersion(PublishFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishFlowVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流程版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowVersionResponse
        /// </returns>
        public async Task<PublishFlowVersionResponse> PublishFlowVersionAsync(PublishFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishFlowVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports a failed task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>In the previous service (Serverless Workflow), the task step that ReportTaskFailed is used to call back <c>pattern: waitForCallback</c> indicates that the current task fails to be executed.
        /// In the new service (CloudFlow), the task step that ReportTaskFailed is used to call back <c>TaskMode: WaitForCustomCallback</c> indicates that the current task fails to be executed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReportTaskFailedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportTaskFailedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports a failed task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>In the previous service (Serverless Workflow), the task step that ReportTaskFailed is used to call back <c>pattern: waitForCallback</c> indicates that the current task fails to be executed.
        /// In the new service (CloudFlow), the task step that ReportTaskFailed is used to call back <c>TaskMode: WaitForCustomCallback</c> indicates that the current task fails to be executed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReportTaskFailedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportTaskFailedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports a failed task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>In the previous service (Serverless Workflow), the task step that ReportTaskFailed is used to call back <c>pattern: waitForCallback</c> indicates that the current task fails to be executed.
        /// In the new service (CloudFlow), the task step that ReportTaskFailed is used to call back <c>TaskMode: WaitForCustomCallback</c> indicates that the current task fails to be executed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReportTaskFailedRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportTaskFailedResponse
        /// </returns>
        public ReportTaskFailedResponse ReportTaskFailed(ReportTaskFailedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportTaskFailedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports a failed task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>In the previous service (Serverless Workflow), the task step that ReportTaskFailed is used to call back <c>pattern: waitForCallback</c> indicates that the current task fails to be executed.
        /// In the new service (CloudFlow), the task step that ReportTaskFailed is used to call back <c>TaskMode: WaitForCustomCallback</c> indicates that the current task fails to be executed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReportTaskFailedRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportTaskFailedResponse
        /// </returns>
        public async Task<ReportTaskFailedResponse> ReportTaskFailedAsync(ReportTaskFailedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportTaskFailedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports a successful task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>In the previous service (Serverless Workflow), the task step that ReportTaskSucceeded is used to call back pattern: waitForCallback indicates that the current task is successfully executed.
        /// In the new service (CloudFlow), the task step that ReportTaskSucceeded is used to call back TaskMode: WaitForCustomCallback indicates that the current task is successfully executed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReportTaskSucceededRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportTaskSucceededResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports a successful task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>In the previous service (Serverless Workflow), the task step that ReportTaskSucceeded is used to call back pattern: waitForCallback indicates that the current task is successfully executed.
        /// In the new service (CloudFlow), the task step that ReportTaskSucceeded is used to call back TaskMode: WaitForCustomCallback indicates that the current task is successfully executed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReportTaskSucceededRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportTaskSucceededResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports a successful task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>In the previous service (Serverless Workflow), the task step that ReportTaskSucceeded is used to call back pattern: waitForCallback indicates that the current task is successfully executed.
        /// In the new service (CloudFlow), the task step that ReportTaskSucceeded is used to call back TaskMode: WaitForCustomCallback indicates that the current task is successfully executed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReportTaskSucceededRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportTaskSucceededResponse
        /// </returns>
        public ReportTaskSucceededResponse ReportTaskSucceeded(ReportTaskSucceededRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportTaskSucceededWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reports a successful task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>In the previous service (Serverless Workflow), the task step that ReportTaskSucceeded is used to call back pattern: waitForCallback indicates that the current task is successfully executed.
        /// In the new service (CloudFlow), the task step that ReportTaskSucceeded is used to call back TaskMode: WaitForCustomCallback indicates that the current task is successfully executed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReportTaskSucceededRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportTaskSucceededResponse
        /// </returns>
        public async Task<ReportTaskSucceededResponse> ReportTaskSucceededAsync(ReportTaskSucceededRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportTaskSucceededWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the execution of a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>The flow is created. A flow only in standard mode is supported.</description></item>
        /// <item><description>If you do not specify an execution, the system automatically generates an execution and starts the execution.</description></item>
        /// <item><description>If an ongoing execution has the same name as that of the execution to be started, the system directly returns the ongoing execution.</description></item>
        /// <item><description>If the ongoing execution with the same name has ended (succeeded or failed), <c>ExecutionAlreadyExists</c> is returned.</description></item>
        /// <item><description>If no execution with the same name exists, the system starts a new execution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartExecutionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["Qualifier"] = request.Qualifier;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the execution of a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>The flow is created. A flow only in standard mode is supported.</description></item>
        /// <item><description>If you do not specify an execution, the system automatically generates an execution and starts the execution.</description></item>
        /// <item><description>If an ongoing execution has the same name as that of the execution to be started, the system directly returns the ongoing execution.</description></item>
        /// <item><description>If the ongoing execution with the same name has ended (succeeded or failed), <c>ExecutionAlreadyExists</c> is returned.</description></item>
        /// <item><description>If no execution with the same name exists, the system starts a new execution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartExecutionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["Qualifier"] = request.Qualifier;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the execution of a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>The flow is created. A flow only in standard mode is supported.</description></item>
        /// <item><description>If you do not specify an execution, the system automatically generates an execution and starts the execution.</description></item>
        /// <item><description>If an ongoing execution has the same name as that of the execution to be started, the system directly returns the ongoing execution.</description></item>
        /// <item><description>If the ongoing execution with the same name has ended (succeeded or failed), <c>ExecutionAlreadyExists</c> is returned.</description></item>
        /// <item><description>If no execution with the same name exists, the system starts a new execution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartExecutionResponse
        /// </returns>
        public StartExecutionResponse StartExecution(StartExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the execution of a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>The flow is created. A flow only in standard mode is supported.</description></item>
        /// <item><description>If you do not specify an execution, the system automatically generates an execution and starts the execution.</description></item>
        /// <item><description>If an ongoing execution has the same name as that of the execution to be started, the system directly returns the ongoing execution.</description></item>
        /// <item><description>If the ongoing execution with the same name has ended (succeeded or failed), <c>ExecutionAlreadyExists</c> is returned.</description></item>
        /// <item><description>If no execution with the same name exists, the system starts a new execution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartExecutionResponse
        /// </returns>
        public async Task<StartExecutionResponse> StartExecutionAsync(StartExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronously starts an execution in a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only flows of the express execution mode are supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartSyncExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartSyncExecutionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["Qualifier"] = request.Qualifier;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronously starts an execution in a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only flows of the express execution mode are supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartSyncExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartSyncExecutionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["Qualifier"] = request.Qualifier;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronously starts an execution in a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only flows of the express execution mode are supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartSyncExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartSyncExecutionResponse
        /// </returns>
        public StartSyncExecutionResponse StartSyncExecution(StartSyncExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartSyncExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronously starts an execution in a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only flows of the express execution mode are supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartSyncExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartSyncExecutionResponse
        /// </returns>
        public async Task<StartSyncExecutionResponse> StartSyncExecutionAsync(StartSyncExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartSyncExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an execution that is in progress in a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>The flow must be in progress.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopExecutionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an execution that is in progress in a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>The flow must be in progress.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopExecutionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an execution that is in progress in a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>The flow must be in progress.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StopExecutionResponse
        /// </returns>
        public StopExecutionResponse StopExecution(StopExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an execution that is in progress in a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>The flow must be in progress.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StopExecutionResponse
        /// </returns>
        public async Task<StopExecutionResponse> StopExecutionAsync(StopExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a flow.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public UpdateFlowResponse UpdateFlowWithOptions(UpdateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFlowShrinkRequest request = new UpdateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Environment))
            {
                request.EnvironmentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Environment, "Environment", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentShrink))
            {
                body["Environment"] = request.EnvironmentShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a flow.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public async Task<UpdateFlowResponse> UpdateFlowWithOptionsAsync(UpdateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFlowShrinkRequest request = new UpdateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Environment))
            {
                request.EnvironmentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Environment, "Environment", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentShrink))
            {
                body["Environment"] = request.EnvironmentShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a flow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public async Task<UpdateFlowResponse> UpdateFlowAsync(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程版本别名配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateFlowAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowAliasResponse
        /// </returns>
        public UpdateFlowAliasResponse UpdateFlowAliasWithOptions(UpdateFlowAliasRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFlowAliasShrinkRequest request = new UpdateFlowAliasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoutingConfigurations))
            {
                request.RoutingConfigurationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoutingConfigurations, "RoutingConfigurations", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutingConfigurationsShrink))
            {
                body["RoutingConfigurations"] = request.RoutingConfigurationsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowAlias",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程版本别名配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateFlowAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowAliasResponse
        /// </returns>
        public async Task<UpdateFlowAliasResponse> UpdateFlowAliasWithOptionsAsync(UpdateFlowAliasRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFlowAliasShrinkRequest request = new UpdateFlowAliasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoutingConfigurations))
            {
                request.RoutingConfigurationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoutingConfigurations, "RoutingConfigurations", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutingConfigurationsShrink))
            {
                body["RoutingConfigurations"] = request.RoutingConfigurationsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowAlias",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程版本别名配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlowAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowAliasResponse
        /// </returns>
        public UpdateFlowAliasResponse UpdateFlowAlias(UpdateFlowAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlowAliasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流程版本别名配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlowAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowAliasResponse
        /// </returns>
        public async Task<UpdateFlowAliasResponse> UpdateFlowAliasAsync(UpdateFlowAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlowAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 MapRun 配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMapRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMapRunResponse
        /// </returns>
        public UpdateMapRunResponse UpdateMapRunWithOptions(UpdateMapRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMapRun",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMapRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 MapRun 配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMapRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMapRunResponse
        /// </returns>
        public async Task<UpdateMapRunResponse> UpdateMapRunWithOptionsAsync(UpdateMapRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMapRun",
                Version = "2019-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMapRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 MapRun 配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMapRunRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMapRunResponse
        /// </returns>
        public UpdateMapRunResponse UpdateMapRun(UpdateMapRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMapRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 MapRun 配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMapRunRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMapRunResponse
        /// </returns>
        public async Task<UpdateMapRunResponse> UpdateMapRunAsync(UpdateMapRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMapRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleResponse
        /// </returns>
        public UpdateScheduleResponse UpdateSchedule(UpdateScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateScheduleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a time-based schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduleResponse
        /// </returns>
        public async Task<UpdateScheduleResponse> UpdateScheduleAsync(UpdateScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateScheduleWithOptionsAsync(request, runtime);
        }

    }
}
