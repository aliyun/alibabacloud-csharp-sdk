// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExportHasInspectPluginResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ExportHasInspectPluginResponseBodyResultContent ResultContent { get; set; }
        public class ExportHasInspectPluginResponseBodyResultContent : TeaModel {
            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }
            [NameInMap("Sha256Sign")]
            [Validation(Required=false)]
            public string Sha256Sign { get; set; }
            [NameInMap("SignContent")]
            [Validation(Required=false)]
            public ExportHasInspectPluginResponseBodyResultContentSignContent SignContent { get; set; }
            public class ExportHasInspectPluginResponseBodyResultContentSignContent : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("ExportTime")]
                [Validation(Required=false)]
                public string ExportTime { get; set; }

            }
        };

    }

}
