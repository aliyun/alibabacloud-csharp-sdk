// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class MountNFSRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NfsDir")]
        [Validation(Required=false)]
        public string NfsDir { get; set; }

        [NameInMap("MountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        [NameInMap("RemoteDir")]
        [Validation(Required=false)]
        public string RemoteDir { get; set; }

    }

}
