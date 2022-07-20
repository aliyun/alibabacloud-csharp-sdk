// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribePlayExperienceMetricDataRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BeginTs")]
        [Validation(Required=false)]
        public string BeginTs { get; set; }

        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public string EndTs { get; set; }

        [NameInMap("ExperienceLevel")]
        [Validation(Required=false)]
        public string ExperienceLevel { get; set; }

        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        [NameInMap("TerminalType")]
        [Validation(Required=false)]
        public string TerminalType { get; set; }

    }

}
