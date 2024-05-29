// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryReportDetailResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryReportDetailResponseBodyContent> Content { get; set; }
        public class QueryReportDetailResponseBodyContent : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Sort")]
            [Validation(Required=false)]
            public string Sort { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("reportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
