// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDynamicImageJobResponseBody : TeaModel {
        [NameInMap("DynamicImageJob")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobResponseBodyDynamicImageJob DynamicImageJob { get; set; }
        public class SubmitDynamicImageJobResponseBodyDynamicImageJob : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
