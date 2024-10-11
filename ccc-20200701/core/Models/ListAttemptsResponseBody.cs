// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListAttemptsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAttemptsResponseBodyData Data { get; set; }
        public class ListAttemptsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListAttemptsResponseBodyDataList> List { get; set; }
            public class ListAttemptsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1632883592732</para>
                /// </summary>
                [NameInMap("AgentEstablishedTime")]
                [Validation(Required=false)]
                public long? AgentEstablishedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("AgentRingDuration")]
                [Validation(Required=false)]
                public long? AgentRingDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1634196287869</para>
                /// </summary>
                [NameInMap("AssignAgentTime")]
                [Validation(Required=false)]
                public long? AssignAgentTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-1704342174816****</para>
                /// </summary>
                [NameInMap("AttemptId")]
                [Validation(Required=false)]
                public string AttemptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1888888****</para>
                /// </summary>
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>05711234****</para>
                /// </summary>
                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>083046e3-5822-4cda-9b84-04f2a02eb605</para>
                /// </summary>
                [NameInMap("CampaignId")]
                [Validation(Required=false)]
                public string CampaignId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>21d194a7-60b7-4824-932b-48ed03a83704</para>
                /// </summary>
                [NameInMap("CaseId")]
                [Validation(Required=false)]
                public string CaseId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-1704342174816****</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1634196286708</para>
                /// </summary>
                [NameInMap("CustomerEstablishedTime")]
                [Validation(Required=false)]
                public long? CustomerEstablishedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1634196317888</para>
                /// </summary>
                [NameInMap("CustomerReleasedTime")]
                [Validation(Required=false)]
                public long? CustomerReleasedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2734</para>
                /// </summary>
                [NameInMap("DialDuration")]
                [Validation(Required=false)]
                public long? DialDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1634196283974</para>
                /// </summary>
                [NameInMap("DialTime")]
                [Validation(Required=false)]
                public long? DialTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1634196287789</para>
                /// </summary>
                [NameInMap("EnqueueTime")]
                [Validation(Required=false)]
                public long? EnqueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1634196286740</para>
                /// </summary>
                [NameInMap("EnterIvrTime")]
                [Validation(Required=false)]
                public long? EnterIvrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1049</para>
                /// </summary>
                [NameInMap("IvrDuration")]
                [Validation(Required=false)]
                public long? IvrDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("QueueDuration")]
                [Validation(Required=false)]
                public long? QueueDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7CC6523B-0E51-1B62-8DA5-6A9831CAE315</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
