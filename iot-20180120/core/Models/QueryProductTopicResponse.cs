// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductTopicResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryProductTopicResponseData Data { get; set; }
        public class QueryProductTopicResponseData : TeaModel {
            [NameInMap("ProductTopicInfo")]
            [Validation(Required=true)]
            public List<QueryProductTopicResponseDataProductTopicInfo> ProductTopicInfo { get; set; }
            public class QueryProductTopicResponseDataProductTopicInfo : TeaModel {
                public string ProductKey { get; set; }
                public string TopicShortName { get; set; }
                public string Operation { get; set; }
                public string Desc { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
