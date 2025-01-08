// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class RegisterAccountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;user api register&quot;</para>
        /// </summary>
        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
