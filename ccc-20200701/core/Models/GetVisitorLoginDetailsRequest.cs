// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetVisitorLoginDetailsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChatDeviceId")]
        [Validation(Required=false)]
        public string ChatDeviceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VisitorId")]
        [Validation(Required=false)]
        public string VisitorId { get; set; }

    }

}
