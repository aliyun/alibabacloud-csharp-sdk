// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class SaveRTCStatsV2Request : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        [NameInMap("GeneralInfo")]
        [Validation(Required=false)]
        public string GeneralInfo { get; set; }

        [NameInMap("SenderReport")]
        [Validation(Required=false)]
        public string SenderReport { get; set; }

        [NameInMap("ReceiverReport")]
        [Validation(Required=false)]
        public string ReceiverReport { get; set; }

        [NameInMap("GoogAddress")]
        [Validation(Required=false)]
        public string GoogAddress { get; set; }

    }

}
