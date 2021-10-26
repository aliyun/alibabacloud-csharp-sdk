// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginTemplatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public DescribePluginTemplatesResponseBodyTemplates Templates { get; set; }
        public class DescribePluginTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<DescribePluginTemplatesResponseBodyTemplatesTemplate> Template { get; set; }
            public class DescribePluginTemplatesResponseBodyTemplatesTemplate : TeaModel {
                public string Title { get; set; }
                public string DocumentAnchor { get; set; }
                public string Description { get; set; }
                public string DocumentId { get; set; }
                public string Sample { get; set; }
            }
        };

    }

}
