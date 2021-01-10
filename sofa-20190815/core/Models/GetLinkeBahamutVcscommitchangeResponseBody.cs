// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutVcscommitchangeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetLinkeBahamutVcscommitchangeResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutVcscommitchangeResponseBodyResult : TeaModel {
            [NameInMap("Amode")]
            [Validation(Required=false)]
            public string Amode { get; set; }

            [NameInMap("Binary")]
            [Validation(Required=false)]
            public bool? Binary { get; set; }

            [NameInMap("Bmode")]
            [Validation(Required=false)]
            public string Bmode { get; set; }

            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            [NameInMap("DeletedFile")]
            [Validation(Required=false)]
            public bool? DeletedFile { get; set; }

            [NameInMap("Diff")]
            [Validation(Required=false)]
            public string Diff { get; set; }

            [NameInMap("FilePathId")]
            [Validation(Required=false)]
            public string FilePathId { get; set; }

            [NameInMap("FromId")]
            [Validation(Required=false)]
            public string FromId { get; set; }

            [NameInMap("NewFile")]
            [Validation(Required=false)]
            public bool? NewFile { get; set; }

            [NameInMap("NewPath")]
            [Validation(Required=false)]
            public string NewPath { get; set; }

            [NameInMap("OldPath")]
            [Validation(Required=false)]
            public string OldPath { get; set; }

            [NameInMap("RenamedFile")]
            [Validation(Required=false)]
            public bool? RenamedFile { get; set; }

            [NameInMap("ToId")]
            [Validation(Required=false)]
            public string ToId { get; set; }

        }

    }

}
