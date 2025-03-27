// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class LivePackagingConfig : TeaModel {
        [NameInMap("DrmConfig")]
        [Validation(Required=false)]
        public LivePackagingConfigDrmConfig DrmConfig { get; set; }
        public class LivePackagingConfigDrmConfig : TeaModel {
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

        [NameInMap("LiveManifestConfigs")]
        [Validation(Required=false)]
        public List<LiveManifestConfig> LiveManifestConfigs { get; set; }

        [NameInMap("SegmentDuration")]
        [Validation(Required=false)]
        public int? SegmentDuration { get; set; }

        [NameInMap("UseAudioRenditionGroups")]
        [Validation(Required=false)]
        public bool? UseAudioRenditionGroups { get; set; }

    }

}
