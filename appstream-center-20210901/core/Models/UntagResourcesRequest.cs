// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to unbind all custom tags from the resource. <b>This parameter takes effect only when <c>TagKey.N</c> is not specified.</b> If <c>TagKey.N</c> is specified, this parameter is ignored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Unbinds all custom tags from the resource, including Wuying system tags that start with <c>System/</c> and were bound by calling <a href="~~TagResources~~">TagResources</a>.</description></item>
        /// <item><description><c>false</c> (default): Does not perform a full unbinding. If <c>TagKey.N</c> is also not specified, the error code <c>InvalidParameter.TagKeyListOrAll</c> is returned.</description></item>
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
        /// <para>The list of resource IDs from which you want to unbind tags. This parameter is required. Specify delivery group IDs. You can specify up to 50 IDs at a time. Duplicate IDs are automatically deduplicated.</para>
        /// <para><b>All IDs must correspond to existing delivery groups under the current Alibaba Cloud account.</b> If any ID does not exist or does not belong to the current account, the entire request fails with the error code <c>InvalidAppInstanceGroup.NotFound</c>, and no tags are unbound from any resource.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. This parameter is required. <b>Currently, only delivery groups are supported.</b> The value is case-insensitive. We recommend that you use uppercase.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>APPINSTANCEGROUP</c>: Wuying delivery group.</description></item>
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
        /// <para>The list of tag keys to unbind. You can specify up to 20 tag keys at a time. <b>Specify at least one of <c>TagKey.N</c> and <c>All</c>.</b> If neither is specified, the error code <c>InvalidParameter.TagKeyListOrAll</c> is returned.</para>
        /// <list type="bullet">
        /// <item><description>If <c>TagKey.N</c> is specified, only the tags that correspond to the specified tag keys are unbound. The <c>All</c> parameter is ignored.</description></item>
        /// <item><description>If a specified tag key does not exist on the resource, the tag key is skipped and no error is returned.</description></item>
        /// <item><description>If <c>TagKey.N</c> is not specified, set <c>All</c> to <c>true</c> to unbind all custom tags from the resource.</description></item>
        /// </list>
        /// <para>Tag keys that start with <c>System/</c> are Wuying system tags. Only the following values are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>System/Scheduler/GRAYSCALE</c>: the canary release tag for the delivery group.</description></item>
        /// <item><description><c>System/Scheduler/STOP_NEW_USER_CONNECTION</c>: prevents newly bound users from establishing connections to the delivery group.</description></item>
        /// </list>
        /// <para>If you specify other tag keys that start with <c>System/</c>, the error code <c>InvalidTagPolicy.KeyInvalid</c> or <c>InvalidTag.SystemKeyNotAllow</c> is returned.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
