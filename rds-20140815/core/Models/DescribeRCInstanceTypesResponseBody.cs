// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeRCInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeRCInstanceTypesResponseBodyInstanceTypes : TeaModel {
            /// <summary>
            /// <para>The instance types.</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeRCInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                /// <summary>
                /// <para>The maximum number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// <para>The ID of the instance family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gn8.cm</para>
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// <para>The instance type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds.gna8.2xlarge.8cm</para>
                /// </summary>
                [NameInMap("InstanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                /// <summary>
                /// <para>The memory size of the instance type. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256</para>
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2911788-25E8-42E5-A3A3-1B38D263F01E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
