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
            this._productId = "AlikafkaStreaming";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
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
        /// <para>Validates whether a specified Flink SQL statement complies with the specifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>You can invoke this operation by using the GET or POST method.</description></item>
        /// <item><description>You must specify the <c>InstanceId</c>, <c>JobName</c>, and <c>SqlContent</c> parameters. The <c>SqlContent</c> parameter specifies the Flink SQL statement to be validated.</description></item>
        /// <item><description>In the response, the <c>Data.Valid</c> field indicates whether the SQL statement passed the validation. If the validation fails, the fault details are returned in the <c>Data.ErrorList</c> field.</description></item>
        /// <item><description>The current version requires both the instance ID (<c>InstanceId</c>) and the job name (<c>JobName</c>) to build the job context.</description></item>
        /// <item><description>A successful response only indicates that the system starts to execute the validation flow. It does not directly indicate whether the SQL statement is valid. Check the <c>Data.Valid</c> field to determine whether the SQL statement is valid.</description></item>
        /// <item><description>For error codes and exception handling, refer to the Error codes section in the References.</description></item>
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
        /// <para>Validates whether a specified Flink SQL statement complies with the specifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>You can invoke this operation by using the GET or POST method.</description></item>
        /// <item><description>You must specify the <c>InstanceId</c>, <c>JobName</c>, and <c>SqlContent</c> parameters. The <c>SqlContent</c> parameter specifies the Flink SQL statement to be validated.</description></item>
        /// <item><description>In the response, the <c>Data.Valid</c> field indicates whether the SQL statement passed the validation. If the validation fails, the fault details are returned in the <c>Data.ErrorList</c> field.</description></item>
        /// <item><description>The current version requires both the instance ID (<c>InstanceId</c>) and the job name (<c>JobName</c>) to build the job context.</description></item>
        /// <item><description>A successful response only indicates that the system starts to execute the validation flow. It does not directly indicate whether the SQL statement is valid. Check the <c>Data.Valid</c> field to determine whether the SQL statement is valid.</description></item>
        /// <item><description>For error codes and exception handling, refer to the Error codes section in the References.</description></item>
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
        /// <para>Validates whether a specified Flink SQL statement complies with the specifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>You can invoke this operation by using the GET or POST method.</description></item>
        /// <item><description>You must specify the <c>InstanceId</c>, <c>JobName</c>, and <c>SqlContent</c> parameters. The <c>SqlContent</c> parameter specifies the Flink SQL statement to be validated.</description></item>
        /// <item><description>In the response, the <c>Data.Valid</c> field indicates whether the SQL statement passed the validation. If the validation fails, the fault details are returned in the <c>Data.ErrorList</c> field.</description></item>
        /// <item><description>The current version requires both the instance ID (<c>InstanceId</c>) and the job name (<c>JobName</c>) to build the job context.</description></item>
        /// <item><description>A successful response only indicates that the system starts to execute the validation flow. It does not directly indicate whether the SQL statement is valid. Check the <c>Data.Valid</c> field to determine whether the SQL statement is valid.</description></item>
        /// <item><description>For error codes and exception handling, refer to the Error codes section in the References.</description></item>
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
        /// <para>Validates whether a specified Flink SQL statement complies with the specifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>You can invoke this operation by using the GET or POST method.</description></item>
        /// <item><description>You must specify the <c>InstanceId</c>, <c>JobName</c>, and <c>SqlContent</c> parameters. The <c>SqlContent</c> parameter specifies the Flink SQL statement to be validated.</description></item>
        /// <item><description>In the response, the <c>Data.Valid</c> field indicates whether the SQL statement passed the validation. If the validation fails, the fault details are returned in the <c>Data.ErrorList</c> field.</description></item>
        /// <item><description>The current version requires both the instance ID (<c>InstanceId</c>) and the job name (<c>JobName</c>) to build the job context.</description></item>
        /// <item><description>A successful response only indicates that the system starts to execute the validation flow. It does not directly indicate whether the SQL statement is valid. Check the <c>Data.Valid</c> field to determine whether the SQL statement is valid.</description></item>
        /// <item><description>For error codes and exception handling, refer to the Error codes section in the References.</description></item>
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
        /// <para>Creates a compute instance. This operation only completes the purchase phase. After the instance is created, call StartComputeInstance to complete network configuration and deployment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a compute instance. This operation only completes the purchase phase. After the instance is created, call StartComputeInstance to complete network configuration and deployment.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: CreateComputeInstance</description></item>
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
        /// <para>Creates a compute instance. This operation only completes the purchase phase. After the instance is created, call StartComputeInstance to complete network configuration and deployment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a compute instance. This operation only completes the purchase phase. After the instance is created, call StartComputeInstance to complete network configuration and deployment.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: CreateComputeInstance</description></item>
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
        /// <para>Creates a compute instance. This operation only completes the purchase phase. After the instance is created, call StartComputeInstance to complete network configuration and deployment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a compute instance. This operation only completes the purchase phase. After the instance is created, call StartComputeInstance to complete network configuration and deployment.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: CreateComputeInstance</description></item>
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
        /// <para>Creates a compute instance. This operation only completes the purchase phase. After the instance is created, call StartComputeInstance to complete network configuration and deployment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a compute instance. This operation only completes the purchase phase. After the instance is created, call StartComputeInstance to complete network configuration and deployment.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: CreateComputeInstance</description></item>
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
        /// <para>Creates a Flink SQL job on a running compute instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This API creates a new Flink SQL job on a specified running compute instance.</description></item>
        /// <item><description>The created job is in the <c>INIT</c> state.</description></item>
        /// <item><description>You can control the resource usage of the job by setting <c>CuLimit</c> and <c>CuReserved</c>.</description></item>
        /// <item><description>The <c>Remark</c> field allows you to add remarks to the job for easier management and identification.</description></item>
        /// <item><description>Make sure that the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If you attempt to create a job with a duplicate name, an error is returned.</description></item>
        /// <item><description>The compute instance must be in the running state to successfully create a job.</description></item>
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
        /// <para>Creates a Flink SQL job on a running compute instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This API creates a new Flink SQL job on a specified running compute instance.</description></item>
        /// <item><description>The created job is in the <c>INIT</c> state.</description></item>
        /// <item><description>You can control the resource usage of the job by setting <c>CuLimit</c> and <c>CuReserved</c>.</description></item>
        /// <item><description>The <c>Remark</c> field allows you to add remarks to the job for easier management and identification.</description></item>
        /// <item><description>Make sure that the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If you attempt to create a job with a duplicate name, an error is returned.</description></item>
        /// <item><description>The compute instance must be in the running state to successfully create a job.</description></item>
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
        /// <para>Creates a Flink SQL job on a running compute instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This API creates a new Flink SQL job on a specified running compute instance.</description></item>
        /// <item><description>The created job is in the <c>INIT</c> state.</description></item>
        /// <item><description>You can control the resource usage of the job by setting <c>CuLimit</c> and <c>CuReserved</c>.</description></item>
        /// <item><description>The <c>Remark</c> field allows you to add remarks to the job for easier management and identification.</description></item>
        /// <item><description>Make sure that the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If you attempt to create a job with a duplicate name, an error is returned.</description></item>
        /// <item><description>The compute instance must be in the running state to successfully create a job.</description></item>
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
        /// <para>Creates a Flink SQL job on a running compute instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This API creates a new Flink SQL job on a specified running compute instance.</description></item>
        /// <item><description>The created job is in the <c>INIT</c> state.</description></item>
        /// <item><description>You can control the resource usage of the job by setting <c>CuLimit</c> and <c>CuReserved</c>.</description></item>
        /// <item><description>The <c>Remark</c> field allows you to add remarks to the job for easier management and identification.</description></item>
        /// <item><description>Make sure that the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If you attempt to create a job with a duplicate name, an error is returned.</description></item>
        /// <item><description>The compute instance must be in the running state to successfully create a job.</description></item>
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
        /// <para>Deletes a compute instance that is in the pending deployment, stopped, or released state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a compute instance that is in the pending deployment, stopped, or released state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: DeleteComputeInstance</description></item>
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
        /// <para>Deletes a compute instance that is in the pending deployment, stopped, or released state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a compute instance that is in the pending deployment, stopped, or released state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: DeleteComputeInstance</description></item>
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
        /// <para>Deletes a compute instance that is in the pending deployment, stopped, or released state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a compute instance that is in the pending deployment, stopped, or released state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: DeleteComputeInstance</description></item>
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
        /// <para>Deletes a compute instance that is in the pending deployment, stopped, or released state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a compute instance that is in the pending deployment, stopped, or released state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: DeleteComputeInstance</description></item>
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
        /// <para>Deletes a specified compute job. A successful request indicates that the deletion request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation deletes a specific compute job.</description></item>
        /// <item><description>A successful call to this operation only indicates that the deletion request has been accepted by the system. The deletion is not completed immediately.</description></item>
        /// <item><description>Make sure that the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If the compute instance or job is in a state that does not allow deletion, such as a non-running state, an error message is returned.</description></item>
        /// <item><description>The deletion operation is irreversible. Proceed with caution.</description></item>
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
        /// <para>Deletes a specified compute job. A successful request indicates that the deletion request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation deletes a specific compute job.</description></item>
        /// <item><description>A successful call to this operation only indicates that the deletion request has been accepted by the system. The deletion is not completed immediately.</description></item>
        /// <item><description>Make sure that the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If the compute instance or job is in a state that does not allow deletion, such as a non-running state, an error message is returned.</description></item>
        /// <item><description>The deletion operation is irreversible. Proceed with caution.</description></item>
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
        /// <para>Deletes a specified compute job. A successful request indicates that the deletion request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation deletes a specific compute job.</description></item>
        /// <item><description>A successful call to this operation only indicates that the deletion request has been accepted by the system. The deletion is not completed immediately.</description></item>
        /// <item><description>Make sure that the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If the compute instance or job is in a state that does not allow deletion, such as a non-running state, an error message is returned.</description></item>
        /// <item><description>The deletion operation is irreversible. Proceed with caution.</description></item>
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
        /// <para>Deletes a specified compute job. A successful request indicates that the deletion request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation deletes a specific compute job.</description></item>
        /// <item><description>A successful call to this operation only indicates that the deletion request has been accepted by the system. The deletion is not completed immediately.</description></item>
        /// <item><description>Make sure that the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If the compute instance or job is in a state that does not allow deletion, such as a non-running state, an error message is returned.</description></item>
        /// <item><description>The deletion operation is irreversible. Proceed with caution.</description></item>
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
        /// <para>Queries the details of a specified compute instance.</para>
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
        /// <para>Queries the details of a specified compute instance.</para>
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
        /// <para>Queries the details of a specified compute instance.</para>
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
        /// <para>Queries the details of a specified compute instance.</para>
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
        /// <para>Queries the details of a compute job in Alikafka Streaming by using a parameter query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the details of a specified compute job.</description></item>
        /// <item><description>You can use the GET or POST method to send requests.</description></item>
        /// <item><description>The <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are required.</description></item>
        /// <item><description>The authorization action is <c>alikafkastreaming:GetComputeJob</c>, and the access level is Read.</description></item>
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
        /// <para>Queries the details of a compute job in Alikafka Streaming by using a parameter query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the details of a specified compute job.</description></item>
        /// <item><description>You can use the GET or POST method to send requests.</description></item>
        /// <item><description>The <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are required.</description></item>
        /// <item><description>The authorization action is <c>alikafkastreaming:GetComputeJob</c>, and the access level is Read.</description></item>
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
        /// <para>Queries the details of a compute job in Alikafka Streaming by using a parameter query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the details of a specified compute job.</description></item>
        /// <item><description>You can use the GET or POST method to send requests.</description></item>
        /// <item><description>The <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are required.</description></item>
        /// <item><description>The authorization action is <c>alikafkastreaming:GetComputeJob</c>, and the access level is Read.</description></item>
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
        /// <para>Queries the details of a compute job in Alikafka Streaming by using a parameter query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the details of a specified compute job.</description></item>
        /// <item><description>You can use the GET or POST method to send requests.</description></item>
        /// <item><description>The <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are required.</description></item>
        /// <item><description>The authorization action is <c>alikafkastreaming:GetComputeJob</c>, and the access level is Read.</description></item>
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
        /// <para>Queries compute instances under the current account by using paging.</para>
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
        /// <para>Queries compute instances under the current account by using paging.</para>
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
        /// <para>Queries compute instances under the current account by using paging.</para>
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
        /// <para>Queries compute instances under the current account by using paging.</para>
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
        /// <para>Queries all job information under a specified compute instance by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports a cursor-based paged query by using the <c>MaxResults</c> and <c>NextToken</c> parameters.</description></item>
        /// <item><description>You do not need to specify <c>NextToken</c> in the first request. For subsequent requests, use the <c>NextToken</c> value returned in the previous response.</description></item>
        /// <item><description>You can search by job name or remark, and specify different sorting fields and directions.</description></item>
        /// <item><description>The authorization action is <c>alikafkastreaming:ListComputeJobs</c>. The access level is List, which applies to all resources.</description></item>
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
        /// <para>Queries all job information under a specified compute instance by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports a cursor-based paged query by using the <c>MaxResults</c> and <c>NextToken</c> parameters.</description></item>
        /// <item><description>You do not need to specify <c>NextToken</c> in the first request. For subsequent requests, use the <c>NextToken</c> value returned in the previous response.</description></item>
        /// <item><description>You can search by job name or remark, and specify different sorting fields and directions.</description></item>
        /// <item><description>The authorization action is <c>alikafkastreaming:ListComputeJobs</c>. The access level is List, which applies to all resources.</description></item>
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
        /// <para>Queries all job information under a specified compute instance by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports a cursor-based paged query by using the <c>MaxResults</c> and <c>NextToken</c> parameters.</description></item>
        /// <item><description>You do not need to specify <c>NextToken</c> in the first request. For subsequent requests, use the <c>NextToken</c> value returned in the previous response.</description></item>
        /// <item><description>You can search by job name or remark, and specify different sorting fields and directions.</description></item>
        /// <item><description>The authorization action is <c>alikafkastreaming:ListComputeJobs</c>. The access level is List, which applies to all resources.</description></item>
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
        /// <para>Queries all job information under a specified compute instance by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports a cursor-based paged query by using the <c>MaxResults</c> and <c>NextToken</c> parameters.</description></item>
        /// <item><description>You do not need to specify <c>NextToken</c> in the first request. For subsequent requests, use the <c>NextToken</c> value returned in the previous response.</description></item>
        /// <item><description>You can search by job name or remark, and specify different sorting fields and directions.</description></item>
        /// <item><description>The authorization action is <c>alikafkastreaming:ListComputeJobs</c>. The access level is List, which applies to all resources.</description></item>
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
        /// <para>Re-enables a stopped pay-as-you-go compute instance. A successful response indicates that the re-enablement request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Re-enables a stopped pay-as-you-go compute instance. A successful response indicates that the re-enablement request has been accepted.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: ReopenComputeInstance</description></item>
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
        /// <para>Re-enables a stopped pay-as-you-go compute instance. A successful response indicates that the re-enablement request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Re-enables a stopped pay-as-you-go compute instance. A successful response indicates that the re-enablement request has been accepted.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: ReopenComputeInstance</description></item>
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
        /// <para>Re-enables a stopped pay-as-you-go compute instance. A successful response indicates that the re-enablement request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Re-enables a stopped pay-as-you-go compute instance. A successful response indicates that the re-enablement request has been accepted.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: ReopenComputeInstance</description></item>
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
        /// <para>Re-enables a stopped pay-as-you-go compute instance. A successful response indicates that the re-enablement request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Re-enables a stopped pay-as-you-go compute instance. A successful response indicates that the re-enablement request has been accepted.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: ReopenComputeInstance</description></item>
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
        /// <para>Configures the network and deploys a compute instance in the pending deployment state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configures the network and deploys a compute instance in the pending deployment state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: StartComputeInstance</description></item>
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
        /// <para>Configures the network and deploys a compute instance in the pending deployment state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configures the network and deploys a compute instance in the pending deployment state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: StartComputeInstance</description></item>
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
        /// <para>Configures the network and deploys a compute instance in the pending deployment state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configures the network and deploys a compute instance in the pending deployment state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: StartComputeInstance</description></item>
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
        /// <para>Configures the network and deploys a compute instance in the pending deployment state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configures the network and deploys a compute instance in the pending deployment state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: StartComputeInstance</description></item>
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
        /// <para>Starts, resumes, or debugs a compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>RecoveryMode</c> supports two modes: <c>savepoint</c> and <c>stateless</c>. If you select the <c>savepoint</c> mode but no savepoint is available, an error is returned.</description></item>
        /// <item><description>The <c>CuLimit</c> and <c>CuReserved</c> parameters are used to set the CU limit and the number of reserved CUs for the job, respectively. Integers and decimals are supported.</description></item>
        /// <item><description>Make sure that the values of the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are correct and exist. Otherwise, the request fails.</description></item>
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
        /// <para>Starts, resumes, or debugs a compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>RecoveryMode</c> supports two modes: <c>savepoint</c> and <c>stateless</c>. If you select the <c>savepoint</c> mode but no savepoint is available, an error is returned.</description></item>
        /// <item><description>The <c>CuLimit</c> and <c>CuReserved</c> parameters are used to set the CU limit and the number of reserved CUs for the job, respectively. Integers and decimals are supported.</description></item>
        /// <item><description>Make sure that the values of the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are correct and exist. Otherwise, the request fails.</description></item>
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
        /// <para>Starts, resumes, or debugs a compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>RecoveryMode</c> supports two modes: <c>savepoint</c> and <c>stateless</c>. If you select the <c>savepoint</c> mode but no savepoint is available, an error is returned.</description></item>
        /// <item><description>The <c>CuLimit</c> and <c>CuReserved</c> parameters are used to set the CU limit and the number of reserved CUs for the job, respectively. Integers and decimals are supported.</description></item>
        /// <item><description>Make sure that the values of the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are correct and exist. Otherwise, the request fails.</description></item>
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
        /// <para>Starts, resumes, or debugs a compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>RecoveryMode</c> supports two modes: <c>savepoint</c> and <c>stateless</c>. If you select the <c>savepoint</c> mode but no savepoint is available, an error is returned.</description></item>
        /// <item><description>The <c>CuLimit</c> and <c>CuReserved</c> parameters are used to set the CU limit and the number of reserved CUs for the job, respectively. Integers and decimals are supported.</description></item>
        /// <item><description>Make sure that the values of the <c>RegionId</c>, <c>InstanceId</c>, and <c>JobName</c> parameters are correct and exist. Otherwise, the request fails.</description></item>
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
        /// <para>Stops a running pay-as-you-go compute instance. A successful response indicates that the stop request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops a running pay-as-you-go compute instance. A successful response indicates that the stop request has been accepted.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: StopComputeInstance</description></item>
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
        /// <para>Stops a running pay-as-you-go compute instance. A successful response indicates that the stop request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops a running pay-as-you-go compute instance. A successful response indicates that the stop request has been accepted.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: StopComputeInstance</description></item>
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
        /// <para>Stops a running pay-as-you-go compute instance. A successful response indicates that the stop request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops a running pay-as-you-go compute instance. A successful response indicates that the stop request has been accepted.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: StopComputeInstance</description></item>
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
        /// <para>Stops a running pay-as-you-go compute instance. A successful response indicates that the stop request has been accepted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops a running pay-as-you-go compute instance. A successful response indicates that the stop request has been accepted.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: StopComputeInstance</description></item>
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
        /// <para>Stops a computing job in a specified region and instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation stops the production or debug running instance of a specified computing job.</description></item>
        /// <item><description>A successful response indicates that the stop request has been accepted, but it does not mean that the job stops immediately.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopStrategy))
            {
                query["StopStrategy"] = request.StopStrategy;
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
        /// <para>Stops a computing job in a specified region and instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation stops the production or debug running instance of a specified computing job.</description></item>
        /// <item><description>A successful response indicates that the stop request has been accepted, but it does not mean that the job stops immediately.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopStrategy))
            {
                query["StopStrategy"] = request.StopStrategy;
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
        /// <para>Stops a computing job in a specified region and instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation stops the production or debug running instance of a specified computing job.</description></item>
        /// <item><description>A successful response indicates that the stop request has been accepted, but it does not mean that the job stops immediately.</description></item>
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
        /// <para>Stops a computing job in a specified region and instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation stops the production or debug running instance of a specified computing job.</description></item>
        /// <item><description>A successful response indicates that the stop request has been accepted, but it does not mean that the job stops immediately.</description></item>
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
        /// <para>Updates the name of a compute instance. The instance must be in the deployment preparation or running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the name of a compute instance. The instance must be in the deployment preparation or running state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: UpdateComputeInstanceName</description></item>
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
        /// <para>Updates the name of a compute instance. The instance must be in the deployment preparation or running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the name of a compute instance. The instance must be in the deployment preparation or running state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: UpdateComputeInstanceName</description></item>
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
        /// <para>Updates the name of a compute instance. The instance must be in the deployment preparation or running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the name of a compute instance. The instance must be in the deployment preparation or running state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: UpdateComputeInstanceName</description></item>
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
        /// <para>Updates the name of a compute instance. The instance must be in the deployment preparation or running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the name of a compute instance. The instance must be in the deployment preparation or running state.</para>
        /// <list type="bullet">
        /// <item><description>API version: 2026-02-02</description></item>
        /// <item><description>Action: UpdateComputeInstanceName</description></item>
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
        /// <para>Modifies the remarks of a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>Ensure that the provided <c>InstanceId</c> and <c>JobName</c> are valid. Otherwise, an error is returned.</description></item>
        /// <item><description>You cannot execute this operation if the instance is not in the running state.</description></item>
        /// <item><description>Modifications are not supported if the current job is running as a debug node or undergoing changes.</description></item>
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
        /// <para>Modifies the remarks of a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>Ensure that the provided <c>InstanceId</c> and <c>JobName</c> are valid. Otherwise, an error is returned.</description></item>
        /// <item><description>You cannot execute this operation if the instance is not in the running state.</description></item>
        /// <item><description>Modifications are not supported if the current job is running as a debug node or undergoing changes.</description></item>
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
        /// <para>Modifies the remarks of a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>Ensure that the provided <c>InstanceId</c> and <c>JobName</c> are valid. Otherwise, an error is returned.</description></item>
        /// <item><description>You cannot execute this operation if the instance is not in the running state.</description></item>
        /// <item><description>Modifications are not supported if the current job is running as a debug node or undergoing changes.</description></item>
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
        /// <para>Modifies the remarks of a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>Ensure that the provided <c>InstanceId</c> and <c>JobName</c> are valid. Otherwise, an error is returned.</description></item>
        /// <item><description>You cannot execute this operation if the instance is not in the running state.</description></item>
        /// <item><description>Modifications are not supported if the current job is running as a debug node or undergoing changes.</description></item>
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
        /// <para>Modifies the compute unit (CU) limit and the number of reserved CUs for a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation allows you to modify the compute unit (CU) limit and the number of reserved CUs for a specific compute job. Before calling this operation, ensure that the specified <c>InstanceId</c> and <c>JobName</c> are correct and that the instance is in the running state. Additionally, verify the validity and reasonableness of the <c>CuLimit</c> and <c>CuReserved</c> parameters to prevent request failures caused by exceeding limits or violating business logic.</para>
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
        /// <para>Modifies the compute unit (CU) limit and the number of reserved CUs for a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation allows you to modify the compute unit (CU) limit and the number of reserved CUs for a specific compute job. Before calling this operation, ensure that the specified <c>InstanceId</c> and <c>JobName</c> are correct and that the instance is in the running state. Additionally, verify the validity and reasonableness of the <c>CuLimit</c> and <c>CuReserved</c> parameters to prevent request failures caused by exceeding limits or violating business logic.</para>
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
        /// <para>Modifies the compute unit (CU) limit and the number of reserved CUs for a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation allows you to modify the compute unit (CU) limit and the number of reserved CUs for a specific compute job. Before calling this operation, ensure that the specified <c>InstanceId</c> and <c>JobName</c> are correct and that the instance is in the running state. Additionally, verify the validity and reasonableness of the <c>CuLimit</c> and <c>CuReserved</c> parameters to prevent request failures caused by exceeding limits or violating business logic.</para>
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
        /// <para>Modifies the compute unit (CU) limit and the number of reserved CUs for a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation allows you to modify the compute unit (CU) limit and the number of reserved CUs for a specific compute job. Before calling this operation, ensure that the specified <c>InstanceId</c> and <c>JobName</c> are correct and that the instance is in the running state. Additionally, verify the validity and reasonableness of the <c>CuLimit</c> and <c>CuReserved</c> parameters to prevent request failures caused by exceeding limits or violating business logic.</para>
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
        /// <para>Updates the Flink SQL draft saved for a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation updates the Flink SQL draft saved for a specific compute job under a given compute instance. Make sure that the provided <c>InstanceId</c> and <c>JobName</c> are accurate, and the current status of the job supports SQL modification.</para>
        /// <list type="bullet">
        /// <item><description><b>Precautions</b>:<list type="bullet">
        /// <item><description>Make sure that the target instance is in the running state.</description></item>
        /// <item><description>The current job status must allow SQL modification. The job must not be undergoing debugging or modification.</description></item>
        /// <item><description>The <c>DraftSql</c> parameter must contain a complete and correctly formatted Flink SQL statement.</description></item>
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
        /// <para>Updates the Flink SQL draft saved for a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation updates the Flink SQL draft saved for a specific compute job under a given compute instance. Make sure that the provided <c>InstanceId</c> and <c>JobName</c> are accurate, and the current status of the job supports SQL modification.</para>
        /// <list type="bullet">
        /// <item><description><b>Precautions</b>:<list type="bullet">
        /// <item><description>Make sure that the target instance is in the running state.</description></item>
        /// <item><description>The current job status must allow SQL modification. The job must not be undergoing debugging or modification.</description></item>
        /// <item><description>The <c>DraftSql</c> parameter must contain a complete and correctly formatted Flink SQL statement.</description></item>
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
        /// <para>Updates the Flink SQL draft saved for a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation updates the Flink SQL draft saved for a specific compute job under a given compute instance. Make sure that the provided <c>InstanceId</c> and <c>JobName</c> are accurate, and the current status of the job supports SQL modification.</para>
        /// <list type="bullet">
        /// <item><description><b>Precautions</b>:<list type="bullet">
        /// <item><description>Make sure that the target instance is in the running state.</description></item>
        /// <item><description>The current job status must allow SQL modification. The job must not be undergoing debugging or modification.</description></item>
        /// <item><description>The <c>DraftSql</c> parameter must contain a complete and correctly formatted Flink SQL statement.</description></item>
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
        /// <para>Updates the Flink SQL draft saved for a specified compute job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation updates the Flink SQL draft saved for a specific compute job under a given compute instance. Make sure that the provided <c>InstanceId</c> and <c>JobName</c> are accurate, and the current status of the job supports SQL modification.</para>
        /// <list type="bullet">
        /// <item><description><b>Precautions</b>:<list type="bullet">
        /// <item><description>Make sure that the target instance is in the running state.</description></item>
        /// <item><description>The current job status must allow SQL modification. The job must not be undergoing debugging or modification.</description></item>
        /// <item><description>The <c>DraftSql</c> parameter must contain a complete and correctly formatted Flink SQL statement.</description></item>
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
