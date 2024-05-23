// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateParameterGroupRequest : TeaModel {
        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **mysql**
        /// *   **PostgreSQL**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version of the instance.
        /// 
        /// *   If the instance runs MySQL, the instance must run one of the following MySQL versions:
        /// 
        ///     *   **5.6**
        ///     *   **5.7**
        ///     *   **8.0**
        /// 
        /// *   If the instance runs PostgreSQL, the instance must run one of the following PostgreSQL versions:
        /// 
        ///     *   **10.0**
        ///     *   **11.0**
        ///     *   **12.0**
        ///     *   **13.0**
        ///     *   **14.0**
        ///     *   **15.0**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The description of the parameter template. The value can be up to 200 characters in length.
        /// </summary>
        [NameInMap("ParameterGroupDesc")]
        [Validation(Required=false)]
        public string ParameterGroupDesc { get; set; }

        /// <summary>
        /// The name of the parameter template.
        /// 
        /// *   The value must start with a letter and can contain letters, digits, periods (.), and underscores (_).
        /// *   The value can be 8 to 64 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// A JSON string that consists of parameters and their values in the parameter template. Format: {"Parameter 1":"Value of Parameter 1","Parameter 2":"Value of Parameter 2"...}. For more information about the parameters that can be modified, see [Modify the parameters of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/96063.html) or [Modify the parameters of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96751.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// The region ID of the parameter template. You can call the DescribeRegions operation to query the most recent zone list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID. You can call the DescribeDBInstanceAttribute operation to obtain the resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
