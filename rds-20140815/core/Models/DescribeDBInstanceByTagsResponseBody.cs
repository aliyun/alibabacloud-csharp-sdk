// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceByTagsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceByTagsResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceByTagsResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceTag")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTag> DBInstanceTag { get; set; }
            public class DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTag : TeaModel {
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTagTags Tags { get; set; }
                public class DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTagTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTagTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTagTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
