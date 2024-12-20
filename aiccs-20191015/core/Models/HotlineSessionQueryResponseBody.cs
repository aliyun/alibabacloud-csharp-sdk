// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HotlineSessionQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public HotlineSessionQueryResponseBodyData Data { get; set; }
        public class HotlineSessionQueryResponseBodyData : TeaModel {
            [NameInMap("CallDetailRecord")]
            [Validation(Required=false)]
            public List<HotlineSessionQueryResponseBodyDataCallDetailRecord> CallDetailRecord { get; set; }
            public class HotlineSessionQueryResponseBodyDataCallDetailRecord : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7719786</para>
                /// </summary>
                [NameInMap("Acid")]
                [Validation(Required=false)]
                public string Acid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("ActiveTransferId")]
                [Validation(Required=false)]
                public string ActiveTransferId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>37</para>
                /// </summary>
                [NameInMap("CallContinueTime")]
                [Validation(Required=false)]
                public int? CallContinueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("CallResult")]
                [Validation(Required=false)]
                public string CallResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public int? CallType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>135615*****</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0571773</para>
                /// </summary>
                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:55</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EvaluationLevel")]
                [Validation(Required=false)]
                public int? EvaluationLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EvaluationScore")]
                [Validation(Required=false)]
                public int? EvaluationScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HangUpRole")]
                [Validation(Required=false)]
                public string HangUpRole { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-02 22:33:46</para>
                /// </summary>
                [NameInMap("HangUpTime")]
                [Validation(Required=false)]
                public string HangUpTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acc1c58dab4a4dd280e3813c66</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:55</para>
                /// </summary>
                [NameInMap("InQueueTime")]
                [Validation(Required=false)]
                public string InQueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7856876</para>
                /// </summary>
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:59</para>
                /// </summary>
                [NameInMap("OutQueueTime")]
                [Validation(Required=false)]
                public string OutQueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("PassiveTransferId")]
                [Validation(Required=false)]
                public string PassiveTransferId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassiveTransferIdType")]
                [Validation(Required=false)]
                public string PassiveTransferIdType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-02 22:33:09</para>
                /// </summary>
                [NameInMap("PickUpTime")]
                [Validation(Required=false)]
                public string PickUpTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("QueueUpContinueTime")]
                [Validation(Required=false)]
                public int? QueueUpContinueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RingContinueTime")]
                [Validation(Required=false)]
                public int? RingContinueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-02 22:33:09</para>
                /// </summary>
                [NameInMap("RingEndTime")]
                [Validation(Required=false)]
                public string RingEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:59</para>
                /// </summary>
                [NameInMap("RingStartTime")]
                [Validation(Required=false)]
                public string RingStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>555555</para>
                /// </summary>
                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public string ServicerId { get; set; }

                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1861111****</para>
                /// </summary>
                [NameInMap("TrunkCall")]
                [Validation(Required=false)]
                public string TrunkCall { get; set; }

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
            /// <para>26</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE339D98-9BD3-4413-B165</para>
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
