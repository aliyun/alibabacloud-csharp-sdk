// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppAgentTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>30D41049-D02D-1C21-86AE-B3E5FD805C27</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeAppAgentTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeAppAgentTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("AsrConfig")]
            [Validation(Required=false)]
            public DescribeAppAgentTemplatesResponseBodyTemplatesAsrConfig AsrConfig { get; set; }
            public class DescribeAppAgentTemplatesResponseBodyTemplatesAsrConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("MaxSentenceSilence")]
                [Validation(Required=false)]
                public int? MaxSentenceSilence { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecfadace11114cf08a7f07aceee798ad</para>
                /// </summary>
                [NameInMap("VocabularyId")]
                [Validation(Required=false)]
                public string VocabularyId { get; set; }

                [NameInMap("WordWeights")]
                [Validation(Required=false)]
                public List<DescribeAppAgentTemplatesResponseBodyTemplatesAsrConfigWordWeights> WordWeights { get; set; }
                public class DescribeAppAgentTemplatesResponseBodyTemplatesAsrConfigWordWeights : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>zh</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChatMode")]
            [Validation(Required=false)]
            public int? ChatMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-09-04T06:22:15Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>你好，机器人。</para>
            /// </summary>
            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wv7N****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InterruptMode")]
            [Validation(Required=false)]
            public int? InterruptMode { get; set; }

            [NameInMap("LlmConfig")]
            [Validation(Required=false)]
            public DescribeAppAgentTemplatesResponseBodyTemplatesLlmConfig LlmConfig { get; set; }
            public class DescribeAppAgentTemplatesResponseBodyTemplatesLlmConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>qW8GpBOdHK/pv9gdUSVLvQ==</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("HistoryDepth")]
                [Validation(Required=false)]
                public int? HistoryDepth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("MaxToken")]
                [Validation(Required=false)]
                public int? MaxToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>deepseek-r1</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>llm</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Prompt")]
                [Validation(Required=false)]
                public string Prompt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("Temperature")]
                [Validation(Required=false)]
                public float? Temperature { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("TopP")]
                [Validation(Required=false)]
                public float? TopP { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://test.com">https://test.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TtsConfig")]
            [Validation(Required=false)]
            public DescribeAppAgentTemplatesResponseBodyTemplatesTtsConfig TtsConfig { get; set; }
            public class DescribeAppAgentTemplatesResponseBodyTemplatesTtsConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>N5448VFGI2mXJU8a/A03VQ==</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                [NameInMap("FilterBrackets")]
                [Validation(Required=false)]
                public List<int?> FilterBrackets { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cosyvoice-v1</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Tts</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("Pitch")]
                [Validation(Required=false)]
                public float? Pitch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public float? Rate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>longwan</para>
                /// </summary>
                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public int? Volume { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
