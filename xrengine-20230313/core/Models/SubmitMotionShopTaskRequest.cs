// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class SubmitMotionShopTaskRequest : TeaModel {
        [NameInMap("AvatarId")]
        [Validation(Required=false)]
        public string AvatarId { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("SelectedBoxIndex")]
        [Validation(Required=false)]
        public int? SelectedBoxIndex { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
