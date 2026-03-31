// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListRolesResponseBodyData Data { get; set; }
        public class ListRolesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The MaxCompute project-level roles.</para>
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListRolesResponseBodyDataRoles> Roles { get; set; }
            public class ListRolesResponseBodyDataRoles : TeaModel {
                /// <summary>
                /// <para>The ACL-based permissions that are granted to the role.</para>
                /// </summary>
                [NameInMap("acl")]
                [Validation(Required=false)]
                public ListRolesResponseBodyDataRolesAcl Acl { get; set; }
                public class ListRolesResponseBodyDataRolesAcl : TeaModel {
                    /// <summary>
                    /// <para>The function.</para>
                    /// </summary>
                    [NameInMap("function")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclFunction> Function { get; set; }
                    public class ListRolesResponseBodyDataRolesAclFunction : TeaModel {
                        /// <summary>
                        /// <para>The operations that were performed on the function.</para>
                        /// </summary>
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        /// <summary>
                        /// <para>The name of the function.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>functionA</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The instance.</para>
                    /// </summary>
                    [NameInMap("instance")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclInstance> Instance { get; set; }
                    public class ListRolesResponseBodyDataRolesAclInstance : TeaModel {
                        /// <summary>
                        /// <para>The operations that were performed on the instance.</para>
                        /// </summary>
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        /// <summary>
                        /// <para>The name of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>instanceA</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The package.</para>
                    /// </summary>
                    [NameInMap("package")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclPackage> Package { get; set; }
                    public class ListRolesResponseBodyDataRolesAclPackage : TeaModel {
                        /// <summary>
                        /// <para>The operations that were performed on the package.</para>
                        /// </summary>
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        /// <summary>
                        /// <para>The name of the package.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>packageA</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The project.</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclProject> Project { get; set; }
                    public class ListRolesResponseBodyDataRolesAclProject : TeaModel {
                        /// <summary>
                        /// <para>The operations that were performed on the project.</para>
                        /// </summary>
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        /// <summary>
                        /// <para>The name of the MaxCompute project.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>projectA</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The resource.</para>
                    /// </summary>
                    [NameInMap("resource")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclResource> Resource { get; set; }
                    public class ListRolesResponseBodyDataRolesAclResource : TeaModel {
                        /// <summary>
                        /// <para>The operations that were performed on the resource.</para>
                        /// </summary>
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        /// <summary>
                        /// <para>The name of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>resourceA</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The table.</para>
                    /// </summary>
                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclTable> Table { get; set; }
                    public class ListRolesResponseBodyDataRolesAclTable : TeaModel {
                        /// <summary>
                        /// <para>The operations that were performed on the table.</para>
                        /// </summary>
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        /// <summary>
                        /// <para>The name of the table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tableA</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>roleA</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The policy that is attached to the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///       &quot;Statement&quot;: [
                ///             {
                ///                   &quot;Action&quot;: [
                ///                         &quot;odps:<em>&quot;
                ///                   ],
                ///                   &quot;Effect&quot;: &quot;Allow&quot;,
                ///                   &quot;Resource&quot;: [
                ///                         &quot;acs:odps:</em>:projects/{projectname}/authorization/packages&quot;
                ///                   ]
                ///             }
                ///       ],
                ///       &quot;Version&quot;: &quot;1&quot;
                /// }</para>
                /// </summary>
                [NameInMap("policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The type of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a06dfe716686526652451361e80ae</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
