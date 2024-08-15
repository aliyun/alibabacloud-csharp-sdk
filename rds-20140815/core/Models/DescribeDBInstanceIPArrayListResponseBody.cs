// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceIPArrayListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details about the IP address whitelists.
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
                /// The attribute of the IP address whitelist. By default, this parameter is empty.
                /// 
                /// >  A whitelist with the hidden attribute does not appear in the console. Such IP address whitelists are used to access Alibaba Cloud services, such as Data Transmission Service (DTS).
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
                /// The IP addresses in the IP address whitelist.
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// The type of the IP address.
                /// </summary>
                [NameInMap("SecurityIPType")]
                [Validation(Required=false)]
                public string SecurityIPType { get; set; }

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
