// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostAutomateResponseConfigRequest : TeaModel {
        /// <summary>
        /// <para>The action configuration of the automated response rule, in JSON array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;actionType&quot;: &quot;doPlaybook&quot;,
        ///             &quot;playbookName&quot;: &quot;WafBlockIP&quot;,
        ///             &quot;playbookUuid&quot;: &quot;bdad6220-6584-41b2-9704-fc6584568758&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("ActionConfig")]
        [Validation(Required=false)]
        public string ActionConfig { get; set; }

        /// <summary>
        /// <para>The type of the action. Separate multiple values with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>doPlaybook</b>: execute playbook</description></item>
        /// <item><description><b>changeEventStatus</b>: change event status</description></item>
        /// <item><description><b>changeThreatLevel</b>: change event threat level</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>doPlaybook,changeEventStatus</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>The type of the automated response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>event</b>: event</description></item>
        /// <item><description><b>alert</b>: alert</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("AutoResponseType")]
        [Validation(Required=false)]
        public string AutoResponseType { get; set; }

        /// <summary>
        /// <para>The trigger condition of the automated response rule, in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;left&quot;:{&quot;value&quot;:&quot;alert_name&quot;},&quot;operator&quot;:&quot;containsString&quot;,&quot;right&quot;:{&quot;value&quot;:&quot;webshell_online&quot;}}]</para>
        /// </summary>
        [NameInMap("ExecutionCondition")]
        [Validation(Required=false)]
        public string ExecutionCondition { get; set; }

        /// <summary>
        /// <para>The ID of the automated response rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. Select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Assets are located in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description><b>ap-southeast-1</b>: Assets are located outside the Chinese mainland.</description></item>
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
        /// <para>The name of the automated response rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw kill quara book</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17108579417****</para>
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public long? SubUserId { get; set; }

    }

}
