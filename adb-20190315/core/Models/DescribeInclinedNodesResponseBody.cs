// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeInclinedNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried storage nodes.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeInclinedNodesResponseBodyItems> Items { get; set; }
        public class DescribeInclinedNodesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The disk usage of the storage node. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90.5</para>
            /// </summary>
            [NameInMap("DiskUsageRatio")]
            [Validation(Required=false)]
            public string DiskUsageRatio { get; set; }

            /// <summary>
            /// <para>The number of the storage node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node1</para>
            /// </summary>
            [NameInMap("Node")]
            [Validation(Required=false)]
            public string Node { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C1A419E-5A79-51A9-B533-FCCB98AD8FD5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
