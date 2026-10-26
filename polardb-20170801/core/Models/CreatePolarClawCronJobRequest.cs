// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarClawCronJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the specified execution agent.</para>
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
        /// <para>Specifies whether to automatically delete the task after the first execution. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
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
        public CreatePolarClawCronJobRequestDelivery Delivery { get; set; }
        public class CreatePolarClawCronJobRequestDelivery : TeaModel {
            /// <summary>
            /// <para>The channel account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
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
            /// <para>feishu</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The delivery mode. Valid values: none, announce, webhook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>announce</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The delivery target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_***</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>The task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily report generation</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the task is enabled. Default value: true.</para>
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
            /// <para>The channel account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The number of consecutive failures before an alert is triggered.</para>
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
            /// <para>feishu</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The minimum interval between two alerts in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("CooldownMs")]
            [Validation(Required=false)]
            public int? CooldownMs { get; set; }

            /// <summary>
            /// <para>The alert mode. Valid values: announce, webhook.</para>
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
            /// <para>Specifies whether to ignore delivery failures.</para>
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
            /// <para>Specifies whether to deliver the output to a channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Deliver")]
            [Validation(Required=false)]
            public bool? Deliver { get; set; }

            /// <summary>
            /// <para>The list of fallback models.</para>
            /// </summary>
            [NameInMap("Fallbacks")]
            [Validation(Required=false)]
            public List<string> Fallbacks { get; set; }

            /// <summary>
            /// <para>The payload type. Valid values: agentTurn, systemEvent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>systemEvent</para>
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
            /// <para>The agent conversation prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generate the daily report.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The model override.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian/qwen3.5-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The system event text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generate the daily report.</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The thinking level. Valid values: off, minimal, low, medium, high, xhigh.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xhigh</para>
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
            /// <para>ou_***</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to restart the gateway after creation. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// <para>Specifies whether to run it once immediately after creation. Default value: false.</para>
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
            /// <para>The base timestamp for interval alignment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1777370572518</para>
            /// </summary>
            [NameInMap("AnchorMs")]
            [Validation(Required=false)]
            public long? AnchorMs { get; set; }

            /// <summary>
            /// <para>The ISO 8601 timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T09:00:00+08:00</para>
            /// </summary>
            [NameInMap("At")]
            [Validation(Required=false)]
            public string At { get; set; }

            /// <summary>
            /// <para>The interval in milliseconds.</para>
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
            /// <para>The schedule type. Valid values: cron, every, at.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cron</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The deterministic jitter window in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StaggerMs")]
            [Validation(Required=false)]
            public int? StaggerMs { get; set; }

            /// <summary>
            /// <para>The IANA time zone.</para>
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
        /// <para>The session target. Valid values: main, isolated, current.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("SessionTarget")]
        [Validation(Required=false)]
        public string SessionTarget { get; set; }

        /// <summary>
        /// <para>The wake mode. Valid values: now, next-heartbeat.</para>
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
