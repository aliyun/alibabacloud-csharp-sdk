// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261121.Models
{
    public class ChatResponseBody : TeaModel {
        /// <summary>
        /// <para>开通 HTTP 音频输出后，完整 JSON 可在 audioFrames 中返回音频帧。type 为 audio 时，data 为 Base64 音频数据，last 为布尔末帧标识。type 为 error 时可含 code、requestId 和 message。无音频时可为空或省略。</para>
        /// </summary>
        [NameInMap("audioFrames")]
        [Validation(Required=false)]
        public List<ChatResponseBodyAudioFrames> AudioFrames { get; set; }
        public class ChatResponseBodyAudioFrames : TeaModel {
            /// <summary>
            /// <para>音频处理失败时可能提供。</para>
            /// 
            /// <b>Example:</b>
            /// <para>DOWNSTREAM_ERROR</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>音频帧的 Base64 数据。末帧的值可以为空字符串。</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUQz</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>true 表示本路音频的最后一帧。</para>
            /// </summary>
            [NameInMap("last")]
            [Validation(Required=false)]
            public bool? Last { get; set; }

            /// <summary>
            /// <para>音频处理失败时按实际错误返回。</para>
            /// 
            /// <b>Example:</b>
            /// <para>语音合成暂不可用</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>用于关联音频错误与本次业务请求。</para>
            /// 
            /// <b>Example:</b>
            /// <para>req-example-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>audio 表示音频，error 表示处理失败。</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>用于关联响应帧与原业务请求和会话的信息。</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public ChatResponseBodyCommunication Communication { get; set; }
        public class ChatResponseBodyCommunication : TeaModel {
            /// <summary>
            /// <para>当前响应所属的业务请求 ID，返回时与请求中的 communication.requestId 一致。</para>
            /// 
            /// <b>Example:</b>
            /// <para>req-example-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>可选整数，业务响应帧标识；网关多帧聚合可为0。不代表可对所有网络帧排序的序列号，也不是会话或请求ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("responseId")]
            [Validation(Required=false)]
            public long? ResponseId { get; set; }

            /// <summary>
            /// <para>当前响应所属的客户会话 ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>session-example-001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>可选业务对象，字段按实际响应出现。单帧 HTTP 音频响应的 data 也可能直接为 Base64 字符串；多态音频完整形状见接口说明。客户端不得假定固定字段全部存在。</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ChatResponseBodyData Data { get; set; }
        public class ChatResponseBodyData : TeaModel {
            /// <summary>
            /// <para>可选业务调试信息，可省略或为 null。在支持的联调场景中可能包含 intentLabel；具体结构和返回时机按实际响应读取。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;intentLabel&quot;:&quot;image_search&quot;}</para>
            /// </summary>
            [NameInMap("debug")]
            [Validation(Required=false)]
            public object Debug { get; set; }

            /// <summary>
            /// <para>业务响应附带的可选扩展信息。inputResources 是本轮输入资源的处理结果数组，元素可含 contentIndex、type、resourceId、url 和 fileName。contentIndex 是原始消息 content 数组的零起始下标，文本块也计数。</para>
            /// </summary>
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public ChatResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class ChatResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// <para>仅在响应提供本轮输入资源处理结果时返回。</para>
                /// </summary>
                [NameInMap("inputResources")]
                [Validation(Required=false)]
                public List<ChatResponseBodyDataExtraInfoInputResources> InputResources { get; set; }
                public class ChatResponseBodyDataExtraInfoInputResources : TeaModel {
                    /// <summary>
                    /// <para>从零开始，按原始 content 数组计数，包含文本块。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("contentIndex")]
                    [Validation(Required=false)]
                    public int? ContentIndex { get; set; }

                    /// <summary>
                    /// <para>有文件名时返回。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cat.png</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>本轮输入资源的标识，用于关联对应资源。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ws_example_001</para>
                    /// </summary>
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>原始内容块对应的资源类型。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>image</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>本轮输入资源的可访问地址。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://cdn.example.com/uploads/cat.png">https://cdn.example.com/uploads/cat.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>可选数组，可能含多条正文、过程或卡片消息。multi_load/iframe 文本为累计快照，不将每帧全文重复拼接；不要固定只取 messages[0]。</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<ChatResponseBodyDataMessages> Messages { get; set; }
            public class ChatResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>可选多态内容，按 mimeType 解析。multi_load/iframe 常为累计文本快照；后帧更新当前内容。过程、卡片按各自类型处理，不把任意 content 强转字符串。</para>
                /// 
                /// <b>Example:</b>
                /// <para>图片如下[(image_waterfall_1)]</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public object Content { get; set; }

                /// <summary>
                /// <para>可选、可扩展的消息元数据。正文消息可通过 multiLoad 提供卡片；过程消息可按类型包含 sourceSeq、type、barTitle、content，用于关联和展示相应内容。</para>
                /// </summary>
                [NameInMap("metaData")]
                [Validation(Required=false)]
                public ChatResponseBodyDataMessagesMetaData MetaData { get; set; }
                public class ChatResponseBodyDataMessagesMetaData : TeaModel {
                    /// <summary>
                    /// <para>用于展示当前过程的上下文标题。处理状态见对应消息的 status。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>问题分析</para>
                    /// </summary>
                    [NameInMap("barTitle")]
                    [Validation(Required=false)]
                    public string BarTitle { get; set; }

                    /// <summary>
                    /// <para>数据结构随模块类型变化。bar/progress 中，思考过程使用 body，工具和结束提示使用 title，过程中检索资料或图片分别使用 docs、images。完整键和示例见接入说明。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;body&quot;:&quot;正在分析问题&quot;,&quot;status&quot;:&quot;processing&quot;}</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public object Content { get; set; }

                    /// <summary>
                    /// <para>与正文关联的结构化内容列表，例如图文卡片，按消息类型返回。</para>
                    /// </summary>
                    [NameInMap("multiLoad")]
                    [Validation(Required=false)]
                    public List<ChatResponseBodyDataMessagesMetaDataMultiLoad> MultiLoad { get; set; }
                    public class ChatResponseBodyDataMessagesMetaDataMultiLoad : TeaModel {
                        /// <summary>
                        /// <para>可选，结构随卡片类型变化。图文卡片可含资源列表。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;list&quot;:[{&quot;imageUrl&quot;:&quot;<a href="https://images.example.com/cat.png%22%7D%5D%7D">https://images.example.com/cat.png&quot;}]}</a></para>
                        /// </summary>
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public object Content { get; set; }

                        /// <summary>
                        /// <para>与正文中的卡片引用关联。相同标识代表同一卡片。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>image_waterfall_1</para>
                        /// </summary>
                        [NameInMap("sourceSeq")]
                        [Validation(Required=false)]
                        public string SourceSeq { get; set; }

                        /// <summary>
                        /// <para>按类型选择卡片展示组件。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>image_waterfall</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>按本次请求和 sourceSeq 关联同一模块的更新。新的完整快照替换旧快照。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>thinking-1</para>
                    /// </summary>
                    [NameInMap("sourceSeq")]
                    [Validation(Required=false)]
                    public string SourceSeq { get; set; }

                    /// <summary>
                    /// <para>例如 bar_thinking、bar_tool、bar_think_finish、bar_ref_source_inline 或 bar_image_inline。按实际类型选择展示组件。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bar_thinking</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>消息类型，按此值解析正文、进度及可选信号和追问。常见类型见接入说明。</para>
                /// 
                /// <b>Example:</b>
                /// <para>multi_load/iframe</para>
                /// </summary>
                [NameInMap("mimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <para>可选消息状态，如 processing、complete；complete 只结束该消息，不替代 SSE event:complete。HTTP200 或单条消息complete都不足以判定整次流成功。</para>
                /// 
                /// <b>Example:</b>
                /// <para>complete</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>可选错误对象，出现时按失败处理。准备阶段可用错误HTTP状态+JSON返回；已识别业务错误可保留HTTP200，SSE首帧提交后用错误终帧表达。优先结合HTTP X-Request-Id关联。</para>
        /// </summary>
        [NameInMap("error")]
        [Validation(Required=false)]
        public ChatResponseBodyError Error { get; set; }
        public class ChatResponseBodyError : TeaModel {
            /// <summary>
            /// <para>可选的错误码，可为字符串或数值，表示服务或 Agent 的具体错误类型。程序应按 code 判断，不依赖 message 全文；数值业务码 500 不代表 HTTP 状态一定为 500。</para>
            /// 
            /// <b>Example:</b>
            /// <para>INVALID_REQUEST</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public object Code { get; set; }

            /// <summary>
            /// <para>业务错误的说明文本。</para>
            /// 
            /// <b>Example:</b>
            /// <para>请求参数无效</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>失败调用的业务请求关联号，用于定位问题。</para>
            /// 
            /// <b>Example:</b>
            /// <para>req-example-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>可选字符串或数值，成功业务响应可为数字0；非零或失败码按错误处理。未返回本字段不自动判失败，须综合 error、HTTP 和流终帧。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public object ErrorCode { get; set; }

        /// <summary>
        /// <para>与响应顶层业务状态码对应的说明。</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>响应顶层可选的业务请求关联号。POP 请求号由响应头 x-acs-request-id 提供。</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-example-001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
