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
        /// <item><description>project</description></item>
        /// <item><description>logstore</description></item>
        /// <item><description>dashboard</description></item>
        /// <item><description>machinegroup</description></item>
        /// <item><description>logtailconfig</description></item>
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
            /// <item><description>The key must be <c>1 to 128</c> characters in length.</description></item>
            /// <item><description>The key cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// <item><description>The key cannot start with <c>acs:</c> or <c>aliyun</c>.</description></item>
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
            /// <item><description>The value must be <c>1 to 128</c> characters in length.</description></item>
            /// <item><description>The value cannot contain <c>http://</c> or <c>https://</c>.</description></item>
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
