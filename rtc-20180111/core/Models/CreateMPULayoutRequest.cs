// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateMPULayoutRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowLog")]
        [Validation(Required=false)]
        public string ShowLog { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("AudioMixCount")]
        [Validation(Required=false)]
        public int? AudioMixCount { get; set; }

        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<CreateMPULayoutRequestPanes> Panes { get; set; }
        public class CreateMPULayoutRequestPanes : TeaModel {
            [NameInMap("MajorPane")]
            [Validation(Required=false)]
            public int? MajorPane { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

        }

    }

}
