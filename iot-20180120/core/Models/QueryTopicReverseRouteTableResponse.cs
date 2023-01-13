// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryTopicReverseRouteTableResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("SrcTopics")]
        [Validation(Required=true)]
        public QueryTopicReverseRouteTableResponseSrcTopics SrcTopics { get; set; }
        public class QueryTopicReverseRouteTableResponseSrcTopics : TeaModel {
            [NameInMap("Topic")]
            [Validation(Required=true)]
            public List<Dictionary<string, object>> Topic { get; set; }

        }

    }

}
