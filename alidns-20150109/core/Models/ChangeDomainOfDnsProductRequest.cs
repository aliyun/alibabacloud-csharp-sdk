// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ChangeDomainOfDnsProductRequest : TeaModel {
        /// <summary>
        /// Specifies whether to force bind a domain name to the instance.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud DNS instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The language in which you want the values of some response parameters to be returned. These response parameters support multiple languages.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The domain name that you want to bind to the instance. If you do not specify this parameter, this operation unbinds the original domain name from the instance.
        /// </summary>
        [NameInMap("NewDomain")]
        [Validation(Required=false)]
        public string NewDomain { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
