// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListAgenticGlobalSqlExecutionHistoriesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the actor. A user ID starts with usr_, and an agent ID starts with agt_. If you do not specify this parameter, all records within the current tenant are queried. If you specify a user ID, the records of the user and the agents under the user are included. If you specify an agent ID, only the records of the agent are matched. The actor must belong to the current tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usr_10001</para>
        /// </summary>
        [NameInMap("ActorId")]
        [Validation(Required=false)]
        public string ActorId { get; set; }

        /// <summary>
        /// <para>The name of the actor for exact match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-user</para>
        /// </summary>
        [NameInMap("ActorName")]
        [Validation(Required=false)]
        public string ActorName { get; set; }

        /// <summary>
        /// <para>The type of the actor for exact match. Valid values: HUMAN and AGENT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HUMAN</para>
        /// </summary>
        [NameInMap("ActorType")]
        [Validation(Required=false)]
        public string ActorType { get; set; }

        /// <summary>
        /// <para>The catalog UUID for exact match. You can obtain this value by calling ListAgenticCatalog or SearchAgenticCatalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-HZ-OfjcNc2z***</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The database UUID for exact match. You can obtain this value by calling ListAgenticDatabase or SearchAgenticDatabase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md-HZ-fp9K7r***</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the yyyy-MM-dd HH:mm:ss format. If you do not specify this parameter, the default end time is the current time. If the format cannot be parsed or the end time is earlier than the start time, the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-01 00:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The execution scenario for exact match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AGENT_QUERY: The agent directly executes the SQL statement.</description></item>
        /// <item><description>WORKFLOW_QUERY: The SQL statement is asynchronously executed through a workflow.
        /// If you do not specify this parameter, both scenarios are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AGENT_QUERY</para>
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The keyword for fuzzy match based on the original SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlKeyword")]
        [Validation(Required=false)]
        public string SqlKeyword { get; set; }

        /// <summary>
        /// <para>The SQL type for exact match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the yyyy-MM-dd HH:mm:ss format. If you do not specify this parameter, the default time range is the last 7 days. If the specified time is earlier than 730 days ago or the format cannot be parsed, the query starts from 730 days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
