// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostRuleStatusChangeRequest : TeaModel {
        /// <summary>
        /// <para>The list of rule IDs in JSON array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[123,345]</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>The enabling status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InUse")]
        [Validation(Required=false)]
        public bool? InUse { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. Select the region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets are located in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Assets are located outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: The view of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>predefine: Predefined.</description></item>
        /// <item><description>customize: Custom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customize</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
