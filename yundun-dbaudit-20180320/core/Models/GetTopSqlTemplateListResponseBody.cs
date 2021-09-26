// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetTopSqlTemplateListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateList")]
        [Validation(Required=false)]
        public List<GetTopSqlTemplateListResponseBodyTemplateList> TemplateList { get; set; }
        public class GetTopSqlTemplateListResponseBodyTemplateList : TeaModel {
            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            [NameInMap("ExecCostUS")]
            [Validation(Required=false)]
            public string ExecCostUS { get; set; }

            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public string AffectRows { get; set; }

            [NameInMap("ExecCostUSMean")]
            [Validation(Required=false)]
            public string ExecCostUSMean { get; set; }

            [NameInMap("LastCaptureTime")]
            [Validation(Required=false)]
            public string LastCaptureTime { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("CaptureCount")]
            [Validation(Required=false)]
            public string CaptureCount { get; set; }

        }

    }

}
