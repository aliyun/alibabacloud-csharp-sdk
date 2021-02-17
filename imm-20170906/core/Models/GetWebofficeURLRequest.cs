// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetWebofficeURLRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SrcType")]
        [Validation(Required=false)]
        public string SrcType { get; set; }

        [NameInMap("FileID")]
        [Validation(Required=false)]
        public string FileID { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        [NameInMap("File")]
        [Validation(Required=false)]
        public string File { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

    }

}
