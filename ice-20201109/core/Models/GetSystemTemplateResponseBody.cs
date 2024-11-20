// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSystemTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The template information.</para>
        /// </summary>
        [NameInMap("SystemTemplate")]
        [Validation(Required=false)]
        public GetSystemTemplateResponseBodySystemTemplate SystemTemplate { get; set; }
        public class GetSystemTemplateResponseBodySystemTemplate : TeaModel {
            /// <summary>
            /// <para>The template state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subtype ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Subtype")]
            [Validation(Required=false)]
            public int? Subtype { get; set; }

            /// <summary>
            /// <para>The subtype name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SubtypeName")]
            [Validation(Required=false)]
            public string SubtypeName { get; set; }

            /// <summary>
            /// <para>The template parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Container&quot;:{&quot;Format&quot;:&quot;m3u8&quot;},&quot;TransConfig&quot;:{&quot;TransMode&quot;:&quot;onepass&quot;},&quot;Video&quot;:{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Maxrate&quot;:8000,&quot;Preset&quot;:&quot;medium&quot;,&quot;PixFmt&quot;:&quot;yuv420p&quot;,&quot;Width&quot;:2048,&quot;Bitrate&quot;:3500},&quot;Audio&quot;:{&quot;Codec&quot;:&quot;aac&quot;,&quot;Bitrate&quot;:160,&quot;Samplerate&quot;:44100,&quot;Channels&quot;:2}}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S00000001-100060</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>M3U8-2K</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The type ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The type name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TranscodeTemplate</para>
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
