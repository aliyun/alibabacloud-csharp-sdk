// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateNotificationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable simple mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DirectedMode")]
        [Validation(Required=false)]
        public bool? DirectedMode { get; set; }

        /// <summary>
        /// <para>The ID of the escalation policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("EscalationPolicyId")]
        [Validation(Required=false)]
        public long? EscalationPolicyId { get; set; }

        /// <summary>
        /// <para>An array of alert event group objects.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify the groupingFields field, all alerts will be sent to contacts based on <c>alertname</c>.</description></item>
        /// <item><description>If you specify the groupingFields field, alerts with the same field will be sent to contacts in one notification.</description></item>
        /// </list>
        /// <para>Sample statement:</para>
        /// <pre><c>{ 
        /// &quot;groupWait&quot;:5,    // The waiting time for grouping. 
        /// &quot;groupInterval&quot;:30,     // The time interval of grouping. 
        /// &quot;groupingFields&quot;:[&quot;alertname&quot;]       // The field that is used to group alert events. 
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{ 	&quot;groupWait&quot;:5, 	&quot;groupInterval&quot;:30, 	&quot;groupingFields&quot;:[&quot;alertname&quot;] }</para>
        /// </summary>
        [NameInMap("GroupRule")]
        [Validation(Required=false)]
        public string GroupRule { get; set; }

        /// <summary>
        /// <para>The ID of the notification policy.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, a new notification policy is created.</description></item>
        /// <item><description>If you specify this parameter, the specified notification policy is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The integration ID of the ticket system to which alerts are pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34</para>
        /// </summary>
        [NameInMap("IntegrationId")]
        [Validation(Required=false)]
        public long? IntegrationId { get; set; }

        /// <summary>
        /// <para>The matching rules. Format:</para>
        /// <pre><c>[
        ///  {
        ///  &quot;matchingConditions&quot;: [
        ///  { 
        ///  &quot;value&quot;: &quot;test&quot;,    // The value of the matching condition. 
        ///  &quot;key&quot;: &quot;alertname&quot;,     // The key of the matching condition. 
        ///  &quot;operator&quot;: &quot;eq&quot;   // The logical operator of the matching condition, including eq (equal to), neq (not equal to), in (contains), nin (does not contain), re (regular expression match), and nre (regular expression mismatch).   
        ///  }
        ///  ]
        ///  } 
        ///  ]
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>[ 		 { 		 &quot;matchingConditions&quot;: [          { 		 &quot;value&quot;: &quot;test&quot;, 		 &quot;key&quot;: &quot;alertname&quot;, 		 &quot;operator&quot;: &quot;eq&quot;         }       ]     }   ]</para>
        /// </summary>
        [NameInMap("MatchingRules")]
        [Validation(Required=false)]
        public string MatchingRules { get; set; }

        /// <summary>
        /// <para>The name of the notification policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notificationpolicy_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>An array of notification rule objects. Format:</para>
        /// <pre><c>{ 
        ///  &quot;notifyStartTime&quot;:&quot;00:00&quot;,      // The start time of the notification window. 
        ///  &quot;notifyEndTime&quot;:&quot;23:59&quot;,       // The end time of the notification window. 
        ///  &quot;notifyChannels&quot;:[&quot;dingTalk&quot;, &quot;email&quot;, &quot;sms&quot;, &quot;tts&quot;, &quot;webhook&quot;],       // The notification methods. Valid values: dingTalk, email, sms, tts, and webhook. 
        ///  &quot;notifyObjects&quot;:[{       // An array of notification objects. 
        ///  &quot;notifyObjectType&quot;:&quot;CONTACT&quot;,       // The type of the notification object. Valid values: CONTACT (contact), CONTACT_GROUP (contact group), ARMS_CONTACT (ARMS contact), ARMS_CONTACT_GROUP (ARMS contact group), DING_ROBOT_GROUP (DingTalk, Lark, WeCom, or IM robot), and CONTACT_SCHEDULE (user on duty defined by a schedule). 
        ///  &quot;notifyObjectId&quot;:123,       // The ID of the notification object. 
        ///  &quot;notifyObjectName&quot;:&quot;test&quot;       // The name of the notification object. 
        ///  }]
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;notifyStartTime&quot;:&quot;00:00&quot;,     &quot;notifyEndTime&quot;:&quot;23:59&quot;,     &quot;notifyChannels&quot;:[         &quot;dingTalk&quot;,         &quot;email&quot;,         &quot;sms&quot;,         &quot;tts&quot;,         &quot;webhook&quot;     ],     &quot;notifyObjects&quot;:[         {             &quot;notifyObjectType&quot;:&quot;CONTACT&quot;,             &quot;notifyObjectId&quot;:123,             &quot;notifyObjectName&quot;:&quot;test&quot;         }     ] }</para>
        /// </summary>
        [NameInMap("NotifyRule")]
        [Validation(Required=false)]
        public string NotifyRule { get; set; }

        /// <summary>
        /// <para>The notification template. The default notification template is provided below the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;robotContent&quot;:&quot;{{if .commonLabels.clustername }} &gt; Cluster name: {{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }} &gt; Application name: {{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }}{{ for .alerts }} &gt; {{.annotations.message}} {{if .generatorURL }} [Link]\({{.generatorURL}}) {{ end }} {{if eq &quot;true&quot; .labels._aliyun_arms_is_denoise_filtered }} (Suspected noise) {{end}} {{end}}&quot;</para>
        /// </summary>
        [NameInMap("NotifyTemplate")]
        [Validation(Required=false)]
        public string NotifyTemplate { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to resend a notification for a long-lasting unresolved alert. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: If you set this parameter to <c>true</c>, you must set <b>RepeatInterval</b>.</description></item>
        /// <item><description><c>false</c>: If you set this parameter to <c>false</c>, you must set <b>EscalationPolicyId</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Repeat")]
        [Validation(Required=false)]
        public bool? Repeat { get; set; }

        /// <summary>
        /// <para>The time interval at which a notification is resent for a long-lasting unresolved alert. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("RepeatInterval")]
        [Validation(Required=false)]
        public long? RepeatInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether the status of an alert automatically changes to Resolved when all events related to the alert change to the Restored state. ARMS notifies contacts when the alert status changes to Resolved.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The system sends a notification.</description></item>
        /// <item><description><c>false</c>: The system does not send a notification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SendRecoverMessage")]
        [Validation(Required=false)]
        public bool? SendRecoverMessage { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the notification policy. Valid values: enable and disable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
