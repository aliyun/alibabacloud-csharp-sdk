// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CopySnapshotResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of successfully created snapshots.</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public List<CopySnapshotResponseBodyAllocationId> AllocationId { get; set; }
        public class CopySnapshotResponseBodyAllocationId : TeaModel {
            /// <summary>
            /// <para>The ID of the edge zone where the snapshot resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-27</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The array of instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The status code indicating success. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PartSuccess</b>: Partially successful.</description></item>
        /// <item><description><b>AllSuccess</b>: All successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PartSuccess</para>
        /// </summary>
        [NameInMap("BizStatusCode")]
        [Validation(Required=false)]
        public string BizStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA3758E0-8899-17D3-9526-5F62CF33A586</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of edge zones where snapshot creation failed.</para>
        /// </summary>
        [NameInMap("UnAllocationId")]
        [Validation(Required=false)]
        public List<CopySnapshotResponseBodyUnAllocationId> UnAllocationId { get; set; }
        public class CopySnapshotResponseBodyUnAllocationId : TeaModel {
            /// <summary>
            /// <para>The ID of the edge zone where the snapshot resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu-26</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

        }

    }

}
