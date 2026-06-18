// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Job progress.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskProgressResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskProgressResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Progress by outbound call dimension.</para>
            /// </summary>
            [NameInMap("CalloutProgress")]
            [Validation(Required=false)]
            public GetAiOutboundTaskProgressResponseBodyDataCalloutProgress CalloutProgress { get; set; }
            public class GetAiOutboundTaskProgressResponseBodyDataCalloutProgress : TeaModel {
                /// <summary>
                /// <para>Call loss count.  </para>
                /// <remarks>
                /// <para>A parameter specific to predictive outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallLossCount")]
                [Validation(Required=false)]
                public int? CallLossCount { get; set; }

                /// <summary>
                /// <para>Call Loss Rate.  </para>
                /// <remarks>
                /// <para>A parameter exclusive to predictive outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.01</para>
                /// </summary>
                [NameInMap("CallLossRate")]
                [Validation(Required=false)]
                public float? CallLossRate { get; set; }

                /// <summary>
                /// <para>Number of successful outbound call connections.  </para>
                /// <remarks>
                /// <para>This parameter is specific to automatic outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CallOutConnectCount")]
                [Validation(Required=false)]
                public int? CallOutConnectCount { get; set; }

                /// <summary>
                /// <para>Outbound Call Connection Rate.  </para>
                /// <remarks>
                /// <para>A parameter exclusive to automated outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("CallOutConnectRate")]
                [Validation(Required=false)]
                public float? CallOutConnectRate { get; set; }

                /// <summary>
                /// <para>Number of outbound calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CallOutCount")]
                [Validation(Required=false)]
                public int? CallOutCount { get; set; }

                /// <summary>
                /// <para>Agent Pickup Count.  </para>
                /// <remarks>
                /// <para>A parameter exclusive to predictive outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CallOutServicerPickupCount")]
                [Validation(Required=false)]
                public int? CallOutServicerPickupCount { get; set; }

                /// <summary>
                /// <para>Agent pickup rate.  </para>
                /// <remarks>
                /// <para>A parameter specific to predictive outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("CallOutServicerPickupRate")]
                [Validation(Required=false)]
                public float? CallOutServicerPickupRate { get; set; }

                /// <summary>
                /// <para>Customer Pickup Count.  </para>
                /// <remarks>
                /// <para>A parameter exclusive to predictive outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CallOutUserPickupCount")]
                [Validation(Required=false)]
                public int? CallOutUserPickupCount { get; set; }

                /// <summary>
                /// <para>Customer Pickup Rate.  </para>
                /// <remarks>
                /// <para>A parameter exclusive to predictive outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("CallOutUserPickupRate")]
                [Validation(Required=false)]
                public float? CallOutUserPickupRate { get; set; }

            }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>Job dimension progress.</para>
            /// </summary>
            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public GetAiOutboundTaskProgressResponseBodyDataTaskProgress TaskProgress { get; set; }
            public class GetAiOutboundTaskProgressResponseBodyDataTaskProgress : TeaModel {
                /// <summary>
                /// <para>Number of jobs in calling status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CallingCount")]
                [Validation(Required=false)]
                public int? CallingCount { get; set; }

                /// <summary>
                /// <para>Number of connected jobs.</para>
                /// <remarks>
                /// <para>Parameter specific to auto dialing.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ConnectCount")]
                [Validation(Required=false)]
                public int? ConnectCount { get; set; }

                /// <summary>
                /// <para>Job connection rate.  </para>
                /// <remarks>
                /// <para>A parameter specific to automatic outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("ConnectRate")]
                [Validation(Required=false)]
                public float? ConnectRate { get; set; }

                /// <summary>
                /// <para>Number of completed jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FinishCount")]
                [Validation(Required=false)]
                public int? FinishCount { get; set; }

                /// <summary>
                /// <para>Job completion rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.20</para>
                /// </summary>
                [NameInMap("FinishRate")]
                [Validation(Required=false)]
                public float? FinishRate { get; set; }

                /// <summary>
                /// <para>Number of agent pickups.</para>
                /// <remarks>
                /// <para>Parameter specific to predictive dialing.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ServicerPickupCount")]
                [Validation(Required=false)]
                public int? ServicerPickupCount { get; set; }

                /// <summary>
                /// <para>Agent pickup rate.</para>
                /// <remarks>
                /// <para>Exclusive parameter for predictive outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("ServicerPickupRate")]
                [Validation(Required=false)]
                public float? ServicerPickupRate { get; set; }

                /// <summary>
                /// <para>Number of stopped jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TerminateCount")]
                [Validation(Required=false)]
                public int? TerminateCount { get; set; }

                /// <summary>
                /// <para>Total number of jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <para>Number of customer pickups.</para>
                /// <remarks>
                /// <para>Parameter specific to predictive dialing.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UserPickupCount")]
                [Validation(Required=false)]
                public int? UserPickupCount { get; set; }

                /// <summary>
                /// <para>Customer pickup rate.</para>
                /// <remarks>
                /// <para>Exclusive parameter for predictive outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("UserPickupRate")]
                [Validation(Required=false)]
                public float? UserPickupRate { get; set; }

                /// <summary>
                /// <para>Number of pending call jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("WaitingCallCount")]
                [Validation(Required=false)]
                public int? WaitingCallCount { get; set; }

                /// <summary>
                /// <para>Number of jobs pending redial.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("WaitingRecallCount")]
                [Validation(Required=false)]
                public int? WaitingRecallCount { get; set; }

            }

            /// <summary>
            /// <para>Task Type. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: Predictive.  </description></item>
            /// <item><description><b>3</b>: Automatic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
