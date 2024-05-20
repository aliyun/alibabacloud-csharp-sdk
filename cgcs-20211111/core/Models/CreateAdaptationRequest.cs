// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateAdaptationRequest : TeaModel {
        [NameInMap("AdaptTarget")]
        [Validation(Required=false)]
        public CreateAdaptationRequestAdaptTarget AdaptTarget { get; set; }
        public class CreateAdaptationRequestAdaptTarget : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppVersionId")]
        [Validation(Required=false)]
        public string AppVersionId { get; set; }

    }

}
