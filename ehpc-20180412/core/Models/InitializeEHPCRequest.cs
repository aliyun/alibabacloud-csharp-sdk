// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InitializeEHPCRequest : TeaModel {
        /// <summary>
        /// The ID of the region where the service-linked role is created.
        /// 
        /// You can call the [ListRegions](~~188593~~) operation to obtain the IDs of regions supported by E-HPC.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// This parameter is unavailable for public use.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
