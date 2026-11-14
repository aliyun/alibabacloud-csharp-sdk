// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. This parameter is required. Specify the ID of the region where the app instance group resides, such as <c>cn-hangzhou</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of resource IDs to which you want to bind tags. This parameter is required. Specify the app instance group IDs. You can specify up to 50 IDs in a single request. Duplicate IDs are automatically deduplicated.</para>
        /// <para><b>All IDs must belong to existing app instance groups under the current Alibaba Cloud account.</b> If any ID does not exist or does not belong to the current account, the entire request fails and the error code <c>InvalidAppInstanceGroup.NotFound</c> is returned. No tags are bound to any resources.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. This parameter is required. <b>Currently, only app instance groups are supported</b>. The value is case-insensitive, but we recommend that you use uppercase letters:</para>
        /// <list type="bullet">
        /// <item><description><c>APPINSTANCEGROUP</c>: app instance group.</description></item>
        /// </list>
        /// <para>If you specify other values, the error code <c>InvalidResourceType.Invalid</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPINSTANCEGROUP</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags to bind. This parameter is required. You can specify up to 20 tags in a single request. You must specify both Key and Value for each tag.</para>
        /// <list type="bullet">
        /// <item><description>Tag keys in the same request cannot be duplicate. Otherwise, the error code <c>InvalidTag.Duplicated</c> is returned.</description></item>
        /// <item><description>If a tag with the same key already exists on the resource, the tag value is updated to the value specified in the current request.</description></item>
        /// <item><description>A single resource can be bound to up to 20 custom tags. If this limit is exceeded, the error code <c>ResourceTag.CustomTagCountExceed</c> is returned.</description></item>
        /// </list>
        /// <para>Tag keys starting with <c>System/</c> are Wuying system tags. Only the following values are supported, and the tag value can only be <c>true</c> or <c>false</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>System/Scheduler/GRAYSCALE</c>: the canary release tag for the app instance group.</description></item>
        /// <item><description><c>System/Scheduler/STOP_NEW_USER_CONNECTION</c>: prevents newly bound users from establishing connections to the app instance group.</description></item>
        /// </list>
        /// <para>If you specify other tag keys starting with <c>System/</c>, the error code <c>InvalidTag.SystemTagKeyInvalid</c> or <c>InvalidTag.SystemKeyNotAllow</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. This parameter is required. The tag key must be 1 to 128 characters in length and is case-sensitive. It cannot start with <c>aliyun</c> or <c>acs:</c> (case-insensitive) and cannot contain <c>http://</c> or <c>https://</c>. It supports letters, digits, spaces, and common Chinese and English punctuation marks. If the tag key does not meet the rules, the error code <c>InvalidTagPolicy.KeyInvalid</c> is returned.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resolution</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. This parameter is required. The tag value must be 0 to 256 characters in length and is case-sensitive. Empty strings are allowed. It cannot contain <c>http://</c> or <c>https://</c>. If the tag value does not meet the rules, the error code <c>InvalidTagPolicy.ValueInvalid</c> is returned.</para>
            /// <para>If the tag key is a system tag, the tag value can only be <c>true</c> or <c>false</c>.</para>
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
