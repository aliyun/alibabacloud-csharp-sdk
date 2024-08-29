// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyMasterSpecRequest : TeaModel {
        /// <summary>
        /// The description of the instance.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// >  You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the IDs of all AnalyticDB for PostgreSQL instances in a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The specifications of coordinator node resources. Valid values:
        /// 
        /// *   2 CU
        /// *   4 CU
        /// *   8 CU
        /// *   16 CU
        /// *   32 CU
        /// 
        /// >  You are charged for coordinator node resources of more than 8 compute units (CUs).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MasterCU")]
        [Validation(Required=false)]
        public int? MasterCU { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs. For information about how to obtain the ID of a resource group, see [View basic information of a resource group](https://help.aliyun.com/document_detail/151181.html).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
