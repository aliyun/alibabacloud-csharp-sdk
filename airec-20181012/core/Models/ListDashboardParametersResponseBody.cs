// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListDashboardParametersResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDashboardParametersResponseBodyResult Result { get; set; }
        public class ListDashboardParametersResponseBodyResult : TeaModel {
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public List<string> SceneId { get; set; }
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public List<string> TraceId { get; set; }
        };

    }

}
