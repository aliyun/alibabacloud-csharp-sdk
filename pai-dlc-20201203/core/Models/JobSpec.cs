// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSpec : TeaModel {
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        [NameInMap("ExtraPodSpec")]
        [Validation(Required=false)]
        public ExtraPodSpec ExtraPodSpec { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("ImageConfig")]
        [Validation(Required=false)]
        public ImageConfig ImageConfig { get; set; }

        [NameInMap("PodCount")]
        [Validation(Required=false)]
        public long? PodCount { get; set; }

        [NameInMap("ResourceConfig")]
        [Validation(Required=false)]
        public ResourceConfig ResourceConfig { get; set; }

        [NameInMap("SpotSpec")]
        [Validation(Required=false)]
        public SpotSpec SpotSpec { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UseSpotInstance")]
        [Validation(Required=false)]
        public bool? UseSpotInstance { get; set; }

    }

}
