// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class SetAccountInfoRequest : TeaModel {
        /// <summary>
        /// Sub Account Nickname. 
        /// * Use the official name of Company, if Sub Account is an enterprise.
        /// * Use the official name of Partner, if Sub Account is a T2 reseller.
        /// </summary>
        [NameInMap("AccountNickname")]
        [Validation(Required=false)]
        public string AccountNickname { get; set; }

        /// <summary>
        /// Description of Sub Account.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The UID of Sub Account.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
