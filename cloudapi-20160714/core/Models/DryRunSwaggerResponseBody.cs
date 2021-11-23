// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DryRunSwaggerResponseBody : TeaModel {
        [NameInMap("Failed")]
        [Validation(Required=false)]
        public DryRunSwaggerResponseBodyFailed Failed { get; set; }
        public class DryRunSwaggerResponseBodyFailed : TeaModel {
            [NameInMap("ApiImportSwaggerFailed")]
            [Validation(Required=false)]
            public List<DryRunSwaggerResponseBodyFailedApiImportSwaggerFailed> ApiImportSwaggerFailed { get; set; }
            public class DryRunSwaggerResponseBodyFailedApiImportSwaggerFailed : TeaModel {
                public string ErrorMsg { get; set; }
                public string HttpMethod { get; set; }
                public string Path { get; set; }
            }
        };

        [NameInMap("GlobalCondition")]
        [Validation(Required=false)]
        public string GlobalCondition { get; set; }

        [NameInMap("ModelFailed")]
        [Validation(Required=false)]
        public DryRunSwaggerResponseBodyModelFailed ModelFailed { get; set; }
        public class DryRunSwaggerResponseBodyModelFailed : TeaModel {
            [NameInMap("ApiImportModelFailed")]
            [Validation(Required=false)]
            public List<DryRunSwaggerResponseBodyModelFailedApiImportModelFailed> ApiImportModelFailed { get; set; }
            public class DryRunSwaggerResponseBodyModelFailedApiImportModelFailed : TeaModel {
                public string ErrorMsg { get; set; }
                public string GroupId { get; set; }
                public string ModelName { get; set; }
            }
        };

        [NameInMap("ModelSuccess")]
        [Validation(Required=false)]
        public DryRunSwaggerResponseBodyModelSuccess ModelSuccess { get; set; }
        public class DryRunSwaggerResponseBodyModelSuccess : TeaModel {
            [NameInMap("ApiImportModelSuccess")]
            [Validation(Required=false)]
            public List<DryRunSwaggerResponseBodyModelSuccessApiImportModelSuccess> ApiImportModelSuccess { get; set; }
            public class DryRunSwaggerResponseBodyModelSuccessApiImportModelSuccess : TeaModel {
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
        public DryRunSwaggerResponseBodySuccess Success { get; set; }
        public class DryRunSwaggerResponseBodySuccess : TeaModel {
            [NameInMap("ApiDryRunSwaggerSuccess")]
            [Validation(Required=false)]
            public List<DryRunSwaggerResponseBodySuccessApiDryRunSwaggerSuccess> ApiDryRunSwaggerSuccess { get; set; }
            public class DryRunSwaggerResponseBodySuccessApiDryRunSwaggerSuccess : TeaModel {
                public string ApiOperation { get; set; }
                public string ApiSwagger { get; set; }
                public string ApiUid { get; set; }
                public string HttpMethod { get; set; }
                public string Path { get; set; }
            }
        };

    }

}
