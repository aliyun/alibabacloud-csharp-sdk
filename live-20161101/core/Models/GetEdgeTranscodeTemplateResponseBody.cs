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
        /// <para>The edge transcoding template.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public GetEdgeTranscodeTemplateResponseBodyTemplate Template { get; set; }
        public class GetEdgeTranscodeTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>The bitrate configuration. Valid values: a fixed bitrate value or ws (follow source).</para>
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
            /// <item><description>H.264.</description></item>
            /// <item><description>H.265.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>H.264</para>
            /// </summary>
            [NameInMap("Codec")]
            [Validation(Required=false)]
            public string Codec { get; set; }

            /// <summary>
            /// <para>The time when the template was created. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-25T02:48:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The frame rate configuration. Valid values: a fixed frame rate value or ws (follow source).</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// <para>The keyframe configuration. Valid values: frame-based, second-based, or ws (follow source).</para>
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
            /// <para>The resolution configuration. Valid values: a fixed resolution value or ws (follow source).</para>
            /// <remarks>
            /// <para>When a fixed resolution is used and width or height is set to -1 or -2, the width or height is adaptive.</para>
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
            /// <para>The edge transcoding type.</para>
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
