// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDTSIPRequest : TeaModel {
        /// <summary>
        /// The ID of the region where the destination instance resides. For more information, see [List of supported regions](~~141033~~).
        /// 
        /// >  If the destination instance is a self-managed database with a public IP address, you can set the parameter to **cn-hangzhou** or the ID of the closest region.
        /// </summary>
        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the region where the source instance resides. For more information, see [List of supported regions](~~141033~~).
        /// 
        /// >  If the source instance is a self-managed database with a public IP address, you can set the parameter to **cn-hangzhou** or the ID of the closest region.
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

    }

}
