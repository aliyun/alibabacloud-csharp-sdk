// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ShieldPrecheckRequest : TeaModel {
        /// <summary>
        /// The ID of the data migration or data synchronization instance. You can call the **DescribeMigrationJobs** or DescribeSynchronizationJobs operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The precheck items that you want to ignore. Separate multiple items with commas (,). Valid values:
        /// 
        /// *   **CHECK_SAME_OBJ**: schema name conflict
        /// 
        /// *   **CHECK_SAME_USER**: multiple usernames for one instance
        /// 
        /// *   **CHECK_SRC**: source database version
        /// 
        /// *   **CHECK_TOPOLOGY**: topology
        /// 
        /// > For more information about the topologies supported by DTS, see [Synchronization topologies](https://help.aliyun.com/document_detail/124115.html).
        /// 
        /// *   **CHECK_SERVER_ID**: value of server_id in the source database
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PrecheckItems")]
        [Validation(Required=false)]
        public string PrecheckItems { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
