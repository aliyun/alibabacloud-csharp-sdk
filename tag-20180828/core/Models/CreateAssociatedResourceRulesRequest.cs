// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class CreateAssociatedResourceRulesRequest : TeaModel {
        /// <summary>
        /// <para>A list of associated resource tag rules.</para>
        /// </summary>
        [NameInMap("CreateRulesList")]
        [Validation(Required=false)]
        public List<CreateAssociatedResourceRulesRequestCreateRulesList> CreateRulesList { get; set; }
        public class CreateAssociatedResourceRulesRequestCreateRulesList : TeaModel {
            [NameInMap("ExistingStatus")]
            [Validation(Required=false)]
            public string ExistingStatus { get; set; }

            /// <summary>
            /// <para>The setting name of the associated resource tag rule.</para>
            /// <para>For valid values, see the <b>Setting name</b> column in <a href="https://help.aliyun.com/document_detail/2586330.html">Resources that support associated resource tagging</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule:AttachEni-DetachEni-TagInstance:Ecs-Instance:Ecs-Eni</para>
            /// </summary>
            [NameInMap("SettingName")]
            [Validation(Required=false)]
            public string SettingName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the associated resource tag rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Enable (default): The rule is enabled.</para>
            /// </description></item>
            /// <item><description><para>Disable: The rule is disabled.</para>
            /// </description></item>
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
            /// <para>The tag keys to which the rule applies.</para>
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
