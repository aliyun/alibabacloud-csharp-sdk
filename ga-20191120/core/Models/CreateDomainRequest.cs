// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// 
        /// You can enter up to 50 IDs.
        /// </summary>
        [NameInMap("AcceleratorIds")]
        [Validation(Required=false)]
        public List<string> AcceleratorIds { get; set; }

        /// <summary>
        /// The accelerated domain name to be added.
        /// 
        /// Wildcard domain names are supported. A wildcard domain name must start with `*.`, such as `*.example.com`.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
