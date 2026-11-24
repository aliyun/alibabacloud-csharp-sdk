// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetAIAppJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("AIAppJob")]
        [Validation(Required=false)]
        public GetAIAppJobResponseBodyAIAppJob AIAppJob { get; set; }
        public class GetAIAppJobResponseBodyAIAppJob : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-06T02:06:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the task was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-06T16:59:25Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2880a70cec1414cac476bce0bd39ad7</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The node results of the workflow task. The results are in JSON format and vary based on the workflow configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Key\&quot;:\&quot;Value\&quot;}</para>
            /// </summary>
            [NameInMap("NodeResults")]
            [Validation(Required=false)]
            public string NodeResults { get; set; }

            /// <summary>
            /// <para>The task outputs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Status\&quot;:\&quot;Success\&quot;}</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>init: The task is created.</description></item>
            /// <item><description>running: The task is running.</description></item>
            /// <item><description>succeeded: The task succeeded.</description></item>
            /// <item><description>failed: The task failed.</description></item>
            /// <item><description>stopped: The task is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The custom information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Key\&quot;:\&quot;Value\&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The output assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;Status&quot;: &quot;completed&quot;,
        ///     &quot;Type&quot;: &quot;image&quot;,
        ///     &quot;Url&quot;: &quot;xxx&quot;,
        ///     &quot;Name&quot;: &quot;blue.png&quot;
        ///   },
        ///   {
        ///     &quot;Status&quot;: &quot;completed&quot;,
        ///     &quot;Type&quot;: &quot;image&quot;,
        ///     &quot;Url&quot;: &quot;xxx&quot;,
        ///     &quot;Name&quot;: &quot;red.png&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("Artifacts")]
        [Validation(Required=false)]
        public List<GetAIAppJobResponseBodyArtifacts> Artifacts { get; set; }
        public class GetAIAppJobResponseBodyArtifacts : TeaModel {
            /// <summary>
            /// <para>The asset ID, which is the media asset ID obtained after registration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx77i16crgqtn96ip914bmixxxx</para>
            /// </summary>
            [NameInMap("AssetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>The asset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_00x</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The asset status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The asset type. Valid values: image, audio, video, document, and text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The asset URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/imgextra/i1/O1CN0157aHKQ1LlJ45vCQ8w_!!6000000001339-0-tps-1080-773.jpg">https://img.alicdn.com/imgextra/i1/O1CN0157aHKQ1LlJ45vCQ8w_!!6000000001339-0-tps-1080-773.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
