// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BuySecretNoRequest : TeaModel {
        /// <summary>
        /// Specifies the home location of the phone number.
        /// 
        /// > 
        /// 
        /// *   The home location can be set only to a location in the Chinese mainland.
        /// 
        /// *   A phone number that starts with 95 does not have a home location. If you purchase a phone number that starts with 95, set this parameter to **Nationwide**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// Specifies whether to add the phone number to the pool of numbers that will be displayed during calls.
        /// 
        /// >  This parameter takes effect only for customers who have enabled the number display feature.
        /// </summary>
        [NameInMap("DisplayPool")]
        [Validation(Required=false)]
        public bool? DisplayPool { get; set; }

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
        /// The prefix of the phone number. If you specify the value of **SecretNo** when you purchase a phone number, a phone number starting with the specified prefix is selected.
        /// 
        /// >  You can specify up to 18 digits of the phone number prefix.
        /// </summary>
        [NameInMap("SecretNo")]
        [Validation(Required=false)]
        public string SecretNo { get; set; }

        /// <summary>
        /// The type of the phone number. Valid values:
        /// 
        /// *   **1**: a phone number assigned by a virtual network operator, that is, a phone number that belongs to the 170 or 171 number segment.
        /// *   **2**: a phone number provided by a carrier.
        /// *   **3**: a phone number that starts with 95.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public long? SpecId { get; set; }

    }

}
