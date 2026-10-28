// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all custom tags from the resources. <b>This parameter takes effect only when <c>TagKey.N</c> is not specified</b>. If <c>TagKey.N</c> is specified, this parameter is ignored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: removes all custom tags from the resources, including Wuying system tags that start with <c>System/</c> and were bound by calling the <a href="~~TagResources~~">TagResources</a> operation.</description></item>
        /// <item><description><c>false</c> (default): does not remove all tags. If <c>TagKey.N</c> is also not specified, the operation returns the error code <c>InvalidParameter.TagKeyListOrAll</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

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
        /// <para>The list of resource IDs from which you want to remove tags. This parameter is required. Specify the app instance group IDs. A maximum of 50 IDs can be specified in a single request. Duplicate IDs are automatically deduplicated.</para>
        /// <para><b>All IDs must belong to existing app instance groups within the current Alibaba Cloud account.</b> If any ID does not exist or does not belong to the current account, the entire request fails and the operation returns the error code <c>InvalidAppInstanceGroup.NotFound</c>. No resources are untagged.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. This parameter is required. <b>Currently, only app instance groups are supported</b>. The value is case-insensitive. We recommend that you use uppercase letters:</para>
        /// <list type="bullet">
        /// <item><description><c>APPINSTANCEGROUP</c>: Wuying app instance group.</description></item>
        /// </list>
        /// <para>If you specify other values, the operation returns the error code <c>InvalidResourceType.Invalid</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPINSTANCEGROUP</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tag keys to be removed. A maximum of 20 tag keys can be specified in a single request. <b>You must specify at least one of <c>TagKey.N</c> and <c>All</c></b>. If neither is specified, the operation returns the error code <c>InvalidParameter.TagKeyListOrAll</c>.</para>
        /// <list type="bullet">
        /// <item><description>If <c>TagKey.N</c> is specified, only the tags corresponding to these tag keys are removed, and the <c>All</c> parameter is ignored.</description></item>
        /// <item><description>If a specified tag key does not exist on a resource, the tag key is skipped and no error is returned.</description></item>
        /// <item><description>If <c>TagKey.N</c> is not specified, you must set <c>All</c> to <c>true</c> to remove all custom tags from the resources.</description></item>
        /// </list>
        /// <para>Tag keys that start with <c>System/</c> are Wuying system tags. Only the following values are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>System/Scheduler/GRAYSCALE</c>: The grayscale tag for the app instance group.</description></item>
        /// <item><description><c>System/Scheduler/STOP_NEW_USER_CONNECTION</c>: Prevents newly bound users from establishing connections to the app instance group.</description></item>
        /// </list>
        /// <para>If you specify other tag keys that start with <c>System/</c>, the operation returns the error code <c>InvalidTagPolicy.KeyInvalid</c> or <c>InvalidTag.SystemKeyNotAllow</c>.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
