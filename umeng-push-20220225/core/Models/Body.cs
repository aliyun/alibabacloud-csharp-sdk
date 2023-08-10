// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class Body : TeaModel {
        [NameInMap("activity")]
        [Validation(Required=false)]
        public string Activity { get; set; }

        [NameInMap("addBadge")]
        [Validation(Required=false)]
        public int? AddBadge { get; set; }

        [NameInMap("afterOpen")]
        [Validation(Required=false)]
        public string AfterOpen { get; set; }

        [NameInMap("builderId")]
        [Validation(Required=false)]
        public long? BuilderId { get; set; }

        [NameInMap("custom")]
        [Validation(Required=false)]
        public string Custom { get; set; }

        [NameInMap("expandImage")]
        [Validation(Required=false)]
        public string ExpandImage { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("img")]
        [Validation(Required=false)]
        public string Img { get; set; }

        [NameInMap("largeIcon")]
        [Validation(Required=false)]
        public string LargeIcon { get; set; }

        [NameInMap("playLights")]
        [Validation(Required=false)]
        public bool? PlayLights { get; set; }

        [NameInMap("playSound")]
        [Validation(Required=false)]
        public bool? PlaySound { get; set; }

        [NameInMap("playVibrate")]
        [Validation(Required=false)]
        public bool? PlayVibrate { get; set; }

        [NameInMap("rePop")]
        [Validation(Required=false)]
        public int? RePop { get; set; }

        [NameInMap("setBadge")]
        [Validation(Required=false)]
        public int? SetBadge { get; set; }

        [NameInMap("sound")]
        [Validation(Required=false)]
        public string Sound { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
