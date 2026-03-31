// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetMmsDbResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMmsDbResponseBodyData Data { get; set; }
        public class GetMmsDbResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>for mms_test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("dstName")]
            [Validation(Required=false)]
            public string DstName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mma_test</para>
            /// </summary>
            [NameInMap("dstProjectName")]
            [Validation(Required=false)]
            public string DstProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>63</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>last ddl time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-17 15:44:42</para>
            /// </summary>
            [NameInMap("lastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hdfs://master-1-1.c-6fc187819ed6bae0.cn-shanghai.emr.aliyuncs.com:9000/user/hive/warehouse</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mms_test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2323</para>
            /// </summary>
            [NameInMap("numRows")]
            [Validation(Required=false)]
            public long? NumRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>System user</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("partitions")]
            [Validation(Required=false)]
            public int? Partitions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("partitionsDoing")]
            [Validation(Required=false)]
            public int? PartitionsDoing { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1400</para>
            /// </summary>
            [NameInMap("partitionsDone")]
            [Validation(Required=false)]
            public int? PartitionsDone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("partitionsFailed")]
            [Validation(Required=false)]
            public int? PartitionsFailed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>323232332</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000017</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("sourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DOING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("tables")]
            [Validation(Required=false)]
            public int? Tables { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("tablesDoing")]
            [Validation(Required=false)]
            public int? TablesDoing { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("tablesDone")]
            [Validation(Required=false)]
            public int? TablesDone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("tablesFailed")]
            [Validation(Required=false)]
            public int? TablesFailed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("tablesPartDone")]
            [Validation(Required=false)]
            public int? TablesPartDone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public bool? Updated { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90D64EB6-2962-5B1C-A039-BC41C8176C7F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
