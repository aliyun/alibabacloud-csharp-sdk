// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. If the request is successful, 0 is returned. If the request fails, a non-zero error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Details about the instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                /// <summary>
                /// <para>The number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// <para>This parameter is unavailable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This parameter is not needed temporarily.</para>
                /// </summary>
                [NameInMap("InstanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                /// <summary>
                /// <para>The name of the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ens.xxx.small</para>
                /// </summary>
                [NameInMap("InstanceTypeName")]
                [Validation(Required=false)]
                public string InstanceTypeName { get; set; }

                /// <summary>
                /// <para>The memory size. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
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
        /// <para>D452D190-BADF-5D09-910D-599B96D42AAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
