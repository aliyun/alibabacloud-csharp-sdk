// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectInfraredLivingFaceRequest : TeaModel {
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DetectInfraredLivingFaceRequestTasks> Tasks { get; set; }
        public class DetectInfraredLivingFaceRequestTasks : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

    }

}
