// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryTokenResponseBody : TeaModel {
        /// <summary>
        /// The unique ID that the system generates for the request. This parameter is a common parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the queried token. Valid values:
        /// 
        /// *   **true**: indicates the token is valid.
        /// *   **false**: indicates the token is invalid.
        /// </summary>
        [NameInMap("TokenStatus")]
        [Validation(Required=false)]
        public bool? TokenStatus { get; set; }

    }

}
