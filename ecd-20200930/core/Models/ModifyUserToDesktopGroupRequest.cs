// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyUserToDesktopGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        [NameInMap("OldEndUserIds")]
        [Validation(Required=false)]
        public List<string> OldEndUserIds { get; set; }

        [NameInMap("NewEndUserIds")]
        [Validation(Required=false)]
        public List<string> NewEndUserIds { get; set; }

    }

}
