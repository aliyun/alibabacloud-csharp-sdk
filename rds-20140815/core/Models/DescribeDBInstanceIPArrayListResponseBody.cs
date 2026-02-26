// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceIPArrayListResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceIPArrayListResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceIPArrayListResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceIPArray")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray> DBInstanceIPArray { get; set; }
            public class DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray : TeaModel {
                [NameInMap("DBInstanceIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBInstanceIPArrayAttribute { get; set; }

                [NameInMap("DBInstanceIPArrayName")]
                [Validation(Required=false)]
                public string DBInstanceIPArrayName { get; set; }

                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                [NameInMap("SecurityIPType")]
                [Validation(Required=false)]
                public string SecurityIPType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2B6AF71-DC32-4055-B477-43B348798D10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
