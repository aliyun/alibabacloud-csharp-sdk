// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetTextEmbeddingRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public List<string> Input { get; set; }

        [NameInMap("input_type")]
        [Validation(Required=false)]
        public string InputType { get; set; }

    }

}
