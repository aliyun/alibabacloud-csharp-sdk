// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListCorpMetricsRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=true)]
        public string CorpId { get; set; }

        [NameInMap("TagCode")]
        [Validation(Required=true)]
        public string TagCode { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public string EndTime { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public string PageSize { get; set; }

        [NameInMap("UserGroupList")]
        [Validation(Required=false)]
        public string UserGroupList { get; set; }

        [NameInMap("DeviceGroupList")]
        [Validation(Required=false)]
        public string DeviceGroupList { get; set; }

        [NameInMap("DeviceIdList")]
        [Validation(Required=false)]
        public string DeviceIdList { get; set; }

    }

}
