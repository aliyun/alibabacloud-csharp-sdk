// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class InitiatePptCreationV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public InitiatePptCreationV2ResponseBodyData Data { get; set; }
        public class InitiatePptCreationV2ResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An alert message related to service usage or status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>本月版本内的配送额度已经用尽，超额使用将走按量后付费，下个月配送额度将重新下发；请知晓</para>
            /// </summary>
            [NameInMap("Alert")]
            [Validation(Required=false)]
            public string Alert { get; set; }

            /// <summary>
            /// <para>The AppKey for initializing the front-end component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S1X5ecouBztZelaQ</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The ID of the export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66b25058-d735-47e5-a534-5da93453d3df</para>
            /// </summary>
            [NameInMap("ExportTaskId")]
            [Validation(Required=false)]
            public string ExportTaskId { get; set; }

            /// <summary>
            /// <para>The URL of the artifact cover.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://a.com/xxx.png">http://a.com/xxx.png</a></para>
            /// </summary>
            [NameInMap("PptArtifactCover")]
            [Validation(Required=false)]
            public string PptArtifactCover { get; set; }

            /// <summary>
            /// <para>The artifact ID. Use this ID to edit the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53059801</para>
            /// </summary>
            [NameInMap("PptArtifactId")]
            [Validation(Required=false)]
            public string PptArtifactId { get; set; }

            /// <summary>
            /// <para>The process ID for creating the PPT, used to initialize the front-end component for artifact creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8485143</para>
            /// </summary>
            [NameInMap("PptProcessId")]
            [Validation(Required=false)]
            public string PptProcessId { get; set; }

            /// <summary>
            /// <para>The signature for initializing the front-end component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dBBGvT0Toje5887Qw+/IwwMNYfk=</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>错误消息</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
