// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetResourceControlEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResourceControlEventResponseBodyData Data { get; set; }
        public class GetResourceControlEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of application records.</para>
            /// </summary>
            [NameInMap("ApplyRecordList")]
            [Validation(Required=false)]
            public List<GetResourceControlEventResponseBodyDataApplyRecordList> ApplyRecordList { get; set; }
            public class GetResourceControlEventResponseBodyDataApplyRecordList : TeaModel {
                /// <summary>
                /// <para>The reason for approval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>meet the requirements</para>
                /// </summary>
                [NameInMap("ApprovalReason")]
                [Validation(Required=false)]
                public string ApprovalReason { get; set; }

                /// <summary>
                /// <para>The time records related to the application.</para>
                /// </summary>
                [NameInMap("EventTimeRecord")]
                [Validation(Required=false)]
                public GetResourceControlEventResponseBodyDataApplyRecordListEventTimeRecord EventTimeRecord { get; set; }
                public class GetResourceControlEventResponseBodyDataApplyRecordListEventTimeRecord : TeaModel {
                    /// <summary>
                    /// <para>The time when the alert ended.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AlertEndTime")]
                    [Validation(Required=false)]
                    public string AlertEndTime { get; set; }

                    /// <summary>
                    /// <para>The time when the first alert was triggered.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AlertStartTime")]
                    [Validation(Required=false)]
                    public string AlertStartTime { get; set; }

                    /// <summary>
                    /// <para>The time when the control action was lifted.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AntiPunishTime")]
                    [Validation(Required=false)]
                    public string AntiPunishTime { get; set; }

                    /// <summary>
                    /// <para>The application time.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-08-21T02:26:50Z</para>
                    /// </summary>
                    [NameInMap("ApplyTime")]
                    [Validation(Required=false)]
                    public string ApplyTime { get; set; }

                    /// <summary>
                    /// <para>The time when the alert was ignored.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("IgnoreAlertTime")]
                    [Validation(Required=false)]
                    public string IgnoreAlertTime { get; set; }

                    /// <summary>
                    /// <para>The time when the instance was shut down.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("InstanceCloseTime")]
                    [Validation(Required=false)]
                    public string InstanceCloseTime { get; set; }

                    /// <summary>
                    /// <para>The time when the instance was scanned.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("InstanceScanTime")]
                    [Validation(Required=false)]
                    public string InstanceScanTime { get; set; }

                    /// <summary>
                    /// <para>The time of the latest detection.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("LastCheckTime")]
                    [Validation(Required=false)]
                    public string LastCheckTime { get; set; }

                    /// <summary>
                    /// <para>The time when the mining alert was processed.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("MiningAlertProcessTime")]
                    [Validation(Required=false)]
                    public string MiningAlertProcessTime { get; set; }

                    /// <summary>
                    /// <para>The estimated shutdown time.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("PreCloseTime")]
                    [Validation(Required=false)]
                    public string PreCloseTime { get; set; }

                    /// <summary>
                    /// <para>The processing time.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-11-05 10:06:21</para>
                    /// </summary>
                    [NameInMap("ProcessTime")]
                    [Validation(Required=false)]
                    public string ProcessTime { get; set; }

                    /// <summary>
                    /// <para>The time when the control action ended.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("PunishEndTime")]
                    [Validation(Required=false)]
                    public string PunishEndTime { get; set; }

                    /// <summary>
                    /// <para>The time when the control action started.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("PunishStartTime")]
                    [Validation(Required=false)]
                    public string PunishStartTime { get; set; }

                    /// <summary>
                    /// <para>The rejection time.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("RejectTime")]
                    [Validation(Required=false)]
                    public string RejectTime { get; set; }

                    /// <summary>
                    /// <para>The removal time.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("RemoveTime")]
                    [Validation(Required=false)]
                    public string RemoveTime { get; set; }

                    /// <summary>
                    /// <para>The time when the risk check succeeded.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("RiskCheckSuccessTime")]
                    [Validation(Required=false)]
                    public string RiskCheckSuccessTime { get; set; }

                }

                /// <summary>
                /// <para>The reason for rejection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>does not meet the requirements</para>
                /// </summary>
                [NameInMap("RejectReason")]
                [Validation(Required=false)]
                public string RejectReason { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test Desc for Draft</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Executing</b>: executing</description></item>
                /// <item><description><b>Removed</b>: removed</description></item>
                /// <item><description><b>Alerting</b>: alerting</description></item>
                /// <item><description><b>Ended</b>: ended</description></item>
                /// <item><description><b>Processed</b>: processed by the user and under platform review</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The recommended action from the assistant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>assistant tip</para>
            /// </summary>
            [NameInMap("AssistantTip")]
            [Validation(Required=false)]
            public string AssistantTip { get; set; }

            /// <summary>
            /// <para>The blocked IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>196.251.81.30</para>
            /// </summary>
            [NameInMap("BlockIp")]
            [Validation(Required=false)]
            public string BlockIp { get; set; }

            /// <summary>
            /// <para>The traffic direction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>in</b>: inbound to the cloud. </description></item>
            /// <item><description><b>out</b>: outbound from the cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>out</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.199.31.155</para>
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30629</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            /// <summary>
            /// <para>The ID of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>57ed8c6ddc9aafb1a3df38e6e84d2d45</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The overview of the event impact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance Stopped</para>
            /// </summary>
            [NameInMap("EventImpact")]
            [Validation(Required=false)]
            public string EventImpact { get; set; }

            /// <summary>
            /// <para>The vulnerability name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mining Management Event</para>
            /// </summary>
            [NameInMap("LeakName")]
            [Validation(Required=false)]
            public string LeakName { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The reason for the penalty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This instance is connecting to a Miner Pool and has likely been compromised by hackers for mining or other illicit activities.</para>
            /// </summary>
            [NameInMap("PunishReason")]
            [Validation(Required=false)]
            public string PunishReason { get; set; }

            /// <summary>
            /// <para>The download URL of the penalty snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyun.com/v2">https://xxx.aliyun.com/v2</a></para>
            /// </summary>
            [NameInMap("SnapshotUrl")]
            [Validation(Required=false)]
            public string SnapshotUrl { get; set; }

            /// <summary>
            /// <para>The attack source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36.134.124.185</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <para>The source port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2168</para>
            /// </summary>
            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public string SrcPort { get; set; }

            /// <summary>
            /// <para>The recommended action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Suggestion</para>
            /// </summary>
            [NameInMap("Tip")]
            [Validation(Required=false)]
            public string Tip { get; set; }

        }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6B57D35D-9DAC-5393-AE39-07697E37C2E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
