// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the resources whose tags you want to query. You must specify at least one of resourceId and tags.</para>
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
        /// <para>The tags that you want to use to filter resources based on exact match. Each tag is a key-value pair. You must specify at least one of resourceId and tags.</para>
        /// <para>You can enter up to 20 tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTags> Tags { get; set; }
        public class ListTagResourcesRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag that you want to use to filter resources. For example, if you set the key to <c>&quot;test-key&quot;</c>, only resources to which the key is added are returned.``</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that you want to use to filter resources. If you set the value to null, resources are filtered based only on the key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
