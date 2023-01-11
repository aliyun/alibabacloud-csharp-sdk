// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyPhoneBusinessProfileRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("ProfilePictureUrl")]
        [Validation(Required=false)]
        public string ProfilePictureUrl { get; set; }

        [NameInMap("Vertical")]
        [Validation(Required=false)]
        public string Vertical { get; set; }

        [NameInMap("Websites")]
        [Validation(Required=false)]
        public List<string> Websites { get; set; }

    }

}
