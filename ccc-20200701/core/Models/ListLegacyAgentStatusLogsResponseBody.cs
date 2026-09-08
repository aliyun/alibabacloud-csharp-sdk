// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListLegacyAgentStatusLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLegacyAgentStatusLogsResponseBodyData Data { get; set; }
        public class ListLegacyAgentStatusLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of agent status data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListLegacyAgentStatusLogsResponseBodyDataList> List { get; set; }
            public class ListLegacyAgentStatusLogsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the agent hung up the call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AgentDropCall")]
                [Validation(Required=false)]
                public string AgentDropCall { get; set; }

                /// <summary>
                /// <para>Agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AgentNo")]
                [Validation(Required=false)]
                public string AgentNo { get; set; }

                /// <summary>
                /// <para>Hang-up reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("AliHangupCause")]
                [Validation(Required=false)]
                public string AliHangupCause { get; set; }

                /// <summary>
                /// <para>Call direction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>内部</para>
                /// </summary>
                [NameInMap("CallDir")]
                [Validation(Required=false)]
                public string CallDir { get; set; }

                /// <summary>
                /// <para>Call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>454326****</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>Call type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>呼入</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>The callee number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1312121****</para>
                /// </summary>
                [NameInMap("CalleeId")]
                [Validation(Required=false)]
                public string CalleeId { get; set; }

                /// <summary>
                /// <para>Calling number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>08337676****</para>
                /// </summary>
                [NameInMap("CallerId")]
                [Validation(Required=false)]
                public string CallerId { get; set; }

                /// <summary>
                /// <para>Call channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>487326****</para>
                /// </summary>
                [NameInMap("ConnId")]
                [Validation(Required=false)]
                public string ConnId { get; set; }

                /// <summary>
                /// <para>Custom extension field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("Extend1")]
                [Validation(Required=false)]
                public string Extend1 { get; set; }

                /// <summary>
                /// <para>Custom extension field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("Extend2")]
                [Validation(Required=false)]
                public string Extend2 { get; set; }

                /// <summary>
                /// <para>Custom extension field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("Extend3")]
                [Validation(Required=false)]
                public string Extend3 { get; set; }

                /// <summary>
                /// <para>Custom extension field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("Extend4")]
                [Validation(Required=false)]
                public string Extend4 { get; set; }

                /// <summary>
                /// <para>Skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("GroupNo")]
                [Validation(Required=false)]
                public string GroupNo { get; set; }

                /// <summary>
                /// <para>The listener phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8032****</para>
                /// </summary>
                [NameInMap("MonitedAgentNo")]
                [Validation(Required=false)]
                public string MonitedAgentNo { get; set; }

                /// <summary>
                /// <para>The monitored agent phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8012****</para>
                /// </summary>
                [NameInMap("MonitedAgentPhoneNo")]
                [Validation(Required=false)]
                public string MonitedAgentPhoneNo { get; set; }

                /// <summary>
                /// <para>Indicates whether the agent is in outbound-only mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                /// <summary>
                /// <para>Agent extension number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8012****</para>
                /// </summary>
                [NameInMap("PhoneNo")]
                [Validation(Required=false)]
                public string PhoneNo { get; set; }

                /// <summary>
                /// <para>The time when the statistics were collected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-03T10:15:30</para>
                /// </summary>
                [NameInMap("StatisticDate")]
                [Validation(Required=false)]
                public string StatisticDate { get; set; }

                /// <summary>
                /// <para>Duration of the status, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("StatisticTime")]
                [Validation(Required=false)]
                public int? StatisticTime { get; set; }

                /// <summary>
                /// <para>Agent status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>振铃</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("TargetRequest")]
                [Validation(Required=false)]
                public string TargetRequest { get; set; }

                /// <summary>
                /// <para>Skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("TargetSelect")]
                [Validation(Required=false)]
                public string TargetSelect { get; set; }

                /// <summary>
                /// <para>Tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acc6736</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>Transfer number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>07551231****</para>
                /// </summary>
                [NameInMap("TransferNo")]
                [Validation(Required=false)]
                public string TransferNo { get; set; }

                /// <summary>
                /// <para>Transfer number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>05711231****</para>
                /// </summary>
                [NameInMap("TransferNumber")]
                [Validation(Required=false)]
                public string TransferNumber { get; set; }

            }

            /// <summary>
            /// <para>Page number, ranging from 1 to 1000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size, ranging from 1 to 1000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C9A5D93-33A6-57F3-A423-4C83BD0A8455</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
