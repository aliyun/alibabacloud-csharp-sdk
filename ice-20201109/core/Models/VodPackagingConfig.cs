// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class VodPackagingConfig : TeaModel {
        [NameInMap("DrmProvider")]
        [Validation(Required=false)]
        public VodPackagingConfigDrmProvider DrmProvider { get; set; }
        public class VodPackagingConfigDrmProvider : TeaModel {
            [NameInMap("EncryptionMethod")]
            [Validation(Required=false)]
            public string EncryptionMethod { get; set; }

            [NameInMap("IV")]
            [Validation(Required=false)]
            public string IV { get; set; }

            [NameInMap("SystemIds")]
            [Validation(Required=false)]
            public List<string> SystemIds { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("ManifestName")]
        [Validation(Required=false)]
        public string ManifestName { get; set; }

        [NameInMap("SegmentDuration")]
        [Validation(Required=false)]
        public long? SegmentDuration { get; set; }

        [NameInMap("StreamSelection")]
        [Validation(Required=false)]
        public VodPackagingConfigStreamSelection StreamSelection { get; set; }
        public class VodPackagingConfigStreamSelection : TeaModel {
            [NameInMap("MaxVideoBitsPerSecond")]
            [Validation(Required=false)]
            public long? MaxVideoBitsPerSecond { get; set; }

            [NameInMap("MinVideoBitsPerSecond")]
            [Validation(Required=false)]
            public long? MinVideoBitsPerSecond { get; set; }

            [NameInMap("StreamOrder")]
            [Validation(Required=false)]
            public string StreamOrder { get; set; }

        }

    }

}
