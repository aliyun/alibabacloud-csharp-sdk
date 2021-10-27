// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeCanExpandInstanceDetailListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCanExpandInstanceDetailListResponseBodyData Data { get; set; }
        public class DescribeCanExpandInstanceDetailListResponseBodyData : TeaModel {
            [NameInMap("itemData")]
            [Validation(Required=false)]
            public List<DescribeCanExpandInstanceDetailListResponseBodyDataItemData> ItemData { get; set; }
            public class DescribeCanExpandInstanceDetailListResponseBodyDataItemData : TeaModel {
                public DescribeCanExpandInstanceDetailListResponseBodyDataItemDataDbList DbList { get; set; }
                public class DescribeCanExpandInstanceDetailListResponseBodyDataItemDataDbList : TeaModel {
                    [NameInMap("db")]
                    [Validation(Required=false)]
                    public List<string> Db { get; set; }

                }
                public string SrcInstance { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
