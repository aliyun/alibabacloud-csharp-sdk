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
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("IsTop")]
                [Validation(Required=false)]
                public string IsTop { get; set; }

                [NameInMap("NoticeBarContent")]
                [Validation(Required=false)]
                public string NoticeBarContent { get; set; }

                [NameInMap("PoppedUpButtonText")]
                [Validation(Required=false)]
                public string PoppedUpButtonText { get; set; }

                [NameInMap("PoppedUpButtonType")]
                [Validation(Required=false)]
                public string PoppedUpButtonType { get; set; }

                [NameInMap("PoppedUpButtonUrl")]
                [Validation(Required=false)]
                public string PoppedUpButtonUrl { get; set; }

                [NameInMap("PoppedUpContent")]
                [Validation(Required=false)]
                public string PoppedUpContent { get; set; }

                [NameInMap("ResourceNiche")]
                [Validation(Required=false)]
                public string ResourceNiche { get; set; }

                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
