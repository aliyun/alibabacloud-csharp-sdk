// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetHelmChartUploadUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("UploadPolicy")]
        [Validation(Required=false)]
        public GetHelmChartUploadUrlResponseBodyUploadPolicy UploadPolicy { get; set; }
        public class GetHelmChartUploadUrlResponseBodyUploadPolicy : TeaModel {
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }
            [NameInMap("PathPrefix")]
            [Validation(Required=false)]
            public string PathPrefix { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
        };

    }

}
