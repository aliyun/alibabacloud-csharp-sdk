// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ResetUserPasswordRequest : TeaModel {
        /// <summary>
        /// The method to notify the user after the password is reset.
        /// 
        /// > Alibaba Cloud accounts of the international site do not support sending notification through text messages.
        /// </summary>
        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public int? NotifyType { get; set; }

        /// <summary>
        /// The names of the convenience users whose passwords you want to reset.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
