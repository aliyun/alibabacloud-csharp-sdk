// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class RetrieveResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Index.InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data field returned by the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RetrieveResponseBodyData Data { get; set; }
        public class RetrieveResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of matched text chunks.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyDataNodes> Nodes { get; set; }
            public class RetrieveResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <para>The metadata map of the text chunk.</para>
                /// <remarks>
                /// <para>The file_path field in the metadata map of a document search knowledge base is meaningless. Do not use it in your business code.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When you retrieve a document search knowledge base, if a chunk contains an image, the image is returned in the image_url field of the metadata map, along with an expiration time.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When you retrieve an audio and video search knowledge base, if a chunk contains audio, the audio is returned in the audio_url field of the metadata map, along with an expiration time.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When you retrieve an audio and video search knowledge base, if a chunk contains a video, the video is returned in the video_url field of the metadata map, along with an expiration time.</para>
                /// </remarks>
                /// <para>&lt;props=&quot;intl&quot;&gt;</para>
                /// <para>The metadata map of the text chunk.</para>
                /// <remarks>
                /// <para>The file_path field in the metadata map of a document search knowledge base is meaningless. Do not use it in your business code.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When you retrieve a document search knowledge base, if a chunk contains an image, the image is returned in the image_url field of the metadata map, along with an expiration time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;parent&quot;: &quot;&quot;,
                ///   &quot;file_path&quot;: &quot;https://<em><b>&quot;,
                ///   &quot;image_url&quot;: [
                ///     &quot;http://</b></em>&quot;
                ///   ],
                ///   &quot;nid&quot;: &quot;<em><b>&quot;,
                ///   &quot;title&quot;: &quot;Alibaba Cloud Model Studio Documentation&quot;,
                ///   &quot;doc_id&quot;: &quot;doc_</b></em>&quot;,
                ///   &quot;content&quot;: &quot;Alibaba Cloud Model Studio is a one-stop large model development platform based on Tongyi large models, industry large models, and third-party large models. It provides enterprise customers and individual developers with a complete set of model service tools and full-link application development kits, pre-installed with rich capability plugins, and offers convenient integration methods such as APIs and SDKs to efficiently build large model applications.&quot;,
                ///   &quot;workspace_id&quot;: &quot;ws_***&quot;,
                ///   &quot;hier_title&quot;: &quot;Alibaba Cloud Model Studio Documentation&quot;,
                ///   &quot;doc_name&quot;: &quot;Introduction to Alibaba Cloud Model Studio Documentation.pdpf&quot;,
                ///   &quot;pipeline_id&quot;: &quot;rhd***&quot;,
                ///   &quot;<em>id&quot;: &quot;ws</em>***&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public object Metadata { get; set; }

                /// <summary>
                /// <para>The similarity score of the text chunk. Valid values: 0 to 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>The content of the text chunk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud Model Studio is a one-stop large model development platform based on Tongyi large models, industry large models, and third-party large models. It provides enterprise customers and individual developers with a complete set of model service tools and full-link application development kits, pre-installed with rich capability plugins, and offers convenient integration methods such as APIs and SDKs to efficiently build large model applications</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Required parameter(%s) missing or invalid, please check the request parameters.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-7734-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The operation was successful.</description></item>
        /// <item><description>false: The operation failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
