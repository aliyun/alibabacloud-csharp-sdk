// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetXConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0000: Success.</description></item>
        /// </list>
        /// <para>Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The configuration of the work number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CallAbility&quot;:&quot;0&quot;,&quot;GNFlag&quot;:&quot;00&quot;,&quot;SmsAbility&quot;:&quot;0&quot;,&quot;SmsSignMode&quot;:&quot;0&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetXConfigResponseBodyData Data { get; set; }
        public class GetXConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Specifies whether the call capability is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CallAbility")]
            [Validation(Required=false)]
            public string CallAbility { get; set; }

            /// <summary>
            /// <para>Specifies whether to pass through the caller ID to display the real caller. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>00: Non-passthrough. The work number is displayed when calls are made to each other.</description></item>
            /// <item><description>10: Passthrough. When Customer A is the caller, the caller ID displayed to Employee B is the number of Customer A. When Employee B is the caller, the caller ID displayed to Customer A is the work number.
            /// Default value: 00.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>00</para>
            /// </summary>
            [NameInMap("GNFlag")]
            [Validation(Required=false)]
            public string GNFlag { get; set; }

            /// <summary>
            /// <para>The control parameters for enterprise profile rules.</para>
            /// </summary>
            [NameInMap("ReachJsons")]
            [Validation(Required=false)]
            public List<GetXConfigResponseBodyDataReachJsons> ReachJsons { get; set; }
            public class GetXConfigResponseBodyDataReachJsons : TeaModel {
                /// <summary>
                /// <para>The call direction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Employee B calls Customer A.</description></item>
                /// <item><description>2: Customer A calls Employee B.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallDir")]
                [Validation(Required=false)]
                public string CallDir { get; set; }

                /// <summary>
                /// <para>The call status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Call ringing.</description></item>
                /// <item><description>2: Before connection.</description></item>
                /// <item><description>3: After connection.</description></item>
                /// <item><description>4: Call ended.</description></item>
                /// <item><description>5: Connected.</description></item>
                /// <item><description>6: Not connected.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallStatus")]
                [Validation(Required=false)]
                public string CallStatus { get; set; }

                /// <summary>
                /// <para>The receiving direction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Caller.</description></item>
                /// <item><description>2: Called party.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReceiveDir")]
                [Validation(Required=false)]
                public string ReceiveDir { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>345</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enterprise profile - SMS rule</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Enterprise profile - SMS.</description></item>
                /// <item><description>2: Enterprise profile - Flash message.</description></item>
                /// <item><description>3: Enterprise profile - Video.</description></item>
                /// <item><description>4: Enterprise profile - Audio.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("TempId")]
                [Validation(Required=false)]
                public string TempId { get; set; }

            }

            /// <summary>
            /// <para>The control parameters for sequence ringing.</para>
            /// </summary>
            [NameInMap("SequenceCalls")]
            [Validation(Required=false)]
            public List<GetXConfigResponseBodyDataSequenceCalls> SequenceCalls { get; set; }
            public class GetXConfigResponseBodyDataSequenceCalls : TeaModel {
                /// <summary>
                /// <para>The play ID of the prompt tone for sequence ringing. The format is the same as callNoPlayCode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value sample value sample value</para>
                /// </summary>
                [NameInMap("SequenceCallNoPlayCode")]
                [Validation(Required=false)]
                public string SequenceCallNoPlayCode { get; set; }

                /// <summary>
                /// <para>The called number for sequence ringing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value sample value sample value</para>
                /// </summary>
                [NameInMap("SequenceCalledNo")]
                [Validation(Required=false)]
                public string SequenceCalledNo { get; set; }

                /// <summary>
                /// <para>The play ID for the caller and called party after the call is connected. The format is the same as calledPlayCode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value sample value sample value</para>
                /// </summary>
                [NameInMap("SequenceCalledPlayCode")]
                [Validation(Required=false)]
                public string SequenceCalledPlayCode { get; set; }

            }

            /// <summary>
            /// <para>The end time of sequence ringing. Format: HH:mm:ss, such as 18:00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:00:00</para>
            /// </summary>
            [NameInMap("SequenceEndTime")]
            [Validation(Required=false)]
            public string SequenceEndTime { get; set; }

            /// <summary>
            /// <para>The start time of sequence ringing. Format: HH:mm:ss, such as 09:00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:00:00</para>
            /// </summary>
            [NameInMap("SequenceStartTime")]
            [Validation(Required=false)]
            public string SequenceStartTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the SMS feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SmsAbility")]
            [Validation(Required=false)]
            public string SmsAbility { get; set; }

            /// <summary>
            /// <para>Specifies whether to pass through the caller ID to display the real caller. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>00: Non-passthrough. The work number is displayed when calls are made to each other.</description></item>
            /// <item><description>10: Passthrough. When Customer A is the caller, the caller ID displayed to Employee B is the number of Customer A. When Employee B is the caller, the caller ID displayed to Customer A is the work number.
            /// Default value: 00.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SmsSignMode")]
            [Validation(Required=false)]
            public string SmsSignMode { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Success.</para>
        /// </description></item>
        /// <item><description><para>false: Failure.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
