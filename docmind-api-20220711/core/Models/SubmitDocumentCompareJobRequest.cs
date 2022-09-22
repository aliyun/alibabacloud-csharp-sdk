// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitDocumentCompareJobRequest : TeaModel {
        [NameInMap("CompareFileName")]
        [Validation(Required=false)]
        public string CompareFileName { get; set; }

        [NameInMap("CompareFileUrl")]
        [Validation(Required=false)]
        public string CompareFileUrl { get; set; }

        [NameInMap("OriginFileName")]
        [Validation(Required=false)]
        public string OriginFileName { get; set; }

        [NameInMap("OriginFileUrl")]
        [Validation(Required=false)]
        public string OriginFileUrl { get; set; }

    }

}
