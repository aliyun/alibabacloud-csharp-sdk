// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class UpdateInstanceNetworkRequest : TeaModel {
        /// <summary>
        /// Specifies the retention period of the classic network endpoint. Unit: days.
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public int? ClassicExpiredDays { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to retain the classic network endpoint.
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public bool? RetainClassic { get; set; }

        /// <summary>
        /// The network type of the PolarDB-X 1.0 instance. Valid values:
        /// 
        /// *   vpc: Virtual Private Cloud (VPC)
        /// *   classic: classic network
        /// </summary>
        [NameInMap("SrcInstanceNetworkType")]
        [Validation(Required=false)]
        public string SrcInstanceNetworkType { get; set; }

    }

}
