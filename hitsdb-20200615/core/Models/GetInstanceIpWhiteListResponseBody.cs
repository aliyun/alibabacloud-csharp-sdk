// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetInstanceIpWhiteListResponseBody : TeaModel {
        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<GetInstanceIpWhiteListResponseBodyGroupList> GroupList { get; set; }
        public class GetInstanceIpWhiteListResponseBodyGroupList : TeaModel {
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("SecurityIpList")]
            [Validation(Required=false)]
            public string SecurityIpList { get; set; }

        }

        /// <summary>
        /// The ID of the Lindorm instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<string> IpList { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
