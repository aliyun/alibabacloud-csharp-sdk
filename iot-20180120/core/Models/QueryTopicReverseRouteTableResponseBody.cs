// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryTopicReverseRouteTableResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SrcTopics")]
        [Validation(Required=false)]
        public QueryTopicReverseRouteTableResponseBodySrcTopics SrcTopics { get; set; }
        public class QueryTopicReverseRouteTableResponseBodySrcTopics : TeaModel {
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Topic { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
