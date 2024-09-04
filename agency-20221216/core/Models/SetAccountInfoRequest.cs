// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class SetAccountInfoRequest : TeaModel {
        /// <summary>
        /// Result Code:
        /// *   200 OK
        /// *   1109 System error
        /// *   3030 Sub Account Nickname exceeds maximum length,  maximum length 150 bytes.
        /// *   3031 Remark exceeds maximum length,  maximum length 3000 bytes.
        /// </summary>
        [NameInMap("AccountNickname")]
        [Validation(Required=false)]
        public string AccountNickname { get; set; }

        /// <summary>
        /// Customer manager（limited 50 character）
        /// </summary>
        [NameInMap("CustomerBd")]
        [Validation(Required=false)]
        public string CustomerBd { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// Request ID, Alibaba Cloud will track errors with this.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
