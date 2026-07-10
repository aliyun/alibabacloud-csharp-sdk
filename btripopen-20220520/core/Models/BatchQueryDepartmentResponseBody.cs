// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class BatchQueryDepartmentResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public BatchQueryDepartmentResponseBodyModule Module { get; set; }
        public class BatchQueryDepartmentResponseBodyModule : TeaModel {
            [NameInMap("has_more")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<BatchQueryDepartmentResponseBodyModuleItems> Items { get; set; }
            public class BatchQueryDepartmentResponseBodyModuleItems : TeaModel {
                [NameInMap("dept_name")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("manager_employee_id_list")]
                [Validation(Required=false)]
                public List<string> ManagerEmployeeIdList { get; set; }

                [NameInMap("out_dept_id")]
                [Validation(Required=false)]
                public string OutDeptId { get; set; }

            }

            [NameInMap("next_cursor_token")]
            [Validation(Required=false)]
            public string NextCursorToken { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
