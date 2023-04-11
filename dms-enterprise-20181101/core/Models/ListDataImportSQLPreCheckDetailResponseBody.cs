// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataImportSQLPreCheckDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PreCheckSQLDetailList")]
        [Validation(Required=false)]
        public List<ListDataImportSQLPreCheckDetailResponseBodyPreCheckSQLDetailList> PreCheckSQLDetailList { get; set; }
        public class ListDataImportSQLPreCheckDetailResponseBodyPreCheckSQLDetailList : TeaModel {
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public long? SqlId { get; set; }

            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
