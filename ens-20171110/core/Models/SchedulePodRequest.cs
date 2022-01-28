// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SchedulePodRequest : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("AreaCodes")]
        [Validation(Required=false)]
        public string AreaCodes { get; set; }

        [NameInMap("GroupUuid")]
        [Validation(Required=false)]
        public string GroupUuid { get; set; }

        [NameInMap("Isps")]
        [Validation(Required=false)]
        public string Isps { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        [NameInMap("Requirements")]
        [Validation(Required=false)]
        public string Requirements { get; set; }

        [NameInMap("ResourceAttribute")]
        [Validation(Required=false)]
        public string ResourceAttribute { get; set; }

        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public string Tenant { get; set; }

        [NameInMap("WorkloadUuid")]
        [Validation(Required=false)]
        public string WorkloadUuid { get; set; }

    }

}
