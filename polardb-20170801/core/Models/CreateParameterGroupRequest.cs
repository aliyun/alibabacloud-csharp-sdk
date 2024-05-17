// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateParameterGroupRequest : TeaModel {
        /// <summary>
        /// The type of the database engine. Only **MySQL** is supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The version of the database engine. Valid values:
        /// 
        /// *   **5.6**
        /// *   **5.7**
        /// *   **8.0**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The description of the parameter template. It must be 0 to 199 characters in length.
        /// </summary>
        [NameInMap("ParameterGroupDesc")]
        [Validation(Required=false)]
        public string ParameterGroupDesc { get; set; }

        /// <summary>
        /// The name of the parameter template. The name must meet the following requirements:
        /// 
        /// *   It can contain letters, digits, and underscores (_). It must start with a letter and cannot end with an underscore.**
        /// *   It must be 8 to 64 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// The JSON string that consists of parameters and values. The parameter values are strings. Example: `{"wait_timeout":"86400","innodb_old_blocks_time":"1000"}`.
        /// 
        /// > You can call the [DescribeParameterTemplates](https://help.aliyun.com/document_detail/207428.html) operation to query the details of all parameters in the cluster of a specified engine version, such as the parameter name and valid values.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/98041.html) operation to query available regions.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
