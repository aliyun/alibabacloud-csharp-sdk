// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region where the Bastionhost instance resides.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the Bastionhost instances. You can specify up to 20 instance IDs.</para>
        /// <para>N can be from 1 to 20.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the IDs of Bastionhost instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-78v1gc****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>Set the value to <c>INSTANCE</c>. This value indicates a Bastionhost instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags to add to the instances. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>The tag key cannot be an empty string. It can be up to 128 characters in length.</para>
            /// </description></item>
            /// <item><description><para>The tag key cannot start with <b>aliyun</b> or <b>acs:</b>. It cannot contain <b>http\://</b> or <b>https\://</b>.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>operation</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>The tag value can be an empty string. It can be up to 128 characters in length.</para>
            /// </description></item>
            /// <item><description><para>The tag value cannot start with <b>aliyun</b> or <b>acs:</b>. It cannot contain <b>http\://</b> or <b>https\://</b>.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>operation_test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
