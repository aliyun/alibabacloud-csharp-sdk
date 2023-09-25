// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20160801.Models
{
    public class DescribeSubscriptionObjectModifyStatusResponseBody : TeaModel {
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public DescribeSubscriptionObjectModifyStatusResponseBodyDetail Detail { get; set; }
        public class DescribeSubscriptionObjectModifyStatusResponseBodyDetail : TeaModel {
            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public List<DescribeSubscriptionObjectModifyStatusResponseBodyDetailCheckItem> CheckItem { get; set; }
            public class DescribeSubscriptionObjectModifyStatusResponseBodyDetailCheckItem : TeaModel {
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public string CheckStatus { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

            }

        }

        [NameInMap("Percent")]
        [Validation(Required=false)]
        public string Percent { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
