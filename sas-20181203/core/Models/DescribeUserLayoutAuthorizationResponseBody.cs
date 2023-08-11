// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserLayoutAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// The result of the query. Valid values:
        /// - **true**: The brute-force attacks protection feature has been authorized.
        /// - **false**: The brute-force attacks protection feature is not authorized.
        /// </summary>
        [NameInMap("Authorized")]
        [Validation(Required=false)]
        public bool? Authorized { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
