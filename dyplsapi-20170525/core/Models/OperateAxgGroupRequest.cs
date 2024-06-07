// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class OperateAxgGroupRequest : TeaModel {
        /// <summary>
        /// The group ID in the AXG binding.
        /// 
        /// You can view the group ID by using either of the following methods:
        /// 
        /// *   On the **Number Pool Management** page in the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account), filter AXG private numbers and click **Number Group G Management** to view the group IDs of number groups G.****
        /// *   If the [CreateAxgGroup](https://help.aliyun.com/document_detail/110250.html) operation is called to create number group G, the value of **GroupId** in the response of the CreateAxgGroup operation is specified as the value of the request parameter **GroupId** of the OperateAxgGroup operation.
        /// 
        /// >  Number group G must have one or more phone numbers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The phone numbers that you add to number group G. Separate the phone numbers with commas (,). You can add up to 200 phone numbers at a time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public string Numbers { get; set; }

        /// <summary>
        /// The type of the operation on number group G. Valid values:
        /// 
        /// *   **addNumbers**: adds phone numbers to number group G.
        /// *   **deleteNumbers**: deletes phone numbers from number group G.
        /// *   **overwriteNumbers**: replaces all phone numbers in number group G. All the original phone numbers are deleted from number group G, and new phone numbers are added to number group G.
        /// 
        /// > 
        /// 
        /// *   When you replace all phone numbers in number group G, the quantity of original phone numbers in number group G cannot exceed 200.
        /// 
        /// *   You can add up to 200 phone numbers to number group G at a time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The key of the phone number pool. Log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) and view the key of the phone number pool on the **Number Pool Management** page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
