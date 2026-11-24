// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaStreaming20260202.Models
{
    public class GetComputeJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetComputeJobResponseBodyData Data { get; set; }
        public class GetComputeJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-02T16:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The CU limit for the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("CuLimit")]
            [Validation(Required=false)]
            public double? CuLimit { get; set; }

            /// <summary>
            /// <para>The reserved CUs for the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("CuReserved")]
            [Validation(Required=false)]
            public double? CuReserved { get; set; }

            /// <summary>
            /// <para>The used CUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("CuUsed")]
            [Validation(Required=false)]
            public double? CuUsed { get; set; }

            /// <summary>
            /// <para>Indicates whether the job is a debug job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DebugMode")]
            [Validation(Required=false)]
            public int? DebugMode { get; set; }

            /// <summary>
            /// <para>The currently deployed SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSERT INTO sink_table SELECT * FROM source_table;</para>
            /// </summary>
            [NameInMap("DeployedSql")]
            [Validation(Required=false)]
            public string DeployedSql { get; set; }

            /// <summary>
            /// <para>The Flink SQL draft.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSERT INTO sink_table SELECT * FROM source_table;</para>
            /// </summary>
            [NameInMap("DraftSql")]
            [Validation(Required=false)]
            public string DraftSql { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL validation or compilation failed: Column \&quot;xxx\&quot; not found</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-11T04:33:03Z</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The compute instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alikafka_streaming-cn-hangzhou-a1b2c3d4</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the compute job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order_enrichment</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The owner of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The remark for the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Real-time order stream cleansing</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The startup mode, such as savepoint or stateless.</para>
            /// 
            /// <b>Example:</b>
            /// <para>savepoint</para>
            /// </summary>
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>062D8E8B-8D47-5DCC-BB12-5A1D93C3A66B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
