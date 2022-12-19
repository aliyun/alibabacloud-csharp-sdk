// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CompareImageFacesRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public CompareImageFacesRequestSource Source { get; set; }
        public class CompareImageFacesRequestSource : TeaModel {
            [NameInMap("URI1")]
            [Validation(Required=false)]
            public string URI1 { get; set; }

            [NameInMap("URI2")]
            [Validation(Required=false)]
            public string URI2 { get; set; }

        }

    }

}
