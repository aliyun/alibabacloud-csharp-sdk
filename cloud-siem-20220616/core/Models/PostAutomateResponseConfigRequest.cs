// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostAutomateResponseConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the action that is specified in the automated response rule. The value is a JSON array.</para>
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
        /// <item><description><para><b>doPlaybook</b>: runs a playbook</para>
        /// </description></item>
        /// <item><description><para><b>changeEventStatus</b>: changes the status of the event</para>
        /// </description></item>
        /// <item><description><para><b>changeThreatLevel</b>: changes the threat level of the event</para>
        /// </description></item>
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
        /// <item><description><para><b>event</b>: event</para>
        /// </description></item>
        /// <item><description><para><b>alert</b>: alert</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("AutoResponseType")]
        [Validation(Required=false)]
        public string AutoResponseType { get; set; }

        /// <summary>
        /// <para>The trigger condition of the automated response rule. The value is in the JSON format.</para>
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
        /// <para>The region where the Data Management center of Threat Analysis is located. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: your assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: your assets are outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user that the administrator uses to switch the view. This parameter is used when an administrator switches to the perspective of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: the view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: the view of all accounts that are managed by the administrator.</para>
        /// </description></item>
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
