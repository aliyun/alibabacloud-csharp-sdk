// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class DeleteSecretBlacklistRequest : TeaModel {
        /// <summary>
        /// The phone numbers in the blacklist. A point-to-point blacklist has a pair of numbers separated by a colon (":"). A number pool blacklist or a platform blacklist has only one single number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BlackNo")]
        [Validation(Required=false)]
        public string BlackNo { get; set; }

        /// <summary>
        /// The blacklist type. Valid values:
        /// 
        /// *   **POINT_TO_POINT_BLACK**: point-to-point blacklist
        /// *   **PARTNER_GLOBAL_NUMBER_BLACK**: number pool blacklist
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BlackType")]
        [Validation(Required=false)]
        public string BlackType { get; set; }

        /// <summary>
        /// The key of the phone number pool. Log on to the [Phone Number Protection console](https://dypls.console.aliyun.com/dypls.htm#/account) and view the key of the phone number pool on the **Number Pool Management** page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// The remarks for the blacklist.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The control on the call direction.
        /// 
        /// *   **PHONEA_REJECT**: The first phone number in the blacklist can be used to call the second phone number, but the second phone number in the blacklist cannot be used to call the first phone number.
        /// *   **PHONEB_REJECT**: The first phone number in the blacklist cannot be used to call the second phone number, but the second phone number in the blacklist can be used to call the first phone number.
        /// *   If this parameter is not specified, the two phone numbers in the blacklist cannot be used to call each other.
        /// 
        /// Valid values:
        /// 
        /// *   DUPLEX_REJECT
        /// *   PHONEA_REJECT
        /// *   PHONEB_REJECT
        /// </summary>
        [NameInMap("WayControl")]
        [Validation(Required=false)]
        public string WayControl { get; set; }

    }

}
