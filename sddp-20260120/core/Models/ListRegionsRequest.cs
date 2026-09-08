// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListRegionsRequest : TeaModel {
        [NameInMap("Audited")]
        [Validation(Required=false)]
        public bool? Audited { get; set; }

        [NameInMap("Identified")]
        [Validation(Required=false)]
        public bool? Identified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
