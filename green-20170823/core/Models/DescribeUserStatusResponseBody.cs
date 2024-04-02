// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeUserStatusResponseBody : TeaModel {
        [NameInMap("AgreeChannel")]
        [Validation(Required=false)]
        public int? AgreeChannel { get; set; }

        [NameInMap("Buyed")]
        [Validation(Required=false)]
        public bool? Buyed { get; set; }

        [NameInMap("InDept")]
        [Validation(Required=false)]
        public bool? InDept { get; set; }

        [NameInMap("OpenApiBeginTime")]
        [Validation(Required=false)]
        public string OpenApiBeginTime { get; set; }

        [NameInMap("OpenApiUsed")]
        [Validation(Required=false)]
        public bool? OpenApiUsed { get; set; }

        [NameInMap("OssCheckStatus")]
        [Validation(Required=false)]
        public string OssCheckStatus { get; set; }

        [NameInMap("OssVideoSizeLimit")]
        [Validation(Required=false)]
        public int? OssVideoSizeLimit { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
