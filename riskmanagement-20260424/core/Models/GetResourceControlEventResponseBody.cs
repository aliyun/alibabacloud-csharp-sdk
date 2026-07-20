// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetResourceControlEventResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResourceControlEventResponseBodyData Data { get; set; }
        public class GetResourceControlEventResponseBodyData : TeaModel {
            [NameInMap("ApplyRecordList")]
            [Validation(Required=false)]
            public List<GetResourceControlEventResponseBodyDataApplyRecordList> ApplyRecordList { get; set; }
            public class GetResourceControlEventResponseBodyDataApplyRecordList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>meet the requirements</para>
                /// </summary>
                [NameInMap("ApprovalReason")]
                [Validation(Required=false)]
                public string ApprovalReason { get; set; }

                [NameInMap("EventTimeRecord")]
                [Validation(Required=false)]
                public GetResourceControlEventResponseBodyDataApplyRecordListEventTimeRecord EventTimeRecord { get; set; }
                public class GetResourceControlEventResponseBodyDataApplyRecordListEventTimeRecord : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AlertEndTime")]
                    [Validation(Required=false)]
                    public string AlertEndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AlertStartTime")]
                    [Validation(Required=false)]
                    public string AlertStartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AntiPunishTime")]
                    [Validation(Required=false)]
                    public string AntiPunishTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-08-21T02:26:50Z</para>
                    /// </summary>
                    [NameInMap("ApplyTime")]
                    [Validation(Required=false)]
                    public string ApplyTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("IgnoreAlertTime")]
                    [Validation(Required=false)]
                    public string IgnoreAlertTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("InstanceCloseTime")]
                    [Validation(Required=false)]
                    public string InstanceCloseTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("InstanceScanTime")]
                    [Validation(Required=false)]
                    public string InstanceScanTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("LastCheckTime")]
                    [Validation(Required=false)]
                    public string LastCheckTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("MiningAlertProcessTime")]
                    [Validation(Required=false)]
                    public string MiningAlertProcessTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("PreCloseTime")]
                    [Validation(Required=false)]
                    public string PreCloseTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-11-05 10:06:21</para>
                    /// </summary>
                    [NameInMap("ProcessTime")]
                    [Validation(Required=false)]
                    public string ProcessTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("PunishEndTime")]
                    [Validation(Required=false)]
                    public string PunishEndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("PunishStartTime")]
                    [Validation(Required=false)]
                    public string PunishStartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("RejectTime")]
                    [Validation(Required=false)]
                    public string RejectTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("RemoveTime")]
                    [Validation(Required=false)]
                    public string RemoveTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("RiskCheckSuccessTime")]
                    [Validation(Required=false)]
                    public string RiskCheckSuccessTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>does not meet the requirements</para>
                /// </summary>
                [NameInMap("RejectReason")]
                [Validation(Required=false)]
                public string RejectReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Test Desc for Draft</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>assistant tip</para>
            /// </summary>
            [NameInMap("AssistantTip")]
            [Validation(Required=false)]
            public string AssistantTip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>196.251.81.30</para>
            /// </summary>
            [NameInMap("BlockIp")]
            [Validation(Required=false)]
            public string BlockIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>out</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.199.31.155</para>
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30629</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>57ed8c6ddc9aafb1a3df38e6e84d2d45</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Instance Stopped</para>
            /// </summary>
            [NameInMap("EventImpact")]
            [Validation(Required=false)]
            public string EventImpact { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Mining Management Event</para>
            /// </summary>
            [NameInMap("LeakName")]
            [Validation(Required=false)]
            public string LeakName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This instance is connecting to a Miner Pool and has likely been compromised by hackers for mining or other illicit activities.</para>
            /// </summary>
            [NameInMap("PunishReason")]
            [Validation(Required=false)]
            public string PunishReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyun.com/v2">https://xxx.aliyun.com/v2</a></para>
            /// </summary>
            [NameInMap("SnapshotUrl")]
            [Validation(Required=false)]
            public string SnapshotUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>36.134.124.185</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2168</para>
            /// </summary>
            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public string SrcPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Suggestion</para>
            /// </summary>
            [NameInMap("Tip")]
            [Validation(Required=false)]
            public string Tip { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6B57D35D-9DAC-5393-AE39-07697E37C2E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
