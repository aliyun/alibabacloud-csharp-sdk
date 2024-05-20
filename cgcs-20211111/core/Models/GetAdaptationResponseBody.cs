// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class GetAdaptationResponseBody : TeaModel {
        [NameInMap("AdaptApplyId")]
        [Validation(Required=false)]
        public long? AdaptApplyId { get; set; }

        [NameInMap("AdaptTarget")]
        [Validation(Required=false)]
        public GetAdaptationResponseBodyAdaptTarget AdaptTarget { get; set; }
        public class GetAdaptationResponseBodyAdaptTarget : TeaModel {
            [NameInMap("BitRate")]
            [Validation(Required=false)]
            public int? BitRate { get; set; }

            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public int? FrameRate { get; set; }

            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            [NameInMap("StartProgram")]
            [Validation(Required=false)]
            public string StartProgram { get; set; }

        }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersionId")]
        [Validation(Required=false)]
        public string AppVersionId { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
