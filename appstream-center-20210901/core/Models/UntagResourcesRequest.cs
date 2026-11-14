// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all custom tags from the resources. <b>This parameter takes effect only when TagKey.N is not specified</b>. If TagKey.N is specified, this parameter is ignored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Removes all custom tags from the resources, including Wuying system tags that start with <c>System/</c> and are bound by calling the <a href="~~TagResources~~">TagResources</a> operation.</description></item>
        /// <item><description>false (default): Does not remove all tags. If TagKey.N is also not specified, the error code InvalidParameter.TagKeyListOrAll is returned.</description></item>
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
        /// <para>The region ID. This parameter is required. Set this parameter to the ID of the region where the app instance group resides, such as cn-hangzhou.</para>
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
        /// <para><b>All IDs must belong to existing app instance groups within the current Alibaba Cloud account.</b> If any ID does not exist or does not belong to the current account, the entire request fails and the error code InvalidAppInstanceGroup.NotFound is returned. No tags are removed from any resources.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. This parameter is required. <b>Currently, only app instance groups are supported</b>. The value is not case-sensitive, but we recommend that you use uppercase letters:</para>
        /// <list type="bullet">
        /// <item><description>APPINSTANCEGROUP: Wuying app instance group.</description></item>
        /// </list>
        /// <para>If you specify other values, the error code InvalidResourceType.Invalid is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPINSTANCEGROUP</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tag keys to be removed. A maximum of 20 tag keys can be specified in a single request. <b>You must specify at least one of TagKey.N and All</b>. If neither is specified, the error code InvalidParameter.TagKeyListOrAll is returned.</para>
        /// <list type="bullet">
        /// <item><description>If TagKey.N is specified, only the tags corresponding to these tag keys are removed, and the All parameter is ignored.</description></item>
        /// <item><description>If a specified tag key does not exist on a resource, the tag key is skipped and no error is returned.</description></item>
        /// <item><description>If TagKey.N is not specified, you must set All to true to remove all custom tags from the resources.</description></item>
        /// </list>
        /// <para>Tag keys that start with <c>System/</c> are Wuying system tags. Only the following values are supported:</para>
        /// <list type="bullet">
        /// <item><description>System/Scheduler/GRAYSCALE: The grayscale tag for the app instance group.</description></item>
        /// <item><description>System/Scheduler/STOP_NEW_USER_CONNECTION: Prevents new connections from users newly bound to the app instance group.</description></item>
        /// </list>
        /// <para>If you specify other tag keys that start with <c>System/</c>, the error code InvalidTagPolicy.KeyInvalid or InvalidTag.SystemKeyNotAllow is returned.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
