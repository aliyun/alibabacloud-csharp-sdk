// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmExtractTaskRequest : TeaModel {
        /// <summary>
        /// <para>The CSV watermark control parameter. You must keep the value of this parameter consistent for watermark embedding and watermark extraction. Otherwise, the extraction fails.</para>
        /// </summary>
        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public CreateWmExtractTaskRequestCsvControl CsvControl { get; set; }
        public class CreateWmExtractTaskRequestCsvControl : TeaModel {
            /// <summary>
            /// <para>The timestamp watermark parameter that specifies how much information a single timestamp holds. You must keep the value of this parameter consistent for watermark embedding and watermark extraction. Otherwise, the extraction fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EmbedBitsNumberInEachTime")]
            [Validation(Required=false)]
            public long? EmbedBitsNumberInEachTime { get; set; }

            /// <summary>
            /// <para>The lossy embedding control parameter that specifies columns to be modified You must keep the value of this parameter consistent for watermark embedding and watermark extraction. Otherwise, the extraction fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EmbedColumn")]
            [Validation(Required=false)]
            public long? EmbedColumn { get; set; }

            /// <summary>
            /// <para>The lossy embedding control parameter that specifies the modification precision. You must keep the value of this parameter consistent for watermark embedding and watermark extraction. Otherwise, the extraction fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EmbedPrecision")]
            [Validation(Required=false)]
            public long? EmbedPrecision { get; set; }

            /// <summary>
            /// <para>The timestamp watermark parameter that specifies the embedding position of the timestamp watermarks. You must keep the value of this parameter consistent for watermark embedding and watermark extraction. Otherwise, the extraction fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Min</para>
            /// </summary>
            [NameInMap("EmbedTimePosition")]
            [Validation(Required=false)]
            public string EmbedTimePosition { get; set; }

            /// <summary>
            /// <para>The CSV watermark embedding method. You must keep the value of this parameter consistent for watermark embedding and watermark extraction. Otherwise, the extraction fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lossless_row_shift_embed</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The timestamp watermark parameter that specifies the timestamp format. You must keep the value of this parameter consistent for watermark embedding and watermark extraction. Otherwise, the extraction fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Year-Mon-Day Hour:Min:Sec.MilSec</para>
            /// </summary>
            [NameInMap("TimeFormat")]
            [Validation(Required=false)]
            public string TimeFormat { get; set; }

        }

        /// <summary>
        /// <para>The document watermark parameter that specifies whether the file to be extracted is a screenshot of a document with a background watermark added. The system determines whether to use the extraction logic for document background watermarks based on whether the file to be extracted is an image file. By default, you do not need to configure this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DocumentIsCapture")]
        [Validation(Required=false)]
        public bool? DocumentIsCapture { get; set; }

        /// <summary>
        /// <para>The URL used to download the file to be extracted. The URL must be accessible over the Internet.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/test-****.pdf">https://example.com/test-****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The name of the file to be extracted. The system needs to check the file type based on the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>Image extraction parameters</para>
        /// </summary>
        [NameInMap("ImageExtractParamsOpenApi")]
        [Validation(Required=false)]
        public CreateWmExtractTaskRequestImageExtractParamsOpenApi ImageExtractParamsOpenApi { get; set; }
        public class CreateWmExtractTaskRequestImageExtractParamsOpenApi : TeaModel {
            /// <summary>
            /// <para>Enhanced visible watermark logo in base64 format. Used to extract the enhanced visible watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iVBORw0KGgoAAAANSUhEUgAAAGQAAAAWCAYAAAA2CDmeAAAACXBIWXMAAAsTAAALEwEAmpwYAAAE7mlUWHRYTUw6Y29tLmFkb2JlLnhtcAAAAAAAPD94cGFja2V0IGJlZ2luPSLvu78iIGlkPSJXNU0wTXBDZWhpSHpyZVN6TlRjemtjOWQiPz4gPHg6eG1wbWV0YSB4bWxuczp4PSJhZG9iZTpuczptZXRhLyIgeDp4bXB0az0iQWRvYmUgWE1QIENvcmUgOS4wLWMwMDAgNzkuMTcxYzI3ZiwgMjAyMi8wOC8xNi0xODowMjo0MyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOnBob3Rvc2hvcD0iaHR0cDovL25zLmFkb2JlLmNvbS9waG90b3Nob3AvMS4wLyIgeG1sbnM6eG1wTU09Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9tbS8iIHhtbG5zOnN0RXZ0PSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvc1R5cGUvUmVzb3VyY2VFdmVudCMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIDI0LjAgKFdpbmRvd3MpIiB4bXA6Q3JlYXRlRGF0ZT0iMjAyNS0wNS0yN1QyMjo1MToyMyswODowMCIgeG1wOk1vZGlmeURhdGU9IjIwMjUtMDUtMjdUMjM6NDQ6MzcrMDg6MDAiIHhtcDpNZXRhZGF0YURhdGU9IjIwMjUtMDUtMjdUMjM6NDQ6MzcrMDg6MDAiIGRjOmZvcm1hdD0iaW1hZ2UvcG5nIiBwaG90b3Nob3A6Q29sb3JNb2RlPSIzIiB4bXBNTTpJbnN0YW5jZUlEPSJ4bXAuaWlkOmRiYTA3MjM3LWJmNWUtNTc0ZS04ZDhlLTAyNDlmNDFlNWE2ZCIgeG1wTU06RG9jdW1lbnRJRD0i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</para>
            /// </summary>
            [NameInMap("SrcLogoBase64")]
            [Validation(Required=false)]
            public string SrcLogoBase64 { get; set; }

        }

        /// <summary>
        /// <para>Audio watermark parameter: specifies whether the watermark was embedded by the client SDK. Default value: false. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes  </description></item>
        /// <item><description><b>false</b>: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsClientEmbed")]
        [Validation(Required=false)]
        public bool? IsClientEmbed { get; set; }

        /// <summary>
        /// <para>The watermark parameter for videos that specifies whether to use the long video watermark SDK. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        /// <summary>
        /// <para>The watermark parameter for long videos that specifies the video speed factor. The value can be a floating-point number or a string. Default value: 1. This parameter indicates the speed at which a watermark is added or the time-stretching rate for videos after a watermark is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VideoSpeed")]
        [Validation(Required=false)]
        public string VideoSpeed { get; set; }

        /// <summary>
        /// <para>The watermark information size. Default value: 32. You must keep the value of this parameter consistent for watermark embedding and watermark extraction. For example, if a 40-bit watermark is used for watermark embedding, you must set this parameter to 40 for watermark extraction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>The watermark type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PureWebappInvisible</b>: web page watermark</description></item>
        /// <item><description><b>PureAppInvisible</b>: app watermark</description></item>
        /// <item><description><b>PureScreenInvisible</b>: screen watermark</description></item>
        /// <item><description><b>PureDocument</b>: document watermark</description></item>
        /// <item><description><b>PureImage</b>: image watermark</description></item>
        /// <item><description><b>PureAudio</b>: audio watermark</description></item>
        /// <item><description><b>PureVideo</b>: video watermark</description></item>
        /// <item><description><b>AigcWebappInvisible</b>: artificial intelligence generated content (AIGC)-based webpage watermark</description></item>
        /// <item><description><b>AigcAppInvisible</b>: AIGC-based app watermark</description></item>
        /// <item><description><b>AigcScreenInvisible</b>: AIGC-based screen watermark</description></item>
        /// <item><description><b>AigcDocument</b>: AIGC-based document watermark</description></item>
        /// <item><description><b>AigcImage</b>: AIGC-based image watermark</description></item>
        /// <item><description><b>AigcAudio</b>: AIGC-based audio watermark</description></item>
        /// <item><description><b>AigcVideo</b>: AIGC-based video watermark</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PureDocument</para>
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
