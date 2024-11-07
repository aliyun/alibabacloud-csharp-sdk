// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ChangeUserPasswordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>alice***</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Admin@12***</para>
        /// </summary>
        [NameInMap("NewPassword")]
        [Validation(Required=false)]
        public string NewPassword { get; set; }

    }

}
