// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class DepartmentSaveRequest : TeaModel {
        [NameInMap("depart_list")]
        [Validation(Required=false)]
        public List<DepartmentSaveRequestDepartList> DepartList { get; set; }
        public class DepartmentSaveRequestDepartList : TeaModel {
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public long? DepartId { get; set; }

            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            [NameInMap("depart_pid")]
            [Validation(Required=false)]
            public long? DepartPid { get; set; }

            [NameInMap("manager_ids")]
            [Validation(Required=false)]
            public string ManagerIds { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("third_depart_id")]
            [Validation(Required=false)]
            public string ThirdDepartId { get; set; }

            [NameInMap("third_depart_pid")]
            [Validation(Required=false)]
            public string ThirdDepartPid { get; set; }

        }

    }

}
