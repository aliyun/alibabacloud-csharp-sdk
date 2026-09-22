// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. This parameter is required. Set this parameter to the ID of the region where the delivery group resides, such as <c>cn-hangzhou</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of resource IDs to which you want to bind tags. This parameter is required. Specify delivery group IDs. You can specify up to 50 IDs in a single request. Duplicate IDs are automatically deduplicated.</para>
        /// <para><b>All IDs must be existing delivery groups under the current Alibaba Cloud account.</b> If any ID does not exist or does not belong to the current account, the entire request fails and the error code <c>InvalidAppInstanceGroup.NotFound</c> is returned. No tags are bound to any resource.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. This parameter is required. <b>Currently, only delivery groups are supported.</b> The value is case-insensitive. We recommend that you use uppercase letters.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>APPINSTANCEGROUP: China Office (Chinese: Wuying) delivery group.</description></item>
        /// </list>
        /// <para>If you specify another value, the error code <c>InvalidResourceType.Invalid</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPINSTANCEGROUP</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags to bind. This parameter is required. You can specify up to 20 tags in a single request. Each tag must include both <c>Key</c> and <c>Value</c>.</para>
        /// <list type="bullet">
        /// <item><description>Tag keys in the same request must be unique. Otherwise, the error code <c>InvalidTag.Duplicated</c> is returned.</description></item>
        /// <item><description>If a tag key already exists on the resource, the tag value is updated to the value specified in the current request.</description></item>
        /// <item><description>A maximum of 20 custom tags can be bound to a single resource. If this limit is exceeded, the error code <c>ResourceTag.CustomTagCountExceed</c> is returned.</description></item>
        /// </list>
        /// <para>Tag keys that start with <c>System/</c> are China Office (Chinese: Wuying) system tags. Only the following values are supported, and the tag value can be only <c>true</c> or <c>false</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>System/Scheduler/GRAYSCALE</c>: the canary release tag for the delivery group.</description></item>
        /// <item><description><c>System/Scheduler/STOP_NEW_USER_CONNECTION</c>: prevents newly bound users from establishing connections to the delivery group.</description></item>
        /// </list>
        /// <para>If you specify other tag keys that start with <c>System/</c>, the error code <c>InvalidTag.SystemTagKeyInvalid</c> or <c>InvalidTag.SystemKeyNotAllow</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. This parameter is required. The tag key must be 1 to 128 characters in length and is case-sensitive. The tag key cannot start with <c>aliyun</c> or <c>acs:</c> (case-insensitive) and cannot contain <c>http://</c> or <c>https://</c>. Letters, digits, spaces, and common punctuation marks are supported. If the tag key does not comply with the rules, the error code <c>InvalidTagPolicy.KeyInvalid</c> is returned.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resolution</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. This parameter is required. The tag value must be 0 to 256 characters in length and is case-sensitive. An empty string is allowed. The tag value cannot contain <c>http://</c> or <c>https://</c>. If the tag value does not comply with the rules, the error code <c>InvalidTagPolicy.ValueInvalid</c> is returned.</para>
            /// <para>If the tag key is a system tag, the tag value can be only <c>true</c> or <c>false</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720p</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
