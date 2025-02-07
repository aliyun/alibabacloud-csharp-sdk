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
                [NameInMap("BytesPerMinute")]
                [Validation(Required=false)]
                public long? BytesPerMinute { get; set; }

                /// <summary>
                /// <b>if can be null:</b>
                /// <c>false</c>
                /// </summary>
                [NameInMap("DisableWriteWindows")]
                [Validation(Required=false)]
                public string DisableWriteWindows { get; set; }

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

                [NameInMap("SubJob")]
                [Validation(Required=false)]
                public string SubJob { get; set; }

                [NameInMap("SubJobStatus")]
                [Validation(Required=false)]
                public string SubJobStatus { get; set; }

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

                [NameInMap("UnsyncedBytes")]
                [Validation(Required=false)]
                public long? UnsyncedBytes { get; set; }

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
