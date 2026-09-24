// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code. OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTaskDetailResponseBodyData Data { get; set; }
        public class ListTaskDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The list of task records.</para>
            /// </summary>
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<ListTaskDetailResponseBodyDataRecord> Record { get; set; }
            public class ListTaskDetailResponseBodyDataRecord : TeaModel {
                /// <summary>
                /// <para>The called number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>186****0000</para>
                /// </summary>
                [NameInMap("Called")]
                [Validation(Required=false)]
                public string Called { get; set; }

                /// <summary>
                /// <para>The caller number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>136****0000</para>
                /// </summary>
                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                /// <summary>
                /// <para>The hangup direction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>User</b>.</description></item>
                /// <item><description><b>Robot</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>User</para>
                /// </summary>
                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                /// <summary>
                /// <para>The call duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The end time in the YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-20 00:03:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The detail ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The current retry count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RetryCurTimes")]
                [Validation(Required=false)]
                public int? RetryCurTimes { get; set; }

                /// <summary>
                /// <para>The total number of retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RetryTimes")]
                [Validation(Required=false)]
                public int? RetryTimes { get; set; }

                /// <summary>
                /// <para>The start time in the YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-20 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The detail status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The call status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200100</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>The description of the call status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Call succeeded</para>
                /// </summary>
                [NameInMap("StatusCodeDesc")]
                [Validation(Required=false)]
                public string StatusCodeDesc { get; set; }

                /// <summary>
                /// <para>The intent label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Affirmative</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
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
