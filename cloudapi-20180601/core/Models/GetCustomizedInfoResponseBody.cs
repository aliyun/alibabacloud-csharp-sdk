// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class GetCustomizedInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SdkDemos")]
        [Validation(Required=false)]
        public GetCustomizedInfoResponseBodySdkDemos SdkDemos { get; set; }
        public class GetCustomizedInfoResponseBodySdkDemos : TeaModel {
            [NameInMap("SdkDemo")]
            [Validation(Required=false)]
            public List<GetCustomizedInfoResponseBodySdkDemosSdkDemo> SdkDemo { get; set; }
            public class GetCustomizedInfoResponseBodySdkDemosSdkDemo : TeaModel {
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
