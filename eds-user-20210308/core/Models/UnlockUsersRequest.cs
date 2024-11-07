// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UnlockUsersRequest : TeaModel {
        /// <summary>
        /// <para>The date on which the convenience users are automatically locked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-03</para>
        /// </summary>
        [NameInMap("AutoLockTime")]
        [Validation(Required=false)]
        public string AutoLockTime { get; set; }

        /// <summary>
        /// <para>The usernames of the convenience users that you want to unlock.</para>
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
