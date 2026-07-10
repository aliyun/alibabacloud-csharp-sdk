// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryEmployeeDetailResponseBody : TeaModel {
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
        public QueryEmployeeDetailResponseBodyModule Module { get; set; }
        public class QueryEmployeeDetailResponseBodyModule : TeaModel {
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("is_leave")]
            [Validation(Required=false)]
            public bool? IsLeave { get; set; }

            [NameInMap("job_number")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            [NameInMap("nick_name")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("out_dept_id")]
            [Validation(Required=false)]
            public string OutDeptId { get; set; }

            [NameInMap("out_dept_id_list")]
            [Validation(Required=false)]
            public List<string> OutDeptIdList { get; set; }

            [NameInMap("out_employee_id")]
            [Validation(Required=false)]
            public string OutEmployeeId { get; set; }

            [NameInMap("phone_no")]
            [Validation(Required=false)]
            public string PhoneNo { get; set; }

            [NameInMap("real_name")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            [NameInMap("real_name_en")]
            [Validation(Required=false)]
            public string RealNameEn { get; set; }

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
