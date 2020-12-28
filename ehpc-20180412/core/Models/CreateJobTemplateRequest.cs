// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class CreateJobTemplateRequest : TeaModel {
        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RunasUser")]
        [Validation(Required=false)]
        public string RunasUser { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("PackagePath")]
        [Validation(Required=false)]
        public string PackagePath { get; set; }

        [NameInMap("StdoutRedirectPath")]
        [Validation(Required=false)]
        public string StdoutRedirectPath { get; set; }

        [NameInMap("StderrRedirectPath")]
        [Validation(Required=false)]
        public string StderrRedirectPath { get; set; }

        [NameInMap("ReRunable")]
        [Validation(Required=false)]
        public bool? ReRunable { get; set; }

        [NameInMap("ArrayRequest")]
        [Validation(Required=false)]
        public string ArrayRequest { get; set; }

        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
