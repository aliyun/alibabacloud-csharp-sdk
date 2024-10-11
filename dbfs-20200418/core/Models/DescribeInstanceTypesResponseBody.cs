// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class DescribeInstanceTypesResponseBody : TeaModel {
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<DescribeInstanceTypesResponseBodyInstanceTypes> InstanceTypes { get; set; }
        public class DescribeInstanceTypesResponseBodyInstanceTypes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("CpuCoreCount")]
            [Validation(Required=false)]
            public float? CpuCoreCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs.small</para>
            /// </summary>
            [NameInMap("InstanceTypeDescription")]
            [Validation(Required=false)]
            public string InstanceTypeDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs.small</para>
            /// </summary>
            [NameInMap("InstanceTypeId")]
            [Validation(Required=false)]
            public string InstanceTypeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public float? MemorySize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
