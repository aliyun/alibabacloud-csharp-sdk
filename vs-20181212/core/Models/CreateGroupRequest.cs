// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateGroupRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("InProtocol")]
        [Validation(Required=false)]
        public string InProtocol { get; set; }

        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

        [NameInMap("PushDomain")]
        [Validation(Required=false)]
        public string PushDomain { get; set; }

        [NameInMap("PlayDomain")]
        [Validation(Required=false)]
        public string PlayDomain { get; set; }

        [NameInMap("LazyPull")]
        [Validation(Required=false)]
        public bool? LazyPull { get; set; }

        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        [NameInMap("CaptureInterval")]
        [Validation(Required=false)]
        public int? CaptureInterval { get; set; }

        [NameInMap("CaptureImage")]
        [Validation(Required=false)]
        public int? CaptureImage { get; set; }

        [NameInMap("CaptureVideo")]
        [Validation(Required=false)]
        public int? CaptureVideo { get; set; }

        [NameInMap("CaptureOssBucket")]
        [Validation(Required=false)]
        public string CaptureOssBucket { get; set; }

        [NameInMap("CaptureOssPath")]
        [Validation(Required=false)]
        public string CaptureOssPath { get; set; }

    }

}
