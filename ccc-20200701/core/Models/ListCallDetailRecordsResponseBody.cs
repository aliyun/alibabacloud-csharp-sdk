// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallDetailRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCallDetailRecordsResponseBodyData Data { get; set; }
        public class ListCallDetailRecordsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCallDetailRecordsResponseBodyDataList> List { get; set; }
            public class ListCallDetailRecordsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0533128****</para>
                /// </summary>
                [NameInMap("AdditionalBroker")]
                [Validation(Required=false)]
                public string AdditionalBroker { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AgentIds")]
                [Validation(Required=false)]
                public string AgentIds { get; set; }

                [NameInMap("AgentNames")]
                [Validation(Required=false)]
                public string AgentNames { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0533127****</para>
                /// </summary>
                [NameInMap("Broker")]
                [Validation(Required=false)]
                public string Broker { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("CallDuration")]
                [Validation(Required=false)]
                public string CallDuration { get; set; }

                [NameInMap("CallIds")]
                [Validation(Required=false)]
                public string CallIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1332315****</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                [NameInMap("CalleeLocation")]
                [Validation(Required=false)]
                public string CalleeLocation { get; set; }

                [NameInMap("CallerLocation")]
                [Validation(Required=false)]
                public string CallerLocation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0533128****</para>
                /// </summary>
                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ContactDisposition")]
                [Validation(Required=false)]
                public string ContactDisposition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-12515239414412****</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Outbound</para>
                /// </summary>
                [NameInMap("ContactType")]
                [Validation(Required=false)]
                public string ContactType { get; set; }

                [NameInMap("DialingTime")]
                [Validation(Required=false)]
                public long? DialingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NotConnected</para>
                /// </summary>
                [NameInMap("EarlyMediaState")]
                [Validation(Required=false)]
                public string EarlyMediaState { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1532448000000</para>
                /// </summary>
                [NameInMap("EstablishedTime")]
                [Validation(Required=false)]
                public long? EstablishedTime { get; set; }

                [NameInMap("HeldTime")]
                [Validation(Required=false)]
                public long? HeldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("IvrTime")]
                [Validation(Required=false)]
                public long? IvrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public long? QueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RecordingDuration")]
                [Validation(Required=false)]
                public long? RecordingDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RecordingReady")]
                [Validation(Required=false)]
                public bool? RecordingReady { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("ReleaseInitiator")]
                [Validation(Required=false)]
                public string ReleaseInitiator { get; set; }

                [NameInMap("ReleaseReason")]
                [Validation(Required=false)]
                public string ReleaseReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1532707199000</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public long? ReleaseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("RingTime")]
                [Validation(Required=false)]
                public long? RingTime { get; set; }

                [NameInMap("SatisfactionDescription")]
                [Validation(Required=false)]
                public string SatisfactionDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public int? SatisfactionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IVR</para>
                /// </summary>
                [NameInMap("SatisfactionSurveyChannel")]
                [Validation(Required=false)]
                public string SatisfactionSurveyChannel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SatisfactionSurveyOffered")]
                [Validation(Required=false)]
                public bool? SatisfactionSurveyOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupIds")]
                [Validation(Required=false)]
                public string SkillGroupIds { get; set; }

                [NameInMap("SkillGroupNames")]
                [Validation(Required=false)]
                public string SkillGroupNames { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1532448000000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("TalkTime")]
                [Validation(Required=false)]
                public long? TalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public long? WaitTime { get; set; }

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
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
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
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
