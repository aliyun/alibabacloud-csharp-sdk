// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeLinktSimpleprojectmembersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryLinkeLinktSimpleprojectmembersResponseBodyData> Data { get; set; }
        public class QueryLinkeLinktSimpleprojectmembersResponseBodyData : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("AdDomain")]
            [Validation(Required=false)]
            public string AdDomain { get; set; }

            [NameInMap("AliFullName")]
            [Validation(Required=false)]
            public string AliFullName { get; set; }

            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            [NameInMap("BuName")]
            [Validation(Required=false)]
            public string BuName { get; set; }

            [NameInMap("BuNo")]
            [Validation(Required=false)]
            public string BuNo { get; set; }

            [NameInMap("Customer")]
            [Validation(Required=false)]
            public string Customer { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("DeptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("DeptNo")]
            [Validation(Required=false)]
            public string DeptNo { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("EmpId")]
            [Validation(Required=false)]
            public string EmpId { get; set; }

            [NameInMap("EmpType")]
            [Validation(Required=false)]
            public string EmpType { get; set; }

            [NameInMap("EmpTypeExt")]
            [Validation(Required=false)]
            public string EmpTypeExt { get; set; }

            [NameInMap("FullPartTime")]
            [Validation(Required=false)]
            public string FullPartTime { get; set; }

            [NameInMap("GitModified")]
            [Validation(Required=false)]
            public long? GitModified { get; set; }

            [NameInMap("GitPassword")]
            [Validation(Required=false)]
            public string GitPassword { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtEntry")]
            [Validation(Required=false)]
            public long? GmtEntry { get; set; }

            [NameInMap("GmtLeave")]
            [Validation(Required=false)]
            public long? GmtLeave { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("LoginAccount")]
            [Validation(Required=false)]
            public string LoginAccount { get; set; }

            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            [NameInMap("Manager")]
            [Validation(Required=false)]
            public bool? Manager { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("RealName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            [NameInMap("SuperName")]
            [Validation(Required=false)]
            public string SuperName { get; set; }

            [NameInMap("SuperNickName")]
            [Validation(Required=false)]
            public string SuperNickName { get; set; }

            [NameInMap("SuperWorkNo")]
            [Validation(Required=false)]
            public string SuperWorkNo { get; set; }

            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }

            [NameInMap("TenantAdmin")]
            [Validation(Required=false)]
            public bool? TenantAdmin { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

            [NameInMap("UserToken")]
            [Validation(Required=false)]
            public string UserToken { get; set; }

            [NameInMap("VirtName")]
            [Validation(Required=false)]
            public string VirtName { get; set; }

            [NameInMap("VirtWorkNo")]
            [Validation(Required=false)]
            public string VirtWorkNo { get; set; }

            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

            [NameInMap("WorkNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

            [NameInMap("WorkStatus")]
            [Validation(Required=false)]
            public string WorkStatus { get; set; }

            [NameInMap("Tenants")]
            [Validation(Required=false)]
            public List<string> Tenants { get; set; }

        }

    }

}
