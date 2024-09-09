// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAccessPointResponseBody : TeaModel {
        /// <summary>
        /// The access point.
        /// </summary>
        [NameInMap("AccessPoint")]
        [Validation(Required=false)]
        public CreateAccessPointResponseBodyAccessPoint AccessPoint { get; set; }
        public class CreateAccessPointResponseBodyAccessPoint : TeaModel {
            /// <summary>
            /// The domain name of the access point.
            /// </summary>
            [NameInMap("AccessPointDomain")]
            [Validation(Required=false)]
            public string AccessPointDomain { get; set; }

            /// <summary>
            /// The ID of the access point.
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
