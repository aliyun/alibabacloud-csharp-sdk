// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceRiskNumRequest : TeaModel {
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<ListInstanceRiskNumRequestInstanceList> InstanceList { get; set; }
        public class ListInstanceRiskNumRequestInstanceList : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
