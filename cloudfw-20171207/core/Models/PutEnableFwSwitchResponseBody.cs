// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutEnableFwSwitchResponseBody : TeaModel {
        /// <summary>
        /// The status information of the asset when it is not synchronized to Cloud Firewall.
        /// </summary>
        [NameInMap("AbnormalResourceStatusList")]
        [Validation(Required=false)]
        public List<PutEnableFwSwitchResponseBodyAbnormalResourceStatusList> AbnormalResourceStatusList { get; set; }
        public class PutEnableFwSwitchResponseBodyAbnormalResourceStatusList : TeaModel {
            /// <summary>
            /// The message displayed when the asset is not synchronized to Cloud Firewall. Valid values:
            /// 
            /// *   cloudfirewall do not sync this ip address: This IP address is not synchronized to Cloud Firewall.
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// The IP address of the asset.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// The status of the asset when it is not synchronized to Cloud Firewall. Valid values:
            /// 
            /// *   ip_not_sync: The asset is not synchronized.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
