// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeMPURuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeMPURuleResponseBodyRules> Rules { get; set; }
        public class DescribeMPURuleResponseBodyRules : TeaModel {
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            [NameInMap("CropMode")]
            [Validation(Required=false)]
            public int? CropMode { get; set; }

            [NameInMap("CallBack")]
            [Validation(Required=false)]
            public string CallBack { get; set; }

            [NameInMap("PlayDomain")]
            [Validation(Required=false)]
            public string PlayDomain { get; set; }

            [NameInMap("ChannelPrefix")]
            [Validation(Required=false)]
            public string ChannelPrefix { get; set; }

            [NameInMap("BackgroudColor")]
            [Validation(Required=false)]
            public int? BackgroudColor { get; set; }

            [NameInMap("IsEnable")]
            [Validation(Required=false)]
            public int? IsEnable { get; set; }

            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<string> LayoutIds { get; set; }

            [NameInMap("TaskProfile")]
            [Validation(Required=false)]
            public string TaskProfile { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

        }

    }

}
