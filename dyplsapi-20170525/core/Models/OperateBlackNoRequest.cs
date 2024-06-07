// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class OperateBlackNoRequest : TeaModel {
        /// <summary>
        /// The phone number to be added to or deleted from the blacklist.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BlackNo")]
        [Validation(Required=false)]
        public string BlackNo { get; set; }

        /// <summary>
        /// The type of the operation on the phone number. Valid values:
        /// 
        /// *   **AddBlack**: adds the phone number to the blacklist.
        /// *   **DeleteBlack**: deletes the phone number from the blacklist.
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

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Tips")]
        [Validation(Required=false)]
        public string Tips { get; set; }

    }

}
