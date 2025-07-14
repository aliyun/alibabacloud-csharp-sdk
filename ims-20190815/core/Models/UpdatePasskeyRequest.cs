// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdatePasskeyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the passkey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PASSKEY-CuZjEHhWcr7GIQOMGvkS</para>
        /// </summary>
        [NameInMap("PasskeyId")]
        [Validation(Required=false)]
        public string PasskeyId { get; set; }

        /// <summary>
        /// <para>The name of the passkey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device1</para>
        /// </summary>
        [NameInMap("PasskeyName")]
        [Validation(Required=false)]
        public string PasskeyName { get; set; }

        /// <summary>
        /// <para>The logon name of the Resource Access Management (RAM) user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
