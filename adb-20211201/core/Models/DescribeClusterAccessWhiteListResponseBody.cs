// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeClusterAccessWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried IP address whitelists.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeClusterAccessWhiteListResponseBodyItems Items { get; set; }
        public class DescribeClusterAccessWhiteListResponseBodyItems : TeaModel {
            [NameInMap("IPArray")]
            [Validation(Required=false)]
            public List<DescribeClusterAccessWhiteListResponseBodyItemsIPArray> IPArray { get; set; }
            public class DescribeClusterAccessWhiteListResponseBodyItemsIPArray : TeaModel {
                /// <summary>
                /// <para>The attribute of the whitelist.</para>
                /// <remarks>
                /// <para>Whitelists with the <b>hidden</b> attribute are not displayed in the console. Those whitelists are used to access Data Transmission Service (DTS) and PolarDB.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>hidden</para>
                /// </summary>
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                /// <summary>
                /// <para>The name of the IP address whitelist.</para>
                /// <para>Each cluster supports up to 50 IP address whitelists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                /// <summary>
                /// <para>The IP addresses in the IP address whitelist. Up to 500 IP addresses can be returned. Multiple IP addresses are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.xx.xx</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>370D09FD-442A-5225-AAD3-7362CAE39177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
