// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateNacPortalSmsPhoneWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The list of phone numbers.</para>
        /// </summary>
        [NameInMap("Phones")]
        [Validation(Required=false)]
        public List<string> Phones { get; set; }

    }

}
