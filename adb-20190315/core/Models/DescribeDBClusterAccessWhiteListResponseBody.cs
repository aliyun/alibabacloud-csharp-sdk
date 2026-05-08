// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterAccessWhiteListResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhiteListResponseBodyItems Items { get; set; }
        public class DescribeDBClusterAccessWhiteListResponseBodyItems : TeaModel {
            [NameInMap("IPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhiteListResponseBodyItemsIPArray> IPArray { get; set; }
            public class DescribeDBClusterAccessWhiteListResponseBodyItemsIPArray : TeaModel {
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
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
