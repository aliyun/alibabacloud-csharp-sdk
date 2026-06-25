// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class GetNetworkBlacklistResponseBody : TeaModel {
        /// <summary>
        /// <para>The network blacklist.</para>
        /// </summary>
        [NameInMap("NetworkBlacklistModel")]
        [Validation(Required=false)]
        public GetNetworkBlacklistResponseBodyNetworkBlacklistModel NetworkBlacklistModel { get; set; }
        public class GetNetworkBlacklistResponseBodyNetworkBlacklistModel : TeaModel {
            /// <summary>
            /// <para>The list of blacklisted domain names.</para>
            /// </summary>
            [NameInMap("DomainBlacklist")]
            [Validation(Required=false)]
            public List<string> DomainBlacklist { get; set; }

            /// <summary>
            /// <para>The list of blacklisted IP addresses.</para>
            /// </summary>
            [NameInMap("IpBlacklist")]
            [Validation(Required=false)]
            public List<string> IpBlacklist { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A578AD3A-8E7C-54FE-A09F-B060941*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
