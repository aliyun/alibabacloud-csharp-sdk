// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAccountMaskingPrivilegeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAccountMaskingPrivilegeResponseBodyData Data { get; set; }
        public class DescribeAccountMaskingPrivilegeResponseBodyData : TeaModel {
            [NameInMap("UserPrivilege")]
            [Validation(Required=false)]
            public List<DescribeAccountMaskingPrivilegeResponseBodyDataUserPrivilege> UserPrivilege { get; set; }
            public class DescribeAccountMaskingPrivilegeResponseBodyDataUserPrivilege : TeaModel {
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("Privilege")]
                [Validation(Required=false)]
                public string Privilege { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
