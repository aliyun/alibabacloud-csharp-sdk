// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyResourceCenterPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud computer policies that you want to associate with cloud computers.</para>
        /// <remarks>
        /// <para> You can specify up to one cloud computer policy that takes effect globally, and up to four cloud computer policies that apply to specific IP addresses. If multiple cloud computer policies are configured for global enforcement, only the earliest-associated policy will take effect</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PolicyGroupIds")]
        [Validation(Required=false)]
        public List<string> PolicyGroupIds { get; set; }

        /// <summary>
        /// <para>The policy type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>general: a general policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>general</para>
        /// </summary>
        [NameInMap("PolicyGroupType")]
        [Validation(Required=false)]
        public string PolicyGroupType { get; set; }

        /// <summary>
        /// <para>The service type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>app: cloud applications.</description></item>
        /// <item><description>resourceGroup: resource groups.</description></item>
        /// <item><description>desktop: cloud computers.</description></item>
        /// <item><description>desktopGroup: cloud computer shares.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The resource IDs. You can specify up to 100 resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>app: cloud applications.</description></item>
        /// <item><description>desktop: cloud computers.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
