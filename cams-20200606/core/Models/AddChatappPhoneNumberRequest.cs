/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class AddChatappPhoneNumberRequest : TeaModel {
        [NameInMap("Cc")]
        [Validation(Required=false)]
        public string Cc { get; set; }

        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("PreValidateId")]
        [Validation(Required=false)]
        public string PreValidateId { get; set; }

        [NameInMap("VerifiedName")]
        [Validation(Required=false)]
        public string VerifiedName { get; set; }

    }

}
