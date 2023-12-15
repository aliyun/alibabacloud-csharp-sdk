// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListCorpMetricsStatisticRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("DeviceGroupList")]
        [Validation(Required=false)]
        public Dictionary<string, object> DeviceGroupList { get; set; }

        [NameInMap("DeviceIdList")]
        [Validation(Required=false)]
        public Dictionary<string, object> DeviceIdList { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("QualitScore")]
        [Validation(Required=false)]
        public string QualitScore { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TagCode")]
        [Validation(Required=false)]
        public string TagCode { get; set; }

        [NameInMap("UserGroupList")]
        [Validation(Required=false)]
        public Dictionary<string, object> UserGroupList { get; set; }

    }

}
