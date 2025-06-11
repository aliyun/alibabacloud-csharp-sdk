// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeTransferHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The migration information.</para>
        /// </summary>
        [NameInMap("HistoryDetails")]
        [Validation(Required=false)]
        public DescribeTransferHistoryResponseBodyHistoryDetails HistoryDetails { get; set; }
        public class DescribeTransferHistoryResponseBodyHistoryDetails : TeaModel {
            [NameInMap("HistoryDetail")]
            [Validation(Required=false)]
            public List<DescribeTransferHistoryResponseBodyHistoryDetailsHistoryDetail> HistoryDetail { get; set; }
            public class DescribeTransferHistoryResponseBodyHistoryDetailsHistoryDetail : TeaModel {
                /// <summary>
                /// <para>The amount of data that is migrated per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10240</para>
                /// </summary>
                [NameInMap("BytesPerMinute")]
                [Validation(Required=false)]
                public long? BytesPerMinute { get; set; }

                /// <summary>
                /// <para>The time window during which write operations are stopped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-08T00:00:00+08:00,2025-02-12T00:00:00+08:00</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>false</c>
                /// </summary>
                [NameInMap("DisableWriteWindows")]
                [Validation(Required=false)]
                public string DisableWriteWindows { get; set; }

                /// <summary>
                /// <para>The number of parts that are migrated per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.24</para>
                /// </summary>
                [NameInMap("PartsPerMinute")]
                [Validation(Required=false)]
                public double? PartsPerMinute { get; set; }

                /// <summary>
                /// <para>The progress of the data migration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The control version of the source cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("SourceControlVersion")]
                [Validation(Required=false)]
                public string SourceControlVersion { get; set; }

                /// <summary>
                /// <para>The ID of the source cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc-bp108z124a8o7****</para>
                /// </summary>
                [NameInMap("SourceDBCluster")]
                [Validation(Required=false)]
                public string SourceDBCluster { get; set; }

                /// <summary>
                /// <para>The status of the data migration task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Finished</b>: The data migration task is complete.</description></item>
                /// <item><description><b>Processing</b>: The data migration task is in progress.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The running subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SubJob</para>
                /// </summary>
                [NameInMap("SubJob")]
                [Validation(Required=false)]
                public string SubJob { get; set; }

                /// <summary>
                /// <para>The subtask status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("SubJobStatus")]
                [Validation(Required=false)]
                public string SubJobStatus { get; set; }

                /// <summary>
                /// <para>The control version of the destination cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2</para>
                /// </summary>
                [NameInMap("TargetControlVersion")]
                [Validation(Required=false)]
                public string TargetControlVersion { get; set; }

                /// <summary>
                /// <para>The ID of the destination cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc-bp13zkh9uw523****</para>
                /// </summary>
                [NameInMap("TargetDBCluster")]
                [Validation(Required=false)]
                public string TargetDBCluster { get; set; }

                /// <summary>
                /// <para>The amount of data that is not migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102400</para>
                /// </summary>
                [NameInMap("UnsyncedBytes")]
                [Validation(Required=false)]
                public long? UnsyncedBytes { get; set; }

                /// <summary>
                /// <para>The number of parts that are not migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("UnsyncedParts")]
                [Validation(Required=false)]
                public long? UnsyncedParts { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05321590-BB65-4720-8CB6-8218E041CDD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
