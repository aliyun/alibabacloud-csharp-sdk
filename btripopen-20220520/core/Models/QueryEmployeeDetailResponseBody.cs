// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryEmployeeDetailResponseBody : TeaModel {
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The details of the response.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public QueryEmployeeDetailResponseBodyModule Module { get; set; }
        public class QueryEmployeeDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>j*********@example.com</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the employee has resigned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_leave")]
            [Validation(Required=false)]
            public bool? IsLeave { get; set; }

            /// <summary>
            /// <para>The employee number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;12138&quot;</para>
            /// </summary>
            [NameInMap("job_number")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            /// <summary>
            /// <para>The nickname of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;张三&quot;</para>
            /// </summary>
            [NameInMap("nick_name")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The external department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;123456&quot;</para>
            /// </summary>
            [NameInMap("out_dept_id")]
            [Validation(Required=false)]
            public string OutDeptId { get; set; }

            /// <summary>
            /// <para>The list of external department IDs.</para>
            /// </summary>
            [NameInMap("out_dept_id_list")]
            [Validation(Required=false)]
            public List<string> OutDeptIdList { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;abc12138&quot;</para>
            /// </summary>
            [NameInMap("out_employee_id")]
            [Validation(Required=false)]
            public string OutEmployeeId { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>138****8888</para>
            /// </summary>
            [NameInMap("phone_no")]
            [Validation(Required=false)]
            public string PhoneNo { get; set; }

            /// <summary>
            /// <para>The real name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;张三&quot;</para>
            /// </summary>
            [NameInMap("real_name")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// <para>The passport name (in pinyin), in the format of LastName/FirstName.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;zhang/san&quot;</para>
            /// </summary>
            [NameInMap("real_name_en")]
            [Validation(Required=false)]
            public string RealNameEn { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Succeeded.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
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
