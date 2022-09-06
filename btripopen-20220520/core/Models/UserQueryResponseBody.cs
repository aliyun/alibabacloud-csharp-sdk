// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UserQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public UserQueryResponseBodyModule Module { get; set; }
        public class UserQueryResponseBodyModule : TeaModel {
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

                [NameInMap("third_part_employee_id")]
                [Validation(Required=false)]
                public string ThirdPartEmployeeId { get; set; }

                [NameInMap("third_part_job_no")]
                [Validation(Required=false)]
                public string ThirdPartJobNo { get; set; }

            }

            [NameInMap("page_token")]
            [Validation(Required=false)]
            public string PageToken { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
