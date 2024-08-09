// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeleteUdfArtifactResult : TeaModel {
        [NameInMap("deleteSuccess")]
        [Validation(Required=false)]
        public bool? DeleteSuccess { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("referencedClasses")]
        [Validation(Required=false)]
        public List<UdfClass> ReferencedClasses { get; set; }

    }

}
