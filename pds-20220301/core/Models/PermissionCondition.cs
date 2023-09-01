// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class PermissionCondition : TeaModel {
        [NameInMap("ip_equals")]
        [Validation(Required=false)]
        public PermissionConditionIpEquals IpEquals { get; set; }
        public class PermissionConditionIpEquals : TeaModel {
            [NameInMap("client_ip")]
            [Validation(Required=false)]
            public List<string> ClientIp { get; set; }

        }

        [NameInMap("ip_not_equals")]
        [Validation(Required=false)]
        public PermissionConditionIpNotEquals IpNotEquals { get; set; }
        public class PermissionConditionIpNotEquals : TeaModel {
            [NameInMap("client_ip")]
            [Validation(Required=false)]
            public List<string> ClientIp { get; set; }

        }

        [NameInMap("string_like")]
        [Validation(Required=false)]
        public PermissionConditionStringLike StringLike { get; set; }
        public class PermissionConditionStringLike : TeaModel {
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public List<string> VpcId { get; set; }

        }

        [NameInMap("string_not_like")]
        [Validation(Required=false)]
        public PermissionConditionStringNotLike StringNotLike { get; set; }
        public class PermissionConditionStringNotLike : TeaModel {
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public List<string> VpcId { get; set; }

        }

    }

}
