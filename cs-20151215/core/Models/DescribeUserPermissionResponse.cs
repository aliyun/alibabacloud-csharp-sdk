// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserPermissionResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribeUserPermissionResponseBody> Body { get; set; }
        public class DescribeUserPermissionResponseBody : TeaModel {
            [NameInMap("resource_id")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            [NameInMap("is_owner")]
            [Validation(Required=false)]
            public long? IsOwner { get; set; }

            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public long? IsRamRole { get; set; }

        }

    }

}
