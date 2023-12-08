// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeConfigHistoryResponseBody : TeaModel {
        [NameInMap("ConfigHistoryItems")]
        [Validation(Required=false)]
        public List<DescribeConfigHistoryResponseBodyConfigHistoryItems> ConfigHistoryItems { get; set; }
        public class DescribeConfigHistoryResponseBodyConfigHistoryItems : TeaModel {
            [NameInMap("ChangeId")]
            [Validation(Required=false)]
            public string ChangeId { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
