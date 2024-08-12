// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ModifySecureNetworkTypeRequest : TeaModel {
        [NameInMap("SecureNetworkType")]
        [Validation(Required=false)]
        public string SecureNetworkType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

    }

}
