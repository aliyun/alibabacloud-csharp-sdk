// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSharedDiskRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68B85217-03B8-5141-9216-EA4D7C496B9A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The shared disk billing records.</para>
        /// </summary>
        [NameInMap("SharedDisks")]
        [Validation(Required=false)]
        public List<DescribeSharedDiskRecordsResponseBodySharedDisks> SharedDisks { get; set; }
        public class DescribeSharedDiskRecordsResponseBodySharedDisks : TeaModel {
            /// <summary>
            /// <para>The creation time of the shared disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-01 10:00:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The shared disk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-57kvvpuj1rk2ghumlgs6</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The disk size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public long? DiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the instance from which the shared disk was last detached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("LastDetachInstanceId")]
            [Validation(Required=false)]
            public string LastDetachInstanceId { get; set; }

            /// <summary>
            /// <para>The time when the shared disk was last detached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-14 18:00:00</para>
            /// </summary>
            [NameInMap("LastDetachTime")]
            [Validation(Required=false)]
            public string LastDetachTime { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The SDG sharing ratio parameter, which supports cloud disks with different maximum sharing ratios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public long? PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The reclamation time of the shared disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-15 14:30:00</para>
            /// </summary>
            [NameInMap("RecycleTime")]
            [Validation(Required=false)]
            public string RecycleTime { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-1</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The SDG ID of the shared disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sdg-fqehhfdjv</para>
            /// </summary>
            [NameInMap("SdgId")]
            [Validation(Required=false)]
            public string SdgId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
