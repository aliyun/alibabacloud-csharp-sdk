// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class WorkspaceSpec : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CodeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        [NameInMap("IsGuaranteedValid")]
        [Validation(Required=false)]
        public bool? IsGuaranteedValid { get; set; }

        [NameInMap("IsOverSoldValid")]
        [Validation(Required=false)]
        public bool? IsOverSoldValid { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public ResourceAmount Spec { get; set; }

        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

    }

}
