// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDestinationPortEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The ports.</para>
        /// </summary>
        [NameInMap("PortList")]
        [Validation(Required=false)]
        public List<DescribeDestinationPortEventResponseBodyPortList> PortList { get; set; }
        public class DescribeDestinationPortEventResponseBodyPortList : TeaModel {
            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            /// <summary>
            /// <para>The number of request packets received by the destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8760950</para>
            /// </summary>
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E7F6B2C-03F2-462F-9076-B782CF0DD502</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
