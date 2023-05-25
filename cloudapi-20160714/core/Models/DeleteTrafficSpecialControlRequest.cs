// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteTrafficSpecialControlRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// *   This API is intended for API providers.
        /// *   You can obtain the input parameters required in this operation by calling other APIs.
        /// </summary>
        [NameInMap("SpecialKey")]
        [Validation(Required=false)]
        public string SpecialKey { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("SpecialType")]
        [Validation(Required=false)]
        public string SpecialType { get; set; }

        /// <summary>
        /// The ID of the app or Alibaba Cloud account. You can view your account ID on the [Account Management](https://account.console.aliyun.com/?spm=a2c4g.11186623.2.15.343130a8sDi8cO#/secure) page.
        /// </summary>
        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

    }

}
