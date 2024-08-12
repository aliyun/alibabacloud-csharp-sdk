// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ReportUserFbAcIssueShrinkRequest : TeaModel {
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("FileList")]
        [Validation(Required=false)]
        public string FileListShrink { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("ReservedA")]
        [Validation(Required=false)]
        public string ReservedA { get; set; }

        [NameInMap("ReservedB")]
        [Validation(Required=false)]
        public string ReservedB { get; set; }

        [NameInMap("UserEmail")]
        [Validation(Required=false)]
        public string UserEmail { get; set; }

    }

}
