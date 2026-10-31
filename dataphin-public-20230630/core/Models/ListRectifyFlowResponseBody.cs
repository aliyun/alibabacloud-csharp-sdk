// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListRectifyFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListRectifyFlowResponseBodyPageResult PageResult { get; set; }
        public class ListRectifyFlowResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The processes on the current page.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListRectifyFlowResponseBodyPageResultData> Data { get; set; }
            public class ListRectifyFlowResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <para>The completion time. The value is a UNIX timestamp in milliseconds. If the process is not completed, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>648218233037</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The total number of issues in the current process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>264461775547</para>
                /// </summary>
                [NameInMap("ProblemCount")]
                [Validation(Required=false)]
                public long? ProblemCount { get; set; }

                /// <summary>
                /// <para>The process ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>474448887101</para>
                /// </summary>
                [NameInMap("RectifyId")]
                [Validation(Required=false)]
                public long? RectifyId { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RectifyName")]
                [Validation(Required=false)]
                public string RectifyName { get; set; }

                /// <summary>
                /// <para>The priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RectifyPriority")]
                [Validation(Required=false)]
                public string RectifyPriority { get; set; }

                /// <summary>
                /// <para>The rectifier ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3001</para>
                /// </summary>
                [NameInMap("RectifyUser")]
                [Validation(Required=false)]
                public string RectifyUser { get; set; }

                /// <summary>
                /// <para>The rectifier name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RectifyUserName")]
                [Validation(Required=false)]
                public string RectifyUserName { get; set; }

                /// <summary>
                /// <para>The start time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>356278124692</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The process status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The initiator ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3001</para>
                /// </summary>
                [NameInMap("SubmitUser")]
                [Validation(Required=false)]
                public string SubmitUser { get; set; }

                /// <summary>
                /// <para>The initiator name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SubmitUserName")]
                [Validation(Required=false)]
                public string SubmitUserName { get; set; }

                /// <summary>
                /// <para>The verifier ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3001</para>
                /// </summary>
                [NameInMap("VerifyUser")]
                [Validation(Required=false)]
                public string VerifyUser { get; set; }

                /// <summary>
                /// <para>The verifier name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("VerifyUserName")]
                [Validation(Required=false)]
                public string VerifyUserName { get; set; }

            }

            /// <summary>
            /// <para>The total number of processes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>699386170553</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
