// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstancePayTypeRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The billing method of the instance. The value is fixed as **Prepaid**, which indicates the subscription billing method.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The renewal cycle of the instance.
        /// 
        /// *   **Year**
        /// *   **Month**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The subscription duration of the instance. Valid values:
        /// 
        /// *   If you set the **Period** parameter to **Year**, the value of the **UsedTime** parameter ranges from 1 to 5.
        /// *   If you set the **Period** parameter to **Month**, the value of the **UsedTime** parameter ranges from 1 to 11.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
