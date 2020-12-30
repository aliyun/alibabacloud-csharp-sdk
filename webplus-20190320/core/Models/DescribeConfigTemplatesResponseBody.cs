// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeConfigTemplatesResponseBody : TeaModel {
        [NameInMap("ConfigTemplates")]
        [Validation(Required=false)]
        public DescribeConfigTemplatesResponseBodyConfigTemplates ConfigTemplates { get; set; }
        public class DescribeConfigTemplatesResponseBodyConfigTemplates : TeaModel {
            [NameInMap("ConfigTemplate")]
            [Validation(Required=false)]
            public List<DescribeConfigTemplatesResponseBodyConfigTemplatesConfigTemplate> ConfigTemplate { get; set; }
            public class DescribeConfigTemplatesResponseBodyConfigTemplatesConfigTemplate : TeaModel {
                public string TemplateDescription { get; set; }
                public string AppName { get; set; }
                public long? UpdateTime { get; set; }
                public string StackId { get; set; }
                public string PkgVersionLabel { get; set; }
                public long? CreateTime { get; set; }
                public string AppId { get; set; }
                public string StackName { get; set; }
                public string PkgVersionId { get; set; }
                public string TemplateName { get; set; }
                public string TemplateId { get; set; }
            }
        };

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

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
