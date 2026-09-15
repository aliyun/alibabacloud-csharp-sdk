// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AlikafkaStreaming20260202.Models;

namespace AlibabaCloud.SDK.AlikafkaStreaming20260202
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("alikafkastreaming", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>检查sql语法</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过 GET 或 POST 方法调用。</description></item>
        /// <item><description>必须提供 <c>InstanceId</c>、<c>JobName</c> 和 <c>SqlContent</c> 参数，其中 <c>SqlContent</c> 是待校验的 Flink SQL 语句。</description></item>
        /// <item><description>返回结果中，<c>Data.Valid</c> 字段指示 SQL 是否通过校验；若未通过，则错误详情位于 <c>Data.ErrorList</c> 中。</description></item>
        /// <item><description>当前版本要求同时传入实例 ID (<c>InstanceId</c>) 和作业名称 (<c>JobName</c>) 以构建作业上下文。</description></item>
        /// <item><description>接口返回成功仅表示校验流程执行完成，并不直接反映 SQL 的有效性，请检查 <c>Data.Valid</c> 字段来确定 SQL 是否有效。</description></item>
        /// <item><description>错误码和异常处理请参考文档中的“错误码”部分。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckSqlContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSqlContentResponse
        /// </returns>
        public CheckSqlContentResponse CheckSqlContentWithOptions(CheckSqlContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlContent))
            {
                query["SqlContent"] = request.SqlContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSqlContent",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSqlContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查sql语法</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过 GET 或 POST 方法调用。</description></item>
        /// <item><description>必须提供 <c>InstanceId</c>、<c>JobName</c> 和 <c>SqlContent</c> 参数，其中 <c>SqlContent</c> 是待校验的 Flink SQL 语句。</description></item>
        /// <item><description>返回结果中，<c>Data.Valid</c> 字段指示 SQL 是否通过校验；若未通过，则错误详情位于 <c>Data.ErrorList</c> 中。</description></item>
        /// <item><description>当前版本要求同时传入实例 ID (<c>InstanceId</c>) 和作业名称 (<c>JobName</c>) 以构建作业上下文。</description></item>
        /// <item><description>接口返回成功仅表示校验流程执行完成，并不直接反映 SQL 的有效性，请检查 <c>Data.Valid</c> 字段来确定 SQL 是否有效。</description></item>
        /// <item><description>错误码和异常处理请参考文档中的“错误码”部分。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckSqlContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSqlContentResponse
        /// </returns>
        public async Task<CheckSqlContentResponse> CheckSqlContentWithOptionsAsync(CheckSqlContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlContent))
            {
                query["SqlContent"] = request.SqlContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSqlContent",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSqlContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查sql语法</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过 GET 或 POST 方法调用。</description></item>
        /// <item><description>必须提供 <c>InstanceId</c>、<c>JobName</c> 和 <c>SqlContent</c> 参数，其中 <c>SqlContent</c> 是待校验的 Flink SQL 语句。</description></item>
        /// <item><description>返回结果中，<c>Data.Valid</c> 字段指示 SQL 是否通过校验；若未通过，则错误详情位于 <c>Data.ErrorList</c> 中。</description></item>
        /// <item><description>当前版本要求同时传入实例 ID (<c>InstanceId</c>) 和作业名称 (<c>JobName</c>) 以构建作业上下文。</description></item>
        /// <item><description>接口返回成功仅表示校验流程执行完成，并不直接反映 SQL 的有效性，请检查 <c>Data.Valid</c> 字段来确定 SQL 是否有效。</description></item>
        /// <item><description>错误码和异常处理请参考文档中的“错误码”部分。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckSqlContentRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSqlContentResponse
        /// </returns>
        public CheckSqlContentResponse CheckSqlContent(CheckSqlContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSqlContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查sql语法</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过 GET 或 POST 方法调用。</description></item>
        /// <item><description>必须提供 <c>InstanceId</c>、<c>JobName</c> 和 <c>SqlContent</c> 参数，其中 <c>SqlContent</c> 是待校验的 Flink SQL 语句。</description></item>
        /// <item><description>返回结果中，<c>Data.Valid</c> 字段指示 SQL 是否通过校验；若未通过，则错误详情位于 <c>Data.ErrorList</c> 中。</description></item>
        /// <item><description>当前版本要求同时传入实例 ID (<c>InstanceId</c>) 和作业名称 (<c>JobName</c>) 以构建作业上下文。</description></item>
        /// <item><description>接口返回成功仅表示校验流程执行完成，并不直接反映 SQL 的有效性，请检查 <c>Data.Valid</c> 字段来确定 SQL 是否有效。</description></item>
        /// <item><description>错误码和异常处理请参考文档中的“错误码”部分。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckSqlContentRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSqlContentResponse
        /// </returns>
        public async Task<CheckSqlContentResponse> CheckSqlContentAsync(CheckSqlContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSqlContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 流计算实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个计算实例。接口只完成购买阶段；创建成功后需调用 StartComputeInstance 完成网络配置和部署。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：CreateComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeInstanceResponse
        /// </returns>
        public CreateComputeInstanceResponse CreateComputeInstanceWithOptions(CreateComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 流计算实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个计算实例。接口只完成购买阶段；创建成功后需调用 StartComputeInstance 完成网络配置和部署。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：CreateComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeInstanceResponse
        /// </returns>
        public async Task<CreateComputeInstanceResponse> CreateComputeInstanceWithOptionsAsync(CreateComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 流计算实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个计算实例。接口只完成购买阶段；创建成功后需调用 StartComputeInstance 完成网络配置和部署。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：CreateComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeInstanceResponse
        /// </returns>
        public CreateComputeInstanceResponse CreateComputeInstance(CreateComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateComputeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 流计算实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个计算实例。接口只完成购买阶段；创建成功后需调用 StartComputeInstance 完成网络配置和部署。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：CreateComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeInstanceResponse
        /// </returns>
        public async Task<CreateComputeInstanceResponse> CreateComputeInstanceAsync(CreateComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateComputeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于在指定的运行中的计算实例上创建一个新的Flink SQL作业。</description></item>
        /// <item><description>创建后的作业将处于<c>INIT</c>状态。</description></item>
        /// <item><description>用户可以通过设置<c>CuLimit</c>和<c>CuReserved</c>来控制作业的资源使用情况。</description></item>
        /// <item><description><c>Remark</c>字段允许用户为作业添加备注信息，便于管理和识别。</description></item>
        /// <item><description>确保提供的<c>RegionId</c>、<c>InstanceId</c>以及<c>JobName</c>参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果尝试创建同名作业，则会返回错误提示。</description></item>
        /// <item><description>计算实例必须处于运行状态才能成功创建作业。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeJobResponse
        /// </returns>
        public CreateComputeJobResponse CreateComputeJobWithOptions(CreateComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuLimit))
            {
                query["CuLimit"] = request.CuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuReserved))
            {
                query["CuReserved"] = request.CuReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于在指定的运行中的计算实例上创建一个新的Flink SQL作业。</description></item>
        /// <item><description>创建后的作业将处于<c>INIT</c>状态。</description></item>
        /// <item><description>用户可以通过设置<c>CuLimit</c>和<c>CuReserved</c>来控制作业的资源使用情况。</description></item>
        /// <item><description><c>Remark</c>字段允许用户为作业添加备注信息，便于管理和识别。</description></item>
        /// <item><description>确保提供的<c>RegionId</c>、<c>InstanceId</c>以及<c>JobName</c>参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果尝试创建同名作业，则会返回错误提示。</description></item>
        /// <item><description>计算实例必须处于运行状态才能成功创建作业。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeJobResponse
        /// </returns>
        public async Task<CreateComputeJobResponse> CreateComputeJobWithOptionsAsync(CreateComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuLimit))
            {
                query["CuLimit"] = request.CuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuReserved))
            {
                query["CuReserved"] = request.CuReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于在指定的运行中的计算实例上创建一个新的Flink SQL作业。</description></item>
        /// <item><description>创建后的作业将处于<c>INIT</c>状态。</description></item>
        /// <item><description>用户可以通过设置<c>CuLimit</c>和<c>CuReserved</c>来控制作业的资源使用情况。</description></item>
        /// <item><description><c>Remark</c>字段允许用户为作业添加备注信息，便于管理和识别。</description></item>
        /// <item><description>确保提供的<c>RegionId</c>、<c>InstanceId</c>以及<c>JobName</c>参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果尝试创建同名作业，则会返回错误提示。</description></item>
        /// <item><description>计算实例必须处于运行状态才能成功创建作业。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeJobResponse
        /// </returns>
        public CreateComputeJobResponse CreateComputeJob(CreateComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateComputeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于在指定的运行中的计算实例上创建一个新的Flink SQL作业。</description></item>
        /// <item><description>创建后的作业将处于<c>INIT</c>状态。</description></item>
        /// <item><description>用户可以通过设置<c>CuLimit</c>和<c>CuReserved</c>来控制作业的资源使用情况。</description></item>
        /// <item><description><c>Remark</c>字段允许用户为作业添加备注信息，便于管理和识别。</description></item>
        /// <item><description>确保提供的<c>RegionId</c>、<c>InstanceId</c>以及<c>JobName</c>参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果尝试创建同名作业，则会返回错误提示。</description></item>
        /// <item><description>计算实例必须处于运行状态才能成功创建作业。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeJobResponse
        /// </returns>
        public async Task<CreateComputeJobResponse> CreateComputeJobAsync(CreateComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateComputeJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除处于待部署、已停止或已释放状态的计算实例。</para>
        /// <list type="bullet">
        /// <item><description>API版本：2026-02-02</description></item>
        /// <item><description>Action：DeleteComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeInstanceResponse
        /// </returns>
        public DeleteComputeInstanceResponse DeleteComputeInstanceWithOptions(DeleteComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteComputeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除处于待部署、已停止或已释放状态的计算实例。</para>
        /// <list type="bullet">
        /// <item><description>API版本：2026-02-02</description></item>
        /// <item><description>Action：DeleteComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeInstanceResponse
        /// </returns>
        public async Task<DeleteComputeInstanceResponse> DeleteComputeInstanceWithOptionsAsync(DeleteComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteComputeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除处于待部署、已停止或已释放状态的计算实例。</para>
        /// <list type="bullet">
        /// <item><description>API版本：2026-02-02</description></item>
        /// <item><description>Action：DeleteComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeInstanceResponse
        /// </returns>
        public DeleteComputeInstanceResponse DeleteComputeInstance(DeleteComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteComputeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除处于待部署、已停止或已释放状态的计算实例。</para>
        /// <list type="bullet">
        /// <item><description>API版本：2026-02-02</description></item>
        /// <item><description>Action：DeleteComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeInstanceResponse
        /// </returns>
        public async Task<DeleteComputeInstanceResponse> DeleteComputeInstanceAsync(DeleteComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteComputeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于删除一个特定的计算作业。</description></item>
        /// <item><description>成功调用此接口仅表示删除请求已被系统接受，并非立即完成删除操作。</description></item>
        /// <item><description>确保提供的<c>RegionId</c>、<c>InstanceId</c>以及<c>JobName</c>参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果计算实例或作业处于不允许删除的状态（例如：非运行状态），则会返回相应的错误信息。</description></item>
        /// <item><description>删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeJobResponse
        /// </returns>
        public DeleteComputeJobResponse DeleteComputeJobWithOptions(DeleteComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteComputeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于删除一个特定的计算作业。</description></item>
        /// <item><description>成功调用此接口仅表示删除请求已被系统接受，并非立即完成删除操作。</description></item>
        /// <item><description>确保提供的<c>RegionId</c>、<c>InstanceId</c>以及<c>JobName</c>参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果计算实例或作业处于不允许删除的状态（例如：非运行状态），则会返回相应的错误信息。</description></item>
        /// <item><description>删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeJobResponse
        /// </returns>
        public async Task<DeleteComputeJobResponse> DeleteComputeJobWithOptionsAsync(DeleteComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteComputeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于删除一个特定的计算作业。</description></item>
        /// <item><description>成功调用此接口仅表示删除请求已被系统接受，并非立即完成删除操作。</description></item>
        /// <item><description>确保提供的<c>RegionId</c>、<c>InstanceId</c>以及<c>JobName</c>参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果计算实例或作业处于不允许删除的状态（例如：非运行状态），则会返回相应的错误信息。</description></item>
        /// <item><description>删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeJobResponse
        /// </returns>
        public DeleteComputeJobResponse DeleteComputeJob(DeleteComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteComputeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于删除一个特定的计算作业。</description></item>
        /// <item><description>成功调用此接口仅表示删除请求已被系统接受，并非立即完成删除操作。</description></item>
        /// <item><description>确保提供的<c>RegionId</c>、<c>InstanceId</c>以及<c>JobName</c>参数准确无误，否则可能导致请求失败。</description></item>
        /// <item><description>如果计算实例或作业处于不允许删除的状态（例如：非运行状态），则会返回相应的错误信息。</description></item>
        /// <item><description>删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeJobResponse
        /// </returns>
        public async Task<DeleteComputeJobResponse> DeleteComputeJobAsync(DeleteComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteComputeJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeInstanceResponse
        /// </returns>
        public GetComputeInstanceResponse GetComputeInstanceWithOptions(GetComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeInstanceResponse
        /// </returns>
        public async Task<GetComputeInstanceResponse> GetComputeInstanceWithOptionsAsync(GetComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetComputeInstanceResponse
        /// </returns>
        public GetComputeInstanceResponse GetComputeInstance(GetComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetComputeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetComputeInstanceResponse
        /// </returns>
        public async Task<GetComputeInstanceResponse> GetComputeInstanceAsync(GetComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetComputeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 JOB 详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询指定计算作业的详情。</description></item>
        /// <item><description>支持使用 GET 或 POST 方法进行请求。</description></item>
        /// <item><description>所有时间字段以 Unix 时间戳形式返回，单位为毫秒。</description></item>
        /// <item><description>必须提供 <c>RegionId</c>、<c>InstanceId</c> 和 <c>JobName</c> 参数。</description></item>
        /// <item><description>授权操作为 <c>alikafkastreaming:GetComputeJob</c>，访问级别为读取（Read）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeJobResponse
        /// </returns>
        public GetComputeJobResponse GetComputeJobWithOptions(GetComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 JOB 详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询指定计算作业的详情。</description></item>
        /// <item><description>支持使用 GET 或 POST 方法进行请求。</description></item>
        /// <item><description>所有时间字段以 Unix 时间戳形式返回，单位为毫秒。</description></item>
        /// <item><description>必须提供 <c>RegionId</c>、<c>InstanceId</c> 和 <c>JobName</c> 参数。</description></item>
        /// <item><description>授权操作为 <c>alikafkastreaming:GetComputeJob</c>，访问级别为读取（Read）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeJobResponse
        /// </returns>
        public async Task<GetComputeJobResponse> GetComputeJobWithOptionsAsync(GetComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 JOB 详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询指定计算作业的详情。</description></item>
        /// <item><description>支持使用 GET 或 POST 方法进行请求。</description></item>
        /// <item><description>所有时间字段以 Unix 时间戳形式返回，单位为毫秒。</description></item>
        /// <item><description>必须提供 <c>RegionId</c>、<c>InstanceId</c> 和 <c>JobName</c> 参数。</description></item>
        /// <item><description>授权操作为 <c>alikafkastreaming:GetComputeJob</c>，访问级别为读取（Read）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetComputeJobResponse
        /// </returns>
        public GetComputeJobResponse GetComputeJob(GetComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetComputeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 JOB 详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询指定计算作业的详情。</description></item>
        /// <item><description>支持使用 GET 或 POST 方法进行请求。</description></item>
        /// <item><description>所有时间字段以 Unix 时间戳形式返回，单位为毫秒。</description></item>
        /// <item><description>必须提供 <c>RegionId</c>、<c>InstanceId</c> 和 <c>JobName</c> 参数。</description></item>
        /// <item><description>授权操作为 <c>alikafkastreaming:GetComputeJob</c>，访问级别为读取（Read）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetComputeJobResponse
        /// </returns>
        public async Task<GetComputeJobResponse> GetComputeJobAsync(GetComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetComputeJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取debug信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobDebugDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobDebugDataResponse
        /// </returns>
        public GetJobDebugDataResponse GetJobDebugDataWithOptions(GetJobDebugDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobDebugData",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobDebugDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取debug信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobDebugDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobDebugDataResponse
        /// </returns>
        public async Task<GetJobDebugDataResponse> GetJobDebugDataWithOptionsAsync(GetJobDebugDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobDebugData",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobDebugDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取debug信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobDebugDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobDebugDataResponse
        /// </returns>
        public GetJobDebugDataResponse GetJobDebugData(GetJobDebugDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobDebugDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取debug信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobDebugDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobDebugDataResponse
        /// </returns>
        public async Task<GetJobDebugDataResponse> GetJobDebugDataAsync(GetJobDebugDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobDebugDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListComputeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeInstancesResponse
        /// </returns>
        public ListComputeInstancesResponse ListComputeInstancesWithOptions(ListComputeInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListComputeInstancesShrinkRequest request = new ListComputeInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeInstances",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListComputeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeInstancesResponse
        /// </returns>
        public async Task<ListComputeInstancesResponse> ListComputeInstancesWithOptionsAsync(ListComputeInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListComputeInstancesShrinkRequest request = new ListComputeInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeInstances",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComputeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComputeInstancesResponse
        /// </returns>
        public ListComputeInstancesResponse ListComputeInstances(ListComputeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListComputeInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComputeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComputeInstancesResponse
        /// </returns>
        public async Task<ListComputeInstancesResponse> ListComputeInstancesAsync(ListComputeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListComputeInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListComputeInstancesInPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeInstancesInPageResponse
        /// </returns>
        public ListComputeInstancesInPageResponse ListComputeInstancesInPageWithOptions(ListComputeInstancesInPageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListComputeInstancesInPageShrinkRequest request = new ListComputeInstancesInPageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeInstancesInPage",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeInstancesInPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListComputeInstancesInPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeInstancesInPageResponse
        /// </returns>
        public async Task<ListComputeInstancesInPageResponse> ListComputeInstancesInPageWithOptionsAsync(ListComputeInstancesInPageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListComputeInstancesInPageShrinkRequest request = new ListComputeInstancesInPageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeInstancesInPage",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeInstancesInPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComputeInstancesInPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComputeInstancesInPageResponse
        /// </returns>
        public ListComputeInstancesInPageResponse ListComputeInstancesInPage(ListComputeInstancesInPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListComputeInstancesInPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComputeInstancesInPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComputeInstancesInPageResponse
        /// </returns>
        public async Task<ListComputeInstancesInPageResponse> ListComputeInstancesInPageAsync(ListComputeInstancesInPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListComputeInstancesInPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询 JOB 列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过 <c>MaxResults</c> 和 <c>NextToken</c> 参数进行游标分页查询。</description></item>
        /// <item><description>首次请求时不需要传递 <c>NextToken</c>，后续请求需使用上一次响应中返回的 <c>NextToken</c> 值。</description></item>
        /// <item><description>支持按作业名称或备注搜索，并可选择不同的排序字段和方向。</description></item>
        /// <item><description>返回的时间字段均为 Unix 时间戳（单位：毫秒）。</description></item>
        /// <item><description>授权操作为 <c>alikafkastreaming:ListComputeJobs</c>，访问级别为列出（List），适用于全部资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListComputeJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeJobsResponse
        /// </returns>
        public ListComputeJobsResponse ListComputeJobsWithOptions(ListComputeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirection))
            {
                query["SortDirection"] = request.SortDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeJobs",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询 JOB 列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过 <c>MaxResults</c> 和 <c>NextToken</c> 参数进行游标分页查询。</description></item>
        /// <item><description>首次请求时不需要传递 <c>NextToken</c>，后续请求需使用上一次响应中返回的 <c>NextToken</c> 值。</description></item>
        /// <item><description>支持按作业名称或备注搜索，并可选择不同的排序字段和方向。</description></item>
        /// <item><description>返回的时间字段均为 Unix 时间戳（单位：毫秒）。</description></item>
        /// <item><description>授权操作为 <c>alikafkastreaming:ListComputeJobs</c>，访问级别为列出（List），适用于全部资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListComputeJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeJobsResponse
        /// </returns>
        public async Task<ListComputeJobsResponse> ListComputeJobsWithOptionsAsync(ListComputeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirection))
            {
                query["SortDirection"] = request.SortDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeJobs",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询 JOB 列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过 <c>MaxResults</c> 和 <c>NextToken</c> 参数进行游标分页查询。</description></item>
        /// <item><description>首次请求时不需要传递 <c>NextToken</c>，后续请求需使用上一次响应中返回的 <c>NextToken</c> 值。</description></item>
        /// <item><description>支持按作业名称或备注搜索，并可选择不同的排序字段和方向。</description></item>
        /// <item><description>返回的时间字段均为 Unix 时间戳（单位：毫秒）。</description></item>
        /// <item><description>授权操作为 <c>alikafkastreaming:ListComputeJobs</c>，访问级别为列出（List），适用于全部资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListComputeJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComputeJobsResponse
        /// </returns>
        public ListComputeJobsResponse ListComputeJobs(ListComputeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListComputeJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询 JOB 列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口支持通过 <c>MaxResults</c> 和 <c>NextToken</c> 参数进行游标分页查询。</description></item>
        /// <item><description>首次请求时不需要传递 <c>NextToken</c>，后续请求需使用上一次响应中返回的 <c>NextToken</c> 值。</description></item>
        /// <item><description>支持按作业名称或备注搜索，并可选择不同的排序字段和方向。</description></item>
        /// <item><description>返回的时间字段均为 Unix 时间戳（单位：毫秒）。</description></item>
        /// <item><description>授权操作为 <c>alikafkastreaming:ListComputeJobs</c>，访问级别为列出（List），适用于全部资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListComputeJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComputeJobsResponse
        /// </returns>
        public async Task<ListComputeJobsResponse> ListComputeJobsAsync(ListComputeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListComputeJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询创建 SQL 任务时支持的连接器列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSupportedConnectorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSupportedConnectorsResponse
        /// </returns>
        public ListSupportedConnectorsResponse ListSupportedConnectorsWithOptions(ListSupportedConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSupportedConnectors",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSupportedConnectorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询创建 SQL 任务时支持的连接器列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSupportedConnectorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSupportedConnectorsResponse
        /// </returns>
        public async Task<ListSupportedConnectorsResponse> ListSupportedConnectorsWithOptionsAsync(ListSupportedConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSupportedConnectors",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSupportedConnectorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询创建 SQL 任务时支持的连接器列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSupportedConnectorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSupportedConnectorsResponse
        /// </returns>
        public ListSupportedConnectorsResponse ListSupportedConnectors(ListSupportedConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSupportedConnectorsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询创建 SQL 任务时支持的连接器列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSupportedConnectorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSupportedConnectorsResponse
        /// </returns>
        public async Task<ListSupportedConnectorsResponse> ListSupportedConnectorsAsync(ListSupportedConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSupportedConnectorsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新启动后付费实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>重新启用一个已停止的后付费计算实例。接口返回成功表示启用请求已受理。</para>
        /// <list type="bullet">
        /// <item><description>API版本：2026-02-02</description></item>
        /// <item><description>Action：ReopenComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReopenComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReopenComputeInstanceResponse
        /// </returns>
        public ReopenComputeInstanceResponse ReopenComputeInstanceWithOptions(ReopenComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReopenComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReopenComputeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新启动后付费实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>重新启用一个已停止的后付费计算实例。接口返回成功表示启用请求已受理。</para>
        /// <list type="bullet">
        /// <item><description>API版本：2026-02-02</description></item>
        /// <item><description>Action：ReopenComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReopenComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReopenComputeInstanceResponse
        /// </returns>
        public async Task<ReopenComputeInstanceResponse> ReopenComputeInstanceWithOptionsAsync(ReopenComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReopenComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReopenComputeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新启动后付费实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>重新启用一个已停止的后付费计算实例。接口返回成功表示启用请求已受理。</para>
        /// <list type="bullet">
        /// <item><description>API版本：2026-02-02</description></item>
        /// <item><description>Action：ReopenComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReopenComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReopenComputeInstanceResponse
        /// </returns>
        public ReopenComputeInstanceResponse ReopenComputeInstance(ReopenComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReopenComputeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新启动后付费实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>重新启用一个已停止的后付费计算实例。接口返回成功表示启用请求已受理。</para>
        /// <list type="bullet">
        /// <item><description>API版本：2026-02-02</description></item>
        /// <item><description>Action：ReopenComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReopenComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReopenComputeInstanceResponse
        /// </returns>
        public async Task<ReopenComputeInstanceResponse> ReopenComputeInstanceAsync(ReopenComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReopenComputeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启 JOB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartComputeJobResponse
        /// </returns>
        public RestartComputeJobResponse RestartComputeJobWithOptions(RestartComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartComputeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启 JOB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartComputeJobResponse
        /// </returns>
        public async Task<RestartComputeJobResponse> RestartComputeJobWithOptionsAsync(RestartComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartComputeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启 JOB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartComputeJobResponse
        /// </returns>
        public RestartComputeJobResponse RestartComputeJob(RestartComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartComputeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重启 JOB</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartComputeJobResponse
        /// </returns>
        public async Task<RestartComputeJobResponse> RestartComputeJobAsync(RestartComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartComputeJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部署实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为处于待部署状态的计算实例配置网络并发起部署。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：StartComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// StartComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartComputeInstanceResponse
        /// </returns>
        public StartComputeInstanceResponse StartComputeInstanceWithOptions(StartComputeInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartComputeInstanceShrinkRequest request = new StartComputeInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                query["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartComputeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部署实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为处于待部署状态的计算实例配置网络并发起部署。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：StartComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// StartComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartComputeInstanceResponse
        /// </returns>
        public async Task<StartComputeInstanceResponse> StartComputeInstanceWithOptionsAsync(StartComputeInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartComputeInstanceShrinkRequest request = new StartComputeInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                query["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartComputeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部署实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为处于待部署状态的计算实例配置网络并发起部署。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：StartComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartComputeInstanceResponse
        /// </returns>
        public StartComputeInstanceResponse StartComputeInstance(StartComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartComputeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部署实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为处于待部署状态的计算实例配置网络并发起部署。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：StartComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartComputeInstanceResponse
        /// </returns>
        public async Task<StartComputeInstanceResponse> StartComputeInstanceAsync(StartComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartComputeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>RecoveryMode</c> 支持两种模式：<c>savepoint</c> 和 <c>stateless</c>。如果选择 <c>savepoint</c> 模式但没有可用的 savepoint，则会返回错误。</description></item>
        /// <item><description><c>CuLimit</c> 和 <c>CuReserved</c> 参数分别用来设定作业的 CU 上限和预留 CU 数量，支持整数或小数形式输入。</description></item>
        /// <item><description>确保提供的 <c>RegionId</c>, <c>InstanceId</c>, 和 <c>JobName</c> 参数值正确且存在，否则将导致请求失败。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartComputeJobResponse
        /// </returns>
        public StartComputeJobResponse StartComputeJobWithOptions(StartComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuLimit))
            {
                query["CuLimit"] = request.CuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuReserved))
            {
                query["CuReserved"] = request.CuReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DraftSql))
            {
                query["DraftSql"] = request.DraftSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMode))
            {
                query["RecoveryMode"] = request.RecoveryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartComputeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>RecoveryMode</c> 支持两种模式：<c>savepoint</c> 和 <c>stateless</c>。如果选择 <c>savepoint</c> 模式但没有可用的 savepoint，则会返回错误。</description></item>
        /// <item><description><c>CuLimit</c> 和 <c>CuReserved</c> 参数分别用来设定作业的 CU 上限和预留 CU 数量，支持整数或小数形式输入。</description></item>
        /// <item><description>确保提供的 <c>RegionId</c>, <c>InstanceId</c>, 和 <c>JobName</c> 参数值正确且存在，否则将导致请求失败。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartComputeJobResponse
        /// </returns>
        public async Task<StartComputeJobResponse> StartComputeJobWithOptionsAsync(StartComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuLimit))
            {
                query["CuLimit"] = request.CuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuReserved))
            {
                query["CuReserved"] = request.CuReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DraftSql))
            {
                query["DraftSql"] = request.DraftSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMode))
            {
                query["RecoveryMode"] = request.RecoveryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartComputeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>RecoveryMode</c> 支持两种模式：<c>savepoint</c> 和 <c>stateless</c>。如果选择 <c>savepoint</c> 模式但没有可用的 savepoint，则会返回错误。</description></item>
        /// <item><description><c>CuLimit</c> 和 <c>CuReserved</c> 参数分别用来设定作业的 CU 上限和预留 CU 数量，支持整数或小数形式输入。</description></item>
        /// <item><description>确保提供的 <c>RegionId</c>, <c>InstanceId</c>, 和 <c>JobName</c> 参数值正确且存在，否则将导致请求失败。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StartComputeJobResponse
        /// </returns>
        public StartComputeJobResponse StartComputeJob(StartComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartComputeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>RecoveryMode</c> 支持两种模式：<c>savepoint</c> 和 <c>stateless</c>。如果选择 <c>savepoint</c> 模式但没有可用的 savepoint，则会返回错误。</description></item>
        /// <item><description><c>CuLimit</c> 和 <c>CuReserved</c> 参数分别用来设定作业的 CU 上限和预留 CU 数量，支持整数或小数形式输入。</description></item>
        /// <item><description>确保提供的 <c>RegionId</c>, <c>InstanceId</c>, 和 <c>JobName</c> 参数值正确且存在，否则将导致请求失败。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StartComputeJobResponse
        /// </returns>
        public async Task<StartComputeJobResponse> StartComputeJobAsync(StartComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartComputeJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停用/释放后付费实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>停止一个正在运行的后付费计算实例。接口返回成功表示停止请求已受理。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：StopComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopComputeInstanceResponse
        /// </returns>
        public StopComputeInstanceResponse StopComputeInstanceWithOptions(StopComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopComputeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停用/释放后付费实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>停止一个正在运行的后付费计算实例。接口返回成功表示停止请求已受理。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：StopComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopComputeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopComputeInstanceResponse
        /// </returns>
        public async Task<StopComputeInstanceResponse> StopComputeInstanceWithOptionsAsync(StopComputeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopComputeInstance",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopComputeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停用/释放后付费实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>停止一个正在运行的后付费计算实例。接口返回成功表示停止请求已受理。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：StopComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopComputeInstanceResponse
        /// </returns>
        public StopComputeInstanceResponse StopComputeInstance(StopComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopComputeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停用/释放后付费实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>停止一个正在运行的后付费计算实例。接口返回成功表示停止请求已受理。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：StopComputeInstance</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopComputeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopComputeInstanceResponse
        /// </returns>
        public async Task<StopComputeInstanceResponse> StopComputeInstanceAsync(StopComputeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopComputeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于停止指定的计算作业生产或 Debug 运行实例。</description></item>
        /// <item><description>接口返回成功表示停止请求已被受理，但并不意味着作业立即停止。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopComputeJobResponse
        /// </returns>
        public StopComputeJobResponse StopComputeJobWithOptions(StopComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopComputeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于停止指定的计算作业生产或 Debug 运行实例。</description></item>
        /// <item><description>接口返回成功表示停止请求已被受理，但并不意味着作业立即停止。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopComputeJobResponse
        /// </returns>
        public async Task<StopComputeJobResponse> StopComputeJobWithOptionsAsync(StopComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopComputeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于停止指定的计算作业生产或 Debug 运行实例。</description></item>
        /// <item><description>接口返回成功表示停止请求已被受理，但并不意味着作业立即停止。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StopComputeJobResponse
        /// </returns>
        public StopComputeJobResponse StopComputeJob(StopComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopComputeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于停止指定的计算作业生产或 Debug 运行实例。</description></item>
        /// <item><description>接口返回成功表示停止请求已被受理，但并不意味着作业立即停止。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StopComputeJobResponse
        /// </returns>
        public async Task<StopComputeJobResponse> StopComputeJobAsync(StopComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopComputeJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例名称</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>修改计算实例名称。实例需处于部署准备阶段或运行中状态。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：UpdateComputeInstanceName</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeInstanceNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeInstanceNameResponse
        /// </returns>
        public UpdateComputeInstanceNameResponse UpdateComputeInstanceNameWithOptions(UpdateComputeInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeInstanceName",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeInstanceNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例名称</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>修改计算实例名称。实例需处于部署准备阶段或运行中状态。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：UpdateComputeInstanceName</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeInstanceNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeInstanceNameResponse
        /// </returns>
        public async Task<UpdateComputeInstanceNameResponse> UpdateComputeInstanceNameWithOptionsAsync(UpdateComputeInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeInstanceName",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeInstanceNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例名称</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>修改计算实例名称。实例需处于部署准备阶段或运行中状态。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：UpdateComputeInstanceName</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeInstanceNameResponse
        /// </returns>
        public UpdateComputeInstanceNameResponse UpdateComputeInstanceName(UpdateComputeInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateComputeInstanceNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例名称</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>修改计算实例名称。实例需处于部署准备阶段或运行中状态。</para>
        /// <list type="bullet">
        /// <item><description>API 版本：2026-02-02</description></item>
        /// <item><description>Action：UpdateComputeInstanceName</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeInstanceNameResponse
        /// </returns>
        public async Task<UpdateComputeInstanceNameResponse> UpdateComputeInstanceNameAsync(UpdateComputeInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateComputeInstanceNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>确保提供的 <c>InstanceId</c> 和 <c>JobName</c> 是有效的，否则将返回错误。</description></item>
        /// <item><description>如果实例状态不在运行中，则不允许执行此操作。</description></item>
        /// <item><description>当前作业状态如果为调试任务正在运行或变更中，则不支持修改。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobResponse
        /// </returns>
        public UpdateComputeJobResponse UpdateComputeJobWithOptions(UpdateComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>确保提供的 <c>InstanceId</c> 和 <c>JobName</c> 是有效的，否则将返回错误。</description></item>
        /// <item><description>如果实例状态不在运行中，则不允许执行此操作。</description></item>
        /// <item><description>当前作业状态如果为调试任务正在运行或变更中，则不支持修改。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobResponse
        /// </returns>
        public async Task<UpdateComputeJobResponse> UpdateComputeJobWithOptionsAsync(UpdateComputeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeJob",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>确保提供的 <c>InstanceId</c> 和 <c>JobName</c> 是有效的，否则将返回错误。</description></item>
        /// <item><description>如果实例状态不在运行中，则不允许执行此操作。</description></item>
        /// <item><description>当前作业状态如果为调试任务正在运行或变更中，则不支持修改。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobResponse
        /// </returns>
        public UpdateComputeJobResponse UpdateComputeJob(UpdateComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateComputeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>确保提供的 <c>InstanceId</c> 和 <c>JobName</c> 是有效的，否则将返回错误。</description></item>
        /// <item><description>如果实例状态不在运行中，则不允许执行此操作。</description></item>
        /// <item><description>当前作业状态如果为调试任务正在运行或变更中，则不支持修改。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobResponse
        /// </returns>
        public async Task<UpdateComputeJobResponse> UpdateComputeJobAsync(UpdateComputeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateComputeJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB 的 CU 配额</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API允许用户修改特定计算作业的计算单元（CU）上限和预留CU数量。在调用此接口前，请确保提供的<c>InstanceId</c>和<c>JobName</c>正确无误，并且实例处于运行状态。此外，注意检查<c>CuLimit</c>与<c>CuReserved</c>参数的有效性和合理性，避免因超出限制或不符合业务逻辑导致请求失败。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobCuRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobCuResponse
        /// </returns>
        public UpdateComputeJobCuResponse UpdateComputeJobCuWithOptions(UpdateComputeJobCuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuLimit))
            {
                query["CuLimit"] = request.CuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuReserved))
            {
                query["CuReserved"] = request.CuReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeJobCu",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeJobCuResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB 的 CU 配额</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API允许用户修改特定计算作业的计算单元（CU）上限和预留CU数量。在调用此接口前，请确保提供的<c>InstanceId</c>和<c>JobName</c>正确无误，并且实例处于运行状态。此外，注意检查<c>CuLimit</c>与<c>CuReserved</c>参数的有效性和合理性，避免因超出限制或不符合业务逻辑导致请求失败。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobCuRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobCuResponse
        /// </returns>
        public async Task<UpdateComputeJobCuResponse> UpdateComputeJobCuWithOptionsAsync(UpdateComputeJobCuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuLimit))
            {
                query["CuLimit"] = request.CuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuReserved))
            {
                query["CuReserved"] = request.CuReserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeJobCu",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeJobCuResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB 的 CU 配额</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API允许用户修改特定计算作业的计算单元（CU）上限和预留CU数量。在调用此接口前，请确保提供的<c>InstanceId</c>和<c>JobName</c>正确无误，并且实例处于运行状态。此外，注意检查<c>CuLimit</c>与<c>CuReserved</c>参数的有效性和合理性，避免因超出限制或不符合业务逻辑导致请求失败。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobCuRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobCuResponse
        /// </returns>
        public UpdateComputeJobCuResponse UpdateComputeJobCu(UpdateComputeJobCuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateComputeJobCuWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB 的 CU 配额</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API允许用户修改特定计算作业的计算单元（CU）上限和预留CU数量。在调用此接口前，请确保提供的<c>InstanceId</c>和<c>JobName</c>正确无误，并且实例处于运行状态。此外，注意检查<c>CuLimit</c>与<c>CuReserved</c>参数的有效性和合理性，避免因超出限制或不符合业务逻辑导致请求失败。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobCuRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobCuResponse
        /// </returns>
        public async Task<UpdateComputeJobCuResponse> UpdateComputeJobCuAsync(UpdateComputeJobCuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateComputeJobCuWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB 的 SQL</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口用于更新特定计算实例下的某个计算作业所保存的Flink SQL草稿内容。请确保提供的<c>InstanceId</c>和<c>JobName</c>准确无误，并且该作业当前状态支持进行SQL修改操作。</para>
        /// <list type="bullet">
        /// <item><description><b>注意事项</b>：<list type="bullet">
        /// <item><description>确保目标实例处于运行状态。</description></item>
        /// <item><description>当前作业状态需允许修改SQL，即作业不应处于调试或变更过程中。</description></item>
        /// <item><description><c>DraftSql</c>参数应包含完整的、格式正确的Flink SQL语句。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobDraftSqlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobDraftSqlResponse
        /// </returns>
        public UpdateComputeJobDraftSqlResponse UpdateComputeJobDraftSqlWithOptions(UpdateComputeJobDraftSqlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DraftSql))
            {
                query["DraftSql"] = request.DraftSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeJobDraftSql",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeJobDraftSqlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB 的 SQL</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口用于更新特定计算实例下的某个计算作业所保存的Flink SQL草稿内容。请确保提供的<c>InstanceId</c>和<c>JobName</c>准确无误，并且该作业当前状态支持进行SQL修改操作。</para>
        /// <list type="bullet">
        /// <item><description><b>注意事项</b>：<list type="bullet">
        /// <item><description>确保目标实例处于运行状态。</description></item>
        /// <item><description>当前作业状态需允许修改SQL，即作业不应处于调试或变更过程中。</description></item>
        /// <item><description><c>DraftSql</c>参数应包含完整的、格式正确的Flink SQL语句。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobDraftSqlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobDraftSqlResponse
        /// </returns>
        public async Task<UpdateComputeJobDraftSqlResponse> UpdateComputeJobDraftSqlWithOptionsAsync(UpdateComputeJobDraftSqlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DraftSql))
            {
                query["DraftSql"] = request.DraftSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeJobDraftSql",
                Version = "2026-02-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeJobDraftSqlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB 的 SQL</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口用于更新特定计算实例下的某个计算作业所保存的Flink SQL草稿内容。请确保提供的<c>InstanceId</c>和<c>JobName</c>准确无误，并且该作业当前状态支持进行SQL修改操作。</para>
        /// <list type="bullet">
        /// <item><description><b>注意事项</b>：<list type="bullet">
        /// <item><description>确保目标实例处于运行状态。</description></item>
        /// <item><description>当前作业状态需允许修改SQL，即作业不应处于调试或变更过程中。</description></item>
        /// <item><description><c>DraftSql</c>参数应包含完整的、格式正确的Flink SQL语句。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobDraftSqlRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobDraftSqlResponse
        /// </returns>
        public UpdateComputeJobDraftSqlResponse UpdateComputeJobDraftSql(UpdateComputeJobDraftSqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateComputeJobDraftSqlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 JOB 的 SQL</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口用于更新特定计算实例下的某个计算作业所保存的Flink SQL草稿内容。请确保提供的<c>InstanceId</c>和<c>JobName</c>准确无误，并且该作业当前状态支持进行SQL修改操作。</para>
        /// <list type="bullet">
        /// <item><description><b>注意事项</b>：<list type="bullet">
        /// <item><description>确保目标实例处于运行状态。</description></item>
        /// <item><description>当前作业状态需允许修改SQL，即作业不应处于调试或变更过程中。</description></item>
        /// <item><description><c>DraftSql</c>参数应包含完整的、格式正确的Flink SQL语句。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeJobDraftSqlRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeJobDraftSqlResponse
        /// </returns>
        public async Task<UpdateComputeJobDraftSqlResponse> UpdateComputeJobDraftSqlAsync(UpdateComputeJobDraftSqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateComputeJobDraftSqlWithOptionsAsync(request, runtime);
        }

    }
}
