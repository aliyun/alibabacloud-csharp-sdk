// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DeleteIpSetsRequest : TeaModel {
        /// <summary>
        /// The IDs of the acceleration regions that you want to delete.
        /// </summary>
        [NameInMap("IpSetIds")]
        [Validation(Required=false)]
        public List<string> IpSetIds { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
