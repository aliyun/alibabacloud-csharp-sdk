// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterAccessWhiteListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information of IP whitelists.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhiteListResponseBodyItems Items { get; set; }
        public class DescribeDBClusterAccessWhiteListResponseBodyItems : TeaModel {
            [NameInMap("IPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhiteListResponseBodyItemsIPArray> IPArray { get; set; }
            public class DescribeDBClusterAccessWhiteListResponseBodyItemsIPArray : TeaModel {
                /// <summary>
                /// The attribute of the whitelist group. It is empty by default.
                /// 
                /// >  The groups with hidden attribute are not displayed in the console. The groups with hidden attribute are used to access DTS and PolarDB-X.
                /// </summary>
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                /// <summary>
                /// The name of the IP address whitelist.
                /// 
                /// *   The name of the IP address whitelist group must be 2 to 32 characters in length and can contain lowercase letters, digits, and underscores (\_). The name must start with a lowercase letter and end with a digit or lowercase letter.
                /// *   You can create up to 50 whitelists for a cluster.
                /// </summary>
                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                /// <summary>
                /// The IP addresses in an IP address whitelist. A maximum of 1,000 IP addresses can be returned. These addresses are separated with commas (,).
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
