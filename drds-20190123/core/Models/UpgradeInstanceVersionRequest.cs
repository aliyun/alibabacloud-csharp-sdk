// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class UpgradeInstanceVersionRequest : TeaModel {
        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance that you want to upgrade.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The version number of the PolarDB-X 1.0 instance. You can leave this parameter unspecified.
        /// </summary>
        [NameInMap("Rpm")]
        [Validation(Required=false)]
        public string Rpm { get; set; }

    }

}
