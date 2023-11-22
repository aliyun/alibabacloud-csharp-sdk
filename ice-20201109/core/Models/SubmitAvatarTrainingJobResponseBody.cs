// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAvatarTrainingJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitAvatarTrainingJobResponseBodyData Data { get; set; }
        public class SubmitAvatarTrainingJobResponseBodyData : TeaModel {
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
