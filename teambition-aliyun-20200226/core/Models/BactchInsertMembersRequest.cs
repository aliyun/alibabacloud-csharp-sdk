// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Teambition_aliyun20200226.Models
{
    public class BactchInsertMembersRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("Members")]
        [Validation(Required=false)]
        public string Members { get; set; }

        [NameInMap("RealPk")]
        [Validation(Required=false)]
        public string RealPk { get; set; }

    }

}
