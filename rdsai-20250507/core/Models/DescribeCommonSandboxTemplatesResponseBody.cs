// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeCommonSandboxTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that indicates the position from which the query starts. Set this parameter to empty to start from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLYz/NvD85HpgBeRBCusEIeVQ0dHZH9jr+NP3X9Jx0iSoql55b9nd4PIDm252/a0f+U=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sandbox templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeCommonSandboxTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeCommonSandboxTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The default number of CPUs for sandboxes created by using this template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefaultCpu")]
            [Validation(Required=false)]
            public string DefaultCpu { get; set; }

            /// <summary>
            /// <para>The default memory size for sandboxes created by using this template. The unit ends with Gi.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1Gi</para>
            /// </summary>
            [NameInMap("DefaultMemory")]
            [Validation(Required=false)]
            public string DefaultMemory { get; set; }

            /// <summary>
            /// <para>The default number of prewarmed sandboxes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefaultReplicas")]
            [Validation(Required=false)]
            public long? DefaultReplicas { get; set; }

            /// <summary>
            /// <para>The description of the sandbox template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Execute user-provided Python code in the sandbox environment. Runs any Python script the user provides and returns the output.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the sandbox template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desktop</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
