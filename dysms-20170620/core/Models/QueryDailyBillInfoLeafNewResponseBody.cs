// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryDailyBillInfoLeafNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QueryDailyBillInfoLeafNewResponseBodyList List { get; set; }
        public class QueryDailyBillInfoLeafNewResponseBodyList : TeaModel {
            [NameInMap("DailyBillDetailInfoDTO")]
            [Validation(Required=false)]
            public List<QueryDailyBillInfoLeafNewResponseBodyListDailyBillDetailInfoDTO> DailyBillDetailInfoDTO { get; set; }
            public class QueryDailyBillInfoLeafNewResponseBodyListDailyBillDetailInfoDTO : TeaModel {
                [NameInMap("AddCount")]
                [Validation(Required=false)]
                public long? AddCount { get; set; }

                [NameInMap("AddDate")]
                [Validation(Required=false)]
                public string AddDate { get; set; }

                [NameInMap("AddUnit")]
                [Validation(Required=false)]
                public string AddUnit { get; set; }

                [NameInMap("BillAmount")]
                [Validation(Required=false)]
                public string BillAmount { get; set; }

                [NameInMap("DetailItemName")]
                [Validation(Required=false)]
                public string DetailItemName { get; set; }

                [NameInMap("SinglePrice")]
                [Validation(Required=false)]
                public string SinglePrice { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
