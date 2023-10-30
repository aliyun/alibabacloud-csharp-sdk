// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class RemoveHostsFromGroupResponseBody : TeaModel {
        /// <summary>
        /// All Alibaba Cloud API operations must include common request parameters. For more information about common request parameters, see [Common parameters](~~315526~~).
        /// 
        /// For more information about sample requests, see the "Examples" section of this topic.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Removes one or more hosts from a host group.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<RemoveHostsFromGroupResponseBodyResults> Results { get; set; }
        public class RemoveHostsFromGroupResponseBodyResults : TeaModel {
            /// <summary>
            /// RemoveHostsFromGroup
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// RemoveHostsFromGroup
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// WB662865
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
