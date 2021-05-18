// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddOuterAccountRequest : TeaModel {
        [NameInMap("OuterAccountId")]
        [Validation(Required=false)]
        public string OuterAccountId { get; set; }

        [NameInMap("OuterAccountType")]
        [Validation(Required=false)]
        public string OuterAccountType { get; set; }

        [NameInMap("OuterAccountName")]
        [Validation(Required=false)]
        public string OuterAccountName { get; set; }

        [NameInMap("Avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("RealName")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        [NameInMap("OuterDepartmentId")]
        [Validation(Required=false)]
        public string OuterDepartmentId { get; set; }

        [NameInMap("OuterGroupIds")]
        [Validation(Required=false)]
        public string OuterGroupIds { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        [NameInMap("OuterDepartmentType")]
        [Validation(Required=false)]
        public string OuterDepartmentType { get; set; }

        [NameInMap("OuterGroupType")]
        [Validation(Required=false)]
        public string OuterGroupType { get; set; }

    }

}
