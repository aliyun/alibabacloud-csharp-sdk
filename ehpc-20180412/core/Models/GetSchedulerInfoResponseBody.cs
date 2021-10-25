// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetSchedulerInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchedInfo")]
        [Validation(Required=false)]
        public List<GetSchedulerInfoResponseBodySchedInfo> SchedInfo { get; set; }
        public class GetSchedulerInfoResponseBodySchedInfo : TeaModel {
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }

            [NameInMap("SchedName")]
            [Validation(Required=false)]
            public string SchedName { get; set; }

        }

    }

}
