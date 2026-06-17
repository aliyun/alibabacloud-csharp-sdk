// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class AddTagsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the application groups.</para>
        /// <para>The value of N can be from 1 to 20.</para>
        /// <para>For information about how to obtain application group IDs, see <a href="https://help.aliyun.com/document_detail/2513168.html">DescribeMonitorGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7301****</para>
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public List<string> GroupIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddTagsRequestTag> Tag { get; set; }
        public class AddTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The value of N can be from 1 to 3. The tag key must be 1 to 64 characters in length.</para>
            /// <para>Enter a new tag key or use an existing tag key from Cloud Monitor. For information about how to obtain tag keys, see <a href="https://help.aliyun.com/document_detail/2513189.html">DescribeTagKeyList</a>.</para>
            /// <remarks>
            /// <para>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>. The <c>Tag.N.Key</c> and <c>Tag.N.Value</c> parameters must be specified together.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The value of N can be from 1 to 3. The tag value must be 1 to 64 characters in length.</para>
            /// <para>Enter a new tag value or use an existing tag value from Cloud Monitor. For information about how to obtain tag values, see <a href="https://help.aliyun.com/document_detail/2513188.html">DescribeTagValueList</a>.</para>
            /// <remarks>
            /// <para>The tag value cannot start with <c>aliyun</c> or <c>acs:</c>. The <c>Tag.N.Key</c> and <c>Tag.N.Value</c> parameters must be specified together.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
