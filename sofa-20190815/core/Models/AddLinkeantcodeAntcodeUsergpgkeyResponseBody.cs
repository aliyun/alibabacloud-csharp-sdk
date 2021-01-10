// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeantcodeAntcodeUsergpgkeyResponseBody : TeaModel {
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        [NameInMap("Verified")]
        [Validation(Required=false)]
        public bool? Verified { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public AddLinkeantcodeAntcodeUsergpgkeyResponseBodyUserId UserId { get; set; }
        public class AddLinkeantcodeAntcodeUsergpgkeyResponseBodyUserId : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
        };

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("Subkeys")]
        [Validation(Required=false)]
        public List<AddLinkeantcodeAntcodeUsergpgkeyResponseBodySubkeys> Subkeys { get; set; }
        public class AddLinkeantcodeAntcodeUsergpgkeyResponseBodySubkeys : TeaModel {
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

        }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
