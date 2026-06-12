// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The resource IDs. You can specify only one resource and add tags to the resource.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>project</para>
        /// </description></item>
        /// <item><description><para>logstore</para>
        /// </description></item>
        /// <item><description><para>dashboard</para>
        /// </description></item>
        /// <item><description><para>machinegroup</para>
        /// </description></item>
        /// <item><description><para>logtailconfig</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags that you want to add to the resource. You can specify up to 20 tags in each call. Each tag is a key-value pair.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTags> Tags { get; set; }
        public class TagResourcesRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag. The key must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>The key must be <c>1 to 128</c> characters in length.</para>
            /// </description></item>
            /// <item><description><para>The key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
            /// <item><description><para>The key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The value must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>The value must be <c>1 to 128</c> characters in length.</para>
            /// </description></item>
            /// <item><description><para>The value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
