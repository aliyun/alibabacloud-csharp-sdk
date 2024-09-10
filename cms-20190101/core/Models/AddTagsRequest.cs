// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class AddTagsRequest : TeaModel {
        /// <summary>
        /// The ID of the application group.
        /// 
        /// Valid values of N: 1 to 20.
        /// 
        /// For more information about how to obtain the ID of an application group, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public List<string> GroupIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tags.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddTagsRequestTag> Tag { get; set; }
        public class AddTagsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// 
            /// Valid values of N: 1 to 3. A tag key can be 1 to 64 characters in length.
            /// 
            /// You can create a tag key or specify an existing tag key. For more information about how to obtain a tag key, see [DescribeTagKeyList](https://help.aliyun.com/document_detail/145558.html).
            /// 
            /// > The tag key cannot start with `aliyun` or `acs:`. The tag key (`Tag.N.Key`) and tag value (`Tag.N.Value`) must be specified at the same time.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// 
            /// Valid values of N: 1 to 3. A tag value can be 1 to 64 characters in length.
            /// 
            /// You can create a tag value or specify an existing tag value. For more information about how to obtain a tag value, see [DescribeTagKeyList](https://help.aliyun.com/document_detail/145557.html).
            /// 
            /// > The tag value cannot start with `aliyun` or `acs:`. The tag key (`Tag.N.Key`) and tag value (`Tag.N.Value`) must be specified at the same time.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
