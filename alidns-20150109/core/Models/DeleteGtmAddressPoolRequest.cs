// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// The ID of the address pool that you want to delete.
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// The language used by the user.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
