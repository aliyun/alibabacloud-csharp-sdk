// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetOfficeEditURLRequest : TeaModel {
        [NameInMap("FileID")]
        [Validation(Required=false)]
        public string FileID { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SrcType")]
        [Validation(Required=false)]
        public string SrcType { get; set; }

        [NameInMap("SrcUri")]
        [Validation(Required=false)]
        public string SrcUri { get; set; }

        [NameInMap("TgtUri")]
        [Validation(Required=false)]
        public string TgtUri { get; set; }

        [NameInMap("UserID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
