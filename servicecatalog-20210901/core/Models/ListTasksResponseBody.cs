// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListTasksResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskDetails")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyTaskDetails> TaskDetails { get; set; }
        public class ListTasksResponseBodyTaskDetails : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Log")]
            [Validation(Required=false)]
            public ListTasksResponseBodyTaskDetailsLog Log { get; set; }
            public class ListTasksResponseBodyTaskDetailsLog : TeaModel {
                [NameInMap("TerraformLogs")]
                [Validation(Required=false)]
                public List<ListTasksResponseBodyTaskDetailsLogTerraformLogs> TerraformLogs { get; set; }
                public class ListTasksResponseBodyTaskDetailsLogTerraformLogs : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Stream")]
                    [Validation(Required=false)]
                    public string Stream { get; set; }

                }

            }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<ListTasksResponseBodyTaskDetailsOutputs> Outputs { get; set; }
            public class ListTasksResponseBodyTaskDetailsOutputs : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("OutputKey")]
                [Validation(Required=false)]
                public string OutputKey { get; set; }

                [NameInMap("OutputValue")]
                [Validation(Required=false)]
                public string OutputValue { get; set; }

            }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<ListTasksResponseBodyTaskDetailsParameters> Parameters { get; set; }
            public class ListTasksResponseBodyTaskDetailsParameters : TeaModel {
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            [NameInMap("ProvisionedProductId")]
            [Validation(Required=false)]
            public string ProvisionedProductId { get; set; }

            [NameInMap("ProvisionedProductName")]
            [Validation(Required=false)]
            public string ProvisionedProductName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
