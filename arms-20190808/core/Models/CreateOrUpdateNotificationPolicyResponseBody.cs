// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateNotificationPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of notification policy objects.</para>
        /// </summary>
        [NameInMap("NotificationPolicy")]
        [Validation(Required=false)]
        public CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicy NotificationPolicy { get; set; }
        public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicy : TeaModel {
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
            /// </summary>
            [NameInMap("GroupRule")]
            [Validation(Required=false)]
            public CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyGroupRule GroupRule { get; set; }
            public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyGroupRule : TeaModel {
                /// <summary>
                /// <para>The time interval of grouping. Unit: seconds. Default value: 30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("GroupInterval")]
                [Validation(Required=false)]
                public long? GroupInterval { get; set; }

                /// <summary>
                /// <para>The waiting time for grouping. Unit: seconds. Default value: 5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("GroupWait")]
                [Validation(Required=false)]
                public long? GroupWait { get; set; }

                /// <summary>
                /// <para>An array of alert event group objects.</para>
                /// <list type="bullet">
                /// <item><description>If you do not specify the groupingFields field, all alerts will be sent to contacts based on <c>alertname</c>.</description></item>
                /// <item><description>If you specify the groupingFields field, alerts with the same field will be sent to contacts in one notification.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("GroupingFields")]
                [Validation(Required=false)]
                public List<string> GroupingFields { get; set; }

            }

            /// <summary>
            /// <para>The ID of the notification policy.</para>
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
            /// <para>The matching rules.</para>
            /// </summary>
            [NameInMap("MatchingRules")]
            [Validation(Required=false)]
            public List<CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyMatchingRules> MatchingRules { get; set; }
            public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyMatchingRules : TeaModel {
                /// <summary>
                /// <para>The matching conditions.</para>
                /// </summary>
                [NameInMap("MatchingConditions")]
                [Validation(Required=false)]
                public List<CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyMatchingRulesMatchingConditions> MatchingConditions { get; set; }
                public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyMatchingRulesMatchingConditions : TeaModel {
                    /// <summary>
                    /// <para>The key of the matching condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>altertname</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The logical operator of the matching condition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>eq</c>: equal to</description></item>
                    /// <item><description><c>neq</c>: not equal to</description></item>
                    /// <item><description><c>in</c>: contains</description></item>
                    /// <item><description><c>nin</c>: does not contain</description></item>
                    /// <item><description><c>re</c>: regular expression match</description></item>
                    /// <item><description><c>nre</c>: regular expression mismatch</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eq</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The value of the matching condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the notification policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>notificationpolicy_test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>An array of notification rule objects.</para>
            /// </summary>
            [NameInMap("NotifyRule")]
            [Validation(Required=false)]
            public CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyRule NotifyRule { get; set; }
            public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyRule : TeaModel {
                /// <summary>
                /// <para>The notification method.</para>
                /// </summary>
                [NameInMap("NotifyChannels")]
                [Validation(Required=false)]
                public List<string> NotifyChannels { get; set; }

                /// <summary>
                /// <para>The end time of the notification window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23:59</para>
                /// </summary>
                [NameInMap("NotifyEndTime")]
                [Validation(Required=false)]
                public string NotifyEndTime { get; set; }

                /// <summary>
                /// <para>An array of notification objects.</para>
                /// </summary>
                [NameInMap("NotifyObjects")]
                [Validation(Required=false)]
                public List<CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyRuleNotifyObjects> NotifyObjects { get; set; }
                public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyRuleNotifyObjects : TeaModel {
                    /// <summary>
                    /// <para>The notification methods specified for a contact.</para>
                    /// </summary>
                    [NameInMap("NotifyChannels")]
                    [Validation(Required=false)]
                    public List<string> NotifyChannels { get; set; }

                    /// <summary>
                    /// <para>The ID of the notification object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("NotifyObjectId")]
                    [Validation(Required=false)]
                    public long? NotifyObjectId { get; set; }

                    /// <summary>
                    /// <para>The name of the notification object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("NotifyObjectName")]
                    [Validation(Required=false)]
                    public string NotifyObjectName { get; set; }

                    /// <summary>
                    /// <para>The type of the notification object. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CONTACT: contact</description></item>
                    /// <item><description>CONTACT_GROUP: contact group</description></item>
                    /// <item><description>ARMS_CONTACT: ARMS contact</description></item>
                    /// <item><description>ARMS_CONTACT_GROUP: ARMS contact group</description></item>
                    /// <item><description>DING_ROBOT_GROUP: DingTalk, Lark, WeCom, or IM robot</description></item>
                    /// <item><description>CONTACT_SCHEDULE: user on duty defined by a schedule</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONTACT</para>
                    /// </summary>
                    [NameInMap("NotifyObjectType")]
                    [Validation(Required=false)]
                    public string NotifyObjectType { get; set; }

                }

                /// <summary>
                /// <para>The start time of the notification window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00</para>
                /// </summary>
                [NameInMap("NotifyStartTime")]
                [Validation(Required=false)]
                public string NotifyStartTime { get; set; }

            }

            /// <summary>
            /// <para>The notification template.</para>
            /// </summary>
            [NameInMap("NotifyTemplate")]
            [Validation(Required=false)]
            public CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyTemplate NotifyTemplate { get; set; }
            public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyTemplate : TeaModel {
                /// <summary>
                /// <para>The content of the alert notification sent through email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alert name: {{ .commonLabels.alertname }}{{if .commonLabels.clustername }} Cluster name: {{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }} Application name: {{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }} Notification policy: {{ .dispatchRuleName }} Alert time: {{ .startTime }} Alert content: {{ for .alerts }} {{.annotations.message}} {{if .generatorURL }} \<a href="{{.generatorURL}}" >Link\</a> {{end}} {{end}}</para>
                /// </summary>
                [NameInMap("EmailContent")]
                [Validation(Required=false)]
                public string EmailContent { get; set; }

                /// <summary>
                /// <para>The content of the alert resolution notification sent through email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alert name: {{ .commonLabels.alertname }}{{if .commonLabels.clustername }} Cluster name: {{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }} Application name: {{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }} Notification policy: {{ .dispatchRuleName }} Alert resolution time: {{ .endTime }} Alert content: {{ for .alerts }} {{.annotations.message}} {{if .generatorURL }} \<a href="{{.generatorURL}}" >Link\</a> {{end}} {{end}}</para>
                /// </summary>
                [NameInMap("EmailRecoverContent")]
                [Validation(Required=false)]
                public string EmailRecoverContent { get; set; }

                /// <summary>
                /// <para>The title of the alert resolution notification sent through email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{{ .commonLabels.alertname }}</para>
                /// </summary>
                [NameInMap("EmailRecoverTitle")]
                [Validation(Required=false)]
                public string EmailRecoverTitle { get; set; }

                /// <summary>
                /// <para>The title of the alert notification sent through email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{{ .commonLabels.alertname }}</para>
                /// </summary>
                [NameInMap("EmailTitle")]
                [Validation(Required=false)]
                public string EmailTitle { get; set; }

                /// <summary>
                /// <para>The content of the alert notification sent by the IM robot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{{if .commonLabels.clustername }} &gt; Cluster name: {{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }} &gt; Application name: {{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }}{{ for .alerts }}&gt; {{.annotations.message}} {{if .generatorURL }} [Link]\({{.generatorURL}}) {{ end }} {{if eq &quot;true&quot; .labels._aliyun_arms_is_denoise_filtered }} (Suspected noise) {{end}} {{end}}</para>
                /// </summary>
                [NameInMap("RobotContent")]
                [Validation(Required=false)]
                public string RobotContent { get; set; }

                /// <summary>
                /// <para>The content of the alert notification sent through text message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\<SmsContent>Notification on the occurrence of a {{ .level }} alert. Alert name: {{ .commonLabels.alertname }}{{if .commonLabels.clustername }} Cluster name: {{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }} Application name: {{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }} Notification policy: {{ .dispatchRuleName }} Alert time: {{ .startTime }} Alert content: {{ for .alerts }} {{.annotations.message}} {{ end }}\</SmsContent></para>
                /// </summary>
                [NameInMap("SmsContent")]
                [Validation(Required=false)]
                public string SmsContent { get; set; }

                /// <summary>
                /// <para>The content of the alert resolution notification sent through text message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\<SmsRecoverContent>Alert resolution notification. Alert name: {{ .commonLabels.alertname }}{{if .commonLabels.clustername }} Cluster name: {{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }} Application name: {{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }} Notification policy: {{ .dispatchRuleName }} Alert resolution time: {{ .endTime }} Alert content: {{ for .alerts }} {{.annotations.message}} {{ end }}\</SmsRecoverContent></para>
                /// </summary>
                [NameInMap("SmsRecoverContent")]
                [Validation(Required=false)]
                public string SmsRecoverContent { get; set; }

                /// <summary>
                /// <para>The content of the alert notification by phone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\<TtsContent>Alert name: {{ .commonLabels.alertname }}{{if .commonLabels.clustername }} Cluster name: {{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }} Application name: {{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }} Notification policy: {{ .dispatchRuleName }} Alert time: {{ .startTime }} Alert content: {{ for .alerts }} {{.annotations.message}} {{ end }}\</TtsContent></para>
                /// </summary>
                [NameInMap("TtsContent")]
                [Validation(Required=false)]
                public string TtsContent { get; set; }

                /// <summary>
                /// <para>The content of the alert resolution notification by phone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\<TtsRecoverContent>Alert name: {{ .commonLabels.alertname }}{{if .commonLabels.clustername }} Cluster name: {{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }} Application name: {{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }} Notification policy: {{ .dispatchRuleName }} Alert resolution time: {{ .endTime }} Alert content: {{ for .alerts }} {{.annotations.message}} {{ end }}\</TtsRecoverContent></para>
                /// </summary>
                [NameInMap("TtsRecoverContent")]
                [Validation(Required=false)]
                public string TtsRecoverContent { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether a notification is resent for a long-lasting unresolved alert. Default value: true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The system resends a notification for a long-lasting unresolved alert at a specified time interval.</description></item>
            /// <item><description><c>false</c>: The system sends a notification for a long-lasting unresolved alert based on an escalation policy.</description></item>
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
            /// <para>Indicates whether the status of an alert automatically changes to Resolved when all events related to the alert change to the Restored state. ARMS notifies contacts when the alert status changes to Resolved.</para>
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
            /// <para>Indicates whether the notification policy is enabled. Valid values: enable and disable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5EC8221-08F2-4C95-9AF1-49FD998C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
