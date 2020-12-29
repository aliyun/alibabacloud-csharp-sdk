// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class ConvertHdrVideoRequest : TeaModel {
        [NameInMap("VideoURL")]
        [Validation(Required=false)]
        public string VideoURL { get; set; }

        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("HDRFormat")]
        [Validation(Required=false)]
        public string HDRFormat { get; set; }

        [NameInMap("MaxIlluminance")]
        [Validation(Required=false)]
        public int? MaxIlluminance { get; set; }

        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public int? Bitrate { get; set; }

    }

}
