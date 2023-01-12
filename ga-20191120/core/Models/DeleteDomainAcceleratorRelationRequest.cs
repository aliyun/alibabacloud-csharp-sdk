// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DeleteDomainAcceleratorRelationRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance to be disassociated. You can enter up to 50 IDs.
        /// 
        /// If you do not set this parameter, all GA instances associated with the specified domain name are disassociated.
        /// </summary>
        [NameInMap("AcceleratorIds")]
        [Validation(Required=false)]
        public List<string> AcceleratorIds { get; set; }

        /// <summary>
        /// The domain name to be disassociated.
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
