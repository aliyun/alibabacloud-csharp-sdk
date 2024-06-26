// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AntChainId")]
        [Validation(Required=false)]
        public string AntChainId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneList")]
        [Validation(Required=false)]
        public Dictionary<string, object> PhoneList { get; set; }

    }

}
