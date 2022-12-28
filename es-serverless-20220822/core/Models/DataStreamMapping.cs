/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20220822.Models
{
    public class DataStreamMapping : TeaModel {
        [NameInMap("caseSensitive")]
        [Validation(Required=false)]
        public bool? CaseSensitive { get; set; }

        [NameInMap("docValues")]
        [Validation(Required=false)]
        public bool? DocValues { get; set; }

        [NameInMap("index")]
        [Validation(Required=false)]
        public bool? Index { get; set; }

        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public List<DataStreamMapping> Properties { get; set; }

        [NameInMap("tokenizeOnChars")]
        [Validation(Required=false)]
        public List<string> TokenizeOnChars { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
