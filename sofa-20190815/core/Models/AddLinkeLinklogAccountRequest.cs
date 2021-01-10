// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeLinklogAccountRequest : TeaModel {
        [NameInMap("EmpId")]
        [Validation(Required=false)]
        public string EmpId { get; set; }

        [NameInMap("Nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public long? Role { get; set; }

        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        [NameInMap("StoreIdsRepeatList")]
        [Validation(Required=false)]
        public List<int?> StoreIdsRepeatList { get; set; }

    }

}
