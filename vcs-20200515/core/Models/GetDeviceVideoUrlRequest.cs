/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetDeviceVideoUrlRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long EndTime { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

    }

}
