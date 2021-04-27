// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateTopicRouteTableResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsAllSucceed")]
        [Validation(Required=false)]
        public bool? IsAllSucceed { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("FailureTopics")]
        [Validation(Required=false)]
        public CreateTopicRouteTableResponseBodyFailureTopics FailureTopics { get; set; }
        public class CreateTopicRouteTableResponseBodyFailureTopics : TeaModel {
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public List<string> Topic { get; set; }
        };

    }

}
