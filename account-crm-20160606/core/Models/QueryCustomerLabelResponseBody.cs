// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
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
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("LabelSeries")]
                [Validation(Required=false)]
                public string LabelSeries { get; set; }

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
