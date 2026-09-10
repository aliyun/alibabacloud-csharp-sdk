// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.LHM20250116.Models;

namespace AlibabaCloud.SDK.LHM20250116
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("lhm", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates or updates the table-level configuration of a data validation task to specify the tables to validate, the validation scope, and the comparison rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Saves the table-level configuration for a specified data validation task. Use this operation to specify the source and target tables for comparison, the comparison scope (columns, partitions, filter conditions, and grouping), and the data volume comparison threshold.
        /// This operation handles both creating new configurations and updating existing ones. After a validation task is created, you must call this operation to write the table-level configuration before the task has any objects to compare and before validation can be triggered.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required. It specifies the ID of the validation task to which the configuration belongs. Obtain this value from the response of the operation that creates a data validation task.</description></item>
        /// <item><description>The source and target table names, columns, partitions, WHERE conditions, GROUP conditions, and hints are provided in pairs to map a source table to a target table and define the rows and columns to compare. You can specify multiple columns separated by commas (,).</description></item>
        /// <item><description><c>isFullTableCount</c> determines the comparison granularity: <c>0</c> indicates partition-level comparison, and <c>1</c> indicates full-table comparison.</description></item>
        /// <item><description><c>totalCountThreshold</c> specifies the total data volume comparison threshold, which determines whether the data volume difference between the source and target is within an acceptable range.</description></item>
        /// <item><description>When the task creation mode is batch creation in the same pattern (<c>taskMode=1</c>), you can submit multiple table configurations at a time by using <c>taskConfigInfo</c>. Separate multiple configurations with a line break (<c>\\n</c>).</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> contains the configuration ID saved in this operation. You can use this ID to query or delete the table-level configuration later.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. Use <c>requestId</c> to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckConfigResponse
        /// </returns>
        public AddDataCheckConfigResponse AddDataCheckConfigWithOptions(AddDataCheckConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFullTableCount))
            {
                body["isFullTableCount"] = request.IsFullTableCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceColumns))
            {
                body["sourceColumns"] = request.SourceColumns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceGroupClause))
            {
                body["sourceGroupClause"] = request.SourceGroupClause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHint))
            {
                body["sourceHint"] = request.SourceHint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePartition))
            {
                body["sourcePartition"] = request.SourcePartition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTable))
            {
                body["sourceTable"] = request.SourceTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceWhereClause))
            {
                body["sourceWhereClause"] = request.SourceWhereClause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetColumns))
            {
                body["targetColumns"] = request.TargetColumns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetGroupClause))
            {
                body["targetGroupClause"] = request.TargetGroupClause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHint))
            {
                body["targetHint"] = request.TargetHint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPartition))
            {
                body["targetPartition"] = request.TargetPartition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTable))
            {
                body["targetTable"] = request.TargetTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWhereClause))
            {
                body["targetWhereClause"] = request.TargetWhereClause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskConfigInfo))
            {
                body["taskConfigInfo"] = request.TaskConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalCountThreshold))
            {
                body["totalCountThreshold"] = request.TotalCountThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataCheckConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/saveConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataCheckConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates the table-level configuration of a data validation task to specify the tables to validate, the validation scope, and the comparison rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Saves the table-level configuration for a specified data validation task. Use this operation to specify the source and target tables for comparison, the comparison scope (columns, partitions, filter conditions, and grouping), and the data volume comparison threshold.
        /// This operation handles both creating new configurations and updating existing ones. After a validation task is created, you must call this operation to write the table-level configuration before the task has any objects to compare and before validation can be triggered.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required. It specifies the ID of the validation task to which the configuration belongs. Obtain this value from the response of the operation that creates a data validation task.</description></item>
        /// <item><description>The source and target table names, columns, partitions, WHERE conditions, GROUP conditions, and hints are provided in pairs to map a source table to a target table and define the rows and columns to compare. You can specify multiple columns separated by commas (,).</description></item>
        /// <item><description><c>isFullTableCount</c> determines the comparison granularity: <c>0</c> indicates partition-level comparison, and <c>1</c> indicates full-table comparison.</description></item>
        /// <item><description><c>totalCountThreshold</c> specifies the total data volume comparison threshold, which determines whether the data volume difference between the source and target is within an acceptable range.</description></item>
        /// <item><description>When the task creation mode is batch creation in the same pattern (<c>taskMode=1</c>), you can submit multiple table configurations at a time by using <c>taskConfigInfo</c>. Separate multiple configurations with a line break (<c>\\n</c>).</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> contains the configuration ID saved in this operation. You can use this ID to query or delete the table-level configuration later.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. Use <c>requestId</c> to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckConfigResponse
        /// </returns>
        public async Task<AddDataCheckConfigResponse> AddDataCheckConfigWithOptionsAsync(AddDataCheckConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFullTableCount))
            {
                body["isFullTableCount"] = request.IsFullTableCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceColumns))
            {
                body["sourceColumns"] = request.SourceColumns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceGroupClause))
            {
                body["sourceGroupClause"] = request.SourceGroupClause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHint))
            {
                body["sourceHint"] = request.SourceHint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePartition))
            {
                body["sourcePartition"] = request.SourcePartition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTable))
            {
                body["sourceTable"] = request.SourceTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceWhereClause))
            {
                body["sourceWhereClause"] = request.SourceWhereClause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetColumns))
            {
                body["targetColumns"] = request.TargetColumns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetGroupClause))
            {
                body["targetGroupClause"] = request.TargetGroupClause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHint))
            {
                body["targetHint"] = request.TargetHint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPartition))
            {
                body["targetPartition"] = request.TargetPartition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTable))
            {
                body["targetTable"] = request.TargetTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWhereClause))
            {
                body["targetWhereClause"] = request.TargetWhereClause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskConfigInfo))
            {
                body["taskConfigInfo"] = request.TaskConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalCountThreshold))
            {
                body["totalCountThreshold"] = request.TotalCountThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataCheckConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/saveConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataCheckConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates the table-level configuration of a data validation task to specify the tables to validate, the validation scope, and the comparison rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Saves the table-level configuration for a specified data validation task. Use this operation to specify the source and target tables for comparison, the comparison scope (columns, partitions, filter conditions, and grouping), and the data volume comparison threshold.
        /// This operation handles both creating new configurations and updating existing ones. After a validation task is created, you must call this operation to write the table-level configuration before the task has any objects to compare and before validation can be triggered.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required. It specifies the ID of the validation task to which the configuration belongs. Obtain this value from the response of the operation that creates a data validation task.</description></item>
        /// <item><description>The source and target table names, columns, partitions, WHERE conditions, GROUP conditions, and hints are provided in pairs to map a source table to a target table and define the rows and columns to compare. You can specify multiple columns separated by commas (,).</description></item>
        /// <item><description><c>isFullTableCount</c> determines the comparison granularity: <c>0</c> indicates partition-level comparison, and <c>1</c> indicates full-table comparison.</description></item>
        /// <item><description><c>totalCountThreshold</c> specifies the total data volume comparison threshold, which determines whether the data volume difference between the source and target is within an acceptable range.</description></item>
        /// <item><description>When the task creation mode is batch creation in the same pattern (<c>taskMode=1</c>), you can submit multiple table configurations at a time by using <c>taskConfigInfo</c>. Separate multiple configurations with a line break (<c>\\n</c>).</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> contains the configuration ID saved in this operation. You can use this ID to query or delete the table-level configuration later.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. Use <c>requestId</c> to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckConfigResponse
        /// </returns>
        public AddDataCheckConfigResponse AddDataCheckConfig(AddDataCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddDataCheckConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates the table-level configuration of a data validation task to specify the tables to validate, the validation scope, and the comparison rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Saves the table-level configuration for a specified data validation task. Use this operation to specify the source and target tables for comparison, the comparison scope (columns, partitions, filter conditions, and grouping), and the data volume comparison threshold.
        /// This operation handles both creating new configurations and updating existing ones. After a validation task is created, you must call this operation to write the table-level configuration before the task has any objects to compare and before validation can be triggered.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required. It specifies the ID of the validation task to which the configuration belongs. Obtain this value from the response of the operation that creates a data validation task.</description></item>
        /// <item><description>The source and target table names, columns, partitions, WHERE conditions, GROUP conditions, and hints are provided in pairs to map a source table to a target table and define the rows and columns to compare. You can specify multiple columns separated by commas (,).</description></item>
        /// <item><description><c>isFullTableCount</c> determines the comparison granularity: <c>0</c> indicates partition-level comparison, and <c>1</c> indicates full-table comparison.</description></item>
        /// <item><description><c>totalCountThreshold</c> specifies the total data volume comparison threshold, which determines whether the data volume difference between the source and target is within an acceptable range.</description></item>
        /// <item><description>When the task creation mode is batch creation in the same pattern (<c>taskMode=1</c>), you can submit multiple table configurations at a time by using <c>taskConfigInfo</c>. Separate multiple configurations with a line break (<c>\\n</c>).</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> contains the configuration ID saved in this operation. You can use this ID to query or delete the table-level configuration later.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. Use <c>requestId</c> to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckConfigResponse
        /// </returns>
        public async Task<AddDataCheckConfigResponse> AddDataCheckConfigAsync(AddDataCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddDataCheckConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data validation task with specified source and destination data sources, validation type, and scheduling mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a data validation task that establishes a data consistency verification scheduling unit between a source data source and a destination data source.
        /// The task itself only describes which two data sources to verify and which verification method to use. The specific tables to verify are determined by the table detail configuration. Therefore, after creating a task, you must save the table detail configuration for the task and then trigger the verification to execute.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskName</c>, <c>checkType</c>, <c>taskMode</c>, and the data source IDs and types for both the source and destination are required. The task name supports only Chinese characters, English characters, and digits.</description></item>
        /// <item><description><c>checkType</c> specifies the validation method: <c>0</c>: data volume comparison. <c>1</c>: metric comparison. <c>2</c>: weak content comparison.</description></item>
        /// <item><description><c>taskMode</c> specifies how the table detail configuration is created: <c>0</c>: table-by-table fine-grained creation. <c>1</c>: batch creation with the same schema. When batch creation is selected, you can submit multiple table configurations at a time when saving the table detail configuration.</description></item>
        /// <item><description><c>srcDsId</c>/<c>srcDsType</c> and <c>dstDsId</c>/<c>dstDsType</c> specify the source and destination data sources respectively. The values are the IDs and types of existing data sources. <c>srcDsName</c>/<c>dstDsName</c> are the corresponding data source names.</description></item>
        /// <item><description><c>checkTemplateId</c> references an existing validation template. If not specified, the built-in default template is used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is create task ID of the newly created task. Use this ID for subsequent operations such as configuring table details, executing validations, querying create task list, or deleting create task.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckTaskResponse
        /// </returns>
        public AddDataCheckTaskResponse AddDataCheckTaskWithOptions(AddDataCheckTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckTemplateId))
            {
                body["checkTemplateId"] = request.CheckTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                body["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsId))
            {
                body["dstDsId"] = request.DstDsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsName))
            {
                body["dstDsName"] = request.DstDsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsType))
            {
                body["dstDsType"] = request.DstDsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsId))
            {
                body["srcDsId"] = request.SrcDsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsName))
            {
                body["srcDsName"] = request.SrcDsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsType))
            {
                body["srcDsType"] = request.SrcDsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMode))
            {
                body["taskMode"] = request.TaskMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataCheckTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data validation task with specified source and destination data sources, validation type, and scheduling mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a data validation task that establishes a data consistency verification scheduling unit between a source data source and a destination data source.
        /// The task itself only describes which two data sources to verify and which verification method to use. The specific tables to verify are determined by the table detail configuration. Therefore, after creating a task, you must save the table detail configuration for the task and then trigger the verification to execute.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskName</c>, <c>checkType</c>, <c>taskMode</c>, and the data source IDs and types for both the source and destination are required. The task name supports only Chinese characters, English characters, and digits.</description></item>
        /// <item><description><c>checkType</c> specifies the validation method: <c>0</c>: data volume comparison. <c>1</c>: metric comparison. <c>2</c>: weak content comparison.</description></item>
        /// <item><description><c>taskMode</c> specifies how the table detail configuration is created: <c>0</c>: table-by-table fine-grained creation. <c>1</c>: batch creation with the same schema. When batch creation is selected, you can submit multiple table configurations at a time when saving the table detail configuration.</description></item>
        /// <item><description><c>srcDsId</c>/<c>srcDsType</c> and <c>dstDsId</c>/<c>dstDsType</c> specify the source and destination data sources respectively. The values are the IDs and types of existing data sources. <c>srcDsName</c>/<c>dstDsName</c> are the corresponding data source names.</description></item>
        /// <item><description><c>checkTemplateId</c> references an existing validation template. If not specified, the built-in default template is used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is create task ID of the newly created task. Use this ID for subsequent operations such as configuring table details, executing validations, querying create task list, or deleting create task.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckTaskResponse
        /// </returns>
        public async Task<AddDataCheckTaskResponse> AddDataCheckTaskWithOptionsAsync(AddDataCheckTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckTemplateId))
            {
                body["checkTemplateId"] = request.CheckTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                body["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsId))
            {
                body["dstDsId"] = request.DstDsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsName))
            {
                body["dstDsName"] = request.DstDsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsType))
            {
                body["dstDsType"] = request.DstDsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsId))
            {
                body["srcDsId"] = request.SrcDsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsName))
            {
                body["srcDsName"] = request.SrcDsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsType))
            {
                body["srcDsType"] = request.SrcDsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMode))
            {
                body["taskMode"] = request.TaskMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataCheckTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data validation task with specified source and destination data sources, validation type, and scheduling mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a data validation task that establishes a data consistency verification scheduling unit between a source data source and a destination data source.
        /// The task itself only describes which two data sources to verify and which verification method to use. The specific tables to verify are determined by the table detail configuration. Therefore, after creating a task, you must save the table detail configuration for the task and then trigger the verification to execute.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskName</c>, <c>checkType</c>, <c>taskMode</c>, and the data source IDs and types for both the source and destination are required. The task name supports only Chinese characters, English characters, and digits.</description></item>
        /// <item><description><c>checkType</c> specifies the validation method: <c>0</c>: data volume comparison. <c>1</c>: metric comparison. <c>2</c>: weak content comparison.</description></item>
        /// <item><description><c>taskMode</c> specifies how the table detail configuration is created: <c>0</c>: table-by-table fine-grained creation. <c>1</c>: batch creation with the same schema. When batch creation is selected, you can submit multiple table configurations at a time when saving the table detail configuration.</description></item>
        /// <item><description><c>srcDsId</c>/<c>srcDsType</c> and <c>dstDsId</c>/<c>dstDsType</c> specify the source and destination data sources respectively. The values are the IDs and types of existing data sources. <c>srcDsName</c>/<c>dstDsName</c> are the corresponding data source names.</description></item>
        /// <item><description><c>checkTemplateId</c> references an existing validation template. If not specified, the built-in default template is used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is create task ID of the newly created task. Use this ID for subsequent operations such as configuring table details, executing validations, querying create task list, or deleting create task.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckTaskResponse
        /// </returns>
        public AddDataCheckTaskResponse AddDataCheckTask(AddDataCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddDataCheckTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data validation task with specified source and destination data sources, validation type, and scheduling mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a data validation task that establishes a data consistency verification scheduling unit between a source data source and a destination data source.
        /// The task itself only describes which two data sources to verify and which verification method to use. The specific tables to verify are determined by the table detail configuration. Therefore, after creating a task, you must save the table detail configuration for the task and then trigger the verification to execute.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskName</c>, <c>checkType</c>, <c>taskMode</c>, and the data source IDs and types for both the source and destination are required. The task name supports only Chinese characters, English characters, and digits.</description></item>
        /// <item><description><c>checkType</c> specifies the validation method: <c>0</c>: data volume comparison. <c>1</c>: metric comparison. <c>2</c>: weak content comparison.</description></item>
        /// <item><description><c>taskMode</c> specifies how the table detail configuration is created: <c>0</c>: table-by-table fine-grained creation. <c>1</c>: batch creation with the same schema. When batch creation is selected, you can submit multiple table configurations at a time when saving the table detail configuration.</description></item>
        /// <item><description><c>srcDsId</c>/<c>srcDsType</c> and <c>dstDsId</c>/<c>dstDsType</c> specify the source and destination data sources respectively. The values are the IDs and types of existing data sources. <c>srcDsName</c>/<c>dstDsName</c> are the corresponding data source names.</description></item>
        /// <item><description><c>checkTemplateId</c> references an existing validation template. If not specified, the built-in default template is used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is create task ID of the newly created task. Use this ID for subsequent operations such as configuring table details, executing validations, querying create task list, or deleting create task.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckTaskResponse
        /// </returns>
        public async Task<AddDataCheckTaskResponse> AddDataCheckTaskAsync(AddDataCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddDataCheckTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data validation template that defines reusable comparison rules, which can be referenced by data validation nodes through the template ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a reusable data validation template. This operation allows you to define a set of comparison rules, including metric calculation methods, difference tolerance rates, sampling policies, and null value and precision handling policies. Validation nodes can reference the template by template ID, which eliminates the need to repeatedly configure rules for each node.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>templateName</c> specifies the template name, and <c>templateDesc</c> specifies the template description.</description></item>
        /// <item><description><c>checkType</c> specifies the comparison type that the template applies to. Valid values: <c>0</c> (data volume comparison), <c>1</c> (metric comparison), <c>2</c> (weak content comparison), <c>3</c> (custom comparison), <c>4</c> (full-text comparison), and <c>5</c> (null rate comparison). Different values correspond to different rule fields. Specify only the rule fields that match the selected type.</description></item>
        /// <item><description>For metric comparison (<c>checkType=1</c>), use <c>basicMetricRules</c> and <c>metricRules</c> to describe the metric calculation methods (such as SUM, AVG, MIN, and MAX) and difference tolerance rates for each data type. If <c>diffTolerateType</c> is set to <c>0</c> (unified), specify only one value for <c>diffTolerateValues</c>. If <c>diffTolerateType</c> is set to <c>1</c> (custom), specify a value for each metric.</description></item>
        /// <item><description>For weak content comparison (<c>checkType=2</c>), use <c>weakContentRule</c> to specify the weak content algorithm (such as <c>md5</c> or <c>crc32</c>), the field type filter conditions, and the field name expressions for the fields that participate in the verification.</description></item>
        /// <item><description>For null rate comparison (<c>checkType=5</c>), use <c>nullRules</c> to configure null values grouped by data type.</description></item>
        /// <item><description>Row-by-row and column-by-column comparison strategies are controlled by fields with the <c>column</c> prefix, including whether to enable sampling, the sampling method (by row or by percentage) and values, the size comparison type, whether to enable cosine similarity, and whether to ignore differences between null values and 0 values.</description></item>
        /// <item><description><c>dsEngineRels</c> declares the data source engines associated with the template, including the data source engine configuration ID, the data source type, and the list of verification engine types covered.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the template ID (UUID character string) of the template you create. Reference this ID by using <c>checkTemplateId</c> when you create a validation node.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failed request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckTemplateResponse
        /// </returns>
        public AddDataCheckTemplateResponse AddDataCheckTemplateWithOptions(AddDataCheckTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicMetricRules))
            {
                body["basicMetricRules"] = request.BasicMetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                body["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplexMetricRules))
            {
                body["complexMetricRules"] = request.ComplexMetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsEngineRels))
            {
                body["dsEngineRels"] = request.DsEngineRels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FulltextRule))
            {
                body["fulltextRule"] = request.FulltextRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricRules))
            {
                body["metricRules"] = request.MetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NullRules))
            {
                body["nullRules"] = request.NullRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDesc))
            {
                body["templateDesc"] = request.TemplateDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WeakContentRule))
            {
                body["weakContentRule"] = request.WeakContentRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataCheckTemplate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataCheckTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data validation template that defines reusable comparison rules, which can be referenced by data validation nodes through the template ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a reusable data validation template. This operation allows you to define a set of comparison rules, including metric calculation methods, difference tolerance rates, sampling policies, and null value and precision handling policies. Validation nodes can reference the template by template ID, which eliminates the need to repeatedly configure rules for each node.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>templateName</c> specifies the template name, and <c>templateDesc</c> specifies the template description.</description></item>
        /// <item><description><c>checkType</c> specifies the comparison type that the template applies to. Valid values: <c>0</c> (data volume comparison), <c>1</c> (metric comparison), <c>2</c> (weak content comparison), <c>3</c> (custom comparison), <c>4</c> (full-text comparison), and <c>5</c> (null rate comparison). Different values correspond to different rule fields. Specify only the rule fields that match the selected type.</description></item>
        /// <item><description>For metric comparison (<c>checkType=1</c>), use <c>basicMetricRules</c> and <c>metricRules</c> to describe the metric calculation methods (such as SUM, AVG, MIN, and MAX) and difference tolerance rates for each data type. If <c>diffTolerateType</c> is set to <c>0</c> (unified), specify only one value for <c>diffTolerateValues</c>. If <c>diffTolerateType</c> is set to <c>1</c> (custom), specify a value for each metric.</description></item>
        /// <item><description>For weak content comparison (<c>checkType=2</c>), use <c>weakContentRule</c> to specify the weak content algorithm (such as <c>md5</c> or <c>crc32</c>), the field type filter conditions, and the field name expressions for the fields that participate in the verification.</description></item>
        /// <item><description>For null rate comparison (<c>checkType=5</c>), use <c>nullRules</c> to configure null values grouped by data type.</description></item>
        /// <item><description>Row-by-row and column-by-column comparison strategies are controlled by fields with the <c>column</c> prefix, including whether to enable sampling, the sampling method (by row or by percentage) and values, the size comparison type, whether to enable cosine similarity, and whether to ignore differences between null values and 0 values.</description></item>
        /// <item><description><c>dsEngineRels</c> declares the data source engines associated with the template, including the data source engine configuration ID, the data source type, and the list of verification engine types covered.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the template ID (UUID character string) of the template you create. Reference this ID by using <c>checkTemplateId</c> when you create a validation node.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failed request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckTemplateResponse
        /// </returns>
        public async Task<AddDataCheckTemplateResponse> AddDataCheckTemplateWithOptionsAsync(AddDataCheckTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicMetricRules))
            {
                body["basicMetricRules"] = request.BasicMetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                body["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplexMetricRules))
            {
                body["complexMetricRules"] = request.ComplexMetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsEngineRels))
            {
                body["dsEngineRels"] = request.DsEngineRels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FulltextRule))
            {
                body["fulltextRule"] = request.FulltextRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricRules))
            {
                body["metricRules"] = request.MetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NullRules))
            {
                body["nullRules"] = request.NullRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDesc))
            {
                body["templateDesc"] = request.TemplateDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WeakContentRule))
            {
                body["weakContentRule"] = request.WeakContentRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataCheckTemplate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataCheckTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data validation template that defines reusable comparison rules, which can be referenced by data validation nodes through the template ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a reusable data validation template. This operation allows you to define a set of comparison rules, including metric calculation methods, difference tolerance rates, sampling policies, and null value and precision handling policies. Validation nodes can reference the template by template ID, which eliminates the need to repeatedly configure rules for each node.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>templateName</c> specifies the template name, and <c>templateDesc</c> specifies the template description.</description></item>
        /// <item><description><c>checkType</c> specifies the comparison type that the template applies to. Valid values: <c>0</c> (data volume comparison), <c>1</c> (metric comparison), <c>2</c> (weak content comparison), <c>3</c> (custom comparison), <c>4</c> (full-text comparison), and <c>5</c> (null rate comparison). Different values correspond to different rule fields. Specify only the rule fields that match the selected type.</description></item>
        /// <item><description>For metric comparison (<c>checkType=1</c>), use <c>basicMetricRules</c> and <c>metricRules</c> to describe the metric calculation methods (such as SUM, AVG, MIN, and MAX) and difference tolerance rates for each data type. If <c>diffTolerateType</c> is set to <c>0</c> (unified), specify only one value for <c>diffTolerateValues</c>. If <c>diffTolerateType</c> is set to <c>1</c> (custom), specify a value for each metric.</description></item>
        /// <item><description>For weak content comparison (<c>checkType=2</c>), use <c>weakContentRule</c> to specify the weak content algorithm (such as <c>md5</c> or <c>crc32</c>), the field type filter conditions, and the field name expressions for the fields that participate in the verification.</description></item>
        /// <item><description>For null rate comparison (<c>checkType=5</c>), use <c>nullRules</c> to configure null values grouped by data type.</description></item>
        /// <item><description>Row-by-row and column-by-column comparison strategies are controlled by fields with the <c>column</c> prefix, including whether to enable sampling, the sampling method (by row or by percentage) and values, the size comparison type, whether to enable cosine similarity, and whether to ignore differences between null values and 0 values.</description></item>
        /// <item><description><c>dsEngineRels</c> declares the data source engines associated with the template, including the data source engine configuration ID, the data source type, and the list of verification engine types covered.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the template ID (UUID character string) of the template you create. Reference this ID by using <c>checkTemplateId</c> when you create a validation node.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failed request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckTemplateResponse
        /// </returns>
        public AddDataCheckTemplateResponse AddDataCheckTemplate(AddDataCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddDataCheckTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data validation template that defines reusable comparison rules, which can be referenced by data validation nodes through the template ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a reusable data validation template. This operation allows you to define a set of comparison rules, including metric calculation methods, difference tolerance rates, sampling policies, and null value and precision handling policies. Validation nodes can reference the template by template ID, which eliminates the need to repeatedly configure rules for each node.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>templateName</c> specifies the template name, and <c>templateDesc</c> specifies the template description.</description></item>
        /// <item><description><c>checkType</c> specifies the comparison type that the template applies to. Valid values: <c>0</c> (data volume comparison), <c>1</c> (metric comparison), <c>2</c> (weak content comparison), <c>3</c> (custom comparison), <c>4</c> (full-text comparison), and <c>5</c> (null rate comparison). Different values correspond to different rule fields. Specify only the rule fields that match the selected type.</description></item>
        /// <item><description>For metric comparison (<c>checkType=1</c>), use <c>basicMetricRules</c> and <c>metricRules</c> to describe the metric calculation methods (such as SUM, AVG, MIN, and MAX) and difference tolerance rates for each data type. If <c>diffTolerateType</c> is set to <c>0</c> (unified), specify only one value for <c>diffTolerateValues</c>. If <c>diffTolerateType</c> is set to <c>1</c> (custom), specify a value for each metric.</description></item>
        /// <item><description>For weak content comparison (<c>checkType=2</c>), use <c>weakContentRule</c> to specify the weak content algorithm (such as <c>md5</c> or <c>crc32</c>), the field type filter conditions, and the field name expressions for the fields that participate in the verification.</description></item>
        /// <item><description>For null rate comparison (<c>checkType=5</c>), use <c>nullRules</c> to configure null values grouped by data type.</description></item>
        /// <item><description>Row-by-row and column-by-column comparison strategies are controlled by fields with the <c>column</c> prefix, including whether to enable sampling, the sampling method (by row or by percentage) and values, the size comparison type, whether to enable cosine similarity, and whether to ignore differences between null values and 0 values.</description></item>
        /// <item><description><c>dsEngineRels</c> declares the data source engines associated with the template, including the data source engine configuration ID, the data source type, and the list of verification engine types covered.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the template ID (UUID character string) of the template you create. Reference this ID by using <c>checkTemplateId</c> when you create a validation node.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failed request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDataCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataCheckTemplateResponse
        /// </returns>
        public async Task<AddDataCheckTemplateResponse> AddDataCheckTemplateAsync(AddDataCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddDataCheckTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a metadata data source and completes connectivity configuration. This is a prerequisite step for starting metadata discovery tasks. The create action does not require authentication, but the duplicate name check within it is authenticated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a metadata data source and registers its type, version, and connection configuration. A data source serves as the foundational input for capabilities such as metadata discovery, workflow migration, and data validation. Related tasks reference the data source created here by data source ID or name.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dsName</c> specifies the data source name, which must be unique within the same tenant. If the name already exists, the operation returns a data source already exists error.</description></item>
        /// <item><description><c>dsType</c> and <c>dsVersion</c> specify the data source type and version, such as <c>Hive</c> and <c>3.2.0</c>.</description></item>
        /// <item><description><c>dsConfig</c> specifies the data source connection configuration, submitted as a JSON string. The content varies by data source type and typically includes the access address and access credentials. Credential fields are masked when returned in query responses.</description></item>
        /// <item><description><c>componentType</c> identifies the role of the data source in the migration pipeline: <c>0</c> for source, <c>1</c> for destination.</description></item>
        /// <item><description><c>categoryType</c> specifies the data source category. Valid values: <c>DATASET</c>, <c>WORKFLOW</c>, <c>ENGINE</c>.</description></item>
        /// <item><description><c>dsId</c> specifies the external ID of the data source. <c>dsStatus</c> specifies the connectivity status. <c>dsDesc</c> specifies the data source description.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the ID (long integer) of the newly created data source. Subsequent operations reference this data source by this ID or the data source name.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddMetaDataComponentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMetaDataComponentResponse
        /// </returns>
        public AddMetaDataComponentResponse AddMetaDataComponentWithOptions(AddMetaDataComponentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["categoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                body["componentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsConfig))
            {
                body["dsConfig"] = request.DsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsDesc))
            {
                body["dsDesc"] = request.DsDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsId))
            {
                body["dsId"] = request.DsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsName))
            {
                body["dsName"] = request.DsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsStatus))
            {
                body["dsStatus"] = request.DsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsType))
            {
                body["dsType"] = request.DsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsVersion))
            {
                body["dsVersion"] = request.DsVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMetaDataComponent",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMetaDataComponentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a metadata data source and completes connectivity configuration. This is a prerequisite step for starting metadata discovery tasks. The create action does not require authentication, but the duplicate name check within it is authenticated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a metadata data source and registers its type, version, and connection configuration. A data source serves as the foundational input for capabilities such as metadata discovery, workflow migration, and data validation. Related tasks reference the data source created here by data source ID or name.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dsName</c> specifies the data source name, which must be unique within the same tenant. If the name already exists, the operation returns a data source already exists error.</description></item>
        /// <item><description><c>dsType</c> and <c>dsVersion</c> specify the data source type and version, such as <c>Hive</c> and <c>3.2.0</c>.</description></item>
        /// <item><description><c>dsConfig</c> specifies the data source connection configuration, submitted as a JSON string. The content varies by data source type and typically includes the access address and access credentials. Credential fields are masked when returned in query responses.</description></item>
        /// <item><description><c>componentType</c> identifies the role of the data source in the migration pipeline: <c>0</c> for source, <c>1</c> for destination.</description></item>
        /// <item><description><c>categoryType</c> specifies the data source category. Valid values: <c>DATASET</c>, <c>WORKFLOW</c>, <c>ENGINE</c>.</description></item>
        /// <item><description><c>dsId</c> specifies the external ID of the data source. <c>dsStatus</c> specifies the connectivity status. <c>dsDesc</c> specifies the data source description.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the ID (long integer) of the newly created data source. Subsequent operations reference this data source by this ID or the data source name.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddMetaDataComponentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMetaDataComponentResponse
        /// </returns>
        public async Task<AddMetaDataComponentResponse> AddMetaDataComponentWithOptionsAsync(AddMetaDataComponentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["categoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                body["componentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsConfig))
            {
                body["dsConfig"] = request.DsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsDesc))
            {
                body["dsDesc"] = request.DsDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsId))
            {
                body["dsId"] = request.DsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsName))
            {
                body["dsName"] = request.DsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsStatus))
            {
                body["dsStatus"] = request.DsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsType))
            {
                body["dsType"] = request.DsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsVersion))
            {
                body["dsVersion"] = request.DsVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMetaDataComponent",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMetaDataComponentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a metadata data source and completes connectivity configuration. This is a prerequisite step for starting metadata discovery tasks. The create action does not require authentication, but the duplicate name check within it is authenticated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a metadata data source and registers its type, version, and connection configuration. A data source serves as the foundational input for capabilities such as metadata discovery, workflow migration, and data validation. Related tasks reference the data source created here by data source ID or name.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dsName</c> specifies the data source name, which must be unique within the same tenant. If the name already exists, the operation returns a data source already exists error.</description></item>
        /// <item><description><c>dsType</c> and <c>dsVersion</c> specify the data source type and version, such as <c>Hive</c> and <c>3.2.0</c>.</description></item>
        /// <item><description><c>dsConfig</c> specifies the data source connection configuration, submitted as a JSON string. The content varies by data source type and typically includes the access address and access credentials. Credential fields are masked when returned in query responses.</description></item>
        /// <item><description><c>componentType</c> identifies the role of the data source in the migration pipeline: <c>0</c> for source, <c>1</c> for destination.</description></item>
        /// <item><description><c>categoryType</c> specifies the data source category. Valid values: <c>DATASET</c>, <c>WORKFLOW</c>, <c>ENGINE</c>.</description></item>
        /// <item><description><c>dsId</c> specifies the external ID of the data source. <c>dsStatus</c> specifies the connectivity status. <c>dsDesc</c> specifies the data source description.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the ID (long integer) of the newly created data source. Subsequent operations reference this data source by this ID or the data source name.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddMetaDataComponentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMetaDataComponentResponse
        /// </returns>
        public AddMetaDataComponentResponse AddMetaDataComponent(AddMetaDataComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddMetaDataComponentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a metadata data source and completes connectivity configuration. This is a prerequisite step for starting metadata discovery tasks. The create action does not require authentication, but the duplicate name check within it is authenticated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a metadata data source and registers its type, version, and connection configuration. A data source serves as the foundational input for capabilities such as metadata discovery, workflow migration, and data validation. Related tasks reference the data source created here by data source ID or name.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dsName</c> specifies the data source name, which must be unique within the same tenant. If the name already exists, the operation returns a data source already exists error.</description></item>
        /// <item><description><c>dsType</c> and <c>dsVersion</c> specify the data source type and version, such as <c>Hive</c> and <c>3.2.0</c>.</description></item>
        /// <item><description><c>dsConfig</c> specifies the data source connection configuration, submitted as a JSON string. The content varies by data source type and typically includes the access address and access credentials. Credential fields are masked when returned in query responses.</description></item>
        /// <item><description><c>componentType</c> identifies the role of the data source in the migration pipeline: <c>0</c> for source, <c>1</c> for destination.</description></item>
        /// <item><description><c>categoryType</c> specifies the data source category. Valid values: <c>DATASET</c>, <c>WORKFLOW</c>, <c>ENGINE</c>.</description></item>
        /// <item><description><c>dsId</c> specifies the external ID of the data source. <c>dsStatus</c> specifies the connectivity status. <c>dsDesc</c> specifies the data source description.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the ID (long integer) of the newly created data source. Subsequent operations reference this data source by this ID or the data source name.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddMetaDataComponentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMetaDataComponentResponse
        /// </returns>
        public async Task<AddMetaDataComponentResponse> AddMetaDataComponentAsync(AddMetaDataComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddMetaDataComponentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an SQL conversion task and immediately runs the conversion. Returns a task ID for subsequent queries on conversion progress and results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an SQL conversion task and immediately triggers the conversion. This operation completes task creation and conversion execution in a single step. It is suitable for scenarios where source scripts are ready and you want to directly obtain target dialect scripts.
        /// The returned task ID serves as the entry point for querying conversion progress, retrieving conversion results, and submitting results for execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskName</c> is required and specifies the task name. <c>taskDescription</c> specifies the task description.</description></item>
        /// <item><description><c>type</c> specifies the script type: <c>0</c> for DDL, <c>1</c> for DQL.</description></item>
        /// <item><description><c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects. The conversion process rewrites source dialect scripts into target dialect scripts.</description></item>
        /// <item><description><c>sourceSqlScript</c> is the list of scripts to convert. When creating a task, provide the script name, script ID, and original script content <c>sqlSourceContent</c>. Fields such as <c>sqlResultContent</c>, <c>errorMessage</c>, <c>finishTime</c>, and <c>scriptTransformStatus</c> carry conversion results and statuses and are populated by the server.</description></item>
        /// <item><description>Valid values of <c>scriptTransformStatus</c>: <c>pass</c> (conversion succeeded), <c>turning</c> (conversion in progress), <c>fail</c> (conversion failed). In some scenarios, the following values are used: <c>success</c> (succeeded), <c>failed</c> (failed), <c>skipped</c> (skipped).</description></item>
        /// <item><description><c>tableMappingList</c> declares table name mappings from the source to the target, including the source schema and table name, and the target type and table name. During conversion, table names in scripts are rewritten based on these mappings.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The <c>data</c> field returns <c>taskId</c>, which is the ID of the conversion task that has been created and started. Use this ID to query conversion progress, retrieve conversion results, or submit conversion results for execution.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExecuteSqlConversionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExecuteSqlConversionResponse
        /// </returns>
        public CreateExecuteSqlConversionResponse CreateExecuteSqlConversionWithOptions(CreateExecuteSqlConversionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExecuteSqlConversion",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/api/createExecute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExecuteSqlConversionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an SQL conversion task and immediately runs the conversion. Returns a task ID for subsequent queries on conversion progress and results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an SQL conversion task and immediately triggers the conversion. This operation completes task creation and conversion execution in a single step. It is suitable for scenarios where source scripts are ready and you want to directly obtain target dialect scripts.
        /// The returned task ID serves as the entry point for querying conversion progress, retrieving conversion results, and submitting results for execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskName</c> is required and specifies the task name. <c>taskDescription</c> specifies the task description.</description></item>
        /// <item><description><c>type</c> specifies the script type: <c>0</c> for DDL, <c>1</c> for DQL.</description></item>
        /// <item><description><c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects. The conversion process rewrites source dialect scripts into target dialect scripts.</description></item>
        /// <item><description><c>sourceSqlScript</c> is the list of scripts to convert. When creating a task, provide the script name, script ID, and original script content <c>sqlSourceContent</c>. Fields such as <c>sqlResultContent</c>, <c>errorMessage</c>, <c>finishTime</c>, and <c>scriptTransformStatus</c> carry conversion results and statuses and are populated by the server.</description></item>
        /// <item><description>Valid values of <c>scriptTransformStatus</c>: <c>pass</c> (conversion succeeded), <c>turning</c> (conversion in progress), <c>fail</c> (conversion failed). In some scenarios, the following values are used: <c>success</c> (succeeded), <c>failed</c> (failed), <c>skipped</c> (skipped).</description></item>
        /// <item><description><c>tableMappingList</c> declares table name mappings from the source to the target, including the source schema and table name, and the target type and table name. During conversion, table names in scripts are rewritten based on these mappings.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The <c>data</c> field returns <c>taskId</c>, which is the ID of the conversion task that has been created and started. Use this ID to query conversion progress, retrieve conversion results, or submit conversion results for execution.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExecuteSqlConversionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExecuteSqlConversionResponse
        /// </returns>
        public async Task<CreateExecuteSqlConversionResponse> CreateExecuteSqlConversionWithOptionsAsync(CreateExecuteSqlConversionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExecuteSqlConversion",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/api/createExecute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExecuteSqlConversionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an SQL conversion task and immediately runs the conversion. Returns a task ID for subsequent queries on conversion progress and results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an SQL conversion task and immediately triggers the conversion. This operation completes task creation and conversion execution in a single step. It is suitable for scenarios where source scripts are ready and you want to directly obtain target dialect scripts.
        /// The returned task ID serves as the entry point for querying conversion progress, retrieving conversion results, and submitting results for execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskName</c> is required and specifies the task name. <c>taskDescription</c> specifies the task description.</description></item>
        /// <item><description><c>type</c> specifies the script type: <c>0</c> for DDL, <c>1</c> for DQL.</description></item>
        /// <item><description><c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects. The conversion process rewrites source dialect scripts into target dialect scripts.</description></item>
        /// <item><description><c>sourceSqlScript</c> is the list of scripts to convert. When creating a task, provide the script name, script ID, and original script content <c>sqlSourceContent</c>. Fields such as <c>sqlResultContent</c>, <c>errorMessage</c>, <c>finishTime</c>, and <c>scriptTransformStatus</c> carry conversion results and statuses and are populated by the server.</description></item>
        /// <item><description>Valid values of <c>scriptTransformStatus</c>: <c>pass</c> (conversion succeeded), <c>turning</c> (conversion in progress), <c>fail</c> (conversion failed). In some scenarios, the following values are used: <c>success</c> (succeeded), <c>failed</c> (failed), <c>skipped</c> (skipped).</description></item>
        /// <item><description><c>tableMappingList</c> declares table name mappings from the source to the target, including the source schema and table name, and the target type and table name. During conversion, table names in scripts are rewritten based on these mappings.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The <c>data</c> field returns <c>taskId</c>, which is the ID of the conversion task that has been created and started. Use this ID to query conversion progress, retrieve conversion results, or submit conversion results for execution.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExecuteSqlConversionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExecuteSqlConversionResponse
        /// </returns>
        public CreateExecuteSqlConversionResponse CreateExecuteSqlConversion(CreateExecuteSqlConversionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExecuteSqlConversionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an SQL conversion task and immediately runs the conversion. Returns a task ID for subsequent queries on conversion progress and results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an SQL conversion task and immediately triggers the conversion. This operation completes task creation and conversion execution in a single step. It is suitable for scenarios where source scripts are ready and you want to directly obtain target dialect scripts.
        /// The returned task ID serves as the entry point for querying conversion progress, retrieving conversion results, and submitting results for execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskName</c> is required and specifies the task name. <c>taskDescription</c> specifies the task description.</description></item>
        /// <item><description><c>type</c> specifies the script type: <c>0</c> for DDL, <c>1</c> for DQL.</description></item>
        /// <item><description><c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects. The conversion process rewrites source dialect scripts into target dialect scripts.</description></item>
        /// <item><description><c>sourceSqlScript</c> is the list of scripts to convert. When creating a task, provide the script name, script ID, and original script content <c>sqlSourceContent</c>. Fields such as <c>sqlResultContent</c>, <c>errorMessage</c>, <c>finishTime</c>, and <c>scriptTransformStatus</c> carry conversion results and statuses and are populated by the server.</description></item>
        /// <item><description>Valid values of <c>scriptTransformStatus</c>: <c>pass</c> (conversion succeeded), <c>turning</c> (conversion in progress), <c>fail</c> (conversion failed). In some scenarios, the following values are used: <c>success</c> (succeeded), <c>failed</c> (failed), <c>skipped</c> (skipped).</description></item>
        /// <item><description><c>tableMappingList</c> declares table name mappings from the source to the target, including the source schema and table name, and the target type and table name. During conversion, table names in scripts are rewritten based on these mappings.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The <c>data</c> field returns <c>taskId</c>, which is the ID of the conversion task that has been created and started. Use this ID to query conversion progress, retrieve conversion results, or submit conversion results for execution.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExecuteSqlConversionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExecuteSqlConversionResponse
        /// </returns>
        public async Task<CreateExecuteSqlConversionResponse> CreateExecuteSqlConversionAsync(CreateExecuteSqlConversionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExecuteSqlConversionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits SQL conversion results in batch to the target for execution and returns the execution job information for this submission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits the conversion results generated by an SQL conversion task in batch to the target for execution. This is used to deploy scripts all at once after dialect conversion is complete.
        /// This operation only handles submission and returns the execution job information generated by this submission.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId specifies the SQL conversion task to submit for execution. The task must already have conversion results.</description></item>
        /// <item><description>concurrency specifies the concurrency level to control the number of concurrent executions for this submission. This is an optional parameter.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The data object returns taskId, execJobId (the execution job ID generated by this submission), success, and message. The inner success field indicates whether the submission action succeeded. If it fails, message provides the reason.
        /// The outer success, errCode, and errMessage fields indicate the result of the API call itself. requestId is used to troubleshoot this call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSqlExecJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlExecJobResponse
        /// </returns>
        public CreateSqlExecJobResponse CreateSqlExecJobWithOptions(CreateSqlExecJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlExecJob",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlExecJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits SQL conversion results in batch to the target for execution and returns the execution job information for this submission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits the conversion results generated by an SQL conversion task in batch to the target for execution. This is used to deploy scripts all at once after dialect conversion is complete.
        /// This operation only handles submission and returns the execution job information generated by this submission.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId specifies the SQL conversion task to submit for execution. The task must already have conversion results.</description></item>
        /// <item><description>concurrency specifies the concurrency level to control the number of concurrent executions for this submission. This is an optional parameter.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The data object returns taskId, execJobId (the execution job ID generated by this submission), success, and message. The inner success field indicates whether the submission action succeeded. If it fails, message provides the reason.
        /// The outer success, errCode, and errMessage fields indicate the result of the API call itself. requestId is used to troubleshoot this call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSqlExecJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlExecJobResponse
        /// </returns>
        public async Task<CreateSqlExecJobResponse> CreateSqlExecJobWithOptionsAsync(CreateSqlExecJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlExecJob",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlExecJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits SQL conversion results in batch to the target for execution and returns the execution job information for this submission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits the conversion results generated by an SQL conversion task in batch to the target for execution. This is used to deploy scripts all at once after dialect conversion is complete.
        /// This operation only handles submission and returns the execution job information generated by this submission.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId specifies the SQL conversion task to submit for execution. The task must already have conversion results.</description></item>
        /// <item><description>concurrency specifies the concurrency level to control the number of concurrent executions for this submission. This is an optional parameter.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The data object returns taskId, execJobId (the execution job ID generated by this submission), success, and message. The inner success field indicates whether the submission action succeeded. If it fails, message provides the reason.
        /// The outer success, errCode, and errMessage fields indicate the result of the API call itself. requestId is used to troubleshoot this call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSqlExecJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlExecJobResponse
        /// </returns>
        public CreateSqlExecJobResponse CreateSqlExecJob(CreateSqlExecJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSqlExecJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits SQL conversion results in batch to the target for execution and returns the execution job information for this submission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits the conversion results generated by an SQL conversion task in batch to the target for execution. This is used to deploy scripts all at once after dialect conversion is complete.
        /// This operation only handles submission and returns the execution job information generated by this submission.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId specifies the SQL conversion task to submit for execution. The task must already have conversion results.</description></item>
        /// <item><description>concurrency specifies the concurrency level to control the number of concurrent executions for this submission. This is an optional parameter.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The data object returns taskId, execJobId (the execution job ID generated by this submission), success, and message. The inner success field indicates whether the submission action succeeded. If it fails, message provides the reason.
        /// The outer success, errCode, and errMessage fields indicate the result of the API call itself. requestId is used to troubleshoot this call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSqlExecJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlExecJobResponse
        /// </returns>
        public async Task<CreateSqlExecJobResponse> CreateSqlExecJobAsync(CreateSqlExecJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSqlExecJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified data validation task configuration. After deletion, the configuration no longer participates in subsequent validation scheduling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Deletes a table-level configuration from a data validation task. After deletion, the configuration no longer participates in subsequent validation scheduling. The task itself is not affected.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>id is required and specifies the ID of the configuration to delete. You can obtain this ID by calling the query data validation task configuration operation.</description></item>
        /// <item><description>This operation deletes a single configuration by configuration ID. Each call processes only one configuration.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. If success is true, the deletion is successful. If success is false, use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckConfigResponse
        /// </returns>
        public DeleteDataCheckConfigResponse DeleteDataCheckConfigWithOptions(DeleteDataCheckConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataCheckConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/deleteConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataCheckConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified data validation task configuration. After deletion, the configuration no longer participates in subsequent validation scheduling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Deletes a table-level configuration from a data validation task. After deletion, the configuration no longer participates in subsequent validation scheduling. The task itself is not affected.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>id is required and specifies the ID of the configuration to delete. You can obtain this ID by calling the query data validation task configuration operation.</description></item>
        /// <item><description>This operation deletes a single configuration by configuration ID. Each call processes only one configuration.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. If success is true, the deletion is successful. If success is false, use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckConfigResponse
        /// </returns>
        public async Task<DeleteDataCheckConfigResponse> DeleteDataCheckConfigWithOptionsAsync(DeleteDataCheckConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataCheckConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/deleteConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataCheckConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified data validation task configuration. After deletion, the configuration no longer participates in subsequent validation scheduling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Deletes a table-level configuration from a data validation task. After deletion, the configuration no longer participates in subsequent validation scheduling. The task itself is not affected.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>id is required and specifies the ID of the configuration to delete. You can obtain this ID by calling the query data validation task configuration operation.</description></item>
        /// <item><description>This operation deletes a single configuration by configuration ID. Each call processes only one configuration.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. If success is true, the deletion is successful. If success is false, use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckConfigResponse
        /// </returns>
        public DeleteDataCheckConfigResponse DeleteDataCheckConfig(DeleteDataCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDataCheckConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified data validation task configuration. After deletion, the configuration no longer participates in subsequent validation scheduling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Deletes a table-level configuration from a data validation task. After deletion, the configuration no longer participates in subsequent validation scheduling. The task itself is not affected.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>id is required and specifies the ID of the configuration to delete. You can obtain this ID by calling the query data validation task configuration operation.</description></item>
        /// <item><description>This operation deletes a single configuration by configuration ID. Each call processes only one configuration.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. If success is true, the deletion is successful. If success is false, use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckConfigResponse
        /// </returns>
        public async Task<DeleteDataCheckConfigResponse> DeleteDataCheckConfigAsync(DeleteDataCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDataCheckConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a logical deletion of data validation tasks (batch operation supported). Deleted tasks are no longer displayed in the list or scheduled for execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Batch deletes data validation tasks by using logical deletion. After deletion, tasks are no longer displayed in the task list or scheduled for execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskIds is required and specifies the list of task IDs to delete. You can delete multiple tasks in a single request.</description></item>
        /// <item><description>Deletion is logical, which only changes the visibility and scheduling status of tasks. Tasks that are currently running cannot be deleted.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. If success is true, the deletion is successful. If success is false, use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckTaskResponse
        /// </returns>
        public DeleteDataCheckTaskResponse DeleteDataCheckTaskWithOptions(DeleteDataCheckTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataCheckTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a logical deletion of data validation tasks (batch operation supported). Deleted tasks are no longer displayed in the list or scheduled for execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Batch deletes data validation tasks by using logical deletion. After deletion, tasks are no longer displayed in the task list or scheduled for execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskIds is required and specifies the list of task IDs to delete. You can delete multiple tasks in a single request.</description></item>
        /// <item><description>Deletion is logical, which only changes the visibility and scheduling status of tasks. Tasks that are currently running cannot be deleted.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. If success is true, the deletion is successful. If success is false, use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckTaskResponse
        /// </returns>
        public async Task<DeleteDataCheckTaskResponse> DeleteDataCheckTaskWithOptionsAsync(DeleteDataCheckTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataCheckTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a logical deletion of data validation tasks (batch operation supported). Deleted tasks are no longer displayed in the list or scheduled for execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Batch deletes data validation tasks by using logical deletion. After deletion, tasks are no longer displayed in the task list or scheduled for execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskIds is required and specifies the list of task IDs to delete. You can delete multiple tasks in a single request.</description></item>
        /// <item><description>Deletion is logical, which only changes the visibility and scheduling status of tasks. Tasks that are currently running cannot be deleted.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. If success is true, the deletion is successful. If success is false, use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckTaskResponse
        /// </returns>
        public DeleteDataCheckTaskResponse DeleteDataCheckTask(DeleteDataCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDataCheckTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a logical deletion of data validation tasks (batch operation supported). Deleted tasks are no longer displayed in the list or scheduled for execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Batch deletes data validation tasks by using logical deletion. After deletion, tasks are no longer displayed in the task list or scheduled for execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskIds is required and specifies the list of task IDs to delete. You can delete multiple tasks in a single request.</description></item>
        /// <item><description>Deletion is logical, which only changes the visibility and scheduling status of tasks. Tasks that are currently running cannot be deleted.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. If success is true, the deletion is successful. If success is false, use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckTaskResponse
        /// </returns>
        public async Task<DeleteDataCheckTaskResponse> DeleteDataCheckTaskAsync(DeleteDataCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDataCheckTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch deletes data validation templates along with their associated rule configurations and datasource engine relationships.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Batch deletes data validation templates to clean up templates that are no longer in use. The deletion scope includes the templates themselves and their associated rule configurations and datasource engine relationships.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>templateIds is the list of template IDs to delete. You can delete multiple templates at a time. If this list is empty, the operation returns a missing parameter error.</description></item>
        /// <item><description>The delete operation does not verify whether a template is referenced by a validation task. Check whether a template is referenced by a validation task by viewing the reference mark returned by the template list operation before deletion.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. A value of true for success indicates that the deletion is successful. A value of false for success indicates a failure. Use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckTemplateResponse
        /// </returns>
        public DeleteDataCheckTemplateResponse DeleteDataCheckTemplateWithOptions(DeleteDataCheckTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataCheckTemplate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataCheckTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch deletes data validation templates along with their associated rule configurations and datasource engine relationships.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Batch deletes data validation templates to clean up templates that are no longer in use. The deletion scope includes the templates themselves and their associated rule configurations and datasource engine relationships.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>templateIds is the list of template IDs to delete. You can delete multiple templates at a time. If this list is empty, the operation returns a missing parameter error.</description></item>
        /// <item><description>The delete operation does not verify whether a template is referenced by a validation task. Check whether a template is referenced by a validation task by viewing the reference mark returned by the template list operation before deletion.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. A value of true for success indicates that the deletion is successful. A value of false for success indicates a failure. Use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckTemplateResponse
        /// </returns>
        public async Task<DeleteDataCheckTemplateResponse> DeleteDataCheckTemplateWithOptionsAsync(DeleteDataCheckTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataCheckTemplate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataCheckTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch deletes data validation templates along with their associated rule configurations and datasource engine relationships.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Batch deletes data validation templates to clean up templates that are no longer in use. The deletion scope includes the templates themselves and their associated rule configurations and datasource engine relationships.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>templateIds is the list of template IDs to delete. You can delete multiple templates at a time. If this list is empty, the operation returns a missing parameter error.</description></item>
        /// <item><description>The delete operation does not verify whether a template is referenced by a validation task. Check whether a template is referenced by a validation task by viewing the reference mark returned by the template list operation before deletion.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. A value of true for success indicates that the deletion is successful. A value of false for success indicates a failure. Use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckTemplateResponse
        /// </returns>
        public DeleteDataCheckTemplateResponse DeleteDataCheckTemplate(DeleteDataCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDataCheckTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch deletes data validation templates along with their associated rule configurations and datasource engine relationships.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Batch deletes data validation templates to clean up templates that are no longer in use. The deletion scope includes the templates themselves and their associated rule configurations and datasource engine relationships.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>templateIds is the list of template IDs to delete. You can delete multiple templates at a time. If this list is empty, the operation returns a missing parameter error.</description></item>
        /// <item><description>The delete operation does not verify whether a template is referenced by a validation task. Check whether a template is referenced by a validation task by viewing the reference mark returned by the template list operation before deletion.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only success, errCode, errMessage, and requestId. No business data is returned. A value of true for success indicates that the deletion is successful. A value of false for success indicates a failure. Use errCode and errMessage to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCheckTemplateResponse
        /// </returns>
        public async Task<DeleteDataCheckTemplateResponse> DeleteDataCheckTemplateAsync(DeleteDataCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDataCheckTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits the configuration of an existing SQL conversion task through the POP channel, such as the source dialect, target dialect, and conversion scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Edits the configuration of an existing SQL conversion task. The request is submitted through the POP open channel. You can modify the task name, task type, source and target dialects, concurrency, and the test data source associated with a DQL task.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the conversion task to edit. <c>taskType</c> is required and specifies the task type: <c>1</c> for DDL and <c>2</c> for DQL.</description></item>
        /// <item><description><c>taskName</c>, <c>sourceDialect</c>, and <c>targetDialect</c> specify the task name, source SQL dialect, and target SQL dialect.</description></item>
        /// <item><description><c>dqlTestDatasourceName</c> specifies the name of the test data source associated with a DQL task. The server resolves the corresponding data source by this name under the current tenant and uses it for subsequent conversion processing.</description></item>
        /// <item><description><c>concurrency</c> specifies the concurrency for controlling the number of concurrent conversion executions.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The <c>data</c> field contains the result of this edit operation, including the task ID, record primary key ID, file upload and parsing ID, and the <c>success</c> and <c>message</c> fields that indicate whether the edit succeeded. If the edit fails, <c>message</c> provides the reason.
        /// The outer <c>success</c>, <c>errCode</c>, and <c>errMessage</c> fields indicate the result of the API call itself. <c>requestId</c> is used for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditTaskPopRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditTaskPopResponse
        /// </returns>
        public EditTaskPopResponse EditTaskPopWithOptions(EditTaskPopRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestDatasourceName))
            {
                body["dqlTestDatasourceName"] = request.DqlTestDatasourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditTaskPop",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/editPop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditTaskPopResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits the configuration of an existing SQL conversion task through the POP channel, such as the source dialect, target dialect, and conversion scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Edits the configuration of an existing SQL conversion task. The request is submitted through the POP open channel. You can modify the task name, task type, source and target dialects, concurrency, and the test data source associated with a DQL task.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the conversion task to edit. <c>taskType</c> is required and specifies the task type: <c>1</c> for DDL and <c>2</c> for DQL.</description></item>
        /// <item><description><c>taskName</c>, <c>sourceDialect</c>, and <c>targetDialect</c> specify the task name, source SQL dialect, and target SQL dialect.</description></item>
        /// <item><description><c>dqlTestDatasourceName</c> specifies the name of the test data source associated with a DQL task. The server resolves the corresponding data source by this name under the current tenant and uses it for subsequent conversion processing.</description></item>
        /// <item><description><c>concurrency</c> specifies the concurrency for controlling the number of concurrent conversion executions.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The <c>data</c> field contains the result of this edit operation, including the task ID, record primary key ID, file upload and parsing ID, and the <c>success</c> and <c>message</c> fields that indicate whether the edit succeeded. If the edit fails, <c>message</c> provides the reason.
        /// The outer <c>success</c>, <c>errCode</c>, and <c>errMessage</c> fields indicate the result of the API call itself. <c>requestId</c> is used for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditTaskPopRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditTaskPopResponse
        /// </returns>
        public async Task<EditTaskPopResponse> EditTaskPopWithOptionsAsync(EditTaskPopRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestDatasourceName))
            {
                body["dqlTestDatasourceName"] = request.DqlTestDatasourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditTaskPop",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/editPop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditTaskPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits the configuration of an existing SQL conversion task through the POP channel, such as the source dialect, target dialect, and conversion scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Edits the configuration of an existing SQL conversion task. The request is submitted through the POP open channel. You can modify the task name, task type, source and target dialects, concurrency, and the test data source associated with a DQL task.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the conversion task to edit. <c>taskType</c> is required and specifies the task type: <c>1</c> for DDL and <c>2</c> for DQL.</description></item>
        /// <item><description><c>taskName</c>, <c>sourceDialect</c>, and <c>targetDialect</c> specify the task name, source SQL dialect, and target SQL dialect.</description></item>
        /// <item><description><c>dqlTestDatasourceName</c> specifies the name of the test data source associated with a DQL task. The server resolves the corresponding data source by this name under the current tenant and uses it for subsequent conversion processing.</description></item>
        /// <item><description><c>concurrency</c> specifies the concurrency for controlling the number of concurrent conversion executions.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The <c>data</c> field contains the result of this edit operation, including the task ID, record primary key ID, file upload and parsing ID, and the <c>success</c> and <c>message</c> fields that indicate whether the edit succeeded. If the edit fails, <c>message</c> provides the reason.
        /// The outer <c>success</c>, <c>errCode</c>, and <c>errMessage</c> fields indicate the result of the API call itself. <c>requestId</c> is used for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditTaskPopRequest
        /// </param>
        /// 
        /// <returns>
        /// EditTaskPopResponse
        /// </returns>
        public EditTaskPopResponse EditTaskPop(EditTaskPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EditTaskPopWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits the configuration of an existing SQL conversion task through the POP channel, such as the source dialect, target dialect, and conversion scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Edits the configuration of an existing SQL conversion task. The request is submitted through the POP open channel. You can modify the task name, task type, source and target dialects, concurrency, and the test data source associated with a DQL task.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the conversion task to edit. <c>taskType</c> is required and specifies the task type: <c>1</c> for DDL and <c>2</c> for DQL.</description></item>
        /// <item><description><c>taskName</c>, <c>sourceDialect</c>, and <c>targetDialect</c> specify the task name, source SQL dialect, and target SQL dialect.</description></item>
        /// <item><description><c>dqlTestDatasourceName</c> specifies the name of the test data source associated with a DQL task. The server resolves the corresponding data source by this name under the current tenant and uses it for subsequent conversion processing.</description></item>
        /// <item><description><c>concurrency</c> specifies the concurrency for controlling the number of concurrent conversion executions.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The <c>data</c> field contains the result of this edit operation, including the task ID, record primary key ID, file upload and parsing ID, and the <c>success</c> and <c>message</c> fields that indicate whether the edit succeeded. If the edit fails, <c>message</c> provides the reason.
        /// The outer <c>success</c>, <c>errCode</c>, and <c>errMessage</c> fields indicate the result of the API call itself. <c>requestId</c> is used for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditTaskPopRequest
        /// </param>
        /// 
        /// <returns>
        /// EditTaskPopResponse
        /// </returns>
        public async Task<EditTaskPopResponse> EditTaskPopAsync(EditTaskPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EditTaskPopWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the result details file at the subtask level by validation batch for offline verification of data differences.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Exports the subtask result details file for a specified validation batch and returns a downloadable link. You can use this link to verify data differences offline, archive validation conclusions, or deliver results to business stakeholders for confirmation.
        /// This operation only exports reports that have already been generated. It does not trigger report generation. If the report for the batch has not been generated, call the report generation operation first and wait until the report status changes to Generated before exporting.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>batchId specifies the validation batch to export. Obtain this value from the response of the save data validation task operation.</description></item>
        /// <item><description>Before calling this operation, make sure the report status for the batch is Generated. The export fails if the report has not been generated or generation has failed. Confirm the status by calling the report status query operation.</description></item>
        /// <item><description>Each call exports the result details for a single batch.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. The data field contains the download link for the report file (a temporary Object Storage Service (OSS) URL). The link has an expiration time. Download the file promptly after obtaining the link. If the link expires, call this operation again to obtain a new link.
        /// If success is false, use errCode and errMessage to identify the failure cause. Use requestId to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckDownloadReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckDownloadReportResponse
        /// </returns>
        public ExecDataCheckDownloadReportResponse ExecDataCheckDownloadReportWithOptions(ExecDataCheckDownloadReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckDownloadReport",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/download",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckDownloadReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the result details file at the subtask level by validation batch for offline verification of data differences.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Exports the subtask result details file for a specified validation batch and returns a downloadable link. You can use this link to verify data differences offline, archive validation conclusions, or deliver results to business stakeholders for confirmation.
        /// This operation only exports reports that have already been generated. It does not trigger report generation. If the report for the batch has not been generated, call the report generation operation first and wait until the report status changes to Generated before exporting.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>batchId specifies the validation batch to export. Obtain this value from the response of the save data validation task operation.</description></item>
        /// <item><description>Before calling this operation, make sure the report status for the batch is Generated. The export fails if the report has not been generated or generation has failed. Confirm the status by calling the report status query operation.</description></item>
        /// <item><description>Each call exports the result details for a single batch.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. The data field contains the download link for the report file (a temporary Object Storage Service (OSS) URL). The link has an expiration time. Download the file promptly after obtaining the link. If the link expires, call this operation again to obtain a new link.
        /// If success is false, use errCode and errMessage to identify the failure cause. Use requestId to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckDownloadReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckDownloadReportResponse
        /// </returns>
        public async Task<ExecDataCheckDownloadReportResponse> ExecDataCheckDownloadReportWithOptionsAsync(ExecDataCheckDownloadReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckDownloadReport",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/download",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckDownloadReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the result details file at the subtask level by validation batch for offline verification of data differences.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Exports the subtask result details file for a specified validation batch and returns a downloadable link. You can use this link to verify data differences offline, archive validation conclusions, or deliver results to business stakeholders for confirmation.
        /// This operation only exports reports that have already been generated. It does not trigger report generation. If the report for the batch has not been generated, call the report generation operation first and wait until the report status changes to Generated before exporting.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>batchId specifies the validation batch to export. Obtain this value from the response of the save data validation task operation.</description></item>
        /// <item><description>Before calling this operation, make sure the report status for the batch is Generated. The export fails if the report has not been generated or generation has failed. Confirm the status by calling the report status query operation.</description></item>
        /// <item><description>Each call exports the result details for a single batch.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. The data field contains the download link for the report file (a temporary Object Storage Service (OSS) URL). The link has an expiration time. Download the file promptly after obtaining the link. If the link expires, call this operation again to obtain a new link.
        /// If success is false, use errCode and errMessage to identify the failure cause. Use requestId to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckDownloadReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckDownloadReportResponse
        /// </returns>
        public ExecDataCheckDownloadReportResponse ExecDataCheckDownloadReport(ExecDataCheckDownloadReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecDataCheckDownloadReportWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the result details file at the subtask level by validation batch for offline verification of data differences.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Exports the subtask result details file for a specified validation batch and returns a downloadable link. You can use this link to verify data differences offline, archive validation conclusions, or deliver results to business stakeholders for confirmation.
        /// This operation only exports reports that have already been generated. It does not trigger report generation. If the report for the batch has not been generated, call the report generation operation first and wait until the report status changes to Generated before exporting.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>batchId specifies the validation batch to export. Obtain this value from the response of the save data validation task operation.</description></item>
        /// <item><description>Before calling this operation, make sure the report status for the batch is Generated. The export fails if the report has not been generated or generation has failed. Confirm the status by calling the report status query operation.</description></item>
        /// <item><description>Each call exports the result details for a single batch.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. The data field contains the download link for the report file (a temporary Object Storage Service (OSS) URL). The link has an expiration time. Download the file promptly after obtaining the link. If the link expires, call this operation again to obtain a new link.
        /// If success is false, use errCode and errMessage to identify the failure cause. Use requestId to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckDownloadReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckDownloadReportResponse
        /// </returns>
        public async Task<ExecDataCheckDownloadReportResponse> ExecDataCheckDownloadReportAsync(ExecDataCheckDownloadReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecDataCheckDownloadReportWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers report generation for a specified data validation batch. After generation is complete, you can query results through the report overview and details operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Triggers report generation for a specified data validation batch. After validation execution is complete, comparison results are stored as detailed records. You must generate a report before you can query results from the report perspective through operations such as report overview and report details, or export result files.
        /// Report generation is an asynchronous process. This operation only initiates the generation. A successful response indicates that the generation request has been accepted, not that the report is available.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch for which to generate a report. The value is obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>Initiate generation only after the validation execution of the batch is complete. A report generated for a batch that is still running does not contain the final results.</description></item>
        /// <item><description>Track the generation progress and result through the report status query operation. The report overview can be queried or the file can be exported only after the report status changes to &quot;Generated&quot;.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the generation request has been accepted. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckGenerateReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckGenerateReportResponse
        /// </returns>
        public ExecDataCheckGenerateReportResponse ExecDataCheckGenerateReportWithOptions(ExecDataCheckGenerateReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckGenerateReport",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/generateReport",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckGenerateReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers report generation for a specified data validation batch. After generation is complete, you can query results through the report overview and details operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Triggers report generation for a specified data validation batch. After validation execution is complete, comparison results are stored as detailed records. You must generate a report before you can query results from the report perspective through operations such as report overview and report details, or export result files.
        /// Report generation is an asynchronous process. This operation only initiates the generation. A successful response indicates that the generation request has been accepted, not that the report is available.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch for which to generate a report. The value is obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>Initiate generation only after the validation execution of the batch is complete. A report generated for a batch that is still running does not contain the final results.</description></item>
        /// <item><description>Track the generation progress and result through the report status query operation. The report overview can be queried or the file can be exported only after the report status changes to &quot;Generated&quot;.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the generation request has been accepted. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckGenerateReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckGenerateReportResponse
        /// </returns>
        public async Task<ExecDataCheckGenerateReportResponse> ExecDataCheckGenerateReportWithOptionsAsync(ExecDataCheckGenerateReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckGenerateReport",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/generateReport",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckGenerateReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers report generation for a specified data validation batch. After generation is complete, you can query results through the report overview and details operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Triggers report generation for a specified data validation batch. After validation execution is complete, comparison results are stored as detailed records. You must generate a report before you can query results from the report perspective through operations such as report overview and report details, or export result files.
        /// Report generation is an asynchronous process. This operation only initiates the generation. A successful response indicates that the generation request has been accepted, not that the report is available.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch for which to generate a report. The value is obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>Initiate generation only after the validation execution of the batch is complete. A report generated for a batch that is still running does not contain the final results.</description></item>
        /// <item><description>Track the generation progress and result through the report status query operation. The report overview can be queried or the file can be exported only after the report status changes to &quot;Generated&quot;.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the generation request has been accepted. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckGenerateReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckGenerateReportResponse
        /// </returns>
        public ExecDataCheckGenerateReportResponse ExecDataCheckGenerateReport(ExecDataCheckGenerateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecDataCheckGenerateReportWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers report generation for a specified data validation batch. After generation is complete, you can query results through the report overview and details operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Triggers report generation for a specified data validation batch. After validation execution is complete, comparison results are stored as detailed records. You must generate a report before you can query results from the report perspective through operations such as report overview and report details, or export result files.
        /// Report generation is an asynchronous process. This operation only initiates the generation. A successful response indicates that the generation request has been accepted, not that the report is available.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch for which to generate a report. The value is obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>Initiate generation only after the validation execution of the batch is complete. A report generated for a batch that is still running does not contain the final results.</description></item>
        /// <item><description>Track the generation progress and result through the report status query operation. The report overview can be queried or the file can be exported only after the report status changes to &quot;Generated&quot;.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the generation request has been accepted. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckGenerateReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckGenerateReportResponse
        /// </returns>
        public async Task<ExecDataCheckGenerateReportResponse> ExecDataCheckGenerateReportAsync(ExecDataCheckGenerateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecDataCheckGenerateReportWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reruns a completed data validation task to re-execute data comparison and generate a new validation batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Initiates a full rerun for the specified validation batch: a new batch is created based on the original batch, and all tables pending validation under the task are compared again, rather than only rerunning the failed portions.
        /// This operation is applicable to scenarios where source or destination data has been corrected and a complete validation conclusion is needed. If you only need to rerun failed or unverified subtasks, use the rerun failed subtasks operation to avoid the resource consumption caused by a full comparison.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch to use as the rerun baseline. The value is obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>The batch must exist and must not be in the running state. Repeated requests against a running batch are denied.</description></item>
        /// <item><description>Before the rerun starts, a connectivity dry run is performed on the source and destination data sources associated with the node. The rerun does not start if a data source is not active.</description></item>
        /// <item><description>The rerun uses the table-level configuration of the node to which the original batch belongs. The configuration itself is not modified.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the batch ID of the newly created rerun batch. The execution progress, report, and result details of the rerun are associated with this new batch. The historical results of the original batch are retained. Use the new batch ID for subsequent queries and exports.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckReRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckReRunResponse
        /// </returns>
        public ExecDataCheckReRunResponse ExecDataCheckReRunWithOptions(ExecDataCheckReRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckReRun",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/rerun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckReRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reruns a completed data validation task to re-execute data comparison and generate a new validation batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Initiates a full rerun for the specified validation batch: a new batch is created based on the original batch, and all tables pending validation under the task are compared again, rather than only rerunning the failed portions.
        /// This operation is applicable to scenarios where source or destination data has been corrected and a complete validation conclusion is needed. If you only need to rerun failed or unverified subtasks, use the rerun failed subtasks operation to avoid the resource consumption caused by a full comparison.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch to use as the rerun baseline. The value is obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>The batch must exist and must not be in the running state. Repeated requests against a running batch are denied.</description></item>
        /// <item><description>Before the rerun starts, a connectivity dry run is performed on the source and destination data sources associated with the node. The rerun does not start if a data source is not active.</description></item>
        /// <item><description>The rerun uses the table-level configuration of the node to which the original batch belongs. The configuration itself is not modified.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the batch ID of the newly created rerun batch. The execution progress, report, and result details of the rerun are associated with this new batch. The historical results of the original batch are retained. Use the new batch ID for subsequent queries and exports.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckReRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckReRunResponse
        /// </returns>
        public async Task<ExecDataCheckReRunResponse> ExecDataCheckReRunWithOptionsAsync(ExecDataCheckReRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckReRun",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/rerun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckReRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reruns a completed data validation task to re-execute data comparison and generate a new validation batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Initiates a full rerun for the specified validation batch: a new batch is created based on the original batch, and all tables pending validation under the task are compared again, rather than only rerunning the failed portions.
        /// This operation is applicable to scenarios where source or destination data has been corrected and a complete validation conclusion is needed. If you only need to rerun failed or unverified subtasks, use the rerun failed subtasks operation to avoid the resource consumption caused by a full comparison.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch to use as the rerun baseline. The value is obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>The batch must exist and must not be in the running state. Repeated requests against a running batch are denied.</description></item>
        /// <item><description>Before the rerun starts, a connectivity dry run is performed on the source and destination data sources associated with the node. The rerun does not start if a data source is not active.</description></item>
        /// <item><description>The rerun uses the table-level configuration of the node to which the original batch belongs. The configuration itself is not modified.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the batch ID of the newly created rerun batch. The execution progress, report, and result details of the rerun are associated with this new batch. The historical results of the original batch are retained. Use the new batch ID for subsequent queries and exports.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckReRunRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckReRunResponse
        /// </returns>
        public ExecDataCheckReRunResponse ExecDataCheckReRun(ExecDataCheckReRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecDataCheckReRunWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reruns a completed data validation task to re-execute data comparison and generate a new validation batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Initiates a full rerun for the specified validation batch: a new batch is created based on the original batch, and all tables pending validation under the task are compared again, rather than only rerunning the failed portions.
        /// This operation is applicable to scenarios where source or destination data has been corrected and a complete validation conclusion is needed. If you only need to rerun failed or unverified subtasks, use the rerun failed subtasks operation to avoid the resource consumption caused by a full comparison.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch to use as the rerun baseline. The value is obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>The batch must exist and must not be in the running state. Repeated requests against a running batch are denied.</description></item>
        /// <item><description>Before the rerun starts, a connectivity dry run is performed on the source and destination data sources associated with the node. The rerun does not start if a data source is not active.</description></item>
        /// <item><description>The rerun uses the table-level configuration of the node to which the original batch belongs. The configuration itself is not modified.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the batch ID of the newly created rerun batch. The execution progress, report, and result details of the rerun are associated with this new batch. The historical results of the original batch are retained. Use the new batch ID for subsequent queries and exports.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckReRunRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckReRunResponse
        /// </returns>
        public async Task<ExecDataCheckReRunResponse> ExecDataCheckReRunAsync(ExecDataCheckReRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecDataCheckReRunWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a data validation task immediately without waiting for timed scheduling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Immediately triggers a data validation execution without waiting for timed scheduling. This is applicable when you want to view comparison results right after saving a configuration, or when you need to run an additional execution outside the scheduling cycle.
        /// The execution is performed asynchronously. A success response from this operation indicates that the execution has been initiated. Query the comparison results through the report and result details operations after the check execution is complete.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the check batch to execute. The value is obtained from the response of the operation that saves the data validation task.</description></item>
        /// <item><description>The batch must exist and must not be in the running state. Repeated requests for a running batch are rejected.</description></item>
        /// <item><description>Before execution, a connectivity dry run is performed on the source and target data sources associated with the task. The execution does not start if a data source is unavailable.</description></item>
        /// <item><description>If you want to execute immediately after saving the configuration, you can also set the immediate execution switch to enabled when saving the data validation task, without calling this operation separately.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. A <c>success</c> value of <c>true</c> indicates that the execution has been initiated, not that the comparison is complete. If the value is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckRunResponse
        /// </returns>
        public ExecDataCheckRunResponse ExecDataCheckRunWithOptions(ExecDataCheckRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckRun",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a data validation task immediately without waiting for timed scheduling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Immediately triggers a data validation execution without waiting for timed scheduling. This is applicable when you want to view comparison results right after saving a configuration, or when you need to run an additional execution outside the scheduling cycle.
        /// The execution is performed asynchronously. A success response from this operation indicates that the execution has been initiated. Query the comparison results through the report and result details operations after the check execution is complete.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the check batch to execute. The value is obtained from the response of the operation that saves the data validation task.</description></item>
        /// <item><description>The batch must exist and must not be in the running state. Repeated requests for a running batch are rejected.</description></item>
        /// <item><description>Before execution, a connectivity dry run is performed on the source and target data sources associated with the task. The execution does not start if a data source is unavailable.</description></item>
        /// <item><description>If you want to execute immediately after saving the configuration, you can also set the immediate execution switch to enabled when saving the data validation task, without calling this operation separately.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. A <c>success</c> value of <c>true</c> indicates that the execution has been initiated, not that the comparison is complete. If the value is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckRunResponse
        /// </returns>
        public async Task<ExecDataCheckRunResponse> ExecDataCheckRunWithOptionsAsync(ExecDataCheckRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckRun",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a data validation task immediately without waiting for timed scheduling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Immediately triggers a data validation execution without waiting for timed scheduling. This is applicable when you want to view comparison results right after saving a configuration, or when you need to run an additional execution outside the scheduling cycle.
        /// The execution is performed asynchronously. A success response from this operation indicates that the execution has been initiated. Query the comparison results through the report and result details operations after the check execution is complete.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the check batch to execute. The value is obtained from the response of the operation that saves the data validation task.</description></item>
        /// <item><description>The batch must exist and must not be in the running state. Repeated requests for a running batch are rejected.</description></item>
        /// <item><description>Before execution, a connectivity dry run is performed on the source and target data sources associated with the task. The execution does not start if a data source is unavailable.</description></item>
        /// <item><description>If you want to execute immediately after saving the configuration, you can also set the immediate execution switch to enabled when saving the data validation task, without calling this operation separately.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. A <c>success</c> value of <c>true</c> indicates that the execution has been initiated, not that the comparison is complete. If the value is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckRunRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckRunResponse
        /// </returns>
        public ExecDataCheckRunResponse ExecDataCheckRun(ExecDataCheckRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecDataCheckRunWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a data validation task immediately without waiting for timed scheduling.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Immediately triggers a data validation execution without waiting for timed scheduling. This is applicable when you want to view comparison results right after saving a configuration, or when you need to run an additional execution outside the scheduling cycle.
        /// The execution is performed asynchronously. A success response from this operation indicates that the execution has been initiated. Query the comparison results through the report and result details operations after the check execution is complete.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the check batch to execute. The value is obtained from the response of the operation that saves the data validation task.</description></item>
        /// <item><description>The batch must exist and must not be in the running state. Repeated requests for a running batch are rejected.</description></item>
        /// <item><description>Before execution, a connectivity dry run is performed on the source and target data sources associated with the task. The execution does not start if a data source is unavailable.</description></item>
        /// <item><description>If you want to execute immediately after saving the configuration, you can also set the immediate execution switch to enabled when saving the data validation task, without calling this operation separately.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. A <c>success</c> value of <c>true</c> indicates that the execution has been initiated, not that the comparison is complete. If the value is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckRunRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckRunResponse
        /// </returns>
        public async Task<ExecDataCheckRunResponse> ExecDataCheckRunAsync(ExecDataCheckRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecDataCheckRunWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reruns failed subtasks in a specified data validation batch, scoped by rerun type to avoid a full rerun.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Reruns subtasks that did not pass in a specified data validation batch. The rerun scope is limited by the rerun type to avoid rerunning tables that have already passed validation.
        /// The difference from a full rerun is the scope: a full rerun revalidates all tables under the task, whereas this operation only reruns subtasks that match the selected type. Both approaches create a new batch to hold the results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch to rerun. Obtain this value from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description><c>type</c> determines the rerun scope: <c>0</c> reruns only execution-failed subtasks, <c>1</c> reruns execution-failed and validation-failed subtasks, and <c>2</c> reruns execution-failed and stopped subtasks. If not specified, the default value is <c>1</c>.</description></item>
        /// <item><description>The specified batch must exist, and the most recent batch of the parent task must not be running. Otherwise, the rerun request is rejected.</description></item>
        /// <item><description>The specified batch must contain completed data validation subtasks. If no subtasks have finished, there are no subtasks to rerun, and the operation returns an error.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the ID of the new batch created for this rerun. The rerun progress and results are associated with this new batch. The original batch results remain unchanged. Use the new batch ID for subsequent queries and exports.
        /// If <c>success</c> is <c>false</c>, check <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckRunFailedRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckRunFailedResponse
        /// </returns>
        public ExecDataCheckRunFailedResponse ExecDataCheckRunFailedWithOptions(ExecDataCheckRunFailedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckRunFailed",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/runFailed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckRunFailedResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reruns failed subtasks in a specified data validation batch, scoped by rerun type to avoid a full rerun.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Reruns subtasks that did not pass in a specified data validation batch. The rerun scope is limited by the rerun type to avoid rerunning tables that have already passed validation.
        /// The difference from a full rerun is the scope: a full rerun revalidates all tables under the task, whereas this operation only reruns subtasks that match the selected type. Both approaches create a new batch to hold the results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch to rerun. Obtain this value from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description><c>type</c> determines the rerun scope: <c>0</c> reruns only execution-failed subtasks, <c>1</c> reruns execution-failed and validation-failed subtasks, and <c>2</c> reruns execution-failed and stopped subtasks. If not specified, the default value is <c>1</c>.</description></item>
        /// <item><description>The specified batch must exist, and the most recent batch of the parent task must not be running. Otherwise, the rerun request is rejected.</description></item>
        /// <item><description>The specified batch must contain completed data validation subtasks. If no subtasks have finished, there are no subtasks to rerun, and the operation returns an error.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the ID of the new batch created for this rerun. The rerun progress and results are associated with this new batch. The original batch results remain unchanged. Use the new batch ID for subsequent queries and exports.
        /// If <c>success</c> is <c>false</c>, check <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckRunFailedRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckRunFailedResponse
        /// </returns>
        public async Task<ExecDataCheckRunFailedResponse> ExecDataCheckRunFailedWithOptionsAsync(ExecDataCheckRunFailedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckRunFailed",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/runFailed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckRunFailedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reruns failed subtasks in a specified data validation batch, scoped by rerun type to avoid a full rerun.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Reruns subtasks that did not pass in a specified data validation batch. The rerun scope is limited by the rerun type to avoid rerunning tables that have already passed validation.
        /// The difference from a full rerun is the scope: a full rerun revalidates all tables under the task, whereas this operation only reruns subtasks that match the selected type. Both approaches create a new batch to hold the results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch to rerun. Obtain this value from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description><c>type</c> determines the rerun scope: <c>0</c> reruns only execution-failed subtasks, <c>1</c> reruns execution-failed and validation-failed subtasks, and <c>2</c> reruns execution-failed and stopped subtasks. If not specified, the default value is <c>1</c>.</description></item>
        /// <item><description>The specified batch must exist, and the most recent batch of the parent task must not be running. Otherwise, the rerun request is rejected.</description></item>
        /// <item><description>The specified batch must contain completed data validation subtasks. If no subtasks have finished, there are no subtasks to rerun, and the operation returns an error.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the ID of the new batch created for this rerun. The rerun progress and results are associated with this new batch. The original batch results remain unchanged. Use the new batch ID for subsequent queries and exports.
        /// If <c>success</c> is <c>false</c>, check <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckRunFailedRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckRunFailedResponse
        /// </returns>
        public ExecDataCheckRunFailedResponse ExecDataCheckRunFailed(ExecDataCheckRunFailedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecDataCheckRunFailedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reruns failed subtasks in a specified data validation batch, scoped by rerun type to avoid a full rerun.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Reruns subtasks that did not pass in a specified data validation batch. The rerun scope is limited by the rerun type to avoid rerunning tables that have already passed validation.
        /// The difference from a full rerun is the scope: a full rerun revalidates all tables under the task, whereas this operation only reruns subtasks that match the selected type. Both approaches create a new batch to hold the results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the data validation batch to rerun. Obtain this value from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description><c>type</c> determines the rerun scope: <c>0</c> reruns only execution-failed subtasks, <c>1</c> reruns execution-failed and validation-failed subtasks, and <c>2</c> reruns execution-failed and stopped subtasks. If not specified, the default value is <c>1</c>.</description></item>
        /// <item><description>The specified batch must exist, and the most recent batch of the parent task must not be running. Otherwise, the rerun request is rejected.</description></item>
        /// <item><description>The specified batch must contain completed data validation subtasks. If no subtasks have finished, there are no subtasks to rerun, and the operation returns an error.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the ID of the new batch created for this rerun. The rerun progress and results are associated with this new batch. The original batch results remain unchanged. Use the new batch ID for subsequent queries and exports.
        /// If <c>success</c> is <c>false</c>, check <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckRunFailedRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckRunFailedResponse
        /// </returns>
        public async Task<ExecDataCheckRunFailedResponse> ExecDataCheckRunFailedAsync(ExecDataCheckRunFailedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecDataCheckRunFailedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves one or more modified data validation tasks. You can also configure settings such as whether to perform full-table validation and whether to execute the task immediately.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Saves the execution configuration of a data validation task and generates a validation batch for the task. The task itself describes which two data sources to validate and which validation method to use. This operation determines the execution scope of the validation: whether to perform full-table validation, global parameters, data volume difference thresholds, and whether to execute immediately after saving.
        /// The batch ID returned upon successful saving serves as the unified entry point for subsequent operations such as execution, stopping, re-running, report generation, and result detail queries.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> specifies the validation task for which to save the configuration. The task must already exist.</description></item>
        /// <item><description>Before saving, the system checks whether the task has any table detail configurations. If no table detail configurations exist, the save operation is rejected. Add table detail configurations to the task first.</description></item>
        /// <item><description><c>fullTableCount</c> determines the comparison granularity: <c>0</c> for partition-level validation (default), <c>1</c> for full-table validation.</description></item>
        /// <item><description><c>sourceGlobalParams</c>, <c>targetGlobalParams</c>, and <c>checkGlobalParams</c> are global parameters for the source, target, and validation phases respectively. Separate multiple parameters with a line feed (<c>\\n</c>).</description></item>
        /// <item><description><c>totalCountThreshold</c> is the total data volume comparison threshold, used to determine whether the data volume difference between the source and target is within an acceptable range.</description></item>
        /// <item><description><c>startImmediately</c> determines whether to execute immediately after saving: <c>0</c> for no (default), <c>1</c> for yes. When set to <c>1</c>, the generated batch starts asynchronous execution immediately, eliminating the need to call a separate execution operation.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is the validation batch ID generated by this save operation (not the task ID). Subsequent operations such as execution, stopping, re-running, report generation, and result detail queries all reference this validation by the batch ID.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckSaveTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckSaveTaskResponse
        /// </returns>
        public ExecDataCheckSaveTaskResponse ExecDataCheckSaveTaskWithOptions(ExecDataCheckSaveTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckGlobalParams))
            {
                body["checkGlobalParams"] = request.CheckGlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTableCount))
            {
                body["fullTableCount"] = request.FullTableCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceGlobalParams))
            {
                body["sourceGlobalParams"] = request.SourceGlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartImmediately))
            {
                body["startImmediately"] = request.StartImmediately;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetGlobalParams))
            {
                body["targetGlobalParams"] = request.TargetGlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalCountThreshold))
            {
                body["totalCountThreshold"] = request.TotalCountThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckSaveTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckSaveTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves one or more modified data validation tasks. You can also configure settings such as whether to perform full-table validation and whether to execute the task immediately.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Saves the execution configuration of a data validation task and generates a validation batch for the task. The task itself describes which two data sources to validate and which validation method to use. This operation determines the execution scope of the validation: whether to perform full-table validation, global parameters, data volume difference thresholds, and whether to execute immediately after saving.
        /// The batch ID returned upon successful saving serves as the unified entry point for subsequent operations such as execution, stopping, re-running, report generation, and result detail queries.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> specifies the validation task for which to save the configuration. The task must already exist.</description></item>
        /// <item><description>Before saving, the system checks whether the task has any table detail configurations. If no table detail configurations exist, the save operation is rejected. Add table detail configurations to the task first.</description></item>
        /// <item><description><c>fullTableCount</c> determines the comparison granularity: <c>0</c> for partition-level validation (default), <c>1</c> for full-table validation.</description></item>
        /// <item><description><c>sourceGlobalParams</c>, <c>targetGlobalParams</c>, and <c>checkGlobalParams</c> are global parameters for the source, target, and validation phases respectively. Separate multiple parameters with a line feed (<c>\\n</c>).</description></item>
        /// <item><description><c>totalCountThreshold</c> is the total data volume comparison threshold, used to determine whether the data volume difference between the source and target is within an acceptable range.</description></item>
        /// <item><description><c>startImmediately</c> determines whether to execute immediately after saving: <c>0</c> for no (default), <c>1</c> for yes. When set to <c>1</c>, the generated batch starts asynchronous execution immediately, eliminating the need to call a separate execution operation.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is the validation batch ID generated by this save operation (not the task ID). Subsequent operations such as execution, stopping, re-running, report generation, and result detail queries all reference this validation by the batch ID.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckSaveTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckSaveTaskResponse
        /// </returns>
        public async Task<ExecDataCheckSaveTaskResponse> ExecDataCheckSaveTaskWithOptionsAsync(ExecDataCheckSaveTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckGlobalParams))
            {
                body["checkGlobalParams"] = request.CheckGlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTableCount))
            {
                body["fullTableCount"] = request.FullTableCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceGlobalParams))
            {
                body["sourceGlobalParams"] = request.SourceGlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartImmediately))
            {
                body["startImmediately"] = request.StartImmediately;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetGlobalParams))
            {
                body["targetGlobalParams"] = request.TargetGlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalCountThreshold))
            {
                body["totalCountThreshold"] = request.TotalCountThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckSaveTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckSaveTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves one or more modified data validation tasks. You can also configure settings such as whether to perform full-table validation and whether to execute the task immediately.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Saves the execution configuration of a data validation task and generates a validation batch for the task. The task itself describes which two data sources to validate and which validation method to use. This operation determines the execution scope of the validation: whether to perform full-table validation, global parameters, data volume difference thresholds, and whether to execute immediately after saving.
        /// The batch ID returned upon successful saving serves as the unified entry point for subsequent operations such as execution, stopping, re-running, report generation, and result detail queries.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> specifies the validation task for which to save the configuration. The task must already exist.</description></item>
        /// <item><description>Before saving, the system checks whether the task has any table detail configurations. If no table detail configurations exist, the save operation is rejected. Add table detail configurations to the task first.</description></item>
        /// <item><description><c>fullTableCount</c> determines the comparison granularity: <c>0</c> for partition-level validation (default), <c>1</c> for full-table validation.</description></item>
        /// <item><description><c>sourceGlobalParams</c>, <c>targetGlobalParams</c>, and <c>checkGlobalParams</c> are global parameters for the source, target, and validation phases respectively. Separate multiple parameters with a line feed (<c>\\n</c>).</description></item>
        /// <item><description><c>totalCountThreshold</c> is the total data volume comparison threshold, used to determine whether the data volume difference between the source and target is within an acceptable range.</description></item>
        /// <item><description><c>startImmediately</c> determines whether to execute immediately after saving: <c>0</c> for no (default), <c>1</c> for yes. When set to <c>1</c>, the generated batch starts asynchronous execution immediately, eliminating the need to call a separate execution operation.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is the validation batch ID generated by this save operation (not the task ID). Subsequent operations such as execution, stopping, re-running, report generation, and result detail queries all reference this validation by the batch ID.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckSaveTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckSaveTaskResponse
        /// </returns>
        public ExecDataCheckSaveTaskResponse ExecDataCheckSaveTask(ExecDataCheckSaveTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecDataCheckSaveTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves one or more modified data validation tasks. You can also configure settings such as whether to perform full-table validation and whether to execute the task immediately.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Saves the execution configuration of a data validation task and generates a validation batch for the task. The task itself describes which two data sources to validate and which validation method to use. This operation determines the execution scope of the validation: whether to perform full-table validation, global parameters, data volume difference thresholds, and whether to execute immediately after saving.
        /// The batch ID returned upon successful saving serves as the unified entry point for subsequent operations such as execution, stopping, re-running, report generation, and result detail queries.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> specifies the validation task for which to save the configuration. The task must already exist.</description></item>
        /// <item><description>Before saving, the system checks whether the task has any table detail configurations. If no table detail configurations exist, the save operation is rejected. Add table detail configurations to the task first.</description></item>
        /// <item><description><c>fullTableCount</c> determines the comparison granularity: <c>0</c> for partition-level validation (default), <c>1</c> for full-table validation.</description></item>
        /// <item><description><c>sourceGlobalParams</c>, <c>targetGlobalParams</c>, and <c>checkGlobalParams</c> are global parameters for the source, target, and validation phases respectively. Separate multiple parameters with a line feed (<c>\\n</c>).</description></item>
        /// <item><description><c>totalCountThreshold</c> is the total data volume comparison threshold, used to determine whether the data volume difference between the source and target is within an acceptable range.</description></item>
        /// <item><description><c>startImmediately</c> determines whether to execute immediately after saving: <c>0</c> for no (default), <c>1</c> for yes. When set to <c>1</c>, the generated batch starts asynchronous execution immediately, eliminating the need to call a separate execution operation.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is the validation batch ID generated by this save operation (not the task ID). Subsequent operations such as execution, stopping, re-running, report generation, and result detail queries all reference this validation by the batch ID.
        /// When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckSaveTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckSaveTaskResponse
        /// </returns>
        public async Task<ExecDataCheckSaveTaskResponse> ExecDataCheckSaveTaskAsync(ExecDataCheckSaveTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecDataCheckSaveTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a preview of the comparison SQL that will be issued based on the check task configuration, allowing you to confirm the check scope before execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Generates and returns the actual comparison SQL that will be issued based on the specified table and check conditions, without executing it. Use this operation to confirm whether the check scope meets expectations before you execute the check. For example, you can verify that the partition range, filter conditions, and fields involved in the comparison are correctly defined.
        /// The generated SQL is intended only for preview and troubleshooting purposes and can serve as a reference for diagnosing unexpected comparison results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dataSourceId</c> specifies the data source on which the SQL is generated.</description></item>
        /// <item><description><c>fullTableName</c> specifies the table to check, in the format <c>schema.table</c>.</description></item>
        /// <item><description><c>taskId</c> specifies the check task, which is used to retrieve the check method and rules configured for that task.</description></item>
        /// <item><description><c>engineId</c> specifies the check engine, used in Spark check scenarios.</description></item>
        /// <item><description><c>partitionCondition</c> is the partition condition that limits the comparison scope to specified partitions. <c>whereClause</c> is the filter condition that further limits the rows involved in the comparison.</description></item>
        /// <item><description><c>checkColumn</c> specifies the fields involved in the comparison. Separate multiple fields with commas (,). If not specified, the SQL is generated based on the field scope configured for the task.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the generated comparison SQL statement text. Because this operation only generates the SQL without executing it, a successful response does not indicate that data has been compared.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckSqlPreviewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckSqlPreviewResponse
        /// </returns>
        public ExecDataCheckSqlPreviewResponse ExecDataCheckSqlPreviewWithOptions(ExecDataCheckSqlPreviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckColumn))
            {
                body["checkColumn"] = request.CheckColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineId))
            {
                body["engineId"] = request.EngineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTableName))
            {
                body["fullTableName"] = request.FullTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionCondition))
            {
                body["partitionCondition"] = request.PartitionCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhereClause))
            {
                body["whereClause"] = request.WhereClause;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckSqlPreview",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/sql/preview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckSqlPreviewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a preview of the comparison SQL that will be issued based on the check task configuration, allowing you to confirm the check scope before execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Generates and returns the actual comparison SQL that will be issued based on the specified table and check conditions, without executing it. Use this operation to confirm whether the check scope meets expectations before you execute the check. For example, you can verify that the partition range, filter conditions, and fields involved in the comparison are correctly defined.
        /// The generated SQL is intended only for preview and troubleshooting purposes and can serve as a reference for diagnosing unexpected comparison results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dataSourceId</c> specifies the data source on which the SQL is generated.</description></item>
        /// <item><description><c>fullTableName</c> specifies the table to check, in the format <c>schema.table</c>.</description></item>
        /// <item><description><c>taskId</c> specifies the check task, which is used to retrieve the check method and rules configured for that task.</description></item>
        /// <item><description><c>engineId</c> specifies the check engine, used in Spark check scenarios.</description></item>
        /// <item><description><c>partitionCondition</c> is the partition condition that limits the comparison scope to specified partitions. <c>whereClause</c> is the filter condition that further limits the rows involved in the comparison.</description></item>
        /// <item><description><c>checkColumn</c> specifies the fields involved in the comparison. Separate multiple fields with commas (,). If not specified, the SQL is generated based on the field scope configured for the task.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the generated comparison SQL statement text. Because this operation only generates the SQL without executing it, a successful response does not indicate that data has been compared.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckSqlPreviewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckSqlPreviewResponse
        /// </returns>
        public async Task<ExecDataCheckSqlPreviewResponse> ExecDataCheckSqlPreviewWithOptionsAsync(ExecDataCheckSqlPreviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckColumn))
            {
                body["checkColumn"] = request.CheckColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineId))
            {
                body["engineId"] = request.EngineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTableName))
            {
                body["fullTableName"] = request.FullTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionCondition))
            {
                body["partitionCondition"] = request.PartitionCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhereClause))
            {
                body["whereClause"] = request.WhereClause;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckSqlPreview",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/sql/preview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckSqlPreviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a preview of the comparison SQL that will be issued based on the check task configuration, allowing you to confirm the check scope before execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Generates and returns the actual comparison SQL that will be issued based on the specified table and check conditions, without executing it. Use this operation to confirm whether the check scope meets expectations before you execute the check. For example, you can verify that the partition range, filter conditions, and fields involved in the comparison are correctly defined.
        /// The generated SQL is intended only for preview and troubleshooting purposes and can serve as a reference for diagnosing unexpected comparison results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dataSourceId</c> specifies the data source on which the SQL is generated.</description></item>
        /// <item><description><c>fullTableName</c> specifies the table to check, in the format <c>schema.table</c>.</description></item>
        /// <item><description><c>taskId</c> specifies the check task, which is used to retrieve the check method and rules configured for that task.</description></item>
        /// <item><description><c>engineId</c> specifies the check engine, used in Spark check scenarios.</description></item>
        /// <item><description><c>partitionCondition</c> is the partition condition that limits the comparison scope to specified partitions. <c>whereClause</c> is the filter condition that further limits the rows involved in the comparison.</description></item>
        /// <item><description><c>checkColumn</c> specifies the fields involved in the comparison. Separate multiple fields with commas (,). If not specified, the SQL is generated based on the field scope configured for the task.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the generated comparison SQL statement text. Because this operation only generates the SQL without executing it, a successful response does not indicate that data has been compared.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckSqlPreviewRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckSqlPreviewResponse
        /// </returns>
        public ExecDataCheckSqlPreviewResponse ExecDataCheckSqlPreview(ExecDataCheckSqlPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecDataCheckSqlPreviewWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a preview of the comparison SQL that will be issued based on the check task configuration, allowing you to confirm the check scope before execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Generates and returns the actual comparison SQL that will be issued based on the specified table and check conditions, without executing it. Use this operation to confirm whether the check scope meets expectations before you execute the check. For example, you can verify that the partition range, filter conditions, and fields involved in the comparison are correctly defined.
        /// The generated SQL is intended only for preview and troubleshooting purposes and can serve as a reference for diagnosing unexpected comparison results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dataSourceId</c> specifies the data source on which the SQL is generated.</description></item>
        /// <item><description><c>fullTableName</c> specifies the table to check, in the format <c>schema.table</c>.</description></item>
        /// <item><description><c>taskId</c> specifies the check task, which is used to retrieve the check method and rules configured for that task.</description></item>
        /// <item><description><c>engineId</c> specifies the check engine, used in Spark check scenarios.</description></item>
        /// <item><description><c>partitionCondition</c> is the partition condition that limits the comparison scope to specified partitions. <c>whereClause</c> is the filter condition that further limits the rows involved in the comparison.</description></item>
        /// <item><description><c>checkColumn</c> specifies the fields involved in the comparison. Separate multiple fields with commas (,). If not specified, the SQL is generated based on the field scope configured for the task.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the generated comparison SQL statement text. Because this operation only generates the SQL without executing it, a successful response does not indicate that data has been compared.
        /// If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckSqlPreviewRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckSqlPreviewResponse
        /// </returns>
        public async Task<ExecDataCheckSqlPreviewResponse> ExecDataCheckSqlPreviewAsync(ExecDataCheckSqlPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecDataCheckSqlPreviewWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the check node execution in the current scheduling run. Task results of completed subtasks are retained.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Stops a running check batch and terminates any incomplete comparison work in the current scheduling run. Task results of completed subtasks are retained. After the node is stopped, you can rerun only the failed and stopped portions without rerunning the entire node.
        /// This operation is applicable to scenarios where the check scope is misconfigured, the source or destination is under heavy load and needs to be relieved, or the execution time needs to be rescheduled.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the check batch to stop. The value is obtained from the response of the API operation that saves the data validation node.</description></item>
        /// <item><description>You can stop only a batch that is in the running state. If the batch does not exist or has already ended (succeeded, failed, or stopped), the operation returns an error without making any changes.</description></item>
        /// <item><description>The stop action applies only to the current batch and does not change the timed scheduling switch of the node. To stop periodic execution, use the API operation that enables or disables timed scheduling.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the stop action has taken effect. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. The error message &quot;task is not running&quot; indicates that the batch no longer needs to be stopped.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckStopRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckStopResponse
        /// </returns>
        public ExecDataCheckStopResponse ExecDataCheckStopWithOptions(ExecDataCheckStopRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckStop",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckStopResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the check node execution in the current scheduling run. Task results of completed subtasks are retained.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Stops a running check batch and terminates any incomplete comparison work in the current scheduling run. Task results of completed subtasks are retained. After the node is stopped, you can rerun only the failed and stopped portions without rerunning the entire node.
        /// This operation is applicable to scenarios where the check scope is misconfigured, the source or destination is under heavy load and needs to be relieved, or the execution time needs to be rescheduled.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the check batch to stop. The value is obtained from the response of the API operation that saves the data validation node.</description></item>
        /// <item><description>You can stop only a batch that is in the running state. If the batch does not exist or has already ended (succeeded, failed, or stopped), the operation returns an error without making any changes.</description></item>
        /// <item><description>The stop action applies only to the current batch and does not change the timed scheduling switch of the node. To stop periodic execution, use the API operation that enables or disables timed scheduling.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the stop action has taken effect. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. The error message &quot;task is not running&quot; indicates that the batch no longer needs to be stopped.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckStopRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckStopResponse
        /// </returns>
        public async Task<ExecDataCheckStopResponse> ExecDataCheckStopWithOptionsAsync(ExecDataCheckStopRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckStop",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckStopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the check node execution in the current scheduling run. Task results of completed subtasks are retained.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Stops a running check batch and terminates any incomplete comparison work in the current scheduling run. Task results of completed subtasks are retained. After the node is stopped, you can rerun only the failed and stopped portions without rerunning the entire node.
        /// This operation is applicable to scenarios where the check scope is misconfigured, the source or destination is under heavy load and needs to be relieved, or the execution time needs to be rescheduled.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the check batch to stop. The value is obtained from the response of the API operation that saves the data validation node.</description></item>
        /// <item><description>You can stop only a batch that is in the running state. If the batch does not exist or has already ended (succeeded, failed, or stopped), the operation returns an error without making any changes.</description></item>
        /// <item><description>The stop action applies only to the current batch and does not change the timed scheduling switch of the node. To stop periodic execution, use the API operation that enables or disables timed scheduling.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the stop action has taken effect. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. The error message &quot;task is not running&quot; indicates that the batch no longer needs to be stopped.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckStopRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckStopResponse
        /// </returns>
        public ExecDataCheckStopResponse ExecDataCheckStop(ExecDataCheckStopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecDataCheckStopWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the check node execution in the current scheduling run. Task results of completed subtasks are retained.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Stops a running check batch and terminates any incomplete comparison work in the current scheduling run. Task results of completed subtasks are retained. After the node is stopped, you can rerun only the failed and stopped portions without rerunning the entire node.
        /// This operation is applicable to scenarios where the check scope is misconfigured, the source or destination is under heavy load and needs to be relieved, or the execution time needs to be rescheduled.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> specifies the check batch to stop. The value is obtained from the response of the API operation that saves the data validation node.</description></item>
        /// <item><description>You can stop only a batch that is in the running state. If the batch does not exist or has already ended (succeeded, failed, or stopped), the operation returns an error without making any changes.</description></item>
        /// <item><description>The stop action applies only to the current batch and does not change the timed scheduling switch of the node. To stop periodic execution, use the API operation that enables or disables timed scheduling.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the stop action has taken effect. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. The error message &quot;task is not running&quot; indicates that the batch no longer needs to be stopped.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckStopRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckStopResponse
        /// </returns>
        public async Task<ExecDataCheckStopResponse> ExecDataCheckStopAsync(ExecDataCheckStopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecDataCheckStopWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switches the timed scheduling toggle of a data validation task to control whether the task is periodically executed based on a Cron rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Starts or stops the timed scheduling toggle of a data validation task to control whether the task is periodically executed based on the configured scheduling rule. You can submit multiple tasks at a time to start or stop a batch of validation tasks.
        /// This operation only switches the scheduling toggle. It does not change the scheduling expression of the task or trigger an immediate execution. To run a task immediately, use the immediate execution operation for validation tasks.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>params</c> is a list of task scheduling parameters. You can submit multiple tasks at a time.</description></item>
        /// <item><description>The <c>id</c> field in each item is the validation task ID. The <c>lastBatchId</c> field is the most recent batch number of the task. The <c>isScheduled</c> field is the target scheduling status: <c>0</c> indicates that timed scheduling is stopped, and <c>1</c> indicates that timed scheduling is started.</description></item>
        /// <item><description>To start timed scheduling, the task must have a valid scheduling rule configured. After timed scheduling is stopped, the task is no longer periodically triggered, and existing historical batches and results are retained.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the scheduling status of the tasks in the list has been switched as submitted. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckToggleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckToggleResponse
        /// </returns>
        public ExecDataCheckToggleResponse ExecDataCheckToggleWithOptions(ExecDataCheckToggleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckToggle",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/toggle",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckToggleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switches the timed scheduling toggle of a data validation task to control whether the task is periodically executed based on a Cron rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Starts or stops the timed scheduling toggle of a data validation task to control whether the task is periodically executed based on the configured scheduling rule. You can submit multiple tasks at a time to start or stop a batch of validation tasks.
        /// This operation only switches the scheduling toggle. It does not change the scheduling expression of the task or trigger an immediate execution. To run a task immediately, use the immediate execution operation for validation tasks.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>params</c> is a list of task scheduling parameters. You can submit multiple tasks at a time.</description></item>
        /// <item><description>The <c>id</c> field in each item is the validation task ID. The <c>lastBatchId</c> field is the most recent batch number of the task. The <c>isScheduled</c> field is the target scheduling status: <c>0</c> indicates that timed scheduling is stopped, and <c>1</c> indicates that timed scheduling is started.</description></item>
        /// <item><description>To start timed scheduling, the task must have a valid scheduling rule configured. After timed scheduling is stopped, the task is no longer periodically triggered, and existing historical batches and results are retained.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the scheduling status of the tasks in the list has been switched as submitted. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckToggleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckToggleResponse
        /// </returns>
        public async Task<ExecDataCheckToggleResponse> ExecDataCheckToggleWithOptionsAsync(ExecDataCheckToggleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecDataCheckToggle",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/toggle",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDataCheckToggleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switches the timed scheduling toggle of a data validation task to control whether the task is periodically executed based on a Cron rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Starts or stops the timed scheduling toggle of a data validation task to control whether the task is periodically executed based on the configured scheduling rule. You can submit multiple tasks at a time to start or stop a batch of validation tasks.
        /// This operation only switches the scheduling toggle. It does not change the scheduling expression of the task or trigger an immediate execution. To run a task immediately, use the immediate execution operation for validation tasks.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>params</c> is a list of task scheduling parameters. You can submit multiple tasks at a time.</description></item>
        /// <item><description>The <c>id</c> field in each item is the validation task ID. The <c>lastBatchId</c> field is the most recent batch number of the task. The <c>isScheduled</c> field is the target scheduling status: <c>0</c> indicates that timed scheduling is stopped, and <c>1</c> indicates that timed scheduling is started.</description></item>
        /// <item><description>To start timed scheduling, the task must have a valid scheduling rule configured. After timed scheduling is stopped, the task is no longer periodically triggered, and existing historical batches and results are retained.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the scheduling status of the tasks in the list has been switched as submitted. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckToggleRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckToggleResponse
        /// </returns>
        public ExecDataCheckToggleResponse ExecDataCheckToggle(ExecDataCheckToggleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecDataCheckToggleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switches the timed scheduling toggle of a data validation task to control whether the task is periodically executed based on a Cron rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Starts or stops the timed scheduling toggle of a data validation task to control whether the task is periodically executed based on the configured scheduling rule. You can submit multiple tasks at a time to start or stop a batch of validation tasks.
        /// This operation only switches the scheduling toggle. It does not change the scheduling expression of the task or trigger an immediate execution. To run a task immediately, use the immediate execution operation for validation tasks.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>params</c> is a list of task scheduling parameters. You can submit multiple tasks at a time.</description></item>
        /// <item><description>The <c>id</c> field in each item is the validation task ID. The <c>lastBatchId</c> field is the most recent batch number of the task. The <c>isScheduled</c> field is the target scheduling status: <c>0</c> indicates that timed scheduling is stopped, and <c>1</c> indicates that timed scheduling is started.</description></item>
        /// <item><description>To start timed scheduling, the task must have a valid scheduling rule configured. After timed scheduling is stopped, the task is no longer periodically triggered, and existing historical batches and results are retained.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A common response is returned, which contains only <c>success</c>, <c>errCode</c>, <c>errMessage</c>, and <c>requestId</c>. No business data is returned. If <c>success</c> is <c>true</c>, the scheduling status of the tasks in the list has been switched as submitted. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecDataCheckToggleRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecDataCheckToggleResponse
        /// </returns>
        public async Task<ExecDataCheckToggleResponse> ExecDataCheckToggleAsync(ExecDataCheckToggleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecDataCheckToggleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a datasource with the specified name already exists under the current tenant. This operation is used as a pre-check before creating or renaming a datasource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Checks whether a datasource name is already in use under the current tenant. This operation is used as a pre-check before creating a datasource or updating a datasource name.
        /// Datasource names must be unique within a tenant. If a name conflict exists, the creation request fails directly. Call this operation first to confirm that the name is available. This helps you avoid exposing conflicts only when you submit the creation request.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dsName</c> specifies the datasource name to check. The system performs an exact match against non-deleted datasources under the current tenant. Prefix matching and fuzzy matching are not supported.</description></item>
        /// <item><description>The check scope is limited to the current tenant. Datasources with the same name under other tenants do not affect the result. Names of deleted datasources can be reused.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is a Boolean value that indicates the name check result: <c>true</c> indicates that a datasource with the same name already exists and the name is unavailable. <c>false</c> indicates that the name is not in use and can be used to create a datasource.
        /// Note that the semantics of <c>data</c> is opposite to that of <c>success</c>. If <c>success</c> is <c>true</c> and <c>data</c> is <c>true</c>, the call succeeded and a datasource with the same name was found. In this case, use a different name. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the call failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecMetaDataComponentNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecMetaDataComponentNameResponse
        /// </returns>
        public ExecMetaDataComponentNameResponse ExecMetaDataComponentNameWithOptions(ExecMetaDataComponentNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsName))
            {
                query["dsName"] = request.DsName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecMetaDataComponentName",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component/check-name",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecMetaDataComponentNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a datasource with the specified name already exists under the current tenant. This operation is used as a pre-check before creating or renaming a datasource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Checks whether a datasource name is already in use under the current tenant. This operation is used as a pre-check before creating a datasource or updating a datasource name.
        /// Datasource names must be unique within a tenant. If a name conflict exists, the creation request fails directly. Call this operation first to confirm that the name is available. This helps you avoid exposing conflicts only when you submit the creation request.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dsName</c> specifies the datasource name to check. The system performs an exact match against non-deleted datasources under the current tenant. Prefix matching and fuzzy matching are not supported.</description></item>
        /// <item><description>The check scope is limited to the current tenant. Datasources with the same name under other tenants do not affect the result. Names of deleted datasources can be reused.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is a Boolean value that indicates the name check result: <c>true</c> indicates that a datasource with the same name already exists and the name is unavailable. <c>false</c> indicates that the name is not in use and can be used to create a datasource.
        /// Note that the semantics of <c>data</c> is opposite to that of <c>success</c>. If <c>success</c> is <c>true</c> and <c>data</c> is <c>true</c>, the call succeeded and a datasource with the same name was found. In this case, use a different name. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the call failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecMetaDataComponentNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecMetaDataComponentNameResponse
        /// </returns>
        public async Task<ExecMetaDataComponentNameResponse> ExecMetaDataComponentNameWithOptionsAsync(ExecMetaDataComponentNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsName))
            {
                query["dsName"] = request.DsName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecMetaDataComponentName",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component/check-name",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecMetaDataComponentNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a datasource with the specified name already exists under the current tenant. This operation is used as a pre-check before creating or renaming a datasource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Checks whether a datasource name is already in use under the current tenant. This operation is used as a pre-check before creating a datasource or updating a datasource name.
        /// Datasource names must be unique within a tenant. If a name conflict exists, the creation request fails directly. Call this operation first to confirm that the name is available. This helps you avoid exposing conflicts only when you submit the creation request.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dsName</c> specifies the datasource name to check. The system performs an exact match against non-deleted datasources under the current tenant. Prefix matching and fuzzy matching are not supported.</description></item>
        /// <item><description>The check scope is limited to the current tenant. Datasources with the same name under other tenants do not affect the result. Names of deleted datasources can be reused.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is a Boolean value that indicates the name check result: <c>true</c> indicates that a datasource with the same name already exists and the name is unavailable. <c>false</c> indicates that the name is not in use and can be used to create a datasource.
        /// Note that the semantics of <c>data</c> is opposite to that of <c>success</c>. If <c>success</c> is <c>true</c> and <c>data</c> is <c>true</c>, the call succeeded and a datasource with the same name was found. In this case, use a different name. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the call failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecMetaDataComponentNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecMetaDataComponentNameResponse
        /// </returns>
        public ExecMetaDataComponentNameResponse ExecMetaDataComponentName(ExecMetaDataComponentNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecMetaDataComponentNameWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a datasource with the specified name already exists under the current tenant. This operation is used as a pre-check before creating or renaming a datasource.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Checks whether a datasource name is already in use under the current tenant. This operation is used as a pre-check before creating a datasource or updating a datasource name.
        /// Datasource names must be unique within a tenant. If a name conflict exists, the creation request fails directly. Call this operation first to confirm that the name is available. This helps you avoid exposing conflicts only when you submit the creation request.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>dsName</c> specifies the datasource name to check. The system performs an exact match against non-deleted datasources under the current tenant. Prefix matching and fuzzy matching are not supported.</description></item>
        /// <item><description>The check scope is limited to the current tenant. Datasources with the same name under other tenants do not affect the result. Names of deleted datasources can be reused.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is a Boolean value that indicates the name check result: <c>true</c> indicates that a datasource with the same name already exists and the name is unavailable. <c>false</c> indicates that the name is not in use and can be used to create a datasource.
        /// Note that the semantics of <c>data</c> is opposite to that of <c>success</c>. If <c>success</c> is <c>true</c> and <c>data</c> is <c>true</c>, the call succeeded and a datasource with the same name was found. In this case, use a different name. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the call failure.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecMetaDataComponentNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecMetaDataComponentNameResponse
        /// </returns>
        public async Task<ExecMetaDataComponentNameResponse> ExecMetaDataComponentNameAsync(ExecMetaDataComponentNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecMetaDataComponentNameWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a single SQL script.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a synchronous conversion of a single SQL script. The parsing and rewriting are completed within a single call, and the SQL text in the target dialect is returned directly. This operation is suitable for manually verifying individual statements or validating conversion results. The conversion processes statements as query statements (DQL). To convert entire scripts or large files in batches, use the asynchronous script conversion task operation to avoid synchronous call timeouts.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects (such as hive or maxcompute), which determine the direction of the rewriting rules.</description></item>
        /// <item><description><c>sourceSqlScript</c> is the script content to be converted. It must be Base64-encoded before being passed in. The server decodes the content before performing the conversion. Passing in the raw text causes a decoding failure and prevents the conversion.</description></item>
        /// <item><description><c>tableMapping</c> is a list of table name mappings. Each element uses a comma (,) to separate the source table and target table (such as <c>src_table,dst_table</c>). Multiple mappings are merged by line breaks during conversion. If this parameter is not specified, the original table names in the script are used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the converted SQL script in the target dialect (string). If <c>success</c> is <c>true</c>, the conversion is complete. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. <c>requestId</c> is used to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecSqlTransSingleScriptTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecSqlTransSingleScriptTranslateResponse
        /// </returns>
        public ExecSqlTransSingleScriptTranslateResponse ExecSqlTransSingleScriptTranslateWithOptions(ExecSqlTransSingleScriptTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMapping))
            {
                body["tableMapping"] = request.TableMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecSqlTransSingleScriptTranslate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/translate-sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecSqlTransSingleScriptTranslateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a single SQL script.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a synchronous conversion of a single SQL script. The parsing and rewriting are completed within a single call, and the SQL text in the target dialect is returned directly. This operation is suitable for manually verifying individual statements or validating conversion results. The conversion processes statements as query statements (DQL). To convert entire scripts or large files in batches, use the asynchronous script conversion task operation to avoid synchronous call timeouts.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects (such as hive or maxcompute), which determine the direction of the rewriting rules.</description></item>
        /// <item><description><c>sourceSqlScript</c> is the script content to be converted. It must be Base64-encoded before being passed in. The server decodes the content before performing the conversion. Passing in the raw text causes a decoding failure and prevents the conversion.</description></item>
        /// <item><description><c>tableMapping</c> is a list of table name mappings. Each element uses a comma (,) to separate the source table and target table (such as <c>src_table,dst_table</c>). Multiple mappings are merged by line breaks during conversion. If this parameter is not specified, the original table names in the script are used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the converted SQL script in the target dialect (string). If <c>success</c> is <c>true</c>, the conversion is complete. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. <c>requestId</c> is used to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecSqlTransSingleScriptTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecSqlTransSingleScriptTranslateResponse
        /// </returns>
        public async Task<ExecSqlTransSingleScriptTranslateResponse> ExecSqlTransSingleScriptTranslateWithOptionsAsync(ExecSqlTransSingleScriptTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMapping))
            {
                body["tableMapping"] = request.TableMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecSqlTransSingleScriptTranslate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/translate-sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecSqlTransSingleScriptTranslateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a single SQL script.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a synchronous conversion of a single SQL script. The parsing and rewriting are completed within a single call, and the SQL text in the target dialect is returned directly. This operation is suitable for manually verifying individual statements or validating conversion results. The conversion processes statements as query statements (DQL). To convert entire scripts or large files in batches, use the asynchronous script conversion task operation to avoid synchronous call timeouts.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects (such as hive or maxcompute), which determine the direction of the rewriting rules.</description></item>
        /// <item><description><c>sourceSqlScript</c> is the script content to be converted. It must be Base64-encoded before being passed in. The server decodes the content before performing the conversion. Passing in the raw text causes a decoding failure and prevents the conversion.</description></item>
        /// <item><description><c>tableMapping</c> is a list of table name mappings. Each element uses a comma (,) to separate the source table and target table (such as <c>src_table,dst_table</c>). Multiple mappings are merged by line breaks during conversion. If this parameter is not specified, the original table names in the script are used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the converted SQL script in the target dialect (string). If <c>success</c> is <c>true</c>, the conversion is complete. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. <c>requestId</c> is used to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecSqlTransSingleScriptTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecSqlTransSingleScriptTranslateResponse
        /// </returns>
        public ExecSqlTransSingleScriptTranslateResponse ExecSqlTransSingleScriptTranslate(ExecSqlTransSingleScriptTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecSqlTransSingleScriptTranslateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a single SQL script.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a synchronous conversion of a single SQL script. The parsing and rewriting are completed within a single call, and the SQL text in the target dialect is returned directly. This operation is suitable for manually verifying individual statements or validating conversion results. The conversion processes statements as query statements (DQL). To convert entire scripts or large files in batches, use the asynchronous script conversion task operation to avoid synchronous call timeouts.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects (such as hive or maxcompute), which determine the direction of the rewriting rules.</description></item>
        /// <item><description><c>sourceSqlScript</c> is the script content to be converted. It must be Base64-encoded before being passed in. The server decodes the content before performing the conversion. Passing in the raw text causes a decoding failure and prevents the conversion.</description></item>
        /// <item><description><c>tableMapping</c> is a list of table name mappings. Each element uses a comma (,) to separate the source table and target table (such as <c>src_table,dst_table</c>). Multiple mappings are merged by line breaks during conversion. If this parameter is not specified, the original table names in the script are used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the converted SQL script in the target dialect (string). If <c>success</c> is <c>true</c>, the conversion is complete. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. <c>requestId</c> is used to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecSqlTransSingleScriptTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecSqlTransSingleScriptTranslateResponse
        /// </returns>
        public async Task<ExecSqlTransSingleScriptTranslateResponse> ExecSqlTransSingleScriptTranslateAsync(ExecSqlTransSingleScriptTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecSqlTransSingleScriptTranslateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the connectivity of a storage data source used for schedule migration. You can submit a workflow migration task only after the connectivity check is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Checks whether a storage data source used for schedule migration is reachable. Before submitting a workflow migration (write) task, call this operation to verify that the destination storage is accessible. This helps you identify connection issues before the task enters the write phase.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. The dsName, dsType, dsVersion, and dsConfig parameters together describe the data source to be checked. The dsConfig parameter is a JSON string whose structure is determined by dsType.</description></item>
        /// <item><description>If you specify id, the check is performed on a registered data source. The isModified parameter indicates whether the configuration has been modified, which tells the server to reconnect by using the new configuration.</description></item>
        /// <item><description>The check is performed in the schedule migration scenario and only determines whether the access capabilities required for this scenario are available.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>If the data source is reachable, success is set to true and data is set to true. If the data source is not reachable, the operation returns an error: errCode contains the data source connection error, and errMessage provides the specific failure reason. Use this information to check network reachability, account permissions, and dsConfig settings.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecWorkflowConnectivityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecWorkflowConnectivityResponse
        /// </returns>
        public ExecWorkflowConnectivityResponse ExecWorkflowConnectivityWithOptions(ExecWorkflowConnectivityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsConfig))
            {
                body["dsConfig"] = request.DsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsName))
            {
                body["dsName"] = request.DsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsType))
            {
                body["dsType"] = request.DsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsVersion))
            {
                body["dsVersion"] = request.DsVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsModified))
            {
                body["isModified"] = request.IsModified;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecWorkflowConnectivity",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component/workflow/connectivity",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecWorkflowConnectivityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the connectivity of a storage data source used for schedule migration. You can submit a workflow migration task only after the connectivity check is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Checks whether a storage data source used for schedule migration is reachable. Before submitting a workflow migration (write) task, call this operation to verify that the destination storage is accessible. This helps you identify connection issues before the task enters the write phase.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. The dsName, dsType, dsVersion, and dsConfig parameters together describe the data source to be checked. The dsConfig parameter is a JSON string whose structure is determined by dsType.</description></item>
        /// <item><description>If you specify id, the check is performed on a registered data source. The isModified parameter indicates whether the configuration has been modified, which tells the server to reconnect by using the new configuration.</description></item>
        /// <item><description>The check is performed in the schedule migration scenario and only determines whether the access capabilities required for this scenario are available.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>If the data source is reachable, success is set to true and data is set to true. If the data source is not reachable, the operation returns an error: errCode contains the data source connection error, and errMessage provides the specific failure reason. Use this information to check network reachability, account permissions, and dsConfig settings.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecWorkflowConnectivityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecWorkflowConnectivityResponse
        /// </returns>
        public async Task<ExecWorkflowConnectivityResponse> ExecWorkflowConnectivityWithOptionsAsync(ExecWorkflowConnectivityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsConfig))
            {
                body["dsConfig"] = request.DsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsName))
            {
                body["dsName"] = request.DsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsType))
            {
                body["dsType"] = request.DsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsVersion))
            {
                body["dsVersion"] = request.DsVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsModified))
            {
                body["isModified"] = request.IsModified;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecWorkflowConnectivity",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component/workflow/connectivity",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecWorkflowConnectivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the connectivity of a storage data source used for schedule migration. You can submit a workflow migration task only after the connectivity check is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Checks whether a storage data source used for schedule migration is reachable. Before submitting a workflow migration (write) task, call this operation to verify that the destination storage is accessible. This helps you identify connection issues before the task enters the write phase.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. The dsName, dsType, dsVersion, and dsConfig parameters together describe the data source to be checked. The dsConfig parameter is a JSON string whose structure is determined by dsType.</description></item>
        /// <item><description>If you specify id, the check is performed on a registered data source. The isModified parameter indicates whether the configuration has been modified, which tells the server to reconnect by using the new configuration.</description></item>
        /// <item><description>The check is performed in the schedule migration scenario and only determines whether the access capabilities required for this scenario are available.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>If the data source is reachable, success is set to true and data is set to true. If the data source is not reachable, the operation returns an error: errCode contains the data source connection error, and errMessage provides the specific failure reason. Use this information to check network reachability, account permissions, and dsConfig settings.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecWorkflowConnectivityRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecWorkflowConnectivityResponse
        /// </returns>
        public ExecWorkflowConnectivityResponse ExecWorkflowConnectivity(ExecWorkflowConnectivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecWorkflowConnectivityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the connectivity of a storage data source used for schedule migration. You can submit a workflow migration task only after the connectivity check is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Checks whether a storage data source used for schedule migration is reachable. Before submitting a workflow migration (write) task, call this operation to verify that the destination storage is accessible. This helps you identify connection issues before the task enters the write phase.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. The dsName, dsType, dsVersion, and dsConfig parameters together describe the data source to be checked. The dsConfig parameter is a JSON string whose structure is determined by dsType.</description></item>
        /// <item><description>If you specify id, the check is performed on a registered data source. The isModified parameter indicates whether the configuration has been modified, which tells the server to reconnect by using the new configuration.</description></item>
        /// <item><description>The check is performed in the schedule migration scenario and only determines whether the access capabilities required for this scenario are available.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>If the data source is reachable, success is set to true and data is set to true. If the data source is not reachable, the operation returns an error: errCode contains the data source connection error, and errMessage provides the specific failure reason. Use this information to check network reachability, account permissions, and dsConfig settings.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecWorkflowConnectivityRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecWorkflowConnectivityResponse
        /// </returns>
        public async Task<ExecWorkflowConnectivityResponse> ExecWorkflowConnectivityAsync(ExecWorkflowConnectivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecWorkflowConnectivityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the paging list of commit (write) instances for a scheduling migration node by node ID and status, and returns the transform and commit stage status of each instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the paging list of instances in the commit (write) stage for a scheduling migration node to view the transform and commit progress of each workflow instance on the destination. After a commit node is started, this operation serves as the primary entry point for tracking the execute results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the scheduling migration node ID.</description></item>
        /// <item><description><c>status</c> is optional and filters instances by instance status. If this parameter is not specified, instances in all statuses under the node are returned.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional and specify the page number and the number of entries per page. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A paging response is returned: <c>totalCount</c> indicates the total number of instances that meet the conditional criteria, <c>pageIndex</c> and <c>pageSize</c> echo the paging parameters of the current request, and <c>data</c> contains the instance list for the current page. Each list element includes the instance identity (<c>instanceId</c> and <c>instanceName</c>), the source scheduling information <c>srcMetaInfo</c> and its metadata update time <c>srcMetaGmtUpdate</c>, the transform execute time <c>gmtConvert</c>, the transform result <c>status</c>, and the transform failed reason <c>detail</c>. When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to troubleshoot the issue.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationSubmitInstanceListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationSubmitInstanceListResponse
        /// </returns>
        public GetBwmMigrationSubmitInstanceListResponse GetBwmMigrationSubmitInstanceListWithOptions(GetBwmMigrationSubmitInstanceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBwmMigrationSubmitInstanceList",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bwm/task/migration/submit/instances/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBwmMigrationSubmitInstanceListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the paging list of commit (write) instances for a scheduling migration node by node ID and status, and returns the transform and commit stage status of each instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the paging list of instances in the commit (write) stage for a scheduling migration node to view the transform and commit progress of each workflow instance on the destination. After a commit node is started, this operation serves as the primary entry point for tracking the execute results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the scheduling migration node ID.</description></item>
        /// <item><description><c>status</c> is optional and filters instances by instance status. If this parameter is not specified, instances in all statuses under the node are returned.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional and specify the page number and the number of entries per page. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A paging response is returned: <c>totalCount</c> indicates the total number of instances that meet the conditional criteria, <c>pageIndex</c> and <c>pageSize</c> echo the paging parameters of the current request, and <c>data</c> contains the instance list for the current page. Each list element includes the instance identity (<c>instanceId</c> and <c>instanceName</c>), the source scheduling information <c>srcMetaInfo</c> and its metadata update time <c>srcMetaGmtUpdate</c>, the transform execute time <c>gmtConvert</c>, the transform result <c>status</c>, and the transform failed reason <c>detail</c>. When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to troubleshoot the issue.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationSubmitInstanceListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationSubmitInstanceListResponse
        /// </returns>
        public async Task<GetBwmMigrationSubmitInstanceListResponse> GetBwmMigrationSubmitInstanceListWithOptionsAsync(GetBwmMigrationSubmitInstanceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBwmMigrationSubmitInstanceList",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bwm/task/migration/submit/instances/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBwmMigrationSubmitInstanceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the paging list of commit (write) instances for a scheduling migration node by node ID and status, and returns the transform and commit stage status of each instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the paging list of instances in the commit (write) stage for a scheduling migration node to view the transform and commit progress of each workflow instance on the destination. After a commit node is started, this operation serves as the primary entry point for tracking the execute results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the scheduling migration node ID.</description></item>
        /// <item><description><c>status</c> is optional and filters instances by instance status. If this parameter is not specified, instances in all statuses under the node are returned.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional and specify the page number and the number of entries per page. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A paging response is returned: <c>totalCount</c> indicates the total number of instances that meet the conditional criteria, <c>pageIndex</c> and <c>pageSize</c> echo the paging parameters of the current request, and <c>data</c> contains the instance list for the current page. Each list element includes the instance identity (<c>instanceId</c> and <c>instanceName</c>), the source scheduling information <c>srcMetaInfo</c> and its metadata update time <c>srcMetaGmtUpdate</c>, the transform execute time <c>gmtConvert</c>, the transform result <c>status</c>, and the transform failed reason <c>detail</c>. When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to troubleshoot the issue.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationSubmitInstanceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationSubmitInstanceListResponse
        /// </returns>
        public GetBwmMigrationSubmitInstanceListResponse GetBwmMigrationSubmitInstanceList(GetBwmMigrationSubmitInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBwmMigrationSubmitInstanceListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the paging list of commit (write) instances for a scheduling migration node by node ID and status, and returns the transform and commit stage status of each instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the paging list of instances in the commit (write) stage for a scheduling migration node to view the transform and commit progress of each workflow instance on the destination. After a commit node is started, this operation serves as the primary entry point for tracking the execute results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the scheduling migration node ID.</description></item>
        /// <item><description><c>status</c> is optional and filters instances by instance status. If this parameter is not specified, instances in all statuses under the node are returned.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional and specify the page number and the number of entries per page. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A paging response is returned: <c>totalCount</c> indicates the total number of instances that meet the conditional criteria, <c>pageIndex</c> and <c>pageSize</c> echo the paging parameters of the current request, and <c>data</c> contains the instance list for the current page. Each list element includes the instance identity (<c>instanceId</c> and <c>instanceName</c>), the source scheduling information <c>srcMetaInfo</c> and its metadata update time <c>srcMetaGmtUpdate</c>, the transform execute time <c>gmtConvert</c>, the transform result <c>status</c>, and the transform failed reason <c>detail</c>. When <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to troubleshoot the issue.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationSubmitInstanceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationSubmitInstanceListResponse
        /// </returns>
        public async Task<GetBwmMigrationSubmitInstanceListResponse> GetBwmMigrationSubmitInstanceListAsync(GetBwmMigrationSubmitInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBwmMigrationSubmitInstanceListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the result package of a write task by instance ID for offline viewing of complete batch write results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Exports the result package of the write phase for a scheduling migration by commit instance, and returns the download URL of the result package. This allows you to view the complete batch write result details offline. The write result package and the transform result package share the same export capability with consistent field definitions.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> is required. It specifies the commit instance identity for which to export the result package. You can obtain this identity from the list commit instances operation.</description></item>
        /// <item><description>Each invocation exports the result package for only one instance. To export result packages for multiple instances, invoke this operation separately for each instance.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the result package URL (character string). Use this URL to download the complete result file. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. <c>requestId</c> can be used to troubleshoot the invocation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationTaskWriterResultPackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationTaskWriterResultPackageResponse
        /// </returns>
        public GetBwmMigrationTaskWriterResultPackageResponse GetBwmMigrationTaskWriterResultPackageWithOptions(GetBwmMigrationTaskWriterResultPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBwmMigrationTaskWriterResultPackage",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bwm/task/migration/write/result/export/package",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBwmMigrationTaskWriterResultPackageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the result package of a write task by instance ID for offline viewing of complete batch write results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Exports the result package of the write phase for a scheduling migration by commit instance, and returns the download URL of the result package. This allows you to view the complete batch write result details offline. The write result package and the transform result package share the same export capability with consistent field definitions.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> is required. It specifies the commit instance identity for which to export the result package. You can obtain this identity from the list commit instances operation.</description></item>
        /// <item><description>Each invocation exports the result package for only one instance. To export result packages for multiple instances, invoke this operation separately for each instance.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the result package URL (character string). Use this URL to download the complete result file. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. <c>requestId</c> can be used to troubleshoot the invocation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationTaskWriterResultPackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationTaskWriterResultPackageResponse
        /// </returns>
        public async Task<GetBwmMigrationTaskWriterResultPackageResponse> GetBwmMigrationTaskWriterResultPackageWithOptionsAsync(GetBwmMigrationTaskWriterResultPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBwmMigrationTaskWriterResultPackage",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bwm/task/migration/write/result/export/package",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBwmMigrationTaskWriterResultPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the result package of a write task by instance ID for offline viewing of complete batch write results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Exports the result package of the write phase for a scheduling migration by commit instance, and returns the download URL of the result package. This allows you to view the complete batch write result details offline. The write result package and the transform result package share the same export capability with consistent field definitions.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> is required. It specifies the commit instance identity for which to export the result package. You can obtain this identity from the list commit instances operation.</description></item>
        /// <item><description>Each invocation exports the result package for only one instance. To export result packages for multiple instances, invoke this operation separately for each instance.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the result package URL (character string). Use this URL to download the complete result file. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. <c>requestId</c> can be used to troubleshoot the invocation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationTaskWriterResultPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationTaskWriterResultPackageResponse
        /// </returns>
        public GetBwmMigrationTaskWriterResultPackageResponse GetBwmMigrationTaskWriterResultPackage(GetBwmMigrationTaskWriterResultPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBwmMigrationTaskWriterResultPackageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the result package of a write task by instance ID for offline viewing of complete batch write results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Exports the result package of the write phase for a scheduling migration by commit instance, and returns the download URL of the result package. This allows you to view the complete batch write result details offline. The write result package and the transform result package share the same export capability with consistent field definitions.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> is required. It specifies the commit instance identity for which to export the result package. You can obtain this identity from the list commit instances operation.</description></item>
        /// <item><description>Each invocation exports the result package for only one instance. To export result packages for multiple instances, invoke this operation separately for each instance.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the result package URL (character string). Use this URL to download the complete result file. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. <c>requestId</c> can be used to troubleshoot the invocation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationTaskWriterResultPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationTaskWriterResultPackageResponse
        /// </returns>
        public async Task<GetBwmMigrationTaskWriterResultPackageResponse> GetBwmMigrationTaskWriterResultPackageAsync(GetBwmMigrationTaskWriterResultPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBwmMigrationTaskWriterResultPackageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query on the details of workflows in a write (or publish) report by instance ID with paging. Supports filtering by workflow name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a paged query on workflow details in a write report by commit instance with paging. Supports filtering by name. Use this operation to verify the commit status, target workflow identity, and failure reason for each workflow on the target side. This operation is shared by write reports and publish reports.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> is required and specifies the commit instance identity.</description></item>
        /// <item><description><c>workflowName</c> is optional and filters by workflow name to quickly locate a specific workflow within an instance.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. The default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response: <c>totalCount</c> is the total number of workflows that match the filter conditions, and <c>data</c> contains the details of the current page. Each element in the list contains the source workflow identifier and name (<c>workflowId</c>, <c>workflowName</c>), the scheduling expression <c>cron</c>, the node count <c>taskNodeCount</c>, the submit status <c>submitStatus</c> (WRT_INIT: submit not started, WRT_RUN: submitting, WRT_SUCC: all submitted successfully, WRT_FAIL: all submissions failed, WRT_PART_FAIL: some submissions failed, DPY_SUCC: published successfully, DPY_FAIL: publish failed), the submit failure message <c>submitDetail</c>, and the target workflow name and identifier (<c>targetWorkflowName</c>, <c>targetWorkflowId</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationTaskWriterWorkflowListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationTaskWriterWorkflowListResponse
        /// </returns>
        public GetBwmMigrationTaskWriterWorkflowListResponse GetBwmMigrationTaskWriterWorkflowListWithOptions(GetBwmMigrationTaskWriterWorkflowListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowName))
            {
                query["workflowName"] = request.WorkflowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBwmMigrationTaskWriterWorkflowList",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bwm/task/migration/write/result/workflow/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBwmMigrationTaskWriterWorkflowListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query on the details of workflows in a write (or publish) report by instance ID with paging. Supports filtering by workflow name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a paged query on workflow details in a write report by commit instance with paging. Supports filtering by name. Use this operation to verify the commit status, target workflow identity, and failure reason for each workflow on the target side. This operation is shared by write reports and publish reports.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> is required and specifies the commit instance identity.</description></item>
        /// <item><description><c>workflowName</c> is optional and filters by workflow name to quickly locate a specific workflow within an instance.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. The default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response: <c>totalCount</c> is the total number of workflows that match the filter conditions, and <c>data</c> contains the details of the current page. Each element in the list contains the source workflow identifier and name (<c>workflowId</c>, <c>workflowName</c>), the scheduling expression <c>cron</c>, the node count <c>taskNodeCount</c>, the submit status <c>submitStatus</c> (WRT_INIT: submit not started, WRT_RUN: submitting, WRT_SUCC: all submitted successfully, WRT_FAIL: all submissions failed, WRT_PART_FAIL: some submissions failed, DPY_SUCC: published successfully, DPY_FAIL: publish failed), the submit failure message <c>submitDetail</c>, and the target workflow name and identifier (<c>targetWorkflowName</c>, <c>targetWorkflowId</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationTaskWriterWorkflowListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationTaskWriterWorkflowListResponse
        /// </returns>
        public async Task<GetBwmMigrationTaskWriterWorkflowListResponse> GetBwmMigrationTaskWriterWorkflowListWithOptionsAsync(GetBwmMigrationTaskWriterWorkflowListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowName))
            {
                query["workflowName"] = request.WorkflowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBwmMigrationTaskWriterWorkflowList",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bwm/task/migration/write/result/workflow/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBwmMigrationTaskWriterWorkflowListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query on the details of workflows in a write (or publish) report by instance ID with paging. Supports filtering by workflow name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a paged query on workflow details in a write report by commit instance with paging. Supports filtering by name. Use this operation to verify the commit status, target workflow identity, and failure reason for each workflow on the target side. This operation is shared by write reports and publish reports.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> is required and specifies the commit instance identity.</description></item>
        /// <item><description><c>workflowName</c> is optional and filters by workflow name to quickly locate a specific workflow within an instance.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. The default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response: <c>totalCount</c> is the total number of workflows that match the filter conditions, and <c>data</c> contains the details of the current page. Each element in the list contains the source workflow identifier and name (<c>workflowId</c>, <c>workflowName</c>), the scheduling expression <c>cron</c>, the node count <c>taskNodeCount</c>, the submit status <c>submitStatus</c> (WRT_INIT: submit not started, WRT_RUN: submitting, WRT_SUCC: all submitted successfully, WRT_FAIL: all submissions failed, WRT_PART_FAIL: some submissions failed, DPY_SUCC: published successfully, DPY_FAIL: publish failed), the submit failure message <c>submitDetail</c>, and the target workflow name and identifier (<c>targetWorkflowName</c>, <c>targetWorkflowId</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationTaskWriterWorkflowListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationTaskWriterWorkflowListResponse
        /// </returns>
        public GetBwmMigrationTaskWriterWorkflowListResponse GetBwmMigrationTaskWriterWorkflowList(GetBwmMigrationTaskWriterWorkflowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBwmMigrationTaskWriterWorkflowListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query on the details of workflows in a write (or publish) report by instance ID with paging. Supports filtering by workflow name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a paged query on workflow details in a write report by commit instance with paging. Supports filtering by name. Use this operation to verify the commit status, target workflow identity, and failure reason for each workflow on the target side. This operation is shared by write reports and publish reports.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>instanceId</c> is required and specifies the commit instance identity.</description></item>
        /// <item><description><c>workflowName</c> is optional and filters by workflow name to quickly locate a specific workflow within an instance.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. The default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response: <c>totalCount</c> is the total number of workflows that match the filter conditions, and <c>data</c> contains the details of the current page. Each element in the list contains the source workflow identifier and name (<c>workflowId</c>, <c>workflowName</c>), the scheduling expression <c>cron</c>, the node count <c>taskNodeCount</c>, the submit status <c>submitStatus</c> (WRT_INIT: submit not started, WRT_RUN: submitting, WRT_SUCC: all submitted successfully, WRT_FAIL: all submissions failed, WRT_PART_FAIL: some submissions failed, DPY_SUCC: published successfully, DPY_FAIL: publish failed), the submit failure message <c>submitDetail</c>, and the target workflow name and identifier (<c>targetWorkflowName</c>, <c>targetWorkflowId</c>).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationTaskWriterWorkflowListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationTaskWriterWorkflowListResponse
        /// </returns>
        public async Task<GetBwmMigrationTaskWriterWorkflowListResponse> GetBwmMigrationTaskWriterWorkflowListAsync(GetBwmMigrationTaskWriterWorkflowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBwmMigrationTaskWriterWorkflowListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a schedule import (write) task by task ID to batch import converted workflows into the destination scheduling system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Starts the submit (write) action sequence for a scheduling migration task to batch import converted workflows into the destination scheduling system. The start operation is asynchronous: a successful call only indicates that the write process has been triggered. To check the progress, query the submit instance list and workflow details.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the scheduling migration task ID.</description></item>
        /// <item><description>This operation triggers the write sequence for the entire task at once. You do not need to submit workflows one by one.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is a fixed integer value of <c>0</c>, which only indicates that the start request has been accepted. It does not indicate that the import is complete or the number of imported workflows. To check the import result, query the submit instance list and workflow details. If <c>success</c> is <c>false</c>, troubleshoot the issue based on <c>errCode</c> and <c>errMessage</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationWorkflowSubmitStartRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationWorkflowSubmitStartResponse
        /// </returns>
        public GetBwmMigrationWorkflowSubmitStartResponse GetBwmMigrationWorkflowSubmitStartWithOptions(GetBwmMigrationWorkflowSubmitStartRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBwmMigrationWorkflowSubmitStart",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bwm/task/migration/submit/start",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBwmMigrationWorkflowSubmitStartResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a schedule import (write) task by task ID to batch import converted workflows into the destination scheduling system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Starts the submit (write) action sequence for a scheduling migration task to batch import converted workflows into the destination scheduling system. The start operation is asynchronous: a successful call only indicates that the write process has been triggered. To check the progress, query the submit instance list and workflow details.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the scheduling migration task ID.</description></item>
        /// <item><description>This operation triggers the write sequence for the entire task at once. You do not need to submit workflows one by one.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is a fixed integer value of <c>0</c>, which only indicates that the start request has been accepted. It does not indicate that the import is complete or the number of imported workflows. To check the import result, query the submit instance list and workflow details. If <c>success</c> is <c>false</c>, troubleshoot the issue based on <c>errCode</c> and <c>errMessage</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationWorkflowSubmitStartRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationWorkflowSubmitStartResponse
        /// </returns>
        public async Task<GetBwmMigrationWorkflowSubmitStartResponse> GetBwmMigrationWorkflowSubmitStartWithOptionsAsync(GetBwmMigrationWorkflowSubmitStartRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBwmMigrationWorkflowSubmitStart",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bwm/task/migration/submit/start",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBwmMigrationWorkflowSubmitStartResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a schedule import (write) task by task ID to batch import converted workflows into the destination scheduling system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Starts the submit (write) action sequence for a scheduling migration task to batch import converted workflows into the destination scheduling system. The start operation is asynchronous: a successful call only indicates that the write process has been triggered. To check the progress, query the submit instance list and workflow details.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the scheduling migration task ID.</description></item>
        /// <item><description>This operation triggers the write sequence for the entire task at once. You do not need to submit workflows one by one.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is a fixed integer value of <c>0</c>, which only indicates that the start request has been accepted. It does not indicate that the import is complete or the number of imported workflows. To check the import result, query the submit instance list and workflow details. If <c>success</c> is <c>false</c>, troubleshoot the issue based on <c>errCode</c> and <c>errMessage</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationWorkflowSubmitStartRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationWorkflowSubmitStartResponse
        /// </returns>
        public GetBwmMigrationWorkflowSubmitStartResponse GetBwmMigrationWorkflowSubmitStart(GetBwmMigrationWorkflowSubmitStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBwmMigrationWorkflowSubmitStartWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a schedule import (write) task by task ID to batch import converted workflows into the destination scheduling system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Starts the submit (write) action sequence for a scheduling migration task to batch import converted workflows into the destination scheduling system. The start operation is asynchronous: a successful call only indicates that the write process has been triggered. To check the progress, query the submit instance list and workflow details.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the scheduling migration task ID.</description></item>
        /// <item><description>This operation triggers the write sequence for the entire task at once. You do not need to submit workflows one by one.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is a fixed integer value of <c>0</c>, which only indicates that the start request has been accepted. It does not indicate that the import is complete or the number of imported workflows. To check the import result, query the submit instance list and workflow details. If <c>success</c> is <c>false</c>, troubleshoot the issue based on <c>errCode</c> and <c>errMessage</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBwmMigrationWorkflowSubmitStartRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBwmMigrationWorkflowSubmitStartResponse
        /// </returns>
        public async Task<GetBwmMigrationWorkflowSubmitStartResponse> GetBwmMigrationWorkflowSubmitStartAsync(GetBwmMigrationWorkflowSubmitStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBwmMigrationWorkflowSubmitStartWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calculates and returns the next 5 execute times based on a Cron expression, allowing you to verify that a validation rule is correct before configuring a scheduled data validation task. This is a general-purpose operation that does not require authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Calculates and returns the next 5 execution times based on a Cron expression. Use this operation to confirm that the expression matches the expected schedule before configuring a scheduling rule for a data validation task. This helps you avoid discovering scheduling errors only after the configuration takes effect.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>cronRule is required and must be a Cron expression. When passed as a query parameter, replace spaces in the expression with plus signs <c>+</c>. For example, <c>0+0+0+*+*+?</c> indicates execution at midnight every day.</description></item>
        /// <item><description>The server validates the expression first. If the expression is invalid, an error is returned directly without an execution time list.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. The data field contains 5 execution times (strings) sorted in chronological order. If success is <c>false</c>, the expression is invalid or the calculation failed. Use errCode and errMessage to troubleshoot. Use requestId to trace the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCronExecTimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCronExecTimeResponse
        /// </returns>
        public GetCronExecTimeResponse GetCronExecTimeWithOptions(GetCronExecTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronRule))
            {
                query["cronRule"] = request.CronRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCronExecTime",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/cron/exeTime",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCronExecTimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calculates and returns the next 5 execute times based on a Cron expression, allowing you to verify that a validation rule is correct before configuring a scheduled data validation task. This is a general-purpose operation that does not require authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Calculates and returns the next 5 execution times based on a Cron expression. Use this operation to confirm that the expression matches the expected schedule before configuring a scheduling rule for a data validation task. This helps you avoid discovering scheduling errors only after the configuration takes effect.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>cronRule is required and must be a Cron expression. When passed as a query parameter, replace spaces in the expression with plus signs <c>+</c>. For example, <c>0+0+0+*+*+?</c> indicates execution at midnight every day.</description></item>
        /// <item><description>The server validates the expression first. If the expression is invalid, an error is returned directly without an execution time list.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. The data field contains 5 execution times (strings) sorted in chronological order. If success is <c>false</c>, the expression is invalid or the calculation failed. Use errCode and errMessage to troubleshoot. Use requestId to trace the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCronExecTimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCronExecTimeResponse
        /// </returns>
        public async Task<GetCronExecTimeResponse> GetCronExecTimeWithOptionsAsync(GetCronExecTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronRule))
            {
                query["cronRule"] = request.CronRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCronExecTime",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/cron/exeTime",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCronExecTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calculates and returns the next 5 execute times based on a Cron expression, allowing you to verify that a validation rule is correct before configuring a scheduled data validation task. This is a general-purpose operation that does not require authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Calculates and returns the next 5 execution times based on a Cron expression. Use this operation to confirm that the expression matches the expected schedule before configuring a scheduling rule for a data validation task. This helps you avoid discovering scheduling errors only after the configuration takes effect.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>cronRule is required and must be a Cron expression. When passed as a query parameter, replace spaces in the expression with plus signs <c>+</c>. For example, <c>0+0+0+*+*+?</c> indicates execution at midnight every day.</description></item>
        /// <item><description>The server validates the expression first. If the expression is invalid, an error is returned directly without an execution time list.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. The data field contains 5 execution times (strings) sorted in chronological order. If success is <c>false</c>, the expression is invalid or the calculation failed. Use errCode and errMessage to troubleshoot. Use requestId to trace the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCronExecTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCronExecTimeResponse
        /// </returns>
        public GetCronExecTimeResponse GetCronExecTime(GetCronExecTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCronExecTimeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calculates and returns the next 5 execute times based on a Cron expression, allowing you to verify that a validation rule is correct before configuring a scheduled data validation task. This is a general-purpose operation that does not require authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Calculates and returns the next 5 execution times based on a Cron expression. Use this operation to confirm that the expression matches the expected schedule before configuring a scheduling rule for a data validation task. This helps you avoid discovering scheduling errors only after the configuration takes effect.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>cronRule is required and must be a Cron expression. When passed as a query parameter, replace spaces in the expression with plus signs <c>+</c>. For example, <c>0+0+0+*+*+?</c> indicates execution at midnight every day.</description></item>
        /// <item><description>The server validates the expression first. If the expression is invalid, an error is returned directly without an execution time list.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. The data field contains 5 execution times (strings) sorted in chronological order. If success is <c>false</c>, the expression is invalid or the calculation failed. Use errCode and errMessage to troubleshoot. Use requestId to trace the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCronExecTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCronExecTimeResponse
        /// </returns>
        public async Task<GetCronExecTimeResponse> GetCronExecTimeAsync(GetCronExecTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCronExecTimeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the table detail configurations of a data validation task by task ID, and returns the tables to be validated, validation scope, and comparison rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the detail configuration list of tables to be validated for a data validation task. All results are returned at once without pagination. Use this operation to view the source tables and destination tables configured for the task, the scope of comparison, and the comparison rules. This is the primary entry point for verifying configurations before executing a validation task.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId is required. It specifies the ID of the data validation task, which is obtained from the response of the operation that creates a data validation task.</description></item>
        /// <item><description>A single call returns all table detail configurations under the specified task. If no table details are configured for the task, an empty list is returned.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. Each element in data represents a table detail configuration, which contains the configuration ID, the associated task and validation type, the data source, table name, fields, partitions, WHERE and GROUP conditions, hints, and comparison keys for both the source and destination. It also contains comparison rule-related fields: totalCountThreshold for the total data volume threshold, groupCountThreshold for the grouped data volume threshold, batchSize for the batch size, algorithm for the validation algorithm, comparator for the comparison type, metricType for the metric type, isFullTableCount for whether full-table comparison is enabled, and isSkipped for whether the configuration is skipped. If success is false, troubleshoot the issue based on errCode and errMessage.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckConfigResponse
        /// </returns>
        public GetDataCheckConfigResponse GetDataCheckConfigWithOptions(GetDataCheckConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/getConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the table detail configurations of a data validation task by task ID, and returns the tables to be validated, validation scope, and comparison rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the detail configuration list of tables to be validated for a data validation task. All results are returned at once without pagination. Use this operation to view the source tables and destination tables configured for the task, the scope of comparison, and the comparison rules. This is the primary entry point for verifying configurations before executing a validation task.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId is required. It specifies the ID of the data validation task, which is obtained from the response of the operation that creates a data validation task.</description></item>
        /// <item><description>A single call returns all table detail configurations under the specified task. If no table details are configured for the task, an empty list is returned.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. Each element in data represents a table detail configuration, which contains the configuration ID, the associated task and validation type, the data source, table name, fields, partitions, WHERE and GROUP conditions, hints, and comparison keys for both the source and destination. It also contains comparison rule-related fields: totalCountThreshold for the total data volume threshold, groupCountThreshold for the grouped data volume threshold, batchSize for the batch size, algorithm for the validation algorithm, comparator for the comparison type, metricType for the metric type, isFullTableCount for whether full-table comparison is enabled, and isSkipped for whether the configuration is skipped. If success is false, troubleshoot the issue based on errCode and errMessage.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckConfigResponse
        /// </returns>
        public async Task<GetDataCheckConfigResponse> GetDataCheckConfigWithOptionsAsync(GetDataCheckConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/getConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the table detail configurations of a data validation task by task ID, and returns the tables to be validated, validation scope, and comparison rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the detail configuration list of tables to be validated for a data validation task. All results are returned at once without pagination. Use this operation to view the source tables and destination tables configured for the task, the scope of comparison, and the comparison rules. This is the primary entry point for verifying configurations before executing a validation task.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId is required. It specifies the ID of the data validation task, which is obtained from the response of the operation that creates a data validation task.</description></item>
        /// <item><description>A single call returns all table detail configurations under the specified task. If no table details are configured for the task, an empty list is returned.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. Each element in data represents a table detail configuration, which contains the configuration ID, the associated task and validation type, the data source, table name, fields, partitions, WHERE and GROUP conditions, hints, and comparison keys for both the source and destination. It also contains comparison rule-related fields: totalCountThreshold for the total data volume threshold, groupCountThreshold for the grouped data volume threshold, batchSize for the batch size, algorithm for the validation algorithm, comparator for the comparison type, metricType for the metric type, isFullTableCount for whether full-table comparison is enabled, and isSkipped for whether the configuration is skipped. If success is false, troubleshoot the issue based on errCode and errMessage.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckConfigResponse
        /// </returns>
        public GetDataCheckConfigResponse GetDataCheckConfig(GetDataCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataCheckConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the table detail configurations of a data validation task by task ID, and returns the tables to be validated, validation scope, and comparison rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the detail configuration list of tables to be validated for a data validation task. All results are returned at once without pagination. Use this operation to view the source tables and destination tables configured for the task, the scope of comparison, and the comparison rules. This is the primary entry point for verifying configurations before executing a validation task.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId is required. It specifies the ID of the data validation task, which is obtained from the response of the operation that creates a data validation task.</description></item>
        /// <item><description>A single call returns all table detail configurations under the specified task. If no table details are configured for the task, an empty list is returned.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. Each element in data represents a table detail configuration, which contains the configuration ID, the associated task and validation type, the data source, table name, fields, partitions, WHERE and GROUP conditions, hints, and comparison keys for both the source and destination. It also contains comparison rule-related fields: totalCountThreshold for the total data volume threshold, groupCountThreshold for the grouped data volume threshold, batchSize for the batch size, algorithm for the validation algorithm, comparator for the comparison type, metricType for the metric type, isFullTableCount for whether full-table comparison is enabled, and isSkipped for whether the configuration is skipped. If success is false, troubleshoot the issue based on errCode and errMessage.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckConfigResponse
        /// </returns>
        public async Task<GetDataCheckConfigResponse> GetDataCheckConfigAsync(GetDataCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataCheckConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the overview of a data validation report by validation batch, and returns summary metrics such as the number of validated tables, passed tables, and pass rate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the overview of a data validation report by validation batch. The response includes the number of tables validated in this batch, the number of tables that passed, the pass rate, partition-level and field-level statistics, and the report generation status. This operation serves as the primary entry point for viewing validation conclusions. To obtain table-level details, call the report instance or column-level result operations.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required. It specifies the ID of the validation job (batch), which is returned by the operation that saves a validation task. Subsequent operations for execution, stopping, rerunning, and reporting all reference the same validation by this ID.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value object. The <c>data</c> field is the overview object: <c>checkType</c> indicates the validation type (0: data volume comparison, 1: metric comparison, 2: weak content comparison). <c>checkResult</c> indicates the validation result (0: no records, 1: passed, 2: not passed). <c>reportStatus</c> indicates the report generation status (0: not generated, 1: generating, 2: generated). <c>reportGenerateMessage</c> provides a message about the generation progress. The statistics section includes the number of validated tables, tables with errors, tables that passed, skipped tables and partitions, validated partitions, validated rows and passed rows, pass rate (<c>passProcess</c> as a decimal and <c>passProcessExport</c> as a percentage string), field-level validation count and pass count, source and destination data source information, associated task identifiers and timestamps, and template information for metric validation scenarios.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckReportOverviewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckReportOverviewResponse
        /// </returns>
        public GetDataCheckReportOverviewResponse GetDataCheckReportOverviewWithOptions(GetDataCheckReportOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckReportOverview",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/overview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckReportOverviewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the overview of a data validation report by validation batch, and returns summary metrics such as the number of validated tables, passed tables, and pass rate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the overview of a data validation report by validation batch. The response includes the number of tables validated in this batch, the number of tables that passed, the pass rate, partition-level and field-level statistics, and the report generation status. This operation serves as the primary entry point for viewing validation conclusions. To obtain table-level details, call the report instance or column-level result operations.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required. It specifies the ID of the validation job (batch), which is returned by the operation that saves a validation task. Subsequent operations for execution, stopping, rerunning, and reporting all reference the same validation by this ID.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value object. The <c>data</c> field is the overview object: <c>checkType</c> indicates the validation type (0: data volume comparison, 1: metric comparison, 2: weak content comparison). <c>checkResult</c> indicates the validation result (0: no records, 1: passed, 2: not passed). <c>reportStatus</c> indicates the report generation status (0: not generated, 1: generating, 2: generated). <c>reportGenerateMessage</c> provides a message about the generation progress. The statistics section includes the number of validated tables, tables with errors, tables that passed, skipped tables and partitions, validated partitions, validated rows and passed rows, pass rate (<c>passProcess</c> as a decimal and <c>passProcessExport</c> as a percentage string), field-level validation count and pass count, source and destination data source information, associated task identifiers and timestamps, and template information for metric validation scenarios.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckReportOverviewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckReportOverviewResponse
        /// </returns>
        public async Task<GetDataCheckReportOverviewResponse> GetDataCheckReportOverviewWithOptionsAsync(GetDataCheckReportOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckReportOverview",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/overview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckReportOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the overview of a data validation report by validation batch, and returns summary metrics such as the number of validated tables, passed tables, and pass rate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the overview of a data validation report by validation batch. The response includes the number of tables validated in this batch, the number of tables that passed, the pass rate, partition-level and field-level statistics, and the report generation status. This operation serves as the primary entry point for viewing validation conclusions. To obtain table-level details, call the report instance or column-level result operations.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required. It specifies the ID of the validation job (batch), which is returned by the operation that saves a validation task. Subsequent operations for execution, stopping, rerunning, and reporting all reference the same validation by this ID.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value object. The <c>data</c> field is the overview object: <c>checkType</c> indicates the validation type (0: data volume comparison, 1: metric comparison, 2: weak content comparison). <c>checkResult</c> indicates the validation result (0: no records, 1: passed, 2: not passed). <c>reportStatus</c> indicates the report generation status (0: not generated, 1: generating, 2: generated). <c>reportGenerateMessage</c> provides a message about the generation progress. The statistics section includes the number of validated tables, tables with errors, tables that passed, skipped tables and partitions, validated partitions, validated rows and passed rows, pass rate (<c>passProcess</c> as a decimal and <c>passProcessExport</c> as a percentage string), field-level validation count and pass count, source and destination data source information, associated task identifiers and timestamps, and template information for metric validation scenarios.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckReportOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckReportOverviewResponse
        /// </returns>
        public GetDataCheckReportOverviewResponse GetDataCheckReportOverview(GetDataCheckReportOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataCheckReportOverviewWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the overview of a data validation report by validation batch, and returns summary metrics such as the number of validated tables, passed tables, and pass rate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the overview of a data validation report by validation batch. The response includes the number of tables validated in this batch, the number of tables that passed, the pass rate, partition-level and field-level statistics, and the report generation status. This operation serves as the primary entry point for viewing validation conclusions. To obtain table-level details, call the report instance or column-level result operations.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required. It specifies the ID of the validation job (batch), which is returned by the operation that saves a validation task. Subsequent operations for execution, stopping, rerunning, and reporting all reference the same validation by this ID.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value object. The <c>data</c> field is the overview object: <c>checkType</c> indicates the validation type (0: data volume comparison, 1: metric comparison, 2: weak content comparison). <c>checkResult</c> indicates the validation result (0: no records, 1: passed, 2: not passed). <c>reportStatus</c> indicates the report generation status (0: not generated, 1: generating, 2: generated). <c>reportGenerateMessage</c> provides a message about the generation progress. The statistics section includes the number of validated tables, tables with errors, tables that passed, skipped tables and partitions, validated partitions, validated rows and passed rows, pass rate (<c>passProcess</c> as a decimal and <c>passProcessExport</c> as a percentage string), field-level validation count and pass count, source and destination data source information, associated task identifiers and timestamps, and template information for metric validation scenarios.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckReportOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckReportOverviewResponse
        /// </returns>
        public async Task<GetDataCheckReportOverviewResponse> GetDataCheckReportOverviewAsync(GetDataCheckReportOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataCheckReportOverviewWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the generation status (not generated, generating, or generated) and generation information of a report for a specified validation batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the generation status of a data validation report by validation batch. Use this operation to poll the progress after triggering report generation. Report generation is an asynchronous process. The report overview and report details operations return complete data only after the status changes to generated.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required. It is the validation batch ID, obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>Each call queries the status of only one batch. When the report is being generated, call this operation repeatedly at intervals to refresh the status.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is the report generation status code: <c>0</c> for not generated, <c>1</c> for generating, <c>2</c> for generated, and <c>3</c> for generation failed. After the status changes to generated, you can query the report overview and details. If the status is generation failed, troubleshoot the issue based on <c>errCode</c> and <c>errMessage</c>, and re-trigger report generation if necessary.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckReportStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckReportStatusResponse
        /// </returns>
        public GetDataCheckReportStatusResponse GetDataCheckReportStatusWithOptions(GetDataCheckReportStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckReportStatus",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/getReportStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckReportStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the generation status (not generated, generating, or generated) and generation information of a report for a specified validation batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the generation status of a data validation report by validation batch. Use this operation to poll the progress after triggering report generation. Report generation is an asynchronous process. The report overview and report details operations return complete data only after the status changes to generated.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required. It is the validation batch ID, obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>Each call queries the status of only one batch. When the report is being generated, call this operation repeatedly at intervals to refresh the status.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is the report generation status code: <c>0</c> for not generated, <c>1</c> for generating, <c>2</c> for generated, and <c>3</c> for generation failed. After the status changes to generated, you can query the report overview and details. If the status is generation failed, troubleshoot the issue based on <c>errCode</c> and <c>errMessage</c>, and re-trigger report generation if necessary.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckReportStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckReportStatusResponse
        /// </returns>
        public async Task<GetDataCheckReportStatusResponse> GetDataCheckReportStatusWithOptionsAsync(GetDataCheckReportStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckReportStatus",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/getReportStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckReportStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the generation status (not generated, generating, or generated) and generation information of a report for a specified validation batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the generation status of a data validation report by validation batch. Use this operation to poll the progress after triggering report generation. Report generation is an asynchronous process. The report overview and report details operations return complete data only after the status changes to generated.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required. It is the validation batch ID, obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>Each call queries the status of only one batch. When the report is being generated, call this operation repeatedly at intervals to refresh the status.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is the report generation status code: <c>0</c> for not generated, <c>1</c> for generating, <c>2</c> for generated, and <c>3</c> for generation failed. After the status changes to generated, you can query the report overview and details. If the status is generation failed, troubleshoot the issue based on <c>errCode</c> and <c>errMessage</c>, and re-trigger report generation if necessary.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckReportStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckReportStatusResponse
        /// </returns>
        public GetDataCheckReportStatusResponse GetDataCheckReportStatus(GetDataCheckReportStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataCheckReportStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the generation status (not generated, generating, or generated) and generation information of a report for a specified validation batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the generation status of a data validation report by validation batch. Use this operation to poll the progress after triggering report generation. Report generation is an asynchronous process. The report overview and report details operations return complete data only after the status changes to generated.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required. It is the validation batch ID, obtained from the response of the ExecDataCheckSaveTask operation.</description></item>
        /// <item><description>Each call queries the status of only one batch. When the report is being generated, call this operation repeatedly at intervals to refresh the status.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> is the report generation status code: <c>0</c> for not generated, <c>1</c> for generating, <c>2</c> for generated, and <c>3</c> for generation failed. After the status changes to generated, you can query the report overview and details. If the status is generation failed, troubleshoot the issue based on <c>errCode</c> and <c>errMessage</c>, and re-trigger report generation if necessary.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckReportStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckReportStatusResponse
        /// </returns>
        public async Task<GetDataCheckReportStatusResponse> GetDataCheckReportStatusAsync(GetDataCheckReportStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataCheckReportStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete configuration of a data validation task by task ID, including data sources, validation type, and scheduling settings.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the batch-level complete configuration of a data validation task. The response includes the validation type, execution and scheduling settings, comparison granularity and thresholds, batch concurrency, source and destination global parameters, and the table-level detail configurations under the task. Use this operation to verify the overall settings of a task before running the validation.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the ID of the data validation task.</description></item>
        /// <item><description>This operation returns task-level settings and includes the table-level detail configurations in the <c>dataCheckConfig</c> array. To retrieve only the table-level details, use the list operation for data validation task configurations.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response contains a single-value result. <c>data</c> is the task configuration object: <c>checkType</c> indicates the validation rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). <c>executeType</c>, <c>isScheduled</c>, <c>cronExp</c>, <c>scheduleId</c>, and <c>startImmediately</c> describe the execution method and scheduling settings. <c>fullTableCount</c>, <c>totalCountThreshold</c>, <c>groupCountThreshold</c>, and <c>concurrency</c> describe the comparison granularity, data volume thresholds, and batch concurrency. <c>sourceGlobalParams</c>, <c>targetGlobalParams</c>, and <c>checkGlobalParams</c> are the global parameters for the source, destination, and validation service respectively (JSON strings). <c>scopeFilter</c> specifies the scope filter conditions. <c>taskMode</c> indicates the creation method (0: table-by-table fine-grained, 1: same-schema batch). <c>batchId</c> is the current batch identifier, and <c>dataCheckConfig</c> is the list of table-level detail configurations under the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTaskConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTaskConfigResponse
        /// </returns>
        public GetDataCheckTaskConfigResponse GetDataCheckTaskConfigWithOptions(GetDataCheckTaskConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckTaskConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete configuration of a data validation task by task ID, including data sources, validation type, and scheduling settings.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the batch-level complete configuration of a data validation task. The response includes the validation type, execution and scheduling settings, comparison granularity and thresholds, batch concurrency, source and destination global parameters, and the table-level detail configurations under the task. Use this operation to verify the overall settings of a task before running the validation.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the ID of the data validation task.</description></item>
        /// <item><description>This operation returns task-level settings and includes the table-level detail configurations in the <c>dataCheckConfig</c> array. To retrieve only the table-level details, use the list operation for data validation task configurations.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response contains a single-value result. <c>data</c> is the task configuration object: <c>checkType</c> indicates the validation rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). <c>executeType</c>, <c>isScheduled</c>, <c>cronExp</c>, <c>scheduleId</c>, and <c>startImmediately</c> describe the execution method and scheduling settings. <c>fullTableCount</c>, <c>totalCountThreshold</c>, <c>groupCountThreshold</c>, and <c>concurrency</c> describe the comparison granularity, data volume thresholds, and batch concurrency. <c>sourceGlobalParams</c>, <c>targetGlobalParams</c>, and <c>checkGlobalParams</c> are the global parameters for the source, destination, and validation service respectively (JSON strings). <c>scopeFilter</c> specifies the scope filter conditions. <c>taskMode</c> indicates the creation method (0: table-by-table fine-grained, 1: same-schema batch). <c>batchId</c> is the current batch identifier, and <c>dataCheckConfig</c> is the list of table-level detail configurations under the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTaskConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTaskConfigResponse
        /// </returns>
        public async Task<GetDataCheckTaskConfigResponse> GetDataCheckTaskConfigWithOptionsAsync(GetDataCheckTaskConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckTaskConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete configuration of a data validation task by task ID, including data sources, validation type, and scheduling settings.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the batch-level complete configuration of a data validation task. The response includes the validation type, execution and scheduling settings, comparison granularity and thresholds, batch concurrency, source and destination global parameters, and the table-level detail configurations under the task. Use this operation to verify the overall settings of a task before running the validation.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the ID of the data validation task.</description></item>
        /// <item><description>This operation returns task-level settings and includes the table-level detail configurations in the <c>dataCheckConfig</c> array. To retrieve only the table-level details, use the list operation for data validation task configurations.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response contains a single-value result. <c>data</c> is the task configuration object: <c>checkType</c> indicates the validation rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). <c>executeType</c>, <c>isScheduled</c>, <c>cronExp</c>, <c>scheduleId</c>, and <c>startImmediately</c> describe the execution method and scheduling settings. <c>fullTableCount</c>, <c>totalCountThreshold</c>, <c>groupCountThreshold</c>, and <c>concurrency</c> describe the comparison granularity, data volume thresholds, and batch concurrency. <c>sourceGlobalParams</c>, <c>targetGlobalParams</c>, and <c>checkGlobalParams</c> are the global parameters for the source, destination, and validation service respectively (JSON strings). <c>scopeFilter</c> specifies the scope filter conditions. <c>taskMode</c> indicates the creation method (0: table-by-table fine-grained, 1: same-schema batch). <c>batchId</c> is the current batch identifier, and <c>dataCheckConfig</c> is the list of table-level detail configurations under the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTaskConfigResponse
        /// </returns>
        public GetDataCheckTaskConfigResponse GetDataCheckTaskConfig(GetDataCheckTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataCheckTaskConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete configuration of a data validation task by task ID, including data sources, validation type, and scheduling settings.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the batch-level complete configuration of a data validation task. The response includes the validation type, execution and scheduling settings, comparison granularity and thresholds, batch concurrency, source and destination global parameters, and the table-level detail configurations under the task. Use this operation to verify the overall settings of a task before running the validation.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the ID of the data validation task.</description></item>
        /// <item><description>This operation returns task-level settings and includes the table-level detail configurations in the <c>dataCheckConfig</c> array. To retrieve only the table-level details, use the list operation for data validation task configurations.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response contains a single-value result. <c>data</c> is the task configuration object: <c>checkType</c> indicates the validation rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). <c>executeType</c>, <c>isScheduled</c>, <c>cronExp</c>, <c>scheduleId</c>, and <c>startImmediately</c> describe the execution method and scheduling settings. <c>fullTableCount</c>, <c>totalCountThreshold</c>, <c>groupCountThreshold</c>, and <c>concurrency</c> describe the comparison granularity, data volume thresholds, and batch concurrency. <c>sourceGlobalParams</c>, <c>targetGlobalParams</c>, and <c>checkGlobalParams</c> are the global parameters for the source, destination, and validation service respectively (JSON strings). <c>scopeFilter</c> specifies the scope filter conditions. <c>taskMode</c> indicates the creation method (0: table-by-table fine-grained, 1: same-schema batch). <c>batchId</c> is the current batch identifier, and <c>dataCheckConfig</c> is the list of table-level detail configurations under the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTaskConfigResponse
        /// </returns>
        public async Task<GetDataCheckTaskConfigResponse> GetDataCheckTaskConfigAsync(GetDataCheckTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataCheckTaskConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists data validation tasks by condition with paging, with support for filtering by task name, data source, and other dimensions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Lists data validation tasks by condition with paging, with support for combined filtering by task name, validation type, execute status, validation result, scheduling status, template name, and creation or update time range. The response includes the execution progress, validation statistics, and data source and engine information for both the source and destination of each task. This operation serves as the task overview entry point for data validation capabilities.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object in which all fields are optional. If no filter conditions are specified, all tasks visible to the current user are returned.</description></item>
        /// <item><description><c>taskName</c> and <c>templateName</c> support fuzzy match. The server converts <c>templateName</c> into a list of template IDs before filtering.</description></item>
        /// <item><description><c>checkType</c>, <c>execStatus</c>, <c>checkResult</c>, and <c>isScheduled</c> filter by exact enum values. <c>createStartTime</c> and <c>createEndTime</c>, <c>updateStartTime</c> and <c>updateEndTime</c> define time ranges in the format YYYY-MM-DD HH:MM:SS.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> control pagination. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is paginated: <c>totalCount</c> indicates the total number of tasks that match the filter conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the task list for the current page. Each list element includes the task ID and name, creation mode <c>taskMode</c>, validation type <c>checkType</c>, execution status <c>execStatus</c>, execution type <c>executeType</c>, validation result <c>checkResult</c>, execution progress <c>process</c>, pass rate <c>passProcess</c>, number of validated tables and the counts of abnormal, successful, and skipped tables, latest batch IDs (<c>lastBatchId</c> and <c>lastFinishedId</c>), scheduling switch, start and end times, execution duration, creation and modification times, report time and title, error message <c>errorMsg</c>, as well as data source and validation engine information for both the source and destination and the validation template used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTaskListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTaskListResponse
        /// </returns>
        public GetDataCheckTaskListResponse GetDataCheckTaskListWithOptions(GetDataCheckTaskListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckResult))
            {
                body["checkResult"] = request.CheckResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                body["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                body["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                body["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecStatus))
            {
                body["execStatus"] = request.ExecStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsScheduled))
            {
                body["isScheduled"] = request.IsScheduled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                body["updateEndTime"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                body["updateStartTime"] = request.UpdateStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckTaskList",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/find",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckTaskListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists data validation tasks by condition with paging, with support for filtering by task name, data source, and other dimensions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Lists data validation tasks by condition with paging, with support for combined filtering by task name, validation type, execute status, validation result, scheduling status, template name, and creation or update time range. The response includes the execution progress, validation statistics, and data source and engine information for both the source and destination of each task. This operation serves as the task overview entry point for data validation capabilities.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object in which all fields are optional. If no filter conditions are specified, all tasks visible to the current user are returned.</description></item>
        /// <item><description><c>taskName</c> and <c>templateName</c> support fuzzy match. The server converts <c>templateName</c> into a list of template IDs before filtering.</description></item>
        /// <item><description><c>checkType</c>, <c>execStatus</c>, <c>checkResult</c>, and <c>isScheduled</c> filter by exact enum values. <c>createStartTime</c> and <c>createEndTime</c>, <c>updateStartTime</c> and <c>updateEndTime</c> define time ranges in the format YYYY-MM-DD HH:MM:SS.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> control pagination. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is paginated: <c>totalCount</c> indicates the total number of tasks that match the filter conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the task list for the current page. Each list element includes the task ID and name, creation mode <c>taskMode</c>, validation type <c>checkType</c>, execution status <c>execStatus</c>, execution type <c>executeType</c>, validation result <c>checkResult</c>, execution progress <c>process</c>, pass rate <c>passProcess</c>, number of validated tables and the counts of abnormal, successful, and skipped tables, latest batch IDs (<c>lastBatchId</c> and <c>lastFinishedId</c>), scheduling switch, start and end times, execution duration, creation and modification times, report time and title, error message <c>errorMsg</c>, as well as data source and validation engine information for both the source and destination and the validation template used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTaskListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTaskListResponse
        /// </returns>
        public async Task<GetDataCheckTaskListResponse> GetDataCheckTaskListWithOptionsAsync(GetDataCheckTaskListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckResult))
            {
                body["checkResult"] = request.CheckResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                body["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                body["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                body["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecStatus))
            {
                body["execStatus"] = request.ExecStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsScheduled))
            {
                body["isScheduled"] = request.IsScheduled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                body["updateEndTime"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                body["updateStartTime"] = request.UpdateStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckTaskList",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/find",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists data validation tasks by condition with paging, with support for filtering by task name, data source, and other dimensions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Lists data validation tasks by condition with paging, with support for combined filtering by task name, validation type, execute status, validation result, scheduling status, template name, and creation or update time range. The response includes the execution progress, validation statistics, and data source and engine information for both the source and destination of each task. This operation serves as the task overview entry point for data validation capabilities.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object in which all fields are optional. If no filter conditions are specified, all tasks visible to the current user are returned.</description></item>
        /// <item><description><c>taskName</c> and <c>templateName</c> support fuzzy match. The server converts <c>templateName</c> into a list of template IDs before filtering.</description></item>
        /// <item><description><c>checkType</c>, <c>execStatus</c>, <c>checkResult</c>, and <c>isScheduled</c> filter by exact enum values. <c>createStartTime</c> and <c>createEndTime</c>, <c>updateStartTime</c> and <c>updateEndTime</c> define time ranges in the format YYYY-MM-DD HH:MM:SS.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> control pagination. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is paginated: <c>totalCount</c> indicates the total number of tasks that match the filter conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the task list for the current page. Each list element includes the task ID and name, creation mode <c>taskMode</c>, validation type <c>checkType</c>, execution status <c>execStatus</c>, execution type <c>executeType</c>, validation result <c>checkResult</c>, execution progress <c>process</c>, pass rate <c>passProcess</c>, number of validated tables and the counts of abnormal, successful, and skipped tables, latest batch IDs (<c>lastBatchId</c> and <c>lastFinishedId</c>), scheduling switch, start and end times, execution duration, creation and modification times, report time and title, error message <c>errorMsg</c>, as well as data source and validation engine information for both the source and destination and the validation template used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTaskListResponse
        /// </returns>
        public GetDataCheckTaskListResponse GetDataCheckTaskList(GetDataCheckTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataCheckTaskListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists data validation tasks by condition with paging, with support for filtering by task name, data source, and other dimensions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Lists data validation tasks by condition with paging, with support for combined filtering by task name, validation type, execute status, validation result, scheduling status, template name, and creation or update time range. The response includes the execution progress, validation statistics, and data source and engine information for both the source and destination of each task. This operation serves as the task overview entry point for data validation capabilities.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object in which all fields are optional. If no filter conditions are specified, all tasks visible to the current user are returned.</description></item>
        /// <item><description><c>taskName</c> and <c>templateName</c> support fuzzy match. The server converts <c>templateName</c> into a list of template IDs before filtering.</description></item>
        /// <item><description><c>checkType</c>, <c>execStatus</c>, <c>checkResult</c>, and <c>isScheduled</c> filter by exact enum values. <c>createStartTime</c> and <c>createEndTime</c>, <c>updateStartTime</c> and <c>updateEndTime</c> define time ranges in the format YYYY-MM-DD HH:MM:SS.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> control pagination. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is paginated: <c>totalCount</c> indicates the total number of tasks that match the filter conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the task list for the current page. Each list element includes the task ID and name, creation mode <c>taskMode</c>, validation type <c>checkType</c>, execution status <c>execStatus</c>, execution type <c>executeType</c>, validation result <c>checkResult</c>, execution progress <c>process</c>, pass rate <c>passProcess</c>, number of validated tables and the counts of abnormal, successful, and skipped tables, latest batch IDs (<c>lastBatchId</c> and <c>lastFinishedId</c>), scheduling switch, start and end times, execution duration, creation and modification times, report time and title, error message <c>errorMsg</c>, as well as data source and validation engine information for both the source and destination and the validation template used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTaskListResponse
        /// </returns>
        public async Task<GetDataCheckTaskListResponse> GetDataCheckTaskListAsync(GetDataCheckTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataCheckTaskListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed configuration of a metric check template by template ID and returns the metric definitions included in the template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the detailed configuration of a data validation template by template ID. The response includes the basic template information, the overwrite scope of data sources and DPI engines, and the definitions of various check rules under the template. You can use this operation to view, reuse, or modify a configured set of check rules.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>templateId</c> is required. It specifies the check template ID, which can be obtained from the list templates operation.</description></item>
        /// <item><description>Each call returns the details of only one template.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value response. <c>data</c> is the template details object: <c>templateName</c> and <c>templateDesc</c> are the template name and description. <c>checkType</c> is the check rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). <c>checkTypeExport</c> is the Chinese name of the check type. <c>dsEngineRels</c> lists the data source types and check engine types covered by the template. The rule section varies by <c>checkType</c>: metric comparison (1) uses <c>basicMetricRules</c> and <c>complexMetricRules</c>, which correspond to metric rules for native and composite data types respectively, and <c>metricRules</c> is the list of metric rules. Weak content comparison (2) uses <c>weakContentRule</c>. Full-text comparison (4) uses <c>fulltextRule</c>. Null rate comparison (5) uses <c>nullRules</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTemplateResponse
        /// </returns>
        public GetDataCheckTemplateResponse GetDataCheckTemplateWithOptions(GetDataCheckTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckTemplate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed configuration of a metric check template by template ID and returns the metric definitions included in the template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the detailed configuration of a data validation template by template ID. The response includes the basic template information, the overwrite scope of data sources and DPI engines, and the definitions of various check rules under the template. You can use this operation to view, reuse, or modify a configured set of check rules.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>templateId</c> is required. It specifies the check template ID, which can be obtained from the list templates operation.</description></item>
        /// <item><description>Each call returns the details of only one template.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value response. <c>data</c> is the template details object: <c>templateName</c> and <c>templateDesc</c> are the template name and description. <c>checkType</c> is the check rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). <c>checkTypeExport</c> is the Chinese name of the check type. <c>dsEngineRels</c> lists the data source types and check engine types covered by the template. The rule section varies by <c>checkType</c>: metric comparison (1) uses <c>basicMetricRules</c> and <c>complexMetricRules</c>, which correspond to metric rules for native and composite data types respectively, and <c>metricRules</c> is the list of metric rules. Weak content comparison (2) uses <c>weakContentRule</c>. Full-text comparison (4) uses <c>fulltextRule</c>. Null rate comparison (5) uses <c>nullRules</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTemplateResponse
        /// </returns>
        public async Task<GetDataCheckTemplateResponse> GetDataCheckTemplateWithOptionsAsync(GetDataCheckTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckTemplate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed configuration of a metric check template by template ID and returns the metric definitions included in the template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the detailed configuration of a data validation template by template ID. The response includes the basic template information, the overwrite scope of data sources and DPI engines, and the definitions of various check rules under the template. You can use this operation to view, reuse, or modify a configured set of check rules.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>templateId</c> is required. It specifies the check template ID, which can be obtained from the list templates operation.</description></item>
        /// <item><description>Each call returns the details of only one template.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value response. <c>data</c> is the template details object: <c>templateName</c> and <c>templateDesc</c> are the template name and description. <c>checkType</c> is the check rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). <c>checkTypeExport</c> is the Chinese name of the check type. <c>dsEngineRels</c> lists the data source types and check engine types covered by the template. The rule section varies by <c>checkType</c>: metric comparison (1) uses <c>basicMetricRules</c> and <c>complexMetricRules</c>, which correspond to metric rules for native and composite data types respectively, and <c>metricRules</c> is the list of metric rules. Weak content comparison (2) uses <c>weakContentRule</c>. Full-text comparison (4) uses <c>fulltextRule</c>. Null rate comparison (5) uses <c>nullRules</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTemplateResponse
        /// </returns>
        public GetDataCheckTemplateResponse GetDataCheckTemplate(GetDataCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataCheckTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed configuration of a metric check template by template ID and returns the metric definitions included in the template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the detailed configuration of a data validation template by template ID. The response includes the basic template information, the overwrite scope of data sources and DPI engines, and the definitions of various check rules under the template. You can use this operation to view, reuse, or modify a configured set of check rules.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>templateId</c> is required. It specifies the check template ID, which can be obtained from the list templates operation.</description></item>
        /// <item><description>Each call returns the details of only one template.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value response. <c>data</c> is the template details object: <c>templateName</c> and <c>templateDesc</c> are the template name and description. <c>checkType</c> is the check rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). <c>checkTypeExport</c> is the Chinese name of the check type. <c>dsEngineRels</c> lists the data source types and check engine types covered by the template. The rule section varies by <c>checkType</c>: metric comparison (1) uses <c>basicMetricRules</c> and <c>complexMetricRules</c>, which correspond to metric rules for native and composite data types respectively, and <c>metricRules</c> is the list of metric rules. Weak content comparison (2) uses <c>weakContentRule</c>. Full-text comparison (4) uses <c>fulltextRule</c>. Null rate comparison (5) uses <c>nullRules</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTemplateResponse
        /// </returns>
        public async Task<GetDataCheckTemplateResponse> GetDataCheckTemplateAsync(GetDataCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataCheckTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data validation templates with paging. Supports filtering by check type, template name, and whether the template is built-in. General node templates can be downloaded without authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries a paginated list of data validation templates. Supports filtering by check type, template name, and whether the template is built-in. Use this operation to select an existing template when creating a validation task, or to view available built-in and custom templates.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>All parameters are optional. checkType filters by validation rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). templateName filters by template name. isBuiltin distinguishes built-in templates (1) from custom templates (0).</description></item>
        /// <item><description>pageSize, pageIndex, orderBy, orderDirection, groupBy, and needTotalCount are common query parameters that control pagination, sorting, and whether to return the total count.</description></item>
        /// <item><description>idList and isAdmin are legacy parameters. isAdmin is deprecated, and passing idList does not affect query results. Neither parameter needs to be used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response contains a list. Each element in data represents a template and includes the template ID and name, the check type checkType and its display name checkTypeExport, the covered data source types dsTypes and validation engine types engineTypes, whether the template is built-in isBuiltin, the template description templateDesc, the modification time gmtModified, and whether the template is referenced by a validation task isUsedByTask. The response body returns only the list itself and does not include the total record count or pagination parameters.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetDataCheckTemplateListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTemplateListResponse
        /// </returns>
        public GetDataCheckTemplateListResponse GetDataCheckTemplateListWithOptions(GetDataCheckTemplateListRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDataCheckTemplateListShrinkRequest request = new GetDataCheckTemplateListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IdList))
            {
                request.IdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IdList, "idList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdListShrink))
            {
                query["idList"] = request.IdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAdmin))
            {
                query["isAdmin"] = request.IsAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBuiltin))
            {
                query["isBuiltin"] = request.IsBuiltin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckTemplateList",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckTemplateListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data validation templates with paging. Supports filtering by check type, template name, and whether the template is built-in. General node templates can be downloaded without authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries a paginated list of data validation templates. Supports filtering by check type, template name, and whether the template is built-in. Use this operation to select an existing template when creating a validation task, or to view available built-in and custom templates.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>All parameters are optional. checkType filters by validation rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). templateName filters by template name. isBuiltin distinguishes built-in templates (1) from custom templates (0).</description></item>
        /// <item><description>pageSize, pageIndex, orderBy, orderDirection, groupBy, and needTotalCount are common query parameters that control pagination, sorting, and whether to return the total count.</description></item>
        /// <item><description>idList and isAdmin are legacy parameters. isAdmin is deprecated, and passing idList does not affect query results. Neither parameter needs to be used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response contains a list. Each element in data represents a template and includes the template ID and name, the check type checkType and its display name checkTypeExport, the covered data source types dsTypes and validation engine types engineTypes, whether the template is built-in isBuiltin, the template description templateDesc, the modification time gmtModified, and whether the template is referenced by a validation task isUsedByTask. The response body returns only the list itself and does not include the total record count or pagination parameters.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetDataCheckTemplateListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTemplateListResponse
        /// </returns>
        public async Task<GetDataCheckTemplateListResponse> GetDataCheckTemplateListWithOptionsAsync(GetDataCheckTemplateListRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDataCheckTemplateListShrinkRequest request = new GetDataCheckTemplateListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IdList))
            {
                request.IdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IdList, "idList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdListShrink))
            {
                query["idList"] = request.IdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAdmin))
            {
                query["isAdmin"] = request.IsAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBuiltin))
            {
                query["isBuiltin"] = request.IsBuiltin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataCheckTemplateList",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataCheckTemplateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data validation templates with paging. Supports filtering by check type, template name, and whether the template is built-in. General node templates can be downloaded without authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries a paginated list of data validation templates. Supports filtering by check type, template name, and whether the template is built-in. Use this operation to select an existing template when creating a validation task, or to view available built-in and custom templates.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>All parameters are optional. checkType filters by validation rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). templateName filters by template name. isBuiltin distinguishes built-in templates (1) from custom templates (0).</description></item>
        /// <item><description>pageSize, pageIndex, orderBy, orderDirection, groupBy, and needTotalCount are common query parameters that control pagination, sorting, and whether to return the total count.</description></item>
        /// <item><description>idList and isAdmin are legacy parameters. isAdmin is deprecated, and passing idList does not affect query results. Neither parameter needs to be used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response contains a list. Each element in data represents a template and includes the template ID and name, the check type checkType and its display name checkTypeExport, the covered data source types dsTypes and validation engine types engineTypes, whether the template is built-in isBuiltin, the template description templateDesc, the modification time gmtModified, and whether the template is referenced by a validation task isUsedByTask. The response body returns only the list itself and does not include the total record count or pagination parameters.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTemplateListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTemplateListResponse
        /// </returns>
        public GetDataCheckTemplateListResponse GetDataCheckTemplateList(GetDataCheckTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataCheckTemplateListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data validation templates with paging. Supports filtering by check type, template name, and whether the template is built-in. General node templates can be downloaded without authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries a paginated list of data validation templates. Supports filtering by check type, template name, and whether the template is built-in. Use this operation to select an existing template when creating a validation task, or to view available built-in and custom templates.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>All parameters are optional. checkType filters by validation rule type (0: data volume comparison, 1: metric comparison, 2: weak content comparison, 3: custom comparison, 4: full-text comparison, 5: null rate comparison). templateName filters by template name. isBuiltin distinguishes built-in templates (1) from custom templates (0).</description></item>
        /// <item><description>pageSize, pageIndex, orderBy, orderDirection, groupBy, and needTotalCount are common query parameters that control pagination, sorting, and whether to return the total count.</description></item>
        /// <item><description>idList and isAdmin are legacy parameters. isAdmin is deprecated, and passing idList does not affect query results. Neither parameter needs to be used.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response contains a list. Each element in data represents a template and includes the template ID and name, the check type checkType and its display name checkTypeExport, the covered data source types dsTypes and validation engine types engineTypes, whether the template is built-in isBuiltin, the template description templateDesc, the modification time gmtModified, and whether the template is referenced by a validation task isUsedByTask. The response body returns only the list itself and does not include the total record count or pagination parameters.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataCheckTemplateListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataCheckTemplateListResponse
        /// </returns>
        public async Task<GetDataCheckTemplateListResponse> GetDataCheckTemplateListAsync(GetDataCheckTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataCheckTemplateListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the asynchronous execution result of a workflow conversion by submit credential. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This is an internal operation for querying the asynchronous result of a workflow conversion. After the submit operation PostInnerConvert accepts a conversion task and returns the acceptance result, this operation queries the asynchronous execution result of that conversion by using the same request credential. This operation serves as the polling side in the submit-and-poll invocation pattern.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. The taskId parameter specifies the ID of the conversion task to query, which is the task identifier associated with the conversion task at the time of submission.</para>
        /// <h2>Response description</h2>
        /// <para>The success parameter indicates whether the call is successful. The data parameter contains the asynchronous execution result of the conversion task in string format. In specific error scenarios such as multiple data sources with the same name, the data parameter carries the error detail text. If the call fails, troubleshoot the issue based on errCode and errMessage. The requestId parameter uniquely identifies the call. Provide this value when troubleshooting issues.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInnerConvertAsyncResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInnerConvertAsyncResultResponse
        /// </returns>
        public GetInnerConvertAsyncResultResponse GetInnerConvertAsyncResultWithOptions(GetInnerConvertAsyncResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInnerConvertAsyncResult",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/convert/async-result",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInnerConvertAsyncResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the asynchronous execution result of a workflow conversion by submit credential. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This is an internal operation for querying the asynchronous result of a workflow conversion. After the submit operation PostInnerConvert accepts a conversion task and returns the acceptance result, this operation queries the asynchronous execution result of that conversion by using the same request credential. This operation serves as the polling side in the submit-and-poll invocation pattern.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. The taskId parameter specifies the ID of the conversion task to query, which is the task identifier associated with the conversion task at the time of submission.</para>
        /// <h2>Response description</h2>
        /// <para>The success parameter indicates whether the call is successful. The data parameter contains the asynchronous execution result of the conversion task in string format. In specific error scenarios such as multiple data sources with the same name, the data parameter carries the error detail text. If the call fails, troubleshoot the issue based on errCode and errMessage. The requestId parameter uniquely identifies the call. Provide this value when troubleshooting issues.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInnerConvertAsyncResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInnerConvertAsyncResultResponse
        /// </returns>
        public async Task<GetInnerConvertAsyncResultResponse> GetInnerConvertAsyncResultWithOptionsAsync(GetInnerConvertAsyncResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInnerConvertAsyncResult",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/convert/async-result",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInnerConvertAsyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the asynchronous execution result of a workflow conversion by submit credential. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This is an internal operation for querying the asynchronous result of a workflow conversion. After the submit operation PostInnerConvert accepts a conversion task and returns the acceptance result, this operation queries the asynchronous execution result of that conversion by using the same request credential. This operation serves as the polling side in the submit-and-poll invocation pattern.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. The taskId parameter specifies the ID of the conversion task to query, which is the task identifier associated with the conversion task at the time of submission.</para>
        /// <h2>Response description</h2>
        /// <para>The success parameter indicates whether the call is successful. The data parameter contains the asynchronous execution result of the conversion task in string format. In specific error scenarios such as multiple data sources with the same name, the data parameter carries the error detail text. If the call fails, troubleshoot the issue based on errCode and errMessage. The requestId parameter uniquely identifies the call. Provide this value when troubleshooting issues.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInnerConvertAsyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInnerConvertAsyncResultResponse
        /// </returns>
        public GetInnerConvertAsyncResultResponse GetInnerConvertAsyncResult(GetInnerConvertAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInnerConvertAsyncResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the asynchronous execution result of a workflow conversion by submit credential. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This is an internal operation for querying the asynchronous result of a workflow conversion. After the submit operation PostInnerConvert accepts a conversion task and returns the acceptance result, this operation queries the asynchronous execution result of that conversion by using the same request credential. This operation serves as the polling side in the submit-and-poll invocation pattern.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. The taskId parameter specifies the ID of the conversion task to query, which is the task identifier associated with the conversion task at the time of submission.</para>
        /// <h2>Response description</h2>
        /// <para>The success parameter indicates whether the call is successful. The data parameter contains the asynchronous execution result of the conversion task in string format. In specific error scenarios such as multiple data sources with the same name, the data parameter carries the error detail text. If the call fails, troubleshoot the issue based on errCode and errMessage. The requestId parameter uniquely identifies the call. Provide this value when troubleshooting issues.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInnerConvertAsyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInnerConvertAsyncResultResponse
        /// </returns>
        public async Task<GetInnerConvertAsyncResultResponse> GetInnerConvertAsyncResultAsync(GetInnerConvertAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInnerConvertAsyncResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the asynchronous execution result of a source workflow read operation by submit credential. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This is an internal operation for querying the asynchronous result of a workflow read operation. After the submit operation PostInnerReader accepts a source workflow read task and returns an acceptance result, this operation queries the asynchronous execution result of that read operation by using the same request credential. This operation serves as the polling side in the submit-and-poll invocation pattern.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. The dataSourceName parameter specifies the name of the data source to which the read task belongs. The read task uses this field as its dimension identifier.</para>
        /// <h2>Response description</h2>
        /// <para>The success field indicates whether the call is successful. The data field contains the asynchronous execution result of the read task in string format. If the call fails, use errCode and errMessage to troubleshoot the issue. The requestId field uniquely identifies the call. Provide this value when troubleshooting issues.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInnerReadAsyncResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInnerReadAsyncResultResponse
        /// </returns>
        public GetInnerReadAsyncResultResponse GetInnerReadAsyncResultWithOptions(GetInnerReadAsyncResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInnerReadAsyncResult",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/read/async-result",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInnerReadAsyncResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the asynchronous execution result of a source workflow read operation by submit credential. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This is an internal operation for querying the asynchronous result of a workflow read operation. After the submit operation PostInnerReader accepts a source workflow read task and returns an acceptance result, this operation queries the asynchronous execution result of that read operation by using the same request credential. This operation serves as the polling side in the submit-and-poll invocation pattern.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. The dataSourceName parameter specifies the name of the data source to which the read task belongs. The read task uses this field as its dimension identifier.</para>
        /// <h2>Response description</h2>
        /// <para>The success field indicates whether the call is successful. The data field contains the asynchronous execution result of the read task in string format. If the call fails, use errCode and errMessage to troubleshoot the issue. The requestId field uniquely identifies the call. Provide this value when troubleshooting issues.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInnerReadAsyncResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInnerReadAsyncResultResponse
        /// </returns>
        public async Task<GetInnerReadAsyncResultResponse> GetInnerReadAsyncResultWithOptionsAsync(GetInnerReadAsyncResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInnerReadAsyncResult",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/read/async-result",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInnerReadAsyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the asynchronous execution result of a source workflow read operation by submit credential. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This is an internal operation for querying the asynchronous result of a workflow read operation. After the submit operation PostInnerReader accepts a source workflow read task and returns an acceptance result, this operation queries the asynchronous execution result of that read operation by using the same request credential. This operation serves as the polling side in the submit-and-poll invocation pattern.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. The dataSourceName parameter specifies the name of the data source to which the read task belongs. The read task uses this field as its dimension identifier.</para>
        /// <h2>Response description</h2>
        /// <para>The success field indicates whether the call is successful. The data field contains the asynchronous execution result of the read task in string format. If the call fails, use errCode and errMessage to troubleshoot the issue. The requestId field uniquely identifies the call. Provide this value when troubleshooting issues.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInnerReadAsyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInnerReadAsyncResultResponse
        /// </returns>
        public GetInnerReadAsyncResultResponse GetInnerReadAsyncResult(GetInnerReadAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInnerReadAsyncResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the asynchronous execution result of a source workflow read operation by submit credential. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This is an internal operation for querying the asynchronous result of a workflow read operation. After the submit operation PostInnerReader accepts a source workflow read task and returns an acceptance result, this operation queries the asynchronous execution result of that read operation by using the same request credential. This operation serves as the polling side in the submit-and-poll invocation pattern.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. The dataSourceName parameter specifies the name of the data source to which the read task belongs. The read task uses this field as its dimension identifier.</para>
        /// <h2>Response description</h2>
        /// <para>The success field indicates whether the call is successful. The data field contains the asynchronous execution result of the read task in string format. If the call fails, use errCode and errMessage to troubleshoot the issue. The requestId field uniquely identifies the call. Provide this value when troubleshooting issues.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInnerReadAsyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInnerReadAsyncResultResponse
        /// </returns>
        public async Task<GetInnerReadAsyncResultResponse> GetInnerReadAsyncResultAsync(GetInnerReadAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInnerReadAsyncResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registration and running status of a user-side Agent by agent type and skill name to determine whether the local environment is ready.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the registration and running status of a user-side Agent. Call this operation before using capabilities that depend on a local Agent, such as data validation, to confirm that the Agent is ready. This helps avoid task execution failures caused by an unregistered or stopped Agent.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>agentType</c>: required. Specifies the Agent type. Set this parameter to <c>0</c> for data validation (the only type currently supported) or <c>1</c> for metadata.</description></item>
        /// <item><description><c>skillName</c>: optional. The skill name.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the status information of the Agent as a string. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. Use <c>requestId</c> to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLhmAgentStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLhmAgentStatusResponse
        /// </returns>
        public GetLhmAgentStatusResponse GetLhmAgentStatusWithOptions(GetLhmAgentStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["agentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                query["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLhmAgentStatus",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/lhm/agent/getAgentStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLhmAgentStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registration and running status of a user-side Agent by agent type and skill name to determine whether the local environment is ready.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the registration and running status of a user-side Agent. Call this operation before using capabilities that depend on a local Agent, such as data validation, to confirm that the Agent is ready. This helps avoid task execution failures caused by an unregistered or stopped Agent.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>agentType</c>: required. Specifies the Agent type. Set this parameter to <c>0</c> for data validation (the only type currently supported) or <c>1</c> for metadata.</description></item>
        /// <item><description><c>skillName</c>: optional. The skill name.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the status information of the Agent as a string. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. Use <c>requestId</c> to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLhmAgentStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLhmAgentStatusResponse
        /// </returns>
        public async Task<GetLhmAgentStatusResponse> GetLhmAgentStatusWithOptionsAsync(GetLhmAgentStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["agentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                query["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLhmAgentStatus",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/lhm/agent/getAgentStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLhmAgentStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registration and running status of a user-side Agent by agent type and skill name to determine whether the local environment is ready.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the registration and running status of a user-side Agent. Call this operation before using capabilities that depend on a local Agent, such as data validation, to confirm that the Agent is ready. This helps avoid task execution failures caused by an unregistered or stopped Agent.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>agentType</c>: required. Specifies the Agent type. Set this parameter to <c>0</c> for data validation (the only type currently supported) or <c>1</c> for metadata.</description></item>
        /// <item><description><c>skillName</c>: optional. The skill name.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the status information of the Agent as a string. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. Use <c>requestId</c> to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLhmAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLhmAgentStatusResponse
        /// </returns>
        public GetLhmAgentStatusResponse GetLhmAgentStatus(GetLhmAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLhmAgentStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registration and running status of a user-side Agent by agent type and skill name to determine whether the local environment is ready.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the registration and running status of a user-side Agent. Call this operation before using capabilities that depend on a local Agent, such as data validation, to confirm that the Agent is ready. This helps avoid task execution failures caused by an unregistered or stopped Agent.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>agentType</c>: required. Specifies the Agent type. Set this parameter to <c>0</c> for data validation (the only type currently supported) or <c>1</c> for metadata.</description></item>
        /// <item><description><c>skillName</c>: optional. The skill name.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the status information of the Agent as a string. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the failure cause. Use <c>requestId</c> to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLhmAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLhmAgentStatusResponse
        /// </returns>
        public async Task<GetLhmAgentStatusResponse> GetLhmAgentStatusAsync(GetLhmAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLhmAgentStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a user\&quot;s DataWorks resource groups by region to determine whether available execution resources exist for migration tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the status of a user\&quot;s DataWorks resource groups by region. Use this operation before submitting a migration or validation task to confirm whether available execution resources exist in the specified region.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>regionId is required. Set this parameter to a region ID, such as cn-hangzhou.</description></item>
        /// <item><description>Each call queries only one region. For cross-region deployments, query each region separately.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. The data field contains the status information of the resource group in the specified region as a string. If success is false, use errCode and errMessage to identify the cause of the failure. Use requestId to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLhmDWResourceGroupStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLhmDWResourceGroupStatusResponse
        /// </returns>
        public GetLhmDWResourceGroupStatusResponse GetLhmDWResourceGroupStatusWithOptions(GetLhmDWResourceGroupStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLhmDWResourceGroupStatus",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/lhm/resource/getDWResourceGroupStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLhmDWResourceGroupStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a user\&quot;s DataWorks resource groups by region to determine whether available execution resources exist for migration tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the status of a user\&quot;s DataWorks resource groups by region. Use this operation before submitting a migration or validation task to confirm whether available execution resources exist in the specified region.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>regionId is required. Set this parameter to a region ID, such as cn-hangzhou.</description></item>
        /// <item><description>Each call queries only one region. For cross-region deployments, query each region separately.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. The data field contains the status information of the resource group in the specified region as a string. If success is false, use errCode and errMessage to identify the cause of the failure. Use requestId to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLhmDWResourceGroupStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLhmDWResourceGroupStatusResponse
        /// </returns>
        public async Task<GetLhmDWResourceGroupStatusResponse> GetLhmDWResourceGroupStatusWithOptionsAsync(GetLhmDWResourceGroupStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLhmDWResourceGroupStatus",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/lhm/resource/getDWResourceGroupStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLhmDWResourceGroupStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a user\&quot;s DataWorks resource groups by region to determine whether available execution resources exist for migration tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the status of a user\&quot;s DataWorks resource groups by region. Use this operation before submitting a migration or validation task to confirm whether available execution resources exist in the specified region.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>regionId is required. Set this parameter to a region ID, such as cn-hangzhou.</description></item>
        /// <item><description>Each call queries only one region. For cross-region deployments, query each region separately.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. The data field contains the status information of the resource group in the specified region as a string. If success is false, use errCode and errMessage to identify the cause of the failure. Use requestId to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLhmDWResourceGroupStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLhmDWResourceGroupStatusResponse
        /// </returns>
        public GetLhmDWResourceGroupStatusResponse GetLhmDWResourceGroupStatus(GetLhmDWResourceGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLhmDWResourceGroupStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a user\&quot;s DataWorks resource groups by region to determine whether available execution resources exist for migration tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the status of a user\&quot;s DataWorks resource groups by region. Use this operation before submitting a migration or validation task to confirm whether available execution resources exist in the specified region.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>regionId is required. Set this parameter to a region ID, such as cn-hangzhou.</description></item>
        /// <item><description>Each call queries only one region. For cross-region deployments, query each region separately.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. The data field contains the status information of the resource group in the specified region as a string. If success is false, use errCode and errMessage to identify the cause of the failure. Use requestId to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLhmDWResourceGroupStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLhmDWResourceGroupStatusResponse
        /// </returns>
        public async Task<GetLhmDWResourceGroupStatusResponse> GetLhmDWResourceGroupStatusAsync(GetLhmDWResourceGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLhmDWResourceGroupStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves temporary OSS upload credentials (STS), including the AccessKey, security token, bucket, upload directory, and expiration time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves temporary authorization credentials required for direct file uploads to Object Storage Service (OSS). The response includes a temporary AccessKey, security token, access endpoint, bucket, allowed upload directory prefix, upload policy and signature, and expiration time. These credentials enable the client to upload files by using form-based direct upload (PostObject) without storing long-term keys on the client.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation has no request parameters. The credential ownership and allowed upload directory are automatically generated by the server based on the current user and region.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the temporary credential object: <c>ak</c> and <c>securityToken</c> are the temporary identity credentials. <c>endpoint</c> and <c>bucket</c> specify the upload target. <c>dir</c> is the allowed upload directory prefix (ending with a forward slash). The key of the uploaded object must start with this prefix. Otherwise, the request is rejected. <c>policy</c> is a Base64-encoded upload policy that defines constraints such as file size and path prefix. The decoded value is a JSON string. <c>signature</c> is the signature calculated based on the policy. <c>expire</c> is the credential expiration timestamp in Unix seconds. Before use, verify whether the credential has expired. If it has expired, call this operation again to obtain new credentials. <c>ak</c> and <c>securityToken</c> are sensitive credentials. Do not hard-code them in your code or print them to logs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMetaOssTempKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMetaOssTempKeyResponse
        /// </returns>
        public GetMetaOssTempKeyResponse GetMetaOssTempKeyWithOptions(GetMetaOssTempKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMetaOssTempKey",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component/okss-services/file-job/sts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetaOssTempKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves temporary OSS upload credentials (STS), including the AccessKey, security token, bucket, upload directory, and expiration time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves temporary authorization credentials required for direct file uploads to Object Storage Service (OSS). The response includes a temporary AccessKey, security token, access endpoint, bucket, allowed upload directory prefix, upload policy and signature, and expiration time. These credentials enable the client to upload files by using form-based direct upload (PostObject) without storing long-term keys on the client.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation has no request parameters. The credential ownership and allowed upload directory are automatically generated by the server based on the current user and region.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the temporary credential object: <c>ak</c> and <c>securityToken</c> are the temporary identity credentials. <c>endpoint</c> and <c>bucket</c> specify the upload target. <c>dir</c> is the allowed upload directory prefix (ending with a forward slash). The key of the uploaded object must start with this prefix. Otherwise, the request is rejected. <c>policy</c> is a Base64-encoded upload policy that defines constraints such as file size and path prefix. The decoded value is a JSON string. <c>signature</c> is the signature calculated based on the policy. <c>expire</c> is the credential expiration timestamp in Unix seconds. Before use, verify whether the credential has expired. If it has expired, call this operation again to obtain new credentials. <c>ak</c> and <c>securityToken</c> are sensitive credentials. Do not hard-code them in your code or print them to logs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMetaOssTempKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMetaOssTempKeyResponse
        /// </returns>
        public async Task<GetMetaOssTempKeyResponse> GetMetaOssTempKeyWithOptionsAsync(GetMetaOssTempKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMetaOssTempKey",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component/okss-services/file-job/sts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetaOssTempKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves temporary OSS upload credentials (STS), including the AccessKey, security token, bucket, upload directory, and expiration time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves temporary authorization credentials required for direct file uploads to Object Storage Service (OSS). The response includes a temporary AccessKey, security token, access endpoint, bucket, allowed upload directory prefix, upload policy and signature, and expiration time. These credentials enable the client to upload files by using form-based direct upload (PostObject) without storing long-term keys on the client.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation has no request parameters. The credential ownership and allowed upload directory are automatically generated by the server based on the current user and region.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the temporary credential object: <c>ak</c> and <c>securityToken</c> are the temporary identity credentials. <c>endpoint</c> and <c>bucket</c> specify the upload target. <c>dir</c> is the allowed upload directory prefix (ending with a forward slash). The key of the uploaded object must start with this prefix. Otherwise, the request is rejected. <c>policy</c> is a Base64-encoded upload policy that defines constraints such as file size and path prefix. The decoded value is a JSON string. <c>signature</c> is the signature calculated based on the policy. <c>expire</c> is the credential expiration timestamp in Unix seconds. Before use, verify whether the credential has expired. If it has expired, call this operation again to obtain new credentials. <c>ak</c> and <c>securityToken</c> are sensitive credentials. Do not hard-code them in your code or print them to logs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMetaOssTempKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMetaOssTempKeyResponse
        /// </returns>
        public GetMetaOssTempKeyResponse GetMetaOssTempKey(GetMetaOssTempKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMetaOssTempKeyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves temporary OSS upload credentials (STS), including the AccessKey, security token, bucket, upload directory, and expiration time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves temporary authorization credentials required for direct file uploads to Object Storage Service (OSS). The response includes a temporary AccessKey, security token, access endpoint, bucket, allowed upload directory prefix, upload policy and signature, and expiration time. These credentials enable the client to upload files by using form-based direct upload (PostObject) without storing long-term keys on the client.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation has no request parameters. The credential ownership and allowed upload directory are automatically generated by the server based on the current user and region.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is the temporary credential object: <c>ak</c> and <c>securityToken</c> are the temporary identity credentials. <c>endpoint</c> and <c>bucket</c> specify the upload target. <c>dir</c> is the allowed upload directory prefix (ending with a forward slash). The key of the uploaded object must start with this prefix. Otherwise, the request is rejected. <c>policy</c> is a Base64-encoded upload policy that defines constraints such as file size and path prefix. The decoded value is a JSON string. <c>signature</c> is the signature calculated based on the policy. <c>expire</c> is the credential expiration timestamp in Unix seconds. Before use, verify whether the credential has expired. If it has expired, call this operation again to obtain new credentials. <c>ak</c> and <c>securityToken</c> are sensitive credentials. Do not hard-code them in your code or print them to logs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMetaOssTempKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMetaOssTempKeyResponse
        /// </returns>
        public async Task<GetMetaOssTempKeyResponse> GetMetaOssTempKeyAsync(GetMetaOssTempKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMetaOssTempKeyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution progress of an SQL conversion task by task ID and returns the total count, completed count, success count, and completion percentage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the execution progress of an SQL conversion task by task ID and returns the total number of scripts, the number of scripts being converted, the number of completed scripts, the number of failed scripts, and the completion percentage. Use this operation to poll the progress after submitting an asynchronous conversion task and determine when to retrieve the conversion results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId is required. It specifies the SQL conversion task ID, which is obtained from the response of the operation that creates the conversion task.</description></item>
        /// <item><description>You can call this operation repeatedly during the conversion process to refresh the progress.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single-value result. The data field is a progress object: total indicates the total number of scripts, running indicates the number of scripts being converted, finish indicates the number of completed scripts, fail indicates the number of failed scripts, and percent indicates the completion percentage (for example, 66.67 indicates that approximately two-thirds of the scripts are completed). After the task is complete, call the query conversion results operation to retrieve the conversion details for each script.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConversionProgressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConversionProgressResponse
        /// </returns>
        public GetSqlConversionProgressResponse GetSqlConversionProgressWithOptions(GetSqlConversionProgressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlConversionProgress",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/api/progress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConversionProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution progress of an SQL conversion task by task ID and returns the total count, completed count, success count, and completion percentage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the execution progress of an SQL conversion task by task ID and returns the total number of scripts, the number of scripts being converted, the number of completed scripts, the number of failed scripts, and the completion percentage. Use this operation to poll the progress after submitting an asynchronous conversion task and determine when to retrieve the conversion results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId is required. It specifies the SQL conversion task ID, which is obtained from the response of the operation that creates the conversion task.</description></item>
        /// <item><description>You can call this operation repeatedly during the conversion process to refresh the progress.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single-value result. The data field is a progress object: total indicates the total number of scripts, running indicates the number of scripts being converted, finish indicates the number of completed scripts, fail indicates the number of failed scripts, and percent indicates the completion percentage (for example, 66.67 indicates that approximately two-thirds of the scripts are completed). After the task is complete, call the query conversion results operation to retrieve the conversion details for each script.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConversionProgressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConversionProgressResponse
        /// </returns>
        public async Task<GetSqlConversionProgressResponse> GetSqlConversionProgressWithOptionsAsync(GetSqlConversionProgressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlConversionProgress",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/api/progress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConversionProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution progress of an SQL conversion task by task ID and returns the total count, completed count, success count, and completion percentage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the execution progress of an SQL conversion task by task ID and returns the total number of scripts, the number of scripts being converted, the number of completed scripts, the number of failed scripts, and the completion percentage. Use this operation to poll the progress after submitting an asynchronous conversion task and determine when to retrieve the conversion results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId is required. It specifies the SQL conversion task ID, which is obtained from the response of the operation that creates the conversion task.</description></item>
        /// <item><description>You can call this operation repeatedly during the conversion process to refresh the progress.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single-value result. The data field is a progress object: total indicates the total number of scripts, running indicates the number of scripts being converted, finish indicates the number of completed scripts, fail indicates the number of failed scripts, and percent indicates the completion percentage (for example, 66.67 indicates that approximately two-thirds of the scripts are completed). After the task is complete, call the query conversion results operation to retrieve the conversion details for each script.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConversionProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConversionProgressResponse
        /// </returns>
        public GetSqlConversionProgressResponse GetSqlConversionProgress(GetSqlConversionProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSqlConversionProgressWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution progress of an SQL conversion task by task ID and returns the total count, completed count, success count, and completion percentage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the execution progress of an SQL conversion task by task ID and returns the total number of scripts, the number of scripts being converted, the number of completed scripts, the number of failed scripts, and the completion percentage. Use this operation to poll the progress after submitting an asynchronous conversion task and determine when to retrieve the conversion results.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>taskId is required. It specifies the SQL conversion task ID, which is obtained from the response of the operation that creates the conversion task.</description></item>
        /// <item><description>You can call this operation repeatedly during the conversion process to refresh the progress.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single-value result. The data field is a progress object: total indicates the total number of scripts, running indicates the number of scripts being converted, finish indicates the number of completed scripts, fail indicates the number of failed scripts, and percent indicates the completion percentage (for example, 66.67 indicates that approximately two-thirds of the scripts are completed). After the task is complete, call the query conversion results operation to retrieve the conversion details for each script.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConversionProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConversionProgressResponse
        /// </returns>
        public async Task<GetSqlConversionProgressResponse> GetSqlConversionProgressAsync(GetSqlConversionProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSqlConversionProgressWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result details of an SQL conversion task and returns the source statement, target statement, and conversion status of each SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the result details of an SQL conversion task by using paging. Returns the original content, transformed content, transform status, failure reason, and table name mapping for each script. Use this operation to verify transform results one by one after a transform task is complete, or to identify scripts that failed to transform.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>taskId</c> specifies the ID of the SQL conversion task to query, which is obtained from the response of the create conversion task operation. <c>page</c> and <c>size</c> specify the page number and the number of entries per page.</description></item>
        /// <item><description>Conversion is an asynchronous process. Query the conversion progress first to confirm that the task is complete before calling this operation to retrieve details. If you call this operation while the conversion is still in progress, records with a converting status are returned.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A paginated response is returned. <c>totalCount</c> is the total number of scripts that meet the conditions. <c>pageSize</c> and <c>pageIndex</c> echo the pagination parameters of the current request (corresponding to <c>size</c> and <c>page</c> in the request, respectively). <c>data</c> is the list of scripts on the current page. Each element in the list contains the script name and identifier (<c>scriptName</c> and <c>scriptId</c>), the original script content <c>sqlSourceContent</c>, the converted script content <c>sqlResultContent</c>, the script conversion status <c>scriptTransformStatus</c> (in conversion job scenarios: pass for conversion succeeded, turning for converting, and fail for conversion failed. In some scenarios: success for succeeded, failed for failed, and skipped for skipped), the error reason <c>errorMessage</c>, the completion time <c>finishTime</c>, and the table name mapping <c>tableMappingList</c>. For scripts with a conversion failed status, use <c>errorMessage</c> to identify the issue, fix the script, and resubmit it for conversion.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConversionResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConversionResultResponse
        /// </returns>
        public GetSqlConversionResultResponse GetSqlConversionResultWithOptions(GetSqlConversionResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlConversionResult",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/api/result",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConversionResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result details of an SQL conversion task and returns the source statement, target statement, and conversion status of each SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the result details of an SQL conversion task by using paging. Returns the original content, transformed content, transform status, failure reason, and table name mapping for each script. Use this operation to verify transform results one by one after a transform task is complete, or to identify scripts that failed to transform.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>taskId</c> specifies the ID of the SQL conversion task to query, which is obtained from the response of the create conversion task operation. <c>page</c> and <c>size</c> specify the page number and the number of entries per page.</description></item>
        /// <item><description>Conversion is an asynchronous process. Query the conversion progress first to confirm that the task is complete before calling this operation to retrieve details. If you call this operation while the conversion is still in progress, records with a converting status are returned.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A paginated response is returned. <c>totalCount</c> is the total number of scripts that meet the conditions. <c>pageSize</c> and <c>pageIndex</c> echo the pagination parameters of the current request (corresponding to <c>size</c> and <c>page</c> in the request, respectively). <c>data</c> is the list of scripts on the current page. Each element in the list contains the script name and identifier (<c>scriptName</c> and <c>scriptId</c>), the original script content <c>sqlSourceContent</c>, the converted script content <c>sqlResultContent</c>, the script conversion status <c>scriptTransformStatus</c> (in conversion job scenarios: pass for conversion succeeded, turning for converting, and fail for conversion failed. In some scenarios: success for succeeded, failed for failed, and skipped for skipped), the error reason <c>errorMessage</c>, the completion time <c>finishTime</c>, and the table name mapping <c>tableMappingList</c>. For scripts with a conversion failed status, use <c>errorMessage</c> to identify the issue, fix the script, and resubmit it for conversion.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConversionResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConversionResultResponse
        /// </returns>
        public async Task<GetSqlConversionResultResponse> GetSqlConversionResultWithOptionsAsync(GetSqlConversionResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlConversionResult",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/api/result",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConversionResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result details of an SQL conversion task and returns the source statement, target statement, and conversion status of each SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the result details of an SQL conversion task by using paging. Returns the original content, transformed content, transform status, failure reason, and table name mapping for each script. Use this operation to verify transform results one by one after a transform task is complete, or to identify scripts that failed to transform.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>taskId</c> specifies the ID of the SQL conversion task to query, which is obtained from the response of the create conversion task operation. <c>page</c> and <c>size</c> specify the page number and the number of entries per page.</description></item>
        /// <item><description>Conversion is an asynchronous process. Query the conversion progress first to confirm that the task is complete before calling this operation to retrieve details. If you call this operation while the conversion is still in progress, records with a converting status are returned.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A paginated response is returned. <c>totalCount</c> is the total number of scripts that meet the conditions. <c>pageSize</c> and <c>pageIndex</c> echo the pagination parameters of the current request (corresponding to <c>size</c> and <c>page</c> in the request, respectively). <c>data</c> is the list of scripts on the current page. Each element in the list contains the script name and identifier (<c>scriptName</c> and <c>scriptId</c>), the original script content <c>sqlSourceContent</c>, the converted script content <c>sqlResultContent</c>, the script conversion status <c>scriptTransformStatus</c> (in conversion job scenarios: pass for conversion succeeded, turning for converting, and fail for conversion failed. In some scenarios: success for succeeded, failed for failed, and skipped for skipped), the error reason <c>errorMessage</c>, the completion time <c>finishTime</c>, and the table name mapping <c>tableMappingList</c>. For scripts with a conversion failed status, use <c>errorMessage</c> to identify the issue, fix the script, and resubmit it for conversion.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConversionResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConversionResultResponse
        /// </returns>
        public GetSqlConversionResultResponse GetSqlConversionResult(GetSqlConversionResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSqlConversionResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result details of an SQL conversion task and returns the source statement, target statement, and conversion status of each SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the result details of an SQL conversion task by using paging. Returns the original content, transformed content, transform status, failure reason, and table name mapping for each script. Use this operation to verify transform results one by one after a transform task is complete, or to identify scripts that failed to transform.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>taskId</c> specifies the ID of the SQL conversion task to query, which is obtained from the response of the create conversion task operation. <c>page</c> and <c>size</c> specify the page number and the number of entries per page.</description></item>
        /// <item><description>Conversion is an asynchronous process. Query the conversion progress first to confirm that the task is complete before calling this operation to retrieve details. If you call this operation while the conversion is still in progress, records with a converting status are returned.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A paginated response is returned. <c>totalCount</c> is the total number of scripts that meet the conditions. <c>pageSize</c> and <c>pageIndex</c> echo the pagination parameters of the current request (corresponding to <c>size</c> and <c>page</c> in the request, respectively). <c>data</c> is the list of scripts on the current page. Each element in the list contains the script name and identifier (<c>scriptName</c> and <c>scriptId</c>), the original script content <c>sqlSourceContent</c>, the converted script content <c>sqlResultContent</c>, the script conversion status <c>scriptTransformStatus</c> (in conversion job scenarios: pass for conversion succeeded, turning for converting, and fail for conversion failed. In some scenarios: success for succeeded, failed for failed, and skipped for skipped), the error reason <c>errorMessage</c>, the completion time <c>finishTime</c>, and the table name mapping <c>tableMappingList</c>. For scripts with a conversion failed status, use <c>errorMessage</c> to identify the issue, fix the script, and resubmit it for conversion.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConversionResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConversionResultResponse
        /// </returns>
        public async Task<GetSqlConversionResultResponse> GetSqlConversionResultAsync(GetSqlConversionResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSqlConversionResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses table-level lineage from a single SQL script and returns the names of upstream and downstream tables referenced by the script.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Parses table-level lineage from a single SQL script and returns the names of upstream and downstream tables referenced by the script. Use this operation to identify the scope of tables involved in a script before performing batch conversions, or to provide a basis for configuring table name mapping.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>dialect</c> specifies the SQL dialect used by the script (such as hive). During parsing, the same dialect is used for both the source and target. This operation only performs parsing and does not perform cross-dialect rewriting. <c>defaultSchema</c> specifies the default database name, which is used to complete table references in the script that do not explicitly specify a database name. <c>sourceSqlScriptBase64</c> specifies the script content to be parsed, which must be Base64-encoded before being passed in. The server decodes the content before parsing.</description></item>
        /// <item><description>Parsing is processed as a data query language (DQL) statement. Each call parses only one script.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the lineage object. <c>upstreamTables</c> is the list of upstream table names. <c>downstreamTables</c> is the list of downstream table names. <c>success</c> indicates whether the parsing was successful. <c>errorMsg</c> provides the reason when parsing fails. When parsing fails, the outer layer also returns an SQL validation error. Use <c>errCode</c> and <c>errMessage</c> to troubleshoot the issue. Common causes include unparseable script syntax or Base64 decoding failure. <c>requestId</c> is used to locate the current call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlTableLineageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlTableLineageResponse
        /// </returns>
        public GetSqlTableLineageResponse GetSqlTableLineageWithOptions(GetSqlTableLineageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultSchema))
            {
                body["defaultSchema"] = request.DefaultSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dialect))
            {
                body["dialect"] = request.Dialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScriptBase64))
            {
                body["sourceSqlScriptBase64"] = request.SourceSqlScriptBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlTableLineage",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/getTableLineage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlTableLineageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses table-level lineage from a single SQL script and returns the names of upstream and downstream tables referenced by the script.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Parses table-level lineage from a single SQL script and returns the names of upstream and downstream tables referenced by the script. Use this operation to identify the scope of tables involved in a script before performing batch conversions, or to provide a basis for configuring table name mapping.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>dialect</c> specifies the SQL dialect used by the script (such as hive). During parsing, the same dialect is used for both the source and target. This operation only performs parsing and does not perform cross-dialect rewriting. <c>defaultSchema</c> specifies the default database name, which is used to complete table references in the script that do not explicitly specify a database name. <c>sourceSqlScriptBase64</c> specifies the script content to be parsed, which must be Base64-encoded before being passed in. The server decodes the content before parsing.</description></item>
        /// <item><description>Parsing is processed as a data query language (DQL) statement. Each call parses only one script.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the lineage object. <c>upstreamTables</c> is the list of upstream table names. <c>downstreamTables</c> is the list of downstream table names. <c>success</c> indicates whether the parsing was successful. <c>errorMsg</c> provides the reason when parsing fails. When parsing fails, the outer layer also returns an SQL validation error. Use <c>errCode</c> and <c>errMessage</c> to troubleshoot the issue. Common causes include unparseable script syntax or Base64 decoding failure. <c>requestId</c> is used to locate the current call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlTableLineageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlTableLineageResponse
        /// </returns>
        public async Task<GetSqlTableLineageResponse> GetSqlTableLineageWithOptionsAsync(GetSqlTableLineageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultSchema))
            {
                body["defaultSchema"] = request.DefaultSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dialect))
            {
                body["dialect"] = request.Dialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScriptBase64))
            {
                body["sourceSqlScriptBase64"] = request.SourceSqlScriptBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlTableLineage",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/getTableLineage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlTableLineageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses table-level lineage from a single SQL script and returns the names of upstream and downstream tables referenced by the script.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Parses table-level lineage from a single SQL script and returns the names of upstream and downstream tables referenced by the script. Use this operation to identify the scope of tables involved in a script before performing batch conversions, or to provide a basis for configuring table name mapping.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>dialect</c> specifies the SQL dialect used by the script (such as hive). During parsing, the same dialect is used for both the source and target. This operation only performs parsing and does not perform cross-dialect rewriting. <c>defaultSchema</c> specifies the default database name, which is used to complete table references in the script that do not explicitly specify a database name. <c>sourceSqlScriptBase64</c> specifies the script content to be parsed, which must be Base64-encoded before being passed in. The server decodes the content before parsing.</description></item>
        /// <item><description>Parsing is processed as a data query language (DQL) statement. Each call parses only one script.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the lineage object. <c>upstreamTables</c> is the list of upstream table names. <c>downstreamTables</c> is the list of downstream table names. <c>success</c> indicates whether the parsing was successful. <c>errorMsg</c> provides the reason when parsing fails. When parsing fails, the outer layer also returns an SQL validation error. Use <c>errCode</c> and <c>errMessage</c> to troubleshoot the issue. Common causes include unparseable script syntax or Base64 decoding failure. <c>requestId</c> is used to locate the current call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlTableLineageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlTableLineageResponse
        /// </returns>
        public GetSqlTableLineageResponse GetSqlTableLineage(GetSqlTableLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSqlTableLineageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses table-level lineage from a single SQL script and returns the names of upstream and downstream tables referenced by the script.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Parses table-level lineage from a single SQL script and returns the names of upstream and downstream tables referenced by the script. Use this operation to identify the scope of tables involved in a script before performing batch conversions, or to provide a basis for configuring table name mapping.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>dialect</c> specifies the SQL dialect used by the script (such as hive). During parsing, the same dialect is used for both the source and target. This operation only performs parsing and does not perform cross-dialect rewriting. <c>defaultSchema</c> specifies the default database name, which is used to complete table references in the script that do not explicitly specify a database name. <c>sourceSqlScriptBase64</c> specifies the script content to be parsed, which must be Base64-encoded before being passed in. The server decodes the content before parsing.</description></item>
        /// <item><description>Parsing is processed as a data query language (DQL) statement. Each call parses only one script.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>A single-value response is returned. <c>data</c> is the lineage object. <c>upstreamTables</c> is the list of upstream table names. <c>downstreamTables</c> is the list of downstream table names. <c>success</c> indicates whether the parsing was successful. <c>errorMsg</c> provides the reason when parsing fails. When parsing fails, the outer layer also returns an SQL validation error. Use <c>errCode</c> and <c>errMessage</c> to troubleshoot the issue. Common causes include unparseable script syntax or Base64 decoding failure. <c>requestId</c> is used to locate the current call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlTableLineageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlTableLineageResponse
        /// </returns>
        public async Task<GetSqlTableLineageResponse> GetSqlTableLineageAsync(GetSqlTableLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSqlTableLineageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves table metadata information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Parses a single SQL script and returns the list of table names referenced in the script. Use this operation before performing a conversion to confirm which tables the script references, facilitating table name mapping preparation or conversion scope verification.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects (such as hive or maxcompute). <c>sourceSqlScript</c> is the script content to be parsed. You must Base64-encode the script before passing it in. The server decodes the content before parsing. Passing the raw script directly causes a decoding failure and prevents parsing.</description></item>
        /// <item><description>Parsing treats the input as a data query language (DQL) statement. Each call parses only one script.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. <c>data</c> is a string array where each item is a table name parsed from the script. If the script contains no table references, an empty list is returned. If parsing fails, a SQL validation error is returned. <c>errCode</c> and <c>errMessage</c> provide the failure reason. <c>requestId</c> identifies the call for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlTransTableMetaInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlTransTableMetaInfoResponse
        /// </returns>
        public GetSqlTransTableMetaInfoResponse GetSqlTransTableMetaInfoWithOptions(GetSqlTransTableMetaInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlTransTableMetaInfo",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/get-table-info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlTransTableMetaInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves table metadata information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Parses a single SQL script and returns the list of table names referenced in the script. Use this operation before performing a conversion to confirm which tables the script references, facilitating table name mapping preparation or conversion scope verification.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects (such as hive or maxcompute). <c>sourceSqlScript</c> is the script content to be parsed. You must Base64-encode the script before passing it in. The server decodes the content before parsing. Passing the raw script directly causes a decoding failure and prevents parsing.</description></item>
        /// <item><description>Parsing treats the input as a data query language (DQL) statement. Each call parses only one script.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. <c>data</c> is a string array where each item is a table name parsed from the script. If the script contains no table references, an empty list is returned. If parsing fails, a SQL validation error is returned. <c>errCode</c> and <c>errMessage</c> provide the failure reason. <c>requestId</c> identifies the call for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlTransTableMetaInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlTransTableMetaInfoResponse
        /// </returns>
        public async Task<GetSqlTransTableMetaInfoResponse> GetSqlTransTableMetaInfoWithOptionsAsync(GetSqlTransTableMetaInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlTransTableMetaInfo",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/get-table-info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlTransTableMetaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves table metadata information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Parses a single SQL script and returns the list of table names referenced in the script. Use this operation before performing a conversion to confirm which tables the script references, facilitating table name mapping preparation or conversion scope verification.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects (such as hive or maxcompute). <c>sourceSqlScript</c> is the script content to be parsed. You must Base64-encode the script before passing it in. The server decodes the content before parsing. Passing the raw script directly causes a decoding failure and prevents parsing.</description></item>
        /// <item><description>Parsing treats the input as a data query language (DQL) statement. Each call parses only one script.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. <c>data</c> is a string array where each item is a table name parsed from the script. If the script contains no table references, an empty list is returned. If parsing fails, a SQL validation error is returned. <c>errCode</c> and <c>errMessage</c> provide the failure reason. <c>requestId</c> identifies the call for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlTransTableMetaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlTransTableMetaInfoResponse
        /// </returns>
        public GetSqlTransTableMetaInfoResponse GetSqlTransTableMetaInfo(GetSqlTransTableMetaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSqlTransTableMetaInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves table metadata information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Parses a single SQL script and returns the list of table names referenced in the script. Use this operation before performing a conversion to confirm which tables the script references, facilitating table name mapping preparation or conversion scope verification.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sourceDialect</c> and <c>targetDialect</c> specify the source and target SQL dialects (such as hive or maxcompute). <c>sourceSqlScript</c> is the script content to be parsed. You must Base64-encode the script before passing it in. The server decodes the content before parsing. Passing the raw script directly causes a decoding failure and prevents parsing.</description></item>
        /// <item><description>Parsing treats the input as a data query language (DQL) statement. Each call parses only one script.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. <c>data</c> is a string array where each item is a table name parsed from the script. If the script contains no table references, an empty list is returned. If parsing fails, a SQL validation error is returned. <c>errCode</c> and <c>errMessage</c> provide the failure reason. <c>requestId</c> identifies the call for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlTransTableMetaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlTransTableMetaInfoResponse
        /// </returns>
        public async Task<GetSqlTransTableMetaInfoResponse> GetSqlTransTableMetaInfoAsync(GetSqlTransTableMetaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSqlTransTableMetaInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the step-level result overview by validation result ID to determine the overall pass status of a single validation step.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the result overview of a single validation step by validation result ID. The response includes the consistency conclusion, the number of validated and passed fields and metrics, and the table, partition, and metric information for both the source and target. This is useful for quickly determining the overall pass status when drilling down to a specific validation result in a report.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>resultId</c> is required. It is the unique ID of the validation result, obtained from the <c>resultId</c> field returned by the validation report query operation.</description></item>
        /// <item><description>Each call queries only one validation result. To retrieve field-level comparison details for the result, call the field-level detail operation.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value object. <c>data</c> is the overview object: <c>resultId</c> echoes the validation result ID of this query. <c>status</c> indicates the step status. Valid values: 0 (created), 1 (running), 2 (completed), 3 (stopped), 4 (canceled). <c>isConsistent</c> indicates whether the source and target are consistent. Valid values: 0 (inconsistent), 1 (consistent). <c>checkColumnCount</c> and <c>passColumnCount</c> indicate the number of validated fields and the number of passed fields. <c>metricColumnCount</c> and <c>metricPassColumnCount</c> indicate the number of validated metrics and the number of passed metrics. <c>sourceTable</c> and <c>targetTable</c>, <c>sourcePtName</c> and <c>targetPtName</c>, <c>srcMetricName</c> and <c>dstMetricName</c> provide the table names, partition names, and metric names for the source and target respectively. The consistency conclusion and statistics are meaningful only when the step status is completed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStepResultOverviewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStepResultOverviewResponse
        /// </returns>
        public GetStepResultOverviewResponse GetStepResultOverviewWithOptions(GetStepResultOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["resultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStepResultOverview",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/result/overview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStepResultOverviewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the step-level result overview by validation result ID to determine the overall pass status of a single validation step.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the result overview of a single validation step by validation result ID. The response includes the consistency conclusion, the number of validated and passed fields and metrics, and the table, partition, and metric information for both the source and target. This is useful for quickly determining the overall pass status when drilling down to a specific validation result in a report.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>resultId</c> is required. It is the unique ID of the validation result, obtained from the <c>resultId</c> field returned by the validation report query operation.</description></item>
        /// <item><description>Each call queries only one validation result. To retrieve field-level comparison details for the result, call the field-level detail operation.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value object. <c>data</c> is the overview object: <c>resultId</c> echoes the validation result ID of this query. <c>status</c> indicates the step status. Valid values: 0 (created), 1 (running), 2 (completed), 3 (stopped), 4 (canceled). <c>isConsistent</c> indicates whether the source and target are consistent. Valid values: 0 (inconsistent), 1 (consistent). <c>checkColumnCount</c> and <c>passColumnCount</c> indicate the number of validated fields and the number of passed fields. <c>metricColumnCount</c> and <c>metricPassColumnCount</c> indicate the number of validated metrics and the number of passed metrics. <c>sourceTable</c> and <c>targetTable</c>, <c>sourcePtName</c> and <c>targetPtName</c>, <c>srcMetricName</c> and <c>dstMetricName</c> provide the table names, partition names, and metric names for the source and target respectively. The consistency conclusion and statistics are meaningful only when the step status is completed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStepResultOverviewRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStepResultOverviewResponse
        /// </returns>
        public async Task<GetStepResultOverviewResponse> GetStepResultOverviewWithOptionsAsync(GetStepResultOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["resultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStepResultOverview",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/result/overview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStepResultOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the step-level result overview by validation result ID to determine the overall pass status of a single validation step.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the result overview of a single validation step by validation result ID. The response includes the consistency conclusion, the number of validated and passed fields and metrics, and the table, partition, and metric information for both the source and target. This is useful for quickly determining the overall pass status when drilling down to a specific validation result in a report.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>resultId</c> is required. It is the unique ID of the validation result, obtained from the <c>resultId</c> field returned by the validation report query operation.</description></item>
        /// <item><description>Each call queries only one validation result. To retrieve field-level comparison details for the result, call the field-level detail operation.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value object. <c>data</c> is the overview object: <c>resultId</c> echoes the validation result ID of this query. <c>status</c> indicates the step status. Valid values: 0 (created), 1 (running), 2 (completed), 3 (stopped), 4 (canceled). <c>isConsistent</c> indicates whether the source and target are consistent. Valid values: 0 (inconsistent), 1 (consistent). <c>checkColumnCount</c> and <c>passColumnCount</c> indicate the number of validated fields and the number of passed fields. <c>metricColumnCount</c> and <c>metricPassColumnCount</c> indicate the number of validated metrics and the number of passed metrics. <c>sourceTable</c> and <c>targetTable</c>, <c>sourcePtName</c> and <c>targetPtName</c>, <c>srcMetricName</c> and <c>dstMetricName</c> provide the table names, partition names, and metric names for the source and target respectively. The consistency conclusion and statistics are meaningful only when the step status is completed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStepResultOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStepResultOverviewResponse
        /// </returns>
        public GetStepResultOverviewResponse GetStepResultOverview(GetStepResultOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetStepResultOverviewWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the step-level result overview by validation result ID to determine the overall pass status of a single validation step.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the result overview of a single validation step by validation result ID. The response includes the consistency conclusion, the number of validated and passed fields and metrics, and the table, partition, and metric information for both the source and target. This is useful for quickly determining the overall pass status when drilling down to a specific validation result in a report.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>resultId</c> is required. It is the unique ID of the validation result, obtained from the <c>resultId</c> field returned by the validation report query operation.</description></item>
        /// <item><description>Each call queries only one validation result. To retrieve field-level comparison details for the result, call the field-level detail operation.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a single-value object. <c>data</c> is the overview object: <c>resultId</c> echoes the validation result ID of this query. <c>status</c> indicates the step status. Valid values: 0 (created), 1 (running), 2 (completed), 3 (stopped), 4 (canceled). <c>isConsistent</c> indicates whether the source and target are consistent. Valid values: 0 (inconsistent), 1 (consistent). <c>checkColumnCount</c> and <c>passColumnCount</c> indicate the number of validated fields and the number of passed fields. <c>metricColumnCount</c> and <c>metricPassColumnCount</c> indicate the number of validated metrics and the number of passed metrics. <c>sourceTable</c> and <c>targetTable</c>, <c>sourcePtName</c> and <c>targetPtName</c>, <c>srcMetricName</c> and <c>dstMetricName</c> provide the table names, partition names, and metric names for the source and target respectively. The consistency conclusion and statistics are meaningful only when the step status is completed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStepResultOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStepResultOverviewResponse
        /// </returns>
        public async Task<GetStepResultOverviewResponse> GetStepResultOverviewAsync(GetStepResultOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetStepResultOverviewWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries field (column) dimension validation details by validation result ID with paging, and returns the comparison results and threshold evaluation for each field between the source and destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries field (column) dimension validation details by validation result ID with paging. The response returns the comparison results between the source and destination for each field, the comparison rule used, the expected threshold, and the actual difference. Use this operation to drill down validation conclusions to the field level and identify which column was determined to be inconsistent and by which rule.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>resultId</c> is required. It specifies the validation result ID, which is obtained from the validation report query operation or the step overview operation.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. They specify the page number (starting from 1) and the number of entries per page, respectively. The default value of <c>pageSize</c> is 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is paginated: <c>totalCount</c> indicates the total number of fields that meet the conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the field details for the current page. Each element in the list contains the step ID <c>stepId</c>, the field name and field type for the source and destination (<c>srcColumnName</c>, <c>srcColumnType</c>, <c>dstColumnName</c>, <c>dstColumnType</c>), the metric key and alias for the source and destination (<c>srcMetricColumn</c>, <c>dstMetricColumn</c>, <c>srcAlias</c>, <c>dstAlias</c>), the comparison rule <c>checkRule</c>, the expected threshold <c>expectThreshold</c>, the result values for the source and destination (<c>srcResult</c>, <c>dstResult</c>), the actual difference <c>actualThreshold</c>, the validation result <c>isConsistent</c> (0: inconsistent, 1: consistent, 2: manually repaired), and the execution result <c>checkResult</c> (0: no record, 1: passed, 2: failed). When troubleshooting differences, compare <c>srcResult</c> and <c>dstResult</c> against <c>actualThreshold</c> to determine whether it exceeds <c>expectThreshold</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckColumnResultsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckColumnResultsResponse
        /// </returns>
        public ListDataCheckColumnResultsResponse ListDataCheckColumnResultsWithOptions(ListDataCheckColumnResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["resultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckColumnResults",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/column/page",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckColumnResultsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries field (column) dimension validation details by validation result ID with paging, and returns the comparison results and threshold evaluation for each field between the source and destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries field (column) dimension validation details by validation result ID with paging. The response returns the comparison results between the source and destination for each field, the comparison rule used, the expected threshold, and the actual difference. Use this operation to drill down validation conclusions to the field level and identify which column was determined to be inconsistent and by which rule.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>resultId</c> is required. It specifies the validation result ID, which is obtained from the validation report query operation or the step overview operation.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. They specify the page number (starting from 1) and the number of entries per page, respectively. The default value of <c>pageSize</c> is 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is paginated: <c>totalCount</c> indicates the total number of fields that meet the conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the field details for the current page. Each element in the list contains the step ID <c>stepId</c>, the field name and field type for the source and destination (<c>srcColumnName</c>, <c>srcColumnType</c>, <c>dstColumnName</c>, <c>dstColumnType</c>), the metric key and alias for the source and destination (<c>srcMetricColumn</c>, <c>dstMetricColumn</c>, <c>srcAlias</c>, <c>dstAlias</c>), the comparison rule <c>checkRule</c>, the expected threshold <c>expectThreshold</c>, the result values for the source and destination (<c>srcResult</c>, <c>dstResult</c>), the actual difference <c>actualThreshold</c>, the validation result <c>isConsistent</c> (0: inconsistent, 1: consistent, 2: manually repaired), and the execution result <c>checkResult</c> (0: no record, 1: passed, 2: failed). When troubleshooting differences, compare <c>srcResult</c> and <c>dstResult</c> against <c>actualThreshold</c> to determine whether it exceeds <c>expectThreshold</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckColumnResultsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckColumnResultsResponse
        /// </returns>
        public async Task<ListDataCheckColumnResultsResponse> ListDataCheckColumnResultsWithOptionsAsync(ListDataCheckColumnResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["resultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckColumnResults",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/column/page",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckColumnResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries field (column) dimension validation details by validation result ID with paging, and returns the comparison results and threshold evaluation for each field between the source and destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries field (column) dimension validation details by validation result ID with paging. The response returns the comparison results between the source and destination for each field, the comparison rule used, the expected threshold, and the actual difference. Use this operation to drill down validation conclusions to the field level and identify which column was determined to be inconsistent and by which rule.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>resultId</c> is required. It specifies the validation result ID, which is obtained from the validation report query operation or the step overview operation.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. They specify the page number (starting from 1) and the number of entries per page, respectively. The default value of <c>pageSize</c> is 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is paginated: <c>totalCount</c> indicates the total number of fields that meet the conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the field details for the current page. Each element in the list contains the step ID <c>stepId</c>, the field name and field type for the source and destination (<c>srcColumnName</c>, <c>srcColumnType</c>, <c>dstColumnName</c>, <c>dstColumnType</c>), the metric key and alias for the source and destination (<c>srcMetricColumn</c>, <c>dstMetricColumn</c>, <c>srcAlias</c>, <c>dstAlias</c>), the comparison rule <c>checkRule</c>, the expected threshold <c>expectThreshold</c>, the result values for the source and destination (<c>srcResult</c>, <c>dstResult</c>), the actual difference <c>actualThreshold</c>, the validation result <c>isConsistent</c> (0: inconsistent, 1: consistent, 2: manually repaired), and the execution result <c>checkResult</c> (0: no record, 1: passed, 2: failed). When troubleshooting differences, compare <c>srcResult</c> and <c>dstResult</c> against <c>actualThreshold</c> to determine whether it exceeds <c>expectThreshold</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckColumnResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckColumnResultsResponse
        /// </returns>
        public ListDataCheckColumnResultsResponse ListDataCheckColumnResults(ListDataCheckColumnResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataCheckColumnResultsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries field (column) dimension validation details by validation result ID with paging, and returns the comparison results and threshold evaluation for each field between the source and destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries field (column) dimension validation details by validation result ID with paging. The response returns the comparison results between the source and destination for each field, the comparison rule used, the expected threshold, and the actual difference. Use this operation to drill down validation conclusions to the field level and identify which column was determined to be inconsistent and by which rule.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>resultId</c> is required. It specifies the validation result ID, which is obtained from the validation report query operation or the step overview operation.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. They specify the page number (starting from 1) and the number of entries per page, respectively. The default value of <c>pageSize</c> is 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is paginated: <c>totalCount</c> indicates the total number of fields that meet the conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the field details for the current page. Each element in the list contains the step ID <c>stepId</c>, the field name and field type for the source and destination (<c>srcColumnName</c>, <c>srcColumnType</c>, <c>dstColumnName</c>, <c>dstColumnType</c>), the metric key and alias for the source and destination (<c>srcMetricColumn</c>, <c>dstMetricColumn</c>, <c>srcAlias</c>, <c>dstAlias</c>), the comparison rule <c>checkRule</c>, the expected threshold <c>expectThreshold</c>, the result values for the source and destination (<c>srcResult</c>, <c>dstResult</c>), the actual difference <c>actualThreshold</c>, the validation result <c>isConsistent</c> (0: inconsistent, 1: consistent, 2: manually repaired), and the execution result <c>checkResult</c> (0: no record, 1: passed, 2: failed). When troubleshooting differences, compare <c>srcResult</c> and <c>dstResult</c> against <c>actualThreshold</c> to determine whether it exceeds <c>expectThreshold</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckColumnResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckColumnResultsResponse
        /// </returns>
        public async Task<ListDataCheckColumnResultsResponse> ListDataCheckColumnResultsAsync(ListDataCheckColumnResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataCheckColumnResultsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询校验任务配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按数据校验任务 ID 分页查询该任务下的表明细配置，支持按源表名称模糊筛选，用于在任务包含较多表时定位单张表的配置，核对源端与目标端的表、字段、分区、过滤条件与比对规则是否符合预期。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> 必填，为数据校验任务 ID。</description></item>
        /// <item><description><c>srcTable</c> 选填，按源表名称模糊搜索。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，默认值为 1 与 10。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的配置总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页配置列表。列表元素包含配置 ID、是否跳过 <c>isSkipped</c>、所属任务 <c>taskId</c> 与校验类型 <c>checkType</c>；源端的 <c>sourceDataSource</c>、<c>sourceId</c>、<c>sourceType</c>、<c>sourceTable</c>、<c>sourceColumns</c>、<c>sourcePartition</c>、<c>sourceWhereClause</c>、<c>sourceGroupClause</c>、<c>sourceHint</c>、<c>sourceSql</c> 与 <c>sourceCompareKey</c>，以及目标端一一对应的 <c>targetDataSource</c>、<c>targetId</c>、<c>targetType</c>、<c>targetTable</c>、<c>targetColumns</c>、<c>targetPartition</c>、<c>targetWhereClause</c>、<c>targetGroupClause</c>、<c>targetHint</c>、<c>targetSql</c> 与 <c>targetCompareKey</c>；比对规则相关的总数据量阈值 <c>totalCountThreshold</c>、分组数据量阈值 <c>groupCountThreshold</c>、批大小 <c>batchSize</c>、校验算法 <c>algorithm</c>、比较类型 <c>comparator</c>、指标类型 <c>metricType</c>、是否整表比对 <c>isFullTableCount</c>、源端与目标端是否校验所有列（<c>sourceCheckAllColumn</c>、<c>targetCheckAllColumn</c>）；另有配置详情 <c>taskConfigInfo</c> 与备用字段 <c>extra</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckConfigResponse
        /// </returns>
        public ListDataCheckConfigResponse ListDataCheckConfigWithOptions(ListDataCheckConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTable))
            {
                query["srcTable"] = request.SrcTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/listConfig/page",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询校验任务配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按数据校验任务 ID 分页查询该任务下的表明细配置，支持按源表名称模糊筛选，用于在任务包含较多表时定位单张表的配置，核对源端与目标端的表、字段、分区、过滤条件与比对规则是否符合预期。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> 必填，为数据校验任务 ID。</description></item>
        /// <item><description><c>srcTable</c> 选填，按源表名称模糊搜索。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，默认值为 1 与 10。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的配置总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页配置列表。列表元素包含配置 ID、是否跳过 <c>isSkipped</c>、所属任务 <c>taskId</c> 与校验类型 <c>checkType</c>；源端的 <c>sourceDataSource</c>、<c>sourceId</c>、<c>sourceType</c>、<c>sourceTable</c>、<c>sourceColumns</c>、<c>sourcePartition</c>、<c>sourceWhereClause</c>、<c>sourceGroupClause</c>、<c>sourceHint</c>、<c>sourceSql</c> 与 <c>sourceCompareKey</c>，以及目标端一一对应的 <c>targetDataSource</c>、<c>targetId</c>、<c>targetType</c>、<c>targetTable</c>、<c>targetColumns</c>、<c>targetPartition</c>、<c>targetWhereClause</c>、<c>targetGroupClause</c>、<c>targetHint</c>、<c>targetSql</c> 与 <c>targetCompareKey</c>；比对规则相关的总数据量阈值 <c>totalCountThreshold</c>、分组数据量阈值 <c>groupCountThreshold</c>、批大小 <c>batchSize</c>、校验算法 <c>algorithm</c>、比较类型 <c>comparator</c>、指标类型 <c>metricType</c>、是否整表比对 <c>isFullTableCount</c>、源端与目标端是否校验所有列（<c>sourceCheckAllColumn</c>、<c>targetCheckAllColumn</c>）；另有配置详情 <c>taskConfigInfo</c> 与备用字段 <c>extra</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckConfigResponse
        /// </returns>
        public async Task<ListDataCheckConfigResponse> ListDataCheckConfigWithOptionsAsync(ListDataCheckConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTable))
            {
                query["srcTable"] = request.SrcTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckConfig",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/config/v3/listConfig/page",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询校验任务配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按数据校验任务 ID 分页查询该任务下的表明细配置，支持按源表名称模糊筛选，用于在任务包含较多表时定位单张表的配置，核对源端与目标端的表、字段、分区、过滤条件与比对规则是否符合预期。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> 必填，为数据校验任务 ID。</description></item>
        /// <item><description><c>srcTable</c> 选填，按源表名称模糊搜索。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，默认值为 1 与 10。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的配置总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页配置列表。列表元素包含配置 ID、是否跳过 <c>isSkipped</c>、所属任务 <c>taskId</c> 与校验类型 <c>checkType</c>；源端的 <c>sourceDataSource</c>、<c>sourceId</c>、<c>sourceType</c>、<c>sourceTable</c>、<c>sourceColumns</c>、<c>sourcePartition</c>、<c>sourceWhereClause</c>、<c>sourceGroupClause</c>、<c>sourceHint</c>、<c>sourceSql</c> 与 <c>sourceCompareKey</c>，以及目标端一一对应的 <c>targetDataSource</c>、<c>targetId</c>、<c>targetType</c>、<c>targetTable</c>、<c>targetColumns</c>、<c>targetPartition</c>、<c>targetWhereClause</c>、<c>targetGroupClause</c>、<c>targetHint</c>、<c>targetSql</c> 与 <c>targetCompareKey</c>；比对规则相关的总数据量阈值 <c>totalCountThreshold</c>、分组数据量阈值 <c>groupCountThreshold</c>、批大小 <c>batchSize</c>、校验算法 <c>algorithm</c>、比较类型 <c>comparator</c>、指标类型 <c>metricType</c>、是否整表比对 <c>isFullTableCount</c>、源端与目标端是否校验所有列（<c>sourceCheckAllColumn</c>、<c>targetCheckAllColumn</c>）；另有配置详情 <c>taskConfigInfo</c> 与备用字段 <c>extra</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckConfigResponse
        /// </returns>
        public ListDataCheckConfigResponse ListDataCheckConfig(ListDataCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataCheckConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询校验任务配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按数据校验任务 ID 分页查询该任务下的表明细配置，支持按源表名称模糊筛选，用于在任务包含较多表时定位单张表的配置，核对源端与目标端的表、字段、分区、过滤条件与比对规则是否符合预期。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> 必填，为数据校验任务 ID。</description></item>
        /// <item><description><c>srcTable</c> 选填，按源表名称模糊搜索。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，默认值为 1 与 10。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的配置总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页配置列表。列表元素包含配置 ID、是否跳过 <c>isSkipped</c>、所属任务 <c>taskId</c> 与校验类型 <c>checkType</c>；源端的 <c>sourceDataSource</c>、<c>sourceId</c>、<c>sourceType</c>、<c>sourceTable</c>、<c>sourceColumns</c>、<c>sourcePartition</c>、<c>sourceWhereClause</c>、<c>sourceGroupClause</c>、<c>sourceHint</c>、<c>sourceSql</c> 与 <c>sourceCompareKey</c>，以及目标端一一对应的 <c>targetDataSource</c>、<c>targetId</c>、<c>targetType</c>、<c>targetTable</c>、<c>targetColumns</c>、<c>targetPartition</c>、<c>targetWhereClause</c>、<c>targetGroupClause</c>、<c>targetHint</c>、<c>targetSql</c> 与 <c>targetCompareKey</c>；比对规则相关的总数据量阈值 <c>totalCountThreshold</c>、分组数据量阈值 <c>groupCountThreshold</c>、批大小 <c>batchSize</c>、校验算法 <c>algorithm</c>、比较类型 <c>comparator</c>、指标类型 <c>metricType</c>、是否整表比对 <c>isFullTableCount</c>、源端与目标端是否校验所有列（<c>sourceCheckAllColumn</c>、<c>targetCheckAllColumn</c>）；另有配置详情 <c>taskConfigInfo</c> 与备用字段 <c>extra</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckConfigResponse
        /// </returns>
        public async Task<ListDataCheckConfigResponse> ListDataCheckConfigAsync(ListDataCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataCheckConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询校验报告，表维度明细</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按校验作业（批次）分页查询校验报告明细，返回每个校验子作业及其对应表的校验结果，包含行数比对、字段与指标通过情况、差异率、源端与目标端配置和错误信息，是查看一次校验执行结论的主要入口。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>请求体为 JSON 对象，其中 <c>batchId</c> 必填，为校验作业（批次）ID，取自保存校验任务接口的返回值。</description></item>
        /// <item><description><c>checkResult</c> 选填，按校验结果筛选（0 无记录、1 通过、2 不通过）；<c>jobStatus</c> 选填，按作业状态筛选（0 INIT 待运行、1 RUNNING 运行中、2 FINISHED 运行完成、3 STOPPED 终止、4 FAIL 失败、6 READY 就绪、7 SKIPPED 跳过）；<c>tableName</c> 选填，按表名筛选。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，分别表示页码（最小值与默认值为 1）与每页条数。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的明细总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页明细列表。列表元素包含批次与作业标识（<c>batchId</c>、<c>jobId</c>、<c>resultId</c>）、是否跳过 <c>isSkipped</c>、校验结果 <c>checkResult</c> 与作业状态 <c>jobStatus</c>；源端与目标端行数（<c>sourceCount</c>、<c>targetCount</c>）、实际差异与相同行数（<c>realDiffCount</c>、<c>realSameCount</c>）、预期差异行数 <c>expDiffCount</c>、差异率 <c>diffRate</c>、作业完成率 <c>completionRate</c>、仅源端或仅目标端存在的条数（<c>onlySrcCount</c>、<c>onlyDstCount</c>）；字段与指标维度的校验数与通过数（<c>checkColumCount</c>、<c>passColumCount</c>、<c>metricColumCount</c>、<c>metricPassColumCount</c>）；源端与目标端的数据源、类型、表、字段、分区、where 与 group 条件、hint、SQL 列表、比较字段与错误信息；以及阈值 <c>threshold</c>、分组数据量阈值 <c>totalCountThreshold</c>、模板名称 <c>templateName</c>、任务配置 ID <c>taskConfigId</c>、执行时间 <c>execTime</c>、完成时间 <c>finishTime</c> 与错误信息 <c>errorMsg</c>。其中的 <c>jobId</c> 与 <c>resultId</c> 可分别用于查询步骤维度明细与字段维度明细。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportResponse
        /// </returns>
        public ListDataCheckReportResponse ListDataCheckReportWithOptions(ListDataCheckReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckResult))
            {
                body["checkResult"] = request.CheckResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatus))
            {
                body["jobStatus"] = request.JobStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["tableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckReport",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/page",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询校验报告，表维度明细</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按校验作业（批次）分页查询校验报告明细，返回每个校验子作业及其对应表的校验结果，包含行数比对、字段与指标通过情况、差异率、源端与目标端配置和错误信息，是查看一次校验执行结论的主要入口。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>请求体为 JSON 对象，其中 <c>batchId</c> 必填，为校验作业（批次）ID，取自保存校验任务接口的返回值。</description></item>
        /// <item><description><c>checkResult</c> 选填，按校验结果筛选（0 无记录、1 通过、2 不通过）；<c>jobStatus</c> 选填，按作业状态筛选（0 INIT 待运行、1 RUNNING 运行中、2 FINISHED 运行完成、3 STOPPED 终止、4 FAIL 失败、6 READY 就绪、7 SKIPPED 跳过）；<c>tableName</c> 选填，按表名筛选。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，分别表示页码（最小值与默认值为 1）与每页条数。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的明细总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页明细列表。列表元素包含批次与作业标识（<c>batchId</c>、<c>jobId</c>、<c>resultId</c>）、是否跳过 <c>isSkipped</c>、校验结果 <c>checkResult</c> 与作业状态 <c>jobStatus</c>；源端与目标端行数（<c>sourceCount</c>、<c>targetCount</c>）、实际差异与相同行数（<c>realDiffCount</c>、<c>realSameCount</c>）、预期差异行数 <c>expDiffCount</c>、差异率 <c>diffRate</c>、作业完成率 <c>completionRate</c>、仅源端或仅目标端存在的条数（<c>onlySrcCount</c>、<c>onlyDstCount</c>）；字段与指标维度的校验数与通过数（<c>checkColumCount</c>、<c>passColumCount</c>、<c>metricColumCount</c>、<c>metricPassColumCount</c>）；源端与目标端的数据源、类型、表、字段、分区、where 与 group 条件、hint、SQL 列表、比较字段与错误信息；以及阈值 <c>threshold</c>、分组数据量阈值 <c>totalCountThreshold</c>、模板名称 <c>templateName</c>、任务配置 ID <c>taskConfigId</c>、执行时间 <c>execTime</c>、完成时间 <c>finishTime</c> 与错误信息 <c>errorMsg</c>。其中的 <c>jobId</c> 与 <c>resultId</c> 可分别用于查询步骤维度明细与字段维度明细。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportResponse
        /// </returns>
        public async Task<ListDataCheckReportResponse> ListDataCheckReportWithOptionsAsync(ListDataCheckReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckResult))
            {
                body["checkResult"] = request.CheckResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatus))
            {
                body["jobStatus"] = request.JobStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["tableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckReport",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/page",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询校验报告，表维度明细</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按校验作业（批次）分页查询校验报告明细，返回每个校验子作业及其对应表的校验结果，包含行数比对、字段与指标通过情况、差异率、源端与目标端配置和错误信息，是查看一次校验执行结论的主要入口。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>请求体为 JSON 对象，其中 <c>batchId</c> 必填，为校验作业（批次）ID，取自保存校验任务接口的返回值。</description></item>
        /// <item><description><c>checkResult</c> 选填，按校验结果筛选（0 无记录、1 通过、2 不通过）；<c>jobStatus</c> 选填，按作业状态筛选（0 INIT 待运行、1 RUNNING 运行中、2 FINISHED 运行完成、3 STOPPED 终止、4 FAIL 失败、6 READY 就绪、7 SKIPPED 跳过）；<c>tableName</c> 选填，按表名筛选。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，分别表示页码（最小值与默认值为 1）与每页条数。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的明细总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页明细列表。列表元素包含批次与作业标识（<c>batchId</c>、<c>jobId</c>、<c>resultId</c>）、是否跳过 <c>isSkipped</c>、校验结果 <c>checkResult</c> 与作业状态 <c>jobStatus</c>；源端与目标端行数（<c>sourceCount</c>、<c>targetCount</c>）、实际差异与相同行数（<c>realDiffCount</c>、<c>realSameCount</c>）、预期差异行数 <c>expDiffCount</c>、差异率 <c>diffRate</c>、作业完成率 <c>completionRate</c>、仅源端或仅目标端存在的条数（<c>onlySrcCount</c>、<c>onlyDstCount</c>）；字段与指标维度的校验数与通过数（<c>checkColumCount</c>、<c>passColumCount</c>、<c>metricColumCount</c>、<c>metricPassColumCount</c>）；源端与目标端的数据源、类型、表、字段、分区、where 与 group 条件、hint、SQL 列表、比较字段与错误信息；以及阈值 <c>threshold</c>、分组数据量阈值 <c>totalCountThreshold</c>、模板名称 <c>templateName</c>、任务配置 ID <c>taskConfigId</c>、执行时间 <c>execTime</c>、完成时间 <c>finishTime</c> 与错误信息 <c>errorMsg</c>。其中的 <c>jobId</c> 与 <c>resultId</c> 可分别用于查询步骤维度明细与字段维度明细。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportResponse
        /// </returns>
        public ListDataCheckReportResponse ListDataCheckReport(ListDataCheckReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataCheckReportWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询校验报告，表维度明细</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按校验作业（批次）分页查询校验报告明细，返回每个校验子作业及其对应表的校验结果，包含行数比对、字段与指标通过情况、差异率、源端与目标端配置和错误信息，是查看一次校验执行结论的主要入口。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>请求体为 JSON 对象，其中 <c>batchId</c> 必填，为校验作业（批次）ID，取自保存校验任务接口的返回值。</description></item>
        /// <item><description><c>checkResult</c> 选填，按校验结果筛选（0 无记录、1 通过、2 不通过）；<c>jobStatus</c> 选填，按作业状态筛选（0 INIT 待运行、1 RUNNING 运行中、2 FINISHED 运行完成、3 STOPPED 终止、4 FAIL 失败、6 READY 就绪、7 SKIPPED 跳过）；<c>tableName</c> 选填，按表名筛选。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，分别表示页码（最小值与默认值为 1）与每页条数。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的明细总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页明细列表。列表元素包含批次与作业标识（<c>batchId</c>、<c>jobId</c>、<c>resultId</c>）、是否跳过 <c>isSkipped</c>、校验结果 <c>checkResult</c> 与作业状态 <c>jobStatus</c>；源端与目标端行数（<c>sourceCount</c>、<c>targetCount</c>）、实际差异与相同行数（<c>realDiffCount</c>、<c>realSameCount</c>）、预期差异行数 <c>expDiffCount</c>、差异率 <c>diffRate</c>、作业完成率 <c>completionRate</c>、仅源端或仅目标端存在的条数（<c>onlySrcCount</c>、<c>onlyDstCount</c>）；字段与指标维度的校验数与通过数（<c>checkColumCount</c>、<c>passColumCount</c>、<c>metricColumCount</c>、<c>metricPassColumCount</c>）；源端与目标端的数据源、类型、表、字段、分区、where 与 group 条件、hint、SQL 列表、比较字段与错误信息；以及阈值 <c>threshold</c>、分组数据量阈值 <c>totalCountThreshold</c>、模板名称 <c>templateName</c>、任务配置 ID <c>taskConfigId</c>、执行时间 <c>execTime</c>、完成时间 <c>finishTime</c> 与错误信息 <c>errorMsg</c>。其中的 <c>jobId</c> 与 <c>resultId</c> 可分别用于查询步骤维度明细与字段维度明细。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportResponse
        /// </returns>
        public async Task<ListDataCheckReportResponse> ListDataCheckReportAsync(ListDataCheckReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataCheckReportWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of historical check instances by check task ID to trace the check results of each scheduling run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the list of historical check instances by data validation node. The response includes the batch ID, report generation time, and report label for each check execution (including each run triggered by timed scheduling). Use this operation to trace historical check records and further query the corresponding report content by batch ID.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the data validation node ID.</description></item>
        /// <item><description>A single invoke returns all historical instances under the specified node without paging. When there are many instances, use the most recent batches as needed.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. Each element in <c>data</c> represents a historical check instance: <c>batchId</c> is the batch ID (character string) that can be used as an input parameter for operations such as check report, report overview, report status, and node historical instance queries. <c>reportTime</c> is the report generation time. <c>label</c> is the report label. An empty list is returned when the node has no historical execute records. When <c>success</c> is <c>false</c>, troubleshoot by using <c>errCode</c> and <c>errMessage</c>. <c>requestId</c> is used to locate the current invoke.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportInstanceResponse
        /// </returns>
        public ListDataCheckReportInstanceResponse ListDataCheckReportInstanceWithOptions(ListDataCheckReportInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckReportInstance",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckReportInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of historical check instances by check task ID to trace the check results of each scheduling run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the list of historical check instances by data validation node. The response includes the batch ID, report generation time, and report label for each check execution (including each run triggered by timed scheduling). Use this operation to trace historical check records and further query the corresponding report content by batch ID.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the data validation node ID.</description></item>
        /// <item><description>A single invoke returns all historical instances under the specified node without paging. When there are many instances, use the most recent batches as needed.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. Each element in <c>data</c> represents a historical check instance: <c>batchId</c> is the batch ID (character string) that can be used as an input parameter for operations such as check report, report overview, report status, and node historical instance queries. <c>reportTime</c> is the report generation time. <c>label</c> is the report label. An empty list is returned when the node has no historical execute records. When <c>success</c> is <c>false</c>, troubleshoot by using <c>errCode</c> and <c>errMessage</c>. <c>requestId</c> is used to locate the current invoke.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportInstanceResponse
        /// </returns>
        public async Task<ListDataCheckReportInstanceResponse> ListDataCheckReportInstanceWithOptionsAsync(ListDataCheckReportInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckReportInstance",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckReportInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of historical check instances by check task ID to trace the check results of each scheduling run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the list of historical check instances by data validation node. The response includes the batch ID, report generation time, and report label for each check execution (including each run triggered by timed scheduling). Use this operation to trace historical check records and further query the corresponding report content by batch ID.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the data validation node ID.</description></item>
        /// <item><description>A single invoke returns all historical instances under the specified node without paging. When there are many instances, use the most recent batches as needed.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. Each element in <c>data</c> represents a historical check instance: <c>batchId</c> is the batch ID (character string) that can be used as an input parameter for operations such as check report, report overview, report status, and node historical instance queries. <c>reportTime</c> is the report generation time. <c>label</c> is the report label. An empty list is returned when the node has no historical execute records. When <c>success</c> is <c>false</c>, troubleshoot by using <c>errCode</c> and <c>errMessage</c>. <c>requestId</c> is used to locate the current invoke.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportInstanceResponse
        /// </returns>
        public ListDataCheckReportInstanceResponse ListDataCheckReportInstance(ListDataCheckReportInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataCheckReportInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of historical check instances by check task ID to trace the check results of each scheduling run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the list of historical check instances by data validation node. The response includes the batch ID, report generation time, and report label for each check execution (including each run triggered by timed scheduling). Use this operation to trace historical check records and further query the corresponding report content by batch ID.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> is required and specifies the data validation node ID.</description></item>
        /// <item><description>A single invoke returns all historical instances under the specified node without paging. When there are many instances, use the most recent batches as needed.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response is a list. Each element in <c>data</c> represents a historical check instance: <c>batchId</c> is the batch ID (character string) that can be used as an input parameter for operations such as check report, report overview, report status, and node historical instance queries. <c>reportTime</c> is the report generation time. <c>label</c> is the report label. An empty list is returned when the node has no historical execute records. When <c>success</c> is <c>false</c>, troubleshoot by using <c>errCode</c> and <c>errMessage</c>. <c>requestId</c> is used to locate the current invoke.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportInstanceResponse
        /// </returns>
        public async Task<ListDataCheckReportInstanceResponse> ListDataCheckReportInstanceAsync(ListDataCheckReportInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataCheckReportInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries step-level (partition-level) verification details by job ID with a paged query. Supports filtering by verification result and node status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries step-level (partition or shard) dimension verification details for a verification sub-job with a paged query. Supports filtering by verification result and step status. Use this operation to drill down verification conclusions to the partition level and view the source and destination data volumes, actual SQL statements executed, consistency conclusions, and error messages for each step.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>jobId</c> is required and specifies the database ID (integer) of the verification sub-job. If you have a UUID-format sub-job ID, use the operation that queries step details by UUID instead. The two operations have different parameter formats and are not interchangeable.</description></item>
        /// <item><description><c>checkResult</c> is optional and filters by verification result (0: no record, 1: passed, 2: failed). <c>jobStatus</c> is optional and filters by step status (0: INIT, 1: RUNNING, 2: FINISHED, 3: STOPPED, 4: FAIL, 6: READY, 7: SKIPPED).</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response: <c>totalCount</c> indicates the total number of steps that meet the filter conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the step details for the current page. Each list element includes the record ID <c>id</c>, step ID <c>stepId</c>, verification result ID <c>resultId</c>, parent job <c>jobId</c>, shard boundary <c>boundary</c>, source and destination partition names (<c>sourcePtName</c>, <c>targetPtName</c>), source and destination data volumes (<c>srcCount</c>, <c>dstCount</c>), source and destination SQL statements (<c>srcSql</c>, <c>dstSql</c>), step status <c>status</c> (0: created, 1: running, 2: completed, 3: stopped, 4: canceled), consistency conclusion <c>isConsistent</c> (0: inconsistent, 1: consistent), error message <c>errMessage</c>, start and end times (<c>gmtStart</c>, <c>gmtEnd</c>), creation and modification times (<c>gmtCreate</c>, <c>gmtModified</c>), verified and passed counts at the field and metric levels (<c>checkColumCount</c>, <c>passColumCount</c>, <c>metricColumCount</c>, <c>metricPassColumCount</c>), label name list <c>signNameList</c>, and reserved field <c>extra</c>. The <c>resultId</c> can be used to further query field-level details and result overview for the step.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportStepRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportStepResponse
        /// </returns>
        public ListDataCheckReportStepResponse ListDataCheckReportStepWithOptions(ListDataCheckReportStepRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckResult))
            {
                query["checkResult"] = request.CheckResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatus))
            {
                query["jobStatus"] = request.JobStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckReportStep",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/step/page",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckReportStepResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries step-level (partition-level) verification details by job ID with a paged query. Supports filtering by verification result and node status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries step-level (partition or shard) dimension verification details for a verification sub-job with a paged query. Supports filtering by verification result and step status. Use this operation to drill down verification conclusions to the partition level and view the source and destination data volumes, actual SQL statements executed, consistency conclusions, and error messages for each step.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>jobId</c> is required and specifies the database ID (integer) of the verification sub-job. If you have a UUID-format sub-job ID, use the operation that queries step details by UUID instead. The two operations have different parameter formats and are not interchangeable.</description></item>
        /// <item><description><c>checkResult</c> is optional and filters by verification result (0: no record, 1: passed, 2: failed). <c>jobStatus</c> is optional and filters by step status (0: INIT, 1: RUNNING, 2: FINISHED, 3: STOPPED, 4: FAIL, 6: READY, 7: SKIPPED).</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response: <c>totalCount</c> indicates the total number of steps that meet the filter conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the step details for the current page. Each list element includes the record ID <c>id</c>, step ID <c>stepId</c>, verification result ID <c>resultId</c>, parent job <c>jobId</c>, shard boundary <c>boundary</c>, source and destination partition names (<c>sourcePtName</c>, <c>targetPtName</c>), source and destination data volumes (<c>srcCount</c>, <c>dstCount</c>), source and destination SQL statements (<c>srcSql</c>, <c>dstSql</c>), step status <c>status</c> (0: created, 1: running, 2: completed, 3: stopped, 4: canceled), consistency conclusion <c>isConsistent</c> (0: inconsistent, 1: consistent), error message <c>errMessage</c>, start and end times (<c>gmtStart</c>, <c>gmtEnd</c>), creation and modification times (<c>gmtCreate</c>, <c>gmtModified</c>), verified and passed counts at the field and metric levels (<c>checkColumCount</c>, <c>passColumCount</c>, <c>metricColumCount</c>, <c>metricPassColumCount</c>), label name list <c>signNameList</c>, and reserved field <c>extra</c>. The <c>resultId</c> can be used to further query field-level details and result overview for the step.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportStepRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportStepResponse
        /// </returns>
        public async Task<ListDataCheckReportStepResponse> ListDataCheckReportStepWithOptionsAsync(ListDataCheckReportStepRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckResult))
            {
                query["checkResult"] = request.CheckResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatus))
            {
                query["jobStatus"] = request.JobStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckReportStep",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/step/page",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckReportStepResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries step-level (partition-level) verification details by job ID with a paged query. Supports filtering by verification result and node status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries step-level (partition or shard) dimension verification details for a verification sub-job with a paged query. Supports filtering by verification result and step status. Use this operation to drill down verification conclusions to the partition level and view the source and destination data volumes, actual SQL statements executed, consistency conclusions, and error messages for each step.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>jobId</c> is required and specifies the database ID (integer) of the verification sub-job. If you have a UUID-format sub-job ID, use the operation that queries step details by UUID instead. The two operations have different parameter formats and are not interchangeable.</description></item>
        /// <item><description><c>checkResult</c> is optional and filters by verification result (0: no record, 1: passed, 2: failed). <c>jobStatus</c> is optional and filters by step status (0: INIT, 1: RUNNING, 2: FINISHED, 3: STOPPED, 4: FAIL, 6: READY, 7: SKIPPED).</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response: <c>totalCount</c> indicates the total number of steps that meet the filter conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the step details for the current page. Each list element includes the record ID <c>id</c>, step ID <c>stepId</c>, verification result ID <c>resultId</c>, parent job <c>jobId</c>, shard boundary <c>boundary</c>, source and destination partition names (<c>sourcePtName</c>, <c>targetPtName</c>), source and destination data volumes (<c>srcCount</c>, <c>dstCount</c>), source and destination SQL statements (<c>srcSql</c>, <c>dstSql</c>), step status <c>status</c> (0: created, 1: running, 2: completed, 3: stopped, 4: canceled), consistency conclusion <c>isConsistent</c> (0: inconsistent, 1: consistent), error message <c>errMessage</c>, start and end times (<c>gmtStart</c>, <c>gmtEnd</c>), creation and modification times (<c>gmtCreate</c>, <c>gmtModified</c>), verified and passed counts at the field and metric levels (<c>checkColumCount</c>, <c>passColumCount</c>, <c>metricColumCount</c>, <c>metricPassColumCount</c>), label name list <c>signNameList</c>, and reserved field <c>extra</c>. The <c>resultId</c> can be used to further query field-level details and result overview for the step.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportStepRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportStepResponse
        /// </returns>
        public ListDataCheckReportStepResponse ListDataCheckReportStep(ListDataCheckReportStepRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataCheckReportStepWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries step-level (partition-level) verification details by job ID with a paged query. Supports filtering by verification result and node status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries step-level (partition or shard) dimension verification details for a verification sub-job with a paged query. Supports filtering by verification result and step status. Use this operation to drill down verification conclusions to the partition level and view the source and destination data volumes, actual SQL statements executed, consistency conclusions, and error messages for each step.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>jobId</c> is required and specifies the database ID (integer) of the verification sub-job. If you have a UUID-format sub-job ID, use the operation that queries step details by UUID instead. The two operations have different parameter formats and are not interchangeable.</description></item>
        /// <item><description><c>checkResult</c> is optional and filters by verification result (0: no record, 1: passed, 2: failed). <c>jobStatus</c> is optional and filters by step status (0: INIT, 1: RUNNING, 2: FINISHED, 3: STOPPED, 4: FAIL, 6: READY, 7: SKIPPED).</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional. Default values are 1 and 10.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response: <c>totalCount</c> indicates the total number of steps that meet the filter conditions, <c>pageIndex</c> and <c>pageSize</c> echo the pagination parameters of the current request, and <c>data</c> contains the step details for the current page. Each list element includes the record ID <c>id</c>, step ID <c>stepId</c>, verification result ID <c>resultId</c>, parent job <c>jobId</c>, shard boundary <c>boundary</c>, source and destination partition names (<c>sourcePtName</c>, <c>targetPtName</c>), source and destination data volumes (<c>srcCount</c>, <c>dstCount</c>), source and destination SQL statements (<c>srcSql</c>, <c>dstSql</c>), step status <c>status</c> (0: created, 1: running, 2: completed, 3: stopped, 4: canceled), consistency conclusion <c>isConsistent</c> (0: inconsistent, 1: consistent), error message <c>errMessage</c>, start and end times (<c>gmtStart</c>, <c>gmtEnd</c>), creation and modification times (<c>gmtCreate</c>, <c>gmtModified</c>), verified and passed counts at the field and metric levels (<c>checkColumCount</c>, <c>passColumCount</c>, <c>metricColumCount</c>, <c>metricPassColumCount</c>), label name list <c>signNameList</c>, and reserved field <c>extra</c>. The <c>resultId</c> can be used to further query field-level details and result overview for the step.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportStepRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportStepResponse
        /// </returns>
        public async Task<ListDataCheckReportStepResponse> ListDataCheckReportStepAsync(ListDataCheckReportStepRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataCheckReportStepWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报告-作业维度明细（分区列表）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按 UUID 形式的校验子作业 ID 分页查询 step（分区或分片）维度的校验明细。返回的明细与按数据库 ID 查询的接口一致，区别在于入参形态：本接口直接使用校验报告中给出的子作业 ID 字符串，无需先换算为数据库 ID，适合从报告结果直接下钻。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>jobId</c> 必填，为 UUID 形式的校验子作业 ID（字符串），取自校验报告查询接口返回的 <c>jobId</c>。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，默认值为 1 与 10。</description></item>
        /// <item><description>本接口不支持按校验结果或 step 状态筛选；需要筛选时改用按数据库 ID 查询 step 明细的接口。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的 step 总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页 step 明细。列表元素包含步骤 ID <c>stepId</c>、校验结果 ID <c>resultId</c>、分片边界 <c>boundary</c>、源端与目标端分区名称（<c>sourcePtName</c>、<c>targetPtName</c>）、源端与目标端数据量（<c>srcCount</c>、<c>dstCount</c>）、源端与目标端执行 SQL（<c>srcSql</c>、<c>dstSql</c>）、step 状态 <c>status</c>（0 创建、1 运行中、2 运行完成、3 停止、4 取消）、一致性结论 <c>isConsistent</c>（0 不一致、1 一致）、错误消息 <c>errMessage</c>、启动与结束时间（<c>gmtStart</c>、<c>gmtEnd</c>）、字段与指标维度的校验数与通过数（<c>checkColumCount</c>、<c>passColumCount</c>、<c>metricColumCount</c>、<c>metricPassColumCount</c>）与备用字段 <c>extra</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportStepByJobIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportStepByJobIdResponse
        /// </returns>
        public ListDataCheckReportStepByJobIdResponse ListDataCheckReportStepByJobIdWithOptions(ListDataCheckReportStepByJobIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckReportStepByJobId",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/step/pageByJobId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckReportStepByJobIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报告-作业维度明细（分区列表）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按 UUID 形式的校验子作业 ID 分页查询 step（分区或分片）维度的校验明细。返回的明细与按数据库 ID 查询的接口一致，区别在于入参形态：本接口直接使用校验报告中给出的子作业 ID 字符串，无需先换算为数据库 ID，适合从报告结果直接下钻。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>jobId</c> 必填，为 UUID 形式的校验子作业 ID（字符串），取自校验报告查询接口返回的 <c>jobId</c>。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，默认值为 1 与 10。</description></item>
        /// <item><description>本接口不支持按校验结果或 step 状态筛选；需要筛选时改用按数据库 ID 查询 step 明细的接口。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的 step 总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页 step 明细。列表元素包含步骤 ID <c>stepId</c>、校验结果 ID <c>resultId</c>、分片边界 <c>boundary</c>、源端与目标端分区名称（<c>sourcePtName</c>、<c>targetPtName</c>）、源端与目标端数据量（<c>srcCount</c>、<c>dstCount</c>）、源端与目标端执行 SQL（<c>srcSql</c>、<c>dstSql</c>）、step 状态 <c>status</c>（0 创建、1 运行中、2 运行完成、3 停止、4 取消）、一致性结论 <c>isConsistent</c>（0 不一致、1 一致）、错误消息 <c>errMessage</c>、启动与结束时间（<c>gmtStart</c>、<c>gmtEnd</c>）、字段与指标维度的校验数与通过数（<c>checkColumCount</c>、<c>passColumCount</c>、<c>metricColumCount</c>、<c>metricPassColumCount</c>）与备用字段 <c>extra</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportStepByJobIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportStepByJobIdResponse
        /// </returns>
        public async Task<ListDataCheckReportStepByJobIdResponse> ListDataCheckReportStepByJobIdWithOptionsAsync(ListDataCheckReportStepByJobIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckReportStepByJobId",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/report/v3/step/pageByJobId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckReportStepByJobIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报告-作业维度明细（分区列表）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按 UUID 形式的校验子作业 ID 分页查询 step（分区或分片）维度的校验明细。返回的明细与按数据库 ID 查询的接口一致，区别在于入参形态：本接口直接使用校验报告中给出的子作业 ID 字符串，无需先换算为数据库 ID，适合从报告结果直接下钻。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>jobId</c> 必填，为 UUID 形式的校验子作业 ID（字符串），取自校验报告查询接口返回的 <c>jobId</c>。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，默认值为 1 与 10。</description></item>
        /// <item><description>本接口不支持按校验结果或 step 状态筛选；需要筛选时改用按数据库 ID 查询 step 明细的接口。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的 step 总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页 step 明细。列表元素包含步骤 ID <c>stepId</c>、校验结果 ID <c>resultId</c>、分片边界 <c>boundary</c>、源端与目标端分区名称（<c>sourcePtName</c>、<c>targetPtName</c>）、源端与目标端数据量（<c>srcCount</c>、<c>dstCount</c>）、源端与目标端执行 SQL（<c>srcSql</c>、<c>dstSql</c>）、step 状态 <c>status</c>（0 创建、1 运行中、2 运行完成、3 停止、4 取消）、一致性结论 <c>isConsistent</c>（0 不一致、1 一致）、错误消息 <c>errMessage</c>、启动与结束时间（<c>gmtStart</c>、<c>gmtEnd</c>）、字段与指标维度的校验数与通过数（<c>checkColumCount</c>、<c>passColumCount</c>、<c>metricColumCount</c>、<c>metricPassColumCount</c>）与备用字段 <c>extra</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportStepByJobIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportStepByJobIdResponse
        /// </returns>
        public ListDataCheckReportStepByJobIdResponse ListDataCheckReportStepByJobId(ListDataCheckReportStepByJobIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataCheckReportStepByJobIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报告-作业维度明细（分区列表）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>按 UUID 形式的校验子作业 ID 分页查询 step（分区或分片）维度的校验明细。返回的明细与按数据库 ID 查询的接口一致，区别在于入参形态：本接口直接使用校验报告中给出的子作业 ID 字符串，无需先换算为数据库 ID，适合从报告结果直接下钻。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>jobId</c> 必填，为 UUID 形式的校验子作业 ID（字符串），取自校验报告查询接口返回的 <c>jobId</c>。</description></item>
        /// <item><description><c>pageIndex</c> 与 <c>pageSize</c> 选填，默认值为 1 与 10。</description></item>
        /// <item><description>本接口不支持按校验结果或 step 状态筛选；需要筛选时改用按数据库 ID 查询 step 明细的接口。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回分页响应：<c>totalCount</c> 为满足条件的 step 总数，<c>pageIndex</c> 与 <c>pageSize</c> 回显本次分页参数，<c>data</c> 为当前页 step 明细。列表元素包含步骤 ID <c>stepId</c>、校验结果 ID <c>resultId</c>、分片边界 <c>boundary</c>、源端与目标端分区名称（<c>sourcePtName</c>、<c>targetPtName</c>）、源端与目标端数据量（<c>srcCount</c>、<c>dstCount</c>）、源端与目标端执行 SQL（<c>srcSql</c>、<c>dstSql</c>）、step 状态 <c>status</c>（0 创建、1 运行中、2 运行完成、3 停止、4 取消）、一致性结论 <c>isConsistent</c>（0 不一致、1 一致）、错误消息 <c>errMessage</c>、启动与结束时间（<c>gmtStart</c>、<c>gmtEnd</c>）、字段与指标维度的校验数与通过数（<c>checkColumCount</c>、<c>passColumCount</c>、<c>metricColumCount</c>、<c>metricPassColumCount</c>）与备用字段 <c>extra</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckReportStepByJobIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckReportStepByJobIdResponse
        /// </returns>
        public async Task<ListDataCheckReportStepByJobIdResponse> ListDataCheckReportStepByJobIdAsync(ListDataCheckReportStepByJobIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataCheckReportStepByJobIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries historical instances of data validation nodes by batch ID and node ID with paging. Supports filtering by execute status, validation result, and time ranges for creation, execute start, and execute end.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries historical execute instances (batches) of data validation nodes with paging. Supports combined filtering by batch ID, node ID, execute status, validation result, and three types of time ranges: creation time, execute start time, and execute end time. Returns table count statistics, pass rate, start and end times, and execute duration for each execution. Use this operation to review historical validation execute details and result trends.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required and specifies the validation job (batch) ID.</description></item>
        /// <item><description><c>taskId</c> is optional and specifies the data validation task ID. <c>execStatus</c> is optional and filters by execution status (0: pending, 1: running, 2: stopped, 3: failed, 4: completed). <c>checkResult</c> is optional and filters by validation result (0: no records, 1: passed, 2: failed).</description></item>
        /// <item><description><c>createStartTime</c> and <c>createEndTime</c>, <c>execStartTime</c> and <c>execEndTime</c>, <c>finishStartTime</c> and <c>finishEndTime</c> define the filter ranges for job creation time, execution start time, and execution end time, respectively. The format is YYYY-MM-DD HH:MM:SS. Specify both the start and end values in pairs.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional and specify the page number and the number of entries per page, respectively.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response. <c>totalCount</c> indicates the total number of historical instances that meet the filter conditions. <c>pageIndex</c> and <c>pageSize</c> reflect the pagination parameters of the current request. <c>data</c> contains the list of instances on the current page. Each list element includes batch identifiers (<c>batchId</c>, <c>originBatchId</c>, <c>seqId</c>), report title and report time (<c>reportTitle</c>, <c>reportTime</c>), the number of validated tables and the number of tables with errors, successes, and skips (<c>checkTableNum</c>, <c>errorTableNum</c>, <c>successfulTableNum</c>, <c>skipTableNum</c>), execution status <c>execStatus</c> and validation result <c>checkResult</c>, start and end times (<c>startTime</c>, <c>endTime</c>) and execution duration <c>execTime</c>, task progress <c>progress</c>, pass rate <c>passProcess</c> and its percentage string form <c>passProcessExport</c>, scheduling cycle expression <c>cronExp</c>, batch concurrency <c>concurrency</c>, scheduled task ID <c>scheduleId</c>, creator and updater (<c>creator</c>, <c>operator</c>), creation and last modification times (<c>gmtCreate</c>, <c>gmtModified</c>), error message <c>errorMsg</c>, reserved field <c>extra</c>, and business field <c>biz</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckTaskHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckTaskHistoryResponse
        /// </returns>
        public ListDataCheckTaskHistoryResponse ListDataCheckTaskHistoryWithOptions(ListDataCheckTaskHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckResult))
            {
                query["checkResult"] = request.CheckResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecEndTime))
            {
                query["execEndTime"] = request.ExecEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecStartTime))
            {
                query["execStartTime"] = request.ExecStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecStatus))
            {
                query["execStatus"] = request.ExecStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishEndTime))
            {
                query["finishEndTime"] = request.FinishEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishStartTime))
            {
                query["finishStartTime"] = request.FinishStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckTaskHistory",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckTaskHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries historical instances of data validation nodes by batch ID and node ID with paging. Supports filtering by execute status, validation result, and time ranges for creation, execute start, and execute end.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries historical execute instances (batches) of data validation nodes with paging. Supports combined filtering by batch ID, node ID, execute status, validation result, and three types of time ranges: creation time, execute start time, and execute end time. Returns table count statistics, pass rate, start and end times, and execute duration for each execution. Use this operation to review historical validation execute details and result trends.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required and specifies the validation job (batch) ID.</description></item>
        /// <item><description><c>taskId</c> is optional and specifies the data validation task ID. <c>execStatus</c> is optional and filters by execution status (0: pending, 1: running, 2: stopped, 3: failed, 4: completed). <c>checkResult</c> is optional and filters by validation result (0: no records, 1: passed, 2: failed).</description></item>
        /// <item><description><c>createStartTime</c> and <c>createEndTime</c>, <c>execStartTime</c> and <c>execEndTime</c>, <c>finishStartTime</c> and <c>finishEndTime</c> define the filter ranges for job creation time, execution start time, and execution end time, respectively. The format is YYYY-MM-DD HH:MM:SS. Specify both the start and end values in pairs.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional and specify the page number and the number of entries per page, respectively.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response. <c>totalCount</c> indicates the total number of historical instances that meet the filter conditions. <c>pageIndex</c> and <c>pageSize</c> reflect the pagination parameters of the current request. <c>data</c> contains the list of instances on the current page. Each list element includes batch identifiers (<c>batchId</c>, <c>originBatchId</c>, <c>seqId</c>), report title and report time (<c>reportTitle</c>, <c>reportTime</c>), the number of validated tables and the number of tables with errors, successes, and skips (<c>checkTableNum</c>, <c>errorTableNum</c>, <c>successfulTableNum</c>, <c>skipTableNum</c>), execution status <c>execStatus</c> and validation result <c>checkResult</c>, start and end times (<c>startTime</c>, <c>endTime</c>) and execution duration <c>execTime</c>, task progress <c>progress</c>, pass rate <c>passProcess</c> and its percentage string form <c>passProcessExport</c>, scheduling cycle expression <c>cronExp</c>, batch concurrency <c>concurrency</c>, scheduled task ID <c>scheduleId</c>, creator and updater (<c>creator</c>, <c>operator</c>), creation and last modification times (<c>gmtCreate</c>, <c>gmtModified</c>), error message <c>errorMsg</c>, reserved field <c>extra</c>, and business field <c>biz</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckTaskHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckTaskHistoryResponse
        /// </returns>
        public async Task<ListDataCheckTaskHistoryResponse> ListDataCheckTaskHistoryWithOptionsAsync(ListDataCheckTaskHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["batchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckResult))
            {
                query["checkResult"] = request.CheckResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecEndTime))
            {
                query["execEndTime"] = request.ExecEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecStartTime))
            {
                query["execStartTime"] = request.ExecStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecStatus))
            {
                query["execStatus"] = request.ExecStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishEndTime))
            {
                query["finishEndTime"] = request.FinishEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishStartTime))
            {
                query["finishStartTime"] = request.FinishStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCheckTaskHistory",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCheckTaskHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries historical instances of data validation nodes by batch ID and node ID with paging. Supports filtering by execute status, validation result, and time ranges for creation, execute start, and execute end.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries historical execute instances (batches) of data validation nodes with paging. Supports combined filtering by batch ID, node ID, execute status, validation result, and three types of time ranges: creation time, execute start time, and execute end time. Returns table count statistics, pass rate, start and end times, and execute duration for each execution. Use this operation to review historical validation execute details and result trends.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required and specifies the validation job (batch) ID.</description></item>
        /// <item><description><c>taskId</c> is optional and specifies the data validation task ID. <c>execStatus</c> is optional and filters by execution status (0: pending, 1: running, 2: stopped, 3: failed, 4: completed). <c>checkResult</c> is optional and filters by validation result (0: no records, 1: passed, 2: failed).</description></item>
        /// <item><description><c>createStartTime</c> and <c>createEndTime</c>, <c>execStartTime</c> and <c>execEndTime</c>, <c>finishStartTime</c> and <c>finishEndTime</c> define the filter ranges for job creation time, execution start time, and execution end time, respectively. The format is YYYY-MM-DD HH:MM:SS. Specify both the start and end values in pairs.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional and specify the page number and the number of entries per page, respectively.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response. <c>totalCount</c> indicates the total number of historical instances that meet the filter conditions. <c>pageIndex</c> and <c>pageSize</c> reflect the pagination parameters of the current request. <c>data</c> contains the list of instances on the current page. Each list element includes batch identifiers (<c>batchId</c>, <c>originBatchId</c>, <c>seqId</c>), report title and report time (<c>reportTitle</c>, <c>reportTime</c>), the number of validated tables and the number of tables with errors, successes, and skips (<c>checkTableNum</c>, <c>errorTableNum</c>, <c>successfulTableNum</c>, <c>skipTableNum</c>), execution status <c>execStatus</c> and validation result <c>checkResult</c>, start and end times (<c>startTime</c>, <c>endTime</c>) and execution duration <c>execTime</c>, task progress <c>progress</c>, pass rate <c>passProcess</c> and its percentage string form <c>passProcessExport</c>, scheduling cycle expression <c>cronExp</c>, batch concurrency <c>concurrency</c>, scheduled task ID <c>scheduleId</c>, creator and updater (<c>creator</c>, <c>operator</c>), creation and last modification times (<c>gmtCreate</c>, <c>gmtModified</c>), error message <c>errorMsg</c>, reserved field <c>extra</c>, and business field <c>biz</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckTaskHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckTaskHistoryResponse
        /// </returns>
        public ListDataCheckTaskHistoryResponse ListDataCheckTaskHistory(ListDataCheckTaskHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataCheckTaskHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries historical instances of data validation nodes by batch ID and node ID with paging. Supports filtering by execute status, validation result, and time ranges for creation, execute start, and execute end.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries historical execute instances (batches) of data validation nodes with paging. Supports combined filtering by batch ID, node ID, execute status, validation result, and three types of time ranges: creation time, execute start time, and execute end time. Returns table count statistics, pass rate, start and end times, and execute duration for each execution. Use this operation to review historical validation execute details and result trends.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>batchId</c> is required and specifies the validation job (batch) ID.</description></item>
        /// <item><description><c>taskId</c> is optional and specifies the data validation task ID. <c>execStatus</c> is optional and filters by execution status (0: pending, 1: running, 2: stopped, 3: failed, 4: completed). <c>checkResult</c> is optional and filters by validation result (0: no records, 1: passed, 2: failed).</description></item>
        /// <item><description><c>createStartTime</c> and <c>createEndTime</c>, <c>execStartTime</c> and <c>execEndTime</c>, <c>finishStartTime</c> and <c>finishEndTime</c> define the filter ranges for job creation time, execution start time, and execution end time, respectively. The format is YYYY-MM-DD HH:MM:SS. Specify both the start and end values in pairs.</description></item>
        /// <item><description><c>pageIndex</c> and <c>pageSize</c> are optional and specify the page number and the number of entries per page, respectively.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a paginated response. <c>totalCount</c> indicates the total number of historical instances that meet the filter conditions. <c>pageIndex</c> and <c>pageSize</c> reflect the pagination parameters of the current request. <c>data</c> contains the list of instances on the current page. Each list element includes batch identifiers (<c>batchId</c>, <c>originBatchId</c>, <c>seqId</c>), report title and report time (<c>reportTitle</c>, <c>reportTime</c>), the number of validated tables and the number of tables with errors, successes, and skips (<c>checkTableNum</c>, <c>errorTableNum</c>, <c>successfulTableNum</c>, <c>skipTableNum</c>), execution status <c>execStatus</c> and validation result <c>checkResult</c>, start and end times (<c>startTime</c>, <c>endTime</c>) and execution duration <c>execTime</c>, task progress <c>progress</c>, pass rate <c>passProcess</c> and its percentage string form <c>passProcessExport</c>, scheduling cycle expression <c>cronExp</c>, batch concurrency <c>concurrency</c>, scheduled task ID <c>scheduleId</c>, creator and updater (<c>creator</c>, <c>operator</c>), creation and last modification times (<c>gmtCreate</c>, <c>gmtModified</c>), error message <c>errorMsg</c>, reserved field <c>extra</c>, and business field <c>biz</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataCheckTaskHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCheckTaskHistoryResponse
        /// </returns>
        public async Task<ListDataCheckTaskHistoryResponse> ListDataCheckTaskHistoryAsync(ListDataCheckTaskHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataCheckTaskHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata data source list by paging and returns the data source type, connection status, and status information of associated profiling nodes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the metadata data source list by paging and returns the basic information, connectivity status, and associated profiling node status of each data source. This operation is used for data source management, selection, and troubleshooting.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. You can filter results by data source type, name, connectivity status, and categorization. The dsName parameter supports exact match or fuzzy match. The pageIndex parameter starts from 1, and pageSize specifies the number of records per page. The orderBy and orderDirection parameters control the sorting field and sorting direction. The needTotalCount parameter specifies whether to return the total number of records in the paging result.</para>
        /// <h2>Response description</h2>
        /// <para>The totalCount parameter indicates the total number of records that meet the conditional filter criteria. The pageIndex and pageSize parameters echo the paging parameters. The data parameter contains the list of data sources on the current page. Each element in the list contains the datasource config (sensitive fields such as tokens are masked in the response) and profiling node information. If a data source is not associated with a profiling node, the profilingJob field is empty.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMetaDataComponentPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMetaDataComponentPageResponse
        /// </returns>
        public ListMetaDataComponentPageResponse ListMetaDataComponentPageWithOptions(ListMetaDataComponentPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["categoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                body["componentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsName))
            {
                body["dsName"] = request.DsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsStatus))
            {
                body["dsStatus"] = request.DsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsType))
            {
                body["dsType"] = request.DsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsTypeList))
            {
                body["dsTypeList"] = request.DsTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                body["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                body["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcComponentId))
            {
                body["srcComponentId"] = request.SrcComponentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMetaDataComponentPage",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component/page",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMetaDataComponentPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata data source list by paging and returns the data source type, connection status, and status information of associated profiling nodes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the metadata data source list by paging and returns the basic information, connectivity status, and associated profiling node status of each data source. This operation is used for data source management, selection, and troubleshooting.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. You can filter results by data source type, name, connectivity status, and categorization. The dsName parameter supports exact match or fuzzy match. The pageIndex parameter starts from 1, and pageSize specifies the number of records per page. The orderBy and orderDirection parameters control the sorting field and sorting direction. The needTotalCount parameter specifies whether to return the total number of records in the paging result.</para>
        /// <h2>Response description</h2>
        /// <para>The totalCount parameter indicates the total number of records that meet the conditional filter criteria. The pageIndex and pageSize parameters echo the paging parameters. The data parameter contains the list of data sources on the current page. Each element in the list contains the datasource config (sensitive fields such as tokens are masked in the response) and profiling node information. If a data source is not associated with a profiling node, the profilingJob field is empty.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMetaDataComponentPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMetaDataComponentPageResponse
        /// </returns>
        public async Task<ListMetaDataComponentPageResponse> ListMetaDataComponentPageWithOptionsAsync(ListMetaDataComponentPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["categoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                body["componentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsName))
            {
                body["dsName"] = request.DsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsStatus))
            {
                body["dsStatus"] = request.DsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsType))
            {
                body["dsType"] = request.DsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsTypeList))
            {
                body["dsTypeList"] = request.DsTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                body["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                body["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcComponentId))
            {
                body["srcComponentId"] = request.SrcComponentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMetaDataComponentPage",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/v2/meta/data-component/page",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMetaDataComponentPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata data source list by paging and returns the data source type, connection status, and status information of associated profiling nodes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the metadata data source list by paging and returns the basic information, connectivity status, and associated profiling node status of each data source. This operation is used for data source management, selection, and troubleshooting.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. You can filter results by data source type, name, connectivity status, and categorization. The dsName parameter supports exact match or fuzzy match. The pageIndex parameter starts from 1, and pageSize specifies the number of records per page. The orderBy and orderDirection parameters control the sorting field and sorting direction. The needTotalCount parameter specifies whether to return the total number of records in the paging result.</para>
        /// <h2>Response description</h2>
        /// <para>The totalCount parameter indicates the total number of records that meet the conditional filter criteria. The pageIndex and pageSize parameters echo the paging parameters. The data parameter contains the list of data sources on the current page. Each element in the list contains the datasource config (sensitive fields such as tokens are masked in the response) and profiling node information. If a data source is not associated with a profiling node, the profilingJob field is empty.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMetaDataComponentPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMetaDataComponentPageResponse
        /// </returns>
        public ListMetaDataComponentPageResponse ListMetaDataComponentPage(ListMetaDataComponentPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMetaDataComponentPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata data source list by paging and returns the data source type, connection status, and status information of associated profiling nodes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the metadata data source list by paging and returns the basic information, connectivity status, and associated profiling node status of each data source. This operation is used for data source management, selection, and troubleshooting.</para>
        /// <h2>Request description</h2>
        /// <para>The request body is a JSON object. You can filter results by data source type, name, connectivity status, and categorization. The dsName parameter supports exact match or fuzzy match. The pageIndex parameter starts from 1, and pageSize specifies the number of records per page. The orderBy and orderDirection parameters control the sorting field and sorting direction. The needTotalCount parameter specifies whether to return the total number of records in the paging result.</para>
        /// <h2>Response description</h2>
        /// <para>The totalCount parameter indicates the total number of records that meet the conditional filter criteria. The pageIndex and pageSize parameters echo the paging parameters. The data parameter contains the list of data sources on the current page. Each element in the list contains the datasource config (sensitive fields such as tokens are masked in the response) and profiling node information. If a data source is not associated with a profiling node, the profilingJob field is empty.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMetaDataComponentPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMetaDataComponentPageResponse
        /// </returns>
        public async Task<ListMetaDataComponentPageResponse> ListMetaDataComponentPageAsync(ListMetaDataComponentPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMetaDataComponentPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>User Scheduling Task Transformation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>This is an internal interface for submitting a workflow transformation task. It submits a workflow transformation based on the source, target data sources, and SQL node type mapping. The interface synchronously returns the acceptance result, and the asynchronous execution result can be queried through GetInnerConvertAsyncResult.</para>
        /// <h2>Request Description</h2>
        /// <para>The request body is a JSON object. <c>srcDataSourceName</c> and <c>tgtDataSourceName</c> are the names of the scheduling data sources at the source and target ends of the transformation task, respectively; <c>sqlConvertMap</c> is the mapping from source node types to target node types, which is written into the transformation configuration if not empty.</para>
        /// <h2>Response Description</h2>
        /// <para>When successful, <c>data</c> returns the identifier of the transformation task (a string) for subsequent asynchronous result queries; in specific error cases such as multiple data sources with the same name, <c>data</c> carries the detailed error text; in case of failure, use <c>errCode</c> and <c>errMessage</c> for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerConvertRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostInnerConvertResponse
        /// </returns>
        public PostInnerConvertResponse PostInnerConvertWithOptions(PostInnerConvertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlConvertMap))
            {
                body["sqlConvertMap"] = request.SqlConvertMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDataSourceName))
            {
                body["srcDataSourceName"] = request.SrcDataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtDataSourceName))
            {
                body["tgtDataSourceName"] = request.TgtDataSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostInnerConvert",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/convert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostInnerConvertResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>User Scheduling Task Transformation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>This is an internal interface for submitting a workflow transformation task. It submits a workflow transformation based on the source, target data sources, and SQL node type mapping. The interface synchronously returns the acceptance result, and the asynchronous execution result can be queried through GetInnerConvertAsyncResult.</para>
        /// <h2>Request Description</h2>
        /// <para>The request body is a JSON object. <c>srcDataSourceName</c> and <c>tgtDataSourceName</c> are the names of the scheduling data sources at the source and target ends of the transformation task, respectively; <c>sqlConvertMap</c> is the mapping from source node types to target node types, which is written into the transformation configuration if not empty.</para>
        /// <h2>Response Description</h2>
        /// <para>When successful, <c>data</c> returns the identifier of the transformation task (a string) for subsequent asynchronous result queries; in specific error cases such as multiple data sources with the same name, <c>data</c> carries the detailed error text; in case of failure, use <c>errCode</c> and <c>errMessage</c> for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerConvertRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostInnerConvertResponse
        /// </returns>
        public async Task<PostInnerConvertResponse> PostInnerConvertWithOptionsAsync(PostInnerConvertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlConvertMap))
            {
                body["sqlConvertMap"] = request.SqlConvertMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDataSourceName))
            {
                body["srcDataSourceName"] = request.SrcDataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtDataSourceName))
            {
                body["tgtDataSourceName"] = request.TgtDataSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostInnerConvert",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/convert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostInnerConvertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>User Scheduling Task Transformation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>This is an internal interface for submitting a workflow transformation task. It submits a workflow transformation based on the source, target data sources, and SQL node type mapping. The interface synchronously returns the acceptance result, and the asynchronous execution result can be queried through GetInnerConvertAsyncResult.</para>
        /// <h2>Request Description</h2>
        /// <para>The request body is a JSON object. <c>srcDataSourceName</c> and <c>tgtDataSourceName</c> are the names of the scheduling data sources at the source and target ends of the transformation task, respectively; <c>sqlConvertMap</c> is the mapping from source node types to target node types, which is written into the transformation configuration if not empty.</para>
        /// <h2>Response Description</h2>
        /// <para>When successful, <c>data</c> returns the identifier of the transformation task (a string) for subsequent asynchronous result queries; in specific error cases such as multiple data sources with the same name, <c>data</c> carries the detailed error text; in case of failure, use <c>errCode</c> and <c>errMessage</c> for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerConvertRequest
        /// </param>
        /// 
        /// <returns>
        /// PostInnerConvertResponse
        /// </returns>
        public PostInnerConvertResponse PostInnerConvert(PostInnerConvertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PostInnerConvertWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>User Scheduling Task Transformation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>This is an internal interface for submitting a workflow transformation task. It submits a workflow transformation based on the source, target data sources, and SQL node type mapping. The interface synchronously returns the acceptance result, and the asynchronous execution result can be queried through GetInnerConvertAsyncResult.</para>
        /// <h2>Request Description</h2>
        /// <para>The request body is a JSON object. <c>srcDataSourceName</c> and <c>tgtDataSourceName</c> are the names of the scheduling data sources at the source and target ends of the transformation task, respectively; <c>sqlConvertMap</c> is the mapping from source node types to target node types, which is written into the transformation configuration if not empty.</para>
        /// <h2>Response Description</h2>
        /// <para>When successful, <c>data</c> returns the identifier of the transformation task (a string) for subsequent asynchronous result queries; in specific error cases such as multiple data sources with the same name, <c>data</c> carries the detailed error text; in case of failure, use <c>errCode</c> and <c>errMessage</c> for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerConvertRequest
        /// </param>
        /// 
        /// <returns>
        /// PostInnerConvertResponse
        /// </returns>
        public async Task<PostInnerConvertResponse> PostInnerConvertAsync(PostInnerConvertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PostInnerConvertWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调度skillread</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>源端工作流读取任务提交内部接口。按数据源名称提交一次源端工作流读取，接口同步返回受理结果，读取的异步执行结果通过 GetInnerReadAsyncResult 查询。</para>
        /// <h2>请求说明</h2>
        /// <para>请求体为 JSON 对象，dataSourceName 指定读取任务的数据源名称；数据源缺失时可改由 dataSourceDescriptor 在入参中一次传齐数据源描述信息作为兜底。</para>
        /// <h2>返回说明</h2>
        /// <para>成功时 data 返回读取任务标识（字符串），用于后续异步结果查询；命中多个同名数据源等特定错误时 data 承载错误明细文本；失败时结合 errCode 与 errMessage 排查。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerReaderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostInnerReaderResponse
        /// </returns>
        public PostInnerReaderResponse PostInnerReaderWithOptions(PostInnerReaderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceDescriptor))
            {
                body["dataSourceDescriptor"] = request.DataSourceDescriptor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostInnerReader",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/read",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostInnerReaderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调度skillread</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>源端工作流读取任务提交内部接口。按数据源名称提交一次源端工作流读取，接口同步返回受理结果，读取的异步执行结果通过 GetInnerReadAsyncResult 查询。</para>
        /// <h2>请求说明</h2>
        /// <para>请求体为 JSON 对象，dataSourceName 指定读取任务的数据源名称；数据源缺失时可改由 dataSourceDescriptor 在入参中一次传齐数据源描述信息作为兜底。</para>
        /// <h2>返回说明</h2>
        /// <para>成功时 data 返回读取任务标识（字符串），用于后续异步结果查询；命中多个同名数据源等特定错误时 data 承载错误明细文本；失败时结合 errCode 与 errMessage 排查。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerReaderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostInnerReaderResponse
        /// </returns>
        public async Task<PostInnerReaderResponse> PostInnerReaderWithOptionsAsync(PostInnerReaderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceDescriptor))
            {
                body["dataSourceDescriptor"] = request.DataSourceDescriptor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostInnerReader",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/read",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostInnerReaderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调度skillread</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>源端工作流读取任务提交内部接口。按数据源名称提交一次源端工作流读取，接口同步返回受理结果，读取的异步执行结果通过 GetInnerReadAsyncResult 查询。</para>
        /// <h2>请求说明</h2>
        /// <para>请求体为 JSON 对象，dataSourceName 指定读取任务的数据源名称；数据源缺失时可改由 dataSourceDescriptor 在入参中一次传齐数据源描述信息作为兜底。</para>
        /// <h2>返回说明</h2>
        /// <para>成功时 data 返回读取任务标识（字符串），用于后续异步结果查询；命中多个同名数据源等特定错误时 data 承载错误明细文本；失败时结合 errCode 与 errMessage 排查。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerReaderRequest
        /// </param>
        /// 
        /// <returns>
        /// PostInnerReaderResponse
        /// </returns>
        public PostInnerReaderResponse PostInnerReader(PostInnerReaderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PostInnerReaderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调度skillread</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>源端工作流读取任务提交内部接口。按数据源名称提交一次源端工作流读取，接口同步返回受理结果，读取的异步执行结果通过 GetInnerReadAsyncResult 查询。</para>
        /// <h2>请求说明</h2>
        /// <para>请求体为 JSON 对象，dataSourceName 指定读取任务的数据源名称；数据源缺失时可改由 dataSourceDescriptor 在入参中一次传齐数据源描述信息作为兜底。</para>
        /// <h2>返回说明</h2>
        /// <para>成功时 data 返回读取任务标识（字符串），用于后续异步结果查询；命中多个同名数据源等特定错误时 data 承载错误明细文本；失败时结合 errCode 与 errMessage 排查。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerReaderRequest
        /// </param>
        /// 
        /// <returns>
        /// PostInnerReaderResponse
        /// </returns>
        public async Task<PostInnerReaderResponse> PostInnerReaderAsync(PostInnerReaderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PostInnerReaderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a local conversion result package for subsequent batch writing to the destination scheduling system. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Uploads a local conversion result package and overwrites the existing result package on the task for subsequent batch writing to the destination scheduling system. This operation is applicable to scenarios where you need to modify conversion results locally before uploading them back. First, export the conversion result package, modify the file content offline, and then use this operation to overwrite and upload the package.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. taskId specifies the scheduling migration task ID and determines which task the result package belongs to. fileName specifies the file name. fileContentBase64 specifies the file content, which must be Base64-encoded before being sent. The server decodes the content before saving it.</description></item>
        /// <item><description>The upload uses overwrite semantics. Uploading again for the same task replaces the existing result package. Confirm that the local file is the expected final version before uploading.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. data contains the upload result information as a string. A successful upload only indicates that the result package has been received by the server and overwritten on the corresponding task. It does not mean that the data has been written to the destination scheduling system. Writing requires a separate submit action. If the call fails, troubleshoot by using errCode and errMessage. Common causes include a nonexistent task ID, invalid file content, or Base64 decoding failure. requestId identifies this specific call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerUploadConvertPackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostInnerUploadConvertPackageResponse
        /// </returns>
        public PostInnerUploadConvertPackageResponse PostInnerUploadConvertPackageWithOptions(PostInnerUploadConvertPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileContentBase64))
            {
                body["fileContentBase64"] = request.FileContentBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostInnerUploadConvertPackage",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/convert/upload-package",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostInnerUploadConvertPackageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a local conversion result package for subsequent batch writing to the destination scheduling system. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Uploads a local conversion result package and overwrites the existing result package on the task for subsequent batch writing to the destination scheduling system. This operation is applicable to scenarios where you need to modify conversion results locally before uploading them back. First, export the conversion result package, modify the file content offline, and then use this operation to overwrite and upload the package.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. taskId specifies the scheduling migration task ID and determines which task the result package belongs to. fileName specifies the file name. fileContentBase64 specifies the file content, which must be Base64-encoded before being sent. The server decodes the content before saving it.</description></item>
        /// <item><description>The upload uses overwrite semantics. Uploading again for the same task replaces the existing result package. Confirm that the local file is the expected final version before uploading.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. data contains the upload result information as a string. A successful upload only indicates that the result package has been received by the server and overwritten on the corresponding task. It does not mean that the data has been written to the destination scheduling system. Writing requires a separate submit action. If the call fails, troubleshoot by using errCode and errMessage. Common causes include a nonexistent task ID, invalid file content, or Base64 decoding failure. requestId identifies this specific call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerUploadConvertPackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostInnerUploadConvertPackageResponse
        /// </returns>
        public async Task<PostInnerUploadConvertPackageResponse> PostInnerUploadConvertPackageWithOptionsAsync(PostInnerUploadConvertPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileContentBase64))
            {
                body["fileContentBase64"] = request.FileContentBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostInnerUploadConvertPackage",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/skill/inner/v1/convert/upload-package",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostInnerUploadConvertPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a local conversion result package for subsequent batch writing to the destination scheduling system. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Uploads a local conversion result package and overwrites the existing result package on the task for subsequent batch writing to the destination scheduling system. This operation is applicable to scenarios where you need to modify conversion results locally before uploading them back. First, export the conversion result package, modify the file content offline, and then use this operation to overwrite and upload the package.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. taskId specifies the scheduling migration task ID and determines which task the result package belongs to. fileName specifies the file name. fileContentBase64 specifies the file content, which must be Base64-encoded before being sent. The server decodes the content before saving it.</description></item>
        /// <item><description>The upload uses overwrite semantics. Uploading again for the same task replaces the existing result package. Confirm that the local file is the expected final version before uploading.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. data contains the upload result information as a string. A successful upload only indicates that the result package has been received by the server and overwritten on the corresponding task. It does not mean that the data has been written to the destination scheduling system. Writing requires a separate submit action. If the call fails, troubleshoot by using errCode and errMessage. Common causes include a nonexistent task ID, invalid file content, or Base64 decoding failure. requestId identifies this specific call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerUploadConvertPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// PostInnerUploadConvertPackageResponse
        /// </returns>
        public PostInnerUploadConvertPackageResponse PostInnerUploadConvertPackage(PostInnerUploadConvertPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PostInnerUploadConvertPackageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a local conversion result package for subsequent batch writing to the destination scheduling system. This is a Skill internal operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Uploads a local conversion result package and overwrites the existing result package on the task for subsequent batch writing to the destination scheduling system. This operation is applicable to scenarios where you need to modify conversion results locally before uploading them back. First, export the conversion result package, modify the file content offline, and then use this operation to overwrite and upload the package.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. taskId specifies the scheduling migration task ID and determines which task the result package belongs to. fileName specifies the file name. fileContentBase64 specifies the file content, which must be Base64-encoded before being sent. The server decodes the content before saving it.</description></item>
        /// <item><description>The upload uses overwrite semantics. Uploading again for the same task replaces the existing result package. Confirm that the local file is the expected final version before uploading.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. data contains the upload result information as a string. A successful upload only indicates that the result package has been received by the server and overwritten on the corresponding task. It does not mean that the data has been written to the destination scheduling system. Writing requires a separate submit action. If the call fails, troubleshoot by using errCode and errMessage. Common causes include a nonexistent task ID, invalid file content, or Base64 decoding failure. requestId identifies this specific call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PostInnerUploadConvertPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// PostInnerUploadConvertPackageResponse
        /// </returns>
        public async Task<PostInnerUploadConvertPackageResponse> PostInnerUploadConvertPackageAsync(PostInnerUploadConvertPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PostInnerUploadConvertPackageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a Dry Run validation on a single converted SQL statement to verify syntax and execution permissions without actually writing data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a Dry Run validation on a single SQL statement against a specified data source. This operation verifies whether the syntax can be parsed and whether the required execution permissions are granted, without actually writing data. Use this operation to validate individual SQL statements before batch execution of converted SQL, reducing the risk of failures during formal execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sql</c> specifies the SQL statement to validate. <c>datasourceName</c> specifies the name of the data source used for validation, which must be a registered and connectable data source.</description></item>
        /// <item><description>Dry Run only performs validation without producing data changes and can be called repeatedly. After validation succeeds, submit the formal SQL execution job.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the Dry Run execution result (string). If validation fails, the operation returns an error: <c>errCode</c> is DRY_RUN_ERROR, and <c>errMessage</c> provides the specific reason (such as a syntax error or insufficient execution permissions). Use this information to correct the SQL statement or datasource config and retry. <c>requestId</c> identifies the current call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleSqlDryRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleSqlDryRunResponse
        /// </returns>
        public SingleSqlDryRunResponse SingleSqlDryRunWithOptions(SingleSqlDryRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceName))
            {
                body["datasourceName"] = request.DatasourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleSqlDryRun",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/dryRun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleSqlDryRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a Dry Run validation on a single converted SQL statement to verify syntax and execution permissions without actually writing data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a Dry Run validation on a single SQL statement against a specified data source. This operation verifies whether the syntax can be parsed and whether the required execution permissions are granted, without actually writing data. Use this operation to validate individual SQL statements before batch execution of converted SQL, reducing the risk of failures during formal execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sql</c> specifies the SQL statement to validate. <c>datasourceName</c> specifies the name of the data source used for validation, which must be a registered and connectable data source.</description></item>
        /// <item><description>Dry Run only performs validation without producing data changes and can be called repeatedly. After validation succeeds, submit the formal SQL execution job.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the Dry Run execution result (string). If validation fails, the operation returns an error: <c>errCode</c> is DRY_RUN_ERROR, and <c>errMessage</c> provides the specific reason (such as a syntax error or insufficient execution permissions). Use this information to correct the SQL statement or datasource config and retry. <c>requestId</c> identifies the current call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleSqlDryRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleSqlDryRunResponse
        /// </returns>
        public async Task<SingleSqlDryRunResponse> SingleSqlDryRunWithOptionsAsync(SingleSqlDryRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceName))
            {
                body["datasourceName"] = request.DatasourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleSqlDryRun",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/dryRun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleSqlDryRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a Dry Run validation on a single converted SQL statement to verify syntax and execution permissions without actually writing data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a Dry Run validation on a single SQL statement against a specified data source. This operation verifies whether the syntax can be parsed and whether the required execution permissions are granted, without actually writing data. Use this operation to validate individual SQL statements before batch execution of converted SQL, reducing the risk of failures during formal execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sql</c> specifies the SQL statement to validate. <c>datasourceName</c> specifies the name of the data source used for validation, which must be a registered and connectable data source.</description></item>
        /// <item><description>Dry Run only performs validation without producing data changes and can be called repeatedly. After validation succeeds, submit the formal SQL execution job.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the Dry Run execution result (string). If validation fails, the operation returns an error: <c>errCode</c> is DRY_RUN_ERROR, and <c>errMessage</c> provides the specific reason (such as a syntax error or insufficient execution permissions). Use this information to correct the SQL statement or datasource config and retry. <c>requestId</c> identifies the current call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleSqlDryRunRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleSqlDryRunResponse
        /// </returns>
        public SingleSqlDryRunResponse SingleSqlDryRun(SingleSqlDryRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SingleSqlDryRunWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a Dry Run validation on a single converted SQL statement to verify syntax and execution permissions without actually writing data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a Dry Run validation on a single SQL statement against a specified data source. This operation verifies whether the syntax can be parsed and whether the required execution permissions are granted, without actually writing data. Use this operation to validate individual SQL statements before batch execution of converted SQL, reducing the risk of failures during formal execution.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. <c>sql</c> specifies the SQL statement to validate. <c>datasourceName</c> specifies the name of the data source used for validation, which must be a registered and connectable data source.</description></item>
        /// <item><description>Dry Run only performs validation without producing data changes and can be called repeatedly. After validation succeeds, submit the formal SQL execution job.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>Returns a single-value response. <c>data</c> contains the Dry Run execution result (string). If validation fails, the operation returns an error: <c>errCode</c> is DRY_RUN_ERROR, and <c>errMessage</c> provides the specific reason (such as a syntax error or insufficient execution permissions). Use this information to correct the SQL statement or datasource config and retry. <c>requestId</c> identifies the current call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleSqlDryRunRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleSqlDryRunResponse
        /// </returns>
        public async Task<SingleSqlDryRunResponse> SingleSqlDryRunAsync(SingleSqlDryRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SingleSqlDryRunWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对某个sql转换任务校验+转换</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>对指定的 SQL 转换任务先执行语法校验、再执行转换，在一次调用内串起「校验 + 转换」两个动作，适用于希望在转换前自动拦截语法问题、而不必分两步分别调用的场景。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> 必填，为 SQL 转换任务 ID。</description></item>
        /// <item><description>调用会校验任务归属，只能处理归属于当前账号的任务，否则返回鉴权失败。</description></item>
        /// <item><description>本接口按任务维度触发处理，不接受逐条脚本入参；脚本较多时处理耗时较长。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回单值响应，<c>data</c> 为对象，其中 <c>taskId</c> 回显本次处理的任务 ID。逐条脚本的校验与转换结果不在本接口返回，需调用查询转换进度接口跟踪进展、调用查询转换结果接口获取每条脚本的源语句、目标语句与转换状态。<c>success</c> 为 <c>false</c> 时说明语法校验或转换环节失败，结合 <c>errCode</c> 与 <c>errMessage</c> 定位原因；<c>requestId</c> 用于排查本次调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyntaxCheckAndTransformSqlConversionTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyntaxCheckAndTransformSqlConversionTaskResponse
        /// </returns>
        public SyntaxCheckAndTransformSqlConversionTaskResponse SyntaxCheckAndTransformSqlConversionTaskWithOptions(SyntaxCheckAndTransformSqlConversionTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyntaxCheckAndTransformSqlConversionTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/api/syntaxCheckAndTransformTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyntaxCheckAndTransformSqlConversionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对某个sql转换任务校验+转换</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>对指定的 SQL 转换任务先执行语法校验、再执行转换，在一次调用内串起「校验 + 转换」两个动作，适用于希望在转换前自动拦截语法问题、而不必分两步分别调用的场景。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> 必填，为 SQL 转换任务 ID。</description></item>
        /// <item><description>调用会校验任务归属，只能处理归属于当前账号的任务，否则返回鉴权失败。</description></item>
        /// <item><description>本接口按任务维度触发处理，不接受逐条脚本入参；脚本较多时处理耗时较长。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回单值响应，<c>data</c> 为对象，其中 <c>taskId</c> 回显本次处理的任务 ID。逐条脚本的校验与转换结果不在本接口返回，需调用查询转换进度接口跟踪进展、调用查询转换结果接口获取每条脚本的源语句、目标语句与转换状态。<c>success</c> 为 <c>false</c> 时说明语法校验或转换环节失败，结合 <c>errCode</c> 与 <c>errMessage</c> 定位原因；<c>requestId</c> 用于排查本次调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyntaxCheckAndTransformSqlConversionTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyntaxCheckAndTransformSqlConversionTaskResponse
        /// </returns>
        public async Task<SyntaxCheckAndTransformSqlConversionTaskResponse> SyntaxCheckAndTransformSqlConversionTaskWithOptionsAsync(SyntaxCheckAndTransformSqlConversionTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyntaxCheckAndTransformSqlConversionTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/api/syntaxCheckAndTransformTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyntaxCheckAndTransformSqlConversionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对某个sql转换任务校验+转换</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>对指定的 SQL 转换任务先执行语法校验、再执行转换，在一次调用内串起「校验 + 转换」两个动作，适用于希望在转换前自动拦截语法问题、而不必分两步分别调用的场景。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> 必填，为 SQL 转换任务 ID。</description></item>
        /// <item><description>调用会校验任务归属，只能处理归属于当前账号的任务，否则返回鉴权失败。</description></item>
        /// <item><description>本接口按任务维度触发处理，不接受逐条脚本入参；脚本较多时处理耗时较长。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回单值响应，<c>data</c> 为对象，其中 <c>taskId</c> 回显本次处理的任务 ID。逐条脚本的校验与转换结果不在本接口返回，需调用查询转换进度接口跟踪进展、调用查询转换结果接口获取每条脚本的源语句、目标语句与转换状态。<c>success</c> 为 <c>false</c> 时说明语法校验或转换环节失败，结合 <c>errCode</c> 与 <c>errMessage</c> 定位原因；<c>requestId</c> 用于排查本次调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyntaxCheckAndTransformSqlConversionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SyntaxCheckAndTransformSqlConversionTaskResponse
        /// </returns>
        public SyntaxCheckAndTransformSqlConversionTaskResponse SyntaxCheckAndTransformSqlConversionTask(SyntaxCheckAndTransformSqlConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyntaxCheckAndTransformSqlConversionTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对某个sql转换任务校验+转换</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>对指定的 SQL 转换任务先执行语法校验、再执行转换，在一次调用内串起「校验 + 转换」两个动作，适用于希望在转换前自动拦截语法问题、而不必分两步分别调用的场景。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>taskId</c> 必填，为 SQL 转换任务 ID。</description></item>
        /// <item><description>调用会校验任务归属，只能处理归属于当前账号的任务，否则返回鉴权失败。</description></item>
        /// <item><description>本接口按任务维度触发处理，不接受逐条脚本入参；脚本较多时处理耗时较长。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回单值响应，<c>data</c> 为对象，其中 <c>taskId</c> 回显本次处理的任务 ID。逐条脚本的校验与转换结果不在本接口返回，需调用查询转换进度接口跟踪进展、调用查询转换结果接口获取每条脚本的源语句、目标语句与转换状态。<c>success</c> 为 <c>false</c> 时说明语法校验或转换环节失败，结合 <c>errCode</c> 与 <c>errMessage</c> 定位原因；<c>requestId</c> 用于排查本次调用。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyntaxCheckAndTransformSqlConversionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SyntaxCheckAndTransformSqlConversionTaskResponse
        /// </returns>
        public async Task<SyntaxCheckAndTransformSqlConversionTaskResponse> SyntaxCheckAndTransformSqlConversionTaskAsync(SyntaxCheckAndTransformSqlConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyntaxCheckAndTransformSqlConversionTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an existing data validation task. You can adjust the basic task information, source and destination data sources, validation engines, and the referenced validation template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Modifies an existing data validation task. You can adjust the task name and description, source and destination data sources, source and destination validation engines, and the validation template referenced by the task. This operation is used to correct configurations or change the source of comparison rules after a task is created.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. The <c>id</c> field is required and specifies the ID of the data validation task to modify. All other fields are optional. Fields that are not included in the request retain their original values.</description></item>
        /// <item><description><c>taskName</c> supports only Chinese characters, English letters, and digits. <c>taskDescription</c> specifies the task description.</description></item>
        /// <item><description><c>srcDsId</c>, <c>srcDsName</c>, and <c>srcDsType</c> describe the source data source. <c>dstDsId</c>, <c>dstDsName</c>, and <c>dstDsType</c> describe the destination data source. <c>srcEngineId</c>, <c>srcEngineName</c>, and <c>srcEngineType</c> describe the source validation engine. <c>dstEngineId</c>, <c>dstEngineName</c>, and <c>dstEngineType</c> describe the destination validation engine. Provide the ID, name, and type of a data source or engine as a group to avoid configuration inconsistencies caused by modifying only one of them.</description></item>
        /// <item><description>Comparison rules are indirectly adjusted through <c>checkTemplateId</c>. After you replace the template, the task runs based on the rules of the new template. If this field is not included, the original template is retained. This operation does not accept table-level detail configurations or scheduling settings. To adjust these settings, use the validation task configuration and scheduling operations.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is an integer business data value returned with the update result. To determine whether the update is successful, check the <c>success</c> field. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. Common causes include a nonexistent task ID, insufficient permissions to modify the task, or a task name that does not meet the character restrictions. <c>requestId</c> is used to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataCheckTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCheckTaskResponse
        /// </returns>
        public UpdateDataCheckTaskResponse UpdateDataCheckTaskWithOptions(UpdateDataCheckTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckTemplateId))
            {
                body["checkTemplateId"] = request.CheckTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsId))
            {
                body["dstDsId"] = request.DstDsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsName))
            {
                body["dstDsName"] = request.DstDsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsType))
            {
                body["dstDsType"] = request.DstDsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstEngineId))
            {
                body["dstEngineId"] = request.DstEngineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstEngineName))
            {
                body["dstEngineName"] = request.DstEngineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstEngineType))
            {
                body["dstEngineType"] = request.DstEngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsId))
            {
                body["srcDsId"] = request.SrcDsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsName))
            {
                body["srcDsName"] = request.SrcDsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsType))
            {
                body["srcDsType"] = request.SrcDsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngineId))
            {
                body["srcEngineId"] = request.SrcEngineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngineName))
            {
                body["srcEngineName"] = request.SrcEngineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngineType))
            {
                body["srcEngineType"] = request.SrcEngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataCheckTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an existing data validation task. You can adjust the basic task information, source and destination data sources, validation engines, and the referenced validation template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Modifies an existing data validation task. You can adjust the task name and description, source and destination data sources, source and destination validation engines, and the validation template referenced by the task. This operation is used to correct configurations or change the source of comparison rules after a task is created.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. The <c>id</c> field is required and specifies the ID of the data validation task to modify. All other fields are optional. Fields that are not included in the request retain their original values.</description></item>
        /// <item><description><c>taskName</c> supports only Chinese characters, English letters, and digits. <c>taskDescription</c> specifies the task description.</description></item>
        /// <item><description><c>srcDsId</c>, <c>srcDsName</c>, and <c>srcDsType</c> describe the source data source. <c>dstDsId</c>, <c>dstDsName</c>, and <c>dstDsType</c> describe the destination data source. <c>srcEngineId</c>, <c>srcEngineName</c>, and <c>srcEngineType</c> describe the source validation engine. <c>dstEngineId</c>, <c>dstEngineName</c>, and <c>dstEngineType</c> describe the destination validation engine. Provide the ID, name, and type of a data source or engine as a group to avoid configuration inconsistencies caused by modifying only one of them.</description></item>
        /// <item><description>Comparison rules are indirectly adjusted through <c>checkTemplateId</c>. After you replace the template, the task runs based on the rules of the new template. If this field is not included, the original template is retained. This operation does not accept table-level detail configurations or scheduling settings. To adjust these settings, use the validation task configuration and scheduling operations.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is an integer business data value returned with the update result. To determine whether the update is successful, check the <c>success</c> field. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. Common causes include a nonexistent task ID, insufficient permissions to modify the task, or a task name that does not meet the character restrictions. <c>requestId</c> is used to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataCheckTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCheckTaskResponse
        /// </returns>
        public async Task<UpdateDataCheckTaskResponse> UpdateDataCheckTaskWithOptionsAsync(UpdateDataCheckTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckTemplateId))
            {
                body["checkTemplateId"] = request.CheckTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsId))
            {
                body["dstDsId"] = request.DstDsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsName))
            {
                body["dstDsName"] = request.DstDsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDsType))
            {
                body["dstDsType"] = request.DstDsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstEngineId))
            {
                body["dstEngineId"] = request.DstEngineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstEngineName))
            {
                body["dstEngineName"] = request.DstEngineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstEngineType))
            {
                body["dstEngineType"] = request.DstEngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsId))
            {
                body["srcDsId"] = request.SrcDsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsName))
            {
                body["srcDsName"] = request.SrcDsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDsType))
            {
                body["srcDsType"] = request.SrcDsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngineId))
            {
                body["srcEngineId"] = request.SrcEngineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngineName))
            {
                body["srcEngineName"] = request.SrcEngineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngineType))
            {
                body["srcEngineType"] = request.SrcEngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataCheckTask",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/task/v3/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an existing data validation task. You can adjust the basic task information, source and destination data sources, validation engines, and the referenced validation template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Modifies an existing data validation task. You can adjust the task name and description, source and destination data sources, source and destination validation engines, and the validation template referenced by the task. This operation is used to correct configurations or change the source of comparison rules after a task is created.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. The <c>id</c> field is required and specifies the ID of the data validation task to modify. All other fields are optional. Fields that are not included in the request retain their original values.</description></item>
        /// <item><description><c>taskName</c> supports only Chinese characters, English letters, and digits. <c>taskDescription</c> specifies the task description.</description></item>
        /// <item><description><c>srcDsId</c>, <c>srcDsName</c>, and <c>srcDsType</c> describe the source data source. <c>dstDsId</c>, <c>dstDsName</c>, and <c>dstDsType</c> describe the destination data source. <c>srcEngineId</c>, <c>srcEngineName</c>, and <c>srcEngineType</c> describe the source validation engine. <c>dstEngineId</c>, <c>dstEngineName</c>, and <c>dstEngineType</c> describe the destination validation engine. Provide the ID, name, and type of a data source or engine as a group to avoid configuration inconsistencies caused by modifying only one of them.</description></item>
        /// <item><description>Comparison rules are indirectly adjusted through <c>checkTemplateId</c>. After you replace the template, the task runs based on the rules of the new template. If this field is not included, the original template is retained. This operation does not accept table-level detail configurations or scheduling settings. To adjust these settings, use the validation task configuration and scheduling operations.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is an integer business data value returned with the update result. To determine whether the update is successful, check the <c>success</c> field. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. Common causes include a nonexistent task ID, insufficient permissions to modify the task, or a task name that does not meet the character restrictions. <c>requestId</c> is used to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCheckTaskResponse
        /// </returns>
        public UpdateDataCheckTaskResponse UpdateDataCheckTask(UpdateDataCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDataCheckTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an existing data validation task. You can adjust the basic task information, source and destination data sources, validation engines, and the referenced validation template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Modifies an existing data validation task. You can adjust the task name and description, source and destination data sources, source and destination validation engines, and the validation template referenced by the task. This operation is used to correct configurations or change the source of comparison rules after a task is created.</para>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>The request body is a JSON object. The <c>id</c> field is required and specifies the ID of the data validation task to modify. All other fields are optional. Fields that are not included in the request retain their original values.</description></item>
        /// <item><description><c>taskName</c> supports only Chinese characters, English letters, and digits. <c>taskDescription</c> specifies the task description.</description></item>
        /// <item><description><c>srcDsId</c>, <c>srcDsName</c>, and <c>srcDsType</c> describe the source data source. <c>dstDsId</c>, <c>dstDsName</c>, and <c>dstDsType</c> describe the destination data source. <c>srcEngineId</c>, <c>srcEngineName</c>, and <c>srcEngineType</c> describe the source validation engine. <c>dstEngineId</c>, <c>dstEngineName</c>, and <c>dstEngineType</c> describe the destination validation engine. Provide the ID, name, and type of a data source or engine as a group to avoid configuration inconsistencies caused by modifying only one of them.</description></item>
        /// <item><description>Comparison rules are indirectly adjusted through <c>checkTemplateId</c>. After you replace the template, the task runs based on the rules of the new template. If this field is not included, the original template is retained. This operation does not accept table-level detail configurations or scheduling settings. To adjust these settings, use the validation task configuration and scheduling operations.</description></item>
        /// </list>
        /// <h2>Response description</h2>
        /// <para>The response returns a single value. <c>data</c> is an integer business data value returned with the update result. To determine whether the update is successful, check the <c>success</c> field. If <c>success</c> is <c>false</c>, use <c>errCode</c> and <c>errMessage</c> to identify the cause of the failure. Common causes include a nonexistent task ID, insufficient permissions to modify the task, or a task name that does not meet the character restrictions. <c>requestId</c> is used to troubleshoot the call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCheckTaskResponse
        /// </returns>
        public async Task<UpdateDataCheckTaskResponse> UpdateDataCheckTaskAsync(UpdateDataCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDataCheckTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据校验模版</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>更新数据校验模板的名称、描述、适用的数据源与引擎范围以及各类校验规则定义。模板被校验任务引用后，更新会改变这些任务后续执行时所采用的比对规则，请在变更前确认影响范围。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>请求体为 JSON 对象：<c>templateId</c> 指定要更新的校验模板 ID，<c>templateName</c> 与 <c>templateDesc</c> 更新模板名称与描述，<c>checkType</c> 为校验规则类型（0 数据量比对、1 指标比对、2 弱内容对比、3 自定义比对、4 全文比对、5 空值率比对），<c>dsEngineRels</c> 更新模板关联的数据源与引擎范围。</description></item>
        /// <item><description>规则字段按 <c>checkType</c> 取用：指标比对（1）使用 <c>basicMetricRules</c>（基础数据类型指标规则，该场景下应使用此字段）、<c>complexMetricRules</c>（复合数据类型指标规则）与 <c>metricRules</c>（指标规则列表）；弱内容对比（2）使用 <c>weakContentRule</c>，该场景下需要一并传入；全文比对（4）使用 <c>fulltextRule</c>；空值率比对（5）使用 <c>nullRules</c>。与 <c>checkType</c> 不匹配的规则字段不会被使用。</description></item>
        /// <item><description><c>requestId</c> 选填，为请求 ID。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回状态响应，响应体只包含 <c>success</c>、<c>errCode</c>、<c>errMessage</c> 与 <c>requestId</c>，不返回业务数据；<c>success</c> 为 <c>true</c> 即表示模板已更新，无需再回查确认。更新失败时结合 <c>errCode</c> 与 <c>errMessage</c> 排查，常见原因为模板 ID 不存在、无权修改该模板，或规则字段与 <c>checkType</c> 不匹配导致校验不通过。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCheckTemplateResponse
        /// </returns>
        public UpdateDataCheckTemplateResponse UpdateDataCheckTemplateWithOptions(UpdateDataCheckTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicMetricRules))
            {
                body["basicMetricRules"] = request.BasicMetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                body["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplexMetricRules))
            {
                body["complexMetricRules"] = request.ComplexMetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsEngineRels))
            {
                body["dsEngineRels"] = request.DsEngineRels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FulltextRule))
            {
                body["fulltextRule"] = request.FulltextRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricRules))
            {
                body["metricRules"] = request.MetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NullRules))
            {
                body["nullRules"] = request.NullRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDesc))
            {
                body["templateDesc"] = request.TemplateDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WeakContentRule))
            {
                body["weakContentRule"] = request.WeakContentRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataCheckTemplate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataCheckTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据校验模版</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>更新数据校验模板的名称、描述、适用的数据源与引擎范围以及各类校验规则定义。模板被校验任务引用后，更新会改变这些任务后续执行时所采用的比对规则，请在变更前确认影响范围。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>请求体为 JSON 对象：<c>templateId</c> 指定要更新的校验模板 ID，<c>templateName</c> 与 <c>templateDesc</c> 更新模板名称与描述，<c>checkType</c> 为校验规则类型（0 数据量比对、1 指标比对、2 弱内容对比、3 自定义比对、4 全文比对、5 空值率比对），<c>dsEngineRels</c> 更新模板关联的数据源与引擎范围。</description></item>
        /// <item><description>规则字段按 <c>checkType</c> 取用：指标比对（1）使用 <c>basicMetricRules</c>（基础数据类型指标规则，该场景下应使用此字段）、<c>complexMetricRules</c>（复合数据类型指标规则）与 <c>metricRules</c>（指标规则列表）；弱内容对比（2）使用 <c>weakContentRule</c>，该场景下需要一并传入；全文比对（4）使用 <c>fulltextRule</c>；空值率比对（5）使用 <c>nullRules</c>。与 <c>checkType</c> 不匹配的规则字段不会被使用。</description></item>
        /// <item><description><c>requestId</c> 选填，为请求 ID。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回状态响应，响应体只包含 <c>success</c>、<c>errCode</c>、<c>errMessage</c> 与 <c>requestId</c>，不返回业务数据；<c>success</c> 为 <c>true</c> 即表示模板已更新，无需再回查确认。更新失败时结合 <c>errCode</c> 与 <c>errMessage</c> 排查，常见原因为模板 ID 不存在、无权修改该模板，或规则字段与 <c>checkType</c> 不匹配导致校验不通过。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCheckTemplateResponse
        /// </returns>
        public async Task<UpdateDataCheckTemplateResponse> UpdateDataCheckTemplateWithOptionsAsync(UpdateDataCheckTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicMetricRules))
            {
                body["basicMetricRules"] = request.BasicMetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                body["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplexMetricRules))
            {
                body["complexMetricRules"] = request.ComplexMetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsEngineRels))
            {
                body["dsEngineRels"] = request.DsEngineRels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FulltextRule))
            {
                body["fulltextRule"] = request.FulltextRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricRules))
            {
                body["metricRules"] = request.MetricRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NullRules))
            {
                body["nullRules"] = request.NullRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDesc))
            {
                body["templateDesc"] = request.TemplateDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WeakContentRule))
            {
                body["weakContentRule"] = request.WeakContentRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataCheckTemplate",
                Version = "2025-01-16",
                Protocol = "HTTPS",
                Pathname = "/dataCheck/template/v3/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataCheckTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据校验模版</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>更新数据校验模板的名称、描述、适用的数据源与引擎范围以及各类校验规则定义。模板被校验任务引用后，更新会改变这些任务后续执行时所采用的比对规则，请在变更前确认影响范围。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>请求体为 JSON 对象：<c>templateId</c> 指定要更新的校验模板 ID，<c>templateName</c> 与 <c>templateDesc</c> 更新模板名称与描述，<c>checkType</c> 为校验规则类型（0 数据量比对、1 指标比对、2 弱内容对比、3 自定义比对、4 全文比对、5 空值率比对），<c>dsEngineRels</c> 更新模板关联的数据源与引擎范围。</description></item>
        /// <item><description>规则字段按 <c>checkType</c> 取用：指标比对（1）使用 <c>basicMetricRules</c>（基础数据类型指标规则，该场景下应使用此字段）、<c>complexMetricRules</c>（复合数据类型指标规则）与 <c>metricRules</c>（指标规则列表）；弱内容对比（2）使用 <c>weakContentRule</c>，该场景下需要一并传入；全文比对（4）使用 <c>fulltextRule</c>；空值率比对（5）使用 <c>nullRules</c>。与 <c>checkType</c> 不匹配的规则字段不会被使用。</description></item>
        /// <item><description><c>requestId</c> 选填，为请求 ID。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回状态响应，响应体只包含 <c>success</c>、<c>errCode</c>、<c>errMessage</c> 与 <c>requestId</c>，不返回业务数据；<c>success</c> 为 <c>true</c> 即表示模板已更新，无需再回查确认。更新失败时结合 <c>errCode</c> 与 <c>errMessage</c> 排查，常见原因为模板 ID 不存在、无权修改该模板，或规则字段与 <c>checkType</c> 不匹配导致校验不通过。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCheckTemplateResponse
        /// </returns>
        public UpdateDataCheckTemplateResponse UpdateDataCheckTemplate(UpdateDataCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDataCheckTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据校验模版</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>接口说明</h2>
        /// <para>更新数据校验模板的名称、描述、适用的数据源与引擎范围以及各类校验规则定义。模板被校验任务引用后，更新会改变这些任务后续执行时所采用的比对规则，请在变更前确认影响范围。</para>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>请求体为 JSON 对象：<c>templateId</c> 指定要更新的校验模板 ID，<c>templateName</c> 与 <c>templateDesc</c> 更新模板名称与描述，<c>checkType</c> 为校验规则类型（0 数据量比对、1 指标比对、2 弱内容对比、3 自定义比对、4 全文比对、5 空值率比对），<c>dsEngineRels</c> 更新模板关联的数据源与引擎范围。</description></item>
        /// <item><description>规则字段按 <c>checkType</c> 取用：指标比对（1）使用 <c>basicMetricRules</c>（基础数据类型指标规则，该场景下应使用此字段）、<c>complexMetricRules</c>（复合数据类型指标规则）与 <c>metricRules</c>（指标规则列表）；弱内容对比（2）使用 <c>weakContentRule</c>，该场景下需要一并传入；全文比对（4）使用 <c>fulltextRule</c>；空值率比对（5）使用 <c>nullRules</c>。与 <c>checkType</c> 不匹配的规则字段不会被使用。</description></item>
        /// <item><description><c>requestId</c> 选填，为请求 ID。</description></item>
        /// </list>
        /// <h2>返回说明</h2>
        /// <para>返回状态响应，响应体只包含 <c>success</c>、<c>errCode</c>、<c>errMessage</c> 与 <c>requestId</c>，不返回业务数据；<c>success</c> 为 <c>true</c> 即表示模板已更新，无需再回查确认。更新失败时结合 <c>errCode</c> 与 <c>errMessage</c> 排查，常见原因为模板 ID 不存在、无权修改该模板，或规则字段与 <c>checkType</c> 不匹配导致校验不通过。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCheckTemplateResponse
        /// </returns>
        public async Task<UpdateDataCheckTemplateResponse> UpdateDataCheckTemplateAsync(UpdateDataCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDataCheckTemplateWithOptionsAsync(request, headers, runtime);
        }

    }
}
