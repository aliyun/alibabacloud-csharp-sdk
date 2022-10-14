// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeVideoCastCrewListAdvanceRequest : TeaModel {
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<RecognizeVideoCastCrewListAdvanceRequestParams> Params { get; set; }
        public class RecognizeVideoCastCrewListAdvanceRequestParams : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RegisterUrl")]
        [Validation(Required=false)]
        public string RegisterUrl { get; set; }

        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public Stream VideoUrlObject { get; set; }

    }

}
