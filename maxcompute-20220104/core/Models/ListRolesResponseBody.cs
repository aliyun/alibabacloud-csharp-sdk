// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListRolesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListRolesResponseBodyData Data { get; set; }
        public class ListRolesResponseBodyData : TeaModel {
            /// <summary>
            /// The MaxCompute project-level roles.
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListRolesResponseBodyDataRoles> Roles { get; set; }
            public class ListRolesResponseBodyDataRoles : TeaModel {
                /// <summary>
                /// The ACL-based permissions that are granted to the role.
                /// </summary>
                [NameInMap("acl")]
                [Validation(Required=false)]
                public ListRolesResponseBodyDataRolesAcl Acl { get; set; }
                public class ListRolesResponseBodyDataRolesAcl : TeaModel {
                    /// <summary>
                    /// The function.
                    /// </summary>
                    [NameInMap("function")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclFunction> Function { get; set; }
                    public class ListRolesResponseBodyDataRolesAclFunction : TeaModel {
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

                    }

                    /// <summary>
                    /// The instance.
                    /// </summary>
                    [NameInMap("instance")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclInstance> Instance { get; set; }
                    public class ListRolesResponseBodyDataRolesAclInstance : TeaModel {
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

                    }

                    /// <summary>
                    /// The package.
                    /// </summary>
                    [NameInMap("package")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclPackage> Package { get; set; }
                    public class ListRolesResponseBodyDataRolesAclPackage : TeaModel {
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

                    }

                    /// <summary>
                    /// The project.
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclProject> Project { get; set; }
                    public class ListRolesResponseBodyDataRolesAclProject : TeaModel {
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

                    }

                    /// <summary>
                    /// The resource.
                    /// </summary>
                    [NameInMap("resource")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclResource> Resource { get; set; }
                    public class ListRolesResponseBodyDataRolesAclResource : TeaModel {
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

                    }

                    /// <summary>
                    /// The table.
                    /// </summary>
                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclTable> Table { get; set; }
                    public class ListRolesResponseBodyDataRolesAclTable : TeaModel {
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

                    }

                }

                /// <summary>
                /// The name of the role.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The policy that is attached to the role.
                /// </summary>
                [NameInMap("policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// The type of the role.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
