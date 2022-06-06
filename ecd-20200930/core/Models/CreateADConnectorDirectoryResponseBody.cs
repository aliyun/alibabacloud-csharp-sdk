// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorDirectoryResponseBody : TeaModel {
        [NameInMap("AdConnectors")]
        [Validation(Required=false)]
        public List<CreateADConnectorDirectoryResponseBodyAdConnectors> AdConnectors { get; set; }
        public class CreateADConnectorDirectoryResponseBodyAdConnectors : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

        }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrustPassword")]
        [Validation(Required=false)]
        public string TrustPassword { get; set; }

    }

}
