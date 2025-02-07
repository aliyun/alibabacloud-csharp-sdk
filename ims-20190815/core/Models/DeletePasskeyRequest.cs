// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class DeletePasskeyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PASSKEY-CuZjEHhWcr7GIQOMGvkS</para>
        /// </summary>
        [NameInMap("PasskeyId")]
        [Validation(Required=false)]
        public string PasskeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
