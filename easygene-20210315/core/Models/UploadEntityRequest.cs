// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class UploadEntityRequest : TeaModel {
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("EntityTSVFile")]
        [Validation(Required=false)]
        public string EntityTSVFile { get; set; }

    }

}
