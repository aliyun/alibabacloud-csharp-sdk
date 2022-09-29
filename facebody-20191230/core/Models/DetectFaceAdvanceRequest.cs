// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectFaceAdvanceRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("Landmark")]
        [Validation(Required=false)]
        public bool? Landmark { get; set; }

        [NameInMap("MaxFaceNumber")]
        [Validation(Required=false)]
        public long? MaxFaceNumber { get; set; }

        [NameInMap("Pose")]
        [Validation(Required=false)]
        public bool? Pose { get; set; }

        [NameInMap("Quality")]
        [Validation(Required=false)]
        public bool? Quality { get; set; }

    }

}
