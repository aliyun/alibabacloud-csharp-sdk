// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class GetUserRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:user/user_name</para>
        /// </summary>
        [NameInMap("userPrincipal")]
        [Validation(Required=false)]
        public string UserPrincipal { get; set; }

    }

}
