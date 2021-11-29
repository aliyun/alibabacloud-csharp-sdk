// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListFCTriggerResponseBody : TeaModel {
        [NameInMap("FCTriggers")]
        [Validation(Required=false)]
        public List<ListFCTriggerResponseBodyFCTriggers> FCTriggers { get; set; }
        public class ListFCTriggerResponseBodyFCTriggers : TeaModel {
            [NameInMap("EventMetaName")]
            [Validation(Required=false)]
            public string EventMetaName { get; set; }

            [NameInMap("EventMetaVersion")]
            [Validation(Required=false)]
            public string EventMetaVersion { get; set; }

            [NameInMap("Notes")]
            [Validation(Required=false)]
            public string Notes { get; set; }

            [NameInMap("RoleARN")]
            [Validation(Required=false)]
            public string RoleARN { get; set; }

            [NameInMap("SourceArn")]
            [Validation(Required=false)]
            public string SourceArn { get; set; }

            [NameInMap("TriggerARN")]
            [Validation(Required=false)]
            public string TriggerARN { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
