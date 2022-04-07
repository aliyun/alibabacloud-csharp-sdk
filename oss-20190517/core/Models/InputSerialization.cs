// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InputSerialization : TeaModel {
        [NameInMap("CSV")]
        [Validation(Required=false)]
        public CSVInput Csv { get; set; }

        [NameInMap("CompressionType")]
        [Validation(Required=false)]
        public string CompressionType { get; set; }

        [NameInMap("JSON")]
        [Validation(Required=false)]
        public JSONInput Json { get; set; }

    }

}
