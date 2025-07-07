// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseRoleQueryBizRoleDetailResponseBody : TeaModel {
        [NameInMap("BizRoleDetail")]
        [Validation(Required=false)]
        public EnterpriseRoleQueryBizRoleDetailResponseBodyBizRoleDetail BizRoleDetail { get; set; }
        public class EnterpriseRoleQueryBizRoleDetailResponseBodyBizRoleDetail : TeaModel {
            [NameInMap("BizPermissions")]
            [Validation(Required=false)]
            public List<EnterpriseRoleQueryBizRoleDetailResponseBodyBizRoleDetailBizPermissions> BizPermissions { get; set; }
            public class EnterpriseRoleQueryBizRoleDetailResponseBodyBizRoleDetailBizPermissions : TeaModel {
                [NameInMap("BizPermissionCode")]
                [Validation(Required=false)]
                public string BizPermissionCode { get; set; }

                [NameInMap("BizPermissionDesc")]
                [Validation(Required=false)]
                public string BizPermissionDesc { get; set; }

                [NameInMap("BizPermissionName")]
                [Validation(Required=false)]
                public string BizPermissionName { get; set; }

            }

            [NameInMap("BizRoleCode")]
            [Validation(Required=false)]
            public string BizRoleCode { get; set; }

            [NameInMap("BizRoleDesc")]
            [Validation(Required=false)]
            public string BizRoleDesc { get; set; }

            [NameInMap("BizRoleName")]
            [Validation(Required=false)]
            public string BizRoleName { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
