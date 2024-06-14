// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateNetworkRuleRequest : TeaModel {
        /// <summary>
        /// The description after the update.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the access control rule that you want to update.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The private IP address or CIDR block after the update. Separate multiple items with commas (,).
        /// </summary>
        [NameInMap("SourcePrivateIp")]
        [Validation(Required=false)]
        public string SourcePrivateIp { get; set; }

    }

}
