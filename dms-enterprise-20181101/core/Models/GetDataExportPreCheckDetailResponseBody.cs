// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataExportPreCheckDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public GetDataExportPreCheckDetailResponseBodyPreCheckResult PreCheckResult { get; set; }
        public class GetDataExportPreCheckDetailResponseBodyPreCheckResult : TeaModel {
            [NameInMap("IgnoreAffectRows")]
            [Validation(Required=false)]
            public bool? IgnoreAffectRows { get; set; }

            [NameInMap("PreCheckDetailList")]
            [Validation(Required=false)]
            public GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailList PreCheckDetailList { get; set; }
            public class GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailList : TeaModel {
                [NameInMap("PreCheckDetailList")]
                [Validation(Required=false)]
                public List<GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailListPreCheckDetailList> PreCheckDetailList { get; set; }
                public class GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailListPreCheckDetailList : TeaModel {
                    [NameInMap("AffectRows")]
                    [Validation(Required=false)]
                    public long? AffectRows { get; set; }

                    [NameInMap("SQL")]
                    [Validation(Required=false)]
                    public string SQL { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
