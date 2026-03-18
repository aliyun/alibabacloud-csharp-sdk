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

        [NameInMap("stackResults")]
        [Validation(Required=false)]
        public List<GetStackExecutionResultResponseBodyStackResults> StackResults { get; set; }
        public class GetStackExecutionResultResponseBodyStackResults : TeaModel {
            [NameInMap("deployments")]
            [Validation(Required=false)]
            public List<GetStackExecutionResultResponseBodyStackResultsDeployments> Deployments { get; set; }
            public class GetStackExecutionResultResponseBodyStackResultsDeployments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>prod</para>
                /// </summary>
                [NameInMap("deploymentName")]
                [Validation(Required=false)]
                public string DeploymentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Service returned null result</para>
                /// </summary>
                [NameInMap("jobResult")]
                [Validation(Required=false)]
                public string JobResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Applied</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://iacnext.console.aliyun.com/stack/stack-al181av2bloah5s53hacbp4/details?deploymentName=production&deploymentNo=6&configVersion=v1">https://iacnext.console.aliyun.com/stack/stack-al181av2bloah5s53hacbp4/details?deploymentName=production&amp;deploymentNo=6&amp;configVersion=v1</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>No corresponding Stack found.</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stack-al181av2bloah5s53hacbp4</para>
            /// </summary>
            [NameInMap("stackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stack-demo</para>
            /// </summary>
            [NameInMap("stackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("stackStatus")]
            [Validation(Required=false)]
            public string StackStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>event-xxx</para>
        /// </summary>
        [NameInMap("triggerId")]
        [Validation(Required=false)]
        public string TriggerId { get; set; }

    }

}
