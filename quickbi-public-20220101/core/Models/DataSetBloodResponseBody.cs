// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DataSetBloodResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DataSetBloodResponseBodyResult> Result { get; set; }
        public class DataSetBloodResponseBodyResult : TeaModel {
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            [NameInMap("WorksType")]
            [Validation(Required=false)]
            public string WorksType { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
