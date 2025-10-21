// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class AiModel : TeaModel {
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("inputSchema")]
        [Validation(Required=false)]
        public Schema InputSchema { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        [NameInMap("outputSchema")]
        [Validation(Required=false)]
        public Schema OutputSchema { get; set; }

    }

}
