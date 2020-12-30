// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribePublicConfigTemplatesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PublicConfigTemplates")]
        [Validation(Required=false)]
        public DescribePublicConfigTemplatesResponseBodyPublicConfigTemplates PublicConfigTemplates { get; set; }
        public class DescribePublicConfigTemplatesResponseBodyPublicConfigTemplates : TeaModel {
            [NameInMap("PublicConfigTemplate")]
            [Validation(Required=false)]
            public List<DescribePublicConfigTemplatesResponseBodyPublicConfigTemplatesPublicConfigTemplate> PublicConfigTemplate { get; set; }
            public class DescribePublicConfigTemplatesResponseBodyPublicConfigTemplatesPublicConfigTemplate : TeaModel {
                public string TemplateDescription { get; set; }
                public long? UpdateTime { get; set; }
                public string StackId { get; set; }
                public string TemplateLogo { get; set; }
                public long? CreateTime { get; set; }
                public string PackageSource { get; set; }
                public string StackName { get; set; }
                public string TemplateName { get; set; }
                public string CategoryName { get; set; }
                public string TemplateId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
