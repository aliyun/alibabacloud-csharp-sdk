// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeInstanceTypeResponseBody : TeaModel {
        [NameInMap("InstanceTypeSpecList")]
        [Validation(Required=false)]
        public DescribeInstanceTypeResponseBodyInstanceTypeSpecList InstanceTypeSpecList { get; set; }
        public class DescribeInstanceTypeResponseBodyInstanceTypeSpecList : TeaModel {
            [NameInMap("InstanceTypeSpec")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypeResponseBodyInstanceTypeSpecListInstanceTypeSpec> InstanceTypeSpec { get; set; }
            public class DescribeInstanceTypeResponseBodyInstanceTypeSpecListInstanceTypeSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("CpuSize")]
                [Validation(Required=false)]
                public long? CpuSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hbase.n2.4xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MemSize")]
                [Validation(Required=false)]
                public long? MemSize { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD23BBB4-64C2-42A4-B2E2-7E56C7AA815A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
