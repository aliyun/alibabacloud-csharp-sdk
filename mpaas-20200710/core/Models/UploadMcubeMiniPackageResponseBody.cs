// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class UploadMcubeMiniPackageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("UploadMiniPackageResult")]
        [Validation(Required=false)]
        public UploadMcubeMiniPackageResponseBodyUploadMiniPackageResult UploadMiniPackageResult { get; set; }
        public class UploadMcubeMiniPackageResponseBodyUploadMiniPackageResult : TeaModel {
            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("ReturnPackageResult")]
            [Validation(Required=false)]
            public UploadMcubeMiniPackageResponseBodyUploadMiniPackageResultReturnPackageResult ReturnPackageResult { get; set; }
            public class UploadMcubeMiniPackageResponseBodyUploadMiniPackageResultReturnPackageResult : TeaModel {
                [NameInMap("DebugUrl")]
                [Validation(Required=false)]
                public string DebugUrl { get; set; }

                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
