// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class StartChatRequest : TeaModel {
        /// <summary>
        /// <para>Set this parameter to V2 to route requests to the ROS Agent V2 backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V2</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>The array of image attachments. A maximum of 5 attachments are supported. Currently, only the image type is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Type&quot;:&quot;image&quot;,&quot;MimeType&quot;:&quot;image/png&quot;,&quot;Name&quot;:&quot;topology.png&quot;,&quot;OssObjectKey&quot;:&quot;user-id/attachments/topology.png&quot;}]</para>
        /// </summary>
        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public List<StartChatRequestAttachments> Attachments { get; set; }
        public class StartChatRequestAttachments : TeaModel {
            /// <summary>
            /// <para>The image media type. Valid values: image/png, image/jpeg, image/webp, and image/gif.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image/png</para>
            /// </summary>
            [NameInMap("MimeType")]
            [Validation(Required=false)]
            public string MimeType { get; set; }

            /// <summary>
            /// <para>The attachment file name. If this parameter is not specified, the file name is obtained from OssObjectKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topology.png</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The OSS object key under the current user directory. The value cannot contain absolute paths or path traversal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-id/attachments/topology.png</para>
            /// </summary>
            [NameInMap("OssObjectKey")]
            [Validation(Required=false)]
            public string OssObjectKey { get; set; }

            /// <summary>
            /// <para>The attachment type. V2 currently supports only image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>V2 does not support direct URL upload. Use OssObjectKey instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/topology.png">https://example.com/topology.png</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>A compatibility field. V2 always returns event streams through SSE. The current service does not consume this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePartialMessage")]
        [Validation(Required=false)]
        public bool? EnablePartialMessage { get; set; }

        /// <summary>
        /// <para>Specifies whether to output thinking content. Default value: true. This parameter can be reset per request when re-entering the same session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableThinking")]
        [Validation(Required=false)]
        public bool? EnableThinking { get; set; }

        /// <summary>
        /// <para>V2 supports only IaCCodeNormal or IaCCodePipeline. The default value for a new session is IaCCodeNormal. An existing session cannot switch modes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IaCCodeNormal</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The user input. The value cannot be empty or contain only whitespace characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create an ROS template with a VPC and a VSwitch</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The region ID for this resource operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>If this parameter is not specified, a new session is created. If this parameter is specified, the existing session of the current user is continued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7f4e2a8c6d9b4a1f8e3c5b7d2a6f9012</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
