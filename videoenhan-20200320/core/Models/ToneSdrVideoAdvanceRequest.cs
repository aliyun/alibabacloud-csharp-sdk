// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class ToneSdrVideoAdvanceRequest : TeaModel {
        [NameInMap("VideoURLObject")]
        [Validation(Required=true)]
        public Stream VideoURLObject { get; set; }

        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public int? Bitrate { get; set; }

        [NameInMap("RecolorModel")]
        [Validation(Required=false)]
        public string RecolorModel { get; set; }

    }

}
