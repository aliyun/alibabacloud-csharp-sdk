// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListJobTemplatesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public ListJobTemplatesResponseBodyTemplates Templates { get; set; }
        public class ListJobTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("JobTemplates")]
            [Validation(Required=false)]
            public List<ListJobTemplatesResponseBodyTemplatesJobTemplates> JobTemplates { get; set; }
            public class ListJobTemplatesResponseBodyTemplatesJobTemplates : TeaModel {
                public int? Task { get; set; }
                public string Variables { get; set; }
                public string CommandLine { get; set; }
                public string Queue { get; set; }
                public int? Priority { get; set; }
                public string Mem { get; set; }
                public int? Thread { get; set; }
                public string ArrayRequest { get; set; }
                public string StderrRedirectPath { get; set; }
                public int? Node { get; set; }
                public string StdoutRedirectPath { get; set; }
                public int? Gpu { get; set; }
                public string PackagePath { get; set; }
                public string ClockTime { get; set; }
                public bool? ReRunable { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
                public string RunasUser { get; set; }
            }
        };

    }

}
