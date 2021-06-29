// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class CreateFilePredictRequest : TeaModel {
        [NameInMap("AlgorithmCode")]
        [Validation(Required=false)]
        public string AlgorithmCode { get; set; }

        [NameInMap("ResourceUrl")]
        [Validation(Required=false)]
        public string ResourceUrl { get; set; }

        [NameInMap("PushConfig")]
        [Validation(Required=false)]
        public string PushConfig { get; set; }

        [NameInMap("DecryptConfig")]
        [Validation(Required=false)]
        public string DecryptConfig { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OutputOss")]
        [Validation(Required=false)]
        public string OutputOss { get; set; }

        [NameInMap("OutputRegion")]
        [Validation(Required=false)]
        public string OutputRegion { get; set; }

    }

}
