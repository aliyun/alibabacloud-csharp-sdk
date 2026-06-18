// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetAutomaticFrequencyControlConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The action to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>observe</b>: Monitors requests.</para>
        /// </description></item>
        /// <item><description><para><b>deny</b>: Denies requests.</para>
        /// </description></item>
        /// <item><description><para><b>js</b>: Issues a JavaScript challenge.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>js</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic frequency control is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The statistics collection interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The protection level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>loose</b>: Loose.</para>
        /// </description></item>
        /// <item><description><para><b>normal</b>: Normal.</para>
        /// </description></item>
        /// <item><description><para><b>strict</b>: Strict.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The duration of the penalty, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20000000</para>
        /// </summary>
        [NameInMap("PunishTime")]
        [Validation(Required=false)]
        public int? PunishTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11957665</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The threshold that triggers the action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

    }

}
