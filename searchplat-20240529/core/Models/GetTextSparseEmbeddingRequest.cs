// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetTextSparseEmbeddingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public List<string> Input { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("input_type")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        [NameInMap("return_token")]
        [Validation(Required=false)]
        public bool? ReturnToken { get; set; }

    }

}
