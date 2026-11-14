// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class TagCloudResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The list of resource IDs. A maximum of 50 resource IDs are supported. This parameter is not required when the resource type is tenant ID.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The cloud resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppInstanceGroupId</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags. System tags and custom tags are supported.</para>
        /// <list type="bullet">
        /// <item><description><para>System tag enum values:</para>
        /// <list type="bullet">
        /// <item><description><c>System/Scheduler/GRAYSCALE</c>: grayscale tag.</description></item>
        /// <item><description><c>System/Scheduler/STOP_NEW_USER_CONNECTION</c>: tag that prevents new users bound to the app instance group from establishing connections.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Custom tags: A maximum of 20 custom tags can be created.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>A tag key on a resource can map to only one tag value. If you add a tag with an existing key, the tag value is updated to the new value.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<TagCloudResourcesRequestTags> Tags { get; set; }
        public class TagCloudResourcesRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. It is case-sensitive and must be 1 to 128 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resolution</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. It is case-sensitive and must be 1 to 128 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720p</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
