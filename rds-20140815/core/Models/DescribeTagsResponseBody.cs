// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The tags that are added to the instance.</para>
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
                /// <para>The IDs of the instances to which the tag is added.</para>
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
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
