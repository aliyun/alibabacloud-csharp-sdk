// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskDetails")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyTaskDetails> TaskDetails { get; set; }
        public class ListTasksResponseBodyTaskDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-23T09:46:27Z</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>apply</para>
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Apply complete! Resources: 42 added, 0 changed, 0 destroyed.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>stdout</para>
                    /// </summary>
                    [NameInMap("Stream")]
                    [Validation(Required=false)]
                    public string Stream { get; set; }

                }

            }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<ListTasksResponseBodyTaskDetailsOutputs> Outputs { get; set; }
            public class ListTasksResponseBodyTaskDetailsOutputs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>The ECS instance ID.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>instance_id</para>
                /// </summary>
                [NameInMap("OutputKey")]
                [Validation(Required=false)]
                public string OutputKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-xxxxxx</para>
                /// </summary>
                [NameInMap("OutputValue")]
                [Validation(Required=false)]
                public string OutputValue { get; set; }

            }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<ListTasksResponseBodyTaskDetailsParameters> Parameters { get; set; }
            public class ListTasksResponseBodyTaskDetailsParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>instance_type</para>
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.s6-c1m1.small</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>port-bp1yt7582g****</para>
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pv-bp15e79d26****</para>
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pp-bp1ddg1n2a****</para>
            /// </summary>
            [NameInMap("ProvisionedProductId")]
            [Validation(Required=false)]
            public string ProvisionedProductId { get; set; }

            [NameInMap("ProvisionedProductName")]
            [Validation(Required=false)]
            public string ProvisionedProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Resource CREATE failed: terraform stack sc-146611588617****-pp-bp1ddg1n2a**** failure...</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>代表资源名称的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-bp1dmg242c****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>LaunchProduct</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-26T03:28:45Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
