// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UserQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public UserQueryResponseBodyModule Module { get; set; }
        public class UserQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("has_more")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<UserQueryResponseBodyModuleItems> Items { get; set; }
            public class UserQueryResponseBodyModuleItems : TeaModel {
                [NameInMap("employee_nick")]
                [Validation(Required=false)]
                public string EmployeeNick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("leave_status")]
                [Validation(Required=false)]
                public int? LeaveStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("third_part_employee_id")]
                [Validation(Required=false)]
                public string ThirdPartEmployeeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>001</para>
                /// </summary>
                [NameInMap("third_part_job_no")]
                [Validation(Required=false)]
                public string ThirdPartJobNo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9YN+jxa7PcxbNUTISeKjEw==</para>
            /// </summary>
            [NameInMap("page_token")]
            [Validation(Required=false)]
            public string PageToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2f624a6316366024344424669e3279</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
