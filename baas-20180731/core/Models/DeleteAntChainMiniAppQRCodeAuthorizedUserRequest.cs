// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DeleteAntChainMiniAppQRCodeAuthorizedUserRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AntChainId")]
        [Validation(Required=false)]
        public string AntChainId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

    }

}
