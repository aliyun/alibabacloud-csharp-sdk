// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ApplyTokenResponseBody : TeaModel {
        /// <summary>
        /// The request ID. This parameter is a common parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The token that is returned by the ApsaraMQ for MQTT broker.
        /// 
        /// >  Do not assume the length, format, or rule of the token to return. The actual returned token shall prevail.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
