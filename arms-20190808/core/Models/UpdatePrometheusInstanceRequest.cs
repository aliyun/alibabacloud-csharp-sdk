// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// The number of days for which data is automatically archived after the storage expires. Valid values: 60, 90, 180, and 365. 0 indicates that the data is not archived.
        /// </summary>
        [NameInMap("ArchiveDuration")]
        [Validation(Required=false)]
        public int? ArchiveDuration { get; set; }

        [NameInMap("AuthFreeReadPolicy")]
        [Validation(Required=false)]
        public string AuthFreeReadPolicy { get; set; }

        [NameInMap("AuthFreeWritePolicy")]
        [Validation(Required=false)]
        public string AuthFreeWritePolicy { get; set; }

        /// <summary>
        /// The ID of the Prometheus instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("EnableAuthFreeRead")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeRead { get; set; }

        [NameInMap("EnableAuthFreeWrite")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeWrite { get; set; }

        [NameInMap("EnableAuthToken")]
        [Validation(Required=false)]
        public bool? EnableAuthToken { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The data storage duration. Unit: days.
        /// </summary>
        [NameInMap("StorageDuration")]
        [Validation(Required=false)]
        public int? StorageDuration { get; set; }

    }

}
