// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ManagePrivateRdsRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("RdsAction")]
        [Validation(Required=false)]
        public string RdsAction { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
