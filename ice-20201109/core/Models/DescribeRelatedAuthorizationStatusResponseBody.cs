// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeRelatedAuthorizationStatusResponseBody : TeaModel {
        [NameInMap("Authorized")]
        [Validation(Required=false)]
        public bool? Authorized { get; set; }

        [NameInMap("MNSAuthorized")]
        [Validation(Required=false)]
        public bool? MNSAuthorized { get; set; }

        [NameInMap("MTSAuthorized")]
        [Validation(Required=false)]
        public bool? MTSAuthorized { get; set; }

        [NameInMap("OSSAuthorized")]
        [Validation(Required=false)]
        public bool? OSSAuthorized { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
