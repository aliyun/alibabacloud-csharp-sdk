// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        /// <summary>
        /// The tags that are added to the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTagsResponseBodyItems Items { get; set; }
        public class DescribeTagsResponseBodyItems : TeaModel {
            [NameInMap("TagInfos")]
            [Validation(Required=false)]
            public List<DescribeTagsResponseBodyItemsTagInfos> TagInfos { get; set; }
            public class DescribeTagsResponseBodyItemsTagInfos : TeaModel {
                /// <summary>
                /// The IDs of the instances to which the tag is added.
                /// </summary>
                [NameInMap("DBInstanceIds")]
                [Validation(Required=false)]
                public DescribeTagsResponseBodyItemsTagInfosDBInstanceIds DBInstanceIds { get; set; }
                public class DescribeTagsResponseBodyItemsTagInfosDBInstanceIds : TeaModel {
                    [NameInMap("DBInstanceIds")]
                    [Validation(Required=false)]
                    public List<string> DBInstanceIds { get; set; }

                }

                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
