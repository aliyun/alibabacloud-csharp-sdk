// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamTranscodeRequest : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=true)]
        public string Domain { get; set; }

        [NameInMap("App")]
        [Validation(Required=true)]
        public string App { get; set; }

        [NameInMap("Template")]
        [Validation(Required=true)]
        public string Template { get; set; }

        [NameInMap("Lazy")]
        [Validation(Required=false)]
        public string Lazy { get; set; }

        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        [NameInMap("Mix")]
        [Validation(Required=false)]
        public string Mix { get; set; }

        [NameInMap("OnlyAudio")]
        [Validation(Required=false)]
        public string OnlyAudio { get; set; }

        [NameInMap("WaterPattern")]
        [Validation(Required=false)]
        public string WaterPattern { get; set; }

    }

}
