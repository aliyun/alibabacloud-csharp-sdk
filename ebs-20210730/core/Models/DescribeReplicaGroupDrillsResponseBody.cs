// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeReplicaGroupDrillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of disaster recovery drills that were performed on the replication pair-consistent group.</para>
        /// </summary>
        [NameInMap("Drills")]
        [Validation(Required=false)]
        public List<DescribeReplicaGroupDrillsResponseBodyDrills> Drills { get; set; }
        public class DescribeReplicaGroupDrillsResponseBodyDrills : TeaModel {
            /// <summary>
            /// <para>The ID of the drill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-drill-xxx</para>
            /// </summary>
            [NameInMap("DrillId")]
            [Validation(Required=false)]
            public string DrillId { get; set; }

            /// <summary>
            /// <para>The ID of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-xxx</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The information of replication pairs.</para>
            /// </summary>
            [NameInMap("PairsInfo")]
            [Validation(Required=false)]
            public List<DescribeReplicaGroupDrillsResponseBodyDrillsPairsInfo> PairsInfo { get; set; }
            public class DescribeReplicaGroupDrillsResponseBodyDrillsPairsInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the drill disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-xxx</para>
                /// </summary>
                [NameInMap("DrillDiskId")]
                [Validation(Required=false)]
                public string DrillDiskId { get; set; }

                /// <summary>
                /// <para>The status of the drill disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>created</description></item>
                /// <item><description>deleted</description></item>
                /// <item><description>creating</description></item>
                /// <item><description>deleting</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter can also display error code details if your drill disk fails to be created or deleted.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>created</para>
                /// </summary>
                [NameInMap("DrillDiskStatus")]
                [Validation(Required=false)]
                public string DrillDiskStatus { get; set; }

                /// <summary>
                /// <para>The ID of the replication pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pair-xxx</para>
                /// </summary>
                [NameInMap("PairId")]
                [Validation(Required=false)]
                public string PairId { get; set; }

            }

            /// <summary>
            /// <para>The recovery point of the drill. The value of this parameter is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1691114995</para>
            /// </summary>
            [NameInMap("RecoverPoint")]
            [Validation(Required=false)]
            public long? RecoverPoint { get; set; }

            /// <summary>
            /// <para>The beginning time of the drill. The value of this parameter is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649750977</para>
            /// </summary>
            [NameInMap("StartAt")]
            [Validation(Required=false)]
            public long? StartAt { get; set; }

            /// <summary>
            /// <para>The status of the drill. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>execute_failed</description></item>
            /// <item><description>executed</description></item>
            /// <item><description>executing</description></item>
            /// <item><description>clear_failed</description></item>
            /// <item><description>clearing</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>executed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The error message that appears if the drill fails to be executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GROUP_SYNCPOINT_NOT_FOUND</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C123F94F-4E38-19AE-942A-A8D6F44F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
