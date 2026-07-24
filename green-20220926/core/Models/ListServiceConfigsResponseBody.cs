// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListServiceConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListServiceConfigsResponseBodyData> Data { get; set; }
        public class ListServiceConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The classification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guard-scene</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>The primary service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nickname_detection</para>
            /// </summary>
            [NameInMap("CopyFrom")]
            [Validation(Required=false)]
            public string CopyFrom { get; set; }

            /// <summary>
            /// <para>The service configuration.</para>
            /// </summary>
            [NameInMap("CustomServiceConf")]
            [Validation(Required=false)]
            public ListServiceConfigsResponseBodyDataCustomServiceConf CustomServiceConf { get; set; }
            public class ListServiceConfigsResponseBodyDataCustomServiceConf : TeaModel {
                /// <summary>
                /// <para>The audio service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>audio_media_detection</para>
                /// </summary>
                [NameInMap("AudioService")]
                [Validation(Required=false)]
                public string AudioService { get; set; }

                /// <summary>
                /// <para>The image service.</para>
                /// </summary>
                [NameInMap("ImageService")]
                [Validation(Required=false)]
                public List<string> ImageService { get; set; }

                /// <summary>
                /// <para>The ignored keyword library.</para>
                /// </summary>
                [NameInMap("KeywordFilterLibs")]
                [Validation(Required=false)]
                public List<string> KeywordFilterLibs { get; set; }

                /// <summary>
                /// <para>The hit keyword library.</para>
                /// </summary>
                [NameInMap("KeywordHitLibs")]
                [Validation(Required=false)]
                public List<string> KeywordHitLibs { get; set; }

                /// <summary>
                /// <para>The service rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListServiceConfigsResponseBodyDataCustomServiceConfRules> Rules { get; set; }
                public class ListServiceConfigsResponseBodyDataCustomServiceConfRules : TeaModel {
                    /// <summary>
                    /// <para>The image moderation rule.</para>
                    /// </summary>
                    [NameInMap("ImageScanRule")]
                    [Validation(Required=false)]
                    public ListServiceConfigsResponseBodyDataCustomServiceConfRulesImageScanRule ImageScanRule { get; set; }
                    public class ListServiceConfigsResponseBodyDataCustomServiceConfRulesImageScanRule : TeaModel {
                        /// <summary>
                        /// <para>The image service.</para>
                        /// </summary>
                        [NameInMap("Services")]
                        [Validation(Required=false)]
                        public List<string> Services { get; set; }

                    }

                    /// <summary>
                    /// <para>The ordinal number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>The text moderation rule.</para>
                    /// </summary>
                    [NameInMap("TextScanRule")]
                    [Validation(Required=false)]
                    public ListServiceConfigsResponseBodyDataCustomServiceConfRulesTextScanRule TextScanRule { get; set; }
                    public class ListServiceConfigsResponseBodyDataCustomServiceConfRulesTextScanRule : TeaModel {
                        /// <summary>
                        /// <para>The text services.</para>
                        /// </summary>
                        [NameInMap("Services")]
                        [Validation(Required=false)]
                        public List<string> Services { get; set; }

                    }

                }

                /// <summary>
                /// <para>The hit similar text library.</para>
                /// </summary>
                [NameInMap("SimilarTextHitLibs")]
                [Validation(Required=false)]
                public List<string> SimilarTextHitLibs { get; set; }

            }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-11 15:40:04</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The options.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public Dictionary<string, object> Option { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The scene type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>recommended_scene: recommended scenario.</para>
            /// </description></item>
            /// <item><description><para>all_scene: all scenarios.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all_scene</para>
            /// </summary>
            [NameInMap("SceneType")]
            [Validation(Required=false)]
            public string SceneType { get; set; }

            /// <summary>
            /// <para>The service code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nickname_detection</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <para>The service description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务描述</para>
            /// </summary>
            [NameInMap("ServiceDesc")]
            [Validation(Required=false)]
            public string ServiceDesc { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务名称</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plus</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>UID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1674*****0071291</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>The usage status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("UseStatus")]
            [Validation(Required=false)]
            public string UseStatus { get; set; }

        }

        /// <summary>
        /// <para>The description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID assigned by the backend, which uniquely identifies the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
