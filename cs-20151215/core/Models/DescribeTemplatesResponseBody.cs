// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeTemplatesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeTemplatesResponseBodyPageInfo : TeaModel {
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("templates")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("template_type")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            [NameInMap("template_with_hist_id")]
            [Validation(Required=false)]
            public string TemplateWithHistId { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
