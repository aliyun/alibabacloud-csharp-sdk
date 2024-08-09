// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UpdateUdfArtifactResult : TeaModel {
        [NameInMap("collidingClasses")]
        [Validation(Required=false)]
        public List<UdfClass> CollidingClasses { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("missingClasses")]
        [Validation(Required=false)]
        public List<UdfClass> MissingClasses { get; set; }

        [NameInMap("udfArtifact")]
        [Validation(Required=false)]
        public UdfArtifact UdfArtifact { get; set; }

        [NameInMap("updateSuccess")]
        [Validation(Required=false)]
        public bool? UpdateSuccess { get; set; }

    }

}
