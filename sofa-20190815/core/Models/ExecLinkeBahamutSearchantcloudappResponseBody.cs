// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeBahamutSearchantcloudappResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ExecLinkeBahamutSearchantcloudappResponseBodyResult> Result { get; set; }
        public class ExecLinkeBahamutSearchantcloudappResponseBodyResult : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("HasImported")]
            [Validation(Required=false)]
            public bool? HasImported { get; set; }

            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            [NameInMap("BuildpackName")]
            [Validation(Required=false)]
            public string BuildpackName { get; set; }

            [NameInMap("AppLevel")]
            [Validation(Required=false)]
            public string AppLevel { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("AppGroupName")]
            [Validation(Required=false)]
            public string AppGroupName { get; set; }

            [NameInMap("OwnerLoginName")]
            [Validation(Required=false)]
            public string OwnerLoginName { get; set; }

            [NameInMap("BuildpackVersion")]
            [Validation(Required=false)]
            public string BuildpackVersion { get; set; }

            [NameInMap("TechV2")]
            [Validation(Required=false)]
            public bool? TechV2 { get; set; }

            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

        }

    }

}
