// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStacksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FBAC80B4-9C27-529D-BC9C-4155FA5CD7A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the stacks.</para>
        /// </summary>
        [NameInMap("Stacks")]
        [Validation(Required=false)]
        public List<ListStacksResponseBodyStacks> Stacks { get; set; }
        public class ListStacksResponseBodyStacks : TeaModel {
            /// <summary>
            /// <para>The time when the stack was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-10T06:44:36</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled for the stack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: Deletion protection is enabled for the stack.</description></item>
            /// <item><description>Disabled: Deletion protection is disabled for the stack. In this case, you can delete the stack by using the console or calling the <a href="https://help.aliyun.com/document_detail/610812.html">DeleteStack</a> operation.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Deletion protection of a nested stack is the same as that of its root stack.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public string DeletionProtection { get; set; }

            /// <summary>
            /// <para>Indicates whether rollback is disabled when the stack fails to be created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableRollback")]
            [Validation(Required=false)]
            public bool? DisableRollback { get; set; }

            /// <summary>
            /// <para>The time when the most recent successful drift detection was performed on the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-10T06:46:36</para>
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// <para>The supplementary information that is returned if an error occurs on a stack operation.</para>
            /// <remarks>
            /// <para> This parameter is returned only under specific conditions, and is returned together with at least one sub-parameter. For example, an error occurred when an API operation of another Alibaba Cloud service was called.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("OperationInfo")]
            [Validation(Required=false)]
            public ListStacksResponseBodyStacksOperationInfo OperationInfo { get; set; }
            public class ListStacksResponseBodyStacksOperationInfo : TeaModel {
                /// <summary>
                /// <para>The name of the API operation that belongs to another Alibaba Cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DeleteSecurityGroup</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DependencyViolation</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The logical ID of the resource on which the operation error occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EcsSecurityGroup</para>
                /// </summary>
                [NameInMap("LogicalResourceId")]
                [Validation(Required=false)]
                public string LogicalResourceId { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>There is still instance(s) in the specified security group.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the request that is initiated to call the API operation of another Alibaba Cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>071D6166-3F6B-5C7B-A1F0-0113FBB643A8</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The type of the resource on which the operation error occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::SecurityGroup</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the parent stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf692****</para>
            /// </summary>
            [NameInMap("ParentStackId")]
            [Validation(Required=false)]
            public string ParentStackId { get; set; }

            /// <summary>
            /// <para>The region ID of the stack. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2frunvw7****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the stack is a managed stack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The name of the service to which the managed stack belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACVS</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The state of the stack on which the most recent successful drift detection was performed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DRIFTED: The stack has drifted.</description></item>
            /// <item><description>NOT_CHECKED: No successful drift detection is performed on the stack.</description></item>
            /// <item><description>IN_SYNC: The stack is being synchronized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN_SYNC</para>
            /// </summary>
            [NameInMap("StackDriftStatus")]
            [Validation(Required=false)]
            public string StackDriftStatus { get; set; }

            /// <summary>
            /// <para>The stack ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67805444-a605-45ee-a57f-83908ff6****</para>
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <para>The stack name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyStack</para>
            /// </summary>
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// <para>The stack type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ROS: ROS stack. The stack is created by using a ROS template.</description></item>
            /// <item><description>Terraform: Terraform stack. The stack is created by using a Terraform template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROS</para>
            /// </summary>
            [NameInMap("StackType")]
            [Validation(Required=false)]
            public string StackType { get; set; }

            /// <summary>
            /// <para>The state of the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the stack is in its current state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Stack CREATE completed successfully</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The tags of the stack.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListStacksResponseBodyStacksTags> Tags { get; set; }
            public class ListStacksResponseBodyStacksTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the stack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:rm:rgId</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the stack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2frunvw7****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The timeout period for creating the stack. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=false)]
            public int? TimeoutInMinutes { get; set; }

            /// <summary>
            /// <para>The time when the stack was updated. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-10T07:44:36</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of stacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
