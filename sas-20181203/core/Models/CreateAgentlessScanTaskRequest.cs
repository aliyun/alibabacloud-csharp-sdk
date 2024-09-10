// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAgentlessScanTaskRequest : TeaModel {
        /// <summary>
        /// Identification of asset selection.
        /// </summary>
        [NameInMap("AssetSelectionType")]
        [Validation(Required=false)]
        public string AssetSelectionType { get; set; }

        /// <summary>
        /// The retention period of images. Unit: days.
        /// </summary>
        [NameInMap("AutoDeleteDays")]
        [Validation(Required=false)]
        public int? AutoDeleteDays { get; set; }

        /// <summary>
        /// Specifies whether to enable the cost-saving mode. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ReleaseAfterScan")]
        [Validation(Required=false)]
        public bool? ReleaseAfterScan { get; set; }

        /// <summary>
        /// Specifies whether to check data disks. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ScanDataDisk")]
        [Validation(Required=false)]
        public bool? ScanDataDisk { get; set; }

        /// <summary>
        /// The type of the detection object. Valid values:
        /// 
        /// *   **2**: image
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        /// <summary>
        /// The UUIDs of the assets on which you want to run the detection task.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
