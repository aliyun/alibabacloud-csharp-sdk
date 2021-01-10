// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeantcodeAntcodeLsifreferencesResponseBody : TeaModel {
        [NameInMap("FileCount")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RefCount")]
        [Validation(Required=false)]
        public long? RefCount { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("RefList")]
        [Validation(Required=false)]
        public List<CreateLinkeantcodeAntcodeLsifreferencesResponseBodyRefList> RefList { get; set; }
        public class CreateLinkeantcodeAntcodeLsifreferencesResponseBodyRefList : TeaModel {
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

            [NameInMap("ReferenceChunks")]
            [Validation(Required=false)]
            public List<string> ReferenceChunks { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
