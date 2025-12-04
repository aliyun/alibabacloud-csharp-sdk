// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormV2InstanceSecurityGroupsResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SgList")]
        [Validation(Required=false)]
        public List<GetLindormV2InstanceSecurityGroupsResponseBodySgList> SgList { get; set; }
        public class GetLindormV2InstanceSecurityGroupsResponseBodySgList : TeaModel {
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("IpList")]
            [Validation(Required=false)]
            public string IpList { get; set; }

            [NameInMap("IsAvailable")]
            [Validation(Required=false)]
            public bool? IsAvailable { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

        }

    }

}
