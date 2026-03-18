// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetPackageResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPackageResponseBodyData Data { get; set; }
        public class GetPackageResponseBodyData : TeaModel {
            [NameInMap("allowedProjectList")]
            [Validation(Required=false)]
            public List<GetPackageResponseBodyDataAllowedProjectList> AllowedProjectList { get; set; }
            public class GetPackageResponseBodyDataAllowedProjectList : TeaModel {
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

            }

            [NameInMap("resourceList")]
            [Validation(Required=false)]
            public GetPackageResponseBodyDataResourceList ResourceList { get; set; }
            public class GetPackageResponseBodyDataResourceList : TeaModel {
                [NameInMap("function")]
                [Validation(Required=false)]
                public List<GetPackageResponseBodyDataResourceListFunction> Function { get; set; }
                public class GetPackageResponseBodyDataResourceListFunction : TeaModel {
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
                public List<GetPackageResponseBodyDataResourceListResource> Resource { get; set; }
                public class GetPackageResponseBodyDataResourceListResource : TeaModel {
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
                public List<GetPackageResponseBodyDataResourceListTable> Table { get; set; }
                public class GetPackageResponseBodyDataResourceListTable : TeaModel {
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
