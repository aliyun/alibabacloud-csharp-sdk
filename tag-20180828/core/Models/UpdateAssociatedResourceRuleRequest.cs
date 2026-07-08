// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class UpdateAssociatedResourceRuleRequest : TeaModel {
        [NameInMap("ExistingStatus")]
        [Validation(Required=false)]
        public string ExistingStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The name of the Associated Resource Tag Rule setting.</para>
        /// <para>For valid values, see the <b>Setting Name</b> column in <a href="https://help.aliyun.com/document_detail/2586330.html">Resources that support the Associated Resource Tag Rule feature</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule:AssociateEip-UnassociateEip-TagInstance:Ecs-Instance:Vpc-Eip</para>
        /// </summary>
        [NameInMap("SettingName")]
        [Validation(Required=false)]
        public string SettingName { get; set; }

        /// <summary>
        /// <para>The status of the Associated Resource Tag Rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Enable: The rule is enabled.</para>
        /// </description></item>
        /// <item><description><para>Disable: The rule is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A list of tag keys for the Associated Resource Tag Rule.</para>
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

    }

}
