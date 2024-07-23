// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveTranscodeTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public GetLiveTranscodeTemplateResponseBodyTemplateContent TemplateContent { get; set; }
        public class GetLiveTranscodeTemplateResponseBodyTemplateContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>customized</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-25T06:15:14Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfig TemplateConfig { get; set; }
            public class GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfig : TeaModel {
                [NameInMap("AudioParams")]
                [Validation(Required=false)]
                public GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfigAudioParams AudioParams { get; set; }
                public class GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfigAudioParams : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public string Channels { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AAC</para>
                    /// </summary>
                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("Samplerate")]
                    [Validation(Required=false)]
                    public string Samplerate { get; set; }

                }

                [NameInMap("VideoParams")]
                [Validation(Required=false)]
                public GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfigVideoParams VideoParams { get; set; }
                public class GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfigVideoParams : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2500</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>H.264</para>
                    /// </summary>
                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Gop")]
                    [Validation(Required=false)]
                    public string Gop { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>720</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1280</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bcfa57950bc649b2abfb476ecd36ea4f</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
