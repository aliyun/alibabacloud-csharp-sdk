// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySaasRecordNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QuerySaasRecordNewResponseBodyList List { get; set; }
        public class QuerySaasRecordNewResponseBodyList : TeaModel {
            [NameInMap("SaasRecord")]
            [Validation(Required=false)]
            public List<QuerySaasRecordNewResponseBodyListSaasRecord> SaasRecord { get; set; }
            public class QuerySaasRecordNewResponseBodyListSaasRecord : TeaModel {
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("DetailPkId")]
                [Validation(Required=false)]
                public long? DetailPkId { get; set; }

                [NameInMap("IndexCol")]
                [Validation(Required=false)]
                public string IndexCol { get; set; }

                [NameInMap("LastDealDate")]
                [Validation(Required=false)]
                public string LastDealDate { get; set; }

                [NameInMap("RecordBizExpireDate")]
                [Validation(Required=false)]
                public string RecordBizExpireDate { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("ResultDesc")]
                [Validation(Required=false)]
                public string ResultDesc { get; set; }

                [NameInMap("SaasContent")]
                [Validation(Required=false)]
                public string SaasContent { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
