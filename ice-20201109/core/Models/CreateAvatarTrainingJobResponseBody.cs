// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateAvatarTrainingJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAvatarTrainingJobResponseBodyData Data { get; set; }
        public class CreateAvatarTrainingJobResponseBodyData : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
