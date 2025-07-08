// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsStatisticsNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QuerySmsStatisticsNewResponseBodyList> List { get; set; }
        public class QuerySmsStatisticsNewResponseBodyList : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            [NameInMap("DetailStsDate")]
            [Validation(Required=false)]
            public string DetailStsDate { get; set; }

            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("SendSuccessRate")]
            [Validation(Required=false)]
            public string SendSuccessRate { get; set; }

            [NameInMap("SendTotal")]
            [Validation(Required=false)]
            public long? SendTotal { get; set; }

            [NameInMap("SendTotalFail")]
            [Validation(Required=false)]
            public long? SendTotalFail { get; set; }

            [NameInMap("SendTotalSuccess")]
            [Validation(Required=false)]
            public long? SendTotalSuccess { get; set; }

            [NameInMap("SendTotalUnknown")]
            [Validation(Required=false)]
            public long? SendTotalUnknown { get; set; }

            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
