// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetPackageResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPackageResponseBodyData Data { get; set; }
        public class GetPackageResponseBodyData : TeaModel {
            /// <summary>
            /// The projects in which the package is installed.
            /// </summary>
            [NameInMap("allowedProjectList")]
            [Validation(Required=false)]
            public List<GetPackageResponseBodyDataAllowedProjectList> AllowedProjectList { get; set; }
            public class GetPackageResponseBodyDataAllowedProjectList : TeaModel {
                /// <summary>
                /// The security level for sensitive data.
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The name of the MaxCompute project.
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

            }

            /// <summary>
            /// The details of the resources that are included in the package.
            /// </summary>
            [NameInMap("resourceList")]
            [Validation(Required=false)]
            public GetPackageResponseBodyDataResourceList ResourceList { get; set; }
            public class GetPackageResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// The functions.
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public List<GetPackageResponseBodyDataResourceListFunction> Function { get; set; }
                public class GetPackageResponseBodyDataResourceListFunction : TeaModel {
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

                    [NameInMap("schemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                }

                /// <summary>
                /// The resources.
                /// </summary>
                [NameInMap("resource")]
                [Validation(Required=false)]
                public List<GetPackageResponseBodyDataResourceListResource> Resource { get; set; }
                public class GetPackageResponseBodyDataResourceListResource : TeaModel {
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

                    [NameInMap("schemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                }

                /// <summary>
                /// The tables.
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public List<GetPackageResponseBodyDataResourceListTable> Table { get; set; }
                public class GetPackageResponseBodyDataResourceListTable : TeaModel {
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

                    [NameInMap("schemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                }

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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
