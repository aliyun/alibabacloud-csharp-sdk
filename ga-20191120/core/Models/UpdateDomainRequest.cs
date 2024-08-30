// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateDomainRequest : TeaModel {
        /// <summary>
        /// The new accelerated domain name.
        /// 
        /// Only primary domain names are supported, such as `example.net`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The accelerated domain name to be modified.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetDomain")]
        [Validation(Required=false)]
        public string TargetDomain { get; set; }

    }

}
