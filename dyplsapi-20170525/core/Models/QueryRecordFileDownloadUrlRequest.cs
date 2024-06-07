// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryRecordFileDownloadUrlRequest : TeaModel {
        /// <summary>
        /// The ID of the call record. Log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) and view **Call Record ID** on the **Call Record Query** page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// The call initiation time in the call record. Log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account). View **Call Initiated At** on the **Call Record Query** page, or view the call_time field in the Call Detail Record (CDR) receipt.
        /// </summary>
        [NameInMap("CallTime")]
        [Validation(Required=false)]
        public string CallTime { get; set; }

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
        /// The product type. Valid values:
        /// 
        /// *   **AXB_170**.
        /// *   **AXN_170**.
        /// *   **AXN_95**.
        /// *   **AXN_EXTENSION_REUSE**
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

    }

}
