// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class CheckDatasetOssBucketCORSResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckDatasetOssBucketCORSResponseBodyData Data { get; set; }
        public class CheckDatasetOssBucketCORSResponseBodyData : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("OssBucketCORSConfigUrl")]
            [Validation(Required=false)]
            public string OssBucketCORSConfigUrl { get; set; }

            [NameInMap("SetOssBucketCORSFlag")]
            [Validation(Required=false)]
            public bool? SetOssBucketCORSFlag { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
