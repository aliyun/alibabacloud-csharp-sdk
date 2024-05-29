// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SkipPreCheckRequest : TeaModel {
        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The ID of the precheck task. You can call the **DescribePreCheckStatus** operation to query the task ID.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The region ID of the DTS instance. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether to skip the precheck item. Valid values:
        /// 
        /// *   **true**: skips the precheck item.
        /// *   **false**: does not skip the precheck item.
        /// 
        /// >  This parameter is required.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public bool? Skip { get; set; }

        /// <summary>
        /// The shortened name of the precheck item. Valid values:
        /// 
        /// *   **CHECK_SAME_OBJ**: object name conflict
        /// 
        /// *   **CHECK_SAME_USER**: multiple usernames for one instance
        /// 
        /// *   **CHECK_SRC**: source database version
        /// 
        /// *   **CHECK_TOPOLOGY**: topology type
        /// 
        /// > For more information about the topologies supported by DTS, see [Synchronization topologies](https://help.aliyun.com/document_detail/124115.html).
        /// 
        /// *   **CHECK_SERVER_ID**: the server ID of the source database
        /// 
        /// >  Separate multiple shortened names with commas (,).
        /// </summary>
        [NameInMap("SkipPreCheckItems")]
        [Validation(Required=false)]
        public string SkipPreCheckItems { get; set; }

        /// <summary>
        /// The name of the precheck item. This parameter corresponds to the **SkipPreCheckItems** parameter. Valid values:
        /// 
        /// *   **CHECK_SAME_OBJ_DETAIL**: object name conflict
        /// 
        /// *   **CHECK_SAME_USER_DETAIL**: multiple usernames for one instance
        /// 
        /// *   **CHECK_SRC_DETAIL**: source database version
        /// 
        /// *   **CHECK_TOPOLOGY_DETAIL**: topology type
        /// 
        /// > For more information about the topologies supported by DTS, see [Synchronization topologies](https://help.aliyun.com/document_detail/124115.html).
        /// 
        /// *   **CHECK_SERVER_ID_DETAIL**: the server ID of the source database
        /// 
        /// >  Separate multiple item names with commas (,).
        /// </summary>
        [NameInMap("SkipPreCheckNames")]
        [Validation(Required=false)]
        public string SkipPreCheckNames { get; set; }

    }

}
