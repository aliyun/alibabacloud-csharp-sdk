// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SendTTSVerifyLinkRequest : TeaModel {
        /// <summary>
        /// The ID of the alert contact.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// The mobile number of the alert contact.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

    }

}
