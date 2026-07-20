// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryResourceControlEventsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryResourceControlEventsResponseBodyData Data { get; set; }
        public class QueryResourceControlEventsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryResourceControlEventsResponseBodyDataList> List { get; set; }
            public class QueryResourceControlEventsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DEPLOY_STAGE_REBOOT_TASK</para>
                /// </summary>
                [NameInMap("ActionCode")]
                [Validation(Required=false)]
                public string ActionCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>挖矿告警</para>
                /// </summary>
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

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
                /// <para>1</para>
                /// </summary>
                [NameInMap("ApplyRecordCount")]
                [Validation(Required=false)]
                public int? ApplyRecordCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AUDIT</para>
                /// </summary>
                [NameInMap("ApplyStatus")]
                [Validation(Required=false)]
                public string ApplyStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ApplyTrial")]
                [Validation(Required=false)]
                public bool? ApplyTrial { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e\&quot;c\&quot;s</para>
                /// </summary>
                [NameInMap("BusinessName")]
                [Validation(Required=false)]
                public string BusinessName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TEST_IMS_ACCOUNT_PUNISH_WHITE_TEST</para>
                /// </summary>
                [NameInMap("CaseCode")]
                [Validation(Required=false)]
                public string CaseCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ubs-mm-nwwss-ddos.purchern.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e791c08281b41e8240f897a424c188ae</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>挖矿管控事件</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;createAt\&quot;:\&quot;2025-08-03 11:18:59\&quot;,\&quot;updatedAt\&quot;:\&quot;2025-08-03 11:18:59\&quot;}</para>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public string Extras { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FormType")]
                [Validation(Required=false)]
                public string FormType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-03-16 15:15:00</para>
                /// </summary>
                [NameInMap("GmtLatest")]
                [Validation(Required=false)]
                public string GmtLatest { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rm-3nsvwmt67pn72py1z</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0.158.58</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

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
                [NameInMap("PreCloseTime")]
                [Validation(Required=false)]
                public string PreCloseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MRM</para>
                /// </summary>
                [NameInMap("PunishFrom")]
                [Validation(Required=false)]
                public string PunishFrom { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-03-16 15:15:00</para>
                /// </summary>
                [NameInMap("PunishTime")]
                [Validation(Required=false)]
                public string PunishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>挖矿告警</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Suggestion</para>
                /// </summary>
                [NameInMap("Reinforcement")]
                [Validation(Required=false)]
                public string Reinforcement { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportBatchApply")]
                [Validation(Required=false)]
                public bool? SupportBatchApply { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportSingleApply")]
                [Validation(Required=false)]
                public bool? SupportSingleApply { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>miner</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://pm.alicdn.com/quali/bc98e42b619ad4127bf6437b87045597.jpg?auth_key=1758682451-0-0-897be72852503566bd6775cd9914f5aa">https://pm.alicdn.com/quali/bc98e42b619ad4127bf6437b87045597.jpg?auth_key=1758682451-0-0-897be72852503566bd6775cd9914f5aa</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public QueryResourceControlEventsResponseBodyDataPageInfo PageInfo { get; set; }
            public class QueryResourceControlEventsResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Current")]
                [Validation(Required=false)]
                public int? Current { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>739705BB-B0EF-554B-B3A8-383F4F93E067</para>
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
