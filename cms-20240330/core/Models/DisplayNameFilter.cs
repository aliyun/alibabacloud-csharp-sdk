// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DisplayNameFilter : TeaModel {
        /// <summary>
        /// <para>Returns only resources whose display name contains the specified string. The match is case-sensitive.</para>
        /// </summary>
        [NameInMap("contains")]
        [Validation(Required=false)]
        public string Contains { get; set; }

        /// <summary>
        /// <para>Returns only resources whose display name does not contain the specified string. The match is case-sensitive.</para>
        /// </summary>
        [NameInMap("notContains")]
        [Validation(Required=false)]
        public string NotContains { get; set; }

    }

}
