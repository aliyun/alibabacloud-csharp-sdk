// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterAccessWhiteListResponseBody : TeaModel {
        /// <summary>
        /// The details about the IP address whitelist.
        /// </summary>
        [NameInMap("DBClusterAccessWhiteList")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteList DBClusterAccessWhiteList { get; set; }
        public class DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteList : TeaModel {
            [NameInMap("IPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteListIPArray> IPArray { get; set; }
            public class DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteListIPArray : TeaModel {
                /// <summary>
                /// The attribute of the IP address whitelist.
                /// </summary>
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                /// <summary>
                /// The name of the IP address whitelist.
                /// </summary>
                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                /// <summary>
                /// The IP addresses in the IP address whitelist.
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
