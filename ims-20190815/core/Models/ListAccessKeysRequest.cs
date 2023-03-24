// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListAccessKeysRequest : TeaModel {
        /// <summary>
        /// The logon name of the RAM user.
        /// 
        /// If this parameter is empty, the AccessKey pairs of the current user are queried.
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
