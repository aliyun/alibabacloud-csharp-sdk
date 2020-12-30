// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RegisterMediaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FailedFileURLs")]
        [Validation(Required=false)]
        public List<string> FailedFileURLs { get; set; }

        [NameInMap("RegisteredMediaList")]
        [Validation(Required=false)]
        public List<RegisterMediaResponseBodyRegisteredMediaList> RegisteredMediaList { get; set; }
        public class RegisterMediaResponseBodyRegisteredMediaList : TeaModel {
            [NameInMap("NewRegister")]
            [Validation(Required=false)]
            public bool? NewRegister { get; set; }

            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

    }

}
