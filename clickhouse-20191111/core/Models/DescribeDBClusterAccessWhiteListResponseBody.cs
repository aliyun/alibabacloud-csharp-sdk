// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterAccessWhiteListResponseBody : TeaModel {
        [NameInMap("DBClusterAccessWhiteList")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteList DBClusterAccessWhiteList { get; set; }
        public class DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteList : TeaModel {
            [NameInMap("IPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteListIPArray> IPArray { get; set; }
            public class DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteListIPArray : TeaModel {
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>905F13A4-5097-4897-A84D-527EC75FFF4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
