// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetUrlUploadInfosResponseBody : TeaModel {
        [NameInMap("NonExists")]
        [Validation(Required=false)]
        public List<string> NonExists { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("URLUploadInfoList")]
        [Validation(Required=false)]
        public List<GetUrlUploadInfosResponseBodyURLUploadInfoList> URLUploadInfoList { get; set; }
        public class GetUrlUploadInfosResponseBodyURLUploadInfoList : TeaModel {
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UploadURL")]
            [Validation(Required=false)]
            public string UploadURL { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

    }

}
