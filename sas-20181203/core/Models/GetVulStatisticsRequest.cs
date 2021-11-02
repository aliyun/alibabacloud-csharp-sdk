// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVulStatisticsRequest : TeaModel {
        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public string GroupIdList { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public string TypeList { get; set; }

    }

}
