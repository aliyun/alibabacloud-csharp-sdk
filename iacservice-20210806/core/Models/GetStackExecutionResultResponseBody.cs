// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetStackExecutionResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2D40488-3F74-568B-87EC-1C04D098DF8B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution results of the triggered Stacks.</para>
        /// </summary>
        [NameInMap("stackResults")]
        [Validation(Required=false)]
        public List<GetStackExecutionResultResponseBodyStackResults> StackResults { get; set; }
        public class GetStackExecutionResultResponseBodyStackResults : TeaModel {
            /// <summary>
            /// <para>The deployment results of the Stack.</para>
            /// </summary>
            [NameInMap("deployments")]
            [Validation(Required=false)]
            public List<GetStackExecutionResultResponseBodyStackResultsDeployments> Deployments { get; set; }
            public class GetStackExecutionResultResponseBodyStackResultsDeployments : TeaModel {
                /// <summary>
                /// <para>The deployment name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod</para>
                /// </summary>
                [NameInMap("deploymentName")]
                [Validation(Required=false)]
                public string DeploymentName { get; set; }

                /// <summary>
                /// <para>The result of the deployment task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Service returned null result</para>
                /// </summary>
                [NameInMap("jobResult")]
                [Validation(Required=false)]
                public string JobResult { get; set; }

                /// <summary>
                /// <para>The deployment status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Applied</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The URL for viewing deployment details.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://iacnext.console.aliyun.com/stack/stack-al181av2bloah5s53hacbp4/details?deploymentName=production&deploymentNo=6&configVersion=v1">https://iacnext.console.aliyun.com/stack/stack-al181av2bloah5s53hacbp4/details?deploymentName=production&amp;deploymentNo=6&amp;configVersion=v1</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Error code of the stack execution</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No corresponding Stack found.</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The unique identifier of the Stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-al181av2bloah5s53hacbp4</para>
            /// </summary>
            [NameInMap("stackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <para>The Stack name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-demo</para>
            /// </summary>
            [NameInMap("stackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// <para>The execution status of the Stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("stackStatus")]
            [Validation(Required=false)]
            public string StackStatus { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>event-xxx</para>
        /// </summary>
        [NameInMap("triggerId")]
        [Validation(Required=false)]
        public string TriggerId { get; set; }

        /// <summary>
        /// <para>The overall execution status of this trigger task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Waiting: Processing.</description></item>
        /// <item><description>Success: Processing succeeded.</description></item>
        /// <item><description>Errored: Processing failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("triggeredStatus")]
        [Validation(Required=false)]
        public string TriggeredStatus { get; set; }

    }

}
