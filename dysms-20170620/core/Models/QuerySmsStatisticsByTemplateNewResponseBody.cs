// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsStatisticsByTemplateNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QuerySmsStatisticsByTemplateNewResponseBodyList List { get; set; }
        public class QuerySmsStatisticsByTemplateNewResponseBodyList : TeaModel {
            [NameInMap("SmsStatisticsResponse")]
            [Validation(Required=false)]
            public List<QuerySmsStatisticsByTemplateNewResponseBodyListSmsStatisticsResponse> SmsStatisticsResponse { get; set; }
            public class QuerySmsStatisticsByTemplateNewResponseBodyListSmsStatisticsResponse : TeaModel {
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
