// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class ResetCustomizedResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SdkDemos")]
        [Validation(Required=false)]
        public ResetCustomizedResponseBodySdkDemos SdkDemos { get; set; }
        public class ResetCustomizedResponseBodySdkDemos : TeaModel {
            [NameInMap("SdkDemo")]
            [Validation(Required=false)]
            public List<ResetCustomizedResponseBodySdkDemosSdkDemo> SdkDemo { get; set; }
            public class ResetCustomizedResponseBodySdkDemosSdkDemo : TeaModel {
                [NameInMap("CallDemo")]
                [Validation(Required=false)]
                public string CallDemo { get; set; }

                [NameInMap("IdeKey")]
                [Validation(Required=false)]
                public string IdeKey { get; set; }

            }

        }

    }

}
