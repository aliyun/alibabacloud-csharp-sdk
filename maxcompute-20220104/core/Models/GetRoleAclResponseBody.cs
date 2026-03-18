// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRoleAclResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRoleAclResponseBodyData Data { get; set; }
        public class GetRoleAclResponseBodyData : TeaModel {
            [NameInMap("function")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataFunction> Function { get; set; }
            public class GetRoleAclResponseBodyDataFunction : TeaModel {
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            [NameInMap("instance")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataInstance> Instance { get; set; }
            public class GetRoleAclResponseBodyDataInstance : TeaModel {
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            [NameInMap("package")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataPackage> Package { get; set; }
            public class GetRoleAclResponseBodyDataPackage : TeaModel {
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            [NameInMap("project")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataProject> Project { get; set; }
            public class GetRoleAclResponseBodyDataProject : TeaModel {
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            [NameInMap("resource")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataResource> Resource { get; set; }
            public class GetRoleAclResponseBodyDataResource : TeaModel {
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            [NameInMap("table")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataTable> Table { get; set; }
            public class GetRoleAclResponseBodyDataTable : TeaModel {
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
