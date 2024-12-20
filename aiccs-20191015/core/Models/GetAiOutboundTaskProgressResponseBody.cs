// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskProgressResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskProgressResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskProgressResponseBodyData : TeaModel {
            [NameInMap("CalloutProgress")]
            [Validation(Required=false)]
            public GetAiOutboundTaskProgressResponseBodyDataCalloutProgress CalloutProgress { get; set; }
            public class GetAiOutboundTaskProgressResponseBodyDataCalloutProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallLossCount")]
                [Validation(Required=false)]
                public int? CallLossCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.01</para>
                /// </summary>
                [NameInMap("CallLossRate")]
                [Validation(Required=false)]
                public float? CallLossRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CallOutConnectCount")]
                [Validation(Required=false)]
                public int? CallOutConnectCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("CallOutConnectRate")]
                [Validation(Required=false)]
                public float? CallOutConnectRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CallOutCount")]
                [Validation(Required=false)]
                public int? CallOutCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CallOutServicerPickupCount")]
                [Validation(Required=false)]
                public int? CallOutServicerPickupCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("CallOutServicerPickupRate")]
                [Validation(Required=false)]
                public float? CallOutServicerPickupRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CallOutUserPickupCount")]
                [Validation(Required=false)]
                public int? CallOutUserPickupCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("CallOutUserPickupRate")]
                [Validation(Required=false)]
                public float? CallOutUserPickupRate { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public GetAiOutboundTaskProgressResponseBodyDataTaskProgress TaskProgress { get; set; }
            public class GetAiOutboundTaskProgressResponseBodyDataTaskProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CallingCount")]
                [Validation(Required=false)]
                public int? CallingCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ConnectCount")]
                [Validation(Required=false)]
                public int? ConnectCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("ConnectRate")]
                [Validation(Required=false)]
                public float? ConnectRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FinishCount")]
                [Validation(Required=false)]
                public int? FinishCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.20</para>
                /// </summary>
                [NameInMap("FinishRate")]
                [Validation(Required=false)]
                public float? FinishRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ServicerPickupCount")]
                [Validation(Required=false)]
                public int? ServicerPickupCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("ServicerPickupRate")]
                [Validation(Required=false)]
                public float? ServicerPickupRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TerminateCount")]
                [Validation(Required=false)]
                public int? TerminateCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UserPickupCount")]
                [Validation(Required=false)]
                public int? UserPickupCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("UserPickupRate")]
                [Validation(Required=false)]
                public float? UserPickupRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("WaitingCallCount")]
                [Validation(Required=false)]
                public int? WaitingCallCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("WaitingRecallCount")]
                [Validation(Required=false)]
                public int? WaitingRecallCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
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
