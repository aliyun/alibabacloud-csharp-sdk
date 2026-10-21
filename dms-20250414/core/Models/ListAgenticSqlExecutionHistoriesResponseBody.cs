// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListAgenticSqlExecutionHistoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of SQL execution history.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAgenticSqlExecutionHistoriesResponseBodyData> Data { get; set; }
        public class ListAgenticSqlExecutionHistoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the actor. User IDs start with usr_, and agent IDs start with agt_.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usr_10001</para>
            /// </summary>
            [NameInMap("ActorId")]
            [Validation(Required=false)]
            public string ActorId { get; set; }

            /// <summary>
            /// <para>The name of the actor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-user</para>
            /// </summary>
            [NameInMap("ActorName")]
            [Validation(Required=false)]
            public string ActorName { get; set; }

            /// <summary>
            /// <para>The type of the actor. HUMAN indicates a user, and AGENT indicates an agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HUMAN</para>
            /// </summary>
            [NameInMap("ActorType")]
            [Validation(Required=false)]
            public string ActorType { get; set; }

            /// <summary>
            /// <para>The number of affected rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AffectedRows")]
            [Validation(Required=false)]
            public long? AffectedRows { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the agent belongs. The ID starts with usr_.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usr_10001</para>
            /// </summary>
            [NameInMap("AgentOwnerId")]
            [Validation(Required=false)]
            public string AgentOwnerId { get; set; }

            /// <summary>
            /// <para>The catalog UUID to which the execution belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mc-HZ-OfjcNc2z***</para>
            /// </summary>
            [NameInMap("CatalogUuid")]
            [Validation(Required=false)]
            public string CatalogUuid { get; set; }

            /// <summary>
            /// <para>The IP address of the client that initiated the execution, excluding the port. This parameter is empty in workflow scenarios or when the IP address is not recorded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.0.113.10</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The execution duration of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public long? Cost { get; set; }

            /// <summary>
            /// <para>The search name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_db</para>
            /// </summary>
            [NameInMap("DatabaseSearchName")]
            [Validation(Required=false)]
            public string DatabaseSearchName { get; set; }

            /// <summary>
            /// <para>The database UUID to which the execution belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>md-HZ-fp9K7r***</para>
            /// </summary>
            [NameInMap("DatabaseUuid")]
            [Validation(Required=false)]
            public string DatabaseUuid { get; set; }

            /// <summary>
            /// <para>The error message returned when the execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>syntax error</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The actual SQL statement that was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT 1</para>
            /// </summary>
            [NameInMap("ExecutedSql")]
            [Validation(Required=false)]
            public string ExecutedSql { get; set; }

            /// <summary>
            /// <para>The execution status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUCCESS: The execution succeeded.</description></item>
            /// <item><description>FAILED: The execution failed.</description></item>
            /// <item><description>BLOCKED: The execution was blocked or not actually executed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("ExecutionStatus")]
            [Validation(Required=false)]
            public string ExecutionStatus { get; set; }

            /// <summary>
            /// <para>The original SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT 1</para>
            /// </summary>
            [NameInMap("OriginalSql")]
            [Validation(Required=false)]
            public string OriginalSql { get; set; }

            /// <summary>
            /// <para>The query ID of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trace-10001</para>
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

            /// <summary>
            /// <para>The number of returned rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReturnedRows")]
            [Validation(Required=false)]
            public long? ReturnedRows { get; set; }

            /// <summary>
            /// <para>The execution scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AGENT_QUERY: The agent directly executes the SQL statement.</description></item>
            /// <item><description>WORKFLOW_QUERY: The SQL statement is asynchronously executed through a workflow.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT_QUERY</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            /// <summary>
            /// <para>The SQL type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// <para>The start time of the execution. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The workflow ID. This parameter may be empty in non-workflow scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wf-10001</para>
            /// </summary>
            [NameInMap("WorkflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is empty when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INVALID_PARAMETER</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid endTime format, expected yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34E01EDD-6A16-4CF0-9541-C644D1BE01AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
