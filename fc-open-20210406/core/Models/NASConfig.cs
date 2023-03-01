// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class NASConfig : TeaModel {
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public int? GroupId { get; set; }

        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<NASConfigMountPoints> MountPoints { get; set; }
        public class NASConfigMountPoints : TeaModel {
            [NameInMap("enableTLS")]
            [Validation(Required=false)]
            public bool? EnableTLS { get; set; }

            [NameInMap("mountDir")]
            [Validation(Required=false)]
            public string MountDir { get; set; }

            [NameInMap("serverAddr")]
            [Validation(Required=false)]
            public string ServerAddr { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public int? UserId { get; set; }

    }

}
