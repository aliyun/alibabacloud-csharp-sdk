// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BMed20261121.Models
{
    public class MedicalModelInferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>可选的聚合音频帧列表。若返回音频，正常帧可含 type=audio、Base64 字符串 data 和布尔值 last，正常末帧的 data 可为空字符串。失败帧可含 type=error、code、requestId、last 和可选 message。各帧字段依类型而定。</para>
        /// </summary>
        [NameInMap("audioFrames")]
        [Validation(Required=false)]
        public List<MedicalModelInferenceResponseBodyAudioFrames> AudioFrames { get; set; }
        public class MedicalModelInferenceResponseBodyAudioFrames : TeaModel {
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
            /// <para>AAEC</para>
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
            /// <para>音频生成失败</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>用于关联音频错误与本次业务请求。</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-req-001</para>
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
        /// <para>关联原请求及会话的标识。</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public MedicalModelInferenceResponseBodyCommunication Communication { get; set; }
        public class MedicalModelInferenceResponseBodyCommunication : TeaModel {
            /// <summary>
            /// <para>对应请求中的 communication.requestId，便于匹配并发请求。</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-req-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>业务响应帧标识。一次完整 JSON 聚合时可为 0。SSE 按事件到达顺序处理，responseId 无需连续。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("responseId")]
            [Validation(Required=false)]
            public long? ResponseId { get; set; }

            /// <summary>
            /// <para>对应请求中的 communication.sessionId。</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-session-001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>本次应答的业务数据，正文位于 messages。</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public MedicalModelInferenceResponseBodyData Data { get; set; }
        public class MedicalModelInferenceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>可选业务调试信息，可为任意 JSON 值（含 null）。是否返回、返回时机和内容按实际执行结果，不保证每轮或结束事件必有；不用于判断业务完成。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("debug")]
            [Validation(Required=false)]
            public object Debug { get; set; }

            /// <summary>
            /// <para>响应的可选补充信息。使用图片等资源时可读取 inputResources 中返回的对应资源信息。</para>
            /// </summary>
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public MedicalModelInferenceResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class MedicalModelInferenceResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// <para>可选的资源信息数组，通过 contentIndex 与请求中的内容块对应。未返回资源信息时可省略。</para>
                /// </summary>
                [NameInMap("inputResources")]
                [Validation(Required=false)]
                public List<MedicalModelInferenceResponseBodyDataExtraInfoInputResources> InputResources { get; set; }
                public class MedicalModelInferenceResponseBodyDataExtraInfoInputResources : TeaModel {
                    /// <summary>
                    /// <para>原请求本轮 content 数组的索引，从 0 开始。文本块也占用索引。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("contentIndex")]
                    [Validation(Required=false)]
                    public int? ContentIndex { get; set; }

                    /// <summary>
                    /// <para>上游提供时返回资源文件名。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>report.png</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>返回的输入资源标识，存在时可用于在业务记录中引用该资源。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ws_123</para>
                    /// </summary>
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>资源类型，例如图片引用。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>image</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>返回的资源访问地址。客户端按实际返回值使用。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/report.png">https://example.com/report.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>当前响应中的消息列表。读取消息的 mimeType、status 和 content。完整正文可通过 mimeType=multi_load/iframe 且 status=complete 的消息取得。</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<MedicalModelInferenceResponseBodyDataMessages> Messages { get; set; }
            public class MedicalModelInferenceResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>消息正文，具体结构随 mimeType 变化。流式快照可能包含到当前为止的完整正文，收到新快照时更新原内容，避免重复拼接。</para>
                /// 
                /// <b>Example:</b>
                /// <para>血红蛋白用于携带氧气。解读报告时可结合报告上的参考范围。</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public object Content { get; set; }

                /// <summary>
                /// <para>可选消息附加信息，按实际返回处理。当前医疗模型不承诺返回医疗 Agent 的检索进度、资料来源或业务卡片。</para>
                /// </summary>
                [NameInMap("metaData")]
                [Validation(Required=false)]
                public MedicalModelInferenceResponseBodyDataMessagesMetaData MetaData { get; set; }
                public class MedicalModelInferenceResponseBodyDataMessagesMetaData : TeaModel {
                    /// <summary>
                    /// <para>可选的消息附加标题，存在时按实际值使用。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>问题分析中</para>
                    /// </summary>
                    [NameInMap("barTitle")]
                    [Validation(Required=false)]
                    public string BarTitle { get; set; }

                    /// <summary>
                    /// <para>可选元数据内容，按实际返回类型解释。当前医疗模型不保证返回进度模块。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;body&quot;:&quot;正在分析用户的问题。&quot;,&quot;status&quot;:&quot;processing&quot;}</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public object Content { get; set; }

                    /// <summary>
                    /// <para>为兼容已有响应形状保留的可选列表，可为空或省略；当前医疗模型不保证生成 Agent 业务卡片。</para>
                    /// </summary>
                    [NameInMap("multiLoad")]
                    [Validation(Required=false)]
                    public List<MedicalModelInferenceResponseBodyDataMessagesMetaDataMultiLoad> MultiLoad { get; set; }
                    public class MedicalModelInferenceResponseBodyDataMessagesMetaDataMultiLoad : TeaModel {
                        /// <summary>
                        /// <para>可选 JSON 内容，结构随实际附加项类型变化，不保证存在固定业务卡片。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;list&quot;:[{&quot;image_url&quot;:&quot;<a href="https://example.com/image.jpg%22,%22image_width%22:%22800%22,%22image_height%22:%22600%22%7D%5D%7D">https://example.com/image.jpg&quot;,&quot;image_width&quot;:&quot;800&quot;,&quot;image_height&quot;:&quot;600&quot;}]}</a></para>
                        /// </summary>
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public object Content { get; set; }

                        /// <summary>
                        /// <para>可选的附加项关联标识，存在时按实际值解释。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>image_waterfall_1</para>
                        /// </summary>
                        [NameInMap("sourceSeq")]
                        [Validation(Required=false)]
                        public string SourceSeq { get; set; }

                        /// <summary>
                        /// <para>可选的附加项类型，遇到未识别类型可忽略该附加项。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>image_waterfall</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>可选的消息关联标识，存在时按实际值使用；本模型接口不保证返回。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bar_thinking_1</para>
                    /// </summary>
                    [NameInMap("sourceSeq")]
                    [Validation(Required=false)]
                    public string SourceSeq { get; set; }

                    /// <summary>
                    /// <para>可选元数据类型，存在时按实际类型解释；不据此推断模型提供 Agent 过程能力。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bar_thinking</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>该消息的内容类型，用于选择解析和展示方式。multi_load/iframe 表示正文；遇到应用不支持的类型，可跳过该消息。</para>
                /// 
                /// <b>Example:</b>
                /// <para>multi_load/iframe</para>
                /// </summary>
                [NameInMap("mimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <para>当前消息的处理状态。complete 表示这条消息已完成；流式请求是否结束以 SSE 结束事件为准。</para>
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
        /// <para>可选的结构化错误信息。返回时读取 code、message 和 requestId。</para>
        /// </summary>
        [NameInMap("error")]
        [Validation(Required=false)]
        public MedicalModelInferenceResponseBodyError Error { get; set; }
        public class MedicalModelInferenceResponseBodyError : TeaModel {
            /// <summary>
            /// <para>业务错误码，客户端可根据此字段判断错误类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>INVALID_REQUEST</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public object Code { get; set; }

            /// <summary>
            /// <para>错误原因的文字说明，便于排查后调整请求。</para>
            /// 
            /// <b>Example:</b>
            /// <para>请求参数无效</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>失败请求的业务请求 ID，联系支持时可一并提供。</para>
            /// 
            /// <b>Example:</b>
            /// <para>med-req-001</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>业务状态码。0 表示业务成功，非 0 时结合 errorMsg 或 error 查看原因。流式还应处理 event:error。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public object ErrorCode { get; set; }

        /// <summary>
        /// <para>业务状态的文字说明。失败时用于辅助排查，程序分支应依据状态码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>可选的业务请求 ID。联系支持时可同时提供响应头 x-acs-request-id 中的阿里云请求 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>med-req-001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
