// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountLabel20200315.Models
{
    public class QueryCustomerLabelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomerLabelResponseBodyData Data { get; set; }
        public class QueryCustomerLabelResponseBodyData : TeaModel {
            [NameInMap("CustomerLabel")]
            [Validation(Required=false)]
            public List<QueryCustomerLabelResponseBodyDataCustomerLabel> CustomerLabel { get; set; }
            public class QueryCustomerLabelResponseBodyDataCustomerLabel : TeaModel {
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("EndTimeStr")]
                [Validation(Required=false)]
                public string EndTimeStr { get; set; }

                [NameInMap("GmtCreatedStr")]
                [Validation(Required=false)]
                public string GmtCreatedStr { get; set; }

                [NameInMap("GmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("LabelSeries")]
                [Validation(Required=false)]
                public string LabelSeries { get; set; }

                [NameInMap("StartTimeStr")]
                [Validation(Required=false)]
                public string StartTimeStr { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
