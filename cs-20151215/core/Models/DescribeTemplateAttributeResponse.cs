// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplateAttributeResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribeTemplateAttributeResponseBody> Body { get; set; }
        public class DescribeTemplateAttributeResponseBody : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("template_type")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("template_with_hist_id")]
            [Validation(Required=false)]
            public string TemplateWithHistId { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
