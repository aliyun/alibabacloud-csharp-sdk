// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRdsResourceSettingsResponseBody : TeaModel {
        [NameInMap("RdsInstanceResourceSettings")]
        [Validation(Required=false)]
        public DescribeRdsResourceSettingsResponseBodyRdsInstanceResourceSettings RdsInstanceResourceSettings { get; set; }
        public class DescribeRdsResourceSettingsResponseBodyRdsInstanceResourceSettings : TeaModel {
            [NameInMap("RdsInstanceResourceSetting")]
            [Validation(Required=false)]
            public List<DescribeRdsResourceSettingsResponseBodyRdsInstanceResourceSettingsRdsInstanceResourceSetting> RdsInstanceResourceSetting { get; set; }
            public class DescribeRdsResourceSettingsResponseBodyRdsInstanceResourceSettingsRdsInstanceResourceSetting : TeaModel {
                public string EndDate { get; set; }
                public string IsTop { get; set; }
                public string NoticeBarContent { get; set; }
                public string PoppedUpButtonText { get; set; }
                public string PoppedUpButtonType { get; set; }
                public string PoppedUpButtonUrl { get; set; }
                public string PoppedUpContent { get; set; }
                public string ResourceNiche { get; set; }
                public string StartDate { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
