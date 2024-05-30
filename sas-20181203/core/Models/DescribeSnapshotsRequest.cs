// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSnapshotsRequest : TeaModel {
        /// <summary>
        /// The version of the anti-ransomware policy. Valid values:
        /// 
        /// *   **1.0.0**
        /// *   **2.0.0**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the server is an Elastic Compute Service (ECS) instance. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("IsAliYunEcs")]
        [Validation(Required=false)]
        public string IsAliYunEcs { get; set; }

        /// <summary>
        /// The region in which the server resides.
        /// 
        /// > This parameter is required if you do not specify the Uuid parameter.
        /// </summary>
        [NameInMap("MachineRegion")]
        [Validation(Required=false)]
        public string MachineRegion { get; set; }

        /// <summary>
        /// The name or IP address of the server.
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// The starting position of the query. If this parameter is left empty, the query starts from the beginning.
        /// 
        /// >  If you call the operation for the first time, you do not need to specify the parameter. The response to the first call contains the token that can be used for the second call. Each subsequent response contains the token that can be used for the next call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The status of backup snapshots from which data can be restored. Valid values:
        /// 
        /// *   **COMPLETE**: complete
        /// *   **PARTIAL_COMPLETE**: partial complete
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// 
        /// >  You can call the [DescribeBackupPolicy](~~DescribeBackupPolicy~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
