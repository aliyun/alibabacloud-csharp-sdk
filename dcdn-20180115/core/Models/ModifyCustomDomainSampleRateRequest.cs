// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyCustomDomainSampleRateRequest : TeaModel {
        [NameInMap("BaseConfigID")]
        [Validation(Required=false)]
        public string BaseConfigID { get; set; }

        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public float? SampleRate { get; set; }

        [NameInMap("SinkID")]
        [Validation(Required=false)]
        public long? SinkID { get; set; }

    }

}
