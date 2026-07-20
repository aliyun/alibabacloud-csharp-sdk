// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class BatchQueryDepartmentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
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
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public BatchQueryDepartmentResponseBodyModule Module { get; set; }
        public class BatchQueryDepartmentResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("has_more")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<BatchQueryDepartmentResponseBodyModuleItems> Items { get; set; }
            public class BatchQueryDepartmentResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>电磁继电器装配SL10线</para>
                /// </summary>
                [NameInMap("dept_name")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("manager_employee_id_list")]
                [Validation(Required=false)]
                public List<string> ManagerEmployeeIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1335</para>
                /// </summary>
                [NameInMap("out_dept_id")]
                [Validation(Required=false)]
                public string OutDeptId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NjE1OTgwOTY</para>
            /// </summary>
            [NameInMap("next_cursor_token")]
            [Validation(Required=false)]
            public string NextCursorToken { get; set; }

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
        /// <para>B72B39C8-<b><b>-</b></b>-****-D53F11F6ADFE</para>
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
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
