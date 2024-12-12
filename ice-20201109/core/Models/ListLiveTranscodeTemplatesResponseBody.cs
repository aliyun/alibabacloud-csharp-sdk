// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveTranscodeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of transcoding templates.</para>
        /// </summary>
        [NameInMap("TemplateContentList")]
        [Validation(Required=false)]
        public List<ListLiveTranscodeTemplatesResponseBodyTemplateContentList> TemplateContentList { get; set; }
        public class ListLiveTranscodeTemplatesResponseBodyTemplateContentList : TeaModel {
            /// <summary>
            /// <para>The category of the template. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T03:26:36Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The configuration of the template.</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfig TemplateConfig { get; set; }
            public class ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfig : TeaModel {
                /// <summary>
                /// <para>The audio parameters.</para>
                /// </summary>
                [NameInMap("AudioParams")]
                [Validation(Required=false)]
                public ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfigAudioParams AudioParams { get; set; }
                public class ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfigAudioParams : TeaModel {
                    /// <summary>
                    /// <para>The audio bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The number of sound channels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public string Channels { get; set; }

                    /// <summary>
                    /// <para>The audio codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AAC</para>
                    /// </summary>
                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    /// <summary>
                    /// <para>The encoding profile.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aac_low</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// <para>The audio sampling rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("Samplerate")]
                    [Validation(Required=false)]
                    public string Samplerate { get; set; }

                }

                /// <summary>
                /// <para>The video parameters.</para>
                /// </summary>
                [NameInMap("VideoParams")]
                [Validation(Required=false)]
                public ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfigVideoParams VideoParams { get; set; }
                public class ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfigVideoParams : TeaModel {
                    /// <summary>
                    /// <para>The video bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2500</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The encoding format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>264</para>
                    /// </summary>
                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    /// <summary>
                    /// <para>The video frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <para>The group of pictures (GOP) of the output video. Unit: frame.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Gop")]
                    [Validation(Required=false)]
                    public string Gop { get; set; }

                    /// <summary>
                    /// <para>The vertical resolution of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1280</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The encoding profile.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// <para>The horizontal resolution of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>720</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9b1571b513cb44f7a1ba6ae561ff46f7</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The type of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
