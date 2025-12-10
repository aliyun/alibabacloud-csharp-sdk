// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetNodeInputSchemaResponseBody : TeaModel {
        [NameInMap("ColNames")]
        [Validation(Required=false)]
        public List<string> ColNames { get; set; }

        [NameInMap("ColTypes")]
        [Validation(Required=false)]
        public List<string> ColTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CEB07647-8A5D-56F1-8B99-361BCF51402F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
