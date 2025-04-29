// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryEmployeeDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public QueryEmployeeDetailResponseBodyModule Module { get; set; }
        public class QueryEmployeeDetailResponseBodyModule : TeaModel {
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_leave")]
            [Validation(Required=false)]
            public bool? IsLeave { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;12138&quot;</para>
            /// </summary>
            [NameInMap("job_number")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            [NameInMap("nick_name")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;123456&quot;</para>
            /// </summary>
            [NameInMap("out_dept_id")]
            [Validation(Required=false)]
            public string OutDeptId { get; set; }

            [NameInMap("out_dept_id_list")]
            [Validation(Required=false)]
            public List<string> OutDeptIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;abc12138&quot;</para>
            /// </summary>
            [NameInMap("out_employee_id")]
            [Validation(Required=false)]
            public string OutEmployeeId { get; set; }

            [NameInMap("phone_no")]
            [Validation(Required=false)]
            public string PhoneNo { get; set; }

            [NameInMap("real_name")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;zhang/san&quot;</para>
            /// </summary>
            [NameInMap("real_name_en")]
            [Validation(Required=false)]
            public string RealNameEn { get; set; }

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
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
