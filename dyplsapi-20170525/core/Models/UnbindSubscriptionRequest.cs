// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UnbindSubscriptionRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The key of the phone number pool. Log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) and view the key of the phone number pool on the **Number Pool Management** page.
        /// 
        /// >  This parameter is required when **ProductType** is left empty.
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// The product type. Fixed value: **AXB_170**.
        /// 
        /// > 
        /// 
        /// *   This parameter is applicable to the original key accounts of Alibaba Cloud. This parameter can be ignored for Alibaba Cloud users.
        /// 
        /// *   This parameter is required when **PoolKey** is left empty.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The private number, that is, phone number X specified in an API operation for a phone number binding such as [BindAXG](https://help.aliyun.com/document_detail/110249.html) or automatically assigned after such an operation is called.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretNo")]
        [Validation(Required=false)]
        public string SecretNo { get; set; }

        /// <summary>
        /// The binding ID.
        /// 
        /// Log on to the Phone Number Protection console, choose **Number and Number Pool** > **Number Management**. On the Number Management page, select the desired record and click Details to view the binding ID. Alternatively, you can view the value of the **SubsId** parameter returned by an API operation for a phone number binding such as BindAxb. The value of this parameter indicates a binding ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubsId")]
        [Validation(Required=false)]
        public string SubsId { get; set; }

    }

}
