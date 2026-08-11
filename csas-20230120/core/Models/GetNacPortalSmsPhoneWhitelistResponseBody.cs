// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetNacPortalSmsPhoneWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of phone numbers.</para>
        /// </summary>
        [NameInMap("Phones")]
        [Validation(Required=false)]
        public List<string> Phones { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B608C6AE-623D-55C4-9454-601B88AE937E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
