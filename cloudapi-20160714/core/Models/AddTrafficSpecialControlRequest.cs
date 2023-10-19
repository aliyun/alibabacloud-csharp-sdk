// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AddTrafficSpecialControlRequest : TeaModel {
        /// <summary>
        /// The security token included in the WebSocket request header. The system uses this token to authenticate the request.
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the app or Alibaba Cloud account. Specify this parameter based on the value of the **SpecialType** parameter. You can view your account ID on the [Account Management](https://account.console.aliyun.com/?spm=a2c4g.11186623.2.15.3f053654YpMPwo#/secure) page.
        /// </summary>
        [NameInMap("SpecialKey")]
        [Validation(Required=false)]
        public string SpecialKey { get; set; }

        /// <summary>
        /// The type of the special throttling policy. Valid values:
        /// 
        /// *   **APP**
        /// *   **USER**
        /// </summary>
        [NameInMap("SpecialType")]
        [Validation(Required=false)]
        public string SpecialType { get; set; }

        /// <summary>
        /// The ID of the specified throttling policy.
        /// </summary>
        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

        /// <summary>
        /// The special throttling value.
        /// </summary>
        [NameInMap("TrafficValue")]
        [Validation(Required=false)]
        public int? TrafficValue { get; set; }

    }

}
