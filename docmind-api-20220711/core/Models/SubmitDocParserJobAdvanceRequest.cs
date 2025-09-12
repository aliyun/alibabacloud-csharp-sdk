// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitDocParserJobAdvanceRequest : TeaModel {
        [NameInMap("CustomOssConfig")]
        [Validation(Required=false)]
        public SubmitDocParserJobAdvanceRequestCustomOssConfig CustomOssConfig { get; set; }
        public class SubmitDocParserJobAdvanceRequestCustomOssConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AccessId</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AccessKeySecret</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>StsToken</para>
            /// </summary>
            [NameInMap("StsToken")]
            [Validation(Required=false)]
            public string StsToken { get; set; }

        }

        [NameInMap("EnhancementMode")]
        [Validation(Required=false)]
        public string EnhancementMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>docStructure.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pdf</para>
        /// </summary>
        [NameInMap("FileNameExtension")]
        [Validation(Required=false)]
        public string FileNameExtension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://gw.alipayobjects.com/os/basement_prod/598b9edf-5287-4065-9e36-464305c60698.pdf">https://gw.alipayobjects.com/os/basement_prod/598b9edf-5287-4065-9e36-464305c60698.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        [NameInMap("FormulaEnhancement")]
        [Validation(Required=false)]
        public bool? FormulaEnhancement { get; set; }

        [NameInMap("LLMParam")]
        [Validation(Required=false)]
        public SubmitDocParserJobAdvanceRequestLLMParam LLMParam { get; set; }
        public class SubmitDocParserJobAdvanceRequestLLMParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-vl-ocr-latest</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Read all the text from the image.</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

        }

        [NameInMap("LlmEnhancement")]
        [Validation(Required=false)]
        public bool? LlmEnhancement { get; set; }

        [NameInMap("MultimediaParameters")]
        [Validation(Required=false)]
        public SubmitDocParserJobAdvanceRequestMultimediaParameters MultimediaParameters { get; set; }
        public class SubmitDocParserJobAdvanceRequestMultimediaParameters : TeaModel {
            [NameInMap("EnableSynopsisParse")]
            [Validation(Required=false)]
            public bool? EnableSynopsisParse { get; set; }

            [NameInMap("VlParsePrompt")]
            [Validation(Required=false)]
            public string VlParsePrompt { get; set; }

        }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        [NameInMap("OutputHtmlTable")]
        [Validation(Required=false)]
        public bool? OutputHtmlTable { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public string PageIndex { get; set; }

    }

}
