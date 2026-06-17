// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdatePolarClawCronJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Agent that runs the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-xxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the task after its first execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteAfterRun")]
        [Validation(Required=false)]
        public bool? DeleteAfterRun { get; set; }

        /// <summary>
        /// <para>The result delivery configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Mode&quot;:&quot;announce&quot;,&quot;Channel&quot;:&quot;telegram&quot;}</para>
        /// </summary>
        [NameInMap("Delivery")]
        [Validation(Required=false)]
        public UpdatePolarClawCronJobRequestDelivery Delivery { get; set; }
        public class UpdatePolarClawCronJobRequestDelivery : TeaModel {
            /// <summary>
            /// <para>The account ID for the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accountId123</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore delivery failures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BestEffort")]
            [Validation(Required=false)]
            public bool? BestEffort { get; set; }

            /// <summary>
            /// <para>The delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>telegram</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The delivery mode. Valid values: <c>none</c>, <c>announce</c>, and <c>webhook</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>announce</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The delivery target. This parameter is required and must be a URL if <c>Delivery.Mode</c> is <c>webhook</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/webhook">https://example.com/webhook</a></para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>The new description for the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily report generation</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the task is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The configuration for failure alerts. Set this to <c>false</c> to disable alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;After&quot;:3,&quot;Channel&quot;:&quot;telegram&quot;}</para>
        /// </summary>
        [NameInMap("FailureAlert")]
        [Validation(Required=false)]
        public UpdatePolarClawCronJobRequestFailureAlert FailureAlert { get; set; }
        public class UpdatePolarClawCronJobRequestFailureAlert : TeaModel {
            /// <summary>
            /// <para>The account ID for the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accountId123</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The number of consecutive failures after which to send an alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("After")]
            [Validation(Required=false)]
            public int? After { get; set; }

            /// <summary>
            /// <para>The alert channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>email</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The minimum interval between two alerts, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("CooldownMs")]
            [Validation(Required=false)]
            public int? CooldownMs { get; set; }

            /// <summary>
            /// <para>The alert mode. Valid values: <c>announce</c> and <c>webhook</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>announce</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The alert target.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user@example.com">user@example.com</a></para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>The ID of the scheduled task to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ee00f56-f467-4d41-858c-ca4ede2c770e</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The new name for the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afternoon-report</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The new payload configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Kind&quot;:&quot;agentTurn&quot;,&quot;Message&quot;:&quot;Updated: Generate afternoon report.&quot;}</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public UpdatePolarClawCronJobRequestPayload Payload { get; set; }
        public class UpdatePolarClawCronJobRequestPayload : TeaModel {
            /// <summary>
            /// <para>Specifies whether to ignore delivery failures.</para>
            /// </summary>
            [NameInMap("BestEffortDeliver")]
            [Validation(Required=false)]
            public bool? BestEffortDeliver { get; set; }

            /// <summary>
            /// <para>The ID of the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>telegram</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>Specifies whether to deliver the output to a channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Deliver")]
            [Validation(Required=false)]
            public bool? Deliver { get; set; }

            /// <summary>
            /// <para>A list of fallback models.</para>
            /// </summary>
            [NameInMap("Fallbacks")]
            [Validation(Required=false)]
            public List<string> Fallbacks { get; set; }

            /// <summary>
            /// <para>The payload type. Valid values are <c>agentTurn</c> (for an Agent conversation) or <c>systemEvent</c> (for a system event).</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentTurn</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>Specifies whether to use a lightweight context.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LightContext")]
            [Validation(Required=false)]
            public bool? LightContext { get; set; }

            /// <summary>
            /// <para>The prompt for the Agent conversation. This parameter is required if <c>Payload.Kind</c> is <c>agentTurn</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generate the daily report and send it to the team.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The model override.</para>
            /// 
            /// <b>Example:</b>
            /// <para>anthropic/sonnet-4.6</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The text for the system event. This parameter is required if <c>Payload.Kind</c> is <c>systemEvent</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Send a reminder to the user.</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The thinking level. Valid values: <c>off</c>, <c>minimal</c>, <c>low</c>, <c>medium</c>, <c>high</c>, and <c>xhigh</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("Thinking")]
            [Validation(Required=false)]
            public string Thinking { get; set; }

            /// <summary>
            /// <para>The execution timeout in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TimeoutSeconds")]
            [Validation(Required=false)]
            public int? TimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The delivery target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to restart the gateway after the update. Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// <para>The scheduling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Kind&quot;:&quot;cron&quot;,&quot;Expr&quot;:&quot;0 12 * * *&quot;,&quot;Tz&quot;:&quot;America/New_York&quot;}</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public UpdatePolarClawCronJobRequestSchedule Schedule { get; set; }
        public class UpdatePolarClawCronJobRequestSchedule : TeaModel {
            /// <summary>
            /// <para>The anchor timestamp for interval alignment, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1777370572518</para>
            /// </summary>
            [NameInMap("AnchorMs")]
            [Validation(Required=false)]
            public long? AnchorMs { get; set; }

            /// <summary>
            /// <para>An ISO 8601 timestamp. This parameter is required if <c>Schedule.Kind</c> is <c>at</c>. For example: <c>2026-04-10T09:00:00+08:00</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T09:00:00+08:00</para>
            /// </summary>
            [NameInMap("At")]
            [Validation(Required=false)]
            public string At { get; set; }

            /// <summary>
            /// <para>The interval in milliseconds. This parameter is required if <c>Schedule.Kind</c> is <c>every</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("EveryMs")]
            [Validation(Required=false)]
            public long? EveryMs { get; set; }

            /// <summary>
            /// <para>The cron expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 9 * * *</para>
            /// </summary>
            [NameInMap("Expr")]
            [Validation(Required=false)]
            public string Expr { get; set; }

            /// <summary>
            /// <para>The schedule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cron</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The deterministic jitter window, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StaggerMs")]
            [Validation(Required=false)]
            public int? StaggerMs { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("Tz")]
            [Validation(Required=false)]
            public string Tz { get; set; }

        }

        /// <summary>
        /// <para>The session routing key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent:main:feishu:direct:***</para>
        /// </summary>
        [NameInMap("SessionKey")]
        [Validation(Required=false)]
        public string SessionKey { get; set; }

        /// <summary>
        /// <para>The new session target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>isolated</para>
        /// </summary>
        [NameInMap("SessionTarget")]
        [Validation(Required=false)]
        public string SessionTarget { get; set; }

        /// <summary>
        /// <para>The new wake mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>now</para>
        /// </summary>
        [NameInMap("WakeMode")]
        [Validation(Required=false)]
        public string WakeMode { get; set; }

    }

}
