// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para> If the call does not return all result entries, the value of the NextToken parameter is returned. By default, 200 rows are returned. You can call this operation again and set the value of the parameter to the value of the parameter that is returned in the last call to implement paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>A list of resource IDs for which you want to query tags. You can enter a maximum of 50 resource IDs.</para>
        /// <para>Enter multiple resource IDs in the <c>[&quot;ResourceId. 1&quot;,&quot;ResourceId. 2&quot;,...]</c> format.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of resource whose tags you want to query. Valid value:</para>
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
        /// <para>A list of tags that you want to query. Valid values of N: 1 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. A tag consists of a key-value pair.</para>
            /// <para>You can enter up to 20 tags. Enter multiple tags in the <c>[{&quot;Key&quot;:&quot;key1&quot;,&quot;Value&quot;:&quot;value1&quot;},{&quot;Key&quot;:&quot;key2&quot;,&quot;Value&quot;:&quot;value2&quot;},..]</c> format.</para>
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
