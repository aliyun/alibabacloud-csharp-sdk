// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about executions.</para>
        /// </summary>
        [NameInMap("Executions")]
        [Validation(Required=false)]
        public List<ListExecutionsResponseBodyExecutions> Executions { get; set; }
        public class ListExecutionsResponseBodyExecutions : TeaModel {
            [NameInMap("Environment")]
            [Validation(Required=false)]
            public ListExecutionsResponseBodyExecutionsEnvironment Environment { get; set; }
            public class ListExecutionsResponseBodyExecutionsEnvironment : TeaModel {
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<ListExecutionsResponseBodyExecutionsEnvironmentVariables> Variables { get; set; }
                public class ListExecutionsResponseBodyExecutionsEnvironmentVariables : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The definition of the flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version: v1.0\ntype: flow\nname: test\nsteps:\n  - type: pass\n    name: mypass</para>
            /// </summary>
            [NameInMap("FlowDefinition")]
            [Validation(Required=false)]
            public string FlowDefinition { get; set; }

            /// <summary>
            /// <para>The name of the flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flow</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// <para>The input of the execution, which is in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            /// <summary>
            /// <para>The name of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output of the execution, which is in the JSON format</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The time when the execution started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-01T01:01:01.001Z</para>
            /// </summary>
            [NameInMap("StartedTime")]
            [Validation(Required=false)]
            public string StartedTime { get; set; }

            /// <summary>
            /// <para>The status of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the execution stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-01T01:01:01.001Z</para>
            /// </summary>
            [NameInMap("StoppedTime")]
            [Validation(Required=false)]
            public string StoppedTime { get; set; }

        }

        /// <summary>
        /// <para>The start key for the next query. This parameter is not returned if this is the last query.</para>
        /// <remarks>
        /// <para> This parameter may not be displayed in the response because no next page exists.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>exec2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRequestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
