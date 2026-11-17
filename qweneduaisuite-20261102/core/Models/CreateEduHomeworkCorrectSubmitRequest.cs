// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduHomeworkCorrectSubmitRequest : TeaModel {
        [NameInMap("dewarp")]
        [Validation(Required=false)]
        public bool? Dewarp { get; set; }

        [NameInMap("imageBase64")]
        [Validation(Required=false)]
        public string ImageBase64 { get; set; }

        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
