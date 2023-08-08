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
        /// *   The value must start with a letter and can contain letters, digits, periods (.), and underscores (\_).
        /// *   The value can be 8 to 64 characters in length.
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// A JSON string that consists of parameters and their values in the parameter template. Format: {"Parameter 1":"Value of Parameter 1","Parameter 2":"Value of Parameter 2"...}. For more information about the parameters that can be modified, see [Modify the parameters of an ApsaraDB RDS for MySQL instance](~~96063~~) or [Modify the parameters of an ApsaraDB RDS for PostgreSQL instance](~~96751~~).
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// The region ID of the parameter template. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
