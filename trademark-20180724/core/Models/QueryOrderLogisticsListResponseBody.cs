// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryOrderLogisticsListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryOrderLogisticsListResponseBodyData> Data { get; set; }
        public class QueryOrderLogisticsListResponseBodyData : TeaModel {
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("FileIdentifier")]
            [Validation(Required=false)]
            public string FileIdentifier { get; set; }

            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("LogisticsNo")]
            [Validation(Required=false)]
            public string LogisticsNo { get; set; }

            [NameInMap("ProduceOrderId")]
            [Validation(Required=false)]
            public string ProduceOrderId { get; set; }

            [NameInMap("TmIcon")]
            [Validation(Required=false)]
            public string TmIcon { get; set; }

            [NameInMap("TmName")]
            [Validation(Required=false)]
            public string TmName { get; set; }

            [NameInMap("TmNumber")]
            [Validation(Required=false)]
            public string TmNumber { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
