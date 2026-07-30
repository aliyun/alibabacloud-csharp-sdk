// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UserQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The employee information query result. Returns null if the request fails.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public UserQueryResponseBodyModule Module { get; set; }
        public class UserQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Indicates whether more data exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("has_more")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The employee information. Returns an empty array [] if total is 0.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<UserQueryResponseBodyModuleItems> Items { get; set; }
            public class UserQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>The employee nickname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("employee_nick")]
                [Validation(Required=false)]
                public string EmployeeNick { get; set; }

                /// <summary>
                /// <para>The employment status of the employee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("leave_status")]
                [Validation(Required=false)]
                public int? LeaveStatus { get; set; }

                /// <summary>
                /// <para>The employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_1234</para>
                /// </summary>
                [NameInMap("third_part_employee_id")]
                [Validation(Required=false)]
                public string ThirdPartEmployeeId { get; set; }

                /// <summary>
                /// <para>The employee job number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job_1234</para>
                /// </summary>
                [NameInMap("third_part_job_no")]
                [Validation(Required=false)]
                public string ThirdPartJobNo { get; set; }

            }

            /// <summary>
            /// <para>The pagination token.</para>
            /// <list type="bullet">
            /// <item><description>Returned when <c>has_more = true</c>. Not returned otherwise.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9YN+jx********SeKjEw==</para>
            /// </summary>
            [NameInMap("page_token")]
            [Validation(Required=false)]
            public string PageToken { get; set; }

            /// <summary>
            /// <para>The total number of data items returned by this call. A value of 0 indicates that no employee information matches the query conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-<b><b>-</b></b>-****-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace identifier of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2f624a********4669e3279</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
