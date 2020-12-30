// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDialogMessagesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DialogList")]
        [Validation(Required=false)]
        public List<DescribeDialogMessagesResponseBodyDialogList> DialogList { get; set; }
        public class DescribeDialogMessagesResponseBodyDialogList : TeaModel {
            [NameInMap("DialogKey")]
            [Validation(Required=false)]
            public string DialogKey { get; set; }

            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            [NameInMap("ID")]
            [Validation(Required=false)]
            public long? ID { get; set; }

        }

    }

}
