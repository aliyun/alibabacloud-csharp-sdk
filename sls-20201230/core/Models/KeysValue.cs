// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class KeysValue : TeaModel {
        /// <summary>
        /// Specifies whether to enable case sensitivity. This parameter is required only when **type** is set to **text**. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("caseSensitive")]
        [Validation(Required=false)]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Specifies whether to include Chinese characters. This parameter is required only when **type** is set to **text**. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// The data type of the field value. Valid values: text, json, double, and long.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The alias of the field.
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// The delimiters that are used to split text.
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public List<string> Token { get; set; }

        /// <summary>
        /// Specifies whether to turn on Enable Analytics for the field.
        /// </summary>
        [NameInMap("doc_value")]
        [Validation(Required=false)]
        public bool? DocValue { get; set; }

    }

}
