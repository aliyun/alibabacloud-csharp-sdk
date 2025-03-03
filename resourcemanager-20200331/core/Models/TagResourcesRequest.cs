// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of a resource group or member.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the objects to which you want to add tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ResourceGroup : resource group. This is the default value.</description></item>
        /// <item><description>Account: member.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if you add tags to members in a resource directory.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceGroup</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>A tag key.</para>
            /// <para>A tag key can be a maximum of 128 characters in length. It cannot contain <c>http://</c> or <c>https://</c> and cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>A tag value.</para>
            /// <para>A tag value can be a maximum of 128 characters in length. It cannot contain <c>http://</c> or <c>https://</c> and cannot start with <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
