// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceVerifyResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=true)]
        public DescribeFaceVerifyResponseResultObject ResultObject { get; set; }
        public class DescribeFaceVerifyResponseResultObject : TeaModel {
            [NameInMap("SubCode")]
            [Validation(Required=true)]
            public string SubCode { get; set; }
            [NameInMap("MaterialInfo")]
            [Validation(Required=true)]
            public string MaterialInfo { get; set; }
            [NameInMap("IdentityInfo")]
            [Validation(Required=true)]
            public string IdentityInfo { get; set; }
            [NameInMap("DeviceToken")]
            [Validation(Required=true)]
            public string DeviceToken { get; set; }
            [NameInMap("Passed")]
            [Validation(Required=true)]
            public string Passed { get; set; }
        };

    }

}
