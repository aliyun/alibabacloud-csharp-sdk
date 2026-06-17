// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyThreatIntelligenceSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The list of threat intelligence categories.</para>
        /// </summary>
        [NameInMap("CategoryList")]
        [Validation(Required=false)]
        public List<ModifyThreatIntelligenceSwitchRequestCategoryList> CategoryList { get; set; }
        public class ModifyThreatIntelligenceSwitchRequestCategoryList : TeaModel {
            /// <summary>
            /// <para>The action of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>alert</b>: observation</para>
            /// </description></item>
            /// <item><description><para><b>drop</b>: block</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alert</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The ID of the threat intelligence category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IpOutThreatTorExit</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The status of the switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

        }

    }

}
