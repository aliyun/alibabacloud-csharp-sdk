// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// The specifications of the cluster.
        /// 
        /// *   Valid values when the cluster is of Single-replica Edition:
        /// 
        ///     *   **S4-NEW**
        ///     *   **S8**
        ///     *   **S16**
        ///     *   **S32**
        ///     *   **S64**
        ///     *   **S104**
        /// 
        /// *   Valid values when the cluster is of Double-replica Edition:
        /// 
        ///     *   **C4-NEW**
        ///     *   **C8**
        ///     *   **C16**
        ///     *   **C32**
        ///     *   **C64**
        ///     *   **C104**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The number of nodes in the cluster.
        /// 
        /// *   If the cluster is of Single-replica Edition, the value must be an integer that ranges from 1 to 48.
        /// *   If the cluster is of Double-replica Edition, the value must be an integer that ranges from 1 to 24.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// The storage capacity of a single node of the cluster. Unit: GB.
        /// 
        /// Valid values: 100 to 32000.
        /// 
        /// >  This value is a multiple of 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        [NameInMap("DbNodeStorageType")]
        [Validation(Required=false)]
        public string DbNodeStorageType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/170875.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
