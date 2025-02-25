// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class SampleBase : TeaModel {
        [NameInMap("FullSampleDeviceIds")]
        [Validation(Required=false)]
        public List<FullSampleItem> FullSampleDeviceIds { get; set; }

        [NameInMap("FullSampleUsers")]
        [Validation(Required=false)]
        public List<FullSampleItem> FullSampleUsers { get; set; }

        [NameInMap("SampleMethod")]
        [Validation(Required=false)]
        public string SampleMethod { get; set; }

        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public float? SampleRate { get; set; }

    }

}
