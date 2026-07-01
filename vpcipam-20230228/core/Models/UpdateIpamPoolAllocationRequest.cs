// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class UpdateIpamPoolAllocationRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("IpamPoolAllocationDescription")]
        [Validation(Required=false)]
        public string IpamPoolAllocationDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IpamPoolAllocationId")]
        [Validation(Required=false)]
        public string IpamPoolAllocationId { get; set; }

        [NameInMap("IpamPoolAllocationName")]
        [Validation(Required=false)]
        public string IpamPoolAllocationName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
