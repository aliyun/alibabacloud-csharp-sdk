// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class BatchQueryDepartmentRequest : TeaModel {
        [NameInMap("modified_time_greater_or_equal_than")]
        [Validation(Required=false)]
        public string ModifiedTimeGreaterOrEqualThan { get; set; }

        [NameInMap("out_dept_id")]
        [Validation(Required=false)]
        public string OutDeptId { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("page_token")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

    }

}
