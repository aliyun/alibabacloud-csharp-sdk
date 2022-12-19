// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SearchImageFigureClusterRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

    }

}
