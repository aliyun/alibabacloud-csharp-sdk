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
    public class CheckChatappContactsRequest : TeaModel {
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public List<string> Contacts { get; set; }

        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        public string CustWabaId { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

    }

}
