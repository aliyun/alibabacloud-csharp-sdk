// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertTransConfig : TeaModel {
        [NameInMap("AdjDarMethod")]
        [Validation(Required=false)]
        public string AdjDarMethod { get; set; }

        [NameInMap("IsCheckAudioBitrate")]
        [Validation(Required=false)]
        public bool? IsCheckAudioBitrate { get; set; }

        [NameInMap("IsCheckAudioBitrateFail")]
        [Validation(Required=false)]
        public bool? IsCheckAudioBitrateFail { get; set; }

        [NameInMap("IsCheckReso")]
        [Validation(Required=false)]
        public bool? IsCheckReso { get; set; }

        [NameInMap("IsCheckResoFail")]
        [Validation(Required=false)]
        public bool? IsCheckResoFail { get; set; }

        [NameInMap("IsCheckVideoBitrate")]
        [Validation(Required=false)]
        public bool? IsCheckVideoBitrate { get; set; }

        [NameInMap("IsCheckVideoBitrateFail")]
        [Validation(Required=false)]
        public bool? IsCheckVideoBitrateFail { get; set; }

        [NameInMap("TransMode")]
        [Validation(Required=false)]
        public string TransMode { get; set; }

    }

}
