// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class FeedbackSessionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public FeedbackSessionResponseBodyData Data { get; set; }
        public class FeedbackSessionResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
