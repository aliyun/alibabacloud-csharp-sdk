// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetMaterializedViewResponseBody : TeaModel {
        /// <summary>
        /// <para>The aggregation interval of the materialized view results, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("aggIntervalMins")]
        [Validation(Required=false)]
        public int? AggIntervalMins { get; set; }

        /// <summary>
        /// <para>The time when the materialized view was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1722411060</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the materialized view is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The Logstore from which the materialized view sources its data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>alert-123456</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The original SQL statement executed by the materialized view.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>| select count(*) from log</description></item>
        /// </list>
        /// </summary>
        [NameInMap("originalSql")]
        [Validation(Required=false)]
        public string OriginalSql { get; set; }

        /// <summary>
        /// <para>The number of shards used by the Logstore that stores the materialized view data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("shardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The time from which the materialized view starts processing data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1448748198</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>The status information of the materialized view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public GetMaterializedViewResponseBodyStatus Status { get; set; }
        public class GetMaterializedViewResponseBodyStatus : TeaModel {
            /// <summary>
            /// <para>The error message from the last execution of the materialized view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>column \&quot;value\&quot; not defined</para>
            /// </summary>
            [NameInMap("lastRunError")]
            [Validation(Required=false)]
            public string LastRunError { get; set; }

            /// <summary>
            /// <para>The time when the materialized view was last executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1787647228</para>
            /// </summary>
            [NameInMap("lastRunTime")]
            [Validation(Required=false)]
            public long? LastRunTime { get; set; }

            /// <summary>
            /// <para>The latest position up to which the materialized view has processed data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1787647228</para>
            /// </summary>
            [NameInMap("maxCursorTime")]
            [Validation(Required=false)]
            public long? MaxCursorTime { get; set; }

            /// <summary>
            /// <para>The execute statistics information of the materialized view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("stats")]
            [Validation(Required=false)]
            public GetMaterializedViewResponseBodyStatusStats Stats { get; set; }
            public class GetMaterializedViewResponseBodyStatusStats : TeaModel {
                /// <summary>
                /// <para>The number of times the materialized view was used in the last day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("hits")]
                [Validation(Required=false)]
                public long? Hits { get; set; }

                /// <summary>
                /// <para>The top 3 most frequently accelerated SQL statements by the materialized view.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("queries")]
                [Validation(Required=false)]
                public List<string> Queries { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of days that the materialized view results are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
