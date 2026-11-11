// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EcdBiz20240929.Models
{
    public class ActiveRightsRequest : TeaModel {
        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.1</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The ID of the image that is available for the specification in the target region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-example</para>
        /// </summary>
        [NameInMap("CustomImageId")]
        [Validation(Required=false)]
        public string CustomImageId { get; set; }

        /// <summary>
        /// <para>The size of the data cloud disk, in GiB. Pass this parameter only when the commodity supports this activation parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        /// <summary>
        /// <para>The desktop type. Specify the value based on the types supported by the selected commodity. Omit this parameter if regular cloud desktops do not have this configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.business_edition_office.4c8g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The end time of the non-hibernation period, in the HH:mm:ss format. This parameter is used together with StartTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The hibernation-related options. The compute plan and existing activation rules corresponding to the right are used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Hibernate")]
        [Validation(Required=false)]
        public int? Hibernate { get; set; }

        /// <summary>
        /// <para>The display language of the cloud desktop. Valid values: en-US, ja-JP, zh-CN, and zh-HK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The ID of the office network in the target region. This parameter is required when you activate a cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-example</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The ID of the policy group. This parameter is optional. If you do not specify this parameter, the default policy of the workspace is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-example</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. This parameter is optional. The ID is specified by the caller and passed through to the activation request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-example</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of IDs of the assigned end users. The IDs correspond to the rights in this batch by position. For convenience accounts, pass the EndUserId. The number of IDs must be the same as the number of rights.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;user-example&quot;]</para>
        /// </summary>
        [NameInMap("RightsAssignedUser")]
        [Validation(Required=false)]
        public List<string> RightsAssignedUser { get; set; }

        /// <summary>
        /// <para>The GPU specification. The value is subject to the return value of the rights details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.graphics_flagship_pro.8c16g.2g</para>
        /// </summary>
        [NameInMap("RightsGpuSpec")]
        [Validation(Required=false)]
        public string RightsGpuSpec { get; set; }

        /// <summary>
        /// <para>The list of IDs of the rights to be activated. Select the rights accessible to the current identity from ListRights. The parameters in the same batch apply to these rights.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;New_beds-example_0001&quot;]</para>
        /// </summary>
        [NameInMap("RightsIds")]
        [Validation(Required=false)]
        public List<string> RightsIds { get; set; }

        /// <summary>
        /// <para>The area to which the right belongs. This parameter cannot replace the resource region for a new activation request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-east</para>
        /// </summary>
        [NameInMap("RightsResourceArea")]
        [Validation(Required=false)]
        public string RightsResourceArea { get; set; }

        /// <summary>
        /// <para>The operating system type of the image used for rights activation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("RightsResourceImageOs")]
        [Validation(Required=false)]
        public string RightsResourceImageOs { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resource resides. This parameter is configured separately from the routing region of the POP request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RightsResourceRegion")]
        [Validation(Required=false)]
        public string RightsResourceRegion { get; set; }

        /// <summary>
        /// <para>The resource type of the right. For regular cloud desktops, use Desktop. For other commodities, pass the actual type of the right.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("RightsResourceType")]
        [Validation(Required=false)]
        public string RightsResourceType { get; set; }

        /// <summary>
        /// <para>The specification code of the right. The value is subject to the rights query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.business_edition_office.4c8g</para>
        /// </summary>
        [NameInMap("RightsSpec")]
        [Validation(Required=false)]
        public string RightsSpec { get; set; }

        /// <summary>
        /// <para>The size of the system cloud disk, in GiB. Pass this parameter only when the commodity supports this activation parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("RootDiskSize")]
        [Validation(Required=false)]
        public int? RootDiskSize { get; set; }

        /// <summary>
        /// <para>The start time of the non-hibernation period, in the HH:mm:ss format. This parameter applies only to the corresponding compute plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the target office network. Pass the value based on the network type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-example</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The list of AD workspace IDs used for BusinessJvsCopilotAgent activation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ws-example&quot;]</para>
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public List<string> WorkspaceIds { get; set; }

        /// <summary>
        /// <para>The list of WAIDs used for BusinessJvsCopilotAgent activation. Do not pass this parameter for regular cloud desktop activation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;waid-example&quot;]</para>
        /// </summary>
        [NameInMap("WyidList")]
        [Validation(Required=false)]
        public List<string> WyidList { get; set; }

    }

}
