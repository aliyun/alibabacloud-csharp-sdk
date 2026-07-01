// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class AddIpamPoolCidrRequest : TeaModel {
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IpamPoolId")]
        [Validation(Required=false)]
        public string IpamPoolId { get; set; }

        [NameInMap("NetmaskLength")]
        [Validation(Required=false)]
        public int? NetmaskLength { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
