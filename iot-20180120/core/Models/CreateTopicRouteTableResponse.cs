// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateTopicRouteTableResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("IsAllSucceed")]
        [Validation(Required=true)]
        public bool? IsAllSucceed { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("FailureTopics")]
        [Validation(Required=true)]
        public CreateTopicRouteTableResponseFailureTopics FailureTopics { get; set; }
        public class CreateTopicRouteTableResponseFailureTopics : TeaModel {
            [NameInMap("Topic")]
            [Validation(Required=true)]
            public List<string> Topic { get; set; }
        };

    }

}
