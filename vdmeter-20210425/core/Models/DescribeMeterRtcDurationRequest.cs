// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRtcDurationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        [NameInMap("ServiceArea")]
        [Validation(Required=false)]
        public string ServiceArea { get; set; }

        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

    }

}
