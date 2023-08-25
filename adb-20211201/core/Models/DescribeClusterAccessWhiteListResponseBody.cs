// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeClusterAccessWhiteListResponseBody : TeaModel {
        /// <summary>
        /// The queried IP address whitelists.
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
                /// The attribute of the whitelist.
                /// 
                /// > Whitelists with the **hidden** attribute are not displayed in the console. Those whitelists are used to access Data Transmission Service (DTS) and PolarDB.
                /// </summary>
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                /// <summary>
                /// The name of the IP address whitelist.
                /// 
                /// Each cluster supports up to 50 IP address whitelists.
                /// </summary>
                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                /// <summary>
                /// The IP addresses in the IP address whitelist. Up to 500 IP addresses can be returned. Multiple IP addresses are separated by commas (,).
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
