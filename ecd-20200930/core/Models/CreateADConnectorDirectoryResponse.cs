// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorDirectoryResponse : TeaModel {
        [NameInMap("DirectoryId")]
        [Validation(Required=true)]
        public string DirectoryId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TrustPassword")]
        [Validation(Required=true)]
        public string TrustPassword { get; set; }

        [NameInMap("AdConnectors")]
        [Validation(Required=true)]
        public List<CreateADConnectorDirectoryResponseAdConnectors> AdConnectors { get; set; }
        public class CreateADConnectorDirectoryResponseAdConnectors : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=true)]
            public string Address { get; set; }

        }

    }

}
