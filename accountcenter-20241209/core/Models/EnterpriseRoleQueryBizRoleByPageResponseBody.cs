// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseRoleQueryBizRoleByPageResponseBody : TeaModel {
        [NameInMap("BizRoles")]
        [Validation(Required=false)]
        public List<EnterpriseRoleQueryBizRoleByPageResponseBodyBizRoles> BizRoles { get; set; }
        public class EnterpriseRoleQueryBizRoleByPageResponseBodyBizRoles : TeaModel {
            [NameInMap("BizPermissionCount")]
            [Validation(Required=false)]
            public int? BizPermissionCount { get; set; }

            [NameInMap("BizPermissionNameList")]
            [Validation(Required=false)]
            public List<string> BizPermissionNameList { get; set; }

            [NameInMap("BizRoleCode")]
            [Validation(Required=false)]
            public string BizRoleCode { get; set; }

            [NameInMap("BizRoleDesc")]
            [Validation(Required=false)]
            public string BizRoleDesc { get; set; }

            [NameInMap("BizRoleName")]
            [Validation(Required=false)]
            public string BizRoleName { get; set; }

            [NameInMap("GrantedPkCount")]
            [Validation(Required=false)]
            public int? GrantedPkCount { get; set; }

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

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
