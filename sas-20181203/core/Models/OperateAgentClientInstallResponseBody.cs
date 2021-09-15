// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateAgentClientInstallResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AegisCelintInstallResposeList")]
        [Validation(Required=false)]
        public List<OperateAgentClientInstallResponseBodyAegisCelintInstallResposeList> AegisCelintInstallResposeList { get; set; }
        public class OperateAgentClientInstallResponseBodyAegisCelintInstallResposeList : TeaModel {
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

        }

    }

}
