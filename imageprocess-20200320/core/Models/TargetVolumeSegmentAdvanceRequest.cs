// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class TargetVolumeSegmentAdvanceRequest : TeaModel {
        [NameInMap("CancerType")]
        [Validation(Required=false)]
        public string CancerType { get; set; }

        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("TargetVolumeType")]
        [Validation(Required=false)]
        public string TargetVolumeType { get; set; }

        [NameInMap("URLList")]
        [Validation(Required=false)]
        public List<TargetVolumeSegmentAdvanceRequestURLList> URLList { get; set; }
        public class TargetVolumeSegmentAdvanceRequestURLList : TeaModel {
            [NameInMap("URL")]
            [Validation(Required=false)]
            public Stream URLObject { get; set; }

        }

    }

}
