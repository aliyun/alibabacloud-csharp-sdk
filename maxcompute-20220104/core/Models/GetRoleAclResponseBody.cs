// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRoleAclResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRoleAclResponseBodyData Data { get; set; }
        public class GetRoleAclResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The function.</para>
            /// </summary>
            [NameInMap("function")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataFunction> Function { get; set; }
            public class GetRoleAclResponseBodyDataFunction : TeaModel {
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

                /// <summary>
                /// <para>The Schema name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// <para>The instance.</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataInstance> Instance { get; set; }
            public class GetRoleAclResponseBodyDataInstance : TeaModel {
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

                /// <summary>
                /// <para>The Schema name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// <para>The package.</para>
            /// </summary>
            [NameInMap("package")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataPackage> Package { get; set; }
            public class GetRoleAclResponseBodyDataPackage : TeaModel {
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

                /// <summary>
                /// <para>The Schema name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// <para>The project.</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataProject> Project { get; set; }
            public class GetRoleAclResponseBodyDataProject : TeaModel {
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

                /// <summary>
                /// <para>The Schema name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// <para>The resource.</para>
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataResource> Resource { get; set; }
            public class GetRoleAclResponseBodyDataResource : TeaModel {
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

                /// <summary>
                /// <para>The Schema name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            /// <summary>
            /// <para>The table.</para>
            /// </summary>
            [NameInMap("table")]
            [Validation(Required=false)]
            public List<GetRoleAclResponseBodyDataTable> Table { get; set; }
            public class GetRoleAclResponseBodyDataTable : TeaModel {
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

                /// <summary>
                /// <para>The Schema name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>040002</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>error message</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a06dc0916696898838762018e9564</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
