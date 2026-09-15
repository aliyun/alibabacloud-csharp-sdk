// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaStreaming20260202.Models
{
    public class GetComputeJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetComputeJobResponseBodyData Data { get; set; }
        public class GetComputeJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-02T16:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("CuLimit")]
            [Validation(Required=false)]
            public double? CuLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("CuReserved")]
            [Validation(Required=false)]
            public double? CuReserved { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("CuUsed")]
            [Validation(Required=false)]
            public double? CuUsed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DebugMode")]
            [Validation(Required=false)]
            public int? DebugMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INSERT INTO sink_table SELECT * FROM source_table;</para>
            /// </summary>
            [NameInMap("DeployedSql")]
            [Validation(Required=false)]
            public string DeployedSql { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INSERT INTO sink_table SELECT * FROM source_table;</para>
            /// </summary>
            [NameInMap("DraftSql")]
            [Validation(Required=false)]
            public string DraftSql { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SQL 校验或编译失败：Column \&quot;xxx\&quot; not found</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-11T04:33:03Z</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alikafka_streaming-cn-hangzhou-a1b2c3d4</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>order_enrichment</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>订单流实时清洗</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>savepoint</para>
            /// </summary>
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>062D8E8B-8D47-5DCC-BB12-5A1D93C3A66B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
