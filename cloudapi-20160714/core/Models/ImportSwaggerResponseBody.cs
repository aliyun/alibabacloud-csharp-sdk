// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportSwaggerResponseBody : TeaModel {
        [NameInMap("Failed")]
        [Validation(Required=false)]
        public ImportSwaggerResponseBodyFailed Failed { get; set; }
        public class ImportSwaggerResponseBodyFailed : TeaModel {
            [NameInMap("ApiImportSwaggerFailed")]
            [Validation(Required=false)]
            public List<ImportSwaggerResponseBodyFailedApiImportSwaggerFailed> ApiImportSwaggerFailed { get; set; }
            public class ImportSwaggerResponseBodyFailedApiImportSwaggerFailed : TeaModel {
                public string ErrorMsg { get; set; }
                public string HttpMethod { get; set; }
                public string Path { get; set; }
            }
        };

        [NameInMap("ModelFailed")]
        [Validation(Required=false)]
        public ImportSwaggerResponseBodyModelFailed ModelFailed { get; set; }
        public class ImportSwaggerResponseBodyModelFailed : TeaModel {
            [NameInMap("ApiImportModelFailed")]
            [Validation(Required=false)]
            public List<ImportSwaggerResponseBodyModelFailedApiImportModelFailed> ApiImportModelFailed { get; set; }
            public class ImportSwaggerResponseBodyModelFailedApiImportModelFailed : TeaModel {
                public string ErrorMsg { get; set; }
                public string GroupId { get; set; }
                public string ModelName { get; set; }
            }
        };

        [NameInMap("ModelSuccess")]
        [Validation(Required=false)]
        public ImportSwaggerResponseBodyModelSuccess ModelSuccess { get; set; }
        public class ImportSwaggerResponseBodyModelSuccess : TeaModel {
            [NameInMap("ApiImportModelSuccess")]
            [Validation(Required=false)]
            public List<ImportSwaggerResponseBodyModelSuccessApiImportModelSuccess> ApiImportModelSuccess { get; set; }
            public class ImportSwaggerResponseBodyModelSuccessApiImportModelSuccess : TeaModel {
                public string GroupId { get; set; }
                public string ModelName { get; set; }
                public string ModelOperation { get; set; }
                public string ModelUid { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public ImportSwaggerResponseBodySuccess Success { get; set; }
        public class ImportSwaggerResponseBodySuccess : TeaModel {
            [NameInMap("ApiImportSwaggerSuccess")]
            [Validation(Required=false)]
            public List<ImportSwaggerResponseBodySuccessApiImportSwaggerSuccess> ApiImportSwaggerSuccess { get; set; }
            public class ImportSwaggerResponseBodySuccessApiImportSwaggerSuccess : TeaModel {
                public string ApiOperation { get; set; }
                public string ApiUid { get; set; }
                public string HttpMethod { get; set; }
                public string Path { get; set; }
            }
        };

    }

}
