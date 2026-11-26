// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results when the response is truncated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of resource IDs. You can specify up to 50 resource IDs in a single call.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The resource type supports users and access configurations:</description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the resource type is user, enter the user ID.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the resource type is access configuration, enter the access configuration ID.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para><notice>If the DirectoryId parameter is not specified, you must add the prefix &quot;${DirectoryId}_&quot; to the resource ID.</notice></para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Users and access configurations are supported.</para>
        /// <list type="bullet">
        /// <item><description><para>Set the value to user for users.</para>
        /// </description></item>
        /// <item><description><para>Set the value to accessConfiguration for access configurations.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accessConfiguration</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags. You can specify up to 20 tags in a single call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>The value cannot be an empty string.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
