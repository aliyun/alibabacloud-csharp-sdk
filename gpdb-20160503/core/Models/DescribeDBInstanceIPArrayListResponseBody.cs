// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceIPArrayListResponseBody : TeaModel {
        /// <summary>
        /// The queried IP address whitelists.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceIPArrayListResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceIPArrayListResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceIPArray")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray> DBInstanceIPArray { get; set; }
            public class DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray : TeaModel {
                /// <summary>
                /// The attribute of the IP address whitelist. By default, this parameter is empty. A whitelist with the `hidden` attribute is not displayed in the console.
                /// </summary>
                [NameInMap("DBInstanceIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBInstanceIPArrayAttribute { get; set; }

                /// <summary>
                /// The name of the IP address whitelist.
                /// </summary>
                [NameInMap("DBInstanceIPArrayName")]
                [Validation(Required=false)]
                public string DBInstanceIPArrayName { get; set; }

                /// <summary>
                /// The IP addresses listed in the whitelist. Up to 1,000 IP addresses are contained in a whitelist and separated by commas (,). The IP addresses must use one of the following formats:
                /// 
                /// *   0.0.0.0/0
                /// *   10.23.12.24. This is a standard IP address.
                /// *   10.23.12.24/24. This is a CIDR block. The value `/24` indicates that the prefix of the CIDR block is 24-bit long. You can replace 24 with a value in the range of `1 to 32`.
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
