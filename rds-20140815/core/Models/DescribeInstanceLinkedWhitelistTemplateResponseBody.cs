// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeInstanceLinkedWhitelistTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInstanceLinkedWhitelistTemplateResponseBodyData Data { get; set; }
        public class DescribeInstanceLinkedWhitelistTemplateResponseBodyData : TeaModel {
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<DescribeInstanceLinkedWhitelistTemplateResponseBodyDataTemplates> Templates { get; set; }
            public class DescribeInstanceLinkedWhitelistTemplateResponseBodyDataTemplates : TeaModel {
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
