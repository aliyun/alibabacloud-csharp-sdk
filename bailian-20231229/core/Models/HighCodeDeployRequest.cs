// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class HighCodeDeployRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>智能客服agent</para>
        /// </summary>
        [NameInMap("agentDesc")]
        [Validation(Required=false)]
        public string AgentDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000013</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mma_test_02</para>
        /// </summary>
        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx.whl</para>
        /// </summary>
        [NameInMap("sourceCodeName")]
        [Validation(Required=false)]
        public string SourceCodeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://bailian-application-developer-code.oss-cn-beijing.aliyuncs.com/xxxxx.whl">https://bailian-application-developer-code.oss-cn-beijing.aliyuncs.com/xxxxx.whl</a></para>
        /// </summary>
        [NameInMap("sourceCodeOssUrl")]
        [Validation(Required=false)]
        public string SourceCodeOssUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("telemetryEnabled")]
        [Validation(Required=false)]
        public bool? TelemetryEnabled { get; set; }

    }

}
