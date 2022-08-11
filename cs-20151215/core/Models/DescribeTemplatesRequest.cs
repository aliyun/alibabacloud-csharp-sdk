// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplatesRequest : TeaModel {
        [NameInMap("page_num")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
