// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateInstanceAclRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public string Actions { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("decision")]
        [Validation(Required=false)]
        public string Decision { get; set; }

        [NameInMap("ipWhitelists")]
        [Validation(Required=false)]
        public List<string> IpWhitelists { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
