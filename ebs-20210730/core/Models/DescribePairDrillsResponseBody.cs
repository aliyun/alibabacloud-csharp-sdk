// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribePairDrillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of disaster recovery drills that were performed on the replication pair.</para>
        /// </summary>
        [NameInMap("Drills")]
        [Validation(Required=false)]
        public List<DescribePairDrillsResponseBodyDrills> Drills { get; set; }
        public class DescribePairDrillsResponseBodyDrills : TeaModel {
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
            /// <para>The ID of the drill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drill-xxx</para>
            /// </summary>
            [NameInMap("DrillId")]
            [Validation(Required=false)]
            public string DrillId { get; set; }

            /// <summary>
            /// <para>The recovery point of the drill. The value of this parameter is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1690855931</para>
            /// </summary>
            [NameInMap("RecoverPoint")]
            [Validation(Required=false)]
            public long? RecoverPoint { get; set; }

            /// <summary>
            /// <para>The beginning time of the drill. The value of this parameter is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1690855888</para>
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
            /// <para>executing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The error message that was displayed if the drill failed to be executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAIR_SYNCPOINT_NOT_FOUND</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
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
        /// <para>C46FF5A8-C5F0-4024-8262-B16B6392****</para>
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
