// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class ListAttackTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of scan targets on the current page.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAttackTargetsResponseBodyData> Data { get; set; }
        public class ListAttackTargetsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The advanced connection configuration for the target (JSON character string). For common fields and provider configuration templates, see the ConnectionConfig parameter description of the CreateAttackTarget operation.</para>
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
            /// <para>The time when the target was created. The value is a millisecond-level UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the scan target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Production Bailian application</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The HTTP or HTTPS endpoint address of the target model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The time when the first scan was performed. The value is a millisecond-level UNIX timestamp. This parameter is null if no scan has been performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// <para>The failure reason of the most recent scan task. This parameter is empty if the most recent scan did not fail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scan executor connection timed out</para>
            /// </summary>
            [NameInMap("LastScanFailMessage")]
            [Validation(Required=false)]
            public string LastScanFailMessage { get; set; }

            /// <summary>
            /// <para>The detection status of the most recent scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("LastScanStatus")]
            [Validation(Required=false)]
            public string LastScanStatus { get; set; }

            /// <summary>
            /// <para>The time when the last scan was performed. The value is a millisecond-level UNIX timestamp. This parameter is null if no scan has been performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735689600000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The detailed message of the most recent connectivity verification. If the verification succeeded, the value is a response content snippet returned by the target service. If the verification failed, the value is the error reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connectivity verification succeeded</para>
            /// </summary>
            [NameInMap("LastVerifyMessage")]
            [Validation(Required=false)]
            public string LastVerifyMessage { get; set; }

            /// <summary>
            /// <para>The name of the target model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-flash</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The time when the target was last modified. The value is a millisecond-level UNIX timestamp.</para>
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
            /// <para>The risk level derived from the most recent completed scan task. This parameter is null if no scan has been performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The total number of scans performed. The value is 0 if no scan has been performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ScanCount")]
            [Validation(Required=false)]
            public long? ScanCount { get; set; }

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

            /// <summary>
            /// <para>The connectivity verification status of the target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verified</para>
            /// </summary>
            [NameInMap("VerifyStatus")]
            [Validation(Required=false)]
            public string VerifyStatus { get; set; }

        }

        /// <summary>
        /// <para>The normalized page number that takes effect. The value may differ from the input parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The normalized number of entries per page that takes effect. The value may differ from the input parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of scan targets that match the filter conditions. In post-filtering scenarios, this value is the total count after in-memory filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
