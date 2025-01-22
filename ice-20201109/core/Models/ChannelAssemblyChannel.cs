// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ChannelAssemblyChannel : TeaModel {
        [NameInMap("AccessPolicy")]
        [Validation(Required=false)]
        public bool? AccessPolicy { get; set; }

        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        [NameInMap("ChannelTier")]
        [Validation(Required=false)]
        public string ChannelTier { get; set; }

        [NameInMap("FillerSourceLocationName")]
        [Validation(Required=false)]
        public string FillerSourceLocationName { get; set; }

        [NameInMap("FillerSourceName")]
        [Validation(Required=false)]
        public string FillerSourceName { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("OutPutConfigList")]
        [Validation(Required=false)]
        public List<ChannelAssemblyChannelOutPutConfigList> OutPutConfigList { get; set; }
        public class ChannelAssemblyChannelOutPutConfigList : TeaModel {
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("ManifestName")]
            [Validation(Required=false)]
            public string ManifestName { get; set; }

            [NameInMap("ManifestSettings")]
            [Validation(Required=false)]
            public string ManifestSettings { get; set; }

            [NameInMap("PlaybackUrl")]
            [Validation(Required=false)]
            public string PlaybackUrl { get; set; }

            [NameInMap("SourceGroupName")]
            [Validation(Required=false)]
            public string SourceGroupName { get; set; }

        }

        [NameInMap("PlaybackMode")]
        [Validation(Required=false)]
        public string PlaybackMode { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

    }

}
