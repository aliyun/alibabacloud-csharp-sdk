// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreatePhoneMessageQrdlRequest : TeaModel {
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("GenerateQrImage")]
        [Validation(Required=false)]
        public string GenerateQrImage { get; set; }

        /// <summary>
        /// The phone number. Add the country code before the phone number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PrefilledMessage")]
        [Validation(Required=false)]
        public string PrefilledMessage { get; set; }

    }

}
