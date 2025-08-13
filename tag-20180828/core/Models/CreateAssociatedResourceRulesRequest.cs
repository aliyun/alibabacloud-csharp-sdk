// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class CreateAssociatedResourceRulesRequest : TeaModel {
        /// <summary>
        /// <para>The associated resource tagging rules that you want to create.</para>
        /// </summary>
        [NameInMap("CreateRulesList")]
        [Validation(Required=false)]
        public List<CreateAssociatedResourceRulesRequestCreateRulesList> CreateRulesList { get; set; }
        public class CreateAssociatedResourceRulesRequestCreateRulesList : TeaModel {
            [NameInMap("ExistingStatus")]
            [Validation(Required=false)]
            public string ExistingStatus { get; set; }

            /// <summary>
            /// <para>The name of the associated resource tagging rule.</para>
            /// <para>For more information, see the <b>Rule Name</b> column in <a href="https://help.aliyun.com/document_detail/2586330.html">Resource types that support the Associated Resource Tagging feature</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule:AttachEni-DetachEni-TagInstance:Ecs-Instance:Ecs-Eni</para>
            /// </summary>
            [NameInMap("SettingName")]
            [Validation(Required=false)]
            public string SettingName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the associated resource tagging rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enable (default)</description></item>
            /// <item><description>Disable</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag keys to which the associated resource tagging rule applies.</para>
            /// </summary>
            [NameInMap("TagKeys")]
            [Validation(Required=false)]
            public List<string> TagKeys { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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

    }

}
