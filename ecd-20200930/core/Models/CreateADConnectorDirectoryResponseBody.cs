// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorDirectoryResponseBody : TeaModel {
        /// <summary>
        /// Details of the AD connectors.
        /// </summary>
        [NameInMap("AdConnectors")]
        [Validation(Required=false)]
        public List<CreateADConnectorDirectoryResponseBodyAdConnectors> AdConnectors { get; set; }
        public class CreateADConnectorDirectoryResponseBodyAdConnectors : TeaModel {
            /// <summary>
            /// The IP address of the AD connector.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

        }

        /// <summary>
        /// The ID of the AD directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The AD trust password.
        /// </summary>
        [NameInMap("TrustPassword")]
        [Validation(Required=false)]
        public string TrustPassword { get; set; }

    }

}
