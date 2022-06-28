// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class RecognizeVideoCastCrewListRequest : TeaModel {
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<RecognizeVideoCastCrewListRequestParams> Params { get; set; }
        public class RecognizeVideoCastCrewListRequestParams : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RegisterUrl")]
        [Validation(Required=false)]
        public string RegisterUrl { get; set; }

        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
