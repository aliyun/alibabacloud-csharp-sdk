// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Image_detect20211221.Models
{
    public class GetMqConfigListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public GetMqConfigListResponseBodyResponse Response { get; set; }
        public class GetMqConfigListResponseBodyResponse : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMqConfigListResponseBodyResponseList> List { get; set; }
            public class GetMqConfigListResponseBodyResponseList : TeaModel {
                public string ConfigName { get; set; }
                public string GmtCreate { get; set; }
                public string MqAccessKey { get; set; }
                public string MqEndpoint { get; set; }
                public string MqGroupId { get; set; }
                public string MqTopic { get; set; }
            }
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
