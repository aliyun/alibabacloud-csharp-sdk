// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class AgenticFSVolumeConfig : TeaModel {
        [NameInMap("accessPointID")]
        [Validation(Required=false)]
        public string AccessPointID { get; set; }

        [NameInMap("agenticSpaceID")]
        [Validation(Required=false)]
        public string AgenticSpaceID { get; set; }

        [NameInMap("fileSystemID")]
        [Validation(Required=false)]
        public string FileSystemID { get; set; }

        [NameInMap("groupID")]
        [Validation(Required=false)]
        public int? GroupID { get; set; }

        [NameInMap("serverAddr")]
        [Validation(Required=false)]
        public string ServerAddr { get; set; }

        [NameInMap("userID")]
        [Validation(Required=false)]
        public int? UserID { get; set; }

    }

}
