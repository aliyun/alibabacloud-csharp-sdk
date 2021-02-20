// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateMPURuleRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowLog")]
        [Validation(Required=false)]
        public string ShowLog { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ChannelPrefix")]
        [Validation(Required=false)]
        public string ChannelPrefix { get; set; }

        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public int? BackgroundColor { get; set; }

        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public int? CropMode { get; set; }

        [NameInMap("TaskProfile")]
        [Validation(Required=false)]
        public string TaskProfile { get; set; }

        [NameInMap("PlayDomain")]
        [Validation(Required=false)]
        public string PlayDomain { get; set; }

        [NameInMap("CallBack")]
        [Validation(Required=false)]
        public string CallBack { get; set; }

        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<int?> LayoutIds { get; set; }

    }

}
