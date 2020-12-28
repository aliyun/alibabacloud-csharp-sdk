// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListJobTemplatesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<ListJobTemplatesResponseBodyTemplates> Templates { get; set; }
        public class ListJobTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("StdoutRedirectPath")]
            [Validation(Required=false)]
            public string StdoutRedirectPath { get; set; }

            [NameInMap("Variables")]
            [Validation(Required=false)]
            public string Variables { get; set; }

            [NameInMap("CommandLine")]
            [Validation(Required=false)]
            public string CommandLine { get; set; }

            [NameInMap("PackagePath")]
            [Validation(Required=false)]
            public string PackagePath { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("ReRunable")]
            [Validation(Required=false)]
            public bool? ReRunable { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ArrayRequest")]
            [Validation(Required=false)]
            public string ArrayRequest { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("StderrRedirectPath")]
            [Validation(Required=false)]
            public string StderrRedirectPath { get; set; }

            [NameInMap("RunasUser")]
            [Validation(Required=false)]
            public string RunasUser { get; set; }

        }

    }

}
