// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class ResetMainPasswordRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("UseRandomPassword")]
        [Validation(Required=true)]
        public bool? UseRandomPassword { get; set; }

        [NameInMap("InitPassword")]
        [Validation(Required=false)]
        public string InitPassword { get; set; }

        [NameInMap("EnableKMS")]
        [Validation(Required=false)]
        public bool? EnableKMS { get; set; }

        [NameInMap("ExternalUid")]
        [Validation(Required=false)]
        public string ExternalUid { get; set; }

        [NameInMap("ExternalAliyunUid")]
        [Validation(Required=false)]
        public string ExternalAliyunUid { get; set; }

        [NameInMap("ExternalBizAliyunUid")]
        [Validation(Required=false)]
        public string ExternalBizAliyunUid { get; set; }

    }

}
