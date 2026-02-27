// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class OpenStructSaseDepartment : TeaModel {
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        [NameInMap("FullDepartmentIdPath")]
        [Validation(Required=false)]
        public string FullDepartmentIdPath { get; set; }

        [NameInMap("FullDn")]
        [Validation(Required=false)]
        public string FullDn { get; set; }

        [NameInMap("IdpId")]
        [Validation(Required=false)]
        public long? IdpId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ParentDepartmentId")]
        [Validation(Required=false)]
        public string ParentDepartmentId { get; set; }

    }

}
