// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class CreateVideoSummaryTaskRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=true)]
        public string CorpId { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=true)]
        public string DeviceId { get; set; }

        [NameInMap("StartTimeStamp")]
        [Validation(Required=true)]
        public long StartTimeStamp { get; set; }

        [NameInMap("EndTimeStamp")]
        [Validation(Required=true)]
        public long EndTimeStamp { get; set; }

        [NameInMap("OptionList")]
        [Validation(Required=false)]
        public string OptionList { get; set; }

        [NameInMap("LiveVideoSummary")]
        [Validation(Required=false)]
        public string LiveVideoSummary { get; set; }

    }

}
