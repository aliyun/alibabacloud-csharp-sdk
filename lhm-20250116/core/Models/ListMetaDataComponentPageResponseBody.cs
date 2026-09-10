// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListMetaDataComponentPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list returned by the operation. For the structure of each element, see the child parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListMetaDataComponentPageResponseBodyData> Data { get; set; }
        public class ListMetaDataComponentPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The entry component type. In some operations, this parameter is used as a backward compatible field for version 1.1.0. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: source</description></item>
            /// <item><description>1: destination</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public long? ComponentType { get; set; }

            /// <summary>
            /// <para>The creation time of the table or partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The datasource config in JSON string format. The structure is defined by each dsType. Parse the JSON string before use. Sensitive fields such as tokens are masked in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;endpoint&quot;:&quot;...&quot;,&quot;token&quot;:&quot;******&quot;}</para>
            /// </summary>
            [NameInMap("dsConfig")]
            [Validation(Required=false)]
            public string DsConfig { get; set; }

            /// <summary>
            /// <para>The description of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data source description</para>
            /// </summary>
            [NameInMap("dsDesc")]
            [Validation(Required=false)]
            public string DsDesc { get; set; }

            /// <summary>
            /// <para>The business ID of the data source (external ID, which may be the same as the primary key ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>290</para>
            /// </summary>
            [NameInMap("dsId")]
            [Validation(Required=false)]
            public string DsId { get; set; }

            /// <summary>
            /// <para>The data source name. Exact match and fuzzy match are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_ds318_hangzhou_0428</para>
            /// </summary>
            [NameInMap("dsName")]
            [Validation(Required=false)]
            public string DsName { get; set; }

            /// <summary>
            /// <para>The connectivity status of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not tested.</description></item>
            /// <item><description>1: Connected.</description></item>
            /// <item><description>2: Connection failed.</description></item>
            /// <item><description>-1: Connectivity test not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dsStatus")]
            [Validation(Required=false)]
            public int? DsStatus { get; set; }

            /// <summary>
            /// <para>The data source type, such as Hive or MaxCompute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("dsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }

            /// <summary>
            /// <para>The version number of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.2.0</para>
            /// </summary>
            [NameInMap("dsVersion")]
            [Validation(Required=false)]
            public string DsVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the data source has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Expired.</description></item>
            /// <item><description>false: Not expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// <para>The primary key ID that uniquely identifies a record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The profiling task information, including the task status, scheduling ID, profiling rule, and profiling type. This field is empty if the data source is not associated with a profiling task.</para>
            /// </summary>
            [NameInMap("profilingJob")]
            [Validation(Required=false)]
            public ListMetaDataComponentPageResponseBodyDataProfilingJob ProfilingJob { get; set; }
            public class ListMetaDataComponentPageResponseBodyDataProfilingJob : TeaModel {
                /// <summary>
                /// <para>The component ID, which is the primary key of the data source component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("componentId")]
                [Validation(Required=false)]
                public long? ComponentId { get; set; }

                /// <summary>
                /// <para>The creation time of the table or partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-16T10:00:00Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The primary key ID that uniquely identifies a record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The description of the profiling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Profiling task description</para>
                /// </summary>
                [NameInMap("jobDesc")]
                [Validation(Required=false)]
                public string JobDesc { get; set; }

                /// <summary>
                /// <para>The name of the profiling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job_name</para>
                /// </summary>
                [NameInMap("jobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The ID of the most recent profiling task batch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20001</para>
                /// </summary>
                [NameInMap("lastBatchId")]
                [Validation(Required=false)]
                public string LastBatchId { get; set; }

                /// <summary>
                /// <para>The profiling task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Not started.</description></item>
                /// <item><description>1: Running.</description></item>
                /// <item><description>2: Stopped.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("profilingEnable")]
                [Validation(Required=false)]
                public int? ProfilingEnable { get; set; }

                /// <summary>
                /// <para>The profiling permission. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: read-only link</description></item>
                /// <item><description>1: client</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("profilingPermission")]
                [Validation(Required=false)]
                public int? ProfilingPermission { get; set; }

                /// <summary>
                /// <para>The cron expression for scheduled profiling. This parameter takes effect only when profilingType is set to CRON.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 2 * * ?</para>
                /// </summary>
                [NameInMap("profilingRule")]
                [Validation(Required=false)]
                public string ProfilingRule { get; set; }

                /// <summary>
                /// <para>The profiling policy (scheduling type). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: daily</description></item>
                /// <item><description>1: CRON</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("profilingType")]
                [Validation(Required=false)]
                public int? ProfilingType { get; set; }

                /// <summary>
                /// <para>The scheduling ID, which uniquely identifies the profiling task on the scheduling side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("schedulerToken")]
                [Validation(Required=false)]
                public string SchedulerToken { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The page size, which is the number of records returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed. Check errCode and errMessage for details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the query conditions. This parameter is used for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
