// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCreatePrePaidInstanceResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned results of creating an instance.</para>
        /// </summary>
        [NameInMap("InstanceCreateResult")]
        [Validation(Required=false)]
        public DescribeCreatePrePaidInstanceResultResponseBodyInstanceCreateResult InstanceCreateResult { get; set; }
        public class DescribeCreatePrePaidInstanceResultResponseBodyInstanceCreateResult : TeaModel {
            /// <summary>
            /// <para>The status of the instance creation.</para>
            /// <list type="bullet">
            /// <item><description>Accepted</description></item>
            /// <item><description>Creating</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Successed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Successed</para>
            /// </summary>
            [NameInMap("InstanceCreateStatus")]
            [Validation(Required=false)]
            public string InstanceCreateStatus { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-6ecpqvkicnchxccozrpxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAE90880-4970-4D81-A534-A6C0F3631F74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
