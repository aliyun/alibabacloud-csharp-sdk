// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListChunksResponseBody : TeaModel {
        /// <summary>
        /// <para>The error status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Index.InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned by the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListChunksResponseBodyData Data { get; set; }
        public class ListChunksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of text chunks.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListChunksResponseBodyDataNodes> Nodes { get; set; }
            public class ListChunksResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <para>The metadata map of the text chunk.</para>
                /// <remarks>
                /// <para>The <c>file_path</c> field in the metadata map of document search knowledge bases is meaningless. Do not use it in your business code.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When retrieving a document search knowledge base, if a chunk contains an image, the image is returned through the <c>image_url</c> field in the metadata map, along with an expiration time.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When retrieving an audio/video search knowledge base, if a chunk contains audio, the audio is returned through the <c>audio_url</c> field in the metadata map, along with an expiration time.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When retrieving an audio/video search knowledge base, if a chunk contains video, the video is returned through the <c>video_url</c> field in the metadata map, along with an expiration time.</para>
                /// </remarks>
                /// <para>&lt;props=&quot;intl&quot;&gt;</para>
                /// <para>The metadata map of the text chunk.</para>
                /// <remarks>
                /// <para>The <c>file_path</c> field in the metadata map of document search knowledge bases is meaningless. Do not use it in your business code.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When retrieving a document search knowledge base, if a chunk contains an image, the image is returned through the <c>image_url</c> field in the metadata map, along with an expiration time.</para>
                /// </remarks>
                /// <para>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;file_path&quot;: &quot;<a href="https://bailian-">https://bailian-</a><em><b>&quot;,
                ///   &quot;parent&quot;: &quot;阿里云百炼是一站式的大模型开发及应用构建平台。不论是开发者还是业务人员，都能深入参与大模型应用的设计和构建。您可以通过简单的界面操作，在 5分钟内开发出一款大模型应用，或在几小时内训练出一个专属模型，从而将更多精力专注于应用创新。&quot;,
                ///   &quot;is_displayed_chunk_content&quot;: &quot;true&quot;,
                ///   &quot;image_url&quot;: [],
                ///   &quot;nid&quot;: &quot;83</b></em>&quot;,
                ///   &quot;source&quot;: &quot;0&quot;,
                ///   &quot;_score&quot;: 0,
                ///   &quot;title&quot;: &quot;&quot;,
                ///   &quot;doc_id&quot;: &quot;file_24e***&quot;,
                ///   &quot;content&quot;: &quot;阿里云百炼是一站式的大模型开发及应用构建平台。不论是开发者还是业务人员，都能深入参与大模型应用的设计和构建。您可以通过简单的界面操作，在 5分钟内开发出一款大模型应用，或在几小时内训练出一个专属模型，从而将更多精力专注于应用创新。&quot;,
                ///   &quot;_rc_score&quot;: 0,
                ///   &quot;workspace_id&quot;: &quot;llm-zna***&quot;,
                ///   &quot;hier_title&quot;: &quot;&quot;,
                ///   &quot;doc_name&quot;: &quot;什么是阿里云百炼&quot;,
                ///   &quot;pipeline_id&quot;: &quot;j6b***&quot;,
                ///   &quot;_id&quot;: &quot;llm-zna5***&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public object Metadata { get; set; }

                /// <summary>
                /// <para>The similarity score of the text chunk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>The content of the text chunk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里云百炼是一站式的大模型开发及应用构建平台。不论是开发者还是业务人员，都能深入参与大模型应用的设计和构建。您可以通过简单的界面操作，在 5分钟内开发出一款大模型应用，或在几小时内训练出一个专属模型，从而将更多精力专注于应用创新。</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The total number of returned results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
        /// <para>8F97A63B-xxxx-527F-9D6E-467B6A7E8CF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code returned by the operation.</para>
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
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
