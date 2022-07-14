// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ImAuditResponseBody : TeaModel {
        [NameInMap("ImageQuotaExceed")]
        [Validation(Required=false)]
        public bool? ImageQuotaExceed { get; set; }

        [NameInMap("ImageResults")]
        [Validation(Required=false)]
        public ImAuditResponseBodyImageResults ImageResults { get; set; }
        public class ImAuditResponseBodyImageResults : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ImAuditResponseBodyImageResultsResult> Result { get; set; }
            public class ImAuditResponseBodyImageResultsResult : TeaModel {
                public long? Code { get; set; }
                public string DataId { get; set; }
                public Dictionary<string, string> Extras { get; set; }
                public string Msg { get; set; }
                public List<ImAuditResponseBodyImageResultsResultResults> Results { get; set; }
                public class ImAuditResponseBodyImageResultsResultResults : TeaModel {
                    public string Label { get; set; }
                    public double? Rate { get; set; }
                    public string Scene { get; set; }
                    public string Suggestion { get; set; }
                }
                public string TaskId { get; set; }
                public string Url { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TextQuotaExceed")]
        [Validation(Required=false)]
        public bool? TextQuotaExceed { get; set; }

        [NameInMap("TextResults")]
        [Validation(Required=false)]
        public ImAuditResponseBodyTextResults TextResults { get; set; }
        public class ImAuditResponseBodyTextResults : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ImAuditResponseBodyTextResultsResult> Result { get; set; }
            public class ImAuditResponseBodyTextResultsResult : TeaModel {
                public long? Code { get; set; }
                public string Content { get; set; }
                public string DataId { get; set; }
                public string Msg { get; set; }
                public List<ImAuditResponseBodyTextResultsResultResults> Results { get; set; }
                public class ImAuditResponseBodyTextResultsResultResults : TeaModel {
                    public List<ImAuditResponseBodyTextResultsResultResultsDetails> Details { get; set; }
                    public class ImAuditResponseBodyTextResultsResultResultsDetails : TeaModel {
                        public string Label { get; set; }
                    }
                    public string Label { get; set; }
                    public double? Rate { get; set; }
                    public string Scene { get; set; }
                    public string Suggestion { get; set; }
                }
                public string TaskId { get; set; }
            }
        };

    }

}
