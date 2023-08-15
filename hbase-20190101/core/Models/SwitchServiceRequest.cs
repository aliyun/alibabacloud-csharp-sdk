// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class SwitchServiceRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Operate")]
        [Validation(Required=false)]
        public string Operate { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
