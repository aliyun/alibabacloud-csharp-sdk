// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectInfraredLivingFaceAdvanceRequest : TeaModel {
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DetectInfraredLivingFaceAdvanceRequestTasks> Tasks { get; set; }
        public class DetectInfraredLivingFaceAdvanceRequestTasks : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public Stream ImageURLObject { get; set; }

        }

    }

}
