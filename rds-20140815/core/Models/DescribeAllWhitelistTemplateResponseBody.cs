// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAllWhitelistTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAllWhitelistTemplateResponseBodyData Data { get; set; }
        public class DescribeAllWhitelistTemplateResponseBodyData : TeaModel {
            [NameInMap("CurrPageNumbers")]
            [Validation(Required=false)]
            public int? CurrPageNumbers { get; set; }

            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            [NameInMap("HasPrev")]
            [Validation(Required=false)]
            public bool? HasPrev { get; set; }

            [NameInMap("MaxRecordsPerPage")]
            [Validation(Required=false)]
            public int? MaxRecordsPerPage { get; set; }

            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<DescribeAllWhitelistTemplateResponseBodyDataTemplates> Templates { get; set; }
            public class DescribeAllWhitelistTemplateResponseBodyDataTemplates : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public string Ips { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public int? TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public int? UserId { get; set; }

            }

            [NameInMap("TotalPageNumbers")]
            [Validation(Required=false)]
            public int? TotalPageNumbers { get; set; }

            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public int? TotalRecords { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
