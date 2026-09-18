// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class GetAttackTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The scan target details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAttackTargetResponseBodyData Data { get; set; }
        public class GetAttackTargetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The advanced connection configuration (JSON character string). For common fields and provider configuration templates, refer to the ConnectionConfig parameter of CreateAttackTarget.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;httpMethod\&quot;:\&quot;POST\&quot;,\&quot;authType\&quot;:\&quot;bearer\&quot;,\&quot;timeoutMs\&quot;:30000,\&quot;requestTemplate\&quot;:\&quot;{\\\&quot;input\\\&quot;:{\\\&quot;prompt\\\&quot;:\\\&quot;{{prompt}}\\\&quot;},\\\&quot;parameters\\\&quot;:{\\\&quot;incremental_output\\\&quot;:true},\\\&quot;debug\\\&quot;:{}}\&quot;,\&quot;messageJsonPath\&quot;:\&quot;$.output.text\&quot;,\&quot;requestHeaders\&quot;:\&quot;{\\\&quot;X-DashScope-SSE\\\&quot;: \\\&quot;enable\\\&quot; }\&quot;,\&quot;stream\&quot;:true,\&quot;customAuthHeaderName\&quot;:\&quot;\&quot;}</para>
            /// </summary>
            [NameInMap("ConnectionConfig")]
            [Validation(Required=false)]
            public string ConnectionConfig { get; set; }

            /// <summary>
            /// <para>The connection protocol type of the target service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openai</para>
            /// </summary>
            [NameInMap("ConnectionMethod")]
            [Validation(Required=false)]
            public string ConnectionMethod { get; set; }

            /// <summary>
            /// <para>The time when the target was created. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the scan target. This value may be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Production Bailian application</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The HTTP or HTTPS endpoint of the target model service. When ConnectionMethod is set to enterprise_relay, this value is a fixed internal endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The time of the first scan. This value is a UNIX timestamp in milliseconds. This is an aggregate field that is not populated by this operation and returns an empty value. Refer to ListAttackTargets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// <para>The failure reason of the most recent scan task. This is an aggregate field that is not populated by this operation and returns an empty value. Refer to ListAttackTargets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Execution timed out</para>
            /// </summary>
            [NameInMap("LastScanFailMessage")]
            [Validation(Required=false)]
            public string LastScanFailMessage { get; set; }

            /// <summary>
            /// <para>The status of the most recent scan task. This is an aggregate field that is not populated by this operation and returns an empty value. Refer to ListAttackTargets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("LastScanStatus")]
            [Validation(Required=false)]
            public string LastScanStatus { get; set; }

            /// <summary>
            /// <para>The time of the most recent scan. This value is a UNIX timestamp in milliseconds. This is an aggregate field that is not populated by this operation and returns an empty value. Refer to ListAttackTargets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The name of the target model. When ConnectionMethod is set to enterprise_relay, this value is the fixed platform value Agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-flash</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The time when the target was last modified. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The business label of the model or agent provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The risk level of the task result. This is an aggregate field that is not populated by this operation and returns an empty value. Refer to ListAttackTargets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The cumulative number of scans. This is an aggregate field that is not populated by this operation and returns an empty value. For the meaning and example values, refer to the ListAttackTargets response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ScanCount")]
            [Validation(Required=false)]
            public long? ScanCount { get; set; }

            /// <summary>
            /// <para>The scan node configuration (JSON character string). Common fields include scanType (scan pattern: attack for security attack scan, tc260 for TC260 filing scan), scannerType (execute DPI engine: classic for per-sample execute, agent for multi-round autonomous attack), and sampleScope (sample scope: version for the current effective version, all for full samples). If the target is not configured, the default configurations are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;scanType&quot;:&quot;attack&quot;,&quot;scannerType&quot;:&quot;classic&quot;,&quot;sampleScope&quot;:&quot;all&quot;}</para>
            /// </summary>
            [NameInMap("ScanTaskConfig")]
            [Validation(Required=false)]
            public string ScanTaskConfig { get; set; }

            /// <summary>
            /// <para>The unique identifier of the scan target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>target-abc123def4567</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The display name of the scan target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My Bailian target</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The type of the scan target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-B7AB7B5A9C8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
