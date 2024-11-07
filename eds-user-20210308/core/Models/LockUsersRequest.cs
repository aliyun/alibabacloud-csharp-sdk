// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class LockUsersRequest : TeaModel {
        [NameInMap("LogoutSession")]
        [Validation(Required=false)]
        public bool? LogoutSession { get; set; }

        /// <summary>
        /// <para>The usernames of the convenience users that you want to lock.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
