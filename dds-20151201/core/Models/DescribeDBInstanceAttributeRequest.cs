// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The database engine of the instance. Set the value to **MongoDB**.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// Specifies whether to delete the instance. Valid values:
        /// 
        /// - **false**: queries the details of running instances.
        /// - **true**: queries the details of deleted instances.
        /// </summary>
        [NameInMap("IsDelete")]
        [Validation(Required=false)]
        public bool? IsDelete { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the resource group. For more information, see [View the basic information of a resource group](https://help.aliyun.com/document_detail/151181.html).
        /// 
        /// > This parameter is available only if you use the China site (aliyun.com).
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
