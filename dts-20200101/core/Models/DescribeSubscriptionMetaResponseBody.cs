// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionMetaResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("SubscriptionMetaList")]
        [Validation(Required=false)]
        public List<DescribeSubscriptionMetaResponseBodySubscriptionMetaList> SubscriptionMetaList { get; set; }
        public class DescribeSubscriptionMetaResponseBodySubscriptionMetaList : TeaModel {
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public long? Checkpoint { get; set; }

            [NameInMap("DProxyUrl")]
            [Validation(Required=false)]
            public string DProxyUrl { get; set; }

            [NameInMap("DBList")]
            [Validation(Required=false)]
            public string DBList { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

    }

}
