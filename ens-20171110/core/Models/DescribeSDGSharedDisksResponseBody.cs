// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGSharedDisksResponseBody : TeaModel {
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
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxsxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of shared disks.</para>
        /// </summary>
        [NameInMap("SharedDisks")]
        [Validation(Required=false)]
        public List<DescribeSDGSharedDisksResponseBodySharedDisks> SharedDisks { get; set; }
        public class DescribeSDGSharedDisksResponseBodySharedDisks : TeaModel {
            /// <summary>
            /// <para>The time when the shared disk was created. The time follows the ISO 8601 standard and includes a time zone offset in the YYYY-MM-DDTHH:mm:ss+HH:mm format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-09T15:13:21+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the shared disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-57kvvpuj1rk2ghumlgs6</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The type of the shared disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

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
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-1</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the SDG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sdg-fqehhfdjv</para>
            /// </summary>
            [NameInMap("SdgId")]
            [Validation(Required=false)]
            public string SdgId { get; set; }

            /// <summary>
            /// <para>The number of shared mounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SharedNum")]
            [Validation(Required=false)]
            public int? SharedNum { get; set; }

            /// <summary>
            /// <para>The status of the shared disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>avaliable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
