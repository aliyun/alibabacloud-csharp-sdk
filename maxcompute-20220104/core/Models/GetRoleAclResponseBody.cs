// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRoleAclResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRoleAclResponseBodyData Data { get; set; }
        public class GetRoleAclResponseBodyData : TeaModel {
            /// <summary>
            /// The function.
            /// </summary>
            [NameInMap("function")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataFunction> Function { get; set; }
            public class GetRoleAclResponseBodyDataFunction : TeaModel {
                /// <summary>
                /// The operations that were performed on the function.
                /// </summary>
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                /// <summary>
                /// The name of the function.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The Schema name.
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// The instance.
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataInstance> Instance { get; set; }
            public class GetRoleAclResponseBodyDataInstance : TeaModel {
                /// <summary>
                /// The operations that were performed on the instance.
                /// </summary>
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The Schema name.
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// The package.
            /// </summary>
            [NameInMap("package")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataPackage> Package { get; set; }
            public class GetRoleAclResponseBodyDataPackage : TeaModel {
                /// <summary>
                /// The operations that were performed on the package.
                /// </summary>
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                /// <summary>
                /// The name of the package.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The Schema name.
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// The project.
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataProject> Project { get; set; }
            public class GetRoleAclResponseBodyDataProject : TeaModel {
                /// <summary>
                /// The operations that were performed on the project.
                /// </summary>
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                /// <summary>
                /// The name of the MaxCompute project.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The Schema name.
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// The resource.
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataResource> Resource { get; set; }
            public class GetRoleAclResponseBodyDataResource : TeaModel {
                /// <summary>
                /// The operations that were performed on the resource.
                /// </summary>
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                /// <summary>
                /// The name of the resource.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The Schema name.
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// The table.
            /// </summary>
            [NameInMap("table")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataTable> Table { get; set; }
            public class GetRoleAclResponseBodyDataTable : TeaModel {
                /// <summary>
                /// The operations that were performed on the table.
                /// </summary>
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<string> Actions { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The Schema name.
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
