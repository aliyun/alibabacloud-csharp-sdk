// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TargetSubtitle : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable subtitle generation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you call the GenerateVideoPlaylist operation and subtitles are required, you must set this parameter to false.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableSubtitle")]
        [Validation(Required=false)]
        public bool? DisableSubtitle { get; set; }

        /// <summary>
        /// <para>The subtitle extraction settings.</para>
        /// <remarks>
        /// <para> The GenerateVideoPlaylist operation does not support this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ExtractSubtitle")]
        [Validation(Required=false)]
        public TargetSubtitleExtractSubtitle ExtractSubtitle { get; set; }
        public class TargetSubtitleExtractSubtitle : TeaModel {
            /// <summary>
            /// <para>The format of the extracted subtitle file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ass</description></item>
            /// <item><description>srt</description></item>
            /// <item><description>webvtt</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>webvtt</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The prefix of the OSS URI where the extracted subtitles are stored. The OSS URI is in the oss://bucket/object format, where bucket specifies the name of the OSS bucket that is in the same region as the current project and object specifies the full file path that includes the file name extension.</para>
            /// <list type="bullet">
            /// <item><description>Example: If the prefix is oss://examplebucket/outputSubtitle, an output subtitle file has a URI in the format of oss://examplebucket/outputSubitile_${index}.${ext}. In the URI format, ${ext} is the file name extension of the output subtitle file, and ${index} is the same 0-based index number as that of the corresponding source subtitle stream file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/extractsubtitle</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The index numbers of subtitle streams that need to be processed. If you set this parameter to null (default) or a value greater than 100, all subtitle streams are processed.</para>
        /// <list type="bullet">
        /// <item><description>For example, you can set the parameter to <c>[0,1]</c> to process subtitle streams with index numbers 0 and 1, <c>[1]</c> to process only the subtitle stream with the index number 1, and <c>[101]</c> to process all subtitle streams.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify an index number but no subtitle stream with the index number is found, the index number is ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public List<int?> Stream { get; set; }

    }

}
