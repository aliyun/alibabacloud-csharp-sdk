// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListTagValueTrendResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("PidTagTrendList")]
        [Validation(Required=true)]
        public List<ListTagValueTrendResponsePidTagTrendList> PidTagTrendList { get; set; }
        public class ListTagValueTrendResponsePidTagTrendList : TeaModel {
            [NameInMap("PidTagName")]
            [Validation(Required=true)]
            public string PidTagName { get; set; }

            [NameInMap("PidTagValueList")]
            [Validation(Required=true)]
            public List<ListTagValueTrendResponsePidTagTrendListPidTagValueList> PidTagValueList { get; set; }
            public class ListTagValueTrendResponsePidTagTrendListPidTagValueList : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=true)]
                public long Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=true)]
                public string Value { get; set; }

            }

        }

    }

}
