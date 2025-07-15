// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetEdgeTranscodeTemplateResponseBody : TeaModel {
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
        /// <para>The details of the edge transcoding template.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public GetEdgeTranscodeTemplateResponseBodyTemplate Template { get; set; }
        public class GetEdgeTranscodeTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>The bitrate. If a numeric value is returned, a fixed bitrate is configured for the output stream. If ws is returned, the output stream maintains the same bitrate as the input stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// <para>The video encoding format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>H.264</description></item>
            /// <item><description>H.265</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>H.264</para>
            /// </summary>
            [NameInMap("Codec")]
            [Validation(Required=false)]
            public string Codec { get; set; }

            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-25T02:48:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The frame rate. If a numeric value is returned, a fixed frame rate is configured for the output stream. If ws is returned, the output stream maintains the same frame rate as the input stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// <para>The group of pictures (GOP) size. The GOP size can be defined by the number of frames or the time interval between I-frames. If ws is returned, the output stream maintains the same GOP size as the input stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2s</para>
            /// </summary>
            [NameInMap("Gop")]
            [Validation(Required=false)]
            public string Gop { get; set; }

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
            /// <para>The resolution. If width and height values are returned, a fixed resolution is configured for the output stream. If ws is returned, the output stream maintains the same resolution as the input stream.</para>
            /// <remarks>
            /// <para> If the width value is -1, the width of the output stream is adapted to the height. If the height value is -2, the height of the output stream is adapted to the width.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1920*1080</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9b1571b513cb44f7a1ba6ae561ff****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The type of edge transcoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>common</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
