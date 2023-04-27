// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenVbrHealthCheckRequest : TeaModel {
        /// <summary>
        /// The ID of the VBR.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("VbrInstanceId")]
        [Validation(Required=false)]
        public string VbrInstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the VBR is deployed.
        /// </summary>
        [NameInMap("VbrInstanceOwnerId")]
        [Validation(Required=false)]
        public long? VbrInstanceOwnerId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeCenVbrHealthCheck**.
        /// </summary>
        [NameInMap("VbrInstanceRegionId")]
        [Validation(Required=false)]
        public string VbrInstanceRegionId { get; set; }

    }

}
