// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class CameraConsoleDebugStreamRequest : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public CameraConsoleDebugStreamRequestConfig Config { get; set; }
        public class CameraConsoleDebugStreamRequestConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAMERA</para>
            /// </summary>
            [NameInMap("agentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CameraStandard</para>
            /// </summary>
            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            [NameInMap("extensionConfig")]
            [Validation(Required=false)]
            public CameraConsoleDebugStreamRequestConfigExtensionConfig ExtensionConfig { get; set; }
            public class CameraConsoleDebugStreamRequestConfigExtensionConfig : TeaModel {
                [NameInMap("camera")]
                [Validation(Required=false)]
                public CameraConsoleDebugStreamRequestConfigExtensionConfigCamera Camera { get; set; }
                public class CameraConsoleDebugStreamRequestConfigExtensionConfigCamera : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.65</para>
                    /// </summary>
                    [NameInMap("headMaxHeightRatio")]
                    [Validation(Required=false)]
                    public double? HeadMaxHeightRatio { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.1</para>
                    /// </summary>
                    [NameInMap("headMinHeightRatio")]
                    [Validation(Required=false)]
                    public double? HeadMinHeightRatio { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.6</para>
                    /// </summary>
                    [NameInMap("minConfidence")]
                    [Validation(Required=false)]
                    public double? MinConfidence { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>person</para>
                    /// </summary>
                    [NameInMap("scenario")]
                    [Validation(Required=false)]
                    public string Scenario { get; set; }

                }

                [NameInMap("personScan")]
                [Validation(Required=false)]
                public CameraConsoleDebugStreamRequestConfigExtensionConfigPersonScan PersonScan { get; set; }
                public class CameraConsoleDebugStreamRequestConfigExtensionConfigPersonScan : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.65</para>
                    /// </summary>
                    [NameInMap("maxHeightRatio")]
                    [Validation(Required=false)]
                    public double? MaxHeightRatio { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.1</para>
                    /// </summary>
                    [NameInMap("minHeightRatio")]
                    [Validation(Required=false)]
                    public double? MinHeightRatio { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.6</para>
                    /// </summary>
                    [NameInMap("minScore")]
                    [Validation(Required=false)]
                    public double? MinScore { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>person_scan</para>
                /// </summary>
                [NameInMap("scenario")]
                [Validation(Required=false)]
                public string Scenario { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>你是图片识别助手，请按约定格式返回识别结果。</para>
            /// </summary>
            [NameInMap("instructions")]
            [Validation(Required=false)]
            public string Instructions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("maxIterations")]
            [Validation(Required=false)]
            public int? MaxIterations { get; set; }

            [NameInMap("model")]
            [Validation(Required=false)]
            public CameraConsoleDebugStreamRequestConfigModel Model { get; set; }
            public class CameraConsoleDebugStreamRequestConfigModel : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&lt;主模型目录ID&gt;</para>
                /// </summary>
                [NameInMap("catalogModelId")]
                [Validation(Required=false)]
                public string CatalogModelId { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public CameraConsoleDebugStreamRequestInput Input { get; set; }
        public class CameraConsoleDebugStreamRequestInput : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:[{&quot;type&quot;:&quot;image_url&quot;,&quot;image_url&quot;:{&quot;url&quot;:&quot;<a href="https://example.com/images/person.jpg%22%7D%7D%5D%7D%5D">https://example.com/images/person.jpg&quot;}}]}]</a></para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<CameraConsoleDebugStreamRequestInputMessages> Messages { get; set; }
            public class CameraConsoleDebugStreamRequestInputMessages : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public List<CameraConsoleDebugStreamRequestInputMessagesContent> Content { get; set; }
                public class CameraConsoleDebugStreamRequestInputMessagesContent : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("imageUrl")]
                    [Validation(Required=false)]
                    public CameraConsoleDebugStreamRequestInputMessagesContentImageUrl ImageUrl { get; set; }
                    public class CameraConsoleDebugStreamRequestInputMessagesContentImageUrl : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com/images/person.jpg">https://example.com/images/person.jpg</a></para>
                        /// </summary>
                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>image_url</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>meeting-room-001</para>
            /// </summary>
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("stream")]
            [Validation(Required=false)]
            public bool? Stream { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAMERA_<your_instance_id></para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public CameraConsoleDebugStreamRequestParameters Parameters { get; set; }
        public class CameraConsoleDebugStreamRequestParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.65</para>
            /// </summary>
            [NameInMap("maxHeightRatio")]
            [Validation(Required=false)]
            public double? MaxHeightRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("minHeightRatio")]
            [Validation(Required=false)]
            public double? MinHeightRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("minScore")]
            [Validation(Required=false)]
            public double? MinScore { get; set; }

        }

        /// <summary>
        /// <para>请求 ID 优先级：可信 POP 注入的 x-acs-request-id、非空 X-QI-Request-Id Header、Body.requestId。没有前两者时 Body.requestId 必填；没有可信 POP ID 时 Header 与 Body.requestId 至少提供一个。 格式同 sessionId。成功重放还须复用原 Session；已记录为失败的请求须换新 Request ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>debug-request-001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>person_scan</para>
        /// </summary>
        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>debug-session-001</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
