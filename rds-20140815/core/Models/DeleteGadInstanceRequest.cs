// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteGadInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the global active database cluster. You can call the [DescribeGadInstances](~~330105~~) operation to query the IDs of global active database clusters.
        /// </summary>
        [NameInMap("GadInstanceName")]
        [Validation(Required=false)]
        public string GadInstanceName { get; set; }

        /// <summary>
        /// The region ID of the central node of the global active database cluster. You can call the [DescribeGadInstances](~~330105~~) operation to query the region IDs of global active database clusters.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
