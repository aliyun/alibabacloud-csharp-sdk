// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetXDefaultConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
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
        /// <item><description><para>0000: Success.</para>
        /// </description></item>
        /// <item><description><para>Other values: Failure.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The default configurations of the work number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CallAbility&quot;:&quot;0&quot;,&quot;GNFlag&quot;:&quot;00&quot;,&quot;SmsAbility&quot;:&quot;0&quot;,&quot;SmsSignMode&quot;:&quot;0&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetXDefaultConfigResponseBodyData Data { get; set; }
        public class GetXDefaultConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The status of the call capability. Valid values: 0: disabled. 1: enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CallAbility")]
            [Validation(Required=false)]
            public string CallAbility { get; set; }

            /// <summary>
            /// <para>Specifies whether to pass through the caller ID to display the real caller. Valid values: 00: non-passthrough. The work number is displayed when calls are made to each other. 10: passthrough. When Customer A is the caller, the caller ID displayed to Employee B is the number of Customer A. When Employee B is the caller, the caller ID displayed to Customer A is the work number. Default value: 00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00</para>
            /// </summary>
            [NameInMap("GNFlag")]
            [Validation(Required=false)]
            public string GNFlag { get; set; }

            /// <summary>
            /// <para>The enterprise business card rule control parameters.</para>
            /// </summary>
            [NameInMap("ReachJson")]
            [Validation(Required=false)]
            public List<GetXDefaultConfigResponseBodyDataReachJson> ReachJson { get; set; }
            public class GetXDefaultConfigResponseBodyDataReachJson : TeaModel {
                /// <summary>
                /// <para>The call direction. Valid values: 1: Employee B calls Customer A. 2: Customer A calls Employee B.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallDir")]
                [Validation(Required=false)]
                public string CallDir { get; set; }

                /// <summary>
                /// <para>The call status. Valid values: 1: ringing. 2: before connection. 3: after connection. 4: call ended. 5: connected. 6: not connected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallStatus")]
                [Validation(Required=false)]
                public string CallStatus { get; set; }

                /// <summary>
                /// <para>The receive direction. Valid values: 1: caller. 2: callee.</para>
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
                /// <para>Enterprise business card - SMS rule</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule type. Valid values: 1: enterprise business card - SMS. 2: enterprise business card - flash SMS. 3: enterprise business card - video. 4: enterprise business card - audio.</para>
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
            /// <para>The sequential ringing control parameters.</para>
            /// </summary>
            [NameInMap("SequenceCall")]
            [Validation(Required=false)]
            public List<GetXDefaultConfigResponseBodyDataSequenceCall> SequenceCall { get; set; }
            public class GetXDefaultConfigResponseBodyDataSequenceCall : TeaModel {
                /// <summary>
                /// <para>The play code for the sequential ringing prompt tone. The format is the same as callNoPlayCode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value</para>
                /// </summary>
                [NameInMap("SequenceCallNoPlayCode")]
                [Validation(Required=false)]
                public string SequenceCallNoPlayCode { get; set; }

                /// <summary>
                /// <para>The callee number for sequential ringing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value sample value sample value</para>
                /// </summary>
                [NameInMap("SequenceCalledNo")]
                [Validation(Required=false)]
                public string SequenceCalledNo { get; set; }

                /// <summary>
                /// <para>The play code for the caller and callee after the call is connected. The format is the same as calledPlayCode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value sample value sample value</para>
                /// </summary>
                [NameInMap("SequenceCalledPlayCode")]
                [Validation(Required=false)]
                public string SequenceCalledPlayCode { get; set; }

            }

            /// <summary>
            /// <para>The end time of sequential ringing. Format: HH:mm:ss, such as 18:00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:00:00</para>
            /// </summary>
            [NameInMap("SequenceEndTime")]
            [Validation(Required=false)]
            public string SequenceEndTime { get; set; }

            /// <summary>
            /// <para>The start time of sequential ringing. Format: HH:mm:ss, such as 09:00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:00:00</para>
            /// </summary>
            [NameInMap("SequenceStartTime")]
            [Validation(Required=false)]
            public string SequenceStartTime { get; set; }

            /// <summary>
            /// <para>The status of the SMS feature. Valid values: 0: disabled. 1: enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SmsAbility")]
            [Validation(Required=false)]
            public string SmsAbility { get; set; }

            /// <summary>
            /// <para>Specifies whether to pass through the caller ID to display the real caller. Valid values: 00: non-passthrough. The work number is displayed when calls are made to each other. 10: passthrough. When Customer A is the caller, the caller ID displayed to Employee B is the number of Customer A. When Employee B is the caller, the caller ID displayed to Customer A is the work number. Default value: 00.</para>
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
        /// <item><description><para>true: The request is successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request fails.</para>
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
