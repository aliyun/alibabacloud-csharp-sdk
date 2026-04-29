// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarClawCronJobShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteAfterRun")]
        [Validation(Required=false)]
        public bool? DeleteAfterRun { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Mode&quot;:&quot;announce&quot;,&quot;Channel&quot;:&quot;telegram&quot;}</para>
        /// </summary>
        [NameInMap("Delivery")]
        [Validation(Required=false)]
        public string DeliveryShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Daily report generation</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;After&quot;:3,&quot;Channel&quot;:&quot;telegram&quot;}</para>
        /// </summary>
        [NameInMap("FailureAlert")]
        [Validation(Required=false)]
        public string FailureAlertShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>daily-report</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Kind&quot;:&quot;agentTurn&quot;,&quot;Message&quot;:&quot;Generate the daily report.&quot;}</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string PayloadShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RunImmediately")]
        [Validation(Required=false)]
        public bool? RunImmediately { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Kind&quot;:&quot;cron&quot;,&quot;Expr&quot;:&quot;0 9 * * *&quot;,&quot;Tz&quot;:&quot;Asia/Shanghai&quot;}</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string ScheduleShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent:main:feishu:direct:***</para>
        /// </summary>
        [NameInMap("SessionKey")]
        [Validation(Required=false)]
        public string SessionKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("SessionTarget")]
        [Validation(Required=false)]
        public string SessionTarget { get; set; }

        /// <summary>
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
