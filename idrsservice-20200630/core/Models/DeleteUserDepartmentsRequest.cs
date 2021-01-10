// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class DeleteUserDepartmentsRequest : TeaModel {
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public List<string> UserId { get; set; }

        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public List<string> DepartmentId { get; set; }

    }

}
