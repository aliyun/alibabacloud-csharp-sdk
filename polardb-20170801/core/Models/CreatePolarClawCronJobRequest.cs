// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarClawCronJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the agent that executes the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically delete the job after its first execution. This is useful for one-time tasks. Default: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteAfterRun")]
        [Validation(Required=false)]
        public bool? DeleteAfterRun { get; set; }

        /// <summary>
        /// <para>The configuration for delivering task execution results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Mode&quot;:&quot;announce&quot;,&quot;Channel&quot;:&quot;telegram&quot;}</para>
        /// </summary>
        [NameInMap("Delivery")]
        [Validation(Required=false)]
        public CreatePolarClawCronJobRequestDelivery Delivery { get; set; }
        public class CreatePolarClawCronJobRequestDelivery : TeaModel {
            /// <summary>
            /// <para>The account ID for the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>Specifies whether to use best-effort delivery. If <c>true</c>, delivery failures are ignored.</para>
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
            /// <para>feishu</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The delivery mode. Valid values are <c>none</c>, <c>announce</c>, and <c>webhook</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>announce</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The recipient for the delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_***</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>A description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily report generation</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the cron job is enabled. Default: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The failure alert configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;After&quot;:3,&quot;Channel&quot;:&quot;telegram&quot;}</para>
        /// </summary>
        [NameInMap("FailureAlert")]
        [Validation(Required=false)]
        public CreatePolarClawCronJobRequestFailureAlert FailureAlert { get; set; }
        public class CreatePolarClawCronJobRequestFailureAlert : TeaModel {
            /// <summary>
            /// <para>The account ID for the alert channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The number of consecutive failures required to trigger an alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("After")]
            [Validation(Required=false)]
            public int? After { get; set; }

            /// <summary>
            /// <para>The channel for sending failure alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feishu</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The cooldown period, in milliseconds, between alerts for the same job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("CooldownMs")]
            [Validation(Required=false)]
            public int? CooldownMs { get; set; }

            /// <summary>
            /// <para>The mode for sending alerts. Valid values are <c>announce</c> and <c>webhook</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>announce</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The recipient for the failure alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_***</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>The unique name of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>daily-report</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The execution payload configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Kind&quot;:&quot;agentTurn&quot;,&quot;Message&quot;:&quot;Generate the daily report.&quot;}</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public CreatePolarClawCronJobRequestPayload Payload { get; set; }
        public class CreatePolarClawCronJobRequestPayload : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use best-effort delivery. If <c>true</c>, delivery failures are ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BestEffortDeliver")]
            [Validation(Required=false)]
            public bool? BestEffortDeliver { get; set; }

            /// <summary>
            /// <para>The ID of the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feishu</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>Specifies whether to deliver the agent\&quot;s output to a channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Deliver")]
            [Validation(Required=false)]
            public bool? Deliver { get; set; }

            /// <summary>
            /// <para>A list of fallback models to use if the primary model fails.</para>
            /// </summary>
            [NameInMap("Fallbacks")]
            [Validation(Required=false)]
            public List<string> Fallbacks { get; set; }

            /// <summary>
            /// <para>The payload type. Valid values are <c>agentTurn</c> and <c>systemEvent</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>systemEvent</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>Specifies whether to use a light context for the agent conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LightContext")]
            [Validation(Required=false)]
            public bool? LightContext { get; set; }

            /// <summary>
            /// <para>The prompt for an agent conversation, used when <c>Kind</c> is <c>agentTurn</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generate the daily report.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Specifies a model that overrides the agent\&quot;s default model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian/qwen3.5-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The text for the system event, used when <c>Kind</c> is <c>systemEvent</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generate the daily report.</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The thinking level for the agent\&quot;s response generation. Valid values are <c>off</c>, <c>minimal</c>, <c>low</c>, <c>medium</c>, <c>high</c>, and <c>xhigh</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xhigh</para>
            /// </summary>
            [NameInMap("Thinking")]
            [Validation(Required=false)]
            public string Thinking { get; set; }

            /// <summary>
            /// <para>The execution timeout, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TimeoutSeconds")]
            [Validation(Required=false)]
            public int? TimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The specific target or recipient within the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_***</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to restart the gateway upon job creation. Default: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// <para>Specifies whether to run the job once immediately upon creation. Default: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RunImmediately")]
        [Validation(Required=false)]
        public bool? RunImmediately { get; set; }

        /// <summary>
        /// <para>The schedule configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Kind&quot;:&quot;cron&quot;,&quot;Expr&quot;:&quot;0 9 * * *&quot;,&quot;Tz&quot;:&quot;Asia/Shanghai&quot;}</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public CreatePolarClawCronJobRequestSchedule Schedule { get; set; }
        public class CreatePolarClawCronJobRequestSchedule : TeaModel {
            /// <summary>
            /// <para>The anchor timestamp for aligning interval-based schedules, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1777370572518</para>
            /// </summary>
            [NameInMap("AnchorMs")]
            [Validation(Required=false)]
            public long? AnchorMs { get; set; }

            /// <summary>
            /// <para>The specific time for a one-time execution, specified as an ISO 8601 timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T09:00:00+08:00</para>
            /// </summary>
            [NameInMap("At")]
            [Validation(Required=false)]
            public string At { get; set; }

            /// <summary>
            /// <para>The task execution interval, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("EveryMs")]
            [Validation(Required=false)]
            public long? EveryMs { get; set; }

            /// <summary>
            /// <para>The cron expression that specifies when the task runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 9 * * *</para>
            /// </summary>
            [NameInMap("Expr")]
            [Validation(Required=false)]
            public string Expr { get; set; }

            /// <summary>
            /// <para>The type of schedule.</para>
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
            /// <para>The time zone for the schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("Tz")]
            [Validation(Required=false)]
            public string Tz { get; set; }

        }

        /// <summary>
        /// <para>The session routing key, which determines the conversation session for the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent:main:feishu:direct:***</para>
        /// </summary>
        [NameInMap("SessionKey")]
        [Validation(Required=false)]
        public string SessionKey { get; set; }

        /// <summary>
        /// <para>The session target. Valid values are <c>main</c>, <c>isolated</c>, and <c>current</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("SessionTarget")]
        [Validation(Required=false)]
        public string SessionTarget { get; set; }

        /// <summary>
        /// <para>The wake mode for the agent. Valid values are <c>now</c> and <c>next-heartbeat</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>now</para>
        /// </summary>
        [NameInMap("WakeMode")]
        [Validation(Required=false)]
        public string WakeMode { get; set; }

    }

}
