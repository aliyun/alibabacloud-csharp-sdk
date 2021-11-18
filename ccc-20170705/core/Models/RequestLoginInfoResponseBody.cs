// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class RequestLoginInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("LoginInfo")]
        [Validation(Required=false)]
        public RequestLoginInfoResponseBodyLoginInfo LoginInfo { get; set; }
        public class RequestLoginInfoResponseBodyLoginInfo : TeaModel {
            [NameInMap("AgentServerUrl")]
            [Validation(Required=false)]
            public string AgentServerUrl { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public RequestLoginInfoResponseBodyLoginInfoRoles Roles { get; set; }
            public class RequestLoginInfoResponseBodyLoginInfoRoles : TeaModel {
                [NameInMap("Role")]
                [Validation(Required=false)]
                public List<RequestLoginInfoResponseBodyLoginInfoRolesRole> Role { get; set; }
                public class RequestLoginInfoResponseBodyLoginInfoRolesRole : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("RoleDescription")]
                    [Validation(Required=false)]
                    public string RoleDescription { get; set; }

                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public string RoleId { get; set; }

                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

            }
            [NameInMap("SignData")]
            [Validation(Required=false)]
            public string SignData { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("WebRtcUrl")]
            [Validation(Required=false)]
            public string WebRtcUrl { get; set; }
        };

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
