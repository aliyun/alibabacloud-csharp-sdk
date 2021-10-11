// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi20210930.Models
{
    public class CreateAiStoreUserTaskRequest : TeaModel {
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("BucketKeyPrefix")]
        [Validation(Required=false)]
        public string BucketKeyPrefix { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ParamInfo")]
        [Validation(Required=false)]
        public string ParamInfo { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ReceiveConfig")]
        [Validation(Required=false)]
        public string ReceiveConfig { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
