// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CloudPlayerShrinkRequest : TeaModel {
        [NameInMap("CurPlayIndex")]
        [Validation(Required=false)]
        public int? CurPlayIndex { get; set; }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

        [NameInMap("PlayMode")]
        [Validation(Required=false)]
        public string PlayMode { get; set; }

        [NameInMap("SongId")]
        [Validation(Required=false)]
        public string SongId { get; set; }

        [NameInMap("SongIdList")]
        [Validation(Required=false)]
        public string SongIdListShrink { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
