// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AddTrafficSpecialControlRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("SpecialKey")]
        [Validation(Required=false)]
        public string SpecialKey { get; set; }

        /// <summary>
        /// The special throttling value.
        /// </summary>
        [NameInMap("SpecialType")]
        [Validation(Required=false)]
        public string SpecialType { get; set; }

        /// <summary>
        /// The ID of the app or Alibaba Cloud account. Specify this parameter based on the value of the **SpecialType** parameter. You can view your account ID on the [Account Management](https://account.console.aliyun.com/?spm=a2c4g.11186623.2.15.3f053654YpMPwo#/secure) page.
        /// </summary>
        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

        /// <summary>
        /// *   This API is intended for API providers.
        /// *   If the input SpecialKey already exists, the previous configuration is overwritten. Use caution when calling this operation.
        /// *   Special throttling policies must be added to an existing throttling policy, and can take effect on all the APIs to which the throttling policy is bound.
        /// </summary>
        [NameInMap("TrafficValue")]
        [Validation(Required=false)]
        public int? TrafficValue { get; set; }

    }

}
