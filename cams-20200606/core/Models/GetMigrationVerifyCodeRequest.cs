// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetMigrationVerifyCodeRequest : TeaModel {
        /// <summary>
        /// The space ID of the user under the ISV account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        /// <summary>
        /// The method to obtain the verification code. Valid values: sms and voice.
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

    }

}
