// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceByTagsResponseBody : TeaModel {
        /// <summary>
        /// The details about the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceByTagsResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceByTagsResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceTag")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTag> DBInstanceTag { get; set; }
            public class DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTag : TeaModel {
                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The details about the tag.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTagTags Tags { get; set; }
                public class DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTagTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTagTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceByTagsResponseBodyItemsDBInstanceTagTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
