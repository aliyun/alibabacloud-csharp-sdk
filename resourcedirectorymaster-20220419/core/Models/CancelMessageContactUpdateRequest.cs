// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class CancelMessageContactUpdateRequest : TeaModel {
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        [NameInMap("EmailAddress")]
        [Validation(Required=false)]
        public string EmailAddress { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

    }

}
