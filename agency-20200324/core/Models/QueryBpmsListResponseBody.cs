// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20200324.Models
{
    public class QueryBpmsListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public QueryBpmsListResponseBodyList List { get; set; }
        public class QueryBpmsListResponseBodyList : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryBpmsListResponseBodyListList> List { get; set; }
            public class QueryBpmsListResponseBodyListList : TeaModel {
                [NameInMap("ApplyRemarks")]
                [Validation(Required=false)]
                public string ApplyRemarks { get; set; }

                [NameInMap("ApplyTime")]
                [Validation(Required=false)]
                public string ApplyTime { get; set; }

                [NameInMap("AuditStatus")]
                [Validation(Required=false)]
                public int? AuditStatus { get; set; }

                [NameInMap("CustomerName")]
                [Validation(Required=false)]
                public string CustomerName { get; set; }

                [NameInMap("CustomerRptType")]
                [Validation(Required=false)]
                public int? CustomerRptType { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("PartnerPk")]
                [Validation(Required=false)]
                public long? PartnerPk { get; set; }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
