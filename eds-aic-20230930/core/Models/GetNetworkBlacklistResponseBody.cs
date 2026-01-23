// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class GetNetworkBlacklistResponseBody : TeaModel {
        [NameInMap("NetworkBlacklistModel")]
        [Validation(Required=false)]
        public GetNetworkBlacklistResponseBodyNetworkBlacklistModel NetworkBlacklistModel { get; set; }
        public class GetNetworkBlacklistResponseBodyNetworkBlacklistModel : TeaModel {
            [NameInMap("DomainBlacklist")]
            [Validation(Required=false)]
            public List<string> DomainBlacklist { get; set; }

            [NameInMap("IpBlacklist")]
            [Validation(Required=false)]
            public List<string> IpBlacklist { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A578AD3A-8E7C-54FE-A09F-B060941*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
