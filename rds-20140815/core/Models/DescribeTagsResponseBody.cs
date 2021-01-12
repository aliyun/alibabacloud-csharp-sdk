// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTagsResponseBodyItems Items { get; set; }
        public class DescribeTagsResponseBodyItems : TeaModel {
            [NameInMap("TagInfos")]
            [Validation(Required=false)]
            public List<DescribeTagsResponseBodyItemsTagInfos> TagInfos { get; set; }
            public class DescribeTagsResponseBodyItemsTagInfos : TeaModel {
                public string TagKey { get; set; }
                public string TagValue { get; set; }
                public DescribeTagsResponseBodyItemsTagInfosDBInstanceIds DBInstanceIds { get; set; }
                public class DescribeTagsResponseBodyItemsTagInfosDBInstanceIds : TeaModel {
                    [NameInMap("DBInstanceIds")]
                    [Validation(Required=false)]
                    public List<string> DBInstanceIds { get; set; }

                }
            }
        };

    }

}
