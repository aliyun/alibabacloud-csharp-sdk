// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class AddTagsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>Valid values of N: 1 to 20.</para>
        /// <para>For more information about how to obtain the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
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
        /// <para>The tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddTagsRequestTag> Tag { get; set; }
        public class AddTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>Valid values of N: 1 to 3. A tag key can be 1 to 64 characters in length.</para>
            /// <para>You can create a tag key or specify an existing tag key. For more information about how to obtain a tag key, see <a href="https://help.aliyun.com/document_detail/145558.html">DescribeTagKeyList</a>.</para>
            /// <remarks>
            /// <para> The tag key cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key (<c>Tag.N.Key</c>) and tag value (<c>Tag.N.Value</c>) must be specified at the same time.</para>
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
            /// <para>Valid values of N: 1 to 3. A tag value can be 1 to 64 characters in length.</para>
            /// <para>You can create a tag value or specify an existing tag value. For more information about how to obtain a tag value, see <a href="https://help.aliyun.com/document_detail/145557.html">DescribeTagValueList</a>.</para>
            /// <remarks>
            /// <para> The tag value cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key (<c>Tag.N.Key</c>) and tag value (<c>Tag.N.Value</c>) must be specified at the same time.</para>
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
