// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyPortRequest : TeaModel {
        [NameInMap("BackendPort")]
        [Validation(Required=false)]
        public string BackendPort { get; set; }

        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public string FrontendPort { get; set; }

        [NameInMap("FrontendProtocol")]
        [Validation(Required=false)]
        public string FrontendProtocol { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

    }

}
