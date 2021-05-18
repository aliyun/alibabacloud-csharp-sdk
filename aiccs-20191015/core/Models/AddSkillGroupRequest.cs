// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddSkillGroupRequest : TeaModel {
        [NameInMap("OuterGroupId")]
        [Validation(Required=false)]
        public string OuterGroupId { get; set; }

        [NameInMap("OuterGroupName")]
        [Validation(Required=false)]
        public string OuterGroupName { get; set; }

        [NameInMap("OuterGroupType")]
        [Validation(Required=false)]
        public string OuterGroupType { get; set; }

        [NameInMap("OuterDepartmentId")]
        [Validation(Required=false)]
        public string OuterDepartmentId { get; set; }

        [NameInMap("OuterDepartmentType")]
        [Validation(Required=false)]
        public string OuterDepartmentType { get; set; }

    }

}
