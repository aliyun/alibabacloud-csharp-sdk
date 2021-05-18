// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityResultRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TouchStartTime")]
        [Validation(Required=false)]
        public string TouchStartTime { get; set; }

        [NameInMap("TouchEndTime")]
        [Validation(Required=false)]
        public string TouchEndTime { get; set; }

        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        [NameInMap("HitStatus")]
        [Validation(Required=false)]
        public int? HitStatus { get; set; }

        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public List<int?> GroupIds { get; set; }

        [NameInMap("QualityRuleIds")]
        [Validation(Required=false)]
        public List<int?> QualityRuleIds { get; set; }

        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public List<int?> ProjectIds { get; set; }

    }

}
