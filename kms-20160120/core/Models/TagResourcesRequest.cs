// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/601478.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The IDs of the resources to which you want to add tags. You can enter a maximum of 50 resource IDs.</para>
        /// <para>Enter multiple resource IDs in the <c>[&quot;ResourceId. 1&quot;,&quot;ResourceId. 2&quot;,...]</c> format.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource to which you want to add tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>key</description></item>
        /// <item><description>secret</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>A list of tags. You can enter up to 20 tags.</para>
        /// <para>A tag consists of a key-value pair. Enter multiple tags in the <c>[{&quot;Key&quot;:&quot;key1&quot;,&quot;Value&quot;:&quot;value1&quot;},{&quot;Key&quot;:&quot;key2&quot;,&quot;Value&quot;:&quot;value2&quot;},..]</c> format.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. A tag consists of a key-value pair.</para>
            /// <para>You can enter up to 20 tags. Enter multiple tags in the <c>[{&quot;Key&quot;:&quot;key1&quot;,&quot;Value&quot;:&quot;value1&quot;},{&quot;Key&quot;:&quot;key2&quot;,&quot;Value&quot;:&quot;value2&quot;},..]</c> format.</para>
            /// <para>Each key can be up to 128 characters in length and can contain letters, digits, forward slashes (/), backslashes (\\), underscores (_), hyphens (-), periods (.), plus signs (+), equal signs (=), colons (:), and at signs (@).</para>
            /// <remarks>
            /// <para> The key cannot start with aliyun or acs:.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>disk-encryption</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. A tag consists of a key-value pair.</para>
            /// <para>You can enter up to 20 tags. Enter multiple tags in the <c>[{&quot;Key&quot;:&quot;key1&quot;,&quot;Value&quot;:&quot;value1&quot;},{&quot;Key&quot;:&quot;key2&quot;,&quot;Value&quot;:&quot;value2&quot;},..]</c> format.</para>
            /// <para>Each value can be up to 128 characters in length and can contain letters, digits, forward slashes (/), backslashes (\\), underscores (_), hyphens (-), periods (.), plus signs (+), equal signs (=), colons (:), and at signs (@).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
