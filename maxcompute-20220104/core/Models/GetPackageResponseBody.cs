// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPackageResponseBodyData Data { get; set; }
        public class GetPackageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The projects in which the package is installed.</para>
            /// </summary>
            [NameInMap("allowedProjectList")]
            [Validation(Required=false)]
            public List<GetPackageResponseBodyDataAllowedProjectList> AllowedProjectList { get; set; }
            public class GetPackageResponseBodyDataAllowedProjectList : TeaModel {
                /// <summary>
                /// <para>The security level for sensitive data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The name of the MaxCompute project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>proejctB</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

            }

            /// <summary>
            /// <para>The details of the resources that are included in the package.</para>
            /// </summary>
            [NameInMap("resourceList")]
            [Validation(Required=false)]
            public GetPackageResponseBodyDataResourceList ResourceList { get; set; }
            public class GetPackageResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// <para>The functions.</para>
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public List<GetPackageResponseBodyDataResourceListFunction> Function { get; set; }
                public class GetPackageResponseBodyDataResourceListFunction : TeaModel {
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
                    /// <para>function_1</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The name of schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("schemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                }

                /// <summary>
                /// <para>The resources.</para>
                /// </summary>
                [NameInMap("resource")]
                [Validation(Required=false)]
                public List<GetPackageResponseBodyDataResourceListResource> Resource { get; set; }
                public class GetPackageResponseBodyDataResourceListResource : TeaModel {
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
                    /// <para>res_1</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The name of schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("schemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                }

                /// <summary>
                /// <para>The tables.</para>
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public List<GetPackageResponseBodyDataResourceListTable> Table { get; set; }
                public class GetPackageResponseBodyDataResourceListTable : TeaModel {
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
                    /// <para>dim_odps</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The name of schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("schemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                }

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
        /// <para>error message.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.</para>
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
        /// <para>0b57ff8316614119858417939e3e54</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
