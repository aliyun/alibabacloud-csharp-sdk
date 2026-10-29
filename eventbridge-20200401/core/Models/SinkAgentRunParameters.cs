// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkAgentRunParameters : TeaModel {
        /// <summary>
        /// <para>The name of the AgentRun agent runtime. You can obtain it from the Alibaba Cloud AgentRun console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-demo-example</para>
        /// </summary>
        [NameInMap("AgentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        /// <summary>
        /// <para>The triplet configuration for the Body parameter template. It defines the data transformation method and supports two modes: ORIGINAL (pass-through) and TEMPLATE (template replacement).</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public SinkAgentRunParametersBody Body { get; set; }
        public class SinkAgentRunParametersBody : TeaModel {
            /// <summary>
            /// <para>The transformation format. Default value: CONSTANT. Valid values: ORIGINAL, TEMPLATE. Example: <c>ORIGINAL</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ORIGINAL</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template pattern. This parameter is required only when Form is set to TEMPLATE. It supports ${variable} placeholder replacement. Example: <c>The value of ${key} is ${value}!</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The parameter value. In ORIGINAL mode, the value is $. In TEMPLATE mode, the value is a key-value mapping in JSON format, where the value is a JSONPath expression or a constant. Example: <c>$</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The endpoint name of the AgentRun agent runtime, which is used to construct the invocation URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The name of the AgentRun agent role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-agent-role</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The HTTP request timeout period in milliseconds. Default value: 30000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public string Timeout { get; set; }

    }

}
