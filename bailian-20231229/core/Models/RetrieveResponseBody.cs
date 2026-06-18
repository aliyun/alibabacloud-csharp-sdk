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
        /// <para>The business data returned by the API.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RetrieveResponseBodyData Data { get; set; }
        public class RetrieveResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array of retrieved text chunks.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyDataNodes> Nodes { get; set; }
            public class RetrieveResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <para>A map of metadata for the text chunk.</para>
                /// <remarks>
                /// <para>For document search knowledge bases, the <c>file_path</c> field in the metadata map is not applicable and should not be used in your application code.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When you retrieve data from a document search knowledge base, if a text chunk contains an image, its URL is returned in the <c>image_url</c> field of the metadata map. This URL expires.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When you retrieve data from an audio/video search knowledge base, if a text chunk contains audio, its URL is returned in the <c>audio_url</c> field of the metadata map. This URL expires.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When you retrieve data from an audio/video search knowledge base, if a text chunk contains video, its URL is returned in the <c>video_url</c> field of the metadata map. This URL expires.</para>
                /// </remarks>
                /// <para>&lt;props=&quot;intl&quot;&gt;</para>
                /// <para>A map of metadata for the text chunk.</para>
                /// <remarks>
                /// <para>For document search knowledge bases, the <c>file_path</c> field in the metadata map is not applicable and should not be used in your application code.</para>
                /// </remarks>
                /// <remarks>
                /// <para>When you retrieve data from a document search knowledge base, if a text chunk contains an image, its URL is returned in the <c>image_url</c> field of the metadata map. This URL expires.</para>
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
                ///   &quot;title&quot;: &quot;阿里云百炼文档&quot;,
                ///   &quot;doc_id&quot;: &quot;doc_</b></em>&quot;,
                ///   &quot;content&quot;: &quot;阿里云百炼是基于通义大模型、行业大模型以及三方大模型的一站式大模型开发平台。面向企业客户和个人开发者，提供完整的模型服务工具和全链路应用开发套件，预置丰富的能力插件，提供API及SDK等便捷的集成方式，高效完成大模型应用构建&quot;,
                ///   &quot;workspace_id&quot;: &quot;ws_***&quot;,
                ///   &quot;hier_title&quot;: &quot;阿里云百炼文档&quot;,
                ///   &quot;doc_name&quot;: &quot;阿里云百炼文档介绍.pdpf&quot;,
                ///   &quot;pipeline_id&quot;: &quot;rhd***&quot;,
                ///   &quot;<em>id&quot;: &quot;ws</em>***&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public object Metadata { get; set; }

                /// <summary>
                /// <para>The similarity score of the text chunk, ranging from 0 to 1.</para>
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
                /// <para>阿里云百炼是基于通义大模型、行业大模型以及三方大模型的一站式大模型开发平台。面向企业客户和个人开发者，提供完整的模型服务工具和全链路应用开发套件，预置丰富的能力插件，提供API及SDK等便捷的集成方式，高效完成大模型应用构建。</para>
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
        /// <para>The HTTP status code of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The call succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: The call failed.</para>
        /// </description></item>
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
