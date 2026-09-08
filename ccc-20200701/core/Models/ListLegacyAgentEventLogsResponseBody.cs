// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListLegacyAgentEventLogsResponseBody : TeaModel {
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
        public ListLegacyAgentEventLogsResponseBodyData Data { get; set; }
        public class ListLegacyAgentEventLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of agent event logs.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListLegacyAgentEventLogsResponseBodyDataList> List { get; set; }
            public class ListLegacyAgentEventLogsResponseBodyDataList : TeaModel {
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
                /// <para>378654****</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>Call pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>呼入</para>
                /// </summary>
                [NameInMap("CallMode")]
                [Validation(Required=false)]
                public string CallMode { get; set; }

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
                /// <para>Callee number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1312343****</para>
                /// </summary>
                [NameInMap("CalleeId")]
                [Validation(Required=false)]
                public string CalleeId { get; set; }

                /// <summary>
                /// <para>Calling number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>08331111****</para>
                /// </summary>
                [NameInMap("CallerId")]
                [Validation(Required=false)]
                public string CallerId { get; set; }

                /// <summary>
                /// <para>Call channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>345467****</para>
                /// </summary>
                [NameInMap("ConnId")]
                [Validation(Required=false)]
                public string ConnId { get; set; }

                /// <summary>
                /// <para>Type of management event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>拨号</para>
                /// </summary>
                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                /// <summary>
                /// <para>List of skill group IDs that the agent signed in to. Separate multiple skill group IDs with commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup1@ccc-test,skillgroup2@ccc-test</para>
                /// </summary>
                [NameInMap("GroupNo")]
                [Validation(Required=false)]
                public string GroupNo { get; set; }

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
                /// <para>Statistics timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-03T10:15:30</para>
                /// </summary>
                [NameInMap("StatisticDate")]
                [Validation(Required=false)]
                public string StatisticDate { get; set; }

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
                /// <para>acc101</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>Transfer number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>07518888****</para>
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
        /// <para>2802EE59-3B53-513A-A130-85E480AF689D</para>
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
